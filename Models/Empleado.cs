using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoSangre { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
