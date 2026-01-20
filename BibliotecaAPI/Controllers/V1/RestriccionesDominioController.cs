using BibliotecaAPI.Datos;
using BibliotecaAPI.DTOs;
using BibliotecaAPI.Entidades;
using BibliotecaAPI.Servicios;
using BibliotecaAPI.Utilidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Controllers.V1
{
    [ApiController]
    [Route("api/v1/restriccionesdominio")]
    [Authorize]
    [DeshabilitarLimitarPeticiones]
    public class RestriccionesDominioController : ControllerBase
    {
        private readonly AplicationDBContext context;
        private readonly IServiciosUsuarios serviciosUsuarios;

        public RestriccionesDominioController(AplicationDBContext context, IServiciosUsuarios serviciosUsuarios)
        {
            this.context = context;
            this.serviciosUsuarios = serviciosUsuarios;
        }

        [HttpPost]
        public async Task<ActionResult> Post(RestriccionesDominioCreacionDTO restriccionesDominioCreacionDTO)
        {
            var llaveBD = await context.LlavesAPI.FirstOrDefaultAsync(x=>x.Id == restriccionesDominioCreacionDTO.LlaveId);

            if (llaveBD is null)
            {
                return NotFound();
            }

            var usuarioId = serviciosUsuarios.ObetenerUsuarioId();

            if (llaveBD.UsuarioId != usuarioId)
            {
                return Forbid();
            }

            var restriccionDominio = new RestriccionDominio
            {
                LlaveId = restriccionesDominioCreacionDTO.LlaveId,
                Dominio = restriccionesDominioCreacionDTO.Domino
            };

            context.Add(restriccionDominio);
            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id ,RestriccionDominioActualizacionDTO restriccionDominioActualizacionDTO)
        {
            var restriccionDB = await context.RestriccionDominio.Include(x=>x.Llave).FirstOrDefaultAsync(x=>x.Id == id);

            if (restriccionDB is null)
            {
                return NotFound();
            }

            var usuarioId = serviciosUsuarios.ObetenerUsuarioId();

            if (restriccionDB.Llave!.UsuarioId != usuarioId)
            {
                return Forbid();
            }

            restriccionDB.Dominio = restriccionDominioActualizacionDTO.Domino;

            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var restriccionDB = await context.RestriccionDominio.Include(x => x.Llave)
                                             .FirstOrDefaultAsync(x => x.Id == id);

            if (restriccionDB is null)
            {
                return NotFound();
            }

            var usuarioId = serviciosUsuarios.ObetenerUsuarioId();

            if (restriccionDB.Llave!.UsuarioId != usuarioId)
            {
                return Forbid();
            }


            context.Remove(restriccionDB);
            await context.SaveChangesAsync();
            return NoContent();

        }
    }
}
