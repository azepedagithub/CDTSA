Imports Clases
Imports System.ComponentModel
Public Class frmPopupProducto
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim currentRow As DataRow
    Public gsIDProducto As String = ""
    Public gsDescr As String = ""
    Public gbBonifica As Boolean
    Public gdCostoPromLocal As Decimal = 0
    Public gdCostoPromDolar As Decimal = 0
    Public gsIDNivel As String
    Public gsIDMoneda As String
    Private Sub frmPopupProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        ShowBasico()
    End Sub
    Sub RefreshGrid()
        Try
            tableData = cManager.ExecSPgetData("fafgetProductos", "0")
            GridControl1.DataSource = tableData
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub GridViewProducto_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducto.FocusedRowChanged
        Dim dr As DataRow = GridViewProducto.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then
            gsIDProducto = dr("IDProducto").ToString()
            gsDescr = dr("Descr").ToString()
            gdCostoPromLocal = dr("CostoPromLocal").ToString()
            gdCostoPromDolar = dr("CostoPromDolar").ToString()
            gbBonifica = dr("Bonifica").ToString()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Me.Close()
    End Sub


    Private Sub GridControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl1.KeyPress
        If Asc(e.KeyChar) = Keys.Return Then
            Me.Close()
        End If
    End Sub




    Private Sub btnVerBonif_Click(sender As Object, e As EventArgs) Handles btnVerBonif.Click
        If gbBonifica Then
            If gsIDProducto <> "" And Val(gsIDProducto) > 0 Then
                Dim frm As New frmPopupBonificacion()
                frm.gsProductoID = gsIDProducto
                frm.gsIDNivel = gsIDNivel
                frm.gsIDMoneda = gsIDMoneda
                frm.ShowDialog()
                frm.Dispose()
            End If
        Else
            MessageBox.Show("El produto no Bonifica... No existe tabla de bonificación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmPopupProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnVerBonif_Click(sender, e)
            e.Handled = False
        End If
    End Sub

    Private Sub cmdBasico_Click(sender As Object, e As EventArgs) Handles cmdBasico.Click
        ShowBasico()
    End Sub
    Private Sub ShowBasico()
        GridViewProducto.Columns("Clasif4").Visible = False
        GridViewProducto.Columns("Clasif5").Visible = False
        GridViewProducto.Columns("Clasif6").Visible = False
    End Sub
    Private Sub ShowAll()
        GridViewProducto.Columns("Clasif4").Visible = True
        GridViewProducto.Columns("Clasif5").Visible = True
        GridViewProducto.Columns("Clasif6").Visible = True
    End Sub

    Private Sub cmdAll_Click(sender As Object, e As EventArgs) Handles cmdAll.Click
        ShowAll()
    End Sub
End Class