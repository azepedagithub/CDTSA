Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.GridView
Imports DevExpress.XtraGrid.Views.Base
Imports Clases
Imports DevExpress.XtraRichEdit.Layout
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors

Public Class frmCPAplicaCreditos
    Dim cManager As New ClassManager
    Dim gdTotalAbono As Decimal
    Dim gdTotalAbonoNacional As Decimal
    Dim gdTotalAbonoExtranjero As Decimal
    Dim gbGridGargado As Boolean = False
    Dim tableData As New DataTable()
    Public gbAplicar As Boolean
    Public gIDProveedor As Int32
    Public gsNombre As String
    Public gIDDocPago As Int32
    Public gIDMoneda As Integer
    Public gsMoneda As String
    Public gsClase As String
    Public gdMontoOriginal As Decimal
    Public gdSaldo As Decimal
    Public gsDocumento As String
    Public gdFecha As Date
    Public gdTipoCambio As Decimal
    Dim gsSimboloMonedaExtranjera As String
    Dim gsSimboloMonedaNacional As String
    Dim gbMonedaCreditoNacional As Boolean = False



    Private Sub frmCPAplicaCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoPago", "{0}")
        'GridView2.Columns("MontoPago").Summary.Add(item)
        'GridView2.Columns("MontoPago").SummaryItem.DisplayFormat = "{0:n2}"
        Me.txtDocumento.Text = gsDocumento
        Me.txtIDProveedor.EditValue = gIDProveedor
        Me.txtNombre.EditValue = gsNombre
        Me.txtMontoOriginal.EditValue = Math.Round(gdMontoOriginal, 2)
        Me.txtTipo.EditValue = gsClase
        Me.txtSaldoOriginal.EditValue = Math.Round(gdSaldo, 2)
        Me.txtDocumento.Text = gsDocumento
        Me.DateEditFecha.EditValue = gdFecha

        gbGridGargado = False
        Me.txtIDProveedor.ReadOnly = True
        Me.txtNombre.ReadOnly = True
        Me.txtDocumento.ReadOnly = True
        Me.txtMontoOriginal.ReadOnly = True
        Me.txtSaldoOriginal.ReadOnly = True
        Me.txtTipo.ReadOnly = True
        Me.txtTotalAbonadoDolar.ReadOnly = True
        Me.DateEditFecha.ReadOnly = True
        Me.txtMoneda.EditValue = gsMoneda
        'gdTipoCambio = Math.Round(gdTipoCambio, 2)
        Me.txtTipoCambio.EditValue = gdTipoCambio
        Me.txtMontoOrigConversion.EditValue = Math.Round(Me.txtMontoOriginal.EditValue / gdTipoCambio, 2)
        Dim td As New DataTable
        Dim sWhere As String = "IDMoneda=" & gIDMoneda.ToString()
        td = cManager.GetDataTable("globalMoneda", "IDMoneda, Descr, Nacional, Simbolo", sWhere, "IDMoneda")
        If CBool(td.Rows(0)("Nacional")) = True Then
            gsSimboloMonedaNacional = td.Rows(0)("Simbolo").ToString()
            gbMonedaCreditoNacional = True
            td = cManager.GetDataTable("globalMoneda", "IDMoneda, Descr, Nacional, Simbolo", "Nacional = 0", "IDMoneda")
            gsSimboloMonedaExtranjera = td.Rows(0)("Simbolo").ToString()
            lblMontoOriginal.Text = "Monto Original " & gsSimboloMonedaNacional
            Me.lblMontoOriginalConversion.Text = "Monto Original " & gsSimboloMonedaExtranjera
            ' Dolarizamos el monto y saldo de conversion
            Me.txtMontoOrigConversion.EditValue = Math.Round(Me.txtMontoOriginal.EditValue / gdTipoCambio, 2)
            txtSaldoConversion.EditValue = Math.Round(txtSaldoOriginal.EditValue / gdTipoCambio, 2)


            lblSaldoOriginal.Text = "Saldo Original " & gsSimboloMonedaNacional
            lblSaldoConversion.Text = "Saldo Original" & gsSimboloMonedaExtranjera
            Me.txtDisponibleDolar.EditValue = Math.Round(CDec(txtSaldoConversion.EditValue), 2)
            Me.txtDisponibleNacional.EditValue = Math.Round(CDec(txtSaldoOriginal.EditValue), 2)

            Me.lblTotalAbonadoDolar.Text = "Total Abonado " & gsSimboloMonedaExtranjera
            Me.lblTotalAbonadoNacional.Text = "Total Abonado " & gsSimboloMonedaNacional
            'Me.txtTotalAbonadoNacional.EditValue = Math.Round(txtTotalAbonadoDolar.EditValue / gdTipoCambio, 4)
        Else ' ES dolar la moneda del credito
            gsSimboloMonedaExtranjera = td.Rows(0)("Simbolo").ToString()
            td = cManager.GetDataTable("globalMoneda", "IDMoneda, Descr, Nacional, Simbolo", "Nacional = 1", "IDMoneda")
            gsSimboloMonedaNacional = td.Rows(0)("Simbolo").ToString()
            gbMonedaCreditoNacional = False
            lblMontoOriginal.Text = "Monto Original " & gsSimboloMonedaExtranjera
            Me.lblMontoOriginalConversion.Text = "Monto Original " & gsSimboloMonedaNacional
            ' Dolarizamos el monto y saldo de conversion
            Me.txtMontoOrigConversion.EditValue = Math.Round(Me.txtMontoOriginal.EditValue * gdTipoCambio, 2)
            txtSaldoConversion.EditValue = Math.Round(txtSaldoOriginal.EditValue * gdTipoCambio, 2)


            lblSaldoOriginal.Text = "Saldo Original " & gsSimboloMonedaExtranjera
            lblSaldoConversion.Text = "Saldo Original " & gsSimboloMonedaNacional

            Me.txtDisponibleDolar.EditValue = Math.Round(CDec(txtSaldoOriginal.EditValue), 2)
            Me.txtDisponibleNacional.EditValue = Math.Round(CDec(txtSaldoConversion.EditValue), 2)


            Me.lblTotalAbonadoDolar.Text = "Total Abonado " & gsSimboloMonedaExtranjera
            Me.lblTotalAbonadoNacional.Text = "Total Abonado " & gsSimboloMonedaNacional
        End If
        Me.txtTotalAbonadoNacional.EditValue = 0
        Me.txtTotalAbonadoNacional.EditValue = 0
        Me.txtDifDolar.EditValue = Math.Round(txtDisponibleDolar.EditValue - txtTotalAbonadoDolar.EditValue, 2)
        Me.txtDifNacional.EditValue = Math.Round(txtDisponibleNacional.EditValue - txtTotalAbonadoNacional.EditValue, 2)



        If gbAplicar Then
            Me.GridControl1.Visible = True
            Me.GridControl2.Visible = False
            gbGridGargado = True
            Me.btnReversaDocumento.Enabled = False
            Me.btnReversaAplicacion.Enabled = False
            Me.btnAplicar.Enabled = True
            RefreshGridToPay()
            FormatFieldsToGrid()
        Else
            'Me.btnReversaDocumento.Enabled = True
            'Me.btnReversaAplicacion.Enabled = True
            Me.btnAplicar.Enabled = False
            Me.Text = "Aplicaciones de un Débito"
            Me.GridControl1.Visible = False
            Me.GridControl2.Visible = True
            RefreshGridAplicacion()


        End If




    End Sub


    Sub FormatFieldsToGrid()
        If gbAplicar Then
            Me.GridView1.OptionsBehavior.ReadOnly = False
            Me.GridView1.OptionsBehavior.Editable = True
        Else
            Me.GridView1.OptionsBehavior.ReadOnly = True
            Me.GridView1.OptionsBehavior.Editable = False

        End If

        Me.GridView1.Columns("IDDebito").Visible = True
        Me.GridView1.Columns("IDDebito").OptionsColumn.AllowEdit = False
        Me.GridView1.Columns("IDDebito").Width = 60

        Me.GridView1.Columns("IDClase").Visible = True
        Me.GridView1.Columns("IDClase").OptionsColumn.AllowEdit = False
        Me.GridView1.Columns("IDClase").Width = 60

        Me.GridView1.Columns("IDSubTipo").Width = 60
        Me.GridView1.Columns("IDSubTipo").Visible = True
        Me.GridView1.Columns("IDSubTipo").OptionsColumn.AllowEdit = False

        Me.GridView1.Columns("Documento").Width = 100
        Me.GridView1.Columns("Documento").Visible = True
        Me.GridView1.Columns("Documento").OptionsColumn.AllowEdit = False

        Me.GridView1.Columns("Fecha").Width = 80
        Me.GridView1.Columns("Fecha").Visible = True
        Me.GridView1.Columns("Fecha").OptionsColumn.AllowEdit = False

        Me.GridView1.Columns("Vencimiento").Width = 80
        Me.GridView1.Columns("Vencimiento").Visible = True
        Me.GridView1.Columns("Vencimiento").OptionsColumn.AllowEdit = False

        Me.GridView1.Columns("DiasVencidos").Width = 80
        Me.GridView1.Columns("DiasVencidos").Visible = True
        Me.GridView1.Columns("DiasVencidos").OptionsColumn.AllowEdit = False


        Me.GridView1.Columns("Saldo").Visible = True
        Me.GridView1.Columns("Saldo").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns("Saldo").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns("Saldo").OptionsColumn.AllowEdit = False
        Me.GridView1.Columns("Saldo").Width = 120
        Me.GridView1.Columns("Saldo").DisplayFormat.FormatString = "n2"

        Me.GridView1.Columns("Abono").Visible = True
        Me.GridView1.Columns("Abono").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns("Abono").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridView1.Columns("Abono").Width = 120
        Me.GridView1.Columns("Abono").DisplayFormat.FormatString = "n2"
        Me.GridView1.Columns("Abono").OptionsColumn.ReadOnly = False
        Me.GridView1.Columns("Abono").OptionsColumn.AllowEdit = True


        ' Me.GridView1.Columns("Abono").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:c2}")

    End Sub


    Sub RefreshGridToPay()
        Try
            Dim sIDProvedor As String, sFecha As String, sIDDebito As String
            Dim sParametros As String

            sIDProvedor = gIDProveedor.ToString()
            'sFecha = gdFecha.ToString("yyyyMMdd")
            sFecha = Now.ToString("yyyyMMdd")
            sIDDebito = "0"
            sParametros = sIDProvedor + ",'" + sFecha + "',0"
            tableData = cManager.ExecSPgetData("cppPagarDocumentosxPagar", sParametros)
            If tableData.Rows.Count > 0 Then
                tableData.Columns("Abono").ReadOnly = False
            End If
            Me.GridControl1.DataSource = tableData
            GridControl1.Refresh()
            GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
            GridView1.ViewCaption = "Documentos Débitos a Pagar/Abonar"
            GridView1.Columns("Abono").ToolTip = "El Monto de Pago es siempre en la Moneda del Débito"

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub

    Sub RefreshGridAplicacion()
        Try
            Dim sParametros As String
            sParametros = gIDDocPago.ToString()
            tableData = cManager.ExecSPgetData("cppgetAplicacion", sParametros)
            Me.GridControl2.DataSource = tableData
            GridControl2.Refresh()
            If tableData.Rows.Count > 0 Then

                Me.btnReversaAplicacion.Enabled = True
               
            Else
                Me.btnReversaAplicacion.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            Dim dt As New DataTable
            Dim lbok As Boolean
            Dim sparameterValues As String
            Dim sSql As String

            If tableData.Rows.Count > 0 Then
                dt.Columns.Add("IDCredito")
                dt.Columns.Add("IDDebito")
                dt.Columns.Add("Pago")
                Dim strCriteria As String = "Abono > 0"
                Dim drSelect As DataRow() = tableData.Select(strCriteria)
                If drSelect.Length > 0 Then
                    cManager.batchSQLLista.Clear()
                    cManager.batchSQLitem.Clear()
                    Dim dTipoCambio As Decimal = gdTipoCambio
                    For Each row As DataRow In drSelect
                        sparameterValues = "'I', " & gIDDocPago.ToString() & "," & row("IDCredito").ToString() & ","
                        sparameterValues = sparameterValues & Math.Round(CDec(row("Abono")), 4).ToString() & ",'" & gsUsuario & "',"
                        sparameterValues = sparameterValues & gdTipoCambio.ToString()
                        sSql = cManager.CreateStoreProcSql("cppUpdateAplicaciones", sparameterValues)
                        Dim clase = New CbatchSQLIitem(sSql, False, False, False, False, "cppUpdateAplicaciones", "cppUpdateAplicaciones")

                        cManager.batchSQLitem.Add(sSql)
                        cManager.batchSQLLista.Add(clase)


                        Dim r As DataRow = dt.NewRow
                        r("IDCredito") = row("IDCredito")
                        r("IDDebito") = gIDDocPago
                        r("Pago") = Math.Round(CDec(row("Abono")), 4)
                        dt.Rows.Add(r)
                    Next
                End If
            End If
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("No se puede realizar la aplicacion porque no existen pagos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cManager.ExecCmdWithTransaction() Then
                lbok = True
                Me.GridView1.OptionsBehavior.ReadOnly = True
                Me.GridView1.OptionsBehavior.Editable = False
                btnAplicar.Enabled = False
                btnReversaAplicacion.Enabled = True
                btnReversaDocumento.Enabled = True
                Me.txtSaldoOriginal.EditValue = CDec(txtSaldoOriginal.EditValue) - CDec(txtTotalAbonadoDolar.EditValue)
                MessageBox.Show("Los Debitos han sido aplicados  exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub




    Private Sub GridView1_ValidateRow_1(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try

            Dim Saldo As Decimal = Convert.ToDecimal(GridView1.GetRowCellValue(e.RowHandle, "Saldo"))
            Dim Abono As Decimal = Convert.ToDecimal(GridView1.GetRowCellValue(e.RowHandle, "Abono"))
            If Abono <= 0 Then
                MessageBox.Show("El Abono debe ser un valor positivo... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
                TotalizaAbonos()
                Exit Sub
            End If
            Dim iIDMoneda As Integer = CInt(GridView1.GetRowCellValue(e.RowHandle, "IDMoneda"))
            Dim td As New DataTable
            Dim sWhere As String = "IDMoneda=" & iIDMoneda.ToString()
            td = cManager.GetDataTable("globalMoneda", "IDMoneda, Descr, Nacional, Simbolo", sWhere, "IDMoneda")
            Dim dAbonoNacional As Decimal
            Dim dAbonoDolar As Decimal
            Dim dSaldoNacional As Decimal = CDec(txtDisponibleNacional.EditValue)
            Dim dSaldoDolar As Decimal = CDec(txtDisponibleDolar.EditValue)

            If CBool(td.Rows(0)("Nacional")) = True Then ' moneda del debito es Cordoba
                dAbonoNacional = Abono
                dAbonoDolar = Math.Round(CDec(Abono / gdTipoCambio), 2)
                If txtDifNacional.EditValue = 0 And dAbonoDolar <> 0 Then
                    dAbonoDolar = 0
                End If

            Else ' La moneda del Debito es Dolar
                dAbonoNacional = Math.Round(Abono * gdTipoCambio, 2)
                If txtDifDolar.EditValue = 0 And dAbonoNacional <> 0 Then
                    dAbonoNacional = 0
                End If
                'If (dAbonoNacional - CDec(txtDifNacional.EditValue)) >= 0.0001 And (dAbonoNacional - CDec(txtDifNacional.EditValue)) <= 0.000999 Then
                '    dAbonoNacional = CDec(txtDifNacional.EditValue)
                'End If
                dAbonoDolar = Abono
            End If
            If (Abono > Saldo) Then
                MessageBox.Show("Ud no puede Abonar más que el saldo del Dédibo. Total Abonado : " & CDec(Abono).ToString() & " Saldo del Debito : " & CDec(Saldo).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
                TotalizaAbonos()
                Exit Sub
            End If
            If CBool(td.Rows(0)("Nacional")) = False Then
                If Abono > Me.txtDifDolar.EditValue Then
                    MessageBox.Show("Ud no puede Abonar más que el saldo del Credito. Saldo del Credito en $ : " & CDec(Me.txtDifDolar.EditValue).ToString() & " en C$ " & CDec(Me.txtDifDolar.EditValue).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
                    TotalizaAbonos()
                    Exit Sub
                End If

            End If

            If CBool(td.Rows(0)("Nacional")) = True Then
                If Abono > Me.txtDifNacional.EditValue Then
                    MessageBox.Show("Ud no puede Abonar más que el saldo del Credito. Saldo del Credito en $ : " & CDec(Me.txtDifNacional.EditValue).ToString() & " en C$ " & CDec(Me.txtDifNacional.EditValue).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
                    TotalizaAbonos()
                    Exit Sub
                End If

            End If

            If (Math.Round(dAbonoNacional, 2) > Math.Round(Me.txtDifNacional.EditValue, 2)) Or (Math.Round(dAbonoDolar, 2) > Math.Round(Me.txtDifDolar.EditValue, 2)) Then  '(dAbonoNacional > dSaldoNacional) Or (dAbonoDolar > dSaldoDolar) Then
                MessageBox.Show("Ud no puede Abonar más que el saldo del Credito. Saldo del Credito en $ : " & CDec(Me.txtDifDolar.EditValue).ToString() & " en C$ " & CDec(Me.txtDifNacional.EditValue).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
                TotalizaAbonos()
                Exit Sub
            End If

            'If (dAbonoNacional + CDec(Me.txtTotalAbonadoNacional.EditValue) > dSaldoNacional) Or (dAbonoDolar + CDec(Me.txtTotalAbonadoDolar.EditValue) > dSaldoDolar) Then
            '    MessageBox.Show("Ud no puede Abonar más que el saldo del Credito. Saldo del Credito en $ : " & CDec(dSaldoDolar).ToString() & " en C$ " & CDec(dSaldoNacional).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, 0)
            '    Exit Sub
            'End If
            'txtTotalAbonado.EditValue = getTotalAbono()
            TotalizaAbonos()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If tableData.Rows.Count > 0 Then
            gdTotalAbono = Me.tableData.Compute("Sum(Abono)", "")

        End If
    End Sub
    Private Function getTotalAbono() As Decimal
        gdTotalAbono = Me.tableData.Compute("Sum(Abono)", "")
        getTotalAbono = gdTotalAbono
    End Function

    Private Sub TotalizaAbonos()
        Dim td As New DataTable
        Dim sWhere As String
        gdTotalAbonoExtranjero = 0
        gdTotalAbonoNacional = 0
        If tableData.Rows.Count > 0 Then
            For Each dr In tableData.Rows

                sWhere = "IDMoneda=" & dr("IDMoneda").ToString()
                td = cManager.GetDataTable("globalMoneda", "IDMoneda, Descr, Nacional, Simbolo", sWhere, "IDMoneda")

                'If CDec(dr("Abono")) > 0 Then
                If CBool(td.Rows(0)("Nacional")) Then
                    gdTotalAbonoExtranjero = gdTotalAbonoExtranjero + CDec(dr("Abono")) / gdTipoCambio
                    gdTotalAbonoNacional = gdTotalAbonoNacional + CDec(dr("Abono"))
                Else
                    gdTotalAbonoExtranjero = gdTotalAbonoExtranjero + CDec(dr("Abono"))
                    gdTotalAbonoNacional = gdTotalAbonoNacional + CDec(dr("Abono")) * gdTipoCambio
                End If

                'End If
            Next dr
            'If Math.Round(gdTotalAbonoExtranjero, 4) > 0 And Math.Round(gdTotalAbonoNacional, 4) > 0 Then
            If DiferenciaDecimal(gdTotalAbonoNacional, txtDisponibleNacional.EditValue) Then
                gdTotalAbonoNacional = txtDisponibleNacional.EditValue
            End If
            If DiferenciaDecimal(gdTotalAbonoExtranjero, txtDisponibleDolar.EditValue) Then
                gdTotalAbonoExtranjero = txtDisponibleDolar.EditValue
            End If
            txtTotalAbonadoDolar.EditValue = Math.Round(gdTotalAbonoExtranjero, 4)
            txtTotalAbonadoNacional.EditValue = Math.Round(gdTotalAbonoNacional, 4)
            Me.txtDifDolar.EditValue = Math.Round(CDec(Me.txtDisponibleDolar.EditValue) - gdTotalAbonoExtranjero, 4)
            Me.txtDifNacional.EditValue = Math.Round(CDec(Me.txtDisponibleNacional.EditValue) - gdTotalAbonoNacional, 4)
            'txtDisponibleDolar.EditValue = Math.Round(CDec(txtDisponibleDolar.EditValue) - gdTotalAbonoExtranjero, 4)
            'txtDisponibleNacional.EditValue = Math.Round(CDec(txtDisponibleNacional.EditValue) - gdTotalAbonoNacional, 4)
            'If gbMonedaCreditoNacional Then
            '    Me.txtSaldoOriginal.EditValue = Math.Round(CDec(txtSaldoOriginal.EditValue) - gdTotalAbonoExtranjero, 4)
            'End If

            'Me.txtSaldoConversion.EditValue = Math.Round(CDec(Me.txtSaldoConversion.EditValue) - gdTotalAbonoNacional, 4)
            'End If

        End If
    End Sub


    'Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        GridView1.UpdateCurrentRow()
    '    End If
    'End Sub

    Private Sub GridView2_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView2.FocusedColumnChanged
        Dim dr As DataRow = GridView2.GetFocusedDataRow()
        If dr IsNot Nothing Then
            Me.btnReversaDocumento.Enabled = True
            Me.btnReversaAplicacion.Enabled = True
        Else
            Me.btnReversaDocumento.Enabled = False
            btnReversaAplicacion.Enabled = False
        End If
    End Sub

    Private Sub btnReversaDocumento_Click(sender As Object, e As EventArgs) Handles btnReversaDocumento.Click

        Dim dr As DataRow = GridView2.GetFocusedDataRow()
        Try

            If dr IsNot Nothing Then
                If MessageBox.Show("Está seguro de eliminar  la Aplicacion para el Documento  " & dr("DocCredito").ToString(), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    Exit Sub
                End If

                Dim sParametros As String = "0," & dr("IDAplicacion").ToString()
                If cManager.ExecSP("cppDesAplicar", sParametros) Then
                    MessageBox.Show("El Documento ha sido Desaplicado  exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefreshGridAplicacion()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReversaAplicacion_Click(sender As Object, e As EventArgs) Handles btnReversaAplicacion.Click
        If MessageBox.Show("Está seguro de eliminar Toda la Aplicacion del Credito  " & Me.txtDocumento.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
            Exit Sub
        End If
        Dim dr As DataRow = GridView2.GetFocusedDataRow()
        Try
            If dr IsNot Nothing Then
                Dim sParametros As String = gIDDocPago.ToString() & ",0"
                If cManager.ExecSP("cppDesAplicar", sParametros) Then
                    MessageBox.Show("La Aplicacion ha sido Desaplicada totalmente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class