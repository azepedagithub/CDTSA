namespace Seguridad
{
	partial class frmRoles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
			this.dtgAcciones = new DevExpress.XtraGrid.GridControl();
			this.gridViewAcciones = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colModulo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescrLarga = new DevExpress.XtraEditors.TextEdit();
			this.txtDescr = new DevExpress.XtraEditors.TextEdit();
			this.dtgRoles = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.barManager1 = new DevExpress.XtraBars.BarManager();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)(this.dtgAcciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAcciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDescrLarga.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgAcciones
			// 
			this.dtgAcciones.Location = new System.Drawing.Point(362, 12);
			this.dtgAcciones.MainView = this.gridViewAcciones;
			this.dtgAcciones.Name = "dtgAcciones";
			this.dtgAcciones.Size = new System.Drawing.Size(517, 333);
			this.dtgAcciones.TabIndex = 0;
			this.dtgAcciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAcciones});
			// 
			// gridViewAcciones
			// 
			this.gridViewAcciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModulo,
            this.colAccion});
			this.gridViewAcciones.GridControl = this.dtgAcciones;
			this.gridViewAcciones.GroupCount = 1;
			this.gridViewAcciones.Name = "gridViewAcciones";
			this.gridViewAcciones.OptionsSelection.MultiSelect = true;
			this.gridViewAcciones.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			this.gridViewAcciones.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
			this.gridViewAcciones.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colModulo, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridViewAcciones.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAcciones_CellValueChanging);
			// 
			// colModulo
			// 
			this.colModulo.Caption = "Módulo";
			this.colModulo.FieldName = "DescrModulo";
			this.colModulo.Name = "colModulo";
			this.colModulo.Visible = true;
			this.colModulo.VisibleIndex = 0;
			// 
			// colAccion
			// 
			this.colAccion.Caption = "Acción";
			this.colAccion.FieldName = "DescrAccion";
			this.colAccion.Name = "colAccion";
			this.colAccion.Visible = true;
			this.colAccion.VisibleIndex = 1;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.label1);
			this.layoutControl1.Controls.Add(this.txtDescrLarga);
			this.layoutControl1.Controls.Add(this.txtDescr);
			this.layoutControl1.Controls.Add(this.dtgRoles);
			this.layoutControl1.Controls.Add(this.dtgAcciones);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 31);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(549, 236, 250, 350);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(891, 357);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Listado de Roles";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDescrLarga
			// 
			this.txtDescrLarga.Location = new System.Drawing.Point(103, 36);
			this.txtDescrLarga.Name = "txtDescrLarga";
			this.txtDescrLarga.Size = new System.Drawing.Size(255, 20);
			this.txtDescrLarga.StyleController = this.layoutControl1;
			this.txtDescrLarga.TabIndex = 6;
			// 
			// txtDescr
			// 
			this.txtDescr.Location = new System.Drawing.Point(103, 12);
			this.txtDescr.Name = "txtDescr";
			this.txtDescr.Size = new System.Drawing.Size(255, 20);
			this.txtDescr.StyleController = this.layoutControl1;
			this.txtDescr.TabIndex = 5;
			// 
			// dtgRoles
			// 
			this.dtgRoles.Location = new System.Drawing.Point(12, 84);
			this.dtgRoles.MainView = this.gridView2;
			this.dtgRoles.Name = "dtgRoles";
			this.dtgRoles.Size = new System.Drawing.Size(346, 261);
			this.dtgRoles.TabIndex = 4;
			this.dtgRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.dtgRoles;
			this.gridView2.Name = "gridView2";
			this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(891, 357);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgAcciones;
			this.layoutControlItem1.Location = new System.Drawing.Point(350, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(521, 337);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.dtgRoles;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(350, 265);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtDescr;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(350, 24);
			this.layoutControlItem3.Text = "Descripción:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtDescrLarga;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(350, 24);
			this.layoutControlItem4.Text = "Descripción Larga:";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.label1;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(350, 24);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
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
            this.btnAdd,
            this.btnCancelar,
            this.btnGuardar,
            this.btnDelete,
            this.btnEdit});
			this.barManager1.MaxItemId = 5;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar)});
			this.bar1.OptionsBar.AllowQuickCustomization = false;
			this.bar1.Text = "Tools";
			// 
			// btnAdd
			// 
			this.btnAdd.Caption = "Agregar";
			this.btnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.Glyph")));
			this.btnAdd.Id = 0;
			this.btnAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.LargeGlyph")));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Editar";
			this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
			this.btnEdit.Id = 4;
			this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Eliminar";
			this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
			this.btnDelete.Id = 3;
			this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Caption = "Cancelar";
			this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
			this.btnCancelar.Id = 1;
			this.btnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.LargeGlyph")));
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Caption = "Guardar";
			this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
			this.btnGuardar.Id = 2;
			this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
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
			this.barDockControlTop.Size = new System.Drawing.Size(891, 31);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
			this.barDockControlBottom.Size = new System.Drawing.Size(891, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 357);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(891, 31);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 357);
			// 
			// frmRoles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 411);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frmRoles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listado de Roles";
			this.Load += new System.EventHandler(this.frmRoles_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgAcciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAcciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtDescrLarga.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl dtgAcciones;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewAcciones;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl dtgRoles;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraGrid.Columns.GridColumn colModulo;
		private DevExpress.XtraGrid.Columns.GridColumn colAccion;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtDescrLarga;
		private DevExpress.XtraEditors.TextEdit txtDescr;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem btnAdd;
		private DevExpress.XtraBars.BarButtonItem btnEdit;
		private DevExpress.XtraBars.BarButtonItem btnDelete;
		private DevExpress.XtraBars.BarButtonItem btnCancelar;
		private DevExpress.XtraBars.BarButtonItem btnGuardar;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}