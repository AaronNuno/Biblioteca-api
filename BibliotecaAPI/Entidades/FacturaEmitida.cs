using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace BibliotecaAPI.Entidades
{
    [PrimaryKey ("Mes", "Año")]
    public class FacturaEmitida
    {
        public int Mes {  get; set; }
        public int Año { get; set; }
    }
}
