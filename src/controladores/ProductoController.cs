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
    public class ProductoController : IProductoProvider
    {
        public async Task<Productos> Actualizar(Productos producto)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Productos
                                    .Include(p => p.cProductoEstatus)
                                    .Include(p => p.Proveedores)
                                    .FirstOrDefaultAsync(p => p.id == producto.id);
                result.idEstatus = producto.idEstatus;
                result.idProveedor = producto.idProveedor;
                result.nombre = producto.nombre;
                result.precio = producto.precio;
                result.costo = producto.costo;
                result.codigo = producto.codigo;
                await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<Productos> CambiarEstatus(int idProducto, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Productos
                                    .Include(p => p.cProductoEstatus)
                                    .Include(p => p.Proveedores)
                                    .FirstOrDefaultAsync(p => p.id == idProducto);
                result.idEstatus = nuevoEstatus;
                await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<Productos> CrearNuevo(Productos producto)
        {
            using (var db = new dulce_aroma_db())
            {
                var newProduct = db.Productos.Add(producto);
                await db.SaveChangesAsync();
                return newProduct;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerAgotados()
        {
            using (var db = new dulce_aroma_db())
            {
                var agotados = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p =>
                                            p.idEstatus != 2 &&
                                            p.existencias == 0)
                                        .ToListAsync();
                return agotados;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerExistentes()
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p =>
                                            p.idEstatus != 2 &&
                                            p.existencias > 0)
                                        .ToListAsync();
                return res;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerPorAgotarse()
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p =>
                                            p.idEstatus != 2 &&
                                            p.existencias <= 3)
                                        .ToListAsync();
                return res;
            }
        }

        public async Task<Productos> ObtenerPorCodigo(string codigoProducto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.codigo == codigoProducto && p.idEstatus != 2);
                return res;
            }
        }

        public async Task<Productos> ObtenerPorId(int idProducto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.id == idProducto);
                return res;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerPorNombreMatch(string nombreProducto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p => p.nombre.Contains(nombreProducto) && p.idEstatus != 2)
                                        .ToListAsync();
                return res;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerProductos(DateTime from, DateTime to)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p => p.idEstatus != 2)
                                        .ToListAsync();
                return res;
            }
        }

        public async Task<IEnumerable<Productos>> ObtenerTodos()
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .Where(p => p.idEstatus != 2)
                                        .Take(1000)
                                        .ToListAsync();
                return res;
            }
        }

        public async Task<(bool exists, Productos producto)> VerificarCodigo(string codigoProducto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.codigo == codigoProducto && p.idEstatus != 2);
                return res != null ? (true, res) : (false, res);
            }
        }

        public async Task<(bool exists, Productos producto)> VerificarNombre(string nombreProducto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.nombre == nombreProducto && p.idEstatus != 2);
                return res != null ? (true, res) : (false, res);
            }
        }

        public async Task<(bool actualizado, Productos producto)> AgregarExistencias(int idProducto, int nuevaCantidad, decimal nuevoPrecio, decimal nuevoCosto)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.id == idProducto);
                res.existencias += nuevaCantidad;
                res.precio = nuevoPrecio;
                res.costo = nuevoCosto;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, res) : (false, null);
            }
        }
        public async Task<(bool actualizado, Productos producto)> QuitarExistencias(int idProducto, int nuevaCantidad)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Productos
                                        .Include(p => p.cProductoEstatus)
                                        .Include(p => p.Proveedores)
                                        .FirstOrDefaultAsync(p => p.id == idProducto);
                res.existencias -= nuevaCantidad;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, res) : (false, null);
            }
        }
    }
}
