Public Class Frm_Paidlist
    Private Sub Frm_Paidlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoid()
    End Sub

    Sub calc()
        Dim ราคาสินค้ารวม As Double
        For i As Integer = 0 To DG.Rows.Count - 1
            ราคาสินค้ารวม += DG.Rows(i).Cells(3).Value
        Next
        TextBox2.Text = ราคาสินค้ารวม
        TextBox2.Text = CDbl(TextBox2.Text).ToString("##,##0.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_namepro.Text = "" Then
            MsgBox("กรุณากรอกชื่อสินค้าที่ซื้อ", MsgBoxStyle.Critical)
        End If
        If txt_proprice.Text = "" Then
            MsgBox("กรุณากรอกจำนวนที่ซื้อ", MsgBoxStyle.Critical)
        End If
        If txt_proqty.Text = "" Then
            MsgBox("กรุณากรอกราคาที่ซื้อ", MsgBoxStyle.Critical)
        End If
        Try
            Dim sumprice As Double = CDbl(txt_proprice.Text) * CDbl(txt_proqty.Text)
            DG.Rows.Add(txt_namepro.Text, txt_proprice.Text, txt_proqty.Text, sumprice, txt_disciption.Text)
        Catch ex As Exception

        End Try



        'txt_namepro.Clear()
        'txt_proqty.Clear()
        txt_namepro.Clear()
        txt_proprice.Clear()
        txt_proqty.Clear()
        txt_disciption.Clear()
        calc()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DG.Rows.Remove(DG.CurrentRow)
        Catch ex As Exception
            MsgBox("ไม่มีข้อมูล")
        End Try
        calc()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmdate.Tick
        TextBox3.Text = Now.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i As Integer = 0 To DG.Rows.Count - 1

            ' executesql("INSERT INTO Tbl_PaidList (PR_ID,PR_NameProduct,PR_Price,PR_QtyProduct,PR_Date,PR_Sumprice,PR_Disciption)
            '  VALUES ('" & TextBox1.Text & "','" & DG.Rows(i).Cells(0).Value.ToString() & "','" & DG.Rows(i).Cells(1).Value.ToString() & "','" & DG.Rows(i).Cells(2).Value.ToString() & "','GETDATE()','" & DG.Rows(i).Cells(3).Value.ToString() & "','" & DG.Rows(i).Cells(4).Value.ToString() & "')")


            executesql("INSERT INTO Tbl_PaidList (PR_ID,PR_NameProduct,PR_QtyProduct,PR_Price,PR_Date,PR_Sumprice,PR_Disciption)
            VALUES ('" & TextBox1.Text & "','" & DG.Rows(i).Cells(0).Value.ToString() & "','" & DG.Rows(i).Cells(2).Value.ToString() & "','" & DG.Rows(i).Cells(1).Value.ToString() & "',GETDATE(),'" & DG.Rows(i).Cells(3).Value.ToString() & "','" & DG.Rows(i).Cells(4).Value.ToString() & "')")

        Next

        MsgBox("บันทึกข้อมูลเรียบร้อย")
        TextBox2.Text = ""
        txt_proprice.Text = ""
        txt_proqty.Text = ""

        DG.Rows.Clear()
        autoid()
        txt_namepro.Focus()

    End Sub



    Sub autoid()
        Dim sql As String = "Select  ('PR' + SUBSTRING(CONVERT(NVARCHAR(4), YEAR(GETDATE()) + 543), 3, 2) + SUBSTRING(REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 103), '/', ''), 3, 2) + REPLICATE('0', 6 - LEN(IDENT_CURRENT('Tbl_PaidList'))) + CONVERT(NVARCHAR(6), IDENT_CURRENT('Tbl_PaidList'))) as autonum"
            Dim data As DataTable = executesql(sql)
        TextBox1.Text = data(0)("autonum").ToString
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

End Class