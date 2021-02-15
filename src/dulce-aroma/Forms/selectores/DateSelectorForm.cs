using System;
using System.Windows.Forms;

namespace dulce_aroma.Forms.selectores
{
    public partial class DateSelectorForm : Form
    {
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        public DateSelectorForm()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Continuar?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!r.Equals(DialogResult.Yes)) return;
            this.Fecha1 = this.txtfecha1.Value;
            this.Fecha2 = this.txtfecha2.Value;
            this.DialogResult = DialogResult.Yes;
        }
    }
}
