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

namespace dulce_aroma.Forms.turnos
{
    public partial class ReporteDeTurno : Form
    {
        public ReporteDeTurno(List<ReporteVentaModel> ventas, string empleado, string fechaApertura, string horaApertura, string fechaCierre, string horaCierre, string totalVentas, string importeTotal)
        {
            InitializeComponent();
            var rptH = new ReportClass();
            rptH.FileName = @"C:\dulce-aroma-reportes\TurnoReport.rpt";
            rptH.Load();
            rptH.SetDataSource(ventas);

            rptH.SetParameterValue("pEmpleado", empleado);
            rptH.SetParameterValue("pFechaApertura", fechaApertura);
            rptH.SetParameterValue("pHoraApertura", horaApertura);
            rptH.SetParameterValue("pFechaCierre", fechaCierre);
            rptH.SetParameterValue("pHoraCierre", horaCierre);
            rptH.SetParameterValue("pTotalVentas", totalVentas);
            rptH.SetParameterValue("pImporteTotal", importeTotal);

            crv.ReportSource = rptH;
            crv.Refresh();
        }
    }
}
