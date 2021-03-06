Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class BangDiem_TotNghiep_KhoaLuan
    Private subdata As DataView
    Private subdata2 As DataView
    Private mID_sv As Integer
    Private mdt As DataTable

    Public Sub New(Optional ByVal ID_sv As Integer = 0, Optional ByVal Tieu_de_bao_cao As String = "")
        mID_sv = ID_sv
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.tieu_de.Text = Tieu_de_bao_cao
        TieuDe_ChucDanh.Text = gTieu_de_chuc_danh1
        Ten_ChucDanh.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL

        mdt = obj.Load_BangDiemToanKhoa_SV(mID_sv)
        If mdt.Rows.Count > 0 Then
            Me.Ma_sv.Text = mdt.Rows(0).Item("Ma_sv").ToString
            Me.Ho_ten.Text = mdt.Rows(0).Item("Ho_ten").ToString
            If mdt.Rows(0).Item("Ngay_sinh").ToString <> "" Then Me.Ngay_sinh.Text = mdt.Rows(0).Item("Ngay_sinh")
            Me.Que_quan.Text = mdt.Rows(0).Item("Ten_tinh").ToString
            Me.Ten_lop.Text = mdt.Rows(0).Item("Ten_lop").ToString
            Me.Nien_khoa.Text = mdt.Rows(0).Item("Nien_khoa").ToString
            Me.Ten_khoa.Text = mdt.Rows(0).Item("Ten_khoa").ToString
            Me.Ten_he.Text = mdt.Rows(0).Item("Ten_he").ToString
            Me.Chuyen_nganh.Text = mdt.Rows(0).Item("Chuyen_nganh").ToString
            Dim So_hoc_trinh As Double = 0
            Dim TBCHT As Double = 0
            For i As Integer = 0 To mdt.Rows.Count - 1
                So_hoc_trinh = So_hoc_trinh + mdt.Rows(i)("So_hoc_trinh")
                TBCHT = TBCHT + mdt.Rows(i)("So_hoc_trinh") * mdt.Rows(i)("TBCHP")
            Next
            If So_hoc_trinh > 0 Then TBCHT = Round_Mark_TBC_ToanKhoa(TBCHT / So_hoc_trinh)

            TBCHT_TK.Text = Math.Round(TBCHT, 2)
            Xep_loai.Text = obj.Load_XepHangTotNghiep(TBCHT)
        End If
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptBangDiemToanKhoa_Sub = XrSubreport1.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")
        Dim dem As Integer = Math.Round(mdt.Rows.Count / 2 - 0.01, 0)

        mdt.DefaultView.Sort = "Ten_mon"
        For i As Integer = 0 To dem - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr("STT") = i + 1
            dr("TBCHP") = mdt.DefaultView.Item(i)("TBCHP")
            dr("Ten_mon") = mdt.DefaultView.Item(i)("Ten_mon")
            dr("So_hoc_trinh") = mdt.DefaultView.Item(i)("So_hoc_trinh")
            dt.Rows.Add(dr)
        Next
        rpt.DataSource = dt.DefaultView
        rpt.binding()
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim rpt2 As rptBangDiemToanKhoa_Sub1 = XrSubreport2.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")
        Dim dem As Integer = Math.Round(mdt.Rows.Count / 2 - 0.01, 0)

        mdt.DefaultView.Sort = "Ten_mon"
        For i As Integer = dem To mdt.DefaultView.Count - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr("STT") = i + 1
            dr("TBCHP") = mdt.DefaultView.Item(i)("TBCHP")
            dr("Ten_mon") = mdt.DefaultView.Item(i)("Ten_mon")
            dr("So_hoc_trinh") = mdt.DefaultView.Item(i)("So_hoc_trinh")
            dt.Rows.Add(dr)
        Next
        rpt2.DataSource = dt.DefaultView
        rpt2.binding()
    End Sub
End Class