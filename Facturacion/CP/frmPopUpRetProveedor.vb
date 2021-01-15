Imports Clases
Public Class frmPopUpRetProveedor
    Public gsIDProveedor As String
    Public gsNombreProveedor As String
    Public gsDocumento As String
    Dim currentRow As DataRow
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim gbAsignadaProveedor As Boolean
    Dim gbAplicada As Boolean
    Public gsIDRetenciones As String = ""

    Private Sub frmPopUpRetProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
    Sub RefreshGrid()
        Try
            tableData = cManager.ExecSPgetData("cppgetPopUpRetenciones", gsIDProveedor)
            GridControl1.DataSource = tableData
            GridControl1.Refresh()
            SetCheckedItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub GridViewProveedor_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProveedor.FocusedRowChanged
        Dim dr As DataRow = GridViewProveedor.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then
            gbAplicada = CBool(dr("Aplicada"))
            gbAsignadaProveedor = CBool(dr("AsignadaProveedor"))
        End If
    End Sub

    Private Sub SetCheckedItems()
        For i As Integer = 0 To GridViewProveedor.DataRowCount - 1

            If CBool(Me.GridViewProveedor.GetRowCellValue(i, "AsignadaProveedor")) = True And CBool(Me.GridViewProveedor.GetRowCellValue(i, "Aplicada")) = False Then
                Me.GridViewProveedor.SelectRow(i)
            End If
        Next
    End Sub

    Private Sub GetCheckedItems()
        Dim Rows As New ArrayList()

        ' Add the selected rows to the list. 
        Dim selectedRowHandles As Int32() = Me.GridViewProveedor.GetSelectedRows()
        Dim I As Integer
        gsIDRetenciones = ""
        If selectedRowHandles.Length > 0 Then
            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                If (selectedRowHandle >= 0) Then

                    Dim dataRow As DataRow = GridViewProveedor.GetDataRow(selectedRowHandle)
                    If CBool(dataRow("Aplicada")) = False Then
                        Dim sParametros As String = dataRow("IDRetencion").ToString & "," & gsIDProveedor   'Rows(1).ToString() & "', " & Rows(0).ToString()
                        gsIDRetenciones = gsIDRetenciones & dataRow("IDRetencion").ToString & ","
                    End If
                End If

            Next
            gsIDRetenciones = gsIDRetenciones.TrimEnd(",")
            Me.Close()

        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAplicaRetenciones_Click(sender As Object, e As EventArgs) Handles cmdAplicaRetenciones.Click
        GetCheckedItems()
    End Sub

    Private Sub GridViewProveedor_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridViewProveedor.SelectionChanged
        Dim selectedRowHandles As Int32() = Me.GridViewProveedor.GetSelectedRows()
        Dim I As Integer
        If selectedRowHandles.Length > 0 Then
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                If (selectedRowHandle >= 0) Then

                    Dim dataRow As DataRow = GridViewProveedor.GetDataRow(selectedRowHandle)
                If CBool(dataRow("Aplicada")) = True Then
                    GridViewProveedor.UnselectRow(selectedRowHandle)

                End If
                End If
        End If

    End Sub
End Class