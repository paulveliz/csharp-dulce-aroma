using controladores.Interfaces;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class ProductoController : IProductoProvider
    {
        public Task<Productos> Actualizar(Productos producto)
        {
            throw new NotImplementedException();
        }

        public Task<Productos> CambiarEstatus(int idProducto, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<Productos> CrearNuevo(Productos producto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productos>> ObtenerAgotados()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productos>> ObtenerExistentes()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productos>> ObtenerPorAgotarse()
        {
            throw new NotImplementedException();
        }

        public Task<Productos> ObtenerPorCodigo(string codigoProducto)
        {
            throw new NotImplementedException();
        }

        public Task<Productos> ObtenerPorId(int idProducto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productos>> ObtenerPorNombreMatch(string nombreProducto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Productos>> ObtenerProductos(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<(bool exists, Productos producto)> VerificarCodigo(string codigoProducto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool exists, Productos producto)> VerificarNombre(string nombreProducto)
        {
            throw new NotImplementedException();
        }
    }
}
