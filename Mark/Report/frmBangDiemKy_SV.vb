Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmBangDiemKy_SV
    Dim So_tt As Integer = 0
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal Ma_sv As String = "", Optional ByVal Ho_ten As String = "", Optional ByVal Ngay_sinh As String = "", Optional ByVal Chuyen_nganh As String = "", Optional ByVal Ten_nganh As String = "", Optional ByVal Ten_tinh As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de_bao_cao
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ki1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ki2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ki3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ki4.Text = gTieu_de_nguoi_ki4

        Me.TBCHT.Text = dtMain.Rows(0)("TBCHT").ToString
        Me.Xep_loai.Text = dtMain.Rows(0)("Xep_loai").ToString
        Me.Ma_sv.Text = Ma_sv.ToString
        Me.Ho_ten.Text = Ho_ten.ToString
        Me.Ngay_sinh.Text = Ngay_sinh.ToString
        Me.Que_quan.Text = Ten_tinh.ToString
        Me.Ten_khoa.Text = Chuyen_nganh.ToString
        Me.Chuyen_nganh.Text = Ten_nganh.ToString
    End Sub
    Public Sub Binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        DVHT.DataBindings.Add("Text", DataSource, "So_tin_chi")
        Diem_l1.DataBindings.Add("Text", DataSource, "TBCMH1", "{0:n1}")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP_HienThi", "{0:n1}")
    End Sub

    Private Sub So_thutu_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles So_thutu.BeforePrint
        So_tt = So_tt + 1
        Me.So_thutu.Text = So_tt
    End Sub
End Class