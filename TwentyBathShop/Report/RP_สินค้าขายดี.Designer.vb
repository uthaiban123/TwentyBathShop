Partial Class RP_สินค้าขายดี

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
        Me.pro_BuyOutCaptionTextBox = New Telerik.Reporting.TextBox()
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
        Me.pro_BuyOutDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "SELECT        TOP (5) Pro_Name, Pro_ID, Pro_Price, Pro_BuyOut" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Tb" &
    "l_Inventory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY Pro_BuyOut DESC"
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pro_IDCaptionTextBox, Me.pro_NameCaptionTextBox, Me.pro_PriceCaptionTextBox, Me.pro_BuyOutCaptionTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'pro_IDCaptionTextBox
        '
        Me.pro_IDCaptionTextBox.CanGrow = True
        Me.pro_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_IDCaptionTextBox.Name = "pro_IDCaptionTextBox"
        Me.pro_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_IDCaptionTextBox.Style.Font.Bold = True
        Me.pro_IDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.pro_IDCaptionTextBox.StyleName = "Caption"
        Me.pro_IDCaptionTextBox.Value = "รหัสสินค้า"
        '
        'pro_NameCaptionTextBox
        '
        Me.pro_NameCaptionTextBox.CanGrow = True
        Me.pro_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9932291507720947R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_NameCaptionTextBox.Name = "pro_NameCaptionTextBox"
        Me.pro_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_NameCaptionTextBox.Style.Font.Bold = True
        Me.pro_NameCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.pro_NameCaptionTextBox.StyleName = "Caption"
        Me.pro_NameCaptionTextBox.Value = "ชื่อสินค้า"
        '
        'pro_PriceCaptionTextBox
        '
        Me.pro_PriceCaptionTextBox.CanGrow = True
        Me.pro_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_PriceCaptionTextBox.Name = "pro_PriceCaptionTextBox"
        Me.pro_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_PriceCaptionTextBox.Style.Font.Bold = True
        Me.pro_PriceCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.pro_PriceCaptionTextBox.StyleName = "Caption"
        Me.pro_PriceCaptionTextBox.Value = "ราคาสินค้า"
        '
        'pro_BuyOutCaptionTextBox
        '
        Me.pro_BuyOutCaptionTextBox.CanGrow = True
        Me.pro_BuyOutCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.873854637145996R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_BuyOutCaptionTextBox.Name = "pro_BuyOutCaptionTextBox"
        Me.pro_BuyOutCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_BuyOutCaptionTextBox.Style.Font.Bold = True
        Me.pro_BuyOutCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.pro_BuyOutCaptionTextBox.StyleName = "Caption"
        Me.pro_BuyOutCaptionTextBox.Value = "สินค้าที่ขายไป/ชิ้น"
        '
        'pro_IDGroupHeaderSection
        '
        Me.pro_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pro_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.pro_NameDataTextBox, Me.pro_PriceDataTextBox, Me.pro_BuyOutDataTextBox})
        Me.pro_IDGroupHeaderSection.Name = "pro_IDGroupHeaderSection"
        '
        'pro_IDGroupFooterSection
        '
        Me.pro_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.22365035116672516R)
        Me.pro_IDGroupFooterSection.Name = "pro_IDGroupFooterSection"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.Pro_ID"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0000998973846436R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.161149978637695R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "รายงานสินค้าขายดี 5 อันดับ"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3677079677581787R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox3, Me.TextBox4})
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.detail.Name = "detail"
        '
        'pro_NameDataTextBox
        '
        Me.pro_NameDataTextBox.CanGrow = True
        Me.pro_NameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9405126571655273R), Telerik.Reporting.Drawing.Unit.Cm(0.10573320835828781R))
        Me.pro_NameDataTextBox.Name = "pro_NameDataTextBox"
        Me.pro_NameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_NameDataTextBox.StyleName = "Data"
        Me.pro_NameDataTextBox.Value = "= Fields.Pro_Name"
        '
        'pro_PriceDataTextBox
        '
        Me.pro_PriceDataTextBox.CanGrow = True
        Me.pro_PriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_PriceDataTextBox.Format = "{0:N2}"
        Me.pro_PriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8808250427246094R), Telerik.Reporting.Drawing.Unit.Cm(0.10573320835828781R))
        Me.pro_PriceDataTextBox.Name = "pro_PriceDataTextBox"
        Me.pro_PriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_PriceDataTextBox.StyleName = "Data"
        Me.pro_PriceDataTextBox.Value = "= Fields.Pro_Price"
        '
        'pro_BuyOutDataTextBox
        '
        Me.pro_BuyOutDataTextBox.CanGrow = True
        Me.pro_BuyOutDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_BuyOutDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.821137428283691R), Telerik.Reporting.Drawing.Unit.Cm(0.10573320835828781R))
        Me.pro_BuyOutDataTextBox.Name = "pro_BuyOutDataTextBox"
        Me.pro_BuyOutDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_BuyOutDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pro_BuyOutDataTextBox.StyleName = "Data"
        Me.pro_BuyOutDataTextBox.Value = "= Fields.Pro_BuyOut"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8808250427246094R), Telerik.Reporting.Drawing.Unit.Cm(0.36760756373405457R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7191751003265381R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "ขายไปทั้งหมด"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.821138381958008R), Telerik.Reporting.Drawing.Unit.Cm(0.35715115070343018R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4000012874603271R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "= Sum(Fields.Pro_BuyOut)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.91136646270752R), Telerik.Reporting.Drawing.Unit.Cm(0.35715115070343018R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0086345672607422R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "ชิ้น"
        '
        'RP_สินค้าขายดี
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
        Me.Name = "RP_สินค้าขายดี"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(16.214065551757812R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents pro_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_BuyOutCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pro_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pro_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pro_NameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_PriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_BuyOutDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
End Class