<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBonificaciones))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDTabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantHasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCopyEscala = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchLookUpEditProductoReceptor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewClear = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEscalaenLote = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelProd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelProv = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.chkDejarProducto = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkDejarProv = New DevExpress.XtraEditors.CheckEdit()
        Me.SearchLookUpEditProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBono = New DevExpress.XtraEditors.TextEdit()
        Me.txtHasta = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEditProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDesde = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.SearchLookUpEditProductoReceptor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDejarProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDejarProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 211)
        Me.GridControl1.MainView = Me.GridViewDetalle
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(843, 444)
        Me.GridControl1.TabIndex = 27
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetalle})
        '
        'GridViewDetalle
        '
        Me.GridViewDetalle.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewDetalle.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDTabla, Me.IDProveedor, Me.Nombre, Me.Codigo, Me.GridColumn2, Me.CantDesde, Me.CantHasta, Me.Bono})
        Me.GridViewDetalle.GridControl = Me.GridControl1
        Me.GridViewDetalle.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewDetalle.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Me.GridColumn2, "{Count = {0}}")})
        Me.GridViewDetalle.Name = "GridViewDetalle"
        Me.GridViewDetalle.OptionsBehavior.ReadOnly = True
        Me.GridViewDetalle.OptionsFind.AlwaysVisible = True
        Me.GridViewDetalle.OptionsView.AllowCellMerge = True
        Me.GridViewDetalle.OptionsView.ShowAutoFilterRow = True
        Me.GridViewDetalle.OptionsView.ShowFooter = True
        Me.GridViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'IDTabla
        '
        Me.IDTabla.Caption = "IDTabla"
        Me.IDTabla.FieldName = "IDTabla"
        Me.IDTabla.Name = "IDTabla"
        '
        'IDProveedor
        '
        Me.IDProveedor.Caption = "IDProveedor"
        Me.IDProveedor.FieldName = "IDProveedor"
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.Visible = True
        Me.IDProveedor.VisibleIndex = 0
        Me.IDProveedor.Width = 78
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        Me.Nombre.Width = 201
        '
        'Codigo
        '
        Me.Codigo.Caption = "Código"
        Me.Codigo.FieldName = "IDProducto"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 2
        Me.Codigo.Width = 66
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descr"
        Me.GridColumn2.FieldName = "Descr"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 291
        '
        'CantDesde
        '
        Me.CantDesde.Caption = "Desde"
        Me.CantDesde.FieldName = "CantDesde"
        Me.CantDesde.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.CantDesde.Name = "CantDesde"
        Me.CantDesde.OptionsColumn.AllowEdit = False
        Me.CantDesde.Visible = True
        Me.CantDesde.VisibleIndex = 4
        Me.CantDesde.Width = 103
        '
        'CantHasta
        '
        Me.CantHasta.Caption = "Hasta"
        Me.CantHasta.FieldName = "CantHasta"
        Me.CantHasta.Name = "CantHasta"
        Me.CantHasta.Visible = True
        Me.CantHasta.VisibleIndex = 5
        Me.CantHasta.Width = 87
        '
        'Bono
        '
        Me.Bono.Caption = "Bono"
        Me.Bono.FieldName = "Bono"
        Me.Bono.Name = "Bono"
        Me.Bono.Visible = True
        Me.Bono.VisibleIndex = 6
        Me.Bono.Width = 89
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.btnCancel)
        Me.LayoutControl2.Controls.Add(Me.LabelControl2)
        Me.LayoutControl2.Controls.Add(Me.btnExcel)
        Me.LayoutControl2.Controls.Add(Me.cmdCopyEscala)
        Me.LayoutControl2.Controls.Add(Me.SearchLookUpEditProductoReceptor)
        Me.LayoutControl2.Controls.Add(Me.btnDelete)
        Me.LayoutControl2.Controls.Add(Me.btnEdit)
        Me.LayoutControl2.Controls.Add(Me.cmdNewClear)
        Me.LayoutControl2.Controls.Add(Me.cmdEscalaenLote)
        Me.LayoutControl2.Controls.Add(Me.cmdDelProd)
        Me.LayoutControl2.Controls.Add(Me.cmdDelProv)
        Me.LayoutControl2.Controls.Add(Me.cmdRefresh)
        Me.LayoutControl2.Controls.Add(Me.chkDejarProducto)
        Me.LayoutControl2.Controls.Add(Me.LabelControl1)
        Me.LayoutControl2.Controls.Add(Me.chkDejarProv)
        Me.LayoutControl2.Controls.Add(Me.SearchLookUpEditProveedor)
        Me.LayoutControl2.Controls.Add(Me.txtBono)
        Me.LayoutControl2.Controls.Add(Me.txtHasta)
        Me.LayoutControl2.Controls.Add(Me.SearchLookUpEditProducto)
        Me.LayoutControl2.Controls.Add(Me.txtDesde)
        Me.LayoutControl2.Location = New System.Drawing.Point(5, -1)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(881, 218)
        Me.LayoutControl2.TabIndex = 28
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl2.Location = New System.Drawing.Point(349, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(143, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl2
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Ultima escala termina en 9999"
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(773, 151)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(40, 38)
        Me.btnExcel.StyleController = Me.LayoutControl2
        Me.btnExcel.TabIndex = 39
        '
        'cmdCopyEscala
        '
        Me.cmdCopyEscala.Image = CType(resources.GetObject("cmdCopyEscala.Image"), System.Drawing.Image)
        Me.cmdCopyEscala.Location = New System.Drawing.Point(484, 151)
        Me.cmdCopyEscala.Name = "cmdCopyEscala"
        Me.cmdCopyEscala.Size = New System.Drawing.Size(41, 38)
        Me.cmdCopyEscala.StyleController = Me.LayoutControl2
        Me.cmdCopyEscala.TabIndex = 38
        Me.cmdCopyEscala.ToolTip = "Copia la escala del Producto Base al Producto Receptor"
        '
        'SearchLookUpEditProductoReceptor
        '
        Me.SearchLookUpEditProductoReceptor.Location = New System.Drawing.Point(117, 100)
        Me.SearchLookUpEditProductoReceptor.Name = "SearchLookUpEditProductoReceptor"
        Me.SearchLookUpEditProductoReceptor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditProductoReceptor.Properties.View = Me.GridView1
        Me.SearchLookUpEditProductoReceptor.Size = New System.Drawing.Size(431, 20)
        Me.SearchLookUpEditProductoReceptor.StyleController = Me.LayoutControl2
        Me.SearchLookUpEditProductoReceptor.TabIndex = 37
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(719, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 38)
        Me.btnDelete.StyleController = Me.LayoutControl2
        Me.btnDelete.TabIndex = 34
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(665, 151)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(40, 38)
        Me.btnEdit.StyleController = Me.LayoutControl2
        Me.btnEdit.TabIndex = 32
        '
        'cmdNewClear
        '
        Me.cmdNewClear.Image = CType(resources.GetObject("cmdNewClear.Image"), System.Drawing.Image)
        Me.cmdNewClear.Location = New System.Drawing.Point(611, 151)
        Me.cmdNewClear.Name = "cmdNewClear"
        Me.cmdNewClear.Size = New System.Drawing.Size(40, 38)
        Me.cmdNewClear.StyleController = Me.LayoutControl2
        Me.cmdNewClear.TabIndex = 35
        Me.cmdNewClear.ToolTip = "Prepara el nuevo registro, limpia los controles"
        '
        'cmdEscalaenLote
        '
        Me.cmdEscalaenLote.Image = CType(resources.GetObject("cmdEscalaenLote.Image"), System.Drawing.Image)
        Me.cmdEscalaenLote.Location = New System.Drawing.Point(539, 151)
        Me.cmdEscalaenLote.Name = "cmdEscalaenLote"
        Me.cmdEscalaenLote.Size = New System.Drawing.Size(41, 38)
        Me.cmdEscalaenLote.StyleController = Me.LayoutControl2
        Me.cmdEscalaenLote.TabIndex = 36
        Me.cmdEscalaenLote.ToolTip = "Agrega las escalas completas de un producto base a todos los productos del provee" & _
    "dor"
        '
        'cmdDelProd
        '
        Me.cmdDelProd.Image = CType(resources.GetObject("cmdDelProd.Image"), System.Drawing.Image)
        Me.cmdDelProd.Location = New System.Drawing.Point(552, 74)
        Me.cmdDelProd.Name = "cmdDelProd"
        Me.cmdDelProd.Size = New System.Drawing.Size(24, 22)
        Me.cmdDelProd.StyleController = Me.LayoutControl2
        Me.cmdDelProd.TabIndex = 23
        '
        'cmdDelProv
        '
        Me.cmdDelProv.Image = CType(resources.GetObject("cmdDelProv.Image"), System.Drawing.Image)
        Me.cmdDelProv.Location = New System.Drawing.Point(552, 48)
        Me.cmdDelProv.Name = "cmdDelProv"
        Me.cmdDelProv.Size = New System.Drawing.Size(24, 22)
        Me.cmdDelProv.StyleController = Me.LayoutControl2
        Me.cmdDelProv.TabIndex = 22
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.Location = New System.Drawing.Point(769, 48)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(88, 38)
        Me.cmdRefresh.StyleController = Me.LayoutControl2
        Me.cmdRefresh.TabIndex = 21
        Me.cmdRefresh.Text = "Refresh"
        '
        'chkDejarProducto
        '
        Me.chkDejarProducto.Location = New System.Drawing.Point(580, 71)
        Me.chkDejarProducto.Name = "chkDejarProducto"
        Me.chkDejarProducto.Properties.Caption = "Mantener Producto Base"
        Me.chkDejarProducto.Size = New System.Drawing.Size(140, 19)
        Me.chkDejarProducto.StyleController = Me.LayoutControl2
        Me.chkDejarProducto.TabIndex = 20
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(24, 134)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(321, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl2
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "--------------------------  Escala de Bonificación --------------------------"
        '
        'chkDejarProv
        '
        Me.chkDejarProv.Location = New System.Drawing.Point(580, 48)
        Me.chkDejarProv.Name = "chkDejarProv"
        Me.chkDejarProv.Properties.Caption = "Mantener Proveedor"
        Me.chkDejarProv.Size = New System.Drawing.Size(140, 19)
        Me.chkDejarProv.StyleController = Me.LayoutControl2
        Me.chkDejarProv.TabIndex = 17
        '
        'SearchLookUpEditProveedor
        '
        Me.SearchLookUpEditProveedor.Location = New System.Drawing.Point(117, 48)
        Me.SearchLookUpEditProveedor.Name = "SearchLookUpEditProveedor"
        Me.SearchLookUpEditProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEditProveedor.Size = New System.Drawing.Size(431, 20)
        Me.SearchLookUpEditProveedor.StyleController = Me.LayoutControl2
        Me.SearchLookUpEditProveedor.TabIndex = 13
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtBono
        '
        Me.txtBono.EditValue = ""
        Me.txtBono.Location = New System.Drawing.Point(417, 151)
        Me.txtBono.Name = "txtBono"
        Me.txtBono.Size = New System.Drawing.Size(53, 20)
        Me.txtBono.StyleController = Me.LayoutControl2
        Me.txtBono.TabIndex = 12
        '
        'txtHasta
        '
        Me.txtHasta.EditValue = ""
        Me.txtHasta.Location = New System.Drawing.Point(267, 151)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Properties.DisplayFormat.FormatString = "d"
        Me.txtHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtHasta.Size = New System.Drawing.Size(53, 20)
        Me.txtHasta.StyleController = Me.LayoutControl2
        Me.txtHasta.TabIndex = 6
        '
        'SearchLookUpEditProducto
        '
        Me.SearchLookUpEditProducto.Location = New System.Drawing.Point(117, 72)
        Me.SearchLookUpEditProducto.Name = "SearchLookUpEditProducto"
        Me.SearchLookUpEditProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditProducto.Properties.View = Me.GridView4
        Me.SearchLookUpEditProducto.Size = New System.Drawing.Size(431, 20)
        Me.SearchLookUpEditProducto.StyleController = Me.LayoutControl2
        Me.SearchLookUpEditProducto.TabIndex = 5
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'txtDesde
        '
        Me.txtDesde.EditValue = ""
        Me.txtDesde.Location = New System.Drawing.Point(117, 151)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesde.Size = New System.Drawing.Size(53, 20)
        Me.txtDesde.StyleController = Me.LayoutControl2
        Me.txtDesde.TabIndex = 4
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(881, 218)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CaptionImage = CType(resources.GetObject("LayoutControlGroup4.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.EmptySpaceItem7, Me.EmptySpaceItem4, Me.EmptySpaceItem9, Me.LayoutControlItem2, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem21, Me.LayoutControlItem17, Me.EmptySpaceItem10, Me.LayoutControlItem18, Me.EmptySpaceItem8, Me.EmptySpaceItem11, Me.LayoutControlItem16, Me.LayoutControlItem12, Me.LayoutControlItem19})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(861, 198)
        Me.LayoutControlGroup4.Text = "Captación de la Bonificación"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SearchLookUpEditProducto
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(528, 28)
        Me.LayoutControlItem10.Text = "Producto Base "
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEditProveedor
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(528, 24)
        Me.LayoutControlItem1.Text = "Proveedor"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkDejarProducto
        Me.LayoutControlItem3.Location = New System.Drawing.Point(556, 23)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(144, 29)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkDejarProv
        Me.LayoutControlItem5.Location = New System.Drawing.Point(556, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(144, 23)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdRefresh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(745, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(92, 86)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdDelProv
        Me.LayoutControlItem7.Location = New System.Drawing.Point(528, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdDelProd
        Me.LayoutControlItem8.Location = New System.Drawing.Point(528, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(700, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(45, 86)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 76)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(700, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdEscalaenLote
        Me.LayoutControlItem6.Location = New System.Drawing.Point(515, 103)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(45, 47)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnDelete
        Me.LayoutControlItem15.Location = New System.Drawing.Point(695, 103)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(44, 47)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(641, 103)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(44, 47)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdNewClear
        Me.LayoutControlItem13.Location = New System.Drawing.Point(587, 103)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(44, 47)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(685, 103)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(631, 103)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(570, 103)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(17, 47)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(560, 103)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(739, 103)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(472, 86)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(365, 17)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(325, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtDesde
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(150, 47)
        Me.LayoutControlItem9.Text = "Desde"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtHasta
        Me.LayoutControlItem11.Location = New System.Drawing.Point(150, 103)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(150, 47)
        Me.LayoutControlItem11.Text = "Hasta"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtBono
        Me.LayoutControlItem21.CustomizationFormText = "Bono Bono"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(300, 103)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(150, 47)
        Me.LayoutControlItem21.Text = "Bonifica "
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(90, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SearchLookUpEditProductoReceptor
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(528, 24)
        Me.LayoutControlItem17.Text = "Producto Receptor"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(90, 13)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(528, 52)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(172, 24)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdCopyEscala
        Me.LayoutControlItem18.Location = New System.Drawing.Point(460, 103)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(45, 47)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(505, 103)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(450, 103)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(10, 47)
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnExcel
        Me.LayoutControlItem16.Location = New System.Drawing.Point(749, 103)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(44, 47)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.LabelControl2
        Me.LayoutControlItem12.Location = New System.Drawing.Point(325, 86)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(147, 17)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'AlertControl1
        '
        Me.AlertControl1.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Right
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(817, 151)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 38)
        Me.btnCancel.StyleController = Me.LayoutControl2
        Me.btnCancel.TabIndex = 40
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.btnCancel
        Me.LayoutControlItem19.Location = New System.Drawing.Point(793, 103)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(44, 47)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'frmBonificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 633)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBonificaciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Bonificaciones"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.SearchLookUpEditProductoReceptor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDejarProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDejarProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CantDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SearchLookUpEditProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEditProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents IDTabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CantHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkDejarProv As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdNewClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkDejarProducto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdDelProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelProv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdEscalaenLote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SearchLookUpEditProductoReceptor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdCopyEscala As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
End Class
