Public Class rptBangDiem_NamHoc_Sub
    Public Sub binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_tin_chi.DataBindings.Add("Text", DataSource, "So_tin_chi")
        TBCHP1.DataBindings.Add("Text", DataSource, "TBCMH1", "{0:n1}")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP_HienThi", "{0:n1}")
    End Sub
End Class