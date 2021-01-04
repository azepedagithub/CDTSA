namespace Seguridad
{
	partial class frmListadoUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoUsuario));
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
			this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
			this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
			this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtNombre = new DevExpress.XtraEditors.TextEdit();
			this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
			this.dtgUsuarios = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.btnResetearPass = new DevExpress.XtraBars.BarButtonItem();
			this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnCancelar,
            this.lblStatus,
            this.btnExportar,
            this.btnRefrescar,
            this.btnAgregar,
            this.btnEditar,
            this.btnGuardar,
            this.btnEliminar,
            this.btnResetearPass});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 10;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(832, 143);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Caption = "Cancelar";
			this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
			this.btnCancelar.Id = 4;
			this.btnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.LargeGlyph")));
			this.btnCancelar.Name = "btnCancelar";
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
			this.btnRefrescar.Id = 4;
			this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
			this.btnRefrescar.Name = "btnRefrescar";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Caption = "Agregar";
			this.btnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Glyph")));
			this.btnAgregar.Id = 5;
			this.btnAgregar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAgregar.LargeGlyph")));
			this.btnAgregar.Name = "btnAgregar";
			// 
			// btnEditar
			// 
			this.btnEditar.Caption = "Editar";
			this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
			this.btnEditar.Id = 6;
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
			// btnEliminar
			// 
			this.btnEliminar.Caption = "Eliminar";
			this.btnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Glyph")));
			this.btnEliminar.Id = 8;
			this.btnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.LargeGlyph")));
			this.btnEliminar.Name = "btnEliminar";
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
			this.ribbonPageGroup1.ItemLinks.Add(this.btnResetearPass);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Acciones";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.chkActivo);
			this.layoutControl1.Controls.Add(this.txtPassword);
			this.layoutControl1.Controls.Add(this.txtNombre);
			this.layoutControl1.Controls.Add(this.txtUsuario);
			this.layoutControl1.Controls.Add(this.dtgUsuarios);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 143);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(870, 202, 250, 350);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(832, 498);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// chkActivo
			// 
			this.chkActivo.Location = new System.Drawing.Point(707, 42);
			this.chkActivo.MenuManager = this.ribbonControl;
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Properties.Caption = "Activo";
			this.chkActivo.Size = new System.Drawing.Size(101, 19);
			this.chkActivo.StyleController = this.layoutControl1;
			this.chkActivo.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(77, 90);
			this.txtPassword.MenuManager = this.ribbonControl;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(731, 20);
			this.txtPassword.StyleController = this.layoutControl1;
			this.txtPassword.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(77, 66);
			this.txtNombre.MenuManager = this.ribbonControl;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(731, 20);
			this.txtNombre.StyleController = this.layoutControl1;
			this.txtNombre.TabIndex = 1;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(77, 42);
			this.txtUsuario.MenuManager = this.ribbonControl;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(626, 20);
			this.txtUsuario.StyleController = this.layoutControl1;
			this.txtUsuario.TabIndex = 0;
			// 
			// dtgUsuarios
			// 
			this.dtgUsuarios.Location = new System.Drawing.Point(12, 145);
			this.dtgUsuarios.MainView = this.gridView1;
			this.dtgUsuarios.MenuManager = this.ribbonControl;
			this.dtgUsuarios.Name = "dtgUsuarios";
			this.dtgUsuarios.Size = new System.Drawing.Size(808, 341);
			this.dtgUsuarios.TabIndex = 4;
			this.dtgUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuario,
            this.colNombre,
            this.colActivo});
			this.gridView1.GridControl = this.dtgUsuarios;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(832, 498);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgUsuarios;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 133);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(812, 345);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(812, 114);
			this.layoutControlGroup2.Text = "Datos del Usuario:";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtUsuario;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(683, 24);
			this.layoutControlItem2.Text = "Usuario:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtNombre;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(788, 24);
			this.layoutControlItem3.Text = "Nombre:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtPassword;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(788, 24);
			this.layoutControlItem4.Text = "Password:";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.chkActivo;
			this.layoutControlItem6.Location = new System.Drawing.Point(683, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(105, 24);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 19);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 19);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(812, 19);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// btnResetearPass
			// 
			this.btnResetearPass.Caption = "Resetear Contraseña";
			this.btnResetearPass.Glyph = ((System.Drawing.Image)(resources.GetObject("btnResetearPass.Glyph")));
			this.btnResetearPass.Id = 9;
			this.btnResetearPass.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnResetearPass.LargeGlyph")));
			this.btnResetearPass.Name = "btnResetearPass";
			this.btnResetearPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetearPass_ItemClick);
			// 
			// colUsuario
			// 
			this.colUsuario.Caption = "Usuario";
			this.colUsuario.FieldName = "USUARIO";
			this.colUsuario.Name = "colUsuario";
			this.colUsuario.Visible = true;
			this.colUsuario.VisibleIndex = 0;
			this.colUsuario.Width = 106;
			// 
			// colNombre
			// 
			this.colNombre.Caption = "Nombre";
			this.colNombre.FieldName = "DESCR";
			this.colNombre.Name = "colNombre";
			this.colNombre.Visible = true;
			this.colNombre.VisibleIndex = 1;
			this.colNombre.Width = 616;
			// 
			// colActivo
			// 
			this.colActivo.Caption = "Activo";
			this.colActivo.FieldName = "ACTIVO";
			this.colActivo.Name = "colActivo";
			this.colActivo.Visible = true;
			this.colActivo.VisibleIndex = 2;
			this.colActivo.Width = 68;
			// 
			// frmListadoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 641);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "frmListadoUsuario";
			this.Ribbon = this.ribbonControl;
			this.Text = "Listado de Usuarios";
			this.Load += new System.EventHandler(this.frmCatalogoUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem btnAgregar;
		private DevExpress.XtraBars.BarButtonItem btnEditar;
		private DevExpress.XtraBars.BarButtonItem btnGuardar;
		private DevExpress.XtraBars.BarButtonItem btnEliminar;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraEditors.TextEdit txtNombre;
		private DevExpress.XtraEditors.TextEdit txtUsuario;
		private DevExpress.XtraGrid.GridControl dtgUsuarios;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraEditors.CheckEdit chkActivo;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraBars.BarButtonItem btnResetearPass;
		private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
		private DevExpress.XtraGrid.Columns.GridColumn colNombre;
		private DevExpress.XtraGrid.Columns.GridColumn colActivo;
	}
}