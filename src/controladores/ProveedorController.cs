using controladores.Interfaces;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class ProveedorController : IProveeedorProvider
    {
        public Task<Proveedores> Actualizar(Proveedores proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> CambiarEstatus(int idProveedor, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> CrearNuevo(Proveedores proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<Proveedores> ObtenerPorId(int idProveedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Proveedores>> ObtenerPorNombreMatch(string nombreProveedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Proveedores>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<(bool exists, Proveedores proveedor)> VerificarNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
