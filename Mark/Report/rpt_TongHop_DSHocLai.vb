Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_TongHop_DSHocLai
    Public Sub New(Optional ByVal dt As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng" & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Me.Tieu_de_bao_cao2.Text = Tieu_de_bao_cao2
    End Sub
    Public Sub Binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        So_sinh_vien.DataBindings.Add("Text", DataSource, "So_sv")
    End Sub

End Class