namespace CG.Consultas
{
    partial class frmConsultaAsientoDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAsientoDiario));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dtgAsientos = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cEjercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAsiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCreadoBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMayorizadoBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFechaMayorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAnuladoPor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAnulado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cModuloFuente = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsientos)).BeginInit();
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
            this.btnFiltro});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(500, 143);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
            // dtgAsientos
            // 
            this.dtgAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAsientos.Location = new System.Drawing.Point(0, 143);
            this.dtgAsientos.MainView = this.gridView;
            this.dtgAsientos.MenuManager = this.ribbonControl;
            this.dtgAsientos.Name = "dtgAsientos";
            this.dtgAsientos.Size = new System.Drawing.Size(500, 283);
            this.dtgAsientos.TabIndex = 3;
            this.dtgAsientos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cEjercicio,
            this.cPeriodo,
            this.cAsiento,
            this.cConcepto,
            this.cFecha,
            this.cTipo,
            this.cCreadoBy,
            this.cFechaCreacion,
            this.cMayorizadoBy,
            this.cFechaMayorizacion,
            this.cAnuladoPor,
            this.cFechaAnulacion,
            this.cAnulado,
            this.cTipoCambio,
            this.cModuloFuente});
            this.gridView.GridControl = this.dtgAsientos;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            // 
            // cEjercicio
            // 
            this.cEjercicio.Caption = "Ejercicio";
            this.cEjercicio.FieldName = "IDEjercicio";
            this.cEjercicio.Name = "cEjercicio";
            this.cEjercicio.Visible = true;
            this.cEjercicio.VisibleIndex = 0;
            this.cEjercicio.Width = 76;
            // 
            // cPeriodo
            // 
            this.cPeriodo.Caption = "Periodo";
            this.cPeriodo.FieldName = "Periodo";
            this.cPeriodo.Name = "cPeriodo";
            this.cPeriodo.Visible = true;
            this.cPeriodo.VisibleIndex = 1;
            this.cPeriodo.Width = 76;
            // 
            // cAsiento
            // 
            this.cAsiento.Caption = "Asiento";
            this.cAsiento.FieldName = "Asiento";
            this.cAsiento.Name = "cAsiento";
            this.cAsiento.Visible = true;
            this.cAsiento.VisibleIndex = 3;
            this.cAsiento.Width = 155;
            // 
            // cConcepto
            // 
            this.cConcepto.Caption = "Referencia";
            this.cConcepto.FieldName = "Concepto";
            this.cConcepto.Name = "cConcepto";
            this.cConcepto.Visible = true;
            this.cConcepto.VisibleIndex = 5;
            this.cConcepto.Width = 289;
            // 
            // cFecha
            // 
            this.cFecha.Caption = "Fecha";
            this.cFecha.FieldName = "FechaHora";
            this.cFecha.Name = "cFecha";
            this.cFecha.Visible = true;
            this.cFecha.VisibleIndex = 2;
            this.cFecha.Width = 76;
            // 
            // cTipo
            // 
            this.cTipo.Caption = "Tipo Asiento";
            this.cTipo.FieldName = "Tipo";
            this.cTipo.Name = "cTipo";
            this.cTipo.Visible = true;
            this.cTipo.VisibleIndex = 4;
            this.cTipo.Width = 67;
            // 
            // cCreadoBy
            // 
            this.cCreadoBy.Caption = "Usuario Creación";
            this.cCreadoBy.FieldName = "Createdby";
            this.cCreadoBy.Name = "cCreadoBy";
            this.cCreadoBy.Visible = true;
            this.cCreadoBy.VisibleIndex = 6;
            this.cCreadoBy.Width = 97;
            // 
            // cFechaCreacion
            // 
            this.cFechaCreacion.Caption = "Fecha Creación";
            this.cFechaCreacion.FieldName = "CreateDate";
            this.cFechaCreacion.Name = "cFechaCreacion";
            this.cFechaCreacion.Visible = true;
            this.cFechaCreacion.VisibleIndex = 7;
            this.cFechaCreacion.Width = 92;
            // 
            // cMayorizadoBy
            // 
            this.cMayorizadoBy.Caption = "Usuario Mayorizado";
            this.cMayorizadoBy.FieldName = "MayorizadoBy";
            this.cMayorizadoBy.Name = "cMayorizadoBy";
            this.cMayorizadoBy.Visible = true;
            this.cMayorizadoBy.VisibleIndex = 8;
            this.cMayorizadoBy.Width = 109;
            // 
            // cFechaMayorizacion
            // 
            this.cFechaMayorizacion.Caption = "Fecha Mayorización";
            this.cFechaMayorizacion.FieldName = "MayorizadoDate";
            this.cFechaMayorizacion.Name = "cFechaMayorizacion";
            this.cFechaMayorizacion.Visible = true;
            this.cFechaMayorizacion.VisibleIndex = 9;
            this.cFechaMayorizacion.Width = 124;
            // 
            // cAnuladoPor
            // 
            this.cAnuladoPor.Caption = "Usuario Anulación";
            this.cAnuladoPor.FieldName = "Anuladoby";
            this.cAnuladoPor.Name = "cAnuladoPor";
            this.cAnuladoPor.Visible = true;
            this.cAnuladoPor.VisibleIndex = 10;
            this.cAnuladoPor.Width = 110;
            // 
            // cFechaAnulacion
            // 
            this.cFechaAnulacion.Caption = "Fecha Anulación";
            this.cFechaAnulacion.FieldName = "AnuladoDate";
            this.cFechaAnulacion.Name = "cFechaAnulacion";
            this.cFechaAnulacion.Visible = true;
            this.cFechaAnulacion.VisibleIndex = 11;
            this.cFechaAnulacion.Width = 95;
            // 
            // cAnulado
            // 
            this.cAnulado.Caption = "Anulado";
            this.cAnulado.FieldName = "Anulado";
            this.cAnulado.Name = "cAnulado";
            this.cAnulado.Visible = true;
            this.cAnulado.VisibleIndex = 12;
            this.cAnulado.Width = 48;
            // 
            // cTipoCambio
            // 
            this.cTipoCambio.Caption = "Tipo Camb.";
            this.cTipoCambio.FieldName = "TipoCambio";
            this.cTipoCambio.Name = "cTipoCambio";
            this.cTipoCambio.Visible = true;
            this.cTipoCambio.VisibleIndex = 13;
            this.cTipoCambio.Width = 70;
            // 
            // cModuloFuente
            // 
            this.cModuloFuente.Caption = "Módulo Fuente";
            this.cModuloFuente.FieldName = "ModuloFuente";
            this.cModuloFuente.Name = "cModuloFuente";
            this.cModuloFuente.Visible = true;
            this.cModuloFuente.VisibleIndex = 14;
            this.cModuloFuente.Width = 66;
            // 
            // frmConsultaAsientoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 426);
            this.Controls.Add(this.dtgAsientos);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmConsultaAsientoDiario";
            this.Ribbon = this.ribbonControl;
            this.Text = "frmConsultaAsientoDiario";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsientos)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dtgAsientos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cEjercicio;
        private DevExpress.XtraGrid.Columns.GridColumn cPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn cAsiento;
        private DevExpress.XtraGrid.Columns.GridColumn cConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn cFecha;
        private DevExpress.XtraGrid.Columns.GridColumn cTipo;
        private DevExpress.XtraGrid.Columns.GridColumn cCreadoBy;
        private DevExpress.XtraGrid.Columns.GridColumn cFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn cMayorizadoBy;
        private DevExpress.XtraGrid.Columns.GridColumn cFechaMayorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn cAnuladoPor;
        private DevExpress.XtraGrid.Columns.GridColumn cFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn cAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn cTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn cModuloFuente;
    }
}