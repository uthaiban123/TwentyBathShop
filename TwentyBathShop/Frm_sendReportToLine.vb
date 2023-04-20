Imports System.IO
Imports System.Net
Imports System.Text

Public Class Frm_sendReportToLine
    Private Sub Frm_sendReportToLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim showpriceSum As DataTable = executesql("Select sum(TR_Sumprice) as Total From Tbl_TransectionSale WHERE TR_Date Between '" & Getdatestart(DateTimePicker1.Value) & "' and '" & Getdateend(DateTimePicker2.Value) & "'")
        Try
            TextBox1.Text = showpriceSum(0)(0)
            TextBox1.Text = CDbl(TextBox1.Text).ToString("##,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Cursor.Current = Cursors.WaitCursor
            System.Net.ServicePointManager.Expect100Continue = False
            Dim request = DirectCast(WebRequest.Create(“https://notify-api.line.me/api/notify”), HttpWebRequest)
            Dim postData = String.Format(“message={0}”, "ยอดขายจากวันที่ " + DateTimePicker1.Value + " ถึงวันที่ " + DateTimePicker2.Value + " = ยอดเงิน " + TextBox1.Text + " บาท")
            Dim data = Encoding.UTF8.GetBytes(postData)
            request.Method = “POST”
            request.ContentType = “application/x-www-form-urlencoded”
            request.ContentLength = data.Length
            request.Headers.Add(“Authorization”, “Bearer uPo4w6XDKrBvK0LGURahzbqEjgHRmLxhMjERdynUKJb”)
            request.AllowWriteStreamBuffering = True
            request.KeepAlive = False
            request.Credentials = CredentialCache.DefaultCredentials
            Using stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using
            Dim response = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim responseString = New StreamReader(response.GetResponseStream()).ReadToEnd()
        Catch ex As Exception
            MessageBox.Show(ex.Message, “Error”, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            Cursor.Current = Cursors.Default
            MsgBox("ส่งรายงานยอดขายเรียบร้อยแล้ว", MsgBoxStyle.OkOnly, MessageBoxIcon.Information)
        End Try
    End Sub
End Class