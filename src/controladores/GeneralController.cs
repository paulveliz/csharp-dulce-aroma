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
    public class GeneralController : IGeneralLogic
    {
        public async Task<IEnumerable<cEmpleadoNivel>> ObtenerNivelesDeEmpleados()
        {
            using (var db = new dulce_aroma_db())
            {
                var niveles = await db.cEmpleadoNivel.Take(5).ToListAsync();
                return niveles;
            }
        }
    }
}
