<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemisionBodega
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemisionBodega))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnRemisionar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblIDPedido = New DevExpress.XtraEditors.LabelControl()
        Me.lblNombreClientePedido = New DevExpress.XtraEditors.LabelControl()
        Me.btnRegresar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtgDetallePedido = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDetallePedido = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDProductoDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantLote = New DevExpress.XtraEditors.TextEdit()
        Me.slkupLote = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Lote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVenceEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GroupMenu = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.groupModify = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dtgPedidosProceso = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPedidoInProcess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPedidoProceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreProceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEnProceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtgPedidos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPedidos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.dtgDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slkupLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupModify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPedidosProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPedidoInProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LayoutControl2)
        Me.LayoutControl1.Controls.Add(Me.dtgPedidosProceso)
        Me.LayoutControl1.Controls.Add(Me.dtgPedidos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(237, -6, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1033, 750)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.btnRemisionar)
        Me.LayoutControl2.Controls.Add(Me.lblIDPedido)
        Me.LayoutControl2.Controls.Add(Me.lblNombreClientePedido)
        Me.LayoutControl2.Controls.Add(Me.btnRegresar)
        Me.LayoutControl2.Controls.Add(Me.btnCancelar)
        Me.LayoutControl2.Controls.Add(Me.btnModificar)
        Me.LayoutControl2.Controls.Add(Me.dtgDetallePedido)
        Me.LayoutControl2.Controls.Add(Me.btnGuardar)
        Me.LayoutControl2.Controls.Add(Me.btnEliminar)
        Me.LayoutControl2.Controls.Add(Me.btnEditar)
        Me.LayoutControl2.Controls.Add(Me.btnAgregar)
        Me.LayoutControl2.Controls.Add(Me.txtCantLote)
        Me.LayoutControl2.Controls.Add(Me.slkupLote)
        Me.LayoutControl2.Controls.Add(Me.txtProducto)
        Me.LayoutControl2.Controls.Add(Me.txtCantidad)
        Me.LayoutControl2.Location = New System.Drawing.Point(12, 326)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(823, 6, 250, 350)
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(1009, 412)
        Me.LayoutControl2.TabIndex = 6
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'btnRemisionar
        '
        Me.btnRemisionar.Image = CType(resources.GetObject("btnRemisionar.Image"), System.Drawing.Image)
        Me.btnRemisionar.Location = New System.Drawing.Point(901, 74)
        Me.btnRemisionar.Name = "btnRemisionar"
        Me.btnRemisionar.Size = New System.Drawing.Size(96, 38)
        Me.btnRemisionar.StyleController = Me.LayoutControl2
        Me.btnRemisionar.TabIndex = 20
        Me.btnRemisionar.Text = "Remisionar"
        '
        'lblIDPedido
        '
        Me.lblIDPedido.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPedido.Location = New System.Drawing.Point(93, 116)
        Me.lblIDPedido.Name = "lblIDPedido"
        Me.lblIDPedido.Size = New System.Drawing.Size(28, 16)
        Me.lblIDPedido.StyleController = Me.LayoutControl2
        Me.lblIDPedido.TabIndex = 19
        Me.lblIDPedido.Text = "-- --"
        '
        'lblNombreClientePedido
        '
        Me.lblNombreClientePedido.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreClientePedido.Location = New System.Drawing.Point(150, 116)
        Me.lblNombreClientePedido.Name = "lblNombreClientePedido"
        Me.lblNombreClientePedido.Size = New System.Drawing.Size(28, 16)
        Me.lblNombreClientePedido.StyleController = Me.LayoutControl2
        Me.lblNombreClientePedido.TabIndex = 17
        Me.lblNombreClientePedido.Text = "-- --"
        '
        'btnRegresar
        '
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(881, 32)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(116, 38)
        Me.btnRegresar.StyleController = Me.LayoutControl2
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "Regresar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(431, 32)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 38)
        Me.btnCancelar.StyleController = Me.LayoutControl2
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(12, 74)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 38)
        Me.btnModificar.StyleController = Me.LayoutControl2
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        '
        'dtgDetallePedido
        '
        Me.dtgDetallePedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetallePedido.Location = New System.Drawing.Point(12, 184)
        Me.dtgDetallePedido.MainView = Me.GridViewDetallePedido
        Me.dtgDetallePedido.Name = "dtgDetallePedido"
        Me.dtgDetallePedido.Size = New System.Drawing.Size(985, 216)
        Me.dtgDetallePedido.TabIndex = 13
        Me.dtgDetallePedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetallePedido})
        '
        'GridViewDetallePedido
        '
        Me.GridViewDetallePedido.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDetallePedido.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewDetallePedido.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDetallePedido.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewDetallePedido.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewDetallePedido.Appearance.Row.Options.UseFont = True
        Me.GridViewDetallePedido.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProductoDetalle, Me.colDescr, Me.colLote, Me.colFechaVence, Me.colCantidad})
        Me.GridViewDetallePedido.GridControl = Me.dtgDetallePedido
        Me.GridViewDetallePedido.Name = "GridViewDetallePedido"
        Me.GridViewDetallePedido.OptionsBehavior.ReadOnly = True
        Me.GridViewDetallePedido.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewDetallePedido.OptionsView.ShowGroupPanel = False
        '
        'colIDProductoDetalle
        '
        Me.colIDProductoDetalle.Caption = "IDProducto"
        Me.colIDProductoDetalle.FieldName = "IDProducto"
        Me.colIDProductoDetalle.Name = "colIDProductoDetalle"
        Me.colIDProductoDetalle.Visible = True
        Me.colIDProductoDetalle.VisibleIndex = 0
        Me.colIDProductoDetalle.Width = 93
        '
        'colDescr
        '
        Me.colDescr.Caption = "Descripción"
        Me.colDescr.FieldName = "Descr"
        Me.colDescr.Name = "colDescr"
        Me.colDescr.Visible = True
        Me.colDescr.VisibleIndex = 1
        Me.colDescr.Width = 537
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "LoteProveedor"
        Me.colLote.Name = "colLote"
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 2
        Me.colLote.Width = 91
        '
        'colFechaVence
        '
        Me.colFechaVence.Caption = "Fecha Vence"
        Me.colFechaVence.FieldName = "FechaVencimiento"
        Me.colFechaVence.Name = "colFechaVence"
        Me.colFechaVence.Visible = True
        Me.colFechaVence.VisibleIndex = 3
        Me.colFechaVence.Width = 116
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 4
        Me.colCantidad.Width = 130
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(320, 32)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(107, 38)
        Me.btnGuardar.StyleController = Me.LayoutControl2
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(112, 32)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 38)
        Me.btnEliminar.StyleController = Me.LayoutControl2
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(12, 32)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 38)
        Me.btnEditar.StyleController = Me.LayoutControl2
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(213, 32)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(103, 38)
        Me.btnAgregar.StyleController = Me.LayoutControl2
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        '
        'txtCantLote
        '
        Me.txtCantLote.Enabled = False
        Me.txtCantLote.Location = New System.Drawing.Point(742, 160)
        Me.txtCantLote.Name = "txtCantLote"
        Me.txtCantLote.Size = New System.Drawing.Size(255, 20)
        Me.txtCantLote.StyleController = Me.LayoutControl2
        Me.txtCantLote.TabIndex = 7
        '
        'slkupLote
        '
        Me.slkupLote.EditValue = "--"
        Me.slkupLote.Enabled = False
        Me.slkupLote.Location = New System.Drawing.Point(89, 160)
        Me.slkupLote.Name = "slkupLote"
        Me.slkupLote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slkupLote.Properties.DisplayMember = "LoteProveedor"
        Me.slkupLote.Properties.NullText = "-- --"
        Me.slkupLote.Properties.ValueMember = "IDLote"
        Me.slkupLote.Properties.View = Me.SearchLookUpEdit1View
        Me.slkupLote.Size = New System.Drawing.Size(572, 20)
        Me.slkupLote.StyleController = Me.LayoutControl2
        Me.slkupLote.TabIndex = 6
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Lote, Me.colFechaVenceEdit})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Lote
        '
        Me.Lote.Caption = "Lote"
        Me.Lote.FieldName = "LoteProveedor"
        Me.Lote.Name = "Lote"
        Me.Lote.Visible = True
        Me.Lote.VisibleIndex = 0
        '
        'colFechaVenceEdit
        '
        Me.colFechaVenceEdit.Caption = "F. Vence"
        Me.colFechaVenceEdit.FieldName = "FechaVencimiento"
        Me.colFechaVenceEdit.Name = "colFechaVenceEdit"
        Me.colFechaVenceEdit.Visible = True
        Me.colFechaVenceEdit.VisibleIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(89, 136)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Properties.Appearance.Options.UseFont = True
        Me.txtProducto.Properties.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(572, 20)
        Me.txtProducto.StyleController = Me.LayoutControl2
        Me.txtProducto.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(742, 136)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(255, 20)
        Me.txtCantidad.StyleController = Me.LayoutControl2
        Me.txtCantidad.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem12, Me.EmptySpaceItem4, Me.GroupMenu, Me.groupModify, Me.LayoutControlItem16, Me.EmptySpaceItem7, Me.LayoutControlItem18, Me.EmptySpaceItem6, Me.EmptySpaceItem8})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1009, 412)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCantidad
        Me.LayoutControlItem4.Location = New System.Drawing.Point(653, 124)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Cantidad Total:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtProducto
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(653, 24)
        Me.LayoutControlItem5.Text = "Producto:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.slkupLote
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(653, 24)
        Me.LayoutControlItem6.Text = "Lote:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtCantLote
        Me.LayoutControlItem7.Location = New System.Drawing.Point(653, 148)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem7.Text = "Cant Lote:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.dtgDetallePedido
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(989, 220)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem4.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.EmptySpaceItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(989, 20)
        Me.EmptySpaceItem4.Text = "Detalle del Pedido"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(74, 0)
        Me.EmptySpaceItem4.TextVisible = True
        '
        'GroupMenu
        '
        Me.GroupMenu.GroupBordersVisible = False
        Me.GroupMenu.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem9, Me.LayoutControlItem13, Me.EmptySpaceItem1, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.GroupMenu.Location = New System.Drawing.Point(0, 20)
        Me.GroupMenu.Name = "GroupMenu"
        Me.GroupMenu.Size = New System.Drawing.Size(989, 42)
        Me.GroupMenu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnEditar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnEliminar
        Me.LayoutControlItem11.Location = New System.Drawing.Point(100, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnAgregar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(201, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnGuardar
        Me.LayoutControlItem13.Location = New System.Drawing.Point(308, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(509, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(360, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnCancelar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(419, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnRegresar
        Me.LayoutControlItem15.Location = New System.Drawing.Point(869, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'groupModify
        '
        Me.groupModify.GroupBordersVisible = False
        Me.groupModify.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.EmptySpaceItem5, Me.LayoutControlItem17})
        Me.groupModify.Location = New System.Drawing.Point(0, 62)
        Me.groupModify.Name = "groupModify"
        Me.groupModify.Size = New System.Drawing.Size(989, 42)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnModificar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(100, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(789, 42)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnRemisionar
        Me.LayoutControlItem17.Location = New System.Drawing.Point(889, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.lblNombreClientePedido
        Me.LayoutControlItem16.Location = New System.Drawing.Point(138, 104)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(32, 20)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(170, 104)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(819, 20)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.lblIDPedido
        Me.LayoutControlItem18.Location = New System.Drawing.Point(81, 104)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(32, 20)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(113, 104)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(25, 20)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 104)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(81, 20)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'dtgPedidosProceso
        '
        Me.dtgPedidosProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPedidosProceso.Location = New System.Drawing.Point(490, 39)
        Me.dtgPedidosProceso.MainView = Me.GridViewPedidoInProcess
        Me.dtgPedidosProceso.Name = "dtgPedidosProceso"
        Me.dtgPedidosProceso.Size = New System.Drawing.Size(531, 283)
        Me.dtgPedidosProceso.TabIndex = 5
        Me.dtgPedidosProceso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPedidoInProcess})
        '
        'GridViewPedidoInProcess
        '
        Me.GridViewPedidoInProcess.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidoInProcess.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewPedidoInProcess.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewPedidoInProcess.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidoInProcess.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewPedidoInProcess.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidoInProcess.Appearance.Row.Options.UseBackColor = True
        Me.GridViewPedidoInProcess.Appearance.Row.Options.UseFont = True
        Me.GridViewPedidoInProcess.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewPedidoInProcess.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridViewPedidoInProcess.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPedidoProceso, Me.colNombreProceso, Me.colFechaEnProceso})
        Me.GridViewPedidoInProcess.GridControl = Me.dtgPedidosProceso
        Me.GridViewPedidoInProcess.Name = "GridViewPedidoInProcess"
        Me.GridViewPedidoInProcess.OptionsBehavior.Editable = False
        Me.GridViewPedidoInProcess.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridViewPedidoInProcess.OptionsView.ShowGroupPanel = False
        '
        'colIDPedidoProceso
        '
        Me.colIDPedidoProceso.Caption = "IDPedido"
        Me.colIDPedidoProceso.FieldName = "IDPedido"
        Me.colIDPedidoProceso.Name = "colIDPedidoProceso"
        Me.colIDPedidoProceso.Visible = True
        Me.colIDPedidoProceso.VisibleIndex = 0
        Me.colIDPedidoProceso.Width = 84
        '
        'colNombreProceso
        '
        Me.colNombreProceso.Caption = "Nombre Cliente"
        Me.colNombreProceso.FieldName = "Cliente"
        Me.colNombreProceso.Name = "colNombreProceso"
        Me.colNombreProceso.Visible = True
        Me.colNombreProceso.VisibleIndex = 1
        Me.colNombreProceso.Width = 322
        '
        'colFechaEnProceso
        '
        Me.colFechaEnProceso.Caption = "Fecha"
        Me.colFechaEnProceso.FieldName = "Fecha"
        Me.colFechaEnProceso.Name = "colFechaEnProceso"
        Me.colFechaEnProceso.Visible = True
        Me.colFechaEnProceso.VisibleIndex = 2
        Me.colFechaEnProceso.Width = 89
        '
        'dtgPedidos
        '
        Me.dtgPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPedidos.Location = New System.Drawing.Point(12, 39)
        Me.dtgPedidos.MainView = Me.GridViewPedidos
        Me.dtgPedidos.Name = "dtgPedidos"
        Me.dtgPedidos.Size = New System.Drawing.Size(474, 283)
        Me.dtgPedidos.TabIndex = 4
        Me.dtgPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPedidos})
        '
        'GridViewPedidos
        '
        Me.GridViewPedidos.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidos.Appearance.FocusedCell.Options.UseFont = True
        Me.GridViewPedidos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewPedidos.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewPedidos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidos.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewPedidos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPedidos.Appearance.Row.Options.UseBackColor = True
        Me.GridViewPedidos.Appearance.Row.Options.UseFont = True
        Me.GridViewPedidos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewPedidos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridViewPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPedido, Me.colNombreCliente, Me.colFecha})
        Me.GridViewPedidos.GridControl = Me.dtgPedidos
        Me.GridViewPedidos.Name = "GridViewPedidos"
        Me.GridViewPedidos.OptionsBehavior.Editable = False
        Me.GridViewPedidos.OptionsBehavior.ReadOnly = True
        Me.GridViewPedidos.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridViewPedidos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewPedidos.OptionsView.ShowGroupPanel = False
        '
        'colIDPedido
        '
        Me.colIDPedido.Caption = "IDPedido"
        Me.colIDPedido.FieldName = "IDPedido"
        Me.colIDPedido.Name = "colIDPedido"
        Me.colIDPedido.Visible = True
        Me.colIDPedido.VisibleIndex = 0
        Me.colIDPedido.Width = 80
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Caption = "Nombre Cliente"
        Me.colNombreCliente.FieldName = "Cliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 1
        Me.colNombreCliente.Width = 265
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 2
        Me.colFecha.Width = 108
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1033, 750)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dtgPedidos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(478, 287)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtgPedidosProceso
        Me.LayoutControlItem2.Location = New System.Drawing.Point(478, 27)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(535, 287)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LayoutControl2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 314)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1013, 416)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem2.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(478, 27)
        Me.EmptySpaceItem2.Text = "Cola de Pedidos"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem2.TextVisible = True
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmptySpaceItem3.AppearanceItemCaption.Options.UseFont = True
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(478, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(535, 27)
        Me.EmptySpaceItem3.Text = "Pedidos en Proceso"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem3.TextVisible = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImprimir, Me.btnRefrescar})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefrescar)})
        Me.Bar1.Text = "Tools"
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "Imprimir"
        Me.btnImprimir.Glyph = CType(resources.GetObject("btnImprimir.Glyph"), System.Drawing.Image)
        Me.btnImprimir.Id = 0
        Me.btnImprimir.LargeGlyph = CType(resources.GetObject("btnImprimir.LargeGlyph"), System.Drawing.Image)
        Me.btnImprimir.Name = "btnImprimir"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 1
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1033, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 797)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1033, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 750)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1033, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 750)
        '
        'frmRemisionBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 797)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRemisionBodega"
        Me.Text = "Entrega de Productos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.dtgDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slkupLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupModify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPedidosProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPedidoInProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dtgPedidosProceso As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPedidoInProcess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtgPedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtCantLote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents slkupLote As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colIDPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPedidoProceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreProceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEnProceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtgDetallePedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetallePedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupMenu As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents groupModify As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVenceEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProductoDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRegresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblIDPedido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombreClientePedido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnRemisionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
End Class
