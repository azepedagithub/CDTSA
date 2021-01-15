<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDocumentosCobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDocumentosCobrar))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblEmpresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.psEmpresa = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblNombreReporte = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.psCliente = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblHasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.pdFechaFinal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.IDCliente = New DevExpress.XtraReports.UI.CalculatedField()
        Me.piIDCliente = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSaldoFavorLocal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSaldoFavorDolar = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel32, Me.XrLabel7, Me.XrLabel8, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel9})
        Me.Detail.HeightF = 28.04165!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.IDCLASE")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 4.999987!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(57.50002!, 18.0!)
        Me.XrLabel7.StyleName = "DataField"
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.DOCUMENTO")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(76.29172!, 4.999987!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(125.7916!, 18.0!)
        Me.XrLabel8.StyleName = "DataField"
        Me.XrLabel8.Text = "XrLabel8"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.DIASVENCIDOS")})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(360.8752!, 3.000005!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(68.95831!, 18.0!)
        Me.XrLabel10.StyleName = "DataField"
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SALDO", "{0:n2}")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(441.0836!, 3.000005!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel11.StyleName = "DataField"
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SALDODOLAR", "{0:n2}")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(552.417!, 3.000005!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(87.58301!, 18.0!)
        Me.XrLabel12.StyleName = "DataField"
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.Vencimiento", "{0:dd/MM/yyyy}")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(254.1252!, 3.000005!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(93.25003!, 18.0!)
        Me.XrLabel9.StyleName = "DataField"
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 67.66667!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 56.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_CED2_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "ccfDocumentosxCobrar"
        QueryParameter1.Name = "@IDCliente"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.piIDCliente]", GetType(Integer))
        QueryParameter2.Name = "@FECHACORTE"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.pdFechaFinal]", GetType(Date))
        QueryParameter3.Name = "@IDDebito"
        QueryParameter3.Type = GetType(Integer)
        QueryParameter3.ValueInfo = "0"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "ccfDocumentosxCobrar"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(5.95843!, 102.2083!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(65.12501!, 18.0!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.Text = "IDClase"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(76.29172!, 102.2083!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(83.70839!, 18.0!)
        Me.XrLabel2.StyleName = "FieldCaption"
        Me.XrLabel2.Text = "Documento"
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(265.2502!, 102.2083!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(93.25001!, 18.0!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Vencimiento"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(358.5002!, 102.2083!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(74.5!, 18.0!)
        Me.XrLabel4.StyleName = "FieldCaption"
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Vencidos"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(471.2086!, 102.2083!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(67.20834!, 18.0!)
        Me.XrLabel5.StyleName = "FieldCaption"
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Saldo C$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(580.0833!, 102.2083!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(59.9166!, 18.0!)
        Me.XrLabel6.StyleName = "FieldCaption"
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Saldo $"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 120.2083!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.HeightF = 0.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel33, Me.XrLabel28, Me.XrLabel27, Me.lblEmpresa, Me.lblNombreReporte, Me.lblCliente, Me.lblHasta, Me.XrLabel13, Me.XrLabel15, Me.XrPageInfo3, Me.XrPageInfo4, Me.XrLabel3, Me.XrLabel5, Me.XrLabel4, Me.XrLabel6, Me.XrLabel2, Me.XrLabel1, Me.XrLine1})
        Me.PageHeader.HeightF = 130.2083!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psEmpresa, "Text", "")})
        Me.lblEmpresa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(65.29169!, 0.0!)
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
        'lblNombreReporte
        '
        Me.lblNombreReporte.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreReporte.LocationFloat = New DevExpress.Utils.PointFloat(142.5418!, 23.0!)
        Me.lblNombreReporte.Name = "lblNombreReporte"
        Me.lblNombreReporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNombreReporte.SizeF = New System.Drawing.SizeF(183.6251!, 23.00001!)
        Me.lblNombreReporte.StylePriority.UseFont = False
        Me.lblNombreReporte.StylePriority.UseTextAlignment = False
        Me.lblNombreReporte.Text = "Documentos por Cobrar"
        Me.lblNombreReporte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblCliente
        '
        Me.lblCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psCliente, "Text", "")})
        Me.lblCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.LocationFloat = New DevExpress.Utils.PointFloat(91.29178!, 69.00001!)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCliente.SizeF = New System.Drawing.SizeF(538.5416!, 23.0!)
        Me.lblCliente.StylePriority.UseFont = False
        '
        'psCliente
        '
        Me.psCliente.Description = "Parameter1"
        Me.psCliente.Name = "psCliente"
        Me.psCliente.ValueInfo = "4"
        Me.psCliente.Visible = False
        '
        'lblHasta
        '
        Me.lblHasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.pdFechaFinal, "Text", "{0:dd/MM/yyyy}")})
        Me.lblHasta.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.LocationFloat = New DevExpress.Utils.PointFloat(230.4587!, 46.0!)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHasta.SizeF = New System.Drawing.SizeF(95.70813!, 23.0!)
        Me.lblHasta.StylePriority.UseFont = False
        '
        'pdFechaFinal
        '
        Me.pdFechaFinal.Description = "Parameter1"
        Me.pdFechaFinal.Name = "pdFechaFinal"
        Me.pdFechaFinal.Type = GetType(Date)
        Me.pdFechaFinal.ValueInfo = "02/13/2020 09:12:17"
        Me.pdFechaFinal.Visible = False
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(135.6253!, 46.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(94.8334!, 23.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Cortado al :"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 69.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(81.37496!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "Cliente :"
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(471.2086!, 33.00001!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(141.1249!, 23.0!)
        Me.XrPageInfo3.StyleName = "PageInfo"
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo4.Format = "Page {0} of {1}"
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(530.5836!, 10.00001!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(81.74994!, 23.0!)
        Me.XrPageInfo4.StyleName = "PageInfo"
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel34, Me.lblSaldoFavorDolar, Me.lblSaldoFavorLocal, Me.XrLabel29, Me.XrLabel23, Me.XrLabel22, Me.XrLabel20, Me.XrLabel14, Me.XrLine4, Me.XrLine3, Me.XrLabel26, Me.XrLine2, Me.XrLabel25, Me.XrLabel24, Me.XrLabel21, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16})
        Me.ReportFooter.HeightF = 273.9584!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(248.6255!, 0.0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(391.0411!, 12.99998!)
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(340.0416!, 203.9999!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(220.9585!, 23.0!)
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(358.5002!, 227.0!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(174.4583!, 42.79166!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Revisado por" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crédito y Cobranza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00002!, 203.9999!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(184.5001!, 23.0!)
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(47.62511!, 227.0!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(112.375!, 23.0!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.Text = "Elaborado por "
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(1.833391!, 150.9584!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(628.0!, 35.49998!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "Nota : Estimado Cliente, evite manchar su record crediticio, pague sus facturas a" & _
    " Tiempo."
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(248.6255!, 68.79164!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(162.2083!, 23.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.Text = "Totales No Vencidos   :"
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(248.6255!, 45.79166!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(162.2083!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.Text = "Totales Vencidos        :"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SALDODOLAR")})
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(552.417!, 21.45834!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(86.33328!, 18.0!)
        Me.XrLabel18.StyleName = "DataField"
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel18.Summary = XrSummary1
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SALDO")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(441.834!, 21.45834!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(99.99997!, 18.0!)
        Me.XrLabel17.StyleName = "DataField"
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary2
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(246.9589!, 21.45834!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(163.8749!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "Totales por Cobrar      :"
        '
        'IDCliente
        '
        Me.IDCliente.DataMember = "ccfDocumentosxCobrar"
        Me.IDCliente.Name = "IDCliente"
        '
        'piIDCliente
        '
        Me.piIDCliente.Description = "Parameter1"
        Me.piIDCliente.Name = "piIDCliente"
        Me.piIDCliente.Type = GetType(Integer)
        Me.piIDCliente.ValueInfo = "0"
        Me.piIDCliente.Visible = False
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoVencidoLOCAL", "{0:n2}")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(441.834!, 45.79163!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoVencidoDOLAR", "{0:n2}")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(552.417!, 45.79163!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(85.58289!, 23.0!)
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoNoVencidoLocal", "{0:n2}")})
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(441.834!, 68.79164!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoNoVencidoDolar", "{0:n2}")})
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(552.417!, 68.79161!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(85.58289!, 23.0!)
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.TipoCambioCorte", "{0:n4}")})
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(371.5418!, 46.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(71.875!, 23.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "XrLabel27"
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(326.1669!, 46.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(44.12476!, 23.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.Text = "T/C:"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(5.95843!, 116.6667!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(209.7082!, 23.00001!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.Text = "El Cliente tiene a Favor en C$ :"
        '
        'lblSaldoFavorLocal
        '
        Me.lblSaldoFavorLocal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoCreditoAFavorLocal", "{0:n2}")})
        Me.lblSaldoFavorLocal.LocationFloat = New DevExpress.Utils.PointFloat(215.6666!, 116.6667!)
        Me.lblSaldoFavorLocal.Name = "lblSaldoFavorLocal"
        Me.lblSaldoFavorLocal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblSaldoFavorLocal.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lblSaldoFavorLocal.StylePriority.UseTextAlignment = False
        Me.lblSaldoFavorLocal.Text = "lblSaldoFavorLocal"
        Me.lblSaldoFavorLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblSaldoFavorDolar
        '
        Me.lblSaldoFavorDolar.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.SaldoCreditoAFavorDolar", "{0:n2}")})
        Me.lblSaldoFavorDolar.LocationFloat = New DevExpress.Utils.PointFloat(446.6252!, 116.6666!)
        Me.lblSaldoFavorDolar.Name = "lblSaldoFavorDolar"
        Me.lblSaldoFavorDolar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblSaldoFavorDolar.SizeF = New System.Drawing.SizeF(86.33325!, 23.00001!)
        Me.lblSaldoFavorDolar.StylePriority.UseTextAlignment = False
        Me.lblSaldoFavorDolar.Text = "lblSaldoFavorDolar"
        Me.lblSaldoFavorDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ccfDocumentosxCobrar.Simbolo")})
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(202.0834!, 4.999987!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(28.37535!, 18.0!)
        Me.XrLabel32.Text = "XrLabel32"
        '
        'XrLabel33
        '
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(190.625!, 102.2083!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(62.16687!, 18.0!)
        Me.XrLabel33.StyleName = "FieldCaption"
        Me.XrLabel33.Text = "Moneda"
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(332.1258!, 116.6666!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(111.291!, 23.00001!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.Text = "y en moneda $ :"
        '
        'rptDocumentosCobrar
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.PageHeader, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.IDCliente})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "ccfDocumentosxCobrar"
        Me.DataSource = Me.SqlDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 68, 56)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.psEmpresa, Me.psCliente, Me.pdFechaFinal, Me.piIDCliente})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents lblEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psEmpresa As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblNombreReporte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psCliente As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblHasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pdFechaFinal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IDCliente As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents piIDCliente As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaldoFavorDolar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSaldoFavorLocal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
End Class
