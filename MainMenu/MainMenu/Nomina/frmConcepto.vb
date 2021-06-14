Imports Clases
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.XtraExport
Imports System.IO
Public Class frmConcepto
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsStoreProcNameGetData As String
    Public gsCodeName As String = ""
    Public gbCodeNumeric As Boolean = False
    Public gsCodeValue As String = ""
    Public gbEdit As Boolean = False
    Public gbAdd As Boolean = False
    Private Sub frmConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class