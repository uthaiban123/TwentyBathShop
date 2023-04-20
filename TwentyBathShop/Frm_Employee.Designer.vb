<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_emptel = New System.Windows.Forms.TextBox()
        Me.txt_empemail = New System.Windows.Forms.TextBox()
        Me.txt_empaddress = New System.Windows.Forms.TextBox()
        Me.txt_empname = New System.Windows.Forms.TextBox()
        Me.txt_empid = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(378, 192)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(198, 48)
        Me.BtnClear.TabIndex = 35
        Me.BtnClear.Text = "เคลียร์ข้อมูล"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(378, 132)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(96, 48)
        Me.BtnEdit.TabIndex = 34
        Me.BtnEdit.Text = "แก้ไขข้อมูล"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(480, 132)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(96, 48)
        Me.btnDel.TabIndex = 33
        Me.btnDel.Text = "ลบข้อมูล"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 232)
        Me.DataGridView1.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ชื่อพนักงาน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "รหัสพนักงาน"
        '
        'txt_emptel
        '
        Me.txt_emptel.Location = New System.Drawing.Point(132, 233)
        Me.txt_emptel.MaxLength = 10
        Me.txt_emptel.Name = "txt_emptel"
        Me.txt_emptel.Size = New System.Drawing.Size(140, 20)
        Me.txt_emptel.TabIndex = 24
        '
        'txt_empemail
        '
        Me.txt_empemail.Location = New System.Drawing.Point(132, 207)
        Me.txt_empemail.Name = "txt_empemail"
        Me.txt_empemail.Size = New System.Drawing.Size(156, 20)
        Me.txt_empemail.TabIndex = 23
        '
        'txt_empaddress
        '
        Me.txt_empaddress.Location = New System.Drawing.Point(132, 132)
        Me.txt_empaddress.Multiline = True
        Me.txt_empaddress.Name = "txt_empaddress"
        Me.txt_empaddress.Size = New System.Drawing.Size(212, 69)
        Me.txt_empaddress.TabIndex = 22
        '
        'txt_empname
        '
        Me.txt_empname.Location = New System.Drawing.Point(132, 78)
        Me.txt_empname.Name = "txt_empname"
        Me.txt_empname.Size = New System.Drawing.Size(180, 20)
        Me.txt_empname.TabIndex = 20
        '
        'txt_empid
        '
        Me.txt_empid.Location = New System.Drawing.Point(132, 51)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.Size = New System.Drawing.Size(70, 20)
        Me.txt_empid.TabIndex = 19
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(378, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(198, 48)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 29)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "จัดการข้อมูลพนักงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "ระดับพนักงาน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ที่อยู่พนักงาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "อีเมลล์พนักงาน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "เบอร์โทรศัพท์"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"พนักงานทั่วไป", "เจ้าของร้าน"})
        Me.ComboBox1.Location = New System.Drawing.Point(132, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(593, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 85)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_emptel)
        Me.Controls.Add(Me.txt_empemail)
        Me.Controls.Add(Me.txt_empaddress)
        Me.Controls.Add(Me.txt_empname)
        Me.Controls.Add(Me.txt_empid)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Frm_Employee"
        Me.Text = "จัดการข้อมูลพนักงาน"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_emptel As TextBox
    Friend WithEvents txt_empemail As TextBox
    Friend WithEvents txt_empaddress As TextBox
    Friend WithEvents txt_empname As TextBox
    Friend WithEvents txt_empid As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
