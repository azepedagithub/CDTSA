<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupBonificacion
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
        Me.IDProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Presentacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Generico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Precio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Publico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Escala1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Escala2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Escala3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Escala4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(7, 6)
        Me.GridControl1.MainView = Me.GridViewDetalle
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1143, 419)
        Me.GridControl1.TabIndex = 28
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetalle})
        '
        'GridViewDetalle
        '
        Me.GridViewDetalle.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewDetalle.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDProveedor, Me.Nombre, Me.IDProducto, Me.Descr, Me.Presentacion, Me.Generico, Me.Precio, Me.Publico, Me.Escala1, Me.Escala2, Me.Escala3, Me.Escala4})
        Me.GridViewDetalle.GridControl = Me.GridControl1
        Me.GridViewDetalle.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewDetalle.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "{Count = {0}}")})
        Me.GridViewDetalle.Name = "GridViewDetalle"
        Me.GridViewDetalle.OptionsFind.AlwaysVisible = True
        Me.GridViewDetalle.OptionsView.ShowAutoFilterRow = True
        Me.GridViewDetalle.OptionsView.ShowFooter = True
        Me.GridViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'IDProveedor
        '
        Me.IDProveedor.Caption = "IDProveedor"
        Me.IDProveedor.FieldName = "IDProveedor"
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.Visible = True
        Me.IDProveedor.VisibleIndex = 0
        Me.IDProveedor.Width = 74
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Nombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        Me.Nombre.Width = 155
        '
        'IDProducto
        '
        Me.IDProducto.Caption = "IDProducto"
        Me.IDProducto.FieldName = "IDProducto"
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.Visible = True
        Me.IDProducto.VisibleIndex = 2
        Me.IDProducto.Width = 61
        '
        'Descr
        '
        Me.Descr.Caption = "Descr"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Descr.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 3
        Me.Descr.Width = 179
        '
        'Presentacion
        '
        Me.Presentacion.Caption = "Presentacion"
        Me.Presentacion.FieldName = "Presentacion"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Presentacion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Presentacion.Visible = True
        Me.Presentacion.VisibleIndex = 4
        Me.Presentacion.Width = 74
        '
        'Generico
        '
        Me.Generico.Caption = "Generico"
        Me.Generico.FieldName = "Generico"
        Me.Generico.Name = "Generico"
        Me.Generico.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Generico.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Generico.Visible = True
        Me.Generico.VisibleIndex = 5
        Me.Generico.Width = 74
        '
        'Precio
        '
        Me.Precio.Caption = "Precio"
        Me.Precio.FieldName = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Visible = True
        Me.Precio.VisibleIndex = 6
        Me.Precio.Width = 74
        '
        'Publico
        '
        Me.Publico.Caption = "Publico"
        Me.Publico.FieldName = "Publico"
        Me.Publico.Name = "Publico"
        Me.Publico.Visible = True
        Me.Publico.VisibleIndex = 7
        Me.Publico.Width = 74
        '
        'Escala1
        '
        Me.Escala1.Caption = "Escala1"
        Me.Escala1.FieldName = "Escala1"
        Me.Escala1.Name = "Escala1"
        Me.Escala1.Visible = True
        Me.Escala1.VisibleIndex = 8
        Me.Escala1.Width = 74
        '
        'Escala2
        '
        Me.Escala2.Caption = "Escala2"
        Me.Escala2.FieldName = "Escala2"
        Me.Escala2.Name = "Escala2"
        Me.Escala2.Visible = True
        Me.Escala2.VisibleIndex = 9
        Me.Escala2.Width = 74
        '
        'Escala3
        '
        Me.Escala3.Caption = "Escala3"
        Me.Escala3.FieldName = "Escala3"
        Me.Escala3.Name = "Escala3"
        Me.Escala3.Visible = True
        Me.Escala3.VisibleIndex = 10
        Me.Escala3.Width = 74
        '
        'Escala4
        '
        Me.Escala4.Caption = "Escala4"
        Me.Escala4.FieldName = "Escala4"
        Me.Escala4.Name = "Escala4"
        Me.Escala4.Visible = True
        Me.Escala4.VisibleIndex = 11
        Me.Escala4.Width = 123
        '
        'frmPopupBonificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 427)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPopupBonificacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Bonificación"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Presentacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Generico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Precio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Publico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Escala1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Escala2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Escala3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Escala4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
