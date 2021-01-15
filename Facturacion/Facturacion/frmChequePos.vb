Imports Clases
Public Class frmChequePos
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gIDCheque As Integer
    Public gIDCredito As Integer

    Private Sub frmChequePos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim spParameters As String
        spParameters = gIDCheque.ToString()
        tableData = cManager.ExecSPgetData("ccfgetChequePos", spParameters)
        If tableData.Rows.Count > 0 Then
            lblCliente.Text = tableData.Rows(0)("Nombre").ToString()
            lblRecibo.Text = tableData.Rows(0)("Recibo").ToString()
            lblChequeNo.Text = tableData.Rows(0)("NumeroCheque").ToString()
            lblFechaCobro.Text = tableData.Rows(0)("FechaCobro").ToString()
            lblMonto.Text = Math.Round(CDec(tableData.Rows(0)("Monto")), 2).ToString()
            lblCobrado.Text = IIf(CBool(tableData.Rows(0)("Cobrado")) = True, "YA FUE COBRADO", "NO HA SIDO COBRADO")
            If CBool(tableData.Rows(0)("Cobrado")) = True Then
                lblSinFondo.Text = "CHEQUE OK "
            End If
            If CBool(tableData.Rows(0)("Cobrado")) = False And CBool(tableData.Rows(0)("SinFondo")) = True Then
                lblSinFondo.Text = "CHEQUE SIN FONDOS"
                lblSinFondo.ForeColor = Color.Red
            End If

            If CBool(tableData.Rows(0)("Cobrado")) = False And CBool(tableData.Rows(0)("SinFondo")) = False Then
                lblSinFondo.Text = "CHEQUE PENDIENTE"
            End If

            lblBanco.Text = tableData.Rows(0)("Descr").ToString()
        End If

    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim sParametros As String
        sParametros = gIDCheque.ToString() & "1,0"
        If Not cManager.ExecSP("ccfUpdateChequePos", sParametros) Then
            MessageBox.Show("Hubo un error Cobrar el Cheque " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnSinFondo_Click(sender As Object, e As EventArgs) Handles btnSinFondo.Click
        Dim sParametros As String

        sParametros = "'C'," & gIDCredito.ToString()
        Dim td As New DataTable
        td = cManager.ExecFunction("ccfTieneAplicaciones", sParametros)
        If (td.Rows(0)(0)) = True Then
            MessageBox.Show("Al indicar que un Cheque 'No tiene Fondos', se anulará el R/C.... Este documento tiene Aplicaciones, por favor vaya a la opción Desaplicar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        sParametros = gIDCheque.ToString() & ",0,1"
        If Not cManager.ExecSP("ccfUpdateChequePos", sParametros) Then
            MessageBox.Show("Hubo un error indicar Sin Fondos el Cheque " & sParametros, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class