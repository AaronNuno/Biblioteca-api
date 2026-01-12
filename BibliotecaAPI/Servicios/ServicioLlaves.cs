using BibliotecaAPI.Datos;
using BibliotecaAPI.Entidades;

namespace BibliotecaAPI.Servicios
{
    public class ServicioLlaves : IServicioLlaves
    {
        private readonly AplicationDBContext context;

        public ServicioLlaves(AplicationDBContext context)
        {
            this.context = context;
        }

        public async Task<LlaveAPI> CrearLlave(string usuarioId, TipoLlave tipoLlave)
        {
            var llave = GenerarLlave();
            var llaveAPI = new LlaveAPI
            {
                Activa = true,
                Llave = llave,
                TipoLlave = tipoLlave,
                UsuarioId = usuarioId

            };

            context.Add(llaveAPI);
            await context.SaveChangesAsync();
            return llaveAPI;
        }

        public string GenerarLlave() => Guid.NewGuid().ToString().Replace("-", "");
    }
}
