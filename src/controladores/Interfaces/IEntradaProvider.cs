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
        Task<Entradas> ObtenerPorId(int @idEntrada);
        Task<IEnumerable<Entradas>> ObtenerPorFechas(DateTime from, DateTime to);
        Task<IEnumerable<Entradas>> ObtenerTodas();
        Task<IEnumerable<Entradas>> ObtenerPorEmpleado(DateTime from, DateTime to, int idEmpleado);
        Task<IEnumerable<Entradas>> ObtenerConBaja(DateTime from, DateTime to);
        Task<(bool IsSucess, Entradas entrada)> CrearNueva(Entradas entrada, IEnumerable<Detalle_Entradas> detalle);
        Task<(bool IsSucess, Entradas entrada)> CambiarEstatus(int idVenta, int nuevoEstatus);
        Task<(bool IsSucess, Entradas entrada)> Devolver(int idVenta, int nuevoEstatus);
    }
}
