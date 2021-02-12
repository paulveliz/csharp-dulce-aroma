using controladores;
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

        private void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Mandar a imprimir turno
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
