Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSach_XetLenLop
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal Tieu_de2 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = "KHOA " + dv.Item(0)("Ten_khoa").ToString.ToUpper
       

        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2

        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3

        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4

        Me.Tieu_de_bao_cao.Text = Tieu_de_bao_cao
        Me.Tieu_de2.Text = Tieu_de2
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tong_tiet.DataBindings.Add("Text", DataSource, "Tong_tiet")
        He_so_no.DataBindings.Add("Text", DataSource, "So_trinh_no")
        Ten_mon_no.DataBindings.Add("Text", DataSource, "Ten_mon_no")
        So_mon_no.DataBindings.Add("Text", DataSource, "So_mon_no")
    End Sub
End Class