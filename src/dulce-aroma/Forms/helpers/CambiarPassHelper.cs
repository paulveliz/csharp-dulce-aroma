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
    public partial class CambiarPassHelper : Form
    {
        public Empleados Empelado { get; set; }
        public CambiarPassHelper(Empleados emp)
        {
            this.Empelado = emp;
            InitializeComponent();
        }

        private async void btnchange_Click(object sender, EventArgs e)
        {
            if(txtpass1.Text.Length < 5)
            {
                MessageBox.Show("La contraseña debe tener almenos 5 letras de longitud.");
                return;
            }
            if(txtpass2.Text.Length < 5)
            {
                MessageBox.Show("La contraseña debe tener almenos 5 letras de longitud.");
                return;
            }
            if(txtpass1.Text != txtpass2.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir.");
                return;
            }

            // cambiar pass
            var empleadoController = new EmpleadoController();
            this.Empelado.pass = this.txtpass1.Text;
            var n = await empleadoController.Actualizar(this.Empelado);
            MessageBox.Show("Contraseña cambiada con exito");
            this.Close();
        }
    }
}
