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
    public partial class ReporteDeTurnoPorFechas : Form
    {
        public ReporteDeTurnoPorFechas(List<ReporteDeTurnoModel> turnos, string fecha1, string fecha2)
        {
            InitializeComponent();
            var rptH = new ReportClass();
            rptH.FileName = @"C:\dulce-aroma-reportes\TurnosPorFechasReport.rpt";
            rptH.Load();
            rptH.SetDataSource(turnos);
            rptH.SetParameterValue("pFecha1", fecha1);
            rptH.SetParameterValue("pFecha2", fecha2);
            crv.ReportSource = rptH;
            crv.Refresh();
        }
    }
}
