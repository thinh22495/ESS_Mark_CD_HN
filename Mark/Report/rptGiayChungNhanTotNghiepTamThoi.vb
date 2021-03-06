Public Class rptGiayChungNhanTotNghiepTamThoi
    Public Sub New(ByVal dv As DataView, ByVal So_QD1 As String, ByVal So_QD2 As String, ByVal So_QD3 As String)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        'Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        'Me.So_QD.Text = So_QD1.ToString
        Me.So_QD2.Text = So_QD2.ToString
        Me.So_QD3.Text = So_QD3.ToString
        Dim ngay As Integer = DateTime.Now.Day
        Dim Ngay_HT As String = ""
        If ngay < 10 Then
            Ngay_HT = "0" & ngay.ToString
        Else
            Ngay_HT = ngay.ToString
        End If
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        'Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & Ngay_HT.ToString & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
        Nien_khoa.DataBindings.Add("Text", DataSource, "Nien_khoa")
    End Sub
End Class