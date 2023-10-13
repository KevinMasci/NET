using System.ComponentModel.DataAnnotations;

namespace APIRestNetCore.Models
{
    public class Alumno
    {
        [Key]
        public String DNI { get; set; }
        public String ApellidoNombre { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set;}
        public decimal NotaPromedio { get; set; }
    }
}
