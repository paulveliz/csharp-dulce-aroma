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
            this.Text = $"Bienvenida al sistema dulce aroma - {this.Empleado.nombre_completo}";
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            bienvenida();
            if(this.Empleado.idNivel != 1)
            {
                toolStripLabel1.Enabled = false;
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
            var frm = new entradas.EntradasForm();
            frm.ShowDialog();
        }

        private void turnoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new turnos.TurnoForm();
            frm.ShowDialog();
        }

        private async void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoController tc = new TurnoController();
            var turno = await tc.ObtenerActivo();
            if (turno.isActive)
            {
                var frm = new ventas.FormVenta();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay turno activo.","Abra un turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
