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

namespace dulce_aroma.Forms.empleados
{
    public partial class EmpleadosForm : Form
    {
        EmpleadoController empCtrl = new EmpleadoController();
        GeneralController genCtrl = new GeneralController();
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private async Task ObtenerEmpleadosToDgv()
        {
            if(this.dgvbase.Rows.Count > 0)
            {
                this.dgvbase.Rows.Clear();
            }
            this.Cursor = Cursors.WaitCursor;
            var empleados = await empCtrl.ObtenerTodos();
            foreach (var empleado in empleados)
            {
                this.dgvbase.Rows.Add($"{empleado.id}", $"{empleado.nombre_completo}", $"{empleado.cEmpleadoNivel.descripcion}");
            }
            MakeControls(true);
            this.Cursor = Cursors.Default;
        }

        private async Task ObtenerNivelesEmpleados()
        {
            this.Cursor = Cursors.WaitCursor;
            var niveles = await genCtrl.ObtenerNivelesDeEmpleados();
            this.cboxniveles.DataSource = niveles;
            this.cboxniveles.DisplayMember = "descripcion";
            this.cboxniveles.ValueMember = "id";
            this.Cursor = Cursors.Default;
        }

        private void MakeControls(bool t)
        {
            this.txtnombre.Enabled = t;
            this.txtbuscar.Enabled = t;
            this.txtpass1.Enabled = t;
            this.txtpass2.Enabled = t;
            this.txtusuario.Enabled = t;
            this.btnadd.Enabled = t;
            this.cboxniveles.Enabled = t;
        }

        private void ClearControls()
        {
            this.txtnombre.Clear();
            this.txtbuscar.Clear();
            this.txtpass1.Clear();
            this.txtpass2.Clear();
            this.txtusuario.Clear();
            this.txtnombre.Focus();
        }
        private async Task<bool> CrearNuevoEmpleado(Empleados empleado)
        {
            this.Cursor = Cursors.WaitCursor;
            MakeControls(false);
            // Agregar empleado al sistema
            var addNewEmpleado = await empCtrl.CrearNuevo(empleado);
            MakeControls(true);
            this.Cursor = Cursors.Default;
            return addNewEmpleado != null ? true : false;

        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await ObtenerNivelesEmpleados();
            await ObtenerEmpleadosToDgv();
            this.txtnombre.Focus();
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            if(this.txtnombre.Text.Trim().Length < 5)
            {
                MessageBox.Show("Por favor introduzca un nombre de almenos 5 letras.", "Nombre incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtnombre.Focus();
                return;
            }
            if(this.txtusuario.Text.Trim().Length < 5)
            {
                MessageBox.Show("Por favor introduzca un nombre de usuario de almenos 5 letras.", "Identificador incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtusuario.Focus();
                return;
            }
            if(this.txtpass1.Text.Length < 5)
            {
                MessageBox.Show("Por favor introduzca una contraseña 5 letras/numeros.", "Contraseña incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtpass1.Focus();
                return;
            }            
            if(this.txtpass2.Text.Length < 5)
            {
                MessageBox.Show("Por favor repita su contraseña correctamente.", "Repetición de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtpass2.Focus();
                return;
            }            
            if(txtpass1.Text != txtpass2.Text)
            {
                MessageBox.Show("Las contraseñas introducidas no coinciden.", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtpass2.Focus();
                return;
            }
            var nivelSeleccionado = (cEmpleadoNivel)this.cboxniveles.SelectedItem;
            var confirm = MessageBox.Show($"¿Desea agregar al sistema a \"{this.txtnombre.Text}\" con nivel de \"{nivelSeleccionado.descripcion}\" ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            // Agregar empleado al sistema.
            var empleado = new Empleados()
            {
                idEstatus = 1,
                idNivel = nivelSeleccionado.id,
                nombre_completo = this.txtnombre.Text.Trim(),
                nombre_usuario = this.txtusuario.Text.Trim(),
                pass = this.txtpass1.Text
            };
            var verificarNombre = await empCtrl.ValidarNombreUsuario(this.txtusuario.Text.Trim());
            if (verificarNombre.exists)
            {
                MessageBox.Show($"El usuario introdúcido \"{this.txtusuario.Text.Trim()}\" ya existe en el sistema.", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtusuario.Focus();
                return;
            }
            var newEmpleado = await this.CrearNuevoEmpleado(empleado);
            MakeControls(false);
            if (newEmpleado)
            {
                MessageBox.Show("Registro de empleado exítoso.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                await ObtenerEmpleadosToDgv();
            }
            else
            {
                MessageBox.Show("Ocurrió un error intentando agregar un nuevo empleado, contacte con el administrador e intente de nuevo.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        private async void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dgvbase.Rows.Count > 0)
            {
                this.dgvbase.Rows.Clear();
            }
            this.Cursor = Cursors.WaitCursor;
            var empleados = await empCtrl.ObtenerPorNombreMatch(this.txtbuscar.Text);
            foreach (var empleado in empleados)
            {
                this.dgvbase.Rows.Add($"{empleado.id}", $"{empleado.nombre_completo}", $"{empleado.cEmpleadoNivel.descripcion}");
            }
            this.Cursor = Cursors.Default;
        }

        private void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Implementar baja para empleados.
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
