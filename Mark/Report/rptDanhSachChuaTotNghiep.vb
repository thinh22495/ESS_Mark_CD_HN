Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSachChuaTotNghiep
    Public Sub New(Optional ByVal dt As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Me.Tieu_de_bao_cao2.Text = Tieu_de_bao_cao2
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv1")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten1")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh1", "{0:dd/MM/yyyy}")
        Ly_do.DataBindings.Add("Text", DataSource, "Ly_do")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHT1")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang1")
    End Sub
End Class