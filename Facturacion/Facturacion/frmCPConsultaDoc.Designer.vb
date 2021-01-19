<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPConsultaDoc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPConsultaDoc))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEditNoContabilizados = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarConsulta = New DevExpress.XtraBars.Bar()
        Me.BarButtonItemNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemAplicar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemAplicaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemAsiento = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemContabilizar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDocumento = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemLimpiaFiltro = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.CheckEditContabilizados = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEditSaldos = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditNoAprobados = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditAprobados = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditNoAnulados = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditAnulados = New DevExpress.XtraEditors.CheckEdit()
        Me.DateEditDesde = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditHasta = New DevExpress.XtraEditors.DateEdit()
        Me.SearchLookUpEditVendedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEditSubTipo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEditClase = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.btnCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Aprobado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDClase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDSubTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Asiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoOriginal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaldoDebito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaldoCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConceptoSistema = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConceptoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoCambio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDVendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrigenExterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Anulado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEditNoContabilizados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditContabilizados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditSaldos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditNoAprobados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditAprobados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditNoAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditSubTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditClase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LayoutControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1110, 113)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Filtro General de Documentos"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEditNoContabilizados)
        Me.LayoutControl1.Controls.Add(Me.CheckEditContabilizados)
        Me.LayoutControl1.Controls.Add(Me.txtDocumento)
        Me.LayoutControl1.Controls.Add(Me.CheckEditSaldos)
        Me.LayoutControl1.Controls.Add(Me.CheckEditNoAprobados)
        Me.LayoutControl1.Controls.Add(Me.CheckEditAprobados)
        Me.LayoutControl1.Controls.Add(Me.CheckEditNoAnulados)
        Me.LayoutControl1.Controls.Add(Me.CheckEditAnulados)
        Me.LayoutControl1.Controls.Add(Me.DateEditDesde)
        Me.LayoutControl1.Controls.Add(Me.DateEditHasta)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEditVendedor)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEditSubTipo)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEditClase)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Controls.Add(Me.btnCliente)
        Me.LayoutControl1.Location = New System.Drawing.Point(5, 23)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(257, 426, 590, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1087, 119)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEditNoContabilizados
        '
        Me.CheckEditNoContabilizados.Location = New System.Drawing.Point(870, 38)
        Me.CheckEditNoContabilizados.MenuManager = Me.BarManager1
        Me.CheckEditNoContabilizados.Name = "CheckEditNoContabilizados"
        Me.CheckEditNoContabilizados.Properties.Caption = "No Contabilizados"
        Me.CheckEditNoContabilizados.Size = New System.Drawing.Size(109, 19)
        Me.CheckEditNoContabilizados.StyleController = Me.LayoutControl1
        Me.CheckEditNoContabilizados.TabIndex = 21
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.BarConsulta, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItemAprobar, Me.BarButtonItemAplicar, Me.BarButtonItemAsiento, Me.BarButtonItemRefresh, Me.BarButtonItemContabilizar, Me.BarButtonItemLimpiaFiltro, Me.BarButtonItemAplicaciones, Me.BarButtonItemDocumento, Me.BarButtonItemNuevo, Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.BarConsulta
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'BarConsulta
        '
        Me.BarConsulta.BarAppearance.Pressed.Options.UseTextOptions = True
        Me.BarConsulta.BarAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BarConsulta.BarName = "Main menu"
        Me.BarConsulta.DockCol = 0
        Me.BarConsulta.DockRow = 0
        Me.BarConsulta.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarConsulta.FloatLocation = New System.Drawing.Point(60, 151)
        Me.BarConsulta.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemAprobar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemAplicar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemAplicaciones), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemAsiento), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemContabilizar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemDocumento), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemLimpiaFiltro), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemRefresh)})
        Me.BarConsulta.OptionsBar.MultiLine = True
        Me.BarConsulta.OptionsBar.UseWholeRow = True
        Me.BarConsulta.Text = "Main menu"
        '
        'BarButtonItemNuevo
        '
        Me.BarButtonItemNuevo.Caption = "Nuevo Documento"
        Me.BarButtonItemNuevo.Id = 8
        Me.BarButtonItemNuevo.Name = "BarButtonItemNuevo"
        '
        'BarButtonItemAprobar
        '
        Me.BarButtonItemAprobar.Caption = "Aprobar"
        Me.BarButtonItemAprobar.Id = 0
        Me.BarButtonItemAprobar.Name = "BarButtonItemAprobar"
        '
        'BarButtonItemAplicar
        '
        Me.BarButtonItemAplicar.Caption = "Aplicar"
        Me.BarButtonItemAplicar.Glyph = CType(resources.GetObject("BarButtonItemAplicar.Glyph"), System.Drawing.Image)
        Me.BarButtonItemAplicar.Id = 1
        Me.BarButtonItemAplicar.Name = "BarButtonItemAplicar"
        '
        'BarButtonItemAplicaciones
        '
        Me.BarButtonItemAplicaciones.Caption = "Ver Aplicaciones"
        Me.BarButtonItemAplicaciones.Id = 6
        Me.BarButtonItemAplicaciones.Name = "BarButtonItemAplicaciones"
        '
        'BarButtonItemAsiento
        '
        Me.BarButtonItemAsiento.Caption = "Ver Asiento Contable"
        Me.BarButtonItemAsiento.Id = 2
        Me.BarButtonItemAsiento.Name = "BarButtonItemAsiento"
        '
        'BarButtonItemContabilizar
        '
        Me.BarButtonItemContabilizar.Caption = "Contabilizar"
        Me.BarButtonItemContabilizar.Id = 4
        Me.BarButtonItemContabilizar.Name = "BarButtonItemContabilizar"
        '
        'BarButtonItemDocumento
        '
        Me.BarButtonItemDocumento.Caption = "Ver Documento"
        Me.BarButtonItemDocumento.Id = 7
        Me.BarButtonItemDocumento.Name = "BarButtonItemDocumento"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Anular Documento"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItemLimpiaFiltro
        '
        Me.BarButtonItemLimpiaFiltro.Caption = "Limpiar Filtro"
        Me.BarButtonItemLimpiaFiltro.Id = 5
        Me.BarButtonItemLimpiaFiltro.Name = "BarButtonItemLimpiaFiltro"
        '
        'BarButtonItemRefresh
        '
        Me.BarButtonItemRefresh.Caption = "Refrescar Filtro"
        Me.BarButtonItemRefresh.Id = 3
        Me.BarButtonItemRefresh.Name = "BarButtonItemRefresh"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1134, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 709)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1134, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 669)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1134, 40)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 669)
        '
        'CheckEditContabilizados
        '
        Me.CheckEditContabilizados.Location = New System.Drawing.Point(773, 38)
        Me.CheckEditContabilizados.MenuManager = Me.BarManager1
        Me.CheckEditContabilizados.Name = "CheckEditContabilizados"
        Me.CheckEditContabilizados.Properties.Caption = "Contabilizados"
        Me.CheckEditContabilizados.Size = New System.Drawing.Size(93, 19)
        Me.CheckEditContabilizados.StyleController = Me.LayoutControl1
        Me.CheckEditContabilizados.TabIndex = 20
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(69, 38)
        Me.txtDocumento.MenuManager = Me.BarManager1
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(95, 20)
        Me.txtDocumento.StyleController = Me.LayoutControl1
        Me.txtDocumento.TabIndex = 19
        '
        'CheckEditSaldos
        '
        Me.CheckEditSaldos.Location = New System.Drawing.Point(983, 38)
        Me.CheckEditSaldos.MenuManager = Me.BarManager1
        Me.CheckEditSaldos.Name = "CheckEditSaldos"
        Me.CheckEditSaldos.Properties.Caption = "Saldos <> 0"
        Me.CheckEditSaldos.Size = New System.Drawing.Size(82, 19)
        Me.CheckEditSaldos.StyleController = Me.LayoutControl1
        Me.CheckEditSaldos.TabIndex = 18
        '
        'CheckEditNoAprobados
        '
        Me.CheckEditNoAprobados.Location = New System.Drawing.Point(677, 38)
        Me.CheckEditNoAprobados.Name = "CheckEditNoAprobados"
        Me.CheckEditNoAprobados.Properties.Caption = "No Aprobados"
        Me.CheckEditNoAprobados.Size = New System.Drawing.Size(92, 19)
        Me.CheckEditNoAprobados.StyleController = Me.LayoutControl1
        Me.CheckEditNoAprobados.TabIndex = 17
        '
        'CheckEditAprobados
        '
        Me.CheckEditAprobados.Location = New System.Drawing.Point(598, 38)
        Me.CheckEditAprobados.Name = "CheckEditAprobados"
        Me.CheckEditAprobados.Properties.Caption = "Aprobados"
        Me.CheckEditAprobados.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.CheckEditAprobados.Size = New System.Drawing.Size(75, 19)
        Me.CheckEditAprobados.StyleController = Me.LayoutControl1
        Me.CheckEditAprobados.TabIndex = 16
        '
        'CheckEditNoAnulados
        '
        Me.CheckEditNoAnulados.Location = New System.Drawing.Point(511, 38)
        Me.CheckEditNoAnulados.Name = "CheckEditNoAnulados"
        Me.CheckEditNoAnulados.Properties.Caption = "No Anulados"
        Me.CheckEditNoAnulados.Size = New System.Drawing.Size(83, 19)
        Me.CheckEditNoAnulados.StyleController = Me.LayoutControl1
        Me.CheckEditNoAnulados.TabIndex = 15
        '
        'CheckEditAnulados
        '
        Me.CheckEditAnulados.Location = New System.Drawing.Point(440, 38)
        Me.CheckEditAnulados.Name = "CheckEditAnulados"
        Me.CheckEditAnulados.Properties.Caption = "Anulados"
        Me.CheckEditAnulados.Size = New System.Drawing.Size(67, 19)
        Me.CheckEditAnulados.StyleController = Me.LayoutControl1
        Me.CheckEditAnulados.TabIndex = 14
        '
        'DateEditDesde
        '
        Me.DateEditDesde.EditValue = Nothing
        Me.DateEditDesde.Location = New System.Drawing.Point(497, 62)
        Me.DateEditDesde.Name = "DateEditDesde"
        Me.DateEditDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDesde.Size = New System.Drawing.Size(129, 20)
        Me.DateEditDesde.StyleController = Me.LayoutControl1
        Me.DateEditDesde.TabIndex = 13
        '
        'DateEditHasta
        '
        Me.DateEditHasta.EditValue = Nothing
        Me.DateEditHasta.Location = New System.Drawing.Point(687, 62)
        Me.DateEditHasta.Name = "DateEditHasta"
        Me.DateEditHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditHasta.Size = New System.Drawing.Size(163, 20)
        Me.DateEditHasta.StyleController = Me.LayoutControl1
        Me.DateEditHasta.TabIndex = 12
        '
        'SearchLookUpEditVendedor
        '
        Me.SearchLookUpEditVendedor.Location = New System.Drawing.Point(225, 38)
        Me.SearchLookUpEditVendedor.Name = "SearchLookUpEditVendedor"
        Me.SearchLookUpEditVendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditVendedor.Properties.View = Me.GridView3
        Me.SearchLookUpEditVendedor.Size = New System.Drawing.Size(211, 20)
        Me.SearchLookUpEditVendedor.StyleController = Me.LayoutControl1
        Me.SearchLookUpEditVendedor.TabIndex = 10
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEditSubTipo
        '
        Me.SearchLookUpEditSubTipo.Location = New System.Drawing.Point(776, 12)
        Me.SearchLookUpEditSubTipo.Name = "SearchLookUpEditSubTipo"
        Me.SearchLookUpEditSubTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditSubTipo.Properties.View = Me.GridView2
        Me.SearchLookUpEditSubTipo.Size = New System.Drawing.Size(299, 20)
        Me.SearchLookUpEditSubTipo.StyleController = Me.LayoutControl1
        Me.SearchLookUpEditSubTipo.TabIndex = 9
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEditClase
        '
        Me.SearchLookUpEditClase.Location = New System.Drawing.Point(577, 12)
        Me.SearchLookUpEditClase.Name = "SearchLookUpEditClase"
        Me.SearchLookUpEditClase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditClase.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEditClase.Size = New System.Drawing.Size(138, 20)
        Me.SearchLookUpEditClase.StyleController = Me.LayoutControl1
        Me.SearchLookUpEditClase.TabIndex = 8
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(269, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(247, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 7
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(69, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(94, 20)
        Me.txtCliente.StyleController = Me.LayoutControl1
        Me.txtCliente.TabIndex = 6
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(167, 12)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(41, 22)
        Me.btnCliente.StyleController = Me.LayoutControl1
        Me.btnCliente.TabIndex = 5
        Me.btnCliente.Text = "..."
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem16, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem1, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1087, 119)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCliente
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(155, 26)
        Me.LayoutControlItem5.Text = "Cliente"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SearchLookUpEditClase
        Me.LayoutControlItem7.Location = New System.Drawing.Point(508, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(199, 26)
        Me.LayoutControlItem7.Text = "Clase"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SearchLookUpEditSubTipo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(707, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(360, 26)
        Me.LayoutControlItem8.Text = "SubTipo"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SearchLookUpEditVendedor
        Me.LayoutControlItem9.Location = New System.Drawing.Point(156, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(272, 24)
        Me.LayoutControlItem9.Text = "Vendedor"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnCliente
        Me.LayoutControlItem4.Location = New System.Drawing.Point(155, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(45, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtNombre
        Me.LayoutControlItem6.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(308, 26)
        Me.LayoutControlItem6.Text = "Nombre"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtDocumento
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(156, 24)
        Me.LayoutControlItem16.Text = "Documento"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(54, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1057, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CheckEditAnulados
        Me.LayoutControlItem12.Location = New System.Drawing.Point(428, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(71, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.CheckEditNoAnulados
        Me.LayoutControlItem13.Location = New System.Drawing.Point(499, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(87, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.CheckEditAprobados
        Me.LayoutControlItem14.Location = New System.Drawing.Point(586, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(79, 24)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.CheckEditNoAprobados
        Me.LayoutControlItem15.Location = New System.Drawing.Point(665, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(96, 24)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckEditSaldos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(971, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(86, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckEditContabilizados
        Me.LayoutControlItem17.Location = New System.Drawing.Point(761, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(97, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.CheckEditNoContabilizados
        Me.LayoutControlItem18.Location = New System.Drawing.Point(858, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(113, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 50)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(428, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.DateEditDesde
        Me.LayoutControlItem10.Location = New System.Drawing.Point(428, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem10.Text = "Desde"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.DateEditHasta
        Me.LayoutControlItem11.Location = New System.Drawing.Point(618, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(224, 24)
        Me.LayoutControlItem11.Text = "Hasta"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(54, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(842, 50)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(225, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 74)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1067, 25)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 129)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1110, 528)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Aprobado, Me.IDCliente, Me.Nombre, Me.IDClase, Me.IDSubTipo, Me.SubTipo, Me.IDDocumento, Me.TipoDocumento, Me.SubTipoDocumento, Me.Documento, Me.Fecha, Me.Vencimiento, Me.Asiento, Me.MontoOriginal, Me.SaldoDebito, Me.SaldoCredito, Me.ConceptoSistema, Me.ConceptoUsuario, Me.TipoCambio, Me.IDVendedor, Me.OrigenExterno, Me.Anulado})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'Aprobado
        '
        Me.Aprobado.Caption = "Aprobado"
        Me.Aprobado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Aprobado.FieldName = "Aprobado"
        Me.Aprobado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Aprobado.Name = "Aprobado"
        Me.Aprobado.OptionsColumn.ReadOnly = True
        Me.Aprobado.Visible = True
        Me.Aprobado.VisibleIndex = 0
        Me.Aprobado.Width = 60
        '
        'IDCliente
        '
        Me.IDCliente.Caption = "IDCliente"
        Me.IDCliente.FieldName = "IDCliente"
        Me.IDCliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.OptionsColumn.ReadOnly = True
        Me.IDCliente.Visible = True
        Me.IDCliente.VisibleIndex = 1
        Me.IDCliente.Width = 61
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'IDClase
        '
        Me.IDClase.Caption = "IDClase"
        Me.IDClase.FieldName = "IDClase"
        Me.IDClase.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.IDClase.Name = "IDClase"
        Me.IDClase.OptionsColumn.ReadOnly = True
        Me.IDClase.Visible = True
        Me.IDClase.VisibleIndex = 2
        Me.IDClase.Width = 57
        '
        'IDSubTipo
        '
        Me.IDSubTipo.Caption = "IDSubTipo"
        Me.IDSubTipo.FieldName = "IDSubTipo"
        Me.IDSubTipo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.IDSubTipo.Name = "IDSubTipo"
        Me.IDSubTipo.OptionsColumn.ReadOnly = True
        '
        'SubTipo
        '
        Me.SubTipo.Caption = "SubTipo"
        Me.SubTipo.FieldName = "SubTipo"
        Me.SubTipo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.SubTipo.Name = "SubTipo"
        Me.SubTipo.OptionsColumn.ReadOnly = True
        Me.SubTipo.Visible = True
        Me.SubTipo.VisibleIndex = 3
        Me.SubTipo.Width = 141
        '
        'IDDocumento
        '
        Me.IDDocumento.Caption = "IDDocumento"
        Me.IDDocumento.FieldName = "IDDocumento"
        Me.IDDocumento.Name = "IDDocumento"
        '
        'TipoDocumento
        '
        Me.TipoDocumento.Caption = "TipoDocumento"
        Me.TipoDocumento.FieldName = "TipoDocumento"
        Me.TipoDocumento.Name = "TipoDocumento"
        '
        'SubTipoDocumento
        '
        Me.SubTipoDocumento.Caption = "SubTipoDocumento"
        Me.SubTipoDocumento.FieldName = "SubTipoDocumento"
        Me.SubTipoDocumento.Name = "SubTipoDocumento"
        '
        'Documento
        '
        Me.Documento.Caption = "Documento"
        Me.Documento.FieldName = "Documento"
        Me.Documento.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Documento.Name = "Documento"
        Me.Documento.OptionsColumn.ReadOnly = True
        Me.Documento.Visible = True
        Me.Documento.VisibleIndex = 4
        Me.Documento.Width = 121
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Fecha.Name = "Fecha"
        Me.Fecha.OptionsColumn.ReadOnly = True
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 5
        '
        'Vencimiento
        '
        Me.Vencimiento.Caption = "Vencimiento"
        Me.Vencimiento.FieldName = "Vencimiento"
        Me.Vencimiento.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.OptionsColumn.ReadOnly = True
        Me.Vencimiento.Visible = True
        Me.Vencimiento.VisibleIndex = 6
        '
        'Asiento
        '
        Me.Asiento.Caption = "Asiento"
        Me.Asiento.FieldName = "Asiento"
        Me.Asiento.Name = "Asiento"
        Me.Asiento.Visible = True
        Me.Asiento.VisibleIndex = 10
        '
        'MontoOriginal
        '
        Me.MontoOriginal.Caption = "Monto"
        Me.MontoOriginal.FieldName = "MontoOriginal"
        Me.MontoOriginal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.MontoOriginal.Name = "MontoOriginal"
        Me.MontoOriginal.Visible = True
        Me.MontoOriginal.VisibleIndex = 7
        Me.MontoOriginal.Width = 105
        '
        'SaldoDebito
        '
        Me.SaldoDebito.Caption = "SaldoDebito"
        Me.SaldoDebito.FieldName = "SaldoDebito"
        Me.SaldoDebito.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.SaldoDebito.Name = "SaldoDebito"
        Me.SaldoDebito.OptionsColumn.ReadOnly = True
        Me.SaldoDebito.Visible = True
        Me.SaldoDebito.VisibleIndex = 8
        Me.SaldoDebito.Width = 109
        '
        'SaldoCredito
        '
        Me.SaldoCredito.Caption = "SaldoCredito"
        Me.SaldoCredito.FieldName = "SaldoCredito"
        Me.SaldoCredito.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.SaldoCredito.Name = "SaldoCredito"
        Me.SaldoCredito.OptionsColumn.ReadOnly = True
        Me.SaldoCredito.Visible = True
        Me.SaldoCredito.VisibleIndex = 9
        Me.SaldoCredito.Width = 127
        '
        'ConceptoSistema
        '
        Me.ConceptoSistema.Caption = "ConceptoSistema"
        Me.ConceptoSistema.FieldName = "ConceptoSistema"
        Me.ConceptoSistema.Name = "ConceptoSistema"
        Me.ConceptoSistema.OptionsColumn.ReadOnly = True
        Me.ConceptoSistema.Visible = True
        Me.ConceptoSistema.VisibleIndex = 11
        Me.ConceptoSistema.Width = 172
        '
        'ConceptoUsuario
        '
        Me.ConceptoUsuario.Caption = "ConceptoUsuario"
        Me.ConceptoUsuario.FieldName = "ConceptoUsuario"
        Me.ConceptoUsuario.Name = "ConceptoUsuario"
        Me.ConceptoUsuario.OptionsColumn.ReadOnly = True
        Me.ConceptoUsuario.Visible = True
        Me.ConceptoUsuario.VisibleIndex = 12
        Me.ConceptoUsuario.Width = 118
        '
        'TipoCambio
        '
        Me.TipoCambio.Caption = "TipoCambio"
        Me.TipoCambio.FieldName = "TipoCambio"
        Me.TipoCambio.Name = "TipoCambio"
        Me.TipoCambio.Visible = True
        Me.TipoCambio.VisibleIndex = 13
        '
        'IDVendedor
        '
        Me.IDVendedor.Caption = "IDVendedor"
        Me.IDVendedor.FieldName = "IDVendedor"
        Me.IDVendedor.Name = "IDVendedor"
        Me.IDVendedor.Visible = True
        Me.IDVendedor.VisibleIndex = 14
        '
        'OrigenExterno
        '
        Me.OrigenExterno.Caption = "Externo"
        Me.OrigenExterno.FieldName = "OrigenExterno"
        Me.OrigenExterno.Name = "OrigenExterno"
        Me.OrigenExterno.Visible = True
        Me.OrigenExterno.VisibleIndex = 15
        '
        'Anulado
        '
        Me.Anulado.Caption = "Anulado"
        Me.Anulado.FieldName = "Anulado"
        Me.Anulado.Name = "Anulado"
        Me.Anulado.Visible = True
        Me.Anulado.VisibleIndex = 16
        Me.Anulado.Width = 48
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Controls.Add(Me.GroupControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(668, 183, 634, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(1134, 669)
        Me.LayoutControl2.TabIndex = 4
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1134, 669)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GroupControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 117)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(5, 117)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1114, 117)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1114, 532)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmCPConsultaDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 732)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCPConsultaDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Cuentas por Cobrar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEditNoContabilizados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditContabilizados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditSaldos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditNoAprobados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditAprobados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditNoAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditSubTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditClase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Aprobado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDClase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDSubTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoOriginal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaldoDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaldoCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConceptoSistema As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConceptoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoCambio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrigenExterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Anulado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchLookUpEditSubTipo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEditClase As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchLookUpEditVendedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DateEditDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEditNoAnulados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditAnulados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEditNoAprobados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditAprobados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarConsulta As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItemAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemAplicar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItemAsiento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckEditSaldos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarButtonItemContabilizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Asiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEditContabilizados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEditNoContabilizados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarButtonItemLimpiaFiltro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItemAplicaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarButtonItemDocumento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
