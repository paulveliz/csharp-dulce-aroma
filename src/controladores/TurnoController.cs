using controladores.Interfaces;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace controladores
{
    public class TurnoController : ITurnoProvider
    {
        public async Task<(bool isSucess, Turnos turno)> CrearNuevo(Turnos turno)
        {
            using (var db = new dulce_aroma_db())
            {
                var nuevoTurno = db.Turnos.Add(turno);
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, nuevoTurno) : (false, nuevoTurno);
            }
        }

        public async Task<(bool isActive, Turnos turno)> ObtenerActivo()
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos
                    .Include(tr => tr.Empleados)
                    .Include(tr => tr.cTurnoEstatus)
                    .Include(tr => tr.Ventas)
                    .FirstOrDefaultAsync(tr => tr.idEstatus == 1);
                return t != null ? (true, t) : (false, t);
            }
        }
        public async Task<IEnumerable<Turnos>> ObtenerConcluidos()
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos
                    .Include(tr => tr.Empleados)
                    .Include(tr => tr.cTurnoEstatus)
                    .Include(tr => tr.Ventas)
                    .Where(tr => tr.idEstatus == 2)
                    .Take(100)
                    .OrderByDescending(tr => tr.id)
                    .ToListAsync();
                return t;
            }
        }

        public async Task<(bool isSucess, Turnos turno)> ModificarEstatus(int idTurno, int nuevoEstatus, DateTime fecha, TimeSpan hora)
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos
                    .Include(tr => tr.Empleados)
                    .Include(tr => tr.cTurnoEstatus)
                    .Include(tr => tr.Ventas)
                    .FirstOrDefaultAsync(tr => tr.id == idTurno);
                t.idEstatus = nuevoEstatus;
                t.hora_cierre = hora;
                t.fecha_cierre = fecha;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, t) : (false, t);
            }
        }

        public async Task<Turnos> ObtenerPorId(int idTurno)
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos
                    .Include(tr => tr.Empleados)
                    .Include(tr => tr.cTurnoEstatus)
                    .Include(tr => tr.Ventas)
                    .Include("Ventas.Detalle_Ventas")
                    .Include("Ventas.Detalle_Ventas.Productos")
                    .FirstOrDefaultAsync(tr => tr.id == idTurno);
                return t;
            }
        }

        public async Task<IEnumerable<Turnos>> TurnosPorEmpleado(DateTime fromt, DateTime to, int idEmpleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var turnos = await db.Turnos
                                    .Include(t => t.cTurnoEstatus)
                                    .Include(t => t.Empleados)
                                    .Include(t => t.Ventas)
                                    .Where(t =>
                                        t.fecha_apertura >= fromt &&
                                        t.fecha_apertura <= to &&
                                        t.idEmpleado == idEmpleado
                                    )
                                    .OrderByDescending(t => t.id)
                                    .ToListAsync();
                return turnos;
            }
        }

        public async Task<IEnumerable<Turnos>> TurnosPorFecha(DateTime fromt, DateTime to)
        {
            using (var db = new dulce_aroma_db())
            {
                var turnos = await db.Turnos
                                    .Include(t => t.cTurnoEstatus)
                                    .Include(t => t.Empleados)
                                    .Include(t => t.Ventas)
                                    .Where(t =>
                                        t.idEstatus != 1 &&
                                        t.fecha_apertura >= fromt &&
                                        t.fecha_apertura <= to 
                                    )
                                    .OrderByDescending(t => t.id)
                                    .ToListAsync();
                return turnos;
            }
        }
        public async Task<(bool exists, Turnos turno)> ObtenerUltimoTurnoConcluido()
        {
            using (var db = new dulce_aroma_db())
            {
                var turnos = await db.Turnos
                                    .Include(t => t.cTurnoEstatus)
                                    .Include(t => t.Empleados)
                                    .Include(t => t.Ventas)
                                    .Where(t => t.idEstatus != 1)
                                    .OrderByDescending(t => t.id)
                                    .ToListAsync();
                return turnos.Count > 0 ? (true, turnos[0]) : (false, null);
            }
        }
    }
}
