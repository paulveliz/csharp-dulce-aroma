using modelos;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IEntradaProvider
    {
        Task<FullEntrada> ObtenerPorId(int @idEntrada);
        Task<IEnumerable<FullEntrada>> ObtenerPorFechas(DateTime from, DateTime to);
        Task<IEnumerable<FullEntrada>> ObtenerPorEmpleado(DateTime from, DateTime to);
        Task<IEnumerable<FullEntrada>> ObtenerConBaja(DateTime from, DateTime to);
        Task<(bool IsSucess, FullEntrada venta)> CrearNueva(FullEntrada entrada);
        Task<(bool IsSucess, FullEntrada venta)> CambiarEstatus(int idVenta, int nuevoEstatus);
        Task<(bool IsSucess, FullEntrada venta)> Devolver(int idVenta, int nuevoEstatus);
    }
}
