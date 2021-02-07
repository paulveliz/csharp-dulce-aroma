using modelos.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IProveeedorProvider
    {
        Task<Proveedores> ObtenerPorId(int idProveedor);
        Task<IEnumerable<Proveedores>> ObtenerTodos();
        Task<IEnumerable<Proveedores>> ObtenerPorNombreMatch(string nombreProveedor);
        Task<(bool exists, Proveedores proveedor)> VerificarNombre(string nombre);
        Task<Proveedores> CrearNuevo(Proveedores proveedor);
        Task<Proveedores> Actualizar(Proveedores proveedor);
        Task<Proveedores> CambiarEstatus(int idProveedor, int nuevoEstatus);
    }
}
