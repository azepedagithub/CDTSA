Imports Clases
Imports DevExpress

Public Class frmRemisionBodega
    Dim CManager As New ClassManager
    Dim dtPedidos As New DataTable()
    Dim dtPedidosInProcess As New DataTable()
    Dim dtDetallePedido As New DataTable()
    Dim currentRow As DataRow
    Dim sAccion As String = "View"

    Dim _IDProducto As Long, _IDLote As Integer, _IDPedido As Integer


    Private Sub frmRemisionBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarPedidos()
            CargarPedidoInProcess()

        Catch ex As Exception
            MessageBox.Show("Han ocurrido los siguiente errores " + ex.Message, "Remision de Bodega")
        End Try

    End Sub

    Sub CargarPedidoInProcess()
        dtPedidosInProcess = CManager.ExecSPgetData("fafGetPedidosRemision", "'P'")
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
            Dim sNombreCliente As String

            IDPedido = CInt(currentRow("IDPedido"))
            sNombreCliente = currentRow("Cliente").ToString()

            Me.lblIDPedido.Text = "IDPedido: " + IDPedido.ToString()
            Me.lblNombreClientePedido.Text = "Cliente: " + sNombreCliente


            dtDetallePedido = CManager.ExecSPgetData("fafGetPedidoDetalleRemision", IDPedido.ToString() + ",-1")
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

    Private Sub btnImprimir_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick

        Dim Index As Integer = Me.GridViewPedidos.FocusedRowHandle()
        If Index > -1 Then
            Dim IDPedido As Integer
            currentRow = Me.GridViewPedidos.GetFocusedDataRow
            IDPedido = CInt(currentRow("IDPedido"))
            dtDetallePedido = CManager.ExecSPgetData("fafInsertPedidoSugeridoLote", IDPedido.ToString() + ",'" + gsUsuario + "'")

            CargarPedidoInProcess()
            CargarDetallePedido()
            CargarPedidos()
            'TODO: Mostrar el reporte
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (Me.GridViewDetallePedido.FocusedRowHandle > -1) Then
            Me.groupModify.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            Me.GroupMenu.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Me.slkupLote.Enabled = True
            Me.txtCantLote.Enabled = True

            Dim row As DataRow = Me.GridViewDetallePedido.GetFocusedDataRow


            _IDProducto = CLng(row("IDProducto"))
            _IDLote = CInt(row("IDLote"))
            _IDPedido = CInt(row("IDPedido"))

            dtDetallePedido = CManager.ExecSPgetData("fafGetPedidoDetalleRemision", _IDPedido.ToString() + "," + _IDProducto.ToString())
            Me.dtgDetallePedido.DataSource = dtDetallePedido

            Dim dtDetallePedidoByProduct As DataTable = CManager.ExecSPgetData("fafGetDetallePedido", _IDPedido.ToString() + "," + _IDProducto.ToString())
            Me.txtProducto.EditValue = row("Descr").ToString()
            Me.txtCantidad.EditValue = CInt(dtDetallePedidoByProduct.Rows(0)("Cantidad"))
            'Cargar los lotes del producto                  
            Dim dtLoteProducto As DataTable = CManager.ExecSPgetData("invGetLote", "-1,'" + _IDProducto.ToString() + "','*','*'")
            Me.slkupLote.Properties.DataSource = dtLoteProducto

            Me.dtgPedidos.Enabled = False
            Me.dtgPedidosProceso.Enabled = False
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (Me.GridViewDetallePedido.FocusedRowHandle > -1) Then
            Me.btnEditar.Enabled = False
            Me.btnAgregar.Enabled = False
            Me.btnGuardar.Enabled = True
            Me.btnEliminar.Enabled = False
            Me.btnCancelar.Enabled = True
            sAccion = "Edit"
            Dim row As DataRow = Me.GridViewDetallePedido.GetFocusedDataRow

            Dim Cantidad As Double = CDbl(row("Cantidad"))
            _IDProducto = CLng(row("IDProducto"))
            _IDLote = CInt(row("IDLote"))
            _IDPedido = CInt(row("IDPedido"))

            
            'Dim dtDetallePedido As DataTable = CManager.ExecSPgetData("fafGetDetallePedido", _IDPedido.ToString() + "," + _IDProducto.ToString())

            Me.txtCantLote.EditValue = Cantidad
            ' Me.txtProducto.EditValue = row("Descr").ToString()
            Me.slkupLote.EditValue = _IDLote
            'Me.txtCantidad.EditValue = CInt(dtDetallePedido.Rows(0)("Cantidad"))


            'dtDetallePedido = CManager.ExecSPgetData("fafGetPedidoDetalleRemision", _IDPedido.ToString() + "," + _IDProducto.ToString())
            'Me.dtgDetallePedido.DataSource = dtDetallePedido


        End If
    End Sub

    Private Sub LimpiarControles(Optional bWithExtras As Boolean = False)
        Me.txtCantLote.EditValue = Nothing
        Me.slkupLote.EditValue = Nothing
        If (bWithExtras) Then
            Me.txtProducto.EditValue = Nothing
            Me.txtCantidad.EditValue = Nothing
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarControles()
        Me.btnEditar.Enabled = True
        Me.btnAgregar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnEliminar.Enabled = True
        Me.btnCancelar.Enabled = False
        sAccion = "View"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dtDetallePedido As DataTable = Me.dtgDetallePedido.DataSource
            If (sAccion = "Edit") Then
                dtDetallePedido.Columns("Cantidad").ReadOnly = False
                Dim dtRow As DataRow = dtDetallePedido.Select("IDLote = " + _IDLote.ToString()).First()
                dtRow("Cantidad") = Me.txtCantLote.EditValue
                dtDetallePedido.Columns("Cantidad").ReadOnly = True
                dtDetallePedido.AcceptChanges()
            End If
            If (sAccion = "Add") Then
                Dim drLoteSeleccionado As DataRowView = Me.slkupLote.GetSelectedDataRow
                Dim NewFila As DataRow = dtDetallePedido.NewRow()
                NewFila("IDPedido") = _IDPedido
                NewFila("IDProducto") = _IDProducto
                NewFila("Descr") = Me.txtProducto.EditValue
                NewFila("IDLote") = drLoteSeleccionado("IDLote")
                NewFila("LoteProveedor") = drLoteSeleccionado("LoteProveedor")
                NewFila("FechaVencimiento") = drLoteSeleccionado("FechaVencimiento")
                NewFila("Cantidad") = Me.txtCantLote.EditValue

                dtDetallePedido.Rows.Add(NewFila)
            End If
            LimpiarControles()
            Me.btnEditar.Enabled = True
            Me.btnAgregar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnEliminar.Enabled = True
            Me.btnCancelar.Enabled = False

            sAccion = "View"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        LimpiarControles()
        Me.btnEditar.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = False
        Me.btnCancelar.Enabled = True
        sAccion = "Add"
        Me.txtCantLote.EditValue = Nothing
        Me.slkupLote.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.GridViewDetallePedido.FocusedRowHandle > -1) Then
            If (MessageBox.Show("Esta seguro de eliminar el elemento seleccionado ? ", "Eliminar Lote", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                Dim row As DataRow = Me.GridViewDetallePedido.GetFocusedDataRow
                row.Delete()
                Me.dtDetallePedido.AcceptChanges()
             
            End If
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
       
        Dim Total As Decimal
        Dim dtDetalleModif As DataTable = Me.dtgDetallePedido.DataSource
        Total = 0
        For Each fila As DataRow In dtDetalleModif.Rows
            Total = Total + CDec(fila("Cantidad"))
        Next

        If Total <> CDec(Me.txtCantidad.EditValue) Then
            MessageBox.Show("Por favor verique las cantidades, estas deben de ser iguales a las del pedido")
            Return
        End If
        Me.groupModify.Visibility = XtraLayout.Utils.LayoutVisibility.Always
        Me.GroupMenu.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        sAccion = "View"

        'Eliminar todo del producto
        CManager.ExecSP("fafUpdatePedidoPreparado", "'D'," + Me._IDPedido.ToString() + "," + Me._IDProducto.ToString() + ",-1,0,'admin'")

        For Each fila As DataRow In dtDetalleModif.Rows
            CManager.ExecSP("fafUpdatePedidoPreparado", "'I'," + Me._IDPedido.ToString() + "," + Me._IDProducto.ToString() + "," + fila("IDLote").ToString() + "," + fila("Cantidad").ToString() + ",'" + gsUsuario + "'")
        Next

        CargarDetallePedido()
        Me.dtgPedidos.Enabled = True
        Me.dtgPedidosProceso.Enabled = True
        Me.slkupLote.Enabled = False
        Me.txtCantLote.Enabled = False
        'Validar que el pedido sea el total 
        'Guardar el pedido
    End Sub
End Class