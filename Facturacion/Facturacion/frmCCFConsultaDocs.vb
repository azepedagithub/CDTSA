Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFConsultaDocs
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
    Dim gsMoneda As String
    Dim gIDMoneda As String
    Dim gdTipoCambio As Decimal


    Private Sub frmCCFConsultaDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaParametros()
            DateEditDesde.EditValue = Now.AddMonths(-2)
            DateEditHasta.EditValue = Now
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
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "Activo=1", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditClase, "ccfClaseDocumento", "IDClase, Descr", "Activo=1 AND IDCLASE <>'R/C' ", "Orden", "Descr", "IDClase")
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
        Try
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
                If Me.txtDocumento.Text <> "" Then
                    psDocumento = "'" & txtDocumento.EditValue.ToString() & "'"
                Else
                    psDocumento = "'*'"
                End If

            Else
                psDocumento = "'*'"
            End If
            If Me.SearchLookUpEditClase.EditValue IsNot Nothing Then
                If Me.SearchLookUpEditClase.Text <> "" Then
                    psIDClase = "'" & Me.SearchLookUpEditClase.EditValue.ToString() & "'"
                Else
                    psIDClase = "'*'"
                End If

            Else
                psIDClase = "'*'"
            End If

            If Me.SearchLookUpEditSubTipo.EditValue IsNot Nothing Then
                If Me.SearchLookUpEditSubTipo.Text <> "" Then
                    psIDSubTipo = Me.SearchLookUpEditSubTipo.EditValue.ToString()
                Else
                    psIDSubTipo = "0"
                End If

            Else
                psIDSubTipo = "0"
            End If

            If Me.CheckEditContabilizados.EditValue IsNot Nothing And Me.CheckEditNoContabilizados.EditValue IsNot Nothing Then
                If CheckEditContabilizados.Checked And Me.CheckEditNoContabilizados.Checked = False Then
                    psContabilizado = "1"
                End If
                If CheckEditContabilizados.Checked = False And Me.CheckEditNoContabilizados.Checked = True Then
                    psContabilizado = "0"
                End If
                If (CheckEditContabilizados.Checked = False And Me.CheckEditNoContabilizados.Checked = False) Or (CheckEditContabilizados.Checked = True And Me.CheckEditNoContabilizados.Checked = True) Then
                    psContabilizado = "-1"
                End If
            Else
                psContabilizado = "-1"
            End If

            If Me.CheckEditAprobados.EditValue IsNot Nothing And Me.CheckEditNoAprobados.EditValue IsNot Nothing Then
                If CheckEditAprobados.Checked And Me.CheckEditNoAprobados.Checked = False Then
                    psAprobado = "1"
                End If
                If CheckEditAprobados.Checked = False And Me.CheckEditNoAprobados.Checked = True Then
                    psAprobado = "0"
                End If
                If (CheckEditAprobados.Checked = False And Me.CheckEditNoAprobados.Checked = False) Or (CheckEditAprobados.Checked = True And Me.CheckEditNoAprobados.Checked = True) Then
                    psAprobado = "-1"
                End If
            Else
                psAprobado = "-1"
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
            If Me.CheckEditSaldos.EditValue IsNot Nothing And Me.CheckEditSinSaldo.EditValue IsNot Nothing Then
                If CheckEditSaldos.Checked And CheckEditSinSaldo.Checked = False Then
                    psSaldos = "1"
                End If
                If CheckEditSaldos.Checked = False And Me.CheckEditSinSaldo.Checked = True Then
                    psSaldos = "0"
                End If
                If CheckEditSaldos.Checked = False And Me.CheckEditSinSaldo.Checked = False Then
                    psSaldos = "-1"
                End If
            Else
                psAnulado = "-1"
            End If

            spParameters = psIDCliente & "," & psIDVendedor & "," & psFechaDesde & "," & psFechaHasta & "," & psDocumento & "," & psIDClase & "," & _
                psIDSubTipo & "," & psAprobado & "," & psAnulado & "," & psSaldos & "," & psContabilizado
            tableData = cManager.ExecSPgetData("ccfGetMovimientos", spParameters)
            If tableData.Rows.Count > 0 Then
                Me.GridControl1.DataSource = tableData
            Else
                Me.GridControl1.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            If CBool(dr("Aprobado")) = False Then
                MessageBox.Show("No se puede Aplicar Documento que no ha sido Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If CBool(dr("Anulado")) = True Then
                MessageBox.Show("No se puede Aplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If dr("TipoDocumento").ToString() = "D" Then
                MessageBox.Show("No se puede Aplicar un Debito ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If dr("TipoDocumento").ToString() = "C" And CBool(dr("Aprobado")) = False Then
                MessageBox.Show("No se puede Aplicar un Credito sin estar Aprobado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        End If
        getDataRowFromGridParaAplicar()
        If gsClase <> "" Then
            Dim frm As New frmCCFAplicaCreditos
            frm.gbAplicar = True
            frm.gsClase = gsClase
            frm.gIDCliente = gIDCliente
            frm.gsNombre = gsNombre
            frm.gIDCredito = gIDCredito
            frm.gdMontoOriginal = gdMontoOriginal
            frm.gdSaldo = gdSaldo
            frm.gdFecha = gdFecha
            frm.gsDocumento = gsDocumento
            frm.gsMoneda = gsMoneda
            frm.gIDMoneda = gIDMoneda
            frm.gdTipoCambio = gdTipoCambio
            frm.ShowDialog()
            RefrescaFiltro()
        End If

    End Sub

    Private Sub getDataRowFromGridParaAplicar()
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
                gIDMoneda = CInt(dr("IDMoneda"))
                gsMoneda = dr("DescrMoneda").ToString()
                gdTipoCambio = CDec(dr("TipoCambio"))
            End If
        Else
            gsClase = ""
        End If
    End Sub

    Private Sub getDataRowCreditoFromGrid()
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        gsClase = ""
        If dr IsNot Nothing Then
            If dr("TipoDocumento").ToString() = "C" Then
                gIDCliente = CInt(dr("IDCliente"))
                gsNombre = dr("Nombre").ToString()
                gIDCredito = CInt(dr("IDDocumento"))
                gsClase = dr("IDClase").ToString()
                gdMontoOriginal = CDec(dr("MontoOriginal"))
                gdSaldo = CDec(dr("SaldoCredito"))
                gdFecha = CDate(dr("Fecha"))
                gsDocumento = dr("Documento").ToString()
                gdTipoCambio = CDec(dr("TipoCambio"))
                gsMoneda = dr("DescrMoneda").ToString()
                gIDMoneda = CInt(dr("IDMoneda"))
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
        getDataRowCreditoFromGrid()
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
            frm.gdTipoCambio = gdTipoCambio
            frm.gIDMoneda = gIDMoneda
            frm.gsMoneda = gsMoneda
            frm.ShowDialog()
            RefrescaFiltro()
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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnular.ItemClick
        Try
            Dim dr As DataRow = GridView1.GetFocusedDataRow()
            If dr IsNot Nothing Then
                If MessageBox.Show("Está seguro de anular el Documento  " & dr("Documento").ToString(), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    Exit Sub
                End If
                Dim sTipoDocumento As String = dr("TipoDocumento").ToString()
                Dim sIDDocumento As String = CInt(dr("IDDocumento")).ToString()
                Dim sParametros As String = "'" & sTipoDocumento & "'," & sIDDocumento
                Dim td As New DataTable
                td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
                If (td.Rows(0)(0)) = True Then
                    MessageBox.Show("No se puede Anular un Documento si tiene Aplicaciones, por favor Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If Not cManager.ExecSP("ccfAnularDocumento", sParametros) Then
                    MessageBox.Show("Hubo un error aprobando El Documento " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("El Documento ha sido Anulado Exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefrescaFiltro()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error al Anular el Documento " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarButtonItemDesaplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDesaplicar.ItemClick
        Try
            Dim dr As DataRow = GridView1.GetFocusedDataRow()
            gsClase = ""
            If dr IsNot Nothing Then
                If CBool(dr("Anulado")) = True Then
                    MessageBox.Show("No se puede Desaplicar Documento Anulado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If dr("TipoDocumento").ToString() = "D" Then
                    MessageBox.Show("No se puede Desaplicar un Debito ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If dr("TipoDocumento").ToString() = "C" And CBool(dr("Aprobado")) = False Then
                    MessageBox.Show("No se puede Desaplicar un Credito sin estar Aplicado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

            End If
            getDataRowCreditoFromGrid()
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
                frm.gdTipoCambio = gdTipoCambio
                frm.gIDMoneda = gIDMoneda
                frm.gsMoneda = gsMoneda
                frm.ShowDialog()
                RefrescaFiltro()
            End If

        Catch ex As Exception
            MessageBox.Show("No se puede Aplicar un Credito sin estar Aplicado " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarbtnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarbtnExcel.ItemClick
        Try
            Dim path As String = "output1.xlsx"
            GridControl1.ExportToXlsx(path)
            ' Open the created XLSX file with the default application. 
            Process.Start(path)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a excel" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarListItem3_ListItemClick(sender As Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BarListItem3.ListItemClick

    End Sub

    Private Sub BarButtonItemrptDocumentosxCobrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemrptDocumentosxCobrar.ItemClick
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptDocumentosPorCobrar
            frm.gsNombreReporte = "Reporte Documentos por Cobrar"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar los reportes" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemrptMovimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemrptMovimientos.ItemClick
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptMovimientos
            frm.gsNombreReporte = "Reporte de Movimientos del Cliente"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar los reportes" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemrptDesglosePagos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemrptDesglosePagos.ItemClick
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptDesglosePagos
            frm.gsNombreReporte = "Reporte Desglose de Pagos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar los reportes" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemrptAntiguedadCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemrptAntiguedadCliente.ItemClick
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptAnalisisVencimiento
            frm.gsNombreReporte = "Reporte Analisis de Vencimientos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar los reportes" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemrptAntiguedadSucursal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemrptAntiguedadSucursal.ItemClick
        Try
            Dim frm As New frmCCFFiltroReportes()
            frm.iReporte = CrptAnalisisVencimientoSucursal
            frm.gsNombreReporte = "Reporte Analisis de Vencimientos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Error al Filtrar los reportes" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BarButtonItemCreaDocAnulado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemCreaDocAnulado.ItemClick
        Try
            Dim frm As New frmCCFCreaDocAnulado()
            frm.Show()
            RefrescaFiltro()

        Catch ex As Exception
            MessageBox.Show("Error al Crear un Documento Anulado" & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class