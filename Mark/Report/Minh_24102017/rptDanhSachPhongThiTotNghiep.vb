Public Class rptDanhSachPhongThiTotNghiep
    Public Sub New(ByVal dvSource As DataView, ByVal Ten_mon_hoc As String, ByVal Ngay_thi As String)
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.DataSource = dvSource
        Me.lbl_Mon_thi.Text = Ten_mon_hoc
        Me.lbl_Ngay_thi.Text = Ngay_thi
        Me.lbl_Phong_thi.Text = dvSource.Item(0)("Ten_phong").ToString
        'Me.Ten_hoc_phan.Text = Ten_hoc_phan
        'Me.He.Text = He
        'Me.Chuyen_nganh.Text = Chuyen_nganh
        'Me.Ten_lop.Text = Ten_lop
        'Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        Binding()
    End Sub
    Public Sub Binding()
        xHo_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        xTen.DataBindings.Add("Text", DataSource, "Ten")
        xNgay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        xLop.DataBindings.Add("Text", DataSource, "Ten_lop")
        xDiem_thi.DataBindings.Add("Text", DataSource, "Diem_thi")
        xSo_phach.DataBindings.Add("Text", DataSource, "So_bao_danh")
        xGhi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub
End Class