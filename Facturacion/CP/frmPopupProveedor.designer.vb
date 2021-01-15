<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupProveedor
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewProveedor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Alia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Contacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIDMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDcondicionPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 12)
        Me.GridControl1.MainView = Me.GridViewProveedor
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(987, 448)
        Me.GridControl1.TabIndex = 27
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProveedor})
        '
        'GridViewProveedor
        '
        Me.GridViewProveedor.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewProveedor.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProveedor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDProveedor, Me.Nombre, Me.Activo, Me.Alia, Me.Direccion, Me.Contacto, Me.Telefono, Me.GridColumnIDMoneda, Me.IDcondicionPago})
        Me.GridViewProveedor.GridControl = Me.GridControl1
        Me.GridViewProveedor.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewProveedor.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Me.Nombre, "{Count = {0}}")})
        Me.GridViewProveedor.Name = "GridViewProveedor"
        Me.GridViewProveedor.OptionsBehavior.Editable = False
        Me.GridViewProveedor.OptionsFind.AlwaysVisible = True
        Me.GridViewProveedor.OptionsFind.SearchInPreview = True
        Me.GridViewProveedor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewProveedor.OptionsView.ShowAutoFilterRow = True
        Me.GridViewProveedor.OptionsView.ShowFooter = True
        Me.GridViewProveedor.OptionsView.ShowGroupPanel = False
        '
        'IDProveedor
        '
        Me.IDProveedor.Caption = "Código"
        Me.IDProveedor.FieldName = "IDProveedor"
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.OptionsColumn.AllowEdit = False
        Me.IDProveedor.Visible = True
        Me.IDProveedor.VisibleIndex = 0
        Me.IDProveedor.Width = 70
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsColumn.AllowEdit = False
        Me.Nombre.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Nombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        Me.Nombre.Width = 201
        '
        'Activo
        '
        Me.Activo.Caption = "Activo"
        Me.Activo.FieldName = "Activo"
        Me.Activo.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.Activo.Name = "Activo"
        Me.Activo.OptionsColumn.AllowEdit = False
        Me.Activo.Visible = True
        Me.Activo.VisibleIndex = 6
        Me.Activo.Width = 91
        '
        'Alia
        '
        Me.Alia.Caption = "Alias"
        Me.Alia.FieldName = "Alias"
        Me.Alia.Name = "Alia"
        Me.Alia.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Alia.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Alia.Visible = True
        Me.Alia.VisibleIndex = 2
        Me.Alia.Width = 191
        '
        'Direccion
        '
        Me.Direccion.Caption = "Direccion"
        Me.Direccion.FieldName = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Visible = True
        Me.Direccion.VisibleIndex = 5
        Me.Direccion.Width = 321
        '
        'Contacto
        '
        Me.Contacto.Caption = "Contacto"
        Me.Contacto.FieldName = "Contacto"
        Me.Contacto.Name = "Contacto"
        Me.Contacto.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Contacto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Contacto.Visible = True
        Me.Contacto.VisibleIndex = 4
        Me.Contacto.Width = 160
        '
        'Telefono
        '
        Me.Telefono.Caption = "Telefono"
        Me.Telefono.FieldName = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = True
        Me.Telefono.VisibleIndex = 3
        Me.Telefono.Width = 76
        '
        'GridColumnIDMoneda
        '
        Me.GridColumnIDMoneda.Caption = "IDMoneda"
        Me.GridColumnIDMoneda.FieldName = "IDMoneda"
        Me.GridColumnIDMoneda.Name = "GridColumnIDMoneda"
        '
        'IDcondicionPago
        '
        Me.IDcondicionPago.Caption = "Plazo"
        Me.IDcondicionPago.FieldName = "IDcondicionPago"
        Me.IDcondicionPago.Name = "IDcondicionPago"
        '
        'frmPopupProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 462)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPopupProveedor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Proveedores"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProveedor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIDMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Contacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDcondicionPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
End Class
