namespace CG.Consultas
{
    partial class frmConsultaDetalleDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDetalleDiario));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCuentasContables = new DevExpress.XtraBars.BarButtonItem();
            this.btnCentrosCosto = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dtgDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cIDEjercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAsiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMayorizadoBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cModuloFuente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDescrCentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDescrCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.barButtonItem1,
            this.btnRefrescar,
            this.btnFiltro,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnCuentasContables,
            this.btnCentrosCosto});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 18;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(481, 143);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Caption = "Refrescar";
            this.btnRefrescar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Glyph")));
            this.btnRefrescar.Id = 10;
            this.btnRefrescar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.LargeGlyph")));
            this.btnRefrescar.Name = "btnRefrescar";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Caption = "Filtro";
            this.btnFiltro.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Glyph")));
            this.btnFiltro.Id = 11;
            this.btnFiltro.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFiltro.LargeGlyph")));
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltro_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 14;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnCuentasContables
            // 
            this.btnCuentasContables.Caption = "Cuentas Contables";
            this.btnCuentasContables.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCuentasContables.Glyph")));
            this.btnCuentasContables.Id = 16;
            this.btnCuentasContables.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCuentasContables.LargeGlyph")));
            this.btnCuentasContables.Name = "btnCuentasContables";
            this.btnCuentasContables.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCuentasContables_ItemClick);
            // 
            // btnCentrosCosto
            // 
            this.btnCentrosCosto.Caption = "Centros de Costo";
            this.btnCentrosCosto.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCentrosCosto.Glyph")));
            this.btnCentrosCosto.Id = 17;
            this.btnCentrosCosto.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCentrosCosto.LargeGlyph")));
            this.btnCentrosCosto.Name = "btnCentrosCosto";
            this.btnCentrosCosto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCentrosCosto_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operaciones Consulta de Saldo Cuenta";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFiltro);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExportar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefrescar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCuentasContables);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCentrosCosto);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalle.Location = new System.Drawing.Point(0, 143);
            this.dtgDetalle.MainView = this.gridView;
            this.dtgDetalle.MenuManager = this.ribbonControl;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.Size = new System.Drawing.Size(481, 223);
            this.dtgDetalle.TabIndex = 2;
            this.dtgDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIDEjercicio,
            this.cPeriodo,
            this.cAsiento,
            this.cFecha,
            this.cMayorizadoBy,
            this.cConcepto,
            this.cModuloFuente,
            this.cCentro,
            this.cDescrCentro,
            this.cCuenta,
            this.cDescrCuenta,
            this.cDebito,
            this.cCredito,
            this.cReferencia});
            this.gridView.GridControl = this.dtgDetalle;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            // 
            // cIDEjercicio
            // 
            this.cIDEjercicio.Caption = "Ejercicio";
            this.cIDEjercicio.FieldName = "IDEjercicio";
            this.cIDEjercicio.Name = "cIDEjercicio";
            this.cIDEjercicio.Visible = true;
            this.cIDEjercicio.VisibleIndex = 0;
            // 
            // cPeriodo
            // 
            this.cPeriodo.Caption = "Periodo";
            this.cPeriodo.FieldName = "Periodo";
            this.cPeriodo.Name = "cPeriodo";
            this.cPeriodo.Visible = true;
            this.cPeriodo.VisibleIndex = 1;
            // 
            // cAsiento
            // 
            this.cAsiento.Caption = "Asiento";
            this.cAsiento.FieldName = "Asiento";
            this.cAsiento.Name = "cAsiento";
            this.cAsiento.Visible = true;
            this.cAsiento.VisibleIndex = 2;
            this.cAsiento.Width = 139;
            // 
            // cFecha
            // 
            this.cFecha.Caption = "Fecha";
            this.cFecha.FieldName = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.Visible = true;
            this.cFecha.VisibleIndex = 3;
            // 
            // cMayorizadoBy
            // 
            this.cMayorizadoBy.Caption = "Usuario Mayorización";
            this.cMayorizadoBy.FieldName = "MayorizadoBy";
            this.cMayorizadoBy.Name = "cMayorizadoBy";
            this.cMayorizadoBy.Visible = true;
            this.cMayorizadoBy.VisibleIndex = 4;
            this.cMayorizadoBy.Width = 113;
            // 
            // cConcepto
            // 
            this.cConcepto.Caption = "Concepto";
            this.cConcepto.FieldName = "Concepto";
            this.cConcepto.Name = "cConcepto";
            this.cConcepto.Visible = true;
            this.cConcepto.VisibleIndex = 5;
            this.cConcepto.Width = 178;
            // 
            // cModuloFuente
            // 
            this.cModuloFuente.Caption = "ModuloFuente";
            this.cModuloFuente.FieldName = "ModuloFuente";
            this.cModuloFuente.Name = "cModuloFuente";
            this.cModuloFuente.Visible = true;
            this.cModuloFuente.VisibleIndex = 6;
            // 
            // cCentro
            // 
            this.cCentro.Caption = "Centro";
            this.cCentro.FieldName = "Centro";
            this.cCentro.Name = "cCentro";
            this.cCentro.Visible = true;
            this.cCentro.VisibleIndex = 7;
            // 
            // cDescrCentro
            // 
            this.cDescrCentro.Caption = "Descr Centro";
            this.cDescrCentro.FieldName = "DescrCentro";
            this.cDescrCentro.Name = "cDescrCentro";
            this.cDescrCentro.Visible = true;
            this.cDescrCentro.VisibleIndex = 8;
            this.cDescrCentro.Width = 154;
            // 
            // cCuenta
            // 
            this.cCuenta.Caption = "Cuenta";
            this.cCuenta.FieldName = "Cuenta";
            this.cCuenta.Name = "cCuenta";
            this.cCuenta.Visible = true;
            this.cCuenta.VisibleIndex = 9;
            // 
            // cDescrCuenta
            // 
            this.cDescrCuenta.Caption = "Descr Cuenta";
            this.cDescrCuenta.FieldName = "DescrCuenta";
            this.cDescrCuenta.Name = "cDescrCuenta";
            this.cDescrCuenta.Visible = true;
            this.cDescrCuenta.VisibleIndex = 10;
            this.cDescrCuenta.Width = 189;
            // 
            // cDebito
            // 
            this.cDebito.Caption = "Débito";
            this.cDebito.FieldName = "Debito";
            this.cDebito.Name = "cDebito";
            this.cDebito.Visible = true;
            this.cDebito.VisibleIndex = 11;
            // 
            // cCredito
            // 
            this.cCredito.Caption = "Crédito";
            this.cCredito.FieldName = "Credito";
            this.cCredito.Name = "cCredito";
            this.cCredito.Visible = true;
            this.cCredito.VisibleIndex = 12;
            // 
            // cReferencia
            // 
            this.cReferencia.Caption = "Referencia";
            this.cReferencia.FieldName = "Referencia";
            this.cReferencia.Name = "cReferencia";
            this.cReferencia.Visible = true;
            this.cReferencia.VisibleIndex = 13;
            // 
            // frmConsultaDetalleDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 366);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmConsultaDetalleDiario";
            this.Ribbon = this.ribbonControl;
            this.Text = "frmConsultaDetalleDiario";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.BarButtonItem btnExportar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnFiltro;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnCuentasContables;
        private DevExpress.XtraBars.BarButtonItem btnCentrosCosto;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl dtgDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cIDEjercicio;
        private DevExpress.XtraGrid.Columns.GridColumn cPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn cAsiento;
        private DevExpress.XtraGrid.Columns.GridColumn cFecha;
        private DevExpress.XtraGrid.Columns.GridColumn cMayorizadoBy;
        private DevExpress.XtraGrid.Columns.GridColumn cConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn cModuloFuente;
        private DevExpress.XtraGrid.Columns.GridColumn cCentro;
        private DevExpress.XtraGrid.Columns.GridColumn cDescrCentro;
        private DevExpress.XtraGrid.Columns.GridColumn cCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn cDescrCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn cDebito;
        private DevExpress.XtraGrid.Columns.GridColumn cCredito;
        private DevExpress.XtraGrid.Columns.GridColumn cReferencia;
    }
}