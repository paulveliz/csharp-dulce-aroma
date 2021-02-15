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

namespace dulce_aroma.Forms.entradas
{
    public partial class EntradaReport : Form
    {
        public EntradaReport(List<EntradaDetalleModel> detalle, string empleado, string proveedor, string cantprod, string importe, string fecha, string folio)
        {
            InitializeComponent();
            var rptH = new ReportClass();
            rptH.FileName = @"C:\dulce-aroma-reportes\EntradaReportCrv.rpt";
            rptH.Load();
            rptH.SetDataSource(detalle);
            rptH.SetParameterValue("pEmpleado", empleado);
            rptH.SetParameterValue("pProveedor", proveedor);
            rptH.SetParameterValue("pCantProd", cantprod);
            rptH.SetParameterValue("pImporteTotal", importe);
            rptH.SetParameterValue("pFecha", fecha);
            rptH.SetParameterValue("pFolio", folio);
            crv.ReportSource = rptH;
            crv.Refresh();
        }
    }
}
