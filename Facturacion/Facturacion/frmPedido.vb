Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win
Imports DevExpress.XtraGrid.Editors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid.Columns
Public Class frmPedido
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsStoreProcNameGetData As String
    Public gsCodeName As String = ""
    Public gbCodeNumeric As Boolean = False
    Public gsCodeValue As String = ""
    Dim viewSelectedRow As GridView
    Dim currentRow As DataRow
    Dim PorcImpuesto As Double = 0
    Dim iNumeroLineasFactura As Integer = 0
    Dim gdBonoProductoActual As Decimal = 0
    Dim gbRequiereBonif As Boolean = False
    Dim gdPorcDescPromFecha As Decimal = 0
    Dim gdPorcDescPromEscala As Decimal = 0


    Private Sub frmPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            btnProducto_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F3 Then
            btnClientes_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F2 Then
            btnAdd_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F4 Then
            btnNuevo_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F6 Then
            btnUpdate_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F8 Then
            btnDelete_Click(sender, e)
            e.Handled = False
        End If
        If e.KeyCode = Keys.F10 Then
            btnSave_Click(sender, e)
            e.Handled = False
        End If
    End Sub



    Private Sub frmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormatDateEdit(Me.DateEditFecha)
        ' FormatDateEdit(Me.DateEditRequerido)
        CargagridLookUpsFromTables()
        AssignFieldsToGrid()
        AddCollumnsToDataTableGrid()
        PrepareControls()
        FormattextNumbers()
        ' Me.Focus()
    End Sub



    Private Sub TotalizaGrid()
        If tableData.Rows.Count > 0 Then
            Dim SubTotal As Decimal = tableData.Compute("Sum(SubTotal)", "") 'Convert.ToDecimal(tableData.AsEnumerable().Sum(Function(row) row.Field(Of String)("SubTotal")))
            Dim Impuesto As Decimal = tableData.Compute("Sum(Impuesto)", "") 'Convert.ToDouble(tableData.AsEnumerable().Sum(Function(row) row.Field(Of String)("Impuesto")))
            Dim Descuento As Decimal = tableData.Compute("Sum(Descuento)", "")
            Dim DescuentoEsp As Decimal = tableData.Compute("Sum(DescEspecial)", "")
            Me.txtSubTotal.EditValue = SubTotal
            Me.txtSubTotalFinal.EditValue = (SubTotal - Descuento - DescuentoEsp)
            Me.txtIGV.EditValue = Impuesto
            Me.txtTotal.EditValue = (SubTotal - Descuento - DescuentoEsp) + Impuesto
            Me.txtDcto.EditValue = Descuento
            Me.txtDctoEsp.EditValue = DescuentoEsp

        Else
            Me.txtSubTotal.EditValue = 0
            Me.txtIGV.EditValue = 0
            Me.txtDcto.EditValue = 0
            Me.txtDctoEsp.EditValue = 0
            Me.txtTotal.EditValue = 0
        End If

    End Sub


    Private Sub ClearControlslinea()
        Me.txtCodigo.Text = 0
        Me.txtDescr.Text = ""
        Me.chkBonifica.Checked = False
        Me.chkBonificaProd.Checked = False
        Me.txtCantidad.Text = 0
        Me.txtPorcImp.Text = 0
        Me.txtIGV.Text = 0
        Me.txtImpuesto.Text = 0
        Me.txtPrecio.Text = 0
        Me.txtExistencia.Text = 0
        Me.txtSubTotLin.Text = 0
        Me.txtCantBonif.Text = 0
        txtCantBonifPrecio.Text = 0
        Me.txtSubTotFinalLin.Text = 0
        Me.txtTotalLin.Text = 0
        Me.txtPorcDescEsp.Text = 0
        txtAhorro.Text = 0
        txtPrecioLista.Text = 0
        Me.btnProducto.Focus()
    End Sub


    Private Sub txtCantidad_GotFocus(sender As Object, e As EventArgs) Handles txtCantidad.GotFocus
        TryCast(sender, TextEdit).SelectAll()
    End Sub


    Private Sub ValidaLetraNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtCantidad.KeyPress, txtPrecio.KeyPress, txtExistencia.KeyPress, txtCantBonif.KeyPress, txtCantBonifPrecio.KeyPress
        Dim strListaControles As String
        strListaControles = "txtCantidad , txtPrecio , txtExistencia, txtCantBonif, txtCantBonifPrecio"
        If strListaControles.Contains(sender.name) = True And Asc(e.KeyChar) <> Keys.Return Then
            e.KeyChar = Chr(Solo_Numeros(Asc(e.KeyChar)))
        End If
        If sender.name = "txtCantidad" And Asc(e.KeyChar) = Keys.Return Then
            txtPrecio.Focus()
        End If
        If sender.name = "txtCantBonif" And Asc(e.KeyChar) = Keys.Return Then
            txtCantBonifPrecio.Focus()
        End If
        If sender.name = "txtCantBonifPrecio" And Asc(e.KeyChar) = Keys.Return Then
            Me.btnAdd.Focus()

        End If

        If sender.name = "txtPrecio" And Asc(e.KeyChar) = Keys.Return Then
            Me.btnAdd.Focus()
        End If

    End Sub

    Private Sub PrepareControls()

        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecio.ReadOnly = True
        Me.txtIGV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPedido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    End Sub

    Private Function getTipoCambio(dFecha As Date, sIDTipoCambio As String) As Decimal
        Try
            '  Dim cManager As New Clases.ClassManagerCDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd")
            Dim t As DataTable
            Dim sParameter As String
            sParameter = "'" & dFecha.ToString("yyyyMMdd") & "','" & sIDTipoCambio & "'"
            t = cManager.ExecFunction("globalGetLastTipoCambio", sParameter)
            Return t.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
            MessageBox.Show("Error al Obtener el Tipo de Cambio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Private Function ControlsDetalleOk() As Boolean
        Dim lbok As Boolean = True
        If txtCantidad.Text Is Nothing Or String.IsNullOrEmpty(txtCantidad.Text) Then
            lbok = False
            Return lbok
        End If
        If txtPrecio.Text Is Nothing Or String.IsNullOrEmpty(txtCantidad.Text) Then
            lbok = False
            Return lbok
        End If
        If Val(txtCantidad.Text) <= 0 Or Val(txtPrecio.Text) <= 0 Then
            lbok = False
            Return lbok
        End If
        Return lbok
    End Function
    Private Function ControlsHeaderOk() As Boolean
        Dim lbok As Boolean
        lbok = True
        If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditPlazo.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If


        If Not (Me.SearchLookUpEditTipoEntrega.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditVendedor.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.DateEditRequerido.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If
        If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtPedido.Text IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        Return lbok
    End Function

    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditPlazo, "ccfPlazo", "Plazo, Descr, Activo", "", "Plazo", "Descr", "Plazo")
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoEntrega, "fafTipoEntrega", "IDTipoEntrega, Descr, Activo", "", "IDTipoEntrega", "Descr", "IDTipoEntrega")
        CargagridSearchLookUp(Me.SearchLookUpEditNivel, "fafNivelPrecio", "IDNivel, Descr, Activo", "", "IDNivel", "Descr", "IDNivel")
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr, Activo", "", "IDMoneda", "Descr", "IDMoneda")

        Me.DateEditFecha.EditValue = Date.Now
        Me.DateEditRequerido.EditValue = Date.Now
        Me.txtTipoCambio.EditValue = getTipoCambio(Me.DateEditFecha.EditValue, gParametros.TipoCambioFact)
        Me.SearchLookUpEditSucursal.EditValue = gsSucursal
        Me.SearchLookUpEditTipoEntrega.EditValue = gParametros.TipoEntregaDefault

    End Sub
    Sub CargagridLookUp(ByVal g As GridLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.PopupFilterMode = PopupFilterMode.Default
        g.Properties.NullText = ""

    End Sub
    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        g.Properties.PopupFormSize = New Size(250, 250)
        g.Properties.NullText = ""

    End Sub

    Sub AssignFieldsToGrid()
        Me.GridViewProducto.Columns.AddField("IDProducto")
        Me.GridViewProducto.Columns(0).Visible = True
        Me.GridViewProducto.Columns(0).Width = 50
        Me.GridViewProducto.Columns.AddField("Descr")
        Me.GridViewProducto.Columns(1).Width = 200
        Me.GridViewProducto.Columns(1).Visible = True
        Me.GridViewProducto.Columns.AddField("Cantidad")
        Me.GridViewProducto.Columns(2).Visible = True
        Me.GridViewProducto.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(2).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Precio")
        Me.GridViewProducto.Columns(3).Caption = "Precio"
        Me.GridViewProducto.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(3).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(3).Visible = True

        Me.GridViewProducto.Columns.AddField("SubTotal")
        Me.GridViewProducto.Columns(4).Visible = True
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Descuento")
        Me.GridViewProducto.Columns(5).Caption = "Descuento"
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(5).Visible = True

        Me.GridViewProducto.Columns.AddField("DescEspecial")
        Me.GridViewProducto.Columns(6).Caption = "DescEspecial"
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(6).Visible = True



        Me.GridViewProducto.Columns.AddField("SubTotalFinal")
        Me.GridViewProducto.Columns(7).Visible = True
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Impuesto")
        Me.GridViewProducto.Columns(8).Visible = True
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Total")
        Me.GridViewProducto.Columns(9).Caption = "Total"
        Me.GridViewProducto.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(9).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(9).Visible = True


        Me.GridViewProducto.Columns.AddField("CantBonif")
        Me.GridViewProducto.Columns(10).Visible = False
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("CantPrecio")
        Me.GridViewProducto.Columns(11).Visible = False
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("PrecioLista")
        Me.GridViewProducto.Columns(12).Visible = False
        Me.GridViewProducto.Columns(12).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Ahorro")
        Me.GridViewProducto.Columns(13).Visible = False
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns(2).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(4).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(5).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    End Sub

    Sub AddCollumnsToDataTableGrid()
        Try

            Dim dataColumnSubTotal As DataColumn = New DataColumn("SubTotal")
            dataColumnSubTotal.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnSubTotal)
            Dim dataColumnSubTotalFinal As DataColumn = New DataColumn("SubTotalFinal")
            dataColumnSubTotalFinal.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnSubTotalFinal)

            Dim dataColumnTotal As DataColumn = New DataColumn("Total")
            dataColumnTotal.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnTotal)

            Dim dataColumnImpuesto As DataColumn = New DataColumn("Impuesto")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnImpuesto)

            Dim dataColumnPrecio As DataColumn = New DataColumn("Precio")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnPrecio)

            Dim dataColumnPorImpuesto As DataColumn = New DataColumn("PorcImp")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnPorImpuesto)


            Dim dataColumnPorcDescuentoEsp As DataColumn = New DataColumn("PorcDescuentoEsp")
            dataColumnPorcDescuentoEsp.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnPorcDescuentoEsp)

            Dim dataColumnDescuento As DataColumn = New DataColumn("Descuento")
            dataColumnDescuento.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnDescuento)

            Dim dataColumnDescEspecial As DataColumn = New DataColumn("DescEspecial")
            dataColumnDescEspecial.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnDescEspecial)

            Dim dataColumnCantBonif As DataColumn = New DataColumn("CantBonif")
            dataColumnDescEspecial.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnCantBonif)
            Dim dataColumnCantBonifPrecio As DataColumn = New DataColumn("CantPrecio")
            dataColumnCantBonifPrecio.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnCantBonifPrecio)

            Dim dataColumnBonif As DataColumn = New DataColumn("Bonifica")
            dataColumnBonif.DataType = System.Type.GetType("System.Boolean")
            tableData.Columns.Add(dataColumnBonif)

            Dim dataColumnBonifprod As DataColumn = New DataColumn("BonifProd")
            dataColumnBonifprod.DataType = System.Type.GetType("System.Boolean")
            tableData.Columns.Add(dataColumnBonifprod)

            Dim dataColumnPrecioLista As DataColumn = New DataColumn("PrecioLista")
            dataColumnPrecioLista.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnPrecioLista)

            Dim dataColumnAhorro As DataColumn = New DataColumn("Ahorro")
            dataColumnAhorro.DataType = System.Type.GetType("System.Decimal")
            tableData.Columns.Add(dataColumnAhorro)

            tableData.Columns.Add("IDBodega")
            tableData.Columns.Add("IDProducto")
            tableData.Columns.Add("Descr")
            tableData.Columns.Add("Cantidad")

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try


    End Sub


    Sub AddDataToGrid()
        Try
            Dim r As DataRow = tableData.NewRow

            r("IDProducto") = Me.txtCodigo.EditValue  ' Me.SearchLookUpEditProducto.EditValue
            ' r("Descr") = Me.SearchLookUpEditProducto.Text
            r("Descr") = Me.txtDescr.EditValue
            r("IDBodega") = Me.SearchLookUpEditSucursal.EditValue
            r("Cantidad") = CDec(IIf(Me.txtCantidad.Text = "", "0", Me.txtCantidad.Text))
            r("CantBonif") = CDec(IIf(Me.txtCantBonif.Text = "", "0", Me.txtCantBonif.Text))
            r("CantPrecio") = CDec(IIf(Me.txtCantBonifPrecio.Text = "", "0", Me.txtCantBonifPrecio.Text))
            r("Precio") = CDbl(Me.txtPrecio.Text)
            r("Descuento") = CDec(Me.txtDescLinea.Text)
            r("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.Text)
            r("DescEspecial") = CDec(Me.txtDescEspLinea.Text)
            r("Impuesto") = CDec(Me.txtImpuesto.Text)
            r("SubTotal") = CDec(Me.txtSubTotLin.EditValue)
            r("SubTotalFinal") = CDec(r("SubTotal")) - CDec(r("Descuento")) - CDec(r("DescEspecial"))
            r("PorcImp") = CDec(txtPorcImp.Text)
            r("Total") = CDec(Me.txtTotalLin.EditValue)  ' CDec(r("Precio")) * CDec(r("Cantidad")) - CDec(r("Descuento")) - CDec(r("DescEspecial")) + CDec(r("Impuesto"))
            r("Bonifica") = CBool(Me.chkBonifica.EditValue)
            r("BonifProd") = CBool(Me.chkBonificaProd.EditValue)

            r("PrecioLista") = CDec(txtPrecioLista.EditValue)
            r("Ahorro") = CDec(txtAhorro.EditValue)
            tableData.Rows.Add(r)
            Me.GridControl1.DataSource = tableData
            iNumeroLineasFactura = iNumeroLineasFactura + 1
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub


    Private Sub OnFormKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim form As PopupSearchLookUpEditForm = TryCast(sender, PopupSearchLookUpEditForm)
        Dim popup As SearchEditLookUpPopup = TryCast(form.ActiveControl, SearchEditLookUpPopup)
        Dim grid As GridControl = TryCast(popup.lciGrid.Control, GridControl)
        Dim view As GridView = TryCast(grid.FocusedView, GridView)
        If e.KeyCode = Keys.Enter Then
            If view.DataRowCount > 0 Then
                Dim val As Object = view.GetRowCellValue(0, form.OwnerEdit.Properties.ValueMember)
                form.OwnerEdit.ClosePopup()
                form.OwnerEdit.EditValue = val
            End If
        End If
    End Sub

    Private Sub SearchLookUpEditTipoEntrega_Popup(sender As Object, e As EventArgs) Handles SearchLookUpEditTipoEntrega.Popup
        Dim form As PopupSearchLookUpEditForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, PopupSearchLookUpEditForm)
        form.KeyPreview = True
        RemoveHandler form.KeyDown, AddressOf OnFormKeyDown
        AddHandler form.KeyDown, AddressOf OnFormKeyDown
    End Sub


    Private Sub SearchLookUpEditCliente_Popup(sender As Object, e As EventArgs)
        Dim form As PopupSearchLookUpEditForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, PopupSearchLookUpEditForm)
        form.KeyPreview = True
        RemoveHandler form.KeyDown, AddressOf OnFormKeyDown
        AddHandler form.KeyDown, AddressOf OnFormKeyDown
    End Sub

    Private Sub SearchLookUpEditProducto_Popup(sender As Object, e As EventArgs)
        Dim form As PopupSearchLookUpEditForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, PopupSearchLookUpEditForm)
        form.KeyPreview = True
        RemoveHandler form.KeyDown, AddressOf OnFormKeyDown
        AddHandler form.KeyDown, AddressOf OnFormKeyDown


    End Sub

    Private Sub SearchLookUpEditVendedor_Popup(sender As Object, e As EventArgs) Handles SearchLookUpEditVendedor.Popup
        Dim form As PopupSearchLookUpEditForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, PopupSearchLookUpEditForm)
        form.KeyPreview = True
        RemoveHandler form.KeyDown, AddressOf OnFormKeyDown
        AddHandler form.KeyDown, AddressOf OnFormKeyDown
    End Sub



    Private Sub SearchLookUpEditSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSucursal.EditValueChanged
        Try
            Dim t As DataTable
            t = cManager.ExecFunction("fafGetNextPedido", SearchLookUpEditSucursal.EditValue.ToString())
            Me.txtPedido.Text = t.Rows(0).Item(0)
            txtPedido.ReadOnly = True

        Catch ex As Exception

            MessageBox.Show("Error al setear el check de Televentas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos del Pedido, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If

            If Not ControlsDetalleOk() Then
                MessageBox.Show("Por favor revise los datos del Producto, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCantidad.Focus()
                Return
            End If

            If iNumeroLineasFactura >= gParametros.NumeroLineasFact Then
                MessageBox.Show("El número máximo de lineas de un Pedido es " & gParametros.NumeroLineasFact.ToString() & " ... No puede agregar más lineas a la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If

            Dim foundRow() As DataRow
            foundRow = tableData.Select("IDProducto =" & Me.txtCodigo.EditValue.ToString())

            If foundRow IsNot Nothing And foundRow.Count > 0 Then
                MessageBox.Show("Ese Producto ya Existe, por favor revise", "Advertencia", MessageBoxButtons.OK)
                Return

            End If

            AddDataToGrid()
            TotalizaGrid()
            RefreshControlsFromGrid()
            'SearchLookUpEditProducto.Focus()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al agregar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Está seguro de eliminar el registro " & Me.txtDescr.EditValue, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                Exit Sub
            End If
            If tableData.Rows.Count > 0 Then
                GridViewProducto.DeleteRow(GridViewProducto.FocusedRowHandle())
                RefreshControlsFromGrid()
                iNumeroLineasFactura = iNumeroLineasFactura - 1
                TotalizaGrid()
            Else
                MessageBox.Show("No existen Registros ")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al elimniar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos del Pedido, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If
            If Not ControlsDetalleOk() Then
                MessageBox.Show("Por favor revise los datos del Producto, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCantidad.Focus()
                Return
            End If





            Dim LineaPedidoRow() As Data.DataRow
            LineaPedidoRow = tableData.Select("IDProducto =" & txtCodigo.EditValue.ToString())
            If LineaPedidoRow.Count > 0 Then

                ' Actualizo lod datos del Grid
                currentRow("Cantidad") = Me.txtCantidad.Text
                currentRow("CantBonif") = CDec(Me.txtCantBonif.Text)
                currentRow("CantPrecio") = CDec(Me.txtCantBonifPrecio.Text)
                currentRow("Precio") = CDbl(Me.txtPrecio.Text)
                currentRow("Descuento") = CDec(Me.txtDescLinea.Text)
                currentRow("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.Text)
                currentRow("DescEspecial") = CDec(Me.txtDescEspLinea.Text)
                currentRow("Impuesto") = CDec(Me.txtImpuesto.Text)
                currentRow("SubTotal") = CDec(Me.txtPrecio.Text) * (CDbl(txtCantidad.Text) + CDbl(txtCantBonif.Text))
                currentRow("SubTotalFinal") = CDec(currentRow("SubTotal")) - CDec(currentRow("Descuento")) - CDec(currentRow("DescEspecial"))
                currentRow("PorcImp") = CDec(txtPorcImp.Text)
                currentRow("Total") = (CDec(Me.txtPrecio.Text) * CDbl(txtCantidad.Text) + CDbl(txtCantBonif.Text)) + CDec(Me.txtImpuesto.Text)
                currentRow("Bonifica") = CBool(Me.chkBonifica.EditValue)
                currentRow("BonifProd") = CBool(Me.chkBonificaProd.EditValue)
                currentRow("PrecioLista") = CDec(txtPrecioLista.EditValue)
                currentRow("Ahorro") = CDec(txtAhorro.EditValue)

                ' Actualizo los datos del Datatable 
                LineaPedidoRow(0)("Cantidad") = Me.txtCantidad.Text
                LineaPedidoRow(0)("CantBonif") = CDec(Me.txtCantBonif.Text)
                LineaPedidoRow(0)("CantPrecio") = CDec(Me.txtCantBonifPrecio.Text)
                LineaPedidoRow(0)("Precio") = CDbl(Me.txtPrecio.Text)
                LineaPedidoRow(0)("Descuento") = CDec(Me.txtDescLinea.Text)
                LineaPedidoRow(0)("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.Text)
                LineaPedidoRow(0)("DescEspecial") = CDec(Me.txtDescEspLinea.Text)
                LineaPedidoRow(0)("Impuesto") = CDec(Me.txtImpuesto.Text)
                LineaPedidoRow(0)("SubTotal") = CDec(Me.txtPrecio.Text) * (CDbl(txtCantidad.Text) + CDbl(txtCantBonif.Text))
                LineaPedidoRow(0)("SubTotalFinal") = CDec(LineaPedidoRow(0)("SubTotal")) - CDec(LineaPedidoRow(0)("Descuento")) - CDec(LineaPedidoRow(0)("DescEspecial"))
                LineaPedidoRow(0)("PorcImp") = CDec(txtPorcImp.Text)
                LineaPedidoRow(0)("Total") = (CDec(Me.txtPrecio.Text) * CDbl(txtCantidad.Text) + CDbl(txtCantBonif.Text)) + CDec(Me.txtImpuesto.Text)
                LineaPedidoRow(0)("Bonifica") = CBool(Me.chkBonifica.EditValue)
                LineaPedidoRow(0)("BonifProd") = CBool(Me.chkBonificaProd.EditValue)
                LineaPedidoRow(0)("PrecioLista") = CDec(txtPrecioLista.EditValue)
                LineaPedidoRow(0)("Ahorro") = CDec(txtAhorro.EditValue)
                tableData.AcceptChanges()

                TotalizaGrid()

                MessageBox.Show("El Registro ha sido actualizado Exitosamente !!! ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If



        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridViewProducto_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducto.FocusedRowChanged
        RefreshControlsFromGrid()
    End Sub

    Private Sub FormattextNumbers()
        FormatControlNumber(txtCantidad)
        FormatControlNumber(txtImpuesto)
        FormatControlNumber(txtDescLinea)
        FormatControlNumber(txtDescEspLinea)
        FormatControlNumber(txtAhorro)
        FormatControlNumber(txtPrecio)
        FormatControlNumber(txtLimite)
        FormatControlNumber(txtLimite)
        FormatControlNumber(txtDisponible)
        FormatControlNumber(txtSubTotLin)
        FormatControlNumber(txtSubTotFinalLin)
        FormatControlNumber(txtPorcDescEsp)
        FormatControlNumber(txtPorcImp)
        FormatControlNumber(txtExistencia)
        FormatControlNumber(txtCantBonif)
        FormatControlNumber(txtCantBonifPrecio)
        FormatControlNumber(txtTotalLin)
        txtAhorro.ReadOnly = True
        txtAhorro.Visible = False
    End Sub

    Private Sub RefreshControlsFromGrid()
        Dim dr As DataRow = GridViewProducto.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then
            Me.txtCodigo.EditValue = dr("IDProducto").ToString()
            Me.txtCantidad.EditValue = dr("Cantidad")
            Me.txtCantBonif.EditValue = dr("CantBonif")
            Me.txtCantBonifPrecio.EditValue = dr("CantPrecio")
            Me.txtPrecio.EditValue = dr("Precio")
            Me.txtImpuesto.EditValue = dr("Impuesto")
            Me.txtSubTotLin.EditValue = dr("SubTotal")
            Me.txtSubTotFinalLin.EditValue = dr("SubTotalFinal")
            Me.txtDescLinea.EditValue = dr("Descuento")
            Me.txtPorcDescEsp.EditValue = dr("PorcDescuentoEsp")
            Me.txtPorcImp.EditValue = dr("PorcImp")
            Me.txtDescEspLinea.EditValue = dr("DescEspecial")
            Me.txtCantBonif.EditValue = dr("CantBonif")
            Me.chkBonifica.EditValue = dr("Bonifica")
            Me.chkBonificaProd.EditValue = dr("BonifProd")
            Me.txtTotalLin.EditValue = dr("Total") ' String.Format("{0:0.00}", dr("Total"))
            Me.txtPrecioLista.EditValue = dr("PrecioLista")
            Me.txtAhorro.EditValue = dr("Ahorro")
            If txtAhorro.EditValue > 0 Then
                txtAhorro.Visible = True
            Else
                txtAhorro.Visible = False
            End If

        Else
            ClearControlslinea()
        End If
    End Sub
    Private Sub SetVendedorTeleVenta()
        Dim t As DataTable
        t = cManager.ExecFunction("fafVendedorTeleVenta", SearchLookUpEditVendedor.EditValue.ToString())
        If t.Rows(0).Item(0) = 1 Then
            Me.CheckEditTeleVenta.EditValue = True
            Me.CheckEditTeleVenta.ReadOnly = True
        Else
            Me.CheckEditTeleVenta.EditValue = False
            Me.CheckEditTeleVenta.ReadOnly = True
        End If

    End Sub
    Private Sub SearchLookUpEditVendedor_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditVendedor.EditValueChanged
        Try
            SetVendedorTeleVenta()
        Catch ex As Exception

            MessageBox.Show("Error al setear el check de Televentas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub PrintReport(pIDPedido As Int64)
        tableData = cManager.ExecSPgetData("fafPrintPedido", pIDPedido.ToString())
        If tableData.Rows.Count > 0 Then

            Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptPedido.repx", True)
            report.DataSource = vbNull
            report.DataSource = tableData
            report.DataMember = "fafPrintPedido"

            Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)

            tool.ShowPreview()
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sSql As String
        Dim sParameters As String
        Dim dPrecioLocal As Decimal, dPrecioDolar As Decimal, dImpuestoLocal As Decimal, dImpuestoDolar As Decimal, dSubTotalLocal As Decimal, dSubTotalDolar As Decimal
        Dim dCantBonif As Decimal, dDescuentoLocal As Decimal, dDescuentoDolar As Decimal, dPorcDescuentoEsp As Decimal, dDescuentoEspecialLocal As Decimal, dDescuentoEspecialDolar As Decimal
        Dim dSubTotalFinalLocal As Decimal, dSubTotalFinalDolar As Decimal, dCantPrecio As Decimal, dPrecioLista As Decimal, dAhorro As Decimal

        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos del Pedido, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If
            If tableData.Rows.Count <= 0 Then
                MessageBox.Show("No Existen productos para el Pedido, favor aplicar algunos productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            ' Preparando los datos de la cabecera 
            sParameters = "'I',0," & Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & Me.txtPedido.Text & "," & _
                Me.txtIDCliente.Text & "," & Me.SearchLookUpEditVendedor.EditValue.ToString() & ",'" & _
                CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "','" & CDate(Me.DateEditRequerido.EditValue).ToString("yyyyMMdd") & "'," & _
                "0," & IIf(Me.CheckEditTeleVenta.EditValue = True, "1", "0") & ",'C',0,'" & If(MemoEditNota.EditValue Is Nothing, "", MemoEditNota.EditValue.ToString()) & "'," & _
                Me.SearchLookUpEditTipoEntrega.EditValue.ToString() & "," & Me.SearchLookUpEditNivel.EditValue.ToString() & "," & Me.SearchLookUpEditMoneda.EditValue.ToString() & "," & Me.txtTipoCambio.EditValue.ToString() & "," & Me.SearchLookUpEditPlazo.EditValue.ToString()
            'creando la instruccion de insercion en la cabecera
            sSql = cManager.CreateStoreProcSql("fafUpdatePedido", sParameters)
            Dim clase As New CbatchSQLIitem(sSql, True, False, True, False, "fafUpdatePedido", "fafUpdatePedido")
            cManager.batchSQLLista.Add(clase)
            cManager.batchSQLitem.Clear()
            cManager.batchSQLitem.Add(sSql)
            ' REcorrer las lineas del grid 
            Dim lbEsMonedaLocal As Boolean = EsMonedaLocal(CInt(Me.SearchLookUpEditMoneda.EditValue))
            For Each dr In tableData.Rows

                If lbEsMonedaLocal Then
                    dPrecioLocal = Redondear(CDec(dr("Precio")), gParametros.DigitosDecimales)
                    dPrecioDolar = Redondear(CDec(dr("Precio")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dImpuestoLocal = Redondear(CDec(dr("Impuesto")), gParametros.DigitosDecimales)
                    dImpuestoDolar = Redondear(CDec(dr("Impuesto")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalLocal = Redondear(CDec(dr("SubTotal")), gParametros.DigitosDecimales)
                    dSubTotalDolar = Redondear(CDec(dr("SubTotal")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalFinalLocal = Redondear(CDec(dr("SubTotalFinal")), gParametros.DigitosDecimales)
                    dSubTotalFinalDolar = Redondear(CDec(dr("SubTotalFinal")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoLocal = Redondear(CDec(dr("Descuento")), gParametros.DigitosDecimales)
                    dDescuentoDolar = Redondear(CDec(dr("Descuento")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoEspecialLocal = Redondear(CDec(dr("DescEspecial")), gParametros.DigitosDecimales)
                    dDescuentoEspecialDolar = Redondear(CDec(dr("DescEspecial")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                Else
                    dPrecioDolar = Redondear(CDec(dr("Precio")), gParametros.DigitosDecimales)
                    dPrecioLocal = Redondear(CDec(dr("Precio")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dImpuestoDolar = Redondear(CDec(dr("Impuesto")), gParametros.DigitosDecimales)
                    dImpuestoLocal = Redondear(CDec(dr("Impuesto")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalDolar = Redondear(dr("SubTotal"), gParametros.DigitosDecimales)
                    dSubTotalLocal = Redondear(CDec(dr("SubTotal")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalFinalDolar = Redondear(CDec(dr("SubTotalFinal")), gParametros.DigitosDecimales)
                    dSubTotalFinalLocal = Redondear(CDec(dr("SubTotalFinal")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoDolar = Redondear(CDec(dr("Descuento")), gParametros.DigitosDecimales)
                    dDescuentoLocal = Redondear(CDec(dr("Descuento")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoEspecialDolar = Redondear(CDec(dr("DescEspecial")), gParametros.DigitosDecimales)
                    dDescuentoEspecialLocal = Redondear(CDec(dr("DescEspecial")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                End If
                dPorcDescuentoEsp = CDec(dr("PorcDescuentoEsp"))
                dCantBonif = CDec(dr("CantBonif"))
                dCantPrecio = CDec(dr("CantPrecio"))
                dPrecioLista = CDec(dr("PrecioLista"))
                dAhorro = CDec(dr("Ahorro"))
                sParameters = "'I'" & ",@@Identity" & "," & Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & dr("IDProducto").ToString() & "," & _
                dr("Cantidad").ToString() & "," & dPrecioLocal.ToString() & "," & dPrecioDolar.ToString() & "," & dImpuestoLocal.ToString() & "," & _
                dImpuestoDolar.ToString() & "," & dSubTotalLocal.ToString() & "," & dSubTotalDolar.ToString() & "," & dSubTotalFinalLocal.ToString() & "," & dSubTotalFinalDolar.ToString() & "," & _
                IIf(Me.chkBonifica.EditValue = True, "1", "0") & "," & IIf(Me.chkBonificaProd.EditValue = True, "1", "0") & "," & _
                dCantBonif.ToString() & "," & dCantPrecio.ToString() & "," & dDescuentoLocal.ToString() & "," & dDescuentoDolar.ToString() & "," & dPorcDescuentoEsp.ToString() & "," & _
                dDescuentoEspecialLocal.ToString() & "," & dDescuentoEspecialDolar.ToString() & "," & CDec(dr("PorcImp")).ToString() & "," & dPrecioLista.ToString() & "," & dAhorro.ToString()
                sSql = cManager.CreateStoreProcSql("fafUpdatePedidoProd", sParameters)
                clase = New CbatchSQLIitem(sSql, False, True, False, True, "fafUpdatePedido", "fafUpdatePedidoProd")

                cManager.batchSQLitem.Add(sSql)
                cManager.batchSQLLista.Add(clase)
            Next dr

            If cManager.ExecCmdWithTransaction() Then
                Me.btnAdd.Enabled = False
                Me.btnSave.Enabled = False
                Me.btnUpdate.Enabled = False
                Me.btnDelete.Enabled = False
                MessageBox.Show("El Pedido ha sido Guardado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                If chkPrintPedido.Checked = True Then
                    PrintReport(cManager.IDAutoFirstParent.ToString())
                Else
                    Me.Close()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error al Guardar el pedido " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function CalculaImpuesto() As Double

        Dim dImpuesto As Double = 0
        
        dImpuesto = CDbl(Me.txtSubTotFinalLin.EditValue) * CDbl(If(String.IsNullOrEmpty(Me.txtPorcImp.Text), 0, Me.txtPorcImp.Text)) / 100
        Return dImpuesto

    End Function

    Private Sub PopUpCliente()
        Try
            If Me.SearchLookUpEditSucursal.Text = "" Then
                MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmPopupCliente()
            frm.gsIDSucursal = Me.SearchLookUpEditSucursal.EditValue.ToString()
            frm.ShowDialog()
            If frm.gsIDCliente <> "" Then
                Me.txtIDCliente.EditValue = frm.gsIDCliente
                Me.txtNombre.EditValue = frm.gsNombre
                Me.txtFarmacia.EditValue = frm.gsFarmacia
                Me.SearchLookUpEditVendedor.EditValue = CInt(frm.gsVendedor)
                Me.SearchLookUpEditNivel.EditValue = CInt(frm.gsIDNivel)
                Me.SearchLookUpEditNivel.ReadOnly = True
                Me.SearchLookUpEditMoneda.EditValue = CInt(frm.gsIDMoneda)
                Me.SearchLookUpEditPlazo.EditValue = CInt(frm.gsPlazo)
                Me.SearchLookUpEditMoneda.ReadOnly = True
                Me.txtLimite.EditValue = CDec(frm.gdLimite)
                Me.txtDisponible.EditValue = CDec(frm.gdDisponible)
                txtLimite.ReadOnly = True
                txtDisponible.ReadOnly = True
                SetVendedorTeleVenta()
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los clientes " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        PopUpCliente()
    End Sub


    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos del Pedido, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If

            Dim frm As New frmPopupProducto()
            frm.gsIDNivel = Me.SearchLookUpEditNivel.EditValue.ToString()
            frm.gsIDMoneda = Me.SearchLookUpEditMoneda.EditValue.ToString()
            frm.ShowDialog()
            Me.txtCodigo.EditValue = frm.gsIDProducto
            Me.txtDescr.EditValue = frm.gsDescr
            Me.chkBonifica.Checked = frm.gbBonifica
            Me.chkBonifica.Enabled = False
            Me.chkBonificaProd.Enabled = False
            If chkBonifica.Checked = False Then
                txtCantBonif.Enabled = False
                txtCantBonifPrecio.Enabled = False
            Else
                txtCantBonif.Enabled = True
                txtCantBonifPrecio.Enabled = True

            End If
            Dim t As DataTable
            t = cManager.ExecSPgetData("invGetExistenciaBodega", gsSucursal & "," & txtCodigo.EditValue.ToString() & ", -1 ")
            If t.Rows.Count > 0 Then
                txtExistencia.EditValue = t.Rows(0).Item("Existencia")
            Else
                txtExistencia.EditValue = 0
            End If


            t = cManager.ExecFunction("getPorcImpuestoFromProducto", txtCodigo.EditValue.ToString)
            If t.Rows.Count > 0 Then
                PorcImpuesto = t.Rows(0).Item(0)
            Else
                PorcImpuesto = 0
            End If

            txtPorcImp.Text = PorcImpuesto
            getPrecioProducto()
            ' para obtener el PorcDescuentoEspecial
            Dim sparam As String = txtCodigo.EditValue.ToString() & ",'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "'," & Me.txtIDCliente.EditValue.ToString()
            t = cManager.ExecSPgetData("fafGetPorcDescuento", sparam)
            If t.Rows.Count > 0 Then
                Me.txtPorcDescEsp.EditValue = t.Rows(0).Item(0)
                gdPorcDescPromFecha = CDec(t.Rows(0).Item(0))
                gbRequiereBonif = CBool(t.Rows(0).Item(1))
            Else
                Me.txtPorcDescEsp.EditValue = 0
                gbRequiereBonif = False
                gdPorcDescPromFecha = 0
            End If

            txtCantidad.Text = ""
            gdBonoProductoActual = 0
            txtCantBonifPrecio.EditValue = 0
            txtCantidad.Focus()
            frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el Producto ..." & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub

    Private Sub getPrecioProducto()
        Dim dPrecio As Decimal
        Dim t As DataTable
        ' para obtener el Precio
        Dim sParametros As String
        sParametros = txtIDCliente.Text & "," & Me.SearchLookUpEditNivel.EditValue.ToString() & "," & txtCodigo.Text & "," & Me.SearchLookUpEditMoneda.EditValue.ToString()
        t = cManager.ExecFunction("fafGetPrecio", sParametros)
        If t.Rows.Count > 0 Then
            dPrecio = t.Rows(0).Item(0)
        Else
            dPrecio = 0
        End If

        txtPrecio.Text = dPrecio
        txtPrecioLista.EditValue = txtPrecio.EditValue
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmReport()
        frm.ShowDialog()
        frm.Dispose()

        ' DocumentViewer1.DocumentSource = report

    End Sub

    'Private Sub txtCantidad_EditValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.EditValueChanged

    'End Sub

    Private Sub TriggerCantidad()
        If Me.txtPorcDescEsp.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or _
        Not (Me.txtPorcDescEsp.EditValue IsNot Nothing) Or Not (Me.txtPrecio.EditValue IsNot Nothing) Or _
        Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If
        RefrescaBonoProducto()
        CalculaSubTotales()
    End Sub

    Private Sub CalculaSubTotales()
        If CDec(Me.txtCantBonifPrecio.EditValue) > 0 Then
            Me.txtPrecio.EditValue = Redondear((CDec(txtPrecioLista.EditValue) * CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(Me.txtCantBonifPrecio.EditValue)), gParametros.DigitosDecimales)
        End If

        Me.txtSubTotLin.EditValue = Redondear(CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)) * (CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) + CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text))), gParametros.DigitosDecimales)
        Me.txtDescLinea.EditValue = Redondear(CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        Me.txtDescEspLinea.EditValue = Redondear(CDec(IIf(Me.txtPorcDescEsp.Text = "", 0, Me.txtPorcDescEsp.Text)) / 100 * CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        Me.txtDescEspLinea.Text = String.Format("{0:0.00}", txtDescEspLinea.EditValue)

        Me.txtSubTotFinalLin.EditValue = Redondear(Me.txtSubTotLin.EditValue - Me.txtDescLinea.EditValue - Me.txtDescEspLinea.EditValue, gParametros.DigitosDecimales)

        txtAhorro.EditValue = ((Me.txtPrecioLista.EditValue * (txtCantidad.EditValue + txtCantBonif.EditValue)) - Me.txtSubTotFinalLin.EditValue)
        If txtAhorro.EditValue > 0 Then
            txtAhorro.Visible = True
        Else
            txtAhorro.Visible = False
        End If
        txtImpuesto.EditValue = Redondear(CalculaImpuesto(), gParametros.DigitosDecimales)
        Me.txtTotalLin.EditValue = Redondear(Me.txtSubTotFinalLin.EditValue + txtImpuesto.EditValue, gParametros.DigitosDecimales)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If iNumeroLineasFactura >= gParametros.NumeroLineasFact Then
            MessageBox.Show("El número máximo de lineas de un Pedido es " & gParametros.NumeroLineasFact.ToString() & " ... No puede agregar más lineas a la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        ClearControlslinea()
    End Sub


    Private Sub chkBonifica_CheckedChanged(sender As Object, e As EventArgs) Handles chkBonifica.CheckedChanged
        RefrescaBonoProducto()
    End Sub
    Private Sub RefrescaBonoProducto()
        Dim sParametros As String, dBono As Decimal
        Dim t As New DataTable
        If chkBonifica.Checked Then
            chkBonificaProd.ReadOnly = False
            chkBonificaProd.Checked = True
            txtCantBonif.ReadOnly = False
            If txtCantidad.EditValue > 0 Then
                sParametros = txtCodigo.Text & "," & txtCantidad.Text
                t = cManager.ExecFunction("fafGetBono", sParametros)
                If t.Rows.Count > 0 Then
                    dBono = t.Rows(0).Item(0)
                Else
                    dBono = 0
                End If

                gdBonoProductoActual = dBono
                txtCantBonif.EditValue = Redondear(dBono, gParametros.DigitosDecimales)
                ' cambio el 1 de Nov 2020
                t = cManager.ExecFunction("fafgetDescuentoPorEscala", sParametros)
                If t.Rows.Count > 0 Then
                    gdPorcDescPromEscala = t.Rows(0).Item(0)
                Else
                    gdPorcDescPromEscala = 0
                End If
                If gbRequiereBonif And txtCantBonif.EditValue = 0 And txtCantBonifPrecio.EditValue = 0 Then
                    Me.txtPorcDescEsp.EditValue = 0
                Else
                    txtPorcDescEsp.EditValue = gdPorcDescPromFecha + gdPorcDescPromEscala
                End If
            End If
            'txtCantBonif.Focus()
        Else
            chkBonificaProd.ReadOnly = False
            chkBonificaProd.Checked = False
            txtCantBonif.Text = 0
            txtCantBonif.ReadOnly = True

        End If
    End Sub

    Private Sub TriggerCantBonif()
        If Me.txtCantidad.Text = "" Or Me.txtCantBonif.Text = "" Or txtPrecio.Text = "" Or Not (Me.txtCantBonif.EditValue IsNot Nothing) Or Not (Me.txtPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If
        If Me.txtCantBonif.EditValue > 0 And txtCantidad.EditValue = 0 Then
            MessageBox.Show("Ud Digitó la cantidad a Bonificar pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearControlslinea()
            txtCantBonif.Text = 0
            txtCantidad.Focus()
            Return
        End If
        ' cambio el 1 de Nov 2020
        If gbRequiereBonif And txtCantBonif.EditValue = 0 And txtCantBonifPrecio.EditValue = 0 Then
            Me.txtPorcDescEsp.EditValue = 0
        Else
            txtPorcDescEsp.EditValue = gdPorcDescPromFecha + gdPorcDescPromEscala
        End If
        CalculaSubTotales()
    End Sub

    Private Sub chkBonificaProd_CheckedChanged(sender As Object, e As EventArgs) Handles chkBonificaProd.CheckedChanged

        CalculaSubTotales()

    End Sub


    Private Sub TriggerCantBonifPrecio()
        If Me.txtCantidad.Text = "" Or txtPrecio.Text = "" Or Not (Me.txtCantBonifPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If

        If txtCantBonifPrecio.Text = "" Then
            txtCantBonifPrecio.EditValue = 0
        End If

        If Me.txtCantBonifPrecio.EditValue > 0 And txtCantidad.EditValue = 0 Then
            MessageBox.Show("Ud Digitó la cantidad a Bonificar en Precio pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearControlslinea()
            txtCantBonifPrecio.EditValue = 0
            txtCantidad.Focus()
            Return
        End If


        If Me.txtPrecio.EditValue = 0 Or txtCantBonifPrecio.EditValue = 0 Then
            txtPrecio.EditValue = txtPrecioLista.EditValue
        End If

        If CDec(txtCantBonifPrecio.EditValue) <= gdBonoProductoActual Then
            txtCantBonif.EditValue = gdBonoProductoActual - txtCantBonifPrecio.EditValue
        End If

        If (CDec(txtCantBonifPrecio.EditValue) > gdBonoProductoActual) Or txtCantBonifPrecio.Text = "" Then
            txtCantBonifPrecio.EditValue = 0
            txtPrecio.EditValue = txtPrecioLista.EditValue
            txtCantBonif.EditValue = gdBonoProductoActual
        End If

        ' cambio el 1 de Nov 2020

        If gbRequiereBonif And txtCantBonif.EditValue = 0 And txtCantBonifPrecio.EditValue = 0 Then
            Me.txtPorcDescEsp.EditValue = 0
        Else
            txtPorcDescEsp.EditValue = gdPorcDescPromFecha + gdPorcDescPromEscala
        End If


        CalculaSubTotales()

    End Sub

    'Private Sub txtCantBonifPrecio_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCantBonifPrecio.EditValueChanging
    '    If Me.txtCantidad.Text = "" Or e.NewValue.ToString() = "" Or Me.txtCantBonifPrecio.Text = "0" Or txtPrecio.Text = "" Or Not (e.NewValue IsNot Nothing) Or Not (Me.txtPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
    '        Return
    '    End If
    '    If e.NewValue > 0 And txtCantidad.EditValue = 0 Then
    '        MessageBox.Show("Ud Digitó la cantidad a Bonificar en Precio pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ClearControlslinea()
    '        txtCantBonifPrecio.EditValue = 0
    '        txtCantidad.Focus()
    '        Return
    '    End If
    '    If gdBonoProductoActual < CDec(e.NewValue) Then

    '        e.Cancel = True
    '        txtPrecio.EditValue = txtPrecioLista.EditValue
    '        ' txtCantBonif.EditValue = gdBonoProductoActual


    '        Exit Sub
    '    End If
    'End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus
        TriggerCantidad()
    End Sub


    Private Sub txtCantBonif_LostFocus(sender As Object, e As EventArgs) Handles txtCantBonif.LostFocus
        TriggerCantBonif()
    End Sub


    Private Sub txtCantBonifPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtCantBonifPrecio.LostFocus
        TriggerCantBonifPrecio()
    End Sub




    Private Sub btnBonif_Click_1(sender As Object, e As EventArgs) Handles btnBonif.Click
        If txtCodigo.Text <> "" And Val(txtCodigo.Text) > 0 Then
            Dim frm As New frmPopupBonificacion()
            frm.gsProductoID = Me.txtCodigo.Text
            frm.gsIDNivel = Me.SearchLookUpEditNivel.EditValue.ToString()
            frm.gsIDMoneda = Me.SearchLookUpEditMoneda.EditValue.ToString()
            frm.ShowDialog()
            frm.Dispose()
        End If
    End Sub


    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        If txtCodigo.Text <> "" And Val(txtCodigo.Text) > 0 Then
            Dim frm As New frmpopupDescuentoEscala()
            frm.gsProductoID = Me.txtCodigo.Text
            frm.gsIDNivel = Me.SearchLookUpEditNivel.EditValue.ToString()
            frm.gsIDMoneda = Me.SearchLookUpEditMoneda.EditValue.ToString()
            frm.ShowDialog()
            frm.Dispose()
        End If
    End Sub

    Private Sub btnDescProm_Click(sender As Object, e As EventArgs) Handles btnDescProm.Click
        If txtCodigo.Text <> "" And Val(txtCodigo.Text) > 0 Then
            Dim frm As New frmpopupPromociones()
            frm.gsProductoID = Me.txtCodigo.Text
            frm.gsIDNivel = Me.SearchLookUpEditNivel.EditValue.ToString()
            frm.gsIDMoneda = Me.SearchLookUpEditMoneda.EditValue.ToString()
            frm.ShowDialog()
            frm.Dispose()
        End If
    End Sub
End Class