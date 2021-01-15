<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizaPedido))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.rbtDenegados = New System.Windows.Forms.RadioButton()
        Me.btnActivaDenegado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDenegar = New DevExpress.XtraEditors.SimpleButton()
        Me.rbAprobados = New System.Windows.Forms.RadioButton()
        Me.btnFactura = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDPedido = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisponible = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoPendiente = New DevExpress.XtraEditors.TextEdit()
        Me.txtLimite = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAprobar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.rbSoloCreados = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.DateEditHasta = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpProducto = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAhorro = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioLista = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUndo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtImpuesto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcImp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalLin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotalFinalLin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuentoLin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubTotalLin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantBonifPrecio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuentoEsp = New DevExpress.XtraEditors.TextEdit()
        Me.txtPorcDescEsp = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.chkBonifProd = New DevExpress.XtraEditors.CheckEdit()
        Me.chkBonifica = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescr = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantBonif = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtIDPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoPendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProducto.SuspendLayout()
        CType(Me.txtBono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioLista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalLin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalFinalLin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoLin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalLin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantBonifPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoEsp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcDescEsp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBonifProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBonifica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantBonif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 169)
        Me.GridControl1.MainView = Me.GridViewProducto
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(923, 156)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProducto})
        '
        'GridViewProducto
        '
        Me.GridViewProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridViewProducto.GridControl = Me.GridControl1
        Me.GridViewProducto.Name = "GridViewProducto"
        Me.GridViewProducto.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewProducto.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewProducto.OptionsBehavior.AutoPopulateColumns = False
        Me.GridViewProducto.OptionsBehavior.Editable = False
        Me.GridViewProducto.OptionsBehavior.ReadOnly = True
        Me.GridViewProducto.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.GridViewProducto.OptionsView.ShowGroupPanel = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rbtDenegados)
        Me.LayoutControl1.Controls.Add(Me.btnActivaDenegado)
        Me.LayoutControl1.Controls.Add(Me.btnDenegar)
        Me.LayoutControl1.Controls.Add(Me.rbAprobados)
        Me.LayoutControl1.Controls.Add(Me.btnFactura)
        Me.LayoutControl1.Controls.Add(Me.txtIDPedido)
        Me.LayoutControl1.Controls.Add(Me.txtDisponible)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoPendiente)
        Me.LayoutControl1.Controls.Add(Me.txtLimite)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.btnRefresh)
        Me.LayoutControl1.Controls.Add(Me.btnAprobar)
        Me.LayoutControl1.Controls.Add(Me.btnAnular)
        Me.LayoutControl1.Controls.Add(Me.rbSoloCreados)
        Me.LayoutControl1.Controls.Add(Me.rbTodos)
        Me.LayoutControl1.Controls.Add(Me.DateEditHasta)
        Me.LayoutControl1.Controls.Add(Me.DateEditDesde)
        Me.LayoutControl1.Location = New System.Drawing.Point(-1, -12)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(877, 185)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'rbtDenegados
        '
        Me.rbtDenegados.Location = New System.Drawing.Point(558, 48)
        Me.rbtDenegados.Name = "rbtDenegados"
        Me.rbtDenegados.Size = New System.Drawing.Size(81, 25)
        Me.rbtDenegados.TabIndex = 17
        Me.rbtDenegados.TabStop = True
        Me.rbtDenegados.Text = "Denegados"
        Me.rbtDenegados.UseVisualStyleBackColor = True
        '
        'btnActivaDenegado
        '
        Me.btnActivaDenegado.Image = CType(resources.GetObject("btnActivaDenegado.Image"), System.Drawing.Image)
        Me.btnActivaDenegado.Location = New System.Drawing.Point(601, 101)
        Me.btnActivaDenegado.Name = "btnActivaDenegado"
        Me.btnActivaDenegado.Size = New System.Drawing.Size(141, 22)
        Me.btnActivaDenegado.StyleController = Me.LayoutControl1
        Me.btnActivaDenegado.TabIndex = 16
        Me.btnActivaDenegado.Text = "Activar Denegado"
        '
        'btnDenegar
        '
        Me.btnDenegar.Image = CType(resources.GetObject("btnDenegar.Image"), System.Drawing.Image)
        Me.btnDenegar.Location = New System.Drawing.Point(601, 127)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(141, 22)
        Me.btnDenegar.StyleController = Me.LayoutControl1
        Me.btnDenegar.TabIndex = 14
        Me.btnDenegar.Text = "Denegar Pedido"
        '
        'rbAprobados
        '
        Me.rbAprobados.Location = New System.Drawing.Point(451, 48)
        Me.rbAprobados.Name = "rbAprobados"
        Me.rbAprobados.Size = New System.Drawing.Size(87, 25)
        Me.rbAprobados.TabIndex = 13
        Me.rbAprobados.Text = "Aprobados"
        Me.rbAprobados.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.Enabled = False
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.Location = New System.Drawing.Point(756, 129)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(97, 22)
        Me.btnFactura.StyleController = Me.LayoutControl1
        Me.btnFactura.TabIndex = 12
        Me.btnFactura.Text = "Crear Factura"
        '
        'txtIDPedido
        '
        Me.txtIDPedido.Location = New System.Drawing.Point(628, 77)
        Me.txtIDPedido.Name = "txtIDPedido"
        Me.txtIDPedido.Size = New System.Drawing.Size(114, 20)
        Me.txtIDPedido.StyleController = Me.LayoutControl1
        Me.txtIDPedido.TabIndex = 7
        '
        'txtDisponible
        '
        Me.txtDisponible.Location = New System.Drawing.Point(294, 101)
        Me.txtDisponible.Name = "txtDisponible"
        Me.txtDisponible.Properties.ReadOnly = True
        Me.txtDisponible.Size = New System.Drawing.Size(94, 20)
        Me.txtDisponible.StyleController = Me.LayoutControl1
        Me.txtDisponible.TabIndex = 10
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(505, 101)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.Properties.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(92, 20)
        Me.txtSaldoPendiente.StyleController = Me.LayoutControl1
        Me.txtSaldoPendiente.TabIndex = 9
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(110, 101)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Properties.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(94, 20)
        Me.txtLimite.StyleController = Me.LayoutControl1
        Me.txtLimite.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(110, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(428, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 6
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(756, 48)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 22)
        Me.btnRefresh.StyleController = Me.LayoutControl1
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        '
        'btnAprobar
        '
        Me.btnAprobar.Image = CType(resources.GetObject("btnAprobar.Image"), System.Drawing.Image)
        Me.btnAprobar.Location = New System.Drawing.Point(756, 77)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(97, 22)
        Me.btnAprobar.StyleController = Me.LayoutControl1
        Me.btnAprobar.TabIndex = 5
        Me.btnAprobar.Text = "Aprobar"
        '
        'btnAnular
        '
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(756, 103)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(97, 22)
        Me.btnAnular.StyleController = Me.LayoutControl1
        Me.btnAnular.TabIndex = 11
        Me.btnAnular.Text = "Anular"
        '
        'rbSoloCreados
        '
        Me.rbSoloCreados.Checked = True
        Me.rbSoloCreados.Location = New System.Drawing.Point(363, 48)
        Me.rbSoloCreados.Name = "rbSoloCreados"
        Me.rbSoloCreados.Size = New System.Drawing.Size(69, 25)
        Me.rbSoloCreados.TabIndex = 3
        Me.rbSoloCreados.TabStop = True
        Me.rbSoloCreados.Text = "Creados"
        Me.rbSoloCreados.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.Location = New System.Drawing.Point(664, 48)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(78, 25)
        Me.rbTodos.TabIndex = 1
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'DateEditHasta
        '
        Me.DateEditHasta.EditValue = Nothing
        Me.DateEditHasta.Location = New System.Drawing.Point(281, 48)
        Me.DateEditHasta.Name = "DateEditHasta"
        Me.DateEditHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditHasta.Size = New System.Drawing.Size(78, 20)
        Me.DateEditHasta.StyleController = Me.LayoutControl1
        Me.DateEditHasta.TabIndex = 2
        '
        'DateEditDesde
        '
        Me.DateEditDesde.EditValue = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.DateEditDesde.Location = New System.Drawing.Point(110, 48)
        Me.DateEditDesde.Name = "DateEditDesde"
        Me.DateEditDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDesde.Size = New System.Drawing.Size(81, 20)
        Me.DateEditDesde.StyleController = Me.LayoutControl1
        Me.DateEditDesde.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(877, 185)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CaptionImage = CType(resources.GetObject("LayoutControlGroup2.CaptionImage"), System.Drawing.Image)
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem4, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem6, Me.LayoutControlItem14, Me.LayoutControlItem7, Me.LayoutControlItem15, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem5, Me.LayoutControlItem13, Me.EmptySpaceItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem7, Me.EmptySpaceItem10, Me.LayoutControlItem18, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(857, 165)
        Me.LayoutControlGroup2.Text = "Filtro de Pedidos"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DateEditDesde
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(140, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(171, 29)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnAnular
        Me.LayoutControlItem6.Location = New System.Drawing.Point(732, 55)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(101, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(722, 29)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(722, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 29)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnRefresh
        Me.LayoutControlItem5.Location = New System.Drawing.Point(732, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(101, 29)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DateEditHasta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(171, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(140, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(168, 29)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.rbSoloCreados
        Me.LayoutControlItem3.Location = New System.Drawing.Point(339, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(73, 29)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.rbTodos
        Me.LayoutControlItem4.Location = New System.Drawing.Point(640, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(82, 29)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(722, 55)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(10, 62)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnFactura
        Me.LayoutControlItem14.Location = New System.Drawing.Point(732, 81)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(101, 36)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnAprobar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(732, 29)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(101, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.rbAprobados
        Me.LayoutControlItem15.Location = New System.Drawing.Point(427, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(91, 29)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNombre
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(518, 24)
        Me.LayoutControlItem9.Text = "Cliente"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtLimite
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(184, 64)
        Me.LayoutControlItem10.Text = "Límite de Crédito "
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(83, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(619, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(21, 29)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(518, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(16, 29)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(412, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(15, 29)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtIDPedido
        Me.LayoutControlItem13.Location = New System.Drawing.Point(518, 29)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem13.Text = "Pedido"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(83, 13)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(368, 53)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(27, 24)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtSaldoPendiente
        Me.LayoutControlItem11.Location = New System.Drawing.Point(395, 53)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(182, 24)
        Me.LayoutControlItem11.Text = "Saldo Pendiente"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtDisponible
        Me.LayoutControlItem12.Location = New System.Drawing.Point(184, 53)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem12.Text = "Disponible"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(83, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(577, 105)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(145, 12)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(184, 77)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(393, 40)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.btnActivaDenegado
        Me.LayoutControlItem18.Location = New System.Drawing.Point(577, 53)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnDenegar
        Me.LayoutControlItem16.Location = New System.Drawing.Point(577, 79)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.rbtDenegados
        Me.LayoutControlItem17.Location = New System.Drawing.Point(534, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(85, 29)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(50, 20)
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(12, 331)
        Me.GridControl2.MainView = Me.GridViewDetalle
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(923, 230)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetalle})
        '
        'GridViewDetalle
        '
        Me.GridViewDetalle.Appearance.FilterPanel.Options.UseTextOptions = True
        Me.GridViewDetalle.GridControl = Me.GridControl2
        Me.GridViewDetalle.Name = "GridViewDetalle"
        Me.GridViewDetalle.OptionsFilter.AllowFilterEditor = False
        Me.GridViewDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewDetalle.OptionsView.ShowFooter = True
        Me.GridViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'grpProducto
        '
        Me.grpProducto.Controls.Add(Me.LabelControl17)
        Me.grpProducto.Controls.Add(Me.txtBono)
        Me.grpProducto.Controls.Add(Me.LabelControl16)
        Me.grpProducto.Controls.Add(Me.txtAhorro)
        Me.grpProducto.Controls.Add(Me.LabelControl15)
        Me.grpProducto.Controls.Add(Me.txtPrecioLista)
        Me.grpProducto.Controls.Add(Me.cmdUndo)
        Me.grpProducto.Controls.Add(Me.LabelControl14)
        Me.grpProducto.Controls.Add(Me.txtImpuesto)
        Me.grpProducto.Controls.Add(Me.LabelControl13)
        Me.grpProducto.Controls.Add(Me.txtPorcImp)
        Me.grpProducto.Controls.Add(Me.LabelControl12)
        Me.grpProducto.Controls.Add(Me.txtTotalLin)
        Me.grpProducto.Controls.Add(Me.LabelControl11)
        Me.grpProducto.Controls.Add(Me.txtSubTotalFinalLin)
        Me.grpProducto.Controls.Add(Me.LabelControl10)
        Me.grpProducto.Controls.Add(Me.txtDescuentoLin)
        Me.grpProducto.Controls.Add(Me.LabelControl9)
        Me.grpProducto.Controls.Add(Me.txtSubTotalLin)
        Me.grpProducto.Controls.Add(Me.LabelControl8)
        Me.grpProducto.Controls.Add(Me.txtCantBonifPrecio)
        Me.grpProducto.Controls.Add(Me.LabelControl7)
        Me.grpProducto.Controls.Add(Me.LabelControl6)
        Me.grpProducto.Controls.Add(Me.txtDescuentoEsp)
        Me.grpProducto.Controls.Add(Me.txtPorcDescEsp)
        Me.grpProducto.Controls.Add(Me.cmdAplicar)
        Me.grpProducto.Controls.Add(Me.LabelControl5)
        Me.grpProducto.Controls.Add(Me.chkBonifProd)
        Me.grpProducto.Controls.Add(Me.chkBonifica)
        Me.grpProducto.Controls.Add(Me.LabelControl4)
        Me.grpProducto.Controls.Add(Me.LabelControl3)
        Me.grpProducto.Controls.Add(Me.LabelControl2)
        Me.grpProducto.Controls.Add(Me.LabelControl1)
        Me.grpProducto.Controls.Add(Me.txtDescr)
        Me.grpProducto.Controls.Add(Me.txtCodigo)
        Me.grpProducto.Controls.Add(Me.txtCantBonif)
        Me.grpProducto.Controls.Add(Me.txtPrecio)
        Me.grpProducto.Controls.Add(Me.txtCantidad)
        Me.grpProducto.Controls.Add(Me.ShapeContainer1)
        Me.grpProducto.Location = New System.Drawing.Point(12, 525)
        Me.grpProducto.Name = "grpProducto"
        Me.grpProducto.Size = New System.Drawing.Size(923, 123)
        Me.grpProducto.TabIndex = 9
        Me.grpProducto.Text = "Producto en Proceso"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(423, 26)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl17.TabIndex = 39
        Me.LabelControl17.Text = "Bono"
        '
        'txtBono
        '
        Me.txtBono.Location = New System.Drawing.Point(456, 23)
        Me.txtBono.Name = "txtBono"
        Me.txtBono.Properties.ReadOnly = True
        Me.txtBono.Size = New System.Drawing.Size(52, 20)
        Me.txtBono.TabIndex = 38
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(685, 59)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl16.TabIndex = 37
        Me.LabelControl16.Text = "Ahorro"
        '
        'txtAhorro
        '
        Me.txtAhorro.Location = New System.Drawing.Point(743, 56)
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.Properties.ReadOnly = True
        Me.txtAhorro.Size = New System.Drawing.Size(85, 20)
        Me.txtAhorro.TabIndex = 36
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(514, 25)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl15.TabIndex = 35
        Me.LabelControl15.Text = "Precio Lista"
        '
        'txtPrecioLista
        '
        Me.txtPrecioLista.Location = New System.Drawing.Point(587, 21)
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.Properties.ReadOnly = True
        Me.txtPrecioLista.Size = New System.Drawing.Size(82, 20)
        Me.txtPrecioLista.TabIndex = 34
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = CType(resources.GetObject("cmdUndo.Image"), System.Drawing.Image)
        Me.cmdUndo.Location = New System.Drawing.Point(838, 75)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(74, 23)
        Me.cmdUndo.TabIndex = 33
        Me.cmdUndo.Text = "Deshacer"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(587, 96)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl14.TabIndex = 30
        Me.LabelControl14.Text = "IVA"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(610, 94)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Properties.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(76, 20)
        Me.txtImpuesto.TabIndex = 29
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(687, 26)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl13.TabIndex = 28
        Me.LabelControl13.Text = "% IVA"
        '
        'txtPorcImp
        '
        Me.txtPorcImp.Location = New System.Drawing.Point(743, 20)
        Me.txtPorcImp.Name = "txtPorcImp"
        Me.txtPorcImp.Properties.ReadOnly = True
        Me.txtPorcImp.Size = New System.Drawing.Size(85, 20)
        Me.txtPorcImp.TabIndex = 27
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(693, 94)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl12.TabIndex = 26
        Me.LabelControl12.Text = "TotalFinal"
        '
        'txtTotalLin
        '
        Me.txtTotalLin.Location = New System.Drawing.Point(745, 92)
        Me.txtTotalLin.Name = "txtTotalLin"
        Me.txtTotalLin.Properties.ReadOnly = True
        Me.txtTotalLin.Size = New System.Drawing.Size(87, 20)
        Me.txtTotalLin.TabIndex = 25
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(431, 96)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl11.TabIndex = 24
        Me.LabelControl11.Text = "SubTotalFinal"
        '
        'txtSubTotalFinalLin
        '
        Me.txtSubTotalFinalLin.Location = New System.Drawing.Point(501, 93)
        Me.txtSubTotalFinalLin.Name = "txtSubTotalFinalLin"
        Me.txtSubTotalFinalLin.Properties.ReadOnly = True
        Me.txtSubTotalFinalLin.Size = New System.Drawing.Size(80, 20)
        Me.txtSubTotalFinalLin.TabIndex = 23
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(153, 95)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl10.TabIndex = 22
        Me.LabelControl10.Text = "Descuento"
        '
        'txtDescuentoLin
        '
        Me.txtDescuentoLin.Location = New System.Drawing.Point(210, 93)
        Me.txtDescuentoLin.Name = "txtDescuentoLin"
        Me.txtDescuentoLin.Properties.ReadOnly = True
        Me.txtDescuentoLin.Size = New System.Drawing.Size(67, 20)
        Me.txtDescuentoLin.TabIndex = 21
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(6, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "SubTotal"
        '
        'txtSubTotalLin
        '
        Me.txtSubTotalLin.Location = New System.Drawing.Point(62, 92)
        Me.txtSubTotalLin.Name = "txtSubTotalLin"
        Me.txtSubTotalLin.Properties.ReadOnly = True
        Me.txtSubTotalLin.Size = New System.Drawing.Size(85, 20)
        Me.txtSubTotalLin.TabIndex = 19
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(413, 45)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Cant Bonif Precio"
        '
        'txtCantBonifPrecio
        '
        Me.txtCantBonifPrecio.Location = New System.Drawing.Point(431, 58)
        Me.txtCantBonifPrecio.Name = "txtCantBonifPrecio"
        Me.txtCantBonifPrecio.Size = New System.Drawing.Size(54, 20)
        Me.txtCantBonifPrecio.TabIndex = 17
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(283, 94)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Desc Especial"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(510, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "% Desc Esp"
        '
        'txtDescuentoEsp
        '
        Me.txtDescuentoEsp.Location = New System.Drawing.Point(351, 94)
        Me.txtDescuentoEsp.Name = "txtDescuentoEsp"
        Me.txtDescuentoEsp.Properties.ReadOnly = True
        Me.txtDescuentoEsp.Size = New System.Drawing.Size(76, 20)
        Me.txtDescuentoEsp.TabIndex = 14
        '
        'txtPorcDescEsp
        '
        Me.txtPorcDescEsp.Location = New System.Drawing.Point(587, 55)
        Me.txtPorcDescEsp.Name = "txtPorcDescEsp"
        Me.txtPorcDescEsp.Properties.ReadOnly = True
        Me.txtPorcDescEsp.Size = New System.Drawing.Size(82, 20)
        Me.txtPorcDescEsp.TabIndex = 13
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Image = CType(resources.GetObject("cmdAplicar.Image"), System.Drawing.Image)
        Me.cmdAplicar.Location = New System.Drawing.Point(838, 35)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(74, 23)
        Me.cmdAplicar.TabIndex = 12
        Me.cmdAplicar.Text = "Editar"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(356, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Cant Bonif"
        '
        'chkBonifProd
        '
        Me.chkBonifProd.Location = New System.Drawing.Point(283, 58)
        Me.chkBonifProd.Name = "chkBonifProd"
        Me.chkBonifProd.Properties.Caption = "Bonif Prod"
        Me.chkBonifProd.Properties.ReadOnly = True
        Me.chkBonifProd.Size = New System.Drawing.Size(75, 19)
        Me.chkBonifProd.TabIndex = 10
        '
        'chkBonifica
        '
        Me.chkBonifica.Location = New System.Drawing.Point(220, 58)
        Me.chkBonifica.Name = "chkBonifica"
        Me.chkBonifica.Properties.Caption = "Bonifica"
        Me.chkBonifica.Properties.ReadOnly = True
        Me.chkBonifica.Size = New System.Drawing.Size(75, 19)
        Me.chkBonifica.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(110, 58)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Precio"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Cantidad"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(110, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Descr"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Código"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(146, 23)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Properties.ReadOnly = True
        Me.txtDescr.Size = New System.Drawing.Size(256, 20)
        Me.txtDescr.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(62, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(42, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtCantBonif
        '
        Me.txtCantBonif.Location = New System.Drawing.Point(356, 58)
        Me.txtCantBonif.Name = "txtCantBonif"
        Me.txtCantBonif.Size = New System.Drawing.Size(54, 20)
        Me.txtCantBonif.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(146, 55)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Properties.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(62, 55)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(42, 20)
        Me.txtCantidad.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(2, 20)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(919, 101)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 825
        Me.LineShape1.Y1 = 65
        Me.LineShape1.Y2 = 65
        '
        'frmAutorizaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 660)
        Me.Controls.Add(Me.grpProducto)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmAutorizaPedido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización de Pedidos"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtIDPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProducto.ResumeLayout(False)
        Me.grpProducto.PerformLayout()
        CType(Me.txtBono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioLista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalLin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalFinalLin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoLin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalLin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantBonifPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoEsp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcDescEsp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBonifProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBonifica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantBonif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProducto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DateEditHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rbSoloCreados As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoPendiente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLimite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtIDPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rbAprobados As System.Windows.Forms.RadioButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grpProducto As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantBonif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkBonifProd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBonifica As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoEsp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorcDescEsp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDenegar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnActivaDenegado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantBonifPrecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoLin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubTotalLin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalLin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubTotalFinalLin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcImp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdUndo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioLista As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rbtDenegados As System.Windows.Forms.RadioButton
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
End Class
