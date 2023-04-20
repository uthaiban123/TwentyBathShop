Public Class Frm_สินค้าขายดี
    Private Sub Frm_สินค้าขายดี_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LOADTABLEDATA()
    End Sub

    Sub LOADTABLEDATA()
        ''แสดงข้อมูล
        ' Dim LOADDATA As DataTable = executesql("SELECT Pro_ID,Pro_Name,Pro_BuyOut FROM Tbl_Inventory Order BY Pro_BuyOut DESC")
        '  DataGridView1.DataSource = LOADDATA
        ' DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        ' DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        'DataGridView1.Columns(2).HeaderText = "ขายไป"


    End Sub
    Sub Reset()
        executesql("UPDATE Tbl_Inventory SET Pro_BuyOut = '0' ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("คุณต้องการรีเซ็ตจำนวนหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Reset()
                MsgBox("รีเซ็ตจำนวนเรียบร้อยแล้ว", MsgBoxStyle.Information)
                LOADTABLEDATA()
            Catch ex As Exception
                MsgBox("ไม่มีข้อมูลที่ สามารถรีเซ็ตจำนวนได้", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "SELECT TOP (5) Pro_ID, Pro_Name, Pro_Price, Pro_BuyOut
FROM Tbl_Inventory
ORDER BY Pro_BuyOut DESC"

        Dim report As New RP_สินค้าขายดี
        Dim reportdata As New Telerik.Reporting.SqlDataSource
        reportdata.ConnectionString = STRCON
        reportdata.SelectCommand = sql

        report.DataSource = reportdata
        ReportViewer1.ReportSource = report
        ReportViewer1.RefreshReport()
    End Sub
End Class