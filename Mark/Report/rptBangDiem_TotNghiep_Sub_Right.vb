Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiem_TotNghiep_Sub_Right
    Public mID_sv As Integer
    Dim a As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
    Dim dt As DataTable
    Dim stt As Integer

    Public Sub binding(ByVal TBCHT As Double, ByVal Xep_loai As String, ByVal Thi_CS_Nganh_Diem As Double, ByVal Thi_CS_Nganh_HocTrinh As Double, ByVal Thi_CN_Diem As Double, ByVal Thi_CN_HocTrinh As Double, ByVal ThucTapTotNghiep_Diem As Double, ByVal ThucTapTotNghiep_HocTrinh As Double)
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        lblTBCHT.Text = TBCHT
        lblXep_loai.Text = Xep_loai

        lblCN_Diem.Text = Thi_CN_Diem
        lblHocTrinh_CN.Text = Thi_CN_HocTrinh

        lblCS_Nganh_Diem.Text = Thi_CS_Nganh_Diem
        lblHocTrinh_CS_Nganh.Text = Thi_CS_Nganh_HocTrinh

        lblDiem_ThucTap.Text = ThucTapTotNghiep_Diem
        lblHocTrinh_ThucTap.Text = ThucTapTotNghiep_HocTrinh
    End Sub

End Class