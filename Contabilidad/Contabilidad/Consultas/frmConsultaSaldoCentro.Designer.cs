namespace CG
{
    partial class frmConsultaSaldoCentro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSaldoCentro));
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			this.txtGridSaldoFinal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtpFechaFinal = new DevExpress.XtraEditors.DateEdit();
			this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
			this.grid = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtGridSaldoInicial = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtGridDebito = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtGridCredito = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
			this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dtpFechaInicial = new DevExpress.XtraEditors.DateEdit();
			this.slkupCuenta = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoFinal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoInicial)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridDebito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridCredito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCuenta.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// txtGridSaldoFinal
			// 
			this.txtGridSaldoFinal.AutoHeight = false;
			this.txtGridSaldoFinal.Name = "txtGridSaldoFinal";
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnCancelar,
            this.lblStatus,
            this.btnExportar,
            this.btnRefrescar});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 6;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(741, 143);
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
			// btnRefrescar
			// 
			this.btnRefrescar.Caption = "Refrescar";
			this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
			this.btnRefrescar.Id = 3;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
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
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExportar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Acciones";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtpFechaFinal);
			this.layoutControl1.Controls.Add(this.txtTipoCambio);
			this.layoutControl1.Controls.Add(this.grid);
			this.layoutControl1.Controls.Add(this.dtpFechaInicial);
			this.layoutControl1.Controls.Add(this.slkupCuenta);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 143);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(951, 182, 250, 350);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(741, 268);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtpFechaFinal
			// 
			this.dtpFechaFinal.EditValue = null;
			this.dtpFechaFinal.Location = new System.Drawing.Point(413, 63);
			this.dtpFechaFinal.MenuManager = this.ribbonControl;
			this.dtpFechaFinal.Name = "dtpFechaFinal";
			this.dtpFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Properties.CalendarTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
			this.dtpFechaFinal.Size = new System.Drawing.Size(139, 20);
			this.dtpFechaFinal.StyleController = this.layoutControl1;
			this.dtpFechaFinal.TabIndex = 14;
			this.dtpFechaFinal.EditValueChanged += new System.EventHandler(this.dtpFechaFinal_EditValueChanged);
			// 
			// txtTipoCambio
			// 
			this.txtTipoCambio.Location = new System.Drawing.Point(644, 63);
			this.txtTipoCambio.MenuManager = this.ribbonControl;
			this.txtTipoCambio.Name = "txtTipoCambio";
			this.txtTipoCambio.Properties.DisplayFormat.FormatString = "#,###,###,###.00$";
			this.txtTipoCambio.Properties.Mask.EditMask = "#,###,###,###.00$";
			this.txtTipoCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtTipoCambio.Properties.ReadOnly = true;
			this.txtTipoCambio.Size = new System.Drawing.Size(85, 20);
			this.txtTipoCambio.StyleController = this.layoutControl1;
			this.txtTipoCambio.TabIndex = 13;
			// 
			// grid
			// 
			this.grid.Location = new System.Drawing.Point(12, 109);
			this.grid.MainView = this.gridView1;
			this.grid.MenuManager = this.ribbonControl;
			this.grid.Name = "grid";
			this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtGridSaldoInicial,
            this.txtGridDebito,
            this.txtGridCredito,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.txtGridSaldoFinal});
			this.grid.Size = new System.Drawing.Size(717, 147);
			this.grid.TabIndex = 8;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CentroCosto,
            this.Descr});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.CentroCosto, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// CentroCosto
			// 
			this.CentroCosto.Caption = "Centro de Costo";
			this.CentroCosto.FieldName = "Centro";
			this.CentroCosto.Name = "CentroCosto";
			this.CentroCosto.OptionsColumn.AllowEdit = false;
			this.CentroCosto.OptionsColumn.AllowFocus = false;
			this.CentroCosto.OptionsColumn.ReadOnly = true;
			this.CentroCosto.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
			this.CentroCosto.Visible = true;
			this.CentroCosto.VisibleIndex = 0;
			this.CentroCosto.Width = 123;
			// 
			// Descr
			// 
			this.Descr.Caption = "Descripción";
			this.Descr.FieldName = "Descr";
			this.Descr.Name = "Descr";
			this.Descr.OptionsColumn.AllowFocus = false;
			this.Descr.Visible = true;
			this.Descr.VisibleIndex = 1;
			this.Descr.Width = 248;
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
			// repositoryItemCheckedComboBoxEdit1
			// 
			this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
			this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
			// 
			// repositoryItemGridLookUpEdit1
			// 
			this.repositoryItemGridLookUpEdit1.AutoHeight = false;
			this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
			this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
			// 
			// repositoryItemGridLookUpEdit1View
			// 
			this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
			this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// dtpFechaInicial
			// 
			this.dtpFechaInicial.EditValue = null;
			this.dtpFechaInicial.Location = new System.Drawing.Point(100, 63);
			this.dtpFechaInicial.MenuManager = this.ribbonControl;
			this.dtpFechaInicial.Name = "dtpFechaInicial";
			this.dtpFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.dtpFechaInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.dtpFechaInicial.Size = new System.Drawing.Size(192, 20);
			this.dtpFechaInicial.StyleController = this.layoutControl1;
			this.dtpFechaInicial.TabIndex = 5;
			// 
			// slkupCuenta
			// 
			this.slkupCuenta.Location = new System.Drawing.Point(100, 39);
			this.slkupCuenta.MenuManager = this.ribbonControl;
			this.slkupCuenta.Name = "slkupCuenta";
			this.slkupCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupCuenta.Properties.View = this.searchLookUpEdit1View;
			this.slkupCuenta.Size = new System.Drawing.Size(629, 20);
			this.slkupCuenta.StyleController = this.layoutControl1;
			this.slkupCuenta.TabIndex = 4;
			this.slkupCuenta.EditValueChanged += new System.EventHandler(this.slkupCuenta_EditValueChanged);
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
            this.layoutControlItem9,
            this.emptySpaceItem4,
            this.layoutControlItem3,
            this.emptySpaceItem5});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(741, 268);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.slkupCuenta;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 27);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(721, 24);
			this.layoutControlItem1.Text = "Cuenta Contable:";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.dtpFechaInicial;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 51);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(284, 24);
			this.layoutControlItem2.Text = "Periodo del:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.grid;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 97);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(721, 151);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 75);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 22);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 22);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(721, 22);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.txtTipoCambio;
			this.layoutControlItem9.Location = new System.Drawing.Point(544, 51);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(177, 24);
			this.layoutControlItem9.Text = "T/C:";
			this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutControlItem9.TextSize = new System.Drawing.Size(85, 13);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(284, 51);
			this.emptySpaceItem4.MaxSize = new System.Drawing.Size(29, 0);
			this.emptySpaceItem4.MinSize = new System.Drawing.Size(29, 10);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(29, 24);
			this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.dtpFechaFinal;
			this.layoutControlItem3.Location = new System.Drawing.Point(313, 51);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(231, 24);
			this.layoutControlItem3.Text = "Fecha Final";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.emptySpaceItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.emptySpaceItem5.AppearanceItemCaption.Options.UseFont = true;
			this.emptySpaceItem5.AppearanceItemCaption.Options.UseForeColor = true;
			this.emptySpaceItem5.AppearanceItemCaption.Options.UseTextOptions = true;
			this.emptySpaceItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.emptySpaceItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.emptySpaceItem5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(721, 27);
			this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
			this.emptySpaceItem5.Text = "Consulta de Saldo por Centros de Costos";
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(85, 0);
			this.emptySpaceItem5.TextVisible = true;
			// 
			// frmConsultaSaldoCentro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 411);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaSaldoCentro";
			this.Ribbon = this.ribbonControl;
			this.Text = "Consulta Saldo Centro";
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoFinal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridSaldoInicial)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridDebito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGridCredito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupCuenta.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.BarButtonItem btnExportar;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtpFechaInicial;
        private DevExpress.XtraEditors.SearchLookUpEdit slkupCuenta;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn CentroCosto;
		private DevExpress.XtraGrid.Columns.GridColumn Descr;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridSaldoInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridDebito;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridCredito;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGridSaldoFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dtpFechaFinal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}