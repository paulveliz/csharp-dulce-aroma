using modelos.Context;
using System.Collections.Generic;

namespace modelos
{
    public class FullVenta
    {
        public Ventas Venta { get; set; }
        public IEnumerable<Detalle_Ventas> Detalle { get; set; }
    }
}
