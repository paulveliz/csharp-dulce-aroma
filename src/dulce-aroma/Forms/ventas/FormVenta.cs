using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controladores;
using modelos.Context;

namespace dulce_aroma.Forms.ventas
{
    public partial class FormVenta : Form
    {
        VentasController ventasController = new VentasController();
        ProductoController productoController = new ProductoController();
        public decimal ImporteTotal { get; set; }
        public FormVenta()
        {
            InitializeComponent();
            this.ImporteTotal = 0;
        }
        private void ActualizarImporteTotal()
        {
            this.txtimportetotal.Text = $"TOTAL A PAGAR ${this.ImporteTotal}";
        }
        private (bool existe, DataGridViewRow row) ExisteProductoEnDgv(int idProducto)
        {
            foreach (DataGridViewRow row in this.dgvbase.Rows)
            {
                if(row.Cells[0].Value.ToString().Trim() == idProducto.ToString().Trim())
                {
                    return (true, row);
                }
            }

            return (false, null);
        }
        private void AddProductToDgv(Productos producto, int cantidad)
        {
            if (producto.existencias == 0)
            {
                MessageBox.Show("Producto agotado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var existe = ExisteProductoEnDgv(producto.id);
            if (existe.existe)
            {
                var row = this.dgvbase.Rows[dgvbase.Rows.IndexOf(existe.row)];
                int cantidadActual = Convert.ToInt32(row.Cells[2].Value);
                if(cantidadActual == producto.existencias)
                {
                    MessageBox.Show("Producto agotado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.ImporteTotal += (producto.precio * cantidad);
                row.Cells[2].Value = (cantidadActual + 1).ToString();
                row.Cells[4].Value = (producto.precio * (cantidadActual + 1) ).ToString();
                ActualizarImporteTotal();
            }
            else
            {
                this.ImporteTotal += (producto.precio * cantidad);
                this.dgvbase.Rows.Add($"{producto.id}", $"{producto.nombre}", $"{cantidad}", $"{producto.precio}", $"{(producto.precio * cantidad)}", $"{producto.existencias}");
                ActualizarImporteTotal();
            }
        }
        private void lupa_Click(object sender, EventArgs e)
        {
            using (var selector = new selectores.ProductoSelectorForm())
            {
                var result = selector.ShowDialog();
                if (!result.Equals(DialogResult.Yes)) return;
                var producto = selector.Producto;
                AddProductToDgv(producto, 1);
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.txtbuscar.Select();
            this.txtbuscar.Focus();
            this.txtbuscar.LostFocus += Txtbuscar_LostFocus;
        }

        private void Txtbuscar_LostFocus(object sender, EventArgs e)
        {
            this.txtbuscar.Focus();
        }

        private async void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                var producto = await productoController.ObtenerPorCodigo(this.txtbuscar.Text.Trim());
                if(producto != null)
                {
                    AddProductToDgv(producto, 1);
                    this.txtbuscar.Clear();
                }
                else
                {
                    this.txtbuscar.Clear();
                    MessageBox.Show("Producto no encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = this.dgvbase.SelectedRows[0];
                using (var selector = new selectores.CantidadSelectorForm( Convert.ToInt32(row.Cells[5].Value.ToString().Trim()) ))
                {
                    var result = selector.ShowDialog();
                    if (!result.Equals(DialogResult.Yes)) return;
                    decimal precioactual = Convert.ToDecimal(row.Cells[3].Value);
                    decimal importeDeRowActual = Convert.ToDecimal(row.Cells[4].Value);
                    this.ImporteTotal -= importeDeRowActual;
                    row.Cells[2].Value = (selector.Cantidad).ToString();
                    row.Cells[4].Value = (precioactual * selector.Cantidad).ToString();
                    this.ImporteTotal += (precioactual * selector.Cantidad);
                    ActualizarImporteTotal();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvbase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(e.Button == MouseButtons.Right)
                {
                    var row = this.dgvbase.SelectedRows[0];
                    decimal importeDeRowActual = Convert.ToDecimal(row.Cells[4].Value);
                    this.ImporteTotal -= importeDeRowActual;
                    ActualizarImporteTotal();
                    this.dgvbase.Rows.RemoveAt( row.Index );
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btnfinalizarventa_Click(object sender, EventArgs e)
        {
            var confirmarVenta = MessageBox.Show("¿Efectúar venta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!confirmarVenta.Equals(DialogResult.Yes)) return;
            if (this.dgvbase.Rows.Count == 0)
            {
                return;
            }
            var fecha = DateTime.Now.Date.ToString("d", System.Globalization.CultureInfo.CurrentCulture);
            var hora = DateTime.Now.TimeOfDay;
            var turnoCtrl = new TurnoController();
            var turno = await turnoCtrl.ObtenerActivo();
            var venta = new Ventas()
            {
                fecha =  Convert.ToDateTime( fecha ),
                hora = hora,
                idEstatus = 1,
                idEmpleado = 1, /*TODO: INSERTE EMPLEADO AQUI*/
                idTurno = turno.turno.id,
                importe = this.ImporteTotal
            };
            var detalle = new List<Detalle_Ventas>();
            foreach (DataGridViewRow row in this.dgvbase.Rows)
            {
                int idProducto =  Convert.ToInt32(row.Cells[0].Value);
                int cantidadProd = Convert.ToInt32(row.Cells[2].Value);
                decimal importeProd = Convert.ToDecimal(row.Cells[4].Value);
                var producto = await productoController.ObtenerPorId(idProducto);
                detalle.Add(new Detalle_Ventas()
                {
                    idProducto = idProducto,
                    cantidad = cantidadProd,
                    costo = producto.costo,
                    precio = producto.precio,
                    importe = importeProd
                });
            }
            
            using (var helper = new helpers.CambioHelper(this.ImporteTotal))
            {
                this.dgvbase.Rows.Clear();
                this.ImporteTotal = 0;
                ActualizarImporteTotal();
                var result = helper.ShowDialog();
                if(result == DialogResult.Yes)
                {
                    venta.pago_con = helper.PagoCon;
                    venta.cambio = helper.Cambio;
                    var newVenta = await ventasController.CrearNueva(venta, detalle);
                    if (newVenta.IsSucess)
                    {
                        MessageBox.Show("Venta exitosa", "Imprimiendo ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Imprimir ticket.
                    }

                }
                else if(result == DialogResult.No)
                {
                    // Solo guardar la venta
                    venta.pago_con = helper.PagoCon;
                    venta.cambio = helper.Cambio;
                    var newVenta = await ventasController.CrearNueva(venta, detalle);
                    if (newVenta.IsSucess)
                    {
                        MessageBox.Show("Venta exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Solo guardar la venta
                    venta.pago_con = helper.PagoCon;
                    venta.cambio = helper.Cambio;
                    var newVenta = await ventasController.CrearNueva(venta, detalle);
                    if (newVenta.IsSucess)
                    {
                        MessageBox.Show("Venta exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }
    }
}
