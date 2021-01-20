namespace CI
{
	partial class frmUsuarioBodega
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioBodega));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
			this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
			this.dtgUsuariosSeleccionados = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dtgUsuarios = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.txtCodBodega = new DevExpress.XtraEditors.TextEdit();
			this.txtDescrBodega = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUsuarioAll = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescAll = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuariosSeleccionados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodBodega.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescrBodega.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnAgregar);
			this.layoutControl1.Controls.Add(this.btnQuitar);
			this.layoutControl1.Controls.Add(this.dtgUsuariosSeleccionados);
			this.layoutControl1.Controls.Add(this.dtgUsuarios);
			this.layoutControl1.Controls.Add(this.txtCodBodega);
			this.layoutControl1.Controls.Add(this.txtDescrBodega);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1121, 225, 239, 350);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(737, 534);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.btnAgregar.Location = new System.Drawing.Point(319, 247);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(83, 38);
			this.btnAgregar.StyleController = this.layoutControl1;
			this.btnAgregar.TabIndex = 13;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
			this.btnQuitar.Location = new System.Drawing.Point(319, 289);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(83, 38);
			this.btnQuitar.StyleController = this.layoutControl1;
			this.btnQuitar.TabIndex = 12;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// dtgUsuariosSeleccionados
			// 
			this.dtgUsuariosSeleccionados.Location = new System.Drawing.Point(406, 66);
			this.dtgUsuariosSeleccionados.MainView = this.gridView2;
			this.dtgUsuariosSeleccionados.Name = "dtgUsuariosSeleccionados";
			this.dtgUsuariosSeleccionados.Size = new System.Drawing.Size(319, 456);
			this.dtgUsuariosSeleccionados.TabIndex = 11;
			this.dtgUsuariosSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuario,
            this.colDescr});
			this.gridView2.GridControl = this.dtgUsuariosSeleccionados;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.MultiSelect = true;
			this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			// 
			// dtgUsuarios
			// 
			this.dtgUsuarios.Location = new System.Drawing.Point(12, 66);
			this.dtgUsuarios.MainView = this.gridView1;
			this.dtgUsuarios.Name = "dtgUsuarios";
			this.dtgUsuarios.Size = new System.Drawing.Size(303, 456);
			this.dtgUsuarios.TabIndex = 10;
			this.dtgUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuarioAll,
            this.colDescAll});
			this.gridView1.GridControl = this.dtgUsuarios;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.MultiSelect = true;
			this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			// 
			// txtCodBodega
			// 
			this.txtCodBodega.EditValue = "";
			this.txtCodBodega.Location = new System.Drawing.Point(55, 12);
			this.txtCodBodega.Name = "txtCodBodega";
			this.txtCodBodega.Size = new System.Drawing.Size(116, 20);
			this.txtCodBodega.StyleController = this.layoutControl1;
			this.txtCodBodega.TabIndex = 7;
			// 
			// txtDescrBodega
			// 
			this.txtDescrBodega.EditValue = " ";
			this.txtDescrBodega.Location = new System.Drawing.Point(175, 12);
			this.txtDescrBodega.Name = "txtDescrBodega";
			this.txtDescrBodega.Size = new System.Drawing.Size(550, 20);
			this.txtDescrBodega.StyleController = this.layoutControl1;
			this.txtDescrBodega.TabIndex = 6;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem5,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.emptySpaceItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(737, 534);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtCodBodega;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(163, 24);
			this.layoutControlItem1.Text = "Bodega:";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(307, 24);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(87, 30);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.CustomizationFormText = "Listado de Usuarios";
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 24);
			this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 30);
			this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 30);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(307, 30);
			this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem3.Text = "Listado de Usuarios";
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(40, 0);
			this.emptySpaceItem3.TextVisible = true;
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.CustomizationFormText = "Usuarios Seleccionados";
			this.emptySpaceItem4.Location = new System.Drawing.Point(394, 24);
			this.emptySpaceItem4.MaxSize = new System.Drawing.Size(0, 30);
			this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 30);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(323, 30);
			this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem4.Text = "Usuarios Seleccionados";
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(40, 0);
			this.emptySpaceItem4.TextVisible = true;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtDescrBodega;
			this.layoutControlItem2.Location = new System.Drawing.Point(163, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(554, 24);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.dtgUsuariosSeleccionados;
			this.layoutControlItem5.Location = new System.Drawing.Point(394, 54);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(323, 460);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.dtgUsuarios;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 54);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(307, 460);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(307, 54);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(87, 0);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(87, 10);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(87, 181);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnQuitar;
			this.layoutControlItem4.Location = new System.Drawing.Point(307, 277);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(87, 42);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnAgregar;
			this.layoutControlItem3.Location = new System.Drawing.Point(307, 235);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(87, 42);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(307, 319);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(87, 195);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// colUsuario
			// 
			this.colUsuario.Caption = "Usuario";
			this.colUsuario.FieldName = "Usuario";
			this.colUsuario.Name = "colUsuario";
			this.colUsuario.Visible = true;
			this.colUsuario.VisibleIndex = 0;
			this.colUsuario.Width = 84;
			// 
			// colDescr
			// 
			this.colDescr.Caption = "Descripcion";
			this.colDescr.FieldName = "Descr";
			this.colDescr.Name = "colDescr";
			this.colDescr.Visible = true;
			this.colDescr.VisibleIndex = 1;
			this.colDescr.Width = 213;
			// 
			// colUsuarioAll
			// 
			this.colUsuarioAll.Caption = "Usuario";
			this.colUsuarioAll.FieldName = "USUARIO";
			this.colUsuarioAll.Name = "colUsuarioAll";
			this.colUsuarioAll.Visible = true;
			this.colUsuarioAll.VisibleIndex = 0;
			this.colUsuarioAll.Width = 71;
			// 
			// colDescAll
			// 
			this.colDescAll.Caption = "Descr";
			this.colDescAll.FieldName = "DESCR";
			this.colDescAll.Name = "colDescAll";
			this.colDescAll.Visible = true;
			this.colDescAll.VisibleIndex = 1;
			this.colDescAll.Width = 214;
			// 
			// frmUsuarioBodega
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 534);
			this.Controls.Add(this.layoutControl1);
			this.Name = "frmUsuarioBodega";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asignación de Usuario Bodega";
			this.Load += new System.EventHandler(this.frmUsuarioBodega_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuariosSeleccionados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodBodega.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescrBodega.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.TextEdit txtCodBodega;
		private DevExpress.XtraEditors.TextEdit txtDescrBodega;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraEditors.SimpleButton btnAgregar;
		private DevExpress.XtraEditors.SimpleButton btnQuitar;
		private DevExpress.XtraGrid.GridControl dtgUsuariosSeleccionados;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl dtgUsuarios;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
		private DevExpress.XtraGrid.Columns.GridColumn colDescr;
		private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAll;
		private DevExpress.XtraGrid.Columns.GridColumn colDescAll;
	}
}