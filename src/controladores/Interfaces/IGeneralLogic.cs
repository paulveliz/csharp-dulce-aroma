using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores.Interfaces
{
    interface IGeneralLogic
    {
        Task<IEnumerable<cEmpleadoNivel>> ObtenerNivelesDeEmpleados();
    }
}
