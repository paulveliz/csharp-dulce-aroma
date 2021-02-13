using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.turnos
{
    public class ReporteVentaModel
    {
        public int id { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public decimal importe { get; set; }
    }
}
