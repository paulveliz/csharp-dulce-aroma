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
    public class EmpleadoController : IEmpleadoProvider
    {
        public async Task<Empleados> Actualizar(Empleados empleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Empleados
                    .Include(e => e.cEmpleadoEstatus)
                    .Include(e => e.cEmpleadoNivel)
                    .FirstOrDefaultAsync( e => 
                    e.id == empleado.id
                );

                result.nombre_completo = empleado.nombre_completo;
                result.nombre_usuario = empleado.nombre_usuario;
                result.pass = empleado.pass;
                result.idEstatus = empleado.idEstatus;
                result.idNivel = empleado.idNivel;
                var aff = await db.SaveChangesAsync();
                return result;
            }
        }

        public async Task<(bool updated, Empleados empleado)> CambiarEstatus(int idEmpelado, int nuevoEstatus)
        {
            using (var db = new dulce_aroma_db())
            {
                var emp = await db.Empleados.FirstOrDefaultAsync(e => e.id == idEmpelado);
                emp.idEstatus = nuevoEstatus;
                var aff = await db.SaveChangesAsync();
                return aff > 0 ? (true, emp) : (false, emp);
            }
        }

        public async Task<Empleados> CrearNuevo(Empleados empleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var newEmpleado = db.Empleados.Add(empleado);
                _ = await db.SaveChangesAsync();
                return newEmpleado;
            }
        }

        public async Task<Empleados> ObtenerPorId(int idEmpleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var result = await db.Empleados
                    .Include(e => e.cEmpleadoEstatus)
                    .Include(e => e.cEmpleadoNivel)
                    .FirstOrDefaultAsync(e =>
                   e.id == idEmpleado
                );
                return result;
            }
        }

        public async Task<IEnumerable<Empleados>> ObtenerPorNombreMatch(string nombreEmpleado)
        {
            using (var db = new dulce_aroma_db())
            {
                var empleados = await db.Empleados
                    .Include(e => e.cEmpleadoEstatus)
                    .Include(e => e.cEmpleadoNivel)
                    .Where(e => 
                        e.nombre_completo.Contains(nombreEmpleado) && 
                        e.idEstatus == 1)
                    .OrderByDescending(e => e.id)
                    .ToListAsync();
                return empleados;
            }
        }

        public async Task<IEnumerable<Empleados>> ObtenerTodos()
        {
            using (var db = new dulce_aroma_db())
            {
                var empleados = await db.Empleados
                    .Include(e => e.cEmpleadoEstatus)
                    .Include(e => e.cEmpleadoNivel)
                    .Where(e => e.idEstatus == 1)
                    .OrderByDescending(e => e.id)
                    .ToListAsync();
                return empleados;
            }
        }

        public async Task<(bool exists, Empleados empleado)> ValidarNombreUsuario(string usuario)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Empleados.FirstOrDefaultAsync(e => e.nombre_usuario == usuario);
                return res != null ? (true, res) : (false, res);
            }
        }

        public async Task<(bool IsSucess, Empleados empleado)> Verificar(string usuario, string password)
        {
            using (var db = new dulce_aroma_db())
            {
                var res = await db.Empleados.FirstOrDefaultAsync(e => 
                    e.nombre_usuario == usuario &&
                    e.pass == password &&
                    e.idEstatus == 1
                );
                return res != null ? (true, res) : (false, res);
            }
        }
    }
}
