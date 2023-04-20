<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inventory
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txt_proid = New System.Windows.Forms.TextBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.txt_proprice = New System.Windows.Forms.TextBox()
        Me.txt_proqty = New System.Windows.Forms.TextBox()
        Me.txt_prounit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(424, 98)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(198, 48)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txt_proid
        '
        Me.txt_proid.Location = New System.Drawing.Point(215, 95)
        Me.txt_proid.Name = "txt_proid"
        Me.txt_proid.Size = New System.Drawing.Size(164, 20)
        Me.txt_proid.TabIndex = 1
        '
        'txt_proname
        '
        Me.txt_proname.Location = New System.Drawing.Point(215, 122)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.Size = New System.Drawing.Size(125, 20)
        Me.txt_proname.TabIndex = 2
        '
        'txt_proprice
        '
        Me.txt_proprice.Location = New System.Drawing.Point(215, 149)
        Me.txt_proprice.Name = "txt_proprice"
        Me.txt_proprice.Size = New System.Drawing.Size(70, 20)
        Me.txt_proprice.TabIndex = 3
        '
        'txt_proqty
        '
        Me.txt_proqty.Location = New System.Drawing.Point(215, 176)
        Me.txt_proqty.Name = "txt_proqty"
        Me.txt_proqty.Size = New System.Drawing.Size(50, 20)
        Me.txt_proqty.TabIndex = 4
        '
        'txt_prounit
        '
        Me.txt_prounit.Location = New System.Drawing.Point(215, 229)
        Me.txt_prounit.Name = "txt_prounit"
        Me.txt_prounit.Size = New System.Drawing.Size(55, 20)
        Me.txt_prounit.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ราคา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "บาท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ประเภทสินค้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "หน่วยนับ"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(70, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(657, 232)
        Me.DataGridView1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ลบข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(424, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 48)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "แก้ไขข้อมูล"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 48)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "เคลียร์ข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"สินค้าพลาสติก", "เครื่องเขียน", "เครื่องใช้ในครัว"})
        Me.ComboBox1.Location = New System.Drawing.Point(215, 202)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(255, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "จัดการข้อมูลคลังสินค้า"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(642, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 71)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "ค้นหาสินค้า"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(642, 178)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 71)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "สร้างบาร์โค้ด"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Frm_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 511)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_prounit)
        Me.Controls.Add(Me.txt_proqty)
        Me.Controls.Add(Me.txt_proprice)
        Me.Controls.Add(Me.txt_proname)
        Me.Controls.Add(Me.txt_proid)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Frm_Inventory"
        Me.Text = "คลังสินค้า"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txt_proid As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents txt_proprice As TextBox
    Friend WithEvents txt_proqty As TextBox
    Friend WithEvents txt_prounit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
