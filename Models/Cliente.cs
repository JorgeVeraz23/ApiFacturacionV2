using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = null;
        public string Apellido { get; set; } = null;
        public string Direccion { get; set; } = null;
        public string Telefono { get; set; } = null;
        public string CorreoElectronico { get; set; }
        public string Cedula { get; set; } = string.Empty;


    }
}
