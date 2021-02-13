using controladores;
using modelos.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dulce_aroma.Forms.turnos
{
    public partial class TurnoForm : Form
    {
        TurnoController tCtrl = new TurnoController();
        public TurnoForm()
        {
            InitializeComponent();
        }

        private async void TurnoForm_Load(object sender, EventArgs e)
        {
            this.txtestatus.Text = "CARGANDO DATOS...";
            this.txtempleado.Text = "CARGANDO DATOS...";
            var turno = await tCtrl.ObtenerActivo();
            if (turno.isActive)
            {
                this.txtestatus.Text = $"TURNO CON FOLIO \"{turno.turno.id}\" SE ENCUENTRA ACTIVO Y FUE ABIERTO POR EL EMPLEADO \"{turno.turno.Empleados.nombre_completo}\" CON FECHA \" {turno.turno.fecha_apertura:d} \" A LAS \" {turno.turno.hora_apertura:t} \".";
                btncerrar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
            }
            else
            {
                this.txtestatus.Text = "NO HAY TURNO ABIERTO, TIENE QUE ABRIR UNO PARA PODER REALIZAR VENTAS.";
                btnabrir.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
            }
        }

        private void verListaDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new selectores.TurnoSelectorForm();
            frm.ShowDialog();
        }

        private async void btnabrir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Abrir turno?","Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!result.Equals(DialogResult.Yes)) return;
            var fecha = DateTime.Now.Date.ToString("d", System.Globalization.CultureInfo.CurrentCulture);
            var hora = DateTime.Now.TimeOfDay;
            var tnew = await tCtrl.CrearNuevo(new Turnos() 
            {
                fecha_apertura = Convert.ToDateTime(fecha), 
                hora_apertura = hora,
                idEmpleado = 1,
                idEstatus = 1,
            });
            if (tnew.isSucess)
            {
                btncerrar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
                btnabrir.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
                var turno = await tCtrl.ObtenerActivo();
                if (turno.isActive)
                {
                    this.txtestatus.Text = $"TURNO CON FOLIO \"{turno.turno.id}\" SE ENCUENTRA ACTIVO Y FUE ABIERTO POR EL EMPLEADO \"{turno.turno.Empleados.nombre_completo}\" CON FECHA \" {turno.turno.fecha_apertura:d} \" A LAS \" {turno.turno.hora_apertura:t} \".";
                    btncerrar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
                }
                else
                {
                    this.txtestatus.Text = "NO HAY TURNO ABIERTO, TIENE QUE ABRIR UNO PARA PODER REALIZAR VENTAS.";
                    btnabrir.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
                }
            }
        }

        private async Task GenerarReporteTurno(Turnos turno)
        {
            var vCtrl = new VentasController();
            var ventasPorTurno = await vCtrl.ObtenerPorTurno(turno.id);
            var ventasR = ventasPorTurno.Select(v => new ReporteVentaModel() {
                fecha = v.fecha,
                hora = v.hora,
                id = v.id,
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

        private async void btncerrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿CERRAR turno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!result.Equals(DialogResult.Yes)) return;
            var turno = await tCtrl.ObtenerActivo();
            if (turno.isActive)
            {
                var fecha = DateTime.Now.Date.ToString("d", System.Globalization.CultureInfo.CurrentCulture);
                var hora = DateTime.Now.TimeOfDay;
                var cerrado = await tCtrl.ModificarEstatus(turno.turno.id, 2, Convert.ToDateTime( fecha ), hora);
                if (cerrado.isSucess)
                {
                    this.txtestatus.Text = "NO HAY TURNO ABIERTO, TIENE QUE ABRIR UNO PARA PODER REALIZAR VENTAS.";
                    btnabrir.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
                    btncerrar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
                    // Imprimir reporte de turno
                    var turnoRep = MessageBox.Show("¿IMPRIMIR REPORTE DE TURNO?", "Informe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (!turnoRep.Equals(DialogResult.Yes)) return;
                    await GenerarReporteTurno(cerrado.turno);
                }
            }
        }
    }
}
