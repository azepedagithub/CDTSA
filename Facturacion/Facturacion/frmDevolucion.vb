Imports Clases
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win
Imports DevExpress.XtraGrid.Editors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Public Class frmDevolucion
    Public giIDFactura As Int64
    Public gsConsecMask As String
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim tableDetDev As New DataTable()
    Dim gbError As Boolean = False
    Dim gsMascara As String
    Dim gsCodigoConsecMask As String
    Dim gsConsecutivoAnterior As String
    Dim gdTotalNotaCredito As Decimal = 0

    Private Sub frmDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaParametros()
            CargaParametrosCCF()
            AssignFieldsToGrid()
            AsignFieldsToTableDetalleDevolucion()
            CargaDatosFactura()
            Me.LayoutControl1.OptionsView.IsReadOnly = DefaultBoolean.True
            Me.SearchLookUpEditSucursal.ReadOnly = False
            CargaConsecutivo()
            ReadOnlyGroupNotaCredito(False)
            Me.SearchLookUpEditSubTipo.Properties.NullText = ""
        Catch ex As Exception
            MessageBox.Show("Error al cargar la pantalla de Devoluciones " & Err.Description, "Error", MessageBoxButtons.OK)
        End Try

    End Sub
    
    Sub AssignFieldsToGrid()
        ' Me.GridViewProducto.OptionsBehavior.Editable = True
        Me.GridViewProducto.OptionsView.AllowCellMerge = True
        Me.GridViewProducto.Columns.AddField("IDFactura")
        Me.GridViewProducto.Columns(0).Caption = "IDFactura"
        Me.GridViewProducto.Columns(0).Visible = False
        Me.GridViewProducto.Columns("IDFactura").OptionsColumn.AllowEdit = False
        Me.GridViewProducto.Columns(0).Width = 60
        Me.GridViewProducto.Columns.AddField("IDProducto")
        Me.GridViewProducto.Columns(1).Caption = "Producto"
        Me.GridViewProducto.Columns(1).Visible = True
        Me.GridViewProducto.Columns(1).OptionsColumn.AllowMerge = DefaultBoolean.True
        Me.GridViewProducto.Columns("IDProducto").OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns(1).Width = 60
        Me.GridViewProducto.Columns.AddField("DescrProducto")
        Me.GridViewProducto.Columns(2).Width = 200
        Me.GridViewProducto.Columns(2).Visible = True
        Me.GridViewProducto.Columns(2).OptionsColumn.AllowEdit = False
        Me.GridViewProducto.Columns(2).OptionsColumn.AllowMerge = DefaultBoolean.True


        Me.GridViewProducto.Columns.AddField("IDLote")
        Me.GridViewProducto.Columns(3).Caption = "IDLote"
        Me.GridViewProducto.Columns(3).Visible = False
        Me.GridViewProducto.Columns(3).OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns.AddField("Precio")
        Me.GridViewProducto.Columns(4).Width = 80
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(4).Caption = "Precio"
        Me.GridViewProducto.Columns(4).Visible = True
        Me.GridViewProducto.Columns(4).OptionsColumn.AllowEdit = False


        Me.GridViewProducto.Columns.AddField("PorcDescBonif")
        Me.GridViewProducto.Columns(5).Width = 80
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(5).Caption = "%DescBonif"
        Me.GridViewProducto.Columns(5).Visible = True
        Me.GridViewProducto.Columns(5).FieldName = "PorcDescBonif"
        Me.GridViewProducto.Columns(5).OptionsColumn.ReadOnly = True

        Me.GridViewProducto.Columns.AddField("porcDescuentoEsp")
        Me.GridViewProducto.Columns(6).Width = 80
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(6).Caption = "%DescEsp"
        Me.GridViewProducto.Columns(6).Visible = True
        Me.GridViewProducto.Columns(6).FieldName = "porcDescuentoEsp"
        Me.GridViewProducto.Columns(6).OptionsColumn.ReadOnly = False

        Me.GridViewProducto.Columns.AddField("CantFacturada")
        Me.GridViewProducto.Columns(7).Width = 100
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatString = "n0"
        Me.GridViewProducto.Columns(7).Caption = "CantFacturada"
        Me.GridViewProducto.Columns(7).Visible = True
        Me.GridViewProducto.Columns(7).OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns.AddField("CantBonificada")
        Me.GridViewProducto.Columns(8).Width = 80
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatString = "n0"
        Me.GridViewProducto.Columns(8).Caption = "CantBonif"
        Me.GridViewProducto.Columns(8).Visible = True
        Me.GridViewProducto.Columns(8).OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns.AddField("LoteProveedor")
        Me.GridViewProducto.Columns(9).Width = 100
        Me.GridViewProducto.Columns(9).Caption = "Lote"
        Me.GridViewProducto.Columns(9).Visible = True
        Me.GridViewProducto.Columns(9).OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns.AddField("CantidadLote")
        Me.GridViewProducto.Columns(10).Width = 80
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatString = "n0"
        Me.GridViewProducto.Columns(10).Caption = "CantLote"
        Me.GridViewProducto.Columns(10).Visible = True
        Me.GridViewProducto.Columns(10).OptionsColumn.AllowEdit = False

        Me.GridViewProducto.Columns.AddField("CantADev")
        Me.GridViewProducto.Columns(11).Width = 100
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatString = "n0"
        Me.GridViewProducto.Columns(11).Caption = "CantDevolucion"
        Me.GridViewProducto.Columns(11).AppearanceHeader.BackColor = Color.DarkBlue
        Me.GridViewProducto.Columns(11).AppearanceHeader.ForeColor = Color.White
        Me.GridViewProducto.Columns(11).Visible = True
        Me.GridViewProducto.Columns(11).FieldName = "CantADev"

        Me.GridViewProducto.Columns(11).AppearanceHeader.ForeColor = Color.Red
        'Me.GridViewProducto.Columns(10).AppearanceCell.ForeColor = Color.White
        Me.GridViewProducto.Columns(11).OptionsColumn.ReadOnly = False
        Me.GridViewProducto.Columns(11).OptionsColumn.AllowEdit = True


        Me.GridViewProducto.Columns.AddField("PorcImpuesto")
        Me.GridViewProducto.Columns(12).Width = 80
        Me.GridViewProducto.Columns(12).Caption = "PorcImpuesto"
        Me.GridViewProducto.Columns(12).Visible = False
        Me.GridViewProducto.Columns(12).FieldName = "PorcImpuesto"

        ' add unbound column
        Dim ubColumn As New DevExpress.XtraGrid.Columns.GridColumn() With {
        .Caption = "MontoDevoluc",
        .FieldName = "Monto",
        .UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
        .Visible = True,
        .UnboundExpression = "(CantADev*Precio)-((CantADev*Precio)*(porcDescuentoEsp/100)+ (CantADev*Precio)*(PorcDescBonif/100))"
            }
        Me.GridViewProducto.Columns.Add(ubColumn)
        Me.GridViewProducto.Columns(13).Width = 100
        Me.GridViewProducto.Columns(13).OptionsColumn.ReadOnly = True
        Me.GridViewProducto.Columns(13).OptionsColumn.AllowFocus = False
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatString = "n2"

        Dim ubColumn2 As New DevExpress.XtraGrid.Columns.GridColumn() With {
        .Caption = "IVADevoluc",
        .FieldName = "ImpuestoDev",
        .UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
        .Visible = True,
        .UnboundExpression = "((CantADev*Precio)-((CantADev*Precio)*(porcDescuentoEsp/100)+ (CantADev*Precio)*(PorcDescBonif/100)))*(PorcImpuesto/100)"
            }
        Me.GridViewProducto.Columns.Add(ubColumn2)
        Me.GridViewProducto.Columns(14).OptionsColumn.ReadOnly = True
        Me.GridViewProducto.Columns(14).OptionsColumn.AllowFocus = False
        Me.GridViewProducto.Columns(14).Width = 100
        Me.GridViewProducto.Columns(14).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(14).DisplayFormat.FormatString = "n2"
        

    End Sub
    
    Private Sub CargaDatosFactura()
        If giIDFactura <> 0 Then
            Dim sParameters As String = giIDFactura.ToString()
            tableData = cManager.ExecSPgetData("fafPrintFacturaLote", sParameters)
            CargagridLookUpsFromTables()
            If tableData.Rows.Count > 0 Then

                Me.SearchLookUpEditSucursal.EditValue = CInt(tableData.Rows(0)("IDBodega"))
                Me.SearchLookUpEditPlazo.EditValue = CInt(tableData.Rows(0)("IDPlazo"))
                Me.SearchLookUpEditVendedor.EditValue = CInt(tableData.Rows(0)("IDVendedor"))
                Me.SearchLookUpEditTipoFact.EditValue = CInt(tableData.Rows(0)("IDTipo"))
                Me.SearchLookUpEditTipoEntrega.EditValue = CInt(tableData.Rows(0)("IDTipoEntrega"))
                Me.txtIDCliente.EditValue = CInt(tableData.Rows(0)("IDCliente"))
                Me.SearchLookUpEditNivel.EditValue = CInt(tableData.Rows(0)("IDNivel"))
                Me.SearchLookUpEditMoneda.EditValue = CInt(tableData.Rows(0)("IDMoneda"))
                Me.txtNombre.EditValue = tableData.Rows(0)("Nombre").ToString()

                If CBool(tableData.Rows(0)("EsTeleventa")) = True Then
                    Me.CheckEditTeleVenta.EditValue = CBool(tableData.Rows(0)("EsTeleventa"))
                End If
                Me.DateEditFecha.EditValue = Convert.ToDateTime(tableData.Rows(0)("Fecha"))
                Me.txtFactura.EditValue = tableData.Rows(0)("Factura").ToString()
                Me.txtTipoCambio.EditValue = tableData.Rows(0)("TipoCambio").ToString()
                tableData.Columns("CantADev").ReadOnly = False
                Me.GridControl1.DataSource = tableData
                Me.GridViewProducto.Columns(11).OptionsColumn.AllowMerge = DefaultBoolean.False
                Me.GridViewProducto.Columns(11).DisplayFormat.FormatType = FormatType.Numeric
                Me.GridViewProducto.Columns(11).DisplayFormat.FormatString = "n0"

            End If
        End If
    End Sub
    Sub CargagridLookUpsFromTables()

        'CargagridSearchLookUp(Me.SearchLookUpEditCliente, "vClientes", "IDCliente, Nombre, Telefono, Farmacia,Direccion, DescrTipo, DescrCategoria, Activo", "", "IDCliente", "Nombre", "IDCliente")
        CargagridSearchLookUp(Me.SearchLookUpEditPlazo, "ccfPlazo", "Plazo, Descr, Activo", "", "Plazo", "Descr", "Plazo")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoFact, "fafTipoFactura", "IDTipo, Descr, Activo", "", "IDTipo", "Descr", "IDTipo")
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoEntrega, "fafTipoEntrega", "IDTipoEntrega, Descr, Activo", "", "IDTipoEntrega", "Descr", "IDTipoEntrega")
        CargagridSearchLookUp(Me.SearchLookUpEditNivel, "fafNivelPrecio", "IDNivel, Descr, Activo", "", "IDNivel", "Descr", "IDNivel")
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr, Activo", "", "IDMoneda", "Descr", "IDMoneda")
        CargagridSearchLookUp(Me.SearchLookUpClase, "ccfClaseDocumento", "IDClase, Descr, Activo", "TipoDocumento = 'C' and IDClase='" & gParametrosCCF.IDClaseNCDevolucion & "'", "IDClase", "Descr", "IDClase")
        Me.SearchLookUpClase.EditValue = gParametrosCCF.IDClaseNCDevolucion

        'CargagridSearchLookUp(Me.SearchLookUpEditProducto, "invProducto", "IDProducto, Descr, Activo", "", "IDProducto", "Descr", "IDProducto")
        Me.DateEditFecha.EditValue = Date.Now

        Me.SearchLookUpEditSucursal.EditValue = gsSucursal

        Me.SearchLookUpEditSucursal.ReadOnly = True
    End Sub
    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit 'DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        g.Properties.PopupFormSize = New Size(250, 250)
        g.Properties.NullText = ""
    End Sub

    Private Sub TotalizaGrid()
        Try
            Dim TotalDevSinIVA As Decimal = 0
            Dim TotalDevIVA As Decimal = 0
            For i As Integer = 0 To GridViewProducto.DataRowCount - 1
                If CDec(GridViewProducto.GetRowCellValue(i, "CantADev")) > 0 Then
                    TotalDevSinIVA = TotalDevSinIVA + CDec(GridViewProducto.GetRowCellValue(i, "Monto"))
                    TotalDevIVA = TotalDevIVA + CDec(GridViewProducto.GetRowCellValue(i, "ImpuestoDev"))
                End If
            Next i

            If (TotalDevSinIVA + TotalDevIVA) > 0 Then
                Me.txtTotalDevsinIVA.EditValue = Math.Round(TotalDevSinIVA, gParametros.DigitosDecimales)
                Me.txtTotalDevIVA.EditValue = Math.Round(TotalDevIVA, gParametros.DigitosDecimales)
                Me.txtMonto.EditValue = Math.Round(TotalDevSinIVA + TotalDevIVA, gParametros.DigitosDecimales)
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub GridViewProducto_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridViewProducto.ValidateRow
        Try
            Dim CantADev As Integer = CInt(GridViewProducto.GetRowCellValue(e.RowHandle, "CantADev"))
            Dim Cantidad As Integer = CInt(GridViewProducto.GetRowCellValue(e.RowHandle, "CantidadLote"))
            If CantADev < 0 Then
                MessageBox.Show("El valor a Devolver debe ser mayor que Cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridViewProducto.SetRowCellValue(GridViewProducto.FocusedRowHandle, GridViewProducto.FocusedColumn, 0)
                gbError = True
                Return
            End If

            If CantADev > Cantidad Then
                MessageBox.Show("Ud no puede devolver más que la Cantidad Facturada en ese lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridViewProducto.SetRowCellValue(GridViewProducto.FocusedRowHandle, GridViewProducto.FocusedColumn, 0)
                gbError = True
            Else
                Dim cellValue As Decimal = (GridViewProducto.GetRowCellValue(e.RowHandle, "CantADev"))
                GridViewProducto.SetRowCellValue(e.RowHandle, "CantADev", Math.Round(cellValue, 0))
                gbError = False
                TotalizaGrid()
            End If
        Catch ex As Exception
            gbError = True
            MessageBox.Show("Ha ocurrido un error  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ControlsOk() As Boolean
        If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
            SearchLookUpEditSucursal.Focus()
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then
            DateEditFecha.Focus()
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Fecha del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Me.txtIDCliente.Text = "" Or Not (Me.txtIDCliente.EditValue IsNot Nothing Or txtNombre.EditValue IsNot Nothing) Then
            txtIDCliente.Focus()
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not (Me.SearchLookUpEditVendedor.EditValue IsNot Nothing) Then
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchLookUpEditVendedor.Focus()
            Return False
        End If
        If Not (Me.SearchLookUpEditPlazo.EditValue IsNot Nothing) Then
            SearchLookUpEditPlazo.Focus()
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtDevolucion.Text = "" Then
            MessageBox.Show("Por favor revise los datos del Documento, El número de la Devolución no puede quedar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not (Me.DateEditFechaDevolucion.EditValue IsNot Nothing) Then
            DateEditFechaDevolucion.Focus()
            MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Fecha para la Devolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Me.CheckEditNotaCredito.Checked = True Then
            If txtDocumento.Text = "" Then
                MessageBox.Show("Por favor revise los datos del Documento, El número de la N/C no puede quedar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Not (Me.SearchLookUpClase.EditValue IsNot Nothing) Then
                SearchLookUpClase.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar una Clase de Documento N/C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Not (Me.SearchLookUpEditSubTipo.EditValue IsNot Nothing) Then
                SearchLookUpEditSubTipo.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, debe seleccionar un SubTipo de Documento N/C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If txtMonto.EditValue = 0 Or txtMonto.EditValue Is Nothing Or String.IsNullOrEmpty(txtMonto.EditValue) Then
                txtMonto.Focus()
                MessageBox.Show("Por favor revise los datos del Documento, Debe Revisar el Monto del Documento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

        End If
        Return True
    End Function
    Private Sub GeneraDevolucion()

        Try
            If Not IsMaskOK(gsMascara, Me.txtDevolucion.EditValue) Then
                'MessageBox.Show("El valor de la Devolución no cumple con el patron de la   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDevolucion.Focus()
                Exit Sub
            End If

            If cManager.ExistsInTable("fafDevolucion", "Devolucion", "Devolucion='" & txtDevolucion.EditValue.ToString() & "' and IDBodega=" & Me.SearchLookUpEditSucursal.EditValue.ToString(), "Devolucion") Then
                MessageBox.Show("Por favor revise los datos de la Devolución, esa Devolución ya Existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not ControlsOk() Then
                Exit Sub
            End If
            InsertDataFromGridToTableDetDevolucion()
            If tableDetDev.Rows.Count > 0 Then
                gdTotalNotaCredito = 0
                ' Registro la Cabecera de la Devolucion
                ' Preparando los datos de la cabecera 

                Dim sParameters As String
                Dim sIDNotaCredito As String = "null"
                sParameters = "'I',0," & giIDFactura.ToString() & ",'" & CDate(Me.DateEditFechaDevolucion.EditValue).ToString("yyyyMMdd") & "','" & gsConsecMask & "','" & Me.txtDevolucion.Text & "'," & Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & Me.SearchLookUpEditMoneda.EditValue.ToString() & ", '" & gsUsuario & "'," & _
                    Me.txtTipoCambio.EditValue.ToString() & ", 0," & IIf(Me.CheckEditNotaCredito.EditValue = True, "1", "0") & "," & sIDNotaCredito
                'creando la instruccion de insercion en la cabecera
                Dim sSql As String = cManager.CreateStoreProcSql("fafUpdateDevolucion", sParameters)
                Dim clase As New CbatchSQLIitem(sSql, True, False, True, False, "fafUpdateDevolucion", "fafUpdateDevolucion")
                cManager.batchSQLLista.Add(clase)
                cManager.batchSQLitem.Clear()
                cManager.batchSQLitem.Add(sSql)

               
                ' Recorro las lineas de la devolucion filtrados
                For Each drItem As DataRow In tableDetDev.Rows
                    Dim dr As DataRow = drItem
                    sParameters = "'I'" & ",@@Identity" & "," & dr("IDProducto").ToString() & "," & dr("IDLote").ToString() & "," & dr("Cantidad").ToString() & "," & dr("Precio").ToString() & "," & _
                                 dr("PorcDescBonif").ToString() & "," & dr("PorcDescEspecial").ToString() & "," & CDec(dr("Monto")).ToString() & "," & CDec(dr("IVA")).ToString()

                    sSql = cManager.CreateStoreProcSql("fafUpdateDevDetalle", sParameters)
                    clase = New CbatchSQLIitem(sSql, False, True, False, True, "fafUpdateDevolucion", "fafUpdateDevDetalle")
                    cManager.batchSQLitem.Add(sSql)
                    cManager.batchSQLLista.Add(clase)
                    gdTotalNotaCredito = gdTotalNotaCredito + CDec(dr("Monto")) + CDec(dr("IVA"))

                Next

                ' Afecto el inventario, de la Devolucion 
                sParameters = "@@Identity" & ", '" & gsUsuario & "'"
                'creando la instruccion de insercion en la cabecera
                sSql = cManager.CreateStoreProcSql("fafAplicaDevolucionInventario", sParameters)
                clase = New CbatchSQLIitem(sSql, False, True, False, True, "fafUpdateDevolucion", "fafAplicaDevolucionInventario")
                cManager.batchSQLLista.Add(clase)
                cManager.batchSQLitem.Clear()
                cManager.batchSQLitem.Add(sSql)

                If Me.CheckEditNotaCredito.Checked = True Then
                    sParameters = "'I'"
                    sParameters = sParameters & ",0,@@Identity," & txtIDCliente.EditValue.ToString() & ","
                    sParameters = sParameters & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'C','"
                    sParameters = sParameters & Me.SearchLookUpClase.EditValue.ToString() & "',"
                    sParameters = sParameters & Me.SearchLookUpEditSubTipo.EditValue.ToString() & ",'"
                    sParameters = sParameters & Me.txtDocumento.EditValue.ToString() & "','"
                    sParameters = sParameters & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',"
                    sParameters = sParameters & Me.SearchLookUpEditPlazo.EditValue.ToString() & ","
                    sParameters = sParameters & Me.txtMonto.EditValue.ToString() & ",'"
                    sParameters = sParameters & Me.SearchLookUpClase.EditValue.ToString() & " : " & txtDocumento.Text & " Cliente " & txtIDCliente.Text & " " & Me.txtNombre.EditValue.ToString() & " Generado en FACTURACION" & "','"
                    sParameters = sParameters & "DEVOLUCION DE PRODUCTOS EN FACTURA','"
                    sParameters = sParameters & Me.txtNombre.EditValue.ToString() & "','"
                    sParameters = sParameters & gsUsuario & "',"
                    sParameters = sParameters & txtTipoCambio.EditValue.ToString() & ","
                    sParameters = sParameters & Me.SearchLookUpEditVendedor.EditValue.ToString() & ","
                    sParameters = sParameters & "1,"
                    sParameters = sParameters & "1,'" & gsCodigoConsecMask & "',"
                    sParameters = sParameters & Me.SearchLookUpEditMoneda.EditValue.ToString()
                    sSql = cManager.CreateStoreProcSql("ccfUpdateccfNotaCreditoDev", sParameters)
                    clase = New CbatchSQLIitem(sSql, False, True, True, True, "fafUpdateDevolucion", "ccfUpdateccfNotaCreditoDev")
                    cManager.batchSQLLista.Add(clase)
                    cManager.batchSQLitem.Clear()
                    cManager.batchSQLitem.Add(sSql)
                End If
                If cManager.ExecCmdWithTransaction() Then
                    MessageBox.Show("Devolucion registrada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al registrar la Devolucion " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AsignFieldsToTableDetalleDevolucion()
        tableDetDev.Columns.Add("IDProducto")
        tableDetDev.Columns.Add("IDLote")
        tableDetDev.Columns.Add("Cantidad")
        tableDetDev.Columns.Add("Precio")
        tableDetDev.Columns.Add("PorcDescBonif")
        tableDetDev.Columns.Add("PorcDescEspecial")
        tableDetDev.Columns.Add("Monto")
        tableDetDev.Columns.Add("IVA")
    End Sub
    Private Sub InsertDataFromGridToTableDetDevolucion()
        Dim row As DataRow
        tableDetDev.Rows.Clear()
        For i As Integer = 0 To GridViewProducto.DataRowCount - 1
            If CDec(GridViewProducto.GetRowCellValue(i, "CantADev")) > 0 Then
                row = tableDetDev.NewRow()
                row("IDProducto") = CInt(GridViewProducto.GetRowCellValue(i, "IDProducto"))
                row("IDLote") = CInt(GridViewProducto.GetRowCellValue(i, "IDLote"))
                row("Cantidad") = CDec(GridViewProducto.GetRowCellValue(i, "CantADev"))
                row("Precio") = CDec(GridViewProducto.GetRowCellValue(i, "Precio"))
                row("PorcDescBonif") = CDec(GridViewProducto.GetRowCellValue(i, "PorcDescBonif"))
                row("PorcDescEspecial") = CDec(GridViewProducto.GetRowCellValue(i, "PorcDescEspecial"))
                row("Monto") = CDec(GridViewProducto.GetRowCellValue(i, "Monto"))
                row("IVA") = CDec(GridViewProducto.GetRowCellValue(i, "ImpuestoDev"))
                tableDetDev.Rows.Add(row)
            End If
        Next i
    End Sub

    Private Sub CargaConsecutivo()
        Dim sParameters As String
        Dim td As New DataTable
        sParameters = "'" & gsConsecMask & "'"
        td = cManager.ExecFunction("getNextConsecMask", sParameters)
        If td.Rows.Count <= 0 Then
            MessageBox.Show("No existe un Consecutivo con Mascara para la Devolucion, por favor llamar al Adminstrador del Sistema, debe definirlo en la Bodega correspondiente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.txtDevolucion.EditValue = td.Rows(0)(0)
        Me.DateEditFechaDevolucion.EditValue = Now
        td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
        gsMascara = td.Rows(0)(0)


    End Sub


    Private Sub CheckEditNotaCredito_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditNotaCredito.CheckedChanged
        If CheckEditNotaCredito.Checked = True Then
            ReadOnlyGroupNotaCredito(False)
        Else
            ReadOnlyGroupNotaCredito(True)
        End If

    End Sub
    Private Sub ReadOnlyGroupNotaCredito(bEnable As Boolean)
        Me.SearchLookUpClase.ReadOnly = bEnable
        Me.SearchLookUpEditSubTipo.ReadOnly = bEnable
        Me.txtDocumento.ReadOnly = bEnable
        Me.txtMonto.ReadOnly = True

    End Sub

    Private Sub SearchLookUpEditSubTipo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSubTipo.EditValueChanged
        Try
            If Me.SearchLookUpClase.EditValue Is Nothing Then
                MessageBox.Show("Ud debe seleccionar una Clase de Documento primero, por favor proceda a seleccinar una Clase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Me.SearchLookUpEditSubTipo.EditValue Is Nothing Then
                MessageBox.Show("Ud debe seleccionar un SubTipo de Documento , por favor proceda a seleccinar un SubTipo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim sIDClase As String = Me.SearchLookUpClase.EditValue.ToString()
            Dim sIDSubTipo As String = Me.SearchLookUpEditSubTipo.EditValue.ToString()
            If sIDClase <> "" And sIDSubTipo <> "" Then
                gsCodigoConsecMask = getConsecutivoSubTipo(sIDClase, sIDSubTipo)
                'rbDebitos.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el consecutivo " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function getConsecutivoSubTipo(spIDClase As String, spIDSubTipo As String) As String
        Dim td As New DataTable
        Dim lsCodigoConsecMask As String = ""
        Dim cManager As New Clases.ClassManager
        Dim sParameters As String = "IDClase ='" & spIDClase & "' and IDSubTipo ='" & spIDSubTipo & "'"
        If spIDClase = "" Or spIDSubTipo = "" Then
            lsCodigoConsecMask = ""
            Return lsCodigoConsecMask
        End If
        td = cManager.GetDataTable("ccfSubTipoDocumento", "IDClase, IDSubtipo, CodigoConsecMask", sParameters, "IDSubTipo")
        lsCodigoConsecMask = td.Rows(0)("CodigoConsecMask").ToString()

        sParameters = "'" & lsCodigoConsecMask & "'"
        td = cManager.ExecFunction("getNextConsecMask", sParameters)
        If td.Rows.Count <= 0 Then
            lsCodigoConsecMask = ""
            MessageBox.Show("No existe un Consecutivo con Mascara para el SubTipo seleccionado, por favor llamar al Adminstrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return lsCodigoConsecMask
        End If

        Me.txtDocumento.EditValue = td.Rows(0)(0)
        gsConsecutivoAnterior = txtDocumento.EditValue
      
        td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
        gsMascara = td.Rows(0)(0)
        Return lsCodigoConsecMask
    End Function


    Private Sub SearchLookUpClase_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpClase.EditValueChanged
        If Me.SearchLookUpClase.Text <> "" Then
            CargagridSearchLookUp(Me.SearchLookUpEditSubTipo, "ccfSubTipoDocumento", "IDSubTipo, Descr", "TipoDocumento = 'C' and IDClase = '" & Me.SearchLookUpClase.EditValue.ToString() & "' and IDSubTipo=" & gParametrosCCF.IDSubTipoNCDevolucion.ToString(), "IDSubTipo", "Descr", "IDSubTipo")
            Me.SearchLookUpEditSubTipo.EditValue = gParametrosCCF.IDSubTipoNCDevolucion
            'Me.SearchLookUpEditSubTipo.Text = ""
        End If

    End Sub


    Private Sub BarButtonItemAplicaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ó.ItemClick
        GeneraDevolucion()
    End Sub

    Private Sub BarButtonItemRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRefresh.ItemClick
        Me.Close()
    End Sub

    Private Sub txtDevolucion_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevolucion.EditValueChanged

    End Sub
End Class