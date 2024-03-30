using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.EmpleadoDto
{
    public class UpdateDetallesVentaDto
    {
        [Required]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public string EstadoCivil { get; set; } = string.Empty;
        public string TipoSangre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
    }
}
