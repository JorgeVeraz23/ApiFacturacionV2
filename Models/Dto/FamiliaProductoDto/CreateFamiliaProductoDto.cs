using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.FamiliaProductoDto
{
    public class CreateFamiliaProductoDto
    {
        [Required]
        public int FamiliaProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
