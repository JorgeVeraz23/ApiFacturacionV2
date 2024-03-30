using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.VentaDto
{
    public class VentaDto
    {
        [Required]
        public int VentaId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int EmpleadoId { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal TotalIva { get; set; }
        public DateTime FechaDeVenta { get; set; }
        public DateTime FechaDeModificacion { get; set; }
    }
}
