Public Class rptDanhSachNoMon
    Public Sub New(ByVal dv As DataView, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.Hoc_ky.Text = Hoc_ky
        Me.Nam_hoc.Text = Nam_hoc
        Me.Tong_so.Text = "Tổng số: " & dv.Count
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Ten_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Khoa_hoc.DataBindings.Add("Text", DataSource, "Nien_khoa")
        So_mon.DataBindings.Add("Text", DataSource, "So_mon_no")
        Mon_hoc_lai.DataBindings.Add("Text", DataSource, "Ten_mon_hoc_lai")
        Mon_thi_lai.DataBindings.Add("Text", DataSource, "Ten_mon_thi_lai")
        DVHT.DataBindings.Add("Text", DataSource, "So_trinh_no")
    End Sub
End Class