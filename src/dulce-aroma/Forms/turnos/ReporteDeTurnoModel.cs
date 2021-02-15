using modelos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.turnos
{
    public class ReporteDeTurnoModel
    {
        public string Empleado { get; set; }
        public System.DateTime fecha_apertura { get; set; }
        public System.TimeSpan hora_apertura { get; set; }
        public int TotalVentas { get; set; }
        public decimal ImporteTotal { get; set; }

    }
}
