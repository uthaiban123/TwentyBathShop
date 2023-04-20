Public Class Frm_GenerateBarcode
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = TextBox1.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code39, TextBox1.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            MsgBox(result.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OD As New OpenFileDialog
        OD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If OD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Load(OD.FileName)
            Catch ex As Exception

            End Try
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

    Private Sub Frm_GenerateBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADTABLEDATA()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value

    End Sub
End Class