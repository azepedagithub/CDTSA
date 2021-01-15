<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupFactura
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescrTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescrMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NombreVendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescrUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LoteProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantFacturada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescrProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantBonificadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Precio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescuentoEspecial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubTotalFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantidadLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DateEditFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TxtEditTipo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(1, 68)
        Me.GridControl1.MainView = Me.GridViewDetalle
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1103, 233)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetalle})
        '
        'GridViewDetalle
        '
        Me.GridViewDetalle.Appearance.FilterPanel.Options.UseTextOptions = True
        Me.GridViewDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Factura, Me.Fecha, Me.IDCliente, Me.Nombre, Me.DescrTipo, Me.DescrMoneda, Me.NombreVendedor, Me.IDProducto, Me.DescrProducto, Me.DescrUnidad, Me.LoteProveedor, Me.CantFacturada, Me.CantidadLote, Me.CantBonificadas, Me.Cantidad, Me.Precio, Me.Descuento, Me.DescuentoEspecial, Me.SubTotal, Me.Impuesto, Me.SubTotalFinal, Me.TotalFinal})
        Me.GridViewDetalle.GridControl = Me.GridControl1
        Me.GridViewDetalle.Name = "GridViewDetalle"
        Me.GridViewDetalle.OptionsFilter.AllowFilterEditor = False
        Me.GridViewDetalle.OptionsView.AllowCellMerge = True
        Me.GridViewDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewDetalle.OptionsView.ShowFooter = True
        Me.GridViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'Factura
        '
        Me.Factura.Caption = "Factura"
        Me.Factura.FieldName = "Factura"
        Me.Factura.Name = "Factura"
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'IDCliente
        '
        Me.IDCliente.Caption = "IDCliente"
        Me.IDCliente.FieldName = "IDCliente"
        Me.IDCliente.Name = "IDCliente"
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'DescrTipo
        '
        Me.DescrTipo.Caption = "DescrTipo"
        Me.DescrTipo.FieldName = "DescrTipo"
        Me.DescrTipo.Name = "DescrTipo"
        '
        'DescrMoneda
        '
        Me.DescrMoneda.Caption = "DescrMoneda"
        Me.DescrMoneda.FieldName = "DescrMoneda"
        Me.DescrMoneda.Name = "DescrMoneda"
        '
        'NombreVendedor
        '
        Me.NombreVendedor.Caption = "NombreVendedor"
        Me.NombreVendedor.FieldName = "NombreVendedor"
        Me.NombreVendedor.Name = "NombreVendedor"
        '
        'IDProducto
        '
        Me.IDProducto.Caption = "ID"
        Me.IDProducto.FieldName = "IDProducto"
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.Visible = True
        Me.IDProducto.VisibleIndex = 0
        Me.IDProducto.Width = 52
        '
        'DescrUnidad
        '
        Me.DescrUnidad.Caption = "DescrUnidad"
        Me.DescrUnidad.FieldName = "DescrUnidad"
        Me.DescrUnidad.Name = "DescrUnidad"
        Me.DescrUnidad.Visible = True
        Me.DescrUnidad.VisibleIndex = 3
        Me.DescrUnidad.Width = 85
        '
        'LoteProveedor
        '
        Me.LoteProveedor.Caption = "Lote"
        Me.LoteProveedor.FieldName = "LoteProveedor"
        Me.LoteProveedor.Name = "LoteProveedor"
        Me.LoteProveedor.Visible = True
        Me.LoteProveedor.VisibleIndex = 12
        Me.LoteProveedor.Width = 84
        '
        'CantFacturada
        '
        Me.CantFacturada.Caption = "Facturadas"
        Me.CantFacturada.DisplayFormat.FormatString = "n0"
        Me.CantFacturada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CantFacturada.FieldName = "CantFacturada"
        Me.CantFacturada.Name = "CantFacturada"
        Me.CantFacturada.Visible = True
        Me.CantFacturada.VisibleIndex = 4
        Me.CantFacturada.Width = 72
        '
        'DescrProducto
        '
        Me.DescrProducto.Caption = "DescrProducto"
        Me.DescrProducto.FieldName = "DescrProducto"
        Me.DescrProducto.Name = "DescrProducto"
        Me.DescrProducto.Visible = True
        Me.DescrProducto.VisibleIndex = 1
        Me.DescrProducto.Width = 138
        '
        'CantBonificadas
        '
        Me.CantBonificadas.Caption = "Bonificadas"
        Me.CantBonificadas.DisplayFormat.FormatString = "n0"
        Me.CantBonificadas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CantBonificadas.FieldName = "CantBonificada"
        Me.CantBonificadas.Name = "CantBonificadas"
        Me.CantBonificadas.Visible = True
        Me.CantBonificadas.VisibleIndex = 5
        Me.CantBonificadas.Width = 72
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "CantTotal"
        Me.Cantidad.DisplayFormat.FormatString = "n0"
        Me.Cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 6
        Me.Cantidad.Width = 76
        '
        'Precio
        '
        Me.Precio.Caption = "Precio"
        Me.Precio.DisplayFormat.FormatString = "n2"
        Me.Precio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Precio.FieldName = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Visible = True
        Me.Precio.VisibleIndex = 2
        Me.Precio.Width = 74
        '
        'Descuento
        '
        Me.Descuento.Caption = "Descuento"
        Me.Descuento.DisplayFormat.FormatString = "n2"
        Me.Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Descuento.FieldName = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Visible = True
        Me.Descuento.VisibleIndex = 8
        Me.Descuento.Width = 77
        '
        'DescuentoEspecial
        '
        Me.DescuentoEspecial.Caption = "DescEsp"
        Me.DescuentoEspecial.DisplayFormat.FormatString = "n2"
        Me.DescuentoEspecial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DescuentoEspecial.FieldName = "DescuentoEspecial"
        Me.DescuentoEspecial.Name = "DescuentoEspecial"
        Me.DescuentoEspecial.Visible = True
        Me.DescuentoEspecial.VisibleIndex = 9
        Me.DescuentoEspecial.Width = 67
        '
        'SubTotal
        '
        Me.SubTotal.Caption = "SubTotal"
        Me.SubTotal.DisplayFormat.FormatString = "n2"
        Me.SubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SubTotal.FieldName = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Visible = True
        Me.SubTotal.VisibleIndex = 7
        Me.SubTotal.Width = 77
        '
        'Impuesto
        '
        Me.Impuesto.Caption = "Impuesto"
        Me.Impuesto.DisplayFormat.FormatString = "n2"
        Me.Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Impuesto.FieldName = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Visible = True
        Me.Impuesto.VisibleIndex = 10
        Me.Impuesto.Width = 81
        '
        'SubTotalFinal
        '
        Me.SubTotalFinal.Caption = "SubTotalFinal"
        Me.SubTotalFinal.FieldName = "SubTotalFinal"
        Me.SubTotalFinal.Name = "SubTotalFinal"
        Me.SubTotalFinal.Width = 79
        '
        'TotalFinal
        '
        Me.TotalFinal.Caption = "TotalFinal"
        Me.TotalFinal.DisplayFormat.FormatString = "n2"
        Me.TotalFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalFinal.FieldName = "TotalFinal"
        Me.TotalFinal.Name = "TotalFinal"
        Me.TotalFinal.Visible = True
        Me.TotalFinal.VisibleIndex = 11
        Me.TotalFinal.Width = 79
        '
        'CantidadLote
        '
        Me.CantidadLote.Caption = "CantLote"
        Me.CantidadLote.DisplayFormat.FormatString = "n0"
        Me.CantidadLote.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CantidadLote.FieldName = "CantidadLote"
        Me.CantidadLote.Name = "CantidadLote"
        Me.CantidadLote.Visible = True
        Me.CantidadLote.VisibleIndex = 13
        Me.CantidadLote.Width = 63
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtEditTipo)
        Me.LayoutControl1.Controls.Add(Me.DateEditFecha)
        Me.LayoutControl1.Controls.Add(Me.txtTipoCambio)
        Me.LayoutControl1.Controls.Add(Me.txtMoneda)
        Me.LayoutControl1.Controls.Add(Me.txtVendedor)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Location = New System.Drawing.Point(20, -10)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(893, 72)
        Me.LayoutControl1.TabIndex = 10
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(893, 72)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(76, 12)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Properties.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(95, 20)
        Me.txtFactura.StyleController = Me.LayoutControl1
        Me.txtFactura.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtFactura
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem1.Text = "Factura"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(76, 36)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(368, 20)
        Me.txtCliente.StyleController = Me.LayoutControl1
        Me.txtCliente.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCliente
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(436, 28)
        Me.LayoutControlItem2.Text = "Cliente"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(512, 36)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Properties.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(369, 20)
        Me.txtVendedor.StyleController = Me.LayoutControl1
        Me.txtVendedor.TabIndex = 6
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtVendedor
        Me.LayoutControlItem3.Location = New System.Drawing.Point(436, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(437, 28)
        Me.LayoutControlItem3.Text = "Vendedor"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(547, 12)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Properties.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(128, 20)
        Me.txtMoneda.StyleController = Me.LayoutControl1
        Me.txtMoneda.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtMoneda
        Me.LayoutControlItem4.Location = New System.Drawing.Point(471, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem4.Text = "Moneda"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(393, 12)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Properties.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(86, 20)
        Me.txtTipoCambio.StyleController = Me.LayoutControl1
        Me.txtTipoCambio.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTipoCambio
        Me.LayoutControlItem5.Location = New System.Drawing.Point(317, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(154, 24)
        Me.LayoutControlItem5.Text = "TipoCambio"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
        '
        'DateEditFecha
        '
        Me.DateEditFecha.EditValue = Nothing
        Me.DateEditFecha.Location = New System.Drawing.Point(239, 12)
        Me.DateEditFecha.Name = "DateEditFecha"
        Me.DateEditFecha.Properties.AllowFocused = False
        Me.DateEditFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Size = New System.Drawing.Size(86, 20)
        Me.DateEditFecha.StyleController = Me.LayoutControl1
        Me.DateEditFecha.TabIndex = 9
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DateEditFecha
        Me.LayoutControlItem6.Location = New System.Drawing.Point(163, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(154, 24)
        Me.LayoutControlItem6.Text = "Fecha"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
        '
        'TxtEditTipo
        '
        Me.TxtEditTipo.Location = New System.Drawing.Point(743, 12)
        Me.TxtEditTipo.Name = "TxtEditTipo"
        Me.TxtEditTipo.Properties.ReadOnly = True
        Me.TxtEditTipo.Size = New System.Drawing.Size(138, 20)
        Me.TxtEditTipo.StyleController = Me.LayoutControl1
        Me.TxtEditTipo.TabIndex = 10
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TxtEditTipo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(667, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem7.Text = "Tipo Factura"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
        '
        'frmPopupFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 313)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPopupFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Factura"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescrTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescrMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NombreVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescrProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescrUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoteProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CantFacturada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CantidadLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CantBonificadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Precio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescuentoEspecial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubTotalFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtEditTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEditFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
