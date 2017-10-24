Imports DevExpress.XtraReports.UI
Imports ESS.BLL.Business
Public Class rptInChungChi
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
        Me.Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.So_hieu.DataBindings.Add("Text", DataSource, "So_hieu")
        Me.So_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")
        Me.Ten_CC.DataBindings.Add("Text", DataSource, "Ten_CC")
        Me.Tu_ngay.DataBindings.Add("Text", DataSource, "Tu_ngay")
        Me.Tu_thang.DataBindings.Add("Text", DataSource, "Tu_thang")
        Me.Den_ngay.DataBindings.Add("Text", DataSource, "Den_ngay")
        Me.Den_thang.DataBindings.Add("Text", DataSource, "Den_thang")
        'Dim Ngay_HT As Integer = DateTime.Now.Day()
        'Dim Ngay_chuan As String = ""
        'If Ngay_HT < 10 Then
        '    Ngay_chuan = "0" & Ngay_HT.ToString
        'Else
        '    Ngay_chuan = Ngay_HT.ToString
        'End If
        'Me.Ngay.Text = Ngay_chuan.ToString
        'Me.Thang.Text = DateTime.Now.Month.ToString()
        'Me.Nam.Text = DateTime.Now.Year.ToString()
    End Sub
End Class