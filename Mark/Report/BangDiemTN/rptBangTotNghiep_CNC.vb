Imports DevExpress.XtraReports.UI
Imports ESS.BLL.Business
Public Class rptBangTotNghiep_CNC
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten_Hoa")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh_chuan")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Me.Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
        Me.Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.So_hieu.DataBindings.Add("Text", DataSource, "So_hieu")
        Me.So_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")
        Me.Tu_thang.DataBindings.Add("Text", DataSource, "Tu_thang")
        Me.Den_thang.DataBindings.Add("Text", DataSource, "Den_thang")
        Me.Tu_nam.DataBindings.Add("Text", DataSource, "Tu_nam")
        Me.Den_nam.DataBindings.Add("Text", DataSource, "Den_nam")
        'Me.Ngay_vao_so.DataBindings.Add("Text", DataSource, "Ngay_vao_so")
        'Me.Thang_vao_so.DataBindings.Add("Text", DataSource, "Thang_vao_so")
        'Me.Nam_vao_so.DataBindings.Add("Text", DataSource, "Nam_vao_so")
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki
        Dim Ngay_HT As Integer = DateTime.Now.Day()
        Dim Ngay_chuan As String = ""
        If Ngay_HT < 10 Then
            Ngay_chuan = "0" & Ngay_HT.ToString
        Else
            Ngay_chuan = Ngay_HT.ToString
        End If
        'Me.Ngay.Text = Ngay_chuan.ToString
        'Me.Thang.Text = DateTime.Now.Month.ToString()
        'Me.Nam.Text = DateTime.Now.Year.ToString()
    End Sub
End Class