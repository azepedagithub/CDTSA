Imports Clases
Imports DevExpress

Public Class frmRemisionBodega
    Dim CManager As New ClassManager
    Dim dtPedidos As New DataTable()
    Dim dtPedidosInProcess As New DataTable()
    Dim dtDetallePedido As New DataTable()
    Dim currentRow As DataRow



    Private Sub frmRemisionBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarPedidos()
            CargarPedidoInProcess()
        Catch ex As Exception
            MessageBox.Show("Han ocurrido los siguiente errores " + ex.Message, "Remision de Bodega")
        End Try

    End Sub

    Sub CargarPedidoInProcess()
        dtPedidosInProcess = CManager.ExecSPgetData("fafGetPedidosRemision", "'C'")
        dtgPedidosProceso.DataSource = Nothing
        dtgPedidosProceso.DataSource = dtPedidosInProcess
    End Sub

    Sub CargarPedidos()
        dtPedidos = CManager.ExecSPgetData("fafGetPedidosRemision", "'A'")
        dtgPedidos.DataSource = Nothing
        dtgPedidos.DataSource = dtPedidos
    End Sub

    Sub CargarDetallePedido()
        If currentRow IsNot Nothing Then
            Dim IDPedido As Integer
            IDPedido = CInt(currentRow("IDPedido"))
            dtDetallePedido = CManager.ExecSPgetData("fafGetDetallePedido", IDPedido.ToString())
            Me.dtgDetallePedido.DataSource = dtDetallePedido
        End If
    End Sub




    Private Sub GridViewPedidos_DoubleClick(sender As Object, e As EventArgs) Handles GridViewPedidos.DoubleClick
        Dim GriView = DirectCast(sender, XtraGrid.Views.Grid.GridView)
        Dim Index As Integer = GriView.FocusedRowHandle
        If Index > -1 Then
            currentRow = GriView.GetFocusedDataRow
            CargarDetallePedido()
        End If

    End Sub

    Private Sub GridViewPedidoInProcess_DoubleClick(sender As Object, e As EventArgs) Handles GridViewPedidoInProcess.DoubleClick
        Dim GriView = DirectCast(sender, XtraGrid.Views.Grid.GridView)
        Dim Index As Integer = GriView.FocusedRowHandle
        If Index > -1 Then
            currentRow = GriView.GetFocusedDataRow
            CargarDetallePedido()
        End If

    End Sub
End Class