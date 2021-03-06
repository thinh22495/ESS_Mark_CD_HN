Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSachSinhVienNoTheoHocPhan
    Public Sub New(ByVal dv As DataView, ByVal Tieu_de_BC As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.Hoc_ky.Text = Hoc_ky
        Me.Nam_hoc.Text = Nam_hoc
        Me.Tieu_de.Text = Tieu_de_BC
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Diem_thi.DataBindings.Add("Text", DataSource, "Diem_thi")
        Diem_HP.DataBindings.Add("Text", DataSource, "Diem_HP")
        Khoa_hoc.DataBindings.Add("Text", DataSource, "Nien_khoa")
        Hoc_phan.DataBindings.Add("Text", DataSource, "Hoc_phan")
        XrLabel4.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
    End Sub
End Class