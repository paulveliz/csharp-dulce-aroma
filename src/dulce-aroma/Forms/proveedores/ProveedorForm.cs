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

namespace dulce_aroma.Forms.proveedores
{
    public partial class ProveedorForm : Form
    {
        ProveedorController pCtrl = new ProveedorController();
        public ProveedorForm()
        {
            InitializeComponent();
        }
        private void MakeControls(bool t)
        {
            this.txtbuscar.Enabled = t;
            this.txtnombre.Enabled = t;
            this.btnadd.Enabled = t;
        }
        private async Task ObtenerTodosToDgv() 
        {
            this.dgvbase.Rows.Clear();
            var proveedores = await pCtrl.ObtenerTodos();
            foreach (var p in proveedores)
            {
                this.dgvbase.Rows.Add($"{p.id}", $"{p.nombre}", $"{p.cProveedorEstatus.descripcion}");
            }
            MakeControls(true);
        }

        private async void ProveedorForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            await ObtenerTodosToDgv();
            this.Cursor = Cursors.Default;
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idProveedor = Convert.ToInt32( this.dgvbase.SelectedRows[0].Cells[0].Value );
                var nombreProveedor = this.dgvbase.SelectedRows[0].Cells[2].Value.ToString();
                var res = MessageBox.Show($"¿Desea dar de baja al proveedor \"{nombreProveedor}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes) return;
                // Proceso de eliminado
                this.Cursor = Cursors.WaitCursor;
                var bajaProveedor = await pCtrl.CambiarEstatus(idProveedor, 2);
                await ObtenerTodosToDgv();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.dgvbase.Rows.Clear();
            this.Cursor = Cursors.WaitCursor;
            var proveedores = await pCtrl.ObtenerPorNombreMatch(this.txtbuscar.Text);
            foreach (var p in proveedores)
            {
                this.dgvbase.Rows.Add($"{p.id}", $"{p.nombre}", $"{p.cProveedorEstatus.descripcion}");
            }
            MakeControls(true);
            this.Cursor = Cursors.Default;
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text.Length < 4)
            {
                MessageBox.Show("El nombre del proveedor debe tener almenos 4 letras de longitud.","Nombre incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show($"¿Desea agregar al proveedor \"{this.txtnombre.Text}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm != DialogResult.Yes) return;
            var p = new Proveedores()
            {
                nombre = this.txtnombre.Text.Trim(),
                idEstatus = 1
            };
            this.Cursor = Cursors.WaitCursor;
            MakeControls(false);
            var proveedor = await pCtrl.CrearNuevo(p);
            if(proveedor != null)
            {
                MessageBox.Show("Proveedor implementado al sistema con exito.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ObtenerTodosToDgv();
                this.txtnombre.Clear();
            }
            else
            {
                MessageBox.Show("El proveedor no pudo ser implementado en el sistema. Intente de nuevo.", "Operacion sin exito", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.Cursor = Cursors.Default;
        }

        private void ProveedorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                this.btnadd.Focus();
            }
            if(e.KeyCode == Keys.F2)
            {
                this.txtbuscar.Focus();
            }
        }
    }
}
