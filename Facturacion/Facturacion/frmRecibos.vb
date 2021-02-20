Imports Clases
Imports DevExpress.XtraEditors

Public Class frmRecibos
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim lsMascara As String
    Dim lsConsecutivoAnterior As String
    Dim lsCodigoConsecMask As String
    Dim lsConsecutivoDigitado As String
    Dim lID As Integer
    Dim bgetDocumento As Boolean = False
    Dim gbEdit As Boolean = False
    Dim gdTipoCambio As Decimal

    Private Sub frmRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not CargaParametros() Then
                MessageBox.Show("Ha ocurrido un error al cargar los Parametros de Facturacion...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()

            End If
            If Not CargaParametrosCCF() Then
                MessageBox.Show("Ha ocurrido un error al cargar los Parametros de Cartera...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            CargagridLookUpsFromTables()
            CreateFieldsToDataTable()
            Me.DateEditFechaCredito.EditValue = Now.Date
            Me.SearchLookUpEditClaseCredito.EditValue = gParametrosCCF.IDClaseRCDesglosado
            Me.SearchLookUpEditClaseDebito.EditValue = gParametrosCCF.IDClaseFACRCDesglosado
            gdTipoCambio = getTipoCambio(CDate(Now), gParametros.TipoCambioFact)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la pantalla de Recibos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        Me.SearchLookUpEditSucursal.EditValue = CInt(gsSucursal)
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditClaseCredito, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='C'", "Orden", "IDClase", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditClaseDebito, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='D'", "Orden", "IDClase", "IDClase")

        CargagridSearchLookUp(Me.SearchLookUpEditSubTipoDebito, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='D'", "IDSubTipo", "Descr", "IDSubTipo")
        If gParametrosCCF.IDMonedaUnica <> 0 Then
            CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr", "Activo=1 and IDMoneda = " & gParametrosCCF.IDMonedaUnica.ToString(), "IDMoneda", "Descr", "IDMoneda")
        Else
            CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")
        End If

        CargagridSearchLookUp(Me.SearchLookUpEditMonedaFactura, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")
        CargagridSearchLookUp(Me.SearchLookUpEditBanco, "cbBanco", "IDBanco, Descr", "Activo=1", "IDBanco", "Descr", "IDBanco")
    End Sub

    Sub CreateFieldsToDataTable()
        'Campos del detalle de documentos debitos 
        tableData.Columns.Add("ID", GetType(Integer))
        tableData.Columns("ID").AutoIncrement = True
        tableData.Columns("ID").AutoIncrementSeed = 1
        tableData.Columns.Add("IDBodega", GetType(Integer))
        tableData.Columns.Add("IDClase", GetType(String))
        tableData.Columns.Add("IDSubtipo", GetType(Integer))
        tableData.Columns.Add("IDMoneda", GetType(Integer))
        tableData.Columns.Add("IDDebito", GetType(Integer))
        tableData.Columns.Add("Documento", GetType(String))
        tableData.Columns.Add("Efectivo", GetType(Decimal))
        tableData.Columns.Add("Descuento", GetType(Decimal))
        tableData.Columns.Add("RetencionMunicipal", GetType(Decimal))
        tableData.Columns.Add("RetencionRenta", GetType(Decimal))
        tableData.Columns.Add("Saldo", GetType(Decimal))
        tableData.Columns.Add("Fecha", GetType(Date))
        tableData.Columns.Add("Vencimiento", GetType(Date))
        tableData.Columns.Add("DiasVencidos", GetType(Integer))
        tableData.Columns.Add("IDBanco", GetType(Integer))
        tableData.Columns("IDBanco").AllowDBNull = True
        tableData.Columns.Add("ChequePos", GetType(String))
        tableData.Columns("ChequePos").AllowDBNull = True
        tableData.Columns.Add("MontoChequePos", GetType(Decimal))
        tableData.Columns("MontoChequePos").AllowDBNull = True
        tableData.Columns.Add("FechaCobro", GetType(Date))
        tableData.Columns("FechaCobro").AllowDBNull = True
        tableData.Columns.Add("Aplicado", GetType(Decimal))
        tableData.Columns.Add("PagoChequePos", GetType(Decimal))
    End Sub
    Sub UpdateRowDataTable(sOperacion As String, iID As Integer, iIDBodega As Integer, sIDClase As String, iIDSubTipo As Integer, _
                            iIDMoneda As Integer, sDocumento As String, _
                             dEfectivo As Decimal, dDescuento As Decimal, dRetencionMunicipal As Decimal, dRetencionRenta As Decimal, _
                             dFecha As Date, dVencimiento As Date, iDiasVencidos As Integer, _
                             sChequePos As String, dMontoChequePos? As Decimal, dFechaCobro? As Date, iIDBanco? As Integer, dSaldo As Decimal, dPagoChequePos? As Decimal)
        Select Case sOperacion
            Case "I"

                Dim Row As DataRow = tableData.NewRow
                Row("IDBodega") = iIDBodega
                Row("IDClase") = sIDClase
                Row("IDSubtipo") = iIDSubTipo
                Row("IDMoneda") = iIDMoneda
                Row("Documento") = sDocumento
                Row("IDDebito") = iID
                Row("Efectivo") = dEfectivo
                Row("Descuento") = dDescuento
                Row("RetencionMunicipal") = dRetencionMunicipal
                Row("RetencionRenta") = dRetencionRenta
                Row("Saldo") = dSaldo
                Row("Fecha") = dFecha
                Row("Vencimiento") = dVencimiento
                Row("DiasVencidos") = iDiasVencidos
                If sChequePos IsNot Nothing Then
                    Row("ChequePos") = sChequePos
                End If
                If dMontoChequePos.HasValue Then
                    Row("MontoChequePos") = dMontoChequePos
                End If
                If dPagoChequePos.HasValue Then
                    Row("PagoChequePos") = dPagoChequePos
                End If
                If dFechaCobro.HasValue Then
                    Row("FechaCobro") = dFechaCobro
                End If
                If iIDBanco.HasValue Then
                    Row("IDBanco") = iIDBanco
                End If
                Row("Aplicado") = dEfectivo + dDescuento + dRetencionMunicipal + dRetencionRenta + dPagoChequePos
                tableData.Rows.Add(Row)
            Case "U"
                Dim strCriterio As String = "ID=" & iID.ToString()
                Dim Row As Data.DataRow() = tableData.Select(strCriterio)
                If Row.Length > 0 Then
                    Row(0)("Documento") = sDocumento
                    Row(0)("Efectivo") = dEfectivo
                    Row(0)("Descuento") = dDescuento
                    Row(0)("RetencionMunicipal") = dRetencionMunicipal
                    Row(0)("RetencionRenta") = dRetencionRenta
                    Row(0)("Saldo") = dSaldo
                    Row(0)("Fecha") = dFecha
                    Row(0)("Vencimiento") = dVencimiento
                    Row(0)("DiasVencidos") = iDiasVencidos
                    Row(0)("ChequePos") = sChequePos
                    Row(0)("MontoChequePos") = dMontoChequePos
                    Row(0)("PagoChequePos") = dPagoChequePos
                    Row(0)("FechaCobro") = dFechaCobro
                    Row(0)("IDBanco") = iIDBanco
                    Row(0)("Aplicado") = dEfectivo + dDescuento + dRetencionMunicipal + dRetencionRenta + dPagoChequePos

                End If
            Case "D"
                Dim strCriterio As String = "ID=" & iID.ToString()
                Dim Rows As Data.DataRow() = tableData.Select(strCriterio)
                If Rows.Length > 0 Then
                    For Each Row As DataRow In Rows
                        Dim nrow As DataRow = Row
                        tableData.Rows.Remove(nrow)
                    Next
                End If
        End Select
        RefreshDataFromGridToControls()
        datagrid.DataSource = tableData
        TotalizaGrid()
        datagrid.Refresh()
    End Sub

    Private Sub btnAdcionar_Click(sender As Object, e As EventArgs) Handles btnAdcionar.Click
        Dim schkPosNumero As String, dChkPosMonto As Decimal, dFechaCobro As Date, iIDBanco As Decimal
        gbEdit = False
        If Not ControlsHeaderOk() Then
            MessageBox.Show("Por favor revise los datos generales del Recibo o Crédito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If CDec(txtSaldo.EditValue) < (CDec(txtEfectivo.EditValue) + CDec(txtPagoPosfechado.EditValue) + CDec(txtDescuento.EditValue) + CDec(txtRetencionMunicipal.EditValue) + CDec(txtRetencionRenta.EditValue)) Then
            MessageBox.Show("Ud. No puede hacer un Pago mayor que el Saldo del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If CDec(txtSaldo.EditValue) <= 0 Then
            MessageBox.Show("No se puede cancelar un dédito con saldo menor o igual a cero, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearControlsForNew()
            gbEdit = False
            btnAdcionar.Enabled = True
            btnEdit.Enabled = False
            btnEliminar.Enabled = False
            If Me.chkPosfechado.Checked Then
                txtPagoPosfechado.EditValue = txtchkPosMonto.EditValue
            End If
            txtFactura.Focus()
            Return
        End If

        If Not ControlsDetalleOk() Then
            MessageBox.Show("Por favor revise los datos de la Factura o Débito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsMaskOK(lsMascara, Me.txtRecibo.EditValue) Then
            MessageBox.Show("Por favor revise el valor digitado del Recibo... no coincide con la máscara " & lsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtRecibo.Focus()
            Return
        End If

        If Not Me.txtchkPosNumero.EditValue IsNot Nothing Then
            schkPosNumero = ""
        Else
            schkPosNumero = Me.txtchkPosNumero.EditValue.ToString()
        End If

        If Not Me.txtPagoPosfechado.EditValue IsNot Nothing Then
            dChkPosMonto = 0
        Else
            dChkPosMonto = CDec(Me.txtchkPosMonto.EditValue)
        End If

        If Not Me.DateEditFechaCobro.EditValue IsNot Nothing Then
            dFechaCobro = CDate("01/01/1980")
        Else
            dFechaCobro = CDate(Me.DateEditFechaCobro.EditValue)
        End If
        If Not Me.SearchLookUpEditBanco.EditValue IsNot Nothing Then
            iIDBanco = 0
        Else
            iIDBanco = CInt(Me.SearchLookUpEditBanco.EditValue)
        End If
        If chkPosfechado.Checked Then
            If txtTotalPosFechado.Text = "" Then
                txtTotalPosFechado.Text = "0"
            End If

            If (txtchkPosMonto.EditValue = Me.txtTotalPosFechado.EditValue) Then
                MessageBox.Show("El Monto indicado en el Cheque ha sido aplicado totalmente, no puede aplicar mas facturas a ese monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If CDec(txtchkPosMonto.EditValue) < CDec(txtTotalPosFechado.EditValue) Then
                MessageBox.Show("Por favor revise el valor del Monto del Cheque Pos Fechado al aplicar... debe ser menor o igual al valor del Cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtchkPosMonto.Focus()
                Return
            End If
        End If

        Dim strCriterio As String = "Documento ='" & txtFactura.EditValue.ToString() & "'"
        Dim Row As Data.DataRow() = tableData.Select(strCriterio)
        If Row.Length > 0 Then
            MessageBox.Show("Ud intenta agregar una factura que ya ha sido Aplicada, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If PuedoAplicarPago() Then
            UpdateRowDataTable("I", CInt(Me.txtIDDebito.EditValue), CInt(Me.SearchLookUpEditSucursal.EditValue), (Me.SearchLookUpEditClaseDebito.EditValue.ToString()), CInt(SearchLookUpEditSubTipoDebito.EditValue), CInt(SearchLookUpEditMonedaFactura.EditValue), _
                               Me.txtFactura.EditValue.ToString(), CDec(txtEfectivo.EditValue), CDec(txtDescuento.EditValue), CDec(txtRetencionMunicipal.EditValue), CDec(txtRetencionRenta.EditValue), CDate(Me.DateEditFecha.EditValue), CDate(Me.DateEditVence.EditValue), _
                                CInt(Me.txtDiasVencidos.EditValue), schkPosNumero, dChkPosMonto, dFechaCobro, iIDBanco, CDec(txtSaldo.EditValue), CDec(txtPagoPosfechado.EditValue))
            InitControlsDebito()
            ReadOnlyGrupoRecibo(True)
            ReadOnlyGrupoPosFechado(True)
            CopyDataFromGridToControls()
        Else
            MessageBox.Show("Por favor revise los datos no puede Aplicar el pago, insuficiente saldo ó no puede mezclar un Pos Fechado con otro tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReadOnlyGrupoPosFechado(bReadOnly As Boolean)
        txtchkPosNumero.ReadOnly = bReadOnly
        SearchLookUpEditBanco.ReadOnly = bReadOnly
        txtchkPosMonto.ReadOnly = bReadOnly
        DateEditFechaCobro.ReadOnly = bReadOnly
        txtchkPosMonto.ReadOnly = bReadOnly
    End Sub

    Private Sub ReadOnlyGrupoRecibo(bReadOnly As Boolean)
        Me.txtIDCliente.ReadOnly = bReadOnly
        Me.txtNombre.ReadOnly = bReadOnly
        Me.txtRecibo.ReadOnly = bReadOnly
        Me.SearchLookUpEditSucursal.ReadOnly = bReadOnly
        Me.SearchLookUpEditVendedor.ReadOnly = bReadOnly
        Me.SearchLookUpEditMoneda.ReadOnly = bReadOnly
        Me.SearchLookUpEditClaseCredito.ReadOnly = bReadOnly
        Me.SearchLookUpEditSubTipoCredito.ReadOnly = bReadOnly
        DateEditFechaCredito.ReadOnly = bReadOnly

    End Sub
    Private Sub CallPopUpClientes()
        Try
            If Me.SearchLookUpEditSucursal.Text = "" Then
                MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim frm As New frmPopupCliente()
            frm.gsIDSucursal = Me.SearchLookUpEditSucursal.EditValue.ToString()
            frm.ShowDialog()
            If frm.gsIDCliente <> "" Then
                Me.txtIDCliente.EditValue = frm.gsIDCliente
                Me.txtNombre.EditValue = frm.gsNombre
                Me.SearchLookUpEditVendedor.EditValue = CInt(frm.gsVendedor)
                Me.SearchLookUpEditMoneda.EditValue = CInt(frm.gsIDMoneda)
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los clientes " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function PuedoAplicarPago() As Boolean
        Dim lbok As Boolean = True
        Dim RecordsPosfechado As Integer = 0
        Dim RecordsSinChkPosfechado As Integer = 0
        Dim rows As DataRow()

        rows = tableData.Select("ChequePos <> ''")
        RecordsPosfechado = rows.Length
        rows = tableData.Select("ChequePos = ''")
        RecordsSinChkPosfechado = rows.Length
        If RecordsPosfechado > 0 And CDec(IIf(txtEfectivo.EditValue.ToString() = "", 0, txtEfectivo.EditValue)) > 0 And CDec(IIf(txtPagoPosfechado.EditValue.ToString() = "", 0, txtPagoPosfechado.EditValue)) = 0 Then
            lbok = False
        End If

        If RecordsSinChkPosfechado > 0 And CDec(IIf(txtPagoPosfechado.EditValue.ToString() = "", 0, txtPagoPosfechado.EditValue)) > 0 Then
            lbok = False
        End If


        Return lbok


    End Function

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        CallPopUpClientes()
    End Sub

    Private Sub SearchLookUpEditSubTipoDebito_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipoDebito.EditValueChanged
        Try

            If Me.SearchLookUpEditClaseDebito.Text Is Nothing Then
                MessageBox.Show("Ud debe seleccionar una Clase de Documento primero, por favor proceda a seleccinar una Clase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditSubTipoDebito.Text Is Nothing Then
                MessageBox.Show("Ud debe seleccionar un SubTipo de Documento , por favor proceda a seleccinar un SubTipo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function getConsecutivoSubTipo(spIDClase As String, spIDSubTipo As String) As String
        Dim td As New DataTable
        Dim lsCodigoConsecMask As String = ""
        Dim cManager As New Clases.ClassManager
        Dim sParameters As String = "IDClase ='" & spIDClase & "' and IDSubTipo ='" & spIDSubTipo & "'"
        If spIDClase = "" Or spIDSubTipo = "" Then
            lsCodigoConsecMask = ""
            Return lsCodigoConsecMask
        End If
        td = cManager.GetDataTable("ccfSubTipoDocumento", "IDClase, IDSubtipo, CodigoConsecMask", sParameters, "IDSubTipo")
        lsCodigoConsecMask = td.Rows(0)("CodigoConsecMask").ToString()

        sParameters = "'" & lsCodigoConsecMask & "'"
        td = cManager.ExecFunction("getNextConsecMask", sParameters)
        If td.Rows.Count <= 0 Then
            lsCodigoConsecMask = ""
            MessageBox.Show("No existe un Consecutivo con Mascara para el SubTipo seleccionado, por favor llamar al Adminstrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lsCodigoConsecMask
        End If

        Me.txtRecibo.EditValue = td.Rows(0)(0)
        lsConsecutivoAnterior = txtRecibo.EditValue.ToString()
        td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
        lsMascara = td.Rows(0)(0)
        Return lsCodigoConsecMask
    End Function

    Private Sub SearchLookUpEditSubTipoCredito_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipoCredito.EditValueChanged
        Try

            If Me.SearchLookUpEditClaseCredito.Text Is Nothing Then
                MessageBox.Show("Ud debe seleccionar una Clase de Documento primero, por favor proceda a seleccinar una Clase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditSubTipoCredito.Text Is Nothing Then
                MessageBox.Show("Ud debe seleccionar un SubTipo de Documento , por favor proceda a seleccinar un SubTipo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim sIDClase As String = Me.SearchLookUpEditClaseCredito.EditValue.ToString()
            Dim sIDSubTipo As String = Me.SearchLookUpEditSubTipoCredito.EditValue.ToString()
            If sIDClase <> "" And sIDSubTipo <> "" Then
                lsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)

            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtRecibo_Leave(sender As Object, e As EventArgs) Handles txtRecibo.Leave
        Dim sMensaje As String
        Dim lsConsecutivoDigitado As String
        If Not IsMaskOK(lsMascara, Me.txtRecibo.EditValue) Then
            txtRecibo.EditValue = lsConsecutivoAnterior
            Me.txtRecibo.Focus()
            Return
        End If
        If gParametrosCCF.EditaConsecutivos Then
            lsConsecutivoDigitado = txtRecibo.EditValue.ToString()
            Dim i As Int32 = CountBetweenConsecutivos(lsMascara, lsConsecutivoAnterior, lsConsecutivoDigitado)
            If i > 1 Or i < 0 Then
                sMensaje = "Ud digita un consecutivo que no corresponde al siguiente. El siguiente es " & lsConsecutivoAnterior & " y digito " & lsConsecutivoDigitado & " Hay una diferencia de " & i.ToString() & " Numeros "
                If MessageBox.Show(sMensaje & ". Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbNo Then
                    txtRecibo.EditValue = lsConsecutivoAnterior
                End If
            End If
        End If

    End Sub

    Private Sub RefreshDataFromGridToControls()
        Dim dr As DataRow = GridViewProducto.GetFocusedDataRow()

        If dr IsNot Nothing Then
            Me.SearchLookUpEditClaseDebito.EditValue = dr("IDClase").ToString()
            Me.SearchLookUpEditSubTipoDebito.EditValue = CInt(dr("IDSubTipo"))
            Me.SearchLookUpEditMonedaFactura.EditValue = CInt(dr("IDMoneda"))
            Me.SearchLookUpEditBanco.EditValue = CInt(dr("IDBanco"))
            Me.DateEditFecha.EditValue = CDate(dr("Fecha"))
            Me.DateEditVence.EditValue = CDate(dr("Vencimiento"))
            Me.txtDiasVencidos.EditValue = CInt(dr("DiasVencidos"))
            Me.txtchkPosNumero.EditValue = dr("ChequePos").ToString()
            Me.txtPagoPosfechado.EditValue = CDec(dr("MontoChequePos"))
            Me.DateEditFechaCobro.EditValue = CDate(dr("FechaCobro"))
            Me.txtFactura.EditValue = dr("Documento").ToString()
            Me.txtEfectivo.EditValue = CDec(dr("Efectivo"))
            Me.txtDescuento.EditValue = CDec(dr("Descuento"))
            Me.txtRetencionMunicipal.EditValue = CDec(dr("RetencionMunicipal"))
            Me.txtRetencionRenta.EditValue = CDec(dr("RetencionRenta"))
            Me.txtSaldo.EditValue = CDec(dr("Saldo"))
            Me.txtPagoPosfechado.EditValue = CDec(dr("PagoChequePos"))
            lID = CInt(dr("ID"))
            TotalizaGrid()
        End If
    End Sub


    Private Sub TotalizaGrid()
        If tableData.Rows.Count > 0 Then

            txtTotalDescuento.EditValue = tableData.Compute("Sum(Descuento)", "")
            txtTotalEfectivo.EditValue = tableData.Compute("Sum(Efectivo)", "")
            txtTotalRetMunicipal.EditValue = tableData.Compute("Sum(RetencionMunicipal)", "")
            txtTotalRetRenta.EditValue = tableData.Compute("Sum(RetencionRenta)", "")
            txtTotalPosFechado.EditValue = tableData.Compute("Sum(PagoChequePos)", "")
            txtTotalRecibo.EditValue = txtTotalEfectivo.EditValue
            txtTotalAplicado.EditValue = txtTotalRecibo.EditValue + txtTotalDescuento.EditValue + txtTotalRetMunicipal.EditValue + txtTotalRetRenta.EditValue + txtTotalPosFechado.EditValue


        Else
            txtTotalDescuento.EditValue = 0
            txtTotalEfectivo.EditValue = 0
            txtTotalRetMunicipal.EditValue = 0
            txtTotalRetRenta.EditValue = 0
            txtTotalRecibo.EditValue = 0
            txtTotalAplicado.EditValue = 0
            txtTotalPosFechado.EditValue = 0
        End If

    End Sub


    Private Sub GridViewProducto_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducto.FocusedRowChanged
        CopyDataFromGridToControls()
    End Sub
    Private Sub CopyDataFromGridToControls()
        gbEdit = True
        RefreshDataFromGridToControls()
        btnAdcionar.Enabled = False
        btnEdit.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tableData.Rows.Count > 0 Then
            If MessageBox.Show("Ud va eliminar la Factura o Debito " & Me.txtFactura.EditValue.ToString() & " . Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                UpdateRowDataTable("D", lID, CInt(Me.SearchLookUpEditSucursal.EditValue), (Me.SearchLookUpEditClaseDebito.EditValue.ToString()), CInt(SearchLookUpEditSubTipoDebito.EditValue), CInt(SearchLookUpEditMonedaFactura.EditValue), _
                                   Me.txtFactura.EditValue.ToString(), CDec(txtEfectivo.EditValue), CDec(txtDescuento.EditValue), CDec(txtRetencionMunicipal.EditValue), CDec(txtRetencionRenta.EditValue), CDate(Me.DateEditFecha.EditValue), CDate(Me.DateEditVence.EditValue), _
                                    CInt(Me.txtDiasVencidos.EditValue), Me.txtchkPosNumero.EditValue.ToString(), CDec(Me.txtchkPosMonto.EditValue), CDate(Me.DateEditFechaCobro.EditValue), Me.SearchLookUpEditBanco.EditValue.ToString(), CDec(txtSaldo.EditValue), CDec(txtPagoPosfechado.EditValue))
                If tableData.Rows.Count <= 0 Then
                    btnNew.Enabled = True
                    btnAdcionar.Enabled = False
                    btnEdit.Enabled = False
                    btnEliminar.Enabled = False
                    ClearControlsForNew()
                End If
            End If

        End If
        TotalizaGrid()
    End Sub
    Private Function ControlsHeaderOk() As Boolean
        Dim lbok As Boolean
        lbok = True
        If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtIDCliente.Text IsNot Nothing Or txtNombre.Text IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditVendedor.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.DateEditFechaCredito.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If


        If Not (Me.SearchLookUpEditClaseCredito.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If



        If Not (Me.SearchLookUpEditSubTipoCredito.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If


        If Not (Me.SearchLookUpEditMoneda.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtRecibo.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If


        Return lbok
    End Function

    Private Function ControlsDetalleOk() As Boolean
        Dim lbok As Boolean
        lbok = True
        If Not (Me.SearchLookUpEditClaseDebito.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If
        If Not (Me.SearchLookUpEditSubTipoDebito.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtFactura.Text IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditMonedaFactura.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If chkPosfechado.EditValue = False And (Not (Me.txtEfectivo.EditValue IsNot Nothing) And Not (Me.txtDescuento.EditValue IsNot Nothing) And Not (Me.txtRetencionMunicipal.EditValue IsNot Nothing)) Then
            lbok = False
            Return lbok
        End If

        If chkPosfechado.EditValue = True And (Not (Me.txtPagoPosfechado.EditValue IsNot Nothing)) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.DateEditVence.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtDiasVencidos.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        Return lbok
    End Function

    Private Sub UpdateLineaGrid()
        Try
            Dim schkPosNumero As String, dChkPosMonto As Decimal, dFechaCobro As Date, iIDBanco As Decimal

            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos generales del Recibo o Crédito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not ControlsDetalleOk() Then
                MessageBox.Show("Por favor revise los datos de la Factura o Débito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Me.txtchkPosNumero.EditValue IsNot Nothing Then
                schkPosNumero = ""
            Else
                schkPosNumero = Me.txtchkPosNumero.EditValue.ToString()
            End If

            If Not Me.txtchkPosMonto.EditValue IsNot Nothing Then
                dChkPosMonto = 0
            Else
                dChkPosMonto = CDec(Me.txtchkPosMonto.EditValue)
            End If

            If Not Me.DateEditFechaCobro.EditValue IsNot Nothing Then
                dFechaCobro = CDate("19800101")
            Else
                dFechaCobro = CDate(Me.DateEditFechaCobro.EditValue)
            End If
            If Not Me.SearchLookUpEditBanco.EditValue IsNot Nothing Then
                iIDBanco = CInt(Me.SearchLookUpEditBanco.EditValue)

            End If


            UpdateRowDataTable("U", lID, CInt(Me.SearchLookUpEditSucursal.EditValue), (Me.SearchLookUpEditClaseDebito.EditValue.ToString()), CInt(SearchLookUpEditSubTipoDebito.EditValue), CInt(SearchLookUpEditMonedaFactura.EditValue), _
                               Me.txtFactura.EditValue.ToString(), CDec(txtEfectivo.EditValue), CDec(txtDescuento.EditValue), CDec(txtRetencionMunicipal.EditValue), CDec(txtRetencionRenta.EditValue), CDate(Me.DateEditFecha.EditValue), CDate(Me.DateEditVence.EditValue), _
                                CInt(Me.txtDiasVencidos.EditValue), schkPosNumero, dChkPosMonto, dFechaCobro, iIDBanco, CDec(txtSaldo.EditValue), CDec(txtPagoPosfechado.EditValue))
            If chkPosfechado.Checked Then
                If CDec(txtchkPosMonto.EditValue) < CDec(txtTotalPosFechado.EditValue) Then
                    MessageBox.Show("Por favor revise el valor del Monto del Cheque Pos Fechado al aplicar... debe ser menor o igual al valor del Cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtchkPosMonto.Focus()
                    Return
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al actualizar la linea de la factura... " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFactura_GotFocus(sender As Object, e As EventArgs) Handles txtFactura.GotFocus
        bgetDocumento = False
        Me.txtNombre.EditValue = Me.txtNombre.EditValue
    End Sub



    Private Function getDocumento() As Boolean
        Dim bExiste As Boolean = False
        Dim t As DataTable, sParametros As String, iIDDebito As Integer
        sParametros = "'D', " & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'" & Me.txtFactura.EditValue.ToString() & "', '" & gParametrosCCF.IDClaseFACRCDesglosado & "'"
        t = cManager.ExecFunction("ccfGetIDDocumentoCC", sParametros)
        iIDDebito = t.Rows(0)(0)
        If t.Rows.Count > 0 And t.Rows(0)(0) <> 0 Then
            sParametros = "'D', " & iIDDebito.ToString()
            t = cManager.ExecSPgetData("ccfGetDocumento", sParametros)
            bExiste = True
        End If

        If bExiste Then
            If CInt(t.Rows(0)("IDCliente")) <> CInt(txtIDCliente.EditValue) Then
                bExiste = False
            End If

            If bExiste Then
                If t.Rows.Count > 0 And t.Rows(0)(0) <> 0 Then
                    Me.SearchLookUpEditClaseDebito.EditValue = gParametrosCCF.IDClaseFACRCDesglosado
                    Me.SearchLookUpEditMonedaFactura.EditValue = CInt(t.Rows(0).Item("IDMoneda"))
                    Me.SearchLookUpEditSubTipoDebito.EditValue = CInt(t.Rows(0).Item("IDSubTipo"))
                    Me.txtIDDebito.EditValue = CInt(t.Rows(0).Item("IDDebito"))
                    txtSaldo.EditValue = CDec(t.Rows(0).Item("SaldoActual"))
                    Me.DateEditFecha.EditValue = CDate(t.Rows(0).Item("Fecha"))
                    Me.DateEditVence.EditValue = CDate(t.Rows(0).Item("Vencimiento"))
                    Me.txtDiasVencidos.EditValue = DateDiff(DateInterval.Day, DateEditFecha.EditValue, DateEditVence.EditValue)
                End If
            End If

        End If
        Return bExiste

    End Function
    Private Sub txtFactura_Leave(sender As Object, e As EventArgs) Handles txtFactura.Leave
        Dim bExisteDocumento As Boolean = False
        If Not (Me.SearchLookUpEditClaseDebito.EditValue IsNot Nothing) Then
            SearchLookUpEditClaseDebito.Focus()
            Exit Sub
        End If

        If Not (Me.txtFactura.EditValue IsNot Nothing) Or Me.txtFactura.EditValue = "" Then
            Me.SearchLookUpEditMonedaFactura.Focus()
            Exit Sub

        End If
        If bgetDocumento = False Then
            bExisteDocumento = getDocumento()
            bgetDocumento = True
            If bExisteDocumento = False Then
                MessageBox.Show("Ese Documento no existe... por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFactura.EditValue = ""
                txtFactura.Focus()
            Else
                txtEfectivo.Focus()
            End If

        End If

    End Sub

    Private Sub chkPosfechado_CheckedChanged(sender As Object, e As EventArgs) Handles chkPosfechado.CheckedChanged
        If chkPosfechado.Checked = True Then
            grpPosfechado.Enabled = True
            Me.txtchkPosNumero.Enabled = True
            SearchLookUpEditBanco.Enabled = True
            txtchkPosMonto.Enabled = True
            DateEditFechaCobro.Enabled = True
            ReadOnlyGrupoPosFechado(False)

            Me.txtEfectivo.EditValue = 0
            Me.txtEfectivo.Enabled = False
            txtRetencionMunicipal.EditValue = 0
            txtRetencionRenta.EditValue = 0
            Me.txtRetencionMunicipal.Enabled = True
            Me.txtRetencionRenta.Enabled = True
            txtDescuento.EditValue = 0
            Me.txtDescuento.Enabled = True
            txtPagoPosfechado.EditValue = 0
            Me.txtPagoPosfechado.Enabled = True
            Me.txtPagoPosfechado.ReadOnly = False
            Me.txtchkPosNumero.Focus()
        Else
            Me.txtchkPosNumero.Enabled = False
            SearchLookUpEditBanco.Enabled = False
            txtchkPosMonto.Enabled = False
            DateEditFechaCobro.Enabled = False
            txtPagoPosfechado.EditValue = 0
            Me.txtEfectivo.Enabled = True
            Me.txtRetencionMunicipal.Enabled = True
            Me.txtRetencionRenta.Enabled = True
            Me.txtDescuento.Enabled = True
            Me.txtPagoPosfechado.Enabled = False
        End If
    End Sub
    Private Sub InitControlsDebito()
        txtFactura.EditValue = Nothing
        SearchLookUpEditClaseDebito.EditValue = Nothing
        SearchLookUpEditSubTipoDebito.EditValue = Nothing
        SearchLookUpEditMonedaFactura.EditValue = Nothing
        txtEfectivo.EditValue = Nothing
        txtDescuento.EditValue = Nothing
        txtRetencionMunicipal.EditValue = Nothing
        txtRetencionRenta.EditValue = Nothing
        txtSaldo.EditValue = Nothing
        DateEditFecha.EditValue = Nothing
        DateEditVence.EditValue = Nothing
        txtDiasVencidos.EditValue = Nothing
    End Sub

    Private Sub InitControlsCredito()
        txtIDCliente.EditValue = Nothing
        txtNombre.EditValue = Nothing
        SearchLookUpEditClaseCredito.EditValue = Nothing
        SearchLookUpEditSubTipoCredito.EditValue = Nothing
        SearchLookUpEditMoneda.EditValue = Nothing
        Me.chkPosfechado.EditValue = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UpdateLineaGrid()
        'btnEdit.Enabled = False
    End Sub


    Private Sub SearchLookUpEditClaseCredito_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditClaseCredito.EditValueChanged
        If SearchLookUpEditClaseCredito.EditValue.ToString() <> "" Then
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipoCredito, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='C' and IDClase='" & Me.SearchLookUpEditClaseCredito.EditValue.ToString() & "'", "IDSubTipo", "Descr", "IDSubTipo")
        End If
    End Sub

    Private Sub txtEfectivo_GotFocus(sender As Object, e As EventArgs) Handles txtEfectivo.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub


    Private Sub txtEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescuento.Focus()
        End If
    End Sub

    Private Sub txtDescuento_GotFocus(sender As Object, e As EventArgs) Handles txtDescuento.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRetencionMunicipal.Focus()
        End If
    End Sub

    Private Sub txtRetencion_GotFocus(sender As Object, e As EventArgs) Handles txtRetencionMunicipal.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub


    Private Sub txtRetencion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRetencionMunicipal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRetencionRenta.Focus()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        ClearControlsForNew()
        gbEdit = False
        btnAdcionar.Enabled = True
        btnEdit.Enabled = False
        btnEliminar.Enabled = False
        txtFactura.Focus()
    End Sub
    Private Sub ClearControlsForNew()
        txtFactura.Text = ""
        txtFactura.Enabled = True
        txtFactura.ReadOnly = False
        SearchLookUpEditClaseDebito.Text = ""
        SearchLookUpEditSubTipoDebito.Text = ""
        SearchLookUpEditMonedaFactura.Text = ""
        txtPagoPosfechado.EditValue = 0
        txtEfectivo.Text = "0"
        txtDescuento.Text = "0"
        txtRetencionMunicipal.Text = "0"
        txtRetencionRenta.Text = "0"
        txtSaldo.Text = "0"
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick
        Dim storeName As String, sparameterValues As String
        Dim sSql As String
        Dim td As New DataTable
        Try
            If Not FechaEnPeriodoAbierto(CDate(Me.DateEditFechaCredito.EditValue)) Then
                MessageBox.Show("La Fecha del Documento debe estar en un Período Contable Abierto... Ud debe cambiar la Fecha o llamar al Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos generales del Recibo o Crédito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not ControlsDetalleOk() Then
                MessageBox.Show("Por favor revise los datos de la Factura o Débito, existen al menos un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsMaskOK(lsMascara, Me.txtRecibo.EditValue) Then
                MessageBox.Show("Por favor revise el valor digitado del Recibo... no coincide con la máscara " & lsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtRecibo.Focus()
                Return
            End If
            If gParametrosCCF.EditaConsecutivos = True Then
                If Not IsMaskOK(lsMascara, Me.txtRecibo.EditValue) Then
                    Me.txtRecibo.Focus()
                    Return
                Else
                    If cManager.ExistsInTable("ccfCreditos", "Documento", "Documento='" & txtRecibo.EditValue.ToString() & _
                            "' and IDClase ='" & Me.SearchLookUpEditClaseCredito.EditValue.ToString() & "' and IDSubTipo = " & _
                            Me.SearchLookUpEditSubTipoCredito.EditValue.ToString(), "IDClase, IDSubTipo") Then
                        MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End If
            End If

            storeName = "ccfUpdateccfCreditos"
            sparameterValues = "'I',"
            sparameterValues = sparameterValues & "0," & txtIDCliente.EditValue.ToString() & ","
            sparameterValues = sparameterValues & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'C','"
            sparameterValues = sparameterValues & Me.SearchLookUpEditClaseCredito.EditValue.ToString() & "',"
            sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipoCredito.EditValue.ToString() & ",'"
            sparameterValues = sparameterValues & Me.txtRecibo.EditValue.ToString() & "','"
            sparameterValues = sparameterValues & CDate(Me.DateEditFechaCredito.EditValue).ToString("yyyyMMdd") & "',"
            sparameterValues = sparameterValues & "0," 'Me.SearchLookUpEditPlazo.EditValue.ToString() & ","
            sparameterValues = sparameterValues & Me.txtTotalAplicado.EditValue.ToString() & ",'"
            sparameterValues = sparameterValues & " Generado en Modulo CxC" & "','" ' Me.txtConceptoSistemaC.EditValue.ToString() & "','"
            sparameterValues = sparameterValues & " Generado en Modulo CxC','" 'Me.MemoEditConceptoC.EditValue.ToString() & "','"
            sparameterValues = sparameterValues & txtNombre.EditValue.ToString() & "','" '"','" 'Me.txtRecibimosDe.EditValue.ToString() & "','"
            sparameterValues = sparameterValues & gsUsuario & "',"
            sparameterValues = sparameterValues & gdTipoCambio.ToString() & ","
            sparameterValues = sparameterValues & Me.SearchLookUpEditVendedor.EditValue.ToString() & ","
            sparameterValues = sparameterValues & "0," ' IIf(Me.CheckEditOrigenExternoC.Checked = True, 1, 0).ToString() & ","
            sparameterValues = sparameterValues & "0,'"  ' IIf(Me.CheckEditAprobadoC.Checked = True, 1, 0).ToString() & ",'" &
            sparameterValues = sparameterValues & lsCodigoConsecMask & "',"
            sparameterValues = sparameterValues & Me.SearchLookUpEditMoneda.EditValue.ToString() & ",0,"
            sparameterValues = sparameterValues & IIf(Me.chkPosfechado.Checked = True, 1, 0).ToString() & ","
            sparameterValues = sparameterValues & txtTotalEfectivo.EditValue.ToString() & ","
            sparameterValues = sparameterValues & txtTotalDescuento.EditValue.ToString() & ","
            sparameterValues = sparameterValues & txtTotalRetMunicipal.EditValue.ToString() & ","
            sparameterValues = sparameterValues & txtTotalRetRenta.EditValue.ToString() & ","
            sparameterValues = sparameterValues & txtTotalPosFechado.EditValue.ToString() & ",'"
            sparameterValues = sparameterValues & txtchkPosNumero.EditValue.ToString() & "',"
            sparameterValues = sparameterValues & SearchLookUpEditBanco.EditValue.ToString() & ",'"
            sparameterValues = sparameterValues & CDate(Me.DateEditFechaCredito.EditValue).ToString("yyyyMMdd") & "'," & Me.txtchkPosMonto.EditValue.ToString()
            'td = cManager.ExecSPgetData(storeName, sparameterValues)
            'If td.Rows.Count > 0 Then
            '    Me.txtIDCredito.EditValue = td.Rows(0)(0).ToString()
            'End If

            sSql = cManager.CreateStoreProcSql("ccfUpdateccfCreditos", sparameterValues)
            Dim clase As New CbatchSQLIitem(sSql, True, False, True, False, "ccfUpdateccfCreditos", "ccfUpdateccfCreditos")
            cManager.batchSQLLista.Clear()
            cManager.batchSQLLista.Add(clase)
            cManager.batchSQLitem.Clear()
            cManager.batchSQLitem.Add(sSql)

            ' para guardar las aplicaciones 
            Dim dt As New DataTable

            If tableData.Rows.Count > 0 Then
                dt.Columns.Add("IDCredito")
                dt.Columns.Add("IDDebito")
                dt.Columns.Add("Pago")
                dt.Columns.Add("Efectivo")
                dt.Columns.Add("Descuento")
                dt.Columns.Add("RetencionMunicipal")
                dt.Columns.Add("RetencionRenta")
                dt.Columns.Add("MontoChequePos")
                dt.Columns.Add("flgFlotante")
                Dim strCriteria As String = "Aplicado > 0"
                Dim drSelect As DataRow() = tableData.Select(strCriteria)
                If drSelect.Length > 0 Then
                    For Each row As DataRow In drSelect
                        sparameterValues = "'I', " & row("IDDebito").ToString() & ",@@Identity,"
                        sparameterValues = sparameterValues & Math.Round(CDec(row("Aplicado")), 4).ToString() & ",'" & gsUsuario & "',"
                        sparameterValues = sparameterValues & gdTipoCambio.ToString() & "," & IIf(chkPosfechado.Checked = True, 1, 0).ToString() & ","
                        sparameterValues = sparameterValues & Math.Round(CDec(row("Efectivo")), 4).ToString() & "," & Math.Round(CDec(row("Descuento")), 4).ToString() & ","
                        sparameterValues = sparameterValues & Math.Round(CDec(row("RetencionMunicipal")), 4).ToString() & ", " & Math.Round(CDec(row("RetencionRenta")), 4).ToString() & "," & "0," & Math.Round(CDec(row("MontoChequePos")), 4).ToString()

                        sSql = cManager.CreateStoreProcSql("ccfUpdateAplicaciones", sparameterValues)
                        clase = New CbatchSQLIitem(sSql, False, True, False, True, "ccfUpdateAplicaciones", "ccfUpdateAplicaciones")

                        cManager.batchSQLitem.Add(sSql)
                        cManager.batchSQLLista.Add(clase)

                        Dim r As DataRow = dt.NewRow
                        r("IDCredito") = CInt(txtIDCredito.EditValue)
                        r("IDDebito") = row("IDDebito")
                        r("Pago") = Math.Round(CDec(row("Aplicado")), 4)
                        r("Efectivo") = Math.Round(CDec(row("Efectivo")), 4)
                        r("Descuento") = Math.Round(CDec(row("Descuento")), 4)
                        r("RetencionMunicipal") = Math.Round(CDec(row("RetencionMunicipal")), 4)
                        r("RetencionRenta") = Math.Round(CDec(row("RetencionRenta")), 4)
                        r("MontoChequePos") = Math.Round(CDec(row("MontoChequePos")), 4)
                        r("flgFlotante") = IIf(chkPosfechado.Checked = True, 1, 0)
                        dt.Rows.Add(r)
                    Next
                End If
            End If
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("No se puede realizar la aplicacion porque no existen pagos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            ' Ejecutar con table como parametro ... lo voy a quietar por cambio 
            'If cManager.ExecAplicaRecibo("ccfAplicaCredito", dt, gsUsuario, gdTipoCambio, IIf(Me.chkPosfechado.Checked = True, 1, 0)) Then
            '    lbok = True
            '    MessageBox.Show("Los Debitos han sido aplicados  exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'End If
            If cManager.ExecCmdWithTransaction() Then

                If MessageBox.Show("El Recibo de Caja ha sido Guardado Exitosamente con sus Aplicaciones, Ud desea Crear otro Recibo de Caja ?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    CrearallControlsForNewRC()
                    btnAdcionar.Enabled = True
                    gbEdit = False
                    cManager.batchSQLitem.Clear()
                    cManager.batchSQLLista.Clear()
                    txtTotalDescuento.EditValue = 0
                    txtTotalEfectivo.EditValue = 0
                    txtTotalRetMunicipal.EditValue = 0
                    txtTotalRetRenta.EditValue = 0
                    txtTotalRecibo.EditValue = 0
                    txtTotalAplicado.EditValue = 0
                    txtTotalPosFechado.EditValue = 0
                Else
                    Me.Close()
                End If


            End If


            'MessageBox.Show("El registro ha sido guardado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Error al guardar el Recibo " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub DateEditFechaCredito_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFechaCredito.EditValueChanged
        gdTipoCambio = getTipoCambio(Me.DateEditFechaCredito.EditValue, gParametros.TipoCambioFact)
        If Not DateEditFechaCredito.EditValue Is Nothing Then
            If Not FechaEnPeriodoAbierto(CDate(Me.DateEditFechaCredito.EditValue)) Then
                MessageBox.Show("La Fecha del Documento debe estar en un Período Contable Abierto... Ud debe cambiar la Fecha o llamar al Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
    End Sub

    Private Sub txtchkPosMonto_EditValueChanged(sender As Object, e As EventArgs) Handles txtchkPosMonto.EditValueChanged

    End Sub

    Private Sub txtchkPosMonto_GotFocus(sender As Object, e As EventArgs) Handles txtchkPosMonto.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub


    Private Sub txtSaldo_GotFocus(sender As Object, e As EventArgs) Handles txtSaldo.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub

    Private Sub txtPagoPosfechado_GotFocus(sender As Object, e As EventArgs) Handles txtPagoPosfechado.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub

    Private Sub txtchkPosNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtchkPosNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchLookUpEditBanco.Text = ""
            SearchLookUpEditBanco.Focus()
        End If
    End Sub

    Private Sub SearchLookUpEditBanco_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditBanco.EditValueChanged
        Try
            Dim td As DataTable
            Dim sParameters As String
            If SearchLookUpEditBanco.Text <> "" And Me.txtchkPosNumero.EditValue.ToString() <> "" And txtIDCliente.EditValue.ToString() <> "" Then
                sParameters = "'" & Me.txtchkPosNumero.EditValue.ToString() & "'," & SearchLookUpEditBanco.EditValue.ToString() & ",0," & txtIDCliente.EditValue.ToString()
                td = cManager.ExecFunction("ccfgetMontoSaldoChequePos", sParameters)
                If td.Rows.Count > 0 Then
                    If CDec(td.Rows(0)(0)) = 0 Then
                        txtchkPosMonto.Focus()
                    Else
                        txtchkPosMonto.EditValue = CDec(td.Rows(0)(0))
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al consultar el saldo del Cheque " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtchkPosMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtchkPosMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateEditFechaCobro.Focus()
        End If
    End Sub

    Private Sub DateEditFechaCobro_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFechaCobro.EditValueChanged
        If Me.DateEditFechaCobro.EditValue Is Nothing Then
            Exit Sub
        End If
        If chkPosfechado.Checked Then
            If DateTime.Compare(CDate(Me.DateEditFechaCredito.EditValue), CDate(Me.DateEditFechaCobro.EditValue)) > 0 Then
                MessageBox.Show("La Fecha de Cobro no puede ser menor que la fecha del Recibo ", "Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DateEditFechaCobro.EditValue = DateEditFechaCredito.EditValue
            End If
            txtFactura.Focus()

        End If
    End Sub


    Private Sub txtPagoPosfechado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPagoPosfechado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If gbEdit = False Then
                btnAdcionar.Focus()
            Else
                btnEdit.Focus()
            End If
        End If
    End Sub



    Private Sub BarButtonItemNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNew.ItemClick
        CrearallControlsForNewRC()
    End Sub
    Private Sub CrearallControlsForNewRC()
        ClearControlsForNew()
        gbEdit = False
        btnAdcionar.Enabled = True
        btnEdit.Enabled = False
        btnEliminar.Enabled = False
        Me.txtIDCliente.Text = ""
        Me.txtNombre.Text = ""
        SearchLookUpEditVendedor.Text = ""
        SearchLookUpEditMoneda.Text = ""
        SearchLookUpEditSubTipoCredito.Text = ""
        txtRecibo.Text = ""
        chkPosfechado.Checked = False
        txtchkPosNumero.Text = ""
        SearchLookUpEditBanco.Text = ""
        txtchkPosMonto.Text = ""
        DateEditFecha.EditValue = Nothing
        DateEditVence.EditValue = Nothing
        txtTotalPosFechado.Text = ""
        txtTotalAplicado.Text = ""
        txtIDDebito.Text = ""
        DateEditFechaCobro.EditValue = Nothing
        tableData.Clear()
        datagrid.DataSource = Nothing
        ReadOnlyGrupoRecibo(False)

    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Dim frm As New frmCCFpopupFacturas()
        frm.gsIDCliente = txtIDCliente.EditValue.ToString()
        frm.ShowDialog()
        If frm.gsFactura <> "" Then
            Me.txtFactura.EditValue = frm.gsFactura
            Me.SearchLookUpEditClaseDebito.EditValue = frm.gsIDClase
            Me.SearchLookUpEditMonedaFactura.EditValue = frm.giIDMoneda
            Me.SearchLookUpEditSubTipoDebito.EditValue = frm.giIDSubtipo
            Me.txtIDDebito.EditValue = frm.giIDDebito
            txtSaldo.EditValue = frm.gdSaldo
            If txtSaldo.EditValue <= (txtchkPosMonto.EditValue - txtTotalPosFechado.EditValue) Then
                txtPagoPosfechado.EditValue = txtSaldo.EditValue
            Else
                txtPagoPosfechado.EditValue = (txtchkPosMonto.EditValue - txtTotalPosFechado.EditValue)
            End If
            Me.DateEditFecha.EditValue = frm.gdFecha
            Me.DateEditVence.EditValue = frm.gdFechaVencimiento
            Me.txtDiasVencidos.EditValue = frm.giDiasVencidos
            ' Dim lbok As Boolean = getDocumento()

        End If
        frm.Dispose()

    End Sub


    Private Sub txtRetencionRenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRetencionRenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.chkPosfechado.Checked = False Then
                btnAdcionar.Focus()
            Else
                txtPagoPosfechado.Focus()
            End If

        End If
    End Sub


    Private Sub txtchkPosNumero_Leave(sender As Object, e As EventArgs) Handles txtchkPosNumero.Leave
        SearchLookUpEditBanco.Text = ""
        SearchLookUpEditBanco.Focus()
    End Sub
End Class