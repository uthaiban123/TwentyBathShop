Public Class Frm_Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_id.Text = "" Then
            txt_id.Focus()
            Exit Sub
        End If
        If txt_tel.Text = "" Then
            txt_tel.Focus()
            Exit Sub
        End If
        Dim Selectemp As DataTable = executesql("SELECT * FROM Tbl_Employee WHERE Emp_Id='" & txt_id.Text & "' and Emp_Tel='" & txt_tel.Text & "'")
        If Selectemp.Rows.Count > 0 Then
            Frm_Main.lb_name.Text = Selectemp(0)(1)
            Frm_Main.Show()
            Me.Hide()

        Else
            MsgBox("ไม่เจอผู้ใช้งานในระบบ", MsgBoxStyle.Critical)
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class