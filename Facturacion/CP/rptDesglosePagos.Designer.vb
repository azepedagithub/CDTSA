<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDesglosePagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDesglosePagos))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.GroupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.psEmpresa = New DevExpress.XtraReports.Parameters.Parameter()
        Me.psProveedor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.piIDProveedor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pdFechaInicial = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pdFechaFinal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDesde = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblHasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNombreReporte = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblEmpresa = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel37, Me.XrLabel32, Me.XrLabel13, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22})
        Me.Detail.Dpi = 96.0!
        Me.Detail.HeightF = 18.67575!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.FechaCredito", "{0:dd/MM/yyyy}")})
        Me.XrLabel37.Dpi = 96.0!
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(270.1823!, 0.0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(59.89021!, 14.4!)
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.MonedaCredito", "{0:#.00}")})
        Me.XrLabel32.Dpi = 96.0!
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(330.0725!, 0.0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(65.80798!, 14.4!)
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.IDClaseCredito")})
        Me.XrLabel13.Dpi = 96.0!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(51.82534!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(32.03913!, 14.4!)
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.IDCredito")})
        Me.XrLabel17.Dpi = 96.0!
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(97.36063!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(70.10944!, 14.4!)
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.DOCCREDITO")})
        Me.XrLabel18.Dpi = 96.0!
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(168.9532!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(86.85513!, 14.4!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.DiasVencidos")})
        Me.XrLabel19.Dpi = 96.0!
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(489.3553!, 0.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(38.05734!, 14.4!)
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.VENCIMIENTO", "{0:dd/MM/yyyy}")})
        Me.XrLabel20.Dpi = 96.0!
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(403.0263!, 0.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(65.38638!, 14.4!)
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADO", "{0:n2}")})
        Me.XrLabel21.Dpi = 96.0!
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(547.9285!, 0.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(82.15503!, 14.4!)
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADODOLAR", "{0:n2}")})
        Me.XrLabel22.Dpi = 96.0!
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(644.0354!, 0.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(70.11383!, 14.4!)
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 96.0!
        Me.TopMargin.HeightF = 28.14893!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 96.0!
        Me.BottomMargin.HeightF = 96.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ceda_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "cpprptDesglosePagos"
        QueryParameter1.Name = "@FECHAINICIAL"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.pdFechaInicial]", GetType(Date))
        QueryParameter2.Name = "@FECHAFINAL"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.pdFechaFinal]", GetType(Date))
        QueryParameter3.Name = "@IDProveedor"
        QueryParameter3.Type = GetType(Integer)
        QueryParameter3.ValueInfo = "0"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "cpprptDesglosePagos"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel2, Me.XrLabel1, Me.XrPanel1})
        Me.GroupHeaderBand1.Dpi = 96.0!
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DOCDEBITO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 32.0!
        Me.GroupHeaderBand1.Level = 1
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.StylePriority.UseBackColor = False
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.IDClaseDebito")})
        Me.XrLabel6.Dpi = 96.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(108.4244!, 10.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(49.46353!, 14.4!)
        Me.XrLabel6.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.DOCDEBITO")})
        Me.XrLabel2.Dpi = 96.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(179.4116!, 10.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(76.39671!, 14.4!)
        Me.XrLabel2.StyleName = "DataField"
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 96.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(15.53233!, 10.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(68.33215!, 14.4!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Aplicado por"
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel31, Me.XrLabel14, Me.XrLabel15})
        Me.XrPanel1.Dpi = 96.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(1.702133!, 2.553192!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(722.2979!, 29.44681!)
        Me.XrPanel1.StylePriority.UseBackColor = False
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel5
        '
        Me.XrLabel5.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Dpi = 96.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(401.4129!, 7.446808!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(65.38638!, 14.4!)
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Total Pago"
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.MonedaDebito")})
        Me.XrLabel31.Dpi = 96.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(328.3704!, 7.446808!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(66.14993!, 17.28!)
        Me.XrLabel31.StyleName = "DataField"
        Me.XrLabel31.StylePriority.UseFont = False
        '
        'XrLabel14
        '
        Me.XrLabel14.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.FechaDebito", "{0:dd/MM/yyyy}")})
        Me.XrLabel14.Dpi = 96.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(268.4802!, 7.446808!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(56.94431!, 14.4!)
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseFont = False
        '
        'XrLabel15
        '
        Me.XrLabel15.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.TotalDebito", "{0:n2}")})
        Me.XrLabel15.Dpi = 96.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(487.6531!, 7.446808!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(83.18475!, 14.4!)
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeaderBand2
        '
        Me.GroupHeaderBand2.Dpi = 96.0!
        Me.GroupHeaderBand2.HeightF = 0.0!
        Me.GroupHeaderBand2.Name = "GroupHeaderBand2"
        Me.GroupHeaderBand2.StyleName = "FieldCaption"
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 96.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(45.11633!, 105.9328!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(38.74814!, 17.28001!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Clase"
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 96.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(97.36063!, 105.9328!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(70.10941!, 17.28001!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "IDCrédito"
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 96.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(179.4116!, 105.9328!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(76.39673!, 17.28001!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Documento"
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 96.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(468.5015!, 105.9328!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(69.21344!, 17.28!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Dias Venc"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 96.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(381.8128!, 105.9328!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(76.38635!, 17.28!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Vencimiento"
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 96.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(547.9283!, 105.9328!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(82.15509!, 15.35997!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Aplicado C$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 96.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(644.1846!, 105.9328!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(69.9646!, 15.35999!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Aplicado  $"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Dpi = 96.0!
        Me.PageFooterBand1.HeightF = 45.10638!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'GroupFooterBand1
        '
        Me.GroupFooterBand1.HeightF = 1.0!
        Me.GroupFooterBand1.Name = "GroupFooterBand1"
        '
        'GroupFooterBand2
        '
        Me.GroupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel24, Me.XrLabel25, Me.XrLabel26})
        Me.GroupFooterBand2.Dpi = 96.0!
        Me.GroupFooterBand2.HeightF = 19.0!
        Me.GroupFooterBand2.Level = 1
        Me.GroupFooterBand2.Name = "GroupFooterBand2"
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADO", "{0:C2}")})
        Me.XrLabel24.Dpi = 96.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(547.9284!, 1.719997!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(82.15503!, 17.28!)
        Me.XrLabel24.StyleName = "FieldCaption"
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel24.Summary = XrSummary1
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADODOLAR")})
        Me.XrLabel25.Dpi = 96.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(644.0355!, 0.0!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(70.11377!, 17.28!)
        Me.XrLabel25.StyleName = "FieldCaption"
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel25.Summary = XrSummary2
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel26
        '
        Me.XrLabel26.Dpi = 96.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(389.1272!, 0.0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(138.2854!, 17.28!)
        Me.XrLabel26.StyleName = "FieldCaption"
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "Totales Aplicados en el Pago"
        '
        'ReportFooterBand1
        '
        Me.ReportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel28, Me.XrLabel29})
        Me.ReportFooterBand1.Dpi = 96.0!
        Me.ReportFooterBand1.HeightF = 38.02127!
        Me.ReportFooterBand1.Name = "ReportFooterBand1"
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADO", "{0:C2}")})
        Me.XrLabel27.Dpi = 96.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(547.9285!, 10.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(82.15497!, 17.28!)
        Me.XrLabel27.StyleName = "FieldCaption"
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel27.Summary = XrSummary3
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cpprptDesglosePagos.APLICADODOLAR", "{0:C2}")})
        Me.XrLabel28.Dpi = 96.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(644.0355!, 10.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(70.11383!, 17.28!)
        Me.XrLabel28.StyleName = "FieldCaption"
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel28.Summary = XrSummary4
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel29
        '
        Me.XrLabel29.Dpi = 96.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(434.5105!, 10.0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(92.90211!, 17.28!)
        Me.XrLabel29.StyleName = "FieldCaption"
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.Text = "Totales Generales"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        '
        'psEmpresa
        '
        Me.psEmpresa.Description = "Parameter1"
        Me.psEmpresa.Name = "psEmpresa"
        Me.psEmpresa.Visible = False
        '
        'psProveedor
        '
        Me.psProveedor.Description = "Parameter1"
        Me.psProveedor.Name = "psProveedor"
        Me.psProveedor.Visible = False
        '
        'piIDProveedor
        '
        Me.piIDProveedor.Description = "Parameter1"
        Me.piIDProveedor.Name = "piIDProveedor"
        Me.piIDProveedor.Type = GetType(Integer)
        Me.piIDProveedor.ValueInfo = "1"
        Me.piIDProveedor.Visible = False
        '
        'pdFechaInicial
        '
        Me.pdFechaInicial.Description = "Parameter1"
        Me.pdFechaInicial.Name = "pdFechaInicial"
        Me.pdFechaInicial.Type = GetType(Date)
        Me.pdFechaInicial.ValueInfo = "2020-02-01"
        Me.pdFechaInicial.Visible = False
        '
        'pdFechaFinal
        '
        Me.pdFechaFinal.Description = "Parameter1"
        Me.pdFechaFinal.Name = "pdFechaFinal"
        Me.pdFechaFinal.Type = GetType(Date)
        Me.pdFechaFinal.ValueInfo = "02/27/2020 10:21:01"
        Me.pdFechaFinal.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel36, Me.XrLabel33, Me.lblDesde, Me.lblHasta, Me.XrLabel23, Me.XrLabel30, Me.XrPageInfo4, Me.XrPageInfo3, Me.XrLabel16, Me.lblCliente, Me.lblNombreReporte, Me.lblEmpresa, Me.XrLabel8, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel7, Me.XrLabel3})
        Me.PageHeader.Dpi = 96.0!
        Me.PageHeader.HeightF = 133.2128!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel36
        '
        Me.XrLabel36.Dpi = 96.0!
        Me.XrLabel36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(270.1823!, 105.9328!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(43.97432!, 17.28001!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.Text = "Fecha"
        '
        'XrLabel33
        '
        Me.XrLabel33.Dpi = 96.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(329.7306!, 105.9328!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(52.08224!, 17.28!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.Text = "Moneda"
        '
        'lblDesde
        '
        Me.lblDesde.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pdFechaInicial, "Text", "{0:dd/MM/yyyy}")})
        Me.lblDesde.Dpi = 96.0!
        Me.lblDesde.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.LocationFloat = New DevExpress.Utils.PointFloat(218.1532!, 44.16!)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblDesde.SizeF = New System.Drawing.SizeF(92.60004!, 22.08!)
        Me.lblDesde.StylePriority.UseFont = False
        '
        'lblHasta
        '
        Me.lblHasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pdFechaFinal, "Text", "{0:dd/MM/yyyy}")})
        Me.lblHasta.Dpi = 96.0!
        Me.lblHasta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.LocationFloat = New DevExpress.Utils.PointFloat(373.5532!, 44.16!)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblHasta.SizeF = New System.Drawing.SizeF(115.4398!, 22.08!)
        Me.lblHasta.StylePriority.UseFont = False
        '
        'XrLabel23
        '
        Me.XrLabel23.Dpi = 96.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(168.9532!, 44.16!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(49.2!, 22.08!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.Text = "Desde "
        '
        'XrLabel30
        '
        Me.XrLabel30.Dpi = 96.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(322.2732!, 44.16!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(47.48004!, 22.08!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.Text = "Hasta"
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Dpi = 96.0!
        Me.XrPageInfo4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo4.Format = "Page {0} of {1}"
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(621.5682!, 10.0!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(78.47995!, 22.08!)
        Me.XrPageInfo4.StyleName = "PageInfo"
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Dpi = 96.0!
        Me.XrPageInfo3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(564.5683!, 32.08002!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(135.4799!, 22.08!)
        Me.XrPageInfo3.StyleName = "PageInfo"
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 96.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(140.9033!, 66.24002!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(82.16986!, 22.08!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "Proveedor :"
        '
        'lblCliente
        '
        Me.lblCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psProveedor, "Text", "")})
        Me.lblCliente.Dpi = 96.0!
        Me.lblCliente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.LocationFloat = New DevExpress.Utils.PointFloat(226.4099!, 66.24003!)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblCliente.SizeF = New System.Drawing.SizeF(468.4535!, 22.07999!)
        Me.lblCliente.StylePriority.UseFont = False
        '
        'lblNombreReporte
        '
        Me.lblNombreReporte.Dpi = 96.0!
        Me.lblNombreReporte.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreReporte.LocationFloat = New DevExpress.Utils.PointFloat(226.4099!, 22.07999!)
        Me.lblNombreReporte.Name = "lblNombreReporte"
        Me.lblNombreReporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblNombreReporte.SizeF = New System.Drawing.SizeF(206.9295!, 22.08001!)
        Me.lblNombreReporte.StylePriority.UseFont = False
        Me.lblNombreReporte.StylePriority.UseTextAlignment = False
        Me.lblNombreReporte.Text = "Desglose de Pagos Realizados"
        Me.lblNombreReporte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblEmpresa
        '
        Me.lblEmpresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psEmpresa, "Text", "")})
        Me.lblEmpresa.Dpi = 96.0!
        Me.lblEmpresa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(152.9033!, 0.0!)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblEmpresa.SizeF = New System.Drawing.SizeF(331.0!, 22.08!)
        Me.lblEmpresa.StylePriority.UseFont = False
        Me.lblEmpresa.StylePriority.UseTextAlignment = False
        Me.lblEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'rptDesglosePagos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderBand1, Me.GroupHeaderBand2, Me.PageFooterBand1, Me.GroupFooterBand2, Me.ReportFooterBand1, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "cpprptDesglosePagos"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 96.0!
        Me.Margins = New System.Drawing.Printing.Margins(45, 47, 28, 96)
        Me.PageHeight = 1056
        Me.PageWidth = 816
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.psEmpresa, Me.psProveedor, Me.piIDProveedor, Me.pdFechaInicial, Me.pdFechaFinal})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents GroupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents psEmpresa As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents psProveedor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents piIDProveedor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pdFechaInicial As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pdFechaFinal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNombreReporte As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDesde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
End Class
