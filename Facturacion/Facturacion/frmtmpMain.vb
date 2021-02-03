Imports Clases
Public Class frmtmpMain

    Private Sub btnCatCatCliente_Click(sender As Object, e As EventArgs) Handles btnCatCatCliente.Click
        Try
            Dim frm As New frmDetalles
            frm.gsFormDetalleName = "CATEGORIACLIENTE"
            frm.gsCaptionFrm = "Categorias"
            frm.gsTableName = "fafCategoriaCliente"
            frm.gsCodeName = "IDCategoria"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDCategoria"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la información " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnTipoCliente_Click(sender As Object, e As EventArgs) Handles btnTipoCliente.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipos de Cliente"
            frm.gsTableName = "fafTipoCliente"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la información " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEstadoPedido_Click(sender As Object, e As EventArgs) Handles btnEstadoPedido.Click
        Try
            If Not UsuarioTieneAcceso(gsUsuario, "CATESTADOPEDIDO") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Estados de Los Pedidos"
            frm.gsTableName = "fafEstadoPedido"
            frm.gsCodeName = "Estado"
            frm.gbCodeNumeric = False
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "Estado"
            frm.gbCatalogSistemaReadOnly = True
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnTipoEntrega_Click(sender As Object, e As EventArgs) Handles btnTipoEntrega.Click
        Try
            If Not UsuarioTieneAcceso(gsUsuario, "CATTIPOENTREGA") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipos de Entrega a Clientes"
            frm.gsTableName = "fafTipoEntrega"
            frm.gsCodeName = "IDTipoEntrega"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo, ControlPesoKG"
            frm.gbExtrachk = True
            frm.gsExtrachkLableText = "Control Peso KG"
            frm.gsFieldNameExtrachk = "ControlPesoKG"
            frm.gsOrder = "IDTipoEntrega"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnTipoFactura_Click(sender As Object, e As EventArgs) Handles btnTipoFactura.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipo de Factura"
            frm.gsTableName = "fafTipoFactura"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"
            frm.gbCatalogSistemaReadOnly = True
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdDepto_Click(sender As Object, e As EventArgs) Handles cmdDepto.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Departamentos"
            frm.gsTableName = "globalDepto"
            frm.gsCodeName = "IDDepto"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDDepto"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnMunicipio_Click(sender As Object, e As EventArgs) Handles btnMunicipio.Click
        Try
            Dim frm As New frmSubCatalogo
            frm.gsCaptionFrm = "Master Departamento / Municipios"
            frm.gsStoreProcNameMaster = "fafGetMasterMunicipios"
            frm.gsParametersValuesMaster = "-1,-1"
            frm.gsTableNameMaster = "globalDepto"
            frm.gsCodeNameMaster = "IDDepto"
            frm.gbCodeNumericMaster = True
            frm.gsDescrNameMaster = "Descr"
            frm.gsFieldsRestMaster = "Activo"
            frm.gsTableName = "globalMunicipio"
            frm.gsCodeName = "IDMunicipio"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnZona_Click(sender As Object, e As EventArgs) Handles btnZona.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Zonas"
            frm.gsTableName = "globalZona"
            frm.gsOrder = "IDZona"
            frm.gsCodeName = "IDZona"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = " Activo"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSubZonas_Click(sender As Object, e As EventArgs) Handles btnSubZonas.Click
        Try
            Dim frm As New frmSubCatalogo
            frm.gsCaptionFrm = "Master Zona / SubZona"
            frm.gsStoreProcNameMaster = "fafGetMasterSubZonas"
            frm.gsParametersValuesMaster = "-1,-1"
            frm.gsTableNameMaster = "globalZona"
            frm.gsCodeNameMaster = "IDZona"
            frm.gbCodeNumericMaster = True
            frm.gsDescrNameMaster = "Descr"
            frm.gsFieldsRestMaster = "Activo"
            frm.gsTableName = "globalSubZona"
            frm.gsCodeName = "IDSubZona"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frmClientes()
            frm.gsCodeName = "IDCliente"
            frm.gsCodeValue = 2
            frm.gsStoreProcNameGetData = "fafgetClientes"
            frm.gbCodeNumeric = True
            frm.gbEdit = True
            frm.gbAdd = False
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPlazos_Click(sender As Object, e As EventArgs) Handles btnPlazos.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Plazos de Creditos"
            frm.gsTableName = "ccfPlazo"
            frm.gsCodeName = "Plazo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "Plazo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim frm As New frmDetClientes()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles btnVendedor.Click
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Tipo Vendedor"
            frm.gsTableName = "fafTipoVendedor"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdNivel_Click(sender As Object, e As EventArgs) Handles cmdNivel.Click
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Niveles de Precios"
            frm.gsTableName = "fafNivelPrecio"
            frm.gsCodeName = "IDNivel"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo, IDMoneda"
            frm.gsOrder = "IDNivel"

            ' Campo Extra con control extragridedit
            frm.gbExtragridExiste = True
            frm.gbExtragridCodeNumeric = True
            frm.gsExtragridCodeName = "IDMoneda"
            frm.gsExtragridDescrName = "Moneda"
            frm.gsExtragridFieldsRest = "Descr"
            frm.gsExtragridFiltro = "Activo= 1"
            frm.gsExtragridLableText = "Moneda"
            frm.gsExtragridTableName = "globalMoneda"


            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim frm As New frmDetalles
            frm.gsFormDetalleName = "VENDEDOR"
            frm.gsCaptionFrm = "Vendedores"
            frm.gsTableName = "fafVendedor"
            frm.gsCodeName = "IDVendedor"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Nombre"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDVendedor"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cManager As New Clases.ClassManager
            Dim td As New DataTable
            Dim sParameters As String

            ' aqui va el usuario tiene acceso
            If Not UsuarioTieneAcceso(gsUsuario, "CREARPEDIDO") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros de Facturación en el Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            sParameters = "'" & gsUsuario & "', " & gsSucursal
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)
            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If td.Rows.Count > 0 Then
                gsSucursal = td.Rows(0)("IDBodega").ToString()
                Dim frm As New frmPedido()
                frm.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBonif_Click(sender As Object, e As EventArgs) Handles btnBonif.Click
        Try
            Dim frm As New frmBonificaciones
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        Try
            Dim frm As New frmPrecios
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAutorizaPedido_Click(sender As Object, e As EventArgs) Handles btnAutorizaPedido.Click
        Try
            Dim frm As New frmAutorizaPedido()
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Try
            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros del Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim td As New DataTable
            Dim lsCodigoConsecMask As String
            Dim cManager As New Clases.ClassManager
            Dim sParameters As String = "'" & gsUsuario & "', 1"
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)

            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            gsSucursal = td.Rows(0)("IDBodega").ToString()
            lsCodigoConsecMask = td.Rows(0)("CodigoConsecMask").ToString()
            Dim frm As New frmFactura()
            If (frm IsNot Nothing) Then
                frm.gsConsecMask = lsCodigoConsecMask
                frm.ShowDialog()
                frm.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsecMask_Click(sender As Object, e As EventArgs) Handles btnConsecMask.Click
        Try
            Dim frm As New frmDetalles
            frm.gsFormDetalleName = "CONSECUTIVOMASK"
            frm.gsCaptionFrm = "Consecutivos"
            frm.gsTableName = "globalConsecMask"
            frm.gsCodeName = "Codigo"
            frm.gbCodeNumeric = False
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Consecutivo, Mascara,Activo"
            frm.gsOrder = "Codigo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            frmParametrosFA.Show()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdPromociones_Click(sender As Object, e As EventArgs) Handles cmdPromociones.Click
        Try
            Dim frm As New frmPromociones
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim frm As New frmRemision
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros del Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim td As New DataTable
            Dim lsCodigoConsecMask As String
            Dim cManager As New Clases.ClassManager
            Dim sParameters As String = "'" & gsUsuario & "', 1"
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)

            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            gsSucursal = td.Rows(0)("IDBodega").ToString()
            lsCodigoConsecMask = td.Rows(0)("consecMaskDevolucion").ToString()
            Dim frm As New frmDevolucion()
            If (frm IsNot Nothing) Then
                frm.giIDFactura = 41
                frm.gsConsecMask = lsCodigoConsecMask
                frm.ShowDialog()
                frm.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim frm As New frmReporteIngresos
            frm.gbRINew = True
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim frm As New frmCCFAplicaCreditos()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdDocumentosCC_Click(sender As Object, e As EventArgs) Handles cmdDocumentosCC.Click
        Try
            Dim frm As New frmCPDocumentos()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnConsultaDocs_Click(sender As Object, e As EventArgs) Handles btnConsultaDocs.Click
        Try
            Dim frm As New frmCCFConsultaDocs()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemTransacciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemTransacciones.LinkClicked
        Try
            Dim frm As New frmCCFConsultaDocs()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemMovimientos.LinkClicked
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptMovimientos
            frm.gsNombreReporte = "Reporte de Movimientos del Cliente"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemDesglosePagos.LinkClicked
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptDesglosePagos
            frm.gsNombreReporte = "Reporte Desglose de Pagos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItem4_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemDocumentosporCobrar.LinkClicked
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptDocumentosPorCobrar
            frm.gsNombreReporte = "Reporte Documentos por Cobrar"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemAnalisisVencimiento.LinkClicked
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptAnalisisVencimiento
            frm.gsNombreReporte = "Reporte Analisis de Vencimientos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnZonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptAnalisisVencimientoSucursal
            frm.gsNombreReporte = "Reporte Analisis de Vencimientos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemParametros_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemParametros.LinkClicked
        Try
            Dim frm As New frmCCFParametros()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Try
            frmRecibos.Show()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmdConsulta_Click(sender As Object, e As EventArgs) Handles cmdConsulta.Click
        Try
            Dim frm As New frmConsultaFacturas()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btngrupoVend_Click(sender As Object, e As EventArgs) Handles btngrupoVend.Click
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Grupo Vendedor"
            frm.gsTableName = "fafGrupoVendedor"
            frm.gsCodeName = "IDGrupo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDGrupo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEvalCliente_Click(sender As Object, e As EventArgs) Handles btnEvalCliente.Click
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Evaluacion de Cliente"
            frm.gsTableName = "fafEvaluacionCliente"
            frm.gsCodeName = "IDEvaluacion"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDEvaluacion"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDescuentos_Click(sender As Object, e As EventArgs) Handles btnDescuentos.Click
        Try
            Dim frm As New frmDescuentos()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        Try
            Dim frm As New frmCCFConsultaRC()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub NavBarItemCheques_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemCheques.LinkClicked
        Try
            Dim frm As New frmCCFConsultaChequesPos()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemAutorizaciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemAutorizaciones.LinkClicked
        Try
            Dim frm As New frmCCFConsultaAutorizacion()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemGrabDocAnulado_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemGrabDocAnulado.LinkClicked
        Try
            Dim frm As New frmCCFCreaDocAnulado()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles cmdDocCP.Click
        Try

            Dim a As String = ""
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdCosultaDev_Click(sender As Object, e As EventArgs) Handles cmdCosultaDev.Click
        Try
            Dim frm As New frmConsultaDevoluciones()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuTipoCliente()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipos de Cliente"
            frm.gsTableName = "fafTipoCliente"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la información " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub MenuEstadoPedido()
        Try
            If Not UsuarioTieneAcceso(gsUsuario, "CATESTADOPEDIDO") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Estados de Los Pedidos"
            frm.gsTableName = "fafEstadoPedido"
            frm.gsCodeName = "Estado"
            frm.gbCodeNumeric = False
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "Estado"
            frm.gbCatalogSistemaReadOnly = True
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuTipoEntrega()
        Try
            If Not UsuarioTieneAcceso(gsUsuario, "CATTIPOENTREGA") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipos de Entrega a Clientes"
            frm.gsTableName = "fafTipoEntrega"
            frm.gsCodeName = "IDTipoEntrega"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo, ControlPesoKG"
            frm.gbExtrachk = True
            frm.gsExtrachkLableText = "Control Peso KG"
            frm.gsFieldNameExtrachk = "ControlPesoKG"
            frm.gsOrder = "IDTipoEntrega"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuTipoFactura()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Tipo de Factura"
            frm.gsTableName = "fafTipoFactura"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"
            frm.gbCatalogSistemaReadOnly = True
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Public Sub MenuDepartamento()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Departamentos"
            frm.gsTableName = "globalDepto"
            frm.gsCodeName = "IDDepto"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDDepto"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub MenuMunicipio()
        Try
            Dim frm As New frmSubCatalogo
            frm.gsCaptionFrm = "Master Departamento / Municipios"
            frm.gsStoreProcNameMaster = "fafGetMasterMunicipios"
            frm.gsParametersValuesMaster = "-1,-1"
            frm.gsTableNameMaster = "globalDepto"
            frm.gsCodeNameMaster = "IDDepto"
            frm.gbCodeNumericMaster = True
            frm.gsDescrNameMaster = "Descr"
            frm.gsFieldsRestMaster = "Activo"
            frm.gsTableName = "globalMunicipio"
            frm.gsCodeName = "IDMunicipio"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub MenuZona()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Zonas"
            frm.gsTableName = "globalZona"
            frm.gsOrder = "IDZona"
            frm.gsCodeName = "IDZona"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = " Activo"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuSubZona()
        Try
            Dim frm As New frmSubCatalogo
            frm.gsCaptionFrm = "Master Zona / SubZona"
            frm.gsStoreProcNameMaster = "fafGetMasterSubZonas"
            frm.gsParametersValuesMaster = "-1,-1"
            frm.gsTableNameMaster = "globalZona"
            frm.gsCodeNameMaster = "IDZona"
            frm.gbCodeNumericMaster = True
            frm.gsDescrNameMaster = "Descr"
            frm.gsFieldsRestMaster = "Activo"
            frm.gsTableName = "globalSubZona"
            frm.gsCodeName = "IDSubZona"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuPlazos()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Plazos de Creditos"
            frm.gsTableName = "ccfPlazo"
            frm.gsCodeName = "Plazo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "Plazo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuClientes()
        Try
            Dim frm As New frmDetClientes
            'frm.gsFormDetalleName = "CLIENTE"
            'frm.gsCaptionFrm = "Clientes"
            'frm.gsTableName = "ccfClientes"
            'frm.gsCodeName = "IDCliente"
            'frm.gbCodeNumeric = True
            'frm.gsDescrName = "Nombre"
            'frm.gsFieldsRest = "Activo"
            'frm.gsOrder = "IDCliente"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub MenuTipoVendedor()
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Tipo Vendedor"
            frm.gsTableName = "fafTipoVendedor"
            frm.gsCodeName = "IDTipo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDTipo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub menuNivelPrecio()
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Niveles de Precios"
            frm.gsTableName = "fafNivelPrecio"
            frm.gsCodeName = "IDNivel"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo, IDMoneda"
            frm.gsOrder = "IDNivel"

            ' Campo Extra con control extragridedit
            frm.gbExtragridExiste = True
            frm.gbExtragridCodeNumeric = True
            frm.gsExtragridCodeName = "IDMoneda"
            frm.gsExtragridDescrName = "Moneda"
            frm.gsExtragridFieldsRest = "Descr"
            frm.gsExtragridFiltro = "Activo= 1"
            frm.gsExtragridLableText = "Moneda"
            frm.gsExtragridTableName = "globalMoneda"


            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub MenuVendedores()
        Try
            Dim frm As New frmDetalles
            frm.gsFormDetalleName = "VENDEDOR"
            frm.gsCaptionFrm = "Vendedores"
            frm.gsTableName = "fafVendedor"
            frm.gsCodeName = "IDVendedor"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Nombre"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDVendedor"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub MenuCrearPedido()
        Try
            Dim cManager As New Clases.ClassManager
            Dim td As New DataTable
            Dim sParameters As String

            ' aqui va el usuario tiene acceso
            If Not UsuarioTieneAcceso(gsUsuario, "CREARPEDIDO") Then
                MessageBox.Show("Ud. No tiene acceso a esta opción... repórtelo al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros de Facturación en el Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            sParameters = "'" & gsUsuario & "', " & gsSucursal
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)
            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If td.Rows.Count > 0 Then
                gsSucursal = td.Rows(0)("IDBodega").ToString()
                Dim frm As New frmPedido()
                frm.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuBonificaciones()
        Try
            Dim frm As New frmBonificaciones
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub MenuListaPrecios()
        Try
            Dim frm As New frmPrecios
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub MenuAutorizarPedido()
        Try
            Dim frm As New frmAutorizaPedido()
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub MenuFactura()
        Try
            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros del Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim td As New DataTable
            Dim lsCodigoConsecMask As String
            Dim cManager As New Clases.ClassManager
            Dim sParameters As String = "'" & gsUsuario & "', 1"
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)

            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            gsSucursal = td.Rows(0)("IDBodega").ToString()
            lsCodigoConsecMask = td.Rows(0)("CodigoConsecMask").ToString()
            Dim frm As New frmFactura()
            If (frm IsNot Nothing) Then
                frm.gsConsecMask = lsCodigoConsecMask
                frm.ShowDialog()
                frm.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuConsecutivMask()
        Try
            Dim frm As New frmDetalles
            frm.gsFormDetalleName = "CONSECUTIVOMASK"
            frm.gsCaptionFrm = "Consecutivos"
            frm.gsTableName = "globalConsecMask"
            frm.gsCodeName = "Codigo"
            frm.gbCodeNumeric = False
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Consecutivo, Mascara,Activo"
            frm.gsOrder = "Codigo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuPromociones()
        Try
            Dim frm As New frmPromociones
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuDevolucion()
        Try
            If Not CargaParametros() Then
                MessageBox.Show("No se han definido los parámetros del Sistema... LLame a su administrador de IT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim td As New DataTable
            Dim lsCodigoConsecMask As String
            Dim cManager As New Clases.ClassManager
            Dim sParameters As String = "'" & gsUsuario & "', 1"
            td = cManager.ExecSPgetData("invgetBodegasFromUsuario", sParameters)

            If td.Rows.Count > 1 Then
                MessageBox.Show("El usuario tiene asignada más de una bodega para Facturar... debe tener una sola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If td.Rows.Count <= 0 Then
                MessageBox.Show("El usuario debe tener asignada una bodega para Facturar... favor llamar al administrador de Sistemas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            gsSucursal = td.Rows(0)("IDBodega").ToString()
            lsCodigoConsecMask = td.Rows(0)("consecMaskDevolucion").ToString()
            Dim frm As New frmDevolucion()
            If (frm IsNot Nothing) Then
                frm.giIDFactura = 41
                frm.gsConsecMask = lsCodigoConsecMask
                frm.ShowDialog()
                frm.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Public Sub MenuConsultaFactura()
        Try
            Dim frm As New frmConsultaFacturas()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuGrupoVendedor()
        Try
            Dim frm As New frmCatalogos
            frm.gsCaptionFrm = "Grupo Vendedor"
            frm.gsTableName = "fafGrupoVendedor"
            frm.gsCodeName = "IDGrupo"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDGrupo"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub MenuEvalCliente()
        Try
            Dim frm As New frmCatalogos()
            frm.gsCaptionFrm = "Evaluacion de Cliente"
            frm.gsTableName = "fafEvaluacionCliente"
            frm.gsCodeName = "IDEvaluacion"
            frm.gbCodeNumeric = True
            frm.gsDescrName = "Descr"
            frm.gsFieldsRest = "Activo"
            frm.gsOrder = "IDEvaluacion"

            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuTablaDesc()
        Try
            Dim frm As New frmDescuentos()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub MenuParametrosFactura()
        Try
            frmParametrosFA.Show()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub MenuCatCliente()
        Try
            Dim frm As New frmDetClientes()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la información " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub MenuConsultaDev()
        Try
            Dim frm As New frmConsultaDevoluciones()
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class