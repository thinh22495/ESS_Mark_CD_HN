Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rptBangDiem_Tot_Nghiep_Main
    Private subdata As DataView
    Private subdata2 As DataView
    Private mID_sv As Integer
    Private mdt As DataTable
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

    Private mDem As Integer = 0

    Public Sub New(ByVal TBCHT As Double, ByVal Xep_loai As String, Optional ByVal ID_sv As Integer = 0, Optional ByVal Tieu_de_bao_cao As String = "")
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

            mTBCHT = TBCHT
            mXep_loai = Xep_loai

            For i As Integer = 0 To mdt.Rows.Count - 1
                If mdt.DefaultView.Item(i)("Khong_tinh_TBCHT") = False Then
                    If mdt.DefaultView.Item(i)("Mon_tot_nghiep") = True Then
                        ' La cac hoc phan thi tot nghiep
                        If mdt.DefaultView.Item(i)("Kien_thuc") = 18 AndAlso mdt.DefaultView.Item(i)("TBCHP").ToString <> "" Then ' Co so nganh
                            mThi_CS_Nganh_Diem = mdt.DefaultView.Item(i)("TBCHP")
                            mThi_CS_Nganh_HocTrinh = mdt.DefaultView.Item(i)("So_hoc_trinh")
                        ElseIf mdt.DefaultView.Item(i)("Kien_thuc") = 17 AndAlso mdt.DefaultView.Item(i)("TBCHP").ToString <> "" Then ' Chuyen nganh
                            mThi_CN_Diem = mdt.DefaultView.Item(i)("TBCHP")
                            mThi_CN_HocTrinh = mdt.DefaultView.Item(i)("So_hoc_trinh")
                        ElseIf mdt.DefaultView.Item(i)("Kien_thuc") = 15 AndAlso mdt.DefaultView.Item(i)("TBCHP").ToString <> "" Then  ' Bao cao thuc tap tot nghiep
                            mThucTapTotNghiep_Diem = mdt.DefaultView.Item(i)("TBCHP")
                            mThucTapTotNghiep_HocTrinh = mdt.DefaultView.Item(i)("So_hoc_trinh")
                            'ElseIf mdt.DefaultView.Item(i)("Kien_thuc") = 4 AndAlso mdt.DefaultView.Item(i)("TBCHP").ToString <> "" Then  ' Hoc phan khoa luan
                            '    mKhoaLuan_Diem = mdt.DefaultView.Item(i)("TBCHP")
                            '    mKhoaLuan_HocTrinh = mdt.DefaultView.Item(i)("So_hoc_trinh")
                        End If
                    End If
                End If
            Next
            mdt.DefaultView.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
            mDem = Math.Round(mdt.DefaultView.Count / 2 - 0.01, 0)
        End If
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptBangDiem_TotNghiep_Sub_Left = XrSubreport1.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")

        mdt.DefaultView.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
        'mdt.DefaultView.Sort = "Ten_mon"
        For i As Integer = 0 To mDem + 2
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
        'If mKhoaLuan_Diem <= 0 Then ' Truong hop sinh vien khong lam khoa luan ma thi Tot nghiep - Mau bang diem khac
        Dim rpt2 As rptBangDiem_TotNghiep_Sub_Right = XrSubreport2.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")

        mdt.DefaultView.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
        'mdt.DefaultView.Sort = "Ten_mon"
        For i As Integer = mDem + 3 To mdt.DefaultView.Count - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr("STT") = i + 1
            dr("TBCHP") = mdt.DefaultView.Item(i)("TBCHP")
            dr("Ten_mon") = mdt.DefaultView.Item(i)("Ten_mon")
            dr("So_hoc_trinh") = mdt.DefaultView.Item(i)("So_hoc_trinh")
            dt.Rows.Add(dr)
        Next
        rpt2.DataSource = dt.DefaultView
        rpt2.binding(mTBCHT, mXep_loai, mThi_CS_Nganh_Diem, mThi_CS_Nganh_HocTrinh, mThi_CN_Diem, mThi_CN_HocTrinh, mThucTapTotNghiep_Diem, mThucTapTotNghiep_HocTrinh)
    End Sub
End Class