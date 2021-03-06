Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSachDuThi
    Dim so_tt As Integer = 0
    Public Sub New(ByVal dv As DataView, ByVal Hoc_ky As Integer, ByVal Ten_mon As String, ByVal Lan_thi As Integer)
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.DataSource = dv
        Me.Hoc_ky.Text = Hoc_ky
        Me.Ten_mon.Text = Ten_mon
        Me.Lan_thi.Text = Lan_thi
        Me.Tong_so.Text = "Tổng số: " & dv.Count
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
    End Sub

    Private Sub stt_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles stt.BeforePrint
        so_tt = so_tt + 1
        Me.stt.Text = so_tt
    End Sub
End Class