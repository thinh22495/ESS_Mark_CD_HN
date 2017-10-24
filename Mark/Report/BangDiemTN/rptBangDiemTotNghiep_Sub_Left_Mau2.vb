Public Class rptBangDiemTotNghiep_Sub_Left_Mau2
    Dim stt As Integer
    Public Sub binding()
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP", "{0:n1}")
    End Sub
End Class