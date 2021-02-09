
using modelos;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IVentasProvider
    {
        Task<Ventas> ObtenerPorId(int @idVenta);
        Task<IEnumerable<Ventas>> ObtenerPorFechas(DateTime from, DateTime to);
        Task<IEnumerable<Ventas>> ObtenerPorEmpleado(DateTime from, DateTime to, int idEmpleado);
        Task<IEnumerable<Ventas>> ObtenerDevueltas(DateTime from, DateTime to);
        Task<(bool IsSucess, Ventas venta)> CrearNueva(Ventas venta, IEnumerable<Detalle_Ventas> detalle);
        Task<(bool IsSucess, Ventas venta)> CambiarEstatus(int idVenta, int nuevoEstatus);
        Task<(bool IsSucess, Ventas venta)> Devolver(int idVenta, int nuevoEstatus);
    }
}
