Imports Clases
Imports System.ComponentModel
Public Class frmDetClientes
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Private Sub frmDetClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
    Sub RefreshGrid()
        Try
            tableData = cManager.ExecSPgetData("fafgetClientes", "0" & "," & gsSucursal)
            GridControl1.DataSource = tableData
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Private Sub BorraCliente()
        Dim sCodigo As String
        Dim sDescr As String
        Dim sparameterValues As String
        Try
            Dim dr As DataRow = GridViewClientes.GetFocusedDataRow()
            If dr IsNot Nothing Then
                sCodigo = dr(0).ToString()
                sDescr = dr(1).ToString()
                If MessageBox.Show("Está Ud seguro de eliminar el Cliente " & sDescr, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then


                    sparameterValues = " 'D'," & sCodigo & ",'" & sDescr & "'"
                    cManager.ExecSP("fafUpdateCliente", sparameterValues)
                    MessageBox.Show("El registro ha sido eliminado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefreshGrid()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentar eliminar al Cliente " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try



    End Sub
    Private Sub EditaCliente()
        Try
            Dim dr As DataRow = Me.GridViewClientes.GetFocusedDataRow()
            Dim sCodigo As String
            If dr IsNot Nothing Then
                sCodigo = dr(0).ToString()
                Dim frm As New frmClientes()
                frm.gsCodeName = "IDCliente"
                frm.gsCodeValue = sCodigo
                frm.gsStoreProcNameGetData = "fafgetClientes"
                frm.gbCodeNumeric = True
                frm.gbEdit = True
                frm.ShowDialog()
                frm.Dispose()

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar los clientes " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub AgregaCliente()

        Dim frm As New frmClientes()
        frm.gsStoreProcNameGetData = "fafgetClientes"
        frm.gsCodeName = "IDCliente"
        frm.gbCodeNumeric = True
        frm.gsCodeValue = "0"
        frm.gbAdd = True
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub BarButtonNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonNuevo.ItemClick
        AgregaCliente()
    End Sub

    Private Sub BarButtonEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonEdit.ItemClick
        EditaCliente()
    End Sub

    Private Sub BarButtonDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDelete.ItemClick
        BorraCliente()
    End Sub

    Private Sub GridViewClientes_DoubleClick(sender As Object, e As EventArgs) Handles GridViewClientes.DoubleClick
        EditaCliente()
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        RefreshGrid()
    End Sub
End Class