using WebApplication9.Repository.IRepository;
using WebApplication9.Models;
namespace WebApplication9.Repository
{
    public class VentaRepositorio : Repositorio<Venta>, IVentasRepositorio
    {
        private readonly PuntoDeVentaDtoContext _db;
        public VentaRepositorio(PuntoDeVentaDtoContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Venta> Actualizar(Venta entidad)
        {
            entidad.FechaDeModificacion = DateTime.Now;
            _db.Ventas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
