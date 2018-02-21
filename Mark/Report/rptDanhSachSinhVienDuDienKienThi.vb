Public Class rptDanhSachSinhVienDuDienKienThi
    Public Sub New(Optional ByVal Ten_hoc_phan As String = "", Optional ByVal He As String = "", Optional ByVal Chuyen_nganh As String = "", Optional ByVal Ten_lop As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        'Me.Ten_hoc_phan.Text = Ten_hoc_phan
        'Me.He.Text = He
        'Me.Chuyen_nganh.Text = Chuyen_nganh
        'Me.Ten_lop.Text = Ten_lop
        Me.lblMon_thi.Text = Ten_hoc_phan
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.xNguoi_ky_1.Text = gTieu_de_nguoi_ki2
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
    End Sub
    Public Sub Binding()
        xHo_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        xTen.DataBindings.Add("Text", DataSource, "Ten")
        xNgay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        xLop.DataBindings.Add("Text", DataSource, "Ten_lop")
        xNoi_sinh.DataBindings.Add("Text", DataSource, "Noi_sinh")
        xGhi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub
End Class