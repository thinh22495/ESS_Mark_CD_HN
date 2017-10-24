Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Right_TrungCap
    Public Sub binding(ByVal mTBCHT As Double, ByVal mXep_loai As String, ByVal mCoSo_Diem As Double, ByVal mCoSo_HocTrinh As Double, ByVal mThucHanh_Diem As Double, ByVal mThucHanh_HocTrinh As Double, ByVal mLyThuyet_Diem As Double, ByVal mLyThuyet_HocTrinh As Double)
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        lblTBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
        lblXep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")

        'lblTBCHT.Text = TBCHT
        'lblXep_loai.Text = Xep_loai

        lblDiem_Thuc_hanh.Text = Math.Round(mThucHanh_Diem, 1)
        lblThuc_hanh.Text = mThucHanh_HocTrinh

        lblDiem_Ly_thuyet.Text = Math.Round(mLyThuyet_Diem, 1)
        lblLy_thuyet.Text = mLyThuyet_HocTrinh

        lblDiem_Chinh_tri.Text = Math.Round(mCoSo_Diem, 1)
        lblChinh_tri.Text = mCoSo_HocTrinh
    End Sub
End Class