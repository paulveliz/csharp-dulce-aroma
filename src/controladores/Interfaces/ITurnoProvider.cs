using modelos.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface ITurnoProvider
    {
        Task<Turnos> ObtenerPorId(int idTurno);
        Task<IEnumerable<Turnos>> TurnosPorFecha(DateTime fromt, DateTime to);
        Task<IEnumerable<Turnos>> TurnosPorEmpleado(DateTime fromt, DateTime to, int idEmpleado);
        Task<(bool isSucess, Turnos turno)> CrearNuevo(Turnos turno);
        Task<(bool isSucess, Turnos turno)> ModificarEstatus(int idTurno, int nuevoEstatus);
    }
}
