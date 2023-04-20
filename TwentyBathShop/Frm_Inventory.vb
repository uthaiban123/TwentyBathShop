Public Class Frm_Inventory
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txt_proid.Text = "" Then
            MsgBox("กรุณากรอกรหัสสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proname.Text = "" Then
            MsgBox("กรุณากรอกชื่อสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proprice.Text = "" Then
            MsgBox("กรุณากรอกราคาสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proqty.Text = "" Then
            MsgBox("กรุณากรอกจำนวนสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("กรุณากรอกประเภทสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_prounit.Text = "" Then
            MsgBox("กรุณากรอกหน่วยนับสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' Checkdataid
        Dim checkdata As DataTable = executesql("SELECT Pro_ID FROM Tbl_Inventory WHERE Pro_ID='" & txt_proid.Text & "'")
        If checkdata.Rows.Count > 0 Then
            MsgBox("มีรหัสสินค้าซ้ำในระบบอยู่แล้ว", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("คุณต้องการบันทึกข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            executesql("INSERT INTO Tbl_Inventory (Pro_ID,Pro_Name,Pro_Price,Pro_Qty,Pro_Type,Pro_Unit,Pro_BuyOut) VALUES 
('" & txt_proid.Text & "','" & txt_proname.Text & "','" & txt_proprice.Text & "','" & txt_proqty.Text & "','" & ComboBox1.Text & "','" & txt_prounit.Text & "','0')")

            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            txt_proid.Clear()
            txt_proname.Clear()
            txt_proprice.Clear()
            txt_proqty.Clear()
            ComboBox1.Text = ""
            txt_prounit.Clear()

            LOADTABLEDATA()
        End If


    End Sub
    Sub LOADTABLEDATA()
        ''แสดงข้อมูล
        Dim LOADDATA As DataTable = executesql("SELECT * FROM Tbl_Inventory")
        DataGridView1.DataSource = LOADDATA
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาสินค้า"
        DataGridView1.Columns(3).HeaderText = "จำนวนสินค้า"
        DataGridView1.Columns(4).HeaderText = "ประเภทสสินค้า"
        DataGridView1.Columns(5).HeaderText = "หน่วยนับสินค้า"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N2"

    End Sub
    Private Sub txt_proprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_proprice.KeyPress
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

    Private Sub txt_proqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_proqty.KeyPress
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

    Private Sub Frm_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADTABLEDATA()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If MsgBox("คุณต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                executesql("DELETE FROM Tbl_Inventory WHERE Pro_ID = '" & DataGridView1.CurrentRow.Cells(0).Value & "'")
                MsgBox("ลบข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
                LOADTABLEDATA()
            Catch ex As Exception
                MsgBox("ไม่มีข้อมูลที่ สามารถลบได้", MsgBoxStyle.Critical)
            End Try
        End If



    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txt_proid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_proname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_proprice.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_proprice.Text = CDbl(txt_proprice.Text).ToString("##,##0.00")
        txt_proqty.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_prounit.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_proid.Text = "" Then
            MsgBox("กรุณากรอกรหัสสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proname.Text = "" Then
            MsgBox("กรุณากรอกชื่อสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proprice.Text = "" Then
            MsgBox("กรุณากรอกราคาสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_proqty.Text = "" Then
            MsgBox("กรุณากรอกจำนวนสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("กรุณากรอกประเภทสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_prounit.Text = "" Then
            MsgBox("กรุณากรอกหน่วยนับสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If

        executesql("UPDATE Tbl_Inventory SET Pro_Name='" & txt_proname.Text & "',Pro_Price='" & txt_proprice.Text & "',
Pro_Qty='" & txt_proqty.Text & "',Pro_Type='" & ComboBox1.Text & "',Pro_Unit='" & txt_prounit.Text & "'WHERE Pro_id='" & txt_proid.Text & "'")

        txt_proid.Clear()
        txt_proname.Clear()
        txt_proprice.Clear()
        txt_proqty.Clear()
        ComboBox1.Text = ""
        txt_prounit.Clear()
        MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        LOADTABLEDATA()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_proid.Clear()
        txt_proname.Clear()
        txt_proprice.Clear()
        txt_proqty.Clear()
        ComboBox1.Text = ""
        txt_prounit.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SearchInvetory.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Frm_GenerateBarcode.Show()

    End Sub
End Class