namespace ControlBancario
{
	partial class frmImportMovBancos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportMovBancos));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.dtgImport = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRef = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnLoadDoc = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.dtgImport);
			this.layoutControl1.Controls.Add(this.btnLoadDoc);
			this.layoutControl1.Controls.Add(this.labelControl1);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(633, 364);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
			this.simpleButton1.Location = new System.Drawing.Point(503, 330);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(118, 22);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Importar";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// dtgImport
			// 
			this.dtgImport.Location = new System.Drawing.Point(12, 76);
			this.dtgImport.MainView = this.gridView1;
			this.dtgImport.Name = "dtgImport";
			this.dtgImport.Size = new System.Drawing.Size(609, 250);
			this.dtgImport.TabIndex = 7;
			this.dtgImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colRef,
            this.colConcepto,
            this.colMonto});
			this.gridView1.GridControl = this.dtgImport;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
			// 
			// colFecha
			// 
			this.colFecha.Caption = "Fecha";
			this.colFecha.FieldName = "Fecha";
			this.colFecha.Name = "colFecha";
			this.colFecha.Visible = true;
			this.colFecha.VisibleIndex = 0;
			// 
			// colRef
			// 
			this.colRef.Caption = "Referencia";
			this.colRef.FieldName = "Referencia";
			this.colRef.Name = "colRef";
			this.colRef.Visible = true;
			this.colRef.VisibleIndex = 1;
			// 
			// colConcepto
			// 
			this.colConcepto.Caption = "Concepto";
			this.colConcepto.FieldName = "Concepto";
			this.colConcepto.Name = "colConcepto";
			this.colConcepto.Visible = true;
			this.colConcepto.VisibleIndex = 2;
			// 
			// colMonto
			// 
			this.colMonto.Caption = "Monto";
			this.colMonto.FieldName = "Monto";
			this.colMonto.Name = "colMonto";
			this.colMonto.Visible = true;
			this.colMonto.VisibleIndex = 3;
			// 
			// btnLoadDoc
			// 
			this.btnLoadDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDoc.Image")));
			this.btnLoadDoc.Location = new System.Drawing.Point(12, 29);
			this.btnLoadDoc.Name = "btnLoadDoc";
			this.btnLoadDoc.Size = new System.Drawing.Size(134, 22);
			this.btnLoadDoc.StyleController = this.layoutControl1;
			this.btnLoadDoc.TabIndex = 6;
			this.btnLoadDoc.Text = "Cargar Documento";
			this.btnLoadDoc.Click += new System.EventHandler(this.btnLoadDoc_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(98, 13);
			this.labelControl1.StyleController = this.layoutControl1;
			this.labelControl1.TabIndex = 5;
			this.labelControl1.Text = "Nombre Documento:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(150, 29);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(471, 20);
			this.txtName.StyleController = this.layoutControl1;
			this.txtName.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControl,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.emptySpaceItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(633, 364);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControl
			// 
			this.layoutControl.Control = this.txtName;
			this.layoutControl.Location = new System.Drawing.Point(138, 17);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Size = new System.Drawing.Size(475, 26);
			this.layoutControl.Text = "Nombre Documento:";
			this.layoutControl.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControl.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.labelControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(613, 17);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnLoadDoc;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(138, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.dtgImport;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(613, 254);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 43);
			this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 21);
			this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 21);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(613, 21);
			this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.simpleButton1;
			this.layoutControlItem4.Location = new System.Drawing.Point(491, 318);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(122, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 318);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(491, 26);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// frmImportMovBancos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 364);
			this.Controls.Add(this.layoutControl1);
			this.Name = "frmImportMovBancos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Importar Estado de Cuenta del Banco";
			this.Load += new System.EventHandler(this.frmImportMovBancos_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraLayout.LayoutControlItem layoutControl;
		private DevExpress.XtraEditors.SimpleButton btnLoadDoc;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraGrid.GridControl dtgImport;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraGrid.Columns.GridColumn colFecha;
		private DevExpress.XtraGrid.Columns.GridColumn colRef;
		private DevExpress.XtraGrid.Columns.GridColumn colConcepto;
		private DevExpress.XtraGrid.Columns.GridColumn colMonto;
	}
}