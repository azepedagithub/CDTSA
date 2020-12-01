namespace ControlBancario
{
	partial class frmListadoConciliacionesBancarias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoConciliacionesBancarias));
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtpFechaFinal = new DevExpress.XtraEditors.DateEdit();
			this.dtpFechaInicial = new DevExpress.XtraEditors.DateEdit();
			this.dtgConciliaciones = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIDConciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescrCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoFinalBanco = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoFinalLibro = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgConciliaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnAgregar,
            this.btnEditar,
            this.btnCancelar,
            this.btnEliminar,
            this.lblStatus,
            this.btnExportar,
            this.btnRefrescar});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 4;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(648, 143);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Caption = "Agregar";
			this.btnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Glyph")));
			this.btnAgregar.Id = 1;
			this.btnAgregar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.LargeGlyph")));
			this.btnAgregar.Name = "btnAgregar";
			// 
			// btnEditar
			// 
			this.btnEditar.Caption = "Editar";
			this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
			this.btnEditar.Id = 2;
			this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
			this.btnEditar.Name = "btnEditar";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Caption = "Cancelar";
			this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
			this.btnCancelar.Id = 4;
			this.btnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.LargeGlyph")));
			this.btnCancelar.Name = "btnCancelar";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Caption = "Eliminar";
			this.btnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Glyph")));
			this.btnEliminar.Id = 5;
			this.btnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.LargeGlyph")));
			this.btnEliminar.Name = "btnEliminar";
			// 
			// lblStatus
			// 
			this.lblStatus.Id = 1;
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// btnExportar
			// 
			this.btnExportar.Caption = "Exportar";
			this.btnExportar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportar.Glyph")));
			this.btnExportar.Id = 2;
			this.btnExportar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportar.LargeGlyph")));
			this.btnExportar.Name = "btnExportar";
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Caption = "Refrescar";
			this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
			this.btnRefrescar.Id = 3;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Opciones de Conciliaciones";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAgregar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExportar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Acciones";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtpFechaFinal);
			this.layoutControl1.Controls.Add(this.dtpFechaInicial);
			this.layoutControl1.Controls.Add(this.dtgConciliaciones);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 143);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(648, 298);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtpFechaFinal
			// 
			this.dtpFechaFinal.EditValue = null;
			this.dtpFechaFinal.Location = new System.Drawing.Point(392, 12);
			this.dtpFechaFinal.MenuManager = this.ribbonControl;
			this.dtpFechaFinal.Name = "dtpFechaFinal";
			this.dtpFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Size = new System.Drawing.Size(244, 20);
			this.dtpFechaFinal.StyleController = this.layoutControl1;
			this.dtpFechaFinal.TabIndex = 9;
			// 
			// dtpFechaInicial
			// 
			this.dtpFechaInicial.EditValue = null;
			this.dtpFechaInicial.Location = new System.Drawing.Point(78, 12);
			this.dtpFechaInicial.MenuManager = this.ribbonControl;
			this.dtpFechaInicial.Name = "dtpFechaInicial";
			this.dtpFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Size = new System.Drawing.Size(244, 20);
			this.dtpFechaInicial.StyleController = this.layoutControl1;
			this.dtpFechaInicial.TabIndex = 8;
			// 
			// dtgConciliaciones
			// 
			this.dtgConciliaciones.Location = new System.Drawing.Point(12, 36);
			this.dtgConciliaciones.MainView = this.gridView1;
			this.dtgConciliaciones.MenuManager = this.ribbonControl;
			this.dtgConciliaciones.Name = "dtgConciliaciones";
			this.dtgConciliaciones.Size = new System.Drawing.Size(624, 250);
			this.dtgConciliaciones.TabIndex = 7;
			this.dtgConciliaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDConciliacion,
            this.colDescrCuenta,
            this.colSaldoFinalBanco,
            this.colSaldoFinalLibro,
            this.colUsuario,
            this.colEstado});
			this.gridView1.GridControl = this.dtgConciliaciones;
			this.gridView1.Name = "gridView1";
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// colIDConciliacion
			// 
			this.colIDConciliacion.Caption = "ID";
			this.colIDConciliacion.FieldName = "IDConciliacion";
			this.colIDConciliacion.Name = "colIDConciliacion";
			this.colIDConciliacion.Visible = true;
			this.colIDConciliacion.VisibleIndex = 0;
			// 
			// colDescrCuenta
			// 
			this.colDescrCuenta.Caption = "Cuenta Bancaria";
			this.colDescrCuenta.FieldName = "DescrCuenta";
			this.colDescrCuenta.Name = "colDescrCuenta";
			this.colDescrCuenta.Visible = true;
			this.colDescrCuenta.VisibleIndex = 1;
			// 
			// colSaldoFinalBanco
			// 
			this.colSaldoFinalBanco.Caption = "Saldo Final Banco";
			this.colSaldoFinalBanco.FieldName = "SaldoFinalBanco";
			this.colSaldoFinalBanco.Name = "colSaldoFinalBanco";
			this.colSaldoFinalBanco.Visible = true;
			this.colSaldoFinalBanco.VisibleIndex = 2;
			// 
			// colSaldoFinalLibro
			// 
			this.colSaldoFinalLibro.Caption = "Saldo Final Libro";
			this.colSaldoFinalLibro.FieldName = "SaldoFinalLibro";
			this.colSaldoFinalLibro.Name = "colSaldoFinalLibro";
			this.colSaldoFinalLibro.Visible = true;
			this.colSaldoFinalLibro.VisibleIndex = 3;
			// 
			// colUsuario
			// 
			this.colUsuario.Caption = "Usuario";
			this.colUsuario.FieldName = "Usuario";
			this.colUsuario.Name = "colUsuario";
			this.colUsuario.Visible = true;
			this.colUsuario.VisibleIndex = 4;
			// 
			// colEstado
			// 
			this.colEstado.Caption = "Estado";
			this.colEstado.FieldName = "Estado";
			this.colEstado.Name = "colEstado";
			this.colEstado.Visible = true;
			this.colEstado.VisibleIndex = 5;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(648, 298);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgConciliaciones;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(628, 254);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.dtpFechaInicial;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(314, 24);
			this.layoutControlItem2.Text = "Fecha Inicial:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.dtpFechaFinal;
			this.layoutControlItem3.Location = new System.Drawing.Point(314, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(314, 24);
			this.layoutControlItem3.Text = "Fecha Final:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
			// 
			// frmListadoConciliacionesBancarias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 441);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "frmListadoConciliacionesBancarias";
			this.Ribbon = this.ribbonControl;
			this.Text = "frmListadoConciliacionesBancarias";
			this.Load += new System.EventHandler(this.frmListadoConciliacionesBancarias_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgConciliaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.BarButtonItem btnAgregar;
		private DevExpress.XtraBars.BarButtonItem btnEditar;
		private DevExpress.XtraBars.BarButtonItem btnCancelar;
		private DevExpress.XtraBars.BarButtonItem btnEliminar;
		private DevExpress.XtraBars.BarStaticItem lblStatus;
		private DevExpress.XtraBars.BarButtonItem btnExportar;
		private DevExpress.XtraBars.BarButtonItem btnRefrescar;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl dtgConciliaciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.DateEdit dtpFechaFinal;
		private DevExpress.XtraEditors.DateEdit dtpFechaInicial;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.Columns.GridColumn colIDConciliacion;
		private DevExpress.XtraGrid.Columns.GridColumn colDescrCuenta;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoFinalBanco;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoFinalLibro;
		private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
		private DevExpress.XtraGrid.Columns.GridColumn colEstado;
	}
}