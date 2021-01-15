Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraReports
Public Class frmCPDocumento
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gbEdit As Boolean = False
    Public gbAdd As Boolean = False
    Public giIDDocumento As Integer
    Public gsTipoDocumento As String

    Dim gIDPlazo As Int16
    Dim gsMascara As String
    Dim gsCodigoConsecMask As String
    Dim gdTipoCambio As Decimal
    Dim gsTipoCambio As String
    Dim gsConsecutivoAnteriorD As String
    Dim gsConsecutivoDigitadoD As String
    Dim gsConsecutivoAnteriorC As String
    Dim gsConsecutivoDigitadoC As String
    Dim gbUsaCuentaBancaria As Boolean = False
    Dim giIDMonedaCuentaBancaria As Integer = 0
    Dim gbUltimoNumero As Boolean = False
    Dim gsIDClaseDebito As String = ""
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        CallPopUpProveedor()
    End Sub
    Private Sub CalculaFechaVencimiento()
        Me.DateEditVencimiento.EditValue = DateAdd(DateInterval.Day, CDbl(Me.SearchLookUpEditPlazo.EditValue), Me.DateEditFecha.EditValue)
        Me.DateEditVencimiento.Refresh()
    End Sub
    Private Sub CallPopUpProveedor()
        Try
            'If Me.SearchLookUpEditSucursal.Text = "" Then
            '    MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If


            Dim frm As New frmPopupProveedor()

            frm.ShowDialog()
            If frm.gsIDProveedor <> "" Then
                Me.txtIDProveedor.EditValue = frm.gsIDProveedor
                Me.txtNombre.EditValue = frm.gsNombre
                Me.txtAlias.EditValue = frm.gsAlias
                Me.txtContacto.EditValue = frm.gsContacto
                gIDPlazo = CInt(frm.gsIDCondicionPago)
                Me.SearchLookUpEditPlazo.EditValue = gIDPlazo
                CalculaFechaVencimiento()
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCPDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gsTipoCambio = getTipoCambio()
            If gsTipoCambio = "" Then
                MessageBox.Show("No se ha definido un Tipo de Cambio... favor indicar al Administrador, el tipo de Cambio de CNT no está definido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            If Not CargaParametrosCPP() Then
                MessageBox.Show("Ha ocurrido un error al cargar los Parametros de Cuentas por Pagar...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            CargagridLookUpsFromTables()

            If gbEdit = True Then
                gsTipoDocumento = gsTipoDocumento
                giIDDocumento = giIDDocumento

            End If

            DateEditFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            DateEditFecha.Properties.Mask.EditMask = "dd/MM/yyyy"
            DateEditFecha.Properties.Mask.UseMaskAsDisplayFormat = True
            DateEditFechaC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            DateEditFechaC.Properties.Mask.EditMask = "dd/MM/yyyy"
            DateEditFechaC.Properties.Mask.UseMaskAsDisplayFormat = True
            DateEditVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            DateEditVencimiento.Properties.Mask.EditMask = "dd/MM/yyyy"
            DateEditVencimiento.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.DateEditFecha.EditValue = Now
            Me.DateEditFechaC.EditValue = Now
            AlignControls()
            If gbAdd Then
                gIDPlazo = 0
                seteaControlsNewRecord()
            End If
            If gbEdit Then
                EnableControlsReadOnly(True)
                CargaControlsFromOneRegister()

            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los datos..." & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Sub AlignControls()
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIDC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    End Sub

    Sub EnableControlsToEdit(bAprobado As Boolean, bExterno As Boolean, bAnulado As Boolean)
        If bAprobado Or bExterno Or bAnulado Then
            Me.MemoEditConcepto.ReadOnly = True
            Me.MemoEditConceptoC.ReadOnly = True
            Me.txtMonto.ReadOnly = True
            Me.txtMontoC.ReadOnly = True
            Me.DateEditFecha.ReadOnly = True
            Me.DateEditFechaC.ReadOnly = True
            'Me.txtDocumento.ReadOnly = True
            'Me.txtDocumentoC.ReadOnly = True
            Me.MemoEditConcepto.ReadOnly = True
            Me.MemoEditConceptoC.ReadOnly = True
        Else
            Me.MemoEditConcepto.ReadOnly = False
            Me.MemoEditConceptoC.ReadOnly = False
            Me.txtMonto.ReadOnly = False
            Me.txtMontoC.ReadOnly = False
            Me.DateEditFecha.ReadOnly = False
            Me.DateEditFechaC.ReadOnly = False
            'Me.txtDocumento.ReadOnly = False
            'Me.txtDocumentoC.ReadOnly = False
            Me.MemoEditConcepto.ReadOnly = False
            Me.MemoEditConceptoC.ReadOnly = False
        End If

    End Sub

    Sub EnableControlsReadOnly(bReadonly As Boolean)
        Me.txtAsiento.ReadOnly = bReadonly
        Me.txtAsientoC.ReadOnly = bReadonly
        Me.txtConceptoSistema.ReadOnly = True
        Me.txtConceptoSistemaC.ReadOnly = True
        Me.txtID.ReadOnly = True
        Me.txtIDC.ReadOnly = True
        Me.txtIDProveedor.ReadOnly = bReadonly
        Me.txtNombre.ReadOnly = bReadonly
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldoC.ReadOnly = True
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuarioC.ReadOnly = True

        Me.SearchLookUpEditClase.ReadOnly = bReadonly
        Me.SearchLookUpEditClaseD.ReadOnly = bReadonly
        Me.SearchLookUpEditMoneda.ReadOnly = bReadonly
        Me.SearchLookUpEditMonedaC.ReadOnly = bReadonly

        Me.SearchLookUpEditSubTipo.ReadOnly = bReadonly
        Me.SearchLookUpEditSubTipoD.ReadOnly = bReadonly
        Me.SearchLookUpEditPlazo.ReadOnly = bReadonly
        Me.txtContacto.ReadOnly = bReadonly
        Me.DateEditFecha.ReadOnly = bReadonly
        Me.DateEditFechaC.ReadOnly = bReadonly
        Me.DateEditVencimiento.ReadOnly = bReadonly
        Me.CheckEditAprobado.ReadOnly = True
        Me.CheckEditAprobadoC.ReadOnly = True
        Me.chkAnulado.ReadOnly = True
        Me.chkAnuladoC.ReadOnly = True
        Me.CheckEditOrigenExterno.ReadOnly = True
        Me.CheckEditOrigenExternoC.ReadOnly = True
        If gbAdd Then
            Me.rbDebitos.Enabled = True
            Me.rbCreditos.Enabled = True
        Else
            Me.rbDebitos.Enabled = False
            Me.rbCreditos.Enabled = False
        End If
        Me.txtMonto.ReadOnly = bReadonly
        Me.txtMontoC.ReadOnly = bReadonly
        Me.MemoEditConcepto.ReadOnly = bReadonly
        Me.MemoEditConceptoC.ReadOnly = bReadonly
        Me.txtSubTotal.ReadOnly = bReadonly
        Me.txtDescuento.ReadOnly = bReadonly
        Me.txtSubTotalDescontado.ReadOnly = bReadonly
        Me.txtIVA.ReadOnly = bReadonly
        Me.txtConsumo.ReadOnly = bReadonly
        Me.txtFlete.ReadOnly = bReadonly
        Me.txtTotal.ReadOnly = bReadonly

    End Sub


    Sub seteaControlsNewRecord()

        Me.txtAsiento.Text = ""
        Me.txtAsiento.ReadOnly = True
        Me.txtAsientoC.Text = ""
        Me.txtAsientoC.ReadOnly = True
        Me.MemoEditConcepto.Text = ""
        Me.MemoEditConceptoC.Text = ""
        Me.txtConceptoSistema.Text = ""
        Me.txtConceptoSistemaC.Text = ""
        Me.txtDocumento.Text = ""
        Me.txtDocumentoC.Text = ""
            txtDocumento.ReadOnly = False
            txtDocumentoC.ReadOnly = False
        Me.txtID.Text = ""
        txtID.ReadOnly = True
        Me.txtIDC.Text = ""
        Me.txtIDC.ReadOnly = True
        Me.txtID.ReadOnly = True

        Me.txtIDProveedor.Text = ""
        Me.txtNombre.Text = ""
        Me.txtNombre.ReadOnly = True
        Me.txtSaldo.Text = ""
        Me.txtSaldoC.Text = ""
        Me.txtUsuario.Text = ""
        Me.txtUsuarioC.Text = ""
        Me.SearchLookUpEditClase.Text = ""
        Me.SearchLookUpEditClaseD.Text = ""
        Me.SearchLookUpEditSubTipo.Text = ""
        Me.SearchLookUpEditSubTipoD.Text = ""
 
        Me.SearchLookUpEditPlazo.Text = ""
        Me.DateEditFecha.EditValue = Now
        Me.DateEditFechaC.EditValue = Now
        Me.DateEditVencimiento.ReadOnly = True
        Me.CheckEditAprobado.EditValue = False
        Me.CheckEditAprobadoC.EditValue = False
        Me.CheckEditAprobado.ReadOnly = True
        Me.CheckEditAprobadoC.ReadOnly = True
        Me.chkAnulado.EditValue = False
        Me.chkAnuladoC.EditValue = False
        Me.chkAnulado.ReadOnly = True
        Me.chkAnuladoC.ReadOnly = True
        Me.CheckEditOrigenExterno.EditValue = False
        Me.CheckEditOrigenExternoC.EditValue = False
        Me.CheckEditOrigenExterno.ReadOnly = True
        Me.CheckEditOrigenExternoC.ReadOnly = True
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldoC.ReadOnly = True
        Me.txtMonto.Text = 0
        Me.txtMontoC.Text = 0
        Me.rbDebitos.Enabled = True
        Me.rbDebitos.Checked = True
        Me.rbCreditos.Enabled = True
        Me.txtSubTotal.EditValue = 0
        Me.txtDescuento.EditValue = 0
        Me.txtSubTotalDescontado.EditValue = 0
        Me.txtIVA.EditValue = 0
        txtConsumo.EditValue = 0
        txtFlete.EditValue = 0
        txtTotal.EditValue = 0
    End Sub

    Sub CargaControlsFromOneRegister()
        Dim spParameters As String
        spParameters = "'" & gsTipoDocumento & "'," & giIDDocumento.ToString()
        tableData = cManager.ExecSPgetData("cppGetDocumento", spParameters)

        Me.txtIDProveedor.EditValue = tableData.Rows(0).Item("IDProveedor").ToString()
        Me.txtIDProveedor.Enabled = False
        Me.txtNombre.EditValue = tableData.Rows(0).Item("Nombre").ToString()
        Me.SearchLookUpEditPlazo.EditValue = CInt(tableData.Rows(0).Item("Plazo"))

        If gsTipoDocumento = "D" Then
            Me.rbCreditos.Checked = False
            Me.rbCreditos.Enabled = False
            Me.rbDebitos.Enabled = True
            Me.rbDebitos.Checked = True
            XtraTabDocumentos.TabPages(0).PageVisible = True
            XtraTabDocumentos.TabPages(1).PageVisible = False
            Me.txtID.EditValue = tableData.Rows(0).Item("IDDebito").ToString()
            Me.SearchLookUpEditClaseD.EditValue = (tableData.Rows(0).Item("IDClase")).ToString()
            Me.SearchLookUpEditSubTipoD.EditValue = CInt(tableData.Rows(0).Item("IDSubTipo"))
            Me.SearchLookUpEditMoneda.EditValue = CInt(tableData.Rows(0).Item("IDMoneda"))
            Me.txtDocumento.EditValue = tableData.Rows(0).Item("Documento").ToString()
            Me.txtMonto.EditValue = tableData.Rows(0).Item("MontoOriginal")

            Me.txtSaldo.EditValue = tableData.Rows(0).Item("SaldoActual")
            Me.DateEditFecha.EditValue = CDate(tableData.Rows(0).Item("Fecha"))
            Me.DateEditVencimiento.EditValue = CDate(tableData.Rows(0).Item("Vencimiento"))
            If Not IsDBNull(tableData.Rows(0).Item("ConceptoUsuario")) Then
                Me.MemoEditConcepto.EditValue = tableData.Rows(0).Item("ConceptoUsuario").ToString()
            End If
            If Not IsDBNull(tableData.Rows(0).Item("ConceptoSistema")) Then
                Me.txtConceptoSistema.EditValue = tableData.Rows(0).Item("ConceptoSistema").ToString()
            End If

            Me.txtUsuario.EditValue = tableData.Rows(0).Item("Usuario").ToString()
            Me.txtAsiento.EditValue = tableData.Rows(0).Item("Asiento").ToString()
            Me.chkAnulado.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("Anulado"))
            Me.CheckEditAprobado.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("flgAprobado"))
            Me.CheckEditOrigenExterno.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("flgOrigenExterno"))
            EnableControlsToEdit(Convert.ToBoolean(tableData.Rows(0).Item("flgAprobado")), _
                                 Convert.ToBoolean(tableData.Rows(0).Item("flgOrigenExterno")), _
                                 Convert.ToBoolean(tableData.Rows(0).Item("Anulado")))
            'Dim td As New DataTable
            'Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipoD.EditValue.ToString())
            'If sCodigoMask <> "" Then
            '    sCodigoMask = "'" & sCodigoMask & "'"
            '    td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
            '    gsMascara = td.Rows(0)(0)
            'Else
            '    gsMascara = ""
            'End If
        Else
            Me.rbCreditos.Enabled = True
            Me.rbCreditos.Checked = True
            Me.rbDebitos.Checked = False
            Me.rbDebitos.Enabled = False
            XtraTabDocumentos.TabPages(0).PageVisible = False
            XtraTabDocumentos.TabPages(1).PageVisible = True
            Me.txtIDC.EditValue = tableData.Rows(0).Item("IDCredito").ToString()
            Me.SearchLookUpEditClase.EditValue = (tableData.Rows(0).Item("IDClase")).ToString()
            Me.SearchLookUpEditSubTipo.EditValue = CInt(tableData.Rows(0).Item("IDSubTipo"))
            Me.SearchLookUpEditMonedaC.EditValue = CInt(tableData.Rows(0).Item("IDMoneda"))
            Me.txtDocumentoC.EditValue = tableData.Rows(0).Item("Documento").ToString()
            Me.txtMontoC.EditValue = tableData.Rows(0).Item("MontoOriginal")
            Me.txtSaldoC.EditValue = tableData.Rows(0).Item("SaldoActual")
            Me.DateEditFechaC.EditValue = CDate(tableData.Rows(0).Item("Fecha"))
            Me.txtSubTotal.EditValue = tableData.Rows(0).Item("SubTotal")
            Me.txtDescuento.EditValue = tableData.Rows(0).Item("Descuento")
            Me.txtSubTotalDescontado.EditValue = tableData.Rows(0).Item("SubTotalSinDescuento")
            Me.txtIVA.EditValue = tableData.Rows(0).Item("ImpuestoIVA")
            Me.txtConsumo.EditValue = tableData.Rows(0).Item("ImpuestoConsumo")
            Me.txtFlete.EditValue = tableData.Rows(0).Item("Flete")
            Me.txtTotal.EditValue = tableData.Rows(0).Item("Total")
            If Not IsDBNull(tableData.Rows(0).Item("ConceptoUsuario")) Then
                Me.MemoEditConceptoC.EditValue = tableData.Rows(0).Item("ConceptoUsuario").ToString()
            End If
            If Not IsDBNull(tableData.Rows(0).Item("ConceptoSistema")) Then
                Me.txtConceptoSistemaC.EditValue = tableData.Rows(0).Item("ConceptoSistema").ToString()
            End If
            Me.txtUsuarioC.EditValue = tableData.Rows(0).Item("Usuario").ToString()
            Me.txtAsientoC.EditValue = tableData.Rows(0).Item("Asiento").ToString()
            Me.chkAnuladoC.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("Anulado"))
            Me.CheckEditAprobadoC.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("flgAprobado"))
            Me.CheckEditOrigenExternoC.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("flgOrigenExterno"))

            EnableControlsToEdit(Convert.ToBoolean(tableData.Rows(0).Item("flgAprobado")), _
                                 Convert.ToBoolean(tableData.Rows(0).Item("flgOrigenExterno")), _
                                 Convert.ToBoolean(tableData.Rows(0).Item("Anulado")))
            'Dim td As New DataTable
            'Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipo.EditValue.ToString())
            'If sCodigoMask <> "" Then
            '    sCodigoMask = "'" & sCodigoMask & "'"
            '    td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
            '    gsMascara = td.Rows(0)(0)
            'Else
            '    gsMascara = ""
            'End If

        End If

    End Sub


    Private Function getNextConsecutivoCheque(spIDCuentaBanco As String) As Integer
        Dim td As New DataTable
        Dim iCosecutivoCheque As Integer = 0
        Dim sWhere As String = "IDCuentaBanco=" & spIDCuentaBanco
        Dim cManager As New Clases.ClassManager
        td = cManager.GetDataTable("cbCuentaBancaria", "ConsecCheque", sWhere, "IDCuentaBanco")
        If td.Rows.Count > 0 Then
            iCosecutivoCheque = td.Rows(0)(0)
        End If


        Return iCosecutivoCheque
    End Function

    'Private Function getCodigoConsecMaskSubTipo(spIDSubTipo As String) As String
    '    Dim td As New DataTable
    '    Dim sCodigoMask As String = ""
    '    Dim cManager As New Clases.ClassManager
    '    td = cManager.ExecSPgetData("ccfgetSubTipo", spIDSubTipo)
    '    If td.Rows.Count > 0 Then
    '        sCodigoMask = td.Rows(0)("CodigoConsecMask")
    '    End If
    '    Return sCodigoMask
    'End Function

    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "cppClaseDocumento", "IDClase, Descr, UltimoNumero", "Activo=1 and TipoDocumento='C'", "Orden", "IDClase", "IDClase")
        SearchLookUpEditClase.Text = ""
        CargagridSearchLookUp(Me.SearchLookUpEditClaseD, "cppClaseDocumento", "IDClase, Descr, UsaCuentaBancaria, UltimoNumero", "Activo=1 and TipoDocumento='D'", "Orden", "IDClase", "IDClase")
        Me.SearchLookUpEditClaseD.Text = ""
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")
        CargagridSearchLookUp(Me.SearchLookUpEditMonedaC, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")
        CargagridSearchLookUp(Me.SearchLookUpEditPlazo, "cppCondicionPago", "IDCondicionPago, Descr, Dias", "", "IDCondicionPago", "Descr", "IDCondicionPago")
        CargagridSearchLookUp(Me.SearchLookUpEditCuenta, "cbCuentaBancaria", "IDCuentaBanco, Descr, IDMoneda", "Activa = 1", "IDCuentaBanco", "Descr", "IDCuentaBanco")
        SearchLookUpEditCuenta.Enabled = False
        gbUsaCuentaBancaria = False
    End Sub

    Private Sub rbDebitos_CheckedChanged(sender As Object, e As EventArgs) Handles rbDebitos.CheckedChanged
        XtraTabDocumentos.TabPages(0).PageVisible = True
        XtraTabDocumentos.TabPages(0).BackColor = Color.DarkGray
        XtraTabDocumentos.TabPages(1).PageVisible = False
        XtraTabDocumentos.TabPages(1).BackColor = Color.DarkGray
        gsTipoDocumento = "D"
    End Sub

    Private Sub rbCreditos_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditos.CheckedChanged
        XtraTabDocumentos.TabPages(0).PageVisible = False
        XtraTabDocumentos.TabPages(1).PageVisible = True
        gsTipoDocumento = "C"
        Me.chkDetalle.Checked = False
        grpDetalle.Enabled = False
    End Sub

    Private Sub SearchLookUpEditPlazo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditPlazo.EditValueChanged
        If Me.SearchLookUpEditPlazo.EditValue IsNot Nothing Then
            Me.SearchLookUpEditPlazo.EditValue = gIDPlazo
            CalculaFechaVencimiento()
        End If

    End Sub

    Private Sub DateEditFecha_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFecha.EditValueChanged
        CalculaFechaVencimiento()
        gdTipoCambio = getTipoCambio(Me.DateEditFecha.EditValue, gsTipoCambio)
    End Sub

    Private Sub BarbtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnAdd.ItemClick
        gbAdd = True
        gIDPlazo = 0
        seteaControlsNewRecord()
        EnableControlsReadOnly(False)

    End Sub

    Private Sub SearchLookUpEditClaseD_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditClaseD.EditValueChanged
        Dim sClase As String
        Dim sWhere As String
        If Me.SearchLookUpEditClaseD.Text IsNot Nothing Then
            sClase = "'" + Me.SearchLookUpEditClaseD.EditValue.ToString() + "'"
            sWhere = "TipoDocumento='D' and IDClase = " + sClase
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipoD, "cppSubTipoDocumento", "IDSubTipo, Descr", sWhere, "IDSubTipo", "Descr", "IDSubTipo")
            If Me.SearchLookUpEditClaseD.EditValue <> "" Then

                Dim dr As DataRowView = Me.SearchLookUpEditClaseD.GetSelectedDataRow()
                gbUsaCuentaBancaria = CBool(dr("UsaCuentaBancaria"))
                gbUltimoNumero = CBool(dr("UltimoNumero"))
                gsIDClaseDebito = dr("IDClase").ToString()
                If gbUsaCuentaBancaria Then
                    Me.SearchLookUpEditCuenta.Enabled = True
                Else
                    Me.SearchLookUpEditCuenta.Enabled = False
                End If
                If gbUltimoNumero Then
                    Dim td As New DataTable
                    td = cManager.ExecFunction("cppGetUltimoNumero", "'D'," & sClase)
                    If td.Rows.Count > 0 Then
                        Me.txtDocumento.EditValue = td.Rows(0)(0).ToString()
                    End If
                Else
                    Me.txtDocumento.EditValue = ""
                End If

            End If
        End If
    End Sub

    Private Sub SearchLookUpEditClase_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditClase.EditValueChanged
        Dim sClase As String
        Dim sWhere As String
        If Me.SearchLookUpEditClase.Text <> "" Then
            Dim dr As DataRowView = Me.SearchLookUpEditClase.GetSelectedDataRow()
            gbUltimoNumero = CBool(dr("UltimoNumero"))
            sClase = "'" + Me.SearchLookUpEditClase.EditValue.ToString() + "'"
            sWhere = "TipoDocumento='C' and IDClase = " + sClase
            If Me.SearchLookUpEditClase.EditValue.ToString() = "FAC" Then
                Me.chkDetalle.Checked = True
            Else
                Me.chkDetalle.Checked = False
            End If

            If gbUltimoNumero Then
                Dim td As New DataTable
                td = cManager.ExecFunction("cppGetUltimoNumero", "'C'," & sClase)
                If td.Rows.Count > 0 Then
                    Me.txtDocumentoC.EditValue = td.Rows(0)(0).ToString()
                End If
            Else
                Me.txtDocumento.EditValue = ""
            End If
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "cppSubTipoDocumento", "IDSubTipo, Descr", sWhere, "IDSubTipo", "Descr", "IDSubTipo")
        End If
    End Sub
    'Private Function getConsecutivoSubTipo(spIDClase As String, spIDSubTipo As String) As String
    '    Dim td As New DataTable
    '    Dim lsCodigoConsecMask As String = ""
    '    Dim cManager As New Clases.ClassManager
    '    Dim sParameters As String = "IDClase ='" & spIDClase & "' and IDSubTipo ='" & spIDSubTipo & "'"
    '    If spIDClase = "" Or spIDSubTipo = "" Then
    '        lsCodigoConsecMask = ""
    '        Return lsCodigoConsecMask
    '    End If
    '    td = cManager.GetDataTable("cppSubTipoDocumento", "IDClase, IDSubtipo, CodigoConsecMask", sParameters, "IDSubTipo")
    '    lsCodigoConsecMask = td.Rows(0)("CodigoConsecMask").ToString()

    '    sParameters = "'" & lsCodigoConsecMask & "'"
    '    td = cManager.ExecFunction("getNextConsecMask", sParameters)
    '    If td.Rows.Count <= 0 Then
    '        lsCodigoConsecMask = ""
    '        MessageBox.Show("No existe un Consecutivo con Mascara para el SubTipo seleccionado, por favor llamar al Adminstrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return lsCodigoConsecMask
    '    End If
    '    If rbDebitos.Checked = True Then
    '        Me.txtDocumento.EditValue = td.Rows(0)(0)
    '        gsConsecutivoAnteriorD = txtDocumento.EditValue
    '    Else
    '        Me.txtDocumentoC.EditValue = td.Rows(0)(0)
    '        gsConsecutivoAnteriorC = txtDocumentoC.EditValue
    '    End If
    '    td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
    '    gsMascara = td.Rows(0)(0)
    '    Return lsCodigoConsecMask
    'End Function

    Private Sub SearchLookUpEditSubTipo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipo.EditValueChanged
        Try
            If gbAdd Then
                If Me.SearchLookUpEditClase.Text Is Nothing Then
                    MessageBox.Show("Ud debe seleccionar una Clase de Documento primero, por favor proceda a seleccinar una Clase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If Me.SearchLookUpEditSubTipo.Text Is Nothing Then
                    MessageBox.Show("Ud debe seleccionar un SubTipo de Documento , por favor proceda a seleccinar un SubTipo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                Dim sIDClase As String = Me.SearchLookUpEditClase.EditValue.ToString()
                Dim sIDSubTipo As String = Me.SearchLookUpEditSubTipo.EditValue.ToString()
                If sIDClase <> "" And sIDSubTipo <> "" Then
                    'gsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)
                    rbDebitos.Enabled = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchLookUpEditSubTipoD_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipoD.EditValueChanged
        Try
            If gbAdd Then
                If Me.SearchLookUpEditClaseD.Text Is Nothing Then
                    MessageBox.Show("Ud debe seleccionar una Clase de Documento primero, por favor proceda a seleccinar una Clase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If Me.SearchLookUpEditSubTipoD.Text Is Nothing Then
                    MessageBox.Show("Ud debe seleccionar un SubTipo de Documento , por favor proceda a seleccinar un SubTipo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                Dim sIDClase As String = Me.SearchLookUpEditClaseD.EditValue.ToString()
                Dim sIDSubTipo As String = Me.SearchLookUpEditSubTipoD.EditValue.ToString()
                'If sIDClase <> "" And sIDSubTipo <> "" Then
                '    gsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)
                '    rbCreditos.Enabled = False
                'End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function ControlsOk() As Boolean
        Dim lbok As Boolean = True
        Dim sDocumento As String
        Dim sWhere As String

        'If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
        '    SearchLookUpEditSucursal.Focus()
        '    lbok = False
        '    Return lbok

        'End If
        If Me.txtIDProveedor.Text = "" Or Not (Me.txtIDProveedor.EditValue IsNot Nothing Or txtNombre.EditValue IsNot Nothing) Then
            txtIDProveedor.Focus()
            lbok = False
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lbok

        End If

        If Not (Me.SearchLookUpEditPlazo.EditValue IsNot Nothing) Then
            SearchLookUpEditPlazo.Focus()
            lbok = False
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lbok
        End If

        If rbDebitos.Checked = True Then


            If Not (Me.SearchLookUpEditClaseD.EditValue IsNot Nothing) Then
                SearchLookUpEditClaseD.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Clase de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not (Me.SearchLookUpEditSubTipoD.EditValue IsNot Nothing) Then
                SearchLookUpEditSubTipoD.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un SubTipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not (Me.SearchLookUpEditMoneda.EditValue IsNot Nothing) Then
                SearchLookUpEditMoneda.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then
                DateEditFecha.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Fecha del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not (Me.DateEditVencimiento.EditValue IsNot Nothing) Then
                lbok = False
                DateEditVencimiento.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, debe existir una Fecha de Vencimiento del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Me.txtDocumento.Text = "" Or Not (Me.txtDocumento.Text IsNot Nothing) Then
                lbok = False
                txtDocumento.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, el Numero de Documento no puede quedar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Me.MemoEditConcepto.Text = "" Or Not (Me.MemoEditConcepto.Text IsNot Nothing) Then
                lbok = False
                MemoEditConcepto.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, Debe Indicar un Concepto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If txtMonto.EditValue = 0 Or txtMonto.EditValue Is Nothing Or String.IsNullOrEmpty(txtMonto.EditValue) Then
                lbok = False
                txtMonto.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Val(txtMonto.Text) <= 0 Then
                txtMonto.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If gbUsaCuentaBancaria Then
                If Not (Me.SearchLookUpEditCuenta.EditValue IsNot Nothing) Then
                    SearchLookUpEditCuenta.Focus()
                    lbok = False
                    MessageBox.Show("Por favor revise los datos de la cuenta, debe seleccionar una Cuenta Bancaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return lbok
                End If

            End If
            'Dim td As New DataTable
            'Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipoD.EditValue.ToString())
            'If sCodigoMask <> "" Then
            '    sCodigoMask = "'" & sCodigoMask & "'"
            '    td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
            '    gsMascara = td.Rows(0)(0)
            'Else
            '    gsMascara = ""
            '    lbok = False
            '    Return lbok
            'End If

            sDocumento = Me.txtDocumento.EditValue.ToString()
            'If Not IsMaskOK(gsMascara, sDocumento) Then
            '    Me.txtDocumento.Focus()
            '    lbok = False
            '    MessageBox.Show("Por favor revise los datos del Documento,  El Consecutivo debe Cumplir con la Máscara : " & gsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return lbok
            'End If
            If gbAdd Then
                sWhere = "IDClase='" & Me.SearchLookUpEditClaseD.EditValue.ToString() & "'" & _
                    " and Documento ='" & sDocumento & "'"
                If cManager.ExistsInTable("cppDebitos", "Documento", sWhere, "Documento") Then
                    MessageBox.Show("Por favor revise los datos del Documento, esa Debito ya Existe en la base de datos para ese Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lbok = False
                    Return lbok
                End If

            End If
        Else

            If Not (Me.SearchLookUpEditClase.EditValue IsNot Nothing) Or Me.SearchLookUpEditClase.Text = "" Then
                SearchLookUpEditClase.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Clase de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not (Me.SearchLookUpEditSubTipo.EditValue IsNot Nothing) Or Me.SearchLookUpEditSubTipo.Text = "" Then
                SearchLookUpEditSubTipo.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un SubTipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not (Me.SearchLookUpEditMonedaC.EditValue IsNot Nothing) Or Me.SearchLookUpEditMonedaC.Text = "" Then
                SearchLookUpEditMonedaC.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If


            If Not (Me.DateEditFechaC.EditValue IsNot Nothing) Then
                DateEditFechaC.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Fecha del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If


            If txtDocumentoC.Text = "" Or Not (Me.txtDocumentoC.Text IsNot Nothing) Then
                lbok = False
                txtDocumentoC.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, el Numero de Documento no puede quedar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If MemoEditConceptoC.Text = "" Or Not (Me.MemoEditConceptoC.Text IsNot Nothing) Then
                lbok = False
                MemoEditConceptoC.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, Debe Indicar un Concepto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If txtMontoC.EditValue Is Nothing Or String.IsNullOrEmpty(txtMontoC.EditValue) Then
                lbok = False
                txtMontoC.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not IsNumeric(txtMontoC.Text) Or txtMontoC.EditValue <= 0 Then
                txtMontoC.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not IsNumeric(txtSubTotal.Text) Or txtSubTotal.EditValue < 0 Then
                txtSubTotal.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el SubTotal del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not IsNumeric(txtDescuento.Text) Or txtDescuento.EditValue < 0 Then
                txtDescuento.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Descuento del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not IsNumeric(txtIVA.Text) Or txtIVA.EditValue < 0 Then
                txtIVA.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Impuesto IVA del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not IsNumeric(txtConsumo.Text) Or txtConsumo.EditValue < 0 Then
                txtConsumo.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Impuesto Consumo del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not IsNumeric(txtFlete.Text) Or txtFlete.EditValue < 0 Then
                txtFlete.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Impuesto Consumo del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not IsNumeric(txtTotal.Text) Or txtTotal.EditValue <= 0 Then
                txtTotal.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Impuesto Consumo del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If


            'Dim td As New DataTable
            'Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipo.EditValue.ToString())
            'If sCodigoMask <> "" Then
            '    sCodigoMask = "'" & sCodigoMask & "'"
            '    td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
            '    gsMascara = td.Rows(0)(0)
            'Else
            '    gsMascara = ""
            'End If

            sDocumento = Me.txtDocumentoC.EditValue.ToString()
            'If Not IsMaskOK(gsMascara, sDocumento) Then
            '    Me.txtDocumentoC.Focus()
            '    lbok = False
            '    MessageBox.Show("Por favor revise los datos del Documento, El Consecutivo debe Cumplir con la Máscara : " & gsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return lbok
            'End If
            sWhere = "IDClase='" & Me.SearchLookUpEditClase.EditValue.ToString() & "'" & _
                " and Documento ='" & sDocumento & "'"
            If cManager.ExistsInTable("ccfCreditos", "Documento", sWhere, "Documento") Then
                MessageBox.Show("Por favor revise los datos del Documento, esa Debito ya Existe en la base de datos para ese Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbok = False
                Return lbok
            End If
        End If
        Return lbok



    End Function
    Private Sub BarbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnSave.ItemClick
        Dim storeName As String, sparameterValues As String
        Dim sIDRetenciones As String
        Try
            If ControlsOk() Then
                If gbEdit Then
                    If gsTipoDocumento = "D" And Me.CheckEditAprobado.Checked Then
                        MessageBox.Show("No se puede editar un Documento aprobado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If gsTipoDocumento = "C" And Me.CheckEditAprobadoC.Checked Then
                        MessageBox.Show("No se puede editar un Documento aprobado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                Dim td As New DataTable()
                If Me.rbDebitos.Checked Then
                    If gParametrosCPP.EditaConsecutivos = True Then
                        'If Not IsMaskOK(gsMascara, Me.txtDocumento.EditValue) Then
                        '    Me.txtDocumento.Focus()
                        '    Return
                        'Else
                        If gbAdd Then
                            If cManager.ExistsInTable("ccfDebitos", "Documento", "Documento='" & txtDocumento.EditValue.ToString() & _
                                    "' and IDClase ='" & Me.SearchLookUpEditClaseD.EditValue.ToString() & "' and IDSubTipo = " & _
                                    Me.SearchLookUpEditSubTipoD.EditValue.ToString(), "IDClase, IDSubTipo") Then
                                MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If

                            'End If
                        End If
                    End If


                    storeName = "cppUpdatecppDebitos"
                    sparameterValues = IIf(gbAdd = True, "'I',", "'U',")
                    sparameterValues = sparameterValues & "0," & txtIDProveedor.EditValue.ToString()
                    sparameterValues = sparameterValues & ",'D','"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClaseD.EditValue.ToString() & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipoD.EditValue.ToString() & ",'"
                    sparameterValues = sparameterValues & Me.txtDocumento.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',"
                    sparameterValues = sparameterValues & Me.txtMonto.EditValue.ToString() & ",0,'"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClaseD.EditValue.ToString() & " : " & txtDocumento.Text & " Proveedor " & Me.txtNombre.EditValue.ToString() & " Generado en CXP" & "','"
                    sparameterValues = sparameterValues & Me.MemoEditConcepto.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & gsUsuario & "',"
                    sparameterValues = sparameterValues & gdTipoCambio.ToString() & ","
                    sparameterValues = sparameterValues & IIf(Me.CheckEditOrigenExterno.Checked = True, 1, 0).ToString() & ","
                    sparameterValues = sparameterValues & IIf(Me.CheckEditAprobado.Checked = True, 1, 0).ToString() & ","
                    sparameterValues = sparameterValues & Me.SearchLookUpEditMoneda.EditValue.ToString() & ", 0,"
                    If gbUsaCuentaBancaria Then
                        sparameterValues = sparameterValues & Me.SearchLookUpEditCuenta.EditValue.ToString()
                    Else
                        sparameterValues = sparameterValues & "null"
                    End If

                    td = cManager.ExecSPgetData(storeName, sparameterValues)
                    If td.Rows.Count > 0 Then
                        If gbAdd Then
                            Me.txtID.EditValue = td.Rows(0)(0).ToString()
                        End If

                        gsTipoDocumento = "D"
                        giIDDocumento = Me.txtID.EditValue
                        gbEdit = True
                        gbAdd = False
                    End If
                    MessageBox.Show("El registro ha sido guardado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else

                    Dim frm As New frmPopUpRetProveedor()
                    frm.gsIDProveedor = txtIDProveedor.EditValue.ToString()
                    frm.gsNombreProveedor = txtNombre.ToString()
                    frm.gsDocumento = txtDocumentoC.EditValue.ToString()
                    frm.ShowDialog()
                    sIDRetenciones = frm.gsIDRetenciones
                    frm.Dispose()
                    If gParametrosCPP.EditaConsecutivos = True Then
                        'If Not IsMaskOK(gsMascara, Me.txtDocumentoC.EditValue) Then
                        '    Me.txtDocumentoC.Focus()
                        '    Return
                        'Else
                        If cManager.ExistsInTable("ccfCreditos", "Documento", "IDProveedor=" & txtIDProveedor.EditValue.ToString() & " and '" & Me.SearchLookUpEditClase.EditValue.ToString() & "' and  Documento='" & txtDocumentoC.EditValue.ToString() & "'", "IDCredito") Then
                            MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                            'End If
                        End If
                    End If
                End If
                sparameterValues = IIf(gbAdd = True, "'I',", "'U',")
                storeName = "cppUpdatecppCreditos"
                sparameterValues = sparameterValues & "0," & txtIDProveedor.EditValue.ToString() & ",'C','"
                sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & "',"
                sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipo.EditValue.ToString() & ",'"
                sparameterValues = sparameterValues & Me.txtDocumentoC.EditValue.ToString() & "','"
                sparameterValues = sparameterValues & CDate(Me.DateEditFechaC.EditValue).ToString("yyyyMMdd") & "',"
                sparameterValues = sparameterValues & Me.SearchLookUpEditPlazo.EditValue.ToString() & ","
                sparameterValues = sparameterValues & Me.txtMontoC.EditValue.ToString() & ",'"
                sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & " : " & txtDocumentoC.Text & " Proveedor " & txtIDProveedor.Text & " " & Me.txtNombre.EditValue.ToString() & " Generado en CXP" & "','"
                sparameterValues = sparameterValues & Me.MemoEditConceptoC.EditValue.ToString() & "','"
                sparameterValues = sparameterValues & gsUsuario & "',"
                sparameterValues = sparameterValues & gdTipoCambio.ToString() & ","
                sparameterValues = sparameterValues & IIf(Me.CheckEditOrigenExternoC.Checked = True, 1, 0).ToString() & ","
                sparameterValues = sparameterValues & IIf(Me.CheckEditAprobadoC.Checked = True, 1, 0).ToString() & ","
                sparameterValues = sparameterValues & Me.SearchLookUpEditMonedaC.EditValue.ToString() & ",0, "
                sparameterValues = sparameterValues & txtSubTotal.EditValue.ToString() & "," & txtDescuento.EditValue.ToString() & "," & txtSubTotalDescontado.EditValue.ToString() & ","
                sparameterValues = sparameterValues & txtIVA.EditValue.ToString() & "," & txtConsumo.EditValue.ToString() & "," & txtFlete.EditValue.ToString() & "," & txtTotal.EditValue.ToString() & ",'" & sIDRetenciones & "'"

                td = cManager.ExecSPgetData(storeName, sparameterValues)
                If td.Rows.Count > 0 Then
                    If gbAdd Then
                        Me.txtIDC.EditValue = td.Rows(0)(0).ToString()
                    End If
                    gbAdd = True
                    gbEdit = False
                    gsTipoDocumento = "C"
                    giIDDocumento = Me.txtIDC.EditValue
                    EnableControlsReadOnly(True)
                End If
                MessageBox.Show("El registro ha sido guardado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Me.rbCreditos.Enabled = True
            Me.rbDebitos.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message & " Registrando Documentos ")
        End Try
    End Sub

    Private Sub DateEditFechaC_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFechaC.EditValueChanged
        gdTipoCambio = getTipoCambio(Me.DateEditFechaC.EditValue, gsTipoCambio)
    End Sub

    Private Sub BarbtnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnAprobar.ItemClick
        If Me.CheckEditAprobado.Checked Or Me.CheckEditAprobadoC.Checked Then
            MessageBox.Show("El Documento ya esta Aprobado... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Me.chkAnulado.Checked Or Me.chkAnuladoC.Checked Then
            MessageBox.Show("El Documento ya esta Anulado, no se puede Aprobar... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If gsTipoDocumento = "D" Then
            If Me.CheckEditAprobado.Checked = False And Me.rbDebitos.Checked And Me.txtID.EditValue.ToString() <> "" Then
                Dim sParametros As String = "'D'," & Me.txtID.EditValue.ToString()  'Rows(1).ToString() & "', " & Rows(0).ToString()
                If Not cManager.ExecSP("cppAprobarDocumento", sParametros) Then
                    MessageBox.Show("Hubo un error aprobando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.CheckEditAprobado.Checked = True
                    EnableControlsReadOnly(True)
                    Me.BarbtnAprobar.Enabled = False
                    Me.BarbtnAplicar.Enabled = False
                    MessageBox.Show("El Documento fue Aprobado exitosamente... ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
        If gsTipoDocumento = "C" Then
            If Me.CheckEditAprobadoC.Checked = False And Me.rbCreditos.Checked And Me.txtIDC.EditValue.ToString() <> "" Then
                Dim sParametros As String = "'C'," & Me.txtIDC.EditValue.ToString()  'Rows(1).ToString() & "', " & Rows(0).ToString()
                If Not cManager.ExecSP("cppAprobarDocumento", sParametros) Then
                    MessageBox.Show("Hubo un error aprobando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.CheckEditAprobadoC.Checked = True
                    EnableControlsReadOnly(True)
                    MessageBox.Show("El Documento fue Aprobado exitosamente... ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.BarbtnAprobar.Enabled = False
                    Me.BarbtnAplicar.Enabled = True
                End If
            End If

        End If

    End Sub

    Private Sub BarbtnAplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnAplicar.ItemClick
        If gsTipoDocumento = "D" Then
            If Me.CheckEditAprobado.Checked = False Then
                MessageBox.Show("No se puede Aplicar Documento que no ha sido Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Me.chkAnulado.Checked = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            If Me.CheckEditAprobadoC.Checked = False Then
                MessageBox.Show("No se puede Aplicar Documento que no ha sido Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.chkAnuladoC.Checked = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If


        Dim frm As New frmCPAplicaCreditos()
        frm.gbAplicar = True
        If gsTipoDocumento = "D" Then

            frm.gbAplicar = True
            frm.gsClase = Me.SearchLookUpEditClaseD.EditValue.ToString()
            frm.gIDProveedor = Me.txtIDProveedor.EditValue.ToString()
            frm.gsNombre = Me.txtNombre.EditValue.ToString()
            frm.gIDDocPago = Me.txtID.EditValue.ToString()
            frm.gdMontoOriginal = CDec(Me.txtMonto.EditValue)
            frm.gdSaldo = CDec(txtSaldo.EditValue)
            frm.gdFecha = Me.DateEditFecha.EditValue
            frm.gsDocumento = Me.txtDocumento.EditValue.ToString()
            frm.gsMoneda = Me.SearchLookUpEditMoneda.Text
            frm.gIDMoneda = Me.SearchLookUpEditMoneda.EditValue.ToString()
            frm.gdTipoCambio = gdTipoCambio

            frm.ShowDialog()
            Me.txtSaldo.EditValue = frm.txtSaldoOriginal.EditValue
        End If

    End Sub

    Private Sub BarbtnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnSalir.ItemClick
        Close()
    End Sub

    Private Sub BarButtonItemAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnAnular.ItemClick

        If Me.chkAnulado.Checked Or Me.chkAnuladoC.Checked Then
            MessageBox.Show("El Documento ya esta Anulado... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If gsTipoDocumento = "D" Then

            If Me.chkAnulado.Checked = False And Me.rbDebitos.Checked And Me.txtID.EditValue.ToString() <> "" Then
                Dim sParametros As String = "'D'," & Me.txtID.EditValue.ToString()  'Rows(1).ToString() & "', " & Rows(0).ToString()

                If MessageBox.Show("Está seguro de anular el Documento  " & txtDocumento.EditValue.ToString(), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    Exit Sub
                End If
                Dim td As New DataTable
                td = cManager.ExecFunction("cppTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If Not cManager.ExecSP("cppAnularDocumento", sParametros) Then
                    MessageBox.Show("Hubo un error anulando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.chkAnulado.Checked = True
                    EnableControlsReadOnly(True)
                    Me.BarbtnAnular.Enabled = False
                    Me.BarbtnAplicar.Enabled = False
                    MessageBox.Show("El Documento fue Anulado exitosamente... ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
        If gsTipoDocumento = "C" Then
            If Me.chkAnuladoC.Checked = False And Me.rbCreditos.Checked And Me.txtIDC.EditValue.ToString() <> "" Then
                Dim sParametros As String = "'C'," & Me.txtIDC.EditValue.ToString()  'Rows(1).ToString() & "', " & Rows(0).ToString()

                If MessageBox.Show("Está seguro de anular el Documento  " & txtDocumentoC.EditValue.ToString(), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    Exit Sub
                End If
                Dim td As New DataTable
                td = cManager.ExecFunction("cppTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If


                If Not cManager.ExecSP("cppAnularDocumento", sParametros) Then

                    MessageBox.Show("Hubo un error anulando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.chkAnulado.Checked = True
                    EnableControlsReadOnly(True)
                    Me.BarbtnAnular.Enabled = False
                    Me.BarbtnAplicar.Enabled = False
                End If
            End If

        End If


    End Sub

    Private Sub BarButtonItemImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemImprimir.ItemClick
        Dim sParameters As String
        Dim iIDDocumento As Integer
        If Me.rbCreditos.Checked = True Then
            iIDDocumento = CInt(Me.txtIDC.EditValue)
        Else
            iIDDocumento = CInt(Me.txtID.EditValue)
        End If

        sParameters = "'" & gsTipoDocumento & "'," & iIDDocumento.ToString()

        tableData = cManager.ExecSPgetData("ccfGetDocumento", sParameters)
        If tableData.Rows.Count > 0 Then

            Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptDocumentoCCF.repx", True)
            report.DataSource = vbNull
            report.DataSource = tableData
            ' report.DataMember = "ccfrptMovimientos"
            report.Parameters("psEmpresa").Value = gsNombreEmpresa
            report.Parameters("psTipoDocumento").Value = gsTipoDocumento
            report.Parameters("piIDDocumento").Value = CInt(IIf(rbCreditos.Checked, Me.txtIDC.EditValue, Me.txtID.EditValue))
            report.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)

            tool.ShowPreview()
        End If
    End Sub


    Private Sub txtDocumentoC_Leave(sender As Object, e As EventArgs) Handles txtDocumentoC.Leave
        Dim sMensaje As String = ""
        'If Not IsMaskOK(gsMascara, Me.txtDocumentoC.EditValue) Then
        '    Me.txtDocumentoC.Focus()
        '    Return
        'End If
        If gParametrosCPP.EditaConsecutivos Then
            gsConsecutivoDigitadoC = txtDocumentoC.EditValue.ToString()
            'Dim i As Int32 = CountBetweenConsecutivos(gsMascara, gsConsecutivoAnteriorC, gsConsecutivoDigitadoC)
            'If i > 1 Or i < 0 Then
            '    sMensaje = "Ud digita un consecutivo que no corresponde al siguiente. El siguiente es " & gsConsecutivoAnteriorC & " y digito " & gsConsecutivoDigitadoC & " Hay una diferencia de " & i.ToString() & " Numeros "
            '    If MessageBox.Show(sMensaje & ". Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbNo Then
            '        txtDocumentoC.EditValue = gsConsecutivoAnteriorC
            '    End If
            'End If
        End If
    End Sub

    Private Sub txtDocumento_Leave(sender As Object, e As EventArgs) Handles txtDocumento.Leave
        'Dim sMensaje As String
        ''If Not IsMaskOK(gsMascara, Me.txtDocumento.EditValue) Then
        ''    Me.txtDocumento.Focus()
        ''    Return
        ''End If
        'If gParametrosCPP.EditaConsecutivos Then
        '    gsConsecutivoDigitadoD = txtDocumento.EditValue.ToString()
        '    Dim i As Int32 = CountBetweenConsecutivos(gsMascara, gsConsecutivoAnteriorD, gsConsecutivoDigitadoD)
        '    If i > 1 Or i < 0 Then
        '        sMensaje = "Ud digita un consecutivo que no corresponde al siguiente. El siguiente es " & gsConsecutivoAnteriorD & " y digito " & gsConsecutivoDigitadoD & " Hay una diferencia de " & i.ToString() & " Numeros "
        '        If MessageBox.Show(sMensaje & ". Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbNo Then
        '            txtDocumento.EditValue = gsConsecutivoAnteriorD
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub txtMontoC_LostFocus(sender As Object, e As EventArgs) Handles txtMontoC.LostFocus
        If gbAdd Then
            txtSaldoC.EditValue = txtMontoC.EditValue
        End If
    End Sub

    Private Sub txtMonto_EditValueChanged(sender As Object, e As EventArgs) Handles txtMonto.EditValueChanged

    End Sub

    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            MemoEditConcepto.Focus()
        End If
    End Sub

    Private Sub txtMontoC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoC.KeyDown
        If e.KeyCode = Keys.Enter Then
            MemoEditConceptoC.Focus()
        End If
    End Sub

    Private Sub txtDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub SearchLookUpEditCuenta_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditCuenta.EditValueChanged
        Dim lbok As Boolean = ValidaMonedas()
        If gbAdd Then
            If Me.SearchLookUpEditCuenta.Text <> "" And gsIDClaseDebito = "CHK" Then
                Me.txtDocumento.EditValue = getNextConsecutivoCheque(SearchLookUpEditCuenta.EditValue.ToString())
            End If
        End If
    End Sub
    Private Function ValidaMonedas() As Boolean
        Dim lbok As Boolean = True
        Try
            If Me.SearchLookUpEditCuenta.Text <> "" Then
                If Me.SearchLookUpEditMoneda.Text = "" Then
                    MessageBox.Show("Ud no ha seleccionado la Moneda del documento. Por favor indique la Moneda del documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SearchLookUpEditCuenta.Text = ""
                    lbok = False
                End If
                Dim dr As DataRowView = Me.SearchLookUpEditCuenta.GetSelectedDataRow()
                giIDMonedaCuentaBancaria = CInt(dr("IDMoneda"))
                If giIDMonedaCuentaBancaria <> CInt(Me.SearchLookUpEditMoneda.EditValue) Then
                    MessageBox.Show("Ud seleccionó una Cuenta de Banco con Moneda distinta a la Moneda del documento. Revise por favor, ambas monedas deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SearchLookUpEditCuenta.Text = ""
                    lbok = False
                End If
            End If
            Return lbok
        Catch ex As Exception
            lbok = False
            MessageBox.Show("Ocurrió un error al validar la moneda de la cuenta bancaria y del documento " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lbok
        End Try
    End Function

    Private Sub SearchLookUpEditMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditMoneda.EditValueChanged
        Dim lbok As Boolean = ValidaMonedas()
    End Sub
    Private Sub CalculaDesglose()
        Try
                Me.txtSubTotalDescontado.EditValue = CDec(txtSubTotal.EditValue) - CDec(txtDescuento.EditValue)
                Me.txtTotal.EditValue = CDec(txtSubTotalDescontado.EditValue) + CDec(Me.txtIVA.EditValue) + CDec(txtConsumo.EditValue) + CDec(txtFlete.EditValue)
                txtMontoC.EditValue = CDec(txtTotal.EditValue)
                txtSaldoC.EditValue = CDec(txtMontoC.EditValue)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al Calcular el Desglose" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSubTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtSubTotal.EditValueChanged
        CalculaDesglose()
    End Sub

    Private Sub txtDescuento_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescuento.EditValueChanged
        CalculaDesglose()
    End Sub

    Private Sub txtIVA_EditValueChanged(sender As Object, e As EventArgs) Handles txtIVA.EditValueChanged
        CalculaDesglose()
    End Sub

    Private Sub txtConsumo_EditValueChanged(sender As Object, e As EventArgs) Handles txtConsumo.EditValueChanged
        CalculaDesglose()
    End Sub

    Private Sub txtFlete_EditValueChanged(sender As Object, e As EventArgs) Handles txtFlete.EditValueChanged
        CalculaDesglose()
    End Sub


    Private Sub chkDetalle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetalle.CheckedChanged
        If chkDetalle.Checked = True Then
            Me.grpDetalle.Enabled = True
        Else
            If Me.SearchLookUpEditClase.EditValue.ToString() <> "FAC" Then
                Me.grpDetalle.Enabled = False
            Else
                chkDetalle.Checked = True
            End If

        End If
    End Sub

    Private Sub txtMontoC_Leave(sender As Object, e As EventArgs) Handles txtMontoC.Leave
        If gbAdd Then
            txtSubTotal.EditValue = CDec(txtMontoC.EditValue)
            CalculaDesglose()
        End If

    End Sub


    Private Sub txtMontoC_EditValueChanged(sender As Object, e As EventArgs) Handles txtMontoC.EditValueChanged

    End Sub
End Class