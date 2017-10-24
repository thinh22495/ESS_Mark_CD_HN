Public Class rptTongHopNhapDiem
    Private dtsource As DataTable
    Public Sub New(ByVal dt As DataTable, ByVal tieu_de As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.dtsource = dt
        Dim dataMain As DataTable = dt.DefaultView.ToTable(True, New String() {"Khoa_hoc"})
        Me.DataSource = dataMain
        ' Add any initialization after the InitializeComponent() call.
        binding()
        Me.Tieu_de.Text = tieu_de
        Me.ReportFooter.PrintAtBottom = True
    End Sub
    Public Sub binding()
        Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + GetReportDate()
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptTongHopNhapDiemSub = XrSubreport1.ReportSource
        Dim dv As DataView = dtsource.DefaultView
        If Khoa_hoc.Text > 0 Then
            dv.RowFilter = "Khoa_hoc=" + Khoa_hoc.Text
        End If
        rpt.DataSource = dv
        rpt.binding()
    End Sub
End Class