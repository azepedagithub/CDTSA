namespace CO
{
    partial class frmEmbarque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmbarque));
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation2 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAplicar = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirmar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRecepcionMercaderia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtBodega = new DevExpress.XtraEditors.TextEdit();
            this.linkAsiento = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.dtpFechaEmbarque = new DevExpress.XtraEditors.DateEdit();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.tabLineas = new DevExpress.XtraTab.XtraTabPage();
            this.dtgLineasOrden = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmbarque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescrProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slkupPresentacion = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDetalle = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRellenar = new DevExpress.XtraEditors.SimpleButton();
            this.dtgDetalleEmbarque = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleEmbarque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slkupIDProducto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slkupDescrProducto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantAceptada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabFactura = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGenerarDocCPFactura = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarFactura = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaPoliza = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechaFactura = new DevExpress.XtraEditors.DateEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtMontoSeguro = new DevExpress.XtraEditors.TextEdit();
            this.txtMontoFlete = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalMercaderia = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtAsiento = new DevExpress.XtraEditors.TextEdit();
            this.txtGuiaBL = new DevExpress.XtraEditors.TextEdit();
            this.txtPoliza = new DevExpress.XtraEditors.TextEdit();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabOtros = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.btnEliminarOtrosGastos = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarOtrosPagos = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarOtrosPagos = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarOtrosPagos = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarOtrosPagos = new DevExpress.XtraEditors.SimpleButton();
            this.slkupGastosOtrosPagos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slkupProveedorOtrosPagos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slkupMonedaOtrosPagos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMontoOtrosPagos = new DevExpress.XtraEditors.TextEdit();
            this.dtpFechaOtrosPagos = new DevExpress.XtraEditors.DateEdit();
            this.txtDocumentoOtrosPagos = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtEmbarque = new DevExpress.XtraEditors.TextEdit();
            this.txtOrdenCompra = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtgObligaciones = new Util.S4UGridControl();
            this.gridViewObligaciones = new Util.MyGridView();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colFechaDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmbarque.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmbarque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.tabLineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLineasOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmbarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleEmbarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEmbarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupIDProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupDescrProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.tabFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPoliza.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFactura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFlete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMercaderia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuiaBL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.tabOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupGastosOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupProveedorOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupMonedaOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaOtrosPagos.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentoOtrosPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmbarque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgObligaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewObligaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnEditar,
            this.btnGuardar,
            this.btnCancelar,
            this.btnEliminar,
            this.btnAplicar,
            this.btnConfirmar,
            this.btnRecepcionMercaderia});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(840, 143);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 2;
            this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarSolicitud_ItemClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 3;
            this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardarSolicitud_ItemClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Glyph")));
            this.btnCancelar.Id = 4;
            this.btnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCancelar.LargeGlyph")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelarSolicitud_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Glyph")));
            this.btnEliminar.Id = 5;
            this.btnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.LargeGlyph")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarSolicitud_ItemClick);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Caption = "Liquidar";
            this.btnAplicar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Glyph")));
            this.btnAplicar.Id = 1;
            this.btnAplicar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAplicar.LargeGlyph")));
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAplicar_ItemClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Caption = "Confirmar";
            this.btnConfirmar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Glyph")));
            this.btnConfirmar.Id = 2;
            this.btnConfirmar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.LargeGlyph")));
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirmar_ItemClick);
            // 
            // btnRecepcionMercaderia
            // 
            this.btnRecepcionMercaderia.Caption = "Recepción Mercadería";
            this.btnRecepcionMercaderia.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRecepcionMercaderia.Glyph")));
            this.btnRecepcionMercaderia.Id = 3;
            this.btnRecepcionMercaderia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRecepcionMercaderia.LargeGlyph")));
            this.btnRecepcionMercaderia.Name = "btnRecepcionMercaderia";
            this.btnRecepcionMercaderia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecepcionMercaderia_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.Group = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation2.Group = null;
            reduceOperation2.ItemLinkIndex = 0;
            reduceOperation2.ItemLinksCount = 0;
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.ribbonPage1.ReduceOperations.Add(reduceOperation1);
            this.ribbonPage1.ReduceOperations.Add(reduceOperation2);
            this.ribbonPage1.Text = "Opciones Generales";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCancelar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAplicar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnConfirmar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRecepcionMercaderia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtBodega);
            this.layoutControl1.Controls.Add(this.linkAsiento);
            this.layoutControl1.Controls.Add(this.dtpFechaEmbarque);
            this.layoutControl1.Controls.Add(this.dtpFecha);
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.txtProveedor);
            this.layoutControl1.Controls.Add(this.txtEmbarque);
            this.layoutControl1.Controls.Add(this.txtOrdenCompra);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(600, 353, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(840, 439);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtBodega
            // 
            this.txtBodega.Location = new System.Drawing.Point(467, 77);
            this.txtBodega.MenuManager = this.ribbonControl1;
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(361, 20);
            this.txtBodega.StyleController = this.layoutControl1;
            this.txtBodega.TabIndex = 12;
            // 
            // linkAsiento
            // 
            this.linkAsiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAsiento.Location = new System.Drawing.Point(719, 12);
            this.linkAsiento.Name = "linkAsiento";
            this.linkAsiento.Size = new System.Drawing.Size(109, 13);
            this.linkAsiento.StyleController = this.layoutControl1;
            this.linkAsiento.TabIndex = 11;
            this.linkAsiento.Text = "hyperlinkLabelControl2";
            this.linkAsiento.Click += new System.EventHandler(this.linkAsiento_Click);
            // 
            // dtpFechaEmbarque
            // 
            this.dtpFechaEmbarque.EditValue = null;
            this.dtpFechaEmbarque.Location = new System.Drawing.Point(467, 53);
            this.dtpFechaEmbarque.MenuManager = this.ribbonControl1;
            this.dtpFechaEmbarque.Name = "dtpFechaEmbarque";
            this.dtpFechaEmbarque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaEmbarque.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaEmbarque.Size = new System.Drawing.Size(361, 20);
            this.dtpFechaEmbarque.StyleController = this.layoutControl1;
            this.dtpFechaEmbarque.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = null;
            this.dtpFecha.Location = new System.Drawing.Point(99, 77);
            this.dtpFecha.MenuManager = this.ribbonControl1;
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Size = new System.Drawing.Size(265, 20);
            this.dtpFecha.StyleController = this.layoutControl1;
            this.dtpFecha.TabIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Images = this.imageCollection;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 114);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabLineas;
            this.xtraTabControl1.Size = new System.Drawing.Size(816, 313);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabLineas,
            this.tabDetalle,
            this.tabFactura,
            this.tabOtros});
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("question_16x16.png", "images/support/question_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/question_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "question_16x16.png");
            // 
            // tabLineas
            // 
            this.tabLineas.Controls.Add(this.dtgLineasOrden);
            this.tabLineas.Name = "tabLineas";
            this.tabLineas.Size = new System.Drawing.Size(810, 285);
            this.tabLineas.Text = "Lineas Orden Compra";
            // 
            // dtgLineasOrden
            // 
            this.dtgLineasOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLineasOrden.Location = new System.Drawing.Point(0, 0);
            this.dtgLineasOrden.MainView = this.gridViewEmbarque;
            this.dtgLineasOrden.MenuManager = this.ribbonControl1;
            this.dtgLineasOrden.Name = "dtgLineasOrden";
            this.dtgLineasOrden.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.slkupPresentacion});
            this.dtgLineasOrden.Size = new System.Drawing.Size(810, 285);
            this.dtgLineasOrden.TabIndex = 0;
            this.dtgLineasOrden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmbarque});
            // 
            // gridViewEmbarque
            // 
            this.gridViewEmbarque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.DescrProd,
            this.Presentacion,
            this.Cantidad});
            this.gridViewEmbarque.GridControl = this.dtgLineasOrden;
            this.gridViewEmbarque.Name = "gridViewEmbarque";
            this.gridViewEmbarque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIDProducto
            // 
            this.colIDProducto.Caption = "ID Producto";
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.OptionsColumn.ReadOnly = true;
            this.colIDProducto.Visible = true;
            this.colIDProducto.VisibleIndex = 0;
            // 
            // DescrProd
            // 
            this.DescrProd.Caption = "DescrProd";
            this.DescrProd.FieldName = "DescrProducto";
            this.DescrProd.Name = "DescrProd";
            this.DescrProd.OptionsColumn.ReadOnly = true;
            this.DescrProd.Visible = true;
            this.DescrProd.VisibleIndex = 1;
            this.DescrProd.Width = 608;
            // 
            // Presentacion
            // 
            this.Presentacion.Caption = "Presentacion";
            this.Presentacion.ColumnEdit = this.slkupPresentacion;
            this.Presentacion.FieldName = "IDUnidad";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.Visible = true;
            this.Presentacion.VisibleIndex = 2;
            // 
            // slkupPresentacion
            // 
            this.slkupPresentacion.AutoHeight = false;
            this.slkupPresentacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupPresentacion.Name = "slkupPresentacion";
            this.slkupPresentacion.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.OptionsColumn.ReadOnly = true;
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 3;
            this.Cantidad.Width = 109;
            // 
            // tabDetalle
            // 
            this.tabDetalle.Controls.Add(this.layoutControl2);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Size = new System.Drawing.Size(810, 285);
            this.tabDetalle.Text = "Detalle del Embarque";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnRellenar);
            this.layoutControl2.Controls.Add(this.dtgDetalleEmbarque);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(810, 285);
            this.layoutControl2.TabIndex = 3;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnRellenar
            // 
            this.btnRellenar.Image = ((System.Drawing.Image)(resources.GetObject("btnRellenar.Image")));
            this.btnRellenar.Location = new System.Drawing.Point(12, 12);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(76, 22);
            this.btnRellenar.StyleController = this.layoutControl2;
            this.btnRellenar.TabIndex = 2;
            this.btnRellenar.Text = "Sugerir";
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // dtgDetalleEmbarque
            // 
            this.dtgDetalleEmbarque.Location = new System.Drawing.Point(12, 38);
            this.dtgDetalleEmbarque.MainView = this.gridViewDetalleEmbarque;
            this.dtgDetalleEmbarque.MenuManager = this.ribbonControl1;
            this.dtgDetalleEmbarque.Name = "dtgDetalleEmbarque";
            this.dtgDetalleEmbarque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.slkupIDProducto,
            this.slkupDescrProducto});
            this.dtgDetalleEmbarque.Size = new System.Drawing.Size(786, 235);
            this.dtgDetalleEmbarque.TabIndex = 1;
            this.dtgDetalleEmbarque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleEmbarque});
            // 
            // gridViewDetalleEmbarque
            // 
            this.gridViewDetalleEmbarque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colPrecio,
            this.gridColumn3,
            this.colCantAceptada});
            this.gridViewDetalleEmbarque.GridControl = this.dtgDetalleEmbarque;
            this.gridViewDetalleEmbarque.Name = "gridViewDetalleEmbarque";
            this.gridViewDetalleEmbarque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Producto";
            this.gridColumn1.ColumnEdit = this.slkupIDProducto;
            this.gridColumn1.FieldName = "IDProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 81;
            // 
            // slkupIDProducto
            // 
            this.slkupIDProducto.AutoHeight = false;
            this.slkupIDProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupIDProducto.Name = "slkupIDProducto";
            this.slkupIDProducto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "DescrProd";
            this.gridColumn2.ColumnEdit = this.slkupDescrProducto;
            this.gridColumn2.FieldName = "IDProducto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 316;
            // 
            // slkupDescrProducto
            // 
            this.slkupDescrProducto.AutoHeight = false;
            this.slkupDescrProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupDescrProducto.Name = "slkupDescrProducto";
            this.slkupDescrProducto.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "PrecioUnitario";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            this.colPrecio.Width = 92;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cantidad Ordenada";
            this.gridColumn3.FieldName = "CantidadOrdenada";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 144;
            // 
            // colCantAceptada
            // 
            this.colCantAceptada.AppearanceCell.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.colCantAceptada.AppearanceCell.BackColor2 = System.Drawing.Color.MediumSpringGreen;
            this.colCantAceptada.AppearanceCell.Options.HighPriority = true;
            this.colCantAceptada.AppearanceCell.Options.UseBackColor = true;
            this.colCantAceptada.AppearanceHeader.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.colCantAceptada.AppearanceHeader.BackColor2 = System.Drawing.Color.MediumSpringGreen;
            this.colCantAceptada.AppearanceHeader.Options.UseBackColor = true;
            this.colCantAceptada.Caption = "Cant Aceptada";
            this.colCantAceptada.FieldName = "CantidadAceptada";
            this.colCantAceptada.Name = "colCantAceptada";
            this.colCantAceptada.Visible = true;
            this.colCantAceptada.VisibleIndex = 4;
            this.colCantAceptada.Width = 135;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(810, 285);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtgDetalleEmbarque;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(790, 239);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnRellenar;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(80, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(710, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabFactura
            // 
            this.tabFactura.Controls.Add(this.layoutControl3);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.PageVisible = false;
            this.tabFactura.Size = new System.Drawing.Size(810, 285);
            this.tabFactura.Text = "Factura Mercadería";
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.panelControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(810, 285);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGenerarDocCPFactura);
            this.panelControl1.Controls.Add(this.btnGuardarFactura);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtpFechaPoliza);
            this.panelControl1.Controls.Add(this.dtpFechaVence);
            this.panelControl1.Controls.Add(this.dtpFechaFactura);
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.txtMontoSeguro);
            this.panelControl1.Controls.Add(this.txtMontoFlete);
            this.panelControl1.Controls.Add(this.txtTotalMercaderia);
            this.panelControl1.Controls.Add(this.txtTipoCambio);
            this.panelControl1.Controls.Add(this.txtAsiento);
            this.panelControl1.Controls.Add(this.txtGuiaBL);
            this.panelControl1.Controls.Add(this.txtPoliza);
            this.panelControl1.Controls.Add(this.txtFactura);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(786, 261);
            this.panelControl1.TabIndex = 4;
            // 
            // btnGenerarDocCPFactura
            // 
            this.btnGenerarDocCPFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarDocCPFactura.Image")));
            this.btnGenerarDocCPFactura.Location = new System.Drawing.Point(91, 6);
            this.btnGenerarDocCPFactura.Name = "btnGenerarDocCPFactura";
            this.btnGenerarDocCPFactura.Size = new System.Drawing.Size(141, 23);
            this.btnGenerarDocCPFactura.TabIndex = 3;
            this.btnGenerarDocCPFactura.Text = "Generar Documento";
            this.btnGenerarDocCPFactura.Click += new System.EventHandler(this.btnGenerarDocCPFactura_Click);
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFactura.Image")));
            this.btnGuardarFactura.Location = new System.Drawing.Point(10, 6);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarFactura.TabIndex = 3;
            this.btnGuardarFactura.Text = "Guardar";
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(574, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Fecha Poliza:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(192, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fecha Vence:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(14, 208);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Monto Total:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 182);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Monto Seguro:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 156);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Monto Flete:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Valor Mercaderia:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(192, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(21, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "T/C:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(598, 82);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(40, 13);
            this.labelControl12.TabIndex = 2;
            this.labelControl12.Text = "Asiento:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(397, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Guia / BL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(397, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Poliza:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Factura:";
            // 
            // dtpFechaPoliza
            // 
            this.dtpFechaPoliza.EditValue = null;
            this.dtpFechaPoliza.Location = new System.Drawing.Point(645, 49);
            this.dtpFechaPoliza.Name = "dtpFechaPoliza";
            this.dtpFechaPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaPoliza.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaPoliza.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaPoliza.TabIndex = 1;
            // 
            // dtpFechaVence
            // 
            this.dtpFechaVence.EditValue = null;
            this.dtpFechaVence.Location = new System.Drawing.Point(263, 79);
            this.dtpFechaVence.Name = "dtpFechaVence";
            this.dtpFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaVence.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaVence.TabIndex = 1;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.EditValue = null;
            this.dtpFechaFactura.Location = new System.Drawing.Point(61, 49);
            this.dtpFechaFactura.MenuManager = this.ribbonControl1;
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFactura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFactura.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFactura.TabIndex = 1;
            this.dtpFechaFactura.EditValueChanged += new System.EventHandler(this.dtpFechaFactura_EditValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(104, 205);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // txtMontoSeguro
            // 
            this.txtMontoSeguro.Location = new System.Drawing.Point(104, 179);
            this.txtMontoSeguro.Name = "txtMontoSeguro";
            this.txtMontoSeguro.Properties.ReadOnly = true;
            this.txtMontoSeguro.Size = new System.Drawing.Size(100, 20);
            this.txtMontoSeguro.TabIndex = 0;
            // 
            // txtMontoFlete
            // 
            this.txtMontoFlete.Location = new System.Drawing.Point(104, 153);
            this.txtMontoFlete.Name = "txtMontoFlete";
            this.txtMontoFlete.Properties.Mask.EditMask = "n2";
            this.txtMontoFlete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMontoFlete.Properties.ReadOnly = true;
            this.txtMontoFlete.Size = new System.Drawing.Size(100, 20);
            this.txtMontoFlete.TabIndex = 0;
            // 
            // txtTotalMercaderia
            // 
            this.txtTotalMercaderia.Location = new System.Drawing.Point(104, 127);
            this.txtTotalMercaderia.Name = "txtTotalMercaderia";
            this.txtTotalMercaderia.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTotalMercaderia.Properties.Mask.EditMask = "n2";
            this.txtTotalMercaderia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalMercaderia.Properties.ReadOnly = true;
            this.txtTotalMercaderia.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMercaderia.TabIndex = 0;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(263, 53);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 0;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(645, 79);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Properties.ReadOnly = true;
            this.txtAsiento.Size = new System.Drawing.Size(100, 20);
            this.txtAsiento.TabIndex = 0;
            // 
            // txtGuiaBL
            // 
            this.txtGuiaBL.Location = new System.Drawing.Point(444, 79);
            this.txtGuiaBL.Name = "txtGuiaBL";
            this.txtGuiaBL.Size = new System.Drawing.Size(100, 20);
            this.txtGuiaBL.TabIndex = 0;
            // 
            // txtPoliza
            // 
            this.txtPoliza.Location = new System.Drawing.Point(444, 49);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(100, 20);
            this.txtPoliza.TabIndex = 0;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(62, 79);
            this.txtFactura.MenuManager = this.ribbonControl1;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 20);
            this.txtFactura.TabIndex = 0;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(810, 285);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.panelControl1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(790, 265);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // tabOtros
            // 
            this.tabOtros.Controls.Add(this.layoutControl4);
            this.tabOtros.Name = "tabOtros";
            this.tabOtros.Size = new System.Drawing.Size(810, 285);
            this.tabOtros.Text = "Otros Pagos / Obligaciones";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.dtgObligaciones);
            this.layoutControl4.Controls.Add(this.txtImpuesto);
            this.layoutControl4.Controls.Add(this.btnEliminarOtrosGastos);
            this.layoutControl4.Controls.Add(this.btnEditarOtrosPagos);
            this.layoutControl4.Controls.Add(this.btnAgregarOtrosPagos);
            this.layoutControl4.Controls.Add(this.btnCancelarOtrosPagos);
            this.layoutControl4.Controls.Add(this.btnGuardarOtrosPagos);
            this.layoutControl4.Controls.Add(this.slkupGastosOtrosPagos);
            this.layoutControl4.Controls.Add(this.slkupProveedorOtrosPagos);
            this.layoutControl4.Controls.Add(this.slkupMonedaOtrosPagos);
            this.layoutControl4.Controls.Add(this.txtMontoOtrosPagos);
            this.layoutControl4.Controls.Add(this.dtpFechaOtrosPagos);
            this.layoutControl4.Controls.Add(this.txtDocumentoOtrosPagos);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(0, 0);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup4;
            this.layoutControl4.Size = new System.Drawing.Size(810, 285);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(479, 72);
            this.txtImpuesto.MenuManager = this.ribbonControl1;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(95, 20);
            this.txtImpuesto.StyleController = this.layoutControl4;
            this.txtImpuesto.TabIndex = 16;
            // 
            // btnEliminarOtrosGastos
            // 
            this.btnEliminarOtrosGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOtrosGastos.Image")));
            this.btnEliminarOtrosGastos.Location = new System.Drawing.Point(313, 12);
            this.btnEliminarOtrosGastos.Name = "btnEliminarOtrosGastos";
            this.btnEliminarOtrosGastos.Size = new System.Drawing.Size(76, 22);
            this.btnEliminarOtrosGastos.StyleController = this.layoutControl4;
            this.btnEliminarOtrosGastos.TabIndex = 15;
            this.btnEliminarOtrosGastos.Text = "Eliminar";
            this.btnEliminarOtrosGastos.Click += new System.EventHandler(this.btnEliminarOtrosGastos_Click);
            // 
            // btnEditarOtrosPagos
            // 
            this.btnEditarOtrosPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarOtrosPagos.Image")));
            this.btnEditarOtrosPagos.Location = new System.Drawing.Point(83, 12);
            this.btnEditarOtrosPagos.Name = "btnEditarOtrosPagos";
            this.btnEditarOtrosPagos.Size = new System.Drawing.Size(66, 22);
            this.btnEditarOtrosPagos.StyleController = this.layoutControl4;
            this.btnEditarOtrosPagos.TabIndex = 14;
            this.btnEditarOtrosPagos.Text = "Editar";
            this.btnEditarOtrosPagos.Click += new System.EventHandler(this.btnEditarOtrosPagos_Click);
            // 
            // btnAgregarOtrosPagos
            // 
            this.btnAgregarOtrosPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOtrosPagos.Image")));
            this.btnAgregarOtrosPagos.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarOtrosPagos.Name = "btnAgregarOtrosPagos";
            this.btnAgregarOtrosPagos.Size = new System.Drawing.Size(67, 22);
            this.btnAgregarOtrosPagos.StyleController = this.layoutControl4;
            this.btnAgregarOtrosPagos.TabIndex = 13;
            this.btnAgregarOtrosPagos.Text = "Agregar";
            this.btnAgregarOtrosPagos.Click += new System.EventHandler(this.btnAgregarOtrosPagos_Click);
            // 
            // btnCancelarOtrosPagos
            // 
            this.btnCancelarOtrosPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOtrosPagos.Image")));
            this.btnCancelarOtrosPagos.Location = new System.Drawing.Point(153, 12);
            this.btnCancelarOtrosPagos.Name = "btnCancelarOtrosPagos";
            this.btnCancelarOtrosPagos.Size = new System.Drawing.Size(78, 22);
            this.btnCancelarOtrosPagos.StyleController = this.layoutControl4;
            this.btnCancelarOtrosPagos.TabIndex = 12;
            this.btnCancelarOtrosPagos.Text = "Cancelar";
            this.btnCancelarOtrosPagos.Click += new System.EventHandler(this.btnCancelarOtrosPagos_Click);
            // 
            // btnGuardarOtrosPagos
            // 
            this.btnGuardarOtrosPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarOtrosPagos.Image")));
            this.btnGuardarOtrosPagos.Location = new System.Drawing.Point(235, 12);
            this.btnGuardarOtrosPagos.Name = "btnGuardarOtrosPagos";
            this.btnGuardarOtrosPagos.Size = new System.Drawing.Size(74, 22);
            this.btnGuardarOtrosPagos.StyleController = this.layoutControl4;
            this.btnGuardarOtrosPagos.TabIndex = 11;
            this.btnGuardarOtrosPagos.Text = "Guardar";
            this.btnGuardarOtrosPagos.Click += new System.EventHandler(this.btnGuardarOtrosPagos_Click);
            // 
            // slkupGastosOtrosPagos
            // 
            this.slkupGastosOtrosPagos.Location = new System.Drawing.Point(639, 72);
            this.slkupGastosOtrosPagos.MenuManager = this.ribbonControl1;
            this.slkupGastosOtrosPagos.Name = "slkupGastosOtrosPagos";
            this.slkupGastosOtrosPagos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupGastosOtrosPagos.Properties.ReadOnly = true;
            this.slkupGastosOtrosPagos.Properties.View = this.searchLookUpEdit3View;
            this.slkupGastosOtrosPagos.Size = new System.Drawing.Size(159, 20);
            this.slkupGastosOtrosPagos.StyleController = this.layoutControl4;
            this.slkupGastosOtrosPagos.TabIndex = 10;
            // 
            // searchLookUpEdit3View
            // 
            this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // slkupProveedorOtrosPagos
            // 
            this.slkupProveedorOtrosPagos.Location = new System.Drawing.Point(639, 48);
            this.slkupProveedorOtrosPagos.MenuManager = this.ribbonControl1;
            this.slkupProveedorOtrosPagos.Name = "slkupProveedorOtrosPagos";
            this.slkupProveedorOtrosPagos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupProveedorOtrosPagos.Properties.ReadOnly = true;
            this.slkupProveedorOtrosPagos.Properties.View = this.searchLookUpEdit2View;
            this.slkupProveedorOtrosPagos.Size = new System.Drawing.Size(159, 20);
            this.slkupProveedorOtrosPagos.StyleController = this.layoutControl4;
            this.slkupProveedorOtrosPagos.TabIndex = 8;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // slkupMonedaOtrosPagos
            // 
            this.slkupMonedaOtrosPagos.Location = new System.Drawing.Point(73, 72);
            this.slkupMonedaOtrosPagos.MenuManager = this.ribbonControl1;
            this.slkupMonedaOtrosPagos.Name = "slkupMonedaOtrosPagos";
            this.slkupMonedaOtrosPagos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkupMonedaOtrosPagos.Properties.ReadOnly = true;
            this.slkupMonedaOtrosPagos.Properties.View = this.searchLookUpEdit1View;
            this.slkupMonedaOtrosPagos.Size = new System.Drawing.Size(165, 20);
            this.slkupMonedaOtrosPagos.StyleController = this.layoutControl4;
            this.slkupMonedaOtrosPagos.TabIndex = 7;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtMontoOtrosPagos
            // 
            this.txtMontoOtrosPagos.Location = new System.Drawing.Point(303, 72);
            this.txtMontoOtrosPagos.MenuManager = this.ribbonControl1;
            this.txtMontoOtrosPagos.Name = "txtMontoOtrosPagos";
            this.txtMontoOtrosPagos.Properties.ReadOnly = true;
            this.txtMontoOtrosPagos.Size = new System.Drawing.Size(111, 20);
            this.txtMontoOtrosPagos.StyleController = this.layoutControl4;
            this.txtMontoOtrosPagos.TabIndex = 6;
            // 
            // dtpFechaOtrosPagos
            // 
            this.dtpFechaOtrosPagos.EditValue = null;
            this.dtpFechaOtrosPagos.Location = new System.Drawing.Point(73, 48);
            this.dtpFechaOtrosPagos.MenuManager = this.ribbonControl1;
            this.dtpFechaOtrosPagos.Name = "dtpFechaOtrosPagos";
            this.dtpFechaOtrosPagos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaOtrosPagos.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaOtrosPagos.Properties.ReadOnly = true;
            this.dtpFechaOtrosPagos.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaOtrosPagos.StyleController = this.layoutControl4;
            this.dtpFechaOtrosPagos.TabIndex = 5;
            // 
            // txtDocumentoOtrosPagos
            // 
            this.txtDocumentoOtrosPagos.Location = new System.Drawing.Point(303, 48);
            this.txtDocumentoOtrosPagos.MenuManager = this.ribbonControl1;
            this.txtDocumentoOtrosPagos.Name = "txtDocumentoOtrosPagos";
            this.txtDocumentoOtrosPagos.Properties.ReadOnly = true;
            this.txtDocumentoOtrosPagos.Size = new System.Drawing.Size(271, 20);
            this.txtDocumentoOtrosPagos.StyleController = this.layoutControl4;
            this.txtDocumentoOtrosPagos.TabIndex = 4;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem11,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.emptySpaceItem5,
            this.emptySpaceItem8,
            this.layoutControlItem23,
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.emptySpaceItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(810, 285);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtDocumentoOtrosPagos;
            this.layoutControlItem10.Location = new System.Drawing.Point(230, 36);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem10.Text = "Documento:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtMontoOtrosPagos;
            this.layoutControlItem12.Location = new System.Drawing.Point(230, 60);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem12.Text = "Monto:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dtpFechaOtrosPagos;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem11.Text = "Fecha:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.slkupMonedaOtrosPagos;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem15.Text = "Moneda:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.slkupProveedorOtrosPagos;
            this.layoutControlItem16.Location = new System.Drawing.Point(566, 36);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(224, 24);
            this.layoutControlItem16.Text = "Proveedor:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(58, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(790, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.slkupGastosOtrosPagos;
            this.layoutControlItem18.Location = new System.Drawing.Point(566, 60);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(224, 24);
            this.layoutControlItem18.Text = "Gasto:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.btnGuardarOtrosPagos;
            this.layoutControlItem19.Location = new System.Drawing.Point(223, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(78, 26);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.btnCancelarOtrosPagos;
            this.layoutControlItem20.Location = new System.Drawing.Point(141, 0);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.btnAgregarOtrosPagos;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(71, 26);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.btnEditarOtrosPagos;
            this.layoutControlItem22.Location = new System.Drawing.Point(71, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(70, 26);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(381, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(409, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem8.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem8.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(790, 10);
            this.emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.btnEliminarOtrosGastos;
            this.layoutControlItem23.Location = new System.Drawing.Point(301, 0);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.txtImpuesto;
            this.layoutControlItem24.Location = new System.Drawing.Point(406, 60);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem24.Text = "Impuesto:";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(58, 13);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(467, 29);
            this.txtProveedor.MenuManager = this.ribbonControl1;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(361, 20);
            this.txtProveedor.StyleController = this.layoutControl1;
            this.txtProveedor.TabIndex = 7;
            // 
            // txtEmbarque
            // 
            this.txtEmbarque.Location = new System.Drawing.Point(99, 29);
            this.txtEmbarque.MenuManager = this.ribbonControl1;
            this.txtEmbarque.Name = "txtEmbarque";
            this.txtEmbarque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmbarque.Properties.Appearance.Options.UseFont = true;
            this.txtEmbarque.Properties.ReadOnly = true;
            this.txtEmbarque.Size = new System.Drawing.Size(265, 20);
            this.txtEmbarque.StyleController = this.layoutControl1;
            this.txtEmbarque.TabIndex = 5;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(99, 53);
            this.txtOrdenCompra.MenuManager = this.ribbonControl1;
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.ReadOnly = true;
            this.txtOrdenCompra.Size = new System.Drawing.Size(265, 20);
            this.txtOrdenCompra.StyleController = this.layoutControl1;
            this.txtOrdenCompra.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem14,
            this.emptySpaceItem6,
            this.emptySpaceItem4,
            this.layoutControlItem13,
            this.emptySpaceItem7,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(840, 439);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtOrdenCompra;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(356, 24);
            this.layoutControlItem1.Text = "Orden Compra:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtProveedor;
            this.layoutControlItem4.Location = new System.Drawing.Point(368, 17);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(452, 24);
            this.layoutControlItem4.Text = "Proveedor:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xtraTabControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(820, 317);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 89);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(820, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dtpFecha;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(356, 24);
            this.layoutControlItem6.Text = "Fecha:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dtpFechaEmbarque;
            this.layoutControlItem7.Location = new System.Drawing.Point(368, 41);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(452, 24);
            this.layoutControlItem7.Text = "Fecha Embarque:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtBodega;
            this.layoutControlItem14.Location = new System.Drawing.Point(368, 65);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(452, 24);
            this.layoutControlItem14.Text = "Bodega:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(84, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(356, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(12, 89);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(368, 0);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(0, 17);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 17);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(339, 17);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.Text = "Asiento Contable :";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(84, 0);
            this.emptySpaceItem4.TextVisible = true;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.linkAsiento;
            this.layoutControlItem13.Location = new System.Drawing.Point(707, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(113, 17);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(356, 17);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtEmbarque;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(356, 24);
            this.layoutControlItem2.Text = "Embarque:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // dtgObligaciones
            // 
            this.dtgObligaciones.Location = new System.Drawing.Point(12, 106);
            this.dtgObligaciones.MainView = this.gridViewObligaciones;
            this.dtgObligaciones.MenuManager = this.ribbonControl1;
            this.dtgObligaciones.Name = "dtgObligaciones";
            this.dtgObligaciones.Size = new System.Drawing.Size(786, 167);
            this.dtgObligaciones.TabIndex = 17;
            this.dtgObligaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewObligaciones});
            // 
            // gridViewObligaciones
            // 
            this.gridViewObligaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaDocumento,
            this.colNumDocumento,
            this.colDescrGasto,
            this.Moneda,
            this.colSubTotalG,
            this.colPorcImpuesto,
            this.colMontoTotal});
            this.gridViewObligaciones.GridControl = this.dtgObligaciones;
            this.gridViewObligaciones.Name = "gridViewObligaciones";
            this.gridViewObligaciones.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.dtgObligaciones;
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(790, 171);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // colFechaDocumento
            // 
            this.colFechaDocumento.Caption = "Fecha";
            this.colFechaDocumento.FieldName = "FechaDocumento";
            this.colFechaDocumento.Name = "colFechaDocumento";
            this.colFechaDocumento.OptionsColumn.ReadOnly = true;
            this.colFechaDocumento.Visible = true;
            this.colFechaDocumento.VisibleIndex = 0;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.Caption = "Documento";
            this.colNumDocumento.FieldName = "Documento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.OptionsColumn.ReadOnly = true;
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 1;
            // 
            // colDescrGasto
            // 
            this.colDescrGasto.Caption = "Descr Gasto";
            this.colDescrGasto.FieldName = "DescrGasto";
            this.colDescrGasto.Name = "colDescrGasto";
            this.colDescrGasto.OptionsColumn.ReadOnly = true;
            this.colDescrGasto.Visible = true;
            this.colDescrGasto.VisibleIndex = 2;
            // 
            // Moneda
            // 
            this.Moneda.Caption = "Moneda";
            this.Moneda.FieldName = "DescrMoneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.OptionsColumn.ReadOnly = true;
            this.Moneda.Visible = true;
            this.Moneda.VisibleIndex = 3;
            // 
            // colSubTotalG
            // 
            this.colSubTotalG.Caption = "Sub Total";
            this.colSubTotalG.FieldName = "SubTotal";
            this.colSubTotalG.Name = "colSubTotalG";
            this.colSubTotalG.OptionsColumn.ReadOnly = true;
            this.colSubTotalG.Visible = true;
            this.colSubTotalG.VisibleIndex = 4;
            // 
            // colPorcImpuesto
            // 
            this.colPorcImpuesto.Caption = "% Impuesto";
            this.colPorcImpuesto.FieldName = "PorcImpuesto";
            this.colPorcImpuesto.Name = "colPorcImpuesto";
            this.colPorcImpuesto.OptionsColumn.ReadOnly = true;
            this.colPorcImpuesto.Visible = true;
            this.colPorcImpuesto.VisibleIndex = 5;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.Caption = "Total";
            this.colMontoTotal.FieldName = "MontoTotal";
            this.colMontoTotal.Name = "colMontoTotal";
            this.colMontoTotal.OptionsColumn.ReadOnly = true;
            this.colMontoTotal.Visible = true;
            this.colMontoTotal.VisibleIndex = 6;
            // 
            // frmEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 582);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmEmbarque";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarques";
            this.Load += new System.EventHandler(this.frmEmbarque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmbarque.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmbarque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.tabLineas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLineasOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmbarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleEmbarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEmbarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupIDProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupDescrProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.tabFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPoliza.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFactura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFlete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMercaderia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuiaBL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.tabOtros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupGastosOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupProveedorOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkupMonedaOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaOtrosPagos.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentoOtrosPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmbarque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgObligaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewObligaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dtpFechaEmbarque;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabLineas;
        private DevExpress.XtraGrid.GridControl dtgLineasOrden;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmbarque;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.TextEdit txtEmbarque;
        private DevExpress.XtraEditors.TextEdit txtOrdenCompra;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkAsiento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn DescrProd;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraEditors.TextEdit txtBodega;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraBars.BarButtonItem btnAplicar;
        private DevExpress.XtraTab.XtraTabPage tabDetalle;
        private DevExpress.XtraGrid.GridControl dtgDetalleEmbarque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleEmbarque;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupIDProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupDescrProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantAceptada;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnRellenar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraTab.XtraTabPage tabFactura;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpFechaPoliza;
        private DevExpress.XtraEditors.DateEdit dtpFechaVence;
        private DevExpress.XtraEditors.DateEdit dtpFechaFactura;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtMontoSeguro;
        private DevExpress.XtraEditors.TextEdit txtMontoFlete;
        private DevExpress.XtraEditors.TextEdit txtTotalMercaderia;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.TextEdit txtGuiaBL;
        private DevExpress.XtraEditors.TextEdit txtPoliza;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraBars.BarButtonItem btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarFactura;
        private DevExpress.XtraEditors.SimpleButton btnGenerarDocCPFactura;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtAsiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraTab.XtraTabPage tabOtros;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit slkupProveedorOtrosPagos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit slkupMonedaOtrosPagos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtMontoOtrosPagos;
        private DevExpress.XtraEditors.DateEdit dtpFechaOtrosPagos;
        private DevExpress.XtraEditors.TextEdit txtDocumentoOtrosPagos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SearchLookUpEdit slkupGastosOtrosPagos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraEditors.SimpleButton btnEditarOtrosPagos;
        private DevExpress.XtraEditors.SimpleButton btnAgregarOtrosPagos;
        private DevExpress.XtraEditors.SimpleButton btnCancelarOtrosPagos;
        private DevExpress.XtraEditors.SimpleButton btnGuardarOtrosPagos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.SimpleButton btnEliminarOtrosGastos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraBars.BarButtonItem btnRecepcionMercaderia;
        private DevExpress.XtraGrid.Columns.GridColumn Presentacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit slkupPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private Util.S4UGridControl dtgObligaciones;
        private Util.MyGridView gridViewObligaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrGasto;
        private DevExpress.XtraGrid.Columns.GridColumn Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalG;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;

    }
}