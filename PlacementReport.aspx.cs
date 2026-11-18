using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;
using System.Threading;

namespace PlacementDashboard
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();

            string reportPath = Server.MapPath("~/CrystalReport1.rpt");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-IN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-IN");
            report.Load(reportPath);

            CrystalReportViewer1.ReportSource = report;
            CrystalReportViewer1.DataBind();
        }
    }
}
