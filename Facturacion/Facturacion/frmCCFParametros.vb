Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFParametros
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim iIDParametros As Integer
    Private Sub frmCCFParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SearchLookUpEditMoneda.Enabled = False
        CargagridLookUpsFromTables()
        CargaControlsFromRegister()
    End Sub
    Sub CargaControlsFromRegister()
        Try
            Dim t As DataTable

            t = cManager.GetDataTable("ccfParametros", "IDParametro", "IDParametro >0", "IDParametro")
            If t.Rows.Count > 0 Then
                iIDParametros = t.Rows(0).Item(0)
            Else
                iIDParametros = 0
            End If
            tableData = cManager.ExecSPgetData("ccfGetParametros", iIDParametros.ToString)
            If tableData.Rows.Count > 0 Then
                Me.CheckEditUnaMoneda.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("UnaSolaMoneda"))
                Me.SearchLookUpEditMoneda.EditValue = CInt(tableData.Rows(0).Item("IDMonedaUnica"))
                Me.CheckEditAprobadoDefault.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("DocAprobadosDefault"))
                Me.CheckEditPlazoEdita.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("CambiarPlazo"))
                Me.SearchLookUpEditTipoAsientoDebito.EditValue = (tableData.Rows(0).Item("TipoAsientoDebito")).ToString()
                Me.SearchLookUpEditTipoAsientoCredito.EditValue = (tableData.Rows(0).Item("TipoAsientoCredito")).ToString()
                Me.CheckEditIntegracionContable.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("IntegracionContable"))
                Me.CheckEditEditaConsecutivo.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("EditaConsecutivos"))
                Me.chkUsaRecDesglose.EditValue = Convert.ToBoolean(tableData.Rows(0).Item("UsaReciboDesglosado"))
                Me.SearchLookUpEditClaseRecDesglose.EditValue = (tableData.Rows(0).Item("IDClaseRCDesglosado")).ToString()
                Me.SearchLookUpEditClaseFACDesglose.EditValue = (tableData.Rows(0).Item("IDClaseFACRCDesglosado")).ToString()
                Me.SearchLookUpEditIDClaseNCDevolucion.EditValue = (tableData.Rows(0).Item("IDClaseNCDevolucion")).ToString()
                Me.SearchLookUpEditIDSubTipoNCDevolucion.EditValue = CInt(tableData.Rows(0).Item("IDSubTipoNCDevolucion"))

            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener los Parámetros Globales " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Moneda, Activo", "", "IDMoneda", "Moneda", "IDMoneda")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoAsientoDebito, "cntTipoAsiento", "Tipo, Descr, Activo", "", "Tipo", "Descr", "Tipo")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoAsientoCredito, "cntTipoAsiento", "Tipo, Descr, Activo", "", "Tipo", "Descr", "Tipo")
        CargagridSearchLookUp(Me.SearchLookUpEditClaseRecDesglose, "ccfClaseDocumento", "IDClase, Descr, Activo", "TipoDocumento='C'", "IDClase", "Descr", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditClaseFACDesglose, "ccfClaseDocumento", "IDClase, Descr, Activo", "TipoDocumento='D'", "IDClase", "Descr", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditIDClaseNCDevolucion, "ccfClaseDocumento", "IDClase, Descr, Activo", "TipoDocumento='C' and IDClase='N/C'", "IDClase", "Descr", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditIDSubTipoNCDevolucion, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='C'", "IDSubTipo", "Descr", "IDSubTipo")

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
    End Sub
    Private Function DatosOk() As Boolean
        If Me.CheckEditUnaMoneda.Checked Then
            If SearchLookUpEditMoneda.EditValue = Nothing Then MsgBox("Debe seleccionar una Moneda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Me.SearchLookUpEditMoneda.Focus() : Return False : Exit Function
        End If
        If Me.chkUsaRecDesglose.Checked Then
            If SearchLookUpEditClaseRecDesglose.EditValue = Nothing Then MsgBox("Debe seleccionar una Clase de Documento para los Recibos de Caja", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Me.SearchLookUpEditClaseRecDesglose.Focus() : Return False : Exit Function
        End If
        If Me.chkUsaRecDesglose.Checked Then
            If SearchLookUpEditClaseFACDesglose.EditValue = Nothing Then MsgBox("Debe seleccionar una Clase de Documento para las Facturas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Me.SearchLookUpEditClaseRecDesglose.Focus() : Return False : Exit Function
        End If

        Return True
    End Function


    Private Sub CheckEditUnaMoneda_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditUnaMoneda.CheckedChanged
        If Me.CheckEditUnaMoneda.Checked Then
            Me.SearchLookUpEditMoneda.Enabled = True
        Else
            Me.SearchLookUpEditMoneda.Enabled = False
        End If
    End Sub

 

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim sMoneda As String = "null", sTipoAsientoDebito As String = "null", sTipoAsientoCredito As String = "null", sClaseRC As String = "null", sClaseFAC As String = "null"
            If Not DatosOk() Then

                'MessageBox.Show("Favor Revise los datos de Parámetros Globales ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Me.CheckEditUnaMoneda.Checked = False Then
                sMoneda = "null"
            Else
                sMoneda = Me.SearchLookUpEditMoneda.EditValue
            End If
            If Me.SearchLookUpEditTipoAsientoDebito.EditValue Is Nothing Then
                sTipoAsientoDebito = "null"
            Else
                sTipoAsientoDebito = "'" + Me.SearchLookUpEditTipoAsientoDebito.EditValue.ToString() + "'"
            End If

            If Me.SearchLookUpEditTipoAsientoCredito.EditValue Is Nothing Then
                sTipoAsientoCredito = "null"
            Else
                sTipoAsientoCredito = "'" + Me.SearchLookUpEditTipoAsientoCredito.EditValue.ToString() + "'"
            End If

            If Me.chkUsaRecDesglose.Checked = False Then
                sClaseRC = "null"
                sClaseFAC = "null"
            Else
                sClaseRC = "'" + Me.SearchLookUpEditClaseRecDesglose.EditValue.ToString() + "'"
                sClaseFAC = "'" + Me.SearchLookUpEditClaseFACDesglose.EditValue.ToString() + "'"
            End If
          

            Dim sParameters As String
            sParameters = iIDParametros.ToString() & "," & IIf(Me.CheckEditUnaMoneda.Checked = True, "1", "0") & "," & sMoneda & "," & _
                IIf(Me.CheckEditAprobadoDefault.Checked = True, "1", "0") & "," & IIf(Me.CheckEditPlazoEdita.Checked = True, "1", "0") & _
                "," & sTipoAsientoDebito & "," & sTipoAsientoCredito & "," & IIf(Me.CheckEditIntegracionContable.Checked = True, "1", "0") & _
                 "," & IIf(Me.CheckEditEditaConsecutivo.Checked = True, "1", "0") & _
                 "," & IIf(Me.chkUsaRecDesglose.Checked = True, "1", "0") & ",'" & sClaseRC & "','" & sClaseFAC & "', 'C', " & _
                 Me.SearchLookUpEditIDSubTipoNCDevolucion.EditValue.ToString() & ",'" & Me.SearchLookUpEditIDClaseNCDevolucion.EditValue.ToString() & "'"


            If cManager.ExecSP("ccfUpdateParametros", sParameters) Then
                MessageBox.Show("Parámetros Globales actualizados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar los Parámetros Globales " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub chkUsaRecDesglose_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsaRecDesglose.CheckedChanged
        If chkUsaRecDesglose.EditValue = True Then
            Me.SearchLookUpEditClaseRecDesglose.Enabled = True
            Me.SearchLookUpEditClaseFACDesglose.Enabled = True
        Else
            Me.SearchLookUpEditClaseRecDesglose.Enabled = False
            Me.SearchLookUpEditClaseFACDesglose.Enabled = False
        End If

    End Sub

    Private Sub SearchLookUpEditIDClaseNCDevolucion_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditIDClaseNCDevolucion.EditValueChanged
        If Me.SearchLookUpEditIDClaseNCDevolucion.Text <> "" Then
            CargagridSearchLookUp(Me.SearchLookUpEditIDSubTipoNCDevolucion, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento='C' and IDClase = '" & Me.SearchLookUpEditIDClaseNCDevolucion.EditValue.ToString() & "'", "IDSubTipo", "Descr", "IDSubTipo")
        End If
    End Sub
End Class