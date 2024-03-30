using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.ClienteDto
{
    public class ClienteDto
    {
        [Required]
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Direccion { get; set; } = null;
        public string Telefono { get; set; } = null;
        public string CorreoElectronico { get; set; }
        public string Cedula { get; set; }
    }
}
