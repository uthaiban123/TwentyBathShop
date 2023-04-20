Partial Class RP_รายงานข้อมูลสินค้า

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pro_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_NameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_QtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_TypeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_UnitCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pro_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pro_NameDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_PriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_QtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_TypeDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_UnitDataTextBox = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "SELECT        Pro_ID, Pro_Name, Pro_Price, Pro_Qty, Pro_Type, Pro_Unit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     " &
    "       Tbl_Inventory"
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'pro_IDCaptionTextBox
        '
        Me.pro_IDCaptionTextBox.CanGrow = True
        Me.pro_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.pro_IDCaptionTextBox.Name = "pro_IDCaptionTextBox"
        Me.pro_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_IDCaptionTextBox.Style.Font.Bold = True
        Me.pro_IDCaptionTextBox.StyleName = "Caption"
        Me.pro_IDCaptionTextBox.Value = "รหัสสินค้า"
        '
        'pro_NameCaptionTextBox
        '
        Me.pro_NameCaptionTextBox.CanGrow = True
        Me.pro_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6797919273376465R), Telerik.Reporting.Drawing.Unit.Cm(1.2088582515716553R))
        Me.pro_NameCaptionTextBox.Name = "pro_NameCaptionTextBox"
        Me.pro_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_NameCaptionTextBox.Style.Font.Bold = True
        Me.pro_NameCaptionTextBox.StyleName = "Caption"
        Me.pro_NameCaptionTextBox.Value = "ชื่อสินค้า"
        '
        'pro_PriceCaptionTextBox
        '
        Me.pro_PriceCaptionTextBox.CanGrow = True
        Me.pro_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3066668510437012R), Telerik.Reporting.Drawing.Unit.Cm(1.2088582515716553R))
        Me.pro_PriceCaptionTextBox.Name = "pro_PriceCaptionTextBox"
        Me.pro_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_PriceCaptionTextBox.Style.Font.Bold = True
        Me.pro_PriceCaptionTextBox.StyleName = "Caption"
        Me.pro_PriceCaptionTextBox.Value = "ราคา"
        '
        'pro_QtyCaptionTextBox
        '
        Me.pro_QtyCaptionTextBox.CanGrow = True
        Me.pro_QtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(1.2088582515716553R))
        Me.pro_QtyCaptionTextBox.Name = "pro_QtyCaptionTextBox"
        Me.pro_QtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_QtyCaptionTextBox.Style.Font.Bold = True
        Me.pro_QtyCaptionTextBox.StyleName = "Caption"
        Me.pro_QtyCaptionTextBox.Value = "จำนวนที่มี"
        '
        'pro_TypeCaptionTextBox
        '
        Me.pro_TypeCaptionTextBox.CanGrow = True
        Me.pro_TypeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.560417175292969R), Telerik.Reporting.Drawing.Unit.Cm(1.2088582515716553R))
        Me.pro_TypeCaptionTextBox.Name = "pro_TypeCaptionTextBox"
        Me.pro_TypeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_TypeCaptionTextBox.Style.Font.Bold = True
        Me.pro_TypeCaptionTextBox.StyleName = "Caption"
        Me.pro_TypeCaptionTextBox.Value = "ประเภทสินค้า"
        '
        'pro_UnitCaptionTextBox
        '
        Me.pro_UnitCaptionTextBox.CanGrow = True
        Me.pro_UnitCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.187292098999023R), Telerik.Reporting.Drawing.Unit.Cm(1.2088582515716553R))
        Me.pro_UnitCaptionTextBox.Name = "pro_UnitCaptionTextBox"
        Me.pro_UnitCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_UnitCaptionTextBox.Style.Font.Bold = True
        Me.pro_UnitCaptionTextBox.StyleName = "Caption"
        Me.pro_UnitCaptionTextBox.Value = "หน่อยนับ"
        '
        'pro_IDGroupHeaderSection
        '
        Me.pro_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(2.2089579105377197R)
        Me.pro_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.pro_NameCaptionTextBox, Me.pro_PriceCaptionTextBox, Me.pro_QtyCaptionTextBox, Me.pro_TypeCaptionTextBox, Me.pro_UnitCaptionTextBox, Me.pro_IDCaptionTextBox})
        Me.pro_IDGroupHeaderSection.Name = "pro_IDGroupHeaderSection"
        '
        'pro_IDGroupFooterSection
        '
        Me.pro_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.46770885586738586R)
        Me.pro_IDGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape1})
        Me.pro_IDGroupFooterSection.Name = "pro_IDGroupFooterSection"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6797919273376465R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.Pro_ID"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.pageHeader.Name = "pageHeader"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.95104295015335083R)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.69999885559082R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "รายงานข้อมูลสินค้า"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pro_NameDataTextBox, Me.pro_PriceDataTextBox, Me.pro_QtyDataTextBox, Me.pro_TypeDataTextBox, Me.pro_UnitDataTextBox})
        Me.detail.Name = "detail"
        '
        'pro_NameDataTextBox
        '
        Me.pro_NameDataTextBox.CanGrow = True
        Me.pro_NameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6797916889190674R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_NameDataTextBox.Name = "pro_NameDataTextBox"
        Me.pro_NameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_NameDataTextBox.StyleName = "Data"
        Me.pro_NameDataTextBox.Value = "= Fields.Pro_Name"
        '
        'pro_PriceDataTextBox
        '
        Me.pro_PriceDataTextBox.CanGrow = True
        Me.pro_PriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_PriceDataTextBox.Format = "{0:N2}"
        Me.pro_PriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3066668510437012R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_PriceDataTextBox.Name = "pro_PriceDataTextBox"
        Me.pro_PriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_PriceDataTextBox.StyleName = "Data"
        Me.pro_PriceDataTextBox.Value = "= Fields.Pro_Price"
        '
        'pro_QtyDataTextBox
        '
        Me.pro_QtyDataTextBox.CanGrow = True
        Me.pro_QtyDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_QtyDataTextBox.Format = "{0:N2}"
        Me.pro_QtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_QtyDataTextBox.Name = "pro_QtyDataTextBox"
        Me.pro_QtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_QtyDataTextBox.StyleName = "Data"
        Me.pro_QtyDataTextBox.Value = "= Fields.Pro_Qty"
        '
        'pro_TypeDataTextBox
        '
        Me.pro_TypeDataTextBox.CanGrow = True
        Me.pro_TypeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.560416221618652R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_TypeDataTextBox.Name = "pro_TypeDataTextBox"
        Me.pro_TypeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_TypeDataTextBox.StyleName = "Data"
        Me.pro_TypeDataTextBox.Value = "= Fields.Pro_Type"
        '
        'pro_UnitDataTextBox
        '
        Me.pro_UnitDataTextBox.CanGrow = True
        Me.pro_UnitDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.800000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.00010093052696902305R))
        Me.pro_UnitDataTextBox.Name = "pro_UnitDataTextBox"
        Me.pro_UnitDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_UnitDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.pro_UnitDataTextBox.StyleName = "Data"
        Me.pro_UnitDataTextBox.Value = "= Fields.Pro_Unit"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.699800491333008R), Telerik.Reporting.Drawing.Unit.Cm(0.46770885586738586R))
        '
        'RP_รายงานข้อมูลสินค้า
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.pro_IDGroupFooterSection
        Group2.GroupHeader = Me.pro_IDGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Pro_ID"))
        Group2.Name = "pro_IDGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pro_IDGroupHeaderSection, Me.pro_IDGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "RP_รายงานข้อมูลสินค้า"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Bold = True
        StyleRule2.Style.Font.Italic = False
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Style.Font.Strikeout = False
        StyleRule2.Style.Font.Underline = False
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(16.69999885559082R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents pro_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_QtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_TypeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_UnitCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pro_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pro_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pro_NameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_PriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_QtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_TypeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_UnitDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
End Class