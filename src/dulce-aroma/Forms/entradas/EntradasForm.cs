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

namespace dulce_aroma.Forms.entradas
{
    public partial class EntradasForm : Form
    {
        EntradaController eCtrl = new EntradaController();
        public Proveedores Proveedor { get; set; }
        public Productos Producto { get; set; }
        public EntradasForm()
        {
            InitializeComponent();
        }

        private async Task ObtenerEntradasToDgv()
        {
            this.dgvexistentes.Rows.Clear();
            var entradas = await eCtrl.ObtenerTodas();
            foreach (var entrada in entradas)
            {
                this.dgvexistentes.Rows.Add($"{entrada.id}", $"{entrada.idEmpleado}", $"{entrada.Proveedores.nombre}", $"{entrada.fecha}", $"{entrada.importe}", $"{entrada.cEntradaEstatus.descripcion}");
            }
        }

        private void IsProveedorSeleccionado(bool t)
        {
            this.btnNoProveedor.Enabled = !t;
            this.btnSearchProveedor.Enabled = !t;
            this.btnNoProducto.Enabled = t;
            this.btnSearchProducto.Enabled = t;
            this.txtprecio.Enabled = t;
            this.txtcosto.Enabled = t;
            this.txtcant.Enabled = t;
            this.btnAddCant.Enabled = t;
            this.btnQuitCant.Enabled = t;
            this.btnadd.Enabled = t;
            this.btnfinalizar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
        }
        private void GenerarDatosGenerales(int cantidad, decimal importe)
        {
            int nuevaCantActual = Convert.ToInt32( this.txtCantNuevasEntradas.Text ) + cantidad;
            int nuevosProdAfectados = Convert.ToInt32(this.txtProdAfectados.Text) + 1;
            decimal nuevoImporteTotal = Convert.ToDecimal(txtImporte.Text) + importe;
            this.txtCantNuevasEntradas.Text = nuevaCantActual.ToString();
            this.txtProdAfectados.Text = nuevosProdAfectados.ToString();
            this.txtImporte.Text = nuevoImporteTotal.ToString();
        }

        private void AgregarProductoAEntrada(int cantidad, Productos producto)
        {
            this.dgvNuevas.Rows.Add($"{producto.id}", $"{producto.nombre}", $"{cantidad}", $"{producto.precio}", $"{producto.costo}", $"{(cantidad * producto.costo)}");
            GenerarDatosGenerales(cantidad, (cantidad * producto.costo));
            this.txtproducto.Clear();
            this.Producto = new Productos();
            this.txtprecio.Text = "0";
            this.txtcant.Text = "1";
            this.txtcosto.Text = "0";
            this.btnSearchProducto.Focus();
        }

        private bool ExistsProduct(int idProduct) 
        {
            foreach (DataGridViewRow row in this.dgvNuevas.Rows)
            {
                if(row.Cells[0].Value.ToString() == idProduct.ToString())
                {
                    return true;
                }
            }

            return false;
        }
        private void btnSearchProveedor_Click(object sender, EventArgs e)
        {
            using (var selector = new selectores.ProveedorSelectorForm())
            {
                var res = selector.ShowDialog();
                if (!res.Equals(DialogResult.Yes)) return;
                // Traer datos del proveedor.
                IsProveedorSeleccionado(true);
                this.Proveedor = selector.Proveedor;
                this.txtproveedor.Text = this.Proveedor.nombre;
            }
        }

        private void btnSearchProducto_Click(object sender, EventArgs e)
        {
            using (var selector = new selectores.ProductoSelectorForm())
            {
                var res = selector.ShowDialog();
                if (!res.Equals(DialogResult.Yes)) return;
                // Traer datos del producto.
                if(selector.Producto.idProveedor != this.Proveedor.id)
                {
                    MessageBox.Show("El producto seleccionado no pertenece al proveedor indicado.", "Proveedor erroneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.btnSearchProducto.Focus();
                    return;
                }
                this.Producto = selector.Producto;
                this.txtprecio.Text = $"{this.Producto.precio}";
                this.txtcosto.Text = $"{this.Producto.costo}";
                this.txtproducto.Text = $"{this.Producto.nombre}";
            }
        }

        private void btnNoProveedor_Click(object sender, EventArgs e)
        {
            var form = new proveedores.ProveedorForm();
            form.ShowDialog();
        }

        private void btnNoProducto_Click(object sender, EventArgs e)
        {
            var form = new inventarios.InventarioForm();
            form.ShowDialog();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddCant_Click(object sender, EventArgs e)
        {
            var cantActual = Convert.ToInt32(this.txtcant.Text) + 1;
            this.txtcant.Text = cantActual.ToString();
        }

        private void btnQuitCant_Click(object sender, EventArgs e)
        {
            var cantActual = Convert.ToInt32(this.txtcant.Text) == 1 ? 1 : Convert.ToInt32(this.txtcant.Text) - 1;
            this.txtcant.Text = cantActual.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(this.txtproducto.Text.Length == 0)
            {
                MessageBox.Show("Seleccione un producto primero.", "Sin producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSearchProducto.Focus();
                return;
            }
            if(this.txtprecio.Text.Length < 2) 
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
            if(txtcant.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un cantidad de entradas correcta.", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtcant.Focus();
                return;
            }            
            if(txtcant.Text == "0")
            {
                MessageBox.Show("Introduzca un cantidad de entradas correcta.", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtcant.Focus();
                return;
            }

            decimal precioProd = Convert.ToDecimal(this.txtprecio.Text.Trim());
            decimal costoProd = Convert.ToDecimal(this.txtcosto.Text.Trim());
            int cantidadProd = Convert.ToInt32(this.txtcant.Text.Trim());
            if(precioProd < 1 || costoProd < 1)
            {
                MessageBox.Show("El precio y el costo deben ser mayores a $1.00 pesos", "Error monetario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtprecio.Focus();
                return;
            }
            // Agregar producto al dgv
            this.Producto.precio = precioProd;
            this.Producto.costo = costoProd;
            if (ExistsProduct(this.Producto.id))
            {
                MessageBox.Show("Este producto ya fue capturado, elimine el que se encuentra en la lista e intente nuevamente.", "Producto en lista.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgregarProductoAEntrada(cantidadProd, this.Producto);
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            if(this.txtcant.Text == "0")
            {
                this.txtcant.Text = "1";
            }
        }

        private void dgvNuevas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombreProducto = this.dgvNuevas.SelectedRows[0].Cells[1].Value.ToString();
                var result = MessageBox.Show($"¿Desea remover \"{nombreProducto}\"", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!result.Equals(DialogResult.Yes)) return;
                this.dgvNuevas.Rows.Remove(this.dgvNuevas.SelectedRows[0]);
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btnfinalizar_Click(object sender, EventArgs e)
        {
            if(this.dgvNuevas.Rows.Count < 1)
            {
                MessageBox.Show("No hay productos para realizar una entrada.", "Sin productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show("¿Desea finalizar la entrada? al finalizar la entrada generará una nueva entrada en el sistema y actualizará los datos del producto.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!confirm.Equals(DialogResult.Yes)) return;
            var fecha = DateTime.Now.Date.ToString("d", System.Globalization.CultureInfo.CurrentCulture);
            var hora = DateTime.Now.TimeOfDay;
            decimal importe = Convert.ToDecimal(txtImporte.Text);
            // Crear nueva entrada.
            var entrada = new Entradas()
            {
                fecha =  Convert.ToDateTime( fecha ),
                hora = hora,
                idEmpleado = 1 /*TODO: IMPLEMENTAR EMPLEADO*/,
                idEstatus = 1,
                idProveedor = this.Proveedor.id,
                importe = importe
            };
            List<Detalle_Entradas> detalle = new List<Detalle_Entradas>();
            foreach (DataGridViewRow producto in this.dgvNuevas.Rows)
            {
                detalle.Add(new Detalle_Entradas() 
                {
                    idProducto =  Convert.ToInt32( producto.Cells[0].Value.ToString().Trim() ),
                    cantidad = Convert.ToInt32( producto.Cells[2].Value.ToString().Trim() ),
                    precio =  Convert.ToDecimal( producto.Cells[3].Value.ToString() ),
                    costo =  Convert.ToDecimal( producto.Cells[4].Value.ToString() ),
                    importe = Convert.ToDecimal( producto.Cells[5].Value.ToString() )
                });
            }
            var nuevaEntrada = await eCtrl.CrearNueva(entrada, detalle);
            if (nuevaEntrada.IsSucess)
            {
                MessageBox.Show($"La entrada fue generada con exito. con folio \"{nuevaEntrada.entrada.id}\"","Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsProveedorSeleccionado(false);
                this.txtproveedor.Clear();
                this.txtproducto.Clear();
                this.Producto = new Productos();
                this.Proveedor = new Proveedores();
                this.txtprecio.Text = "0";
                this.txtcant.Text = "1";
                this.txtcosto.Text = "0";
                this.txtCantNuevasEntradas.Text = "0";
                this.txtProdAfectados.Text = "0";
                this.txtImporte.Text = "0";
                this.dgvNuevas.Rows.Clear();
                await ObtenerEntradasToDgv();
                this.btnSearchProveedor.Focus();
            }
        }

        private async void EntradasForm_Load(object sender, EventArgs e)
        {
            await ObtenerEntradasToDgv();
        }
    }
}
