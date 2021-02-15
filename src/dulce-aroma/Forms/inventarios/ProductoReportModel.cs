using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.inventarios
{
    public class ProductoReportModel
    {
        public string Producto { get; set; }
        public string Proveedor { get; set; }
        public string Codigo { get; set; }
        public int Existencias { get; set; }
    }
}
