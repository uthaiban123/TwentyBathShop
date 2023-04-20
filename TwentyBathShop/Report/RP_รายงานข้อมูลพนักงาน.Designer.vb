Partial Class RP_รายงานข้อมูลพนักงาน

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
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.emp_IdGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.emp_IdGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.emp_LevelCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.emp_NameCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.emp_AddressCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.emp_EmailCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.emp_TelCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.emp_IdCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.emp_NameDataTextBox = New Telerik.Reporting.TextBox()
        Me.emp_LevelDataTextBox = New Telerik.Reporting.TextBox()
        Me.emp_AddressDataTextBox = New Telerik.Reporting.TextBox()
        Me.emp_EmailDataTextBox = New Telerik.Reporting.TextBox()
        Me.emp_TelDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'emp_IdGroupFooterSection
        '
        Me.emp_IdGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.emp_IdGroupFooterSection.Name = "emp_IdGroupFooterSection"
        '
        'emp_IdGroupHeaderSection
        '
        Me.emp_IdGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(2.6618747711181641R)
        Me.emp_IdGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.emp_LevelCaptionTextBox, Me.emp_NameCaptionTextBox, Me.emp_AddressCaptionTextBox, Me.emp_EmailCaptionTextBox, Me.emp_TelCaptionTextBox, Me.emp_IdCaptionTextBox, Me.TextBox1})
        Me.emp_IdGroupHeaderSection.Name = "emp_IdGroupHeaderSection"
        '
        'emp_LevelCaptionTextBox
        '
        Me.emp_LevelCaptionTextBox.CanGrow = True
        Me.emp_LevelCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(1.4090579748153687R))
        Me.emp_LevelCaptionTextBox.Name = "emp_LevelCaptionTextBox"
        Me.emp_LevelCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_LevelCaptionTextBox.StyleName = "Caption"
        Me.emp_LevelCaptionTextBox.Value = "ตำแหน่ง"
        '
        'emp_NameCaptionTextBox
        '
        Me.emp_NameCaptionTextBox.CanGrow = True
        Me.emp_NameCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.4618749618530273R))
        Me.emp_NameCaptionTextBox.Name = "emp_NameCaptionTextBox"
        Me.emp_NameCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_NameCaptionTextBox.StyleName = "Caption"
        Me.emp_NameCaptionTextBox.Value = "ชื่อ - นามสกุล"
        '
        'emp_AddressCaptionTextBox
        '
        Me.emp_AddressCaptionTextBox.CanGrow = True
        Me.emp_AddressCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.7999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(1.408957839012146R))
        Me.emp_AddressCaptionTextBox.Name = "emp_AddressCaptionTextBox"
        Me.emp_AddressCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_AddressCaptionTextBox.StyleName = "Caption"
        Me.emp_AddressCaptionTextBox.Value = "ที่อยู่"
        '
        'emp_EmailCaptionTextBox
        '
        Me.emp_EmailCaptionTextBox.CanGrow = True
        Me.emp_EmailCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(1.4618746042251587R))
        Me.emp_EmailCaptionTextBox.Name = "emp_EmailCaptionTextBox"
        Me.emp_EmailCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_EmailCaptionTextBox.StyleName = "Caption"
        Me.emp_EmailCaptionTextBox.Value = "อีเมลล์"
        '
        'emp_TelCaptionTextBox
        '
        Me.emp_TelCaptionTextBox.CanGrow = True
        Me.emp_TelCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.199999809265137R), Telerik.Reporting.Drawing.Unit.Cm(1.4618749618530273R))
        Me.emp_TelCaptionTextBox.Name = "emp_TelCaptionTextBox"
        Me.emp_TelCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.973957896232605R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_TelCaptionTextBox.StyleName = "Caption"
        Me.emp_TelCaptionTextBox.Value = "เบอร์โทร"
        '
        'emp_IdCaptionTextBox
        '
        Me.emp_IdCaptionTextBox.CanGrow = True
        Me.emp_IdCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10583332926034927R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.emp_IdCaptionTextBox.Name = "emp_IdCaptionTextBox"
        Me.emp_IdCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.emp_IdCaptionTextBox.StyleName = "Caption"
        Me.emp_IdCaptionTextBox.Value = "รหัสพนักงาน"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.7327086925506592R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.Emp_Id"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-IQGQ4C3\SQLEXPRESS;Initial Catalog=TwentyBath;Integrated Secu" &
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "SELECT        Emp_Id, Emp_Name, Emp_Level, Emp_Address, Emp_Email, Emp_Tel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM " &
    "           Tbl_Employee"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10583332926034927R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "รายงานข้อมูลพนักงาน"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.49999892711639404R)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.reportHeader.Name = "reportHeader"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.46874317526817322R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.873542070388794R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.emp_NameDataTextBox, Me.emp_LevelDataTextBox, Me.emp_AddressDataTextBox, Me.emp_EmailDataTextBox, Me.emp_TelDataTextBox})
        Me.detail.Name = "detail"
        '
        'emp_NameDataTextBox
        '
        Me.emp_NameDataTextBox.CanGrow = True
        Me.emp_NameDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.emp_NameDataTextBox.Name = "emp_NameDataTextBox"
        Me.emp_NameDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.6678084135055542R))
        Me.emp_NameDataTextBox.StyleName = "Data"
        Me.emp_NameDataTextBox.Value = "= Fields.Emp_Name"
        '
        'emp_LevelDataTextBox
        '
        Me.emp_LevelDataTextBox.CanGrow = True
        Me.emp_LevelDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.emp_LevelDataTextBox.Name = "emp_LevelDataTextBox"
        Me.emp_LevelDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.6678084135055542R))
        Me.emp_LevelDataTextBox.StyleName = "Data"
        Me.emp_LevelDataTextBox.Value = "= Fields.Emp_Level"
        '
        'emp_AddressDataTextBox
        '
        Me.emp_AddressDataTextBox.CanGrow = True
        Me.emp_AddressDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.7999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.emp_AddressDataTextBox.Name = "emp_AddressDataTextBox"
        Me.emp_AddressDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.6678084135055542R))
        Me.emp_AddressDataTextBox.StyleName = "Data"
        Me.emp_AddressDataTextBox.Value = "= Fields.Emp_Address"
        '
        'emp_EmailDataTextBox
        '
        Me.emp_EmailDataTextBox.CanGrow = True
        Me.emp_EmailDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7000007629394531R), Telerik.Reporting.Drawing.Unit.Cm(0.10573320835828781R))
        Me.emp_EmailDataTextBox.Name = "emp_EmailDataTextBox"
        Me.emp_EmailDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9999988079071045R), Telerik.Reporting.Drawing.Unit.Cm(0.6678084135055542R))
        Me.emp_EmailDataTextBox.StyleName = "Data"
        Me.emp_EmailDataTextBox.Value = "= Fields.Emp_Email"
        '
        'emp_TelDataTextBox
        '
        Me.emp_TelDataTextBox.CanGrow = True
        Me.emp_TelDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599899291992188R), Telerik.Reporting.Drawing.Unit.Cm(0.10573320835828781R))
        Me.emp_TelDataTextBox.Name = "emp_TelDataTextBox"
        Me.emp_TelDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5739583969116211R), Telerik.Reporting.Drawing.Unit.Cm(0.6678084135055542R))
        Me.emp_TelDataTextBox.StyleName = "Data"
        Me.emp_TelDataTextBox.Value = "= Fields.Emp_Tel"
        '
        'RP_รายงานข้อมูลพนักงาน
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.emp_IdGroupFooterSection
        Group2.GroupHeader = Me.emp_IdGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Emp_Id"))
        Group2.Name = "emp_IdGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.emp_IdGroupHeaderSection, Me.emp_IdGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "RP_รายงานข้อมูลพนักงาน"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(16.173957824707031R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents emp_IdCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents emp_NameCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_LevelCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_AddressCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_EmailCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_TelCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_IdGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents emp_IdGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents emp_NameDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_LevelDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_AddressDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_EmailDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents emp_TelDataTextBox As Telerik.Reporting.TextBox
End Class