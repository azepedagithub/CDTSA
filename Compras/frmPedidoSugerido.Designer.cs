namespace CO
{
	partial class frmPedidoSugerido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoSugerido));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btnQuitarMensaje = new DevExpress.XtraBars.BarButtonItem();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.dtgPedidoSugerido = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescrProducto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUndVentaTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCantMeses = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostoPromDolar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMontoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrecioUnitCompra = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCantSugerida = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtpFecha = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.txtUmbralExistencia = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.btnImportarPedido = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidoSugerido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnQuitarMensaje,
            this.dtpFecha,
            this.txtUmbralExistencia,
            this.barButtonItem1,
            this.btnRefrescar,
            this.btnImportarPedido});
			this.barManager1.MaxItemId = 6;
			this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemTextEdit1});
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(797, 47);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 422);
			this.barDockControlBottom.Size = new System.Drawing.Size(797, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(797, 47);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.dtpFecha, "", false, true, true, 152, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.txtUmbralExistencia, "", false, true, true, 196, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefrescar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuitarMensaje),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportarPedido)});
			this.bar1.Text = "Tools";
			// 
			// btnQuitarMensaje
			// 
			this.btnQuitarMensaje.Caption = "Quitar Elementos con Mensajes";
			this.btnQuitarMensaje.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuitarMensaje.Glyph")));
			this.btnQuitarMensaje.Id = 0;
			this.btnQuitarMensaje.Name = "btnQuitarMensaje";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtgPedidoSugerido);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 47);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(797, 375);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(797, 375);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// dtgPedidoSugerido
			// 
			this.dtgPedidoSugerido.Location = new System.Drawing.Point(12, 12);
			this.dtgPedidoSugerido.MainView = this.gridView1;
			this.dtgPedidoSugerido.MenuManager = this.barManager1;
			this.dtgPedidoSugerido.Name = "dtgPedidoSugerido";
			this.dtgPedidoSugerido.Size = new System.Drawing.Size(773, 351);
			this.dtgPedidoSugerido.TabIndex = 4;
			this.dtgPedidoSugerido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colDescrProducto,
            this.colUndVentaTotal,
            this.colCantMeses,
            this.colCostoPromDolar,
            this.colMontoOrden,
            this.colPrecioUnitCompra,
            this.colExistencia,
            this.colCantSugerida,
            this.colMensaje});
			this.gridView1.GridControl = this.dtgPedidoSugerido;
			this.gridView1.Name = "gridView1";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgPedidoSugerido;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(777, 355);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// colIdProducto
			// 
			this.colIdProducto.Caption = "ID Producto";
			this.colIdProducto.FieldName = "IDProducto";
			this.colIdProducto.Name = "colIdProducto";
			this.colIdProducto.Visible = true;
			this.colIdProducto.VisibleIndex = 0;
			// 
			// colDescrProducto
			// 
			this.colDescrProducto.Caption = "Descr Producto";
			this.colDescrProducto.FieldName = "DescrProducto";
			this.colDescrProducto.Name = "colDescrProducto";
			this.colDescrProducto.Visible = true;
			this.colDescrProducto.VisibleIndex = 1;
			// 
			// colUndVentaTotal
			// 
			this.colUndVentaTotal.Caption = "UndVentaTotal";
			this.colUndVentaTotal.FieldName = "UndVentaTotal";
			this.colUndVentaTotal.Name = "colUndVentaTotal";
			this.colUndVentaTotal.Visible = true;
			this.colUndVentaTotal.VisibleIndex = 2;
			// 
			// colCantMeses
			// 
			this.colCantMeses.Caption = "CantMeses";
			this.colCantMeses.FieldName = "CantMeses";
			this.colCantMeses.Name = "colCantMeses";
			this.colCantMeses.Visible = true;
			this.colCantMeses.VisibleIndex = 3;
			// 
			// colCostoPromDolar
			// 
			this.colCostoPromDolar.Caption = "CostoPromDolar";
			this.colCostoPromDolar.FieldName = "CostoPromDolar";
			this.colCostoPromDolar.Name = "colCostoPromDolar";
			this.colCostoPromDolar.Visible = true;
			this.colCostoPromDolar.VisibleIndex = 4;
			// 
			// colMontoOrden
			// 
			this.colMontoOrden.Caption = "MontoOrden";
			this.colMontoOrden.FieldName = "MontoOrden";
			this.colMontoOrden.Name = "colMontoOrden";
			this.colMontoOrden.Visible = true;
			this.colMontoOrden.VisibleIndex = 5;
			// 
			// colPrecioUnitCompra
			// 
			this.colPrecioUnitCompra.Caption = "PrecioUnitCompra";
			this.colPrecioUnitCompra.FieldName = "PrecioUnitCompra";
			this.colPrecioUnitCompra.Name = "colPrecioUnitCompra";
			this.colPrecioUnitCompra.Visible = true;
			this.colPrecioUnitCompra.VisibleIndex = 6;
			// 
			// colExistencia
			// 
			this.colExistencia.Caption = "Existencia";
			this.colExistencia.FieldName = "Existencia";
			this.colExistencia.Name = "colExistencia";
			this.colExistencia.Visible = true;
			this.colExistencia.VisibleIndex = 7;
			// 
			// colCantSugerida
			// 
			this.colCantSugerida.Caption = "CantSugerida";
			this.colCantSugerida.FieldName = "CantSugerida";
			this.colCantSugerida.Name = "colCantSugerida";
			this.colCantSugerida.Visible = true;
			this.colCantSugerida.VisibleIndex = 8;
			// 
			// colMensaje
			// 
			this.colMensaje.Caption = "Mensaje";
			this.colMensaje.FieldName = "Mensaje";
			this.colMensaje.Name = "colMensaje";
			this.colMensaje.Visible = true;
			this.colMensaje.VisibleIndex = 9;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Caption = "Fecha:";
			this.dtpFecha.Edit = this.repositoryItemDateEdit1;
			this.dtpFecha.Id = 1;
			this.dtpFecha.Name = "dtpFecha";
			// 
			// repositoryItemDateEdit1
			// 
			this.repositoryItemDateEdit1.AutoHeight = false;
			this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
			// 
			// txtUmbralExistencia
			// 
			this.txtUmbralExistencia.Caption = "Umbral de Existencia:";
			this.txtUmbralExistencia.Edit = this.repositoryItemTextEdit1;
			this.txtUmbralExistencia.Id = 2;
			this.txtUmbralExistencia.Name = "txtUmbralExistencia";
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Cargar Datos";
			this.barButtonItem1.Id = 3;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Caption = "Cargar Datos";
			this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
			this.btnRefrescar.Id = 4;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
			// 
			// btnImportarPedido
			// 
			this.btnImportarPedido.Caption = "Sugerir Pedido";
			this.btnImportarPedido.Glyph = ((System.Drawing.Image)(resources.GetObject("btnImportarPedido.Glyph")));
			this.btnImportarPedido.Id = 5;
			this.btnImportarPedido.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnImportarPedido.LargeGlyph")));
			this.btnImportarPedido.Name = "btnImportarPedido";
			this.btnImportarPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportarPedido_ItemClick);
			// 
			// frmPedidoSugerido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 422);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPedidoSugerido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pedido Sugerido";
			this.Load += new System.EventHandler(this.frmPedidoSugerido_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidoSugerido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnQuitarMensaje;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl dtgPedidoSugerido;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
		private DevExpress.XtraGrid.Columns.GridColumn colDescrProducto;
		private DevExpress.XtraGrid.Columns.GridColumn colUndVentaTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colCantMeses;
		private DevExpress.XtraGrid.Columns.GridColumn colCostoPromDolar;
		private DevExpress.XtraGrid.Columns.GridColumn colMontoOrden;
		private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitCompra;
		private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
		private DevExpress.XtraGrid.Columns.GridColumn colCantSugerida;
		private DevExpress.XtraGrid.Columns.GridColumn colMensaje;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.BarEditItem dtpFecha;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
		private DevExpress.XtraBars.BarEditItem txtUmbralExistencia;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraBars.BarButtonItem btnRefrescar;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnImportarPedido;
	}
}