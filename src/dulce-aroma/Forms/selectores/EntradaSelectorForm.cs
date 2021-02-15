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

namespace dulce_aroma.Forms.selectores
{
    public partial class EntradaSelectorForm : Form
    {
        public Entradas Entrada { get; set; }
        public EntradaSelectorForm()
        {
            InitializeComponent();
        }


        private async void EntradaSelectorForm_Load(object sender, EventArgs e)
        {
            await ObtenerEntradasToDgv();
        }

        private async Task ObtenerEntradasToDgv()
        {
            var eCtrl = new EntradaController();
            this.dgvexistentes.Rows.Clear();
            var entradas = await eCtrl.ObtenerTodas();
            foreach (var entrada in entradas)
            {
                this.dgvexistentes.Rows.Add($"{entrada.id}", $"{entrada.Empleados.nombre_completo}", $"{entrada.Proveedores.nombre}", $"{entrada.fecha}", $"{entrada.importe}", $"{entrada.cEntradaEstatus.descripcion}");
            }
        }

        private async void dgvexistentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idEntrada =  Convert.ToInt32( this.dgvexistentes.SelectedRows[0].Cells[0].Value.ToString());
                var result = MessageBox.Show($"¿Seleccionar entrada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!result.Equals(DialogResult.Yes)) return;
                var eCtrl = new EntradaController();
                var entrada = await eCtrl.ObtenerPorId(idEntrada);
                this.Entrada = entrada;
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btnfiltrar_Click(object sender, EventArgs e)
        {
            var eCtrl = new EntradaController();
            this.dgvexistentes.Rows.Clear();
            var entradas = await eCtrl.ObtenerPorFechas(txtfecha1.Value, txtfecha2.Value);
            foreach (var entrada in entradas)
            {
                this.dgvexistentes.Rows.Add($"{entrada.id}", $"{entrada.Empleados.nombre_completo}", $"{entrada.Proveedores.nombre}", $"{entrada.fecha}", $"{entrada.importe}", $"{entrada.cEntradaEstatus.descripcion}");
            }
        }
    }
}
