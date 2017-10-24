Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Right_2_Dau_Diem
    Public Sub binding(ByVal mMon_LyThuyet_Diem As Double, ByVal mMon_LyThuyet_HocTrinh As Double, ByVal mMon_ThucHanh_Diem As Double, ByVal mMon_ThucHanh_HocTrinh As Double, ByVal mMon_ChinhTri_Diem As Double, ByVal mMon_ChinhTri_HocTrinh As Double)
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP", "{0:n1}")

        'lblTBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
        lblXep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")

        ThucHanh_Diem.Text = FormatNumber(mMon_ThucHanh_Diem, 1)
        ThucHanh_HocTrinh.Text = mMon_ThucHanh_HocTrinh

        LyThuyet_Diem.Text = FormatNumber(mMon_LyThuyet_Diem, 1)
        LyThuyet_HocTrinh.Text = mMon_LyThuyet_HocTrinh

        ChinhTri_Diem.Text = FormatNumber(mMon_ChinhTri_Diem, 1)
        'Chinh_tri_Hoctrinh.Text = mMon_ChinhTri_HocTrinh
    End Sub

End Class