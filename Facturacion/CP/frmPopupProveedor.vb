Imports Clases
Imports System.ComponentModel
Public Class frmPopupProveedor
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim currentRow As DataRow
    Public gsIDSucursal As String
    Public gsIDProveedor As String
    Public gsNombre As String
    Public gsAlias As String
    Public gsContacto As String
    Public gsIDMoneda As String
    Public gsIDCondicionPago As String
    Private Sub frmPopupProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
    Sub RefreshGrid()
        Try
            tableData = cManager.ExecSPgetData("cppGetProveedor", "-1,'*', -1")
            GridControl1.DataSource = tableData
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub GridViewProveedor_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProveedor.FocusedRowChanged
        Dim dr As DataRow = GridViewProveedor.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then
            gsIDProveedor = dr("IDProveedor").ToString()
            gsNombre = dr("Nombre").ToString()
            gsAlias = dr("Alias").ToString()
            gsContacto = dr("Contacto").ToString()
            gsIDMoneda = dr("IDMoneda").ToString()
            gsIDCondicionPago = dr("IDCondicionPago").ToString()

        End If
    End Sub


    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Me.Close()
    End Sub

    Private Sub GridControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl1.KeyPress
        If Asc(e.KeyChar) = Keys.Return Then
            Me.Close()
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class