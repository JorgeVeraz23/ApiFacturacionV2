using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.ClienteDto
{
    public class CreateClienteDto
    {
        [Required]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; }
        public string Cedula { get; set; } = string.Empty;
    }
}
