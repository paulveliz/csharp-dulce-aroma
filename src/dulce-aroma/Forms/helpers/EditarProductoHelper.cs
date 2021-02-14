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

namespace dulce_aroma.Forms.helpers
{
    public partial class EditarProductoHelper : Form
    {
        public Productos Producto { get; set; }
        ProductoController productoController = new ProductoController();
        public EditarProductoHelper(Productos producto)
        {
            this.Producto = producto;
            InitializeComponent();
        }

        private void EditarProductoHelper_Load(object sender, EventArgs e)
        {
            this.txtnombre.Text = this.Producto.nombre;
            this.txtcodigo.Text = this.Producto.codigo;
            this.txtprecio.Text = this.Producto.precio.ToString();
            this.txtcosto.Text = this.Producto.costo.ToString();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            if(this.txtnombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre del producto debe ser igual o mayor a 3 letras de longitud.", "Nombre incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtprecio.Text.Length < 2)
            {
                MessageBox.Show("Introduzca un precio valido de al menos 2 digitos.", "Precio incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtprecio.Focus();
                return;
            }
            if (this.txtcosto.Text.Length < 2)
            {
                MessageBox.Show("Introduzca un costo valido de al menos 2 digitos.", "Costo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtcosto.Focus();
                return;
            }
            if (txtcodigo.Text.Length == 0)
            {
                MessageBox.Show($"El codigo del producto es obligatorio.", "Codigo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show("¿Actualizar?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (!res.Equals(DialogResult.Yes)) return;
            this.Producto.costo = Convert.ToDecimal(this.txtcosto.Text.Trim());
            this.Producto.precio = Convert.ToDecimal(this.txtprecio.Text.Trim());
            var verifyName = await productoController.VerificarNombre(this.txtnombre.Text.Trim());
            if (verifyName.exists && verifyName.producto.nombre != this.Producto.nombre)
            {
                MessageBox.Show("Ya existe un producto con este nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtnombre.Focus();
                return;
            }
            this.Producto.nombre = this.txtnombre.Text.Trim();
            var verifyCode = await productoController.VerificarCodigo(this.txtcodigo.Text.Trim());
            if (verifyCode.exists && verifyCode.producto.codigo != this.Producto.codigo)
            {
                MessageBox.Show("Ya existe un producto con este codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtcodigo.Focus();
                return;
            }
            this.Producto.codigo = this.txtcodigo.Text.Trim();
            var modified = await productoController.Actualizar(this.Producto);
            if (!modified.Equals(null))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
