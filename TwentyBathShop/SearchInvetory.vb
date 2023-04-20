Public Class SearchInvetory
    Private Sub SearchInvetory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioButton1.Checked = True Then
            TextBox1.Clear()
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Clear()
        ElseIf RadioButton3.Checked = True Then
            TextBox1.Clear()

        End If
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
    Sub LOADTABLEDATA1()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Inventory Where Pro_ID LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาสินค้า"
        DataGridView1.Columns(3).HeaderText = "จำนวนสินค้า"
        DataGridView1.Columns(4).HeaderText = "ประเภทสสินค้า"
        DataGridView1.Columns(5).HeaderText = "หน่วยนับสินค้า"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"

    End Sub
    Sub LOADTABLEDATA2()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Inventory Where Pro_Name LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาสินค้า"
        DataGridView1.Columns(3).HeaderText = "จำนวนสินค้า"
        DataGridView1.Columns(4).HeaderText = "ประเภทสสินค้า"
        DataGridView1.Columns(5).HeaderText = "หน่วยนับสินค้า"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"

    End Sub
    Sub LOADTABLEDATA3()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Inventory Where Pro_Price LIKE '%" & TextBox1.Text & "%'")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาสินค้า"
        DataGridView1.Columns(3).HeaderText = "จำนวนสินค้า"
        DataGridView1.Columns(4).HeaderText = "ประเภทสสินค้า"
        DataGridView1.Columns(5).HeaderText = "หน่วยนับสินค้า"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"

    End Sub
End Class