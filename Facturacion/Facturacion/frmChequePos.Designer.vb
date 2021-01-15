<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequePos
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
        Me.lblChequeNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblCobrado = New DevExpress.XtraEditors.LabelControl()
        Me.lblSinFondo = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonto = New DevExpress.XtraEditors.LabelControl()
        Me.lblBanco = New DevExpress.XtraEditors.LabelControl()
        Me.lblRecibo = New DevExpress.XtraEditors.LabelControl()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaCobro = New DevExpress.XtraEditors.LabelControl()
        Me.btnCobrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSinFondo = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'lblChequeNo
        '
        Me.lblChequeNo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblChequeNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblChequeNo.Location = New System.Drawing.Point(573, 46)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(153, 19)
        Me.lblChequeNo.TabIndex = 0
        Me.lblChequeNo.Text = "Cheque No "
        '
        'lblCobrado
        '
        Me.lblCobrado.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCobrado.Location = New System.Drawing.Point(112, 272)
        Me.lblCobrado.Name = "lblCobrado"
        Me.lblCobrado.Size = New System.Drawing.Size(76, 23)
        Me.lblCobrado.TabIndex = 1
        Me.lblCobrado.Text = "Cobrado "
        '
        'lblSinFondo
        '
        Me.lblSinFondo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinFondo.Location = New System.Drawing.Point(517, 272)
        Me.lblSinFondo.Name = "lblSinFondo"
        Me.lblSinFondo.Size = New System.Drawing.Size(90, 23)
        Me.lblSinFondo.TabIndex = 2
        Me.lblSinFondo.Text = "Sin Fondo "
        '
        'lblMonto
        '
        Me.lblMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(573, 145)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(70, 23)
        Me.lblMonto.TabIndex = 3
        Me.lblMonto.Text = "Monto   "
        '
        'lblBanco
        '
        Me.lblBanco.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBanco.Location = New System.Drawing.Point(142, 63)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(308, 19)
        Me.lblBanco.TabIndex = 4
        Me.lblBanco.Text = "Banco : "
        '
        'lblRecibo
        '
        Me.lblRecibo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblRecibo.Location = New System.Drawing.Point(248, 176)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(315, 23)
        Me.lblRecibo.TabIndex = 5
        Me.lblRecibo.Text = "Recibo No "
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCliente.Location = New System.Drawing.Point(154, 108)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(365, 41)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "Cliente  : "
        '
        'lblFechaCobro
        '
        Me.lblFechaCobro.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblFechaCobro.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaCobro.Location = New System.Drawing.Point(573, 80)
        Me.lblFechaCobro.Name = "lblFechaCobro"
        Me.lblFechaCobro.Size = New System.Drawing.Size(177, 19)
        Me.lblFechaCobro.TabIndex = 7
        Me.lblFechaCobro.Text = "Fecha Cobro"
        '
        'btnCobrar
        '
        Me.btnCobrar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCobrar.Appearance.Options.UseFont = True
        Me.btnCobrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCobrar.Location = New System.Drawing.Point(189, 361)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(154, 26)
        Me.btnCobrar.TabIndex = 8
        Me.btnCobrar.Text = "Cheque Cobrado"
        '
        'btnSinFondo
        '
        Me.btnSinFondo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSinFondo.Appearance.Options.UseFont = True
        Me.btnSinFondo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnSinFondo.Location = New System.Drawing.Point(517, 361)
        Me.btnSinFondo.Name = "btnSinFondo"
        Me.btnSinFondo.Size = New System.Drawing.Size(160, 26)
        Me.btnSinFondo.TabIndex = 9
        Me.btnSinFondo.Text = "Cheque Sin Fondos"
        '
        'frmChequePos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Facturacion.My.Resources.Resources.fondoChequev2
        Me.ClientSize = New System.Drawing.Size(811, 415)
        Me.Controls.Add(Me.btnSinFondo)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.lblFechaCobro)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblRecibo)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblSinFondo)
        Me.Controls.Add(Me.lblCobrado)
        Me.Controls.Add(Me.lblChequeNo)
        Me.Name = "frmChequePos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Recibido del Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChequeNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCobrado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSinFondo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBanco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRecibo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaCobro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCobrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSinFondo As DevExpress.XtraEditors.SimpleButton
End Class
