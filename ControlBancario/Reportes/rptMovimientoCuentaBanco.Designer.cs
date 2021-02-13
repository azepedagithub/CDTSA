namespace ControlBancario.Reportes
{
	partial class rptMovimientoCuentaBanco
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptMovimientoCuentaBanco));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.Negrita = new DevExpress.XtraReports.UI.FormattingRule();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
			this.FechaInicial = new DevExpress.XtraReports.Parameters.Parameter();
			this.FechaFinal = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDCuentaBanco = new DevExpress.XtraReports.Parameters.Parameter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
			this.Detail.HeightF = 23F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel5
			// 
			this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbGetEstadoCuenta.Monto")});
			this.xrLabel5.FormattingRules.Add(this.Negrita);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(676F, 0F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "xrLabel5";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// Negrita
			// 
			this.Negrita.Condition = "[Orden] in (\'I\',\'F\')";
			// 
			// 
			// 
			this.Negrita.Formatting.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Negrita.Name = "Negrita";
			// 
			// xrLabel4
			// 
			this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbGetEstadoCuenta.ConceptoContable")});
			this.xrLabel4.FormattingRules.Add(this.Negrita);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(470.7916F, 0F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(205.2083F, 23F);
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "xrLabel4";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel3
			// 
			this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbGetEstadoCuenta.Numero")});
			this.xrLabel3.FormattingRules.Add(this.Negrita);
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(370.7916F, 0F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "xrLabel3";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel2
			// 
			this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbGetEstadoCuenta.Descr")});
			this.xrLabel2.FormattingRules.Add(this.Negrita);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(270.7916F, 23F);
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "xrLabel2";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbGetEstadoCuenta.Fecha", "{0:MM/dd/yyyy}")});
			this.xrLabel1.FormattingRules.Add(this.Negrita);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 93F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 100F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "ControlBancario.Properties.Settings.strCon";
			this.sqlDataSource1.Name = "sqlDataSource1";
			storedProcQuery1.Name = "cbGetEstadoCuenta";
			queryParameter1.Name = "@FechaInicial";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.FechaInicial]", typeof(System.DateTime));
			queryParameter2.Name = "@FechaFinal";
			queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FechaFinal]", typeof(System.DateTime));
			queryParameter3.Name = "@IDCuentaBanco";
			queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.IDCuentaBanco]", typeof(int));
			storedProcQuery1.Parameters.Add(queryParameter1);
			storedProcQuery1.Parameters.Add(queryParameter2);
			storedProcQuery1.Parameters.Add(queryParameter3);
			storedProcQuery1.StoredProcName = "cbGetEstadoCuenta";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// FechaInicial
			// 
			this.FechaInicial.Name = "FechaInicial";
			this.FechaInicial.Type = typeof(System.DateTime);
			this.FechaInicial.ValueInfo = "2021-02-01";
			this.FechaInicial.Visible = false;
			// 
			// FechaFinal
			// 
			this.FechaFinal.Name = "FechaFinal";
			this.FechaFinal.Type = typeof(System.DateTime);
			this.FechaFinal.ValueInfo = "2021-02-24";
			this.FechaFinal.Visible = false;
			// 
			// IDCuentaBanco
			// 
			this.IDCuentaBanco.Name = "IDCuentaBanco";
			this.IDCuentaBanco.Type = typeof(int);
			this.IDCuentaBanco.ValueInfo = "1";
			this.IDCuentaBanco.Visible = false;
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
			this.ReportHeader.HeightF = 70.83334F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel6
			// 
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(310.4167F, 26.66667F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(144.75F, 23F);
			this.xrLabel6.Text = "Reporte de Movimientos ";
			// 
			// ReportFooter
			// 
			this.ReportFooter.HeightF = 100F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// rptMovimientoCuentaBanco
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "cbGetEstadoCuenta";
			this.DataSource = this.sqlDataSource1;
			this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.Negrita});
			this.Margins = new System.Drawing.Printing.Margins(38, 36, 93, 100);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FechaInicial,
            this.FechaFinal,
            this.IDCuentaBanco});
			this.Version = "15.2";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.FormattingRule Negrita;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.Parameters.Parameter FechaInicial;
		private DevExpress.XtraReports.Parameters.Parameter FechaFinal;
		private DevExpress.XtraReports.Parameters.Parameter IDCuentaBanco;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel6;
		private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
	}
}
