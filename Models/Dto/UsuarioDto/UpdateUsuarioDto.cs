using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.Dto.UsuarioDto
{
    public class UpdateUsuarioDto
    {
        [Required]
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        [Required]
        public int RolId { get; set; }
    }
}
