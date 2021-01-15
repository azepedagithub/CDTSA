Imports Clases
Imports DevExpress.XtraEditors
Public Class frmConsultaDevoluciones
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim tableDataDetalle As New DataTable()
    Dim psIDCliente As String = "0"
    Dim psIDProducto As String = "0"
    Dim psDevolucion As String
    Dim psFactura As String
    Dim psFechaDesde As String
    Dim psFechaHasta As String
    Dim gIDFactura As Integer = 0

    Private Sub frmConsultaDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEditDesde.EditValue = Now.AddMonths(-2)
        DateEditHasta.EditValue = Now
        DateEditDesde.Properties.Mask.EditMask = "dd/MM/yyyy"
        DateEditHasta.Properties.Mask.EditMask = "dd/MM/yyyy"
    End Sub

    Private Sub RefrescaFiltro()
        Dim spParameters As String



        If Me.txtCliente.EditValue IsNot Nothing Then
            If Me.txtCliente.Text <> "" Then
                psIDCliente = Me.txtCliente.EditValue.ToString()
            Else
                psIDCliente = "0"
            End If

        Else
            psIDCliente = "0"
        End If

        If Me.txtProducto.EditValue IsNot Nothing Then
            If Me.txtProducto.Text <> "" Then
                psIDProducto = Me.txtProducto.EditValue.ToString()
            Else
                psIDProducto = "0"
            End If

        Else
            psIDProducto = "0"
        End If

        If Me.DateEditDesde.EditValue IsNot Nothing Then
            psFechaDesde = "'" & CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd") & "'"

        Else
            psFechaDesde = "null"
        End If

        If Me.DateEditHasta.EditValue IsNot Nothing Then
            psFechaHasta = "'" & CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd") & "'"

        Else
            psFechaHasta = "null"
        End If

        If Me.txtDevolucion.EditValue IsNot Nothing Then
            If txtDevolucion.Text <> "" Then
                psDevolucion = "'" & txtDevolucion.EditValue.ToString() & "'"
            Else
                psDevolucion = "'*'"
            End If
        Else
            psDevolucion = "'*'"
        End If

        If Me.txtFactura.EditValue IsNot Nothing Then
            If txtFactura.Text <> "" Then
                psFactura = "'" & txtFactura.EditValue.ToString() & "'"
            Else
                psFactura = "'*'"
            End If
        Else
            psFactura = "'*'"
        End If


        spParameters = psIDCliente & "," & psDevolucion & "," & psFechaDesde & "," & psFechaHasta & "," & psFactura & "," & psIDProducto
        tableData = cManager.ExecSPgetData("fafgetDevolucionHeader", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.GridControl1.DataSource = tableData
        Else
            Me.GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        Try
            RefrescaFiltro()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim sCliente As String
        Dim sDevolucion As String
        Dim sFechaInicio As String
        Dim sFechaFin As String
        Dim sFactura As String

        Dim index As Integer = GridView1.FocusedRowHandle
        If index > -1 Then
            Dim dr As DataRow = GridView1.GetFocusedDataRow()

            If dr IsNot Nothing Then
                sCliente = dr("IDCliente").ToString()
                sDevolucion = "'" & dr("Devolucion").ToString() & "'"
                sFechaInicio = psFechaDesde
                sFechaFin = psFechaHasta
                sFactura = "'" & dr("Factura").ToString() & "'"
                gIDFactura = CInt(dr("IDFactura"))
                Me.GridControl2.DataSource = Nothing
                tableDataDetalle = cManager.ExecSPgetData("fafgetDevolucionDetail", sCliente & "," & sDevolucion & "," & sFechaInicio & "," & sFechaFin & "," & sFactura & "," & psIDProducto)
                Me.GridControl2.DataSource = tableDataDetalle
            End If
        End If

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
                Me.txtCliente.EditValue = frm.gsIDCliente
                Me.txtNombre.EditValue = frm.gsNombre
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Try
            Dim frm As New frmPopupProducto()
            frm.ShowDialog()
            Me.txtProducto.EditValue = frm.gsIDProducto
            Me.txtDescr.EditValue = frm.gsDescr
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar la información " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarButtonItemLimpiaFiltro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLimpiaFiltro.ItemClick
        txtDevolucion.Text = ""
        txtProducto.Text = ""
        txtDescr.Text = ""
        txtCliente.Text = ""
        txtNombre.Text = ""
        txtFactura.Text = ""

    End Sub

    Private Sub BarButtonItemFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemFactura.ItemClick
        If gIDFactura <> 0 Then
            Dim frm As New frmPopupFactura()
            frm.gIDFactura = gIDFactura
            frm.ShowDialog()
        End If
    End Sub
End Class