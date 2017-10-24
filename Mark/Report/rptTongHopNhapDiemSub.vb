Public Class rptTongHopNhapDiemSub
    Public Sub binding()
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tong_so_mon.DataBindings.Add("Text", DataSource, "TongSoMon")
        So_mon_ht.DataBindings.Add("Text", DataSource, "SoMonChuaHoanThanh")
        Ma_mon_chua_ht.DataBindings.Add("Text", DataSource, "TenMonChuaHoanThanh")
        SoMonHoanThanh.DataBindings.Add("Text", DataSource, "SoMonHoanThanh")
    End Sub
End Class