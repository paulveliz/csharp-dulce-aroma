using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.turnos
{
    class ReporteDeTurnoModel
    {
        public string Empleado { get; set; }
        public System.DateTime fecha_apertura { get; set; }
        public System.TimeSpan hora_apertura { get; set; }
        public Nullable<System.DateTime> fecha_cierre { get; set; }
        public Nullable<System.TimeSpan> hora_cierre { get; set; }
        public int TotalVentas { get; set; }
        public decimal ImporteTotal { get; set; }

    }
}
