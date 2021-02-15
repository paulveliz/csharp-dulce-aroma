using controladores;
using dulce_aroma.Forms.turnos;
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

namespace dulce_aroma.Forms.selectores
{
    public partial class TurnoSelectorForm : Form
    {
        TurnoController tCtrl = new TurnoController();
        public TurnoSelectorForm()
        {
            InitializeComponent();
        }
        private async Task GenerarReporteTurno(Turnos turno)
        {
            var vCtrl = new VentasController();
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
        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idTurno = Convert.ToInt32(this.dgvbase.SelectedRows[0].Cells[0].Value.ToString());
                // Mandar a imprimir turno
                var d = MessageBox.Show("¿Imprimir este turno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!d.Equals(DialogResult.Yes)) return;
                var tc = new TurnoController();
                var turno = await tc.ObtenerPorId(idTurno);
                await GenerarReporteTurno(turno);
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void TurnoSelectorForm_Load(object sender, EventArgs e)
        {
            var turnos = await tCtrl.ObtenerConcluidos();
            foreach (var turno in turnos)
            {
                this.dgvbase.Rows.Add($"{turno.id}", $"{turno.Empleados.nombre_completo}", $"{turno.fecha_apertura:d} {turno.hora_apertura:t}", $"{turno.fecha_cierre:d} {turno.hora_cierre:t}");
            }
        }
    }
}
