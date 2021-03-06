Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_DS_ToChucThi_PhieuTheoDoi_LyThuyet
    Public Sub New(ByVal mdv As DataView, ByVal dtPlus As DataTable)
        InitializeComponent()
        Dim dv As DataView = mdv
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_truong
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        'Me.lblPhongThi.Text = "Ngày Thi/KT..............................* Thời gian Thi/KT..........phút *Từ..........đến............... * Phòng Thi/KT " & dt.Rows(0).Item("Ten_phong").ToString
        'Me.Ngay_thi.Text = dt.Rows(0).Item("Ngay_thi").ToString
        'Me.Thoi_gian_thi.Text = dt.Rows(0).Item("Thoi_gian").ToString
        'Me.Ngay_thang_nam.Text = gTieu_de_noi_ki & ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Binding()
        txtTen_lop.Text = dtPlus.Rows(0)("Ten_lop")
        Me.Tieu_de_bao_cao.Text = dtPlus.Rows(0)("Tieu_de_bao_cao")
        Ten_mon.Text = dtPlus.Rows(0)("Ten_mon")
        Thoi_gian_thi.Text = dtPlus.Rows(0)("Thoi_gian_thi")
        Ngay_thi.Text = dtPlus.Rows(0)("Ngay_thi")
        Phong_thi.Text = dtPlus.Rows(0)("Phong_thi")
        Me.DataSource = mdv
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_dem")
        Ten.DataBindings.Add("Text", DataSource, "Ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        SBD.DataBindings.Add("Text", DataSource, "So_bao_danh")
        lbGhi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub
End Class