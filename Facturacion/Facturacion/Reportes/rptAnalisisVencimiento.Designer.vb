<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptAnalisisVencimiento
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAnalisisVencimiento))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupHeaderSucursal = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeaderCliente = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblHasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.pdFechaFinal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblCliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.psCliente = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblNombreReporte = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblEmpresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.psEmpresa = New DevExpress.XtraReports.Parameters.Parameter()
        Me.piIDBodega = New DevExpress.XtraReports.Parameters.Parameter()
        Me.piIDCliente = New DevExpress.XtraReports.Parameters.Parameter()
        Me.piConsolidaSucursal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.piEnDolar = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLabel25, Me.XrLabel26})
        Me.Detail.HeightF = 21.7083!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.SaldoNovencido", "{0:n2}")})
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(15.24502!, 1.000023!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(103.0097!, 18.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldoa30", "{0:n2}")})
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(130.7548!, 1.000023!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(75.74262!, 18.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo31a60", "{0:n2}")})
        Me.XrLabel20.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(206.4974!, 1.000023!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(90.87666!, 18.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo61a90", "{0:n2}")})
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(315.8251!, 0.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(73.91107!, 18.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo91a120", "{0:n2}")})
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(398.1559!, 0.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(89.20599!, 18.0!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo121a180", "{0:n2}")})
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(501.5453!, 0.0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(89.2699!, 18.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo181a600", "{0:n2}")})
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(608.9234!, 0.0!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(85.12994!, 18.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldomas600", "{0:n2}")})
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(716.9433!, 0.0!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(81.20685!, 18.0!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "XrLabel25"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.TotalCliente", "{0:n2}")})
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(809.7319!, 0.0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(80.26801!, 18.0!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "XrLabel26"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Ced_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "ccfGetAntiguedadSaldos"
        QueryParameter1.Name = "@IDBodega"
        QueryParameter1.Type = GetType(Integer)
        QueryParameter1.ValueInfo = "0"
        QueryParameter2.Name = "@IDCliente"
        QueryParameter2.Type = GetType(Integer)
        QueryParameter2.ValueInfo = "0"
        QueryParameter3.Name = "@FechaCorte"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.pdFechaFinal]", GetType(Date))
        QueryParameter4.Name = "@EnDolar"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.piEnDolar]", GetType(Short))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.StoredProcName = "ccfrptAntiguedadSaldosPorCliente"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupHeaderSucursal
        '
        Me.GroupHeaderSucursal.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrLabel15})
        Me.GroupHeaderSucursal.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Bodega", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderSucursal.HeightF = 21.33335!
        Me.GroupHeaderSucursal.KeepTogether = True
        Me.GroupHeaderSucursal.Level = 1
        Me.GroupHeaderSucursal.Name = "GroupHeaderSucursal"
        Me.GroupHeaderSucursal.RepeatEveryPage = True
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Bodega")})
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(227.5867!, 3.333346!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(363.2288!, 18.0!)
        Me.XrLabel2.StyleName = "DataField"
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(92.38262!, 1.333332!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(67.70178!, 20.00002!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Sucursal"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.IDBodega")})
        Me.XrLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(175.6743!, 3.333346!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(41.70179!, 18.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "XrLabel15"
        '
        'GroupHeaderCliente
        '
        Me.GroupHeaderCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel16, Me.XrLabel17})
        Me.GroupHeaderCliente.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IDCliente", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderCliente.HeightF = 20.00002!
        Me.GroupHeaderCliente.KeepTogether = True
        Me.GroupHeaderCliente.Name = "GroupHeaderCliente"
        Me.GroupHeaderCliente.RepeatEveryPage = True
        Me.GroupHeaderCliente.StyleName = "FieldCaption"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(15.24502!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(67.70178!, 20.00002!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Cliente"
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.IDCliente")})
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(93.29166!, 0.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(41.70176!, 18.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.NOMBRE")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(145.2041!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(298.5751!, 18.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(15.24499!, 149.5!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(103.0097!, 18.0!)
        Me.XrLabel6.Text = "Saldo Novencido"
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(130.7547!, 149.5!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(75.74263!, 18.0!)
        Me.XrLabel7.Text = "Saldoa30"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(227.5865!, 149.5!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(69.78761!, 18.0!)
        Me.XrLabel8.Text = "Saldo31a60"
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(315.8251!, 149.5!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(73.91107!, 18.0!)
        Me.XrLabel9.Text = "Saldo61a90"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(398.1559!, 149.5!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(89.20593!, 18.0!)
        Me.XrLabel10.Text = "Saldo91a120"
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(501.5453!, 149.5!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(89.2699!, 18.0!)
        Me.XrLabel11.Text = "Saldo121a180"
        '
        'XrLabel12
        '
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(608.9234!, 149.5!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(94.47827!, 18.0!)
        Me.XrLabel12.Text = "Saldo181a600"
        '
        'XrLabel13
        '
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(716.9433!, 149.5!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(81.20685!, 18.0!)
        Me.XrLabel13.Text = "Saldomas600"
        '
        'XrLabel14
        '
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(809.7319!, 149.5!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(80.26813!, 18.0!)
        Me.XrLabel14.Text = "Total Cliente"
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.HeightF = 31.00001!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.HeightF = 0.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'GroupFooterBand1
        '
        Me.GroupFooterBand1.HeightF = 1.0!
        Me.GroupFooterBand1.Name = "GroupFooterBand1"
        '
        'GroupFooterBand2
        '
        Me.GroupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel47, Me.XrLabel46, Me.XrLabel28, Me.XrLabel29, Me.XrLabel30, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel34, Me.XrLabel35, Me.XrLabel36})
        Me.GroupFooterBand2.HeightF = 54.99999!
        Me.GroupFooterBand2.Level = 1
        Me.GroupFooterBand2.Name = "GroupFooterBand2"
        '
        'XrLabel47
        '
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Bodega")})
        Me.XrLabel47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(175.6743!, 0.0!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(363.2288!, 18.0!)
        Me.XrLabel47.StyleName = "DataField"
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.Text = "XrLabel2"
        '
        'XrLabel46
        '
        Me.XrLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(34.375!, 0.0!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(140.3196!, 20.00002!)
        Me.XrLabel46.StyleName = "FieldCaption"
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.Text = "Totales de la Sucursal :"
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.SaldoNovencido")})
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(15.24502!, 35.00001!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(103.0097!, 18.0!)
        Me.XrLabel28.StyleName = "FieldCaption"
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel28.Summary = XrSummary1
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldoa30", "{0:C2}")})
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(130.7548!, 35.00001!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(60.11765!, 18.0!)
        Me.XrLabel29.StyleName = "FieldCaption"
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel29.Summary = XrSummary2
        Me.XrLabel29.Text = "XrLabel29"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo31a60", "{0:C2}")})
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(206.4975!, 35.00001!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(90.87663!, 18.0!)
        Me.XrLabel30.StyleName = "FieldCaption"
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel30.Summary = XrSummary3
        Me.XrLabel30.Text = "XrLabel30"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo61a90", "{0:C2}")})
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(315.8251!, 36.99999!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(73.91107!, 18.0!)
        Me.XrLabel31.StyleName = "FieldCaption"
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel31.Summary = XrSummary4
        Me.XrLabel31.Text = "XrLabel31"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo91a120", "{0:C2}")})
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(398.1559!, 35.00001!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(89.20599!, 18.0!)
        Me.XrLabel32.StyleName = "FieldCaption"
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel32.Summary = XrSummary5
        Me.XrLabel32.Text = "XrLabel32"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo121a180", "{0:C2}")})
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(501.5453!, 35.00001!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(89.26993!, 18.0!)
        Me.XrLabel33.StyleName = "FieldCaption"
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel33.Summary = XrSummary6
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo181a600", "{0:C2}")})
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(608.9234!, 35.00001!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(85.13!, 18.0!)
        Me.XrLabel34.StyleName = "FieldCaption"
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel34.Summary = XrSummary7
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldomas600", "{0:C2}")})
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(716.9433!, 35.00001!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(81.20691!, 18.0!)
        Me.XrLabel35.StyleName = "FieldCaption"
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel35.Summary = XrSummary8
        Me.XrLabel35.Text = "XrLabel35"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel36
        '
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.TotalCliente", "{0:C2}")})
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(809.7321!, 35.00001!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(80.26794!, 18.0!)
        Me.XrLabel36.StyleName = "FieldCaption"
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel36.Summary = XrSummary9
        Me.XrLabel36.Text = "XrLabel36"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportFooterBand1
        '
        Me.ReportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLabel27, Me.XrLabel37, Me.XrLabel38, Me.XrLabel39, Me.XrLabel40, Me.XrLabel41, Me.XrLabel42, Me.XrLabel43, Me.XrLabel44})
        Me.ReportFooterBand1.HeightF = 66.45832!
        Me.ReportFooterBand1.Name = "ReportFooterBand1"
        '
        'XrLabel45
        '
        Me.XrLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(19.76484!, 10.00001!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(140.3196!, 20.00002!)
        Me.XrLabel45.StyleName = "FieldCaption"
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.Text = "Totales Generales :"
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.TotalCliente", "{0:C2}")})
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(809.7322!, 38.45832!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(80.26794!, 18.0!)
        Me.XrLabel27.StyleName = "FieldCaption"
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel27.Summary = XrSummary10
        Me.XrLabel27.Text = "XrLabel36"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel37
        '
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldomas600", "{0:C2}")})
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(716.9434!, 38.45832!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(81.20691!, 18.0!)
        Me.XrLabel37.StyleName = "FieldCaption"
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel37.Summary = XrSummary11
        Me.XrLabel37.Text = "XrLabel35"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel38
        '
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo181a600", "{0:C2}")})
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(608.9235!, 38.45832!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(85.13!, 18.0!)
        Me.XrLabel38.StyleName = "FieldCaption"
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel38.Summary = XrSummary12
        Me.XrLabel38.Text = "XrLabel34"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel39
        '
        Me.XrLabel39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo121a180", "{0:C2}")})
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(501.5453!, 38.45832!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(89.26993!, 18.0!)
        Me.XrLabel39.StyleName = "FieldCaption"
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel39.Summary = XrSummary13
        Me.XrLabel39.Text = "XrLabel33"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel40
        '
        Me.XrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo91a120", "{0:C2}")})
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(398.1559!, 38.45832!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(89.20599!, 18.0!)
        Me.XrLabel40.StyleName = "FieldCaption"
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel40.Summary = XrSummary14
        Me.XrLabel40.Text = "XrLabel32"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel41
        '
        Me.XrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo61a90", "{0:C2}")})
        Me.XrLabel41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(315.8251!, 40.4583!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(73.91107!, 18.0!)
        Me.XrLabel41.StyleName = "FieldCaption"
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel41.Summary = XrSummary15
        Me.XrLabel41.Text = "XrLabel31"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel42
        '
        Me.XrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldo31a60", "{0:C2}")})
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(206.4975!, 38.45832!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(90.87663!, 18.0!)
        Me.XrLabel42.StyleName = "FieldCaption"
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel42.Summary = XrSummary16
        Me.XrLabel42.Text = "XrLabel30"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel43
        '
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.Saldoa30", "{0:C2}")})
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(130.7549!, 38.45832!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(60.11765!, 18.0!)
        Me.XrLabel43.StyleName = "FieldCaption"
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel43.Summary = XrSummary17
        Me.XrLabel43.Text = "XrLabel29"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel44
        '
        Me.XrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.SaldoNovencido")})
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(15.24506!, 38.45832!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(103.0097!, 18.0!)
        Me.XrLabel44.StyleName = "FieldCaption"
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel44.Summary = XrSummary18
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel49, Me.XrLabel48, Me.XrPageInfo4, Me.XrPageInfo3, Me.XrLabel4, Me.XrLabel5, Me.lblHasta, Me.lblCliente, Me.lblNombreReporte, Me.lblEmpresa, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        Me.PageHeader.HeightF = 177.5!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel49
        '
        Me.XrLabel49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfGetAntiguedadSaldos.CalculatedField1")})
        Me.XrLabel49.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(215.6208!, 99.12504!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(228.1584!, 22.99999!)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.Text = "XrLabel49"
        '
        'XrLabel48
        '
        Me.XrLabel48.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(125.1225!, 99.12504!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(81.37496!, 23.0!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.Text = "Moneda :"
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo4.Format = "Page {0} of {1}"
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(654.9127!, 17.125!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(81.74994!, 23.0!)
        Me.XrPageInfo4.StyleName = "PageInfo"
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(595.5376!, 40.12502!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(141.1249!, 23.0!)
        Me.XrPageInfo3.StyleName = "PageInfo"
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(124.329!, 76.12502!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(81.37496!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Cliente :"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(259.9543!, 53.125!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(94.8334!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Cortado al :"
        '
        'lblHasta
        '
        Me.lblHasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pdFechaFinal, "Text", "{0:dd/MM/yyyy}")})
        Me.lblHasta.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.LocationFloat = New DevExpress.Utils.PointFloat(378.4542!, 53.125!)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHasta.SizeF = New System.Drawing.SizeF(120.2498!, 23.0!)
        Me.lblHasta.StylePriority.UseFont = False
        '
        'pdFechaFinal
        '
        Me.pdFechaFinal.Description = "Parameter1"
        Me.pdFechaFinal.Name = "pdFechaFinal"
        Me.pdFechaFinal.Type = GetType(Date)
        Me.pdFechaFinal.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.CanGrow = False
        Me.lblCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psCliente, "Text", "")})
        Me.lblCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.LocationFloat = New DevExpress.Utils.PointFloat(215.6208!, 76.12502!)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCliente.SizeF = New System.Drawing.SizeF(538.5416!, 23.0!)
        Me.lblCliente.StylePriority.UseFont = False
        '
        'psCliente
        '
        Me.psCliente.Description = "Parameter1"
        Me.psCliente.Name = "psCliente"
        Me.psCliente.Visible = False
        '
        'lblNombreReporte
        '
        Me.lblNombreReporte.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreReporte.LocationFloat = New DevExpress.Utils.PointFloat(241.1284!, 30.125!)
        Me.lblNombreReporte.Name = "lblNombreReporte"
        Me.lblNombreReporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNombreReporte.SizeF = New System.Drawing.SizeF(246.2336!, 23.00001!)
        Me.lblNombreReporte.StylePriority.UseFont = False
        Me.lblNombreReporte.StylePriority.UseTextAlignment = False
        Me.lblNombreReporte.Text = "Análisis de Vencimiento"
        Me.lblNombreReporte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblEmpresa
        '
        Me.lblEmpresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psEmpresa, "Text", "")})
        Me.lblEmpresa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(189.6207!, 7.124996!)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblEmpresa.SizeF = New System.Drawing.SizeF(344.7917!, 23.0!)
        Me.lblEmpresa.StylePriority.UseFont = False
        Me.lblEmpresa.StylePriority.UseTextAlignment = False
        Me.lblEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'psEmpresa
        '
        Me.psEmpresa.Description = "Parameter1"
        Me.psEmpresa.Name = "psEmpresa"
        Me.psEmpresa.Visible = False
        '
        'piIDBodega
        '
        Me.piIDBodega.Description = "Parameter1"
        Me.piIDBodega.Name = "piIDBodega"
        Me.piIDBodega.Type = GetType(Integer)
        Me.piIDBodega.ValueInfo = "0"
        Me.piIDBodega.Visible = False
        '
        'piIDCliente
        '
        Me.piIDCliente.Description = "Parameter1"
        Me.piIDCliente.Name = "piIDCliente"
        Me.piIDCliente.Type = GetType(Integer)
        Me.piIDCliente.ValueInfo = "0"
        Me.piIDCliente.Visible = False
        '
        'piConsolidaSucursal
        '
        Me.piConsolidaSucursal.Description = "Parameter1"
        Me.piConsolidaSucursal.Name = "piConsolidaSucursal"
        Me.piConsolidaSucursal.Type = GetType(Short)
        Me.piConsolidaSucursal.ValueInfo = "0"
        Me.piConsolidaSucursal.Visible = False
        '
        'piEnDolar
        '
        Me.piEnDolar.Description = "Parameter1"
        Me.piEnDolar.Name = "piEnDolar"
        Me.piEnDolar.Type = GetType(Short)
        Me.piEnDolar.ValueInfo = "0"
        Me.piEnDolar.Visible = False
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "ccfGetAntiguedadSaldos"
        Me.CalculatedField1.DisplayName = "Moneda"
        Me.CalculatedField1.Expression = "Iif([Parameters.piEnDolar]=1,'DOLAR'  ,'CORDOBA' )"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'rptAnalisisVencimiento
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderSucursal, Me.GroupHeaderCliente, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.GroupFooterBand2, Me.ReportFooterBand1, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "ccfGetAntiguedadSaldos"
        Me.DataSource = Me.SqlDataSource1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 103, 100, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.psCliente, Me.psEmpresa, Me.piIDBodega, Me.piIDCliente, Me.pdFechaFinal, Me.piConsolidaSucursal, Me.piEnDolar})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeaderSucursal As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderCliente As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNombreReporte As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psCliente As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents psEmpresa As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents piIDBodega As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents piIDCliente As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pdFechaFinal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents piConsolidaSucursal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents piEnDolar As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
End Class
