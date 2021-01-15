Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFAutorizacion
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()

    Public gbEdit As Boolean = False
    Public gbAdd As Boolean = False
    Public gIDAutorizacion As Integer = 0
    Private Sub CheckEditIlimitado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditIlimitado.CheckedChanged
        If Me.CheckEditIlimitado.Checked = True Then
            CheckEditLimitado.Checked = False
            Me.txtLimite.ReadOnly = True
            Me.txtLimite.EditValue = 0
        End If
    End Sub

    Private Sub CheckEditLimitado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditLimitado.CheckedChanged
        If Me.CheckEditLimitado.Checked = True Then
            CheckEditIlimitado.Checked = False
            Me.txtLimite.ReadOnly = False
            Me.txtLimite.EditValue = 0
        End If
    End Sub

    Private Sub RefrescaDatos()
        Dim spParameters As String
        If gIDAutorizacion <> 0 Then
            spParameters = gIDAutorizacion.ToString()
            tableData = cManager.ExecSPgetData("ccfgetDatosAutorizacion", spParameters)
            If tableData.Rows.Count > 0 Then
                Me.txtCliente.EditValue = CInt(tableData.Rows(0)("IDCliente"))
                Me.txtNombre.EditValue = tableData.Rows(0)("Nombre").ToString()
                If CBool(tableData.Rows(0)("Limitado")) Then
                    Me.CheckEditIlimitado.Checked = False
                Else
                    Me.CheckEditIlimitado.Checked = True
                End If
                Me.CheckEditLimitado.Checked = CBool(tableData.Rows(0)("Limitado"))
                Me.txtLimite.EditValue = CDec(tableData.Rows(0)("MontoLimite"))
                CheckEditUsado.Checked = CBool(tableData.Rows(0)("Used"))
                CheckEditAnulados.Checked = CBool(tableData.Rows(0)("Anulada"))
                Me.DateEditFecha.EditValue = CDate(tableData.Rows(0)("Fecha"))
                Me.txtNota.EditValue = (tableData.Rows(0)("Nota")).ToString()
                Me.txtIDAutorizacion.EditValue = gIDAutorizacion
            End If

        End If
    End Sub
    Private Sub frmCCFAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gbEdit = True And gbAdd = False Then
            RefrescaDatos()
        End If
        If gbEdit = False And gbAdd = True Then
            Me.DateEditFecha.EditValue = Now
        End If
    End Sub

    Private Sub BarButtonItemNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNew.ItemClick
        gbEdit = False
        gbAdd = True
        Me.txtCliente.Text = ""
        Me.txtNombre.Text = ""
        Me.txtLimite.Text = ""
        txtFactura.Text = ""
        txtNota.Text = ""
        txtIDAutorizacion.Text = ""
        CheckEditIlimitado.Checked = False
        CheckEditUsado.Checked = False
        CheckEditAnulados.Checked = False
        CheckEditLimitado.Checked = False
        DateEditFecha.EditValue = Now
        btnCliente.Focus()
    End Sub

    Private Sub BarButtonItemSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick
        Try
            Dim sParametros As String
            If txtCliente.Text = "" Then
                MessageBox.Show("Ud debe indicar un Cliente para la Autorización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If gbAdd And gbEdit = False Then
                Dim td As New DataTable
                sParametros = txtCliente.EditValue.ToString() & ",'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "'"
                td = cManager.ExecSPgetData("ccfgetAutorizacion", sParametros)
                If td.Rows.Count > 0 Then
                    If (td.Rows(0)(" SaldoLimite")) > 0 Then
                        MessageBox.Show("Ese Cliente ya tiene una autorización, Solamente puede haber una autorizacion activa en el dia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                End If

                sParametros = "'I', 0, " & txtCliente.EditValue.ToString() & "," & "'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "','" & gsUsuario & "'," & _
                IIf(Me.CheckEditLimitado.Checked = True, "1", "0") & "," & IIf(txtLimite.Text = "", "0", txtLimite.Text) & ",0, 0, null,'" & txtNota.Text & "'"
                Dim sSql As String
                sSql = cManager.CreateStoreProcSql("ccfUpdateAutorizacion", sParametros)
                Dim clase As New CbatchSQLIitem(sSql, True, False, True, False, "ccfUpdateAutorizacion", "ccfUpdateAutorizacion")
                cManager.batchSQLLista.Add(clase)
                cManager.batchSQLitem.Clear()
                cManager.batchSQLitem.Add(sSql)
                If cManager.ExecCmdWithTransaction() Then
                    gIDAutorizacion = cManager.IDAutoFirstParent
                    RefrescaDatos()
                    gbEdit = True
                    gbAdd = False
                    MessageBox.Show("La Autorización ha sido Guardada Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                Else
                    MessageBox.Show("Hubo un error actualizando la Autorización " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            End If
            If gbAdd = False And gbEdit = True Then

                If Me.CheckEditLimitado.Checked And (txtLimite.Text = "" Or txtLimite.EditValue = 0) Then
                    MessageBox.Show("Ud indicó que la autorización tiene límite pero Ud no indicó el Monto Límite ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                sParametros = "'U', " & gIDAutorizacion.ToString() & ", " & txtCliente.EditValue.ToString() & "," & "'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "','" & gsUsuario & "'," & _
                IIf(Me.CheckEditLimitado.Checked = True, "1", "0") & "," & txtLimite.EditValue.ToString() & "," & IIf(Me.CheckEditUsado.Checked = True, "1", "0") & "," & IIf(Me.CheckEditAnulados.Checked = True, "1", "0") & "," & IIf(txtFactura.Text = "", "null", txtFactura.Text) & ",'" & txtNota.Text & "'"

                If Not cManager.ExecSP("ccfUpdateAutorizacion", sParametros) Then
                    MessageBox.Show("Hubo un error actualizando la Autorización ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    RefrescaDatos()
                    MessageBox.Show("La Autorización ha sido Guardada Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    gbEdit = True
                    gbAdd = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la Autorización " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarButtonItemSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSalir.ItemClick
        Close()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        CallPopUpClientes()
    End Sub
    Private Sub CallPopUpClientes()
        Try

            Dim frm As New frmPopupCliente()
            frm.gsIDSucursal = 0
            frm.ShowDialog()
            If frm.gsIDCliente <> "" Then
                Me.txtCliente.EditValue = frm.gsIDCliente
                Me.txtNombre.EditValue = frm.gsNombre
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnular.ItemClick
        Dim sParametros As String
        If MessageBox.Show("Ud va a anular una autorización, si lo hace ya no podrá ser utilizada. Está de Acuerdo ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        If gbAdd = False And gbEdit = True Then

            If Me.CheckEditLimitado.Checked And (txtLimite.Text = "" Or txtLimite.EditValue = 0) Then
                MessageBox.Show("Ud indicó que la autorización tiene límite pero Ud no indicó el Monto Límite ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            sParametros = "'A', " & gIDAutorizacion.ToString() & ", " & txtCliente.EditValue.ToString() & "," & "'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "','" & gsUsuario & "'," & _
            IIf(Me.CheckEditLimitado.Checked = True, "1", "0") & "," & txtLimite.EditValue.ToString() & "," & IIf(Me.CheckEditUsado.Checked = True, "1", "0") & "," & IIf(Me.CheckEditAnulados.Checked = True, "1", "0") & "," & IIf(txtFactura.Text = "", "null", txtFactura.Text) & ",'" & txtNota.Text & "'"

            If Not cManager.ExecSP("ccfUpdateAutorizacion", sParametros) Then
                MessageBox.Show("Hubo un error actualizando la Autorización ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                RefrescaDatos()
                MessageBox.Show("La Autorización ha sido Guardada Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                gbEdit = True
                gbAdd = False
            End If
        End If
    End Sub
End Class