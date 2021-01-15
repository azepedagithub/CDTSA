<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionesRC
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
        Me.datagrid = New DevExpress.XtraGrid.GridControl()
        Me.GridViewProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDClase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Recibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDDebito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Efectivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RetencionMunicipal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RetencionRenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDChequePos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SinFondo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cobrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoAplicado = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid
        '
        Me.datagrid.Location = New System.Drawing.Point(-2, 1)
        Me.datagrid.MainView = Me.GridViewProducto
        Me.datagrid.Name = "datagrid"
        Me.datagrid.Size = New System.Drawing.Size(1181, 462)
        Me.datagrid.TabIndex = 2
        Me.datagrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProducto})
        '
        'GridViewProducto
        '
        Me.GridViewProducto.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDClase, Me.IDCredito, Me.Recibo, Me.Fecha, Me.TotalRecibo, Me.IDDebito, Me.Factura, Me.FechaFactura, Me.Efectivo, Me.Descuento, Me.RetencionMunicipal, Me.RetencionRenta, Me.IDChequePos, Me.MontoCheque, Me.SinFondo, Me.Cobrado, Me.MontoAplicado})
        Me.GridViewProducto.GridControl = Me.datagrid
        Me.GridViewProducto.Name = "GridViewProducto"
        Me.GridViewProducto.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewProducto.OptionsBehavior.Editable = False
        Me.GridViewProducto.OptionsView.ShowGroupPanel = False
        '
        'IDClase
        '
        Me.IDClase.Caption = "Tipo"
        Me.IDClase.FieldName = "IDClase"
        Me.IDClase.Name = "IDClase"
        Me.IDClase.Visible = True
        Me.IDClase.VisibleIndex = 0
        Me.IDClase.Width = 41
        '
        'IDCredito
        '
        Me.IDCredito.Caption = "ID"
        Me.IDCredito.FieldName = "IDCredito"
        Me.IDCredito.Name = "IDCredito"
        Me.IDCredito.Width = 68
        '
        'Recibo
        '
        Me.Recibo.Caption = "Recibo"
        Me.Recibo.FieldName = "Recibo"
        Me.Recibo.Name = "Recibo"
        Me.Recibo.Visible = True
        Me.Recibo.VisibleIndex = 1
        Me.Recibo.Width = 106
        '
        'Fecha
        '
        Me.Fecha.Caption = "FechaDoc"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 2
        Me.Fecha.Width = 70
        '
        'TotalRecibo
        '
        Me.TotalRecibo.Caption = "Total R/C"
        Me.TotalRecibo.FieldName = "TotalRecibo"
        Me.TotalRecibo.Name = "TotalRecibo"
        Me.TotalRecibo.Visible = True
        Me.TotalRecibo.VisibleIndex = 3
        Me.TotalRecibo.Width = 92
        '
        'IDDebito
        '
        Me.IDDebito.AppearanceCell.Options.UseTextOptions = True
        Me.IDDebito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDDebito.AppearanceHeader.Options.UseTextOptions = True
        Me.IDDebito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDDebito.Caption = "ID"
        Me.IDDebito.FieldName = "IDDebito"
        Me.IDDebito.Name = "IDDebito"
        Me.IDDebito.Width = 47
        '
        'Factura
        '
        Me.Factura.AppearanceCell.Options.UseTextOptions = True
        Me.Factura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Factura.AppearanceHeader.Options.UseTextOptions = True
        Me.Factura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Factura.Caption = "Factura"
        Me.Factura.FieldName = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Visible = True
        Me.Factura.VisibleIndex = 4
        Me.Factura.Width = 88
        '
        'FechaFactura
        '
        Me.FechaFactura.Caption = "Fecha"
        Me.FechaFactura.FieldName = "FechaFactura"
        Me.FechaFactura.Name = "FechaFactura"
        Me.FechaFactura.Visible = True
        Me.FechaFactura.VisibleIndex = 5
        Me.FechaFactura.Width = 63
        '
        'Efectivo
        '
        Me.Efectivo.AppearanceCell.Options.UseTextOptions = True
        Me.Efectivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Efectivo.Caption = "Efectivo"
        Me.Efectivo.DisplayFormat.FormatString = "n2"
        Me.Efectivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Efectivo.FieldName = "Efectivo"
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Visible = True
        Me.Efectivo.VisibleIndex = 6
        Me.Efectivo.Width = 82
        '
        'Descuento
        '
        Me.Descuento.AppearanceCell.Options.UseTextOptions = True
        Me.Descuento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Descuento.Caption = "Descuento"
        Me.Descuento.DisplayFormat.FormatString = "n2"
        Me.Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Descuento.FieldName = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Visible = True
        Me.Descuento.VisibleIndex = 7
        Me.Descuento.Width = 70
        '
        'RetencionMunicipal
        '
        Me.RetencionMunicipal.Caption = "RetMunicipal"
        Me.RetencionMunicipal.DisplayFormat.FormatString = "n2"
        Me.RetencionMunicipal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RetencionMunicipal.FieldName = "RetencionMunicipal"
        Me.RetencionMunicipal.Name = "RetencionMunicipal"
        Me.RetencionMunicipal.Visible = True
        Me.RetencionMunicipal.VisibleIndex = 8
        Me.RetencionMunicipal.Width = 89
        '
        'RetencionRenta
        '
        Me.RetencionRenta.AppearanceCell.Options.UseTextOptions = True
        Me.RetencionRenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RetencionRenta.Caption = "RetRenta"
        Me.RetencionRenta.DisplayFormat.FormatString = "n2"
        Me.RetencionRenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RetencionRenta.FieldName = "RetencionRenta"
        Me.RetencionRenta.Name = "RetencionRenta"
        Me.RetencionRenta.Visible = True
        Me.RetencionRenta.VisibleIndex = 9
        Me.RetencionRenta.Width = 74
        '
        'IDChequePos
        '
        Me.IDChequePos.Caption = "NumeroChk"
        Me.IDChequePos.FieldName = "Numero"
        Me.IDChequePos.Name = "IDChequePos"
        Me.IDChequePos.Visible = True
        Me.IDChequePos.VisibleIndex = 10
        Me.IDChequePos.Width = 72
        '
        'MontoCheque
        '
        Me.MontoCheque.AppearanceCell.Options.UseTextOptions = True
        Me.MontoCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MontoCheque.Caption = "MontoCheque"
        Me.MontoCheque.DisplayFormat.FormatString = "n2"
        Me.MontoCheque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoCheque.FieldName = "MontoChequePos"
        Me.MontoCheque.Name = "MontoCheque"
        Me.MontoCheque.Visible = True
        Me.MontoCheque.VisibleIndex = 11
        Me.MontoCheque.Width = 76
        '
        'SinFondo
        '
        Me.SinFondo.Caption = "SinFondo"
        Me.SinFondo.FieldName = "SinFondo"
        Me.SinFondo.Name = "SinFondo"
        Me.SinFondo.Visible = True
        Me.SinFondo.VisibleIndex = 12
        Me.SinFondo.Width = 55
        '
        'Cobrado
        '
        Me.Cobrado.Caption = "Cobrado"
        Me.Cobrado.FieldName = "Cobrado"
        Me.Cobrado.Name = "Cobrado"
        Me.Cobrado.Visible = True
        Me.Cobrado.VisibleIndex = 13
        Me.Cobrado.Width = 61
        '
        'MontoAplicado
        '
        Me.MontoAplicado.Caption = "Aplicado"
        Me.MontoAplicado.DisplayFormat.FormatString = "n2"
        Me.MontoAplicado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoAplicado.FieldName = "MontoAplicado"
        Me.MontoAplicado.Name = "MontoAplicado"
        Me.MontoAplicado.Visible = True
        Me.MontoAplicado.VisibleIndex = 14
        Me.MontoAplicado.Width = 124
        '
        'frmAplicacionesRC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 467)
        Me.Controls.Add(Me.datagrid)
        Me.Name = "frmAplicacionesRC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicaciones de un Recibo de Caja"
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProducto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDClase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Recibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Efectivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RetencionRenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDChequePos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoAplicado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SinFondo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cobrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RetencionMunicipal As DevExpress.XtraGrid.Columns.GridColumn
End Class
