Partial Class Report1

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report1))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group4 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group5 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group6 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group7 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group8 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group9 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group10 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group11 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group12 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.tR_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_NameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.product_QtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tR_SumpriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_IDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_NameProductCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_PriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_QtyProductCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_SumpriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tR_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.tR_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.product_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.product_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.product_NameGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.product_NameGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.product_PriceGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.product_PriceGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.product_QtyGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.product_QtyGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.tR_SumpriceGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.tR_SumpriceGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_IDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pR_IDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_NameProductGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pR_NameProductGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_PriceGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pR_PriceGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_QtyProductGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pR_QtyProductGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pR_SumpriceGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pR_SumpriceGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pR_DateCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pR_DateDataTextBox = New Telerik.Reporting.TextBox()
        Me.tR_DateCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tR_DateDataTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.tR_IDCaptionTextBox, Me.product_IDCaptionTextBox, Me.product_NameCaptionTextBox, Me.product_PriceCaptionTextBox, Me.product_QtyCaptionTextBox, Me.tR_SumpriceCaptionTextBox, Me.pR_IDCaptionTextBox, Me.pR_NameProductCaptionTextBox, Me.pR_PriceCaptionTextBox, Me.pR_QtyProductCaptionTextBox, Me.pR_SumpriceCaptionTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'tR_IDCaptionTextBox
        '
        Me.tR_IDCaptionTextBox.CanGrow = True
        Me.tR_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.tR_IDCaptionTextBox.Name = "tR_IDCaptionTextBox"
        Me.tR_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.tR_IDCaptionTextBox.StyleName = "Caption"
        Me.tR_IDCaptionTextBox.Value = "TR_ID"
        '
        'product_IDCaptionTextBox
        '
        Me.product_IDCaptionTextBox.CanGrow = True
        Me.product_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.48575758934021R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_IDCaptionTextBox.Name = "product_IDCaptionTextBox"
        Me.product_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_IDCaptionTextBox.StyleName = "Caption"
        Me.product_IDCaptionTextBox.Value = "Product_ID"
        '
        'product_NameCaptionTextBox
        '
        Me.product_NameCaptionTextBox.CanGrow = True
        Me.product_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9185984134674072R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_NameCaptionTextBox.Name = "product_NameCaptionTextBox"
        Me.product_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_NameCaptionTextBox.StyleName = "Caption"
        Me.product_NameCaptionTextBox.Value = "Product_Name"
        '
        'product_PriceCaptionTextBox
        '
        Me.product_PriceCaptionTextBox.CanGrow = True
        Me.product_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3514394760131836R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_PriceCaptionTextBox.Name = "product_PriceCaptionTextBox"
        Me.product_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_PriceCaptionTextBox.StyleName = "Caption"
        Me.product_PriceCaptionTextBox.Value = "Product_Price"
        '
        'product_QtyCaptionTextBox
        '
        Me.product_QtyCaptionTextBox.CanGrow = True
        Me.product_QtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7842803001403809R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.product_QtyCaptionTextBox.Name = "product_QtyCaptionTextBox"
        Me.product_QtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.product_QtyCaptionTextBox.StyleName = "Caption"
        Me.product_QtyCaptionTextBox.Value = "Product_Qty"
        '
        'tR_SumpriceCaptionTextBox
        '
        Me.tR_SumpriceCaptionTextBox.CanGrow = True
        Me.tR_SumpriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.2171211242675781R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.tR_SumpriceCaptionTextBox.Name = "tR_SumpriceCaptionTextBox"
        Me.tR_SumpriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.tR_SumpriceCaptionTextBox.StyleName = "Caption"
        Me.tR_SumpriceCaptionTextBox.Value = "TR_Sumprice"
        '
        'pR_IDCaptionTextBox
        '
        Me.pR_IDCaptionTextBox.CanGrow = True
        Me.pR_IDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.6499624252319336R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pR_IDCaptionTextBox.Name = "pR_IDCaptionTextBox"
        Me.pR_IDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_IDCaptionTextBox.StyleName = "Caption"
        Me.pR_IDCaptionTextBox.Value = "PR_ID"
        '
        'pR_NameProductCaptionTextBox
        '
        Me.pR_NameProductCaptionTextBox.CanGrow = True
        Me.pR_NameProductCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.082802772521973R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pR_NameProductCaptionTextBox.Name = "pR_NameProductCaptionTextBox"
        Me.pR_NameProductCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_NameProductCaptionTextBox.StyleName = "Caption"
        Me.pR_NameProductCaptionTextBox.Value = "PR_Name Product"
        '
        'pR_PriceCaptionTextBox
        '
        Me.pR_PriceCaptionTextBox.CanGrow = True
        Me.pR_PriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.515644073486328R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pR_PriceCaptionTextBox.Name = "pR_PriceCaptionTextBox"
        Me.pR_PriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_PriceCaptionTextBox.StyleName = "Caption"
        Me.pR_PriceCaptionTextBox.Value = "PR_Price"
        '
        'pR_QtyProductCaptionTextBox
        '
        Me.pR_QtyProductCaptionTextBox.CanGrow = True
        Me.pR_QtyProductCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.948484420776367R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pR_QtyProductCaptionTextBox.Name = "pR_QtyProductCaptionTextBox"
        Me.pR_QtyProductCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_QtyProductCaptionTextBox.StyleName = "Caption"
        Me.pR_QtyProductCaptionTextBox.Value = "PR_Qty Product"
        '
        'pR_SumpriceCaptionTextBox
        '
        Me.pR_SumpriceCaptionTextBox.CanGrow = True
        Me.pR_SumpriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.381325721740723R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pR_SumpriceCaptionTextBox.Name = "pR_SumpriceCaptionTextBox"
        Me.pR_SumpriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_SumpriceCaptionTextBox.StyleName = "Caption"
        Me.pR_SumpriceCaptionTextBox.Value = "PR_Sumprice"
        '
        'tR_IDGroupHeaderSection
        '
        Me.tR_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.tR_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.tR_IDGroupHeaderSection.Name = "tR_IDGroupHeaderSection"
        '
        'tR_IDGroupFooterSection
        '
        Me.tR_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.tR_IDGroupFooterSection.Name = "tR_IDGroupFooterSection"
        '
        'product_IDGroupHeaderSection
        '
        Me.product_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.product_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2})
        Me.product_IDGroupHeaderSection.Name = "product_IDGroupHeaderSection"
        '
        'product_IDGroupFooterSection
        '
        Me.product_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.product_IDGroupFooterSection.Name = "product_IDGroupFooterSection"
        '
        'product_NameGroupHeaderSection
        '
        Me.product_NameGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.product_NameGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3})
        Me.product_NameGroupHeaderSection.Name = "product_NameGroupHeaderSection"
        '
        'product_NameGroupFooterSection
        '
        Me.product_NameGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.product_NameGroupFooterSection.Name = "product_NameGroupFooterSection"
        '
        'product_PriceGroupHeaderSection
        '
        Me.product_PriceGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.product_PriceGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4})
        Me.product_PriceGroupHeaderSection.Name = "product_PriceGroupHeaderSection"
        '
        'product_PriceGroupFooterSection
        '
        Me.product_PriceGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.product_PriceGroupFooterSection.Name = "product_PriceGroupFooterSection"
        '
        'product_QtyGroupHeaderSection
        '
        Me.product_QtyGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.product_QtyGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5})
        Me.product_QtyGroupHeaderSection.Name = "product_QtyGroupHeaderSection"
        '
        'product_QtyGroupFooterSection
        '
        Me.product_QtyGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.product_QtyGroupFooterSection.Name = "product_QtyGroupFooterSection"
        '
        'tR_SumpriceGroupHeaderSection
        '
        Me.tR_SumpriceGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.tR_SumpriceGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6})
        Me.tR_SumpriceGroupHeaderSection.Name = "tR_SumpriceGroupHeaderSection"
        '
        'tR_SumpriceGroupFooterSection
        '
        Me.tR_SumpriceGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.tR_SumpriceGroupFooterSection.Name = "tR_SumpriceGroupFooterSection"
        '
        'pR_IDGroupHeaderSection
        '
        Me.pR_IDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pR_IDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox7})
        Me.pR_IDGroupHeaderSection.Name = "pR_IDGroupHeaderSection"
        '
        'pR_IDGroupFooterSection
        '
        Me.pR_IDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pR_IDGroupFooterSection.Name = "pR_IDGroupFooterSection"
        '
        'pR_NameProductGroupHeaderSection
        '
        Me.pR_NameProductGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pR_NameProductGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8})
        Me.pR_NameProductGroupHeaderSection.Name = "pR_NameProductGroupHeaderSection"
        '
        'pR_NameProductGroupFooterSection
        '
        Me.pR_NameProductGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pR_NameProductGroupFooterSection.Name = "pR_NameProductGroupFooterSection"
        '
        'pR_PriceGroupHeaderSection
        '
        Me.pR_PriceGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pR_PriceGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9})
        Me.pR_PriceGroupHeaderSection.Name = "pR_PriceGroupHeaderSection"
        '
        'pR_PriceGroupFooterSection
        '
        Me.pR_PriceGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pR_PriceGroupFooterSection.Name = "pR_PriceGroupFooterSection"
        '
        'pR_QtyProductGroupHeaderSection
        '
        Me.pR_QtyProductGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pR_QtyProductGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox10})
        Me.pR_QtyProductGroupHeaderSection.Name = "pR_QtyProductGroupHeaderSection"
        '
        'pR_QtyProductGroupFooterSection
        '
        Me.pR_QtyProductGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pR_QtyProductGroupFooterSection.Name = "pR_QtyProductGroupFooterSection"
        '
        'pR_SumpriceGroupHeaderSection
        '
        Me.pR_SumpriceGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pR_SumpriceGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11})
        Me.pR_SumpriceGroupHeaderSection.Name = "pR_SumpriceGroupHeaderSection"
        '
        'pR_SumpriceGroupFooterSection
        '
        Me.pR_SumpriceGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pR_SumpriceGroupFooterSection.Name = "pR_SumpriceGroupFooterSection"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.TR_ID"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.48575758934021R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.Product_ID"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9185984134674072R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "= Fields.Product_Name"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3514394760131836R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.Product_Price"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7842803001403809R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "= Fields.Product_Qty"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.2171211242675781R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "= Fields.TR_Sumprice"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.6499624252319336R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "= Fields.PR_ID"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.082802772521973R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.PR_NameProduct"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.515644073486328R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "= Fields.PR_Price"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.948484420776367R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Fields.PR_QtyProduct"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.381325721740723R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3799242973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "= Fields.PR_Sumprice"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Report1"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(3.1058332920074463R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.pR_DateCaptionTextBox, Me.pR_DateDataTextBox, Me.tR_DateCaptionTextBox, Me.tR_DateDataTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report1"
        '
        'pR_DateCaptionTextBox
        '
        Me.pR_DateCaptionTextBox.CanGrow = True
        Me.pR_DateCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R))
        Me.pR_DateCaptionTextBox.Name = "pR_DateCaptionTextBox"
        Me.pR_DateCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_DateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pR_DateCaptionTextBox.StyleName = "Caption"
        Me.pR_DateCaptionTextBox.Value = "PR_Date:"
        '
        'pR_DateDataTextBox
        '
        Me.pR_DateDataTextBox.CanGrow = True
        Me.pR_DateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9932291507720947R), Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R))
        Me.pR_DateDataTextBox.Name = "pR_DateDataTextBox"
        Me.pR_DateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pR_DateDataTextBox.StyleName = "Data"
        Me.pR_DateDataTextBox.Value = "= Fields.PR_Date"
        '
        'tR_DateCaptionTextBox
        '
        Me.tR_DateCaptionTextBox.CanGrow = True
        Me.tR_DateCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R))
        Me.tR_DateCaptionTextBox.Name = "tR_DateCaptionTextBox"
        Me.tR_DateCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.tR_DateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.tR_DateCaptionTextBox.StyleName = "Caption"
        Me.tR_DateCaptionTextBox.Value = "TR_Date:"
        '
        'tR_DateDataTextBox
        '
        Me.tR_DateDataTextBox.CanGrow = True
        Me.tR_DateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.873854637145996R), Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127R))
        Me.tR_DateDataTextBox.Name = "tR_DateDataTextBox"
        Me.tR_DateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8873958587646484R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.tR_DateDataTextBox.StyleName = "Data"
        Me.tR_DateDataTextBox.Value = "= Fields.TR_Date"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.detail.Name = "detail"
        '
        'Report1
        '
        Me.DataSource = Me.SqlDataSource2
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.tR_IDGroupFooterSection
        Group2.GroupHeader = Me.tR_IDGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.TR_ID"))
        Group2.Name = "tR_IDGroup"
        Group3.GroupFooter = Me.product_IDGroupFooterSection
        Group3.GroupHeader = Me.product_IDGroupHeaderSection
        Group3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Product_ID"))
        Group3.Name = "product_IDGroup"
        Group4.GroupFooter = Me.product_NameGroupFooterSection
        Group4.GroupHeader = Me.product_NameGroupHeaderSection
        Group4.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Product_Name"))
        Group4.Name = "product_NameGroup"
        Group5.GroupFooter = Me.product_PriceGroupFooterSection
        Group5.GroupHeader = Me.product_PriceGroupHeaderSection
        Group5.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Product_Price"))
        Group5.Name = "product_PriceGroup"
        Group6.GroupFooter = Me.product_QtyGroupFooterSection
        Group6.GroupHeader = Me.product_QtyGroupHeaderSection
        Group6.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Product_Qty"))
        Group6.Name = "product_QtyGroup"
        Group7.GroupFooter = Me.tR_SumpriceGroupFooterSection
        Group7.GroupHeader = Me.tR_SumpriceGroupHeaderSection
        Group7.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.TR_Sumprice"))
        Group7.Name = "tR_SumpriceGroup"
        Group8.GroupFooter = Me.pR_IDGroupFooterSection
        Group8.GroupHeader = Me.pR_IDGroupHeaderSection
        Group8.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_ID"))
        Group8.Name = "pR_IDGroup"
        Group9.GroupFooter = Me.pR_NameProductGroupFooterSection
        Group9.GroupHeader = Me.pR_NameProductGroupHeaderSection
        Group9.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_NameProduct"))
        Group9.Name = "pR_NameProductGroup"
        Group10.GroupFooter = Me.pR_PriceGroupFooterSection
        Group10.GroupHeader = Me.pR_PriceGroupHeaderSection
        Group10.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_Price"))
        Group10.Name = "pR_PriceGroup"
        Group11.GroupFooter = Me.pR_QtyProductGroupFooterSection
        Group11.GroupHeader = Me.pR_QtyProductGroupHeaderSection
        Group11.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_QtyProduct"))
        Group11.Name = "pR_QtyProductGroup"
        Group12.GroupFooter = Me.pR_SumpriceGroupFooterSection
        Group12.GroupHeader = Me.pR_SumpriceGroupHeaderSection
        Group12.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PR_Sumprice"))
        Group12.Name = "pR_SumpriceGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3, Group4, Group5, Group6, Group7, Group8, Group9, Group10, Group11, Group12})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.tR_IDGroupHeaderSection, Me.tR_IDGroupFooterSection, Me.product_IDGroupHeaderSection, Me.product_IDGroupFooterSection, Me.product_NameGroupHeaderSection, Me.product_NameGroupFooterSection, Me.product_PriceGroupHeaderSection, Me.product_PriceGroupFooterSection, Me.product_QtyGroupHeaderSection, Me.product_QtyGroupFooterSection, Me.tR_SumpriceGroupHeaderSection, Me.tR_SumpriceGroupFooterSection, Me.pR_IDGroupHeaderSection, Me.pR_IDGroupFooterSection, Me.pR_NameProductGroupHeaderSection, Me.pR_NameProductGroupFooterSection, Me.pR_PriceGroupHeaderSection, Me.pR_PriceGroupFooterSection, Me.pR_QtyProductGroupHeaderSection, Me.pR_QtyProductGroupFooterSection, Me.pR_SumpriceGroupHeaderSection, Me.pR_SumpriceGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "Report1"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents tR_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents product_QtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tR_SumpriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_IDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_NameProductCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_PriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_QtyProductCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_SumpriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents tR_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents tR_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents product_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents product_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents product_NameGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents product_NameGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents product_PriceGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents product_PriceGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents product_QtyGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents product_QtyGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents tR_SumpriceGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents tR_SumpriceGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_IDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents pR_IDGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_NameProductGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents pR_NameProductGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_PriceGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents pR_PriceGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_QtyProductGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents pR_QtyProductGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pR_SumpriceGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents pR_SumpriceGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_DateCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pR_DateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tR_DateCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tR_DateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
End Class