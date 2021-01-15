Imports Clases
Public Class frmAplicacionesRC
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsIDCredito As String
    Public gdFechaInicio As Date
    Public gdFechaFin As Date
    Public gIDCliente As Integer = 0
    Dim gsFechaInicio As String = "'" & CDate(gdFechaInicio).ToString("yyyyMMdd") & "'"
    Dim gsFechaFin As String = "'" & CDate(gdFechaFin).ToString("yyyyMMdd") & "'"
    Private Sub frmAplicacionesRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spParameters As String
        gsFechaInicio = "'" & CDate(gdFechaInicio).ToString("yyyyMMdd") & "'"
        gsFechaFin = "'" & CDate(gdFechaFin).ToString("yyyyMMdd") & "'"
        spParameters = gsIDCredito & "," & gsFechaInicio & "," & gsFechaFin & "," & gIDCliente
        tableData = cManager.ExecSPgetData("ccfgetAplicacionesRC", spParameters)
        If tableData.Rows.Count > 0 Then
            Me.datagrid.DataSource = tableData
        Else
            Me.datagrid.DataSource = Nothing
        End If
    End Sub
End Class