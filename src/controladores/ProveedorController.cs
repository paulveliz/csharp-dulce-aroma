using controladores.Interfaces;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class ProveedorController : IProveeedorProvider
    {
        public async Task<Proveedores> Actualizar(Proveedores proveedor)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Proveedores
                                    .Include(p => p.cProveedorEstatus)
                                    .FirstOrDefaultAsync(p => p.id == proveedor.id);
                result.idEstatus = proveedor.id;
                result.nombre = proveedor.nombre;
                await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<Proveedores> CambiarEstatus(int idProveedor, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Proveedores
                                    .Include(p => p.cProveedorEstatus)
                                    .FirstOrDefaultAsync(p => p.id == idProveedor);
                result.idEstatus = nuevoEstatus;
                await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<Proveedores> CrearNuevo(Proveedores proveedor)
        {
            using (var db = new dulce_aroma_db())
            {
                var newProveedor = db.Proveedores.Add(proveedor);
                await db.SaveChangesAsync();
                return newProveedor;
            }
        }

        public async Task<Proveedores> ObtenerPorId(int idProveedor)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Proveedores
                        .Include(p => p.cProveedorEstatus)
                        .FirstOrDefaultAsync(p => p.id == idProveedor && p.idEstatus == 1);
                await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<IEnumerable<Proveedores>> ObtenerPorNombreMatch(string nombreProveedor)
        {
            using (var db = new dulce_aroma_db())
            {
                var proveedores = await db.Proveedores
                                            .Include(p => p.cProveedorEstatus)
                                            .Where(p =>
                                                p.nombre.Contains(nombreProveedor) &&
                                                p.idEstatus == 1)
                                            .OrderByDescending(p => p.id)
                                            .ToListAsync();
                return proveedores;
            }
        }

        public async Task<IEnumerable<Proveedores>> ObtenerTodos()
        {
            using (var db = new dulce_aroma_db())
            {
                var proveedores = await db.Proveedores
                                            .Include(p => p.cProveedorEstatus)
                                            .Where(p => p.idEstatus == 1)
                                            .OrderByDescending(p => p.id)
                                            .ToListAsync();
                return proveedores;
            }
        }

        public async Task<(bool exists, Proveedores proveedor)> VerificarNombre(string nombre)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Proveedores
                                            .Include(p => p.cProveedorEstatus)
                                            .FirstOrDefaultAsync(p => 
                                                p.nombre == nombre &&
                                                p.idEstatus == 1);
                return result != null ? (true, result) : (false, null);
            }
        }
    }
}
