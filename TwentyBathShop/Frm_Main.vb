Public Class Frm_Main
    Private Sub คลงสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คลงสนคาToolStripMenuItem.Click

        Frm_Inventory.Show()

    End Sub

    Private Sub พนกงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles พนกงานToolStripMenuItem.Click
        Frm_Employee.Show()

    End Sub

    Private Sub txt_proid_TextChanged(sender As Object, e As EventArgs) Handles txt_proid.TextChanged
        Dim Product_data As DataTable = executesql("SELECT Pro_id,Pro_Name,Pro_Price FROM Tbl_Inventory WHERE Pro_id='" & txt_proid.Text & "'")
        If Product_data.Rows.Count > 0 Then
            txt_proname.Text = Product_data(0)("Pro_Name")
            txt_proprice.Text = Product_data(0)("Pro_Price")
            txt_proqty.Focus()
        Else
            txt_proname.Clear()
            txt_proprice.Clear()

        End If
    End Sub

    Private Sub recive_TextChanged(sender As Object, e As EventArgs) Handles recive.TextChanged
        Try
            ton.Text = CDbl(recive.Text) - CDbl(sumprice.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_proname.Text = "" Then
            MsgBox("กรุณากรอกรหัสสินค้าให้ถูกต้อง", MsgBoxStyle.Critical)
        End If
        If txt_proqty.Text = "" Then
            MsgBox("กรุณากรอกจำนวนที่ขาย", MsgBoxStyle.Critical)
        End If
        If txt_proqty.Text = "0" Then
            MsgBox("กรุณากรอกจำนวนที่ขายให้ถูกต้อง", MsgBoxStyle.Critical)
        End If
        Dim sumprice As Double = CDbl(txt_proprice.Text) * CDbl(txt_proqty.Text)
        DG.Rows.Add(txt_proid.Text, txt_proname.Text, txt_proprice.Text, txt_proqty.Text, sumprice)

        txt_proid.Clear()
        txt_proqty.Clear()
        calc()
        txt_proid.Focus()

    End Sub
    Sub calc()
        Dim ราคาสินค้ารวม As Double
        For i As Integer = 0 To DG.Rows.Count - 1
            ราคาสินค้ารวม += DG.Rows(i).Cells(4).Value
        Next
        sumprice.Text = ราคาสินค้ารวม
        sumprice.Text = CDbl(sumprice.Text).ToString("##,##0.00")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DG.Rows.Remove(DG.CurrentRow)
        Catch ex As Exception
            MsgBox("ไม่มีข้อมูล")
        End Try
        calc()

        'ton.Text = ""
        'recive.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_date.Text = Now.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ton.Text < 0 Then
            MsgBox("รับเงินมาไม่ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If recive.Text <= 0 Then
            MsgBox("รับเงินมาไม่ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'บันทึกข้อมูลหลัก
        executesql("INSERT INTO Tbl_TransectionSale 
        (TR_ID,TR_DATE,TR_Sumprice,TR_Recivemoney,TR_Tonmoney) 
        VALUES ('" & txt_trid.Text & "',GETDATE(),'" & sumprice.Text & "','" & recive.Text & "','" & ton.Text & "')")
        'บันทึกข้อมูลรอง
        For i As Integer = 0 To DG.Rows.Count - 1

            executesql("INSERT INTO Tbl_TransectionSaleDetail(TR_ID,Product_ID,Product_Name,Product_Price,Product_Qty,Pro_Sumprice)
            VALUES ('" & txt_trid.Text & "','" & DG.Rows(i).Cells(0).Value & "','" & DG.Rows(i).Cells(1).Value & "','" & DG.Rows(i).Cells(2).Value & "','" & DG.Rows(i).Cells(3).Value & "','" & DG.Rows(i).Cells(4).Value & "')")


                'ตัดสต็อก
                executesql("UPDATE Tbl_Inventory SET Pro_Qty = Pro_Qty - '" & DG.Rows(i).Cells(3).Value & "' WHERE Pro_ID ='" & DG.Rows(i).Cells(0).Value & "' ")
            'เพิ่มจำนวนที่ขาย
            executesql("UPDATE Tbl_Inventory SET Pro_BuyOut = Pro_BuyOut + '" & DG.Rows(i).Cells(3).Value & "' WHERE Pro_ID ='" & DG.Rows(i).Cells(0).Value & "' ")
        Next
        MsgBox("บันทึกข้อมูลเรียบร้อย")
        sumprice.Text = "0.00"
        recive.Text = ""
        ton.Text = "0.00"

        DG.Rows.Clear()
        autoid()
        txt_proid.Focus()

    End Sub
    Sub autoid()
        Dim sql As String = "SELECT  ('TR' + SUBSTRING(CONVERT(NVARCHAR(4), YEAR(GETDATE()) + 543), 3, 2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 103), '/', ''), 3, 2) + REPLICATE('0', 6 - LEN(IDENT_CURRENT('Tbl_TransectionSale'))) + CONVERT(NVARCHAR(6), IDENT_CURRENT('Tbl_TransectionSale'))) as autonum"
        Dim data As DataTable = executesql(sql)
        txt_trid.Text = data(0)("autonum").ToString
    End Sub

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoid()
        txt_proid.Focus()

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

    Private Sub รายงานการขายToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานการขายToolStripMenuItem.Click
        Frm_รายงานการขายสินค้า.Show()

    End Sub

    Private Sub txt_proqty_TextChanged(sender As Object, e As EventArgs) Handles txt_proqty.TextChanged

    End Sub

    Private Sub รายงานสนคาขายดToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานสนคาขายดToolStripMenuItem.Click
        Frm_สินค้าขายดี.Show()
    End Sub

    Private Sub ออกรายงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกรายงานToolStripMenuItem.Click
        Frm_Paidlist.Show()

    End Sub

    Private Sub รายงานรายรบรายจายToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานรายรบรายจายToolStripMenuItem.Click
        Frm_รายรับรายจ่าย.Show()

    End Sub

    Private Sub รายงานขอมลพนกงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลพนกงานToolStripMenuItem.Click
        Frm_รายงานข้อมูลพนักงาน.Show()

    End Sub

    Private Sub รายงานขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอมลสนคาToolStripMenuItem.Click
        Frm_รายข้อมูลสินค้า.Show()

    End Sub

    Private Sub สงรายงานการขายไปทไลนToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สงรายงานการขายไปทไลนToolStripMenuItem.Click
        Frm_sendReportToLine.Show()

    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        If MsgBox("คุณต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Frm_Login.Close()
            Me.Dispose()
        End If


    End Sub
End Class
