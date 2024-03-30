using WebApplication9.Models;

namespace WebApplication9.Repository.IRepository
{
    public interface IVentasRepositorio : IRepository<Venta>
    {
        Task<Venta> Actualizar(Venta venta);
    }
}
