Imports Clases
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmConsultaFacturas
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gbAnular As Boolean = False
    Public gbDevolucion As Boolean = False
    Public gbReimprimir As Boolean = False
    Dim lIDFactura As Int64 = 0
    Dim lbAnulada As Boolean
    Dim sIDCliente As String
    Dim sFactura As String = ""
    Private Sub frmConsultaFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotalFinal", "{0}")
        GridViewHeader.Columns("SubTotalFinal").Summary.Add(item)
        GridViewHeader.Columns("SubTotalFinal").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item2 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFinal", "{0}")
        GridViewHeader.Columns("TotalFinal").Summary.Add(item2)
        GridViewHeader.Columns("TotalFinal").SummaryItem.DisplayFormat = "{0:n2}"
        DateEditHasta.EditValue = Now
        DateEditDesde.EditValue = Now.AddDays(-30)
    End Sub
    Sub RefreshGrid()
        Try
            Dim sParameters As String
            Dim sFechadesde As String = CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd")
            Dim sFechaHasta As String = CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd")
            If txtCliente.Text <> "" Then
                sIDCliente = txtCliente.Text
            Else
                sIDCliente = "0"
            End If
            sParameters = "'" & sFechadesde & "','" & sFechaHasta & "'" & "," & sIDCliente
            tableData = cManager.ExecSPgetData("fafgetFacturasHeader", sParameters)
            GridHeader.DataSource = tableData
            GridHeader.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtCliente.Text = ""
        txtNombre.Text = ""
        sIDCliente = "0"
    End Sub



    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim frm As New frmPopupCliente()
        frm.gsIDSucursal = gsSucursal
        frm.ShowDialog()
        Me.txtCliente.EditValue = frm.gsIDCliente
        Me.txtNombre.EditValue = frm.gsNombre
        frm.Dispose()
    End Sub


    Private Sub AnularFactura()
        Try
            If lIDFactura = 0 Then
                MessageBox.Show("Ud. debe seleccionar una Factura... por favor revise su filtro", "Advertencia", MessageBoxButtons.OK)
                Exit Sub
            End If
            If lbAnulada Then
                MessageBox.Show("Ya Factura seleccionada ya fue anulada ... por favor revise", "Advertencia", MessageBoxButtons.OK)
                Exit Sub
            End If
            If MessageBox.Show("Ud va a ANULAR la factura seleccionada " & sFactura & "  Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            cManager.ExecSP("fafAnulaFactura", lIDFactura.ToString())
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al Anular la Factura : " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub GridViewHeader_FocusedRowChanged(sender As Object, e As Views.Base.FocusedRowChangedEventArgs) Handles GridViewHeader.FocusedRowChanged
        Dim dr As DataRow = GridViewHeader.GetFocusedDataRow()
        If dr IsNot Nothing Then
            lIDFactura = CInt(dr("IDFactura"))
            lbAnulada = CBool(dr("Anulada"))
            sFactura = dr("Factura").ToString()
        End If
    End Sub

    Private Sub PrintReport(pIDFactura As Int64, psMontoFactura As String)

        Dim tableDataLote As DataTable
        tableDataLote = cManager.ExecSPgetData("fafPrintFacturaLote", pIDFactura.ToString())
        tableDataLote.TableName = "fafPrintFacturaLote"
        tableData = cManager.ExecSPgetData("fafgetFacturaHeader", pIDFactura.ToString())
        tableData.TableName = "fafgetFacturaHeader"

        If tableData.Rows.Count > 0 Then

            Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptFacturaFinal.repx", True)

            Dim ds As New DataSet
            ds.Tables.Add(tableDataLote)
            ds.Tables.Add(tableData)

            report.DataSource = vbNull
            report.DataSource = ds
            report.DataMember = "fafPrintFacturaLote"
            report.Parameters(0).Value = pIDFactura
            report.Parameters(1).Value = psMontoFactura

            If gParametros.FacturaPersonalizada Then
                report.PaperKind = System.Drawing.Printing.PaperKind.Custom
                report.ReportUnit = ReportUnit.TenthsOfAMillimeter
                report.PageHeight = gParametros.paginaFacturaAltura * 100
                report.PageWidth = gParametros.paginaFacturaAncho * 100
            Else
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
            End If
            Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)

            tool.ShowPreview()
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs)
        PrintReport(lIDFactura, "REIMPRESIOIN - REIMPRESION - REIMPRESION - NO OFICIAL ")
    End Sub

    Private Sub DevolverProductoFactura()
        Try
            If lIDFactura = 0 Then
                MessageBox.Show("Ud. debe seleccionar una Factura... por favor revise su filtro", "Advertencia", MessageBoxButtons.OK)
                Exit Sub
            End If
            If lIDFactura <> 0 Then
                If lbAnulada Then
                    MessageBox.Show("La Factura seleccionada ya fue Anulada ... por favor revise, no se puede Devolver una Factura Anulada", "Advertencia", MessageBoxButtons.OK)
                    Exit Sub
                End If
                Dim frm As New frmDevolucion
                frm.giIDFactura = lIDFactura
                frm.gsConsecMask = "D"
                frm.ShowDialog()
                frm.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al Preparar la Devolución : " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BarButtonItemAnula_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAnula.ItemClick
        AnularFactura()
    End Sub

    Private Sub BarButtonItemDevolver_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDevolver.ItemClick
        DevolverProductoFactura()
    End Sub

    Private Sub BarButtonItemLimpiaFiltro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLimpiaFiltro.ItemClick
        DateEditHasta.EditValue = Now
        DateEditDesde.EditValue = Now.AddDays(-30)
        txtCliente.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        RefreshGrid()
    End Sub



End Class