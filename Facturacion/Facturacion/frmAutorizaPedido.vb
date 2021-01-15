Imports Clases
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.GridView
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors

Public Class frmAutorizaPedido
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Dim tableDataDetalle As New DataTable()
    Dim currentRow As DataRow

    Dim sVerPedidos As String = ""
    Dim sEstadoPedido As String = ""
    Public gbAutoriza As Boolean = True
    Public gbPuedeCrearFactura As Boolean = False
    Public gsIDPedido As String = ""
    Public gsIDBodega As String = ""
    Public gsIDCliente As String = ""
    Public gsFarmacia As String = ""
    Public gsIDVendedor As String = ""
    Public gsIDNivel As String = ""
    Public gsIDMoneda As String = ""
    Public gsIDPlazo As String = ""
    Public gbPedidoParaFactura As Boolean = False
    Public gdLimite As Decimal = 0
    Public gdDisponible As Decimal = 0
    Dim bNacional As Boolean = False
    Dim formatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
    Dim gridFormatRule = New DevExpress.XtraGrid.GridFormatRule()

    Private Sub frmAutorizaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' si quisiera mostar en la moneda del pedido= CBool(tableData.Rows(0)("Nacional"))

        CreaColmunastoGrid()
        gridFormatRule.ApplyToRow = True
        gridFormatRule.Column = GridViewProducto.Columns("TotalFinalLocal")
        gridFormatRule.Name = "HighlightErrID"
        'formatConditionRuleExpression.Appearance.BackColor = System.Drawing.Color.Red
        'formatConditionRuleExpression.Appearance.Options.UseBackColor = True
        'formatConditionRuleExpression.Expression = "TotalFinalLocal>" & txtDisponible.EditValue.ToString()
        'gridFormatRule.Rule = formatConditionRuleExpression
        GridViewProducto.FormatRules.Add(gridFormatRule)

        bNacional = True ' Fuerzo a que solo vean pedidos en cordobas
        Me.DateEditHasta.EditValue = DateTime.Now
        Me.DateEditDesde.Refresh()
        Me.DateEditHasta.Refresh()
        FormatControlNumber(txtCantidad)
        FormatControlNumber(txtCantBonif)
        FormatControlNumber(txtCantBonifPrecio)
        FormatControlNumber(txtPrecio)
        FormatControlNumber(txtPorcDescEsp)
        FormatControlNumber(txtDescuentoEsp)
        FormatControlNumber(txtSubTotalLin)
        FormatControlNumber(txtDescuentoLin)
        FormatControlNumber(txtDescuentoEsp)
        FormatControlNumber(txtSubTotalFinalLin)
        FormatControlNumber(txtImpuesto)
        FormatControlNumber(txtTotalLin)
        FormatControlNumber(txtPorcImp)
        FormatControlNumber(txtPrecioLista)
        FormatControlNumber(txtAhorro)
        gbPedidoParaFactura = False
        If gbAutoriza = True Then


            Me.DateEditDesde.EditValue = Now.AddDays(-7)
            Me.DateEditHasta.EditValue = Now.Date
            Me.btnAnular.Enabled = True
            Me.btnAprobar.Enabled = True
            Me.btnFactura.Enabled = False
            Me.rbTodos.Enabled = True
            Me.rbtDenegados.Enabled = True
            Me.btnActivaDenegado.Enabled = True
            Me.btnDenegar.Enabled = True
            Me.rbSoloCreados.Enabled = True
            Me.rbSoloCreados.Checked = True
            txtCantidad.Enabled = True
            txtCantBonif.Enabled = True
            txtCantBonifPrecio.Enabled = True
            txtPrecio.Enabled = True
            chkBonifica.Enabled = True
            chkBonifProd.Enabled = True
            cmdAplicar.Enabled = True


            RefreshGrids()
            'Dim gridFormatRule As New GridFormatRule()
            'Dim formatConditionRuleValue As New FormatConditionRuleValue()
            'gridFormatRule.Column = Me.GridViewProducto.Columns("TotalFinalLocal")
            'formatConditionRuleValue.PredefinedName = "Red Bold Text"
            'formatConditionRuleValue.Condition = FormatCondition.Greater
            'formatConditionRuleValue.Value1 = txtDisponible.EditValue
            'gridFormatRule.Rule = formatConditionRuleValue
            'GridViewProducto.FormatRules.Add(gridFormatRule)
        Else
            txtCantidad.Enabled = False
            txtCantBonif.Enabled = False
            txtCantBonifPrecio.Enabled = False
            txtPrecio.Enabled = False
            chkBonifica.Enabled = False
            chkBonifProd.Enabled = False
            cmdAplicar.Enabled = False
            Me.rbtDenegados.Enabled = False
            Me.btnActivaDenegado.Enabled = False
            Me.btnDenegar.Enabled = False

            Me.btnAnular.Enabled = False
            Me.btnAprobar.Enabled = False
            Me.btnFactura.Enabled = True
            Me.rbTodos.Enabled = False
            Me.rbSoloCreados.Enabled = True
            Me.rbSoloCreados.Checked = True
        End If
        If gbPuedeCrearFactura = True Then
            Me.rbAprobados.Enabled = True
            Me.rbAprobados.Checked = True
            Me.rbSoloCreados.Checked = False
            Me.rbSoloCreados.Enabled = False
            Me.rbTodos.Checked = False
            Me.rbTodos.Enabled = False
            Me.rbtDenegados.Enabled = False
            Me.btnActivaDenegado.Enabled = False
            Me.btnDenegar.Enabled = False
        End If

        ' AddCollumnsToDataTableGrid()

    End Sub

    Sub AddCollumnsToDataTableGrid()
        Try

            Dim dataColumnSubTotal As DataColumn = New DataColumn("SubTotal")
            dataColumnSubTotal.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnSubTotal)
            Dim dataColumnSubTotalFinal As DataColumn = New DataColumn("SubTotalFinal")
            dataColumnSubTotalFinal.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnSubTotalFinal)

            Dim dataColumnTotal As DataColumn = New DataColumn("Total")
            dataColumnTotal.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnTotal)

            Dim dataColumnImpuesto As DataColumn = New DataColumn("Impuesto")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnImpuesto)

            Dim dataColumnPrecio As DataColumn = New DataColumn("Precio")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnPrecio)

            Dim dataColumnPorImpuesto As DataColumn = New DataColumn("PorcImp")
            dataColumnImpuesto.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnPorImpuesto)


            Dim dataColumnPorcDescuentoEsp As DataColumn = New DataColumn("PorcDescuentoEsp")
            dataColumnPorcDescuentoEsp.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnPorcDescuentoEsp)

            Dim dataColumnDescuento As DataColumn = New DataColumn("Descuento")
            dataColumnDescuento.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnDescuento)

            Dim dataColumnDescEspecial As DataColumn = New DataColumn("DescEspecial")
            dataColumnDescEspecial.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnDescEspecial)

            Dim dataColumnCantBonif As DataColumn = New DataColumn("CantBonif")
            dataColumnDescEspecial.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnCantBonif)
            Dim dataColumnCantBonifPrecio As DataColumn = New DataColumn("CantPrecio")
            dataColumnCantBonifPrecio.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnCantBonifPrecio)

            Dim dataColumnBonif As DataColumn = New DataColumn("Bonifica")
            dataColumnBonif.DataType = System.Type.GetType("System.Boolean")
            tableDataDetalle.Columns.Add(dataColumnBonif)

            Dim dataColumnBonifprod As DataColumn = New DataColumn("BonifProd")
            dataColumnBonifprod.DataType = System.Type.GetType("System.Boolean")
            tableDataDetalle.Columns.Add(dataColumnBonifprod)

            Dim dataColumnPrecioLista As DataColumn = New DataColumn("PrecioLista")
            dataColumnPrecioLista.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnPrecioLista)

            Dim dataColumnAhorro As DataColumn = New DataColumn("Ahorro")
            dataColumnAhorro.DataType = System.Type.GetType("System.Decimal")
            tableDataDetalle.Columns.Add(dataColumnAhorro)

            tableDataDetalle.Columns.Add("IDBodega")
            tableDataDetalle.Columns.Add("IDProducto")
            tableDataDetalle.Columns.Add("Descr")
            tableDataDetalle.Columns.Add("Cantidad")

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try


    End Sub


    Sub RefreshGrid(Optional sIDPedido As String = "")
        Try
            Dim sParameters As String
            If sIDPedido = "" Or sIDPedido = "*" Then
                sParameters = "0,0" & ",'" & CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd") & "','" & CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd") & "', '" & sVerPedidos & "',1"
            Else
                sParameters = sIDPedido & ",0,'" & CDate(Me.DateEditDesde.EditValue).ToString("yyyyMMdd") & "','" & CDate(Me.DateEditHasta.EditValue).ToString("yyyyMMdd") & "', '" & sVerPedidos & "',1"
            End If

            tableData = cManager.ExecSPgetData("fafgetPedido", sParameters)
            GridControl1.DataSource = Nothing
            GridControl1.DataSource = tableData
            If tableData.Rows.Count > 0 Then

                GridControl1.Refresh()
                HideColumnsPedido(bNacional)

                formatConditionRuleExpression.Appearance.ForeColor = System.Drawing.Color.Red
                formatConditionRuleExpression.Appearance.Options.UseForeColor = True
                formatConditionRuleExpression.Expression = "TotalFinalLocal>DisponibleCredito"
                GridFormatRule.Rule = FormatConditionRuleExpression

            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Private Sub CreaColmunastoGrid()

        Me.GridViewProducto.Columns.AddField("IDPedido")
        Me.GridViewProducto.Columns(0).Visible = True
        Me.GridViewProducto.Columns(0).Width = 50
        Me.GridViewProducto.Columns.AddField("Fecha")
        Me.GridViewProducto.Columns(1).Width = 50
        Me.GridViewProducto.Columns(1).Visible = True
        Me.GridViewProducto.Columns(1).OptionsColumn.ReadOnly = True


        Me.GridViewProducto.Columns.AddField("DescrEstado")
        Me.GridViewProducto.Columns(2).Width = 50
        Me.GridViewProducto.Columns(2).Caption = "Estado"
        Me.GridViewProducto.Columns(2).Visible = True
        Me.GridViewProducto.Columns(2).OptionsColumn.ReadOnly = True


        Me.GridViewProducto.Columns.AddField("IDCliente")
        Me.GridViewProducto.Columns(3).Visible = True
        Me.GridViewProducto.Columns(3).Width = 50

        Me.GridViewProducto.Columns.AddField("Nombre")
        Me.GridViewProducto.Columns(4).Width = 150
        Me.GridViewProducto.Columns(4).Caption = "Nombre"
        Me.GridViewProducto.Columns(4).Visible = True


        Me.GridViewProducto.Columns.AddField("DescuentoLocal")
        Me.GridViewProducto.Columns(5).Visible = False
        Me.GridViewProducto.Columns(5).Caption = "Descuento"
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(5).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("DescuentoDolar")
        Me.GridViewProducto.Columns(6).Visible = False
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(6).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("DescuentoEspecialLocal")
        Me.GridViewProducto.Columns(7).Visible = False
        Me.GridViewProducto.Columns(7).Caption = "DescEspecial"
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(7).DisplayFormat.FormatString = "n2"


        Me.GridViewProducto.Columns.AddField("DescuentoEspecialDolar")
        Me.GridViewProducto.Columns(8).Visible = False
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(8).DisplayFormat.FormatString = "n2"


        Me.GridViewProducto.Columns.AddField("SubTotalLocal")
        Me.GridViewProducto.Columns(9).Visible = False
        Me.GridViewProducto.Columns(9).Caption = "SubTotal"
        Me.GridViewProducto.Columns(9).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(9).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("SubTotalDolar")
        Me.GridViewProducto.Columns(10).Visible = False
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(10).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("ImpuestoLocal")
        Me.GridViewProducto.Columns(11).Visible = False
        Me.GridViewProducto.Columns(11).Caption = "Impuesto"
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(11).DisplayFormat.FormatString = "n2"


        Me.GridViewProducto.Columns.AddField("ImpuestoDolar")
        Me.GridViewProducto.Columns(12).Visible = True
        Me.GridViewProducto.Columns(12).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(12).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("SubTotalFinalLocal")
        Me.GridViewProducto.Columns(13).Visible = False
        Me.GridViewProducto.Columns(13).Caption = "SubTotalFinal"
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(13).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("SubTotalFinalDolar")
        Me.GridViewProducto.Columns(14).Visible = False
        Me.GridViewProducto.Columns(14).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(14).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("TotalFinalLocal")
        Me.GridViewProducto.Columns(15).Visible = False
        Me.GridViewProducto.Columns(15).Caption = "TotalFinal"
        Me.GridViewProducto.Columns(15).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(15).DisplayFormat.FormatString = "n2"

        Me.GridViewProducto.Columns.AddField("TotalFinalDolar")
        Me.GridViewProducto.Columns(16).Visible = False
        Me.GridViewProducto.Columns(16).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewProducto.Columns(16).DisplayFormat.FormatString = "n2"


        Me.GridViewDetalle.Columns.AddField("IDProducto")
        Me.GridViewDetalle.Columns(0).Visible = True
        Me.GridViewDetalle.Columns(0).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("Descr")
        Me.GridViewDetalle.Columns(1).Width = 150
        Me.GridViewDetalle.Columns(1).Caption = "Descr"
        Me.GridViewDetalle.Columns(1).Visible = True
        Me.GridViewDetalle.Columns(1).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("Cantidad")
        Me.GridViewDetalle.Columns(2).Visible = True
        Me.GridViewDetalle.Columns(2).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(2).DisplayFormat.FormatString = "n2"


        Me.GridViewDetalle.Columns.AddField("PrecioLocal")
        Me.GridViewDetalle.Columns(3).Visible = True
        Me.GridViewDetalle.Columns(3).Caption = "Precio"
        Me.GridViewDetalle.Columns(3).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(3).DisplayFormat.FormatString = "n2"

        Dim item3 As GridColumnSummaryItem = GridViewDetalle.Columns(3).Summary.Add()
        item3.SummaryType = DevExpress.Data.SummaryItemType.Count
        item3.FieldName = "PrecioLocal"
        item3.DisplayFormat = "Totales:{0}"

        Me.GridViewDetalle.Columns.AddField("PrecioDolar")
        Me.GridViewDetalle.Columns(4).Visible = False
        Me.GridViewDetalle.Columns(4).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(4).DisplayFormat.FormatString = "n2"

        Me.GridViewDetalle.Columns.AddField("DescuentoLocal")
        Me.GridViewDetalle.Columns(5).Visible = False
        Me.GridViewDetalle.Columns(5).Caption = "Descuento"
        Me.GridViewDetalle.Columns(5).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(5).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(5).OptionsColumn.ReadOnly = True
        ' azepeda
        Dim item As GridColumnSummaryItem = GridViewDetalle.Columns(5).Summary.Add()
        item.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item.FieldName = "DescuentoLocal"
        item.DisplayFormat = " {0:n2}"



        Me.GridViewDetalle.Columns.AddField("DescuentoDolar")
        Me.GridViewDetalle.Columns(6).Visible = False
        Me.GridViewDetalle.Columns(6).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(6).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(6).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("DescuentoEspecialLocal")
        Me.GridViewDetalle.Columns(7).Visible = False
        Me.GridViewDetalle.Columns(7).Caption = "DescEspecial"
        Me.GridViewDetalle.Columns(7).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(7).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(7).OptionsColumn.ReadOnly = True
        Dim item7 As GridColumnSummaryItem = GridViewDetalle.Columns(7).Summary.Add()
        item7.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item7.FieldName = "DescuentoEspecialLocal"
        item7.DisplayFormat = " {0:n2}"


        Me.GridViewDetalle.Columns.AddField("DescuentoEspecialDolar")
        Me.GridViewDetalle.Columns(8).Visible = True
        Me.GridViewDetalle.Columns(8).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(8).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(8).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("SubTotalLocal")
        Me.GridViewDetalle.Columns(9).Visible = False
        Me.GridViewDetalle.Columns(9).Caption = "SubTotal"
        Me.GridViewDetalle.Columns(9).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(9).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(9).OptionsColumn.ReadOnly = True

        Dim item9 As GridColumnSummaryItem = GridViewDetalle.Columns(9).Summary.Add()
        item9.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item9.FieldName = "SubTotalLocal"
        item9.DisplayFormat = " {0:n2}"


        Me.GridViewDetalle.Columns.AddField("SubTotalDolar")
        Me.GridViewDetalle.Columns(10).Visible = False
        Me.GridViewDetalle.Columns(10).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(10).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(10).OptionsColumn.ReadOnly = True


        Me.GridViewDetalle.Columns.AddField("SubTotalFinalLocal")
        Me.GridViewDetalle.Columns(11).Visible = False
        Me.GridViewDetalle.Columns(11).Caption = "SubTotalFinal"
        Me.GridViewDetalle.Columns(11).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(11).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(11).OptionsColumn.ReadOnly = True

        Dim item11 As GridColumnSummaryItem = GridViewDetalle.Columns(11).Summary.Add()
        item11.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item11.FieldName = "SubTotalFinalLocal"
        item11.DisplayFormat = " {0:n2}"

        Me.GridViewDetalle.Columns.AddField("SubTotalFinalDolar")
        Me.GridViewDetalle.Columns(12).Visible = False
        Me.GridViewDetalle.Columns(12).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(12).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(12).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("ImpuestoLocal")
        Me.GridViewDetalle.Columns(13).Visible = False
        Me.GridViewDetalle.Columns(13).Caption = "Impuesto"
        Me.GridViewDetalle.Columns(13).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(13).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(13).OptionsColumn.ReadOnly = True

        Dim item13 As GridColumnSummaryItem = GridViewDetalle.Columns(13).Summary.Add()
        item13.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item13.FieldName = "ImpuestoLocal"
        item13.DisplayFormat = " {0:n2}"


        Me.GridViewDetalle.Columns.AddField("ImpuestoDolar")
        Me.GridViewDetalle.Columns(14).Visible = False
        Me.GridViewDetalle.Columns(14).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(14).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(14).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("TotalFinalLocal")
        Me.GridViewDetalle.Columns(15).Visible = False
        Me.GridViewDetalle.Columns(15).Caption = "TotalFinal"
        Me.GridViewDetalle.Columns(15).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(15).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(15).OptionsColumn.ReadOnly = True

        Dim item15 As GridColumnSummaryItem = GridViewDetalle.Columns(15).Summary.Add()
        item15.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item15.FieldName = "TotalFinalLocal"
        item15.DisplayFormat = " {0:n2}"


        Me.GridViewDetalle.Columns.AddField("TotalFinalDolar")
        Me.GridViewDetalle.Columns(16).Visible = False
        Me.GridViewDetalle.Columns(16).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(16).DisplayFormat.FormatString = "n2"
        Me.GridViewDetalle.Columns(16).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("Bonifica")
        Me.GridViewDetalle.Columns(17).Visible = False
        Me.GridViewDetalle.Columns(17).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(17).OptionsColumn.ReadOnly = True
        Me.GridViewDetalle.Columns.AddField("BonificaConProd")
        Me.GridViewDetalle.Columns(18).Visible = False
        Me.GridViewDetalle.Columns(18).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(18).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("CantBonificada")
        Me.GridViewDetalle.Columns(19).Visible = False
        Me.GridViewDetalle.Columns(19).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(19).OptionsColumn.ReadOnly = True

        Me.GridViewDetalle.Columns.AddField("CantPrecio")
        Me.GridViewDetalle.Columns(20).Visible = False
        Me.GridViewDetalle.Columns(20).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(20).OptionsColumn.ReadOnly = True
        Me.GridViewDetalle.Columns.AddField("PorcImp")
        Me.GridViewDetalle.Columns(21).Visible = False
        Me.GridViewDetalle.Columns(21).DisplayFormat.FormatType = FormatType.Numeric
        Me.GridViewDetalle.Columns(21).OptionsColumn.ReadOnly = True
    End Sub

    Private Sub HideColumnsPedido(bNacional As Boolean)
        If bNacional Then

            Me.GridViewProducto.Columns("DescuentoLocal").Visible = True
            Me.GridViewProducto.Columns("DescuentoEspecialLocal").Visible = True
            Me.GridViewProducto.Columns("ImpuestoLocal").Visible = True
            Me.GridViewProducto.Columns("SubTotalLocal").Visible = True
            Me.GridViewProducto.Columns("SubTotalFinalLocal").Visible = True
            Me.GridViewProducto.Columns("TotalFinalLocal").Visible = True


            Me.GridViewProducto.Columns("DescuentoDolar").Visible = False
            Me.GridViewProducto.Columns("DescuentoEspecialDolar").Visible = False
            Me.GridViewProducto.Columns("ImpuestoDolar").Visible = False
            Me.GridViewProducto.Columns("SubTotalDolar").Visible = False
            Me.GridViewProducto.Columns("SubTotalFinalDolar").Visible = False
            Me.GridViewProducto.Columns("TotalFinalDolar").Visible = False

        Else

            Me.GridViewProducto.Columns("DescuentoLocal").Visible = False
            Me.GridViewProducto.Columns("DescuentoEspecialLocal").Visible = False
            Me.GridViewProducto.Columns("ImpuestoLocal").Visible = False
            Me.GridViewProducto.Columns("SubTotalLocal").Visible = False
            Me.GridViewProducto.Columns("SubTotalFinalLocal").Visible = False
            Me.GridViewProducto.Columns("TotalFinalLocal").Visible = False
            Me.GridViewProducto.Columns("DescuentoDolar").Visible = True
            Me.GridViewProducto.Columns("DescuentoEspecialDolar").Visible = True
            Me.GridViewProducto.Columns("ImpuestoDolar").Visible = True
            Me.GridViewProducto.Columns("SubTotalDolar").Visible = True
            Me.GridViewProducto.Columns("SubTotalFinalDolar").Visible = True
            Me.GridViewProducto.Columns("TotalFinalDolar").Visible = True
        End If
    End Sub


    Private Sub HideColumnsDetalle(bNacional As Boolean)
        If bNacional Then
            Me.GridViewDetalle.Columns("PrecioLocal").Visible = True
            Me.GridViewDetalle.Columns("DescuentoLocal").Visible = True
            Me.GridViewDetalle.Columns("DescuentoEspecialLocal").Visible = True
            Me.GridViewDetalle.Columns("ImpuestoLocal").Visible = True
            Me.GridViewDetalle.Columns("SubTotalLocal").Visible = True
            Me.GridViewDetalle.Columns("SubTotalFinalLocal").Visible = True
            Me.GridViewDetalle.Columns("TotalFinalLocal").Visible = True
            Me.GridViewDetalle.Columns("PrecioDolar").Visible = False
            Me.GridViewDetalle.Columns("DescuentoDolar").Visible = False
            Me.GridViewDetalle.Columns("DescuentoEspecialDolar").Visible = False
            Me.GridViewDetalle.Columns("ImpuestoDolar").Visible = False
            Me.GridViewDetalle.Columns("SubTotalDolar").Visible = False
            Me.GridViewDetalle.Columns("SubTotalFinalDolar").Visible = False
            Me.GridViewDetalle.Columns("TotalFinalDolar").Visible = False
        Else
            Me.GridViewDetalle.Columns("PrecioDolar").Visible = True
            Me.GridViewDetalle.Columns("DescuentoDolar").Visible = True
            Me.GridViewDetalle.Columns("DescuentoEspecialDolar").Visible = True
            Me.GridViewDetalle.Columns("ImpuestoDolar").Visible = True
            Me.GridViewDetalle.Columns("SubTotalDolar").Visible = True
            Me.GridViewDetalle.Columns("SubTotalFinalDolar").Visible = True
            Me.GridViewDetalle.Columns("TotalFinalDolar").Visible = True

            Me.GridViewDetalle.Columns("PrecioLocal").Visible = False
            Me.GridViewDetalle.Columns("DescuentoLocal").Visible = False
            Me.GridViewDetalle.Columns("DescuentoEspecialLocal").Visible = False
            Me.GridViewDetalle.Columns("ImpuestoLocal").Visible = False
            Me.GridViewDetalle.Columns("SubTotalLocal").Visible = False
            Me.GridViewDetalle.Columns("SubTotalFinalLocal").Visible = False
            Me.GridViewDetalle.Columns("TotalFinalLocal").Visible = False

        End If
    End Sub


    Private Sub ActualizaLineaPedido(iIDProducto As Int32, dCantidad As Decimal, dPrecio As Decimal, bBonifica As Int16, bBonifProd As Int16, dCantBonif As Decimal, dCantPrecio As Decimal, dPorcDescuentoEsp As Decimal)
        Try
            Dim dPrecioLista As Decimal, dAhorro As Decimal
            If currentRow IsNot Nothing Then
                currentRow("Cantidad") = Me.txtCantidad.Text
                currentRow("CantBonificada") = CDec(Me.txtCantBonif.Text)
                currentRow("CantPrecio") = CDec(Me.txtCantBonifPrecio.Text)
                currentRow("PrecioLocal") = CDbl(Me.txtPrecio.Text)
                currentRow("DescuentoLocal") = CDec(Me.txtDescuentoLin.EditValue)
                currentRow("PorcDescuentoEsp") = CDec(Me.txtPorcDescEsp.Text)
                currentRow("DescuentoEspecialLocal") = CDec(Me.txtDescuentoEsp.Text)
                currentRow("ImpuestoLocal") = CDec(Me.txtImpuesto.Text)
                currentRow("SubTotalLocal") = CDec(Me.txtPrecio.Text) * (CDbl(txtCantidad.Text) + CDec(Me.txtCantBonif.Text))
                currentRow("SubTotalFinalLocal") = CDec(currentRow("SubTotalLocal")) - CDec(currentRow("DescuentoLocal")) - CDec(currentRow("DescuentoEspecialLocal"))
                currentRow("PorcImp") = CDec(txtPorcImp.Text)
                currentRow("TotalFinalLocal") = CDec(currentRow("SubTotalFinalLocal")) + CDec(Me.txtImpuesto.Text)
                dPrecioLista = CDec(currentRow("PrecioLista"))
                dAhorro = CDec(currentRow("Ahorro"))
                Dim storeName As String, sparameters As String
                storeName = "fafUpdatePedidoProd"
                sparameters = "'U'" & "," & gsIDPedido & "," & gsIDBodega & "," & iIDProducto.ToString() & "," & _
                dCantidad.ToString() & "," & dPrecio.ToString() & "," & 0.ToString() & "," & txtImpuesto.EditValue.ToString() & "," & _
                0.ToString() & "," & txtSubTotalLin.EditValue.ToString() & "," & 0.ToString() & "," & txtSubTotalFinalLin.EditValue.ToString() & "," & 0.ToString() & "," & _
                bBonifica.ToString() & "," & bBonifProd.ToString() & "," & _
                dCantBonif.ToString() & "," & dCantPrecio.ToString() & "," & txtDescuentoLin.EditValue.ToString() & "," & 0.ToString() & "," & txtPorcDescEsp.Text & "," & _
                txtDescuentoEsp.EditValue.ToString() & "," & 0.ToString() & "," & txtPorcImp.EditValue.ToString() & "," & dPrecioLista.ToString() & "," & dAhorro.ToString()
                cManager.ExecSP(storeName, sparameters)
                MessageBox.Show("Ud ha actualizado exitosamente el producto del Pedido seleccionado, recuede aprobar el Pedido para que pueda generar una factura.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim topRowIndex As Integer = Me.GridViewProducto.TopRowIndex
                Dim focusedRowHandle As Integer = GridViewProducto.FocusedRowHandle
                RefreshGrids()
                GridViewProducto.FocusedRowHandle = focusedRowHandle
                GridViewProducto.TopRowIndex = topRowIndex
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar el registro " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshGrids()
    End Sub

    Private Sub RefreshGrids()
        If Me.rbTodos.Checked = True Then
            sVerPedidos = "*"
        End If
        If Me.rbSoloCreados.Checked = True Then
            sVerPedidos = "C"
        End If
        If Me.rbAprobados.Checked = True Then
            sVerPedidos = "A" ' Puede crear facturas y solo necesita refrescar los pedidos Aprobados
        End If
        If Me.rbtDenegados.Checked = True Then
            sVerPedidos = "D" ' Puede crear facturas y solo necesita refrescar los pedidos Aprobados
        End If
        RefreshGrid("")

    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            If sEstadoPedido <> "C" Then
                MessageBox.Show("Para poder Aprobar un Pedido, Ud debe seleccionar solo los Creados... por favor Revise ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If sEstadoPedido = "A" Then
                MessageBox.Show("Este pedido ya está autorizado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("Ud va a aprobar el Pedido " & gsIDPedido & " del Cliente " & txtNombre.Text, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cManager.Update("fafPedido", "Estado = 'A'", " IDPedido = " & gsIDPedido & " and IDBodega = " & gsIDBodega)
                RefreshGrid("")

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub

    Private Sub GridViewProducto_CustomDrawFooterCell(sender As Object, e As Views.Grid.FooterCellCustomDrawEventArgs) Handles GridViewProducto.CustomDrawFooterCell
        Dim summary As GridSummaryItem = e.Info.SummaryItem
        Dim dSubTotal As Decimal = CDec(summary.SummaryValue)
    End Sub

 

    Private Sub GridViewProducto_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProducto.FocusedRowChanged
        Dim index As Integer = GridViewProducto.FocusedRowHandle
        If index > -1 Then
            Dim dr As DataRow = GridViewProducto.GetFocusedDataRow()
            currentRow = dr
            If dr IsNot Nothing Then
                gsIDCliente = dr("IDCliente").ToString()
                gsIDPedido = dr("IDPedido").ToString()
                gsIDBodega = dr("IDBodega").ToString()
                gsIDNivel = dr("IDNivel").ToString()
                gsIDMoneda = dr("IDMoneda").ToString()
                gsIDPlazo = dr("IDPlazo").ToString()
                Me.txtIDPedido.EditValue = dr("IDPedido").ToString()
                sEstadoPedido = dr("Estado").ToString()
                Me.txtNombre.EditValue = dr("Nombre").ToString()
                txtLimite.EditValue = dr("LimiteCredito").ToString()
                txtDisponible.EditValue = dr("DisponibleCredito").ToString()
                Me.GridControl2.DataSource = Nothing
                tableDataDetalle = cManager.ExecSPgetData("fafgetPedido", gsIDPedido & "," & gsIDBodega & ",null, null, '" & sEstadoPedido & "',0")
                Me.GridControl2.DataSource = tableDataDetalle
                HideColumnsDetalle(bNacional)
            End If
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If MessageBox.Show("Está Ud seguro de Anular el Pedido " & gsIDPedido & "No lo podrá utilizar más ...", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                cManager.Update("fafPedido", "Estado = 'N', Anulado= 1", " IDPedido = " & gsIDPedido & " and IDBodega = " & gsIDBodega)
                RefreshGrid("")
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error " & ex.Message)
            End Try

        End If
    End Sub


    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        If gsIDPedido = "" Or gsIDBodega = "" Then
            MessageBox.Show("Ud debe seleccionar un Pedido... por favor corra el proceso Refresh para que Ud pueda seleccionar un pedido", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            gbPedidoParaFactura = False
            Return
        Else
            gbPedidoParaFactura = True
            gdLimite = txtLimite.EditValue
            gdDisponible = txtDisponible.EditValue
            Me.Close()
        End If
    End Sub


    Private Sub RefreshControlsFromGrid()
        Dim dr As DataRow = GridViewDetalle.GetFocusedDataRow()
        currentRow = dr
        If dr IsNot Nothing Then
            Me.txtCodigo.EditValue = dr("IDProducto").ToString()
            Me.txtDescr.EditValue = dr("Descr").ToString()
            Me.txtCantidad.EditValue = dr("Cantidad")
            Me.txtCantBonif.EditValue = dr("CantBonificada")
            Me.txtCantBonifPrecio.EditValue = dr("CantPrecio")
            Me.txtPrecio.EditValue = dr("PrecioLocal")
            Me.chkBonifica.EditValue = dr("Bonifica")
            Me.chkBonifProd.EditValue = dr("BonifconProd")
            Me.txtDescuentoLin.EditValue = dr("DescuentoLocal")
            Me.txtPorcDescEsp.EditValue = dr("PorcDescuentoEsp")
            Me.txtDescuentoEsp.EditValue = dr("DescuentoEspecialLocal")
            Me.txtPorcImp.EditValue = CDec(dr("PorcImp"))
            Me.txtSubTotalLin.EditValue = dr("SubtotalLocal")
            Me.txtTotalLin.EditValue = dr("TotalFinalLocal")
            Me.txtImpuesto.EditValue = dr("ImpuestoLocal")
            txtSubTotalFinalLin.EditValue = dr("SubTotalFinalLocal")
            Me.txtPrecioLista.EditValue = dr("PrecioLista")
            Me.txtAhorro.EditValue = dr("Ahorro")
            Dim sParametros As String
            Dim t As New DataTable
            sParametros = txtCodigo.Text & "," & txtCantidad.Text
            t = cManager.ExecFunction("fafGetBono", sParametros)
            If t.Rows.Count > 0 Then
                txtBono.EditValue = t.Rows(0).Item(0)
            Else
                txtBono.EditValue = 0
            End If



        End If
    End Sub

    Private Function CalculaImpuesto() As Double

        Dim dImpuesto As Double = 0

        dImpuesto = CDbl(Me.txtSubTotalFinalLin.EditValue) * CDbl(If(String.IsNullOrEmpty(Me.txtPorcImp.Text), 0, Me.txtPorcImp.Text)) / 100
        Return dImpuesto

    End Function


    Private Sub RefrescaBonoProducto()
        Dim sParametros As String, dBono As Decimal
        Dim t As New DataTable
        If chkBonifica.Checked Then
            txtCantBonif.ReadOnly = False
            If txtCantidad.EditValue > 0 Then
                sParametros = txtCodigo.Text & "," & txtCantidad.Text
                t = cManager.ExecFunction("fafGetBono", sParametros)
                If t.Rows.Count > 0 Then
                    dBono = t.Rows(0).Item(0)
                Else
                    dBono = 0
                End If

                txtBono.EditValue = dBono
                txtCantBonif.EditValue = Redondear(dBono, gParametros.DigitosDecimales)
                Me.txtCantBonifPrecio.EditValue = 0
            End If
            'txtCantBonif.Focus()
        Else
            txtCantBonif.Text = 0
            txtCantBonif.ReadOnly = True

        End If
    End Sub

    Private Sub ValidaLetraNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtCantidad.KeyPress, txtPrecio.KeyPress, txtCantBonif.KeyPress, txtCantBonifPrecio.KeyPress
        Dim strListaControles As String
        strListaControles = "txtCantidad , txtPrecio ,  txtCantBonif, txtCantBonifPrecio"
        If strListaControles.Contains(sender.name) = True And Asc(e.KeyChar) <> Keys.Return Then
            e.KeyChar = Chr(Solo_Numeros(Asc(e.KeyChar)))
        End If
        If sender.name = "txtCantidad" And Asc(e.KeyChar) = Keys.Return Then
            txtPrecio.Focus()
        End If
        If sender.name = "txtCantBonif" And Asc(e.KeyChar) = Keys.Return Then
            txtAhorro.Focus()
        End If
        If sender.name = "txtCantBonifPrecio" And Asc(e.KeyChar) = Keys.Return Then
            txtAhorro.Focus()

        End If

        If sender.name = "txtPrecio" And Asc(e.KeyChar) = Keys.Return Then
            Me.txtAhorro.Focus()
        End If

    End Sub

    Private Sub TriggerCantidad()
        If Me.txtPorcDescEsp.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or _
        Not (Me.txtPorcDescEsp.EditValue IsNot Nothing) Or Not (Me.txtPrecio.EditValue IsNot Nothing) Or _
        Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If
        RefrescaBonoProducto()
        txtPrecio.EditValue = txtPrecioLista.EditValue ' pongo el precio lista porque pudo haber venido con preciocantidad en el pedido
        CalculaSubTotales()
    End Sub

    Private Sub TriggerCantBonif()
        If Me.txtCantidad.Text = "" Or Me.txtCantBonif.Text = "" Or txtPrecio.Text = "" Or Not (Me.txtCantBonif.EditValue IsNot Nothing) Or Not (Me.txtPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If
        If Me.txtCantBonif.EditValue > 0 And txtCantidad.EditValue = 0 Then
            MessageBox.Show("Ud Digitó la cantidad a Bonificar pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RefreshControlsFromGrid()
            txtCantBonif.Text = 0
            txtCantidad.Focus()
            Return
        End If
        CalculaSubTotales()
    End Sub

    Private Sub CalculaSubTotales()
        If CDec(Me.txtCantBonifPrecio.EditValue) > 0 Then
            Me.txtPrecio.EditValue = Redondear((CDec(txtPrecioLista.EditValue) * CDec(txtCantidad.EditValue)) / (CDec(txtCantidad.EditValue) + CDec(Me.txtCantBonifPrecio.EditValue)), gParametros.DigitosDecimales)
        End If

        Me.txtSubTotalLin.EditValue = Redondear(CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)) * (CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) + CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text))), gParametros.DigitosDecimales)
        Me.txtDescuentoLin.EditValue = Redondear(CDec(IIf(Me.txtCantBonif.Text = "", 0, Me.txtCantBonif.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        Me.txtDescuentoEsp.EditValue = Redondear(CDec(IIf(Me.txtPorcDescEsp.Text = "", 0, Me.txtPorcDescEsp.Text)) / 100 * CDec(IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)) * CDec(IIf(Me.txtPrecio.Text = "", 0, Me.txtPrecio.Text)), gParametros.DigitosDecimales)
        ' Me.txtDescEspLinea.Text = String.Format("{0:0.00}", txtSubTotalLin.EditValue)

        Me.txtSubTotalFinalLin.EditValue = Redondear(Me.txtSubTotalLin.EditValue - Me.txtDescuentoLin.EditValue - Me.txtDescuentoEsp.EditValue, gParametros.DigitosDecimales)

        txtAhorro.EditValue = ((Me.txtPrecioLista.EditValue * (txtCantidad.EditValue + txtCantBonif.EditValue)) - Me.txtSubTotalFinalLin.EditValue)
        If txtAhorro.EditValue > 0 Then
            txtAhorro.Visible = True
        Else
            txtAhorro.Visible = False
        End If
        txtImpuesto.EditValue = Redondear(CalculaImpuesto(), gParametros.DigitosDecimales)
        Me.txtTotalLin.EditValue = Redondear(Me.txtSubTotalFinalLin.EditValue + txtImpuesto.EditValue, gParametros.DigitosDecimales)
    End Sub

    Private Sub GridViewDetalle_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewDetalle.FocusedRowChanged
        RefreshControlsFromGrid()
    End Sub

    'Private Sub CalculaValoresProducto()
    '    ' nuevo el 28/09/2020

    '    Dim dCantidadBonificada As Decimal = 0
    '    Dim dr As DataRow = GridViewDetalle.GetFocusedDataRow()
    '    Dim dPrecio As Decimal
    '    Dim t As DataTable
    '    Dim sParametros As String
    '    currentRow = dr
    '    If dr IsNot Nothing Then

    '        If CDec(dr("CantPrecio")) > 0 And txtCantBonifPrecio.EditValue = 0 Then


    '            sParametros = gsIDCliente & "," & gsIDNivel & "," & txtCodigo.Text & "," & gsIDMoneda
    '            t = cManager.ExecFunction("fafGetPrecio", sParametros)
    '            dPrecio = t.Rows(0).Item(0)
    '            txtPrecio.EditValue = Redondear(dPrecio, gParametros.DigitosDecimales)

    '        Else
    '            Me.txtPrecio.EditValue = dr("PrecioLocal")
    '        End If
    '        dCantidadBonificada = CDec(txtCantBonif.EditValue)


    '        Me.txtDescuentoLin.EditValue = dCantidadBonificada * Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)
    '        If txtPorcDescEsp.Text = "" Then
    '            txtPorcDescEsp.EditValue = 0
    '        End If
    '        Me.txtDescuentoEsp.EditValue = CDec(txtPorcDescEsp.EditValue) / 100 * txtCantidad.EditValue * Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales)

    '        Me.txtSubTotalLin.EditValue = Redondear(CDec(txtPrecio.EditValue), gParametros.DigitosDecimales) * (CDec(txtCantidad.EditValue) + CDec(txtCantBonif.EditValue))

    '        Me.txtSubTotalFinalLin.EditValue = Redondear(CDec(Me.txtSubTotalLin.EditValue) - CDec(Me.txtDescuentoLin.EditValue) - CDec(Me.txtDescuentoEsp.EditValue), gParametros.DigitosDecimales)
    '        txtImpuesto.EditValue = CDbl(Me.txtSubTotalFinalLin.EditValue) * CDbl(If(String.IsNullOrEmpty(Me.txtPorcImp.Text), 0, Me.txtPorcImp.Text)) / 100
    '        Me.txtTotalLin.EditValue = Redondear(Me.txtSubTotalFinalLin.EditValue + txtImpuesto.EditValue, gParametros.DigitosDecimales)


    '        ' Dim s As Object = (GridViewDetalle.Columns(5).SummaryItem.SummaryValue("SubTotalLocal"))


    '        'Dim DescuentoEsp = Me.GridViewDetalle.Columns("DescuentoEspecialLocal").SummaryItem.SummaryValue
    '        'Dim Impuesto = Me.GridViewDetalle.Columns("ImpuestoLocal").SummaryItem.SummaryValue
    '        'Dim SubTotalFinal = Me.GridViewDetalle.Columns("SubTotalFinalLocal").SummaryItem.SummaryValue
    '        'Dim TotalFinal = Me.GridViewDetalle.Columns("TotalFinalLocal").SummaryItem.SummaryValue

    '    End If

    'End Sub



    Private Sub cmdAplicar_Click(sender As Object, e As EventArgs) Handles cmdAplicar.Click
        If sEstadoPedido <> "C" Then
            MessageBox.Show("Para poder Modificar un Pedido, Ud debe seleccionar solo los Creados... por favor Revise ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If ControlsDetalleOk() Then
            ActualizaLineaPedido(txtCodigo.EditValue, txtCantidad.EditValue, txtPrecio.EditValue, chkBonifica.EditValue, chkBonifProd.EditValue, txtCantBonif.EditValue, txtCantBonifPrecio.EditValue, 0)
        Else
            MessageBox.Show("Por favor revise los datos, existe un error en el valor de uno de ellos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If gsIDPedido = "" Or gsIDBodega = "" Then
            MessageBox.Show("Ud debe seleccionar un Pedido... por favor corra el proceso Refresh para que Ud pueda seleccionar un pedido", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            gbPedidoParaFactura = False
            Return
        Else
            gbPedidoParaFactura = True
            Me.Close()
        End If
    End Sub


    Private Sub btnDenegar_Click(sender As Object, e As EventArgs) Handles btnDenegar.Click
        Try
            If sEstadoPedido = "D" Then
                MessageBox.Show("Este pedido ya está Denegado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If sEstadoPedido <> "C" Then
                MessageBox.Show("Solo se puede Denegar un Pedido Creado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("Ud va a Denegar el Pedido " & gsIDPedido & " del Cliente " & txtNombre.Text, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cManager.Update("fafPedido", "Estado = 'D'", " IDPedido = " & gsIDPedido & " and IDBodega = " & gsIDBodega)
                RefreshGrid("")

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub

    Private Sub btnActivaDenegado_Click(sender As Object, e As EventArgs) Handles btnActivaDenegado.Click
        Try
            If sEstadoPedido = "C" Then
                MessageBox.Show("Este pedido no puede ser Activado ya que está creado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If sEstadoPedido <> "D" Then
                MessageBox.Show("Solo se puede Activar un pedido que ha sido Denegado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("Ud va a Activar el Pedido " & gsIDPedido & " del Cliente " & txtNombre.Text, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cManager.Update("fafPedido", "Estado = 'C'", " IDPedido = " & gsIDPedido & " and IDBodega = " & gsIDBodega)
                sVerPedidos = "*"
                RefreshGrid("")

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub


    'Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
    '    If ControlsDetalleOk() Then
    '        CalculaValoresProducto()
    '    Else
    '        MessageBox.Show("Por favor revise los datos, existe un error en el valor de uno de ellos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If

    'End Sub

    Private Sub cmdUndo_Click(sender As Object, e As EventArgs) Handles cmdUndo.Click
        RefreshControlsFromGrid()
    End Sub

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

    Private Sub TriggerCantBonifPrecio()
        If Me.txtCantidad.Text = "" Or txtPrecio.Text = "" Or Not (Me.txtCantBonifPrecio.EditValue IsNot Nothing) Or Not (Me.txtCantidad.EditValue IsNot Nothing) Then
            Return
        End If

        If txtCantBonifPrecio.Text = "" Then
            txtCantBonifPrecio.EditValue = 0
        End If

        If Me.txtCantBonifPrecio.EditValue > 0 And txtCantidad.EditValue = 0 Then
            MessageBox.Show("Ud Digitó la cantidad a Bonificar en Precio pero no digitó la cantidad a Facturar ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RefreshControlsFromGrid()
            txtCantBonifPrecio.EditValue = 0
            txtCantidad.Focus()
            Return
        End If


        If Me.txtPrecio.EditValue = 0 Or txtCantBonifPrecio.EditValue = 0 Then
            txtPrecio.EditValue = txtPrecioLista.EditValue
        End If

        If CDec(txtCantBonifPrecio.EditValue) <= txtBono.EditValue Then
            txtCantBonif.EditValue = txtBono.EditValue - txtCantBonifPrecio.EditValue
        End If

        If (CDec(txtCantBonifPrecio.EditValue) > txtBono.EditValue) Or txtCantBonifPrecio.Text = "" Then
            txtCantBonifPrecio.EditValue = 0
            txtPrecio.EditValue = txtPrecioLista.EditValue
            txtCantBonif.EditValue = txtBono.EditValue
        End If


        CalculaSubTotales()

    End Sub


    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus
        TriggerCantidad()
    End Sub

    Private Sub txtCantBonif_LostFocus(sender As Object, e As EventArgs) Handles txtCantBonif.LostFocus
        TriggerCantBonif()
    End Sub

    Private Sub txtCantBonifPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtCantBonifPrecio.LostFocus
        TriggerCantBonifPrecio()
    End Sub



    Private Function colTotalPedido() As GridColumn
        Throw New NotImplementedException
    End Function

    Private Sub LayoutControl1_Click(sender As Object, e As EventArgs) Handles LayoutControl1.Click

    End Sub

    Private Sub GridViewProducto_RowStyle(sender As Object, e As Views.Grid.RowStyleEventArgs) Handles GridViewProducto.RowStyle
        Dim g As New DevExpress.XtraGrid.Views.Grid.GridView
        g = sender
        If e.RowHandle <> -1 Then
            Dim Dispoinible As Decimal = CDec(g.GetRowCellValue(e.RowHandle, "DisponibleCredito"))
            Dim TotalPedido As Decimal = CDec(g.GetRowCellValue(e.RowHandle, "TotalFinalLocal"))

            If TotalPedido > Dispoinible Then
                g.Appearance.FocusedRow.ForeColor = Color.Red
            Else
                g.Appearance.FocusedRow.ForeColor = Color.Black
            End If
        End If
    End Sub
End Class