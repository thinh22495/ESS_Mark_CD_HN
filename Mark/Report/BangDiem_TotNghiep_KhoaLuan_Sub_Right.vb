Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class BangDiem_TotNghiep_KhoaLuan_Sub_Right
    Public mID_sv As Integer
    Dim a As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
    Dim dt As DataTable
    Dim stt As Integer
    Public Sub binding(ByVal TBCHT As Double, ByVal Xep_loai As String, ByVal KhoaLuan_Diem As Double, ByVal KhoaLuan_HocTrinh As Double)
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        lblTBCHT.Text = TBCHT
        lblXep_loai.Text = Xep_loai

        lblDiem_KhoaLuan.Text = KhoaLuan_Diem
        lblHocTrinh_KhoaLuan.Text = KhoaLuan_HocTrinh
    End Sub
End Class