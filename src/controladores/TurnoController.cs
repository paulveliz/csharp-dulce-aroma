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

        public async Task<(bool isSucess, Turnos turno)> ModificarEstatus(int idTurno, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos.FirstOrDefaultAsync(tr => tr.idEstatus == idTurno);
                t.idEstatus = nuevoEstatus;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, t) : (false, t);
            }
        }

        public async Task<Turnos> ObtenerPorId(int idTurno)
        {
            using (var db = new dulce_aroma_db())
            {
                var t = await db.Turnos.FirstOrDefaultAsync(tr => tr.idEstatus == idTurno);
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
                                        t.fecha >= fromt &&
                                        t.fecha <= to &&
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
                                        t.fecha >= fromt &&
                                        t.fecha <= to 
                                    )
                                    .OrderByDescending(t => t.id)
                                    .ToListAsync();
                return turnos;
            }
        }
    }
}
