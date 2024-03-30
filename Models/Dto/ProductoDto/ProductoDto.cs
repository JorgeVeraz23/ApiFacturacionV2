using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.ProductoDto
{
    public class ProductoDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int FamiliaProductoId { get; set; }
        public string Nombre { get; set; }
        public Boolean GravaIVA { get; set; }
        public string Descripción { get; set; } = string.Empty;
        public string CodigoDeBarras { get; set; } = string.Empty;
        public int StockDisponible { get; set; }
        public decimal Precio { get; set; }
    }
}
