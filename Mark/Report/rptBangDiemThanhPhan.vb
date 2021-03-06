Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiemThanhPhan
    Dim so_tt As Integer = 0
    Public Sub New(Optional ByVal Ten_hoc_phan As String = "", Optional ByVal He As String = "", Optional ByVal Chuyen_nganh As String = "", Optional ByVal Ten_lop As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Ten_hoc_phan.Text = Ten_hoc_phan
        Me.He.Text = He
        Me.Chuyen_nganh.Text = Chuyen_nganh
        Me.Ten_lop.Text = Ten_lop
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Diem1.DataBindings.Add("Text", DataSource, "TP14")
        Diem2.DataBindings.Add("Text", DataSource, "TP31")
        Ghi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

    Private Sub stt_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles stt.BeforePrint
        so_tt = so_tt + 1
        Me.stt.Text = so_tt
    End Sub
End Class