Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFConsultaRC
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim psAnulado As String = "-1"
    Dim psConCheque As String = "-1"
    Dim psAprobado As String = "-1"
    Dim psIDCliente As String = "", psIDVendedor As String = "", psFechaDesde As String, psFechaHasta As String, psDocumento As String, psIDSucursal As String = ""
    Dim gIDCredito As Integer
    Dim gIDChequePos As Integer
    Private Sub frmCCFConsultaRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DateEditDesde.EditValue = Now.AddMonths(-2)
            DateEditHasta.EditValue = Now
            DateEditDesde.Properties.Mask.EditMask = "dd/MM/yyyy"
            DateEditHasta.Properties.Mask.EditMask = "dd/MM/yyyy"
            CargagridLookUpsFromTables()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los Datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "Activo=1", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr", "Activo=1 ", "IDBodega", "Descr", "IDBodega")

    End Sub


    Sub SetParametroConCheque()
        If CheckEditConCheque.EditValue = True And Me.CheckEditSinCheques.EditValue = False Then
            psConCheque = "1"
        End If
        If CheckEditConCheque.EditValue = False And Me.CheckEditSinCheques.EditValue = True Then
            psConCheque = "0"
        End If
        If (CheckEditConCheque.EditValue = False And Me.CheckEditSinCheques.EditValue = False) Or (CheckEditConCheque.EditValue = True And Me.CheckEditSinCheques.EditValue = True) Then
            psConCheque = "-1"
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
    Private Sub CheckEditAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub


    Private Sub CheckEditNoAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub
    Private Sub CheckEditConCheque_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditConCheque.CheckedChanged
        SetParametroConCheque()

    End Sub

    Private Sub CheckEditsinCheques_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditSinCheques.CheckedChanged
        SetParametroConCheque()
    End Sub


    Private Sub RefrescaFiltro()
        Dim spParameters As String
        If Me.txtCliente.EditValue IsNot Nothing Then
            If txtCliente.Text <> "" Then
                psIDCliente = Me.txtCliente.EditValue.ToString()
            Else
                psIDCliente = "0"
            End If

        Else
            psIDCliente = "0"
        End If
        If Me.SearchLookUpEditVendedor.EditValue IsNot Nothing Then
            If Me.SearchLookUpEditVendedor.Text <> "" Then
                psIDVendedor = Me.SearchLookUpEditVendedor.EditValue.ToString()
            Else
                psIDVendedor = "0"
            End If
        Else
            psIDVendedor = "0"
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
  

        If Me.SearchLookUpEditSucursal.EditValue IsNot Nothing Then
            If Me.SearchLookUpEditSucursal.Text <> "" Then
                psIDSucursal = Me.SearchLookUpEditSucursal.EditValue.ToString()
            Else
                psIDSucursal = "0"
            End If

        Else
            psIDSucursal = "0"
        End If

        If Me.CheckEditAnulados.EditValue IsNot Nothing And Me.CheckEditNoAnulados.EditValue IsNot Nothing Then
            If CheckEditAnulados.Checked And Me.CheckEditNoAnulados.Checked = False Then
                psAnulado = "1"
            End If
            If CheckEditAnulados.Checked = False And Me.CheckEditNoAnulados.Checked = True Then
                psAnulado = "0"
            End If
            If (CheckEditAnulados.Checked = False And Me.CheckEditNoAnulados.Checked = False) Or (CheckEditAnulados.Checked = True And Me.CheckEditNoAnulados.Checked = True) Then
                psAnulado = "-1"
            End If
        Else
            psAnulado = "-1"
        End If

        If Me.CheckEditConCheque.EditValue IsNot Nothing And Me.CheckEditSinCheques.EditValue IsNot Nothing Then
            If CheckEditConCheque.Checked And Me.CheckEditSinCheques.Checked = False Then
                psConCheque = "1"
            End If
            If CheckEditConCheque.Checked = False And Me.CheckEditSinCheques.Checked = True Then
                psConCheque = "0"
            End If
            If (CheckEditConCheque.Checked = False And Me.CheckEditSinCheques.Checked = False) Or (CheckEditConCheque.Checked = True And Me.CheckEditSinCheques.Checked = True) Then
                psConCheque = "-1"
            End If
        Else
            psConCheque = "-1"
        End If

        spParameters = psIDSucursal & "," & psFechaDesde & "," & psFechaHasta & "," & psIDCliente & "," & psIDVendedor & "," & psConCheque & "," & psDocumento & "," & _
        psAnulado
        tableData = cManager.ExecSPgetData("ccfgetRecibos", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.GridControl1.DataSource = tableData
        Else
            Me.GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        Try
            RefrescaFiltro()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarButtonItemNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNuevo.ItemClick
        Try
            Dim frm As New frmRecibos()
            frm.ShowDialog()
            RefrescaFiltro()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub BarButtonItemAplicaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicaciones.ItemClick
        Try
            Dim frm As New frmAplicacionesRC()
            If gIDCredito <> 0 Then
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

    Private Sub BarButtonItemAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAprobar.ItemClick

        Dim frm As New frmChequePos()
        If gIDCredito <> 0 And gIDChequePos <> 0 Then
            frm.gIDCheque = gIDChequePos
            frm.gIDCredito = gIDCredito
            frm.Show()
        End If

    End Sub

    Private Sub BarButtonItemAplicacionCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicacionCliente.ItemClick
        Try
            If txtCliente.EditValue = Nothing Then
                MessageBox.Show("Es necesario filtrar al menos un cliente para esta opción. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmAplicacionesRC()
            If gIDCredito <> 0 Then
                frm.gsIDCredito = 0
                frm.gdFechaInicio = Me.DateEditDesde.EditValue
                frm.gdFechaFin = Me.DateEditHasta.EditValue
                frm.gIDCliente = CInt(txtCliente.EditValue)
                frm.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LimpiaFiltro()
        Me.txtCliente.Text = ""
        Me.txtNombre.Text = ""
        txtDocumento.Text = ""
        Me.SearchLookUpEditVendedor.Text = ""
        Me.SearchLookUpEditSucursal.Text = ""
        Me.CheckEditSinCheques.Checked = False
        Me.CheckEditConCheque.Checked = False
        Me.CheckEditNoAnulados.Checked = False
        Me.CheckEditNoAnulados.Checked = False
    End Sub

    Private Sub BarButtonItemLimpiaFiltro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLimpiaFiltro.ItemClick
        Try
            LimpiaFiltro()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarButtonItemAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnular.ItemClick
        Try
            Dim dr As DataRow = GridView1.GetFocusedDataRow()
            If dr IsNot Nothing Then
                If MessageBox.Show("Está seguro de anular el Recibo  " & dr("Recibo").ToString(), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    Exit Sub
                End If

                Dim sIDDocumento As String = CInt(dr("IDCredito")).ToString()
                Dim sParametros As String = "'C'," & sIDDocumento
                Dim td As New DataTable
                td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If Not cManager.ExecSP("ccfAnularDocumento", sParametros) Then
                    MessageBox.Show("Hubo un error aprobando El R/C " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("El R/C ha sido Anulado Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefrescaFiltro()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarButtonItemDesaplic_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDesaplic.ItemClick
        Try
            Dim dr As DataRow = GridView1.GetFocusedDataRow()

            If dr IsNot Nothing Then
                If CBool(dr("Anulado")) = True Then
                    MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If CBool(dr("Aprobado")) = False Then
                    MessageBox.Show("No se puede Aplicar un Credito sin estar Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                Dim frm As New frmCCFAplicaCreditos
                frm.gbAplicar = False
                frm.gsClase = "R/C"
                frm.gIDCliente = CInt(dr("IDCliente"))
                frm.gsNombre = dr("Nombre").ToString()
                frm.gIDCredito = CInt(dr("IDCredito"))
                frm.gdMontoOriginal = CDec(dr("MontoRecibo"))
                frm.gdSaldo = CDec(dr("SaldoCredito"))
                frm.gdFecha = CDate(dr("Fecha"))
                frm.gsDocumento = dr("Recibo").ToString()
                frm.gsMoneda = dr("DescrMoneda").ToString()
                frm.gIDMoneda = CInt(dr("IDMoneda"))
                frm.gdTipoCambio = CDec(dr("TipoCambio"))
                frm.ShowDialog()

            End If

            RefrescaFiltro()


        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class