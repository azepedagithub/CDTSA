<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLotesFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLotesFactura))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.pIDFactura = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pIDProducto = New DevExpress.XtraReports.Parameters.Parameter()
        Me.LoteCantidad = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.Detail.HeightF = 18.75!
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnCount = 4
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "fafGetFacturaLotes.LoteCantidad")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(151.0417!, 13.95833!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 2.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_ceda_Connection 2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "fafGetFacturaLotes"
        QueryParameter1.Name = "@IDFactura"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.pIDFactura]", GetType(Long))
        QueryParameter2.Name = "@IDProducto"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.pIDProducto]", GetType(Integer))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.StoredProcName = "fafGetFacturaLotes"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'pIDFactura
        '
        Me.pIDFactura.Description = "IDFactura"
        Me.pIDFactura.Name = "pIDFactura"
        Me.pIDFactura.Type = GetType(Long)
        Me.pIDFactura.ValueInfo = "0"
        Me.pIDFactura.Visible = False
        '
        'pIDProducto
        '
        Me.pIDProducto.Description = "IDProducto"
        Me.pIDProducto.Name = "pIDProducto"
        Me.pIDProducto.Type = GetType(Integer)
        Me.pIDProducto.ValueInfo = "0"
        Me.pIDProducto.Visible = False
        '
        'LoteCantidad
        '
        Me.LoteCantidad.DataMember = "fafGetFacturaLotes"
        Me.LoteCantidad.Expression = " [LoteProveedor]+ '- ' +ToStr(ToInt([Total]))+':' + ToStr(GetDay([FechaVencimient" & _
    "o]))+'/' + ToStr(GetMonth([FechaVencimiento]))+'/' + ToStr(GetYear([FechaVencimi" & _
    "ento]))"
        Me.LoteCantidad.Name = "LoteCantidad"
        '
        'rptLotesFactura
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.LoteCantidad})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "fafGetFacturaLotes"
        Me.DataSource = Me.SqlDataSource1
        Me.FilterString = "[IDFactura] = ?pIDFactura And [IDProducto] = ?pIDProducto"
        Me.Margins = New System.Drawing.Printing.Margins(99, 100, 2, 0)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pIDFactura, Me.pIDProducto})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents pIDFactura As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pIDProducto As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LoteCantidad As DevExpress.XtraReports.UI.CalculatedField
End Class
