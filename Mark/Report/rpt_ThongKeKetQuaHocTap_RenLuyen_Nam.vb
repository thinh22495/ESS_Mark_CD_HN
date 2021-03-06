Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_ThongKeKetQuaHocTap_RenLuyen_Nam
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de_bao_cao As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        'Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao
        Me.DataSource = dv

        Dim All_sv, All_Xs, All_Gioi, All_Kha, All_TBKha, All_TB, All_Yeu, All_Kem As Integer
        Dim All_Xs_HK, All_Gioi_HK, All_Kha_HK, All_TBKha_HK, All_TB_HK, All_Yeu_HK, All_Kem_HK As Integer
        For i As Integer = 0 To dv.Count - 1
            All_sv += dv.Item(i)("Tong_so_sv")

            All_Xs += dv.Item(i)("So_sv_XS")
            All_Gioi += dv.Item(i)("So_sv_Gioi")
            All_Kha += dv.Item(i)("So_sv_Kha")
            All_TBKha += dv.Item(i)("So_sv_TBKha")
            All_TB += dv.Item(i)("So_sv_TB")
            All_Yeu += dv.Item(i)("So_sv_Yeu")
            All_Kem += dv.Item(i)("So_sv_Kem")

            All_Xs_HK += dv.Item(i)("So_sv_XS_RL")
            All_Gioi_HK += dv.Item(i)("So_sv_Gioi_RL")
            All_Kha_HK += dv.Item(i)("So_sv_Kha_RL")
            All_TBKha_HK += dv.Item(i)("So_sv_TBKha_RL")
            All_TB_HK += dv.Item(i)("So_sv_TB_RL")
            All_Yeu_HK += dv.Item(i)("So_sv_Yeu_RL")
            All_Kem_HK += dv.Item(i)("So_sv_Kem_RL")
        Next
        If All_sv > 0 Then
            Me.PT_xs.Text = Math.Round((All_Xs / All_sv) * 100, 1)
            Me.PT_Gioi.Text = Math.Round((All_Gioi / All_sv) * 100, 1)
            Me.PT_Kha.Text = Math.Round((All_Kha / All_sv) * 100, 1)
            Me.PT_TBKha.Text = Math.Round((All_TBKha / All_sv) * 100, 1)
            Me.PT_TB.Text = Math.Round((All_TB / All_sv) * 100, 1)
            Me.PT_Yeu.Text = Math.Round((All_Yeu / All_sv) * 100, 1)
            Me.PT_Kem.Text = Math.Round((All_Kem / All_sv) * 100, 1)

            Me.PT_XS_HK.Text = Math.Round((All_Xs_HK / All_sv) * 100, 1)
            Me.PT_Gioi_HK.Text = Math.Round((All_Gioi_HK / All_sv) * 100, 1)
            Me.PT_Kha_HK.Text = Math.Round((All_Kha_HK / All_sv) * 100, 1)
            Me.PT_TBKha_HK.Text = Math.Round((All_TBKha_HK / All_sv) * 100, 1)
            Me.PT_TB_HK.Text = Math.Round((All_TB_HK / All_sv) * 100, 1)
            Me.PT_Yeu_HK.Text = Math.Round((All_Yeu_HK / All_sv) * 100, 1)
            Me.PT_Kem_HK.Text = Math.Round((All_Kem_HK / All_sv) * 100, 1)
        End If

        Binding()
    End Sub
    Public Sub Binding()
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Si_so.DataBindings.Add("Text", DataSource, "Tong_so_sv")
        Tong_si_so.DataBindings.Add("Text", DataSource, "Tong_so_sv")

        xs.DataBindings.Add("Text", DataSource, "So_sv_XS")
        Tong_XS.DataBindings.Add("Text", DataSource, "So_sv_XS")
        HK_XS.DataBindings.Add("Text", DataSource, "So_sv_XS_RL")
        Tong_HK_XS.DataBindings.Add("Text", DataSource, "So_sv_XS_RL")

        Gioi.DataBindings.Add("Text", DataSource, "So_sv_Gioi")
        Tong_Gioi.DataBindings.Add("Text", DataSource, "So_sv_Gioi")
        HK_Gioi.DataBindings.Add("Text", DataSource, "So_sv_Gioi_RL")
        Tong_HK_Gioi.DataBindings.Add("Text", DataSource, "So_sv_Gioi_RL")

        Kha.DataBindings.Add("Text", DataSource, "So_sv_Kha")
        Tong_Kha.DataBindings.Add("Text", DataSource, "So_sv_Kha")
        HK_Kha.DataBindings.Add("Text", DataSource, "So_sv_Kha_RL")
        Tong_HK_Kha.DataBindings.Add("Text", DataSource, "So_sv_Kha_RL")

        TBK.DataBindings.Add("Text", DataSource, "So_sv_TBKha")
        Tong_TBK.DataBindings.Add("Text", DataSource, "So_sv_TBKha")
        HK_TBK.DataBindings.Add("Text", DataSource, "So_sv_TBKha_RL")
        Tong_HK_TBK.DataBindings.Add("Text", DataSource, "So_sv_TBKha_RL")

        TB.DataBindings.Add("Text", DataSource, "So_sv_TB")
        Tong_TB.DataBindings.Add("Text", DataSource, "So_sv_TB")
        HK_TB.DataBindings.Add("Text", DataSource, "So_sv_TB_RL")
        Tong_HK_TB.DataBindings.Add("Text", DataSource, "So_sv_TB_RL")

        Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu")
        Tong_Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu")
        HK_Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu_RL")
        Tong_HK_Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu_RL")

        Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem")
        Tong_Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem")
        HK_Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem_RL")
        Tong_HK_Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem_RL")
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_khoa")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub
    'Public Sub abc()
    '    Dim All_sv As Integer = 0
    '    All_sv = Convert.ToInt32(Me.Tong_si_so.Text)
    '    If All_sv > 0 Then
    '        Dim PT_XS, PT_Gioi, PT_Kha, PT_TBKha, PT_TB, PT_Yeu, PT_Kem, PT_XS_HK, PT_Gioi_HK, PT_Kha_HK, PT_TBKha_HK, PT_TB_HK, PT_Yeu_HK, PT_Kem_HK As Double
    '        PT_XS = Math.Round((Convert.ToInt32(Me.Tong_XS.Text) / All_sv) * 100, 1)
    '        PT_Gioi = Math.Round((Convert.ToInt32(Me.Tong_Gioi.Text) / All_sv) * 100, 1)
    '        PT_Kha = Math.Round((Convert.ToInt32(Me.Tong_Kha.Text) / All_sv) * 100, 1)
    '        PT_TBKha = Math.Round((Convert.ToInt32(Me.Tong_TBK.Text) / All_sv) * 100, 1)
    '        PT_TB = Math.Round((Convert.ToInt32(Me.Tong_TB.Text) / All_sv) * 100, 1)
    '        PT_Yeu = Math.Round((Convert.ToInt32(Me.Tong_Yeu.Text) / All_sv) * 100, 1)
    '        PT_Kem = Math.Round((Convert.ToInt32(Me.Tong_Kem.Text) / All_sv) * 100, 1)

    '        PT_XS_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_XS.Text) / All_sv) * 100, 1)
    '        PT_Gioi_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_Gioi.Text) / All_sv) * 100, 1)
    '        PT_Kha_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_Kha.Text) / All_sv) * 100, 1)
    '        PT_TBKha_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_TBK.Text) / All_sv) * 100, 1)
    '        PT_TB_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_TB.Text) / All_sv) * 100, 1)
    '        PT_Yeu_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_Yeu.Text) / All_sv) * 100, 1)
    '        PT_Kem_HK = Math.Round((Convert.ToInt32(Me.Tong_HK_Kem.Text) / All_sv) * 100, 1)
    '    End If
    'End Sub

    'Private Sub XrTableCell29_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PT_xs.BeforePrint
    '    abc()
    'End Sub
End Class