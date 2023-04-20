Public Class Frm_รายงานข้อมูลพนักงาน
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT        Emp_Id, Emp_Name, Emp_Level, Emp_Address, Emp_Email, Emp_Tel
FROM            Tbl_Employee"
        Dim report As New RP_รายงานข้อมูลพนักงาน
        Dim reportdata As New Telerik.Reporting.SqlDataSource
        reportdata.ConnectionString = STRCON
        reportdata.SelectCommand = sql



        report.DataSource = reportdata
        รายงาน.ReportSource = report
        รายงาน.RefreshReport()

    End Sub
End Class