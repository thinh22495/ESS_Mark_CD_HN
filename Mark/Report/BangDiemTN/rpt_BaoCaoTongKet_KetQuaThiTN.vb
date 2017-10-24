Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_BaoCaoTongKet_KetQuaThiTN
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()

        Dim Tong_ALL As Integer = dv.Count

        Dim XS_SL As Double = 0
        Dim Gioi_SL As Double = 0
        Dim Kha_SL As Double = 0
        Dim TBK_SL As Double = 0
        Dim TB_SL As Double = 0
        Dim Yeu_SL As Double = 0
        Dim Kem_SL As Double = 0


        Dim XS_TL As Double = 0
        Dim Gioi_TL As Double = 0
        Dim Kha_TL As Double = 0
        Dim TBK_TL As Double = 0
        Dim TB_TL As Double = 0
        Dim Yeu_TL As Double = 0
        Dim Kem_TL As Double = 0

        dv.RowFilter = "ID_xep_loai = 1"
        XS_SL = dv.Count
        XS_TL = (XS_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"

        dv.RowFilter = "ID_xep_loai = 3"
        Gioi_SL = dv.Count
        Gioi_TL = (Gioi_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"

        dv.RowFilter = "ID_xep_loai = 4"
        Kha_SL = dv.Count
        Kha_TL = (Kha_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"

        dv.RowFilter = "ID_xep_loai = 5"
        TBK_SL = dv.Count
        TBK_TL = (TBK_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"

        dv.RowFilter = "ID_xep_loai = 6"
        TB_SL = dv.Count
        TB_TL = (TB_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"


        dv.RowFilter = "ID_xep_loai = 7"
        Yeu_SL = dv.Count
        Yeu_TL = (Yeu_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"

        dv.RowFilter = "ID_xep_loai = 8"
        Kem_SL = dv.Count
        Kem_TL = (Kem_SL / Tong_ALL) * 100
        dv.RowFilter = "1=1"


        Me.XS_SL.Text = XS_SL
        Me.XS_TL.Text = Math.Round(XS_TL, 2)

        Me.Gioi_SL.Text = Gioi_SL
        Me.Gioi_TL.Text = Math.Round(Gioi_TL, 2)

        Me.Kha_SL.Text = Kha_SL
        Me.Kha_TL.Text = Math.Round(Kha_TL, 2)

        Me.TBK_SL.Text = TBK_SL
        Me.TBK_TL.Text = Math.Round(TBK_TL, 2)

        Me.TB_SL.Text = TB_SL
        Me.TB_TL.Text = Math.Round(TB_TL, 1)

        Me.Yeu_SL.Text = Yeu_SL
        Me.Yeu_TL.Text = Math.Round(Yeu_TL, 2)

        Me.Kem_SL.Text = Kem_SL
        Me.Kem_TL.Text = Math.Round(Kem_TL, 2)

        Me.Tong_ALL.Text = XS_SL + Gioi_SL + Kha_SL + TBK_SL + TB_SL + Yeu_SL + Kem_SL & " (Sinh viên)"
        Me.PT_ALL.Text = XS_TL + Gioi_TL + Kha_TL + TBK_TL + TB_TL + Yeu_TL + Kem_TL & " (%)"

    End Sub
End Class