Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_TongHop_DSSV_HocLai
    Public Sub New(Optional ByVal dt As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Me.Tieu_de_bao_cao2.Text = Tieu_de_bao_cao2
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Diem.DataBindings.Add("Text", DataSource, "Diem")
        Ghi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

End Class