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

namespace dulce_aroma.Forms.selectores
{
    public partial class TurnoGeneralSelector : Form
    {
        TurnoController tCtrl = new TurnoController();
        public Turnos Turno { get; set; }
        public TurnoGeneralSelector()
        {
            InitializeComponent();
        }

        private async void TurnoGeneralSelector_Load(object sender, EventArgs e)
        {
            var turnos = await tCtrl.ObtenerConcluidos();
            foreach (var turno in turnos)
            {
                this.dgvbase.Rows.Add($"{turno.id}", $"{turno.Empleados.nombre_completo}", $"{turno.fecha_apertura:d} {turno.hora_apertura:t}", $"{turno.fecha_cierre:d} {turno.hora_cierre:t}");
            }
        }

        private async void btnfiltrar_Click(object sender, EventArgs e)
        {
            var turnos = await tCtrl.TurnosPorFecha(this.txtfecha1.Value, this.txtfecha2.Value);
            this.dgvbase.Rows.Clear();
            this.dgvbase.Refresh();
            foreach (var turno in turnos)
            {
                this.dgvbase.Rows.Add($"{turno.id}", $"{turno.Empleados.nombre_completo}", $"{turno.fecha_apertura:d} {turno.hora_apertura:t}", $"{turno.fecha_cierre:d} {turno.hora_cierre:t}");
            }
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idTurno = Convert.ToInt32(this.dgvbase.SelectedRows[0].Cells[0].Value.ToString());
                // Mandar a imprimir turno
                var d = MessageBox.Show("¿Seleccionar este turno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!d.Equals(DialogResult.Yes)) return;
                var turno = await tCtrl.ObtenerPorId(idTurno);
                this.Turno = turno;
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
