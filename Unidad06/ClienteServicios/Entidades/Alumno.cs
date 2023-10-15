using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Alumno
    {
        [Key]
        public String DNI { get; set; }
        public String ApellidoNombre { get; set; }
        public string Emial { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal NotaPromedio { get; set; }
    }
}