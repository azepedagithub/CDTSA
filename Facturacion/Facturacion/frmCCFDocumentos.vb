Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Public Class frmCPDocumentos
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
    Dim gsConsecutivoAnteriorD As String
    Dim gsConsecutivoDigitadoD As String
    Dim gsConsecutivoAnteriorC As String
    Dim gsConsecutivoDigitadoC As String

    Private Property frm As Object

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        CallPopUpClientes()
        If rbCreditos.Checked Then
            Me.txtRecibimosDe.EditValue = Me.txtNombre.Text
        End If
    End Sub
    Private Sub CalculaFechaVencimiento()
        Me.DateEditVencimiento.EditValue = DateAdd(DateInterval.Day, CDbl(Me.SearchLookUpEditPlazo.EditValue), Me.DateEditFecha.EditValue)
        Me.DateEditVencimiento.Refresh()
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
                Me.txtFarmacia.EditValue = frm.gsFarmacia
                Me.SearchLookUpEditVendedor.EditValue = CInt(frm.gsVendedor)
                gIDPlazo = CInt(frm.gsPlazo)
                Me.SearchLookUpEditPlazo.EditValue = gIDPlazo


                CalculaFechaVencimiento()
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCCFDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not CargaParametros() Then
                MessageBox.Show("Ha ocurrido un error al cargar los Parametros de Facturacion...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            If Not CargaParametrosCCF() Then
                MessageBox.Show("Ha ocurrido un error al cargar los Parametros de Cartera...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            CargagridLookUpsFromTables()

            If gbEdit = True Then
                gsTipoDocumento = gsTipoDocumento
                giIDDocumento = giIDDocumento

            End If
            Me.SearchLookUpEditSucursal.EditValue = CInt(gsSucursal)
            If gParametrosCCF.UnaSolaMoneda = True Then
                SearchLookUpEditMoneda.EditValue = gParametrosCCF.IDMonedaUnica
                SearchLookUpEditMonedaC.EditValue = gParametrosCCF.IDMonedaUnica
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
            Me.txtRecibimosDe.ReadOnly = True
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
            Me.txtRecibimosDe.ReadOnly = False
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
        'Me.txtDocumento.ReadOnly = bReadonly
        'Me.txtDocumentoC.ReadOnly = bReadonly
        Me.txtID.ReadOnly = True
        Me.txtIDC.ReadOnly = True
        Me.txtIDCliente.ReadOnly = bReadonly
        Me.txtNombre.ReadOnly = bReadonly
        Me.txtRecibimosDe.ReadOnly = bReadonly
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldoC.ReadOnly = True
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuarioC.ReadOnly = True
        Me.SearchLookUpEditSucursal.ReadOnly = bReadonly
        Me.SearchLookUpEditClase.ReadOnly = bReadonly
        Me.SearchLookUpEditClaseD.ReadOnly = bReadonly
        Me.SearchLookUpEditMoneda.ReadOnly = bReadonly
        Me.SearchLookUpEditMonedaC.ReadOnly = bReadonly

        Me.SearchLookUpEditSubTipo.ReadOnly = bReadonly
        Me.SearchLookUpEditSubTipoD.ReadOnly = bReadonly
        Me.SearchLookUpEditPlazo.ReadOnly = bReadonly
        Me.SearchLookUpEditVendedor.ReadOnly = bReadonly
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
        Me.txtRecibimosDe.ReadOnly = False

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
        If gParametrosCCF.EditaConsecutivos = True Then
            txtDocumento.ReadOnly = False
            txtDocumentoC.ReadOnly = False
        Else
            txtDocumento.ReadOnly = True
            txtDocumentoC.ReadOnly = True
        End If
        Me.txtID.Text = ""
        txtID.ReadOnly = True
        Me.txtIDC.Text = ""
        Me.txtIDC.ReadOnly = True
        Me.txtID.ReadOnly = True

        Me.txtIDCliente.Text = ""
        Me.txtNombre.Text = ""
        Me.txtNombre.ReadOnly = True
        Me.txtRecibimosDe.Text = ""
        Me.txtSaldo.Text = ""
        Me.txtSaldoC.Text = ""
        Me.txtUsuario.Text = ""
        Me.txtUsuarioC.Text = ""
        Me.SearchLookUpEditClase.Text = ""
        Me.SearchLookUpEditClaseD.Text = ""
        Me.SearchLookUpEditSubTipo.Text = ""
        Me.SearchLookUpEditSubTipoD.Text = ""
        If gParametrosCCF.UnaSolaMoneda = False Then
            Me.SearchLookUpEditMoneda.Text = ""
            Me.SearchLookUpEditMonedaC.Text = ""

        End If
        Me.SearchLookUpEditPlazo.Text = ""
        Me.SearchLookUpEditVendedor.Text = ""
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
    End Sub

    Sub CargaControlsFromOneRegister()
        Dim spParameters As String
        spParameters = "'" & gsTipoDocumento & "'," & giIDDocumento.ToString()
        tableData = cManager.ExecSPgetData("ccfGetDocumento", spParameters)
        Me.SearchLookUpEditSucursal.EditValue = CInt(tableData.Rows(0).Item("IDBodega"))


        Me.txtIDCliente.EditValue = tableData.Rows(0).Item("IDCliente").ToString()
        Me.txtIDCliente.Enabled = False
        Me.txtNombre.EditValue = tableData.Rows(0).Item("Nombre").ToString()
        Me.SearchLookUpEditVendedor.EditValue = CInt(tableData.Rows(0).Item("IDVendedor"))
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
            Dim td As New DataTable
            Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipoD.EditValue.ToString())
            If sCodigoMask <> "" Then
                sCodigoMask = "'" & sCodigoMask & "'"
                td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
                gsMascara = td.Rows(0)(0)
            Else
                gsMascara = ""
            End If
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
            Dim td As New DataTable
            Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipo.EditValue.ToString())
            If sCodigoMask <> "" Then
                sCodigoMask = "'" & sCodigoMask & "'"
                td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
                gsMascara = td.Rows(0)(0)
            Else
                gsMascara = ""
            End If

        End If

    End Sub

    Private Function getCodigoConsecMaskSubTipo(spIDSubTipo As String) As String
        Dim td As New DataTable
        Dim sCodigoMask As String = ""
        Dim cManager As New Clases.ClassManager
        td = cManager.ExecSPgetData("ccfgetSubTipo", spIDSubTipo)
        If td.Rows.Count > 0 Then
            sCodigoMask = td.Rows(0)("CodigoConsecMask")
        End If
        Return sCodigoMask
    End Function

    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='C' and IDClase <>'" & gParametrosCCF.IDClaseRCDesglosado & "'", "Orden", "IDClase", "IDClase")
        SearchLookUpEditClase.Text = ""
        'CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='C'", "IDSubTipo", "Descr", "IDSubTipo")
        'CargagridSearchLookUp(Me.SearchLookUpEditSubTipoD, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='D'", "IDSubTipo", "Descr", "IDSubTipo")
        CargagridSearchLookUp(Me.SearchLookUpEditClaseD, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='D'", "Orden", "IDClase", "IDClase")
        Me.SearchLookUpEditClaseD.Text = ""
        If gParametrosCCF.UnaSolaMoneda = True Then
            CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr", "Activo=1 and IDMoneda=" & gParametrosCCF.IDMonedaUnica.ToString(), "IDMoneda", "Descr", "IDMoneda")
            CargagridSearchLookUp(Me.SearchLookUpEditMonedaC, "globalMoneda", "IDMoneda, Descr", "Activo=1 and IDMoneda=" & gParametrosCCF.IDMonedaUnica.ToString(), "IDMoneda", "Descr", "IDMoneda")

        Else
            CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")
            CargagridSearchLookUp(Me.SearchLookUpEditMonedaC, "globalMoneda", "IDMoneda, Descr", "Activo=1", "IDMoneda", "Descr", "IDMoneda")

        End If

        CargagridSearchLookUp(Me.SearchLookUpEditPlazo, "ccfPlazo", "Plazo, Descr, Activo", "", "Plazo", "Descr", "Plazo")
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
        If rbCreditos.Checked Then
            Me.txtRecibimosDe.EditValue = Me.txtNombre.Text
        End If
    End Sub

    Private Sub SearchLookUpEditPlazo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditPlazo.EditValueChanged
        If Me.SearchLookUpEditPlazo.EditValue IsNot Nothing Then
            Me.SearchLookUpEditPlazo.EditValue = gIDPlazo
            CalculaFechaVencimiento()
        End If

    End Sub

    Private Sub DateEditFecha_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFecha.EditValueChanged
        CalculaFechaVencimiento()
        gdTipoCambio = getTipoCambio(Me.DateEditFecha.EditValue, gParametros.TipoCambioFact)
        If gbAdd Then
            If Not DateEditFecha.EditValue Is Nothing Then
                If Not FechaEnPeriodoAbierto(CDate(Me.DateEditFecha.EditValue)) Then
                    MessageBox.Show("La Fecha del Documento debe estar en un Período Contable Abierto... Ud debe cambiar la Fecha o llamar al Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

            End If

        End If
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
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipoD, "ccfSubTipoDocumento", "IDSubTipo, Descr", sWhere, "IDSubTipo", "Descr", "IDSubTipo")
        End If
    End Sub

    Private Sub SearchLookUpEditClase_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditClase.EditValueChanged
        Dim sClase As String
        Dim sWhere As String
        If Me.SearchLookUpEditClase.Text <> "" Then
            sClase = "'" + Me.SearchLookUpEditClase.EditValue.ToString() + "'"
            sWhere = "TipoDocumento='C' and IDClase = " + sClase
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", sWhere, "IDSubTipo", "Descr", "IDSubTipo")
            Me.txtRecibimosDe.EditValue = Me.txtNombre.Text
        End If
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
        If rbDebitos.Checked = True Then
            Me.txtDocumento.EditValue = td.Rows(0)(0)
            gsConsecutivoAnteriorD = txtDocumento.EditValue
        Else
            Me.txtDocumentoC.EditValue = td.Rows(0)(0)
            gsConsecutivoAnteriorC = txtDocumentoC.EditValue
        End If
        td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
        gsMascara = td.Rows(0)(0)
        Return lsCodigoConsecMask
    End Function

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
                    gsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)
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
                If sIDClase <> "" And sIDSubTipo <> "" Then
                    gsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)
                    rbCreditos.Enabled = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function ControlsOk() As Boolean
        Dim lbok As Boolean = True
        Dim sDocumento As String
        Dim sWhere As String

        If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
            SearchLookUpEditSucursal.Focus()
            lbok = False
            Return lbok

        End If
        If Me.txtIDCliente.Text = "" Or Not (Me.txtIDCliente.EditValue IsNot Nothing Or txtNombre.EditValue IsNot Nothing) Then
            txtIDCliente.Focus()
            lbok = False
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lbok

        End If
        If Not (Me.SearchLookUpEditVendedor.EditValue IsNot Nothing) Then
            lbok = False
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchLookUpEditVendedor.Focus()
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
            Dim td As New DataTable
            Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipoD.EditValue.ToString())
            If sCodigoMask <> "" Then
                sCodigoMask = "'" & sCodigoMask & "'"
                td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
                gsMascara = td.Rows(0)(0)
            Else
                gsMascara = ""
                lbok = False
                Return lbok
            End If

            sDocumento = Me.txtDocumento.EditValue.ToString()
            If Not IsMaskOK(gsMascara, sDocumento) Then
                Me.txtDocumento.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento,  El Consecutivo debe Cumplir con la Máscara : " & gsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If gbAdd Then
                sWhere = "IDBodega=" & Me.SearchLookUpEditSucursal.EditValue.ToString() & " and IDClase='" & Me.SearchLookUpEditClaseD.EditValue.ToString() & "'" & _
                    " and Documento ='" & sDocumento & "'"
                If cManager.ExistsInTable("ccfDebitos", "Documento", sWhere, "Documento") Then
                    MessageBox.Show("Por favor revise los datos del Documento, esa Debito ya Existe en la base de datos para ese Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lbok = False
                    Return lbok
                End If

            End If
        Else

            If Not (Me.SearchLookUpEditClase.EditValue IsNot Nothing) Then
                SearchLookUpEditClase.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Clase de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            If Not (Me.SearchLookUpEditSubTipo.EditValue IsNot Nothing) Then
                SearchLookUpEditSubTipo.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un SubTipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If

            If Not (Me.SearchLookUpEditMonedaC.EditValue IsNot Nothing) Then
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

            If Val(txtMontoC.Text) <= 0 Then
                txtMontoC.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            Dim td As New DataTable
            Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(SearchLookUpEditSubTipo.EditValue.ToString())
            If sCodigoMask <> "" Then
                sCodigoMask = "'" & sCodigoMask & "'"
                td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
                gsMascara = td.Rows(0)(0)
            Else
                gsMascara = ""
            End If

            sDocumento = Me.txtDocumentoC.EditValue.ToString()
            If Not IsMaskOK(gsMascara, sDocumento) Then
                Me.txtDocumentoC.Focus()
                lbok = False
                MessageBox.Show("Por favor revise los datos del Documento, El Consecutivo debe Cumplir con la Máscara : " & gsMascara, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return lbok
            End If
            sWhere = "IDBodega=" & Me.SearchLookUpEditSucursal.EditValue.ToString() & " and IDClase='" & Me.SearchLookUpEditClase.EditValue.ToString() & "'" & _
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

                    If Not FechaEnPeriodoAbierto(CDate(Me.DateEditFecha.EditValue)) Then
                        MessageBox.Show("La Fecha del Documento debe estar en un Período Contable Abierto... Ud debe cambiar la Fecha o llamar al Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If gParametrosCCF.EditaConsecutivos = True Then
                        If Not IsMaskOK(gsMascara, Me.txtDocumento.EditValue) Then
                            Me.txtDocumento.Focus()
                            Exit Sub
                        Else
                            If gbAdd Then
                                If cManager.ExistsInTable("ccfDebitos", "Documento", "Documento='" & txtDocumento.EditValue.ToString() & _
                                        "' and IDClase ='" & Me.SearchLookUpEditClaseD.EditValue.ToString() & "' and IDSubTipo = " & _
                                        Me.SearchLookUpEditSubTipoD.EditValue.ToString(), "IDClase, IDSubTipo") Then
                                    MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If

                            End If
                        End If
                    End If


                    storeName = "ccfUpdateccfDebitos"
                    sparameterValues = IIf(gbAdd = True, "'I',", "'U',")
                    sparameterValues = sparameterValues & "0," & txtIDCliente.EditValue.ToString() & ","
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'D','"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClaseD.EditValue.ToString() & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipoD.EditValue.ToString() & ",'"
                    sparameterValues = sparameterValues & Me.txtDocumento.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditPlazo.EditValue.ToString() & ","
                    sparameterValues = sparameterValues & Me.txtMonto.EditValue.ToString() & ",0,'"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClaseD.EditValue.ToString() & " : " & txtDocumento.Text & " Cliente " & Me.txtNombre.EditValue.ToString() & " Generado en CXC" & "','"
                    sparameterValues = sparameterValues & Me.MemoEditConcepto.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & gsUsuario & "',"
                    sparameterValues = sparameterValues & gdTipoCambio.ToString() & ","
                    sparameterValues = sparameterValues & Me.SearchLookUpEditVendedor.EditValue.ToString() & ","
                    sparameterValues = sparameterValues & IIf(Me.CheckEditOrigenExterno.Checked = True, 1, 0).ToString() & ","
                    sparameterValues = sparameterValues & IIf(Me.CheckEditAprobado.Checked = True, 1, 0).ToString() & ",'"
                    sparameterValues = sparameterValues & gsCodigoConsecMask & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditMoneda.EditValue.ToString()

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
                    If Not FechaEnPeriodoAbierto(CDate(Me.DateEditFechaC.EditValue)) Then
                        MessageBox.Show("La Fecha del Documento debe estar en un Período Contable Abierto... Ud debe cambiar la Fecha o llamar al Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If gParametrosCCF.EditaConsecutivos = True Then
                        If Not IsMaskOK(gsMascara, Me.txtDocumentoC.EditValue) Then
                            Me.txtDocumentoC.Focus()
                            Return
                        Else
                            If cManager.ExistsInTable("ccfCreditos", "Documento", "Documento='" & txtDocumentoC.EditValue.ToString() & _
                                    "' and IDClase ='" & Me.SearchLookUpEditClase.EditValue.ToString() & "' and IDSubTipo = " & _
                                    Me.SearchLookUpEditSubTipo.EditValue.ToString(), "IDClase, IDSubTipo") Then
                                MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End If
                    End If
                End If
                storeName = "ccfUpdateccfCreditos"
                sparameterValues = IIf(gbAdd = True, "'I',", "'U',")
                sparameterValues = sparameterValues & "0," & txtIDCliente.EditValue.ToString() & ","
                sparameterValues = sparameterValues & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'C','"
                sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & "',"
                sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipo.EditValue.ToString() & ",'"
                sparameterValues = sparameterValues & Me.txtDocumentoC.EditValue.ToString() & "','"
                sparameterValues = sparameterValues & CDate(Me.DateEditFechaC.EditValue).ToString("yyyyMMdd") & "',"
                sparameterValues = sparameterValues & Me.SearchLookUpEditPlazo.EditValue.ToString() & ","
                sparameterValues = sparameterValues & Me.txtMontoC.EditValue.ToString() & ",'"
                sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & " : " & txtDocumentoC.Text & " Cliente " & txtIDCliente.Text & " " & Me.txtNombre.EditValue.ToString() & " Generado en CXC" & "','"
                sparameterValues = sparameterValues & Me.MemoEditConceptoC.EditValue.ToString() & "','"
                sparameterValues = sparameterValues & Me.txtRecibimosDe.EditValue.ToString() & "','"
                sparameterValues = sparameterValues & gsUsuario & "',"
                sparameterValues = sparameterValues & gdTipoCambio.ToString() & ","
                sparameterValues = sparameterValues & Me.SearchLookUpEditVendedor.EditValue.ToString() & ","
                sparameterValues = sparameterValues & IIf(Me.CheckEditOrigenExternoC.Checked = True, 1, 0).ToString() & ","
                sparameterValues = sparameterValues & IIf(Me.CheckEditAprobadoC.Checked = True, 1, 0).ToString() & ",'" & gsCodigoConsecMask & "',"
                sparameterValues = sparameterValues & Me.SearchLookUpEditMonedaC.EditValue.ToString()

                td = cManager.ExecSPgetData(storeName, sparameterValues)
                If td.Rows.Count > 0 Then
                    If gbAdd Then
                        Me.txtIDC.EditValue = td.Rows(0)(0).ToString()
                    End If
                    gbAdd = False
                    gsTipoDocumento = "C"
                    giIDDocumento = Me.txtIDC.EditValue
                    gbEdit = True
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
        gdTipoCambio = getTipoCambio(Me.DateEditFechaC.EditValue, gParametros.TipoCambioFact)
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
                If Not cManager.ExecSP("ccfAprobarDocumento", sParametros) Then
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
                If Not cManager.ExecSP("ccfAprobarDocumento", sParametros) Then
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
            If Me.chkAnulado.Checked = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.CheckEditAprobado.Checked = False Then
                MessageBox.Show("No se puede Aplicar Documento que no ha sido Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
  
        End If

        If gsTipoDocumento = "C" Then
            If Me.CheckEditAprobadoC.Checked = False Then
                MessageBox.Show("No se puede Aplicar Documento que no ha sido Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Me.chkAnuladoC.Checked = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        End If


        Dim frm As New frmCCFAplicaCreditos()
        frm.gbAplicar = True
        If gsTipoDocumento = "C" Then

            frm.gbAplicar = True
            frm.gsClase = Me.SearchLookUpEditClase.EditValue.ToString()
            frm.gIDCliente = Me.txtIDCliente.EditValue.ToString()
            frm.gsNombre = Me.txtNombre.EditValue.ToString()
            frm.gIDCredito = Me.txtIDC.EditValue.ToString()
            frm.gdMontoOriginal = CDec(Me.txtMontoC.EditValue)
            frm.gdSaldo = CDec(txtSaldoC.EditValue)
            frm.gdFecha = Me.DateEditFechaC.EditValue
            frm.gsDocumento = Me.txtDocumentoC.EditValue.ToString()
            frm.gsMoneda = Me.SearchLookUpEditMonedaC.Text
            frm.gIDMoneda = Me.SearchLookUpEditMonedaC.EditValue.ToString()
            frm.gdTipoCambio = gdTipoCambio

            frm.ShowDialog()
            Me.txtSaldoC.EditValue = frm.txtSaldoOriginal.EditValue
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
                td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If Not cManager.ExecSP("ccfAnularDocumento", sParametros) Then
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
                td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If


                If Not cManager.ExecSP("ccfAnularDocumento", sParametros) Then

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
        Dim sMensaje As String
        If Not IsMaskOK(gsMascara, Me.txtDocumentoC.EditValue) Then
            Me.txtDocumentoC.Focus()
            Return
        End If
        If gParametrosCCF.EditaConsecutivos Then
            gsConsecutivoDigitadoC = txtDocumentoC.EditValue.ToString()
            Dim i As Int32 = CountBetweenConsecutivos(gsMascara, gsConsecutivoAnteriorC, gsConsecutivoDigitadoC)
            If i > 1 Or i < 0 Then
                sMensaje = "Ud digita un consecutivo que no corresponde al siguiente. El siguiente es " & gsConsecutivoAnteriorC & " y digito " & gsConsecutivoDigitadoC & " Hay una diferencia de " & i.ToString() & " Numeros "
                If MessageBox.Show(sMensaje & ". Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbNo Then
                    txtDocumentoC.EditValue = gsConsecutivoAnteriorC
                End If
            End If
        End If
    End Sub

    Private Sub txtDocumento_Leave(sender As Object, e As EventArgs) Handles txtDocumento.Leave
        Dim sMensaje As String
        If Not IsMaskOK(gsMascara, Me.txtDocumento.EditValue) Then
            Me.txtDocumento.Focus()
            Return
        End If
        If gParametrosCCF.EditaConsecutivos Then
            gsConsecutivoDigitadoD = txtDocumento.EditValue.ToString()
            Dim i As Int32 = CountBetweenConsecutivos(gsMascara, gsConsecutivoAnteriorD, gsConsecutivoDigitadoD)
            If i > 1 Or i < 0 Then
                sMensaje = "Ud digita un consecutivo que no corresponde al siguiente. El siguiente es " & gsConsecutivoAnteriorD & " y digito " & gsConsecutivoDigitadoD & " Hay una diferencia de " & i.ToString() & " Numeros "
                If MessageBox.Show(sMensaje & ". Esta de Acuerdo ? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbNo Then
                    txtDocumento.EditValue = gsConsecutivoAnteriorD
                End If
            End If
        End If

    End Sub

    Private Sub txtMontoC_LostFocus(sender As Object, e As EventArgs) Handles txtMontoC.LostFocus
        txtSaldoC.EditValue = txtMontoC.EditValue
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

End Class