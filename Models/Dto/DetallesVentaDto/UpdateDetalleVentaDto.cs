using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.DetallesVentaDto
{
    public class UpdateDetalleVentaDto
    {
        [Required]
        public int DetallesVentaId { get; set; }
        public int Cantidad { get; set; }
        [Required]
        public int VentaId { get; set; }
        [Required]
        public int ProductoId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
       
    }
}
