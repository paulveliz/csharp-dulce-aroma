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

namespace dulce_aroma.Forms.inventarios
{
    public partial class InventarioForm : Form
    {
        ProductoController productoCon = new ProductoController();
        public InventarioForm()
        {
            InitializeComponent();
        }
        private void MakeControls(bool t)
        {
            this.txtbuscar.Enabled = t;
            this.txtcodigo.Enabled = t;
            this.txtnombre.Enabled = t;
            this.btnadd.Enabled = t;
            this.cboxproveedores.Enabled = t;
        }
        private async Task ObtenerProveedores()
        {
            var ctrl = new ProveedorController();
            var proveedores = await ctrl.ObtenerTodos();
            this.cboxproveedores.DataSource = proveedores;
            this.cboxproveedores.DisplayMember = "nombre";
            this.cboxproveedores.ValueMember = "id";
        }
        private async Task ObtenerProductosToDgv()
        {
            var productos = await productoCon.ObtenerTodos();
            this.dgvbase.Rows.Clear();
            foreach (var producto in productos)
            {
                this.dgvbase.Rows.Add($"{producto.id}", $"{producto.codigo}", $"{producto.nombre}", $"{producto.Proveedores.nombre}", $"{producto.precio}", $"{producto.costo}", $"{producto.existencias}");
            }
            MakeControls(true);
        }

        private async void InventarioForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            await ObtenerProductosToDgv();
            await ObtenerProveedores();
            this.Cursor = Cursors.Default;
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre del producto debe ser igual o mayor a 3 letras de longitud.", "Nombre incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var verifyCode = await productoCon.VerificarCodigo(this.txtcodigo.Text.Trim());
            if (verifyCode.exists)
            {
                MessageBox.Show($"En el sistema ya existe un producto con el mismo código", "Codigo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var verifyName = await productoCon.VerificarNombre(this.txtnombre.Text.Trim());
            if (verifyName.exists)
            {
                MessageBox.Show($"En el sistema ya existe un producto llamado \"{this.txtnombre.Text.Trim()}\", intente con otro nombre.", "Ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show($"¿Desea agregar el producto \"{this.txtnombre.Text.Trim()}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            var proveedor = (Proveedores)this.cboxproveedores.SelectedItem;
            var fecha = DateTime.Now.Date.ToString("d", System.Globalization.CultureInfo.CurrentCulture);
            var hora = DateTime.Now.TimeOfDay;
            var p = new Productos() 
            {
                codigo = this.txtcodigo.Text.Trim().Length == 0 ? "Sin código" : this.txtcodigo.Text.Trim(),
                nombre = this.txtnombre.Text.Trim(),
                idProveedor = proveedor.id,
                existencias = 0,
                idEstatus = 1,
                precio = 0,
                costo = 0,
                fecha = Convert.ToDateTime(fecha),
                hora = hora
            };
            MakeControls(false);
            this.Cursor = Cursors.WaitCursor;
            var newProduct = await productoCon.CrearNuevo(p);
            if(newProduct != null)
            {
                MessageBox.Show("El producto fue agregado con exito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ObtenerProductosToDgv();
                this.txtcodigo.Clear();
                this.txtnombre.Clear();
            }
            else
            {
                MessageBox.Show("El producto no pudo ser agregado al sistema verifique toda su informacion e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.Cursor = Cursors.Default;
        }

        private void InventarioForm_KeyDown(object sender, KeyEventArgs e)
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

        private async void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.dgvbase.Rows.Clear();
            this.dgvbase.Refresh();
            var productos = await productoCon.ObtenerPorNombreMatch(this.txtbuscar.Text);
            foreach (var producto in productos)
            {
                this.dgvbase.Rows.Add($"{producto.id}", $"{producto.codigo}", $"{producto.nombre}", $"{producto.Proveedores.nombre}", $"{producto.precio}", $"{producto.costo}", $"{producto.existencias}");
            }
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombreProduct = this.dgvbase.SelectedRows[0].Cells[2].Value.ToString();
                int idProduct = Convert.ToInt32( this.dgvbase.SelectedRows[0].Cells[0].Value);
                var confirm = MessageBox.Show($"¿Desea dar de baja el producto \"{nombreProduct}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
                var baja = await productoCon.CambiarEstatus(idProduct, 2);
                if (baja != null)
                {
                    MessageBox.Show("El producto fue dado de baja con exito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ObtenerProductosToDgv();
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser dado de baja del sistema verifique toda su informacion e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
