Public Class Frm_รายงานการขายสินค้า
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT Tbl_TransectionSale.TR_ID, Tbl_TransectionSale.TR_Date, Tbl_TransectionSale.TR_Sumprice, Tbl_TransectionSale.TR_Recivemoney, Tbl_TransectionSale.TR_Tonmoney, Tbl_TransectionSaleDetail.Product_ID, Tbl_TransectionSaleDetail.Product_Name, Tbl_TransectionSaleDetail.Product_Price, Tbl_TransectionSaleDetail.Product_Qty, Tbl_TransectionSaleDetail.Pro_Sumprice FROM Tbl_TransectionSale INNER JOIN Tbl_TransectionSaleDetail ON Tbl_TransectionSale.TR_ID = Tbl_TransectionSaleDetail.TR_ID 
WHERE Tbl_TransectionSale.TR_Date Between '" & Getdatestart(DateTimePicker1.Value) & "' and '" & Getdateend(DateTimePicker2.Value) & "'"
        Dim report As New RP_รายงานการขาย
        Dim reportdata As New Telerik.Reporting.SqlDataSource
        reportdata.ConnectionString = STRCON
        reportdata.SelectCommand = sql
        'ส่งค่ารายงานรวมไปยังรายงาน
        Dim รายงานดาต้า As DataTable = executesql("select sum(TR_Sumprice) as Total, sum(TR_Recivemoney) as ReciveMoney, sum(TR_Tonmoney) as TonMoney from Tbl_TransectionSale
WHERE TR_Date Between '" & Getdatestart(DateTimePicker1.Value) & "' and '" & Getdateend(DateTimePicker2.Value) & "'")

        Try
            report.TextBox18.Value = รายงานดาต้า(0)("Total")
            report.TextBox17.Value = รายงานดาต้า(0)("ReciveMoney")
            report.TextBox16.Value = รายงานดาต้า(0)("TonMoney")

            report.TextBox18.Value = CDbl(report.TextBox18.Value).ToString("##,##0.00")
            report.TextBox17.Value = CDbl(report.TextBox17.Value).ToString("##,##0.00")
            report.TextBox16.Value = CDbl(report.TextBox16.Value).ToString("##,##0.00")
        Catch ex As Exception

        End Try


        report.DataSource = reportdata
        รายงาน.ReportSource = report
        รายงาน.RefreshReport()

    End Sub
End Class