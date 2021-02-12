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
    public partial class ProveedorSelectorForm : Form
    {
        ProveedorController controller = new ProveedorController();
        public Proveedores Proveedor { get; set; }
        public ProveedorSelectorForm()
        {
            InitializeComponent();
        }

        private async Task ObtenerProveedoresToDgv()
        {
            var proveedores = await controller.ObtenerTodos();
            this.dgvbase.Rows.Clear();
            foreach (var p in proveedores)
            {
                this.dgvbase.Rows.Add($"{p.id}", $"{p.nombre}", $"{p.cProveedorEstatus.descripcion}");
            }
        }
        private async void ProveedorSelectorForm_Load(object sender, EventArgs e)
        {
            await ObtenerProveedoresToDgv();
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idProveedor = Convert.ToInt32(this.dgvbase.SelectedRows[0].Cells[0].Value);
                var nombreProveedor = this.dgvbase.SelectedRows[0].Cells[1].Value.ToString();
                var res = MessageBox.Show($"¿Desea seleccionar al proveedor \"{nombreProveedor}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes) return;
                // Proceso de seleccion
                var proveedor = await controller.ObtenerPorId(idProveedor);
                if (!proveedor.Equals(null))
                {
                    this.Proveedor = proveedor;
                    this.DialogResult = DialogResult.Yes;

                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
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
            var proveedores = await controller.ObtenerPorNombreMatch(this.txtbuscar.Text);
            this.Cursor = Cursors.Default;
            foreach (var p in proveedores)
            {
                this.dgvbase.Rows.Add($"{p.id}", $"{p.nombre}", $"{p.cProveedorEstatus.descripcion}");
            }
        }
    }
}
