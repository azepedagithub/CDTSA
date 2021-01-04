namespace Seguridad
{
	partial class frmCatalogoUsuarios
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
			this.dtgUsuarios = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgUsuarios
			// 
			this.dtgUsuarios.Location = new System.Drawing.Point(12, 12);
			this.dtgUsuarios.MainView = this.gridView1;
			this.dtgUsuarios.Name = "dtgUsuarios";
			this.dtgUsuarios.Size = new System.Drawing.Size(475, 331);
			this.dtgUsuarios.TabIndex = 0;
			this.dtgUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.dtgUsuarios;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnCancelar);
			this.layoutControl1.Controls.Add(this.btnAceptar);
			this.layoutControl1.Controls.Add(this.dtgUsuarios);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(499, 381);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(499, 381);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgUsuarios;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(479, 335);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(385, 347);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(102, 22);
			this.btnAceptar.StyleController = this.layoutControl1;
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnAceptar;
			this.layoutControlItem2.Location = new System.Drawing.Point(373, 335);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(106, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(273, 347);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(108, 22);
			this.btnCancelar.StyleController = this.layoutControl1;
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnCancelar;
			this.layoutControlItem3.Location = new System.Drawing.Point(261, 335);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(112, 26);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 335);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(261, 26);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// frmCatalogoUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 381);
			this.Controls.Add(this.layoutControl1);
			this.Name = "frmCatalogoUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.frmCatalogoUsuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl dtgUsuarios;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
		private DevExpress.XtraEditors.SimpleButton btnAceptar;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
	}
}