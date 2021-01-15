<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCFCreaDocAnulado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCCFCreaDocAnulado))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SearchLookUpEditClase = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEditSubTipo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.rbCreditos = New System.Windows.Forms.RadioButton()
        Me.rbDebitos = New System.Windows.Forms.RadioButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SearchLookUpEditSucursal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.DateEditFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMascara = New System.Windows.Forms.Label()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SearchLookUpEditMoneda = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SearchLookUpEditClase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditSubTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEditMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.SearchLookUpEditMoneda)
        Me.GroupControl1.Controls.Add(Me.lblMascara)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.DateEditFecha)
        Me.GroupControl1.Controls.Add(Me.txtDocumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtIDCliente)
        Me.GroupControl1.Controls.Add(Me.btnCliente)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.SearchLookUpEditSucursal)
        Me.GroupControl1.Controls.Add(Me.rbCreditos)
        Me.GroupControl1.Controls.Add(Me.rbDebitos)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SearchLookUpEditSubTipo)
        Me.GroupControl1.Controls.Add(Me.SearchLookUpEditClase)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(561, 261)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Digite el Número y datos del Documento que hay que grabar ANULADO"
        '
        'SearchLookUpEditClase
        '
        Me.SearchLookUpEditClase.Location = New System.Drawing.Point(88, 118)
        Me.SearchLookUpEditClase.Name = "SearchLookUpEditClase"
        Me.SearchLookUpEditClase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditClase.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEditClase.Size = New System.Drawing.Size(125, 20)
        Me.SearchLookUpEditClase.TabIndex = 0
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEditSubTipo
        '
        Me.SearchLookUpEditSubTipo.Location = New System.Drawing.Point(275, 118)
        Me.SearchLookUpEditSubTipo.Name = "SearchLookUpEditSubTipo"
        Me.SearchLookUpEditSubTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditSubTipo.Properties.View = Me.SearchLookUpEdit2View
        Me.SearchLookUpEditSubTipo.Size = New System.Drawing.Size(274, 20)
        Me.SearchLookUpEditSubTipo.TabIndex = 1
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(221, 121)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "SubTipo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 121)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Clase "
        '
        'rbCreditos
        '
        Me.rbCreditos.AutoSize = True
        Me.rbCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCreditos.Location = New System.Drawing.Point(275, 78)
        Me.rbCreditos.Name = "rbCreditos"
        Me.rbCreditos.Size = New System.Drawing.Size(131, 19)
        Me.rbCreditos.TabIndex = 14
        Me.rbCreditos.Text = "Créditos del Cliente"
        Me.rbCreditos.UseVisualStyleBackColor = True
        '
        'rbDebitos
        '
        Me.rbDebitos.AutoSize = True
        Me.rbDebitos.Checked = True
        Me.rbDebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDebitos.Location = New System.Drawing.Point(111, 78)
        Me.rbDebitos.Name = "rbDebitos"
        Me.rbDebitos.Size = New System.Drawing.Size(128, 19)
        Me.rbDebitos.TabIndex = 13
        Me.rbDebitos.TabStop = True
        Me.rbDebitos.Text = "Débitos del Cliente"
        Me.rbDebitos.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Sucursal"
        '
        'SearchLookUpEditSucursal
        '
        Me.SearchLookUpEditSucursal.Location = New System.Drawing.Point(92, 23)
        Me.SearchLookUpEditSucursal.Name = "SearchLookUpEditSucursal"
        Me.SearchLookUpEditSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditSucursal.Properties.View = Me.GridView1
        Me.SearchLookUpEditSucursal.Size = New System.Drawing.Size(457, 20)
        Me.SearchLookUpEditSucursal.TabIndex = 15
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnCliente
        '
        Me.btnCliente.Appearance.Image = CType(resources.GetObject("btnCliente.Appearance.Image"), System.Drawing.Image)
        Me.btnCliente.Appearance.Options.UseImage = True
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(157, 50)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(40, 22)
        Me.btnCliente.TabIndex = 17
        Me.btnCliente.Text = "..."
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(92, 52)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(59, 20)
        Me.txtIDCliente.TabIndex = 18
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Cliente"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(203, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(346, 20)
        Me.txtNombre.TabIndex = 20
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(132, 185)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Documento Número :"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(275, 182)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(125, 20)
        Me.txtDocumento.TabIndex = 22
        '
        'DateEditFecha
        '
        Me.DateEditFecha.EditValue = Nothing
        Me.DateEditFecha.Location = New System.Drawing.Point(86, 149)
        Me.DateEditFecha.Name = "DateEditFecha"
        Me.DateEditFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFecha.Size = New System.Drawing.Size(125, 20)
        Me.DateEditFecha.TabIndex = 23
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(42, 152)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Fecha "
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(172, 220)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(300, 220)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        '
        'lblMascara
        '
        Me.lblMascara.AutoSize = True
        Me.lblMascara.Location = New System.Drawing.Point(419, 185)
        Me.lblMascara.Name = "lblMascara"
        Me.lblMascara.Size = New System.Drawing.Size(130, 13)
        Me.lblMascara.TabIndex = 27
        Me.lblMascara.Text = "                                         "
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(221, 152)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 29
        Me.LabelControl7.Text = "Moneda"
        '
        'SearchLookUpEditMoneda
        '
        Me.SearchLookUpEditMoneda.Location = New System.Drawing.Point(275, 149)
        Me.SearchLookUpEditMoneda.Name = "SearchLookUpEditMoneda"
        Me.SearchLookUpEditMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEditMoneda.Properties.View = Me.GridView2
        Me.SearchLookUpEditMoneda.Size = New System.Drawing.Size(274, 20)
        Me.SearchLookUpEditMoneda.TabIndex = 28
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'frmCCFCreaDocAnulado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 285)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmCCFCreaDocAnulado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Documento Anulado"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SearchLookUpEditClase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditSubTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEditMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchLookUpEditSubTipo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEditClase As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchLookUpEditSucursal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rbCreditos As System.Windows.Forms.RadioButton
    Friend WithEvents rbDebitos As System.Windows.Forms.RadioButton
    Friend WithEvents btnCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIDCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMascara As System.Windows.Forms.Label
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchLookUpEditMoneda As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
