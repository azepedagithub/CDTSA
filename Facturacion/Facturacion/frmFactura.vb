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
Imports System.Collections.Generic
Imports DevExpress.LookAndFeel
Imports System.Globalization
Imports DevExpress.DataAccess.Sql
Imports System.Linq
Imports DevExpress.DataAccess.ConnectionParameters

Public Class frmFactura
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()


    'Dim dtFacturaLineaBonif As New DataTable()
    Dim currentRow As DataRow ' esta row es del grid, linea producto de la factura 
    Dim gsPedidoID As String
    Dim gsIDBodega As String
    Dim gsIDProducto As String
    Dim gbUsaPedido As Boolean = False
    Dim gbBonifica As Boolean = False
    Dim gbBonifConProd As Boolean = False
    Dim gbLoteAsignado As Boolean = False
    Dim gdTotalBonificado As Decimal = 0
    Dim gdTotalBonificadoPrecio As Decimal = 0
    Dim gdTotalFacturado As Decimal = 0
    Dim gdPorcInteres As Decimal = 0
    Dim gIDPlazo As Integer
    Dim gbLoteAsignadoLinea As Boolean = False
    Public gsConsecMask As String
    Dim gsMascara As String
    Dim iNumeroLineasFactura As Integer = 0
    Dim gdBonoProductoActual As Decimal = 0
    Dim gbRequiereBonif As Boolean = False
    Dim gdPorcDescPromFecha As Decimal = 0
    Dim gdPorcDescPromEscala As Decimal = 0


    Sub CargagridLookUp(ByVal g As GridLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.PopupFilterMode = PopupFilterMode.Default
        g.Properties.NullText = ""

    End Sub



    Private Sub InserttblRowFacturaLinea(bLoteAsignado As Boolean, iIDBodega As Integer, iIDProducto As Integer, sDescr As String, dCantidad As Decimal, dPrecio As Decimal, dDescuento As Decimal, dDescuentoEspecial As Decimal, _
            dImpuesto As Decimal, dPorcImp As Decimal, dSubTotal As Decimal, dSubTotalFinal As Decimal, dTotal As Decimal, bBonifica As Boolean, bBonifConProd As Boolean, dCantBonificada As Decimal, dCantPrecio As Decimal, dCantFacturada As Decimal, dPorcDescuentoEsp As Decimal, dPrecioLista As Decimal, dAhorro As Decimal)

        dtFacturaLinea.Rows.Add(bLoteAsignado, iIDBodega, iIDProducto, sDescr, dCantidad, dPrecio, dDescuento, dDescuentoEspecial, dImpuesto, dPorcImp, dSubTotal,
            dSubTotalFinal, dTotal, bBonifica, bBonifConProd, dCantBonificada, dCantPrecio, dCantFacturada, 0, 0, dPorcDescuentoEsp, dPrecioLista, dAhorro)
    End Sub

    Private Sub FillTableFacturalinea()
        Dim dPrecio As Decimal, dDescuento As Decimal, dDescuentoEspecial As Decimal, _
            dImpuesto As Decimal, dSubTotal As Decimal, dSubTotalFinal As Decimal, dTotal As Decimal, dPorcImp As Decimal, dPrecioLista As Decimal, dAhorro As Decimal
        If gbUsaPedido Then
            For Each dr In tableData.Rows ' Me.dtFacturaLinea.Rows
                If CBool(dr("Nacional")) Then
                    dPrecio = Redondear(If(dr("PrecioLocal") IsNot Nothing, CDec(dr("PrecioLocal")), 0), gParametros.DigitosDecimales)
                    dImpuesto = Redondear(If(dr("ImpuestoLocal") IsNot Nothing, CDec(dr("ImpuestoLocal")), 0), gParametros.DigitosDecimales)
                    dSubTotal = Redondear(If(dr("SubTotalLocal") IsNot Nothing, CDec(dr("SubTotalLocal")), 0), gParametros.DigitosDecimales)
                    dSubTotalFinal = Redondear(If(dr("SubTotalFinalLocal") IsNot Nothing, CDec(dr("SubTotalFinalLocal")), 0), gParametros.DigitosDecimales)
                    dDescuento = Redondear(If(dr("DescuentoLocal") IsNot Nothing, CDec(dr("DescuentoLocal")), 0), gParametros.DigitosDecimales)
                    dDescuentoEspecial = Redondear(If(dr("DescuentoEspecialLocal") IsNot Nothing, CDec(dr("DescuentoEspecialLocal")), 0), gParametros.DigitosDecimales)
                    dTotal = Redondear(dSubTotalFinal + dImpuesto, gParametros.DigitosDecimales)
                Else
                    dPrecio = Redondear(If(dr("PrecioDolar") IsNot Nothing, CDec(dr("PrecioDolar")), 0), gParametros.DigitosDecimales)
                    dImpuesto = Redondear(If(dr("ImpuestoDolar") IsNot Nothing, CDec(dr("ImpuestoDolar")), 0), gParametros.DigitosDecimales)
                    dSubTotal = Redondear(If(dr("SubTotalDolar") IsNot Nothing, CDec(dr("SubTotalDolar")), 0), gParametros.DigitosDecimales)
                    dSubTotalFinal = Redondear(If(dr("SubTotalFinalDolar") IsNot Nothing, CDec(dr("SubTotalFinalDolar")), 0), gParametros.DigitosDecimales)
                    dDescuento = Redondear(If(dr("DescuentoDolar") IsNot Nothing, CDec(dr("DescuentoDolar")), 0), gParametros.DigitosDecimales)
                    dDescuentoEspecial = Redondear(If(dr("DescuentoEspecialDolar") IsNot Nothing, CDec(dr("DescuentoEspecialDolar")), 0), gParametros.DigitosDecimales)
                    dTotal = Redondear(dSubTotalFinal + dImpuesto, gParametros.DigitosDecimales)
                End If
                dPorcImp = Redondear(CDec(dr("PorcImp")), gParametros.DigitosDecimales)
                dPrecioLista = Redondear(CDec(dr("PrecioLista")), gParametros.DigitosDecimales)
                dAhorro = Redondear(CDec(dr("Ahorro")), gParametros.DigitosDecimales)
                Dim dCantidad As Integer
                dCantidad = Redondear(Convert.ToDecimal(dr("Cantidad")), gParametros.DigitosDecimales) '- Convert.ToDecimal(dr("CantBonificada"))
                InserttblRowFacturaLinea(False, Convert.ToInt32(dr("IDBodega")), Convert.ToInt32(dr("IDProducto")), dr("Descr").ToString(), _
                                        dCantidad, dPrecio, _
                                        dDescuento, dDescuentoEspecial, _
                                       dImpuesto, dPorcImp, _
                                        dSubTotal, dSubTotalFinal, dTotal, CBool(dr("Bonifica")), _
                                        CBool(dr("BonifConProd")), _
                                Convert.ToDecimal(dr("CantBonificada")), Convert.ToDecimal(dr("CantPrecio")), dCantidad, Convert.ToDecimal(dr("PorcDescuentoEsp")), dPrecioLista, dAhorro)
            Next dr
        End If

    End Sub

    Private Sub InserttblRowFacturaLineaLote(iIDLote As Integer, iIDProducto As Integer, dCantidad As Decimal)
        dtFacturaLineaLote.Rows.Add(iIDLote, iIDProducto, dCantidad)
    End Sub



    ' UpdateDatatable LInea de Factura
    Sub UpdateDataTableRowFacLin(strCriterio As String)
        Dim myRow() As Data.DataRow
        Dim dCantidadBonificada As Decimal = 0, dCantidadPrecio As Decimal = 0

        dCantidadBonificada = CDec(txtCantBonif.EditValue)
        dCantidadPrecio = CDec(txtCantPrecio.EditValue)
        myRow = dtFacturaLinea.Select(strCriterio)
        If myRow.Count > 0 Then
            txtDescLinea.EditValue = dCantidadBonificada * Redondear(CDbl(txtPrecio.EditValue), gParametros.DigitosDecimales)
            myRow(0)("Precio") = Redondear(txtPrecio.EditValue, gParametros.DigitosDecimales)
            myRow(0)("Impuesto") = Redondear(CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            myRow(0)("SubTotal") = Redondear(CDec(Me.txtPrecio.EditValue), gParametros.DigitosDecimales) * (CInt(txtCantidad.EditValue) + CInt(txtCantBonif.EditValue))
            myRow(0)("DescuentoEspecial") = Redondear(CDec(Me.txtDescEspLinea.EditValue), gParametros.DigitosDecimales)
            myRow(0)("Descuento") = dCantidadBonificada * Redondear(CDbl(txtPrecio.EditValue), gParametros.DigitosDecimales)
            myRow(0)("SubTotalFinal") = CDec(myRow(0)("SubTotal")) - CDec(myRow(0)("Descuento")) - CDec(myRow(0)("DescuentoEspecial"))
            myRow(0)("Total") = CDec(myRow(0)("SubTotalFinal")) + Redondear(CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            myRow(0)("CantBonificada") = dCantidadBonificada ' nuevo 19/09/2020
            myRow(0)("CantPrecio") = dCantidadPrecio  ' nuevo 21/09/2020


        End If
    End Sub

    Sub CreateFieldsToDataTable()
        dtFacturaLinea = New DataTable
        dtFacturaLineaLote = New DataTable

        ' Campos del detalle de la factura
        dtFacturaLinea.Columns.Add("LoteAsignado", GetType(Boolean))
        dtFacturaLinea.Columns.Add("IDBodega", GetType(Integer))
        dtFacturaLinea.Columns.Add("IDProducto", GetType(Integer))
        dtFacturaLinea.Columns.Add("Descr", GetType(String))
        dtFacturaLinea.Columns.Add("Cantidad", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Precio", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Descuento", GetType(Decimal))
        dtFacturaLinea.Columns.Add("DescuentoEspecial", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Impuesto", GetType(Decimal))
        dtFacturaLinea.Columns.Add("PorcImp", GetType(Decimal))
        dtFacturaLinea.Columns.Add("SubTotal", GetType(Decimal))
        dtFacturaLinea.Columns.Add("SubTotalFinal", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Total", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Bonifica", GetType(Boolean))
        dtFacturaLinea.Columns.Add("BonifConProd", GetType(Boolean))
        dtFacturaLinea.Columns.Add("CantBonificada", GetType(Decimal))
        dtFacturaLinea.Columns.Add("CantPrecio", GetType(Decimal))
        dtFacturaLinea.Columns.Add("CantFacturada", GetType(Decimal))
        dtFacturaLinea.Columns.Add("CostoLocal", GetType(Decimal))
        dtFacturaLinea.Columns.Add("CostoDolar", GetType(Decimal))
        dtFacturaLinea.Columns.Add("PorcDescuentoEsp", GetType(Decimal))
        dtFacturaLinea.Columns.Add("PrecioLista", GetType(Decimal))
        dtFacturaLinea.Columns.Add("Ahorro", GetType(Decimal))

        'Lotes/fact/Bonificacion
        dtFacturaLineaLote.Columns.Add("IDBodega", GetType(Integer))
        dtFacturaLineaLote.Columns.Add("IDProducto", GetType(Integer))
        dtFacturaLineaLote.Columns.Add("IDLote", GetType(Integer))
        dtFacturaLineaLote.Columns.Add("CantFacturada", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("CantBonificada", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("Cantidad", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("Requerido", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("Bono", GetType(Decimal))
        ' Extras para cuando quieran ver lo que ya fue asignado
        dtFacturaLineaLote.Columns.Add("Descr", GetType(String))
        dtFacturaLineaLote.Columns.Add("LoteInterno", GetType(String))
        dtFacturaLineaLote.Columns.Add("LoteProveedor", GetType(String))
        dtFacturaLineaLote.Columns.Add("Vencimiento", GetType(Date))
        dtFacturaLineaLote.Columns.Add("Existencia", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("AsignadoFA", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("AsignadoBO", GetType(Decimal))
        dtFacturaLineaLote.Columns.Add("AsignadoPrecio", GetType(Decimal))

    End Sub



    Sub CargagridLookUpsFromTables()

        CargagridSearchLookUp(Me.SearchLookUpEditPlazo, "ccfPlazo", "Plazo, Descr, Activo", "", "Plazo", "Descr", "Plazo")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoFact, "fafTipoFactura", "IDTipo, Descr, Activo", "", "IDTipo", "Descr", "IDTipo")
        CargagridSearchLookUp(Me.SearchLookUpEditSucursal, "invBodega", "IDBodega, Descr, Activo", "", "IDBodega", "Descr", "IDBodega")
        CargagridSearchLookUp(Me.SearchLookUpEditVendedor, "fafVendedor", "IDVendedor, Nombre, Activo", "", "IDVendedor", "Nombre", "IDVendedor")
        CargagridSearchLookUp(Me.SearchLookUpEditTipoEntrega, "fafTipoEntrega", "IDTipoEntrega, Descr, Activo", "", "IDTipoEntrega", "Descr", "IDTipoEntrega")
        CargagridSearchLookUp(Me.SearchLookUpEditNivel, "fafNivelPrecio", "IDNivel, Descr, Activo", "", "IDNivel", "Descr", "IDNivel")
        CargagridSearchLookUp(Me.SearchLookUpEditMoneda, "globalMoneda", "IDMoneda, Descr, Activo", "", "IDMoneda", "Descr", "IDMoneda")

        Me.DateEditFecha.EditValue = Date.Now
        Me.txtTipoCambio.EditValue = getTipoCambio(Me.DateEditFecha.EditValue, gParametros.TipoCambioFact)
        Me.SearchLookUpEditSucursal.EditValue = gsSucursal
        gsIDBodega = gsSucursal
        Me.SearchLookUpEditSucursal.ReadOnly = True
        If gParametros.DefaultTipoFact Then
            Me.SearchLookUpEditTipoFact.EditValue = gParametros.TipoFactDefault
        End If
        If gParametros.DefaultTipoEntrega Then
            Me.SearchLookUpEditTipoEntrega.EditValue = gParametros.TipoEntregaDefault
        End If
    End Sub
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Try
            If MessageBox.Show("Ud. va a generar una factura que proviene de un Pedido. Esta de acuerdo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                gbUsaPedido = True
                Dim frm As New frmAutorizaPedido()
                frm.gbAutoriza = False
                frm.gbPuedeCrearFactura = True
                frm.ShowDialog()
                If frm.gbPedidoParaFactura = False Then
                    frm.Dispose()
                    gbUsaPedido = False
                    Me.txtIDCliente.Text = ""
                    Me.txtNombre.Text = ""
                    Me.txtFarmacia.Text = ""
                    Me.MemoEditNota.Text = ""
                    Me.SearchLookUpEditVendedor.Text = ""
                    CreateFieldsToDataTable()
                    CargagridLookUpsFromTables()
                    CargaConsecutivo()
                    dtFacturaLinea.Clear()
                    dtFacturaLineaLote.Clear()
                    tableData.Clear()
                    ClearControlslinea()
                    ClearControlsTotales()
                    gbUsaPedido = False
                    Me.GridControl1.DataSource = Nothing
                    Exit Sub
                End If
                If frm.gsIDPedido = "" And frm.gsIDBodega = "" Then
                    frm.Dispose()
                    gbUsaPedido = False
                    Exit Sub
                End If
                If gParametros.EditaPrecioPedidoenFactura Then
                    txtPrecio.Enabled = True
                Else
                    txtPrecio.Enabled = False
                End If
                If gParametros.EditaCantidadPedidoenFactura Then
                    txtCantidad.Enabled = True
                Else
                    txtCantidad.Enabled = False
                End If
                gsPedidoID = frm.gsIDPedido
                gsIDBodega = frm.gsIDBodega
                txtLimite.EditValue = frm.gdLimite
                txtDisponible.EditValue = frm.gdDisponible
                Me.SearchLookUpEditSucursal.EditValue = CInt(gsIDBodega)
                Me.SearchLookUpEditNivel.EditValue = frm.gsIDNivel
                Me.SearchLookUpEditMoneda.EditValue = frm.gsIDMoneda
                Me.SearchLookUpEditPlazo.EditValue = frm.gsIDPlazo
                ' GetImpuestoDescuentoEspecialPrecio()
                ' Cargar el Pedido seleccionadoº
                RefreshGrid()
                TotalizaGrid()
                frm.Dispose()
                If gsPedidoID <> "" And gsIDBodega <> "" Then
                    gbUsaPedido = True
                    txtCantidad.ReadOnly = True
                    txtCantBonif.ReadOnly = True
                    txtCantPrecio.ReadOnly = True
                    EnableBotonesModificaFactura(False)
                Else
                    gbUsaPedido = False
                End If
            Else
                gbUsaPedido = False
            End If
            gbLoteAsignado = False
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar el Pedido " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gbUsaPedido = False
        End Try
    End Sub

    Private Sub EnableBotonesModificaFactura(bEnable As Boolean)
        btnAdd.Enabled = bEnable
        btnNuevo.Enabled = bEnable
        btnDelete.Enabled = bEnable
        btnProducto.Enabled = bEnable

    End Sub
    Sub RefreshGridFromPedido()
        Try
            If gbUsaPedido Then
                If gsPedidoID <> "" Then
                    Dim sParameters As String = gsPedidoID & "," & gsIDBodega & ",null, null,  'A'," & "0"
                    tableData = cManager.ExecSPgetData("fafgetPedido", sParameters)
                    If tableData.Rows.Count > 0 Then
                        dtFacturaLinea.Clear()
                        dtFacturaLineaLote.Clear()
                        Me.SearchLookUpEditSucursal.EditValue = CInt(tableData.Rows(0)("IDBodega"))
                        Me.SearchLookUpEditVendedor.EditValue = CInt(tableData.Rows(0)("IDVendedor"))
                        Me.SearchLookUpEditTipoEntrega.EditValue = CInt(tableData.Rows(0)("IDTipoEntrega"))
                        Me.txtIDCliente.EditValue = CInt(tableData.Rows(0)("IDCliente"))
                        Me.txtNombre.EditValue = tableData.Rows(0)("Nombre").ToString()
                        Me.txtFarmacia.EditValue = tableData.Rows(0)("Farmacia").ToString()
                        If CBool(tableData.Rows(0)("EsTeleventa")) = True Then
                            Me.CheckEditTeleVenta.EditValue = CBool(tableData.Rows(0)("EsTeleventa"))
                        End If

                        FillTableFacturalinea()
                        If dtFacturaLinea.Rows.Count > 0 Then
                            GridControl1.DataSource = dtFacturaLinea
                            GridControl1.Refresh()
                        End If
                    End If
                End If
                gbUsaPedido = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Sub RefreshGrid()
        Try
            If gbUsaPedido Then
                If gsPedidoID <> "" Then
                    Dim sParameters As String = gsPedidoID & "," & gsIDBodega & ",null, null,  'A'," & "0"
                    tableData = cManager.ExecSPgetData("fafgetPedido", sParameters)
                    If tableData.Rows.Count > 0 Then
                        dtFacturaLinea.Clear()
                        dtFacturaLineaLote.Clear()
                        Me.SearchLookUpEditSucursal.EditValue = CInt(tableData.Rows(0)("IDBodega"))
                        Me.SearchLookUpEditVendedor.EditValue = CInt(tableData.Rows(0)("IDVendedor"))
                        Me.SearchLookUpEditTipoEntrega.EditValue = CInt(tableData.Rows(0)("IDTipoEntrega"))
                        Me.txtIDCliente.EditValue = CInt(tableData.Rows(0)("IDCliente"))
                        Me.txtNombre.EditValue = tableData.Rows(0)("Nombre").ToString()
                        Me.txtFarmacia.EditValue = tableData.Rows(0)("Farmacia").ToString()
                        If CBool(tableData.Rows(0)("EsTeleventa")) = True Then
                            Me.CheckEditTeleVenta.EditValue = CBool(tableData.Rows(0)("EsTeleventa"))
                        End If

                        FillTableFacturalinea()
                        If dtFacturaLinea.Rows.Count > 0 Then
                            GridControl1.DataSource = dtFacturaLinea
                            GridControl1.Refresh()
                        End If
                    End If
                End If
                gbUsaPedido = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Sub AssignFieldsToGrid()
        Me.GridViewProducto.Columns.AddField("LoteAsignado")
        Me.GridViewProducto.Columns(0).Caption = "√"

        Me.GridViewProducto.Columns(0).Visible = True
        Me.GridViewProducto.Columns(0).Width = 25
        Me.GridViewProducto.Columns.AddField("Descr")
        Me.GridViewProducto.Columns(1).Width = 200
        Me.GridViewProducto.Columns(1).Caption = "Producto"
        Me.GridViewProducto.Columns(1).Visible = True
        Me.GridViewProducto.Columns.AddField("Cantidad")
        Me.GridViewProducto.Columns(2).Visible = True
        Me.GridViewProducto.Columns(2).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(2).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns.AddField("Precio")
        Me.GridViewProducto.Columns(3).Caption = "Precio"
        Me.GridViewProducto.Columns(3).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(3).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(3).Visible = True

        Me.GridViewProducto.Columns.AddField("Descuento")
        Me.GridViewProducto.Columns(4).Caption = "Descuento"
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(4).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(4).Visible = True

        Me.GridViewProducto.Columns.AddField("DescuentoEspecial")
        Me.GridViewProducto.Columns(5).Caption = "DescEsp"
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns(5).Visible = True


        Me.GridViewProducto.Columns.AddField("Impuesto")
        Me.GridViewProducto.Columns(6).Visible = True
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatString = "n2"
        Me.GridViewProducto.Columns.AddField("SubTotal")
        Me.GridViewProducto.Columns(7).Visible = True
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("Bonifica")
        Me.GridViewProducto.Columns(8).Visible = False

        Me.GridViewProducto.Columns.AddField("BonifConProd")
        Me.GridViewProducto.Columns(9).Visible = False
        'Me.GridViewProducto.Columns.AddField("LoteAsignado")
        'Me.GridViewProducto.Columns(6).DisplayFormat.FormatString = "yn"
        'Me.GridViewProducto.Columns(6).Visible = False
        Me.GridViewProducto.Columns(2).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(4).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(5).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridViewProducto.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    End Sub

    Private Sub frmFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                CallPopUpProducto()
            Case Keys.F2
                AgregaProducto()
            Case Keys.F3
                CallPopUpClientes()
            Case Keys.F4
                NuevoProducto()
            Case Keys.F6
                EliminaItem()
            Case Keys.F10
                GrabarFactura()
        End Select


    End Sub
    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CreateFieldsToDataTable()
            'AssignFieldsToGrid()
            CargagridLookUpsFromTables()
            CargaConsecutivo()
            FormattextNumbers()
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los datos de Factura " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CargaConsecutivo()
        Dim sParameters As String
        Dim td As New DataTable
        sParameters = "'" & gsConsecMask & "'"
        td = cManager.ExecFunction("getNextConsecMask", sParameters)
        If td.Rows.Count <= 0 Then
            MessageBox.Show("No existe un Consecutivo con Mascara para la Factura, por favor llamar al Adminstrador del Sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.txtFactura.EditValue = td.Rows(0)(0)
        td = cManager.ExecFunction("getMascaraFromConsecMask", sParameters)
        gsMascara = td.Rows(0)(0)
    End Sub
    Private Sub GridViewProducto_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridViewProducto.RowCellStyle
        Dim view As GridView = sender

        If e.Column.FieldName = "LoteAsignado" Then
            Dim sConlote As String = (view.GetRowCellDisplayText(e.RowHandle, view.Columns("LoteAsignado")))
            If UCase(sConlote) = UCase("NO SELECCIONADO") Then
                e.Appearance.BackColor = Color.Bisque
            End If
        End If
    End Sub


    Private Sub TotalizaGrid()
        If dtFacturaLinea.Rows.Count > 0 Then
            Dim SubTotal As Decimal = dtFacturaLinea.Compute("Sum(SubTotal)", "")
            Dim Impuesto As Decimal = dtFacturaLinea.Compute("Sum(Impuesto)", "")
            Dim Descuento As Decimal = dtFacturaLinea.Compute("Sum(Descuento)", "")
            Dim DescuentoEsp As Decimal = dtFacturaLinea.Compute("Sum(DescuentoEspecial)", "")
            Me.txtSubTotal.EditValue = Redondear(SubTotal, gParametros.DigitosDecimales)
            Me.txtSubTotalFinal.EditValue = Redondear((SubTotal - Descuento - DescuentoEsp), gParametros.DigitosDecimales)
            Me.txtIGV.EditValue = Redondear(Impuesto, gParametros.DigitosDecimales)
            Me.txtTotal.EditValue = Redondear((SubTotal - Descuento - DescuentoEsp) + Impuesto, gParametros.DigitosDecimales)
            Me.txtDcto.EditValue = Redondear(Descuento, gParametros.DigitosDecimales)
            Me.txtDctoEsp.EditValue = Redondear(DescuentoEsp, gParametros.DigitosDecimales)

        Else
            Me.txtSubTotal.EditValue = 0
            Me.txtIGV.EditValue = 0
            Me.txtDcto.EditValue = 0
            Me.txtDctoEsp.EditValue = 0
            Me.txtTotal.EditValue = 0
        End If

    End Sub

    Private Sub GridViewProducto_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducto.FocusedRowChanged
        RefreshDataFromGridToControls()
    End Sub

    Private Sub FormattextNumbers()
        FormatControlNumber(txtCantidad)
        FormatControlNumber(txtImpuesto)
        FormatControlNumber(txtDescLinea)
        FormatControlNumber(txtDescEspLinea)
        FormatControlNumber(txtTotLinea)
        FormatControlNumber(txtPrecio)
        FormatControlNumber(txtLimite)
        FormatControlNumber(txtDisponible)
        FormatControlNumber(txtAhorro)
        FormatControlNumber(txtSubTotal)
        FormatControlNumber(txtSubTotLin)
        FormatControlNumber(txtSubTotalFinalLin)
        FormatControlNumber(txtPorcDescEsp)
        FormatControlNumber(txtPorcImpt)
        FormatControlNumber(txtExistencia)
        FormatControlNumber(txtCantBonif)
        FormatControlNumber(txtCantPrecio)


    End Sub
    Private Sub RefreshDataFromGridToControls()
        Dim dr As DataRow = GridViewProducto.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then

            Dim dCantidadBonificada As Decimal
            dCantidadBonificada = CDec(dr("CantBonificada"))
            Me.txtCodigo.Text = dr("IDProducto").ToString()
            gbLoteAsignadoLinea = CBool(dr("LoteAsignado"))
            Me.txtDescr.EditValue = dr("Descr")
            Me.txtCantidad.EditValue = Redondear(dr("Cantidad"), gParametros.DigitosDecimales)
            Me.txtPorcImpt.EditValue = dr("PorcImp")
            Me.txtImpuesto.EditValue = Redondear(dr("Impuesto"), gParametros.DigitosDecimales)
            Me.txtDescLinea.EditValue = Redondear(dr("Descuento"), gParametros.DigitosDecimales)
            Me.txtDescEspLinea.EditValue = Redondear(dr("DescuentoEspecial"), gParametros.DigitosDecimales)
            Me.txtCantBonif.EditValue = dr("CantBonificada")
            Me.txtCantPrecio.EditValue = dr("CantPrecio")
            Me.txtSubTotLin.EditValue = Redondear(dr("SubTotal"), gParametros.DigitosDecimales)
            Me.txtSubTotalFinalLin.EditValue = Redondear(dr("SubTotalFinal"), gParametros.DigitosDecimales)
            Me.txtTotLinea.EditValue = Redondear(dr("Total"), gParametros.DigitosDecimales)
            Me.txtCostoPromLocal.EditValue = Redondear(dr("CostoLocal"), gParametros.DigitosDecimales)
            Me.txtCostoPromDolar.EditValue = Redondear(dr("CostoDolar"), gParametros.DigitosDecimales)
            Me.chkBonifica.Checked = Convert.ToBoolean(dr("Bonifica"))
            Me.chkBonificaProd.Checked = Convert.ToBoolean(dr("BonifConProd"))
            Me.txtPorcDescEsp.EditValue = Redondear(dr("PorcDescuentoEsp"), gParametros.DigitosDecimales)
            Me.txtPrecio.EditValue = Redondear(dr("Precio"), gParametros.DigitosDecimales)
            Me.txtPrecioLista.EditValue = dr("PrecioLista")
            Me.txtAhorro.EditValue = dr("Ahorro")
            If txtAhorro.EditValue > 0 Then
                txtAhorro.Visible = True
            Else
                txtAhorro.Visible = False
            End If

            TotalizaGrid()
        End If
    End Sub

    Private Sub GridViewProducto_DoubleClick(sender As Object, e As EventArgs) Handles GridViewProducto.DoubleClick
        Dim row As DataRow = GridViewProducto.GetDataRow(GridViewProducto.GetSelectedRows()(0))
        Dim bVerLotesdePedido As Boolean = False
        If row IsNot Nothing Then


            If gbUsaPedido = True And Convert.ToBoolean(row("LoteAsignado")) = True Then

                If MessageBox.Show("Este producto ya tiene asignado sus lotes, Ud desea ver los lotes asignados o reasignar los lotes. Si Ud dice que SI solamente verá los lotes asignados, si dice NO se reasignarán los lotes ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    bVerLotesdePedido = True
                End If
            End If

            If (gbUsaPedido = True And Convert.ToBoolean(row("LoteAsignado")) = False) Or (gbUsaPedido And Convert.ToBoolean(row("LoteAsignado")) = True And bVerLotesdePedido = False) Then
                gsIDBodega = row.Item("IDBodega").ToString()
                gsIDProducto = row.Item("IDProducto").ToString()
                row("LoteAsignado") = False
                'BORRO LOS REGISTROS DE LOTE DEL PRODUCTO delete dtFacturaLineaLote.Clear() where producto = x
                Dim foundRows As DataRow() = dtFacturaLineaLote.Select("IDProducto =" & Me.txtCodigo.EditValue)
                If foundRows.Count > 0 Then

                    For Each foundrow In foundRows
                        foundrow.Delete()
                    Next foundrow
                End If

                PopUpAsignaLote(gsIDBodega, gsIDProducto, row.Item("Cantidad").ToString(), row.Item("Descr").ToString(), True, Me.txtCantBonif.EditValue, CBool(chkBonifica.EditValue), CBool(chkBonificaProd.EditValue))
                Exit Sub
            End If

            ' FACTURA SIN PEDIDO
            If gbUsaPedido = False And Convert.ToBoolean(row("LoteAsignado")) = True Then

                If MessageBox.Show("Este producto ya tiene asignado sus lotes, Ud desea ver los lotes asignados o reasignar los lotes. Si Ud dice que SI solamente verá los lotes asignados, si dice NO se reasignarán los lotes ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    bVerLotesdePedido = True
                End If
            End If
            If bVerLotesdePedido = False Then
                row("LoteAsignado") = False
                'BORRO LOS REGISTROS DE LOTE DEL PRODUCTO delete dtFacturaLineaLote.Clear() where producto = x
                Dim foundRows As DataRow() = dtFacturaLineaLote.Select("IDProducto =" & Me.txtCodigo.EditValue)
                If foundRows.Count > 0 Then

                    For Each foundrow In foundRows
                        foundrow.Delete()
                    Next foundrow
                End If
                PopUpAsignaLote(gsIDBodega, gsIDProducto, row.Item("Cantidad").ToString(), row.Item("Descr").ToString(), True, Me.txtCantBonif.EditValue)

                Return
            End If
            ' Solo para ver los lotes asignado de un producto provenga o no de un pedido
            If (bVerLotesdePedido And Convert.ToBoolean(row("LoteAsignado")) = True) Or (gbUsaPedido = False) Then
                gsIDBodega = row.Item("IDBodega").ToString()
                gsIDProducto = row.Item("IDProducto").ToString()
                PopUpAsignaLote(gsIDBodega, gsIDProducto, row.Item("Cantidad").ToString(), row.Item("Descr").ToString(), False)
                'Else
                '    MessageBox.Show("Ud no ha asignado los lotes a este producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub PopUpAsignaLote(sBodega As String, sIDProducto As String, sCantidad As String, sDescr As String, bAsignaLotes As Boolean, Optional sCantBonifPedido As String = "", Optional bBonifica As Boolean = False, Optional bBonifConProd As Boolean = False)
        gsIDBodega = sBodega ' row.Item("IDBodega").ToString()
        gsIDProducto = sIDProducto '  row.Item("IDProducto").ToString()
        Dim frm As New frmAsignaLote()
        frm.gbUsaPedido = gbUsaPedido
        frm.gsIDBodega = gsIDBodega
        frm.gsIDProducto = gsIDProducto
        frm.gsCantidad = sCantidad  'row.Item("Cantidad").ToString()
        frm.gsDescr = sDescr ' row.Item("Descr").ToString()
        frm.gbAsignaLotes = bAsignaLotes
        frm.gsCantidadBonifPedido = sCantBonifPedido
        frm.gdTotalBonificado = CDec(txtCantBonif.EditValue) ' new 21/09/2020
        frm.gdTotalBonificadoPrecio = CDec(Me.txtCantPrecio.EditValue)
        frm.gbBonifica = Me.chkBonifica.Checked
        frm.gbBonificaProd = Me.chkBonificaProd.Checked
        frm.ShowDialog()
        If frm.gbLotesAsignados = True Then
            gbLoteAsignado = frm.gbLotesAsignados
            gbBonifica = frm.gbBonifica
            gbBonifConProd = frm.gbBonificaProd
            chkBonifica.Checked = gbBonifica
            chkBonificaProd.Checked = gbBonifConProd
            gdTotalBonificado = frm.gdTotalBonificado
            gdTotalBonificadoPrecio = frm.gdTotalBonificadoPrecio
            gdTotalFacturado = frm.gdTotalFacturado
            ' nuevo el dia 14 de octubre18

            ' LIMPIAR dtFacturaLineaLote. CON EL ID DEL PRODUCTO
            'BORRO LOS REGISTROS DE LOTE DEL PRODUCTO delete dtFacturaLineaLote.Clear() where producto = x
            Dim foundRows As DataRow() = dtFacturaLineaLote.Select("IDProducto =" & Me.txtCodigo.EditValue)
            If foundRows.Count > 0 Then

                For Each foundrow In foundRows
                    foundrow.Delete()
                Next foundrow
            End If
            Dim bLoteAsignado As Boolean = False
            For Each row In frm.tableLotesAsignados.Rows
                If CDec(row("AsignadoFA")) > 0 Or CDec(row("AsignadoBO")) > 0 Or CDec(row("AsignadoPrecio")) > 0 Then
                    dtFacturaLineaLote.Rows.Add(Convert.ToInt32(gsIDBodega), Convert.ToInt32(row("IDProducto")), Convert.ToInt32(row("IDLote")), Convert.ToDecimal(row("AsignadoFA")), Convert.ToDecimal(row("AsignadoBO")), (Convert.ToDecimal(row("AsignadoFA")) + Convert.ToDecimal(row("AsignadoBO"))), 0, 0, _
                                                row("Descr").ToString(), row("LoteInterno").ToString(), row("LoteProveedor").ToString(), _
                                                Convert.ToDateTime(row("FechaVencimiento")), Convert.ToDecimal(row("Existencia")), Convert.ToDecimal(row("AsignadoFA")), Convert.ToDecimal(row("AsignadoBO")), Convert.ToDecimal(row("AsignadoPrecio")))
                    bLoteAsignado = True

                End If
            Next

            If bLoteAsignado Then

                txtCantidad.EditValue = txtCantidad.EditValue
                Me.txtCantBonif.EditValue = Redondear(gdTotalBonificado, gParametros.DigitosDecimales)
                Me.txtCantPrecio.EditValue = Redondear(gdTotalBonificadoPrecio, gParametros.DigitosDecimales)
                Me.txtDescLinea.EditValue = Redondear(txtCantBonif.EditValue * txtPrecio.EditValue, gParametros.DigitosDecimales) ' nuevo 19/09/2020
                Me.txtCantPrecio.EditValue = Redondear(gdTotalBonificadoPrecio, gParametros.DigitosDecimales)
                CalculaImpuesto() ' nuevo el 19/09/2020
                UpdateFieldsToGrid() ' nuevo 19/09/2020 esta linea eataba al inicio la movi al final 
                TotalizaGrid()
            End If
        End If

        frm.Dispose()

    End Sub
    Private Sub DeleteRows(sBodega As String, sIDProducto As String)
        Dim strCriteria As String = "IDBodega=" + sBodega + " and IDProducto=" + sIDProducto
        Dim drSelect As DataRow() = tableData.Select(strCriteria)
        If drSelect.Length > 0 Then
            For Each drItem As DataRow In drSelect
                Dim nrow As DataRow = drItem
                tableData.Rows.Remove(nrow)
            Next
        End If
    End Sub

    Private Sub CallPopUpClientes()
        Try
            If Me.SearchLookUpEditSucursal.Text = "" Then
                MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If gsPedidoID <> "" And gsIDBodega <> "" And gbUsaPedido Then
                If MessageBox.Show("Previamente Ud cargo un pedido. Está seguro de ignorar la creacion de la factura a partir del Pedido  ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    dtFacturaLinea.Clear()
                    dtFacturaLineaLote.Clear()
                    tableData.Clear()
                    ClearControlslinea()
                    ClearControlsTotales()
                    gbUsaPedido = False
                Else
                    Exit Sub
                End If
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
                Me.SearchLookUpEditMoneda.EditValue = CInt(frm.gsIDMoneda)
                Me.SearchLookUpEditPlazo.EditValue = CInt(frm.gsPlazo)
                gIDPlazo = CInt(frm.gsPlazo)
                gdPorcInteres = CDec(frm.gsPorcInteres)
                txtLimite.EditValue = frm.gdLimite
                txtDisponible.EditValue = frm.gdDisponible
                CalculaFechaVencimiento()
            End If
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los clientes " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        CallPopUpClientes()
        If TieneDisponilidad(0) Then
            Exit Sub
        End If
        EnableBotonesModificaFactura(True)
    End Sub
    Private Function TieneDisponilidad(dTotalAFacturar As Decimal) As Boolean
        Dim lbOK As Boolean = True
        If txtIDCliente.Text <> "" Then
            If txtDisponible.EditValue <= 0 Then
                lbOK = False
                'MessageBox.Show("El Cliente no tiene disponibilidad... por favor llame y solicite autorización ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If txtIDCliente.Text <> "" Then
            If txtDisponible.EditValue > 0 And dTotalAFacturar > CDec(txtDisponible.EditValue) Then
                lbOK = False
                'MessageBox.Show("El Cliente no tiene sufiente Disponibilidad... por favor llame ysolicite autorización " & "Exede : "(dTotalAFacturar - CDec(txtDisponible.EditValue)).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return lbOK
    End Function
    Private Sub CalculaFechaVencimiento()
        Me.DateEditVencimiento.EditValue = DateAdd(DateInterval.Day, CDbl(Me.SearchLookUpEditPlazo.EditValue), Me.DateEditFecha.EditValue)
        Me.DateEditVencimiento.Refresh()
    End Sub
    Private Sub txtCantidad_GotFocus(sender As Object, e As EventArgs) Handles txtCantidad.GotFocus
        If Not gbUsaPedido Then
            txtCantidad.SelectionStart = 0
            txtCantidad.SelectionLength = txtCantidad.Text.Length
            txtCantidad.SelectAll()
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtPrecio.Focus()

        End If
    End Sub

    Private Sub TrataLote()
        Dim iCantidad As Integer
        Try
            If gbUsaPedido Then
                MessageBox.Show("No se puede alterar la cantidad en un pedido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            ' Hice el cambio aqui porque tenia que restar la Bonificacion 15/09/2020
            If gbUsaPedido Then
                iCantidad = (txtCantidad.EditValue - txtCantBonif.EditValue)
            Else
                iCantidad = txtCantidad.EditValue
            End If
            PopUpAsignaLote(Me.SearchLookUpEditSucursal.EditValue.ToString(), txtCodigo.EditValue.ToString(), iCantidad.ToString(), txtDescr.EditValue.ToString(), True, txtCantBonif.EditValue.ToString(), CBool(chkBonifica.EditValue), CBool(chkBonificaProd.EditValue))
            If gbLoteAsignado = False Then
                Exit Sub ' agregado el 21/09/2020
            End If
            Me.txtDescEspLinea.EditValue = CDec(txtPorcDescEsp.EditValue) / 100 * CDec(txtCantidad.EditValue) * CDec(txtPrecio.EditValue)
            txtImpuesto.EditValue = CalculaImpuesto()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en el proceso de Lotes " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos del Pedido, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If

            Dim frm As New frmPopupProducto()
            frm.ShowDialog()
            Me.txtCodigo.EditValue = frm.gsIDProducto
            Me.txtDescr.EditValue = frm.gsDescr
            Me.chkBonifica.Checked = frm.gbBonifica
            Me.chkBonifica.Enabled = False
            Me.chkBonificaProd.Enabled = False
            If chkBonifica.Checked = False Then
                txtCantBonif.Enabled = False
                txtCantPrecio.Enabled = False
            Else
                txtCantBonif.Enabled = True
                txtCantPrecio.Enabled = True

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
                txtPorcImpt.EditValue = t.Rows(0).Item(0)
            Else
                txtPorcImpt.EditValue = 0
            End If

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
            txtCantPrecio.EditValue = 0
            txtCantidad.Focus()
            frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el Producto ..." & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'CallPopUpProducto()
    End Sub

    Private Sub CallPopUpProducto()
        Try

            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos de la Factura, existe un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If gbUsaPedido Then
                MessageBox.Show("No se puede alterar los productos en un en un pedido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim frm As New frmPopupProducto()
            frm.ShowDialog()
            Me.txtCodigo.EditValue = frm.gsIDProducto
            Me.txtDescr.EditValue = frm.gsDescr
            Me.txtCostoPromLocal.EditValue = frm.gdCostoPromLocal
            Me.txtCostoPromDolar.EditValue = frm.gdCostoPromDolar

            gsIDProducto = txtCodigo.EditValue
            GetImpuestoDescuentoEspecialPrecio()
            txtCantidad.EditValue = 0 ' antes ""
            gdBonoProductoActual = 0
            Me.txtCantidad.Focus()
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al consultar el Precio " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetImpuestoDescuentoEspecialPrecio()
        Dim dPrecio As Decimal
        Dim t As DataTable
        GetPorcImuestoYDescuentoEspecial()
        Dim sParametros As String
        sParametros = txtIDCliente.Text & "," & Me.SearchLookUpEditNivel.EditValue.ToString() & "," & txtCodigo.Text & "," & Me.SearchLookUpEditMoneda.EditValue.ToString()
        t = cManager.ExecFunction("fafGetPrecio", sParametros)
        dPrecio = t.Rows(0).Item(0)
        txtPrecio.EditValue = Redondear(dPrecio, gParametros.DigitosDecimales)
    End Sub

    Private Sub GetPorcImuestoYDescuentoEspecial()
        Dim PorcImpuesto As Decimal
        Dim t As DataTable
        t = cManager.ExecFunction("getPorcImpuestoFromProducto", txtCodigo.EditValue.ToString)
        PorcImpuesto = t.Rows(0).Item(0)
        txtPorcImpt.EditValue = PorcImpuesto '.ToString("n2") quitado el 19/09/2020

        ' para obtener el PorcDescuentoEspecial
        Dim sparam As String = txtCodigo.EditValue.ToString() & ",'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "'," & txtIDCliente.EditValue.ToString()
        t = cManager.ExecFunction("fafGetPorcDescuento", sparam)
        Me.txtPorcDescEsp.EditValue = CDec(t.Rows(0).Item(0))
    End Sub

    Private Sub ValidaLetraNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtCantidad.KeyPress, txtPrecio.KeyPress, txtExistencia.KeyPress, txtCantBonif.KeyPress, txtCantPrecio.KeyPress
        Dim strListaControles As String
        strListaControles = "txtCantidad , txtPrecio , txtExistencia, txtCantBonif, txtCantPrecio"
        If strListaControles.Contains(sender.name) = True And Asc(e.KeyChar) <> Keys.Return Then
            e.KeyChar = Chr(Solo_Numeros(Asc(e.KeyChar)))
        End If
        If sender.name = "txtCantidad" And Asc(e.KeyChar) = Keys.Return Then
            txtPrecio.Focus()
        End If
        If sender.name = "txtCantBonif" And Asc(e.KeyChar) = Keys.Return Then
            txtCantPrecio.Focus()
        End If
        If sender.name = "txtCantPrecio" And Asc(e.KeyChar) = Keys.Return Then
            Me.btnAdd.Focus()

        End If

        If sender.name = "txtPrecio" And Asc(e.KeyChar) = Keys.Return Then
            Me.btnAdd.Focus()
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
        If gbRequiereBonif And txtCantBonif.EditValue = 0 And txtCantPrecio.EditValue = 0 Then
            Me.txtPorcDescEsp.EditValue = 0
        Else
            txtPorcDescEsp.EditValue = gdPorcDescPromFecha + gdPorcDescPromEscala
        End If
        CalculaSubTotales()
    End Sub

    Private Sub TriggerCantBonifPrecio()
        If Me.txtCantidad.Text = "" Or txtPrecio.Text = "" Or Not (Me.txtCantPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If

        If txtCantPrecio.Text = "" Then
            txtCantPrecio.EditValue = 0
        End If

        If Me.txtCantPrecio.EditValue > 0 And txtCantidad.EditValue = 0 Then
            MessageBox.Show("Ud Digitó la cantidad a Bonificar en Precio pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearControlslinea()
            txtCantPrecio.EditValue = 0
            txtCantidad.Focus()
            Return
        End If

        If Me.txtPrecio.EditValue = 0 Or txtCantPrecio.EditValue = 0 Then
            txtPrecio.EditValue = txtPrecioLista.EditValue
        End If

        If CDec(txtCantPrecio.EditValue) <= gdBonoProductoActual Then
            txtCantBonif.EditValue = gdBonoProductoActual - txtCantPrecio.EditValue
        End If

        If (CDec(txtCantPrecio.EditValue) > gdBonoProductoActual) Or txtCantPrecio.Text = "" Then
            txtCantPrecio.EditValue = 0
            txtPrecio.EditValue = txtPrecioLista.EditValue
            txtCantBonif.EditValue = gdBonoProductoActual
        End If

        ' cambio el 1 de Nov 2020

        If gbRequiereBonif And txtCantBonif.EditValue = 0 And txtCantPrecio.EditValue = 0 Then
            Me.txtPorcDescEsp.EditValue = 0
        Else
            txtPorcDescEsp.EditValue = gdPorcDescPromFecha + gdPorcDescPromEscala
        End If
        CalculaSubTotales()

    End Sub


    Private Sub UpdateFieldsToGrid()
        If dtFacturaLinea.Rows.Count > 0 Then
            Dim customerRow() As Data.DataRow
            customerRow = dtFacturaLinea.Select("IDProducto =" & gsIDProducto)
            If customerRow.Count > 0 Then
                customerRow(0)("LoteAsignado") = True
                currentRow("Bonifica") = gbBonifica
                currentRow("BonifConProd") = gbBonifConProd
                Me.txtCantPrecio.EditValue = gdTotalBonificadoPrecio

                If gbUsaPedido = True Then
                    Me.txtPrecio.EditValue = CDec(customerRow(0)("Precio"))
                Else

                    Me.txtPrecio.EditValue = Redondear((CDec(txtPrecio.EditValue) * CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(txtCantPrecio.EditValue)), gParametros.DigitosDecimales)
                End If
                If Not gbUsaPedido Then
                    currentRow("Precio") = Me.txtPrecio.EditValue
                End If


                currentRow("SubTotal") = Me.txtSubTotLin.EditValue ' nuevo el 19/09/2020
                currentRow("Descuento") = CDec(txtCantBonif.EditValue) * CDec(txtPrecio.EditValue)
                currentRow("SubTotalFinal") = Redondear(CDec(currentRow("SubTotal")) - CDec(currentRow("Descuento")) - CDec(currentRow("DescuentoEspecial")), gParametros.DigitosDecimales)
                currentRow("Total") = Redondear(CDec(currentRow("SubTotalFinal")) + CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)


                Me.chkBonifica.Checked = gbBonifica
                Me.chkBonificaProd.Checked = gbBonifConProd

            End If
        End If
    End Sub


    Private Function ControlsHeaderOk() As Boolean
        Dim lbok As Boolean
        lbok = True
        If Not (Me.SearchLookUpEditSucursal.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditTipoFact.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.SearchLookUpEditPlazo.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtIDCliente.Text IsNot Nothing Or txtNombre.Text IsNot Nothing) Then
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

        If Not (Me.DateEditFecha.EditValue IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        If Not (Me.txtFactura.Text IsNot Nothing) Then
            lbok = False
            Return lbok
        End If

        Return lbok
    End Function
    Private Function ControlsDetalleOk() As Boolean
        Dim lbok As Boolean = True
        If txtCodigo.Text Is Nothing Or String.IsNullOrEmpty(txtCodigo.Text) Then
            lbok = False
            Return lbok
        End If
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

    Sub AddDataToGrid()
        Try
            Dim r As DataRow = dtFacturaLinea.NewRow
            Dim dCantidadBonificada As Decimal = 0
            dCantidadBonificada = 0
            If txtCantPrecio.Text = "" Then
                txtCantPrecio.EditValue = 0
            End If
            Me.txtPrecio.EditValue = (CDec(txtPrecio.EditValue) * CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(txtCantPrecio.EditValue))
            If Me.chkBonifica.EditValue And chkBonificaProd.EditValue = True Then
                dCantidadBonificada = CDbl(txtCantBonif.EditValue)
            End If

            r("IDProducto") = Me.txtCodigo.EditValue
            r("Descr") = Me.txtDescr.EditValue
            r("IDBodega") = Me.SearchLookUpEditSucursal.EditValue
            r("Cantidad") = Me.txtCantidad.EditValue
            r("Precio") = Redondear(CDec(Me.txtPrecio.EditValue), gParametros.DigitosDecimales)
            r("CantFacturada") = CDec(r("Cantidad"))
            r("CantBonificada") = gdTotalBonificado
            r("CantPrecio") = gdTotalBonificadoPrecio ' nuevo el 21/09/2020
            r("Impuesto") = Redondear(CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            r("SubTotal") = Redondear(CDec(Me.txtPrecio.EditValue) * (CInt(r("CantFacturada")) + CInt(r("CantBonificada"))), gParametros.DigitosDecimales)
            r("PorcImp") = CDec(txtPorcImpt.EditValue)

            r("Bonifica") = CBool(chkBonifica.Checked)
            r("BonifConProd") = CBool(chkBonificaProd.Checked)
            r("LoteASignado") = gbLoteAsignado
            r("DescuentoEspecial") = Redondear(CDec(Me.txtDescEspLinea.EditValue), gParametros.DigitosDecimales)
            r("Descuento") = Redondear(CDec(txtCantBonif.EditValue) * CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)

            r("CostoLocal") = Redondear(CDec(Me.txtCostoPromLocal.EditValue), gParametros.DigitosDecimales)
            r("CostoDolar") = Redondear(CDec(Me.txtCostoPromDolar.EditValue), gParametros.DigitosDecimales)
            r("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.EditValue)
            r("SubTotalFinal") = Redondear(CDec(r("SubTotal")) - CDec(r("Descuento")) - CDec(r("DescuentoEspecial")), gParametros.DigitosDecimales)
            r("Total") = Redondear(CDec(r("SubTotalFinal")) + CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            r("PrecioLista") = txtPrecioLista.EditValue
            r("Ahorro") = txtAhorro.EditValue
            dtFacturaLinea.Rows.Add(r)
            Me.GridControl1.DataSource = Nothing
            Me.GridControl1.DataSource = dtFacturaLinea
            gbLoteAsignado = False
            gdTotalBonificado = 0
            iNumeroLineasFactura = iNumeroLineasFactura + 1
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub
    Private Sub AgregaProducto()
        Try
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos de la Factura, existe un campo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'If Not TieneDisponilidad(0) Then

            '    Exit Sub
            'End If


            If Not ControlsDetalleOk() Then
                MessageBox.Show("Por favor revise los datos del producto, existe un campo incorrecto... revise Cantidad, Precio ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'If Not TieneDisponilidad(CDec(txtTotLinea.EditValue)) Then
            '    Exit Sub
            'End If
            If iNumeroLineasFactura >= gParametros.NumeroLineasFact Then
                MessageBox.Show("El número máximo de lineas de una factura es " & gParametros.NumeroLineasFact.ToString() & " ... No puede agregar más lineas a la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If

            TrataLote() ' se asignan los lotes
            If gbLoteAsignado = False Then
                Exit Sub ' agregado el 21/09/2020
            End If
            If dtFacturaLinea.Rows.Count > 0 Then
                Dim foundRow() As DataRow
                foundRow = dtFacturaLinea.Select("IDProducto =" & Me.txtCodigo.EditValue.ToString())

                If foundRow IsNot Nothing And foundRow.Count > 0 Then
                    MessageBox.Show("Ese Producto ya Existe, por favor revise", "Advertencia", MessageBoxButtons.OK)
                    Return

                End If
            End If
            ' hice un cambio el 7 de sept 2020 para incluir la cantidad bonificada a la facturada
            Dim dCantidadBonificada As Decimal
            If Me.chkBonificaProd.EditValue = False And Me.chkBonifica.EditValue Then
                dCantidadBonificada = 0
            End If
            If Me.chkBonificaProd.EditValue = True And Me.chkBonifica.EditValue Then
                dCantidadBonificada = CDec(txtCantBonif.EditValue)
            End If

            Me.txtDescLinea.EditValue = Redondear(dCantidadBonificada * CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)

            Me.txtSubTotLin.EditValue = Redondear(CDec(Me.txtPrecio.EditValue) * (CDec(txtCantidad.EditValue) + dCantidadBonificada), gParametros.DigitosDecimales)
            txtSubTotalFinalLin.EditValue = Redondear(Me.txtSubTotLin.EditValue - Me.txtDescLinea.EditValue - Me.txtDescEspLinea.EditValue, gParametros.DigitosDecimales)
            txtImpuesto.EditValue = Redondear(CalculaImpuesto(), gParametros.DigitosDecimales)
            AddDataToGrid()

            If dtFacturaLinea.Rows.Count > 0 Then
                GridControl1.DataSource = dtFacturaLinea
                GridControl1.Refresh()
            End If
            TotalizaGrid()
            'Me.GridViewProducto.FocusedRowHandle
            GridViewProducto.MoveFirst()
            RefreshDataFromGridToControls()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al agregar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AgregaProducto()
    End Sub
    Private Function CalculaImpuesto() As Double
        Dim dImpuesto As Double = 0
        dImpuesto = Redondear(CDec(Me.txtSubTotalFinalLin.EditValue), gParametros.DigitosDecimales) * CDbl(If(String.IsNullOrEmpty(Me.txtPorcImpt.EditValue), 0, Me.txtPorcImpt.EditValue)) / 100
        Return dImpuesto
    End Function

    Private Sub txtPrecio_GotFocus(sender As Object, e As EventArgs) Handles txtPrecio.GotFocus

    End Sub
    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtImpuesto.EditValue = CalculaImpuesto()
        End If
    End Sub

    'Private Sub txtPrecio_EditValueChanged(sender As Object, e As EventArgs) Handles txtPrecio.EditValueChanged
    '    Dim strCriterio As String
    '    CalcDescuentoEspLinea()
    '    If Not IsNothing(txtCodigo.EditValue) Then
    '        strCriterio = "IDProducto = " & txtCodigo.EditValue.ToString()
    '        UpdateDataTableRowFacLin(strCriterio)
    '        TotalizaGrid()
    '    End If
    'End Sub

    'Private Sub txtPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtPrecio.LostFocus
    '    TriggerCantidad()
    '    'If txtCodigo.Text Is Nothing Or String.IsNullOrEmpty(txtCodigo.Text) Then
    '    '    Exit Sub
    '    'End If
    '    'txtImpuesto.EditValue = CalculaImpuesto()
    'End Sub

    Private Sub CalculaDatosLineaFactura()
        If txtCantidad.Text <> "0" Then
            txtImpuesto.EditValue = CalculaImpuesto()
        End If
    End Sub

    Private Sub SearchLookUpEditSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditSucursal.EditValueChanged
        gsIDBodega = SearchLookUpEditSucursal.EditValue.ToString()
    End Sub

    Private Sub NuevoProducto()
        Try
            If iNumeroLineasFactura >= gParametros.NumeroLineasFact Then
                MessageBox.Show("El número máximo de lineas de una factura es " & gParametros.NumeroLineasFact.ToString() & " ... No puede agregar más lineas a la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If
            ClearControlslinea()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        NuevoProducto()
    End Sub
    Private Sub ClearControlslinea()
        Me.txtCodigo.EditValue = 0
        Me.txtDescr.Text = ""
        Me.chkBonifica.Checked = False
        Me.chkBonificaProd.Checked = False
        Me.txtCantidad.EditValue = 0
        Me.txtPorcImpt.EditValue = 0
        Me.txtIGV.EditValue = 0
        Me.txtImpuesto.EditValue = 0
        Me.txtPorcDescEsp.EditValue = 0
        Me.txtPrecio.EditValue = 0
        Me.txtExistencia.EditValue = 0
        Me.txtSubTotLin.EditValue = 0
        Me.txtDescEspLinea.EditValue = 0
        Me.txtPrecioLista.EditValue = 0
        txtAhorro.EditValue = 0
        Me.txtDescLinea.EditValue = 0
        Me.txtTotLinea.EditValue = 0
        Me.txtSubTotalFinalLin.EditValue = 0
        Me.txtPorcDescEsp.EditValue = 0
        Me.txtCantBonif.EditValue = 0
        Me.txtCantPrecio.EditValue = 0
        Me.txtCostoPromLocal.EditValue = 0
        Me.txtCostoPromDolar.EditValue = 0
        Me.btnProducto.Focus()
    End Sub

    Private Sub ClearControlsTotales()
        Me.txtSubTotal.EditValue = 0
        Me.txtDcto.EditValue = 0
        txtDctoEsp.EditValue = 0
        txtSubTotalFinal.EditValue = 0
        txtIGV.EditValue = 0
        txtTotal.EditValue = 0
    End Sub
    Private Sub DateEditFecha_KeyUp(sender As Object, e As KeyEventArgs) Handles DateEditFecha.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            CalculaFechaVencimiento()
        End If
    End Sub

    Private Sub SearchLookUpEditTipoFact_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditTipoFact.EditValueChanged
        If Me.SearchLookUpEditTipoFact.EditValue IsNot Nothing And SearchLookUpEditTipoFact.EditValue = 1 Then
            ' si la factura es de Contado
            Me.SearchLookUpEditPlazo.EditValue = gParametros.IDPlazoCont
        End If
        If Me.SearchLookUpEditTipoFact.EditValue IsNot Nothing And Me.SearchLookUpEditTipoFact.EditValue = 2 Then
            Me.SearchLookUpEditPlazo.EditValue = gIDPlazo
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If Not CargaParametros() Then
            MessageBox.Show("No se han definido los Parámetros del Módulo de Facturación ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Return
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SearchLookUpEditPlazo_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditPlazo.EditValueChanged
        If Me.SearchLookUpEditTipoFact.EditValue = 1 Then
            Me.SearchLookUpEditPlazo.EditValue = gParametros.IDPlazoCont
        End If
        If Me.SearchLookUpEditTipoFact.EditValue IsNot Nothing And Me.SearchLookUpEditTipoFact.EditValue = 2 Then
            Me.SearchLookUpEditPlazo.EditValue = gIDPlazo
        End If
        CalculaFechaVencimiento()
    End Sub

    Private Sub EliminaItem()
        Try
            If MessageBox.Show("Está seguro de eliminar el registro " & Me.txtDescr.EditValue, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                Exit Sub
            End If
            Dim foundRows As DataRow() = dtFacturaLineaLote.Select("IDProducto =" & Me.txtCodigo.Text)
            If foundRows.Count > 0 Then

                For Each foundrow In foundRows
                    foundrow.Delete()
                Next foundrow
            End If

            Dim foundRowsLin As DataRow() = dtFacturaLinea.Select("IDProducto =" & Me.txtCodigo.Text)
            If foundRowsLin.Count > 0 Then

                For Each foundrow In foundRowsLin
                    foundrow.Delete()
                Next foundrow
            End If
            If iNumeroLineasFactura > 0 Then
                iNumeroLineasFactura = iNumeroLineasFactura - 1
            End If
            dtFacturaLineaLote.AcceptChanges()
            dtFacturaLinea.AcceptChanges()
            ClearControlslinea()
            RefreshDataFromGridToControls()
            TotalizaGrid()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al eliminar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtFacturaLineaLote.RejectChanges()
            dtFacturaLinea.RejectChanges()
        End Try


    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        EliminaItem()
    End Sub

    Private Function InventarioDisponible() As Boolean
        Dim lbok As Boolean = True
        Dim iExistencia As Int16
        Dim t As DataTable
        If dtFacturaLinea.Rows.Count > 0 Then
            For Each dr In dtFacturaLinea.Rows
                t = cManager.ExecSPgetData("invGetExistenciaBodega", gsSucursal & "," & CInt(dr("IDProducto")).ToString() & ", -1 ")
                If t.Rows.Count > 0 Then
                    iExistencia = t.Rows(0).Item("Existencia")
                Else
                    iExistencia = 0
                End If
                If CDec(dr("Cantidad")) + CDec(dr("CantBonificada")) > iExistencia Then
                    lbok = False
                    MessageBox.Show("El Producto " & dr("Descr").ToString() & " No tiene suficiente existencia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return lbok
                    Exit For
                End If
            Next
        End If
        Return lbok
    End Function

    Private Sub GrabarFactura()
        Dim sSql As String
        Dim sParameters As String
        Dim dPrecioLocal As Decimal, dPrecioDolar As Decimal, dImpuestoLocal As Decimal, dImpuestoDolar As Decimal, dSubTotalLocal As Decimal, dSubTotalDolar As Decimal
        Dim dSubTotalFinalLocal As Decimal, dSubTotalFinalDolar As Decimal, lIDAutorizacion As Integer = 0
        Try

            If Not IsMaskOK(gsMascara, Me.txtFactura.EditValue) Then
                Me.txtFactura.Focus()
                Return
            End If

            If Me.txtTipoCambio.EditValue = 0 Then
                MessageBox.Show("El tipo de Cambio es Cero, favor revise o llame al administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cManager.ExistsInTable("fafFactura", "Factura", "Factura='" & txtFactura.EditValue.ToString() & "' and IDBodega = " & gsIDBodega, "Factura") Then
                MessageBox.Show("Por favor revise los datos de la Factura, esa Factura ya Existe en la base de datos para esa bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Not ControlsHeaderOk() Then
                MessageBox.Show("Por favor revise los datos de la Factura, existe un campo incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.SearchLookUpEditSucursal.Focus()
                Return
            End If
            If dtFacturaLinea.Rows.Count <= 0 Then
                MessageBox.Show("No Existen productos grabados para la Factura, favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If dtFacturaLinea.Rows.Count > 0 Then
                If Not TieneDisponilidad(CDec(txtTotal.EditValue)) Then
                    Dim td As New DataTable
                    Dim lbSinLimite As Boolean = True
                    Dim lbConAutorizacion As Boolean = False
                    sParameters = txtIDCliente.EditValue.ToString() & ",'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "'"
                    td = cManager.ExecSPgetData("ccfgetAutorizacion", sParameters)
                    If td.Rows.Count > 0 Then

                        If CDec(td.Rows(0)("SaldoLimite")) > 0 Then
                            lbConAutorizacion = True
                            lIDAutorizacion = CInt(td.Rows(0)("IDAutorizacion"))
                        Else
                            lbConAutorizacion = False
                            lIDAutorizacion = 0
                        End If
                        If lbConAutorizacion And CDec(td.Rows(0)("SaldoLimite")) < CDec(txtTotal.EditValue) Then
                            MessageBox.Show("Ese Cliente tiene una autorización (" & CDec(td.Rows(0)("SaldoLimite")).ToString() & ") por debajo del Monto de la Factura (" & CDec(txtTotal.EditValue).ToString() & "), lo sentimos... no se puede facturar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                    End If
                    If lbSinLimite And lbConAutorizacion = False Then
                        MessageBox.Show("Ese Cliente No tiene Disponibilidad en su Crédito y tampoco tiene una Autorización,  lo sentimos... no se puede facturar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                Dim foundRow() As DataRow
                foundRow = dtFacturaLinea.Select("LoteAsignado=0")

                If foundRow IsNot Nothing And foundRow.Count > 0 Then
                    MessageBox.Show("Existe al menos un Producto al que Ud no ha asignado los lotes correspondientes, por favor revise", "Advertencia", MessageBoxButtons.OK)
                    Return

                End If

                If Not InventarioDisponible() Then
                    Return
                End If
            End If
            If dtFacturaLineaLote.Rows.Count <= 0 Then
                MessageBox.Show("No Existen Lotes productos grabados para la Factura, favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Not gsPedidoID IsNot Nothing Then
                gsPedidoID = "null"
            End If
            If Not MemoEditNota.EditValue IsNot Nothing Then
                MemoEditNota.EditValue = " "
            End If
            ' Preparando los datos de la cabecera 
            sParameters = "'I'," & Me.SearchLookUpEditSucursal.EditValue.ToString() & ",'" & Me.txtFactura.Text & "'," & Me.SearchLookUpEditTipoFact.EditValue.ToString() & ", " & _
                Me.txtIDCliente.Text & ",'" & txtNombre.EditValue.ToString() & "'," & Me.SearchLookUpEditVendedor.EditValue.ToString() & "," & Me.SearchLookUpEditTipoEntrega.EditValue.ToString() & ", '" & _
                CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "',0," & IIf(Me.CheckEditTeleVenta.EditValue = True, "1", "0") & "," & gsPedidoID & "," & _
                Me.SearchLookUpEditNivel.EditValue.ToString() & "," & Me.SearchLookUpEditMoneda.EditValue.ToString() & "," & Me.SearchLookUpEditPlazo.EditValue.ToString() & "," & _
                Me.txtTipoCambio.EditValue.ToString() & ",'" & gsConsecMask & "','" & MemoEditNota.EditValue.ToString() & "'"

            'creando la instruccion de insercion en la cabecera
            sSql = cManager.CreateStoreProcSql("fafUpdateFactura", sParameters)
            Dim clase As New CbatchSQLIitem(sSql, True, False, True, False, "fafUpdateFactura", "fafUpdateFactura")
            cManager.batchSQLLista.Add(clase)
            cManager.batchSQLitem.Clear()
            cManager.batchSQLitem.Add(sSql)

            ' REcorrer las lineas de la Factura a nivel de Producto 
            Dim lbEsMonedaLocal As Boolean = EsMonedaLocal(CInt(Me.SearchLookUpEditMoneda.EditValue))
            Dim dPorcImp As Decimal
            Dim dPorcDescuentoEsp As Decimal = 0, dCostoLocal As Decimal = 0, dCostoDolar As Decimal, dDescuentoLocal As Decimal, dDescuentoDolar As Decimal,
                dDescuentoEspLocal As Decimal, dDescuentoEspDolar As Decimal, dPrecioLista As Decimal, dAhorro As Decimal
            For Each dr In dtFacturaLinea.Rows

                If lbEsMonedaLocal Then
                    dPrecioLocal = Redondear(CDec(dr("Precio")), gParametros.DigitosDecimales)
                    dPrecioDolar = Redondear(CDec(dr("Precio")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dImpuestoLocal = Redondear(CDec(dr("Impuesto")), gParametros.DigitosDecimales)
                    dImpuestoDolar = Redondear(CDec(dr("Impuesto")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalLocal = Redondear(CDec(dr("SubTotal")), gParametros.DigitosDecimales)
                    dSubTotalDolar = Redondear(CDec(dr("SubTotal")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoLocal = Redondear(CDec(dr("Descuento")), gParametros.DigitosDecimales)
                    dDescuentoDolar = Redondear(CDec(dr("Descuento")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoEspLocal = Redondear(CDec(dr("DescuentoEspecial")), gParametros.DigitosDecimales)
                    dDescuentoEspDolar = Redondear(CDec(dr("DescuentoEspecial")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalFinalLocal = Redondear(CDec(dr("SubTotalFinal")), gParametros.DigitosDecimales)
                    dSubTotalFinalDolar = Redondear(CDec(dr("SubTotalFinal")) / CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                Else
                    dPrecioDolar = Redondear(CDec(dr("Precio")), gParametros.DigitosDecimales)
                    dPrecioLocal = Redondear(CDec(dr("Precio")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dImpuestoDolar = Redondear(CDec(dr("Impuesto")), gParametros.DigitosDecimales)
                    dImpuestoLocal = Redondear(CDec(dr("Impuesto")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalDolar = Redondear(CDec(dr("SubTotal")), gParametros.DigitosDecimales)
                    dSubTotalLocal = Redondear(CDec(dr("SubTotal")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoDolar = Redondear(CDec(dr("Descuento")), gParametros.DigitosDecimales)
                    dDescuentoLocal = Redondear(CDec(dr("Descuento")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dDescuentoEspDolar = Redondear(CDec(dr("DescuentoEspecial")), gParametros.DigitosDecimales)
                    dDescuentoEspLocal = Redondear(CDec(dr("DescuentoEspecial")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                    dSubTotalFinalDolar = Redondear(CDec(dr("SubTotalFinal")), gParametros.DigitosDecimales)
                    dSubTotalFinalLocal = Redondear(CDec(dr("SubTotalFinal")) * CDec(txtTipoCambio.EditValue), gParametros.DigitosDecimales)
                End If

                dPorcImp = CDec(dr("PorcImp"))
                dPorcDescuentoEsp = CDec(dr("PorcDescuentoEsp"))
                dPrecioLista = CDec(dr("PrecioLista"))
                dAhorro = CDec(dr("Ahorro"))
                sParameters = "'I'" & ",@@Identity" & "," & Me.SearchLookUpEditSucursal.EditValue.ToString() & "," & dr("IDProducto").ToString() & "," & _
                    IIf(CBool(dr("Bonifica")) = True, "1", "0") & ",0,0," & IIf(CBool(dr("BonifConProd")) = True, "1", "0") & "," & dr("CantBonificada").ToString() & "," & dr("CantFacturada").ToString() & "," & dr("CantPrecio").ToString() & "," & _
                dPrecioLocal.ToString() & "," & dPrecioDolar.ToString() & "," & dCostoLocal.ToString() & "," & dCostoDolar.ToString() & "," & _
                dDescuentoLocal.ToString() & "," & dDescuentoDolar.ToString() & "," & dDescuentoEspLocal.ToString() & "," & dDescuentoEspDolar.ToString() & "," & _
                dSubTotalLocal.ToString() & "," & dSubTotalDolar.ToString() & "," & dSubTotalFinalLocal.ToString() & "," & dSubTotalFinalDolar.ToString() & "," & dImpuestoLocal.ToString() & "," & dImpuestoDolar.ToString() & ", 1," & dPorcDescuentoEsp.ToString() & "," & dPorcImp.ToString() & "," & dPrecioLista.ToString() & "," & dAhorro.ToString()

                sSql = cManager.CreateStoreProcSql("fafUpdateFacturaProd", sParameters)
                clase = New CbatchSQLIitem(sSql, True, True, True, True, "fafUpdateFactura", "fafUpdateFacturaProd")

                cManager.batchSQLitem.Add(sSql)
                cManager.batchSQLLista.Add(clase)
                ' REcorrer las lineas de los productos  a nivel de Lotes asignados
                Dim foundRowLotes = dtFacturaLineaLote.Select("IDProducto=" & dr("IDProducto").ToString() & " and (AsignadoBO>0 or AsignadoFA>0)")
                For Each drl In foundRowLotes
                    sParameters = "'I'" & ",@@Identity" & "," & drl("IDLote").ToString() & "," & drl("CantBonificada").ToString() & "," & drl("CantFacturada").ToString()
                    sSql = cManager.CreateStoreProcSql("fafUpdateFacturaProdLote", sParameters)
                    clase = New CbatchSQLIitem(sSql, False, True, False, True, "fafUpdateFacturaProd", "fafUpdateFacturaProdLote")

                    cManager.batchSQLitem.Add(sSql)
                    cManager.batchSQLLista.Add(clase)
                Next drl
            Next dr


            ' Actualizo el valor del consecutivo de la factura
            sSql = cManager.CreateUpdateSql("globalConsecMask", "CONSECUTIVO ='" & Me.txtFactura.EditValue.ToString() & "'", "Codigo='" & gsConsecMask & "'")
            clase = New CbatchSQLIitem(sSql, False, False, False, False, "", "")
            cManager.batchSQLitem.Add(sSql)
            cManager.batchSQLLista.Add(clase)
            ' si la factura es de Credito 
            If UCase(Me.SearchLookUpEditTipoFact.GetSelectedDataRow(1).ToString) = "CREDITO" Then
                'creando la instruccion de insercion en la cartera Documento CC
                Dim dDiasVencimiento As Integer
                Dim iIDDocumento As Integer = 0
                dDiasVencimiento = DateDiff(DateInterval.Day, Me.DateEditFecha.EditValue, Me.DateEditVencimiento.EditValue)

                sParameters = "'I'," & " -1 , " & Me.txtIDCliente.EditValue.ToString & "," & Me.SearchLookUpEditSucursal.EditValue.ToString() & ","
                sParameters = sParameters & "'D','FAC', 1, '" & Me.txtFactura.Text & "','" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "'," & dDiasVencimiento.ToString() & ","
                sParameters = sParameters & txtTotal.EditValue.ToString() & "," & gdPorcInteres & ", " & "'FAC : " & txtFactura.Text & " Cliente " & txtIDCliente.Text & " " & txtNombre.Text & " Generada desde Facturación',"
                sParameters = sParameters & "'FAC : " & txtFactura.Text & " Cliente " & txtIDCliente.Text & " " & txtNombre.Text & " Generada desde Facturación'"
                sParameters = sParameters & ",'" & gsUsuario & "'," & txtTipoCambio.EditValue.ToString() & "," & Me.SearchLookUpEditVendedor.EditValue.ToString() & ", 0,1"
                sParameters = sParameters & ",'" & txtFactura.EditValue.ToString() & "'," & Me.SearchLookUpEditMoneda.EditValue.ToString()
                sSql = cManager.CreateStoreProcSql("ccfUpdateccfDebitos", sParameters)
                clase = New CbatchSQLIitem(sSql, False, False, False, False, "ccfUpdateccfDebitos", "ccfUpdateccfDebitos")
                cManager.batchSQLLista.Add(clase)
                cManager.batchSQLitem.Clear()
                cManager.batchSQLitem.Add(sSql)


            End If
            If cManager.ExecCmdWithTransaction() Then
                Me.btnAdd.Enabled = False
                Me.btnSave.Enabled = False
                cManager.Update("fafPedido", "Estado = 'F'", " IDPedido = " & gsPedidoID & " and IDBodega = " & gsIDBodega)
                ' Actualizar Bitacora de Precios y Precios Cliente
                sParameters = cManager.IDAutoFirstParent.ToString() & ",'" & gsUsuario & "'"
                cManager.ExecSP("fafUpdateBitacoraPrecio", sParameters)

                ' Actualizo el Inveentario
                cManager.batchSQLitem.Clear()
                cManager.batchSQLLista.Clear()
                sParameters = "'FAC'," & cManager.IDAutoFirstParent.ToString() & ",'" & gsUsuario & "'"
                sSql = cManager.CreateStoreProcSql("fafAplicaInventario ", sParameters)
                clase = New CbatchSQLIitem(sSql, False, False, False, False, "", "")

                cManager.batchSQLitem.Add(sSql)
                cManager.batchSQLLista.Add(clase)
                If Not cManager.ExecCmdWithTransaction Then

                    MessageBox.Show("Hubo un error al grabar la factura con ID " & cManager.IDAutoFirstParent.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("La Factura ha sido Guardada Exitosamente la factura con ID " & cManager.IDAutoFirstParent.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                ' Actualiza las Autorizaciones 
                If lIDAutorizacion > 0 Then
                    sParameters = "'F'," & lIDAutorizacion.ToString() & "," & txtIDCliente.EditValue.ToString() & ",'" & CDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd") & "','" & gsUsuario & _
                        "',0,0,1,0," & cManager.IDAutoFirstParent.ToString() & ",''," & txtTotal.EditValue.ToString()
                    cManager.ExecSP("ccfUpdateAutorizacion", sParameters)
                End If

                Dim td As New DataTable
                sParameters = "'" & txtTotal.EditValue.ToString() & "'"
                td = cManager.ExecFunction("globalNumberToLetter", sParameters)
                If td.Rows.Count <= 0 Then
                    MessageBox.Show("No se pudo convertir a Letras el monto de la Factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                PrintReport(cManager.IDAutoFirstParent, td.Rows(0)(0).ToString())
                Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al Guardar la Factura " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        GrabarFactura()
    End Sub



    Private Sub txtFactura_LostFocus(sender As Object, e As EventArgs) Handles txtFactura.LostFocus
        If Not IsMaskOK(gsMascara, Me.txtFactura.EditValue) Then
            Me.SearchLookUpEditVendedor.Focus()
        End If
    End Sub

    Private Sub CalcDescuentoEspecial()
        Me.txtDescEspLinea.EditValue = Redondear(CDec(txtPorcDescEsp.EditValue) / 100 * CDec(txtCantidad.EditValue) * CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)
    End Sub

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
        If CDec(Me.txtCantPrecio.EditValue) > 0 Then
            Me.txtPrecio.EditValue = Redondear((CDec(txtPrecioLista.EditValue) * CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(Me.txtCantPrecio.EditValue)), gParametros.DigitosDecimales)
        End If

        Me.txtSubTotLin.EditValue = Redondear(CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)) * (CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) + CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text))), gParametros.DigitosDecimales)
        Me.txtDescLinea.EditValue = Redondear(CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        Me.txtDescEspLinea.EditValue = Redondear(CDec(IIf(Me.txtPorcDescEsp.Text = "", 0, Me.txtPorcDescEsp.Text)) / 100 * CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        Me.txtDescEspLinea.Text = String.Format("{0:0.00}", txtDescEspLinea.EditValue)

        Me.txtSubTotalFinalLin.EditValue = Redondear(Me.txtSubTotLin.EditValue - Me.txtDescLinea.EditValue - Me.txtDescEspLinea.EditValue, gParametros.DigitosDecimales)

        txtAhorro.EditValue = ((Me.txtPrecioLista.EditValue * (txtCantidad.EditValue + txtCantBonif.EditValue)) - Me.txtSubTotalFinalLin.EditValue)
        If txtAhorro.EditValue > 0 Then
            txtAhorro.Visible = True
        Else
            txtAhorro.Visible = False
        End If
        txtImpuesto.EditValue = Redondear(CalculaImpuesto(), gParametros.DigitosDecimales)
        Me.txtTotLinea.EditValue = Redondear(Me.txtSubTotalFinalLin.EditValue + txtImpuesto.EditValue, gParametros.DigitosDecimales)
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
                If gbRequiereBonif And txtCantBonif.EditValue = 0 And Me.txtCantPrecio.EditValue = 0 Then
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

    'Private Sub txtCantidad_EditValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.EditValueChanged
    '    CalcDescuentoEspLinea()

    'End Sub


    'Private Sub CalcDescuentoEspLinea()
    '    ' hice un cambio el 7 de sept 2020 para incluir la cantidad bonificada a la facturada
    '    Dim dCantidadBonificada As Decimal
    '    If Me.chkBonificaProd.EditValue = False And Me.chkBonifica.EditValue Then
    '        dCantidadBonificada = 0
    '    End If
    '    If Me.chkBonificaProd.EditValue = True And Me.chkBonifica.EditValue Then
    '        dCantidadBonificada = CDec(txtCantBonif.EditValue)
    '    End If

    '    Me.txtDescLinea.EditValue = dCantidadBonificada * Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)

    '    Me.txtDescEspLinea.EditValue = CDec(txtPorcDescEsp.EditValue) / 100 * txtCantidad.EditValue * Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)

    '    Me.txtSubTotLin.EditValue = Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales) * (CDec(txtCantidad.EditValue) + CDec(txtCantBonif.EditValue))

    '    Me.txtSubTotalFinalLin.EditValue = Redondear(CDec(Me.txtSubTotLin.EditValue) - CDec(Me.txtDescLinea.EditValue) - CDec(Me.txtDescEspLinea.EditValue), gParametros.DigitosDecimales)
    '    txtImpuesto.EditValue = CalculaImpuesto()
    '    Me.txtTotLinea.EditValue = Redondear(Me.txtSubTotalFinalLin.EditValue + txtImpuesto.EditValue, gParametros.DigitosDecimales)
    'End Sub

    Private Sub txtSubTotalFinalLin_EditValueChanged(sender As Object, e As EventArgs)
        txtImpuesto.EditValue = CalculaImpuesto()
        txtImpuesto.Refresh()
    End Sub

    Private Sub DateEditFecha_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFecha.EditValueChanged
        CalculaFechaVencimiento()
        Me.txtTipoCambio.EditValue = getTipoCambio(Me.DateEditFecha.EditValue, gParametros.TipoCambioFact)
    End Sub

    Private Sub PrintReport(pIDFactura As Int64, psMontoFactura As String)

        'Dim sqlDataSource As SqlDataSource
        'sqlDataSource.ConnectionParameters = New CustomStringConnectionParameters(connectionStringDynamic)
        Dim tableDataLote As DataTable
        tableDataLote = cManager.ExecSPgetData("fafPrintFacturaLote", pIDFactura.ToString())
        tableDataLote.TableName = "fafPrintFacturaLote"
        tableData = cManager.ExecSPgetData("fafgetFacturaHeader", pIDFactura.ToString())
        tableData.TableName = "fafgetFacturaHeader"

        If tableData.Rows.Count > 0 Then

            Dim report As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile("./Reportes/rptFacturaFinal.repx", True)

            Dim ds As New DataSet
            ds.Tables.Add(tableDataLote)
            ds.Tables.Add(tableData)

            report.DataSource = vbNull
            report.DataSource = ds
            report.DataMember = "fafPrintFacturaLote"
            report.Parameters(0).Value = pIDFactura
            report.Parameters(1).Value = psMontoFactura
            'report.Parameters(0).Value = psMontoFactura

            'Dim subReporte As XRSubreport
            'subReporte = report.AllControls(Of XRSubreport).First()
            'Dim subReporteSource As XtraReport
            'subReporteSource = subReporte.Report
            'subReporteSource.DataSource = vbNull

            'subReporteSource.DataSource = tableData
            'subReporteSource.DataMember = "fafPrintFactura"
            'subReporteSource.Parameters(0).Value = psMontoFactura




            If gParametros.FacturaPersonalizada Then
                report.PaperKind = System.Drawing.Printing.PaperKind.Custom
                report.ReportUnit = ReportUnit.TenthsOfAMillimeter
                report.PageHeight = gParametros.paginaFacturaAltura * 100
                report.PageWidth = gParametros.paginaFacturaAncho * 100
            Else
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter
            End If
            Dim tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)

            tool.ShowPreview()
        End If
    End Sub


    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        Dim strCriteria As String

        If Asc(e.KeyChar) = Keys.Return Then
            If txtCodigo.EditValue.ToString() <> "" Then
                strCriteria = "IDProducto=" & txtCodigo.Text
                tableData = cManager.GetDataTable("invProducto", "IDProducto, Descr", strCriteria, "IDProducto")

                If tableData.Rows.Count > 0 Then
                    txtDescr.EditValue = tableData.Rows(0)(1)
                    txtCantidad.Focus()
                End If
            End If
        End If
    End Sub



    Private Sub txtIDCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDCliente.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Return Then

                If gsIDBodega = "" Then
                    MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If gsPedidoID <> "" And gsIDBodega <> "" And gbUsaPedido Then
                    If MessageBox.Show("Previamente Ud cargo un pedido. Está seguro de ignorar la creacion de la factura a partir del Pedido  ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        dtFacturaLinea.Clear()
                        dtFacturaLineaLote.Clear()
                        tableData.Clear()
                        ClearControlslinea()
                        ClearControlsTotales()
                        gbUsaPedido = False
                    Else
                        Exit Sub
                    End If
                End If


                If txtIDCliente.EditValue.ToString() <> "" Then
                    tableData = cManager.ExecSPgetData("fafgetClientes", txtIDCliente.EditValue.ToString() & "," & gsSucursal)

                    If tableData.Rows.Count > 0 Then
                        Me.txtIDCliente.EditValue = txtIDCliente.EditValue.ToString()
                        Me.txtNombre.EditValue = tableData.Rows(0)("Nombre")
                        Me.txtFarmacia.EditValue = tableData.Rows(0)("Farmacia")
                        Me.SearchLookUpEditVendedor.EditValue = CInt(tableData.Rows(0)("IDVendedor"))
                        Me.SearchLookUpEditNivel.EditValue = CInt(tableData.Rows(0)("IDNivel"))
                        Me.SearchLookUpEditMoneda.EditValue = CInt(tableData.Rows(0)("IDMoneda"))
                        Me.SearchLookUpEditPlazo.EditValue = CInt(tableData.Rows(0)("Plazo"))
                        gIDPlazo = CInt(tableData.Rows(0)("Plazo"))
                        gdPorcInteres = CDec(tableData.Rows(0)("Plazo"))
                        CalculaFechaVencimiento()
                    Else
                        MessageBox.Show("No existe ningun Cliente con el codigo digitado  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al carga el cliente " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub chkBonifica_CheckedChanged(sender As Object, e As EventArgs) Handles chkBonifica.CheckedChanged
        If chkBonifica.EditValue Then
            Me.chkBonificaProd.EditValue = True
            Me.txtCantBonif.Enabled = True
            Me.txtCantBonif.ReadOnly = False
            Me.txtCantPrecio.Enabled = True
            txtCantPrecio.ReadOnly = False
            txtCantBonif.Focus()
        Else
            Me.chkBonificaProd.EditValue = False
            Me.txtCantBonif.Enabled = False
            Me.txtCantPrecio.Enabled = False
        End If
    End Sub

    Private Sub ActualizaDetallePedido()
        Try

            Dim dCantidadBonificada As Decimal = 0
            If Me.chkBonifica.EditValue And chkBonificaProd.EditValue = False Then

                Me.txtPrecio.EditValue = Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales) * (CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(txtCantBonif.EditValue))
            End If

            'If Me.chkBonifica.EditValue And chkBonificaProd.EditValue = True Then
            dCantidadBonificada = CDec(txtCantBonif.EditValue)
            'End If

            currentRow("IDProducto") = Me.txtCodigo.EditValue  ' Me.SearchLookUpEditProducto.EditValue
            currentRow("Descr") = Me.txtDescr.EditValue
            currentRow("IDBodega") = Me.SearchLookUpEditSucursal.EditValue
            currentRow("Cantidad") = Me.txtCantidad.EditValue + dCantidadBonificada
            currentRow("Precio") = Redondear(CDec(Me.txtPrecio.EditValue), gParametros.DigitosDecimales)
            currentRow("Impuesto") = Redondear(CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            currentRow("SubTotal") = Redondear(CDec(Me.txtPrecio.EditValue), gParametros.DigitosDecimales) * (CDbl(txtCantidad.EditValue)) ' + dCantidadBonificada) cambio 17/09/2020 comentarie
            currentRow("PorcImp") = CDec(txtPorcImpt.EditValue)

            currentRow("Bonifica") = CBool(chkBonifica.Checked)
            currentRow("BonifConProd") = CBool(chkBonificaProd.Checked)
            currentRow("LoteASignado") = gbLoteAsignado
            currentRow("DescuentoEspecial") = Redondear(CDec(Me.txtDescEspLinea.EditValue), gParametros.DigitosDecimales)
            currentRow("Descuento") = dCantidadBonificada * CDbl(txtPrecio.EditValue) 'gdTotalBonificado * CDbl(txtPrecio.EditValue)
            currentRow("CantFacturada") = CDec(currentRow("Cantidad"))
            currentRow("CantBonificada") = gdTotalBonificado
            currentRow("CostoLocal") = Redondear(CDec(Me.txtCostoPromLocal.EditValue), gParametros.DigitosDecimales)
            currentRow("CostoDolar") = Redondear(CDec(Me.txtCostoPromDolar.EditValue), gParametros.DigitosDecimales)
            currentRow("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.EditValue)
            currentRow("SubTotalFinal") = Redondear(CDec(currentRow("SubTotal")) - CDec(currentRow("Descuento")) - CDec(currentRow("DescuentoEspecial")), gParametros.DigitosDecimales)
            currentRow("Total") = Redondear(CDec(currentRow("SubTotalFinal")) + CDec(Me.txtImpuesto.EditValue), gParametros.DigitosDecimales)
            TotalizaGrid()
            'Me.GridViewProducto.FocusedRowHandle
            GridViewProducto.MoveFirst()
            RefreshDataFromGridToControls()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    'Private Sub chkBonificaProd_CheckedChanged(sender As Object, e As EventArgs) Handles chkBonificaProd.CheckedChanged
    '    If gbUsaPedido And gbLoteAsignado Then
    '        If chkBonifica.Checked And chkBonificaProd.Checked = False Then
    '            ActualizaDetallePedido()
    '        End If
    '    End If
    'End Sub

    'Private Sub txtCantPrecio_EditValueChanged(sender As Object, e As EventArgs) Handles txtCantPrecio.EditValueChanged
    '    If chkBonifica.Checked And chkBonificaProd.Checked = False Then
    '        ActualizaDetallePedido()
    '    End If
    'End Sub

    Private Sub txtCantBonif_LostFocus(sender As Object, e As EventArgs) Handles txtCantBonif.LostFocus
        If Not gbUsaPedido Then
            TriggerCantBonif()
        End If
    End Sub

    Private Sub txtCantPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtCantPrecio.LostFocus
        If Not gbUsaPedido Then
            TriggerCantBonifPrecio()
        End If

    End Sub


    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus
        If Not gbUsaPedido Then
            TriggerCantidad()
        End If
    End Sub

    Private Sub btnTablaBonif_Click(sender As Object, e As EventArgs) Handles btnTablaBonif.Click
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