Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration
Imports Clases
Public Class frmCCFFiltroReportes
    Public iReporte As Integer
    Public gsNombreReporte As String
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Private Sub frmCCFFiltroReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargagridLookUpsFromTables()
        disableControls()
        Dim firstDay = New DateTime(Now.Year, Now.Month, 1)
        Me.DateEditFechaInicial.EditValue = firstDay
        Me.DateEditFechaFinal.EditValue = Now

        Me.GroupControl1.Text = gsNombreReporte
        If iReporte = CrptMovimientos Then
            Me.SearchLookUpEditSucursal.Enabled = True
            Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDCliente.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaInicial.Enabled = True
            'Me.DateEditFechaInicial.EditValue = Now
            Me.DateEditFechaFinal.Enabled = True
            'Me.DateEditFechaFinal.EditValue = Now
        End If
        If iReporte = CrptDocumentosPorCobrar Then
            Me.SearchLookUpEditSucursal.Enabled = True
            Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDCliente.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaFinal.Enabled = True
            'Me.DateEditFechaFinal.EditValue = Now
            Me.lblFechaFin.Text = "Fecha Corte"
            Me.lblFechaFin.Refresh()
        End If
        If iReporte = CrptDesglosePagos Then
            Me.SearchLookUpEditSucursal.Enabled = True
            Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDCliente.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaInicial.Enabled = True
            Me.DateEditFechaFinal.Enabled = True
            
        End If
        If iReporte = CrptAnalisisVencimiento Then
            Me.SearchLookUpEditSucursal.Enabled = True
            Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDCliente.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaFinal.Enabled = True
            'Me.DateEditFechaFinal.EditValue = Now
            Me.lblFechaFin.Text = "Fecha Corte"
            Me.lblFechaFin.Refresh()
            Me.CheckEditConsolidaSucursal.Enabled = True
            Me.CheckEditDolar.Enabled = True
        End If


        If iReporte = CrptAnalisisVencimientoSucursal Then
            Me.SearchLookUpEditSucursal.Enabled = True
            Me.SearchLookUpEditVendedor.Enabled = False
            Me.txtIDCliente.Enabled = False
            Me.btnCliente.Enabled = False
            Me.txtNombre.Enabled = False
            Me.DateEditFechaFinal.Enabled = True
            'Me.DateEditFechaFinal.EditValue = Now
            Me.lblFechaFin.Text = "Fecha Corte"
            Me.lblFechaFin.Refresh()
            Me.CheckEditConsolidaSucursal.Enabled = False
            Me.CheckEditDolar.Enabled = True
        End If

    End Sub

    Sub CargagridLookUpsFromTables()
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
    End Sub
    Private Sub disableControls()
        Me.SearchLookUpEditSucursal.Enabled = False
        Me.SearchLookUpEditVendedor.Enabled = False
        Me.txtIDCliente.Enabled = False
        Me.txtNombre.Enabled = False
        Me.btnCliente.Enabled = False
        Me.DateEditFechaInicial.Enabled = False
        Me.DateEditFechaFinal.Enabled = False
        Me.CheckEditConsolidaSucursal.Enabled = False
        Me.CheckEditDolar.Enabled = False
    End Sub

    Private Sub PrintReport(iReporte As Integer)
        Dim sParameters As String
        If iReporte = CrptMovimientos Then
            If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Sucursal, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaInicial.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Inicial, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & txtIDCliente.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaInicial.EditValue).ToString("yyyyMMdd") & "'"
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'"
            tableData = cManager.ExecSPgetData("ccfrptMovimientos", sParameters)
            If tableData.Rows.Count > 0 Then

                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reporte/Factura/rptMovimientos.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "ccfrptMovimientos"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psCliente").Value = Me.txtIDCliente.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                report.Parameters("pdFechaInicial").Value = Me.DateEditFechaInicial.EditValue
                report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)

                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If
        ' Reporte que necesita un campo calculado AGREGATE SUM..., se llama el store dentro del Reporte y no se pasa el Datatable
        If iReporte = CrptDocumentosPorCobrar Then
            If Me.txtIDCliente.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Cliente, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final o Corte, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = Me.txtIDCliente.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "',0"
            tableData = cManager.ExecSPgetData("ccfDocumentosxCobrar", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reporte/Factura/rptDocumentosCobrar.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "ccfDocumentosxCobrar"

                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psCliente").Value = Me.txtIDCliente.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                report.Parameters("piIDCliente").Value = CInt(Me.txtIDCliente.EditValue)
                report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

        If iReporte = CrptDesglosePagos Then

            If Me.txtIDCliente.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Cliente, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Sucursal, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditVendedor.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Vendedor, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Me.DateEditFechaInicial.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Inicial, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            sParameters = txtIDCliente.EditValue.ToString() & "," & Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & Me.SearchLookUpEditVendedor.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaInicial.EditValue).ToString("yyyyMMdd") & "'"
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'"
            tableData = cManager.ExecSPgetData("ccfrptDesglosePagos", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reporte/Factura/rptDesglosePagos.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "ccfrptDesglosePagos"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psCliente").Value = Me.txtIDCliente.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                report.Parameters("piIDCliente").Value = CInt(Me.txtIDCliente.EditValue)
                report.Parameters("piIDBodega").Value = CInt(Me.SearchLookUpEditSucursal.EditValue)
                report.Parameters("piIDVendedor").Value = CInt(Me.SearchLookUpEditVendedor.EditValue)
                report.Parameters("pdFechaInicial").Value = Me.DateEditFechaInicial.EditValue
                report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
        If iReporte = CrptAnalisisVencimiento Then

            If Me.txtIDCliente.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Cliente, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Sucursal, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = txtIDCliente.EditValue.ToString() & "," & Me.SearchLookUpEditSucursal.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'"
            tableData = cManager.ExecSPgetData("ccfrptAntiguedadSaldosPorCliente", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reporte/Factura/rptAnalisisVencimiento.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "ccfrptAntiguedadSaldosPorCliente"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                If Me.txtIDCliente.EditValue IsNot Nothing And txtIDCliente.Text <> "" Then
                    report.Parameters("psCliente").Value = Me.txtIDCliente.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                    report.Parameters("piIDCliente").Value = CInt(Me.txtIDCliente.EditValue)
                Else
                    report.Parameters("psCliente").Value = "Todos los Clientes"
                    report.Parameters("piIDCliente").Value = 0
                End If
                If Me.SearchLookUpEditSucursal.EditValue IsNot Nothing And SearchLookUpEditSucursal.Text <> "" Then
                    report.Parameters("piIDBodega").Value = CInt(Me.SearchLookUpEditSucursal.EditValue)
                Else
                    report.Parameters("piIDBodega").Value = 0
                End If
                If Me.DateEditFechaFinal.EditValue IsNot Nothing And Me.DateEditFechaFinal.Text <> "" Then
                    report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                Else
                    report.Parameters("pdFechaFinal").Value = Now
                End If


                report.Parameters("piConsolidaSucursal").Value = CBool(Me.CheckEditConsolidaSucursal.EditValue)
                report.Parameters("piEnDolar").Value = IIf(CBool(Me.CheckEditDolar.EditValue) = True, 1, 0)
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter

                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
        If iReporte = CrptAnalisisVencimientoSucursal Then
            Dim sMoneda As String, iIDBodega As Integer, iDolar As Integer
            If Me.CheckEditDolar.EditValue Then
                sMoneda = "DOLAR"
            Else
                sMoneda = "CORDOBA"
            End If
            If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
                iIDBodega = 0
            Else
                iIDBodega = CInt(Me.SearchLookUpEditSucursal.EditValue)
            End If
            If CBool(Me.CheckEditDolar.EditValue) Then
                iDolar = 1
            Else
                iDolar = 0
            End If
            sParameters = "0," & iIDBodega.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'," & iDolar.ToString()
            tableData = cManager.ExecSPgetData("ccfrptAntiguedadSaldosPorSucursal", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reporte/Factura/rptAntiguedadSaldosSucursal.repx", True)
                report.Parameters("psEmpresa").Value = gsNombreEmpresa

                report.Parameters("psMoneda").Value = sMoneda
                report.Parameters("piIDCliente").Value = 0

                report.Parameters("piIDBodega").Value = iIDBodega

                report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue

                report.Parameters("pbDolar").Value = CBool(Me.CheckEditDolar.EditValue)
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter

                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintReport(iReporte)
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
                Me.txtIDCliente.EditValue = frm.gsIDCliente
                Me.txtNombre.EditValue = frm.gsNombre
                Me.SearchLookUpEditSucursal.EditValue = CInt(frm.gsIDSucursal)
                Me.SearchLookUpEditVendedor.EditValue = CInt(frm.gsVendedor)
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearControls()
        Me.SearchLookUpEditSucursal.Text = ""
        Me.SearchLookUpEditVendedor.Text = ""
        Me.txtIDCliente.Text = ""
        Me.txtNombre.Text = ""

        Me.DateEditFechaInicial.Text = ""
        Me.DateEditFechaFinal.Text = ""
        Me.CheckEditConsolidaSucursal.EditValue = False
        Me.CheckEditDolar.EditValue = False
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearControls()
    End Sub
End Class