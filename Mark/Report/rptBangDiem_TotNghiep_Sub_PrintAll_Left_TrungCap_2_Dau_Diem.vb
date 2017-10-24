Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Left_TrungCap_2_Dau_Diem
    Dim stt As Integer
    Public Sub binding()
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        TBCHP1.DataBindings.Add("Text", DataSource, "TBCHP1")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP_HienThi")
    End Sub
End Class