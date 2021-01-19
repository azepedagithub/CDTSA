Imports Clases
Imports DevExpress.XtraGrid

Public Class frmPopUpRetProveedor
    Public gsIDProveedor As String
    Public gsIDCredito As String
    Public gsNombreProveedor As String
    Public gsDocumento As String
    Public gbExisteDocumentoDeuda As Boolean = False ' Popup de Retenciones de un Docunento que no existe, se crearan ambos a la vez
    Dim currentRow As DataRow
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim gbAsignadaProveedor As Boolean
    Dim gbAplicada As Boolean
    Public gsIDRetenciones As String = ""

    Private Sub frmPopUpRetProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Retenciones Proveedor " & gsNombreProveedor & " en el Documento " & gsDocumento
        Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoRetenido", "{0}")
        Me.GridViewProveedor.Columns("MontoRetenido").Summary.Add(item)
        GridViewProveedor.Columns("MontoRetenido").SummaryItem.DisplayFormat = "{0:n2}"
        RefreshGrid()
    End Sub
    Sub RefreshGrid()
        Try
            Dim sParametros As String = gsIDProveedor & "," & gsIDCredito
            tableData = cManager.ExecSPgetData("cppgetPopUpRetenciones", sParametros)
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
        Try
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
                If gbExisteDocumentoDeuda Then
                    Dim sParametros As String = gsIDCredito & ",'" & gsIDRetenciones & "'"

                    cManager.batchSQLLista.Clear()
                    cManager.batchSQLitem.Clear()
                    Dim sSql As String
                    sSql = cManager.CreateStoreProcSql("cppCreaRetenciones", sParametros)
                    Dim clase = New CbatchSQLIitem(sSql, False, False, False, False, "cppCreaRetenciones", "cppCreaRetenciones")
                    cManager.batchSQLitem.Add(sSql)
                    cManager.batchSQLLista.Add(clase)
                    If Not cManager.ExecCmdWithTransaction() Then

                        MessageBox.Show("Ocurrió un Error al Guardar las Retenciones Seleccionadas por Ud para el Documento Obligación del proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                Me.Close()
            Else
                If MessageBox.Show("Ud no seleccionó ninguna Retención, la obligación del proveedor no tendrá retención. Quiere Seleccionar una Retención ?", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                Else
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al seleccionar las retenciones marcadas ...." & Err.Description, "Error", MessageBoxButtons.OK)
        End Try
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