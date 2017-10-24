Public Class rptBangDiemToanKhoa_Sub
    Dim stt As Integer
    Public Sub binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_tin_chi")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP_Max", "{0:n1}")
        So_tt.DataBindings.Add("Text", DataSource, "STT")
    End Sub
End Class