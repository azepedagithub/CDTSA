Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCPConsultaDoc

    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim psAnulado As String = "-1"
    Dim psAprobado As String = "-1"
    Dim psContabilizado As String = "-1"
    Dim psSaldos As String = "0", psIDClase As String, psIDSubTipo As String
    Dim psIDCliente As String = "", psIDVendedor As String = "", psFechaDesde As String, psFechaHasta As String, psDocumento As String

    Dim gIDCliente As Int32
    Dim gsNombre As String
    Dim gIDCredito As Int32
    Dim gsClase As String
    Dim gdMontoOriginal As Decimal
    Dim gdSaldo As Decimal
    Dim gdFecha As Date
    Dim gsDocumento As String


    Private Sub frmCPConsultaDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DateEditDesde.Properties.Mask.EditMask = "dd/MM/yyyy"
            DateEditHasta.Properties.Mask.EditMask = "dd/MM/yyyy"
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            CargagridLookUpsFromTables()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los Datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub getSelectedRows()
        Dim Rows As New ArrayList()

        ' Add the selected rows to the list. 
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Rows.Add(GridView1.GetDataRow(selectedRowHandle))
            End If
        Next

    End Sub

    Private Sub ApruebaBatch()
        Dim Rows As New ArrayList()

        ' Add the selected rows to the list. 
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim I As Integer
        If selectedRowHandles.Length > 0 Then
            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                If (selectedRowHandle >= 0) Then

                    Dim dataRow As DataRow = GridView1.GetDataRow(selectedRowHandle)
                    If CBool(dataRow("Aprobado")) = False And CBool(dataRow("Anulado")) = False Then
                        Dim sParametros As String = "'" & dataRow("TipoDocumento").ToString & "'," & dataRow("IDDocumento").ToString()  'Rows(1).ToString() & "', " & Rows(0).ToString()
                        If Not cManager.ExecSP("ccfAprobarDocumento", sParametros) Then
                            MessageBox.Show("Hubo un error aprobando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If

                    End If
                End If

            Next
            RefrescaFiltro()
            MessageBox.Show("El/Los Documento(s) ha(n) sido Aprobado(s)  exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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

                Me.SearchLookUpEditVendedor.EditValue = CInt(frm.gsVendedor)
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "Activo=1", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 ", "Orden", "Descr", "IDClase")
        CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", "", "IDSubTipo", "Descr", "IDSubTipo")
    End Sub

    Private Sub CheckEditAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub


    Private Sub CheckEditNoAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoAnulados.CheckedChanged
        SetParametroAnulado()
    End Sub

    Sub SetParametroContabilizado()
        If CheckEditContabilizados.EditValue = True And Me.CheckEditContabilizados.EditValue = False Then
            psContabilizado = "1"
        End If
        If CheckEditContabilizados.EditValue = False And Me.CheckEditContabilizados.EditValue = True Then
            psContabilizado = "0"
        End If
        If (CheckEditContabilizados.EditValue = False And Me.CheckEditContabilizados.EditValue = False) Or (CheckEditContabilizados.EditValue = True And Me.CheckEditContabilizados.EditValue = True) Then
            psContabilizado = "-1"
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
    Sub SetParametroAprobado()
        If CheckEditAprobados.EditValue = True And Me.CheckEditNoAprobados.EditValue = False Then
            psAprobado = "1"
        End If
        If CheckEditAprobados.EditValue = False And Me.CheckEditNoAprobados.EditValue = True Then
            psAprobado = "0"
        End If
        If (CheckEditAprobados.EditValue = False And Me.CheckEditNoAprobados.EditValue = False) Or (CheckEditAprobados.EditValue = True And Me.CheckEditNoAprobados.EditValue = True) Then
            psAprobado = "-1"
        End If
    End Sub

    Private Sub CheckEditAprobados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditAprobados.CheckedChanged
        SetParametroAprobado()
    End Sub

    Private Sub CheckEditNoAprobados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoAprobados.CheckedChanged
        SetParametroAprobado()
    End Sub

    Private Sub CheckEditSaldos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditSaldos.CheckedChanged
        If CheckEditSaldos.EditValue = True Then
            psSaldos = "1"
        Else
            psSaldos = "0"
        End If
    End Sub

    Private Sub CheckEditContabilizados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditContabilizados.CheckedChanged
        SetParametroContabilizado()
    End Sub

    Private Sub CheckEditNoContabilizados_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNoContabilizados.CheckedChanged
        SetParametroContabilizado()
    End Sub


    Private Sub BarButtonItemAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAprobar.ItemClick

        Try
            ApruebaBatch()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        RefrescaFiltro()
    End Sub

    Private Sub RefrescaFiltro()
        Dim spParameters As String
        If Me.txtCliente.EditValue IsNot Nothing Then
            psIDCliente = Me.txtCliente.EditValue.ToString()
        Else
            psIDCliente = "0"
        End If
        If Me.SearchLookUpEditVendedor.EditValue IsNot Nothing Then
            psIDVendedor = Me.SearchLookUpEditVendedor.EditValue.ToString()
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
            psDocumento = "'" & txtDocumento.EditValue.ToString() & "'"
        Else
            psDocumento = "'*'"
        End If
        If Me.SearchLookUpEditClase.EditValue IsNot Nothing Then
            psIDClase = "'" & Me.SearchLookUpEditClase.EditValue.ToString() & "'"
        Else
            psIDClase = "'*'"
        End If

        If Me.SearchLookUpEditSubTipo.EditValue IsNot Nothing Then
            psIDSubTipo = Me.SearchLookUpEditSubTipo.EditValue.ToString()
        Else
            psIDSubTipo = "0"
        End If

        spParameters = psIDCliente & "," & psIDVendedor & "," & psFechaDesde & "," & psFechaHasta & "," & psDocumento & "," & psIDClase & "," & _
            psIDSubTipo & "," & psAprobado & "," & psAnulado & "," & psSaldos & "," & psContabilizado
        tableData = cManager.ExecSPgetData("ccfGetMovimientos", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.GridControl1.DataSource = tableData
        Else
            Me.GridControl1.DataSource = Nothing
        End If
    End Sub


    Private Sub BarButtonItemLimpiaFiltro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLimpiaFiltro.ItemClick
        Me.CheckEditNoAprobados.EditValue = False
        Me.CheckEditNoAprobados.EditValue = False
        Me.CheckEditNoAnulados.EditValue = False
        Me.CheckEditAnulados.EditValue = False
        Me.CheckEditContabilizados.EditValue = False
        Me.CheckEditNoContabilizados.EditValue = False
        Me.CheckEditSaldos.EditValue = False
        Me.txtCliente.Text = Nothing
        Me.txtNombre.Text = Nothing
        Me.txtDocumento.Text = Nothing
        Me.SearchLookUpEditClase.Text = Nothing
        Me.SearchLookUpEditSubTipo.Text = Nothing
        Me.SearchLookUpEditVendedor.Text = Nothing
        Me.DateEditDesde.EditValue = Nothing
        Me.DateEditHasta.EditValue = Nothing
        Me.GridControl1.DataSource = Nothing
    End Sub

    Private Sub BarButtonItemAplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicar.ItemClick
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        gsClase = ""
        If dr IsNot Nothing Then
            If CBool(dr("Anulado")) = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If dr("TipoDocumento").ToString() = "D" Then
                MessageBox.Show("No se puede Aplicar un Debito ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If dr("TipoDocumento").ToString() = "C" And CBool(dr("Aprobado")) = False Then
                MessageBox.Show("No se puede Aplicar un Credito sin estar Aplicado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        End If
        getDataRowFromGrid()
        If gsClase <> "" Then
            Dim frm As New frmCCFAplicaCreditos()
            frm.gbAplicar = True
            frm.gsClase = gsClase
            frm.gIDCliente = gIDCliente
            frm.gsNombre = gsNombre
            frm.gIDCredito = gIDCredito
            frm.gdMontoOriginal = gdMontoOriginal
            frm.gdSaldo = gdSaldo
            frm.gdFecha = gdFecha
            frm.gsDocumento = gsDocumento
            frm.Show()
            RefrescaFiltro()
        End If
    End Sub



    Private Sub getDataRowFromGrid()
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        gsClase = ""
        If dr IsNot Nothing Then
            If dr("TipoDocumento").ToString() = "C" And CDec(dr("SaldoCredito")) > 0 Then
                gIDCliente = CInt(dr("IDCliente"))
                gsNombre = dr("Nombre").ToString()
                gIDCredito = CInt(dr("IDDocumento"))
                gsClase = dr("IDClase").ToString()
                gdMontoOriginal = CDec(dr("MontoOriginal"))
                gdSaldo = CDec(dr("SaldoCredito"))
                gdFecha = CDate(dr("Fecha"))
                gsDocumento = dr("Documento").ToString()

            End If
        Else
            gsClase = ""
        End If


    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        If dr IsNot Nothing Then

            If CBool(dr("Aprobado")) = True Then
                BarButtonItemAprobar.Enabled = False
            Else
                BarButtonItemAprobar.Enabled = True
            End If

            If (dr("Asiento") IsNot Nothing) And dr("Asiento").ToString() <> "" Then
                BarButtonItemAsiento.Enabled = True
                BarButtonItemContabilizar.Enabled = False
            Else
                BarButtonItemAsiento.Enabled = False
                BarButtonItemContabilizar.Enabled = True
            End If

            If dr("TipoDocumento").ToString() = "C" Then
                BarButtonItemAplicaciones.Enabled = True
            Else
                BarButtonItemAplicaciones.Enabled = False
            End If

            If dr("TipoDocumento").ToString() = "C" And CDec(dr("SaldoCredito")) > 0 Then
                BarButtonItemAplicar.Enabled = True
            Else
                BarButtonItemAplicar.Enabled = False
            End If

        End If
    End Sub



    Private Sub BarButtonItemAplicaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAplicaciones.ItemClick
        getDataRowFromGrid()
        If gsClase <> "" Then
            Dim frm As New frmCCFAplicaCreditos()
            frm.gbAplicar = False
            frm.gsClase = gsClase
            frm.gIDCliente = gIDCliente
            frm.gsNombre = gsNombre
            frm.gIDCredito = gIDCredito
            frm.gdMontoOriginal = gdMontoOriginal
            frm.gdSaldo = gdSaldo
            frm.gdFecha = gdFecha
            frm.gsDocumento = gsDocumento
            frm.Show()
        End If
    End Sub

    Private Sub BarButtonItemDocumento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDocumento.ItemClick
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        If dr IsNot Nothing Then
            Dim frm As New frmCPDocumentos()
            frm.gbEdit = True
            frm.gbAdd = False
            frm.gsTipoDocumento = dr("TipoDocumento").ToString()
            frm.giIDDocumento = CInt(dr("IDDocumento"))
            frm.Show()
        End If
    End Sub

    Private Sub BarButtonItemNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNuevo.ItemClick
        Dim frm As New frmCPDocumentos()
        frm.gbAdd = True
        frm.gbEdit = False
        frm.Show()

    End Sub

    Private Sub BarButtonItemAsiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAsiento.ItemClick

    End Sub

    Private Sub BarButtonItemContabilizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemContabilizar.ItemClick
        getSelectedRows()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        If dr IsNot Nothing Then

            Dim sTipoDocumento As String = dr("TipoDocumento").ToString()
            Dim sIDDocumento As String = CInt(dr("IDDocumento")).ToString()
            Dim sParametros As String = "'" & sTipoDocumento & "'," & sIDDocumento
            Dim td As New DataTable
            td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
            If (td.Rows(0)(0)) = 1 Then
                MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Not cManager.ExecSP("ccfAnularDocumento", sParametros) Then
                MessageBox.Show("Hubo un error aprobando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("El Documento ha sido Anulado Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

    End Sub
End Class