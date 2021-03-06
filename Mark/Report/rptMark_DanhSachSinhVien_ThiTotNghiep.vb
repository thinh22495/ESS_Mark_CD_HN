Imports DevExpress.XtraReports.UI
Public Class rptMark_DanhSachSinhVien_ThiTotNghiep
    Dim count As Integer = 0
    Dim mThi As Integer = 0
    Public Sub New(ByVal dv As DataView, ByVal Thi As Integer, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1

        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        mThi = Thi
        Me.DataSource = dv
        binding()
    End Sub

    Public Sub binding()
        If mThi = 0 Then
            Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
            Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
            Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
            Ten_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
            Me.Ten_sinh_vien.DataBindings.Add("Text", DataSource, "Ho_ten")
            Me.TBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
            Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
            Me.Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
        Else
            Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop2")
            Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc2")
            Ten_he.DataBindings.Add("Text", DataSource, "Ten_he2")
            Ten_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh2")
            Me.Ten_sinh_vien.DataBindings.Add("Text", DataSource, "Ho_ten2")
            Me.TBCHT.DataBindings.Add("Text", DataSource, "TBCHT2")
            Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv2")
            Me.Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang2")
        End If
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub
End Class
