Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiemTotNghiep_CNC
    Private dict As Dictionary(Of String, DataView)
    Private mTBCHT As Double = 0
    Private mXep_loai As String = ""

    Private mMon_LyThuyet_Diem As Double = 0
    Private mMon_LyThuyet_HocTrinh As Double = 0

    Private mMon_ThucHanh_Diem As Double = 0
    Private mMon_ThucHanh_HocTrinh As Double = 0

    Private mMon_ChinhTri_Diem As Double = 0
    Private mMon_ChinhTri_HocTrinh As Double = 0

    Private ChinhTri_HocTrinh As Double = 0
    Private ChinhTri_Diem As Double = 0

    Private PhapLuat_HocTrinh As Double = 0
    Private PhapLuat_Diem As Double = 0

    Private GDTC_HocTrinh As Double = 0
    Private GDTC_Diem As Double = 0

    Private GDQP_HocTrinh As Double = 0
    Private GDQP_Diem As Double = 0

    Public Sub New(ByVal dv As DataView, ByVal dict1 As Dictionary(Of String, DataView), ByVal tieu_de_bao_cao As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.dict = dict1
        binding()
        'Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.tieu_de.Text = tieu_de_bao_cao
        Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()

       
    End Sub
    Public Sub binding()
        ID_SVLIn.DataBindings.Add("Text", DataSource, "ID_sv")
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten").ToString().ToUpper()
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Que_quan.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Nien_khoa.DataBindings.Add("Text", DataSource, "Nien_khoa")
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
        Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            Dim rpt As rptBangDiem_TotNghiep_Sub_PrintAll_Left_2_Dau_Diem = XrSubreport1.ReportSource
            Dim id_sv1 As Integer
            If ID_SVLIn.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_SVLIn.Text)
            End If
            Dim dv1 As DataView = dict.Item(id_sv1)

            For i As Integer = 0 To dv1.Count - 1
                If dv1.Item(i)("Kien_thuc") = 12 Then
                    ChinhTri_HocTrinh += dv1.Item(i)("So_hoc_trinh")
                    ChinhTri_Diem += dv1.Item(i)("TBCHP") * dv1.Item(i)("So_hoc_trinh")
                ElseIf dv1.Item(i)("Kien_thuc") = 13 Then
                    PhapLuat_HocTrinh += dv1.Item(i)("So_hoc_trinh")
                    PhapLuat_Diem += dv1.Item(i)("TBCHP") * dv1.Item(i)("So_hoc_trinh")
                ElseIf dv1.Item(i)("Kien_thuc") = 14 Then
                    GDTC_HocTrinh += dv1.Item(i)("So_hoc_trinh")
                    GDTC_Diem += dv1.Item(i)("TBCHP") * dv1.Item(i)("So_hoc_trinh")
                ElseIf dv1.Item(i)("Kien_thuc") = 15 Then
                    GDQP_HocTrinh += dv1.Item(i)("So_hoc_trinh")
                    GDQP_Diem += dv1.Item(i)("TBCHP") * dv1.Item(i)("So_hoc_trinh")
                End If
            Next
            Dim TB_ChinhTri As Double = 0
            If ChinhTri_HocTrinh > 0 Then
                TB_ChinhTri = Math.Round((ChinhTri_Diem / ChinhTri_HocTrinh) + 0.0000001, 1)
            End If

            Dim TB_PhapLuat As Double = 0
            If PhapLuat_HocTrinh > 0 Then
                TB_PhapLuat = Math.Round((PhapLuat_Diem / PhapLuat_HocTrinh) + 0.0000001, 1)
            End If

            Dim TB_GDTC As Double = 0
            If GDTC_HocTrinh > 0 Then
                TB_GDTC = Math.Round((GDTC_Diem / GDTC_HocTrinh) + 0.0000001, 1)
            End If

            Dim TB_GDQP As Double = 0
            If GDQP_HocTrinh > 0 Then
                TB_GDQP = Math.Round((GDQP_Diem / GDQP_HocTrinh) + 0.0000001, 1)
            End If

            dv1.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
            Dim dt_sub1 As New DataTable
            dt_sub1.Columns.Add("STT", GetType(Integer))
            dt_sub1.Columns.Add("Ten_mon", GetType(String))
            dt_sub1.Columns.Add("So_hoc_trinh", GetType(Double))
            dt_sub1.Columns.Add("TBCHP", GetType(Double))
            dt_sub1.Columns.Add("TBCHT", GetType(Double))
            Dim tong As Integer = dv1.Count
            Dim dem As Integer = Math.Round(tong / 2, 1)
            If dv1.Count > 0 Then
                For i As Integer = 0 To dem
                    Dim dr As DataRow
                    dr = dt_sub1.NewRow
                    dr("STT") = i + 1
                    dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                    dr("So_hoc_trinh") = dv1.Item(i)("So_hoc_trinh")
                    dr("TBCHP") = dv1.Item(i)("TBCHP")
                    dr("TBCHT") = TBCHT.Text.ToString
                    dt_sub1.Rows.Add(dr)
                Next
            End If
            rpt.DataSource = dt_sub1.DefaultView
            rpt.binding(TB_ChinhTri, ChinhTri_HocTrinh, TB_PhapLuat, PhapLuat_HocTrinh, TB_GDTC, GDTC_HocTrinh, TB_GDQP, GDQP_HocTrinh)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Try
            Dim rpt2 As rptBangDiem_TotNghiep_Sub_PrintAll_Right_2_Dau_Diem = XrSubreport2.ReportSource
            Dim id_sv1 As Integer
            If ID_SVLIn.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_SVLIn.Text)
            End If
            dict.Item(id_sv1).RowFilter = "1=1"
            Dim dv2 As DataView = dict.Item(id_sv1)

            For i As Integer = 0 To dv2.Count - 1
                If dv2.Item(i)("Khong_tinh_TBCHT") = False Then
                    If dv2.Item(i)("Mon_tot_nghiep") = True Then
                        ' La cac hoc phan thi tot nghiep
                        If dv2.Item(i)("Ly_thuyet_nghe") = True AndAlso dv2.Item(i)("TBCHP").ToString <> "" Then ' Lý thuyết nghề
                            mMon_LyThuyet_Diem = dv2.Item(i)("TBCHP")
                            mMon_LyThuyet_HocTrinh = dv2.Item(i)("So_hoc_trinh")
                        ElseIf dv2.Item(i)("Thuc_hanh_nghe") = True AndAlso dv2.Item(i)("TBCHP").ToString <> "" Then ' Thực hành nghề
                            mMon_ThucHanh_Diem = dv2.Item(i)("TBCHP")
                            mMon_ThucHanh_HocTrinh = dv2.Item(i)("So_hoc_trinh")
                        End If
                    End If
                End If
            Next

            For j As Integer = 0 To dv2.Count - 1
                If dv2.Item(j)("Khong_tinh_TBCHT") = True And dv2.Item(j)("Mon_tot_nghiep") = True Then
                    ' La cac hoc phan thi tot nghiep
                    If dv2.Item(j)("Kien_thuc") = 11 AndAlso dv2.Item(j)("TBCHP").ToString <> "" Then ' Lý luận chính trị
                        mMon_ChinhTri_Diem = dv2.Item(j)("TBCHP")
                        mMon_ChinhTri_HocTrinh = dv2.Item(j)("So_hoc_trinh")
                    End If
                End If
            Next
            dv2.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
            'dv2.RowFilter = "Mon_tot_nghiep=FALSE"
            Dim dt_sub2 As New DataTable
            dt_sub2.Columns.Add("STT", GetType(Integer))
            dt_sub2.Columns.Add("Ten_mon", GetType(String))
            dt_sub2.Columns.Add("So_hoc_trinh", GetType(Double))
            dt_sub2.Columns.Add("TBCHP", GetType(Double))
            dt_sub2.Columns.Add("TBCHT", GetType(Double))
            dt_sub2.Columns.Add("Xep_hang", GetType(String))
            Dim tong As Integer = dv2.Count
            Dim dem As Integer = Math.Round(tong / 2, 1)
            If dv2.Count > 0 Then
                For i As Integer = dem + 1 To tong - 1
                    Dim dr As DataRow
                    dr = dt_sub2.NewRow
                    dr("STT") = i + 1
                    dr("Ten_mon") = dv2.Item(i)("Ten_mon")
                    dr("So_hoc_trinh") = dv2.Item(i)("So_hoc_trinh")
                    dr("TBCHP") = dv2.Item(i)("TBCHP")
                    dr("TBCHT") = TBCHT.Text.ToString
                    dr("Xep_hang") = Xep_hang.Text.ToString
                    dt_sub2.Rows.Add(dr)
                Next
            End If
            rpt2.DataSource = dt_sub2.DefaultView
            rpt2.binding(mMon_LyThuyet_Diem, mMon_LyThuyet_HocTrinh, mMon_ThucHanh_Diem, mMon_ThucHanh_HocTrinh, mMon_ChinhTri_Diem, mMon_ChinhTri_HocTrinh)
        Catch ex As Exception
        End Try
    End Sub
End Class