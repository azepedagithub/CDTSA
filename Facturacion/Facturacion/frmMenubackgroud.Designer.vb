<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuFac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuFac))
        Me.Catalogos = New DevExpress.XtraNavBar.NavBarGroup()
        Me.Administracion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.EstadoPedido = New DevExpress.XtraNavBar.NavBarItem()
        Me.TipoEntrega = New DevExpress.XtraNavBar.NavBarItem()
        Me.TipoFactura = New DevExpress.XtraNavBar.NavBarItem()
        Me.Departamentos = New DevExpress.XtraNavBar.NavBarItem()
        Me.Municipios = New DevExpress.XtraNavBar.NavBarItem()
        Me.Zonas = New DevExpress.XtraNavBar.NavBarItem()
        Me.SubZonas = New DevExpress.XtraNavBar.NavBarItem()
        Me.Plazos = New DevExpress.XtraNavBar.NavBarItem()
        Me.Vendedores = New DevExpress.XtraNavBar.NavBarItem()
        Me.NivelesPrecios = New DevExpress.XtraNavBar.NavBarItem()
        Me.Bonificaciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.Promociones = New DevExpress.XtraNavBar.NavBarItem()
        Me.Precios = New DevExpress.XtraNavBar.NavBarItem()
        Me.Consecutivos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.Pedidos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.SuspendLayout()
        '
        'Catalogos
        '
        Me.Catalogos.Caption = "Catalogos"
        Me.Catalogos.Expanded = True
        Me.Catalogos.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.Pedidos), New DevExpress.XtraNavBar.NavBarItemLink(Me.Plazos), New DevExpress.XtraNavBar.NavBarItemLink(Me.Departamentos), New DevExpress.XtraNavBar.NavBarItemLink(Me.Municipios), New DevExpress.XtraNavBar.NavBarItemLink(Me.SubZonas), New DevExpress.XtraNavBar.NavBarItemLink(Me.Zonas), New DevExpress.XtraNavBar.NavBarItemLink(Me.TipoFactura), New DevExpress.XtraNavBar.NavBarItemLink(Me.TipoEntrega), New DevExpress.XtraNavBar.NavBarItemLink(Me.EstadoPedido), New DevExpress.XtraNavBar.NavBarItemLink(Me.TipoEntrega), New DevExpress.XtraNavBar.NavBarItemLink(Me.Departamentos), New DevExpress.XtraNavBar.NavBarItemLink(Me.Vendedores), New DevExpress.XtraNavBar.NavBarItemLink(Me.NivelesPrecios), New DevExpress.XtraNavBar.NavBarItemLink(Me.Consecutivos)})
        Me.Catalogos.LargeImage = CType(resources.GetObject("Catalogos.LargeImage"), System.Drawing.Image)
        Me.Catalogos.Name = "Catalogos"
        '
        'Administracion
        '
        Me.Administracion.Caption = "Administracion "
        Me.Administracion.Expanded = True
        Me.Administracion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.Consecutivos), New DevExpress.XtraNavBar.NavBarItemLink(Me.Precios), New DevExpress.XtraNavBar.NavBarItemLink(Me.Promociones), New DevExpress.XtraNavBar.NavBarItemLink(Me.Bonificaciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem8)})
        Me.Administracion.LargeImage = CType(resources.GetObject("Administracion.LargeImage"), System.Drawing.Image)
        Me.Administracion.Name = "Administracion"
        '
        'EstadoPedido
        '
        Me.EstadoPedido.Caption = "Estado Pedido"
        Me.EstadoPedido.Name = "EstadoPedido"
        '
        'TipoEntrega
        '
        Me.TipoEntrega.Caption = "Tipo Entrega"
        Me.TipoEntrega.Name = "TipoEntrega"
        '
        'TipoFactura
        '
        Me.TipoFactura.Caption = "Tipo Factura"
        Me.TipoFactura.Name = "TipoFactura"
        '
        'Departamentos
        '
        Me.Departamentos.Caption = "Departamentos"
        Me.Departamentos.Name = "Departamentos"
        '
        'Municipios
        '
        Me.Municipios.Caption = "Municipios"
        Me.Municipios.Name = "Municipios"
        '
        'Zonas
        '
        Me.Zonas.Caption = "Zonas"
        Me.Zonas.Name = "Zonas"
        '
        'SubZonas
        '
        Me.SubZonas.Caption = "SubZonas"
        Me.SubZonas.Name = "SubZonas"
        '
        'Plazos
        '
        Me.Plazos.Caption = "Plazos"
        Me.Plazos.Name = "Plazos"
        '
        'Vendedores
        '
        Me.Vendedores.Caption = "Vendedores"
        Me.Vendedores.Name = "Vendedores"
        '
        'NivelesPrecios
        '
        Me.NivelesPrecios.Caption = "Niveles de Precios"
        Me.NivelesPrecios.Name = "NivelesPrecios"
        '
        'Bonificaciones
        '
        Me.Bonificaciones.Caption = "Bonificaciones"
        Me.Bonificaciones.Name = "Bonificaciones"
        '
        'Promociones
        '
        Me.Promociones.Caption = "Promociones"
        Me.Promociones.Name = "Promociones"
        '
        'Precios
        '
        Me.Precios.Caption = "Precios"
        Me.Precios.Name = "Precios"
        '
        'Consecutivos
        '
        Me.Consecutivos.Caption = "Consecutivos"
        Me.Consecutivos.Name = "Consecutivos"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "NavBarItem2"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "NavBarItem3"
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "NavBarItem4"
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'Pedidos
        '
        Me.Pedidos.Caption = "Pedidos"
        Me.Pedidos.Name = "Pedidos"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "NavBarItem6"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "NavBarItem7"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Caption = "NavBarItem8"
        Me.NavBarItem8.Name = "NavBarItem8"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "NavBarGroup1"
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "NavBarGroup2"
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "NavBarGroup3"
        Me.NavBarGroup3.Expanded = True
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'frmMenuFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 587)
        Me.Name = "frmMenuFac"
        Me.Text = "Menu Facturacion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Catalogos As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents EstadoPedido As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents TipoEntrega As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents TipoFactura As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Departamentos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Municipios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Zonas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Administracion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SubZonas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Plazos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Vendedores As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NivelesPrecios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Bonificaciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Promociones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Precios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Consecutivos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Pedidos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
End Class
