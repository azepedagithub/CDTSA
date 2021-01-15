Imports Clases
Imports DevExpress.XtraGrid
Public Class frmPopupFactura
    Public gIDFactura As Integer
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim tableDataDetalle As New DataTable()
    Dim currentRow As DataRow
    Private Sub frmPopupFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFinal", "{0}")
        GridViewDetalle.Columns("TotalFinal").Summary.Add(item)
        GridViewDetalle.Columns("TotalFinal").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item2 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0}")
        GridViewDetalle.Columns("SubTotal").Summary.Add(item2)
        GridViewDetalle.Columns("SubTotal").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item3 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0}")
        GridViewDetalle.Columns("Descuento").Summary.Add(item3)
        GridViewDetalle.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item4 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DescuentoEspecial", "{0}")
        GridViewDetalle.Columns("DescuentoEspecial").Summary.Add(item4)
        GridViewDetalle.Columns("DescuentoEspecial").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item5 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Impuesto", "{0}")
        GridViewDetalle.Columns("Impuesto").Summary.Add(item5)
        GridViewDetalle.Columns("Impuesto").SummaryItem.DisplayFormat = "{0:n2}"
        Dim item6 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotalFinal", "{0}")
        GridViewDetalle.Columns("SubTotalFinal").Summary.Add(item6)
        GridViewDetalle.Columns("SubTotalFinal").SummaryItem.DisplayFormat = "{0:n2}"
        RefreshGrid()

        Me.DateEditFecha.ReadOnly = True
    End Sub

    Sub RefreshGrid()
        Try
            Dim sParameters As String
            If gIDFactura <> 0 Then
                sParameters = gIDFactura.ToString()
                tableData = cManager.ExecSPgetData("fafPrintFacturaLote", sParameters)
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = tableData
                If tableData.Rows.Count > 0 Then
                    GridControl1.Refresh()
                End If
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub GridViewDetalle_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewDetalle.FocusedRowChanged
        Dim index As Integer = GridViewDetalle.FocusedRowHandle
        If index > -1 Then
            Dim dr As DataRow = GridViewDetalle.GetFocusedDataRow()
            currentRow = dr
            If dr IsNot Nothing Then
                txtCliente.EditValue = dr("Nombre").ToString()
                txtFactura.EditValue = dr("Factura").ToString()
                txtMoneda.EditValue = dr("DescrMoneda").ToString()
                txtTipoCambio.EditValue = CDec(dr("TipoCambio"))
                txtVendedor.EditValue = dr("NombreVendedor").ToString()
                TxtEditTipo.EditValue = dr("DescrTipo").ToString()
                DateEditFecha.EditValue = CDate(dr("Fecha"))
            End If
        End If

    End Sub
End Class