Imports Clases
Imports DevExpress.XtraGrid
Public Class frmEscalasSinMaximo
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsTipo As String = ""

    Private Sub frmEscalasSinMaximo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Sub RefreshGrid()
        Try
            Dim sNombreSP As String = ""

            If gsTipo = "DESCUENTO" Then
                sNombreSP = "fafgetProductosSinEscalaMaximaEnDescuento"
            End If
            If gsTipo = "BONIFICACION" Then
                sNombreSP = "fafgetProductosSinEscalaMaximaEnBonficacion"
            End If

            tableData = cManager.ExecSPgetData(sNombreSP, "")
            GridHeader.DataSource = tableData
            GridHeader.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
End Class