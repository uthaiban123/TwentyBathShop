Public Class Searchemployee
    Private Sub Searchemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub LOADTABLEDATA1()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Employee Where Emp_Id LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสพนักงาน"
        DataGridView1.Columns(1).HeaderText = "ชื่อพนักงาน"
        DataGridView1.Columns(2).HeaderText = "ระดับพนักงาน"
        DataGridView1.Columns(3).HeaderText = "ที่อยู่พนักงาน"
        DataGridView1.Columns(4).HeaderText = "อีเมลล์พนักงาน"
        DataGridView1.Columns(5).HeaderText = "เบอร์โทรศัพท์"

    End Sub
    Sub LOADTABLEDATA2()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Employee Where Emp_Name LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสพนักงาน"
        DataGridView1.Columns(1).HeaderText = "ชื่อพนักงาน"
        DataGridView1.Columns(2).HeaderText = "ระดับพนักงาน"
        DataGridView1.Columns(3).HeaderText = "ที่อยู่พนักงาน"
        DataGridView1.Columns(4).HeaderText = "อีเมลล์พนักงาน"
        DataGridView1.Columns(5).HeaderText = "เบอร์โทรศัพท์"

    End Sub
    Sub LOADTABLEDATA3()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Employee Where Emp_Tel LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสพนักงาน"
        DataGridView1.Columns(1).HeaderText = "ชื่อพนักงาน"
        DataGridView1.Columns(2).HeaderText = "ระดับพนักงาน"
        DataGridView1.Columns(3).HeaderText = "ที่อยู่พนักงาน"
        DataGridView1.Columns(4).HeaderText = "อีเมลล์พนักงาน"
        DataGridView1.Columns(5).HeaderText = "เบอร์โทรศัพท์"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            'executesql("SELECT * FROM Tbl_Inventory Where Pro_ID LIKE '%" & TextBox1.Text & "%'")
            LOADTABLEDATA1()
        ElseIf RadioButton2.Checked = True Then
            'executesql("SELECT * FROM Tbl_Inventory Where Pro_Name LIKE '%" & TextBox1.Text & "%'")
            LOADTABLEDATA2()
        ElseIf RadioButton3.Checked = True Then
            'executesql("SELECT * FROM Tbl_Inventory Where Pro_Price LIKE '%" & TextBox1.Text & "%'")
            LOADTABLEDATA3()
        End If
    End Sub
End Class