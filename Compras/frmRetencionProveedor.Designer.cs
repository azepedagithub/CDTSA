namespace CO
{
	partial class frmRetencionProveedor
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetencionProveedor));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtgRetenciones = new DevExpress.XtraGrid.GridControl();
			this.gridViewRetencion = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPorc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMontoMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAplicaTotalFac = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAplicaSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAplicaSubTotalMenosDEsc = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgRetenciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRetencion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAgregar,
            this.btnEliminar});
			this.barManager1.MaxItemId = 2;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAgregar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar)});
			this.bar1.Text = "Tools";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Caption = "Agregar";
			this.btnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Glyph")));
			this.btnAgregar.Id = 0;
			this.btnAgregar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.LargeGlyph")));
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregar_ItemClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Caption = "Eliminar";
			this.btnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Glyph")));
			this.btnEliminar.Id = 1;
			this.btnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.LargeGlyph")));
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(905, 47);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 370);
			this.barDockControlBottom.Size = new System.Drawing.Size(905, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 323);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(905, 47);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 323);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtgRetenciones);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 47);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(905, 323);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtgRetenciones
			// 
			this.dtgRetenciones.Location = new System.Drawing.Point(12, 12);
			this.dtgRetenciones.MainView = this.gridViewRetencion;
			this.dtgRetenciones.MenuManager = this.barManager1;
			this.dtgRetenciones.Name = "dtgRetenciones";
			this.dtgRetenciones.Size = new System.Drawing.Size(881, 299);
			this.dtgRetenciones.TabIndex = 4;
			this.dtgRetenciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRetencion});
			// 
			// gridViewRetencion
			// 
			this.gridViewRetencion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDescr,
            this.colPorc,
            this.colMontoMinimo,
            this.colAplicaTotalFac,
            this.colAplicaSubTotal,
            this.colAplicaSubTotalMenosDEsc});
			this.gridViewRetencion.GridControl = this.dtgRetenciones;
			this.gridViewRetencion.Name = "gridViewRetencion";
			this.gridViewRetencion.OptionsBehavior.ReadOnly = true;
			this.gridViewRetencion.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridViewRetencion.OptionsView.ShowGroupPanel = false;
			this.gridViewRetencion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRetencion_FocusedRowChanged);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(905, 323);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgRetenciones;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(885, 303);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "IDRetencion";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			this.colID.Width = 44;
			// 
			// colDescr
			// 
			this.colDescr.Caption = "Descripción";
			this.colDescr.FieldName = "Descr";
			this.colDescr.Name = "colDescr";
			this.colDescr.Visible = true;
			this.colDescr.VisibleIndex = 1;
			this.colDescr.Width = 380;
			// 
			// colPorc
			// 
			this.colPorc.Caption = "%";
			this.colPorc.FieldName = "Porcentaje";
			this.colPorc.Name = "colPorc";
			this.colPorc.Visible = true;
			this.colPorc.VisibleIndex = 2;
			this.colPorc.Width = 81;
			// 
			// colMontoMinimo
			// 
			this.colMontoMinimo.Caption = "Monto Mínimo";
			this.colMontoMinimo.FieldName = "MontoMinimo";
			this.colMontoMinimo.Name = "colMontoMinimo";
			this.colMontoMinimo.Visible = true;
			this.colMontoMinimo.VisibleIndex = 3;
			this.colMontoMinimo.Width = 91;
			// 
			// colAplicaTotalFac
			// 
			this.colAplicaTotalFac.Caption = "Aplica Total Factura";
			this.colAplicaTotalFac.FieldName = "AplicaTotalFactura";
			this.colAplicaTotalFac.Name = "colAplicaTotalFac";
			this.colAplicaTotalFac.Visible = true;
			this.colAplicaTotalFac.VisibleIndex = 4;
			this.colAplicaTotalFac.Width = 101;
			// 
			// colAplicaSubTotal
			// 
			this.colAplicaSubTotal.Caption = "Aplica Sub Total";
			this.colAplicaSubTotal.FieldName = "AplicaSubTotal";
			this.colAplicaSubTotal.Name = "colAplicaSubTotal";
			this.colAplicaSubTotal.Visible = true;
			this.colAplicaSubTotal.VisibleIndex = 5;
			this.colAplicaSubTotal.Width = 96;
			// 
			// colAplicaSubTotalMenosDEsc
			// 
			this.colAplicaSubTotalMenosDEsc.Caption = "Aplica Sub Total Menos Desc";
			this.colAplicaSubTotalMenosDEsc.FieldName = "AplicaSubTotalMenosDesc";
			this.colAplicaSubTotalMenosDEsc.Name = "colAplicaSubTotalMenosDEsc";
			this.colAplicaSubTotalMenosDEsc.Visible = true;
			this.colAplicaSubTotalMenosDEsc.VisibleIndex = 6;
			this.colAplicaSubTotalMenosDEsc.Width = 172;
			// 
			// frmRetencionProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 393);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frmRetencionProveedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRetencionProveedor";
			this.Load += new System.EventHandler(this.frmRetencionProveedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgRetenciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRetencion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnAgregar;
		private DevExpress.XtraBars.BarButtonItem btnEliminar;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl dtgRetenciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewRetencion;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colDescr;
		private DevExpress.XtraGrid.Columns.GridColumn colPorc;
		private DevExpress.XtraGrid.Columns.GridColumn colMontoMinimo;
		private DevExpress.XtraGrid.Columns.GridColumn colAplicaTotalFac;
		private DevExpress.XtraGrid.Columns.GridColumn colAplicaSubTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colAplicaSubTotalMenosDEsc;
	}
}