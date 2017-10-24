Public Class rpt_KetQuaThiKetThucMonHoc_Mau04a
    Public Sub New(ByVal dvSource As DataView, ByVal Ten_mon_hoc As String, ByVal Ngay_thi As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DataSource = dvSource
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.lbl_Ten_mon_hoc.Text = Ten_mon_hoc
        Me.lbl_Lop.Text = dvSource.Item(0)("Ten_lop").ToString
        Me.lbl_Ngay_thi.Text = Ngay_thi
        'Me.Ten_hoc_phan.Text = Ten_hoc_phan
        'Me.He.Text = He
        'Me.Chuyen_nganh.Text = Chuyen_nganh
        'Me.Ten_lop.Text = Ten_lop
        'Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        'Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        'Tieu_de_noi_ky.Text = gTieu_de_noi_ki & " Ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        ' Add any initialization after the InitializeComponent() call.

        Binding()
    End Sub
    Private Sub Binding()
        xHo_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        xTen.DataBindings.Add("Text", DataSource, "Ten")
        'xDiem_TBC.DataBindings.Add("Text", DataSource, "TBCBP")
        'xSo_gio_nghi.DataBindings.Add("Text", DataSource, "So_tiet_nghi")
        'xGhi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

End Class