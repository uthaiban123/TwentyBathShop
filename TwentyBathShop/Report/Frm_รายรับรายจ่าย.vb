Public Class Frm_รายรับรายจ่าย
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT        Tbl_TransectionSale.TR_ID, Tbl_TransectionSale.TR_Date, Tbl_TransectionSaleDetail.Product_ID, Tbl_TransectionSaleDetail.Product_Name, Tbl_TransectionSaleDetail.Product_Qty, Tbl_TransectionSaleDetail.Product_Price, 
                         Tbl_TransectionSaleDetail.Pro_Sumprice, Tbl_TransectionSale.TR_Sumprice, Tbl_PaidList.PR_ID, Tbl_PaidList.PR_NameProduct, Tbl_PaidList.PR_QtyProduct, Tbl_PaidList.PR_Price, Tbl_PaidList.PR_Date, 
                         Tbl_PaidList.PR_Sumprice
FROM            Tbl_TransectionSale LEFT OUTER JOIN
                         Tbl_TransectionSaleDetail ON Tbl_TransectionSale.TR_ID = Tbl_TransectionSaleDetail.TR_ID LEFT OUTER JOIN
                         Tbl_Inventory ON Tbl_TransectionSaleDetail.Product_ID COLLATE Thai_CI_AS = Tbl_Inventory.Pro_ID CROSS JOIN
                         Tbl_PaidList
WHERE Tbl_TransectionSale.TR_Date Between '" & Getdatestart(DateTimePicker1.Value) & "' and '" & Getdateend(DateTimePicker2.Value) & "'"
        Dim report As New RP_รายรับรายจ่าย
        Dim reportdata As New Telerik.Reporting.SqlDataSource
        reportdata.ConnectionString = STRCON
        reportdata.SelectCommand = sql

        report.DataSource = reportdata
        รายงาน.ReportSource = report
        รายงาน.RefreshReport()
    End Sub

    Private Sub Frm_รายรับรายจ่าย_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class