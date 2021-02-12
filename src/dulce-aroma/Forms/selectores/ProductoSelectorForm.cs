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
    public partial class ProductoSelectorForm : Form
    {
        ProductoController ctrl = new ProductoController();
        public Productos Producto { get; set; }
        public ProductoSelectorForm()
        {
            InitializeComponent();
        }
        private async Task ObtenerProductosToDgv()
        {
            var productos = await ctrl.ObtenerTodos();
            this.dgvbase.Rows.Clear();
            foreach (var producto in productos)
            {
                this.dgvbase.Rows.Add($"{producto.id}", $"{producto.nombre}", $"{producto.Proveedores.nombre}", $"{producto.existencias}" , $"${producto.precio}");
            }
        }
        private async void ProductoSelectorForm_Load(object sender, EventArgs e)
        {
            await ObtenerProductosToDgv();
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombreProduct = this.dgvbase.SelectedRows[0].Cells[2].Value.ToString();
                int idProduct = Convert.ToInt32(this.dgvbase.SelectedRows[0].Cells[0].Value);
                var confirm = MessageBox.Show($"¿Desea seleccionar \"{nombreProduct}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
                var p = await ctrl.ObtenerPorId(idProduct);
                if (p != null)
                {
                    this.Producto = p;
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
            var productos = await ctrl.ObtenerPorNombreMatch(this.txtbuscar.Text);
            this.dgvbase.Rows.Clear();
            foreach (var producto in productos)
            {
                this.dgvbase.Rows.Add($"{producto.id}", $"{producto.nombre}", $"{producto.Proveedores.nombre}", $"{producto.existencias}", $"${producto.precio}");
            }
        }
    }
}
