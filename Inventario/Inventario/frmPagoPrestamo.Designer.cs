namespace CI
{
	partial class frmPagoPrestamo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoPrestamo));
			this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtAsiento = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtReferencia = new DevExpress.XtraEditors.MemoEdit();
			this.dtgDetallePrestamos = new DevExpress.XtraGrid.GridControl();
			this.dtgViewPrestados = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescrProd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIDLote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoteProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCantPagada = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCantPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAsiento.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgViewPrestados)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(80, 22);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(100, 20);
			this.txtDocumento.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(16, 25);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(58, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Documento:";
			// 
			// txtAsiento
			// 
			this.txtAsiento.Location = new System.Drawing.Point(324, 22);
			this.txtAsiento.Name = "txtAsiento";
			this.txtAsiento.Size = new System.Drawing.Size(100, 20);
			this.txtAsiento.TabIndex = 0;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(278, 25);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(40, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Asiento:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(525, 25);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(33, 13);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Fecha:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.EditValue = null;
			this.dtpFecha.Location = new System.Drawing.Point(564, 22);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFecha.Size = new System.Drawing.Size(100, 20);
			this.dtpFecha.TabIndex = 2;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(16, 62);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(56, 13);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Referencia:";
			// 
			// txtReferencia
			// 
			this.txtReferencia.Location = new System.Drawing.Point(80, 60);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(584, 69);
			this.txtReferencia.TabIndex = 3;
			// 
			// dtgDetallePrestamos
			// 
			this.dtgDetallePrestamos.Location = new System.Drawing.Point(12, 135);
			this.dtgDetallePrestamos.MainView = this.dtgViewPrestados;
			this.dtgDetallePrestamos.Name = "dtgDetallePrestamos";
			this.dtgDetallePrestamos.Size = new System.Drawing.Size(652, 271);
			this.dtgDetallePrestamos.TabIndex = 4;
			this.dtgDetallePrestamos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgViewPrestados});
			// 
			// dtgViewPrestados
			// 
			this.dtgViewPrestados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIDProducto,
            this.colDescrProd,
            this.colIDLote,
            this.colLoteProveedor,
            this.colCantidad,
            this.colCantPagada,
            this.colCantPendiente});
			this.dtgViewPrestados.GridControl = this.dtgDetallePrestamos;
			this.dtgViewPrestados.Name = "dtgViewPrestados";
			// 
			// ColIDProducto
			// 
			this.ColIDProducto.Caption = "ID Producto";
			this.ColIDProducto.FieldName = "IDProducto";
			this.ColIDProducto.Name = "ColIDProducto";
			this.ColIDProducto.OptionsColumn.ReadOnly = true;
			this.ColIDProducto.Visible = true;
			this.ColIDProducto.VisibleIndex = 0;
			// 
			// colDescrProd
			// 
			this.colDescrProd.Caption = "Descr Producto";
			this.colDescrProd.Name = "colDescrProd";
			this.colDescrProd.OptionsColumn.ReadOnly = true;
			this.colDescrProd.Visible = true;
			this.colDescrProd.VisibleIndex = 1;
			// 
			// colIDLote
			// 
			this.colIDLote.Caption = "IDLote";
			this.colIDLote.FieldName = "IDLote";
			this.colIDLote.Name = "colIDLote";
			this.colIDLote.OptionsColumn.ReadOnly = true;
			this.colIDLote.Visible = true;
			this.colIDLote.VisibleIndex = 2;
			// 
			// colLoteProveedor
			// 
			this.colLoteProveedor.Caption = "Lote";
			this.colLoteProveedor.FieldName = "LoteProveedor";
			this.colLoteProveedor.Name = "colLoteProveedor";
			this.colLoteProveedor.OptionsColumn.ReadOnly = true;
			this.colLoteProveedor.Visible = true;
			this.colLoteProveedor.VisibleIndex = 3;
			// 
			// colCantidad
			// 
			this.colCantidad.Caption = "Cantidad";
			this.colCantidad.FieldName = "Cantidad";
			this.colCantidad.Name = "colCantidad";
			this.colCantidad.OptionsColumn.ReadOnly = true;
			this.colCantidad.Visible = true;
			this.colCantidad.VisibleIndex = 4;
			// 
			// colCantPagada
			// 
			this.colCantPagada.Caption = "Cant Pagada";
			this.colCantPagada.FieldName = "CantPagada";
			this.colCantPagada.Name = "colCantPagada";
			this.colCantPagada.OptionsColumn.ReadOnly = true;
			this.colCantPagada.Visible = true;
			this.colCantPagada.VisibleIndex = 5;
			// 
			// colCantPendiente
			// 
			this.colCantPendiente.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colCantPendiente.AppearanceCell.Options.UseBackColor = true;
			this.colCantPendiente.Caption = "Cant Pendiente";
			this.colCantPendiente.FieldName = "Pendiente";
			this.colCantPendiente.Name = "colCantPendiente";
			this.colCantPendiente.Visible = true;
			this.colCantPendiente.VisibleIndex = 6;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(589, 412);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// frmPagoPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 443);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dtgDetallePrestamos);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtAsiento);
			this.Controls.Add(this.txtDocumento);
			this.Name = "frmPagoPrestamo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pago de Prestamos";
			this.Load += new System.EventHandler(this.frmPagoPrestamo_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAsiento.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgViewPrestados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtDocumento;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtAsiento;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.DateEdit dtpFecha;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.MemoEdit txtReferencia;
		private DevExpress.XtraGrid.GridControl dtgDetallePrestamos;
		private DevExpress.XtraGrid.Views.Grid.GridView dtgViewPrestados;
		private DevExpress.XtraEditors.SimpleButton btnGuardar;
		private DevExpress.XtraGrid.Columns.GridColumn ColIDProducto;
		private DevExpress.XtraGrid.Columns.GridColumn colDescrProd;
		private DevExpress.XtraGrid.Columns.GridColumn colIDLote;
		private DevExpress.XtraGrid.Columns.GridColumn colLoteProveedor;
		private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
		private DevExpress.XtraGrid.Columns.GridColumn colCantPagada;
		private DevExpress.XtraGrid.Columns.GridColumn colCantPendiente;
	}
}