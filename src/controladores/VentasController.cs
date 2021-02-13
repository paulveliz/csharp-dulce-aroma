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
    public class VentasController : IVentasProvider
    {

        public async Task<(bool IsSucess, Ventas venta)> CrearNueva(Ventas venta, IEnumerable<Detalle_Ventas> detalle)
        {
            using (var db = new dulce_aroma_db())
            {
                // Crear nueva venta.
                var newVenta = db.Ventas.Add(venta);
                // Guardar cambios
                await db.SaveChangesAsync();
                // Pedir venta ala db e ingresar los detalles.
                var result = await db.Ventas
                    .Include(v => v.Detalle_Ventas)
                    .Include(v => v.cVentaEstatus)
                    .Include(v => v.Turnos)
                    .FirstOrDefaultAsync(v => v.id == newVenta.id);
                // Ingresar detalles.  
                ProductoController pCtrl = new ProductoController();
                foreach (var d in detalle)
                {
                    result.Detalle_Ventas.Add(d);
                    // Quitamos existencias
                    await pCtrl.QuitarExistencias(d.idProducto, d.cantidad);
                }
                // Guardar cambios
                var aff = await db.SaveChangesAsync();

                return aff > 0 ? (true, result) : (false, result);
            }
        }

        public async Task<(bool IsSucess, Ventas venta)> CambiarEstatus(int idVenta, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var venta = await db.Ventas.FirstOrDefaultAsync(v => v.id == idVenta);
                venta.idEstatus = nuevoEstatus;

                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, venta) : (false, venta);

            }
        }

        public Task<(bool IsSucess, Ventas venta)> Devolver(int idVenta, int nuevoEstatus)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ventas>> ObtenerDevueltas(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ventas>> ObtenerPorEmpleado(DateTime from, DateTime to, int idEmpleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Ventas
                                      .Include(v => v.cVentaEstatus)
                                      .Include(v => v.Detalle_Ventas)
                                      .Include(v => v.Turnos)
                                      .Where(v => 
                                        v.idEstatus != 2 && 
                                        v.idEmpleado == idEmpleado &&
                                        v.fecha >= from &&
                                        v.fecha <= to)
                                      .OrderByDescending(v => v.id)
                                      .ToListAsync();
                return result;
            }
        }

        public async Task<Ventas> ObtenerPorId(int idVenta)
        {
            using (var db = new dulce_aroma_db())
            {
                var venta = await db.Ventas
                                      .Include(v => v.cVentaEstatus)
                                      .Include(v => v.Detalle_Ventas)
                                      .Include(v => v.Turnos)
                                      .FirstOrDefaultAsync(v => v.id == idVenta);

                return venta;

            }
        }

        public async Task<IEnumerable<Ventas>> ObtenerPorFechas(DateTime from, DateTime to)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Ventas
                                      .Include(v => v.cVentaEstatus)
                                      .Include(v => v.Detalle_Ventas)
                                      .Include(v => v.Turnos)
                                      .Where(v =>
                                        v.idEstatus != 2 &&
                                        v.fecha >= from &&
                                        v.fecha <= to)
                                      .OrderByDescending(v => v.id)
                                      .ToListAsync();
                return result;
            }
        }

        public async Task<IEnumerable<Ventas>> ObtenerPorTurno(int idTurno)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Ventas
                                      .Include(v => v.cVentaEstatus)
                                      .Include(v => v.Detalle_Ventas)
                                      .Include(v => v.Turnos)
                                      .Where(v =>
                                        v.idEstatus != 2 &&
                                        v.idTurno == idTurno)
                                      .OrderByDescending(v => v.id)
                                      .ToListAsync();
                return result;
            }
        }
    }
}
