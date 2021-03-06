Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_ThongKeXepLoaiHocTap_Nam
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal XS As Double = 0, Optional ByVal Gioi As Double = 0, Optional ByVal Kha As Double = 0, Optional ByVal TBKha As Double = 0, Optional ByVal TB As Double = 0, Optional ByVal Yeu As Double = 0, Optional ByVal Kem As Double = 0)
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_bao_cao.Text = Tieu_de_bao_cao

        Me.All_TL_XS.Text = XS
        Me.All_TL_Gioi.Text = Gioi
        Me.All_TL_Kha.Text = Kha
        Me.All_TL_TBKha.Text = TBKha
        Me.All_TL_TB.Text = TB
        Me.All_TL_Yeu.Text = Yeu
        Me.All_TL_Kem.Text = Kem


        Me.Kha_gioi.Text = "+ Tỉ lệ sinh viên khá, giỏi chiếm: " & XS + Gioi + Kha & " %"
        Me.TB_TBKha.Text = "+ Tỉ lệ sinh viên trung bình và trung bình khá chiếm: " & TBKha + TB & " %"
        Me.Yeu_kem.Text = "+ Tỉ lệ sinh viên yếu, kém chiếm: " & Yeu + Kem & " %"

        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Tong_so_sv.DataBindings.Add("Text", DataSource, "Tong_so_sv")
        All_sy_so.DataBindings.Add("Text", DataSource, "Tong_so_sv")

        So_sv_XS.DataBindings.Add("Text", DataSource, "So_sv_XS")
        So_sv_gioi.DataBindings.Add("Text", DataSource, "So_sv_gioi")
        So_sv_Kha.DataBindings.Add("Text", DataSource, "So_sv_Kha")
        So_sv_TBKha.DataBindings.Add("Text", DataSource, "So_sv_TBKha")
        So_sv_TB.DataBindings.Add("Text", DataSource, "So_sv_TB")
        So_sv_Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu")
        So_sv_Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem")

        All_SL_SX.DataBindings.Add("Text", DataSource, "So_sv_XS")
        All_SL_Gioi.DataBindings.Add("Text", DataSource, "So_sv_gioi")
        All_SL_kha.DataBindings.Add("Text", DataSource, "So_sv_Kha")
        All_SL_TBKha.DataBindings.Add("Text", DataSource, "So_sv_TBKha")
        All_SL_TB.DataBindings.Add("Text", DataSource, "So_sv_TB")
        All_SL_Yeu.DataBindings.Add("Text", DataSource, "So_sv_Yeu")
        All_SL_Kem.DataBindings.Add("Text", DataSource, "So_sv_Kem")

        TL_sv_XS.DataBindings.Add("Text", DataSource, "TL_sv_XS")
        TL_sv_Gioi.DataBindings.Add("Text", DataSource, "TL_sv_gioi")
        TL_sv_Kha.DataBindings.Add("Text", DataSource, "TL_sv_Kha")
        TL_sv_TBKha.DataBindings.Add("Text", DataSource, "TL_sv_TBKha")
        TL_sv_TB.DataBindings.Add("Text", DataSource, "TL_sv_TB")
        TL_sv_Yeu.DataBindings.Add("Text", DataSource, "TL_sv_Yeu")
        TL_sv_Kem.DataBindings.Add("Text", DataSource, "TL_sv_Kem")

      
    End Sub
End Class