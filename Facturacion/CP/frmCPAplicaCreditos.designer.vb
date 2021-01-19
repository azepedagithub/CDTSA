<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPAplicaCreditos
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
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDCreditos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDClase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDSubTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiasVencidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDMonedaC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Moneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Abono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalAbonadoDolar = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtDifNacional = New DevExpress.XtraEditors.TextEdit()
        Me.txtDifDolar = New DevExpress.XtraEditors.TextEdit()
        Me.DateEditFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtTipo = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtIDProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoOrigConversion = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalAbonadoNacional = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoConversion = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisponibleDolar = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisponibleNacional = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoOriginal = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoOriginal = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Nombre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TipoDocumento = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblMontoOriginal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblSaldoOriginal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TipoDocumento1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblSaldoConversion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblMontoOriginalConversion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TipoDocumento2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblDisponibleNacional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblDisponibleDolar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblTotalAbonadoNacional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblTotalAbonadoDolar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDAplicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClaseDebito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoDocumentoA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocDebito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VencimientoA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MonedaC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaldoCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClaseCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnReversaDocumento = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReversaAplicacion = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAbonadoDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDifNacional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDifDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoOrigConversion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAbonadoNacional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoConversion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisponibleDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisponibleNacional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoOriginal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoOriginal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMontoOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSaldoOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSaldoConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMontoOriginalConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumento2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDisponibleNacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDisponibleDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalAbonadoNacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalAbonadoDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(732, 13)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(145, 28)
        Me.btnAplicar.TabIndex = 0
        Me.btnAplicar.Text = "Aplicar Credito"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 251)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(942, 323)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDCreditos, Me.IDClase, Me.IDSubTipo, Me.Documento, Me.Fecha, Me.Vencimiento, Me.DiasVencidos, Me.IDMonedaC, Me.Moneda, Me.Saldo, Me.Abono})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowViewCaption = True
        Me.GridView1.ViewCaption = "Documentos Debitos a Pagar"
        '
        'IDCreditos
        '
        Me.IDCreditos.Caption = "IDCredito"
        Me.IDCreditos.FieldName = "IDCredito"
        Me.IDCreditos.Name = "IDCreditos"
        Me.IDCreditos.Visible = True
        Me.IDCreditos.VisibleIndex = 0
        Me.IDCreditos.Width = 54
        '
        'IDClase
        '
        Me.IDClase.Caption = "IDClase"
        Me.IDClase.FieldName = "IDClase"
        Me.IDClase.Name = "IDClase"
        Me.IDClase.Visible = True
        Me.IDClase.VisibleIndex = 1
        Me.IDClase.Width = 53
        '
        'IDSubTipo
        '
        Me.IDSubTipo.Caption = "IDSubTipo"
        Me.IDSubTipo.FieldName = "IDSubTipo"
        Me.IDSubTipo.Name = "IDSubTipo"
        Me.IDSubTipo.Visible = True
        Me.IDSubTipo.VisibleIndex = 2
        Me.IDSubTipo.Width = 59
        '
        'Documento
        '
        Me.Documento.Caption = "Documento"
        Me.Documento.FieldName = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.Visible = True
        Me.Documento.VisibleIndex = 3
        Me.Documento.Width = 161
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 4
        Me.Fecha.Width = 78
        '
        'Vencimiento
        '
        Me.Vencimiento.Caption = "Vencimiento"
        Me.Vencimiento.FieldName = "Vencimiento"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Visible = True
        Me.Vencimiento.VisibleIndex = 5
        Me.Vencimiento.Width = 78
        '
        'DiasVencidos
        '
        Me.DiasVencidos.Caption = "DiasVencidos"
        Me.DiasVencidos.FieldName = "DiasVencidos"
        Me.DiasVencidos.Name = "DiasVencidos"
        Me.DiasVencidos.Visible = True
        Me.DiasVencidos.VisibleIndex = 6
        Me.DiasVencidos.Width = 78
        '
        'IDMonedaC
        '
        Me.IDMonedaC.Caption = "IDMoneda"
        Me.IDMonedaC.FieldName = "IDMoneda"
        Me.IDMonedaC.Name = "IDMonedaC"
        '
        'Moneda
        '
        Me.Moneda.Caption = "Moneda"
        Me.Moneda.FieldName = "DescrMoneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Visible = True
        Me.Moneda.VisibleIndex = 7
        '
        'Saldo
        '
        Me.Saldo.Caption = "Saldo"
        Me.Saldo.FieldName = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:0.##}")})
        Me.Saldo.Visible = True
        Me.Saldo.VisibleIndex = 8
        Me.Saldo.Width = 86
        '
        'Abono
        '
        Me.Abono.Caption = "Abono"
        Me.Abono.FieldName = "Abono"
        Me.Abono.Name = "Abono"
        Me.Abono.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:0.##}"), New DevExpress.XtraGrid.GridColumnSummaryItem()})
        Me.Abono.Visible = True
        Me.Abono.VisibleIndex = 9
        Me.Abono.Width = 103
        '
        'txtTotalAbonadoDolar
        '
        Me.txtTotalAbonadoDolar.Location = New System.Drawing.Point(378, 162)
        Me.txtTotalAbonadoDolar.Name = "txtTotalAbonadoDolar"
        Me.txtTotalAbonadoDolar.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalAbonadoDolar.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalAbonadoDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAbonadoDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAbonadoDolar.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalAbonadoDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalAbonadoDolar.Properties.ReadOnly = True
        Me.txtTotalAbonadoDolar.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalAbonadoDolar.StyleController = Me.LayoutControl1
        Me.txtTotalAbonadoDolar.TabIndex = 3
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtDifNacional)
        Me.LayoutControl1.Controls.Add(Me.txtDifDolar)
        Me.LayoutControl1.Controls.Add(Me.DateEditFecha)
        Me.LayoutControl1.Controls.Add(Me.txtTotalAbonadoDolar)
        Me.LayoutControl1.Controls.Add(Me.txtDocumento)
        Me.LayoutControl1.Controls.Add(Me.txtTipo)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtIDProveedor)
        Me.LayoutControl1.Controls.Add(Me.txtMoneda)
        Me.LayoutControl1.Controls.Add(Me.txtTipoCambio)
        Me.LayoutControl1.Controls.Add(Me.txtMontoOrigConversion)
        Me.LayoutControl1.Controls.Add(Me.txtTotalAbonadoNacional)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoConversion)
        Me.LayoutControl1.Controls.Add(Me.txtDisponibleDolar)
        Me.LayoutControl1.Controls.Add(Me.txtDisponibleNacional)
        Me.LayoutControl1.Controls.Add(Me.txtMontoOriginal)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoOriginal)
        Me.LayoutControl1.Location = New System.Drawing.Point(13, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(238, 292, 452, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(713, 233)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtDifNacional
        '
        Me.txtDifNacional.Location = New System.Drawing.Point(591, 186)
        Me.txtDifNacional.Name = "txtDifNacional"
        Me.txtDifNacional.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDifNacional.Properties.Appearance.Options.UseBackColor = True
        Me.txtDifNacional.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDifNacional.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDifNacional.Properties.DisplayFormat.FormatString = "n2"
        Me.txtDifNacional.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDifNacional.Properties.ReadOnly = True
        Me.txtDifNacional.Size = New System.Drawing.Size(98, 20)
        Me.txtDifNacional.StyleController = Me.LayoutControl1
        Me.txtDifNacional.TabIndex = 12
        '
        'txtDifDolar
        '
        Me.txtDifDolar.Location = New System.Drawing.Point(378, 186)
        Me.txtDifDolar.Name = "txtDifDolar"
        Me.txtDifDolar.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDifDolar.Properties.Appearance.Options.UseBackColor = True
        Me.txtDifDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDifDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDifDolar.Properties.DisplayFormat.FormatString = "n2"
        Me.txtDifDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDifDolar.Properties.ReadOnly = True
        Me.txtDifDolar.Size = New System.Drawing.Size(96, 20)
        Me.txtDifDolar.StyleController = Me.LayoutControl1
        Me.txtDifDolar.TabIndex = 11
        '
        'DateEditFecha
        '
        Me.DateEditFecha.EditValue = Nothing
        Me.DateEditFecha.Location = New System.Drawing.Point(591, 66)
        Me.DateEditFecha.Name = "DateEditFecha"
        Me.DateEditFecha.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.DateEditFecha.Properties.Appearance.Options.UseBackColor = True
        Me.DateEditFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Properties.ReadOnly = True
        Me.DateEditFecha.Size = New System.Drawing.Size(98, 20)
        Me.DateEditFecha.StyleController = Me.LayoutControl1
        Me.DateEditFecha.TabIndex = 10
        '
        'txtDocumento
        '
        Me.txtDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDocumento.Location = New System.Drawing.Point(378, 66)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ReadOnly = True
        Me.txtDocumento.Size = New System.Drawing.Size(96, 20)
        Me.txtDocumento.TabIndex = 7
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(137, 66)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTipo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipo.Properties.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(54, 20)
        Me.txtTipo.StyleController = Me.LayoutControl1
        Me.txtTipo.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(316, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNombre.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombre.Properties.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(373, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 5
        '
        'txtIDProveedor
        '
        Me.txtIDProveedor.Location = New System.Drawing.Point(137, 42)
        Me.txtIDProveedor.Name = "txtIDProveedor"
        Me.txtIDProveedor.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIDProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtIDProveedor.Properties.ReadOnly = True
        Me.txtIDProveedor.Size = New System.Drawing.Size(62, 20)
        Me.txtIDProveedor.StyleController = Me.LayoutControl1
        Me.txtIDProveedor.TabIndex = 4
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(137, 90)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMoneda.Properties.Appearance.Options.UseBackColor = True
        Me.txtMoneda.Properties.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(124, 20)
        Me.txtMoneda.StyleController = Me.LayoutControl1
        Me.txtMoneda.TabIndex = 6
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(137, 114)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTipoCambio.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipoCambio.Properties.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
        Me.txtTipoCambio.StyleController = Me.LayoutControl1
        Me.txtTipoCambio.TabIndex = 6
        '
        'txtMontoOrigConversion
        '
        Me.txtMontoOrigConversion.Location = New System.Drawing.Point(378, 114)
        Me.txtMontoOrigConversion.Name = "txtMontoOrigConversion"
        Me.txtMontoOrigConversion.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoOrigConversion.Properties.Appearance.Options.UseBackColor = True
        Me.txtMontoOrigConversion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoOrigConversion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoOrigConversion.Properties.DisplayFormat.FormatString = "n2"
        Me.txtMontoOrigConversion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoOrigConversion.Properties.ReadOnly = True
        Me.txtMontoOrigConversion.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoOrigConversion.StyleController = Me.LayoutControl1
        Me.txtMontoOrigConversion.TabIndex = 9
        '
        'txtTotalAbonadoNacional
        '
        Me.txtTotalAbonadoNacional.Location = New System.Drawing.Point(591, 162)
        Me.txtTotalAbonadoNacional.Name = "txtTotalAbonadoNacional"
        Me.txtTotalAbonadoNacional.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalAbonadoNacional.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalAbonadoNacional.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAbonadoNacional.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAbonadoNacional.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalAbonadoNacional.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalAbonadoNacional.Properties.ReadOnly = True
        Me.txtTotalAbonadoNacional.Size = New System.Drawing.Size(98, 20)
        Me.txtTotalAbonadoNacional.StyleController = Me.LayoutControl1
        Me.txtTotalAbonadoNacional.TabIndex = 3
        '
        'txtSaldoConversion
        '
        Me.txtSaldoConversion.Location = New System.Drawing.Point(591, 114)
        Me.txtSaldoConversion.Name = "txtSaldoConversion"
        Me.txtSaldoConversion.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldoConversion.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoConversion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoConversion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoConversion.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoConversion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoConversion.Properties.ReadOnly = True
        Me.txtSaldoConversion.Size = New System.Drawing.Size(98, 20)
        Me.txtSaldoConversion.StyleController = Me.LayoutControl1
        Me.txtSaldoConversion.TabIndex = 8
        '
        'txtDisponibleDolar
        '
        Me.txtDisponibleDolar.Location = New System.Drawing.Point(378, 138)
        Me.txtDisponibleDolar.Name = "txtDisponibleDolar"
        Me.txtDisponibleDolar.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDisponibleDolar.Properties.Appearance.Options.UseBackColor = True
        Me.txtDisponibleDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDisponibleDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDisponibleDolar.Properties.DisplayFormat.FormatString = "n2"
        Me.txtDisponibleDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisponibleDolar.Properties.ReadOnly = True
        Me.txtDisponibleDolar.Size = New System.Drawing.Size(96, 20)
        Me.txtDisponibleDolar.StyleController = Me.LayoutControl1
        Me.txtDisponibleDolar.TabIndex = 3
        '
        'txtDisponibleNacional
        '
        Me.txtDisponibleNacional.Location = New System.Drawing.Point(591, 138)
        Me.txtDisponibleNacional.Name = "txtDisponibleNacional"
        Me.txtDisponibleNacional.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDisponibleNacional.Properties.Appearance.Options.UseBackColor = True
        Me.txtDisponibleNacional.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDisponibleNacional.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDisponibleNacional.Properties.DisplayFormat.FormatString = "n2"
        Me.txtDisponibleNacional.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisponibleNacional.Properties.ReadOnly = True
        Me.txtDisponibleNacional.Size = New System.Drawing.Size(98, 20)
        Me.txtDisponibleNacional.StyleController = Me.LayoutControl1
        Me.txtDisponibleNacional.TabIndex = 3
        '
        'txtMontoOriginal
        '
        Me.txtMontoOriginal.Location = New System.Drawing.Point(378, 90)
        Me.txtMontoOriginal.Name = "txtMontoOriginal"
        Me.txtMontoOriginal.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoOriginal.Properties.Appearance.Options.UseBackColor = True
        Me.txtMontoOriginal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoOriginal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoOriginal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtMontoOriginal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoOriginal.Properties.ReadOnly = True
        Me.txtMontoOriginal.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoOriginal.StyleController = Me.LayoutControl1
        Me.txtMontoOriginal.TabIndex = 9
        Me.txtMontoOriginal.Visible = False
        '
        'txtSaldoOriginal
        '
        Me.txtSaldoOriginal.Location = New System.Drawing.Point(591, 90)
        Me.txtSaldoOriginal.Name = "txtSaldoOriginal"
        Me.txtSaldoOriginal.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldoOriginal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoOriginal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoOriginal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoOriginal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtSaldoOriginal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoOriginal.Properties.ReadOnly = True
        Me.txtSaldoOriginal.Size = New System.Drawing.Size(98, 20)
        Me.txtSaldoOriginal.StyleController = Me.LayoutControl1
        Me.txtSaldoOriginal.TabIndex = 8
        Me.txtSaldoOriginal.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AllowBorderColorBlending = True
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(713, 233)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.Nombre, Me.TipoDocumento, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.lblMontoOriginal, Me.lblSaldoOriginal, Me.EmptySpaceItem4, Me.LayoutControlItem5, Me.TipoDocumento1, Me.lblSaldoConversion, Me.EmptySpaceItem5, Me.lblMontoOriginalConversion, Me.TipoDocumento2, Me.lblDisponibleNacional, Me.lblDisponibleDolar, Me.lblTotalAbonadoNacional, Me.lblTotalAbonadoDolar, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(693, 213)
        Me.LayoutControlGroup2.Text = "Datos del Credito / Pago"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtIDProveedor
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1
        Me.LayoutControlItem1.Size = New System.Drawing.Size(179, 24)
        Me.LayoutControlItem1.Text = "Proveedor"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 13)
        '
        'Nombre
        '
        Me.Nombre.Control = Me.txtNombre
        Me.Nombre.Location = New System.Drawing.Point(179, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(490, 24)
        Me.Nombre.TextSize = New System.Drawing.Size(110, 13)
        '
        'TipoDocumento
        '
        Me.TipoDocumento.Control = Me.txtTipo
        Me.TipoDocumento.Location = New System.Drawing.Point(0, 24)
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.OptionsTableLayoutItem.ColumnIndex = 1
        Me.TipoDocumento.OptionsTableLayoutItem.RowIndex = 1
        Me.TipoDocumento.Size = New System.Drawing.Size(171, 24)
        Me.TipoDocumento.Text = "Clase Documento"
        Me.TipoDocumento.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(171, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.OptionsTableLayoutItem.RowIndex = 4
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(70, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDocumento
        Me.LayoutControlItem2.Location = New System.Drawing.Point(241, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.OptionsTableLayoutItem.RowIndex = 1
        Me.LayoutControlItem2.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem2.Text = "Documento"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblMontoOriginal
        '
        Me.lblMontoOriginal.Control = Me.txtMontoOriginal
        Me.lblMontoOriginal.Location = New System.Drawing.Point(241, 48)
        Me.lblMontoOriginal.Name = "lblMontoOriginal"
        Me.lblMontoOriginal.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblMontoOriginal.OptionsTableLayoutItem.RowIndex = 2
        Me.lblMontoOriginal.Size = New System.Drawing.Size(213, 24)
        Me.lblMontoOriginal.Text = "Monto Original Moneda"
        Me.lblMontoOriginal.TextSize = New System.Drawing.Size(110, 13)
        Me.lblMontoOriginal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lblSaldoOriginal
        '
        Me.lblSaldoOriginal.Control = Me.txtSaldoOriginal
        Me.lblSaldoOriginal.Location = New System.Drawing.Point(454, 48)
        Me.lblSaldoOriginal.Name = "lblSaldoOriginal"
        Me.lblSaldoOriginal.OptionsTableLayoutItem.RowIndex = 2
        Me.lblSaldoOriginal.Size = New System.Drawing.Size(215, 24)
        Me.lblSaldoOriginal.Text = "Saldo Moneda"
        Me.lblSaldoOriginal.TextSize = New System.Drawing.Size(110, 13)
        Me.lblSaldoOriginal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DateEditFecha
        Me.LayoutControlItem5.Location = New System.Drawing.Point(454, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.OptionsTableLayoutItem.RowIndex = 3
        Me.LayoutControlItem5.Size = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem5.Text = "Fecha"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(110, 13)
        '
        'TipoDocumento1
        '
        Me.TipoDocumento1.Control = Me.txtMoneda
        Me.TipoDocumento1.CustomizationFormText = "Clase Documento"
        Me.TipoDocumento1.Location = New System.Drawing.Point(0, 48)
        Me.TipoDocumento1.Name = "TipoDocumento1"
        Me.TipoDocumento1.OptionsTableLayoutItem.ColumnIndex = 1
        Me.TipoDocumento1.OptionsTableLayoutItem.RowIndex = 1
        Me.TipoDocumento1.Size = New System.Drawing.Size(241, 24)
        Me.TipoDocumento1.Text = "Moneda"
        Me.TipoDocumento1.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblSaldoConversion
        '
        Me.lblSaldoConversion.Control = Me.txtSaldoConversion
        Me.lblSaldoConversion.CustomizationFormText = "Saldo Moneda"
        Me.lblSaldoConversion.Location = New System.Drawing.Point(454, 72)
        Me.lblSaldoConversion.Name = "lblSaldoConversion"
        Me.lblSaldoConversion.OptionsTableLayoutItem.RowIndex = 2
        Me.lblSaldoConversion.Size = New System.Drawing.Size(215, 24)
        Me.lblSaldoConversion.Text = "Saldo C$"
        Me.lblSaldoConversion.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblMontoOriginalConversion
        '
        Me.lblMontoOriginalConversion.Control = Me.txtMontoOrigConversion
        Me.lblMontoOriginalConversion.CustomizationFormText = "MontoOriginal"
        Me.lblMontoOriginalConversion.Location = New System.Drawing.Point(241, 72)
        Me.lblMontoOriginalConversion.Name = "lblMontoOriginalConversion"
        Me.lblMontoOriginalConversion.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblMontoOriginalConversion.OptionsTableLayoutItem.RowIndex = 2
        Me.lblMontoOriginalConversion.Size = New System.Drawing.Size(213, 24)
        Me.lblMontoOriginalConversion.Text = "Monto Original C$"
        Me.lblMontoOriginalConversion.TextSize = New System.Drawing.Size(110, 13)
        '
        'TipoDocumento2
        '
        Me.TipoDocumento2.Control = Me.txtTipoCambio
        Me.TipoDocumento2.CustomizationFormText = "Clase Documento"
        Me.TipoDocumento2.Location = New System.Drawing.Point(0, 72)
        Me.TipoDocumento2.Name = "TipoDocumento2"
        Me.TipoDocumento2.OptionsTableLayoutItem.ColumnIndex = 1
        Me.TipoDocumento2.OptionsTableLayoutItem.RowIndex = 1
        Me.TipoDocumento2.Size = New System.Drawing.Size(241, 24)
        Me.TipoDocumento2.Text = "Tipo Cambio"
        Me.TipoDocumento2.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblDisponibleNacional
        '
        Me.lblDisponibleNacional.Control = Me.txtDisponibleNacional
        Me.lblDisponibleNacional.CustomizationFormText = "TotalAbonado Moneda"
        Me.lblDisponibleNacional.Location = New System.Drawing.Point(454, 96)
        Me.lblDisponibleNacional.Name = "lblDisponibleNacional"
        Me.lblDisponibleNacional.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblDisponibleNacional.OptionsTableLayoutItem.RowIndex = 3
        Me.lblDisponibleNacional.Size = New System.Drawing.Size(215, 24)
        Me.lblDisponibleNacional.Text = "Disponible C$"
        Me.lblDisponibleNacional.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblDisponibleDolar
        '
        Me.lblDisponibleDolar.Control = Me.txtDisponibleDolar
        Me.lblDisponibleDolar.CustomizationFormText = "TotalAbonado Moneda"
        Me.lblDisponibleDolar.Location = New System.Drawing.Point(241, 96)
        Me.lblDisponibleDolar.Name = "lblDisponibleDolar"
        Me.lblDisponibleDolar.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblDisponibleDolar.OptionsTableLayoutItem.RowIndex = 3
        Me.lblDisponibleDolar.Size = New System.Drawing.Size(213, 24)
        Me.lblDisponibleDolar.Text = "Disponible $"
        Me.lblDisponibleDolar.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblTotalAbonadoNacional
        '
        Me.lblTotalAbonadoNacional.Control = Me.txtTotalAbonadoNacional
        Me.lblTotalAbonadoNacional.CustomizationFormText = "TotalAbonado C$"
        Me.lblTotalAbonadoNacional.Location = New System.Drawing.Point(454, 120)
        Me.lblTotalAbonadoNacional.Name = "lblTotalAbonadoNacional"
        Me.lblTotalAbonadoNacional.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblTotalAbonadoNacional.OptionsTableLayoutItem.RowIndex = 3
        Me.lblTotalAbonadoNacional.Size = New System.Drawing.Size(215, 24)
        Me.lblTotalAbonadoNacional.Text = "TotalAbonado C$"
        Me.lblTotalAbonadoNacional.TextSize = New System.Drawing.Size(110, 13)
        '
        'lblTotalAbonadoDolar
        '
        Me.lblTotalAbonadoDolar.Control = Me.txtTotalAbonadoDolar
        Me.lblTotalAbonadoDolar.Location = New System.Drawing.Point(241, 120)
        Me.lblTotalAbonadoDolar.Name = "lblTotalAbonadoDolar"
        Me.lblTotalAbonadoDolar.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lblTotalAbonadoDolar.OptionsTableLayoutItem.RowIndex = 3
        Me.lblTotalAbonadoDolar.Size = New System.Drawing.Size(213, 24)
        Me.lblTotalAbonadoDolar.Text = "TotalAbonado Moneda"
        Me.lblTotalAbonadoDolar.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDifDolar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(241, 144)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(213, 27)
        Me.LayoutControlItem3.Text = "Dif. $"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtDifNacional
        Me.LayoutControlItem4.Location = New System.Drawing.Point(454, 144)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(215, 27)
        Me.LayoutControlItem4.Text = "Dif C$"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(241, 27)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(13, 262)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(941, 312)
        Me.GridControl2.TabIndex = 5
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDAplicacion, Me.IDDocumento, Me.ClaseDebito, Me.TipoDocumentoA, Me.DocDebito, Me.VencimientoA, Me.IDMoneda, Me.MonedaC, Me.FechaA, Me.SaldoCredito, Me.IDCredito, Me.ClaseCredito, Me.DocCredito, Me.FechaCredito, Me.MontoPago})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'IDAplicacion
        '
        Me.IDAplicacion.Caption = "IDAplicacion"
        Me.IDAplicacion.FieldName = "IDAplicacion"
        Me.IDAplicacion.Name = "IDAplicacion"
        '
        'IDDocumento
        '
        Me.IDDocumento.Caption = "IDDoc"
        Me.IDDocumento.FieldName = "IDDocumento"
        Me.IDDocumento.Name = "IDDocumento"
        Me.IDDocumento.Visible = True
        Me.IDDocumento.VisibleIndex = 7
        Me.IDDocumento.Width = 41
        '
        'ClaseDebito
        '
        Me.ClaseDebito.Caption = "Clase"
        Me.ClaseDebito.FieldName = "ClaseDebito"
        Me.ClaseDebito.Name = "ClaseDebito"
        Me.ClaseDebito.Visible = True
        Me.ClaseDebito.VisibleIndex = 8
        Me.ClaseDebito.Width = 51
        '
        'TipoDocumentoA
        '
        Me.TipoDocumentoA.Caption = "TipoDocumento"
        Me.TipoDocumentoA.FieldName = "TipoDocumento"
        Me.TipoDocumentoA.Name = "TipoDocumentoA"
        Me.TipoDocumentoA.Width = 92
        '
        'DocDebito
        '
        Me.DocDebito.Caption = "DocDebito"
        Me.DocDebito.FieldName = "DocDebito"
        Me.DocDebito.Name = "DocDebito"
        Me.DocDebito.Visible = True
        Me.DocDebito.VisibleIndex = 9
        Me.DocDebito.Width = 96
        '
        'VencimientoA
        '
        Me.VencimientoA.Caption = "Vencimiento"
        Me.VencimientoA.FieldName = "Vencimiento"
        Me.VencimientoA.Name = "VencimientoA"
        Me.VencimientoA.Visible = True
        Me.VencimientoA.VisibleIndex = 5
        Me.VencimientoA.Width = 85
        '
        'IDMoneda
        '
        Me.IDMoneda.Caption = "IDMoneda"
        Me.IDMoneda.FieldName = "IDMoneda"
        Me.IDMoneda.Name = "IDMoneda"
        '
        'MonedaC
        '
        Me.MonedaC.Caption = "Moneda"
        Me.MonedaC.FieldName = "DescrMoneda"
        Me.MonedaC.Name = "MonedaC"
        Me.MonedaC.Visible = True
        Me.MonedaC.VisibleIndex = 4
        Me.MonedaC.Width = 63
        '
        'FechaA
        '
        Me.FechaA.Caption = "Fecha"
        Me.FechaA.FieldName = "Fecha"
        Me.FechaA.Name = "FechaA"
        Me.FechaA.Visible = True
        Me.FechaA.VisibleIndex = 10
        Me.FechaA.Width = 80
        '
        'SaldoCredito
        '
        Me.SaldoCredito.Caption = "SaldoCredito"
        Me.SaldoCredito.DisplayFormat.FormatString = "n2"
        Me.SaldoCredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SaldoCredito.FieldName = "SaldoCredito"
        Me.SaldoCredito.Name = "SaldoCredito"
        Me.SaldoCredito.Visible = True
        Me.SaldoCredito.VisibleIndex = 6
        '
        'IDCredito
        '
        Me.IDCredito.Caption = "IDCredito"
        Me.IDCredito.FieldName = "IDCredito"
        Me.IDCredito.Name = "IDCredito"
        Me.IDCredito.Visible = True
        Me.IDCredito.VisibleIndex = 0
        Me.IDCredito.Width = 61
        '
        'ClaseCredito
        '
        Me.ClaseCredito.Caption = "ClaseCredito"
        Me.ClaseCredito.FieldName = "ClaseCredito"
        Me.ClaseCredito.Name = "ClaseCredito"
        Me.ClaseCredito.Visible = True
        Me.ClaseCredito.VisibleIndex = 1
        '
        'DocCredito
        '
        Me.DocCredito.Caption = "DocCredito"
        Me.DocCredito.FieldName = "DocCredito"
        Me.DocCredito.Name = "DocCredito"
        Me.DocCredito.Visible = True
        Me.DocCredito.VisibleIndex = 2
        Me.DocCredito.Width = 77
        '
        'FechaCredito
        '
        Me.FechaCredito.Caption = "FechaCredito"
        Me.FechaCredito.FieldName = "FechaCredito"
        Me.FechaCredito.Name = "FechaCredito"
        Me.FechaCredito.Visible = True
        Me.FechaCredito.VisibleIndex = 3
        Me.FechaCredito.Width = 84
        '
        'MontoPago
        '
        Me.MontoPago.Caption = "Abonado"
        Me.MontoPago.DisplayFormat.FormatString = "n2"
        Me.MontoPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoPago.FieldName = "MontoPago"
        Me.MontoPago.Name = "MontoPago"
        Me.MontoPago.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum), New DevExpress.XtraGrid.GridColumnSummaryItem()})
        Me.MontoPago.ToolTip = "El monto de Pago es en Moneda del Crédito"
        Me.MontoPago.Visible = True
        Me.MontoPago.VisibleIndex = 11
        Me.MontoPago.Width = 135
        '
        'btnReversaDocumento
        '
        Me.btnReversaDocumento.Location = New System.Drawing.Point(732, 49)
        Me.btnReversaDocumento.Name = "btnReversaDocumento"
        Me.btnReversaDocumento.Size = New System.Drawing.Size(145, 28)
        Me.btnReversaDocumento.TabIndex = 6
        Me.btnReversaDocumento.Text = "Revertir Documento"
        '
        'btnReversaAplicacion
        '
        Me.btnReversaAplicacion.Location = New System.Drawing.Point(732, 86)
        Me.btnReversaAplicacion.Name = "btnReversaAplicacion"
        Me.btnReversaAplicacion.Size = New System.Drawing.Size(147, 28)
        Me.btnReversaAplicacion.TabIndex = 7
        Me.btnReversaAplicacion.Text = "Revertir Toda la Aplicacion"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Los montos que Ud digite en la columna ""Abono"" coresponden a la moneda del Docume" & _
    "nto que Ud va a Abonar, no a la moneda del Documento de Pago"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(966, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 597)
        Me.barDockControlBottom.Size = New System.Drawing.Size(966, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 597)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(966, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 597)
        '
        'frmCPAplicaCreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 622)
        Me.Controls.Add(Me.btnReversaAplicacion)
        Me.Controls.Add(Me.btnReversaDocumento)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCPAplicaCreditos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Documentos"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAbonadoDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDifNacional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDifDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoOrigConversion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAbonadoNacional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoConversion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisponibleDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisponibleNacional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoOriginal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoOriginal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMontoOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSaldoOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSaldoConversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMontoOriginalConversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumento2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDisponibleNacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDisponibleDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalAbonadoNacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalAbonadoDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDCreditos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDClase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDSubTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiasVencidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Abono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalAbonadoDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DateEditFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtMontoOriginal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIDProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Nombre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TipoDocumento As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblSaldoOriginal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblMontoOriginal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTotalAbonadoDolar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoDocumentoA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaldoCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClaseDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClaseCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnReversaDocumento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReversaAplicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents IDAplicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VencimientoA As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents txtSaldoOriginal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TipoDocumento1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TipoDocumento2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMontoOrigConversion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMontoOriginalConversion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Moneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MonedaC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalAbonadoNacional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalAbonadoNacional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSaldoConversion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSaldoConversion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IDMonedaC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDisponibleDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDisponibleDolar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDisponibleNacional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDisponibleNacional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDifNacional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDifDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
