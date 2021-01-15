Imports Clases
Imports DevExpress.XtraEditors
Public Class frmCCFpopupFacturas
    Public gsIDCliente As String
    Public gsFactura As String
    Public gsIDClase As String
    Public giIDSubtipo As Integer
    Public gdFecha As Date
    Public gdFechaVencimiento As Date
    Public giDiasVencidos As Integer
    Public giIDMoneda As Integer
    Public gdSaldo As Decimal
    Public giIDDebito As Integer
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Private Sub frmCCFpopupFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridToPay()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dr As DataRow = GridView1.GetFocusedDataRow()
        If dr IsNot Nothing Then
            giIDDebito = CInt(dr("IDDebito"))
            gsFactura = (dr("Documento")).ToString()
            gsIDClase = (dr("IDClase")).ToString()
            giIDSubtipo = CInt(dr("IDSubTipo"))
            gdFecha = CDate(dr("Fecha"))
            gdFechaVencimiento = CDate(dr("Vencimiento"))
            giDiasVencidos = CInt(dr("DiasVencidos"))
            giIDMoneda = CInt(dr("IDMoneda"))
            gdSaldo = CDec(dr("Saldo"))
        End If
    End Sub
    Sub RefreshGridToPay()
        Try
            Dim sIDCliente As String, sFecha As String, sIDDebito As String
            Dim sParametros As String

            sIDCliente = gsIDCliente.ToString()
            'sFecha = gdFecha.ToString("yyyyMMdd")
            sFecha = Now.ToString("yyyyMMdd")
            sIDDebito = "0"
            sParametros = sIDCliente + ",'" + sFecha + "',0"
            tableData = cManager.ExecSPgetData("ccfPagarDocumentosxCobrar", sParametros)
            If tableData.Rows.Count > 0 Then
                Me.GridControl1.DataSource = tableData
                GridControl1.Refresh()
                GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
                GridView1.ViewCaption = "Documentos Débitos a Pagar/Abonar"
                GridView1.OptionsView.ShowFooter = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub


    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Close()
    End Sub
End Class