using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.UsuarioDto
{
    public class UsuarioDto
    {
        [Required]
        public int UsuarioId { get; set; }  
        public string NombreUsuario { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        [Required]
        public int RolId { get; set; }
    }
}
