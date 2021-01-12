namespace CG
{
    partial class frmConsultaSaldoCuenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSaldoCuenta));
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			this.txtGridSaldoFinal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtHasta = new DevExpress.XtraEditors.DateEdit();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.txtTasaCambio = new DevExpress.XtraEditors.TextEdit();
			this.grid = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtGridSaldoInicial = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtGridDebito = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtGridCredito = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.dtDesde = new DevExpress.XtraEditors.DateEdit();
			this.slkupCentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoFinal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoInicial)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridDebito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridCredito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCentroCosto.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtGridSaldoFinal
			// 
			this.txtGridSaldoFinal.AutoHeight = false;
			this.txtGridSaldoFinal.Name = "txtGridSaldoFinal";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtHasta);
			this.layoutControl1.Controls.Add(this.txtTasaCambio);
			this.layoutControl1.Controls.Add(this.grid);
			this.layoutControl1.Controls.Add(this.dtDesde);
			this.layoutControl1.Controls.Add(this.slkupCentroCosto);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 143);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(576, 208, 387, 405);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(864, 277);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtHasta
			// 
			this.dtHasta.EditValue = null;
			this.dtHasta.Location = new System.Drawing.Point(333, 64);
			this.dtHasta.MenuManager = this.ribbonControl;
			this.dtHasta.Name = "dtHasta";
			this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtHasta.Size = new System.Drawing.Size(144, 20);
			this.dtHasta.StyleController = this.layoutControl1;
			this.dtHasta.TabIndex = 15;
			this.dtHasta.EditValueChanged += new System.EventHandler(this.dtHasta_EditValueChanged);
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnCancelar,
            this.lblStatus,
            this.btnExportar,
            this.barButtonItem3,
            this.barButtonItem1});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 10;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(864, 143);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Caption = "Cancelar";
			this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
			this.btnCancelar.Id = 4;
			this.btnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.LargeGlyph")));
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
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
			this.btnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportar_ItemClick);
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Imprimir";
			this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
			this.barButtonItem3.Id = 6;
			this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Id = 9;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Operaciones Consulta de Saldo Cuenta";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExportar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Acciones";
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Caption = "Refrescar";
			this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
			this.btnRefrescar.Id = 3;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
			// 
			// txtTasaCambio
			// 
			this.txtTasaCambio.Location = new System.Drawing.Point(763, 64);
			this.txtTasaCambio.MenuManager = this.ribbonControl;
			this.txtTasaCambio.Name = "txtTasaCambio";
			this.txtTasaCambio.Properties.DisplayFormat.FormatString = "#,###,###,###.00$";
			this.txtTasaCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTasaCambio.Properties.Mask.BeepOnError = true;
			this.txtTasaCambio.Properties.Mask.EditMask = "#,###,###,###.00$";
			this.txtTasaCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtTasaCambio.Properties.ReadOnly = true;
			this.txtTasaCambio.Size = new System.Drawing.Size(89, 20);
			this.txtTasaCambio.StyleController = this.layoutControl1;
			this.txtTasaCambio.TabIndex = 14;
			// 
			// grid
			// 
			this.grid.Location = new System.Drawing.Point(12, 107);
			this.grid.MainView = this.gridView1;
			this.grid.Name = "grid";
			this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtGridSaldoInicial,
            this.txtGridDebito,
            this.txtGridCredito,
            this.txtGridSaldoFinal});
			this.grid.Size = new System.Drawing.Size(840, 158);
			this.grid.TabIndex = 8;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cuenta,
            this.Descripcion});
			gridFormatRule1.Name = "SaldoFinalNegativo";
			formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less;
			formatConditionRuleValue1.Value1 = 0D;
			gridFormatRule1.Rule = formatConditionRuleValue1;
			this.gridView1.FormatRules.Add(gridFormatRule1);
			this.gridView1.GridControl = this.grid;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Cuenta, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// Cuenta
			// 
			this.Cuenta.Caption = "Cuenta";
			this.Cuenta.FieldName = "Cuenta";
			this.Cuenta.Name = "Cuenta";
			this.Cuenta.OptionsColumn.AllowFocus = false;
			this.Cuenta.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
			this.Cuenta.Visible = true;
			this.Cuenta.VisibleIndex = 0;
			// 
			// Descripcion
			// 
			this.Descripcion.Caption = "Descripcion";
			this.Descripcion.FieldName = "Descr";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.OptionsColumn.AllowFocus = false;
			this.Descripcion.Visible = true;
			this.Descripcion.VisibleIndex = 1;
			// 
			// txtGridSaldoInicial
			// 
			this.txtGridSaldoInicial.AutoHeight = false;
			this.txtGridSaldoInicial.Name = "txtGridSaldoInicial";
			// 
			// txtGridDebito
			// 
			this.txtGridDebito.AutoHeight = false;
			this.txtGridDebito.Name = "txtGridDebito";
			// 
			// txtGridCredito
			// 
			this.txtGridCredito.AutoHeight = false;
			this.txtGridCredito.Name = "txtGridCredito";
			// 
			// dtDesde
			// 
			this.dtDesde.EditValue = null;
			this.dtDesde.Location = new System.Drawing.Point(79, 64);
			this.dtDesde.Name = "dtDesde";
			this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDesde.Properties.CalendarTimeProperties.Mask.EditMask = "d";
			this.dtDesde.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.dtDesde.Size = new System.Drawing.Size(183, 20);
			this.dtDesde.StyleController = this.layoutControl1;
			this.dtDesde.TabIndex = 5;
			// 
			// slkupCentroCosto
			// 
			this.slkupCentroCosto.Location = new System.Drawing.Point(79, 40);
			this.slkupCentroCosto.Name = "slkupCentroCosto";
			this.slkupCentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupCentroCosto.Properties.View = this.searchLookUpEdit1View;
			this.slkupCentroCosto.Size = new System.Drawing.Size(773, 20);
			this.slkupCentroCosto.StyleController = this.layoutControl1;
			this.slkupCentroCosto.TabIndex = 4;
			this.slkupCentroCosto.EditValueChanged += new System.EventHandler(this.slkupCentroCosto_EditValueChanged);
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem3});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(864, 277);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.slkupCentroCosto;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(844, 24);
			this.layoutControlItem1.Text = "Centro Costo";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.dtDesde;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(254, 24);
			this.layoutControlItem2.Text = "Desde :";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.grid;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 95);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(844, 162);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 76);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 19);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 19);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(844, 19);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(469, 52);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(215, 24);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtTasaCambio;
			this.layoutControlItem4.Location = new System.Drawing.Point(684, 52);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(160, 24);
			this.layoutControlItem4.Text = "T/C:";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.dtHasta;
			this.layoutControlItem3.Location = new System.Drawing.Point(254, 52);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(215, 24);
			this.layoutControlItem3.Text = "Hasta: ";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.emptySpaceItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
			this.emptySpaceItem3.AppearanceItemCaption.Options.UseFont = true;
			this.emptySpaceItem3.AppearanceItemCaption.Options.UseForeColor = true;
			this.emptySpaceItem3.AppearanceItemCaption.Options.UseTextOptions = true;
			this.emptySpaceItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(844, 28);
			this.emptySpaceItem3.Text = "Consulta de Saldo por Cuenta Contable";
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(64, 0);
			this.emptySpaceItem3.TextVisible = true;
			// 
			// frmConsultaSaldoCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 420);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaSaldoCuenta";
			this.Ribbon = this.ribbonControl;
			this.Text = "Consulta de Saldos de Cuentas";
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoFinal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoInicial)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridDebito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridCredito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCentroCosto.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SearchLookUpEdit slkupCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn Cuenta;
		private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraEditors.TextEdit txtTasaCambio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridSaldoInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridDebito;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridCredito;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridSaldoFinal;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}