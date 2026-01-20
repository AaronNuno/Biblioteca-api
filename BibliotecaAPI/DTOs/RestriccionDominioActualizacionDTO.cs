using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.DTOs
{
    public class RestriccionDominioActualizacionDTO
    {

        [Required]
        public required string Domino { get; set; }
    }
}
