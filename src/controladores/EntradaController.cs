using controladores.Interfaces;
using modelos;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class EntradaController : IEntradaProvider
    {
        public async Task<(bool IsSucess, Entradas entrada)> CambiarEstatus(int idVenta, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Entradas.FirstOrDefaultAsync(e => 
                    e.id == idVenta
                );

                result.idEstatus = nuevoEstatus;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, result) : (false, result);
            }
        }

        public async Task<(bool IsSucess, Entradas entrada)> CrearNueva(Entradas entrada, IEnumerable<Detalle_Entradas> detalle)
        {
            using (var db = new dulce_aroma_db())
            {
                // Crear nueva entrada
                var newEntrada = db.Entradas.Add(entrada);
                // Guardar cambios
                await db.SaveChangesAsync();
                var entradaActual = await db.Entradas
                    .Include(e => e.Detalle_Entradas)
                    .Include(e => e.Empleados)
                    .Include(e => e.cEntradaEstatus)
                    .Include(e => e.Proveedores)
                    .FirstOrDefaultAsync(e => e.id == newEntrada.id);
                // Guardar detalles
                ProductoController pCtrl = new ProductoController();
                foreach (var d in detalle)
                {
                    entradaActual.Detalle_Entradas.Add(d);
                    // Agregamos existencias acorde el producto del detalle en curso.
                    await pCtrl.AgregarExistencias(d.idProducto, d.cantidad, d.precio, d.costo);
                }
                // Guardar cambios
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, entradaActual) : (false, entradaActual);
            }
        }

        public Task<(bool IsSucess, Entradas entrada)> Devolver(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Entradas>> ObtenerConBaja(DateTime from, DateTime to)
        {
            using (var db = new dulce_aroma_db())
            {
                var bajas = await db.Entradas
                                .Include(e => e.Detalle_Entradas)
                                .Include(e => e.Empleados)
                                .Include(e => e.cEntradaEstatus)
                                .Include(e => e.Proveedores)
                                .Where(e =>
                                    e.idEstatus == 1 &&
                                    e.fecha >= from &&
                                    e.fecha <= to)
                                .OrderByDescending(e => e.id)
                                .ToListAsync();
                return bajas;
            }
        }

        public async Task<IEnumerable<Entradas>> ObtenerPorEmpleado(DateTime from, DateTime to, int idEmpleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var bajas = await db.Entradas
                                .Include(e => e.Detalle_Entradas)
                                .Include(e => e.Empleados)
                                .Include(e => e.cEntradaEstatus)
                                .Include(e => e.Proveedores)
                                .Where(e =>
                                    e.idEmpleado == idEmpleado &&
                                    e.fecha >= from &&
                                    e.fecha <= to)
                                .OrderByDescending(e => e.id)
                                .ToListAsync();
                return bajas;
            }
        }

        public async Task<IEnumerable<Entradas>> ObtenerPorFechas(DateTime from, DateTime to)
        {
            using (var db = new dulce_aroma_db())
            {
                var bajas = await db.Entradas
                                .Include(e => e.Detalle_Entradas)
                                .Include(e => e.Empleados)
                                .Include(e => e.cEntradaEstatus)
                                .Include(e => e.Proveedores)
                                .Where(e =>
                                    e.idEstatus == 1 &&
                                    e.fecha >= from &&
                                    e.fecha <= to)
                                .OrderByDescending(e => e.id)
                                .ToListAsync();
                return bajas;
            }
        }
        public async Task<IEnumerable<Entradas>> ObtenerTodas()
        {
            using (var db = new dulce_aroma_db())
            {
                var bajas = await db.Entradas
                                .Include(e => e.cEntradaEstatus)
                                .Include(e => e.Detalle_Entradas)
                                .Include(e => e.Proveedores)
                                .Include(e => e.Empleados)
                                .Where(e =>
                                    e.idEstatus == 1)
                                .Take(100)
                                .OrderByDescending(e => e.id)
                                .ToListAsync();
                return bajas;
            }
        }

        public async Task<Entradas> ObtenerPorId(int idEntrada)
        {
            using (var db = new dulce_aroma_db())
            {
                var entrada = await db.Entradas
                        .Include(e => e.Detalle_Entradas)
                        .Include(e => e.Empleados)
                        .Include(e => e.cEntradaEstatus)
                        .Include(e => e.Proveedores)
                        .FirstOrDefaultAsync(e => e.id == idEntrada);
                return entrada;
            }
        }
    }
}
