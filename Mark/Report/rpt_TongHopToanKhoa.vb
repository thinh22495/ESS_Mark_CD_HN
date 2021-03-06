Imports DevExpress.XtraReports.UI
Public Class rpt_TongHopToanKhoa
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal Tieu_de_bao_cao_2 As String = "", Optional ByVal dtTenMon As DataTable = Nothing)
        InitializeComponent()
        Dim dv As DataView = dtMain.DefaultView
        Dim dv2 As DataView = dtSub.DefaultView
        Dim dv3 As DataView = dtTenMon.DefaultView
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de_bao_cao
        Me.Tieu_de_2.Text = Tieu_de_bao_cao_2.ToString.ToUpper
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4

        Dim Tong_sv, HL_XS, HL_Gioi, HL_Kha, HL_TBK, HL_TB, HL_Yeu, HL_Kem, RL_XS, RL_Tot, RL_Kha, RL_TBK, RL_TB, RL_Yeu, RL_Kem As Integer
        Dim PT_HL_XS, PT_HL_Gioi, PT_HL_Kha, PT_HL_TBK, PT_HL_TB, PT_HL_Yeu, PT_HL_Kem, PT_RL_XS, PT_RL_Tot, PT_RL_Kha, PT_RL_TBK, PT_RL_TB, PT_RL_Yeu, PT_RL_Kem As Double
        Tong_sv = dv.Count
        Try
            If dv.Count > 0 Then
                For f As Integer = 0 To dv.Count - 1
                    If CType(dv.Item(f)("ID_xep_loai"), Integer) = 1 Then
                        HL_XS = HL_XS + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 2 Then
                        HL_Gioi = HL_Gioi + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 3 Then
                        HL_Kha = HL_Kha + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 4 Then
                        HL_TBK = HL_TBK + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 5 Then
                        HL_TB = HL_TB + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 6 Then
                        HL_Yeu = HL_Yeu + 1
                    ElseIf CType(dv.Item(f)("ID_xep_loai"), Integer) = 7 Then
                        HL_Kem = HL_Kem + 1
                    End If
                Next
            End If
        Catch ex As Exception

        End Try



        Me.HL_XS.Text = HL_XS
        Me.HL_Gioi.Text = HL_Gioi
        Me.HL_Kha.Text = HL_Kha
        Me.HL_TBK.Text = HL_TBK
        Me.HL_TB.Text = HL_TB
        Me.HL_Yeu.Text = HL_Yeu
        Me.HL_Kem.Text = HL_Kem

        PT_HL_Yeu = Math.Round((HL_Yeu / Tong_sv) * 100, 2)
        PT_HL_Kem = Math.Round((HL_Kem / Tong_sv) * 100, 2)
        PT_HL_XS = Math.Round((HL_XS / Tong_sv) * 100, 2)
        PT_HL_Gioi = Math.Round((HL_Gioi / Tong_sv) * 100, 2)
        PT_HL_Kha = Math.Round((HL_Kha / Tong_sv) * 100, 2)
        PT_HL_TB = Math.Round((HL_TB / Tong_sv) * 100, 2)
        PT_HL_TBK = 100 - PT_HL_Yeu - PT_HL_Kem - PT_HL_XS - PT_HL_Gioi - PT_HL_Kha - PT_HL_TB

        Me.HL_PT_XS.Text = PT_HL_XS
        Me.HL_PT_Gioi.Text = PT_HL_Gioi
        Me.HL_PT_Kha.Text = PT_HL_Kha
        Me.HL_PT_TBK.Text = PT_HL_TBK
        Me.HL_PT_TB.Text = PT_HL_TB
        Me.HL_PT_Yeu.Text = PT_HL_Yeu
        Me.HL_PT_Kem.Text = PT_HL_Kem

        For k As Integer = 0 To dv.Count - 1
            If CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 1 Then
                RL_XS = RL_XS + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 2 Then
                RL_Tot = RL_Tot + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 3 Then
                RL_Kha = RL_Kha + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 4 Then
                RL_TBK = RL_TBK + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 5 Then
                RL_TB = RL_TB + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 6 Then
                RL_Yeu = RL_Yeu + 1
            ElseIf CType(dv.Item(k)("ID_Xep_loai_RL"), Integer) = 7 Then
                RL_Kem = RL_Kem + 1
            End If
        Next

        Me.HK_XS.Text = RL_XS
        Me.HK_Tot.Text = RL_Tot
        Me.HK_Kha.Text = RL_Kha
        Me.HK_TBK.Text = RL_TBK
        Me.HK_TB.Text = RL_TB
        Me.HK_Yeu.Text = RL_Yeu
        Me.HK_Kem.Text = RL_Kem

        PT_RL_Yeu = Math.Round((RL_Yeu / Tong_sv) * 100, 2)
        PT_RL_Kem = Math.Round((RL_Kem / Tong_sv) * 100, 2)
        PT_RL_XS = Math.Round((RL_XS / Tong_sv) * 100, 2)
        PT_RL_Tot = Math.Round((RL_Tot / Tong_sv) * 100, 2)
        PT_RL_Kha = Math.Round((RL_Kha / Tong_sv) * 100, 2)
        PT_RL_TB = Math.Round((RL_TB / Tong_sv) * 100, 2)
        PT_RL_TBK = 100 - PT_RL_Yeu - PT_RL_Kem - PT_RL_XS - PT_RL_Tot - PT_RL_Kha - PT_RL_TB



        Me.HK_PT_XS.Text = PT_RL_XS
        Me.HK_PT_Tot.Text = PT_RL_Tot
        Me.HK_PT_Kha.Text = PT_RL_Kha
        Me.HK_PT_TBK.Text = PT_RL_TBK
        Me.HK_PT_TB.Text = PT_RL_TB
        Me.HK_PT_Yeu.Text = PT_RL_Yeu
        Me.HK_PT_Kem.Text = PT_RL_Kem


        Me.So_sv.Text = dv.Count
        dv.RowFilter = "Ten_mon_no <> ''"
        Me.So_sv_hoc_lai.Text = dv.Count
        Me.So_sv_khong_hoc_lai.Text = CType(So_sv.Text, Integer) - CType(So_sv_hoc_lai.Text, Integer)
        dv.RowFilter = "1=1"
        dv.RowFilter = "Danh_hieu_thi_dua = 'HSXS' OR Danh_hieu_thi_dua = 'HSG'"
        Me.So_sv_gioi.Text = "Số HSSV giỏi: " & dv.Count
        dv.RowFilter = "1=1"
        dv.RowFilter = "Danh_hieu_thi_dua = 'HSK'"
        Me.So_sv_tien_tien.Text = "Số HSSV tiên tiến: " & dv.Count
        dv.RowFilter = "1=1"



        Dim numCol As Integer = dv2.Count - 1
        Dim childWidth As Double = HeadRow1.WidthF / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("Ten_mon").ToString
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow4.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow1.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            ValueRow.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "M" & dv2(j).Row("ID_mon"))
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next

        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("So_hoc_trinh")
            lb.WidthF = childWidth
            lb.HeightF = XrTable_hoc_trinh.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow_hoc_trinh.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv3(i).Row("TenMon")
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow3.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            XrTableCell12.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next


        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
        'TBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
        Ten_mon_no.DataBindings.Add("Text", DataSource, "Ten_mon_no")
        So_mon_no.DataBindings.Add("Text", DataSource, "So_mon_no")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
        TongDiem_RL.DataBindings.Add("Text", DataSource, "TBC_RL")
        Xep_loai_RL.DataBindings.Add("Text", DataSource, "Xep_loai_RL")
        Diem_quy_doi.DataBindings.Add("Text", DataSource, "Diem_quy_doi")
        TBC_mo_rong.DataBindings.Add("Text", DataSource, "TBC_MR")
        Danh_hieu.DataBindings.Add("Text", DataSource, "Danh_hieu_thi_dua")
        Me.DataSource = dtMain
    End Sub
End Class