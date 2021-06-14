<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtmpMain
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEmpleado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConcepto = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'cmdEmpleado
        '
        Me.cmdEmpleado.Location = New System.Drawing.Point(50, 38)
        Me.cmdEmpleado.Name = "cmdEmpleado"
        Me.cmdEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.cmdEmpleado.TabIndex = 0
        Me.cmdEmpleado.Text = "Empleados"
        '
        'cmdConcepto
        '
        Me.cmdConcepto.Location = New System.Drawing.Point(50, 81)
        Me.cmdConcepto.Name = "cmdConcepto"
        Me.cmdConcepto.Size = New System.Drawing.Size(75, 23)
        Me.cmdConcepto.TabIndex = 1
        Me.cmdConcepto.Text = "Conceptos"
        '
        'frmtmpMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 262)
        Me.Controls.Add(Me.cmdConcepto)
        Me.Controls.Add(Me.cmdEmpleado)
        Me.Name = "frmtmpMain"
        Me.Text = "frmtmpMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdEmpleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConcepto As DevExpress.XtraEditors.SimpleButton
End Class
