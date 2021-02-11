using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IProductoProvider
    {
        Task<Productos> ObtenerPorId(int idProducto);
        Task<Productos> ObtenerPorCodigo(string codigoProducto);
        Task<IEnumerable<Productos>> ObtenerPorNombreMatch(string nombreProducto);
        Task<IEnumerable<Productos>> ObtenerProductos(DateTime @from, DateTime @to);
        Task<IEnumerable<Productos>> ObtenerExistentes();
        Task<IEnumerable<Productos>> ObtenerTodos();
        Task<IEnumerable<Productos>> ObtenerAgotados();
        Task<IEnumerable<Productos>> ObtenerPorAgotarse();
        Task<(bool exists, Productos producto)> VerificarNombre(string nombreProducto);
        Task<(bool exists, Productos producto)> VerificarCodigo(string codigoProducto);
        Task<Productos> CrearNuevo(Productos producto);
        Task<Productos> Actualizar(Productos producto);
        Task<Productos> CambiarEstatus(int idProducto, int nuevoEstatus);
    }
}
