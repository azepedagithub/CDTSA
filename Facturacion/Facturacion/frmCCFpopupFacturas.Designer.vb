<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCFpopupFacturas
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDDebito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDClase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDSubTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiasVencidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDMonedaC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Moneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(1, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(809, 365)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDDebito, Me.IDClase, Me.IDSubTipo, Me.Documento, Me.Fecha, Me.Vencimiento, Me.DiasVencidos, Me.IDMonedaC, Me.Moneda, Me.Saldo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowViewCaption = True
        Me.GridView1.ViewCaption = "Documentos Pendientes de Pago"
        '
        'IDDebito
        '
        Me.IDDebito.Caption = "IDDebito"
        Me.IDDebito.FieldName = "IDDebito"
        Me.IDDebito.Name = "IDDebito"
        Me.IDDebito.OptionsColumn.AllowEdit = False
        Me.IDDebito.OptionsColumn.ReadOnly = True
        Me.IDDebito.Visible = True
        Me.IDDebito.VisibleIndex = 0
        Me.IDDebito.Width = 74
        '
        'IDClase
        '
        Me.IDClase.Caption = "IDClase"
        Me.IDClase.FieldName = "IDClase"
        Me.IDClase.Name = "IDClase"
        Me.IDClase.OptionsColumn.AllowEdit = False
        Me.IDClase.OptionsColumn.ReadOnly = True
        Me.IDClase.Visible = True
        Me.IDClase.VisibleIndex = 1
        Me.IDClase.Width = 73
        '
        'IDSubTipo
        '
        Me.IDSubTipo.Caption = "IDSubTipo"
        Me.IDSubTipo.FieldName = "IDSubTipo"
        Me.IDSubTipo.Name = "IDSubTipo"
        Me.IDSubTipo.OptionsColumn.AllowEdit = False
        Me.IDSubTipo.OptionsColumn.ReadOnly = True
        Me.IDSubTipo.Visible = True
        Me.IDSubTipo.VisibleIndex = 2
        Me.IDSubTipo.Width = 81
        '
        'Documento
        '
        Me.Documento.Caption = "Documento"
        Me.Documento.FieldName = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.OptionsColumn.AllowEdit = False
        Me.Documento.OptionsColumn.ReadOnly = True
        Me.Documento.Visible = True
        Me.Documento.VisibleIndex = 3
        Me.Documento.Width = 112
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.OptionsColumn.AllowEdit = False
        Me.Fecha.OptionsColumn.ReadOnly = True
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 4
        Me.Fecha.Width = 88
        '
        'Vencimiento
        '
        Me.Vencimiento.Caption = "Vencimiento"
        Me.Vencimiento.FieldName = "Vencimiento"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.OptionsColumn.AllowEdit = False
        Me.Vencimiento.OptionsColumn.ReadOnly = True
        Me.Vencimiento.Visible = True
        Me.Vencimiento.VisibleIndex = 5
        Me.Vencimiento.Width = 106
        '
        'DiasVencidos
        '
        Me.DiasVencidos.Caption = "DiasVencidos"
        Me.DiasVencidos.FieldName = "DiasVencidos"
        Me.DiasVencidos.Name = "DiasVencidos"
        Me.DiasVencidos.OptionsColumn.AllowEdit = False
        Me.DiasVencidos.OptionsColumn.ReadOnly = True
        Me.DiasVencidos.Visible = True
        Me.DiasVencidos.VisibleIndex = 6
        Me.DiasVencidos.Width = 110
        '
        'IDMonedaC
        '
        Me.IDMonedaC.Caption = "IDMoneda"
        Me.IDMonedaC.FieldName = "IDMoneda"
        Me.IDMonedaC.Name = "IDMonedaC"
        Me.IDMonedaC.OptionsColumn.AllowEdit = False
        Me.IDMonedaC.OptionsColumn.ReadOnly = True
        '
        'Moneda
        '
        Me.Moneda.Caption = "Moneda"
        Me.Moneda.FieldName = "DescrMoneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.OptionsColumn.AllowEdit = False
        Me.Moneda.OptionsColumn.ReadOnly = True
        Me.Moneda.Visible = True
        Me.Moneda.VisibleIndex = 7
        Me.Moneda.Width = 148
        '
        'Saldo
        '
        Me.Saldo.Caption = "Saldo"
        Me.Saldo.FieldName = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.OptionsColumn.AllowEdit = False
        Me.Saldo.OptionsColumn.ReadOnly = True
        Me.Saldo.Visible = True
        Me.Saldo.VisibleIndex = 8
        Me.Saldo.Width = 101
        '
        'frmCCFpopupFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 370)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmCCFpopupFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos por Cobrar"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDClase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDSubTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiasVencidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDMonedaC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Moneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Saldo As DevExpress.XtraGrid.Columns.GridColumn
End Class
