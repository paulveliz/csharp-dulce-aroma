
using modelos;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IVentasProvider
    {
        Task<FullVenta> ObtenerPorId(int @idVenta);
        Task<IEnumerable<FullVenta>> ObtenerPorFechas(DateTime from, DateTime to);
        Task<IEnumerable<FullVenta>> ObtenerPorEmpleado(DateTime from, DateTime to);
        Task<IEnumerable<FullVenta>> ObtenerDevueltas(DateTime from, DateTime to);
        Task<(bool IsSucess, FullVenta venta)> CrearNueva(FullVenta venta);
        Task<(bool IsSucess, FullVenta venta)> CambiarEstatus(int idVenta, int nuevoEstatus);
        Task<(bool IsSucess, FullVenta venta)> Devolver(int idVenta, int nuevoEstatus);
    }
}
