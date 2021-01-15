<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTablaBonificacionPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptTablaBonificacionPrecios))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.psMoneda = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.psNivel = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.psEmpresa = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLine2})
        Me.Detail.HeightF = 34.37502!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.IDProducto")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(58.71315!, 17.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel16
        '
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Descr")})
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(58.71315!, 10.00001!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(257.2264!, 17.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel17
        '
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Presentacion")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(315.9395!, 10.00001!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(115.3585!, 17.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel18
        '
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Generico")})
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(443.4439!, 10.00001!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(92.86008!, 17.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Precio", "{0:n2}")})
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(546.8886!, 10.00001!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(71.03842!, 17.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Publico", "{0:n2}")})
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(617.927!, 10.00001!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(76.02606!, 17.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Escala1", "{0:n2}")})
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(701.6013!, 10.00001!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(63.37103!, 17.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.Text = "XrLabel21"
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Escala2")})
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(767.554!, 10.00001!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(61.28784!, 17.0!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.Text = "XrLabel22"
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Escala3")})
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(834.2146!, 10.00001!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(61.83099!, 17.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.Text = "XrLabel23"
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Escala4")})
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(906.4623!, 10.00001!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(78.53772!, 17.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "XrLabel24"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 65.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 92.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_CED2_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "fafprintTablaBonificacionPrecios"
        QueryParameter1.Name = "@Proveedor"
        QueryParameter1.Type = GetType(Integer)
        QueryParameter1.ValueInfo = "0"
        QueryParameter2.Name = "@IDNivelPrecio"
        QueryParameter2.Type = GetType(Integer)
        QueryParameter2.ValueInfo = "0"
        QueryParameter3.Name = "@IDMoneda"
        QueryParameter3.Type = GetType(Integer)
        QueryParameter3.ValueInfo = "0"
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "fafprintTablaBonificacionPrecios"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel13, Me.XrLabel14})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IDProveedor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 23.00002!
        Me.GroupHeaderBand1.KeepTogether = True
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        Me.GroupHeaderBand1.RepeatEveryPage = True
        Me.GroupHeaderBand1.StyleName = "DataField"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(49.94447!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(105.2855!, 17.0!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Proveedor :"
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.IDProveedor")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(155.2299!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(105.2855!, 17.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafprintTablaBonificacionPrecios.Nombre")})
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(276.1404!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(327.6001!, 17.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "XrLabel14"
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.HeightF = 7.375!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(796.2759!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(144.0637!, 12.58333!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.HeightF = 0.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 22.99999!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(315.9395!, 18.0!)
        Me.XrLabel25.StyleName = "Title"
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.Text = "Tabla de Bonificaciones y Precios"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 21.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Pag {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(796.2758!, 22.99999!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(139.7106!, 20.08333!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 64.20838!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(968.0416!, 2.0!)
        '
        'XrLabel12
        '
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(906.4623!, 48.08334!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(47.41907!, 14.125!)
        Me.XrLabel12.StyleName = "FieldCaption"
        Me.XrLabel12.Text = "Escala4"
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(835.6942!, 48.08334!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(49.27197!, 14.125!)
        Me.XrLabel11.StyleName = "FieldCaption"
        Me.XrLabel11.Text = "Escala3"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(764.9723!, 48.08334!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(58.70612!, 14.125!)
        Me.XrLabel10.StyleName = "FieldCaption"
        Me.XrLabel10.Text = "Escala2"
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(701.6013!, 48.08334!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(50.78925!, 14.125!)
        Me.XrLabel9.StyleName = "FieldCaption"
        Me.XrLabel9.Text = "Escala1"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(617.927!, 48.08334!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(65.11084!, 14.125!)
        Me.XrLabel8.StyleName = "FieldCaption"
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Publico"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(546.8886!, 48.08334!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(71.03839!, 14.125!)
        Me.XrLabel7.StyleName = "FieldCaption"
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Precio"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(443.4439!, 48.08334!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(60.56851!, 14.125!)
        Me.XrLabel6.StyleName = "FieldCaption"
        Me.XrLabel6.Text = "Generico"
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(315.7372!, 48.08334!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(103.9001!, 14.125!)
        Me.XrLabel5.StyleName = "FieldCaption"
        Me.XrLabel5.Text = "Presentacion"
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(117.6048!, 48.08334!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(186.6741!, 14.125!)
        Me.XrLabel4.StyleName = "FieldCaption"
        Me.XrLabel4.Text = "Descripción"
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 48.08334!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(95.58814!, 16.125!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.Text = "IDProducto"
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLine1, Me.XrPageInfo2, Me.XrLabel25, Me.XrPageInfo1})
        Me.PageHeaderBand1.HeightF = 74.75001!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(552.3741!, 22.99999!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(65.55292!, 18.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.Text = "Moneda :"
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(328.2372!, 25.08332!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(91.40009!, 18.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.Text = "Nivel Precio :"
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psMoneda, "Text", "")})
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(617.927!, 22.99999!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "XrLabel27"
        '
        'psMoneda
        '
        Me.psMoneda.Description = "psMoneda"
        Me.psMoneda.Name = "psMoneda"
        Me.psMoneda.Visible = False
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psNivel, "Text", "")})
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(419.6374!, 22.99999!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "XrLabel26"
        '
        'psNivel
        '
        Me.psNivel.Description = "psNivel"
        Me.psNivel.Name = "psNivel"
        Me.psNivel.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.psEmpresa, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(276.1404!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(315.9395!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'psEmpresa
        '
        Me.psEmpresa.Description = "psEmpresa"
        Me.psEmpresa.Name = "psEmpresa"
        Me.psEmpresa.Visible = False
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 27.00001!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(995.0!, 7.375!)
        '
        'rptTablaBonificacionPrecios
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeaderBand1, Me.GroupHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1})
        Me.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.DashDot
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "fafprintTablaBonificacionPrecios"
        Me.DataSource = Me.SqlDataSource1
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.DefaultPrinterSettingsUsing.UsePaperKind = True
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(49, 56, 65, 92)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.psEmpresa, Me.psNivel, Me.psMoneda})
        Me.RollPaper = True
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psEmpresa As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psMoneda As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents psNivel As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
End Class
