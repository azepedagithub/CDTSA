<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainCP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainCP))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItemTransacciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemCheques = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemAutorizaciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemGrabDocAnulado = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemReportes = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemMovimientos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemDesglosePagos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemDocumentosporCobrar = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemAnalisisVencimiento = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItemParametros = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(627, 34)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "docxpagar"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(24, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.NavBarControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(247, 546)
        Me.SplitContainerControl1.SplitterPosition = 230
        Me.SplitContainerControl1.TabIndex = 19
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItemTransacciones, Me.NavBarItemReportes, Me.NavBarItemMovimientos, Me.NavBarItemDesglosePagos, Me.NavBarItemDocumentosporCobrar, Me.NavBarItemAnalisisVencimiento, Me.NavBarItem1, Me.NavBarItemParametros, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7, Me.NavBarItem8, Me.NavBarItem9, Me.NavBarItemCheques, Me.NavBarItemAutorizaciones, Me.NavBarItemGrabDocAnulado})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 230
        Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Me.NavBarControl1.Size = New System.Drawing.Size(230, 546)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Cuentas por Pagar"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemTransacciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem9), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemCheques), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemAutorizaciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemGrabDocAnulado), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemReportes), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemMovimientos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemDesglosePagos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemDocumentosporCobrar), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemAnalisisVencimiento), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItemParametros)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.SmallImage = CType(resources.GetObject("NavBarGroup1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemTransacciones
        '
        Me.NavBarItemTransacciones.Caption = "Transacciones"
        Me.NavBarItemTransacciones.Name = "NavBarItemTransacciones"
        Me.NavBarItemTransacciones.SmallImage = CType(resources.GetObject("NavBarItemTransacciones.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem9
        '
        Me.NavBarItem9.Caption = "Recibos de Caja"
        Me.NavBarItem9.Name = "NavBarItem9"
        Me.NavBarItem9.SmallImage = CType(resources.GetObject("NavBarItem9.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemCheques
        '
        Me.NavBarItemCheques.Caption = "Cheques"
        Me.NavBarItemCheques.Name = "NavBarItemCheques"
        Me.NavBarItemCheques.SmallImage = CType(resources.GetObject("NavBarItemCheques.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemAutorizaciones
        '
        Me.NavBarItemAutorizaciones.Caption = "Autorizaciones"
        Me.NavBarItemAutorizaciones.Name = "NavBarItemAutorizaciones"
        Me.NavBarItemAutorizaciones.SmallImage = CType(resources.GetObject("NavBarItemAutorizaciones.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemGrabDocAnulado
        '
        Me.NavBarItemGrabDocAnulado.Caption = "Grabar Doc Anulado"
        Me.NavBarItemGrabDocAnulado.Name = "NavBarItemGrabDocAnulado"
        Me.NavBarItemGrabDocAnulado.SmallImage = CType(resources.GetObject("NavBarItemGrabDocAnulado.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemReportes
        '
        Me.NavBarItemReportes.Caption = "Reportes"
        Me.NavBarItemReportes.Name = "NavBarItemReportes"
        Me.NavBarItemReportes.SmallImage = CType(resources.GetObject("NavBarItemReportes.SmallImage"), System.Drawing.Image)
        '
        'NavBarItemMovimientos
        '
        Me.NavBarItemMovimientos.Caption = "Movimientos del Cliente"
        Me.NavBarItemMovimientos.Name = "NavBarItemMovimientos"
        '
        'NavBarItemDesglosePagos
        '
        Me.NavBarItemDesglosePagos.Caption = "Desglose de Pagos"
        Me.NavBarItemDesglosePagos.Name = "NavBarItemDesglosePagos"
        '
        'NavBarItemDocumentosporCobrar
        '
        Me.NavBarItemDocumentosporCobrar.Caption = "Documentos para Cobrar"
        Me.NavBarItemDocumentosporCobrar.Name = "NavBarItemDocumentosporCobrar"
        '
        'NavBarItemAnalisisVencimiento
        '
        Me.NavBarItemAnalisisVencimiento.Caption = "Analisis de Vencimientos"
        Me.NavBarItemAnalisisVencimiento.Name = "NavBarItemAnalisisVencimiento"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Analisis Vencimiento x Sucursal"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItemParametros
        '
        Me.NavBarItemParametros.Caption = "Parametros"
        Me.NavBarItemParametros.LargeImage = CType(resources.GetObject("NavBarItemParametros.LargeImage"), System.Drawing.Image)
        Me.NavBarItemParametros.Name = "NavBarItemParametros"
        Me.NavBarItemParametros.SmallImage = CType(resources.GetObject("NavBarItemParametros.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Facturacion"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem8)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        Me.NavBarGroup2.SmallImage = CType(resources.GetObject("NavBarGroup2.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Crear Factura"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Crear Pedido"
        Me.NavBarItem3.Name = "NavBarItem3"
        Me.NavBarItem3.SmallImage = CType(resources.GetObject("NavBarItem3.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "Autorizar Pedido"
        Me.NavBarItem4.Name = "NavBarItem4"
        Me.NavBarItem4.SmallImage = CType(resources.GetObject("NavBarItem4.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "Administracion"
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "Bonificaciones"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "Promociones"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Caption = "Precios"
        Me.NavBarItem8.Name = "NavBarItem8"
        '
        'frmMainCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 570)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frmMainCP"
        Me.Text = "frmMainCP"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItemTransacciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem9 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemCheques As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemAutorizaciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemGrabDocAnulado As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemReportes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemMovimientos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemDesglosePagos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemDocumentosporCobrar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemAnalisisVencimiento As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItemParametros As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
End Class
