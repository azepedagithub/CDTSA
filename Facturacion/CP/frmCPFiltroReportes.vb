Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration
Imports Clases
Public Class frmCPFiltroReportes
    Public iReporte As Integer
    Public gsNombreReporte As String
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Private Sub frmCPFiltroReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargagridLookUpsFromTables()
        disableControls()
        Dim firstDay = New DateTime(Now.Year, Now.Month, 1)
        Me.DateEditFechaInicial.EditValue = firstDay
        Me.DateEditFechaFinal.EditValue = Now

        Me.GroupControl1.Text = gsNombreReporte
        If iReporte = CrptMovimientos Then
            'Me.SearchLookUpEditSucursal.Enabled = True
            'Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDProveedor.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaInicial.Enabled = True

            Me.DateEditFechaFinal.Enabled = True

        End If
        If iReporte = CrptDocumentosPorPagar Then
            'Me.SearchLookUpEditSucursal.Enabled = True
            'Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDProveedor.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaFinal.Enabled = True

            Me.lblFechaFin.Text = "Fecha Corte"
            Me.lblFechaFin.Refresh()
        End If
        If iReporte = CrptDesglosePagos Then
            'Me.SearchLookUpEditSucursal.Enabled = True
            'Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDProveedor.Enabled = True
            Me.btnCliente.Enabled = True
            Me.txtNombre.Enabled = True
            Me.DateEditFechaInicial.Enabled = True
            Me.DateEditFechaFinal.Enabled = True

        End If
        If iReporte = CrptAnalisisVencimiento Then
            'Me.SearchLookUpEditSucursal.Enabled = True
            'Me.SearchLookUpEditVendedor.Enabled = True
            Me.txtIDProveedor.Enabled = True
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
            'Me.SearchLookUpEditSucursal.Enabled = True
            'Me.SearchLookUpEditVendedor.Enabled = False
            Me.txtIDProveedor.Enabled = False
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
        'CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        'CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
    End Sub
    Private Sub disableControls()
        'Me.SearchLookUpEditSucursal.Enabled = False
        'Me.SearchLookUpEditVendedor.Enabled = False
        Me.txtIDProveedor.Enabled = False
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

            If Me.DateEditFechaInicial.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Inicial, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = txtIDProveedor.EditValue.ToString() & ",'" & CDate(Me.DateEditFechaInicial.EditValue).ToString("yyyyMMdd") & "'"
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'"
            tableData = cManager.ExecSPgetData("cpprptMovimientos", sParameters)
            If tableData.Rows.Count > 0 Then

                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./rptMovimientos.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "cpprptMovimientos"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psProveedor").Value = Me.txtIDProveedor.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
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
        If iReporte = CrptDocumentosPorPagar Then
            If Me.txtIDProveedor.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Cliente, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final o Corte, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = Me.txtIDProveedor.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "',0"
            tableData = cManager.ExecSPgetData("cppDocumentosxPagar", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./rptDocumentosxPagar.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "cppDocumentosxPagar"

                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psProveedor").Value = Me.txtIDProveedor.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                report.Parameters("piIDProveedor").Value = CInt(Me.txtIDProveedor.EditValue)
                report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
                Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
                tool.ShowPreview()
            Else
                MessageBox.Show("No existe registros con ese criterio de Filtro, por favor revise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

        If iReporte = CrptDesglosePagos Then

            If Me.txtIDProveedor.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Cliente, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            sParameters = txtIDProveedor.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaInicial.EditValue).ToString("yyyyMMdd") & "'"
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'"
            tableData = cManager.ExecSPgetData("cpprptDesglosePagos", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./rptDesglosePagos.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "cpprptDesglosePagos"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                report.Parameters("psProveedor").Value = Me.txtIDProveedor.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                report.Parameters("piIDProveedor").Value = CInt(Me.txtIDProveedor.EditValue)
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

            If Me.txtIDProveedor.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar un Proveedor, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
            '    MessageBox.Show("Debe seleccionar una Sucursal, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return
            'End If
            If Me.DateEditFechaFinal.EditValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una Fecha Final, por favor proceda ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sParameters = txtIDProveedor.EditValue.ToString()  '& Me.SearchLookUpEditSucursal.EditValue.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'," & IIf(Me.CheckEditDolar.Checked = True, "1", "0")
            tableData = cManager.ExecSPgetData("cpprptAntiguedadSaldosPorProveedor", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./rptAnalisisVencimiento.repx", True)
                report.DataSource = vbNull
                report.DataSource = tableData
                report.DataMember = "cpprptAntiguedadSaldosPorProveedor"
                report.Parameters("psEmpresa").Value = gsNombreEmpresa
                If Me.txtIDProveedor.EditValue IsNot Nothing And txtIDProveedor.Text <> "" Then
                    report.Parameters("psProveedor").Value = Me.txtIDProveedor.EditValue.ToString() & " - " & txtNombre.EditValue.ToString()
                    report.Parameters("piIDProveedor").Value = CInt(Me.txtIDProveedor.EditValue)
                Else
                    report.Parameters("psProveedor").Value = "Todos los Proveedores"
                    report.Parameters("piIDProveedor").Value = 0
                End If
                'If Me.SearchLookUpEditSucursal.EditValue IsNot Nothing And SearchLookUpEditSucursal.Text <> "" Then
                '    report.Parameters("piIDBodega").Value = CInt(Me.SearchLookUpEditSucursal.EditValue)
                'Else
                '    report.Parameters("piIDBodega").Value = 0
                'End If
                If Me.DateEditFechaFinal.EditValue IsNot Nothing And Me.DateEditFechaFinal.Text <> "" Then
                    report.Parameters("pdFechaFinal").Value = Me.DateEditFechaFinal.EditValue
                Else
                    report.Parameters("pdFechaFinal").Value = Now
                End If

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
            'If Me.SearchLookUpEditSucursal.EditValue Is Nothing Then
            '    iIDBodega = 0
            'Else
            '    iIDBodega = CInt(Me.SearchLookUpEditSucursal.EditValue)
            'End If
            If CBool(Me.CheckEditDolar.EditValue) Then
                iDolar = 1
            Else
                iDolar = 0
            End If
            sParameters = "0," & iIDBodega.ToString()
            sParameters = sParameters & ",'" & CDate(Me.DateEditFechaFinal.EditValue).ToString("yyyyMMdd") & "'," & iDolar.ToString()
            tableData = cManager.ExecSPgetData("ccfrptAntiguedadSaldosPorSucursal", sParameters)
            If tableData.Rows.Count > 0 Then
                Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptAntiguedadSaldosSucursal.repx", True)
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
        CallPopUpProveedores()
    End Sub
    Private Sub CallPopUpProveedores()
        Try

            Dim frm As New frmPopupProveedor()
            frm.gsIDSucursal = 0
            frm.ShowDialog()
            If frm.gsIDProveedor <> "" Then
                Me.txtIDProveedor.EditValue = frm.gsIDProveedor
                Me.txtNombre.EditValue = frm.gsNombre

            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearControls()
        'Me.SearchLookUpEditSucursal.Text = ""
        'Me.SearchLookUpEditVendedor.Text = ""
        Me.txtIDProveedor.Text = ""
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