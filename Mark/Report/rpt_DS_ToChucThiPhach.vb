Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_DS_ToChucThiPhach
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bc As String = "")
        InitializeComponent()
        Dim dv As DataView = dtMain.DefaultView
        Dim dv2 As DataView = dtSub.DefaultView
        Dim dt As DataTable = dv.Table.Copy
        Me.DataSource = dtMain
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_bao_cao.Text = Tieu_de_bc & dt.Rows(0).Item("Ten_mon").ToString.ToUpper
        'Me.Ten_mon.Text = dt.Rows(0).Item("Ten_mon").ToString
        Me.Phong_thi.Text = dt.Rows(0).Item("Ten_phong").ToString
        Me.Ngay_thi.Text = dt.Rows(0).Item("Ngay_thi").ToString
        Me.Thoi_gian_thi.Text = dt.Rows(0).Item("Thoi_gian").ToString
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Binding()
    End Sub
    Public Sub Binding()
        SBD.DataBindings.Add("Text", DataSource, "So_bao_danh")
        'Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        Ten.DataBindings.Add("Text", DataSource, "Ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Bang_so.DataBindings.Add("Text", DataSource, "Diem_thi", "{0:n1}")
        'Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        'So_phach.DataBindings.Add("Text", DataSource, "So_phach")
    End Sub
End Class