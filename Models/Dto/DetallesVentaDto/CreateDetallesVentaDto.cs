using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication9.Models.Dto.DetallesVentaDto
{
    public class CreateDetallesVentaDto
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
