Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiem_Tot_Nghiep_Main_PrintAll
    Private dict As Dictionary(Of String, DataView)
    Private mTBCHT As Double = 0
    Private mXep_loai As String = ""
    Private mThucTapTotNghiep_Diem As Double = 0
    Private mThucTapTotNghiep_HocTrinh As Double = 0
    Private mThi_CS_Nganh_Diem As Double = 0
    Private mThi_CS_Nganh_HocTrinh As Double = 0
    Private mThi_CN_Diem As Double = 0
    Private mThi_CN_HocTrinh As Double = 0
    Private mKhoaLuan_Diem As Double = 0
    Private mKhoaLuan_HocTrinh As Double = 0
    Public Sub New(ByVal dv As DataView, ByVal dict1 As Dictionary(Of String, DataView), ByVal tieu_de_bao_cao As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.dict = dict1
        binding()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.tieu_de.Text = tieu_de_bao_cao
        TieuDe_ChucDanh.Text = gTieu_de_chuc_danh1
        Ten_ChucDanh.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        'mXep_loai = dv.Item(0)("Xep_hang").ToString
        'mTBCHT = dv.Item(0)("TBCHT").ToString
    End Sub
    Public Sub binding()
        ID_SVLIn.DataBindings.Add("Text", DataSource, "ID_sv")
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten").ToString().ToUpper()
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Que_quan.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Nien_khoa.DataBindings.Add("Text", DataSource, "Nien_khoa")
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_nganh")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
        Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Try
            Dim rpt As rptBangDiem_TotNghiep_Sub_PrintAll_Left = XrSubreport1.ReportSource
            Dim id_sv1 As Integer
            If ID_SVLIn.Text.Length > 0 Then
                id_sv1 = Convert.ToInt32(ID_SVLIn.Text)
            End If
            Dim dv1 As DataView = dict.Item(id_sv1)
            'dv1.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
            dv1.RowFilter = "Mon_tot_nghiep=FALSE"
            Dim dt_sub1 As New DataTable
            dt_sub1.Columns.Add("STT")
            dt_sub1.Columns.Add("Ten_mon")
            dt_sub1.Columns.Add("So_hoc_trinh")
            dt_sub1.Columns.Add("TBCHP")
            dt_sub1.Columns.Add("TBCHT")
            dt_sub1.Columns.Add("Xep_hang")
            Dim tong As Integer = dv1.Count
            Dim dem As Integer = Math.Round(tong / 2, 1)
            If dv1.Count > 0 Then
                For i As Integer = 0 To dem + 2
                    Dim dr As DataRow
                    dr = dt_sub1.NewRow
                    dr("STT") = i + 1
                    dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                    dr("So_hoc_trinh") = dv1.Item(i)("So_hoc_trinh")
                    dr("TBCHP") = dv1.Item(i)("TBCHP")
                    dr("TBCHT") = TBCHT.Text.ToString
                    dr("Xep_hang") = Xep_hang.Text.ToString
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
            Dim rpt2 As rptBangDiem_TotNghiep_Sub_PrintAll_Right = XrSubreport2.ReportSource
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
                        If dv2.Item(i)("Kien_thuc") = 17 AndAlso dv2.Item(i)("TBCHP").ToString <> "" Then ' Co so nganh
                            mThi_CS_Nganh_Diem = dv2.Item(i)("TBCHP")
                            mThi_CS_Nganh_HocTrinh = dv2.Item(i)("So_hoc_trinh")
                        ElseIf dv2.Item(i)("Kien_thuc") = 18 AndAlso dv2.Item(i)("TBCHP").ToString <> "" Then ' Chuyen nganh
                            mThi_CN_Diem = dv2.Item(i)("TBCHP")
                            mThi_CN_HocTrinh = dv2.Item(i)("So_hoc_trinh")
                        ElseIf dv2.Item(i)("Kien_thuc") = 15 AndAlso dv2.Item(i)("TBCHP").ToString <> "" Then  ' Bao cao thuc tap tot nghiep
                            mThucTapTotNghiep_Diem = dv2.Item(i)("TBCHP")
                            mThucTapTotNghiep_HocTrinh = dv2.Item(i)("So_hoc_trinh")
                        End If
                    End If
                End If
            Next
            'dv2.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
            dv2.RowFilter = "Mon_tot_nghiep=FALSE"
            Dim dt_sub2 As New DataTable
            dt_sub2.Columns.Add("STT")
            dt_sub2.Columns.Add("Ten_mon")
            dt_sub2.Columns.Add("So_hoc_trinh")
            dt_sub2.Columns.Add("TBCHP")
            dt_sub2.Columns.Add("TBCHT")
            dt_sub2.Columns.Add("Xep_hang")
            Dim tong As Integer = dv2.Count
            Dim dem As Integer = Math.Round(tong / 2, 1)
            If dv2.Count > 0 Then
                For i As Integer = dem + 3 To tong - 1
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
            rpt2.binding(mTBCHT, mXep_loai, mThi_CS_Nganh_Diem, mThi_CS_Nganh_HocTrinh, mThi_CN_Diem, mThi_CN_HocTrinh, mThucTapTotNghiep_Diem, mThucTapTotNghiep_HocTrinh)
        Catch ex As Exception
        End Try
    End Sub
End Class