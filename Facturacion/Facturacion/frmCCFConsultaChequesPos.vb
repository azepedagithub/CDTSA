Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFConsultaChequesPos
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim psCobrado As String = "-1"
    Dim psIDCliente As String = "0"
    Dim psFechaDesde As String
    Dim psFechaHasta As String
    Dim psDocumento As String
    Dim psCantidad As String
    Dim gIDCredito As Integer
    Dim gIDChequePos As Integer
    Private Sub frmCCFConsultaChequesPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEditDesde.EditValue = Now.AddMonths(-2)
        DateEditHasta.EditValue = Now
        DateEditDesde.Properties.Mask.EditMask = "dd/MM/yyyy"
        DateEditHasta.Properties.Mask.EditMask = "dd/MM/yyyy"
    End Sub
    Sub SetParametroCobrado()
        If CheckEditCobrado.EditValue = True And Me.CheckEditNoCobrados.EditValue = False Then
            psCobrado = "1"
        End If
        If CheckEditCobrado.EditValue = False And Me.CheckEditNoCobrados.EditValue = True Then
            psCobrado = "0"
        End If
        If (CheckEditCobrado.EditValue = False And Me.CheckEditNoCobrados.EditValue = False) Or (CheckEditCobrado.EditValue = True And Me.CheckEditNoCobrados.EditValue = True) Then
            psCobrado = "-1"
        End If
    End Sub

    Private Sub RefrescaFiltro()
        Dim spParameters As String
        If Me.txtDias.EditValue IsNot Nothing Then
            If txtDias.Text <> "" Then
                If Val(txtDias.Text) = 0 Then
                    MessageBox.Show("El valor de Dias debe ser numérico", "Error", MessageBoxButtons.OK)
                    txtDias.Text = ""
                    txtDias.Focus()
                    Exit Sub
                    psCantidad = "0"
                End If
                psCantidad = txtDias.EditValue.ToString()
            End If
        Else
            psCantidad = "0"
        End If
        

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

        If Me.txtDocumento.EditValue IsNot Nothing Then
            If txtDocumento.Text <> "" Then
                psDocumento = "'" & txtDocumento.EditValue.ToString() & "'"
            Else
                psDocumento = "'*'"
            End If
        Else
            psDocumento = "'*'"
        End If

        If Me.CheckEditCobrado.EditValue IsNot Nothing And Me.CheckEditNoCobrados.EditValue IsNot Nothing Then
            If CheckEditCobrado.Checked And Me.CheckEditNoCobrados.Checked = False Then
                psCobrado = "1"
            End If
            If CheckEditCobrado.Checked = False And Me.CheckEditNoCobrados.Checked = True Then
                psCobrado = "0"
            End If
            If (CheckEditCobrado.Checked = False And Me.CheckEditNoCobrados.Checked = False) Or (CheckEditCobrado.Checked = True And Me.CheckEditNoCobrados.Checked = True) Then
                psCobrado = "-1"
            End If
        Else
            psCobrado = "-1"
        End If


        spParameters = psIDCliente & "," & psFechaDesde & "," & psFechaHasta & "," & psDocumento & "," & psCobrado & "," & psCantidad
        tableData = cManager.ExecSPgetData("ccfgetChequesPos", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.GridControl1.DataSource = tableData
        Else
            Me.GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        RefrescaFiltro()
    End Sub

    Private Sub BarButtonItemAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAprobar.ItemClick
        Dim frm As New frmChequePos()
        If gIDCredito <> 0 And gIDChequePos <> 0 Then
            frm.gIDCheque = gIDChequePos
            frm.gIDCredito = gIDCredito
            frm.Show()
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            Dim dr As DataRow = GridView1.GetFocusedDataRow()
            If dr IsNot Nothing Then
                gIDCredito = CInt(dr("IDCredito"))
                gIDChequePos = CInt(dr("IDChequePos"))
            Else
                gIDCredito = 0
                gIDChequePos = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnular.ItemClick

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
        Me.CheckEditCobrado.EditValue = False
        Me.CheckEditNoCobrados.EditValue = False
        Me.txtCliente.EditValue = Nothing
        Me.txtNombre.EditValue = Nothing
        Me.txtDocumento.EditValue = Nothing
        Me.txtDias.EditValue = Nothing
        Me.DateEditDesde.EditValue = Nothing
        Me.DateEditHasta.EditValue = Nothing
        Me.GridControl1.DataSource = Nothing

    End Sub

    Private Sub BarButtonItemAplicaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicaciones.ItemClick
        Try
            Dim frm As New frmAplicacionesRC()
            If gIDCredito <> 0 And gIDChequePos <> 0 Then
                frm.gsIDCredito = gIDCredito.ToString()
                frm.gdFechaInicio = DateAdd(DateInterval.Year, -20, Now)
                frm.gdFechaFin = Now
                frm.gIDCliente = 0
                frm.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemAplicacionCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicacionCliente.ItemClick

    End Sub
End Class