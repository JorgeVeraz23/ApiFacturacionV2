using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public int FamiliaProductoId { get; set; }
        public string Nombre { get; set; }
        public Boolean GravaIVA { get; set; }
        public string Descripción { get; set; }
        public string CodigoDeBarras { get; set; }
        public int StockDisponible { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Precio { get; set; }
        [ForeignKey("FamiliaProductoId")]
        public virtual FamiliaProducto FamiliaProducto { get; set;}
    }
}
