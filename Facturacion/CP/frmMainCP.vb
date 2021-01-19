Public Class frmMainCP

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmPopUpRetProveedor()
        frm.gsIDProveedor = "1"
        frm.Show()
    End Sub

    Private Sub NavBarItemTransacciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemTransacciones.LinkClicked
        Dim frm As New frmCPConsultaDocs()
        frm.ShowDialog()
    End Sub


    Private Sub NavBarItemMovimientos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemMovimientos.LinkClicked
        Try
            Dim frm As New frmCPFiltroReportes()
            frm.iReporte = CrptMovimientos
            frm.gsNombreReporte = "Reporte de Movimientos del Cliente"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemDocumentosporCobrar_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemDocumentosporCobrar.LinkClicked
        Try
            Dim frm As New frmCPFiltroReportes()
            frm.iReporte = CrptDocumentosPorPagar
            frm.gsNombreReporte = "Reporte Documentos por Pagar"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemDesglosePagos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemDesglosePagos.LinkClicked
        Try
            Dim frm As New frmCPFiltroReportes()
            frm.iReporte = CrptDesglosePagos
            frm.gsNombreReporte = "Reporte Desglose de Pagos"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NavBarItemAnalisisVencimiento_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItemAnalisisVencimiento.LinkClicked

        Try
            Dim frm As New frmCPFiltroReportes()
            frm.iReporte = CrptAnalisisVencimiento
            frm.gsNombreReporte = "Reporte Analisis de Vencimientos pro Proveedor"
            frm.Show()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ejecutar la opción " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class