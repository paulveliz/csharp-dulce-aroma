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

namespace dulce_aroma.Forms.proveedores
{
    public partial class EntradasPorProveedorReportForm : Form
    {
        public EntradasPorProveedorReportForm(List<EntradasPorProveedorReportModel> entradas, string fecha1, string fecha2, string proveedor)
        {
            InitializeComponent();
            var rptH = new ReportClass();
            rptH.FileName = @"C:\dulce-aroma-reportes\EntradasPorProveedorReportCrv.rpt";
            rptH.Load();
            rptH.SetDataSource(entradas);
            rptH.SetParameterValue("pFecha1", fecha1);
            rptH.SetParameterValue("pFecha2", fecha2);
            rptH.SetParameterValue("pProveedor", proveedor);
            crv.ReportSource = rptH;
            crv.Refresh();
        }

        private void EntradasPorProveedorReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
