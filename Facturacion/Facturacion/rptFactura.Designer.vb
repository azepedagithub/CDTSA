<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptFactura
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFactura))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.IDFactura = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblMesFactura = New DevExpress.XtraReports.UI.XRLabel()
        Me.pMontoenLetras = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.MontoenLetra = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.MesFactura = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DiaFactura = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.AnioFactura = New DevExpress.XtraReports.UI.CalculatedField()
        Me.HoraFactura = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeaderProducto = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'IDFactura
        '
        Me.IDFactura.Name = "IDFactura"
        Me.IDFactura.Type = GetType(Long)
        Me.IDFactura.ValueInfo = "6"
        Me.IDFactura.Visible = False
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Descuento")})
        Me.XrLabel8.Dpi = 96.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 24.07999!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(62.0!, 14.08!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel8.Summary = XrSummary1
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblMesFactura
        '
        Me.lblMesFactura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Fecha", "{0:MM}")})
        Me.lblMesFactura.Dpi = 96.0!
        Me.lblMesFactura.LocationFloat = New DevExpress.Utils.PointFloat(508.0!, 10.0!)
        Me.lblMesFactura.Name = "lblMesFactura"
        Me.lblMesFactura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lblMesFactura.SizeF = New System.Drawing.SizeF(35.0!, 22.08!)
        '
        'pMontoenLetras
        '
        Me.pMontoenLetras.Description = "pMontoenLetras"
        Me.pMontoenLetras.Name = "pMontoenLetras"
        Me.pMontoenLetras.Visible = False
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.TotalFinal", "{0:#,##0.00}")})
        Me.XrLabel9.Dpi = 96.0!
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(565.0!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(58.0!, 17.08!)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'MontoenLetra
        '
        Me.MontoenLetra.Expression = "[Parameters.pMontoenLetras]"
        Me.MontoenLetra.Name = "MontoenLetra"
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DescrUnidad", "{0:#,##0.00}")})
        Me.XrLabel14.Dpi = 96.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(320.9602!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(73.0!, 17.08!)
        Me.XrLabel14.StylePriority.UseFont = False
        '
        'MesFactura
        '
        Me.MesFactura.DisplayName = "MesFactura"
        Me.MesFactura.Expression = "GetMonth([Fecha])"
        Me.MesFactura.Name = "MesFactura"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.IDCliente")})
        Me.XrLabel15.Dpi = 96.0!
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(447.0!, 46.08!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(96.0!, 22.08!)
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Factura")})
        Me.XrLabel1.Dpi = 96.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(352.6!, 10.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(96.0!, 22.08!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Cantidad", "{0:n}")})
        Me.XrLabel2.Dpi = 96.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(65.60001!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(45.0!, 17.08!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Direccion")})
        Me.XrLabel17.Dpi = 96.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(43.60001!, 33.08!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(204.0!, 35.08!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AnioFactura")})
        Me.XrLabel23.Dpi = 96.0!
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 10.0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(41.0!, 22.08!)
        Me.XrLabel23.Text = "XrLabel23"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_ceda_Connection 1"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "fafPrintFactura"
        QueryParameter1.Name = "@IDFactura"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.IDFactura]", GetType(Long))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "fafPrintFactura"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'DiaFactura
        '
        Me.DiaFactura.DataMember = "fafPrintFactura"
        Me.DiaFactura.Expression = "GetDay([Fecha])"
        Me.DiaFactura.Name = "DiaFactura"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.IDProducto")})
        Me.XrLabel5.Dpi = 96.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(55.60001!, 17.08!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.TotalFinal")})
        Me.XrLabel12.Dpi = 96.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 66.31995!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(62.0!, 14.08!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel12.Summary = XrSummary2
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MontoenLetra")})
        Me.XrLabel13.Dpi = 96.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(25.60001!, 44.23999!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(423.0!, 22.08!)
        Me.XrLabel13.StylePriority.UseFont = False
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "HoraFactura", "{0:hh:mm tt}")})
        Me.XrLabel24.Dpi = 96.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 46.08!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(71.0!, 22.08!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "XrLabel24"
        '
        'XrLabel3
        '
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DescrProducto")})
        Me.XrLabel3.Dpi = 96.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(122.5602!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(168.4!, 17.08!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DescuentoEspecial")})
        Me.XrLabel10.Dpi = 96.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 38.15997!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(62.0!, 14.08!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel10.Summary = XrSummary3
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DescrPlazo")})
        Me.XrLabel25.Dpi = 96.0!
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(259.0!, 46.08!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(56.96021!, 22.08!)
        Me.XrLabel25.Text = "XrLabel25"
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Nombre")})
        Me.XrLabel16.Dpi = 96.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(25.60001!, 10.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(265.3602!, 22.08!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "XrLabel16"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.Detail.Dpi = 96.0!
        Me.Detail.HeightF = 39.15999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport1
        '
        Me.XrSubreport1.Dpi = 96.0!
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("pIDFactura", Nothing, "fafPrintFactura.IDFactura"))
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("pIDProducto", Nothing, "fafPrintFactura.IDProducto"))
        Me.XrSubreport1.ReportSource = New Facturacion.rptLotesFactura()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(623.0!, 39.15999!)
        '
        'AnioFactura
        '
        Me.AnioFactura.Expression = "GetYear([Fecha])"
        Me.AnioFactura.Name = "AnioFactura"
        '
        'HoraFactura
        '
        Me.HoraFactura.Expression = "[Dateinsert]"
        Me.HoraFactura.Name = "HoraFactura"
        '
        'GroupHeaderProducto
        '
        Me.GroupHeaderProducto.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel5, Me.XrLabel7, Me.XrLabel3, Me.XrLabel2, Me.XrLabel9, Me.XrLabel4})
        Me.GroupHeaderProducto.Dpi = 96.0!
        Me.GroupHeaderProducto.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IDProducto", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderProducto.HeightF = 22.08!
        Me.GroupHeaderProducto.Name = "GroupHeaderProducto"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.SubTotal", "{0:#,##0.00}")})
        Me.XrLabel7.Dpi = 96.0!
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(482.0!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(72.0!, 17.08!)
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Precio", "{0:#,##0.00}")})
        Me.XrLabel4.Dpi = 96.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(404.9602!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(57.0!, 17.08!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel25, Me.XrLabel24, Me.XrLabel11, Me.XrLabel23, Me.lblMesFactura, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel1})
        Me.TopMargin.Dpi = 96.0!
        Me.TopMargin.HeightF = 107.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DescrDepto")})
        Me.XrLabel11.Dpi = 96.0!
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(333.9602!, 46.08!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(83.0!, 22.08!)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.DiaFactura")})
        Me.XrLabel18.Dpi = 96.0!
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(465.0!, 10.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(29.0!, 22.08!)
        Me.XrLabel18.Text = "XrLabel18"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel13, Me.XrLabel12, Me.XrLabel10, Me.XrLabel8, Me.XrLabel6})
        Me.BottomMargin.Dpi = 96.0!
        Me.BottomMargin.HeightF = 96.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.Impuesto")})
        Me.XrLabel19.Dpi = 96.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 52.23996!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(62.0!, 14.08!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel19.Summary = XrSummary4
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafPrintFactura.SubTotal")})
        Me.XrLabel6.Dpi = 96.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 10.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(62.0!, 14.08!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel6.Summary = XrSummary5
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rptFactura
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderProducto})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.MontoenLetra, Me.DiaFactura, Me.MesFactura, Me.AnioFactura, Me.HoraFactura})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "fafPrintFactura"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 96.0!
        Me.FilterString = "[IDProducto] = [IDProducto] And [IDFactura] = [IDFactura]"
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(96, 96, 107, 96)
        Me.PageHeight = 1056
        Me.PageWidth = 816
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pMontoenLetras, Me.IDFactura})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents IDFactura As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMesFactura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pMontoenLetras As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents MontoenLetra As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents MesFactura As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents DiaFactura As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents AnioFactura As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents HoraFactura As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupHeaderProducto As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
End Class
