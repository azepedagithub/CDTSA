<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupProducto))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridViewProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Alia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Presentacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Clasif6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bonifica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_ShowBonif = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnVerBonif = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBasico = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ShowBonif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(13, 13)
        Me.GridControl1.MainView = Me.GridViewProducto
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_ShowBonif})
        Me.GridControl1.Size = New System.Drawing.Size(1129, 527)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProducto})
        '
        'GridViewProducto
        '
        Me.GridViewProducto.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDProducto, Me.Descr, Me.Alia, Me.Presentacion, Me.Clasif1, Me.Clasif2, Me.Clasif3, Me.Clasif4, Me.Clasif5, Me.Clasif6, Me.Activo, Me.Bonifica})
        Me.GridViewProducto.GridControl = Me.GridControl1
        Me.GridViewProducto.Name = "GridViewProducto"
        Me.GridViewProducto.OptionsBehavior.Editable = False
        Me.GridViewProducto.OptionsFind.AlwaysVisible = True
        Me.GridViewProducto.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewProducto.OptionsView.ShowAutoFilterRow = True
        '
        'IDProducto
        '
        Me.IDProducto.Caption = "Código"
        Me.IDProducto.FieldName = "IDProducto"
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.Visible = True
        Me.IDProducto.VisibleIndex = 0
        Me.IDProducto.Width = 52
        '
        'Descr
        '
        Me.Descr.Caption = "Descr"
        Me.Descr.FieldName = "Descr"
        Me.Descr.Name = "Descr"
        Me.Descr.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Descr.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descr.Visible = True
        Me.Descr.VisibleIndex = 1
        Me.Descr.Width = 200
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
        Me.Alia.Width = 160
        '
        'Presentacion
        '
        Me.Presentacion.Caption = "Presentacion"
        Me.Presentacion.FieldName = "Presentacion"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Presentacion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Presentacion.Visible = True
        Me.Presentacion.VisibleIndex = 3
        Me.Presentacion.Width = 116
        '
        'Clasif1
        '
        Me.Clasif1.Caption = "Clasif1"
        Me.Clasif1.FieldName = "Clasif1"
        Me.Clasif1.Name = "Clasif1"
        Me.Clasif1.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif1.Visible = True
        Me.Clasif1.VisibleIndex = 4
        Me.Clasif1.Width = 113
        '
        'Clasif2
        '
        Me.Clasif2.Caption = "Clasif2"
        Me.Clasif2.FieldName = "Clasif2"
        Me.Clasif2.Name = "Clasif2"
        Me.Clasif2.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif2.Visible = True
        Me.Clasif2.VisibleIndex = 5
        Me.Clasif2.Width = 106
        '
        'Clasif3
        '
        Me.Clasif3.Caption = "Clasif3"
        Me.Clasif3.FieldName = "Clasif3"
        Me.Clasif3.Name = "Clasif3"
        Me.Clasif3.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif3.Visible = True
        Me.Clasif3.VisibleIndex = 6
        Me.Clasif3.Width = 72
        '
        'Clasif4
        '
        Me.Clasif4.Caption = "Clasif4"
        Me.Clasif4.FieldName = "Clasif4"
        Me.Clasif4.Name = "Clasif4"
        Me.Clasif4.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif4.Width = 61
        '
        'Clasif5
        '
        Me.Clasif5.Caption = "Clasif5"
        Me.Clasif5.FieldName = "Clasif5"
        Me.Clasif5.Name = "Clasif5"
        Me.Clasif5.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif5.Width = 49
        '
        'Clasif6
        '
        Me.Clasif6.Caption = "Clasif6"
        Me.Clasif6.FieldName = "Clasif6"
        Me.Clasif6.Name = "Clasif6"
        Me.Clasif6.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Clasif6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Clasif6.Width = 72
        '
        'Activo
        '
        Me.Activo.Caption = "Activo"
        Me.Activo.FieldName = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = True
        Me.Activo.VisibleIndex = 7
        Me.Activo.Width = 54
        '
        'Bonifica
        '
        Me.Bonifica.Caption = "Bonifica"
        Me.Bonifica.FieldName = "Bonifica"
        Me.Bonifica.Name = "Bonifica"
        Me.Bonifica.Visible = True
        Me.Bonifica.VisibleIndex = 8
        Me.Bonifica.Width = 56
        '
        'btn_ShowBonif
        '
        Me.btn_ShowBonif.AutoHeight = False
        Me.btn_ShowBonif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btn_ShowBonif.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btn_ShowBonif.ContextImage = CType(resources.GetObject("btn_ShowBonif.ContextImage"), System.Drawing.Image)
        Me.btn_ShowBonif.Name = "btn_ShowBonif"
        '
        'btnVerBonif
        '
        Me.btnVerBonif.Image = CType(resources.GetObject("btnVerBonif.Image"), System.Drawing.Image)
        Me.btnVerBonif.Location = New System.Drawing.Point(817, 30)
        Me.btnVerBonif.Name = "btnVerBonif"
        Me.btnVerBonif.Size = New System.Drawing.Size(102, 23)
        Me.btnVerBonif.TabIndex = 1
        Me.btnVerBonif.Text = "Bonificación"
        '
        'cmdBasico
        '
        Me.cmdBasico.Image = CType(resources.GetObject("cmdBasico.Image"), System.Drawing.Image)
        Me.cmdBasico.Location = New System.Drawing.Point(608, 30)
        Me.cmdBasico.Name = "cmdBasico"
        Me.cmdBasico.Size = New System.Drawing.Size(75, 23)
        Me.cmdBasico.TabIndex = 2
        Me.cmdBasico.Text = "Basico"
        '
        'cmdAll
        '
        Me.cmdAll.Image = CType(resources.GetObject("cmdAll.Image"), System.Drawing.Image)
        Me.cmdAll.Location = New System.Drawing.Point(709, 30)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdAll.TabIndex = 3
        Me.cmdAll.Text = "Todas"
        '
        'frmPopupProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 543)
        Me.Controls.Add(Me.cmdAll)
        Me.Controls.Add(Me.cmdBasico)
        Me.Controls.Add(Me.btnVerBonif)
        Me.Controls.Add(Me.GridControl1)
        Me.KeyPreview = True
        Me.Name = "frmPopupProducto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Productos"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ShowBonif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProducto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Clasif6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bonifica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_ShowBonif As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnVerBonif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Presentacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdBasico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAll As DevExpress.XtraEditors.SimpleButton
End Class
