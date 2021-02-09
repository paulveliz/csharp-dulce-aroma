using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelos.Context;
using controladores;

namespace dulce_aroma.Forms.menu
{
    public partial class MenuForm : Form
    {
        public Empleados Empleado { get; set; }
        public MenuForm(Empleados e)
        {
            this.Empleado = e;
            InitializeComponent();
        }

        private void bienvenida()
        {
            this.Text = $"Bienvenida al sistema dulce aroma - {this.Empleado.nombre_completo}";
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            bienvenida();
        }
    }
}
