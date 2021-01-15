Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Public Class frmCCFCreaDocAnulado
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim lIDVendedor As Integer
    Private Sub frmCCFCreaDocAnulado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CargaParametrosCCF() Then
            MessageBox.Show("Ha ocurrido un error al cargar los parámetros de CxC, llame al administrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "IDBodega=" & gsSucursal, "IDBodega", "Descr", "IDBodega")
        Me.SearchLookUpEditSucursal.EditValue = gsSucursal
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='D'", "Orden", "IDClase", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr, Activo", "", "IDMoneda", "Descr", "IDMoneda")
    End Sub

    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit 'DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        g.Properties.PopupFormSize = New Size(250, 250)
        g.Properties.NullText = ""
    End Sub

    Private Sub rbDebitos_CheckedChanged(sender As Object, e As EventArgs) Handles rbDebitos.CheckedChanged
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='D'", "Orden", "IDClase", "IDClase")
    End Sub

    Private Sub rbCreditos_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditos.CheckedChanged
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 and TipoDocumento='C'", "Orden", "IDClase", "IDClase")
    End Sub

    Private Sub SearchLookUpEditClase_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditClase.EditValueChanged
        If Me.SearchLookUpEditClase.Text <> "" Then
            If Me.rbDebitos.Checked = True Then
                CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='D' and IDClase ='" & Me.SearchLookUpEditClase.Text & "'", "IDSubTipo", "Descr", "IDSubTipo")
            End If
            If Me.rbCreditos.Checked = True Then
                CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='C' and IDClase ='" & Me.SearchLookUpEditClase.Text & "'", "IDSubTipo", "Descr", "IDSubTipo")
            End If

        End If

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
                lIDVendedor = CInt(frm.gsVendedor)
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        CallPopUpClientes()
    End Sub

    Private Sub SearchLookUpEditSubTipo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipo.EditValueChanged
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
            lblMascara.Text = getMascaraSubTipo(sIDClase, sIDSubTipo)
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

    Private Function getMascaraSubTipo(spIDClase As String, spIDSubTipo As String) As String

        Dim td As New DataTable
        Dim lsMascara As String
        Dim sCodigoMask As String = getCodigoConsecMaskSubTipo(spIDSubTipo)
        If sCodigoMask <> "" Then
            sCodigoMask = "'" & sCodigoMask & "'"
            td = cManager.ExecFunction("getMascaraFromConsecMask", sCodigoMask)
            lsMascara = td.Rows(0)(0)
        Else
            lsMascara = ""
        End If
        Return lsMascara
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim sTable As String
            Dim storeName As String
            Dim sparameterValues As String
            Dim sTipoDocumento As String

            If Me.txtIDCliente.Text = "" Then
                MessageBox.Show("Se debe indicar el Cliente para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Me.SearchLookUpEditSucursal.Text = "" Then
                MessageBox.Show("Se debe indicar la sucursal para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Me.SearchLookUpEditClase.Text = "" Then
                MessageBox.Show("Se debe indicar la Clase de Documento para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Me.SearchLookUpEditSubTipo.Text = "" Then
                MessageBox.Show("Se debe indicar el subtipo de Documento para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Me.SearchLookUpEditMoneda.Text = "" Then
                MessageBox.Show("Se debe indicar la moneda del Documento para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then

                MessageBox.Show("Se debe indicar la fecha de la anulación para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If lblMascara.Text = "" Then
                MessageBox.Show("No existe una máscara para ese subtipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If txtDocumento.Text = "" Then
                MessageBox.Show("Tiene que digitar el Documento, no puede quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsMaskOK(lblMascara.Text, txtDocumento.Text) Then
                Me.txtDocumento.Focus()
                MessageBox.Show("Por favor revise el Documento,  El Numero debe Cumplir con la Máscara : " & lblMascara.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            ' aqui lo guardo
            If Not IsMaskOK(lblMascara.Text, Me.txtDocumento.Text) Then
                txtDocumento.Focus()
                Exit Sub
            Else
                If rbCreditos.Checked = True Then
                    sTable = "ccfCreditos"
                    storeName = "ccfUpdateccfCreditos"
                    sTipoDocumento = "C"
                    sparameterValues = "'I',"
                    sparameterValues = sparameterValues & "0," & txtIDCliente.EditValue.ToString() & ","
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'" & sTipoDocumento & "','"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipo.EditValue.ToString() & ",'"
                    sparameterValues = sparameterValues & Me.txtDocumento.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',"
                    sparameterValues = sparameterValues & "0,"
                    sparameterValues = sparameterValues & "0,'"
                    sparameterValues = sparameterValues & "Anulado por problemas en Documento Físico','Anulado por problemas en Documento Físico"
                    sparameterValues = sparameterValues & "','"
                    sparameterValues = sparameterValues & "','"
                    sparameterValues = sparameterValues & gsUsuario & "',"
                    sparameterValues = sparameterValues & "1.0,"
                    sparameterValues = sparameterValues & lIDVendedor.ToString() & ","
                    sparameterValues = sparameterValues & "0,"
                    sparameterValues = sparameterValues & "1,'" & lblMascara.Text & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditMoneda.EditValue.ToString() & ",1"
                Else
                    sTable = "ccfDebitos"
                    storeName = "ccfUpdateccfDebitos"
                    sTipoDocumento = "D"

                    sparameterValues = "'I',"
                    sparameterValues = sparameterValues & "0," & txtIDCliente.EditValue.ToString() & ","
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'" & sTipoDocumento & "','"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditClase.EditValue.ToString() & "',"
                    sparameterValues = sparameterValues & Me.SearchLookUpEditSubTipo.EditValue.ToString() & ",'"
                    sparameterValues = sparameterValues & Me.txtDocumento.EditValue.ToString() & "','"
                    sparameterValues = sparameterValues & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',"
                    sparameterValues = sparameterValues & "30,"
                    sparameterValues = sparameterValues & "0,0,'"
                    sparameterValues = sparameterValues & "Anulado por problema en el Documento Físico','Anulado por problema en el Documento Físico"
                    sparameterValues = sparameterValues & "','"
                    sparameterValues = sparameterValues & gsUsuario & "',"
                    sparameterValues = sparameterValues & "1,"
                    sparameterValues = sparameterValues & lIDVendedor.ToString() & ","
                    sparameterValues = sparameterValues & "0,"
                    sparameterValues = sparameterValues & "1,'"
                    sparameterValues = sparameterValues & lblMascara.Text & "',"
                    sparameterValues = sparameterValues & gParametrosCCF.IDMonedaUnica.ToString() & ",1"

                End If

            End If
            If cManager.ExistsInTable(sTable, "Documento", "Documento='" & txtDocumento.EditValue.ToString() & _
                    "' and IDClase ='" & Me.SearchLookUpEditClase.EditValue.ToString() & "' and IDSubTipo = " & _
                    Me.SearchLookUpEditSubTipo.EditValue.ToString(), "IDClase, IDSubTipo") Then
                MessageBox.Show("Por favor revise el consecutivo del Documento, ese Documento ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Focus()
                Exit Sub
            End If


            Dim td As New DataTable
            td = cManager.ExecSPgetData(storeName, sparameterValues)
            If td.Rows.Count > 0 Then
                MessageBox.Show("El registro ha sido guardado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message & " Registrando Documentos ")
        End Try
    End Sub
End Class