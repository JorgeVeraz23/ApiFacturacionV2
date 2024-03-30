using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }   
        public string CorreoElectronico { get; set; }
        public string Contraseña {  get; set; }
        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }
        
    }
}
