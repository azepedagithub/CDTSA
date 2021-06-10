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
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.dtpFecha = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.txtUmbralExistencia = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.btnQuitarMensaje = new DevExpress.XtraBars.BarButtonItem();
			this.btnImportarPedido = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtgPedidoSugerido = new DevExpress.XtraGrid.GridControl();
			this.gridViewPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
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
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnEliminarLinea = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidoSugerido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.dtpFecha, "", false, true, true, 152, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.txtUmbralExistencia, "", false, true, true, 196, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefrescar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuitarMensaje),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportarPedido)});
			this.bar1.Text = "Tools";
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
			// btnRefrescar
			// 
			this.btnRefrescar.Caption = "Cargar Datos";
			this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
			this.btnRefrescar.Id = 4;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
			// 
			// btnQuitarMensaje
			// 
			this.btnQuitarMensaje.Caption = "Quitar Elementos con Mensajes";
			this.btnQuitarMensaje.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuitarMensaje.Glyph")));
			this.btnQuitarMensaje.Id = 0;
			this.btnQuitarMensaje.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuitarMensaje.LargeGlyph")));
			this.btnQuitarMensaje.Name = "btnQuitarMensaje";
			this.btnQuitarMensaje.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuitarMensaje_ItemClick);
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
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(884, 47);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
			this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(884, 47);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Cargar Datos";
			this.barButtonItem1.Id = 3;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnEliminarLinea);
			this.layoutControl1.Controls.Add(this.dtgPedidoSugerido);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 47);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(884, 420);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtgPedidoSugerido
			// 
			this.dtgPedidoSugerido.Location = new System.Drawing.Point(12, 38);
			this.dtgPedidoSugerido.MainView = this.gridViewPedido;
			this.dtgPedidoSugerido.MenuManager = this.barManager1;
			this.dtgPedidoSugerido.Name = "dtgPedidoSugerido";
			this.dtgPedidoSugerido.Size = new System.Drawing.Size(860, 370);
			this.dtgPedidoSugerido.TabIndex = 0;
			this.dtgPedidoSugerido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedido});
			// 
			// gridViewPedido
			// 
			this.gridViewPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
			this.gridViewPedido.GridControl = this.dtgPedidoSugerido;
			this.gridViewPedido.Name = "gridViewPedido";
			this.gridViewPedido.OptionsBehavior.ReadOnly = true;
			this.gridViewPedido.OptionsView.ColumnAutoWidth = false;
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
			this.colDescrProducto.Width = 227;
			// 
			// colUndVentaTotal
			// 
			this.colUndVentaTotal.Caption = "UndVentaTotal";
			this.colUndVentaTotal.FieldName = "UndVentaTotal";
			this.colUndVentaTotal.Name = "colUndVentaTotal";
			this.colUndVentaTotal.Visible = true;
			this.colUndVentaTotal.VisibleIndex = 2;
			this.colUndVentaTotal.Width = 86;
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
			this.colCostoPromDolar.Width = 86;
			// 
			// colMontoOrden
			// 
			this.colMontoOrden.Caption = "MontoOrden";
			this.colMontoOrden.FieldName = "MontoOrden";
			this.colMontoOrden.Name = "colMontoOrden";
			this.colMontoOrden.Visible = true;
			this.colMontoOrden.VisibleIndex = 5;
			this.colMontoOrden.Width = 92;
			// 
			// colPrecioUnitCompra
			// 
			this.colPrecioUnitCompra.Caption = "PrecioUnitCompra";
			this.colPrecioUnitCompra.FieldName = "PrecioUnitCompra";
			this.colPrecioUnitCompra.Name = "colPrecioUnitCompra";
			this.colPrecioUnitCompra.Visible = true;
			this.colPrecioUnitCompra.VisibleIndex = 6;
			this.colPrecioUnitCompra.Width = 101;
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
			this.colMensaje.Width = 151;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(884, 420);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgPedidoSugerido;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(864, 374);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// btnEliminarLinea
			// 
			this.btnEliminarLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarLinea.Image")));
			this.btnEliminarLinea.Location = new System.Drawing.Point(800, 12);
			this.btnEliminarLinea.Name = "btnEliminarLinea";
			this.btnEliminarLinea.Size = new System.Drawing.Size(72, 22);
			this.btnEliminarLinea.StyleController = this.layoutControl1;
			this.btnEliminarLinea.TabIndex = 4;
			this.btnEliminarLinea.Text = "Eliminar";
			this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnEliminarLinea;
			this.layoutControlItem2.Location = new System.Drawing.Point(788, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(76, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(788, 26);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// frmPedidoSugerido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 467);
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
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidoSugerido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedido;
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
		private DevExpress.XtraEditors.SimpleButton btnEliminarLinea;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
	}
}