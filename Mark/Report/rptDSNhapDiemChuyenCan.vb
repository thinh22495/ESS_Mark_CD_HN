Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptDSNhapDiemChuyenCan
    Dim so_tt As Integer = 0
    Dim ID_Lop As Integer
    Public Sub New(Optional ByVal ID_Lop As Integer = 0, Optional ByVal Tieu_de_bao_cao As String = "")
        InitializeComponent()
        Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
        Dim dt As DataTable = obj.rpt_DSDiemChuyenCan(ID_Lop)
        If dt.Rows.Count > 0 Then
            Me.Ten_lop.Text = dt.Rows(0).Item("Ten_lop").ToString
            Me.Ten_khoa.Text = dt.Rows(0).Item("Ten_khoa").ToString
        End If
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Goi_tinh")
    End Sub

    Private Sub stt_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles stt.BeforePrint
        so_tt = so_tt + 1
        Me.stt.Text = so_tt
    End Sub
End Class