Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Left_TrungCap
    Dim stt As Integer
    Public Sub binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
    End Sub
End Class