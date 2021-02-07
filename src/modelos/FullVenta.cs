using modelos.Context;

namespace modelos
{
    public class FullVenta
    {
        public Ventas Venta { get; set; }
        public Detalle_Ventas Detalle { get; set; }
    }
}
