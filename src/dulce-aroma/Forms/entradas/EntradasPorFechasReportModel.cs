using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.entradas
{
    public class EntradasPorFechasReportModel
    {
        public int NoEntrada { get; set; }
        public string Empelado { get; set; }
        public string Proveedor { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int CantProductos { get; set; }
        public decimal Importe { get; set; }
    }
}
