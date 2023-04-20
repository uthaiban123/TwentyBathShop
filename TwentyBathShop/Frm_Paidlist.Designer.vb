<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Paidlist
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.ชื่อสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคาสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคารวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.หมายเหตุ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_proqty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_disciption = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_proprice = New System.Windows.Forms.TextBox()
        Me.txt_namepro = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tmdate = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 399)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายการ"
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อสินค้า, Me.ราคาสินค้า, Me.จำนวนสินค้า, Me.ราคารวม, Me.หมายเหตุ})
        Me.DG.Location = New System.Drawing.Point(6, 19)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(473, 374)
        Me.DG.TabIndex = 0
        '
        'ชื่อสินค้า
        '
        Me.ชื่อสินค้า.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Name = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Width = 120
        '
        'ราคาสินค้า
        '
        Me.ราคาสินค้า.HeaderText = "ราคาสินค้า"
        Me.ราคาสินค้า.Name = "ราคาสินค้า"
        Me.ราคาสินค้า.Width = 60
        '
        'จำนวนสินค้า
        '
        Me.จำนวนสินค้า.HeaderText = "จำนวนสินค้า"
        Me.จำนวนสินค้า.Name = "จำนวนสินค้า"
        Me.จำนวนสินค้า.Width = 60
        '
        'ราคารวม
        '
        Me.ราคารวม.HeaderText = "ราคารวม"
        Me.ราคารวม.Name = "ราคารวม"
        Me.ราคารวม.Width = 70
        '
        'หมายเหตุ
        '
        Me.หมายเหตุ.HeaderText = "หมายเหตุ"
        Me.หมายเหตุ.Name = "หมายเหตุ"
        Me.หมายเหตุ.Width = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "วันที่ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "เลขที่การจ่าย :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_proqty)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_disciption)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_proprice)
        Me.GroupBox2.Controls.Add(Me.txt_namepro)
        Me.GroupBox2.Location = New System.Drawing.Point(503, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 335)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ลงข้อมูลรายจ่าย"
        '
        'txt_proqty
        '
        Me.txt_proqty.Location = New System.Drawing.Point(98, 148)
        Me.txt_proqty.Multiline = True
        Me.txt_proqty.Name = "txt_proqty"
        Me.txt_proqty.Size = New System.Drawing.Size(103, 28)
        Me.txt_proqty.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "จำนวน :"
        '
        'txt_disciption
        '
        Me.txt_disciption.Location = New System.Drawing.Point(98, 199)
        Me.txt_disciption.Multiline = True
        Me.txt_disciption.Name = "txt_disciption"
        Me.txt_disciption.Size = New System.Drawing.Size(207, 100)
        Me.txt_disciption.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "หมายเหตุ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "บาท"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ราคา :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "สินค้า :"
        '
        'txt_proprice
        '
        Me.txt_proprice.Location = New System.Drawing.Point(98, 91)
        Me.txt_proprice.Multiline = True
        Me.txt_proprice.Name = "txt_proprice"
        Me.txt_proprice.Size = New System.Drawing.Size(103, 28)
        Me.txt_proprice.TabIndex = 1
        '
        'txt_namepro
        '
        Me.txt_namepro.Location = New System.Drawing.Point(98, 40)
        Me.txt_namepro.Multiline = True
        Me.txt_namepro.Name = "txt_namepro"
        Me.txt_namepro.Size = New System.Drawing.Size(153, 28)
        Me.txt_namepro.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(509, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 51)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ลงข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(669, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 110)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "บันทึก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(509, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 51)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "ลบข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LawnGreen
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(262, 13)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(229, 58)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmdate
        '
        Me.tmdate.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(98, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(124, 20)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Paidlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 492)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Paidlist"
        Me.Text = "ระบบเก็บข้อมูลรายจ่าย"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DG As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_disciption As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_proprice As TextBox
    Friend WithEvents txt_namepro As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_proqty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tmdate As Timer
    Friend WithEvents ชื่อสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ราคาสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ราคารวม As DataGridViewTextBoxColumn
    Friend WithEvents หมายเหตุ As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
