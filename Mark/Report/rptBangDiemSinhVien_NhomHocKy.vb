Public Class rptBangDiemSinhVien_NhomHocKy
    Private _dvmain As DataView
    Private _dv_TN As DataView
    Public Sub New(ByVal dv As DataView, ByVal dvTN As DataView)
        InitializeComponent()
        _dvmain = dv
        _dv_TN = dvTN
        Me.DataSource = dv
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.XrLabel1.Text = gTieu_de_ten_bo
        Me.XrLabel2.Text = gTieu_de_ten_truong
        Binding()
    End Sub

    Public Sub Binding()
        txtHo_ten.DataBindings.Add("Text", DataSource, "Ho_ten").ToString()
        txtNgay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        txtNoi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        txtTen_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        txtChuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Loai_dao_tao.DataBindings.Add("Text", DataSource, "Loai_dao_tao")


        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP_max")
        TBCHP1.DataBindings.Add("Text", DataSource, "TBCHP1")

        Nam_hoc.DataBindings.Add("Text", DataSource, "NamHoc")

        Xep_loai_rl.DataBindings.Add("Text", DataSource, "Xep_hang_rl")
        TBCHK.DataBindings.Add("Text", DataSource, "TBC_ky")
        Xep_hang_ky.DataBindings.Add("Text", DataSource, "Xep_hang_ky")
    End Sub
    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("NamHoc")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        Dim rpt As rptBangDiemSinhVien_NhomHocKySUB = XrSubreport1.ReportSource
        Dim Tong_diem As Double = 0
        Dim Tong_hoc_trinh As Double = 0
        Dim TBC_toan_khoa As Double = 0
        For i As Integer = 0 To _dvmain.Count - 1
            If _dvmain.Item(i)("Mon_tot_nghiep") = False And _dvmain.Item(i)("Khong_tinh_TBCHT") = False Then
                Tong_diem += _dvmain.Item(i)("TBCHP") * _dvmain.Item(i)("So_hoc_trinh")
                Tong_hoc_trinh += _dvmain.Item(i)("So_hoc_trinh")
            End If
        Next
        If Tong_hoc_trinh > 0 Then
            TBC_toan_khoa = Math.Round(Tong_diem / Tong_hoc_trinh, 1)
            rpt.DTB_toan_khoa.Text = TBC_toan_khoa
        End If
        Dim Diem_CT As Double = 0
        Dim Thuc_hanh_nghe As Double = 0
        Dim Ly_thuuyet_nghe As Double = 0
        If _dv_TN.Count > 0 Then
            For i As Integer = 0 To _dv_TN.Count - 1
                If _dv_TN.Item(i)("Kien_thuc") = 11 Then
                    rpt.txtChinh_tri.Text = _dv_TN.Item(i)("TBCHP")
                    Diem_CT = _dv_TN.Item(i)("TBCHP")
                ElseIf _dv_TN.Item(i)("Kien_thuc") = 9 Then
                    rpt.txtLy_thuyet_nghe.Text = _dv_TN.Item(i)("TBCHP")
                    Ly_thuuyet_nghe = _dv_TN.Item(i)("TBCHP")
                ElseIf _dv_TN.Item(i)("Kien_thuc") = 10 Then
                    rpt.txtThuc_hanh_nghe.Text = _dv_TN.Item(i)("TBCHP")
                    Thuc_hanh_nghe = _dv_TN.Item(i)("TBCHP")
                End If
            Next

            If Diem_CT > 0 And Thuc_hanh_nghe > 0 And Ly_thuuyet_nghe > 0 Then
                Dim TBC_TN As Double = 0
                TBC_TN = Math.Round((Thuc_hanh_nghe * 2 + Ly_thuuyet_nghe + TBC_toan_khoa * 3) / 6, 1)
                rpt.TBCHP.Text = TBC_TN

                If TBC_TN >= 9 Then 'XS;
                    rpt.Xep_loai_TN.Text = "Xuất sắc"
                ElseIf TBC_TN < 9 And TBC_TN >= 8 Then 'Gioi
                    rpt.Xep_loai_TN.Text = "Giỏi"
                ElseIf TBC_TN < 8 And TBC_TN >= 7 Then 'Kha
                    rpt.Xep_loai_TN.Text = "Khá"
                ElseIf TBC_TN < 7 And TBC_TN >= 6 Then 'TB kha
                    rpt.Xep_loai_TN.Text = "TB Khá"
                ElseIf TBC_TN < 6 And TBC_TN >= 5 Then 'TB 
                    rpt.Xep_loai_TN.Text = "Trung bình"
                ElseIf TBC_TN < 5 And TBC_TN >= 4 Then 'Yeu
                    rpt.Xep_loai_TN.Text = "Yếu"
                Else 'Kem
                    rpt.Xep_loai_TN.Text = "Kém"
                End If
            End If
        End If
    End Sub
End Class