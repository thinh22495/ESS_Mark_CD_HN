Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiemToanKhoa_BaoLuu
    Private subdata As DataView
    Public ID_sv As Integer
    Public Sub SetupDatasource(ByVal dv As DataView)
        Me.subdata = dv
    End Sub
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal Ma_sv As String = "", Optional ByVal Ho_ten As String = "", Optional ByVal Ngay_sinh As String = "", Optional ByVal Chuyen_nganh As String = "", Optional ByVal Ten_nganh As String = "", Optional ByVal Ten_tinh As String = "", Optional ByVal Ten_he As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.tieu_de.Text = Tieu_de_bao_cao
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year

        Me.TBCHT.Text = dtMain.Rows(0)("TBCHT").ToString
        Me.Xep_loai.Text = dtMain.Rows(0)("Xep_loai").ToString
        Me.Ma_sv.Text = Ma_sv.ToString
        Me.Ho_ten.Text = Ho_ten.ToString
        Me.Ngay_sinh.Text = Ngay_sinh.ToString
        Me.Que_quan.Text = Ten_tinh.ToString
        Me.Ten_nganh.Text = Chuyen_nganh.ToString
        Me.Chuyen_nganh.Text = Ten_nganh.ToString
        Me.Ten_he.Text = Ten_he.ToString
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptBangDiemToanKhoa_Sub = XrSubreport1.ReportSource
        Dim dv1 As DataView = Me.subdata
        Dim dt_sub1 As New DataTable
        dt_sub1.Columns.Add("STT")
        dt_sub1.Columns.Add("Ten_mon")
        dt_sub1.Columns.Add("So_tin_chi")
        dt_sub1.Columns.Add("TBCMH1")
        dt_sub1.Columns.Add("TBCHP")
        Dim tong As Integer = dv1.Count
        Dim dem As Integer = Math.Round(tong / 2, 1)
        If dv1.Count > 0 Then
            For i As Integer = 0 To dem - 1
                Dim dr As DataRow
                dr = dt_sub1.NewRow
                dr("STT") = dv1.Item(i)("STT")
                dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                dr("So_tin_chi") = dv1.Item(i)("So_tin_chi")
                dr("TBCMH1") = dv1.Item(i)("TBCMH1")
                dr("TBCHP") = dv1.Item(i)("TBCHP")
                dt_sub1.Rows.Add(dr)
            Next
        End If
        rpt.DataSource = dt_sub1.DefaultView
        rpt.binding()
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim rpt2 As rptBangDiemToanKhoa_Sub1 = XrSubreport2.ReportSource
        Dim dv2 As DataView = Me.subdata
        rpt2.DataSource = dv2
        rpt2.binding()
        Dim dt_sub2 As New DataTable
        dt_sub2.Columns.Add("STT")
        dt_sub2.Columns.Add("Ten_mon")
        dt_sub2.Columns.Add("So_tin_chi")
        dt_sub2.Columns.Add("TBCMH1")
        dt_sub2.Columns.Add("TBCHP")
        Dim tong As Integer = dv2.Count
        Dim dem As Integer = Math.Round(tong / 2, 1)
        If dv2.Count > 0 Then
            For i As Integer = dem To tong - 1
                Dim dr As DataRow
                dr = dt_sub2.NewRow
                dr("STT") = dv2.Item(i)("STT")
                dr("Ten_mon") = dv2.Item(i)("Ten_mon")
                dr("So_tin_chi") = dv2.Item(i)("So_tin_chi")
                dr("TBCMH1") = dv2.Item(i)("TBCMH1")
                dr("TBCHP") = dv2.Item(i)("TBCHP")
                dt_sub2.Rows.Add(dr)
            Next
        End If
        rpt2.DataSource = dt_sub2.DefaultView
        rpt2.binding()
    End Sub
End Class