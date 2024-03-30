using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalVenta { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalIva { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime FechaDeVenta { get; set; } = DateTime.MinValue;
        [Column(TypeName = "datetime")]
        public DateTime FechaDeModificacion { get; set; }

        // Relación de uno a muchos con DetallesVenta
        
        public ICollection<DetallesVenta> DetallesVenta { get; } = new List<DetallesVenta>(); // Collection navigation containing dependents

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual Empleado Empleado { get; set; }

    }
}
