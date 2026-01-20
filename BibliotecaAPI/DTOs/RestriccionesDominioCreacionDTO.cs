using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.DTOs
{
    public class RestriccionesDominioCreacionDTO
    {

        public int LlaveId { get; set; }
        [Required]
        public required string Domino { get; set; }
    }
}
