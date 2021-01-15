Public Class rptDocumentosCobrar

    Private Sub XrLabel30_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblSaldoFavorLocal.BeforePrint
        If Val(lblSaldoFavorLocal.Text) > 0 Then
            lblSaldoFavorLocal.Visible = False
            XrLabel29.Visible = False
        End If
    End Sub

    Private Sub XrLabel29_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel29.BeforePrint

    End Sub
End Class