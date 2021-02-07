using controladores.Interfaces;
using modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class EntradaController : IEntradaProvider
    {
        public Task<(bool IsSucess, FullEntrada venta)> CambiarEstatus(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSucess, FullEntrada venta)> CrearNueva(FullEntrada entrada)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSucess, FullEntrada venta)> Devolver(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FullEntrada>> ObtenerConBaja(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FullEntrada>> ObtenerPorEmpleado(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FullEntrada>> ObtenerPorFechas(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<FullEntrada> ObtenerPorId(int idEntrada)
        {
            throw new NotImplementedException();
        }
    }
}
