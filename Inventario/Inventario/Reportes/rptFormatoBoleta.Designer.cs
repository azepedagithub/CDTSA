namespace CI.Reportes
{
	partial class rptFormatoBoleta
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
			this.components = new System.ComponentModel.Container();
			DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
			DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptFormatoBoleta));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.IDBodega = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC1 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC2 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC3 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC4 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC5 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDC6 = new DevExpress.XtraReports.Parameters.Parameter();
			this.IDProveedor = new DevExpress.XtraReports.Parameters.Parameter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
			this.Detail.HeightF = 23F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 100F;
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
			this.sqlDataSource1.ConnectionName = "Conexion";
			this.sqlDataSource1.Name = "sqlDataSource1";
			customSqlQuery1.Name = "Generales";
			customSqlQuery1.Sql = "Select Nombre,Telefono,Logo  from globalCompania\r\n";
			storedProcQuery1.Name = "invGetFormatoBoleta";
			queryParameter1.Name = "@IDBodega";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.IDBodega]", typeof(int));
			queryParameter2.Name = "@IDC1";
			queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC1]", typeof(int));
			queryParameter3.Name = "@IDC2";
			queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC2]", typeof(int));
			queryParameter4.Name = "@IDC3";
			queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC3]", typeof(int));
			queryParameter5.Name = "@IDC4";
			queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC4]", typeof(int));
			queryParameter6.Name = "@IDC5";
			queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC5]", typeof(int));
			queryParameter7.Name = "@IDC6";
			queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.IDC6]", typeof(int));
			queryParameter8.Name = "@IDProveedor";
			queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.IDProveedor]", typeof(int));
			storedProcQuery1.Parameters.Add(queryParameter1);
			storedProcQuery1.Parameters.Add(queryParameter2);
			storedProcQuery1.Parameters.Add(queryParameter3);
			storedProcQuery1.Parameters.Add(queryParameter4);
			storedProcQuery1.Parameters.Add(queryParameter5);
			storedProcQuery1.Parameters.Add(queryParameter6);
			storedProcQuery1.Parameters.Add(queryParameter7);
			storedProcQuery1.Parameters.Add(queryParameter8);
			storedProcQuery1.StoredProcName = "invGetFormatoBoleta";
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            storedProcQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// IDBodega
			// 
			this.IDBodega.Name = "IDBodega";
			this.IDBodega.Type = typeof(int);
			this.IDBodega.ValueInfo = "0";
			// 
			// IDC1
			// 
			this.IDC1.Name = "IDC1";
			this.IDC1.Type = typeof(int);
			this.IDC1.ValueInfo = "-1";
			// 
			// IDC2
			// 
			this.IDC2.Name = "IDC2";
			this.IDC2.Type = typeof(int);
			this.IDC2.ValueInfo = "-1";
			// 
			// IDC3
			// 
			this.IDC3.Name = "IDC3";
			this.IDC3.Type = typeof(int);
			this.IDC3.ValueInfo = "-1";
			// 
			// IDC4
			// 
			this.IDC4.Name = "IDC4";
			this.IDC4.Type = typeof(int);
			this.IDC4.ValueInfo = "-1";
			// 
			// IDC5
			// 
			this.IDC5.Name = "IDC5";
			this.IDC5.Type = typeof(int);
			this.IDC5.ValueInfo = "-1";
			// 
			// IDC6
			// 
			this.IDC6.Name = "IDC6";
			this.IDC6.Type = typeof(int);
			this.IDC6.ValueInfo = "-1";
			// 
			// IDProveedor
			// 
			this.IDProveedor.Name = "IDProveedor";
			this.IDProveedor.Type = typeof(int);
			this.IDProveedor.ValueInfo = "-1";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel10,
            this.xrLabel17});
			this.ReportHeader.HeightF = 100F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel10
			// 
			this.xrLabel10.Font = new System.Drawing.Font("Verdana", 14F);
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(174.9999F, 21.45834F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(570.8334F, 23F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "Boleta de Inventario";
			this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel17
			// 
			this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Generales.Nombre")});
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(174.9999F, 49.24084F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(570.8334F, 23F);
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "xrLabel17";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Generales.Logo")});
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(129.1667F, 100F);
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLine2,
            this.xrLabel16,
            this.xrLine1,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel11});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("IDBodega", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = 79.87499F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// xrLabel1
			// 
			this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.IDBodega")});
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(107.2917F, 10.00001F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// xrLabel2
			// 
			this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.NombreBodega")});
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(207.2917F, 10.00001F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(307.2917F, 23F);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Verdana", 9.75F);
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(61.79161F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.Text = "Bodega:";
			// 
			// xrLabel16
			// 
			this.xrLabel16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 52.94917F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(67.625F, 16.12499F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.Text = "ID Prod";
			// 
			// xrLine2
			// 
			this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.75001F);
			this.xrLine2.Name = "xrLine2";
			this.xrLine2.SizeF = new System.Drawing.SizeF(786.2205F, 7.291662F);
			// 
			// xrLine1
			// 
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 65.87499F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(786.2205F, 7.29167F);
			// 
			// xrLabel15
			// 
			this.xrLabel15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(552.6398F, 52.94917F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(69.79163F, 16.12499F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.Text = "F.V";
			// 
			// xrLabel14
			// 
			this.xrLabel14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(700.6397F, 52.94917F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(74.99988F, 16.12499F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.Text = "Cantidad";
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(417.2231F, 52.94917F);
			this.xrLabel13.Multiline = true;
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(120.8333F, 16.12499F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.Text = "Lote Proveedor\r\n";
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(69.38982F, 52.94917F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(347.8333F, 16.12499F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.Text = "Descripción";
			// 
			// xrLabel3
			// 
			this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.IDProducto")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(67.625F, 23F);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrLabel4
			// 
			this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.Descr")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(69.38982F, 0F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(347.8334F, 23F);
			this.xrLabel4.Text = "xrLabel4";
			// 
			// xrLabel5
			// 
			this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.LoteProveedor")});
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(417.2232F, 0F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(120.8333F, 23F);
			this.xrLabel5.Text = "xrLabel5";
			// 
			// xrLabel6
			// 
			this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "invGetFormatoBoleta.FechaVencimiento", "{0:dd/MM/yyyy}")});
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(552.6398F, 0F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel6.Text = "xrLabel6";
			// 
			// xrLine3
			// 
			this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(675F, 15.625F);
			this.xrLine3.Name = "xrLine3";
			this.xrLine3.SizeF = new System.Drawing.SizeF(100F, 7.375F);
			// 
			// rptFormatoBoleta
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "invGetFormatoBoleta";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(36, 39, 100, 100);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IDBodega,
            this.IDC1,
            this.IDC2,
            this.IDC3,
            this.IDC4,
            this.IDC5,
            this.IDC6,
            this.IDProveedor});
			this.Version = "15.2";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.Parameters.Parameter IDBodega;
		private DevExpress.XtraReports.Parameters.Parameter IDC1;
		private DevExpress.XtraReports.Parameters.Parameter IDC2;
		private DevExpress.XtraReports.Parameters.Parameter IDC3;
		private DevExpress.XtraReports.Parameters.Parameter IDC4;
		private DevExpress.XtraReports.Parameters.Parameter IDC5;
		private DevExpress.XtraReports.Parameters.Parameter IDC6;
		private DevExpress.XtraReports.Parameters.Parameter IDProveedor;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel10;
		private DevExpress.XtraReports.UI.XRLabel xrLabel17;
		private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
		private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel9;
		private DevExpress.XtraReports.UI.XRLine xrLine2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel16;
		private DevExpress.XtraReports.UI.XRLine xrLine1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel15;
		private DevExpress.XtraReports.UI.XRLabel xrLabel14;
		private DevExpress.XtraReports.UI.XRLabel xrLabel13;
		private DevExpress.XtraReports.UI.XRLabel xrLabel11;
		private DevExpress.XtraReports.UI.XRLine xrLine3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel6;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
	}
}
