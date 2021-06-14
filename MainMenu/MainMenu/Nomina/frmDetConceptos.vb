
Imports Clases

Public Class frmDetConceptos
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Private Sub frmDetConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Sub RefreshGrid()
        Try
            tableData = cManager.ExecSPgetData("fafgetConceptos", "")
            GridControl1.DataSource = tableData
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Private Sub BorraRegistro()
        Dim sCodigo As String
        Dim sDescr As String
        Dim sparameterValues As String
        Try
            Dim dr As DataRow = GridViewConceptos.GetFocusedDataRow()
            If dr IsNot Nothing Then
                sCodigo = dr(0).ToString()
                sDescr = dr(1).ToString()
                If MessageBox.Show("Está Ud seguro de eliminar el Concepto " & sDescr, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then


                    sparameterValues = " 'D'," & sCodigo & ",'" & sDescr & "'"
                    cManager.ExecSP("nomUpdateConcepto", sparameterValues)
                    MessageBox.Show("El registro ha sido eliminado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefreshGrid()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentar eliminar al Cliente " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try



    End Sub
    Private Sub EditaConcepto()
        Try
            Dim dr As DataRow = Me.GridViewConceptos.GetFocusedDataRow()
            Dim sCodigo As String
            If dr IsNot Nothing Then
                sCodigo = dr(0).ToString()
                Dim frm As New frmConcepto()
                frm.gsCodeName = "IDConcepto"
                frm.gsCodeValue = sCodigo
                frm.gsStoreProcNameGetData = "nomgetConceptos"
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

        Dim frm As New frmConcepto()
        frm.gsStoreProcNameGetData = "nomgetConceptos"
        frm.gsCodeName = "IDConcepto"
        frm.gbCodeNumeric = True
        frm.gsCodeValue = "0"
        frm.gbAdd = True
        frm.ShowDialog()
        frm.Dispose()
    End Sub

End Class