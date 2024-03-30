using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9
{
    public class PuntoDeVentaDtoContext : DbContext
    {
        public PuntoDeVentaDtoContext(DbContextOptions<PuntoDeVentaDtoContext> options) : base(options){
                    
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetallesVenta> DetallesVentas { get; set; }
        public DbSet<Empleado> Empleado {  get; set; }
        public DbSet<FamiliaProducto> FamiliaProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    }
}
