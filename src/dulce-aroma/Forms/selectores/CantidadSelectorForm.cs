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
    public partial class CantidadSelectorForm : Form
    {
        public int Cantidad { get; set; }
        public int CantidadMaxima { get; set; }
        public CantidadSelectorForm(int maxCant)
        {
            this.CantidadMaxima = maxCant;
            InitializeComponent();
        }

        private void CantidadSelectorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(this.txtcant.Text.Length == 0)
                {
                    this.txtcant.Text = "1";
                }
                int nuevaCantidad = Convert.ToInt32( this.txtcant.Text.Trim() );
                if(nuevaCantidad < 0 || nuevaCantidad == 0)
                {
                    nuevaCantidad = 1;
                    this.txtcant.Text = "1";
                }
                if(nuevaCantidad > CantidadMaxima)
                {
                    nuevaCantidad = CantidadMaxima;
                }
                this.Cantidad = nuevaCantidad;
                this.DialogResult = DialogResult.Yes;

            }
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
