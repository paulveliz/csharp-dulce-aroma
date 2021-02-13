using controladores;
using dulce_aroma.Forms.menu;
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

namespace dulce_aroma
{
    public partial class LoginForm : Form
    {
        EmpleadoController empleadoController = new EmpleadoController();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void makeControls(bool t)
        {
            this.cboxempleados.Enabled = t;
            this.txtpass.Enabled = t;
            this.btnacceso.Enabled = t;
        }
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            makeControls(false);
            var empleados = await empleadoController.ObtenerTodos();
            cboxempleados.DataSource = empleados;
            cboxempleados.DisplayMember = "nombre_completo";
            cboxempleados.ValueMember = "id";
            this.Cursor = Cursors.Default;
            makeControls(true);
            txtpass.Focus();
        }

        private async void btnacceso_Click(object sender, EventArgs e)
        {
            if(txtpass.Text.Length < 3)
            {
                MessageBox.Show("Contraseña demasiado corta.", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cboxempleados.Text.Length < 3)
            {
                MessageBox.Show("Seleccione un usuario primero.", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var empleado = (Empleados)this.cboxempleados.SelectedItem;
            var res = MessageBox.Show($"¿Iniciar sesión con la cuenta {empleado.nombre_completo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res != DialogResult.Yes) return;
            var validAccess = await empleadoController.Verificar(empleado.nombre_usuario, this.txtpass.Text);
            if (validAccess.IsSucess)
            {
                // Acceder al menu y enviar al empleado para validar panel administrativo.
                var frm = new MenuForm(empleado);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
