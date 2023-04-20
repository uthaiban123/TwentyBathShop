<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.การจดการขอมลToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.คลงสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.พนกงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกรายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกรายงานToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานการขายToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานสนคาขายดToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานรายรบรายจายToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานขอมลพนกงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานขอมลสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.สงรายงานการขายไปทไลนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.รหัสสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคาสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนที่ซื้อ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคารวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_proqty = New System.Windows.Forms.TextBox()
        Me.txt_proprice = New System.Windows.Forms.TextBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.txt_proid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_trid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sumprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.recive = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ton = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ออกจากระบบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.การจดการขอมลToolStripMenuItem, Me.ออกรายงานToolStripMenuItem, Me.ออกรายงานToolStripMenuItem1, Me.ออกจากระบบToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'การจดการขอมลToolStripMenuItem
        '
        Me.การจดการขอมลToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.คลงสนคาToolStripMenuItem, Me.พนกงานToolStripMenuItem})
        Me.การจดการขอมลToolStripMenuItem.Name = "การจดการขอมลToolStripMenuItem"
        Me.การจดการขอมลToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.การจดการขอมลToolStripMenuItem.Text = "การจัดการข้อมูล"
        '
        'คลงสนคาToolStripMenuItem
        '
        Me.คลงสนคาToolStripMenuItem.Name = "คลงสนคาToolStripMenuItem"
        Me.คลงสนคาToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.คลงสนคาToolStripMenuItem.Text = "คลังสินค้า"
        '
        'พนกงานToolStripMenuItem
        '
        Me.พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem"
        Me.พนกงานToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.พนกงานToolStripMenuItem.Text = "พนักงาน"
        '
        'ออกรายงานToolStripMenuItem
        '
        Me.ออกรายงานToolStripMenuItem.Name = "ออกรายงานToolStripMenuItem"
        Me.ออกรายงานToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ออกรายงานToolStripMenuItem.Text = "บันทึกรายจ่าย"
        '
        'ออกรายงานToolStripMenuItem1
        '
        Me.ออกรายงานToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายงานการขายToolStripMenuItem, Me.รายงานสนคาขายดToolStripMenuItem, Me.รายงานรายรบรายจายToolStripMenuItem, Me.รายงานขอมลพนกงานToolStripMenuItem, Me.รายงานขอมลสนคาToolStripMenuItem, Me.สงรายงานการขายไปทไลนToolStripMenuItem})
        Me.ออกรายงานToolStripMenuItem1.Name = "ออกรายงานToolStripMenuItem1"
        Me.ออกรายงานToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.ออกรายงานToolStripMenuItem1.Text = "ออกรายงาน"
        '
        'รายงานการขายToolStripMenuItem
        '
        Me.รายงานการขายToolStripMenuItem.Name = "รายงานการขายToolStripMenuItem"
        Me.รายงานการขายToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.รายงานการขายToolStripMenuItem.Text = "รายงานการขาย"
        '
        'รายงานสนคาขายดToolStripMenuItem
        '
        Me.รายงานสนคาขายดToolStripMenuItem.Name = "รายงานสนคาขายดToolStripMenuItem"
        Me.รายงานสนคาขายดToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.รายงานสนคาขายดToolStripMenuItem.Text = "รายงานสินค้าขายดี"
        '
        'รายงานรายรบรายจายToolStripMenuItem
        '
        Me.รายงานรายรบรายจายToolStripMenuItem.Name = "รายงานรายรบรายจายToolStripMenuItem"
        Me.รายงานรายรบรายจายToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.รายงานรายรบรายจายToolStripMenuItem.Text = "รายงานรายรับ-รายจ่าย"
        '
        'รายงานขอมลพนกงานToolStripMenuItem
        '
        Me.รายงานขอมลพนกงานToolStripMenuItem.Name = "รายงานขอมลพนกงานToolStripMenuItem"
        Me.รายงานขอมลพนกงานToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.รายงานขอมลพนกงานToolStripMenuItem.Text = "รายงานข้อมูลพนักงาน"
        '
        'รายงานขอมลสนคาToolStripMenuItem
        '
        Me.รายงานขอมลสนคาToolStripMenuItem.Name = "รายงานขอมลสนคาToolStripMenuItem"
        Me.รายงานขอมลสนคาToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.รายงานขอมลสนคาToolStripMenuItem.Text = "รายงานข้อมูลสินค้า"
        '
        'สงรายงานการขายไปทไลนToolStripMenuItem
        '
        Me.สงรายงานการขายไปทไลนToolStripMenuItem.Name = "สงรายงานการขายไปทไลนToolStripMenuItem"
        Me.สงรายงานการขายไปทไลนToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.สงรายงานการขายไปทไลนToolStripMenuItem.Text = "ส่งรายงานการขายไปที่ไลน์"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 325)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียดสินค้า"
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสสินค้า, Me.ชื่อสินค้า, Me.ราคาสินค้า, Me.จำนวนที่ซื้อ, Me.ราคารวม})
        Me.DG.Location = New System.Drawing.Point(11, 19)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.Size = New System.Drawing.Size(619, 300)
        Me.DG.TabIndex = 0
        '
        'รหัสสินค้า
        '
        Me.รหัสสินค้า.HeaderText = "รหัสสินค้า"
        Me.รหัสสินค้า.Name = "รหัสสินค้า"
        Me.รหัสสินค้า.ReadOnly = True
        '
        'ชื่อสินค้า
        '
        Me.ชื่อสินค้า.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Name = "ชื่อสินค้า"
        Me.ชื่อสินค้า.ReadOnly = True
        Me.ชื่อสินค้า.Width = 200
        '
        'ราคาสินค้า
        '
        Me.ราคาสินค้า.HeaderText = "ราคาสินค้า"
        Me.ราคาสินค้า.Name = "ราคาสินค้า"
        Me.ราคาสินค้า.ReadOnly = True
        Me.ราคาสินค้า.Width = 80
        '
        'จำนวนที่ซื้อ
        '
        Me.จำนวนที่ซื้อ.HeaderText = "จำนวนที่ซื้อ"
        Me.จำนวนที่ซื้อ.Name = "จำนวนที่ซื้อ"
        Me.จำนวนที่ซื้อ.ReadOnly = True
        Me.จำนวนที่ซื้อ.Width = 90
        '
        'ราคารวม
        '
        Me.ราคารวม.HeaderText = "ราคารวม"
        Me.ราคารวม.Name = "ราคารวม"
        Me.ราคารวม.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_proqty)
        Me.GroupBox2.Controls.Add(Me.txt_proprice)
        Me.GroupBox2.Controls.Add(Me.txt_proname)
        Me.GroupBox2.Controls.Add(Me.txt_proid)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 92)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลสินค้า"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(465, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "ลบข้อมูล"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ลงข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_proqty
        '
        Me.txt_proqty.Location = New System.Drawing.Point(314, 58)
        Me.txt_proqty.Name = "txt_proqty"
        Me.txt_proqty.Size = New System.Drawing.Size(95, 20)
        Me.txt_proqty.TabIndex = 7
        '
        'txt_proprice
        '
        Me.txt_proprice.Location = New System.Drawing.Point(314, 25)
        Me.txt_proprice.Name = "txt_proprice"
        Me.txt_proprice.ReadOnly = True
        Me.txt_proprice.Size = New System.Drawing.Size(95, 20)
        Me.txt_proprice.TabIndex = 6
        '
        'txt_proname
        '
        Me.txt_proname.Location = New System.Drawing.Point(71, 58)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.ReadOnly = True
        Me.txt_proname.Size = New System.Drawing.Size(145, 20)
        Me.txt_proname.TabIndex = 5
        '
        'txt_proid
        '
        Me.txt_proid.Location = New System.Drawing.Point(72, 23)
        Me.txt_proid.Name = "txt_proid"
        Me.txt_proid.Size = New System.Drawing.Size(144, 20)
        Me.txt_proid.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "จำนวนขาย :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ราคาสินค้า :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ชื่อสินค้า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รหัสสินค้า :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "เลขที่การขาย :"
        '
        'txt_trid
        '
        Me.txt_trid.Location = New System.Drawing.Point(92, 33)
        Me.txt_trid.Name = "txt_trid"
        Me.txt_trid.ReadOnly = True
        Me.txt_trid.Size = New System.Drawing.Size(137, 20)
        Me.txt_trid.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "วันที่ :"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(295, 34)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(127, 20)
        Me.txt_date.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(714, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ราคารวม"
        '
        'sumprice
        '
        Me.sumprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sumprice.Cursor = System.Windows.Forms.Cursors.Default
        Me.sumprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.sumprice.Location = New System.Drawing.Point(607, 77)
        Me.sumprice.Multiline = True
        Me.sumprice.Name = "sumprice"
        Me.sumprice.ReadOnly = True
        Me.sumprice.Size = New System.Drawing.Size(322, 80)
        Me.sumprice.TabIndex = 8
        Me.sumprice.Text = "0.00"
        Me.sumprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(739, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 31)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "เงินที่รับมา"
        '
        'recive
        '
        Me.recive.BackColor = System.Drawing.Color.White
        Me.recive.Cursor = System.Windows.Forms.Cursors.Default
        Me.recive.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.recive.Location = New System.Drawing.Point(688, 201)
        Me.recive.Multiline = True
        Me.recive.Name = "recive"
        Me.recive.Size = New System.Drawing.Size(212, 59)
        Me.recive.TabIndex = 10
        Me.recive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(745, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 31)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "เงินทอน"
        '
        'ton
        '
        Me.ton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ton.Location = New System.Drawing.Point(690, 302)
        Me.ton.Multiline = True
        Me.ton.Name = "ton"
        Me.ton.ReadOnly = True
        Me.ton.Size = New System.Drawing.Size(210, 61)
        Me.ton.TabIndex = 12
        Me.ton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(696, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(203, 86)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "บันทึกข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_name.Location = New System.Drawing.Point(854, 6)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(56, 16)
        Me.lb_name.TabIndex = 14
        Me.lb_name.Text = "Label10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(728, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ผู้ใช้งานอยู่ขณะนี้ :"
        '
        'ออกจากระบบToolStripMenuItem
        '
        Me.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem"
        Me.ออกจากระบบToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 496)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.recive)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sumprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_trid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมบริหารจัดการร้านเจ๊ปุ๊ ยี่สิบบาท"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents การจดการขอมลToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents คลงสนคาToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents พนกงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ออกรายงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_proqty As TextBox
    Friend WithEvents txt_proprice As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents txt_proid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_trid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sumprice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DG As DataGridView
    Friend WithEvents รหัสสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ราคาสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนที่ซื้อ As DataGridViewTextBoxColumn
    Friend WithEvents ราคารวม As DataGridViewTextBoxColumn
    Friend WithEvents recive As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ton As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents ออกรายงานToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents รายงานการขายToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb_name As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents รายงานสนคาขายดToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานรายรบรายจายToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานขอมลพนกงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานขอมลสนคาToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents สงรายงานการขายไปทไลนToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ออกจากระบบToolStripMenuItem As ToolStripMenuItem
End Class
