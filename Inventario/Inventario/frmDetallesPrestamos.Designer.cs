namespace CI
{
	partial class frmDetallesPrestamos
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.dtgDetallePrestamos = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIDTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLinkDocumento = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsiento = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.colLinkAsiento = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colLinkDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colLinkAsiento)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.dtgDetallePrestamos);
			this.layoutControl1.Controls.Add(this.simpleButton2);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(530, 253);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// dtgDetallePrestamos
			// 
			this.dtgDetallePrestamos.Location = new System.Drawing.Point(12, 12);
			this.dtgDetallePrestamos.MainView = this.gridView1;
			this.dtgDetallePrestamos.Name = "dtgDetallePrestamos";
			this.dtgDetallePrestamos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colLinkDocumento,
            this.colLinkAsiento});
			this.dtgDetallePrestamos.Size = new System.Drawing.Size(506, 203);
			this.dtgDetallePrestamos.TabIndex = 4;
			this.dtgDetallePrestamos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDTransaccion,
            this.colDocumento,
            this.colFecha,
            this.colAsiento,
            this.colReferencia});
			this.gridView1.GridControl = this.dtgDetallePrestamos;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
			// 
			// colIDTransaccion
			// 
			this.colIDTransaccion.Caption = "ID Transacción";
			this.colIDTransaccion.FieldName = "IDTransaccion";
			this.colIDTransaccion.Name = "colIDTransaccion";
			this.colIDTransaccion.Visible = true;
			this.colIDTransaccion.VisibleIndex = 0;
			// 
			// colDocumento
			// 
			this.colDocumento.Caption = "Documento";
			this.colDocumento.ColumnEdit = this.colLinkDocumento;
			this.colDocumento.FieldName = "Documento";
			this.colDocumento.Name = "colDocumento";
			this.colDocumento.Visible = true;
			this.colDocumento.VisibleIndex = 1;
			// 
			// colLinkDocumento
			// 
			this.colLinkDocumento.AutoHeight = false;
			this.colLinkDocumento.Name = "colLinkDocumento";
			this.colLinkDocumento.Tag = "";
			// 
			// colFecha
			// 
			this.colFecha.Caption = "Fecha";
			this.colFecha.FieldName = "Fecha";
			this.colFecha.Name = "colFecha";
			this.colFecha.Visible = true;
			this.colFecha.VisibleIndex = 2;
			// 
			// colAsiento
			// 
			this.colAsiento.Caption = "Asiento";
			this.colAsiento.ColumnEdit = this.colLinkAsiento;
			this.colAsiento.FieldName = "Asiento";
			this.colAsiento.Name = "colAsiento";
			this.colAsiento.Visible = true;
			this.colAsiento.VisibleIndex = 3;
			// 
			// colReferencia
			// 
			this.colReferencia.Caption = "Referencia";
			this.colReferencia.FieldName = "Nota";
			this.colReferencia.Name = "colReferencia";
			this.colReferencia.Visible = true;
			this.colReferencia.VisibleIndex = 4;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(417, 219);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(101, 22);
			this.simpleButton2.StyleController = this.layoutControl1;
			this.simpleButton2.TabIndex = 5;
			this.simpleButton2.Text = "Aceptar";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(530, 253);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.simpleButton2;
			this.layoutControlItem2.Location = new System.Drawing.Point(405, 207);
			this.layoutControlItem2.MaxSize = new System.Drawing.Size(105, 26);
			this.layoutControlItem2.MinSize = new System.Drawing.Size(105, 26);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(105, 26);
			this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtgDetallePrestamos;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(510, 207);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 207);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(405, 26);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// colLinkAsiento
			// 
			this.colLinkAsiento.AutoHeight = false;
			this.colLinkAsiento.Name = "colLinkAsiento";
			// 
			// frmDetallesPrestamos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 253);
			this.Controls.Add(this.layoutControl1);
			this.Name = "frmDetallesPrestamos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Detalle Prestamos";
			this.Load += new System.EventHandler(this.frmDetallesPrestamos_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colLinkDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colLinkAsiento)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl dtgDetallePrestamos;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraGrid.Columns.GridColumn colIDTransaccion;
		private DevExpress.XtraGrid.Columns.GridColumn colDocumento;
		private DevExpress.XtraGrid.Columns.GridColumn colFecha;
		private DevExpress.XtraGrid.Columns.GridColumn colAsiento;
		private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit colLinkDocumento;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit colLinkAsiento;

	}
}