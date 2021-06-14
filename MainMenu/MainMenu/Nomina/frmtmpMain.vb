Public Class frmtmpMain 

    Private Sub cmdConcepto_Click(sender As Object, e As EventArgs) Handles cmdConcepto.Click
        Dim frm As New frmDetConceptos()
        frm.ShowDialog()
    End Sub
End Class