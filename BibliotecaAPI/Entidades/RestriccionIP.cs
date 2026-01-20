using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.Entidades
{
    public class RestriccionIP
    {
        public int Id { get; set; }
        public int LlaveId { get; set; }

        [Required]
        public required string IP { get; set; } // IP
        public LlaveAPI? Llave { get; set; }
    }
}
