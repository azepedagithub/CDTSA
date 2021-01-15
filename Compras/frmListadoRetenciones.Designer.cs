namespace CO
{
	partial class frmListadoRetenciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoRetenciones));
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
			this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtgRetenciones = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
			this.txtMontoMinimo = new DevExpress.XtraEditors.TextEdit();
			this.slkupCuentaRetencion = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.slkupCentroRetencion = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.rdgComportamiento = new DevExpress.XtraEditors.RadioGroup();
			this.txtDescr = new DevExpress.XtraEditors.TextEdit();
			this.txtPorcentaje = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgRetenciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMontoMinimo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCuentaRetencion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCentroRetencion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rdgComportamiento.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnCancelar,
            this.btnEliminar,
            this.lblStatus,
            this.btnExportar,
            this.btnRefrescar,
            this.btnAgregar,
            this.btnEditar,
            this.btnGuardar});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 8;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(803, 143);
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
			// btnAgregar
			// 
			this.btnAgregar.Caption = "Agregar";
			this.btnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Glyph")));
			this.btnAgregar.Id = 4;
			this.btnAgregar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.LargeGlyph")));
			this.btnAgregar.Name = "btnAgregar";
			// 
			// btnEditar
			// 
			this.btnEditar.Caption = "Editar";
			this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
			this.btnEditar.Id = 5;
			this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
			this.btnEditar.Name = "btnEditar";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Caption = "Guardar";
			this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
			this.btnGuardar.Id = 7;
			this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
			this.btnGuardar.Name = "btnGuardar";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Operaciones";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAgregar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnGuardar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExportar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Acciones";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtgRetenciones);
			this.layoutControl1.Controls.Add(this.chkActivo);
			this.layoutControl1.Controls.Add(this.txtMontoMinimo);
			this.layoutControl1.Controls.Add(this.slkupCuentaRetencion);
			this.layoutControl1.Controls.Add(this.slkupCentroRetencion);
			this.layoutControl1.Controls.Add(this.rdgComportamiento);
			this.layoutControl1.Controls.Add(this.txtDescr);
			this.layoutControl1.Controls.Add(this.txtPorcentaje);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 143);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(977, 336, 473, 674);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(803, 441);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtgRetenciones
			// 
			this.dtgRetenciones.Location = new System.Drawing.Point(12, 173);
			this.dtgRetenciones.MainView = this.gridView1;
			this.dtgRetenciones.MenuManager = this.ribbonControl;
			this.dtgRetenciones.Name = "dtgRetenciones";
			this.dtgRetenciones.Size = new System.Drawing.Size(779, 256);
			this.dtgRetenciones.TabIndex = 7;
			this.dtgRetenciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.dtgRetenciones;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// chkActivo
			// 
			this.chkActivo.Location = new System.Drawing.Point(706, 42);
			this.chkActivo.MenuManager = this.ribbonControl;
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Properties.Caption = "Activo";
			this.chkActivo.Size = new System.Drawing.Size(73, 19);
			this.chkActivo.StyleController = this.layoutControl1;
			this.chkActivo.TabIndex = 1;
			// 
			// txtMontoMinimo
			// 
			this.txtMontoMinimo.Location = new System.Drawing.Point(491, 66);
			this.txtMontoMinimo.MenuManager = this.ribbonControl;
			this.txtMontoMinimo.Name = "txtMontoMinimo";
			this.txtMontoMinimo.Properties.Mask.EditMask = "f";
			this.txtMontoMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtMontoMinimo.Size = new System.Drawing.Size(288, 20);
			this.txtMontoMinimo.StyleController = this.layoutControl1;
			this.txtMontoMinimo.TabIndex = 3;
			// 
			// slkupCuentaRetencion
			// 
			this.slkupCuentaRetencion.Location = new System.Drawing.Point(491, 119);
			this.slkupCuentaRetencion.MenuManager = this.ribbonControl;
			this.slkupCuentaRetencion.Name = "slkupCuentaRetencion";
			this.slkupCuentaRetencion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupCuentaRetencion.Properties.View = this.searchLookUpEdit2View;
			this.slkupCuentaRetencion.Size = new System.Drawing.Size(288, 20);
			this.slkupCuentaRetencion.StyleController = this.layoutControl1;
			this.slkupCuentaRetencion.TabIndex = 6;
			// 
			// searchLookUpEdit2View
			// 
			this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
			this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// slkupCentroRetencion
			// 
			this.slkupCentroRetencion.Location = new System.Drawing.Point(112, 119);
			this.slkupCentroRetencion.MenuManager = this.ribbonControl;
			this.slkupCentroRetencion.Name = "slkupCentroRetencion";
			this.slkupCentroRetencion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupCentroRetencion.Properties.View = this.searchLookUpEdit1View;
			this.slkupCentroRetencion.Size = new System.Drawing.Size(287, 20);
			this.slkupCentroRetencion.StyleController = this.layoutControl1;
			this.slkupCentroRetencion.TabIndex = 5;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// rdgComportamiento
			// 
			this.rdgComportamiento.Location = new System.Drawing.Point(112, 90);
			this.rdgComportamiento.MenuManager = this.ribbonControl;
			this.rdgComportamiento.Name = "rdgComportamiento";
			this.rdgComportamiento.Properties.Columns = 3;
			this.rdgComportamiento.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Aplica Total Factura"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Aplica Sub Total"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Aplica Sub Total Menos Desc")});
			this.rdgComportamiento.Size = new System.Drawing.Size(667, 25);
			this.rdgComportamiento.StyleController = this.layoutControl1;
			this.rdgComportamiento.TabIndex = 4;
			// 
			// txtDescr
			// 
			this.txtDescr.Location = new System.Drawing.Point(112, 42);
			this.txtDescr.MenuManager = this.ribbonControl;
			this.txtDescr.Name = "txtDescr";
			this.txtDescr.Size = new System.Drawing.Size(590, 20);
			this.txtDescr.StyleController = this.layoutControl1;
			this.txtDescr.TabIndex = 0;
			// 
			// txtPorcentaje
			// 
			this.txtPorcentaje.Location = new System.Drawing.Point(112, 66);
			this.txtPorcentaje.MenuManager = this.ribbonControl;
			this.txtPorcentaje.Name = "txtPorcentaje";
			this.txtPorcentaje.Properties.Mask.EditMask = "P";
			this.txtPorcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPorcentaje.Size = new System.Drawing.Size(287, 20);
			this.txtPorcentaje.StyleController = this.layoutControl1;
			this.txtPorcentaje.TabIndex = 2;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem8,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(803, 441);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(783, 143);
			this.layoutControlGroup2.Text = "Datos de Retenciones";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtDescr;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(682, 24);
			this.layoutControlItem2.Text = "Descripción:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.chkActivo;
			this.layoutControlItem7.Location = new System.Drawing.Point(682, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(77, 24);
			this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtPorcentaje;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(379, 24);
			this.layoutControlItem1.Text = "Porcentaje:";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.rdgComportamiento;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 29);
			this.layoutControlItem3.MinSize = new System.Drawing.Size(151, 29);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(759, 29);
			this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem3.Text = "Comportamiento:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.slkupCentroRetencion;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 77);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(379, 24);
			this.layoutControlItem4.Text = "Centro Costo:";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.slkupCuentaRetencion;
			this.layoutControlItem5.Location = new System.Drawing.Point(379, 77);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(380, 24);
			this.layoutControlItem5.Text = "Cuenta Contable:";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtMontoMinimo;
			this.layoutControlItem6.Location = new System.Drawing.Point(379, 24);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(380, 24);
			this.layoutControlItem6.Text = "Monto Mínimo:";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.dtgRetenciones;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 161);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(783, 260);
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 143);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 18);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 18);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(783, 18);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// frmListadoRetenciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 584);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "frmListadoRetenciones";
			this.Ribbon = this.ribbonControl;
			this.Text = "Listado de Retenciones";
			this.Load += new System.EventHandler(this.frmListadoRetenciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgRetenciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMontoMinimo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCuentaRetencion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCentroRetencion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rdgComportamiento.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.BarButtonItem btnCancelar;
		private DevExpress.XtraBars.BarButtonItem btnEliminar;
		private DevExpress.XtraBars.BarStaticItem lblStatus;
		private DevExpress.XtraBars.BarButtonItem btnExportar;
		private DevExpress.XtraBars.BarButtonItem btnRefrescar;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem btnAgregar;
		private DevExpress.XtraBars.BarButtonItem btnEditar;
		private DevExpress.XtraBars.BarButtonItem btnGuardar;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl dtgRetenciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.CheckEdit chkActivo;
		private DevExpress.XtraEditors.TextEdit txtMontoMinimo;
		private DevExpress.XtraEditors.SearchLookUpEdit slkupCuentaRetencion;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
		private DevExpress.XtraEditors.SearchLookUpEdit slkupCentroRetencion;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraEditors.RadioGroup rdgComportamiento;
		private DevExpress.XtraEditors.TextEdit txtDescr;
		private DevExpress.XtraEditors.TextEdit txtPorcentaje;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
	}
}