Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiemTotNghiep_Sub_Right_VanHoa
    Public Sub binding()
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP", "{0:n1}")
    End Sub

End Class