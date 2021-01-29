Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win
Imports DevExpress.XtraGrid.Editors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.GridControl
Public Class frmPromocionesClientes
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsStoreProcNameGetData As String
    Public gsCodeName As String = ""
    Public gbCodeNumeric As Boolean = False
    Public gsCodeValue As String = ""
    Dim viewSelectedRow As GridView
    Dim currentRow As DataRow
    Dim sIDTabla As String = "0"
    Dim lbEdit As Boolean = False
    Dim lbAdd As Boolean = False
    Private Sub frmPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargagridLookUpsFromTables()
        RefreshGrid()
    End Sub

    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditProveedor, "cppProveedor", "IDProveedor, Nombre, Activo", "", "IDProveedor", "Nombre", "IDProveedor")
        CargagridSearchLookUp(Me.SearchLookUpEditCliente, "ccfClientes", "IDCliente, Nombre, Farmacia", "", "IDCliente", "Nombre", "IDCliente")

    End Sub
    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        ' g.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        ' g.Properties.PopupFormSize = New Size(900, 300)
        g.Properties.NullText = ""

    End Sub
    Sub RefreshGrid()
        Try
            Dim sProveedor As String
            Dim sCliente As String
            Dim sParametros As String
            If Me.SearchLookUpEditProveedor.Text <> "" Then
                sProveedor = SearchLookUpEditProveedor.EditValue.ToString
            Else
                sProveedor = "0"
            End If
            If Me.SearchLookUpEditCliente.Text <> "" Then
                sCliente = SearchLookUpEditCliente.EditValue.ToString
            Else
                sCliente = "0"
            End If
            sParametros = sProveedor & "," & sCliente
            tableData = cManager.ExecSPgetData("fafgetPromocionesClientes", sParametros)
            GridControl1.DataSource = tableData

            GridControl1.Refresh()
            txtPorcDesc.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Sub AddDataToGrid(Optional ByVal sTodos As String = "0", Optional ByVal sOperacion As String = "I")
        Try

            Dim sParameters As String
            Dim sFechadesde As String = CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd")
            Dim sFechaHasta As String = CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd")
            Dim sRequiereBonif As String
            If Me.chkRequiereBonif.EditValue = True Then
                sRequiereBonif = "1"
            Else
                sRequiereBonif = "0"
            End If
            sParameters = "'" & sOperacion & "'," & sIDTabla & " ," & SearchLookUpEditProveedor.EditValue.ToString() & "," & SearchLookUpEditCliente.EditValue.ToString() & "," & _
            SearchLookUpEditProducto.EditValue.ToString() & "," & _
             txtPorcDesc.Text & "," & txtPorcDescCliEsp.Text & ", '" & sFechadesde & "','" & sFechaHasta & "'," & sRequiereBonif & "," & sTodos
            tableData = cManager.ExecSPgetData("fafUpdatePromocionesClientes", sParameters)
            RefreshGrid()


        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub
    Private Function ControlsOk() As Boolean
        Dim lbok As Boolean = True

        If txtPorcDesc.Text Is Nothing Or String.IsNullOrEmpty(txtPorcDesc.Text) Then
            lbok = False
            Return lbok
        End If
        If txtPorcDescCliEsp.Text Is Nothing Or String.IsNullOrEmpty(txtPorcDescCliEsp.Text) Then
            lbok = False
            Return lbok
        End If
        If Not IsDate(Me.DateEditDesde.Text) Then
            lbok = False
            Return lbok
        End If
        If Not IsDate(Me.DateEditHasta.Text) Then
            lbok = False
            Return lbok
        End If
        If Me.DateEditDesde.EditValue > Me.DateEditHasta.EditValue Then
            lbok = False
            Return lbok
        End If
        Return lbok
    End Function
    Private Sub ClearControls()
        Me.txtPorcDesc.Text = ""
        Me.txtPorcDescCliEsp.Text = ""
        Me.DateEditDesde.Text = ""
        Me.DateEditHasta.Text = ""
        Me.SearchLookUpEditProducto.Text = ""
        Me.chkRequiereBonif.Checked = False
        If chkDejarProv.Checked = False Then
            Me.SearchLookUpEditProveedor.Text = ""
        End If
        If chkDejarCliente.Checked = False Then
            Me.SearchLookUpEditCliente.Text = ""
        End If
    End Sub
    Private Sub EnableButtons()
        If lbAdd = False And lbEdit = False Then
            Me.btnDelete.Enabled = False
            Me.btnEdit.Enabled = False
            cmdNewClear.Enabled = True
            Me.btnExcel.Enabled = False
            btnPropFecha.Enabled = False
        End If
        If lbAdd = False And lbEdit = True Then
            Me.btnDelete.Enabled = True
            Me.btnEdit.Enabled = True
            cmdNewClear.Enabled = True
            btnExcel.Enabled = True
            btnPropFecha.Enabled = True
        End If
        If lbAdd = True And lbEdit = False Then
            Me.btnDelete.Enabled = False
            Me.btnEdit.Enabled = True
            cmdNewClear.Enabled = False
            btnExcel.Enabled = False
            btnPropFecha.Enabled = False
        End If
    End Sub
    Private Sub ClearControlsNoCatalogos()
        Me.txtPorcDesc.Text = ""
        Me.txtPorcDescCliEsp.Text = ""
        Me.DateEditDesde.Text = ""
        Me.DateEditHasta.Text = ""
    End Sub
    Private Sub GridViewDetalle_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewDetalle.FocusedRowChanged
        RefreshItemRowToControl()
    End Sub
    Private Sub RefreshItemRowToControl()
        Dim index As Integer = GridViewDetalle.FocusedRowHandle
        If index > -1 Then
            Dim dr As DataRow = GridViewDetalle.GetFocusedDataRow()
            currentRow = dr
            If dr IsNot Nothing Then
                sIDTabla = dr("IDPromocion").ToString()
                Me.SearchLookUpEditProveedor.EditValue = dr("IDProveedor").ToString()
                Me.SearchLookUpEditCliente.EditValue = dr("IDCliente").ToString()
                Me.SearchLookUpEditProducto.EditValue = dr("IDProducto").ToString()
                Me.txtPorcDesc.Text = dr("PorcDesc")
                Me.txtPorcDescCliEsp.Text = dr("PorcDescCliEsp")
                Me.DateEditDesde.EditValue = CDate(dr("Desde"))
                Me.DateEditHasta.EditValue = CDate(dr("Hasta"))
                Me.chkRequiereBonif.EditValue = CBool(dr("RequiereBonif"))
                lbEdit = True
                lbAdd = False
                EnableButtons()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sTodos As String = "0"
            If Not ControlsOk() Then
                MessageBox.Show("Por favor revise los datos , existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtPorcDesc.Focus()
                Return
            End If

            If Me.chkTodosProd.EditValue = True Then
                If MessageBox.Show("Ud va a Eliminar todos los descuentos de todos los productos del Proveeedor, Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    sTodos = "1"
                End If
            Else
                sTodos = "0"

                If MessageBox.Show("Ud va a Eliminar un descuento para el producto " & Me.SearchLookUpEditProducto.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

            End If

            AddDataToGrid(sTodos, "D")
            If Me.chkTodosProd.EditValue = True Then
                Me.chkTodosProd.EditValue = False
            End If
            'ClearControls()
            'ubico el cursor en la fila del filtro y no en la primera row
            GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
            SearchLookUpEditProducto.Focus()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al eliminar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If lbAdd And Not lbEdit Then
                Dim sTodos As String = "0"
                If Not ControlsOk() Then
                    MessageBox.Show("Por favor revise los datos de la bonificación, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPorcDesc.Focus()
                    Return
                End If

                If chkTodosProd.Checked = True Then
                    If MessageBox.Show("Ud va a aplicar a todos los productos del Proveeedor al Cliente seleccionado el mismo descuento en las mismas fechas, Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        sTodos = "1"
                    End If
                Else
                    sTodos = "0"
                    Dim foundRow() As DataRow
                    Dim sCondicion As String
                    sCondicion = "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString() & " and IDCliente =" & Me.SearchLookUpEditCliente.EditValue.ToString() & " and IDProducto =" & Me.SearchLookUpEditProducto.EditValue.ToString() & _
                        " And Desde ='" & Me.DateEditDesde.EditValue.ToString() & "' And " & " Hasta = '" & Me.DateEditHasta.EditValue.ToString() & "'"
                    foundRow = tableData.Select(sCondicion)

                    If foundRow IsNot Nothing And foundRow.Count > 0 Then
                        MessageBox.Show("Ese Descuento ya Existe, por favor revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return

                    End If
                End If

                AddDataToGrid(sTodos, "I")
                'If Me.chkTodosProd.EditValue = True Then
                '    Me.chkTodosProd.EditValue = False
                'End If
                'If chkDejarProv.EditValue = False Then
                '    Me.SearchLookUpEditProveedor.Text = ""
                'End If

                'ubico el cursor en la fila del filtro y no en la primera row
                GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
                'ClearControls()
                SearchLookUpEditProducto.Focus()
                lbAdd = False
                lbEdit = False
            End If

            If lbEdit And Not lbAdd Then
                Dim sTodos As String = "0"
                If Not ControlsOk() Then
                    MessageBox.Show("Por favor revise los datos , existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtPorcDesc.Focus()
                    Return
                End If

                If chkTodosProd.Checked = True Then
                    If MessageBox.Show("Ud va a aplicar a todos los productos del Proveeedor el mismo descuento en las mismas fechas, Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        sTodos = "1"
                    End If
                Else
                    sTodos = "0"

                End If



                AddDataToGrid(sTodos, "U")
                If Me.chkTodosProd.EditValue = True Then
                    Me.chkTodosProd.EditValue = False
                End If
                'ubico el cursor en la fila del filtro y no en la primera row
                GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
                'ClearControls()
                SearchLookUpEditProducto.Focus()

            End If
            lbAdd = False
            lbEdit = False
            EnableButtons()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al agregar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim file As New SaveFileDialog()
        file.Filter = "Archivo XLS|*.xls"
        If file.ShowDialog() = DialogResult.OK Then
            Me.GridControl1.ExportToXls(file.FileName)

        End If
    End Sub



    Private Sub cmdNewClear_Click(sender As Object, e As EventArgs) Handles cmdNewClear.Click
        ClearControls()
        lbEdit = False
        lbAdd = True
        EnableButtons()
    End Sub
    Private Sub ValidaLetraNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtPorcDesc.KeyPress, txtPorcDescCliEsp.KeyPress
        Dim strListaControles As String
        strListaControles = "txtPorcDesc, txtPorcDescCliEsp"
        If strListaControles.Contains(sender.name) = True And Asc(e.KeyChar) <> Keys.Return Then
            e.KeyChar = Chr(Solo_Numeros(Asc(e.KeyChar)))
        End If
        If sender.name = "txtPorcDesc" And Asc(e.KeyChar) = Keys.Return Then
            txtPorcDesc.Focus()
        End If
        If sender.name = "txtPorcDescCliEsp" And Asc(e.KeyChar) = Keys.Return Then
            Me.DateEditDesde.Focus()
        End If


    End Sub

    Private Sub SearchLookUpEditProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditProveedor.EditValueChanged
        If SearchLookUpEditProveedor.Text <> "" Then
            Dim sFiltro As String = "IDProveedor=" & SearchLookUpEditProveedor.EditValue.ToString()
            CargagridSearchLookUp(Me.SearchLookUpEditProducto, "invProducto", "IDProducto, Descr, Activo", sFiltro, "IDProducto", "Descr", "IDProducto")
        End If

    End Sub


    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        RefreshGrid()
        ClearControlsNocatalogos()
    End Sub


    Private Sub btnPropFecha_Click(sender As Object, e As EventArgs) Handles btnPropFecha.Click
        Try
            Dim sTodos As String = "0"
            sTodos = "1"

            If MessageBox.Show("Ud va a Progagar el rango de Fechas seleccionado a todos los productos del Proveedor " & Me.SearchLookUpEditProveedor.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            AddDataToGrid(sTodos, "F")
            If Me.chkTodosProd.EditValue = True Then
                Me.chkTodosProd.EditValue = False
            End If
            'ClearControls()
            'ubico el cursor en la fila del filtro y no en la primera row
            GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
            'SearchLookUpEditProducto.Focus()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al propagar Fechas " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtPorcDesc_EditValueChanged(sender As Object, e As EventArgs) Handles txtPorcDesc.EditValueChanged
        Me.txtPorcDescCliEsp.EditValue = txtPorcDesc.EditValue
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            If Me.GridViewDetalle.RowCount > 0 Then
                GridViewDetalle.MoveFirst()
                RefreshItemRowToControl()
            Else
                ClearControls()
                lbAdd = False
                lbEdit = False
                EnableButtons()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al Cancelar la operación " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkTodosProd_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosProd.CheckedChanged
        If chkTodosProd.Checked Then
            If lbAdd = False Or lbEdit = True Then
                MessageBox.Show("Para que esta operación tenga efecto, Ud debe indicar que va a adicionar un item y luego proceder, de lo contrario no tendrá efecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class