Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class rptAnalisisVencimiento


    Private Sub rptAnalisisVencimiento_ParametersRequestSubmit(sender As Object, e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
        Dim Info As ParameterInfo

        For Each Info In e.ParametersInformation
            If Info.Parameter.Name = "piConsolidaSucursal" Then
                If Info.Parameter.Value = True Then
                    Me.GroupHeaderCliente.Visible = False
                End If
            End If
        Next Info
    End Sub
End Class