namespace CO
{
    partial class frmRecepcionMercaderia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcionMercaderia));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtOrdenCompra = new DevExpress.XtraEditors.TextEdit();
			this.dtgIngresoMercaderia = new DevExpress.XtraGrid.GridControl();
			this.gridViewIngresoMercaderia = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.slkupGridIDProd = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIDProd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescrProd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.slkupGridDescrProd = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIDProd2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIDLote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.slkupGridLote = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDescrLote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFechaVence = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtEmbarque = new DevExpress.XtraEditors.TextEdit();
			this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
			this.txtFactura = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.btnAgregarLotes = new DevExpress.XtraEditors.SimpleButton();
			this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
			this.btnAddLote = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgIngresoMercaderia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewIngresoMercaderia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridIDProd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridDescrProd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridLote)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbarque.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Location = new System.Drawing.Point(26, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(204, 19);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Recepción de Mercadería";
			// 
			// txtOrdenCompra
			// 
			this.txtOrdenCompra.Location = new System.Drawing.Point(121, 59);
			this.txtOrdenCompra.Name = "txtOrdenCompra";
			this.txtOrdenCompra.Properties.ReadOnly = true;
			this.txtOrdenCompra.Size = new System.Drawing.Size(100, 20);
			this.txtOrdenCompra.TabIndex = 1;
			// 
			// dtgIngresoMercaderia
			// 
			this.dtgIngresoMercaderia.Location = new System.Drawing.Point(2, 150);
			this.dtgIngresoMercaderia.MainView = this.gridViewIngresoMercaderia;
			this.dtgIngresoMercaderia.Name = "dtgIngresoMercaderia";
			this.dtgIngresoMercaderia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.slkupGridIDProd,
            this.slkupGridDescrProd,
            this.slkupGridLote});
			this.dtgIngresoMercaderia.Size = new System.Drawing.Size(707, 382);
			this.dtgIngresoMercaderia.TabIndex = 2;
			this.dtgIngresoMercaderia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIngresoMercaderia});
			// 
			// gridViewIngresoMercaderia
			// 
			this.gridViewIngresoMercaderia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDProducto,
            this.Descr,
            this.colIDLote,
            this.colFechaVencimiento,
            this.Cantidad});
			this.gridViewIngresoMercaderia.GridControl = this.dtgIngresoMercaderia;
			this.gridViewIngresoMercaderia.Name = "gridViewIngresoMercaderia";
			this.gridViewIngresoMercaderia.NewItemRowText = "Agregar nueva linea al ingreso de productos";
			this.gridViewIngresoMercaderia.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gridViewIngresoMercaderia.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gridViewIngresoMercaderia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
			this.gridViewIngresoMercaderia.OptionsView.ShowGroupPanel = false;
			this.gridViewIngresoMercaderia.ShownEditor += new System.EventHandler(this.gridViewRecepcionMercaderia_ShownEditor);
			// 
			// IDProducto
			// 
			this.IDProducto.Caption = "IDProducto";
			this.IDProducto.ColumnEdit = this.slkupGridIDProd;
			this.IDProducto.FieldName = "IDProducto";
			this.IDProducto.Name = "IDProducto";
			this.IDProducto.Visible = true;
			this.IDProducto.VisibleIndex = 0;
			this.IDProducto.Width = 89;
			// 
			// slkupGridIDProd
			// 
			this.slkupGridIDProd.AutoHeight = false;
			this.slkupGridIDProd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupGridIDProd.Name = "slkupGridIDProd";
			this.slkupGridIDProd.View = this.repositoryItemSearchLookUpEdit1View;
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProd,
            this.colDescrProd});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colIDProd
			// 
			this.colIDProd.Caption = "IDProducto";
			this.colIDProd.FieldName = "IDProducto";
			this.colIDProd.Name = "colIDProd";
			this.colIDProd.Visible = true;
			this.colIDProd.VisibleIndex = 0;
			this.colIDProd.Width = 216;
			// 
			// colDescrProd
			// 
			this.colDescrProd.Caption = "Descripción";
			this.colDescrProd.FieldName = "Descr";
			this.colDescrProd.Name = "colDescrProd";
			this.colDescrProd.Visible = true;
			this.colDescrProd.VisibleIndex = 1;
			this.colDescrProd.Width = 920;
			// 
			// Descr
			// 
			this.Descr.Caption = "Descripción";
			this.Descr.ColumnEdit = this.slkupGridDescrProd;
			this.Descr.FieldName = "IDProducto";
			this.Descr.Name = "Descr";
			this.Descr.Visible = true;
			this.Descr.VisibleIndex = 1;
			this.Descr.Width = 600;
			// 
			// slkupGridDescrProd
			// 
			this.slkupGridDescrProd.AutoHeight = false;
			this.slkupGridDescrProd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupGridDescrProd.Name = "slkupGridDescrProd";
			this.slkupGridDescrProd.View = this.gridView1;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProd2,
            this.colDescr});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colIDProd2
			// 
			this.colIDProd2.Caption = "IDProducto";
			this.colIDProd2.FieldName = "IDProducto";
			this.colIDProd2.Name = "colIDProd2";
			this.colIDProd2.Visible = true;
			this.colIDProd2.VisibleIndex = 0;
			this.colIDProd2.Width = 192;
			// 
			// colDescr
			// 
			this.colDescr.Caption = "Descripcion";
			this.colDescr.FieldName = "Descr";
			this.colDescr.Name = "colDescr";
			this.colDescr.Visible = true;
			this.colDescr.VisibleIndex = 1;
			this.colDescr.Width = 944;
			// 
			// colIDLote
			// 
			this.colIDLote.Caption = "Lote";
			this.colIDLote.ColumnEdit = this.slkupGridLote;
			this.colIDLote.FieldName = "IDLote";
			this.colIDLote.Name = "colIDLote";
			this.colIDLote.Visible = true;
			this.colIDLote.VisibleIndex = 2;
			this.colIDLote.Width = 121;
			// 
			// slkupGridLote
			// 
			this.slkupGridLote.AutoHeight = false;
			this.slkupGridLote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupGridLote.Name = "slkupGridLote";
			this.slkupGridLote.View = this.gridView2;
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescrLote,
            this.colFechaVence});
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// colDescrLote
			// 
			this.colDescrLote.Caption = "Lote";
			this.colDescrLote.FieldName = "LoteProveedor";
			this.colDescrLote.Name = "colDescrLote";
			this.colDescrLote.Visible = true;
			this.colDescrLote.VisibleIndex = 0;
			// 
			// colFechaVence
			// 
			this.colFechaVence.Caption = "Fecha Vence";
			this.colFechaVence.FieldName = "FechaVencimiento";
			this.colFechaVence.Name = "colFechaVence";
			this.colFechaVence.Visible = true;
			this.colFechaVence.VisibleIndex = 1;
			// 
			// colFechaVencimiento
			// 
			this.colFechaVencimiento.Caption = "Fecha Vence";
			this.colFechaVencimiento.FieldName = "FechaVencimiento";
			this.colFechaVencimiento.Name = "colFechaVencimiento";
			this.colFechaVencimiento.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.colFechaVencimiento.Visible = true;
			this.colFechaVencimiento.VisibleIndex = 3;
			this.colFechaVencimiento.Width = 133;
			// 
			// Cantidad
			// 
			this.Cantidad.Caption = "Cantidad";
			this.Cantidad.FieldName = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Visible = true;
			this.Cantidad.VisibleIndex = 4;
			this.Cantidad.Width = 193;
			// 
			// gridView3
			// 
			this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// dtpFecha
			// 
			this.dtpFecha.EditValue = null;
			this.dtpFecha.Location = new System.Drawing.Point(554, 55);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFecha.Size = new System.Drawing.Size(100, 20);
			this.dtpFecha.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(26, 62);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(89, 13);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Orden de Compra:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(258, 62);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(52, 13);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Embarque:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(26, 85);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(54, 13);
			this.labelControl4.TabIndex = 4;
			this.labelControl4.Text = "Proveedor:";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(503, 88);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(41, 13);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Factura:";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(511, 58);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(33, 13);
			this.labelControl6.TabIndex = 4;
			this.labelControl6.Text = "Fecha:";
			// 
			// txtEmbarque
			// 
			this.txtEmbarque.Location = new System.Drawing.Point(316, 59);
			this.txtEmbarque.Name = "txtEmbarque";
			this.txtEmbarque.Properties.ReadOnly = true;
			this.txtEmbarque.Size = new System.Drawing.Size(100, 20);
			this.txtEmbarque.TabIndex = 1;
			// 
			// txtProveedor
			// 
			this.txtProveedor.Location = new System.Drawing.Point(121, 85);
			this.txtProveedor.Name = "txtProveedor";
			this.txtProveedor.Properties.ReadOnly = true;
			this.txtProveedor.Size = new System.Drawing.Size(376, 20);
			this.txtProveedor.TabIndex = 1;
			// 
			// txtFactura
			// 
			this.txtFactura.Location = new System.Drawing.Point(554, 82);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Properties.ReadOnly = true;
			this.txtFactura.Size = new System.Drawing.Size(100, 20);
			this.txtFactura.TabIndex = 1;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(2, 131);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(103, 13);
			this.labelControl7.TabIndex = 4;
			this.labelControl7.Text = "Detalle de Productos:";
			// 
			// btnAgregarLotes
			// 
			this.btnAgregarLotes.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLotes.Image")));
			this.btnAgregarLotes.Location = new System.Drawing.Point(540, 12);
			this.btnAgregarLotes.Name = "btnAgregarLotes";
			this.btnAgregarLotes.Size = new System.Drawing.Size(76, 23);
			this.btnAgregarLotes.TabIndex = 5;
			this.btnAgregarLotes.Text = "Guardar";
			this.btnAgregarLotes.Click += new System.EventHandler(this.btnAgregarLotes_Click);
			// 
			// btnAplicar
			// 
			this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
			this.btnAplicar.Location = new System.Drawing.Point(622, 12);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new System.Drawing.Size(76, 23);
			this.btnAplicar.TabIndex = 5;
			this.btnAplicar.Text = "Aplicar";
			this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
			// 
			// btnAddLote
			// 
			this.btnAddLote.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLote.Image")));
			this.btnAddLote.Location = new System.Drawing.Point(600, 121);
			this.btnAddLote.Name = "btnAddLote";
			this.btnAddLote.Size = new System.Drawing.Size(109, 23);
			this.btnAddLote.TabIndex = 5;
			this.btnAddLote.Text = "Agregar Lote";
			this.btnAddLote.Click += new System.EventHandler(this.btnAddLote_Click);
			// 
			// frmRecepcionMercaderia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 532);
			this.Controls.Add(this.btnAplicar);
			this.Controls.Add(this.btnAddLote);
			this.Controls.Add(this.btnAgregarLotes);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.dtgIngresoMercaderia);
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.txtProveedor);
			this.Controls.Add(this.txtEmbarque);
			this.Controls.Add(this.txtOrdenCompra);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmRecepcionMercaderia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recepción de Mercadería";
			this.Load += new System.EventHandler(this.frmRecepcionMeraderia_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgIngresoMercaderia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewIngresoMercaderia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridIDProd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridDescrProd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slkupGridLote)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbarque.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraGrid.GridControl dtgIngresoMercaderia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIngresoMercaderia;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.TextEdit txtEmbarque;
        private DevExpress.XtraEditors.TextEdit txtOrdenCompra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn IDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn Descr;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLote;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupGridIDProd;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupGridDescrProd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupGridLote;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnAgregarLotes;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrLote;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVence;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProd;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrProd;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProd2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescr;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVencimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraEditors.SimpleButton btnAddLote;
    }
}