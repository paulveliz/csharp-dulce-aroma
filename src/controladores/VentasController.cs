using controladores.Interfaces;
using modelos;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    class VentasController : IVentasProvider
    {
        public Task<(bool IsSucess, FullVenta venta)> CambiarEstatus(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool IsSucess, Ventas venta)> CrearNueva(Ventas venta)
        {
            using (var db = new dulce_aroma_db())
            {
                var newVenta = db.Ventas.Add(venta);
                var affectedRows = await db.SaveChangesAsync();
                return affectedRows > 0 ? (true, newVenta) : (false, null);
            }
        }

        public Task<(bool IsSucess, FullVenta venta)> CrearNueva(FullVenta venta)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSucess, FullVenta venta)> Devolver(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FullVenta>> ObtenerDevueltas(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FullVenta>> ObtenerPorEmpleado(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ventas>> ObtenerPorFechas(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<Ventas> ObtenerPorId(int idVenta)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<FullVenta>> IVentasProvider.ObtenerPorFechas(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        Task<FullVenta> IVentasProvider.ObtenerPorId(int idVenta)
        {
            throw new NotImplementedException();
        }
    }
}
