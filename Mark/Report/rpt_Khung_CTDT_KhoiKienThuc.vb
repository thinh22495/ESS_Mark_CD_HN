Imports System.Drawing.Drawing2D
Imports DevExpress.XtraReports.UI
Public Class rpt_Khung_CTDT_KhoiKienThuc
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "", Optional ByVal Tieu_de_bao_cao3 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Dim dv As DataView = dtSub.DefaultView
        dv.Sort = "Kien_thuc, Ky_hieu "
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ten_kien_thuc.DataBindings.Add("Text", DataSource, "Ten_kien_thuc")

        'Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        Ly_thuyet.DataBindings.Add("Text", DataSource, "Ly_thuyet")
        Thuc_hanh.DataBindings.Add("Text", DataSource, "Thuc_hanh")
        Kiem_tra.DataBindings.Add("Text", DataSource, "Bai_tap")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Tong_so.DataBindings.Add("Text", DataSource, "Tong_so_tiet")

        sLy_thuyet.DataBindings.Add("Text", DataSource, "Ly_thuyet")
        sThuc_hanh.DataBindings.Add("Text", DataSource, "Thuc_hanh")
        sKiem_tra.DataBindings.Add("Text", DataSource, "Bai_tap")
        sSo_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        sTong_so.DataBindings.Add("Text", DataSource, "Tong_so_tiet")

        All_ly_thuyet.DataBindings.Add("Text", DataSource, "Ly_thuyet")
        All_thuc_hanh.DataBindings.Add("Text", DataSource, "Thuc_hanh")
        All_kiem_tra.DataBindings.Add("Text", DataSource, "Bai_tap")
        All_So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        All_tong_so.DataBindings.Add("Text", DataSource, "Tong_so_tiet")
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_kien_thuc")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub
End Class