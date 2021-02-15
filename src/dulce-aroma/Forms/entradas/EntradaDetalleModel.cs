using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulce_aroma.Forms.entradas
{
    public class EntradaDetalleModel
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
    }
}
