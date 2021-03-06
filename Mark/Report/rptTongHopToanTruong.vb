Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptTongHopToanTruong
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de_bao_cao As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_bao_cao.Text = Tieu_de_bao_cao
        Me.DataSource = dv

        Dim Tong_sv, Tong_sx, Tong_Kha, Tong_Gioi, Tong_TBKha, Tong_TB, Tong_Yeu, Tong_Kem, Tong_HocLai, Tong_ThiLai As Integer
        'Dim Tong_sx_pt, Tong_Kha_pt, Tong_Gioi_pt, Tong_TBKha_pt, Tong_TB_pt, Tong_Yeu_pt, Tong_Kem_pt, Tong_HocLai_pt, Tong_ThiLai_pt As Double
        For i As Integer = 0 To dv.Count - 1
            Tong_sv += dv.Item(i)("So_SV_tong")
            Tong_sx += dv.Item(i)("So_sv_XS")
            Tong_Gioi += dv.Item(i)("TyLe_Gioi")
            Tong_Kha += dv.Item(i)("TyLe_Kha")
            Tong_TBKha += dv.Item(i)("So_sv_TBKha")
            Tong_TB += dv.Item(i)("So_sv_TB")
            Tong_Yeu += dv.Item(i)("So_sv_Yeu")
            Tong_Kem += dv.Item(i)("So_sv_Kem")
            Tong_HocLai += dv.Item(i)("So_sv_HocLai")
            Tong_ThiLai += dv.Item(i)("So_sv_ThiLai")
        Next
        Me.Tong_sv_all.Text = Tong_sv
        Me.xs_all.Text = Tong_sx
        Me.Gioi_all.Text = Tong_Gioi
        Me.Kha_all.Text = Tong_Kha
        Me.TBKha_all.Text = Tong_TBKha
        Me.tb_all.Text = Tong_TB
        Me.Yeu_all.Text = Tong_Yeu
        Me.Kem_all.Text = Tong_Kem
        Me.HocLai_all.Text = Tong_HocLai
        Me.ThiLai_all.Text = Tong_ThiLai

        Me.xs_all_pt.Text = Math.Round(Tong_sx * 100 / Tong_sv, 2)
        Me.Gioi_all_pt.Text = Math.Round(Tong_Gioi * 100 / Tong_sv, 2)
        Me.Kha_all_pt.Text = Math.Round(Tong_Kha * 100 / Tong_sv, 2)
        Me.TBKha_all_pt.Text = Math.Round(Tong_TBKha * 100 / Tong_sv, 2)
        Me.tb_all_pt.Text = Math.Round(Tong_TB * 100 / Tong_sv, 2)
        Me.Yeu_all_pt.Text = Math.Round(Tong_Yeu * 100 / Tong_sv, 2)
        Me.Kem_all_pt.Text = Math.Round(Tong_Kem * 100 / Tong_sv, 2)
        Me.HocLai_all_pt.Text = Math.Round(Tong_HocLai * 100 / Tong_sv, 2)
        Me.ThiLai_all_pt.Text = Math.Round(Tong_ThiLai * 100 / Tong_sv, 2)

        Binding()
    End Sub
    Public Sub Binding()
        XS_SL.DataBindings.Add("Text", DataSource, "So_sv_XS")
        SX_PT.DataBindings.Add("Text", DataSource, "TyLe_XS")

        Gioi_SL.DataBindings.Add("Text", DataSource, "So_sv_Gioi")
        Gioi_PT.DataBindings.Add("Text", DataSource, "TyLe_Gioi")

        Kha_SL.DataBindings.Add("Text", DataSource, "So_sv_Kha")
        Kha_PT.DataBindings.Add("Text", DataSource, "TyLe_Kha")

        TBKha_SL.DataBindings.Add("Text", DataSource, "So_sv_TBKha")
        TBKha_PT.DataBindings.Add("Text", DataSource, "TyLe_TBKha")

        TB_SL.DataBindings.Add("Text", DataSource, "So_sv_TB")
        TB_PT.DataBindings.Add("Text", DataSource, "TyLe_TB")

        Yeu_SL.DataBindings.Add("Text", DataSource, "So_sv_Yeu")
        Yeu_PT.DataBindings.Add("Text", DataSource, "TyLe_Yeu")

        Kem_sl.DataBindings.Add("Text", DataSource, "So_sv_Kem")
        Kem_PT.DataBindings.Add("Text", DataSource, "TyLe_Kem")

        KhongXL_SL.DataBindings.Add("Text", DataSource, "So_sv_KXL")
        KhongXL_PT.DataBindings.Add("Text", DataSource, "TyLe_KXL")

        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tong_sv.DataBindings.Add("Text", DataSource, "So_SV_tong")

        HocLai_SL.DataBindings.Add("Text", DataSource, "So_sv_HocLai")
        HocLai_PT.DataBindings.Add("Text", DataSource, "TyLe_HocLai")

        ThiLai_SL.DataBindings.Add("Text", DataSource, "So_sv_ThiLai")
        ThiLai_PT.DataBindings.Add("Text", DataSource, "TyLe_ThiLai")

        HocBu_SL.DataBindings.Add("Text", DataSource, "So_sv_KXL")
        HocBu_PT.DataBindings.Add("Text", DataSource, "TyLe_KXL")
    End Sub
End Class