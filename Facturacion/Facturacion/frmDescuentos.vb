Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win
Imports DevExpress.XtraGrid.Editors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.GridControl

Public Class frmDescuentos
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsStoreProcNameGetData As String
    Public gsCodeName As String = ""
    Public gbCodeNumeric As Boolean = False
    Public gsCodeValue As String = ""
    Dim viewSelectedRow As GridView
    Dim currentRow As DataRow
    Dim sIDTabla As String = "0"
    Dim lbEdit As Boolean = True
    Dim lbAdd As Boolean = False


    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditProveedor, "cppProveedor", "IDProveedor, Nombre, Activo", "Bonifica=1", "IDProveedor", "Nombre", "IDProveedor")


    End Sub
    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        'g.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode
        g.Properties.PopupFormSize = New Size(500, 250)
        g.Properties.NullText = ""

    End Sub

    Private Sub frmDescuentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim t As DataTable
        Dim bSinMaximo As Boolean = False
        t = cManager.ExecFunction("fafEscalaSinMaximoEnDescuento", "")
        If t.Rows.Count > 0 Then
            bSinMaximo = CBool(t.Rows(0).Item(0))
        End If
        If bSinMaximo Then
            If MessageBox.Show("Existe al menos un registro de Escala que no tiene el Maximo correcto para los Múltiplos. Quiere ver el detalle ? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then

                Dim frm As New frmEscalasSinMaximo
                frm.gsTipo = "DESCUENTO"
                frm.ShowDialog()

            End If
        End If

        If bSinMaximo = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmBonificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AlertControl1.Show(Me, "Importante", "Recuerde que la última escala debe ser 9999 y se utliiza para calcular los múltiplos, no debe olvidarse.")
        CargagridLookUpsFromTables()
        RefreshGrid()
    End Sub
    Sub RefreshGrid()
        Try
            Dim sParametro As String
            If Me.chkDejarProv.EditValue = True And Me.SearchLookUpEditProveedor.Text <> "" Then
                sParametro = SearchLookUpEditProveedor.EditValue.ToString
            Else
                sParametro = "0"
            End If
            If Me.chkDejarProducto.EditValue = True And Me.SearchLookUpEditProducto.Text <> "" Then
                sParametro = sParametro & "," & SearchLookUpEditProducto.EditValue.ToString
            Else
                sParametro = sParametro & "," & "0"
            End If
            'sParametro = sParametro
            tableData = cManager.ExecSPgetData("fafgetTablaDescuento", sParametro)
            GridControl1.DataSource = tableData
            GridViewDetalle.MoveFirst()
            'GridColumn2.Caption = gsDescrName
            'GridColumn2.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "Elementos Registrados : {0:n0} ")
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub


    Sub AddDataToGrid(Optional ByVal sTodos As String = "0", Optional ByVal sOperacion As String = "I")
        Try

            Dim sParameters As String

            sParameters = "'" & sOperacion & "'," & sIDTabla & " ," & SearchLookUpEditProveedor.EditValue.ToString() & "," & _
              SearchLookUpEditProducto.EditValue.ToString() & ",'" & CDate(Me.DateEditInicio.EditValue).ToString("yyyyMMdd") & "','" & CDate(Me.DateEditFin.EditValue).ToString("yyyyMMdd") & "'," & _
             txtDesde.Text & "," & txtHasta.Text & "," & Me.txtDescuento.Text

            tableData = cManager.ExecSPgetData("fafUpdateTablaDescuento", sParameters)
            RefreshGrid()


        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub


    Private Function ControlsOk() As Boolean
        Dim lbok As Boolean = True
        If txtDesde.Text Is Nothing Or String.IsNullOrEmpty(txtDesde.Text) Then
            lbok = False
            Return lbok
        End If
        If txtHasta.Text Is Nothing Or String.IsNullOrEmpty(txtHasta.Text) Then
            lbok = False
            Return lbok
        End If
        If txtDescuento.Text Is Nothing Or String.IsNullOrEmpty(txtHasta.Text) Then
            lbok = False
            Return lbok
        End If
        If Val(CInt(txtDesde.EditValue)) > Val(CInt(txtHasta.EditValue)) Then
            lbok = False
        End If
        If (DateEditInicio.EditValue IsNot Nothing And DateEditFin.EditValue IsNot Nothing) And (DateEditInicio.Text <> "" And DateEditFin.Text <> "") Then
            If CDate(DateEditInicio.EditValue) > CDate(DateEditFin.EditValue) Then
                lbok = False
            End If
        Else
            lbok = False
        End If

        Return lbok
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Try
            Dim sTodos As String = "0"
            If Not ControlsOk() Then
                MessageBox.Show("Por favor revise los datos del descuento, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDesde.Focus()
                Return
            End If

            sTodos = "0"
            Dim foundRow() As DataRow
            Dim sCondicion As String
            sCondicion = "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString() & " and IDProducto =" & Me.SearchLookUpEditProducto.EditValue.ToString() & _
                " And CantDesde =" & txtDesde.EditValue & " And " & " CantHasta = " & txtHasta.Text
            foundRow = tableData.Select(sCondicion)

            If foundRow IsNot Nothing And foundRow.Count > 0 Then
                MessageBox.Show("Ese Descuento en esa escala ya Existe, por favor revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If




            AddDataToGrid(sTodos, "I")

            If chkDejarProv.EditValue = False Then
                Me.SearchLookUpEditProveedor.Text = ""
            End If

            If chkDejarProducto.EditValue = False Then
                Me.SearchLookUpEditProducto.Text = ""
            End If
            If chkdejarFechas.EditValue = False Then
                Me.DateEditInicio.Text = ""
                Me.DateEditFin.Text = ""
            End If


            'ubico el cursor en la fila del filtro y no en la primera row
            GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
            'ClearControls()
            'SearchLookUpEditProducto.Focus()
            'RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al agregar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ClearControlsCaptacionNoCatalogos()
        Me.txtDesde.Text = ""
        Me.txtHasta.Text = ""
        Me.txtDescuento.Text = ""
            Me.DateEditInicio.Text = ""
            Me.DateEditFin.Text = ""


    End Sub
    Private Sub ClearControls()
        Me.txtDesde.Text = ""
        Me.txtHasta.Text = ""
        Me.txtDescuento.Text = ""
        If chkDejarProducto.Checked = False Then
            Me.SearchLookUpEditProducto.Text = ""
        End If

        If chkDejarProv.Checked = False Then
            Me.SearchLookUpEditProveedor.Text = ""
        End If
        If chkdejarFechas.EditValue = False Then
            Me.DateEditInicio.Text = ""
            Me.DateEditFin.Text = ""
        End If

    End Sub
    ' Exisgir campso solo letras y campos solo numeros
    Private Sub ValidaLetraNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
      Handles txtDesde.KeyPress, txtHasta.KeyPress, txtDescuento.KeyPress
        Dim strListaControles As String
        strListaControles = "txtDesde, txtHasta , txtBono "
        If strListaControles.Contains(sender.name) = True And Asc(e.KeyChar) <> Keys.Return Then
            e.KeyChar = Chr(Solo_Numeros(Asc(e.KeyChar)))
        End If
        If sender.name = "txtdesde" And Asc(e.KeyChar) = Keys.Return Then
            txtDesde.Focus()
        End If
        If sender.name = "txtHasta" And Asc(e.KeyChar) = Keys.Return Then
            Me.txtHasta.Focus()
        End If
        If sender.name = "txtDescuento" And Asc(e.KeyChar) = Keys.Return Then
            Me.txtDescuento.Focus()
        End If

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim sTodos As String = "0"
            If Not ControlsOk() Then
                MessageBox.Show("Por favor revise los datos del descuento, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDesde.Focus()
                Return
            End If

            If lbEdit And Not lbAdd Then
                Dim foundRow() As DataRow
                Dim sCondicion As String
                sCondicion = "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString() & " and IDProducto =" & Me.SearchLookUpEditProducto.EditValue.ToString() & _
                    " And CantDesde =" & txtDesde.Text & " And " & " CantHasta = " & txtHasta.Text & " and Descuento =" & txtDescuento.Text
                foundRow = tableData.Select(sCondicion)

                If (foundRow IsNot Nothing And foundRow.Count > 0) Then
                    MessageBox.Show("Ese Descuento No Existe, por favor revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return

                End If
                AddDataToGrid(sTodos, "U")
                lbAdd = False
                lbEdit = False
            End If

            If lbAdd And Not lbEdit Then


                sTodos = "0"
                Dim foundRow() As DataRow
                Dim sCondicion As String
                sCondicion = "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString() & " and IDProducto =" & Me.SearchLookUpEditProducto.EditValue.ToString() & _
                    " And CantDesde =" & txtDesde.EditValue & " And " & " CantHasta = " & txtHasta.Text
                foundRow = tableData.Select(sCondicion)

                If foundRow IsNot Nothing And foundRow.Count > 0 Then
                    MessageBox.Show("Ese Descuento en esa escala ya Existe, por favor revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return

                End If

                AddDataToGrid(sTodos, "I")

                If chkDejarProv.EditValue = False Then
                    Me.SearchLookUpEditProveedor.Text = ""
                End If

                If chkDejarProducto.EditValue = False Then
                    Me.SearchLookUpEditProducto.Text = ""
                End If
                If chkdejarFechas.EditValue = False Then
                    Me.DateEditInicio.Text = ""
                    Me.DateEditFin.Text = ""
                End If


                'ubico el cursor en la fila del filtro y no en la primera row
                GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle

            End If

            lbAdd = False
            lbEdit = False
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al agregar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridViewDetalle_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewDetalle.FocusedRowChanged
        Dim index As Integer = GridViewDetalle.FocusedRowHandle
        If index > -1 Then
            Dim dr As DataRow = GridViewDetalle.GetFocusedDataRow()
            currentRow = dr
            If dr IsNot Nothing Then
                sIDTabla = dr("IDTabla").ToString()
                Me.SearchLookUpEditProveedor.EditValue = dr("IDProveedor").ToString()
                Me.SearchLookUpEditProducto.EditValue = dr("IDProducto").ToString()
                Me.DateEditInicio.EditValue = CDate(dr("FechaDesde"))
                Me.DateEditFin.EditValue = CDate(dr("FechaHasta"))
                Me.txtDesde.Text = dr("CantDesde")
                Me.txtHasta.Text = dr("CantHasta")
                Me.txtDescuento.Text = dr("Descuento")
                lbAdd = False
                lbEdit = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sTodos As String = "0"
            If Not ControlsOk() Then
                MessageBox.Show("Por favor revise los datos del Descuento, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDesde.Focus()
                Return
            End If

            If MessageBox.Show("Ud va a Eliminar el Descuento del producto " & Me.SearchLookUpEditProducto.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If



            AddDataToGrid(sTodos, "D")
            ClearControls()
            'ubico el cursor en la fila del filtro y no en la primera row
            GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
            SearchLookUpEditProducto.Focus()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al eliminar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SearchLookUpEditProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditProveedor.EditValueChanged
        Try
            If Me.SearchLookUpEditProveedor.Text = "" Then
                Return
            End If

            CargagridSearchLookUp(Me.SearchLookUpEditProducto, "invProducto", "IDProducto, Descr, Activo", "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString(), "IDProducto", "Descr", "IDProducto")
            CargagridSearchLookUp(Me.SearchLookUpEditProductoReceptor, "invProducto", "IDProducto, Descr, Activo", "IDProveedor=" & Me.SearchLookUpEditProveedor.EditValue.ToString(), "IDProducto", "Descr", "IDProducto")
            tableData = cManager.ExecSPgetData("fafgetTablaDescuento", Me.SearchLookUpEditProveedor.EditValue.ToString())
            GridControl1.DataSource = tableData
            'GridColumn2.Caption = gsDescrName
            'GridColumn2.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "Elementos Registrados : {0:n0} ")
            ClearControlsCaptacionNoCatalogos()
            GridControl1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim file As New SaveFileDialog()
        file.Filter = "Archivo XLS|*.xls"
        If file.ShowDialog() = DialogResult.OK Then
            Me.GridControl1.ExportToXls(file.FileName)


        End If
    End Sub



    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub cmdNewClear_Click(sender As Object, e As EventArgs) Handles cmdNewClear.Click
        ClearControls()
        If SearchLookUpEditProveedor.Text = "" Then
            SearchLookUpEditProveedor.Focus()
        ElseIf SearchLookUpEditProducto.Text = "" Then
            SearchLookUpEditProducto.Focus()
        Else
            txtDesde.Focus()
        End If
        lbAdd = True
        lbEdit = False
    End Sub

    Private Sub cmdDelProv_Click(sender As Object, e As EventArgs) Handles cmdDelProv.Click
        Me.SearchLookUpEditProveedor.Text = ""
        Me.chkDejarProv.Checked = False
    End Sub

    Private Sub cmdDelProd_Click(sender As Object, e As EventArgs) Handles cmdDelProd.Click
        Me.SearchLookUpEditProducto.Text = ""
        Me.chkDejarProducto.Checked = False
    End Sub

    Private Sub cmdEscalaenLote_Click(sender As Object, e As EventArgs) Handles cmdEscalaenLote.Click
        If Not ControlsOk() Then
            MessageBox.Show("Por favor revise los datos de la bonificación, debe seleccinar al menos un registro de la Escala", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Me.SearchLookUpEditProducto.Text = "" Then
            MessageBox.Show("Por favor seleccione un producto... para el proceso debe estar activo un producto con escala de Bonificación ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If MessageBox.Show("Ud va a asignar el Descuento del producto seleccionado Base a todos los productos del Proveedor. El Producto seleccionado es : " & Me.SearchLookUpEditProducto.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sProductoReceptor As String = "0"
        If Me.SearchLookUpEditProductoReceptor.Text <> "" Then
            sProductoReceptor = Me.SearchLookUpEditProductoReceptor.EditValue.ToString()
        End If
        SetDescuentosConEscala(Me.SearchLookUpEditProveedor.EditValue.ToString(), Me.SearchLookUpEditProducto.EditValue.ToString(), sProductoReceptor, 2)
        SearchLookUpEditProducto.Text = ""
        chkDejarProducto.Checked = False
        ClearControls()
        RefreshGrid()
    End Sub

    Private Sub SetDescuentosConEscala(sIDProveedor As String, sIDProducto As String, sIDProductoReceptor As String, iTipoSeteo As Integer)
        'iTipoSeteo = 1 es Individual 2 es en Batch
        Try

            Dim sParameters As String
            Dim sNameStoreProc As String
            If iTipoSeteo = 1 Then
                sNameStoreProc = "fafSetDescuentoIndividual"
                sParameters = sIDProveedor & "," & sIDProducto & "," & sIDProductoReceptor
            Else
                sNameStoreProc = "fafSetDescuentoConEscala"
                sParameters = sIDProveedor & "," & sIDProducto
            End If


            cManager.ExecSP(sNameStoreProc, sParameters)
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub

    Private Sub cmdCopyEscala_Click(sender As Object, e As EventArgs) Handles cmdCopyEscala.Click
        If Not ControlsOk() Then
            MessageBox.Show("Por favor revise los datos del Descuento, debe seleccinar al menos un registro de la Escala del Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Me.SearchLookUpEditProducto.Text = "" Then
            MessageBox.Show("Por favor seleccione un producto... para el proceso debe estar activo un producto con escala de Bonificación ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If Me.SearchLookUpEditProductoReceptor.Text = "" Then
            MessageBox.Show("Por favor seleccione un producto Receptor... para el proceso debe estar activo un producto Receptor de la Bonificación ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If MessageBox.Show("Ud va a asignar los DAtos del Descuento del producto BAse al Producto Receptor del Proveedor. El Producto Base es : " & Me.SearchLookUpEditProducto.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sProductoReceptor As String = "0"
        If Me.SearchLookUpEditProductoReceptor.Text <> "" Then
            sProductoReceptor = Me.SearchLookUpEditProductoReceptor.EditValue.ToString()
        End If
        SetDescuentosConEscala(Me.SearchLookUpEditProveedor.EditValue.ToString(), Me.SearchLookUpEditProducto.EditValue.ToString(), sProductoReceptor, 1)
        SearchLookUpEditProducto.Text = ""
        SearchLookUpEditProductoReceptor.Text = ""
        chkDejarProducto.Checked = False
        ClearControls()
        RefreshGrid()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub btnPropFecha_Click(sender As Object, e As EventArgs) Handles btnPropFecha.Click
        Try
            Dim sTodos As String = "0"
            sTodos = "1"

            If MessageBox.Show("Ud va a Progagar el rango de Fechas seleccionado a todos los productos del Proveedor " & Me.SearchLookUpEditProveedor.Text & ", Ud está de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            AddDataToGrid(sTodos, "F")
   
            'ClearControls()
            'ubico el cursor en la fila del filtro y no en la primera row
            GridViewDetalle.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
            'SearchLookUpEditProducto.Focus()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al eliminar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class