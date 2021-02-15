using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dulce_aroma.Forms.inventarios
{
    public partial class ProductoReportForm : Form
    {
        public string Path { get; set; }
        public ProductoReportForm(List<ProductoReportModel> productos, string tipo)
        {
            InitializeComponent();
            if(tipo == "inventario")
            {
                this.Path = "ReporteInventarioCrv.rpt";
            }
            if(tipo == "agotados")
            {
                this.Path = "ReporteInventarioAgotadosCrv.rpt";
            }
            if(tipo == "poragotarse")
            {
                this.Path = "ReporteInventarioPorAgotarseCrv.rpt";
            }
            var rptH = new ReportClass();
            rptH.FileName = $@"C:\dulce-aroma-reportes\{this.Path}";
            rptH.Load();
            rptH.SetDataSource(productos);
            crv.ReportSource = rptH;
            crv.Refresh();
        }
    }
}
