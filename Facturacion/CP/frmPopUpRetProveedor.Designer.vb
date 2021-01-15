<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUpRetProveedor
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
        Me.GridViewProveedor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDRetencion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Asignada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Porcentaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoMinimo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Aplicada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdAplicaRetenciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridViewProveedor
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(852, 350)
        Me.GridControl1.TabIndex = 28
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProveedor})
        '
        'GridViewProveedor
        '
        Me.GridViewProveedor.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewProveedor.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProveedor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Asignada, Me.IDRetencion, Me.Descr, Me.Porcentaje, Me.MontoMinimo, Me.Aplicada})
        Me.GridViewProveedor.GridControl = Me.GridControl1
        Me.GridViewProveedor.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewProveedor.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Me.Descr, "{Count = {0}}")})
        Me.GridViewProveedor.Name = "GridViewProveedor"
        Me.GridViewProveedor.OptionsBehavior.Editable = False
        Me.GridViewProveedor.OptionsFind.AlwaysVisible = True
        Me.GridViewProveedor.OptionsFind.SearchInPreview = True
        Me.GridViewProveedor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewProveedor.OptionsSelection.MultiSelect = True
        Me.GridViewProveedor.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridViewProveedor.OptionsView.ShowAutoFilterRow = True
        Me.GridViewProveedor.OptionsView.ShowFooter = True
        Me.GridViewProveedor.OptionsView.ShowGroupPanel = False
        '
        'IDRetencion
        '
        Me.IDRetencion.Caption = "Código"
        Me.IDRetencion.FieldName = "IDRetencion"
        Me.IDRetencion.Name = "IDRetencion"
        Me.IDRetencion.OptionsColumn.AllowEdit = False
        Me.IDRetencion.Visible = True
        Me.IDRetencion.VisibleIndex = 2
        Me.IDRetencion.Width = 63
        '
        'Descr
        '
        Me.Descr.Caption = "Descripción"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.OptionsColumn.AllowEdit = False
        Me.Descr.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Descr.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 3
        Me.Descr.Width = 354
        '
        'Asignada
        '
        Me.Asignada.Caption = "Asignada"
        Me.Asignada.FieldName = "AsignadaProveedor"
        Me.Asignada.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.Asignada.Name = "Asignada"
        Me.Asignada.Visible = True
        Me.Asignada.VisibleIndex = 1
        Me.Asignada.Width = 54
        '
        'Porcentaje
        '
        Me.Porcentaje.Caption = "%"
        Me.Porcentaje.FieldName = "Porcentaje"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Porcentaje.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Porcentaje.Visible = True
        Me.Porcentaje.VisibleIndex = 4
        '
        'MontoMinimo
        '
        Me.MontoMinimo.Caption = "MontoMinimo"
        Me.MontoMinimo.FieldName = "MontoMinimo"
        Me.MontoMinimo.Name = "MontoMinimo"
        Me.MontoMinimo.Visible = True
        Me.MontoMinimo.VisibleIndex = 5
        Me.MontoMinimo.Width = 131
        '
        'Aplicada
        '
        Me.Aplicada.Caption = "Aplicada"
        Me.Aplicada.FieldName = "Aplicada"
        Me.Aplicada.Name = "Aplicada"
        Me.Aplicada.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Aplicada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Aplicada.Visible = True
        Me.Aplicada.VisibleIndex = 6
        Me.Aplicada.Width = 82
        '
        'cmdAplicaRetenciones
        '
        Me.cmdAplicaRetenciones.Location = New System.Drawing.Point(291, 375)
        Me.cmdAplicaRetenciones.Name = "cmdAplicaRetenciones"
        Me.cmdAplicaRetenciones.Size = New System.Drawing.Size(117, 23)
        Me.cmdAplicaRetenciones.TabIndex = 29
        Me.cmdAplicaRetenciones.Text = "Aplica Retenciones "
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(441, 375)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(117, 23)
        Me.cmdSalir.TabIndex = 30
        Me.cmdSalir.Text = "Salir"
        '
        'frmPopUpRetProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 410)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAplicaRetenciones)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPopUpRetProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retenciones del Proveedor"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProveedor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDRetencion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Asignada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Porcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoMinimo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Aplicada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAplicaRetenciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
End Class
