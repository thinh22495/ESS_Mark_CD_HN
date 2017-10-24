Imports System
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class QuyCheDaoTao
#Region "Var"
        Private mQuy_che As Integer = 25    'Mặc định quy chế 25 cho hệ Đại học, Cao đẳng
        Private mDiem_chuyen_can As Integer = 5  'Điểm chuyên cần
        Private mDiem_kiem_tra_dat As Integer = 5  'Điểm kiểm tra đánh giá là đạt
        Private mDu_diem_thanh_phan As Boolean = 1 'Có đủ số điểm kiểm tra giữa học phần quy định
        Private mKhong_co_diem_khong As Boolean = 1   'Không có kiểm tra giữa học phần điểm 0
        Private mPhan_tram_diem_thanh_phan_dat As Integer = 50 'Có ít nhất % số điểm kiểm tra giữa học phần đạt từ 5 trở lên
        Private mPhan_tram_so_tiet_nghi As Integer = 20 'Phần trăm số tiết lý thuyết nghỉ vượt quá % số tiết quy định
        Private mPhan_tram_so_tiet_nghi_TH As Integer = 0 'Phần trăm số tiết thực hành nghỉ vượt quá % số tiết quy định

        Private mDiem_hoc_phan_dat As Integer = 5 'Điểm tổng kết môn học (ĐHP) đánh giá là đạt
        Private mSo_lan_thi_lai As Integer = 2 'Số lần thi lại
        Private mThanhPhan_lam_tron As Integer = 0 'Điểm Thành phần làm tròn đến chữ số thập phân
        Private mThi_lam_tron As Integer = 0 'Điểm Thi làm tròn đến chữ số thập phân
        Private mTBCBP_he_so As Integer = 1 'Hệ số điểm TBCBP
        Private mThi_he_so As Integer = 2 'Hệ số điểm thi kết thúc học phần
        Private mTBCBP_lam_tron As Integer = 1 'Điểm bộ phận (TBCBP) làm tròn đến chữ số thập phân
        Private mTBCHP_lam_tron As Integer = 0 'Điểm học phần (ĐHP) làm tròn đến chữ số thập phân

        Private mTBCHT_lam_tron As Integer = 2 'Điểm tổng kết (TBCHT) học kỳ, năm học, toàn khóa học làm tròn đến chữ số thập phân
        Private mTongSo_DVHT_coDiem_duoi5 As Integer = 25 'khối lượng các học phần bị điểm dưới 5 tính từ đầu khoá học không quá 25 đơn vị học trình
        Private mPtramHoctrinhThilai_Hatotnghiep As Integer = 5
#End Region
#Region "Constructor"
        Sub New()

        End Sub
        Sub New(ByVal ID_he As Integer)
            mQuy_che = Load_QuyChe(ID_he)
            'Đọc tham số hóa các quy chế đào tạo
            mDiem_chuyen_can = Load_ThamSoQuyChe(Quy_che, "Diem_chuyen_can")
            mDiem_kiem_tra_dat = Load_ThamSoQuyChe(Quy_che, "Diem_kiem_tra_dat")
            mDu_diem_thanh_phan = Load_ThamSoQuyChe(Quy_che, "Du_diem_thanh_phan")
            mKhong_co_diem_khong = Load_ThamSoQuyChe(Quy_che, "Khong_co_diem_khong")
            mPhan_tram_diem_thanh_phan_dat = Load_ThamSoQuyChe(Quy_che, "Phan_tram_diem_thanh_phan_dat")
            mPhan_tram_so_tiet_nghi = Load_ThamSoQuyChe(Quy_che, "Phan_tram_so_tiet_nghi")
            mPhan_tram_so_tiet_nghi_TH = Load_ThamSoQuyChe(Quy_che, "Phan_tram_so_tiet_nghi_th")

            mDiem_hoc_phan_dat = Load_ThamSoQuyChe(Quy_che, "Diem_hoc_phan_dat")
            mSo_lan_thi_lai = Load_ThamSoQuyChe(Quy_che, "So_lan_thi_lai")
            mThanhPhan_lam_tron = Load_ThamSoQuyChe(Quy_che, "ThanhPhan_lam_tron")
            mThi_lam_tron = Load_ThamSoQuyChe(Quy_che, "Thi_lam_tron")
            mTBCBP_he_so = Load_ThamSoQuyChe(Quy_che, "TBCBP_he_so")
            mThi_he_so = Load_ThamSoQuyChe(Quy_che, "Thi_he_so")
            mTBCBP_lam_tron = Load_ThamSoQuyChe(Quy_che, "TBCBP_lam_tron")
            mTBCHP_lam_tron = Load_ThamSoQuyChe(Quy_che, "TBCHP_lam_tron")

            mTBCHT_lam_tron = Load_ThamSoQuyChe(Quy_che, "TBCHT_lam_tron")
            mTongSo_DVHT_coDiem_duoi5 = Load_ThamSoQuyChe(Quy_che, "TongSo_DVHT_coDiem_duoi5")
            mPtramHoctrinhThilai_Hatotnghiep = Load_ThamSoQuyChe(Quy_che, "PtramHoctrinhThilai_Hatotnghiep")
        End Sub
#End Region
#Region "Function"
        Public Function KhongDuDieuKienDuThi(ByVal Lan_hoc As Integer, ByVal dsThanhPhan As ThanhPhanDiem, ByVal objDiem As Diem) As String
            'If objDiem.ID_sv = 16494 Then
            '    objDiem.ID_sv = 16494
            'End If

            Dim Ly_do As String = "_"
            Dim idx As Integer
            Dim Phan_tram_nghi As Integer = 0
            Dim Phan_tram_nghi_th As Integer = 0
            Dim Thieu_bai_thuc_hanh As Byte = 0
            Dim Diem_cc As Double = 0
            Dim Thieu_diem_tp As Boolean = False
            Dim Diem_tp_bang_khong As Boolean = False
            Dim So_tp_khong_dat As Integer = 0
            Dim Ty_le_tp_khong_dat As Double = 0
            Dim TBCBP As Double = 0

            Dim Tong_diem_tp As Double = -1
            Dim Tong_ty_le As Integer

            idx = objDiem.dsDiemDanh.Tim_idx(Lan_hoc)
            If idx >= 0 Then
                'If objDiem.So_tiet_th > 0 Then Phan_tram_nghi_th = (objDiem.dsDiemDanh.DiemDanh(idx).So_tiet_nghi_th / objDiem.So_tiet_th) * 100
                If (objDiem.So_tiet + objDiem.So_tiet_th) > 0 Then
                    'So tiet nghi ly thuyet
                    Phan_tram_nghi = ((objDiem.dsDiemDanh.DiemDanh(idx).So_tiet_nghi + objDiem.dsDiemDanh.DiemDanh(idx).So_tiet_nghi_th) / (objDiem.So_tiet + objDiem.So_tiet_th)) * 100
                End If
                If objDiem.dsDiemDanh.DiemDanh(idx).Thieu_bai_thuc_hanh Then
                    Thieu_bai_thuc_hanh = 1
                End If
            End If
            'Kiểm tra các thành phần điểm
            For i As Integer = 0 To dsThanhPhan.Count - 1
                If dsThanhPhan.ThanhPhanDiem(i).Checked Then
                    idx = objDiem.dsDiemThanhPhan.Tim_idx(dsThanhPhan.ThanhPhanDiem(i).ID_thanh_phan, Lan_hoc)
                    If idx >= 0 Then
                        'Điểm thành phần không đạt
                        If objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Diem < Diem_kiem_tra_dat Then
                            So_tp_khong_dat += 1
                        End If
                        'Điểm chuyên cần
                        If dsThanhPhan.ThanhPhanDiem(i).Ky_hieu = "CC" Or dsThanhPhan.ThanhPhanDiem(i).Ten_thanh_phan = "Chuyên cần" Then
                            Diem_cc = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Diem
                        End If

                        If Tong_diem_tp = -1 Then Tong_diem_tp = 0
                        Tong_diem_tp += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Diem * objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                        Tong_ty_le += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                    Else    'Không có đủ điểm thành phần
                        Thieu_diem_tp = Du_diem_thanh_phan
                    End If
                End If
            Next
            If Tong_ty_le > 0 And Tong_diem_tp >= 0 Then
                TBCBP = Tong_diem_tp / Tong_ty_le
                TBCBP = Math.Round(TBCBP + 0.0000001, TBCBP_lam_tron)
            Else
                TBCBP = -1
            End If

            Ty_le_tp_khong_dat = (So_tp_khong_dat / dsThanhPhan.Count) * 100
            Dim Noi_dung As String = "_"
            Select Case Quy_che
                Case 25 'Đại học, cao đẳng Hệ Chính quy
                    'If Diem_cc < Diem_chuyen_can Then
                    '    Ly_do = "Điểm chuyên cần <5"
                    'End If
                    'If TBCBP = 0 Then
                    '    Ly_do = "Điểm TBCBP =0"
                    'End If
                    If Phan_tram_nghi > Phan_tram_so_tiet_nghi Then
                        Ly_do += ", Nghỉ quá 20% số tiết"
                    End If
                    'If Tong_ty_le > 0 AndAlso Thieu_diem_tp Then
                    '    Ly_do = "Thiếu điểm thành phần"
                    'End If
                    If Diem_tp_bang_khong Then
                        Ly_do += ", Điểm thành phần =0"
                    End If
                    If Ty_le_tp_khong_dat > Phan_tram_diem_thanh_phan_dat Then
                        Ly_do += ", Số TP không đạt điểm từ 5 trở lên lớn hơn 50%"
                    End If
                    If Thieu_bai_thuc_hanh Then
                        Ly_do += ", Thiếu bài thực hành"
                    End If
                Case 36 'Đại học, cao đẳng Hệ VLVH
                    If Phan_tram_nghi > Phan_tram_so_tiet_nghi Then
                        Ly_do += ", Nghỉ quá 25% số tiết"
                    End If
                    If Thieu_diem_tp Then
                        Ly_do += "Thiếu điểm thành phần"
                    End If
                    If Diem_tp_bang_khong Then
                        Ly_do += ", Điểm thành phần =0"
                    End If
                    If Ty_le_tp_khong_dat > Phan_tram_diem_thanh_phan_dat Then
                        Ly_do += ", Số TP không đạt điểm từ 5 trở lên lớn hơn 50%"
                    End If
                    If Thieu_bai_thuc_hanh Then
                        Ly_do += ", Thiếu bài thực hành"
                    End If
                Case 40 'Trung cấp chuyên nghiệp Hệ Chính quy
                    If Phan_tram_nghi > Phan_tram_so_tiet_nghi Then
                        Ly_do += ", Nghỉ quá 20% số tiết"
                    End If
                    If Tong_ty_le > 0 AndAlso Thieu_diem_tp Then
                        Ly_do += ", Thiếu điểm thành phần"
                    End If
                    If Diem_tp_bang_khong Then
                        Ly_do += ", Điểm thành phần =0"
                    End If
                    If Ty_le_tp_khong_dat > Phan_tram_diem_thanh_phan_dat Then
                        Ly_do += ", Số TP không đạt điểm từ 5 trở lên lớn hơn 50%"
                    End If
                    If Thieu_bai_thuc_hanh Then
                        Ly_do += ", Thiếu bài thực hành"
                    End If
                Case 13 'Trung cấp chuyên nghiệp Hệ VLVH
                    If Phan_tram_nghi > Phan_tram_so_tiet_nghi Then
                        Ly_do += ", Nghỉ quá 20% số tiết"
                    End If
                    If Thieu_diem_tp Then
                        Ly_do += ", Thiếu điểm thành phần"
                    End If
                    If Diem_tp_bang_khong Then
                        Ly_do += ", Điểm thành phần =0"
                    End If
                    If Ty_le_tp_khong_dat > Phan_tram_diem_thanh_phan_dat Then
                        Ly_do += ", Số TP không đạt điểm từ 5 trở lên lớn hơn 50%"
                    End If
                    If Thieu_bai_thuc_hanh Then
                        Ly_do += ", Thiếu bài thực hành"
                    End If
                Case 14 'Sơ cấp
                    If Phan_tram_nghi > Phan_tram_so_tiet_nghi Then
                        Ly_do += ", Nghỉ quá 20% số tiết"
                    End If
                    If Phan_tram_nghi_th > Phan_tram_so_tiet_nghi_TH Then
                        Ly_do += ", Thiếu số tiết thực hành"
                    End If
                    If Tong_ty_le > 0 AndAlso Thieu_diem_tp Then
                        Ly_do += ", Thiếu điểm thành phần"
                    End If
                    'If Diem_tp_bang_khong Then
                    '    Ly_do = "Điểm thành phần =0"
                    'End If
                    'If Ty_le_tp_khong_dat > Phan_tram_diem_thanh_phan_dat Then
                    '    Ly_do = "Số TP không đạt điểm từ 5 trở lên lớn hơn 50%"
                    'End If
                    If TBCBP < 5 And TBCBP >= 0 Then
                        Ly_do += ", Điểm TBCKT < 5"
                    End If
                    If Thieu_bai_thuc_hanh Then
                        Ly_do += ", Thiếu bài thực hành"
                    End If
            End Select
            Return Ly_do.Replace("_,", "").Replace("_", "").Trim
        End Function
        Public Function HocLai(ByVal Lan_hoc As Integer, ByVal dsDiemThi As DiemThi) As Integer
            If dsDiemThi.TBCHP_max_LanHoc(Lan_hoc) < Diem_hoc_phan_dat Then
                Dim So_lan_da_thi As Integer = 0
                For i As Integer = 0 To dsDiemThi.Count - 1
                    If dsDiemThi.DiemThi(i).Lan_hoc = Lan_hoc Then
                        If dsDiemThi.DiemThi(i).Ghi_chu.ToUpper <> "M" Then
                            So_lan_da_thi += 1
                        End If
                    End If
                Next
                'Học lại do thi các lần không đạt
                If So_lan_thi_lai > 0 AndAlso (So_lan_da_thi > 0 AndAlso So_lan_da_thi Mod So_lan_thi_lai = 0) Then
                    Return 1
                End If
            Else
                If dsDiemThi.Diem_thi_lan(Lan_hoc, 1) < Diem_kiem_tra_dat And dsDiemThi.Diem_thi_lan(Lan_hoc, 2) < Diem_kiem_tra_dat Then
                    Return 1
                End If
            End If
            Return 0
        End Function
        Public Function ThiLai(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal dsDiemThi As DiemThi) As Integer
            Dim So_lan_da_thi As Integer = 0
            'Ghi chú: P: Vắng thi có phép, M: Môn miễn thi
            'Hệ Cao đẳng nghề chính quy: Sinh viên thi lần 1 dưới 5 sẽ phải thi lại lần 2
            If dsDiemThi.Diem_thi_lan(Lan_hoc, Lan_thi) < Diem_kiem_tra_dat Then
                Return 1
            End If
            If dsDiemThi.TBCHP_lan(Lan_hoc, Lan_thi) < Diem_hoc_phan_dat Then
                For i As Integer = 0 To dsDiemThi.Count - 1
                    If dsDiemThi.DiemThi(i).Lan_hoc = Lan_hoc And dsDiemThi.DiemThi(i).Lan_thi = Lan_thi Then
                        If dsDiemThi.DiemThi(i).Ghi_chu.ToUpper <> "P" And _
                            dsDiemThi.DiemThi(i).Ghi_chu.ToUpper <> "M" Then
                            So_lan_da_thi += 1
                        End If
                    End If
                Next
                If So_lan_thi_lai > 0 AndAlso (So_lan_da_thi > 0 AndAlso So_lan_da_thi Mod So_lan_thi_lai > 0) Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End Function
        Public Function NoMon(ByVal dsDiemThi As DiemThi) As Integer
            If dsDiemThi.TBCHP_max < 5 Then
                Return 1
            Else
                Return 0
            End If
        End Function
        Public Function DiemTBCBP(ByVal Lan_hoc As Integer, ByVal dsThanhPhan As ThanhPhanDiem, ByVal objDiemThanhPhan As DiemThanhPhan) As Double
            Dim idx As Integer
            Dim Tong_diem_tp As Double = -1
            Dim Tong_ty_le As Integer
            Dim TBCBP As Double = -1
            For i As Integer = 0 To dsThanhPhan.Count - 1
                If dsThanhPhan.ThanhPhanDiem(i).Checked Then
                    idx = objDiemThanhPhan.Tim_idx(dsThanhPhan.ThanhPhanDiem(i).ID_thanh_phan, Lan_hoc)
                    If idx >= 0 Then
                        If Tong_diem_tp = -1 Then Tong_diem_tp = 0
                        Tong_diem_tp += objDiemThanhPhan.DiemThanhPhan(idx).Diem * objDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                        Tong_ty_le += objDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                    Else
                        Tong_ty_le += dsThanhPhan.ThanhPhanDiem(i).Ty_le
                    End If
                End If
            Next
            If Tong_ty_le > 0 And Tong_diem_tp >= 0 Then
                TBCBP = Tong_diem_tp / Tong_ty_le
                'Làm tròn điểm TBCBP theo các quy chế
                TBCBP = Math.Round(TBCBP + 0.00000001, TBCBP_lam_tron)
                Return TBCBP
            Else
                Return -1
            End If
        End Function
        Function Round_Mark(ByVal Diem_TBCMH As Double) As Double
            Diem_TBCMH = Math.Round(Diem_TBCMH, 2)
            If Diem_TBCMH > 0 Then
                Dim Diem As Double = Math.Truncate(Diem_TBCMH)
                Dim Diem_le As Double = Diem_TBCMH - Diem

                If Diem_le > 0.25 And Diem_le <= 0.75 Then Diem = Diem + 0.5
                If Diem_le > 0.75 Then Diem = Diem + 1
                Return Diem
            Else
                Return 0
            End If
        End Function
        Public Function DiemTBCHP(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal objDiem As Diem, ByVal dsThanhPhan As ThanhPhanDiem) As Double
            Dim idx As Integer
            Dim TBCBP, TBCHP As Double
            Dim TongdiemTP As Double = 0
            Dim TongPhanTramTP As Integer = 0
            Dim DiemThi As Double = -1
            Dim So_thanh_phan As Integer = 0
            ''
            Dim Tong_diem As Double = 0 ''haivt
            Dim TOng_ty_le As Integer = 0 '' haivt
            ''
            'Duyệt các thành phần điểm
            For i As Integer = 0 To dsThanhPhan.Count - 1
                If dsThanhPhan.ThanhPhanDiem(i).Checked Then
                    idx = objDiem.dsDiemThanhPhan.Tim_idx(dsThanhPhan.ThanhPhanDiem(i).ID_thanh_phan, Lan_hoc)
                    If idx >= 0 Then
                        TongdiemTP += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Diem * objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                        TongPhanTramTP += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                        So_thanh_phan += 1
                        Tong_diem += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Diem * objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                        TOng_ty_le += objDiem.dsDiemThanhPhan.DiemThanhPhan(idx).Ty_le
                    Else
                        TongPhanTramTP += dsThanhPhan.ThanhPhanDiem(i).Ty_le
                        TOng_ty_le += dsThanhPhan.ThanhPhanDiem(i).Ty_le
                    End If
                End If
            Next
            If Lan_thi >= 1 Then
                DiemThi = objDiem.dsDiemThi.Diem_thi_lan(Lan_hoc, Lan_thi)
                Tong_diem += DiemThi * Thi_he_so
                TOng_ty_le += Thi_he_so
            Else
                DiemThi = objDiem.dsDiemThi.Diem_thi_max(Lan_hoc)
                Tong_diem += DiemThi * Thi_he_so
                TOng_ty_le += Thi_he_so
            End If
            Select Case Quy_che
                Case 25 'Đại học, cao đẳng Hệ Chính quy
                    If So_thanh_phan > 0 Then
                        'Tính điểm TBC các điểm bộ phận
                        'TBCBP = TongdiemTP / TongPhanTramTP
                        'Tính điểm TBC Học phần
                        TBCHP = (TongdiemTP * 40 / TongPhanTramTP + DiemThi * 60) / 100
                    Else
                        TBCHP = DiemThi
                    End If
                Case 36 'Đại học, cao đẳng Hệ VLVH
                    If So_thanh_phan > 0 Then
                        'Tính điểm TBC các điểm bộ phận
                        TBCBP = TongdiemTP / TongPhanTramTP
                        'Tính điểm TBC Học phần
                        TBCHP = (TBCBP * TBCBP_he_so + DiemThi * Thi_he_so) / (TBCBP_he_so + Thi_he_so)
                    Else
                        TBCHP = DiemThi
                    End If
                Case 40 'Trung cấp chuyên nghiệp Hệ Chính quy
                    If So_thanh_phan > 0 Then
                        'Tính điểm TBC các điểm bộ phận
                        TBCBP = TongdiemTP / TongPhanTramTP
                        'Tính điểm TBC Học phần
                        TBCHP = (TBCBP * TBCBP_he_so + DiemThi * Thi_he_so) / (TBCBP_he_so + Thi_he_so)
                    Else
                        TBCHP = DiemThi
                    End If
                Case 13 'Trung cấp chuyên nghiệp Hệ VLVH
                    If So_thanh_phan > 0 Then
                        'Tính điểm TBC các điểm bộ phận
                        TBCBP = TongdiemTP / TongPhanTramTP
                        'Tính điểm TBC Học phần
                        TBCHP = (TBCBP * TBCBP_he_so + DiemThi * Thi_he_so) / (TBCBP_he_so + Thi_he_so)
                    Else
                        TBCHP = DiemThi
                    End If
                Case 14 'Cao đẳng nghề hệ Chính quy
                    'Edit by anhnt at 7/3/2012
                    If So_thanh_phan > 0 Then
                        'Tính điểm TBC các điểm bộ phận
                        TBCBP = TongdiemTP
                        'Tính điểm TBC Học phần
                        TBCHP = (2 * TongdiemTP + 3 * DiemThi) / (2 * So_thanh_phan + 3)
                        TBCHP = Tong_diem / TOng_ty_le
                    Else
                        TBCHP = DiemThi
                    End If
                Case 22 'Trung cấp
                    If So_thanh_phan > 0 Then
                        TBCHP = (TongdiemTP * 40 / TongPhanTramTP + DiemThi * 60) / 100
                    Else
                        TBCHP = DiemThi
                    End If
            End Select
            'Làm tròn điểm TBCHP theo các quy chế
            TBCHP = Math.Round(TBCHP + 0.000001, TBCHP_lam_tron, MidpointRounding.AwayFromZero)
            Return TBCHP
        End Function
        Public Function DiemThanhPhan_lam_tron(ByVal Diem As Double) As Double
            Return Math.Round(Diem, ThanhPhan_lam_tron)
        End Function
        Public Function DiemThi_lam_tron(ByVal Diem As Double) As Double
            Return Math.Round(Diem, Thi_lam_tron)
        End Function
        Public Function DiemTBCHT_lam_tron(ByVal TBCHT As Double) As Double
            Return Math.Round(TBCHT + 0.00000001, TBCHT_lam_tron)
        End Function
        Public Function Xep_loai_hoc_tap(ByVal objXepLoai As XepLoaiHocTap, ByVal TBCHT As Double, Optional ByVal Phan_tram_thi_lai As Double = 0) As XepLoaiHocTap
            objXepLoai.ID_xep_loai = objXepLoai.IDXepLoaiHocTap(TBCHT)
            objXepLoai.Xep_loai = objXepLoai.XepLoaiHocTap(TBCHT)
            Select Case Quy_che
                Case 40 'Hạ bậc xếp loại
                    If Phan_tram_thi_lai > 20 Then
                        objXepLoai.ID_xep_loai = objXepLoai.IDXepLoaiHocTapHaBac(TBCHT)
                        objXepLoai.Xep_loai = objXepLoai.XeploaihoctapHaBac(TBCHT)
                        objXepLoai.Ghi_chu = "Hạ 1 bậc xếp loại do >20% số học phần lần 1 thi lại"
                    End If
            End Select
            Return objXepLoai
        End Function
        Public Function Load_QuyChe(ByVal ID_he As Integer) As String
            Try
                Dim obj As QuyCheDaoTao_DAL = New QuyCheDaoTao_DAL
                Dim dt As DataTable = obj.Load_QuyChe(ID_he)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Quy_che")
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function FormatSoThapPhan(ByVal Gia_tri As Double, ByVal Chu_so_lam_tron As Integer) As String
            If Chu_so_lam_tron > 0 Then
                Return Format(Gia_tri, "#0." + Left("000", Chu_so_lam_tron))
            Else
                Return Gia_tri
            End If
        End Function
        Public Function Load_ThamSoQuyChe(ByVal Quy_che As Integer, ByVal Ma_tham_so As String) As Object
            Try
                Dim obj As QuyCheDaoTao_DAL = New QuyCheDaoTao_DAL
                Dim dt As DataTable = obj.Load_ThamSoQuyChe(Quy_che, Ma_tham_so)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Gia_tri")
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ThamSoQuyChe(ByVal ID_tham_so_qc As Integer, ByVal Gia_tri As Double) As Integer
            Try
                Dim obj As QuyCheDaoTao_DAL = New QuyCheDaoTao_DAL
                Return obj.Update_ThamSoQuyChe(ID_tham_so_qc, Gia_tri)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '----------Xét lên lớp, thôi học, ngừng học-------------
        Public Sub LydoNgunghoc_FormatGrid(ByRef Lydo_Ngunghoc1 As String, ByRef Lydo_Ngunghoc2 As String, ByRef Lydo_Thoihoc1 As String, ByRef Lydo_Thoihoc2 As String)
            Select Case Quy_che
                Case 25, 36 'Đại học, cao đẳng Hệ Chính quy-Hệ VLVH
                    Lydo_Ngunghoc1 = "3.5<=TBCHT<5"
                    Lydo_Ngunghoc2 = "Số đvht điểm<5 vượt quá 25 đvht"
                    Lydo_Thoihoc1 = "TBCHT<3.5"
                    Lydo_Thoihoc2 = "TBCHT sau 2,3,>=4 năm"
                Case 13, 14, 40 'Trung cấp chuyên nghiệp Hệ Chính quy-Hệ VLVH-Sơ cấp
                    Lydo_Ngunghoc1 = "4<=TBCHT<5"
                    Lydo_Ngunghoc2 = "Số đvht điểm<5 vượt quá 20 đvht"
                    Lydo_Thoihoc1 = "TBCHT năm<4"
                    Lydo_Thoihoc2 = "TBCHT tích luỹ<4.5"
            End Select
        End Sub
        'Xét lên lớp
        Public Sub DieukienThoihoc_Ngunghoc_TheoNam(ByVal dt_KQHTnam As DataTable, ByVal Nam_hoc As String, ByRef Lydo_Ngunghoc As String, ByRef Lydo_Thoihoc1 As String, ByRef Lydo_Thoihoc2 As String)
            Select Case Quy_che
                Case 25, 36 'Đại học, cao đẳng Hệ Chính quy-Hệ VLVH
                    For i As Integer = 0 To dt_KQHTnam.Rows.Count - 1
                        If dt_KQHTnam.Rows(i).Item("Nam_hoc") <= Nam_hoc Then
                            '-	Nam hien tai TBCHT < 3.5 thi thoi hoc; 3.5<=TBCHT nam hien tai <5 thi ngung hoc
                            If Nam_hoc = dt_KQHTnam.Rows(i).Item("Nam_hoc") AndAlso dt_KQHTnam.Rows(i).Item("TBCHT_Nam").ToString.Trim <> "" Then
                                If dt_KQHTnam.Rows(i).Item("TBCHT_Nam") < 3.5 Then Lydo_Thoihoc1 = dt_KQHTnam.Rows(i).Item("TBCHT_Nam") & "<3.5"
                                If dt_KQHTnam.Rows(i).Item("TBCHT_Nam") >= 3.5 And dt_KQHTnam.Rows(i).Item("TBCHT_Nam") < 5 Then Lydo_Ngunghoc = "3.5<=" & dt_KQHTnam.Rows(i).Item("TBCHT_Nam").ToString & "<5"
                            End If
                            '- Sau 2,3,>=4 nam hoc
                            'Nam thu 2
                            If i = 1 And dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString.Trim <> "" Then
                                If CType(dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam"), Double) < 4 Then Lydo_Thoihoc2 = "Điểm tích luỹ đến năm thứ 2 có " & dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4"
                            End If
                            'Nam thu 3
                            If (i = 2 And dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString.Trim <> "") AndAlso CType(dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam"), Double) < 4.5 Then
                                If Lydo_Thoihoc2.Trim <> "" Then
                                    Lydo_Thoihoc2 += ", Điểm tích luỹ đến năm thứ 3 có " & dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.5"
                                Else
                                    Lydo_Thoihoc2 = "Điểm tích luỹ đến năm thứ 3 có " & dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.5"
                                End If
                            End If
                            'Tu nam thu 4
                            If (i > 2 And dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString.Trim <> "") AndAlso CType(dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam"), Double) < 4.8 Then
                                If Lydo_Thoihoc2.Trim <> "" Then
                                    Lydo_Thoihoc2 += ", Điểm tích luỹ >= năm thứ 4 có " & dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.8"
                                Else
                                    Lydo_Thoihoc2 = "Điểm tích luỹ >= năm thứ 4 có " & dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.8"
                                End If
                            End If
                        End If
                    Next
                Case 13, 14, 40 'Trung cấp chuyên nghiệp Hệ Chính quy-Hệ VLVH-Sơ cấp
                    '2. Check theo Nam hoc
                    For i As Integer = 0 To dt_KQHTnam.Rows.Count - 1
                        If dt_KQHTnam.Rows(i).Item("Nam_hoc") <= Nam_hoc Then
                            '-	Nam hien tai TBCHT < 4 thi thoi hoc; 4<=TBCHT nam hien tai <5 thi ngung hoc
                            If Nam_hoc = dt_KQHTnam.Rows(i).Item("Nam_hoc") AndAlso dt_KQHTnam.Rows(i).Item("TBCHT_Nam").ToString.Trim <> "" Then
                                If dt_KQHTnam.Rows(i).Item("TBCHT_Nam") < 4 Then Lydo_Thoihoc1 = dt_KQHTnam.Rows(i).Item("TBCHT_Nam") & "<4"
                                If dt_KQHTnam.Rows(i).Item("TBCHT_Nam") >= 4 And dt_KQHTnam.Rows(i).Item("TBCHT_Nam") < 5 Then Lydo_Ngunghoc = "4<=" & dt_KQHTnam.Rows(i).Item("TBCHT_Nam").ToString & "<5"
                            End If
                            '- Tu dau khoa hoc co TBCHT < 4.5 
                            If dt_KQHTnam.Rows(i).Item("Nam_hoc") = Nam_hoc AndAlso dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString.Trim <> "" Then
                                If CType(dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam"), Double) < 4.5 Then Lydo_Thoihoc2 = dt_KQHTnam.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.5"
                            End If
                        End If
                    Next
            End Select
        End Sub
        'Xét tốt nghiệp
        Function XuLy_Diem_TBCTK_TotNghiep(ByVal TBCKy As Double, ByVal Tong_Diem_CacMon As Double, ByVal Tong_DVHT_CacMon As Integer, ByVal Tong_Diem_Mon_Thuong As Double, ByVal Tong_DVHT_Mon_Thuong As Double, ByVal Tong_Diem_Mon_TN As Double, ByVal Tong_DVHT_MonTN As Double, ByVal So_Mon_duoi45_5 As Integer, ByRef LyDo_TBCHT_CacMonTN As String, Optional ByVal Tong_DVHT_MonLT_Nghe As Double = 0, Optional ByVal Tong_Diem_Mon_LT_Nghe As Double = 0, Optional ByVal Tong_DVHT_MonTH_Nghe As Double = 0, Optional ByVal Tong_Diem_Mon_TH_Nghe As Double = 0) As Double
            Dim DiemToanKhoa As Double = 0
            LyDo_TBCHT_CacMonTN = ""
            Select Case Quy_che
                Case 25, 36
                    If Tong_DVHT_CacMon > 0 Then DiemToanKhoa = Math.Round(Tong_Diem_CacMon / Tong_DVHT_CacMon, TBCHT_lam_tron)
                Case 40
                    If Tong_DVHT_MonTN > 0 And Tong_DVHT_Mon_Thuong > 0 Then
                        If (Tong_Diem_Mon_TN / Tong_DVHT_MonTN) < 5 Then LyDo_TBCHT_CacMonTN = "TBC thi tốt nghiệp " & Math.Round(Tong_Diem_Mon_TN / Tong_DVHT_MonTN, TBCHT_lam_tron) & "<5"
                        If So_Mon_duoi45_5 > 1 Then
                            If LyDo_TBCHT_CacMonTN.Trim <> "" Then
                                LyDo_TBCHT_CacMonTN = "Có hơn 1 môn thi tốt nghiệp 4.5<=điểm<5"
                            Else
                                LyDo_TBCHT_CacMonTN = ", Có hơn 1 môn thi tốt nghiệp 4.5<=điểm<5"
                            End If
                        End If
                        DiemToanKhoa = Math.Round((Tong_Diem_Mon_Thuong / Tong_DVHT_Mon_Thuong + Tong_Diem_Mon_TN / Tong_DVHT_MonTN) / 2, TBCHT_lam_tron)
                    End If
                Case 14
                    If Tong_DVHT_Mon_Thuong > 0 And Tong_DVHT_MonLT_Nghe > 0 And Tong_DVHT_MonTH_Nghe Then
                        Dim Diem_mon_thuong As Double = (Math.Round((Tong_Diem_Mon_Thuong / Tong_DVHT_Mon_Thuong) + 0.00000001, 1))
                        Dim Diem_mon_LTN As Double = Math.Round((Tong_Diem_Mon_LT_Nghe / Tong_DVHT_MonLT_Nghe) + 0.00000001, 1)
                        Dim Diem_mon_THN As Double = (Math.Round((Tong_Diem_Mon_TH_Nghe / Tong_DVHT_MonTH_Nghe) + 0.00000001, 1))
                        DiemToanKhoa = Math.Round(((3 * Diem_mon_thuong + Diem_mon_LTN + 2 * Diem_mon_THN) / 6) + 0.00000001, 1)
                        'DiemToanKhoa = Math.Round((3 * Tong_Diem_Mon_Thuong / Tong_DVHT_Mon_Thuong + 2 * Tong_Diem_Mon_TH_Nghe / Tong_DVHT_MonTH_Nghe + Tong_Diem_Mon_LT_Nghe / Tong_DVHT_MonLT_Nghe) / 6, TBCHT_lam_tron)
                    End If
                Case 13
                    DiemToanKhoa = Math.Round((TBCKy + Tong_Diem_Mon_TN / Tong_DVHT_MonTN) / 2, TBCHT_lam_tron)
            End Select
            Return DiemToanKhoa
        End Function
        Function Load_DanhSach_BangQC() As DataTable
            Try
                Dim cls As New QuyCheDaoTao_DAL
                Dim dt As DataTable
                dt = cls.Load_DanhSach_BangQC()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Property"
        Public Property Quy_che() As Integer
            Get
                Return mQuy_che
            End Get
            Set(ByVal Value As Integer)
                mQuy_che = Value
            End Set
        End Property
        Public Property Diem_chuyen_can() As Integer
            Get
                Return mDiem_chuyen_can
            End Get
            Set(ByVal Value As Integer)
                mDiem_chuyen_can = Value
            End Set
        End Property
        Public Property Diem_kiem_tra_dat() As Integer
            Get
                Return mDiem_kiem_tra_dat
            End Get
            Set(ByVal Value As Integer)
                mDiem_kiem_tra_dat = Value
            End Set
        End Property
        Public Property Khong_co_diem_khong() As Integer
            Get
                Return mKhong_co_diem_khong
            End Get
            Set(ByVal Value As Integer)
                mKhong_co_diem_khong = Value
            End Set
        End Property
        Public Property Du_diem_thanh_phan() As Integer
            Get
                Return mDu_diem_thanh_phan
            End Get
            Set(ByVal Value As Integer)
                mDu_diem_thanh_phan = Value
            End Set
        End Property
        Public Property Phan_tram_diem_thanh_phan_dat() As Integer
            Get
                Return mPhan_tram_diem_thanh_phan_dat
            End Get
            Set(ByVal Value As Integer)
                mPhan_tram_diem_thanh_phan_dat = Value
            End Set
        End Property
        Public Property PtramHoctrinhThilai_Hatotnghiep() As Integer
            Get
                Return mPtramHoctrinhThilai_Hatotnghiep
            End Get
            Set(ByVal Value As Integer)
                mPtramHoctrinhThilai_Hatotnghiep = Value
            End Set
        End Property
        Public Property Phan_tram_so_tiet_nghi() As Integer
            Get
                Return mPhan_tram_so_tiet_nghi
            End Get
            Set(ByVal Value As Integer)
                mPhan_tram_so_tiet_nghi = Value
            End Set
        End Property
        Public Property Phan_tram_so_tiet_nghi_TH() As Integer
            Get
                Return mPhan_tram_so_tiet_nghi_TH
            End Get
            Set(ByVal Value As Integer)
                mPhan_tram_so_tiet_nghi_TH = Value
            End Set
        End Property
        Public Property Diem_hoc_phan_dat() As Integer
            Get
                Return mDiem_hoc_phan_dat
            End Get
            Set(ByVal Value As Integer)
                mDiem_hoc_phan_dat = Value
            End Set
        End Property
        Public Property So_lan_thi_lai() As Integer
            Get
                Return mSo_lan_thi_lai
            End Get
            Set(ByVal Value As Integer)
                mSo_lan_thi_lai = Value
            End Set
        End Property
        Public Property ThanhPhan_lam_tron() As Integer
            Get
                Return mThanhPhan_lam_tron
            End Get
            Set(ByVal Value As Integer)
                mThanhPhan_lam_tron = Value
            End Set
        End Property
        Public Property Thi_lam_tron() As Integer
            Get
                Return mThi_lam_tron
            End Get
            Set(ByVal Value As Integer)
                mThi_lam_tron = Value
            End Set
        End Property
        Public Property TBCBP_he_so() As Integer
            Get
                Return mTBCBP_he_so
            End Get
            Set(ByVal Value As Integer)
                mTBCBP_he_so = Value
            End Set
        End Property
        Public Property Thi_he_so() As Integer
            Get
                Return mThi_he_so
            End Get
            Set(ByVal Value As Integer)
                mThi_he_so = Value
            End Set
        End Property
        Public Property TBCBP_lam_tron() As Integer
            Get
                Return mTBCBP_lam_tron
            End Get
            Set(ByVal Value As Integer)
                mTBCBP_lam_tron = Value
            End Set
        End Property
        Public Property TBCHP_lam_tron() As Integer
            Get
                Return mTBCHP_lam_tron
            End Get
            Set(ByVal Value As Integer)
                mTBCHP_lam_tron = Value
            End Set
        End Property
        Public Property TBCHT_lam_tron() As Integer
            Get
                Return mTBCHT_lam_tron
            End Get
            Set(ByVal Value As Integer)
                mTBCHT_lam_tron = Value
            End Set
        End Property

        Public Property TongSo_DVHT_coDiem_duoi5() As Integer
            Get
                Return mTongSo_DVHT_coDiem_duoi5
            End Get
            Set(ByVal Value As Integer)
                mTongSo_DVHT_coDiem_duoi5 = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
