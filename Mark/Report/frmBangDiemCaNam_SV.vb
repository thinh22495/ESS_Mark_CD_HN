Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmBangDiemCaNam_SV
    Dim So_tt As Integer = 0
    Public Sub New(Optional ByVal ID_sv As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal Tieu_de_bao_cao As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de_bao_cao
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year

        Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
        Dim dt As DataTable = obj.Load_DiemHocKySV(ID_sv, Hoc_ky, Nam_hoc)

        If dt.Rows.Count > 0 Then
            Me.Ma_sv.Text = dt.Rows(0).Item("Ma_sv")
            Me.Ho_ten.Text = dt.Rows(0).Item("Ho_ten")
            Me.Ngay_sinh.Text = dt.Rows(0).Item("Ngay_sinh")
            Me.Que_quan.Text = dt.Rows(0).Item("Ten_tinh")
            Me.Ten_khoa.Text = dt.Rows(0).Item("Ten_khoa")
            Me.Chuyen_nganh.Text = dt.Rows(0).Item("Chuyen_nganh")
        Else
            Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
        End If

        Dim dt_dtb As DataTable = obj.rpt_DTB_HocKy(ID_sv, Hoc_ky, Nam_hoc)
        If dt_dtb.Rows.Count > 0 Then
            Me.CBCHP.Text = Math.Round(dt_dtb.Rows(0).Item("Diem_tb"), 2)
            Me.Xep_loai.Text = dt_dtb.Rows(0).Item("xh")
        End If
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ki1.Text = gTieu_de_nguoi_ki1
    End Sub
    Public Sub Binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        DVHT.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Diem_l1.DataBindings.Add("Text", DataSource, "TBCMH1")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
    End Sub

    Private Sub So_thutu_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles So_thutu.BeforePrint
        So_tt = So_tt + 1
        Me.So_thutu.Text = So_tt
    End Sub
End Class