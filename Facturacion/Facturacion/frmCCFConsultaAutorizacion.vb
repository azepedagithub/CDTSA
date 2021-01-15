Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFConsultaAutorizacion
    Dim psLimitado As String = "-1"
    Dim psUsed As String = "-1"
    Dim psAnulado As String = "-1"
    Dim psIDCliente As String = "0"
    Dim psFechaDesde As String
    Dim psFechaHasta As String
    Dim cManager As New ClassManager
    Dim gIDAutorizacion As Integer = 0
    Dim tableData As New DataTable()

    Private Sub frmCCFConsultaAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gIDAutorizacion = 0
    End Sub
    Sub SetParametroLimitado()
        If CheckEditLimitado.EditValue = True And Me.CheckEditIlimitado.EditValue = False Then
            pslimitado = "1"
        End If
        If CheckEditLimitado.EditValue = False And Me.CheckEditIlimitado.EditValue = True Then
            pslimitado = "0"
        End If
        If (CheckEditLimitado.EditValue = False And Me.CheckEditIlimitado.EditValue = False) Or (CheckEditLimitado.EditValue = True And Me.CheckEditIlimitado.EditValue = True) Then
            pslimitado = "-1"
        End If
    End Sub
    Sub SetParametroUsed()
        If CheckEditUsado.EditValue = True And Me.CheckEditNoUsado.EditValue = False Then
            psUsed = "1"
        End If
        If CheckEditUsado.EditValue = False And Me.CheckEditNoUsado.EditValue = True Then
            psUsed = "0"
        End If
        If (CheckEditUsado.EditValue = False And Me.CheckEditNoUsado.EditValue = False) Or (CheckEditUsado.EditValue = True And Me.CheckEditNoUsado.EditValue = True) Then
            psUsed = "-1"
        End If
    End Sub
    Sub SetParametroAnulado()
        If CheckEditAnulados.EditValue = True And Me.CheckEditNoAnulados.EditValue = False Then
            psAnulado = "1"
        End If
        If CheckEditAnulados.EditValue = False And Me.CheckEditNoAnulados.EditValue = True Then
            psAnulado = "0"
        End If
        If (CheckEditAnulados.EditValue = False And Me.CheckEditNoAnulados.EditValue = False) Or (CheckEditAnulados.EditValue = True And Me.CheckEditNoAnulados.EditValue = True) Then
            psAnulado = "-1"
        End If
    End Sub

    Private Sub CheckEditIlimitado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditIlimitado.CheckedChanged
        SetParametroLimitado()
    End Sub

    Private Sub CheckEditLimitado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditLimitado.CheckedChanged
        SetParametroLimitado()
    End Sub

    Private Sub CheckEditUsado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditUsado.CheckedChanged
        SetParametroUsed()
    End Sub

    Private Sub CheckEditNoUsado_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoUsado.CheckedChanged
        SetParametroUsed()
    End Sub

    Private Sub CheckEditAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub

    Private Sub CheckEditNoAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub

    Private Sub RefrescaFiltro()
        Dim spParameters As String

        If Me.txtCliente.EditValue IsNot Nothing Then
            If Me.txtCliente.Text <> "" Then
                psIDCliente = Me.txtCliente.EditValue.ToString()
            Else
                psIDCliente = "0"
            End If

        Else
            psIDCliente = "0"
        End If



        If Me.DateEditDesde.EditValue IsNot Nothing Then
            psFechaDesde = "'" & CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd") & "'"

        Else
            psFechaDesde = "null"
        End If

        If Me.DateEditHasta.EditValue IsNot Nothing Then
            psFechaHasta = "'" & CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd") & "'"

        Else
            psFechaHasta = "null"
        End If

        If Me.CheckEditIlimitado.EditValue IsNot Nothing And Me.CheckEditLimitado.EditValue IsNot Nothing Then
            If CheckEditIlimitado.Checked And Me.CheckEditLimitado.Checked = False Then
                psLimitado = "1"
            End If
            If CheckEditIlimitado.Checked = False And Me.CheckEditLimitado.Checked = True Then
                psLimitado = "0"
            End If
            If CheckEditIlimitado.Checked = False And Me.CheckEditLimitado.Checked = False Then
                psLimitado = "-1"
            End If
        Else
            psLimitado = "-1"
        End If

        If Me.CheckEditUsado.EditValue IsNot Nothing And Me.CheckEditNoUsado.EditValue IsNot Nothing Then
            If CheckEditUsado.Checked And Me.CheckEditNoUsado.Checked = False Then
                psUsed = "1"
            End If
            If CheckEditUsado.Checked = False And Me.CheckEditNoUsado.Checked = True Then
                psUsed = "0"
            End If
            If CheckEditUsado.Checked = False And Me.CheckEditNoUsado.Checked = False Then
                psUsed = "-1"
            End If
        Else
            psUsed = "-1"
        End If

        If Me.CheckEditAnulados.EditValue IsNot Nothing And Me.CheckEditNoAnulados.EditValue IsNot Nothing Then
            If CheckEditUsado.Checked And Me.CheckEditNoAnulados.Checked = False Then
                psAnulado = "1"
            End If
            If CheckEditAnulados.Checked = False And Me.CheckEditNoAnulados.Checked = True Then
                psAnulado = "0"
            End If
            If CheckEditAnulados.Checked = False And Me.CheckEditNoAnulados.Checked = False Then
                psAnulado = "-1"
            End If
        Else
            psAnulado = "-1"
        End If

        spParameters = psIDCliente & "," & psFechaDesde & "," & psFechaHasta & "," & psLimitado & "," & psUsed & "," & psAnulado
        tableData = cManager.ExecSPgetData("ccfgetAutorizaciones", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.GridControl1.DataSource = tableData
        Else
            Me.GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        RefrescaFiltro()
    End Sub

    Private Sub BarButtonItemAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAdd.ItemClick
        Dim frm As New frmCCFAutorizacion()
        frm.gbEdit = False
        frm.gbAdd = True
        frm.gIDAutorizacion = 0
        frm.ShowDialog()
        frm.Dispose()
        RefrescaFiltro()

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        If dr IsNot Nothing Then
            gIDAutorizacion = CInt(dr("IDAutorizacion"))
            If CBool(dr("Used")) = False Or CBool(dr("Anulada")) = False Then
                BarButtonItemEdit.Enabled = True
                BarButtonItemAnular.Enabled = True
                BarButtonItemDel.Enabled = True
            End If
            If CBool(dr("Used")) = True Or CBool(dr("Anulada")) = True Then
                BarButtonItemEdit.Enabled = False
                BarButtonItemAnular.Enabled = False
                BarButtonItemDel.Enabled = False
            End If
        End If
    End Sub

    Private Sub BarButtonItemEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemEdit.ItemClick
        Dim frm As New frmCCFAutorizacion()
        frm.gbEdit = True
        frm.gbAdd = False
        frm.gIDAutorizacion = gIDAutorizacion
        frm.ShowDialog()
        RefrescaFiltro()
    End Sub

    Private Sub BarButtonItemAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnular.ItemClick
        If gIDAutorizacion <> 0 Then
            Dim sParametros As String
            If MessageBox.Show("Ud va a anular una autorización, si lo hace ya no podrá ser utilizada. Está de Acuerdo ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Sub
            End If

            sParametros = "'A', " & gIDAutorizacion.ToString() & ", " & "0" & "," & "'" & CDate(Now).ToString("yyyyMMdd") & "','" & gsUsuario & "'," & _
            "0,0" & "," & "0" & "," & "0" & "," & "0" & ",''"

            If Not cManager.ExecSP("ccfUpdateAutorizacion", sParametros) Then
                MessageBox.Show("Hubo un error actualizando la Autorización ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                RefrescaFiltro()
                MessageBox.Show("La Autorización ha sido Anulada Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BarButtonItemDel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDel.ItemClick
        If gIDAutorizacion <> 0 Then
            Dim sParametros As String
            If MessageBox.Show("Ud va eliminar una autorización, si lo hace ya no podrá ser utilizada. Está de Acuerdo ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Sub
            End If

            sParametros = "'D', " & gIDAutorizacion.ToString() & ", " & "0" & "," & "'" & CDate(Now).ToString("yyyyMMdd") & "','" & gsUsuario & "'," & _
            "0,0" & "," & "0" & "," & "0" & "," & "0" & ",''"

            If Not cManager.ExecSP("ccfUpdateAutorizacion", sParametros) Then
                MessageBox.Show("Hubo un error eliminando la Autorización ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                RefrescaFiltro()
                MessageBox.Show("La Autorización ha sido Anulada Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
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

    Private Sub BarButtonItemLimpiaFiltro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLimpiaFiltro.ItemClick
        Try
            LimpiaFiltro()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiaFiltro()
        Me.txtCliente.Text = ""
        Me.txtNombre.Text = ""
        Me.CheckEditAnulados.Checked = False
        Me.CheckEditNoAnulados.Checked = False
        Me.CheckEditIlimitado.Checked = False
        Me.CheckEditLimitado.Checked = False
        Me.CheckEditNoUsado.Checked = False
        Me.CheckEditUsado.Checked = False
        Me.DateEditDesde.EditValue = Nothing
        Me.DateEditHasta.EditValue = Nothing
    End Sub
End Class