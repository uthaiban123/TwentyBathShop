Partial Class RP_รายงานการขาย

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RP_รายงานการขาย))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.tR_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tR_DateCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_NameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_QtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pro_SumpriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tR_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.tR_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.tR_DateGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.tR_DateGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.product_IDDataTextBox = New Telerik.Reporting.TextBox()
        Me.product_NameDataTextBox = New Telerik.Reporting.TextBox()
        Me.product_PriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.product_QtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.pro_SumpriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-9RJNCM7\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'tR_IDCaptionTextBox
        '
        Me.tR_IDCaptionTextBox.CanGrow = True
        Me.tR_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.29999944567680359R), Telerik.Reporting.Drawing.Unit.Cm(0.010555718094110489R))
        Me.tR_IDCaptionTextBox.Name = "tR_IDCaptionTextBox"
        Me.tR_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.tR_IDCaptionTextBox.Style.Font.Bold = True
        Me.tR_IDCaptionTextBox.StyleName = "Caption"
        Me.tR_IDCaptionTextBox.Value = "เลขที่การขาย"
        '
        'tR_DateCaptionTextBox
        '
        Me.tR_DateCaptionTextBox.CanGrow = True
        Me.tR_DateCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.021011717617511749R))
        Me.tR_DateCaptionTextBox.Name = "tR_DateCaptionTextBox"
        Me.tR_DateCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.tR_DateCaptionTextBox.Style.Font.Bold = True
        Me.tR_DateCaptionTextBox.StyleName = "Caption"
        Me.tR_DateCaptionTextBox.Value = "วันที่ทำการขาย"
        '
        'product_IDCaptionTextBox
        '
        Me.product_IDCaptionTextBox.CanGrow = True
        Me.product_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.604522705078125R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_IDCaptionTextBox.Name = "product_IDCaptionTextBox"
        Me.product_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_IDCaptionTextBox.Style.Font.Bold = True
        Me.product_IDCaptionTextBox.StyleName = "Caption"
        Me.product_IDCaptionTextBox.Value = "รหัสสินค้า"
        '
        'product_NameCaptionTextBox
        '
        Me.product_NameCaptionTextBox.CanGrow = True
        Me.product_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.8561301231384277R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_NameCaptionTextBox.Name = "product_NameCaptionTextBox"
        Me.product_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_NameCaptionTextBox.Style.Font.Bold = True
        Me.product_NameCaptionTextBox.StyleName = "Caption"
        Me.product_NameCaptionTextBox.Value = "ชื่อสินค้า"
        '
        'product_PriceCaptionTextBox
        '
        Me.product_PriceCaptionTextBox.CanGrow = True
        Me.product_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9485931396484375R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_PriceCaptionTextBox.Name = "product_PriceCaptionTextBox"
        Me.product_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2512056827545166R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_PriceCaptionTextBox.Style.Font.Bold = True
        Me.product_PriceCaptionTextBox.StyleName = "Caption"
        Me.product_PriceCaptionTextBox.Value = "ราคา/หน่วย"
        '
        'product_QtyCaptionTextBox
        '
        Me.product_QtyCaptionTextBox.CanGrow = True
        Me.product_QtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.199999809265137R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_QtyCaptionTextBox.Name = "product_QtyCaptionTextBox"
        Me.product_QtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0481915473937988R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_QtyCaptionTextBox.Style.Font.Bold = True
        Me.product_QtyCaptionTextBox.StyleName = "Caption"
        Me.product_QtyCaptionTextBox.Value = "จำนวนที่ซื้อ"
        '
        'pro_SumpriceCaptionTextBox
        '
        Me.pro_SumpriceCaptionTextBox.CanGrow = True
        Me.pro_SumpriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.248392105102539R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_SumpriceCaptionTextBox.Name = "pro_SumpriceCaptionTextBox"
        Me.pro_SumpriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5612504482269287R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.pro_SumpriceCaptionTextBox.Style.Font.Bold = True
        Me.pro_SumpriceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pro_SumpriceCaptionTextBox.StyleName = "Caption"
        Me.pro_SumpriceCaptionTextBox.Value = "ราคารวม"
        '
        'tR_IDGroupHeaderSection
        '
        Me.tR_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.tR_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.tR_DateCaptionTextBox, Me.TextBox1, Me.tR_IDCaptionTextBox, Me.TextBox2})
        Me.tR_IDGroupHeaderSection.Name = "tR_IDGroupHeaderSection"
        '
        'tR_IDGroupFooterSection
        '
        Me.tR_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.tR_IDGroupFooterSection.Name = "tR_IDGroupFooterSection"
        '
        'tR_DateGroupHeaderSection
        '
        Me.tR_DateGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.tR_DateGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.product_QtyCaptionTextBox, Me.product_NameCaptionTextBox, Me.product_PriceCaptionTextBox, Me.product_IDCaptionTextBox, Me.pro_SumpriceCaptionTextBox})
        Me.tR_DateGroupHeaderSection.Name = "tR_DateGroupHeaderSection"
        '
        'tR_DateGroupFooterSection
        '
        Me.tR_DateGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(3.3846149444580078R)
        Me.tR_DateGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.Shape2})
        Me.tR_DateGroupFooterSection.Name = "tR_DateGroupFooterSection"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.010555718094110489R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7470831871032715R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.TR_ID"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.3043231964111328R), Telerik.Reporting.Drawing.Unit.Cm(0.021011717617511749R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.847083568572998R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.TR_Date"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.1527168750762939R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.Shape1})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(30.0R)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "รายงานการขายสินค้า"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3.8608653545379639R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox21, Me.TextBox12, Me.TextBox20, Me.TextBox19, Me.TextBox18, Me.TextBox17, Me.TextBox16, Me.TextBox15, Me.TextBox14, Me.TextBox13})
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.80332547426223755R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.product_IDDataTextBox, Me.product_NameDataTextBox, Me.product_PriceDataTextBox, Me.product_QtyDataTextBox, Me.pro_SumpriceDataTextBox})
        Me.detail.Name = "detail"
        '
        'product_IDDataTextBox
        '
        Me.product_IDDataTextBox.CanGrow = True
        Me.product_IDDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.product_IDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.5561308860778809R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_IDDataTextBox.Name = "product_IDDataTextBox"
        Me.product_IDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_IDDataTextBox.StyleName = "Data"
        Me.product_IDDataTextBox.Value = "= Fields.Product_ID"
        '
        'product_NameDataTextBox
        '
        Me.product_NameDataTextBox.CanGrow = True
        Me.product_NameDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.product_NameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.8077383041381836R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_NameDataTextBox.Name = "product_NameDataTextBox"
        Me.product_NameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_NameDataTextBox.StyleName = "Data"
        Me.product_NameDataTextBox.Value = "= Fields.Product_Name"
        '
        'product_PriceDataTextBox
        '
        Me.product_PriceDataTextBox.CanGrow = True
        Me.product_PriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.product_PriceDataTextBox.Format = "{0:N2}"
        Me.product_PriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9002008438110352R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_PriceDataTextBox.Name = "product_PriceDataTextBox"
        Me.product_PriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2512056827545166R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_PriceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.product_PriceDataTextBox.StyleName = "Data"
        Me.product_PriceDataTextBox.Value = "= Fields.Product_Price"
        '
        'product_QtyDataTextBox
        '
        Me.product_QtyDataTextBox.CanGrow = True
        Me.product_QtyDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.product_QtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.200000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_QtyDataTextBox.Name = "product_QtyDataTextBox"
        Me.product_QtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5998002290725708R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.product_QtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.product_QtyDataTextBox.StyleName = "Data"
        Me.product_QtyDataTextBox.Value = "= Fields.Product_Qty"
        '
        'pro_SumpriceDataTextBox
        '
        Me.pro_SumpriceDataTextBox.CanGrow = True
        Me.pro_SumpriceDataTextBox.Culture = New System.Globalization.CultureInfo("en")
        Me.pro_SumpriceDataTextBox.Format = "{0:N2}"
        Me.pro_SumpriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.800000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pro_SumpriceDataTextBox.Name = "pro_SumpriceDataTextBox"
        Me.pro_SumpriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9612501859664917R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.pro_SumpriceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pro_SumpriceDataTextBox.StyleName = "Data"
        Me.pro_SumpriceDataTextBox.Value = "= Fields.Pro_Sumprice"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.69999927282333374R), Telerik.Reporting.Drawing.Unit.Cm(1.3529163599014282R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(14.5R), Telerik.Reporting.Drawing.Unit.Cm(0.7998003363609314R))
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0591449737548828R), Telerik.Reporting.Drawing.Unit.Cm(0.29749152064323425R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "ราคารวม :"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0591449737548828R), Telerik.Reporting.Drawing.Unit.Cm(1.097491979598999R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "รับเงิน :"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0591449737548828R), Telerik.Reporting.Drawing.Unit.Cm(1.8974915742874146R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "ทอนเงิน :"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.30794793367385864R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "= Fields.TR_Sumprice"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.097491979598999R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "= Fields.TR_Recivemoney"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.9079478979110718R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.TR_Tonmoney"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.821905136108398R), Telerik.Reporting.Drawing.Unit.Cm(0.29749152064323425R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "บาท"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.821905136108398R), Telerik.Reporting.Drawing.Unit.Cm(1.0870355367660523R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "บาท"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.817379951477051R), Telerik.Reporting.Drawing.Unit.Cm(1.8974915742874146R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "บาท"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.69999927282333374R), Telerik.Reporting.Drawing.Unit.Cm(2.5848147869110107R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.10964298248291R), Telerik.Reporting.Drawing.Unit.Cm(0.7998003363609314R))
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.67666614055633545R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "สรุปรายงานการขายสินค้า"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7680168151855469R), Telerik.Reporting.Drawing.Unit.Cm(2.350801944732666R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "บาท"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7680168151855469R), Telerik.Reporting.Drawing.Unit.Cm(1.6999995708465576R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox14.StyleName = "Caption"
        Me.TextBox14.Value = "บาท"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7680168151855469R), Telerik.Reporting.Drawing.Unit.Cm(1.0384410619735718R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.99226212501525879R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = "บาท"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3338501453399658R), Telerik.Reporting.Drawing.Unit.Cm(2.3772604465484619R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "0.00"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3338501453399658R), Telerik.Reporting.Drawing.Unit.Cm(1.6999995708465576R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "0.00"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Culture = New System.Globalization.CultureInfo("en")
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3338501453399658R), Telerik.Reporting.Drawing.Unit.Cm(1.0384410619735718R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1986904144287109R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "0.00"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(2.350801944732666R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "ทอนเงิน :"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(1.6999995708465576R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox20.StyleName = "Caption"
        Me.TextBox20.Value = "รับเงิน :"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(1.0384410619735718R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0922622680664062R), Telerik.Reporting.Drawing.Unit.Cm(0.701497495174408R))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Caption"
        Me.TextBox21.Value = "ราคารวม :"
        '
        'RP_รายงานการขาย
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.tR_IDGroupFooterSection
        Group2.GroupHeader = Me.tR_IDGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.TR_ID"))
        Group2.Name = "tR_IDGroup"
        Group3.GroupFooter = Me.tR_DateGroupFooterSection
        Group3.GroupHeader = Me.tR_DateGroupHeaderSection
        Group3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.TR_Date"))
        Group3.Name = "tR_DateGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.tR_IDGroupHeaderSection, Me.tR_IDGroupFooterSection, Me.tR_DateGroupHeaderSection, Me.tR_DateGroupFooterSection, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "RP_รายงานการขาย"
        Me.PageSettings.Landscape = False
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.81932258605957R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents tR_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tR_DateCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_QtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_SumpriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents tR_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents tR_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents tR_DateGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents tR_DateGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents product_IDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_NameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_QtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pro_SumpriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
End Class