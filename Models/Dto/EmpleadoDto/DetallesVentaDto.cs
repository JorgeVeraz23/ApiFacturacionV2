using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.EmpleadoDto
{
    public class DetallesVentaDto
    {
        [Required]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoSangre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
