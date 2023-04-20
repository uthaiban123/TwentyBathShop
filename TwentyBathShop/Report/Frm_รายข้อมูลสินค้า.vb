Public Class Frm_รายข้อมูลสินค้า
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT        Pro_ID, Pro_Name, Pro_Price, Pro_Qty, Pro_Type, Pro_Unit
FROM            Tbl_Inventory"
        Dim report As New RP_รายงานข้อมูลสินค้า
        Dim reportdata As New Telerik.Reporting.SqlDataSource
        reportdata.ConnectionString = STRCON
        reportdata.SelectCommand = sql



        report.DataSource = reportdata
        ReportViewer1.ReportSource = report
        ReportViewer1.RefreshReport()
    End Sub
End Class