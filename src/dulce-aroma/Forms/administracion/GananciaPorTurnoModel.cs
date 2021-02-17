using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.administracion
{
    public class GananciaPorTurnoModel
    {
        public int NoTurno { get; set; }
        public string FechaApertura { get; set; }
        public string HoraApertura { get; set; }
        public string FechaCierre { get; set; }
        public string HoraCierre { get; set; }
        public string Empleado { get; set; }
        /// Cantidad de productos vendidos.
        public int CantProductos { get; set; }
        /// Sumatoria del precio de los productos que se vendieron en dicho turno.
        public decimal ImportePorPrecio { get; set; }
        /// Sumatoria del costo de los productos que se vendieron en dicho turno.
        public decimal ImportePorCosto { get; set; }
        public decimal GananciaTurno { get; set; }

    }
}
