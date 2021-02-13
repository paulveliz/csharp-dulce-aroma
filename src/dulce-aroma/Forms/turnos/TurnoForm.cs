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

        private void btnabrir_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
