Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Imports System.Drawing
Namespace Business
    Public Class Scheduling_BLL
#Region "Variable"
        Private _Tuan_no As Integer
        Private sks As Sukiens
        Private sk_gv As SukienKhacs
        Private sk_ph As SukienKhacs
        Private sk_lp As SukienKhacs
        Private lps As LopTKB_BLL
        Private gvs As GiaoVien_BLL
        Private phs As PhongHoc_BLL
        Private _update As Boolean
        Private _TKB_change As Boolean
#End Region

#Region "construct"
        Public Sub New()
            Doc_tham_so_he_thong()
        End Sub
        Public Sub New(ByVal Tuan_no As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                'Doc tham so he thong 
                Doc_tham_so_he_thong()

                Me._Tuan_no = Tuan_no
                lps = New LopTKB_BLL(Tuan_no)
                gvs = New GiaoVien_BLL()
                phs = New PhongHoc_BLL()

                Dim cls As New Scheduling_DLL
                Dim no As Integer = cls.SuKiens_Count(Me.Tuan_no)

                If no > 0 Then
                    _update = True
                    Read_from_sukien()
                Else
                    _update = False
                    Read_from_KHM()
                    UpdatePhongThucHanh(Hoc_ky, Nam_hoc)
                    Chia_tiet()
                End If
                Doc_sk_gv()
                Doc_sk_lop()
                Doc_sk_phong()

                'Phan_bo_phong_hoc_tu_dong()
                'Phan_cong_giao_vien_tu_dong()
                Khoa_sk_thieu_dulieu()

                Tinh_suc_tai_GV()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "DB"
        Public Sub SaveDB()
            Try
                If _update Then
                    UpdateDB()
                Else
                    InsertDB()
                End If
                Ghi_sukien_ngoaikhoa()
                'Ghi lai chu ky cua TKB lop, giao vien, phong hoc
                Save_class_sign()
                Save_teacher_sign()
                Save_room_sign()
                _TKB_change = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub InsertDB()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                For i As Integer = 0 To sks.Count - 1
                    obj.Insert_Sukiens(sks.Sukien(i))
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub UpdateDB()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                For i As Integer = 0 To sks.Count - 1
                    obj.Update_Sukiens(sks.Sukien(i), sks.Sukien(i).ID)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Read_from_KHM()
            Try
                Dim cls As New Scheduling_DLL
                Dim dt As DataTable
                dt = cls.SuKiensTinChi_Read_from_KHM(_Tuan_no)
                sks = New Sukiens
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If dt.Rows(i)("Ly_thuyet").ToString <> "" And dt.Rows(i)("Ly_thuyet").ToString <> "0" Then
                            Dim sk As New Su_kien
                            sk.ID_kh_tuan = _Tuan_no
                            sk.ID_cb = CInt(dt.Rows(i)("ID_cb").ToString)
                            sk.Hoten_giaovien = dt.Rows(i)("Ho_ten").ToString()
                            sk.Ten = dt.Rows(i)("Ten").ToString()

                            sk.ID_lop = CInt(dt.Rows(i)("ID_lop"))
                            sk.Ten_lop = dt.Rows(i)("Ten_lop").ToString()

                            If dt.Rows(i)("ID_phong").ToString <> "" Then sk.ID_phong = dt.Rows(i)("ID_phong")
                            sk.Ten_phong = dt.Rows(i)("So_phong").ToString()

                            sk.ID_mon = CInt(dt.Rows(i)("ID_mon"))
                            If dt.Rows(i)("ID_bm").ToString <> "" Then sk.ID_bm = CInt(dt.Rows(i)("ID_bm").ToString)
                            sk.Ten_mon = dt.Rows(i)("Ten_mon").ToString()
                            sk.Ky_hieu = dt.Rows(i)("Ky_hieu").ToString()

                            If dt.Rows(i)("Ly_thuyet").ToString <> "" Then sk.So_tiet = dt.Rows(i)("Ly_thuyet")
                            sk.Loai_tiet = 0  'Lý thuyết

                            If dt.Rows(i)("Ca_hoc").ToString <> "" Then sk.Ca_hoc = CType(dt.Rows(i)("Ca_hoc"), eCA_HOC)
                            sks.Add(sk)
                        End If
                        If CInt(dt.Rows(i)("Thuc_hanh").ToString) > 0 Then
                            For t As Integer = 1 To dt.Rows(i)("So_top")
                                Dim sk As New Su_kien
                                sk.ID_kh_tuan = _Tuan_no
                                sk.ID_cb = CInt(dt.Rows(i)("ID_cb").ToString)
                                sk.Ten = dt.Rows(i)("Ten").ToString()

                                sk.ID_lop = CInt(dt.Rows(i)("ID_lop"))
                                sk.Ten_lop = dt.Rows(i)("Ten_lop").ToString()

                                'sk.ID_phong = CInt(dt.Rows(i)("ID_phong").ToString)
                                'sk.Ten_phong = dt.Rows(i)("So_phong").ToString()

                                sk.ID_mon = CInt(dt.Rows(i)("ID_mon"))
                                sk.ID_bm = CInt(dt.Rows(i)("ID_bm").ToString)
                                sk.Ten_mon = dt.Rows(i)("Ten_mon").ToString()
                                sk.Ky_hieu = dt.Rows(i)("Ky_hieu").ToString()

                                sk.So_tiet = CInt(dt.Rows(i)("Thuc_hanh").ToString)
                                sk.Loai_tiet = 1  'Thực hành

                                sk.Ca_hoc = CType(dt.Rows(i)("Ca_hoc").ToString, eCA_HOC)
                                sk.Top_thu = t
                                sks.Add(sk)
                            Next
                        End If
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub FillData()
            Try
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).Thu <> eTHU.KHONG_XAC_DINH Then
                        Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(i).ID_cb)
                        Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(i).ID_phong)
                        Dim idx_lp As Integer = lps.Tim_chi_so(sks.Sukien(i).ID_lop)

                        If idx_gv <> -1 Then gvs.Giaovien(idx_gv).TKB(CInt(sks.Sukien(i).Thu), sks.Sukien(i).Tiet) = i
                        If idx_ph <> -1 Then phs.Phong_hoc(idx_ph).TKB(CInt(sks.Sukien(i).Thu), sks.Sukien(i).Tiet) = i
                        If idx_lp <> -1 Then lps.Lop(idx_lp).TKB(CInt(sks.Sukien(i).Thu), sks.Sukien(i).Tiet) = i
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Read_from_sukien()
            Try
                Dim cls As New Scheduling_DLL
                Dim dt As DataTable
                dt = cls.SuKiensTinChi_Read_from_sukien(_Tuan_no)
                sks = New Sukiens
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim row As DataRow = dt.Rows(i)
                    Dim sk As New Su_kien
                    sk.ID = CLng(row("ID"))
                    sk.ID_kh_tuan = _Tuan_no
                    sk.ID_lop = CInt(row("ID_lop"))
                    sk.ID_mon = CInt(row("ID_mon"))
                    sk.ID_phong = CInt(row("ID_phong"))
                    sk.ID_cb = row("ID_cb").ToString()
                    sk.So_tiet = CInt(row("So_tiet"))
                    sk.Ten = row("Ten").ToString()
                    sk.Hoten_giaovien = row("Ho_ten").ToString()
                    sk.Ten_lop = row("Ten_lop").ToString()
                    sk.Ky_hieu = row("Ky_hieu").ToString() & " (" & CInt(row("So_tiet")) & ")"
                    sk.Ten_mon = row("Ten_mon").ToString() & " (" & CInt(row("So_tiet")) & ")"
                    sk.Ten_phong = row("So_phong").ToString() + row("Ten_nha").ToString()
                    sk.Ca_hoc = CInt(row("Ca_hoc"))
                    sk.Thu = CInt(row("Thu"))
                    sk.Tiet = CInt(row("Tiet"))
                    sk.Loai_tiet = CInt("0" + row("Loai_tiet").ToString)
                    sk.Top_thu = row("Top_thu").ToString
                    sk.Da_xep_lich = row("Da_xep_lich")
                    sks.Add(sk)
                Next

                FillData()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub DeleteDB(ByVal Tuan As Integer)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                obj.Delete_Sukiens(Tuan)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Save_class_sign()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                obj.Delete_SkClassSign(Tuan_no)
                For i As Integer = 0 To lps.Count - 1
                    Dim hc As Integer = Hashcode_class(i)
                    If hc <> "".GetHashCode() Then
                        obj.Insert_SkClassSign(Tuan_no, lps.Lop(i).ID_lop, hc)
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Save_teacher_sign()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                obj.Delete_SkTeacherSign(Tuan_no)
                For i As Integer = 0 To gvs.Count - 1
                    Dim hc As Integer = Hashcode_teacher(i)
                    If hc <> "".GetHashCode() Then
                        obj.Insert_SkTeacherSign(Tuan_no, gvs.Giaovien(i).ID_cb, hc)
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Save_room_sign()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                obj.Delete_SkRoomSign(Tuan_no)
                For i As Integer = 0 To phs.Count - 1
                    Dim hc As Integer = Hashcode_room(i)
                    If hc <> "".GetHashCode() Then
                        obj.Insert_SkRoomSign(Tuan_no, phs.Phong_hoc(i).ID_phong, hc)
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub UpdatePhongThucHanh(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim clsPhongThucHanh As New PhanPhongThucHanh_BLL()
                Dim dt As DataTable = clsPhongThucHanh.Load_PhanPhongThucHanh(Hoc_ky, Nam_hoc)
                For i As Integer = 0 To dt.Rows.Count - 1
                    For j As Integer = 0 To sks.Count - 1
                        If sks.Sukien(j).Loai_tiet = Entity.eLOAI_TIET.THUC_HANH Then
                            If dt.Rows(i)("ID_lop") = sks.Sukien(j).ID_lop And _
                                dt.Rows(i)("ID_mon") = sks.Sukien(j).ID_mon And _
                                dt.Rows(i)("Top_thu") = sks.Sukien(j).Top_thu Then
                                sks.Sukien(j).ID_phong = dt.Rows(i)("ID_phong")
                                sks.Sukien(j).Ten_phong = dt.Rows(i)("Ten_phong")
                            End If
                        End If
                    Next
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Su kien ngoai khoa"
        Public Function LoadLichNgoaiKhoa(ByVal Loai_sk As eLOAI_SK, ByVal ID_kh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim dtKH As DataTable
            Dim r As Integer
            Dim obj As Scheduling_DLL = New Scheduling_DLL
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dt.Columns.Add("Thu", GetType(Integer))
            dt.Columns.Add("Ca", GetType(Integer))
            dt.Columns.Add("Tiet", GetType(Integer))
            'Add các tuần trong 1 học kỳ của năm
            For i As Integer = 0 To khTuan.Count - 1
                If Hoc_ky = 1 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu <= 26 Then
                        dt.Columns.Add("T." + khTuan.KeHoachTuan(i).ID_kh_tuan.ToString, GetType(String))
                    End If
                ElseIf Hoc_ky = 2 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu > 26 Then
                        dt.Columns.Add("T." + khTuan.KeHoachTuan(i).ID_kh_tuan.ToString, GetType(String))
                    End If
                End If
            Next
            'Add thu, tiet
            For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                For tiet As Integer = 0 To So_tiet_ngay - 1
                    Dim row As DataRow = dt.NewRow()
                    row("Thu") = thu + 2
                    row("Ca") = tiet
                    row("Tiet") = tiet + 1
                    dt.Rows.Add(row)
                Next
            Next
            'Load du lieu ngoai khoa vao dt
            Select Case Loai_sk
                Case eLOAI_SK.LK_LOP
                    dtKH = obj.SuKienKhacLopHocKy(ID_kh, ID)
                Case eLOAI_SK.LK_GV
                    dtKH = obj.SuKienKhacGiaoVienHocKy(ID_kh, ID)
                Case eLOAI_SK.LK_PHONG
                    dtKH = obj.SuKienKhacPhongHocKy(ID_kh, ID)
                Case Else
                    dtKH = obj.SuKienKhacTruongHocKy(ID_kh)
            End Select
            For i As Integer = 0 To dtKH.Rows.Count - 1
                r = So_tiet_ngay * dtKH.Rows(i)("Thu") + dtKH.Rows(i)("Tiet")
                If Hoc_ky = 1 Then
                    If dtKH.Rows(i)("Tuan_thu") <= 26 Then
                        dt.Rows(r)("T." + dtKH.Rows(i)("ID_kh_tuan").ToString) = dtKH.Rows(i)("Mo_ta").ToString + Chr(10)
                    End If
                ElseIf Hoc_ky = 2 Then
                    If dtKH.Rows(i)("Tuan_thu") > 26 Then
                        dt.Rows(r)("T." + dtKH.Rows(i)("ID_kh_tuan").ToString) = dtKH.Rows(i)("Mo_ta").ToString + Chr(10)
                    End If
                End If
            Next
            Return dt
        End Function
        Public Sub ThemLichNgoaiKhoaLop(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_lop)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacLop(skk)
                If ID > 0 Then
                    'Update
                    skk.ID = ID
                    obj.Update_SkKhacLop(skk)
                Else
                    'Insert
                    obj.Insert_SkKhacLop(skk)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub XoaLichNgoaiKhoaLop(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_lop)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacLop(skk)
                obj.Delete_SkKhacLop(ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub ThemLichNgoaiKhoaTruong(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_lop)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacTruong(skk)
                If ID > 0 Then
                    'Update
                    skk.ID = ID
                    obj.Update_SkKhacTruong(skk)
                Else
                    'Insert
                    obj.Insert_SkKhacTruong(skk)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub XoaLichNgoaiKhoaTruong(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_lop)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacTruong(skk)
                obj.Delete_SkKhacTruong(ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub ThemLichNgoaiKhoaGiaoVien(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_gv)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacGiaoVien(skk)
                If ID > 0 Then
                    'Update
                    skk.ID = ID
                    obj.Update_SkKhacGiaoVien(skk)
                Else
                    'Insert
                    obj.Insert_SkKhacGiaoVien(skk)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub XoaLichNgoaiKhoaGiaoVien(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_gv)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacGiaoVien(skk)
                obj.Delete_SkKhacGiaoVien(ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub ThemLichNgoaiKhoaPhong(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_phong)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacPhong(skk)
                If ID > 0 Then
                    'Update
                    skk.ID = ID
                    obj.Update_SkKhacPhong(skk)
                Else
                    'Insert
                    obj.Insert_SkKhacPhong(skk)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub XoaLichNgoaiKhoaPhong(ByVal ID_kh_tuan As Integer, ByVal skk As Sukien_phong)
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                Dim ID As Integer = 0
                skk.ID_kh_tuan = ID_kh_tuan
                ID = obj.Check_SkKhacPhong(skk)
                obj.Delete_SkKhacPhong(ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Doc_sk_lop()
            Dim dt As DataTable
            Try
                sk_lp = New SukienKhacs
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                dt = obj.SuKienKhacLop(_Tuan_no)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim stt As Integer = lps.Tim_chi_so(dt.Rows(i)("ID_lop"))
                    If stt >= 0 Then
                        Dim skk As New Sukien_lop
                        skk.ID = dt.Rows(i)("ID")
                        skk.ID_lop = dt.Rows(i)("ID_lop")
                        skk.Mo_ta = dt.Rows(i)("Mo_ta")
                        skk.So_tiet = dt.Rows(i)("So_tiet")
                        skk.Ten_lop = dt.Rows(i)("Ten_lop")
                        skk.Thu = dt.Rows(i)("Thu")
                        skk.Tiet = dt.Rows(i)("Tiet")
                        sk_lp.Add(skk)
                        lps.Lop(stt).TKB(skk.Thu, skk.Tiet) = sk_lp.Count - 1
                        lps.Lop(stt).Loai_sk(skk.Thu, skk.Tiet) = eLOAI_SK.LK_LOP
                    End If
                Next
                'Sự kiện nghỉ toàn trường
                dt = obj.SuKienKhacTruong(_Tuan_no)
                For i As Integer = 0 To dt.Rows.Count - 1
                    For l As Integer = 0 To lps.Count - 1
                        Dim skk As New Sukien_lop
                        skk.ID = dt.Rows(i)("ID")
                        skk.ID_lop = lps.Lop(l).ID_lop
                        skk.Ten_lop = lps.Lop(l).Ten_lop
                        skk.Mo_ta = dt.Rows(i)("Mo_ta")
                        skk.So_tiet = dt.Rows(i)("So_tiet")
                        skk.Thu = dt.Rows(i)("Thu")
                        skk.Tiet = dt.Rows(i)("Tiet")
                        sk_lp.Add(skk)
                        lps.Lop(l).TKB(skk.Thu, skk.Tiet) = sk_lp.Count - 1
                        lps.Lop(l).Loai_sk(skk.Thu, skk.Tiet) = eLOAI_SK.LK_LOP
                    Next
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Doc_sk_phong()
            Try
                sk_ph = New SukienKhacs
                Dim dt As DataTable
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                dt = obj.SuKienKhacPhong(_Tuan_no)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim stt As Integer = phs.Tim_chi_so(dt.Rows(i)("ID_phong"))
                    If stt >= 0 Then
                        Dim skk As New Sukien_phong
                        skk.ID = dt.Rows(i)("ID")
                        skk.ID_phong = dt.Rows(i)("ID_phong")
                        skk.Ten_phong = dt.Rows(i)("So_phong")
                        skk.Mo_ta = dt.Rows(i)("Mo_ta")
                        skk.So_tiet = dt.Rows(i)("So_tiet")
                        skk.Thu = dt.Rows(i)("Thu")
                        skk.Tiet = dt.Rows(i)("Tiet")
                        sk_ph.Add(skk)
                        phs.Phong_hoc(stt).TKB(skk.Thu, skk.Tiet) = sk_ph.Count - 1
                        phs.Phong_hoc(stt).Loai_sk(skk.Thu, skk.Tiet) = eLOAI_SK.LK_PHONG
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Doc_sk_gv()
            Try
                sk_gv = New SukienKhacs
                Dim dt As DataTable
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                dt = obj.SuKienKhacGiaoVien(_Tuan_no)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim stt As Integer = gvs.Tim_chi_so_theo_ID_cb(dt.Rows(i)("ID_cb"))
                    If stt >= 0 Then
                        Dim skk As New Sukien_gv
                        skk.ID = dt.Rows(i)("ID")
                        skk.ID_cb = dt.Rows(i)("ID_cb")
                        skk.Ten_gv = dt.Rows(i)("Ten")
                        skk.Mo_ta = dt.Rows(i)("Mo_ta")
                        skk.So_tiet = dt.Rows(i)("So_tiet")
                        skk.Thu = dt.Rows(i)("Thu")
                        skk.Tiet = dt.Rows(i)("Tiet")
                        sk_gv.Add(skk)

                        gvs.Giaovien(stt).TKB(skk.Thu, skk.Tiet) = sk_gv.Count - 1
                        gvs.Giaovien(stt).Loai_sk(skk.Thu, skk.Tiet) = eLOAI_SK.LK_GV
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Loai_sk_gv(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If gvs.Giaovien(stt).TKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_GV
        End Function
        Public Sub dat_sk_nk_gv(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal mo_ta As String)
            If gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                gvs.Giaovien(stt).TKB(thu, tiet) > -1 Then
                Return
            End If

            If gvs.Giaovien(stt).TKB(thu, tiet) >= 0 Then
                sk_gv.sk_gv(gvs.Giaovien(stt).TKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC
                    gvs.Giaovien(stt).TKB(thu, tiet) = -1
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New Sukien_gv
                    skk.ID_cb = gvs.Giaovien(stt).ID_cb
                    skk.Ten_gv = gvs.Giaovien(stt).Ten
                    skk.So_tiet = Nhom_tiet_donvi
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    ' Them no vao mang de quan ly
                    sk_gv.Add(skk)
                    gvs.Giaovien(stt).TKB(thu, tiet) = sk_gv.Count - 1
                    gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV
                End If
            End If
            _TKB_change = True
        End Sub
        Public Function Loai_sk_phong(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If phs.Phong_hoc(stt).TKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_PHONG
        End Function
        Public Sub dat_sk_nk_phong(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal mo_ta As String)
            If phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                phs.Phong_hoc(stt).TKB(thu, tiet) > -1 Then
                Return
            End If

            If phs.Phong_hoc(stt).TKB(thu, tiet) >= 0 Then
                sk_ph.sk_phong(phs.Phong_hoc(stt).TKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC
                    phs.Phong_hoc(stt).TKB(thu, tiet) = -1
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New Sukien_phong
                    skk.ID_phong = phs.Phong_hoc(stt).ID_phong
                    skk.Ten_phong = phs.Phong_hoc(stt).Ten_phong
                    skk.So_tiet = Nhom_tiet_donvi
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    ' Them no vao mang de quan ly
                    sk_ph.Add(skk)
                    phs.Phong_hoc(stt).TKB(thu, tiet) = sk_ph.Count - 1
                    phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG
                End If
            End If
            _TKB_change = True
        End Sub
        Public Function Loai_sk_lop(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If lps.Lop(stt).TKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If lps.Lop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_LOP
        End Function
        Public Sub dat_sk_nk_lop(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal mo_ta As String)
            If lps.Lop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                lps.Lop(stt).TKB(thu, tiet) > -1 Then
                Return
            End If

            If lps.Lop(stt).TKB(thu, tiet) >= 0 Then
                sk_lp.sk_lop(lps.Lop(stt).TKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    lps.Lop(stt).TKB(thu, tiet) = -1
                    lps.Lop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New Sukien_lop
                    skk.ID_lop = lps.Lop(stt).ID_lop
                    skk.Ten_lop = lps.Lop(stt).Ten_lop
                    skk.So_tiet = Nhom_tiet_donvi
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    ' Them no vao mang de quan ly
                    sk_lp.Add(skk)
                    lps.Lop(stt).TKB(thu, tiet) = sk_lp.Count - 1
                    lps.Lop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP
                End If
            End If
            _TKB_change = True
        End Sub
        Public Sub Ghi_sukien_ngoaikhoa()
            Try
                Dim obj As Scheduling_DLL = New Scheduling_DLL
                For i As Integer = 0 To sk_gv.Count - 1
                    Dim skk As Sukien_gv = sk_gv.sk_gv(i)
                    skk.ID_kh_tuan = Tuan_no
                    If skk.ID = -1 Then
                        If skk.Mo_ta.Trim() <> "" Then
                            obj.Insert_SkKhacGiaoVien(skk)
                        End If
                    Else ' delete or update
                        If skk.Mo_ta.Trim() = "" Then
                            ' del
                            obj.Delete_SkRoomSign(skk.ID)
                        Else
                            ' update
                            obj.Update_SkKhacGiaoVien(skk)
                        End If
                    End If
                Next
                ' phong hoc
                For i As Integer = 0 To sk_ph.Count - 1
                    Dim skk As Sukien_phong = sk_ph.sk_phong(i)
                    skk.ID_kh_tuan = Tuan_no
                    If skk.ID = -1 Then
                        If skk.Mo_ta.Trim() <> "" Then
                            obj.Insert_SkKhacPhong(skk)
                        End If
                    Else ' delete or update
                        If skk.Mo_ta.Trim() = "" Then
                            ' del
                            obj.Delete_SkKhacPhong(skk.ID)
                        Else
                            ' update
                            obj.Update_SkKhacPhong(skk)
                        End If
                    End If
                Next
                ' lop hoc
                For i As Integer = 0 To sk_lp.Count - 1
                    Dim skk As Sukien_lop = sk_lp.sk_lop(i)
                    skk.ID_kh_tuan = Tuan_no
                    If skk.ID = -1 Then
                        If skk.Mo_ta.Trim() <> "" Then
                            obj.Insert_SkKhacLop(skk)
                        End If
                    Else ' delete or update
                        If skk.Mo_ta.Trim() = "" Then
                            ' del
                            obj.Delete_SkKhacLop(skk.ID)
                        Else
                            ' update
                            obj.Update_SkKhacLop(skk)
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "fonction"
        Private Function Hashcode_class(ByVal idx_lop As Integer) As Integer
            Try
                Dim s As String = ""
                If sks.Count > 0 Then
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            Dim i As Integer = lps.Lop(idx_lop).TKB(thu, tiet)
                            If (i >= 0) And (i < sks.Count) Then
                                With sks.Sukien(i)
                                    If (.ID_lop = lps.Lop(idx_lop).ID_lop) And (.Thu <> eTHU.KHONG_XAC_DINH) Then
                                        s += .ID_mon.ToString() + "."
                                        s += .ID_phong.ToString() + "."
                                        s += .ID_cb.ToString() + "."
                                        s += CInt(.Thu).ToString() + "."
                                        s += CInt(.Tiet).ToString() + "."
                                        s += .So_tiet.ToString() + "."
                                        s += .Ca_hoc.ToString() + "."
                                    End If
                                End With
                                'Các sự kiện khác của lớp
                                If lps.Lop(idx_lop).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then
                                    Dim skk As Sukien_lop = sk_lp.sk_lop(lps.Lop(idx_lop).TKB(thu, tiet))
                                    s += skk.Mo_ta.ToString()
                                    s += skk.Thu.ToString()
                                    s += skk.Tiet.ToString()
                                End If
                            End If
                        Next
                    Next
                End If
                Return s.GetHashCode()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Hashcode_teacher(ByVal idx_gv As Integer) As Integer
            Try
                Dim s As String = ""
                If sks.Count > 0 Then
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            Dim i As Integer = gvs.Giaovien(idx_gv).TKB(thu, tiet)
                            If i >= 0 Then
                                With sks.Sukien(i)
                                    If (.ID_cb = gvs.Giaovien(idx_gv).ID_cb) And (.Thu <> eTHU.KHONG_XAC_DINH) Then
                                        s += .ID_mon.ToString() + "."
                                        s += .ID_phong.ToString() + "."
                                        s += .ID_lop.ToString() + "."
                                        s += CInt(.Thu).ToString() + "."
                                        s += CInt(.Tiet).ToString() + "."
                                        s += .So_tiet.ToString() + "."
                                        s += .Ca_hoc.ToString() + "."
                                    End If
                                End With
                            End If
                        Next
                    Next
                End If
                Return s.GetHashCode()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Hashcode_room(ByVal idx_phong As Integer) As Integer
            Try
                Dim s As String = ""
                If sks.Count > 0 Then
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            Dim i As Integer = phs.Phong_hoc(idx_phong).TKB(thu, tiet)
                            If i >= 0 Then
                                With sks.Sukien(i)
                                    If (.ID_phong = phs.Phong_hoc(idx_phong).ID_phong) And (.Thu <> eTHU.KHONG_XAC_DINH) Then
                                        s += CInt(.Thu).ToString() + "."
                                        s += CInt(.Tiet).ToString() + "."
                                        s += .So_tiet.ToString() + "."
                                        s += .Ca_hoc.ToString() + "."
                                    End If
                                End With
                            End If
                        Next
                    Next
                End If
                Return s.GetHashCode()
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Sub Khoa_sk_thieu_dulieu()
            ' Các sự kiện không đủ dữ liệu sẽ không được sử lý
            For i As Integer = 0 To sks.Count - 1
                'If sks.Sukien(i).ID_cb <= 0 Then sks.Sukien(i).Thieu_dulieu = True
                If sks.Sukien(i).ID_phong <= 0 Then sks.Sukien(i).Thieu_dulieu = True
            Next
        End Sub
        Private Sub Phan_bo_phong_hoc_tu_dong()
            Dim idx_ph As Integer
            ' Các sự kiện chưa có phòng học thì sẽ tìm cho phòng học thích hợp
            For idx_lop As Integer = 0 To lps.Count - 1
                For idx_sk As Integer = 0 To sks.Count - 1
                    If sks.Sukien(idx_sk).ID_phong <= 0 Then
                        If sks.Sukien(idx_sk).ID_lop = lps.Lop(idx_lop).ID_lop Then
                            'Tìm phòng thích hợp
                            idx_ph = Tim_phong(idx_sk)
                            'Nếu có phòng thì sẽ gán phòng cho sự kiện
                            If idx_ph >= 0 Then
                                For i As Integer = 0 To sks.Count - 1
                                    If sks.Sukien(i).ID_lop = lps.Lop(idx_lop).ID_lop And sks.Sukien(i).ID_phong <= 0 _
                                    And Count_phong(idx_ph, sks.Sukien(idx_sk).Ca_hoc) + 1 <= Tong_so_sk_tuan_ca Then
                                        sks.Sukien(i).ID_phong = phs.Phong_hoc(idx_ph).ID_phong
                                        sks.Sukien(i).Ten_phong = phs.Phong_hoc(idx_ph).Ten_phong
                                        If sks.Sukien(i).ID_cb > 0 Then sks.Sukien(idx_sk).Thieu_dulieu = False
                                    End If
                                Next
                            Else
                                sks.Sukien(idx_sk).Thieu_dulieu = True
                            End If
                        End If
                    End If
                Next
            Next
        End Sub

        Private Sub Phan_cong_giao_vien_tu_dong()
            ' Các sự kiện chưa có giáo viên thì sẽ tìm cho giáo viên thích hợp
            Dim idx_gv As Integer, ID_mon As Integer
            For idx_lop As Integer = 0 To lps.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).ID_cb <= 0 And lps.Lop(idx_lop).ID_lop = sks.Sukien(i).ID_lop Then
                        'Tìm giao vien thích hợp
                        idx_gv = Tim_giaovien(i)
                        If idx_gv >= 0 Then
                            ID_mon = sks.Sukien(i).ID_mon
                            For j As Integer = 0 To sks.Count - 1
                                If sks.Sukien(i).ID_cb <= 0 And _
                                lps.Lop(idx_lop).ID_lop = sks.Sukien(j).ID_lop Then
                                    'And sks.Sukien(j).ID_mon = ID_mon
                                    sks.Sukien(j).ID_cb = gvs.Giaovien(idx_gv).ID_cb
                                    sks.Sukien(j).Hoten_giaovien = gvs.Giaovien(idx_gv).Ho_ten
                                    sks.Sukien(j).Ten = gvs.Giaovien(idx_gv).Ten
                                    If sks.Sukien(j).ID_phong > 0 Then sks.Sukien(j).Thieu_dulieu = False
                                End If
                            Next
                        Else
                            sks.Sukien(i).Thieu_dulieu = True
                        End If
                    End If
                Next
            Next

        End Sub
        Private Function Sap_xep_GV(ByVal Ca_hoc As Integer) As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các giáo viên theo thứ tự giảm dần 
            ' về độ căng giảng dạy (hay còn gọi một tên khác là sức tải của giáo viên)
            Dim idx(gvs.Count - 1) As Integer
            For i As Integer = 0 To gvs.Count - 1
                idx(i) = i
            Next
            Return idx
            For i As Integer = 0 To gvs.Count - 2
                For j As Integer = i + 1 To gvs.Count - 1
                    If Count_giaovien(i, Ca_hoc) < Count_giaovien(j, Ca_hoc) Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function

        Private Function Tim_giaovien(ByVal idx_sk As Integer) As Integer
            'Sắp xếp giáo viên theo thứ tự tăng dần
            Dim idx() As Integer = Sap_xep_GV(sks.Sukien(idx_sk).Ca_hoc)
            Dim idx_gv As Integer
            For i As Integer = 0 To idx.Length - 1
                idx_gv = idx(i)
                If gvs.Giaovien(idx_gv).ID_bm = sks.Sukien(idx_sk).ID_bm Then
                    'Kiểm tra phòng đã xếp cho các sự kiện khác đã vượt quá số giờ mà phòng có thể đảm nhận 
                    If Count_giaovien(idx_gv, sks.Sukien(idx_sk).Ca_hoc) + 1 <= Tong_so_sk_tuan_ca / 2 Then
                        Return idx_gv
                    End If
                End If
            Next
            Return -1
        End Function

        Private Function Tim_phong(ByVal idx_sk As Integer) As Integer
            'Sắp xếp phòng học theo sức chứa từ nhỏ đến lớn
            Dim idx() As Integer = Sap_xep_phong_hoc()
            Dim idx_ph, idx_lop As Integer
            Dim So_sv As Integer
            idx_lop = lps.Tim_chi_so(sks.Sukien(idx_sk).ID_lop)
            So_sv = lps.Lop(idx_lop).So_sv
            For i As Integer = 0 To idx.Length - 1
                idx_ph = idx(i)
                'Sức chứa của phòng đủ chỗ cho số sinh viên tối đa
                If phs.Phong_hoc(idx_ph).Suc_chua >= So_sv Then
                    'Kiểm tra phòng đã xếp cho các sự kiện khác đã vượt quá số giờ mà phòng có thể đảm nhận 
                    If Count_phong(idx_ph, sks.Sukien(idx_sk).Ca_hoc) + 1 <= Tong_so_sk_tuan_ca Then
                        Return idx_ph
                    End If
                End If
            Next
            Return -1
        End Function

        Private Function Count_phong(ByVal idx_phong As Integer, ByVal Ca_hoc As Integer) As Integer
            Dim ID_phong As Integer = phs.Phong_hoc(idx_phong).ID_phong
            Dim Count As Integer = 0
            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).ID_phong = ID_phong And sks.Sukien(i).Ca_hoc = Ca_hoc Then
                    Count += 1
                End If
            Next
            Return Count
        End Function

        Private Function Count_giaovien(ByVal idx_gv As Integer, ByVal Ca_hoc As Integer) As Integer
            Dim ID_canbo As Integer = gvs.Giaovien(idx_gv).ID_cb
            Dim Count As Integer = 0
            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).ID_cb = ID_canbo And sks.Sukien(i).Ca_hoc = Ca_hoc Then
                    Count += 1
                End If
            Next
            Return Count
        End Function

        Private Function Sap_xep_phong_hoc() As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các phòng học theo thứ tự tăng dần 
            ' về sức chứa của phòng học 
            Dim idx(phs.Count - 1) As Integer

            For i As Integer = 0 To phs.Count - 1
                idx(i) = i
            Next

            For i As Integer = 0 To phs.Count - 2
                For j As Integer = i + 1 To phs.Count - 1
                    If phs.Phong_hoc(i).Suc_chua > phs.Phong_hoc(j).Suc_chua Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function
        Public Function Sched_lop_khoi(ByVal idx_lop As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            If lps.Lop(idx_lop).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then Return False
            Dim ID_lop_khoi As Integer
            ID_lop_khoi = lps.Lop(idx_lop).ID_lop_khoi

            For idx_sk As Integer = 0 To sks.Count - 1
                If sks.Sukien(idx_sk).Tiet = -1 Then
                    idx_lop = Tim_idx_lop(sks.Sukien(idx_sk).ID_lop)
                    If lps.Lop(idx_lop).ID_lop_khoi = ID_lop_khoi Then
                        If Able_to_Sched(idx_sk, thu, tiet) = -1 Then
                            Sched(idx_sk, thu, tiet)
                        End If
                    End If
                End If
            Next
            _TKB_change = True
            Return True
        End Function

        Private Function Sched_Day_Giaovien(ByVal idx_gv As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If gvs.Giaovien(idx_gv).TKB(thu, tiet) <> -1 Then Return False
            Return True
        End Function

        Private Function Sched_Day_Phong(ByVal idx_ph As Integer, ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If idx_sk <> -1 Then
                Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx_sk).ID_lop)
                If phs.Phong_hoc(idx_ph).TKB(thu, tiet) <> -1 Or phs.Phong_hoc(idx_ph).Suc_chua < lps.Lop(idx_lop).So_sv Then Return False
            End If
            Return True
        End Function

        Private Function Sched_Day_Lop(ByVal idx_lop As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If lps.Lop(idx_lop).TKB(thu, tiet) <> -1 Then Return False
            'Kiểm tra ràng buộc giữa khối và lớp
            Dim ID_lop_khoi As Integer = lps.Lop(idx_lop).ID_lop_khoi
            If ID_lop_khoi = 0 Then
                'Kiểm tra khối có trùng với các lớp thuộc khối không?
                For i As Integer = 0 To lps.Count - 1
                    If lps.Lop(i).ID_lop_khoi = lps.Lop(idx_lop).ID_lop Then
                        If lps.Lop(i).TKB(thu, tiet) <> -1 Then Return False
                    End If
                Next
            Else
                'Kiểm tra các lớp có trùng với khối không?
                For i As Integer = 0 To lps.Count - 1
                    If ID_lop_khoi = lps.Lop(i).ID_lop Then
                        If lps.Lop(i).TKB(thu, tiet) <> -1 Then Return False
                    End If
                Next
            End If
            Return True
        End Function

        Private Function Tim_phong(ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Integer
            ' cac phong cho tiet le trung toa nha
            'Sắp xếp phòng học theo sức chứa từ nhỏ đến lớn
            Dim idx() As Integer = Sap_xep_phong_hoc()
            Dim idx_ph As Integer
            For i As Integer = 0 To idx.Length - 1
                idx_ph = idx(i)
                If (Sched_Day_Phong(idx_ph, idx_sk, thu, tiet)) Then
                    Return idx_ph
                End If
            Next
            Return -1
        End Function

        Private Function Tim_giao_vien(ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Integer
            'Sắp xếp giáo viên theo mức độ căng của giáo viên
            Dim idx() As Integer = Sap_xep_GV()
            Dim idx_gv As Integer
            For i As Integer = 0 To idx.Length - 1
                idx_gv = idx(i)
                If (Sched_Day_Giaovien(idx_gv, thu, tiet)) And gvs.Giaovien(idx_gv).ID_bm = sks.Sukien(idx_sk).ID_bm Then
                    Return idx_gv
                End If
            Next
            Return -1
        End Function

        Private Function Thongtin_gv(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            ' Tất cả các hàm đều sử dụng hàm này để lấy thông tin về giáo viên 
            ' bao gồm: Tên lớp ký hiệu tên phòng giảng.......
            If gvs.Giaovien(idx).TKB(thu, tiet) = -1 Then Return ""
            If gvs.Giaovien(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then
                Dim skk As Sukien_gv = sk_gv.sk_gv(gvs.Giaovien(idx).TKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As Su_kien = CType(sks.Sukien(gvs.Giaovien(idx).TKB(thu, tiet)), Su_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ten_lop + vbCrLf + sk.Ky_hieu + vbCrLf + sk.Ten_phong & Chr(0)
                Else
                    Return sk.Ten_lop + vbCrLf + sk.Ky_hieu + vbCrLf + sk.Ten_phong
                End If
            End If
        End Function
        Private Function Thongtin_phong(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            If phs.Phong_hoc(idx).TKB(thu, tiet) = -1 Then Return ""
            If phs.Phong_hoc(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then
                Dim skk As Sukien_phong = sk_ph.sk_phong(phs.Phong_hoc(idx).TKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As Su_kien = CType(sks.Sukien(phs.Phong_hoc(idx).TKB(thu, tiet)), Su_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ten_lop + vbCrLf + sk.Ky_hieu + vbCrLf + sk.Ten & Chr(0)
                Else
                    Return sk.Ten_lop + vbCrLf + sk.Ky_hieu + vbCrLf + sk.Ten
                End If
            End If
        End Function
        Private Function Thongtin_lop(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            If lps.Lop(idx).TKB(thu, tiet) = -1 Then Return ""
            If lps.Lop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then
                Dim skk As Sukien_lop = sk_lp.sk_lop(lps.Lop(idx).TKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As Su_kien = CType(sks.Sukien(lps.Lop(idx).TKB(thu, tiet)), Su_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ky_hieu + vbCrLf + sk.Ten + vbCrLf + sk.Ten_phong & Chr(0)
                Else
                    Return sk.Ky_hieu + vbCrLf + sk.Ten + vbCrLf + sk.Ten_phong
                End If
            End If
        End Function
        Private Function Thongtin_lop_chitiet(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            If lps.Lop(idx).TKB(thu, tiet) = -1 Then Return ""
            If lps.Lop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then
                Dim skk As Sukien_lop = sk_lp.sk_lop(lps.Lop(idx).TKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As Su_kien = CType(sks.Sukien(lps.Lop(idx).TKB(thu, tiet)), Su_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ten_mon + vbCrLf + sk.Hoten_giaovien
                Else
                    Return sk.Ten_mon + vbCrLf + sk.Hoten_giaovien
                End If
            End If
        End Function
        Private Function CalCol(ByVal thu As Integer, ByVal tiet As Integer, ByVal offset As Integer) As Integer
            ' Sẽ làm nhiệm vụ tính cột thứ bao 
            ' nhiêu đối với việc sinh TKB tổng hợp
            Return thu * So_tiet_ngay + tiet + offset
        End Function
        Private Sub Chia_tiet()
            ' Chia nhóm tiết 
            ' Ban đầu các sự kiện có số nhóm tiết là số tiết / tuần
            ' sau đó chúng ta sẽ chia ra các SK có số tiết = nhóm tiết đơn vị
            ' Còn thừa lại ta không sử lý
            Dim i As Integer = 0
            Do While i <= sks.Count - 1
                If sks.Sukien(i).So_tiet > Nhom_tiet_donvi Then
                    Dim skn As Su_kien = sks.Sukien(i).Clone()
                    If sks.Sukien(i).So_tiet = 4 Then
                        sks.Sukien(i).So_tiet = 2
                        skn.So_tiet -= 2
                    Else
                        sks.Sukien(i).So_tiet = Nhom_tiet_donvi
                        skn.So_tiet -= Nhom_tiet_donvi
                    End If
                    sks.Add(skn)
                End If
                i += 1
            Loop
        End Sub
        Public Function Able_to_Sched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            ' Tính toán xem có thể xếp lịch vào thời điểm này không
            ' giá trị trả về là có hoặc không
            ' = -2 không thể xếp lịch vì trái ca
            ' = -3 Đã xếp lịch ngoại khoá
            ' = -4 Dạy khác cơ sở đào tạo
            ' > 0 đã xếp lịch tại ô này
            ' = -1 chưa xếp lịch
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then
                If tiet >= So_tiet_ca Then Return -2
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then
                If Not (tiet >= So_tiet_ca And tiet < So_tiet_ca * 2) Then Return -2
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then
                If tiet < So_tiet_ca * 2 Then Return -2
            End If
            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
            'Đã xếp lịch ngoại khoá của lớpkk
            If idx_lop <> -1 Then
                If lps.Lop(idx_lop).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then Return -3
                'Kiểm tra ràng buộc giữa khối và lớpkk
                If lps.Lop(idx_lop).Khoi = True Then
                    For i As Integer = 0 To lps.Count - 1
                        If lps.Lop(i).ID_lop_khoi = lps.Lop(idx_lop).ID_lop Then
                            If lps.Lop(i).TKB(thu, tiet) <> -1 Then
                                Return lps.Lop(i).TKB(thu, tiet)
                            End If
                        End If
                    Next
                End If
                If lps.Lop(idx_lop).TKB(thu, tiet) <> -1 Then Return lps.Lop(idx_lop).TKB(thu, tiet)
                'Dim idx_lop1 = Tim_idx_lop(sks.Sukien(idx).ID_lop)
                'Dim ID_lop_khoi As Integer = lps.Lop(idx_lop1).ID_lop_khoi
                'If ID_lop_khoi = 0 Then
                '    'Kiểm tra khối có trùng với các lớp thuộc khối không?
                '    For i As Integer = 0 To lps.Count - 1
                '        If lps.Lop(i).ID_lop_khoi = sks.Sukien(idx).ID_lop Then
                '            If lps.Lop(i).TKB(thu, tiet) <> -1 Then Return lps.Lop(i).TKB(thu, tiet)
                '        End If
                '    Next
                'Else
                '    'Kiểm tra các lớp có trùng với khối không?
                '    For i As Integer = 0 To lps.Count - 1
                '        If ID_lop_khoi = lps.Lop(i).ID_lop Then
                '            If lps.Lop(i).TKB(thu, tiet) <> -1 Then Return lps.Lop(i).TKB(thu, tiet)
                '        End If
                '    Next
                'End If
            End If
            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            'Đã xếp lịch ngoại khoá của giáo viên
            If idx_gv <> -1 Then
                If gvs.Giaovien(idx_gv).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then Return -3
                If gvs.Giaovien(idx_gv).TKB(thu, tiet) <> -1 Then Return gvs.Giaovien(idx_gv).TKB(thu, tiet)
            End If
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            'Đã xếp lịch ngoại khoá của phòng học
            If idx_ph <> -1 Then
                If phs.Phong_hoc(idx_ph).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then Return -3
                If phs.Phong_hoc(idx_ph).TKB(thu, tiet) <> -1 Then Return phs.Phong_hoc(idx_ph).TKB(thu, tiet)
            End If
            Return (-1)
        End Function
        Public Sub UnSched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer)
            ' Huỷ lịch của 1 sự kiện phải huỷ theo 3 chiều
            ' lớp, giáo viên, phòng.
            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
            If idx_lop >= 0 Then lps.Lop(idx_lop).TKB(thu, tiet) = -1

            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            If idx_gv >= 0 Then gvs.Giaovien(idx_gv).TKB(thu, tiet) = -1

            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            If idx_ph >= 0 Then phs.Phong_hoc(idx_ph).TKB(thu, tiet) = -1

            sks.Sukien(idx).Thu = -1
            sks.Sukien(idx).Tiet = -1
            sks.Sukien(idx).Da_xep_lich = False
            _TKB_change = True
        End Sub
        Public Function UnSched_gv(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            ' Huỷ theo từng chiều ở đây là giáo viên
            ' idx là số thứ tự của giáo viên
            If gvs.Giaovien(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then Return False
            Dim idx_sk As Integer = gvs.Giaovien(idx).TKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function
        Public Function UnSched_phong(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            If phs.Phong_hoc(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then Return False
            Dim idx_sk As Integer = phs.Phong_hoc(idx).TKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function
        Public Function UnSched_lop(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            If lps.Lop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then Return False
            Dim idx_sk As Integer = lps.Lop(idx).TKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function
        Public Sub Sched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer)
            ' Xếp lịhc cho một sự kiện có số thứ tự là idx
            If sks.Sukien(idx).Thieu_dulieu Then Return

            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
            If idx_lop >= 0 Then
                If lps.Lop(idx_lop).TKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá lớp")
                Else
                    lps.Lop(idx_lop).TKB(thu, tiet) = idx
                    'Nếu là khối thì tìm đến các lớp thuộc khối này
                    If lps.Lop(idx_lop).Khoi Then
                        For i As Integer = 0 To lps.Count - 1
                            If lps.Lop(i).ID_lop_khoi = lps.Lop(idx_lop).ID_lop Then
                                lps.Lop(i).TKB(thu, tiet) = idx
                                For j As Integer = 0 To lps.Count - 1
                                    If lps.Lop(i).ID_lop = lps.Lop(j).ID_lop Then
                                        lps.Lop(j).TKB(thu, tiet) = idx
                                    End If
                                Next
                            End If
                        Next
                    End If
                End If
            End If

            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            If idx_gv >= 0 Then
                If gvs.Giaovien(idx_gv).TKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá giáo viên")
                Else
                    gvs.Giaovien(idx_gv).TKB(thu, tiet) = idx
                End If
            End If

            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            If idx_ph >= 0 Then
                If phs.Phong_hoc(idx_ph).TKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá phòng học")
                Else
                    phs.Phong_hoc(idx_ph).TKB(thu, tiet) = idx
                End If
            End If
            sks.Sukien(idx).Thu = thu
            sks.Sukien(idx).Tiet = tiet
            sks.Sukien(idx).Da_xep_lich = True
            _TKB_change = True
        End Sub

        Private Function Auto_Sched(ByVal idx As Integer) As Boolean
            ' Tự động tìm ô trống cho 1 sự kiện 
            ' và xếp 1 sự kiện này. idx là số thứ tự sự kiện
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' chieu
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    If Able_to_Sched(idx, thu, tiet) = -1 Then
                        Sched(idx, thu, tiet)
                        Return True
                    End If
                Next
            Next
            Return False
        End Function

        Private Function Auto_Sched0(ByVal idx As Integer) As Boolean
            ' Nếu cả giáo viên và lớp cùng rỗi tại thời điểm này
            ' thì chúng ta sẽ xếp lịch cho nó. còn không thì
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' toi
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
                    If Able_to_Sched(idx, thu, tiet) = -1 _
                        And Accept_mon_thu(idx, idx_lop, thu, tiet) _
                        And Accept_mon_tiet(idx, idx_lop, thu, tiet) Then
                        Sched(idx, thu, tiet)
                        Return True
                    End If
                Next
            Next
            Return False
        End Function

        Private Function Auto_Sched1(ByVal idx As Integer) As Boolean
            'Tìm giáo viên và phòng học thích hợp để xếp cho sự kiện này
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' toi
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            Dim idx_phong, idx_gv As Integer
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
                    If Sched_Day_Lop(idx_lop, thu, tiet) Then
                        'Tìm phòng khác rỗi tại thời điểm này để gán cho sự kiện
                        If sks.Sukien(idx).ID_phong > 0 Then
                            idx_phong = Tim_idx_phong(sks.Sukien(idx).ID_phong)
                            If Not Sched_Day_Phong(idx_phong, idx, thu, tiet) Then
                                idx_phong = Tim_phong(idx, thu, tiet)
                            End If
                        Else
                            idx_phong = Tim_phong(idx, thu, tiet)
                        End If
                        'Tìm giáo viên khác rỗi tại thời điểm này để gán cho sự kiện
                        If sks.Sukien(idx).ID_cb > 0 Then
                            idx_gv = Tim_idx_gv(sks.Sukien(idx).ID_cb)
                            If Not Sched_Day_Giaovien(idx_gv, thu, tiet) Then
                                idx_gv = Tim_giao_vien(idx, thu, tiet)
                            End If
                        Else
                            idx_gv = Tim_giao_vien(idx, thu, tiet)
                        End If
                        If idx_phong <> -1 And idx_gv <> -1 Then
                            sks.Sukien(idx).ID_phong = phs.Phong_hoc(idx_phong).ID_phong
                            sks.Sukien(idx).ID_cb = gvs.Giaovien(idx_gv).ID_cb
                            Sched(idx, thu, tiet)
                            Return True
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Public Sub Algo()
            'Phân bổ phòng học tự động
            'Phan_bo_phong_hoc_tu_dong()
            'Phân bổ giáo viên tự động
            'Phan_cong_giao_vien_tu_dong()
            'Thuật toán xếp lịch
            'Thực hiện xếp các khối trước
            For j As Integer = 0 To lps.Count - 1
                If lps.Lop(j).ID_lop_khoi = 0 Then
                    For i As Integer = 0 To sks.Count - 1
                        With sks.Sukien(i)
                            If Not .Thieu_dulieu Then
                                If .ID_lop = lps.Lop(j).ID_lop Then
                                    If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                        (.So_tiet > 1) Then
                                        Auto_Sched0(i)
                                    End If
                                End If
                            End If
                        End With
                    Next
                End If
            Next
            'Thực hiện xếp các lớp sau
            For j As Integer = 0 To lps.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    With sks.Sukien(i)
                        If Not .Thieu_dulieu Then
                            If .ID_lop = lps.Lop(j).ID_lop Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched0(i)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            'Sắp xếp thứ tự ưu tiên giáo viên cần xếp lịch trước
            Dim idx() As Integer = Sap_xep_GV()
            '======================================================
            'Thực hiện xếp lịch cho từng giáo viên
            'idx sẽ chứa số thứ tự của giáo viên từ giáo viên 
            'Khó xếp nhất đến gv dễ xếp lịch nhất
            '======================================================
            'Thực hiện xếp giãn cách các môn học, tránh các môn liền tiết, liền thứ
            For j As Integer = 0 To gvs.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    With sks.Sukien(i)
                        If Not .Thieu_dulieu Then
                            If .ID_cb = gvs.Giaovien(idx(j)).ID_cb Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched0(i)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            'Tiếp tục xếp tiếp các sự kiện còn lại vẫn theo thiều ưu tiên của giáo viên
            For j As Integer = 0 To gvs.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    With sks.Sukien(i)
                        If Not .Thieu_dulieu Then
                            If .ID_cb = gvs.Giaovien(idx(j)).ID_cb Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched(i)
                                End If
                            End If
                        End If
                    End With
                Next
            Next

            '======================================================
            'Tất cả những sự kiện không xếp được lịch sẽ sử dụng tiếp thuật toán khác
            'Thuật toán 2: Tìm và đổi chỗ cho nhau
            '======================================================
            Algo2()
        End Sub

        Private Function Sap_xep_GV() As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các giáo viên theo thứ tự giảm dần 
            ' về độ căng giảng dạy (hay còn gọi một tên khác là sức tải của giáo viên)
            Dim idx(gvs.Count - 1) As Integer
            For i As Integer = 0 To gvs.Count - 1
                idx(i) = i
            Next
            For i As Integer = 0 To gvs.Count - 2
                For j As Integer = i + 1 To gvs.Count - 1
                    If gvs.Giaovien(idx(i)).Max_tiet > gvs.Giaovien(idx(j)).Max_tiet Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function

        Private Sub Tinh_suc_tai_GV()
            For j As Integer = 0 To sks.Count - 1
                Dim sk As Su_kien = sks.Sukien(j)
                Dim idx As Integer = gvs.Tim_chi_so_theo_ID_cb(sk.ID_cb)
                If idx <> -1 Then
                    If sk.Ca_hoc = eCA_HOC.SANG Then
                        gvs.Giaovien(idx).Tiet_Sang += 1
                    End If
                    If sk.Ca_hoc = eCA_HOC.CHIEU Then
                        gvs.Giaovien(idx).Tiet_Chieu += 1
                    End If
                End If
            Next
        End Sub

        Private Function blowup(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As ArrayList
            'Huỷ tất cả các sự kiện liên quan đến sự kiện idx như cùng giáo viên, cùng lớp, cùng phòng học
            Dim a As New ArrayList
            'Duyệt 4 lần để kiểm tra: Trái ca, Lớp học, Giáo viên, Phòng học
            For i As Integer = 0 To 3
                Dim id As Integer = Able_to_Sched(idx, thu, tiet)
                If id = -2 Or id = -3 Then Return Nothing
                If id > 0 Then
                    UnSched(id, thu, tiet)
                    a.Add(id)
                End If
            Next
            Return a
        End Function

        Private Sub setback(ByVal a As ArrayList, ByVal thu As Integer, ByVal tiet As Integer)
            For i As Integer = 0 To a.Count - 1
                Dim idx As Integer = CInt(a(i))
                If sks.Sukien(idx).Da_xep_lich Then
                    UnSched(idx, sks.Sukien(idx).Thu, sks.Sukien(idx).Tiet)
                End If
            Next
            For i As Integer = 0 To a.Count - 1
                Sched(CInt(a(i)), thu, tiet)
            Next
        End Sub

        Private Function fillok(ByVal a As ArrayList) As Boolean
            For i As Integer = 0 To a.Count - 1
                If Not Auto_Sched(CInt(a(i))) Then Return False
            Next
            Return True
        End Function

        Private Function find_xchange(ByVal idx As Integer) As Boolean
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' toi
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            Dim thu, tiet As Integer
            For thu = Thu_bat_dau To Thu_ket_thuc
                For tiet = min To max
                    'Tim tat ca nhung su kien lien quan den su kien nay nhu giao vien, phong hoc, lop de huy di
                    Dim a As ArrayList = blowup(idx, thu, tiet)
                    If Not a Is Nothing Then
                        If a.Count > 0 Then
                            Sched(idx, thu, tiet)
                            'Tim xep cho nhung su kien bi ro ra xep vao cho khac
                            If fillok(a) Then
                                Return True 'Neu thanh cong thi se giai quyet dc tat ca cac su kien
                            Else
                                'Neu khong thi se khoi phuc lai ket qua truoc do
                                UnSched(idx, thu, tiet)
                                setback(a, thu, tiet)
                            End If
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Public Sub Algo2()
            ' Tìm kiếm các sự kiện lân cận đổi chỗ cho nhau
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If Not .Thieu_dulieu Then
                        If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                            (.So_tiet = Nhom_tiet_donvi) Then
                            find_xchange(i)
                        End If
                    End If
                End With
            Next
        End Sub

        Public Sub Algo3()
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                        (.So_tiet > 1) Then
                        Auto_Sched1(i)
                    End If
                End With
            Next
        End Sub

        Public Sub Huy_lich()
            ' Huỷ tất cả các lịch
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If .Thu <> eTHU.KHONG_XAC_DINH _
                        And .Tiet <> -1 Then
                        UnSched(i, .Thu, .Tiet)
                    End If
                End With
            Next
        End Sub

        Public Sub Set_sukien(ByVal idx_sk As Integer, ByVal idx_gv As Integer, ByVal Ten_gv As String, ByVal idx_phong As Integer, ByVal Ten_phong As String, ByVal Ca_hoc As eCA_HOC)
            sks.Sukien(idx_sk).ID_cb = idx_gv
            sks.Sukien(idx_sk).Ten = Ten_gv
            sks.Sukien(idx_sk).ID_phong = idx_phong
            sks.Sukien(idx_sk).Ten_phong = Ten_phong
            sks.Sukien(idx_sk).Ca_hoc = Ca_hoc
        End Sub
        Public Function Move_gv(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = gvs.Giaovien(idx).TKB(thu1, tiet1)
            Dim idx2 As Integer = gvs.Giaovien(idx).TKB(thu2, tiet2)

            Dim sk1 As Su_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As Su_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function
        Public Function Move_lp(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = lps.Lop(idx).TKB(thu1, tiet1)
            Dim idx2 As Integer = lps.Lop(idx).TKB(thu2, tiet2)

            Dim sk1 As Su_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As Su_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function
        Public Function Move_ph(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = phs.Phong_hoc(idx).TKB(thu1, tiet1)
            Dim idx2 As Integer = phs.Phong_hoc(idx).TKB(thu2, tiet2)

            Dim sk1 As Su_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As Su_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function
        Public Function List_free_cell(ByVal idx As Integer) As ArrayList
            Dim mask As New ArrayList

            For tiet As Integer = 0 To So_tiet_ngay - 1
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    If Able_to_Sched(idx, thu, tiet) = -1 Then
                        mask.Add(New Point(thu, tiet))
                    End If
                Next
            Next

            Return mask
        End Function
        Private Function Trung(ByVal idx As Integer) As Boolean
            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            Dim idx_lp As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop)
            For thu As Integer = 0 To Ngay_tuan - 1
                For tiet As Integer = 0 To So_tiet_ngay - 1
                    If thu <> sks.Sukien(idx).Thu And tiet <> sks.Sukien(idx).Tiet Then
                        If idx = gvs.Giaovien(idx_gv).TKB(thu, tiet) Then Return True
                        If idx = phs.Phong_hoc(idx_ph).TKB(thu, tiet) Then Return True
                        If idx = lps.Lop(idx_lp).TKB(thu, tiet) Then Return True
                    End If
                Next
            Next
            Return False
        End Function
        Public Function Cac_sukien_trung() As String
            Dim s As String = ""
            For i As Integer = 0 To sks.Count - 1
                If Trung(i) Then s = s + i.ToString() + "."
            Next
            Return s
        End Function
        Public Function Tim_idx_gv(ByVal ID_cb As Integer)
            Return gvs.Tim_chi_so_theo_ID_cb(ID_cb)
        End Function
        Public Function Tim_idx_lop(ByVal ID_lop As Integer)
            Return lps.Tim_chi_so(ID_lop)
        End Function
        Public Function Tim_idx_phong(ByVal ID_phong As Integer)
            Return phs.Tim_chi_so(ID_phong)
        End Function

        Private Function Accept_mon_tiet(ByVal idx_sk As Integer, ByVal idx_lop As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            Dim tiet1 As Integer
            Select Case tiet
                Case 0
                    tiet1 = 1
                Case 1
                    tiet1 = 0
            End Select
            If lps.Lop(idx_lop).TKB(thu, tiet1) <> -1 And lps.Lop(idx_lop).Loai_sk(thu, tiet1) = eLOAI_SK.LICH_HOC Then
                Dim idx As Integer = lps.Lop(idx_lop).TKB(thu, tiet1)
                If idx > -1 Then If sks.Sukien(idx_sk).ID_mon = sks.Sukien(idx).ID_mon Then Return False
            End If
            Return True
        End Function

        Private Function Accept_mon_thu(ByVal idx_sk As Integer, ByVal idx_lop As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            Dim thu1 As Integer
            Select Case thu
                Case eTHU.THU_BA
                    thu1 = eTHU.THU_HAI
                Case eTHU.THU_TU
                    thu1 = eTHU.THU_BA
                Case eTHU.THU_NAM
                    thu1 = eTHU.THU_TU
                Case eTHU.THU_SAU
                    thu1 = eTHU.THU_NAM
                Case eTHU.THU_BAY
                    thu1 = eTHU.THU_SAU
            End Select
            If lps.Lop(idx_lop).TKB(thu1, tiet) <> -1 And lps.Lop(idx_lop).Loai_sk(thu1, tiet) = eLOAI_SK.LICH_HOC Then
                Dim idx As Integer = lps.Lop(idx_lop).TKB(thu1, tiet)
                If idx > -1 Then If sks.Sukien(idx_sk).ID_mon = sks.Sukien(idx).ID_mon Then Return False
            End If
            Return True
        End Function
#End Region

#Region "Property"
        Public Property Tuan_no() As Integer
            Get
                Return Me._Tuan_no
            End Get
            Set(ByVal Value As Integer)
                Me._Tuan_no = Value
            End Set
        End Property
        Public ReadOnly Property So_su_kien() As Integer
            Get
                Return sks.Count
            End Get
        End Property
        Public ReadOnly Property So_su_kien_chua_xep_lich() As Integer
            Get
                Dim no As Integer = 0
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).Thu = eTHU.KHONG_XAC_DINH Then no += 1
                Next
                Return no
            End Get
        End Property
        Public ReadOnly Property ds_sukiens() As Sukiens
            Get
                Return Me.sks
            End Get
        End Property

        Public Property TKB_change() As Boolean
            Get
                Return Me._TKB_change
            End Get
            Set(ByVal Value As Boolean)
                Me._TKB_change = Value
            End Set
        End Property
#End Region

#Region "Report"
        ' Các hàm trong report được sử dụng để hiển thị dữ liệu trên giao diện
        ' Hầu hết các hàm đều trả về DataTable để dễ hiển thị trên C1Flexgrid.
        ' Các đối tượng được tổ chức theo dạng gần giống với cơ sở dữ liệu quan hệ
        ' Tức là có các đối tượng đơn. Sau đó các đối tượng đơn được nhóm lại bởi
        ' arraylist. Và coi cả nhóm này là một đối tượng mới. Unisched lại tiếp 
        ' tục nhóm các đối tượng lớn này để quản lý chung. Khi truy cập hầu hết
        ' các truy cập được sử dụng thông qua các chỉ số. Trong các đối tượng chúng
        ' ta còn phải lưu thêm cả ID của các đối tượng đó, để tiện cho việc thực hiện
        ' thao tác với CSDL.
        Public Function List_su_kien() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Top_thu", GetType(String))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ca", GetType(String))
            dt.Columns.Add("Thu", GetType(String))
            dt.Columns.Add("Tiet", GetType(String))
            dt.Columns.Add("So_tiet", GetType(Integer))
            dt.Columns.Add("Loai_tiet", GetType(String))

            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).Thu = eTHU.KHONG_XAC_DINH Then
                    Dim sk As Su_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_phong") = sk.Ten_phong
                    row("Ky_hieu") = sk.Ky_hieu
                    row("Ten_mon") = sk.Ten_mon
                    row("Ten_giaovien") = sk.Hoten_giaovien
                    row("Ten_lop") = sk.Ten_lop
                    row("Thu") = sk.Thu
                    row("Tiet") = sk.Tiet
                    row("Ca") = sk.Ca_hoc
                    row("So_tiet") = sk.So_tiet
                    row("Loai_tiet") = sk.Loai_tiet
                    If sk.Top_thu > 0 Then
                        row("Top_thu") = sk.Top_thu
                    End If
                    dt.Rows.Add(row)
                End If
            Next

            Return dt
        End Function
        Public Function Baocao_TKB_giaovien(Optional ByVal ID_bm As Object = Nothing) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            Dim fgAdd As Boolean
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To gvs.Count - 1
                If (ID_bm Is Nothing) Or (Not ID_bm Is Nothing AndAlso gvs.Giaovien(i).ID_bm = ID_bm) Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    If i Mod 2 = 0 Then
                        row("Ten_giaovien") = gvs.Giaovien(i).Ten
                    Else
                        row("Ten_giaovien") = gvs.Giaovien(i).Ten + " "
                    End If
                    fgAdd = False
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If gvs.Giaovien(i).TKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_gv(i, thu, tiet)
                                fgAdd = True
                            End If
                        Next
                    Next
                    'If fgAdd Then dt.Rows.Add(row)
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Baocao_TKB_giaovien_Print(Optional ByVal ID_bm As Object = Nothing) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            Dim fgAdd As Boolean
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 1 To So_tiet_ngay
                    dt.Columns.Add("N" + i.ToString() + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To gvs.Count - 1
                If (ID_bm Is Nothing) Or (Not ID_bm Is Nothing AndAlso gvs.Giaovien(i).ID_bm = ID_bm) Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    If i Mod 2 = 0 Then
                        row("Ten_giaovien") = gvs.Giaovien(i).Ten
                    Else
                        row("Ten_giaovien") = gvs.Giaovien(i).Ten + " "
                    End If
                    fgAdd = False
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If gvs.Giaovien(i).TKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_gv(i, thu, tiet)
                                fgAdd = True
                            End If
                        Next
                    Next
                    If fgAdd Then dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Baocao_TKB_Lop(Optional ByVal ID_khoa As Object = Nothing) As DataTable
            Dim dt As New DataTable
            Dim fgAdd As Boolean
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To lps.Count - 1
                If (ID_khoa Is Nothing) Or (Not ID_khoa Is Nothing AndAlso lps.Lop(i).ID_khoa = ID_khoa) Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = lps.Lop(i).Ten_lop

                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If lps.Lop(i).TKB(thu, tiet) <> -1 Then
                                Dim col As Integer = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_lop(i, thu, tiet)
                                fgAdd = True
                            End If
                        Next
                    Next
                    'If fgAdd Then dt.Rows.Add(row)
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Baocao_TKB_Lop_Print(Optional ByVal ID_khoa As Object = Nothing) As DataTable
            Dim dt As New DataTable
            Dim fgAdd As Boolean
            Dim t As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ten_ca", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ca - 1
                    dt.Columns.Add("N" + i.ToString() + (j).ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To lps.Count - 1
                If (ID_khoa Is Nothing) Or (Not ID_khoa Is Nothing AndAlso lps.Lop(i).ID_khoa = ID_khoa) Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = lps.Lop(i).Ten_lop
                    row("Ten_phong") = lps.Lop(i).Ten_phong
                    row("Ten_ca") = CType(lps.Lop(i).Ca_hoc, eCA_HOC).ToString

                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If lps.Lop(i).TKB(thu, tiet) <> -1 Then
                                t = tiet
                                If t = 2 Then t = 0
                                If t = 3 Then t = 1
                                row("N" + thu.ToString + t.ToString) = Thongtin_lop_chitiet(i, thu, tiet)
                                fgAdd = True
                            End If
                        Next
                    Next
                    If fgAdd Then dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Baocao_TKB_phong() As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To phs.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    For tiet As Integer = 0 To So_tiet_ngay - 1
                        If phs.Phong_hoc(i).TKB(thu, tiet) <> -1 Then
                            col = CalCol(thu, tiet, 2)
                            row(col) = Thongtin_phong(i, thu, tiet)
                        End If
                    Next
                Next
                If row(col).ToString <> "" Then dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Baocao_TKB_phong_Print() As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 1 To So_tiet_ngay
                    dt.Columns.Add("N" + i.ToString() + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To phs.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    For tiet As Integer = 0 To So_tiet_ngay - 1
                        If phs.Phong_hoc(i).TKB(thu, tiet) <> -1 Then
                            col = CalCol(thu, tiet, 2)
                            row(col) = Thongtin_phong(i, thu, tiet)
                        End If
                    Next
                Next
                If row(col).ToString <> "" Then dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Danhsach_giaovien() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_canbo", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            For i As Integer = 0 To gvs.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("ID_canbo") = gvs.Giaovien(i).ID_cb
                row("Ten_giaovien") = gvs.Giaovien(i).Ho_ten
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Danhsach_lop() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("ID_lop") = lps.Lop(i).ID_lop
                row("Ten_lop") = lps.Lop(i).Ten_lop
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Danhsach_phong() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = 0 To phs.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("ID_phong") = phs.Phong_hoc(i).ID_phong
                row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_giaovien(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_gv(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_giaovien_print(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                For tiet = 0 To So_tiet_ngay
                    dt.Columns.Add("N" + tiet.ToString() + thu.ToString, GetType(String))
                Next
            Next
            Dim row As DataRow = dt.NewRow()
            For tiet = 0 To So_tiet_ngay - 1
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row("N" + tiet.ToString + thu.ToString) = Thongtin_gv(idx, thu, tiet)
                Next
            Next
            dt.Rows.Add(row)
            Return dt
        End Function
        Public Function Lich_lop(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_lop(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_lop_print(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                For tiet = 0 To So_tiet_ngay
                    dt.Columns.Add("N" + tiet.ToString() + thu.ToString, GetType(String))
                Next
            Next
            Dim row As DataRow = dt.NewRow()
            For tiet = 0 To So_tiet_ngay - 1
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row("N" + tiet.ToString + thu.ToString) = Thongtin_lop(idx, thu, tiet)
                Next
            Next
            dt.Rows.Add(row)
            Return dt
        End Function
        Public Function Lich_phong(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_phong(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_phong_print(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                For tiet = 0 To So_tiet_ngay
                    dt.Columns.Add("N" + tiet.ToString() + thu.ToString, GetType(String))
                Next
            Next
            Dim row As DataRow = dt.NewRow()
            For tiet = 0 To So_tiet_ngay - 1
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row("N" + tiet.ToString + thu.ToString) = Thongtin_phong(idx, thu, tiet)
                Next
            Next
            dt.Rows.Add(row)
            Return dt
        End Function
        Public Function List_sukien_chua_xeplich_giaovien(ByVal idx As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            For i As Integer = 0 To sks.Count - 1
                If (Not sks.Sukien(i).Da_xep_lich) And _
                (sks.Sukien(i).ID_cb = gvs.Giaovien(idx).ID_cb) And _
                (sks.Sukien(i).So_tiet > 1) Then
                    Dim sk As Su_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = sk.Ten_lop
                    row("Ten_phong") = sk.Ten_phong
                    row("Ten_mon") = sk.Ten_mon
                    row("Ca_hoc") = sk.Ca_hoc
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function List_sukien_chua_xeplich_lop(ByVal idx As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            For i As Integer = 0 To sks.Count - 1
                If (Not sks.Sukien(i).Da_xep_lich) And _
                (sks.Sukien(i).ID_lop = lps.Lop(idx).ID_lop) And _
                (sks.Sukien(i).So_tiet > 1) Then
                    Dim sk As Su_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_giaovien") = sk.Ten
                    row("Ten_phong") = sk.Ten_phong
                    row("Ten_mon") = sk.Ten_mon
                    row("Ca_hoc") = sk.Ca_hoc
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function List_sukien_chua_xeplich_phong(ByVal idx As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            For i As Integer = 0 To sks.Count - 1
                If (Not sks.Sukien(i).Da_xep_lich) And _
                (sks.Sukien(i).ID_phong = phs.Phong_hoc(idx).ID_phong) And _
                (sks.Sukien(i).So_tiet > 1) Then
                    Dim sk As Su_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = sk.Ten_lop
                    row("Ten_giaovien") = sk.Ten
                    row("Ten_mon") = sk.Ten_mon
                    row("Ca_hoc") = sk.Ca_hoc
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Thongke_Sotiet_lop() As DataTable
            Dim s(lps.Count - 1) As Integer
            Dim c(lps.Count - 1) As Integer
            Dim t(lps.Count - 1) As Integer
            For i As Integer = 0 To lps.Count - 1
                For j As Integer = 0 To sks.Count - 1
                    Dim sk As Su_kien = sks.Sukien(j)
                    If sk.ID_lop = lps.Lop(i).ID_lop Then
                        If sk.Ca_hoc = eCA_HOC.SANG Then s(i) += 1
                        If sk.Ca_hoc = eCA_HOC.CHIEU Then c(i) += 1
                        If sk.Ca_hoc = eCA_HOC.TOI Then t(i) += 1
                    End If
                Next
            Next

            Dim dt As New DataTable
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Sang", GetType(Integer))
            dt.Columns.Add("Chieu", GetType(Integer))
            dt.Columns.Add("Toi", GetType(Integer))
            dt.Columns.Add("Tong", GetType(String))
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("Ten_lop") = lps.Lop(i).Ten_lop
                row("Sang") = s(i)
                row("Chieu") = c(i)
                row("Toi") = t(i)
                row("Tong") = s(i) + c(i) + t(i)
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Thongke_Sotiet_giaovien() As DataTable
            Return gvs.Muc_do_cang()
        End Function
#End Region
    End Class
End Namespace


