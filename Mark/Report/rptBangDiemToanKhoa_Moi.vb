Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiemToanKhoa_Moi
    Private dict As Dictionary(Of Integer, DataView)
    Public Sub New(ByVal dv As DataView, ByVal dict1 As Dictionary(Of Integer, DataView), ByVal tieu_de_bao_cao As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.dict = dict1
        binding()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        'Me.tieu_de.Text = tieu_de_bao_cao
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Sub
    Public Sub binding()
        ID_SVLIn.DataBindings.Add("Text", DataSource, "ID_sv")
        txtLop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten").ToString().ToUpper()
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Que_quan.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
        Khoa_hoc.DataBindings.Add("Text", DataSource, "Nien_khoa")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
    End Sub
    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            Dim rpt As rptBangDiemToanKhoa_Sub = XrSubreport1.ReportSource
            Dim id_sv1 As Integer
            If ID_SVLIn.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_SVLIn.Text)
            End If
            Dim dv1 As DataView = dict.Item(id_sv1)
            Dim dt_sub1 As New DataTable
            dt_sub1.Columns.Add("STT")
            dt_sub1.Columns.Add("Ten_mon")
            dt_sub1.Columns.Add("So_tin_chi")
            dt_sub1.Columns.Add("TBCMH1")
            dt_sub1.Columns.Add("TBCHP_Max")
            Dim dem As Integer = 0
            Dim tong As Integer = dv1.Count
            If (tong Mod 2) = 0 Then
                dem = Math.Round((tong / 2) + 0.00000001, 0)
            Else
                dem = Math.Round((tong / 2) + 0.00000001, 0)
            End If
            If dv1.Count > 0 Then
                For i As Integer = 0 To dem - 1
                    Dim dr As DataRow
                    dr = dt_sub1.NewRow
                    dr("STT") = i + 1
                    dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                    dr("So_tin_chi") = dv1.Item(i)("So_tin_chi")
                    dr("TBCMH1") = dv1.Item(i)("TBCMH1")
                    dr("TBCHP_Max") = dv1.Item(i)("TBCHP_Max")
                    dt_sub1.Rows.Add(dr)
                Next
            End If
            rpt.DataSource = dt_sub1.DefaultView
            rpt.binding()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Try
            Dim rpt2 As rptBangDiemToanKhoa_Sub1 = XrSubreport2.ReportSource
            Dim id_sv1 As Integer
            If ID_SVLIn.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_SVLIn.Text)
            End If
            Dim dv1 As DataView = dict.Item(id_sv1)
            Dim dt_sub1 As New DataTable
            dt_sub1.Columns.Add("STT")
            dt_sub1.Columns.Add("Ten_mon")
            dt_sub1.Columns.Add("So_tin_chi")
            dt_sub1.Columns.Add("TBCMH1")
            dt_sub1.Columns.Add("TBCHP_Max")
            Dim tong As Integer = dv1.Count
            Dim dem As Integer = 0
            If tong Mod 2 = 0 Then
                dem = Math.Round((tong / 2) - 0.0000001, 0)
            Else
                dem = Math.Round((tong / 2) - 0.0000001, 0) + 1
            End If
            If dv1.Count > 0 Then
                For i As Integer = dem To tong - 1
                    Dim dr As DataRow
                    dr = dt_sub1.NewRow
                    dr("STT") = i + 1
                    dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                    dr("So_tin_chi") = dv1.Item(i)("So_tin_chi")
                    dr("TBCMH1") = dv1.Item(i)("TBCMH1")
                    dr("TBCHP_Max") = dv1.Item(i)("TBCHP_Max")
                    dt_sub1.Rows.Add(dr)
                Next
            End If
            rpt2.DataSource = dt_sub1.DefaultView
            rpt2.binding()
        Catch ex As Exception
        End Try
    End Sub
End Class