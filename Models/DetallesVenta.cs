using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication9.Models
{
    public class DetallesVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetallesVentaId { get; set; }
       
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal IVA { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Producto Producto { get; set; }
       


    }
}
