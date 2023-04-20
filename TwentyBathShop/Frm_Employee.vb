Imports System.Text.RegularExpressions

Public Class Frm_Employee
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txt_empid.Text = "" Then
            MsgBox("กรุณากรอกรหัสพนักงาน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_empname.Text = "" Then
            MsgBox("กรุณากรอกชื่อพนักงาน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("กรุณากรอกระดับพนักงาน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_empaddress.Text = "" Then
            MsgBox("กรุณากรอกที่อยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_empemail.Text = "" Then
            MsgBox("กรุณากรอกอีเมลล์", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_emptel.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทร", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ' Checkdataid
        Dim checkdata As DataTable = executesql("SELECT Emp_Id FROM Tbl_Employee WHERE Emp_Id='" & txt_empid.Text & "'")
        If checkdata.Rows.Count > 0 Then
            MsgBox("มีรหัสพนักงานซ้ำในระบบอยู่แล้ว", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("คุณต้องการบันทึกข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            executesql("INSERT INTO Tbl_Employee (Emp_Id,Emp_Name,Emp_Level,Emp_Address,Emp_Email,Emp_Tel) VALUES 
('" & txt_empid.Text & "','" & txt_empname.Text & "','" & ComboBox1.Text & "','" & txt_empaddress.Text & "','" & txt_empemail.Text & "','" & txt_emptel.Text & "')")

            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            LOADTABLEDATA()
            txt_empid.Clear()
            txt_empname.Clear()
            ComboBox1.Text = ""
            txt_empaddress.Clear()
            txt_empemail.Clear()
            txt_emptel.Clear()
            LOADTABLEDATA()

        End If

    End Sub

    Sub LOADTABLEDATA()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Employee")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสพนักงาน"
        DataGridView1.Columns(1).HeaderText = "ชื่อพนักงาน"
        DataGridView1.Columns(2).HeaderText = "ระดับพนักงาน"
        DataGridView1.Columns(3).HeaderText = "ที่อยู่พนักงาน"
        DataGridView1.Columns(4).HeaderText = "อีเมลล์พนักงาน"
        DataGridView1.Columns(5).HeaderText = "เบอร์โทรศัพท์"


    End Sub

    Private Sub Frm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADTABLEDATA()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If MsgBox("คุณต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                executesql("DELETE FROM Tbl_Employee WHERE Emp_Id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'")
                MsgBox("ลบข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
                txt_empid.Clear()
                txt_empname.Clear()
                ComboBox1.Text = ""
                txt_empaddress.Clear()
                txt_empemail.Clear()
                txt_emptel.Clear()
                LOADTABLEDATA()
            Catch ex As Exception
                MsgBox("ไม่มีข้อมูลที่ สามารถลบได้", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_empid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_empname.Text = DataGridView1.CurrentRow.Cells(1).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_empaddress.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_empemail.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_emptel.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txt_empid.Clear()
        txt_empname.Clear()
        ComboBox1.Text = ""
        txt_empaddress.Clear()
        txt_empemail.Clear()
        txt_emptel.Clear()
    End Sub
    Private Sub txt_emptel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_emptel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
                'MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txt_empemail_TextChanged(sender As Object, e As EventArgs) Handles txt_empemail.TextChanged
        txt_empemail.BackColor = Color.White
        Dim temp As String
        temp = txt_empemail.Text
        If emailaddresscheck(temp) = True Then
            txt_empemail.BackColor = Color.Green
        Else
            txt_empemail.BackColor = Color.Yellow
        End If
    End Sub
    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click


        executesql("UPDATE Tbl_Employee SET Emp_Name='" & txt_empname.Text & "',Emp_Level='" & ComboBox1.Text & "',
Emp_Address='" & txt_empaddress.Text & "',Emp_Email='" & txt_empemail.Text & "',Emp_Tel='" & txt_emptel.Text & "'WHERE Emp_Id='" & txt_empid.Text & "'")

        txt_empid.Clear()
        txt_empname.Clear()
        ComboBox1.Text = ""
        txt_empaddress.Clear()
        txt_empemail.Clear()
        txt_emptel.Clear()
        MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        LOADTABLEDATA()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Searchemployee.Show()

    End Sub
End Class