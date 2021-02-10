using modelos.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IEmpleadoProvider
    {
        Task<Empleados> ObtenerPorId(int idEmpleado);
        Task<(bool IsSucess, Empleados empleado)> Verificar(string usuario, string password);
        Task<(bool exists, Empleados empleado)> ValidarNombreUsuario(string usuario);
        Task<IEnumerable<Empleados>> ObtenerPorNombreMatch(string nombreEmpleado);
        Task<IEnumerable<Empleados>> ObtenerTodos();
        Task<Empleados> CrearNuevo(Empleados empleado);
        Task<Empleados> Actualizar(Empleados empleado);
        Task<(bool updated, Empleados empleado)> CambiarEstatus(int idEmpelado, int nuevoEstatus);
    }
}
