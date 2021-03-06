Public Class rptGiayChungNhanHoanThanhKhoaHoc
    Public Sub New(ByVal dv As DataView, ByVal So_QD1 As String, ByVal So_QD2 As String)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        'Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        'Me.So_QD.Text = So_QD1.ToString
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        'Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten1")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh1", "{0:dd/MM/yyyy}")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh1")
        Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh1")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh1")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he1")
        Nien_khoa.DataBindings.Add("Text", DataSource, "Nien_khoa1")
    End Sub
End Class