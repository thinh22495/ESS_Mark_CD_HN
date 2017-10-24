Public Class rptDanhSachDuDieuKienThiChinhTri
    Public Sub New(ByVal dv As DataView, ByVal Tieu_de As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.Tieu_de_bao_cao.Text = Tieu_de
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Binding()
    End Sub
    Public Sub Binding()
        Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Diem.DataBindings.Add("Text", DataSource, "Diem_thi", "{0:n1}")
    End Sub
End Class