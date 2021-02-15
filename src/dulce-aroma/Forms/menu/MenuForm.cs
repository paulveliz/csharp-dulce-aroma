using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelos.Context;
using controladores;
using dulce_aroma.Forms.turnos;
using dulce_aroma.Forms.proveedores;
using dulce_aroma.Forms.entradas;
using dulce_aroma.Forms.inventarios;

namespace dulce_aroma.Forms.menu
{
    public partial class MenuForm : Form
    {
        public Empleados Empleado { get; set; }
        public MenuForm(Empleados e)
        {
            this.Empleado = e;
            InitializeComponent();
        }

        private void bienvenida()
        {
            this.Text = $"SISTEMA DULCE AROMA - {this.Empleado.nombre_completo}";
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            bienvenida();
            if(this.Empleado.idNivel != 1)
            {
                toolStripLabel1.Enabled = false;
                nuevaEntradaToolStripMenuItem.Enabled = false;
                nuevoProductoToolStripMenuItem.Enabled = false;
                nuevoProveedorToolStripMenuItem1.Enabled = false;
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empFrm = new empleados.EmpleadosForm();
            empFrm.ShowDialog();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new inventarios.InventarioForm();
            frm.ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var provFrm = new proveedores.ProveedorForm();
            provFrm.ShowDialog();
        }

        private void nuevaEntradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new entradas.EntradasForm(this.Empleado);
            frm.ShowDialog();
        }

        private void turnoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new turnos.TurnoForm(this.Empleado);
            frm.ShowDialog();
        }

        private async void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoController tc = new TurnoController();
            var turno = await tc.ObtenerActivo();
            if (turno.isActive)
            {
                var frm = new ventas.FormVenta(this.Empleado);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay turno activo.","Abra un turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void informeDeTurnoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vCtrl = new VentasController();
            var tCtrl = new TurnoController();
            var hayTurno = await tCtrl.ObtenerUltimoTurnoConcluido();
            if(!hayTurno.exists)
            {
                MessageBox.Show("No hay turno.", "Abra un turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var turno = hayTurno.turno;
            var ventasPorTurno = await vCtrl.ObtenerPorTurno(turno.id);
            var ventasR = ventasPorTurno.Select(v => new ReporteVentaModel()
            {
                fecha = v.fecha,
                hora = v.hora,
                id = v.id,
                cantProductos = v.Detalle_Ventas.Count,
                importe = v.importe
            }).ToList();
            var totalVentas = ventasR.Count();
            decimal importeVentas = 0;
            foreach (var v in ventasR)
            {
                importeVentas += v.importe;
            }

            var frmRpt = new ReporteDeTurno(ventasR, turno.Empleados.nombre_completo, turno.fecha_apertura.ToString("d"), turno.hora_apertura.ToString("t"), turno.fecha_cierre?.ToString("d"), turno.hora_cierre?.ToString("t"), totalVentas.ToString(), importeVentas.ToString());
            frmRpt.ShowDialog();
        }

        private void cambiarMiContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new helpers.CambiarPassHelper(this.Empleado);
            frm.ShowDialog();
        }

        private async void informeDeTurnosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var selector = new selectores.DateSelectorForm())
            {
                var result = selector.ShowDialog();
                if (!result.Equals(DialogResult.Yes)) return;
                var from = Convert.ToDateTime( selector.Fecha1.ToString("d") );
                var to = Convert.ToDateTime( selector.Fecha2.ToString("d") );
                var tc = new TurnoController();
                var turnos = await tc.TurnosPorFecha(from, to);
                var turnosR = turnos.Select(t => new ReporteDeTurnoModel() {
                    Empleado = t.Empleados.nombre_completo,
                    fecha_apertura = t.fecha_apertura,
                    hora_apertura = t.hora_apertura,
                    TotalVentas = t.Ventas.Count,
                    ImporteTotal = (from venta in t.Ventas select venta.importe).Sum()
                }).ToList();
                // Generar reporte
                var reporte = new turnos.ReporteDeTurnoPorFechas(turnosR, from.ToString("d"), to.ToString("d"));
                reporte.ShowDialog();
            }
        }

        private void informeDeTurnoEspecificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new selectores.TurnoSelectorForm();
            frm.ShowDialog();
        }

        private async void informeDeEntradasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var selector =  new selectores.ProveedorSelectorForm())
            {
                var result = selector.ShowDialog();
                if (!result.Equals(DialogResult.Yes)) return;
                var proveedor = selector.Proveedor;
                using (var selectorDate = new selectores.DateSelectorForm())
                {
                    var resultDate = selectorDate.ShowDialog();
                    if (!resultDate.Equals(DialogResult.Yes)) return;
                    var ec = new EntradaController();
                    var entradas = await ec.ObtenerPorProveedor(selectorDate.Fecha1, selectorDate.Fecha2, proveedor.id);
                    var entradasR = entradas.Select(en => new EntradasPorProveedorReportModel()
                    {
                        Empelado = en.Empleados.nombre_completo,
                        Fecha = en.fecha.ToString("d"),
                        Hora = en.hora.ToString("t"),
                        Importe = en.importe,
                        NoEntrada = en.id,
                        CantProductos = (from productos in en.Detalle_Entradas select productos.cantidad).Sum()
                    }).ToList();
                    // Generar reporte
                    var report = new proveedores.EntradasPorProveedorReportForm(entradasR, selectorDate.Fecha1.ToString("d"), selectorDate.Fecha2.ToString("d"), proveedor.nombre);
                    report.ShowDialog();
                }
            }
        }

        private async void informeDeEntradasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var selectorDate = new selectores.DateSelectorForm())
            {
                var resultDate = selectorDate.ShowDialog();
                if (!resultDate.Equals(DialogResult.Yes)) return;
                var ec = new EntradaController();
                var entradas = await ec.ObtenerPorFechas(selectorDate.Fecha1, selectorDate.Fecha2);
                var entradasR = entradas.Select(en => new EntradasPorFechasReportModel()
                {
                    Proveedor = en.Proveedores.nombre,
                    Empelado = en.Empleados.nombre_completo,
                    Fecha = en.fecha.ToString("d"),
                    Hora = en.hora.ToString("t"),
                    Importe = en.importe,
                    NoEntrada = en.id,
                    CantProductos = (from productos in en.Detalle_Entradas select productos.cantidad).Sum()
                }).ToList();
                // Generar reporte
                var report = new entradas.EntradasPorFechasReport(entradasR, selectorDate.Fecha1.ToString("d"), selectorDate.Fecha2.ToString("d"));
                report.ShowDialog();
            }
        }

        private void informeDeEntradaEspecificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var selector = new selectores.EntradaSelectorForm())
            {
                var result = selector.ShowDialog();
                if (!result.Equals(DialogResult.Yes)) return;
                var entrada = selector.Entrada;
                // Imprimir reporte
                int cantProd = 0;
                decimal importeTotal = 0;
                var details = entrada.Detalle_Entradas.Select(dt => {
                    cantProd += dt.cantidad;
                    importeTotal += dt.importe;
                    return new EntradaDetalleModel()
                    {
                        Importe = dt.importe,
                        Cantidad = dt.cantidad,
                        Costo = dt.cantidad,
                        Precio = dt.precio,
                        Producto = dt.Productos.nombre
                    };
                }).ToList();
                var report = new EntradaReport(details, entrada.Empleados.nombre_completo, entrada.Proveedores.nombre, cantProd.ToString(), importeTotal.ToString(), entrada.fecha.ToString("d"), entrada.id.ToString());
                report.ShowDialog();
            }
        }

        private async void informePorAgotarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pController = new ProductoController();
            var productos = await pController.ObtenerPorAgotarse();
            var productosR = productos.Select(p => new ProductoReportModel()
            {
                Codigo = p.codigo,
                Existencias = p.existencias,
                Producto = p.nombre,
                Proveedor = p.Proveedores.nombre
            }).ToList();
            var report = new inventarios.ProductoReportForm(productosR, "poragotarse");
            report.ShowDialog();
        }

        private async void informeAgotadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pController = new ProductoController();
            var productos = await pController.ObtenerAgotados();
            var productosR = productos.Select(p => new ProductoReportModel()
            {
                Codigo = p.codigo,
                Existencias = p.existencias,
                Producto = p.nombre,
                Proveedor = p.Proveedores.nombre
            }).ToList();
            var report = new inventarios.ProductoReportForm(productosR, "agotados");
            report.ShowDialog();
        }

        private async void informeDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pController = new ProductoController();
            var productos = await pController.ObtenerTodos();
            var productosR = productos.Select(p => new ProductoReportModel()
            {
                Codigo = p.codigo,
                Existencias = p.existencias,
                Producto = p.nombre,
                Proveedor = p.Proveedores.nombre
            }).ToList();
            var report = new inventarios.ProductoReportForm(productosR, "inventario");
            report.ShowDialog();
        }
    }
}
