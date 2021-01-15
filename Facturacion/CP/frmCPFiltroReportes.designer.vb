<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPFiltroReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPFiltroReportes))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEditDolar = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditConsolidaSucursal = New DevExpress.XtraEditors.CheckEdit()
        Me.lblFechaInic = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaFin = New DevExpress.XtraEditors.LabelControl()
        Me.DateEditFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditFechaInicial = New DevExpress.XtraEditors.DateEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.btnCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.txtIDProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.CheckEditDolar.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CheckEditConsolidaSucursal.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEditFechaFinal.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEditFechaFinal.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEditFechaInicial.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEditFechaInicial.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNombre.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIDProveedor.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEditDolar)
        Me.GroupControl1.Controls.Add(Me.CheckEditConsolidaSucursal)
        Me.GroupControl1.Controls.Add(Me.lblFechaInic)
        Me.GroupControl1.Controls.Add(Me.lblFechaFin)
        Me.GroupControl1.Controls.Add(Me.DateEditFechaFinal)
        Me.GroupControl1.Controls.Add(Me.DateEditFechaInicial)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.btnCliente)
        Me.GroupControl1.Controls.Add(Me.lblCliente)
        Me.GroupControl1.Controls.Add(Me.txtIDProveedor)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(600, 191)
        Me.GroupControl1.TabIndex = 0
        '
        'CheckEditDolar
        '
        Me.CheckEditDolar.Location = New System.Drawing.Point(290, 151)
        Me.CheckEditDolar.Name = "CheckEditDolar"
        Me.CheckEditDolar.Properties.Caption = "En Dolar"
        Me.CheckEditDolar.Size = New System.Drawing.Size(147, 19)
        Me.CheckEditDolar.TabIndex = 15
        '
        'CheckEditConsolidaSucursal
        '
        Me.CheckEditConsolidaSucursal.Location = New System.Drawing.Point(85, 151)
        Me.CheckEditConsolidaSucursal.Name = "CheckEditConsolidaSucursal"
        Me.CheckEditConsolidaSucursal.Properties.Caption = "Consolidado por Sucursal"
        Me.CheckEditConsolidaSucursal.Size = New System.Drawing.Size(147, 19)
        Me.CheckEditConsolidaSucursal.TabIndex = 14
        '
        'lblFechaInic
        '
        Me.lblFechaInic.Location = New System.Drawing.Point(84, 107)
        Me.lblFechaInic.Name = "lblFechaInic"
        Me.lblFechaInic.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaInic.TabIndex = 13
        Me.lblFechaInic.Text = "Fecha Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(280, 107)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lblFechaFin.TabIndex = 12
        Me.lblFechaFin.Text = "Fecha Final"
        '
        'DateEditFechaFinal
        '
        Me.DateEditFechaFinal.EditValue = Nothing
        Me.DateEditFechaFinal.Location = New System.Drawing.Point(358, 104)
        Me.DateEditFechaFinal.Name = "DateEditFechaFinal"
        Me.DateEditFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFechaFinal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DateEditFechaFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEditFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.DateEditFechaFinal.TabIndex = 11
        '
        'DateEditFechaInicial
        '
        Me.DateEditFechaInicial.EditValue = Nothing
        Me.DateEditFechaInicial.Location = New System.Drawing.Point(153, 104)
        Me.DateEditFechaInicial.Name = "DateEditFechaInicial"
        Me.DateEditFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFechaInicial.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DateEditFechaInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEditFechaInicial.Size = New System.Drawing.Size(102, 20)
        Me.DateEditFechaInicial.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(212, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(315, 20)
        Me.txtNombre.TabIndex = 7
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"),System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(167, 55)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(39, 23)
        Me.btnCliente.TabIndex = 6
        Me.btnCliente.Text = "..."
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(16, 60)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 13)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Proveedor"
        '
        'txtIDProveedor
        '
        Me.txtIDProveedor.Location = New System.Drawing.Point(85, 57)
        Me.txtIDProveedor.Name = "txtIDProveedor"
        Me.txtIDProveedor.Size = New System.Drawing.Size(54, 20)
        Me.txtIDProveedor.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"),System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(144, 226)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"),System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(400, 226)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"),System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(275, 226)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Limpiar"
        '
        'frmCPFiltroReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 261)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmCPFiltroReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro para Reportes"
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.CheckEditDolar.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CheckEditConsolidaSucursal.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEditFechaFinal.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEditFechaFinal.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEditFechaInicial.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEditFechaInicial.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNombre.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIDProveedor.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtIDProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEditDolar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditConsolidaSucursal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblFechaInic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaFin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
End Class
