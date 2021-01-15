<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscalasSinMaximo
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
        Me.GridHeader = New DevExpress.XtraGrid.GridControl()
        Me.GridViewHeader = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridHeader
        '
        Me.GridHeader.Location = New System.Drawing.Point(12, 24)
        Me.GridHeader.MainView = Me.GridViewHeader
        Me.GridHeader.Name = "GridHeader"
        Me.GridHeader.Size = New System.Drawing.Size(661, 384)
        Me.GridHeader.TabIndex = 61
        Me.GridHeader.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewHeader})
        '
        'GridViewHeader
        '
        Me.GridViewHeader.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewHeader.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewHeader.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDProveedor, Me.Nombre, Me.IDProducto, Me.Descr})
        Me.GridViewHeader.GridControl = Me.GridHeader
        Me.GridViewHeader.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewHeader.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "{Count = {0}}")})
        Me.GridViewHeader.Name = "GridViewHeader"
        Me.GridViewHeader.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewHeader.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewHeader.OptionsBehavior.Editable = False
        Me.GridViewHeader.OptionsView.ShowAutoFilterRow = True
        Me.GridViewHeader.OptionsView.ShowFooter = True
        Me.GridViewHeader.OptionsView.ShowGroupPanel = False
        '
        'IDProducto
        '
        Me.IDProducto.Caption = "IDProducto"
        Me.IDProducto.FieldName = "IDProducto"
        Me.IDProducto.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.OptionsColumn.AllowEdit = False
        Me.IDProducto.Visible = True
        Me.IDProducto.VisibleIndex = 2
        Me.IDProducto.Width = 83
        '
        'Descr
        '
        Me.Descr.Caption = "Descr"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 3
        Me.Descr.Width = 269
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        Me.Nombre.Width = 210
        '
        'IDProveedor
        '
        Me.IDProveedor.Caption = "IDProveedor"
        Me.IDProveedor.FieldName = "IDProveedor"
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.Visible = True
        Me.IDProveedor.VisibleIndex = 0
        Me.IDProveedor.Width = 81
        '
        'frmEscalasSinMaximo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 420)
        Me.Controls.Add(Me.GridHeader)
        Me.Name = "frmEscalasSinMaximo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escalas sin Maximo"
        CType(Me.GridHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridHeader As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewHeader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
