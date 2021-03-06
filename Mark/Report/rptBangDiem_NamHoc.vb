Public Class rptBangDiem_NamHoc
    Private dict As Dictionary(Of Integer, DataView)
    Public Sub New(ByVal dv As DataView, ByVal dict1 As Dictionary(Of Integer, DataView), ByVal tieu_de_bao_cao As String, ByVal tieu_de_bao_cao2 As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.dict = dict1
        binding()
        Me.Tieu_de_bao_cao.Text = tieu_de_bao_cao.ToString
        Me.Tieu_de2.Text = tieu_de_bao_cao2.ToString
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Sub
    Public Sub binding()
        ID_sv.DataBindings.Add("Text", DataSource, "ID_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten").ToString().ToUpper()
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Xep_loai_RL.DataBindings.Add("Text", DataSource, "Xep_loai_RL")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            Dim rpt As rptBangDiem_NamHoc_Sub = XrSubreport1.ReportSource
            Dim id_sv1 As Integer
            If ID_sv.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_sv.Text)
            End If
            Dim dv1 As DataView = dict.Item(id_sv1)
            rpt.DataSource = dv1
            rpt.binding()
        Catch ex As Exception
        End Try
    End Sub
End Class