using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CREngine = CrystalDecisions.CrystalReports.Engine;

namespace CRViewerProject
{
    public partial class CRViewer : System.Web.UI.Page
    {
        private string FILE_PATH = @"CR.rpt";
        private string SEQ = "5";

        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            ConnectionInfo info = new ConnectionInfo
            {
                AllowCustomConnection = true,
                ServerName = @"MyOrcl",
                UserID = "systaem",
                Password = "orcl"
            };
            report.Load(FILE_PATH);
            report.SetParameterValue("SEQ", SEQ);
            foreach (CREngine.Table table in report.Database.Tables)
            {
                TableLogOnInfo log_info = table.LogOnInfo;
                log_info.ConnectionInfo = info;
                table.ApplyLogOnInfo(log_info);
            }
            MyViewer.ReportSource = report;
        }
    }
}