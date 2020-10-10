using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ObjectBinding;

namespace CO.Reportes
{
    public partial class rptLiquidacionCompra : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLiquidacionCompra()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRSubreport subreport = sender as XRSubreport;
            //XtraReport reportSource = subreport.ReportSource as XtraReport;
            //(reportSource.DataSource as ObjectDataSource).DataSource = ODataSource.Queries["sqlDataSource1"];  
        }

    }
}
