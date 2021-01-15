<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpopupPromociones
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
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PorcDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PorcDescCliEsp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Desde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Hasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BonifRequer = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(0, -1)
        Me.GridControl1.MainView = Me.GridViewDetalle
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(919, 446)
        Me.GridControl1.TabIndex = 31
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetalle})
        '
        'GridViewDetalle
        '
        Me.GridViewDetalle.Appearance.ColumnFilterButton.Options.UseTextOptions = True
        Me.GridViewDetalle.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDProveedor, Me.Nombre, Me.Codigo, Me.Descr, Me.PorcDesc, Me.PorcDescCliEsp, Me.Desde, Me.Hasta, Me.BonifRequer})
        Me.GridViewDetalle.GridControl = Me.GridControl1
        Me.GridViewDetalle.GroupPanelText = "Agrupe una Columna Aqui :"
        Me.GridViewDetalle.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Me.Descr, "{Count = {0}}")})
        Me.GridViewDetalle.Name = "GridViewDetalle"
        Me.GridViewDetalle.OptionsBehavior.ReadOnly = True
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
        Me.IDProveedor.Width = 20
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 0
        Me.Nombre.Width = 154
        '
        'Codigo
        '
        Me.Codigo.Caption = "Código"
        Me.Codigo.FieldName = "IDProducto"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 1
        Me.Codigo.Width = 62
        '
        'Descr
        '
        Me.Descr.Caption = "Descr"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.OptionsColumn.AllowEdit = False
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 2
        Me.Descr.Width = 189
        '
        'PorcDesc
        '
        Me.PorcDesc.AppearanceCell.Options.UseTextOptions = True
        Me.PorcDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PorcDesc.Caption = "% Desc"
        Me.PorcDesc.FieldName = "PorcDesc"
        Me.PorcDesc.Name = "PorcDesc"
        Me.PorcDesc.OptionsColumn.AllowEdit = False
        Me.PorcDesc.Visible = True
        Me.PorcDesc.VisibleIndex = 3
        Me.PorcDesc.Width = 65
        '
        'PorcDescCliEsp
        '
        Me.PorcDescCliEsp.AppearanceCell.Options.UseTextOptions = True
        Me.PorcDescCliEsp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PorcDescCliEsp.Caption = "% Desc Cli Esp"
        Me.PorcDescCliEsp.FieldName = "PorcDescCliEsp"
        Me.PorcDescCliEsp.Name = "PorcDescCliEsp"
        Me.PorcDescCliEsp.Visible = True
        Me.PorcDescCliEsp.VisibleIndex = 4
        Me.PorcDescCliEsp.Width = 86
        '
        'Desde
        '
        Me.Desde.AppearanceCell.Options.UseTextOptions = True
        Me.Desde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Desde.Caption = "Desde"
        Me.Desde.FieldName = "Desde"
        Me.Desde.Name = "Desde"
        Me.Desde.Visible = True
        Me.Desde.VisibleIndex = 5
        Me.Desde.Width = 66
        '
        'Hasta
        '
        Me.Hasta.AppearanceCell.Options.UseTextOptions = True
        Me.Hasta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Hasta.Caption = "Hasta"
        Me.Hasta.FieldName = "Hasta"
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Visible = True
        Me.Hasta.VisibleIndex = 6
        Me.Hasta.Width = 89
        '
        'BonifRequer
        '
        Me.BonifRequer.AppearanceCell.Options.UseTextOptions = True
        Me.BonifRequer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BonifRequer.Caption = "Requiere Bonif"
        Me.BonifRequer.FieldName = "RequiereBonif"
        Me.BonifRequer.Name = "BonifRequer"
        Me.BonifRequer.Visible = True
        Me.BonifRequer.VisibleIndex = 7
        '
        'frmpopupPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 447)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmpopupPromociones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones Descuento por Fechas"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PorcDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PorcDescCliEsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Desde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Hasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BonifRequer As DevExpress.XtraGrid.Columns.GridColumn
End Class
