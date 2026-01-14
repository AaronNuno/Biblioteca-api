using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAPI.DTOs
{
    public class LimitarPeticionesDTO
    {
        public const string Seccion = "limitarPeticiones";
        [Required]
        public int PeticionesPorDiaGratuito {  get; set; }
    }
}
