Partial Class RP_รายรับรายจ่าย

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RP_รายรับรายจ่าย))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.tR_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.tR_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.pR_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.product_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_NameProductCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_QtyProductCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_SumpriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_SumpriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_NameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.tR_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.pR_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pR_PriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.product_PriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.pR_NameProductDataTextBox = New Telerik.Reporting.TextBox()
        Me.pR_QtyProductDataTextBox = New Telerik.Reporting.TextBox()
        Me.pR_SumpriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_SumpriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.product_NameDataTextBox = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229164481163025R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1677080392837524R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'tR_IDGroupFooterSection
        '
        Me.tR_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229164481163025R)
        Me.tR_IDGroupFooterSection.Name = "tR_IDGroupFooterSection"
        '
        'tR_IDGroupHeaderSection
        '
        Me.tR_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.0001000165939331R)
        Me.tR_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape3, Me.TextBox3, Me.TextBox4})
        Me.tR_IDGroupHeaderSection.Name = "tR_IDGroupHeaderSection"
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(1.0001000165939331R))
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1950004100799561R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.647083044052124R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "รายรับ"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.951250076293945R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.647083044052124R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "รายจ่าย"
        '
        'pR_IDGroupFooterSection
        '
        Me.pR_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229164481163025R)
        Me.pR_IDGroupFooterSection.Name = "pR_IDGroupFooterSection"
        '
        'pR_IDGroupHeaderSection
        '
        Me.pR_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(3.199899435043335R)
        Me.pR_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape1, Me.product_PriceCaptionTextBox, Me.pR_NameProductCaptionTextBox, Me.pR_PriceCaptionTextBox, Me.pR_QtyProductCaptionTextBox, Me.pR_SumpriceCaptionTextBox, Me.pro_SumpriceCaptionTextBox, Me.product_NameCaptionTextBox, Me.TextBox1, Me.tR_IDCaptionTextBox, Me.TextBox2, Me.pR_IDCaptionTextBox})
        Me.pR_IDGroupHeaderSection.Name = "pR_IDGroupHeaderSection"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.4880990982055664R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749332R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(3.1994998455047607R))
        '
        'product_PriceCaptionTextBox
        '
        Me.product_PriceCaptionTextBox.CanGrow = True
        Me.product_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1950004100799561R), Telerik.Reporting.Drawing.Unit.Cm(1.8999000787734985R))
        Me.product_PriceCaptionTextBox.Name = "product_PriceCaptionTextBox"
        Me.product_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0420825481414795R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_PriceCaptionTextBox.Style.Font.Bold = True
        Me.product_PriceCaptionTextBox.StyleName = "Caption"
        Me.product_PriceCaptionTextBox.Value = "ราคาสินค้า"
        '
        'pR_NameProductCaptionTextBox
        '
        Me.pR_NameProductCaptionTextBox.CanGrow = True
        Me.pR_NameProductCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3447818756103516R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.pR_NameProductCaptionTextBox.Name = "pR_NameProductCaptionTextBox"
        Me.pR_NameProductCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_NameProductCaptionTextBox.Style.Font.Bold = True
        Me.pR_NameProductCaptionTextBox.StyleName = "Caption"
        Me.pR_NameProductCaptionTextBox.Value = "ชื่อสินค้า"
        '
        'pR_PriceCaptionTextBox
        '
        Me.pR_PriceCaptionTextBox.CanGrow = True
        Me.pR_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.096031188964844R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.pR_PriceCaptionTextBox.Name = "pR_PriceCaptionTextBox"
        Me.pR_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_PriceCaptionTextBox.Style.Font.Bold = True
        Me.pR_PriceCaptionTextBox.StyleName = "Caption"
        Me.pR_PriceCaptionTextBox.Value = "ราคาสินค้า"
        '
        'pR_QtyProductCaptionTextBox
        '
        Me.pR_QtyProductCaptionTextBox.CanGrow = True
        Me.pR_QtyProductCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.444250106811523R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.pR_QtyProductCaptionTextBox.Name = "pR_QtyProductCaptionTextBox"
        Me.pR_QtyProductCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1540839672088623R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_QtyProductCaptionTextBox.Style.Font.Bold = True
        Me.pR_QtyProductCaptionTextBox.StyleName = "Caption"
        Me.pR_QtyProductCaptionTextBox.Value = "จำนวนสินค้า"
        '
        'pR_SumpriceCaptionTextBox
        '
        Me.pR_SumpriceCaptionTextBox.CanGrow = True
        Me.pR_SumpriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.001565933227539R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.pR_SumpriceCaptionTextBox.Name = "pR_SumpriceCaptionTextBox"
        Me.pR_SumpriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_SumpriceCaptionTextBox.Style.Font.Bold = True
        Me.pR_SumpriceCaptionTextBox.StyleName = "Caption"
        Me.pR_SumpriceCaptionTextBox.Value = "ราคารวม"
        '
        'pro_SumpriceCaptionTextBox
        '
        Me.pro_SumpriceCaptionTextBox.CanGrow = True
        Me.pro_SumpriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8422837257385254R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.pro_SumpriceCaptionTextBox.Name = "pro_SumpriceCaptionTextBox"
        Me.pro_SumpriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_SumpriceCaptionTextBox.Style.Font.Bold = True
        Me.pro_SumpriceCaptionTextBox.StyleName = "Caption"
        Me.pro_SumpriceCaptionTextBox.Value = "ราคารวม"
        '
        'product_NameCaptionTextBox
        '
        Me.product_NameCaptionTextBox.CanGrow = True
        Me.product_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776R), Telerik.Reporting.Drawing.Unit.Cm(1.8996999263763428R))
        Me.product_NameCaptionTextBox.Name = "product_NameCaptionTextBox"
        Me.product_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_NameCaptionTextBox.Style.Font.Bold = True
        Me.product_NameCaptionTextBox.StyleName = "Caption"
        Me.product_NameCaptionTextBox.Value = "ชื่อสินค้า"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9372825622558594R), Telerik.Reporting.Drawing.Unit.Cm(0.13662764430046082R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.TR_ID"
        '
        'tR_IDCaptionTextBox
        '
        Me.tR_IDCaptionTextBox.CanGrow = True
        Me.tR_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.28999966382980347R), Telerik.Reporting.Drawing.Unit.Cm(0.14708364009857178R))
        Me.tR_IDCaptionTextBox.Name = "tR_IDCaptionTextBox"
        Me.tR_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.647083044052124R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.tR_IDCaptionTextBox.Style.Font.Bold = True
        Me.tR_IDCaptionTextBox.StyleName = "Caption"
        Me.tR_IDCaptionTextBox.Value = "เลขที่การขาย"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Culture = New System.Globalization.CultureInfo("")
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.5R), Telerik.Reporting.Drawing.Unit.Cm(0.14708364009857178R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6997992992401123R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.PR_ID"
        '
        'pR_IDCaptionTextBox
        '
        Me.pR_IDCaptionTextBox.CanGrow = True
        Me.pR_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0997991561889648R), Telerik.Reporting.Drawing.Unit.Cm(0.13662764430046082R))
        Me.pR_IDCaptionTextBox.Name = "pR_IDCaptionTextBox"
        Me.pR_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4000008106231689R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_IDCaptionTextBox.Style.Font.Bold = True
        Me.pR_IDCaptionTextBox.StyleName = "Caption"
        Me.pR_IDCaptionTextBox.Value = "เลขที่การจ่าย"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(1.4999001026153565R))
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "รายการรายรับ - รายจ่าย"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageFooter.Name = "pageFooter"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.87936544418335R), Telerik.Reporting.Drawing.Unit.Cm(1.4021615982055664R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4612510204315186R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "กำไรสุทธิ"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.896031379699707R), Telerik.Reporting.Drawing.Unit.Cm(1.2964284420013428R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.89980083703994751R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "บาท"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.0R), Telerik.Reporting.Drawing.Unit.Cm(1.3068840503692627R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3512506484985352R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox13.StyleName = "Data"
        Me.TextBox13.Value = "= sum(Fields.Pro_Sumprice)-sum(Fields.PR_Sumprice)"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.reportHeader.Name = "reportHeader"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(2.4021615982055664R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox10, Me.TextBox9, Me.TextBox13, Me.TextBox12, Me.TextBox11})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.83874887228012085R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4612510204315186R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "รายรับทั้งหมด"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4999995231628418R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "= sum(Fields.Pro_Sumprice)"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.30019998550415R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.89980083703994751R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "บาท"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.360823631286621R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.89980083703994751R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "บาท"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3447818756103516R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7552180290222168R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "รายจ่ายทั้งหมด"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox9.Format = "{0:N2}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.548748970031738R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3512506484985352R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "= sum(Fields.PR_Sumprice)"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3000001907348633R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pR_PriceDataTextBox, Me.product_PriceDataTextBox, Me.pR_NameProductDataTextBox, Me.pR_QtyProductDataTextBox, Me.pR_SumpriceDataTextBox, Me.pro_SumpriceDataTextBox, Me.product_NameDataTextBox, Me.Shape2})
        Me.detail.Name = "detail"
        '
        'pR_PriceDataTextBox
        '
        Me.pR_PriceDataTextBox.CanGrow = True
        Me.pR_PriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pR_PriceDataTextBox.Format = "{0:N2}"
        Me.pR_PriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.148749351501465R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.pR_PriceDataTextBox.Name = "pR_PriceDataTextBox"
        Me.pR_PriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_PriceDataTextBox.StyleName = "Data"
        Me.pR_PriceDataTextBox.Value = "= Fields.PR_Price"
        '
        'product_PriceDataTextBox
        '
        Me.product_PriceDataTextBox.CanGrow = True
        Me.product_PriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.product_PriceDataTextBox.Format = "{0:N2}"
        Me.product_PriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2489485740661621R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.product_PriceDataTextBox.Name = "product_PriceDataTextBox"
        Me.product_PriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_PriceDataTextBox.StyleName = "Data"
        Me.product_PriceDataTextBox.Value = "= Fields.Product_Price"
        '
        'pR_NameProductDataTextBox
        '
        Me.pR_NameProductDataTextBox.CanGrow = True
        Me.pR_NameProductDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3447818756103516R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.pR_NameProductDataTextBox.Name = "pR_NameProductDataTextBox"
        Me.pR_NameProductDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_NameProductDataTextBox.StyleName = "Data"
        Me.pR_NameProductDataTextBox.Value = "= Fields.PR_NameProduct"
        '
        'pR_QtyProductDataTextBox
        '
        Me.pR_QtyProductDataTextBox.CanGrow = True
        Me.pR_QtyProductDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pR_QtyProductDataTextBox.Format = "{0:N2}"
        Me.pR_QtyProductDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.847282409667969R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.pR_QtyProductDataTextBox.Name = "pR_QtyProductDataTextBox"
        Me.pR_QtyProductDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_QtyProductDataTextBox.StyleName = "Data"
        Me.pR_QtyProductDataTextBox.Value = "= Fields.PR_QtyProduct"
        '
        'pR_SumpriceDataTextBox
        '
        Me.pR_SumpriceDataTextBox.CanGrow = True
        Me.pR_SumpriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pR_SumpriceDataTextBox.Format = "{0:N2}"
        Me.pR_SumpriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.948847770690918R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.pR_SumpriceDataTextBox.Name = "pR_SumpriceDataTextBox"
        Me.pR_SumpriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_SumpriceDataTextBox.StyleName = "Data"
        Me.pR_SumpriceDataTextBox.Value = "= Fields.PR_Sumprice"
        '
        'pro_SumpriceDataTextBox
        '
        Me.pro_SumpriceDataTextBox.CanGrow = True
        Me.pro_SumpriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_SumpriceDataTextBox.Format = "{0:N2}"
        Me.pro_SumpriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8422837257385254R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.pro_SumpriceDataTextBox.Name = "pro_SumpriceDataTextBox"
        Me.pro_SumpriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7510514259338379R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pro_SumpriceDataTextBox.StyleName = "Data"
        Me.pro_SumpriceDataTextBox.Value = "= Fields.Pro_Sumprice"
        '
        'product_NameDataTextBox
        '
        Me.product_NameDataTextBox.CanGrow = True
        Me.product_NameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.product_NameDataTextBox.Name = "product_NameDataTextBox"
        Me.product_NameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_NameDataTextBox.StyleName = "Data"
        Me.product_NameDataTextBox.Value = "= Fields.Product_Name"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.4880990982055664R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749332R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(1.0001000165939331R))
        '
        'RP_รายรับรายจ่าย
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.tR_IDGroupFooterSection
        Group2.GroupHeader = Me.tR_IDGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.TR_ID"))
        Group2.Name = "tR_IDGroup"
        Group3.GroupFooter = Me.pR_IDGroupFooterSection
        Group3.GroupHeader = Me.pR_IDGroupHeaderSection
        Group3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_ID"))
        Group3.Name = "pR_IDGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.tR_IDGroupHeaderSection, Me.tR_IDGroupFooterSection, Me.pR_IDGroupHeaderSection, Me.pR_IDGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "RP_รายรับรายจ่าย"
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
    Friend WithEvents tR_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_NameProductCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_QtyProductCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_SumpriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_SumpriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents tR_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents tR_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents pR_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents product_NameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_NameProductDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_PriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_QtyProductDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_SumpriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_SumpriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
End Class