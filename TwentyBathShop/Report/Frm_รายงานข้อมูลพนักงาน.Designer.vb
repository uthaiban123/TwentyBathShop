<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_รายงานข้อมูลพนักงาน
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.รายงาน = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.RP_รายงานข้อมูลพนักงาน1 = New TwentyBathShop.RP_รายงานข้อมูลพนักงาน()
        Me.ReportBook1 = New Telerik.Reporting.ReportBook()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.RP_รายงานข้อมูลพนักงาน1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'รายงาน
        '
        Me.รายงาน.Location = New System.Drawing.Point(0, 55)
        Me.รายงาน.Name = "รายงาน"
        Me.รายงาน.Size = New System.Drawing.Size(665, 375)
        Me.รายงาน.TabIndex = 0
        '
        'RP_รายงานข้อมูลพนักงาน1
        '
        Me.RP_รายงานข้อมูลพนักงาน1.Name = "RP_รายงานข้อมูลพนักงาน"
        '
        'ReportBook1
        '
        Me.ReportBook1.Reports.Add(Me.RP_รายงานข้อมูลพนักงาน1)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "แสดงรายงาน"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_รายงานข้อมูลพนักงาน
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 430)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.รายงาน)
        Me.Name = "Frm_รายงานข้อมูลพนักงาน"
        Me.Text = "รายงานข้อมูลพนักงาน"
        CType(Me.RP_รายงานข้อมูลพนักงาน1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents รายงาน As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents RP_รายงานข้อมูลพนักงาน1 As RP_รายงานข้อมูลพนักงาน
    Friend WithEvents ReportBook1 As Telerik.Reporting.ReportBook
    Friend WithEvents Button1 As Button
End Class
