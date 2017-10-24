'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, July 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class MonTinChi_BLL
        Private arrMonTinChi As New ArrayList
        Private mKy_dang_ky As Integer = 0
        Private mDot As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTu_ngay As Date
        Private mDen_ngay As Date
        Private mdtKeHoachKhac As New DataTable
#Region "Constructor"
        Sub New()

        End Sub
        Sub New(ByVal Ky_dang_ky As Integer)
            Dim clsDAL As New MonTinChi_DAL
            Dim dtMon, dtLop, dtPhamVi, dtKyDangKy As DataTable
            'Load môn tín chỉ đã tạo trong học kỳ
            dtMon = clsDAL.Load_tkbMonTinChi_List(Ky_dang_ky)
            'Load lớp tín chỉ của các môn
            dtLop = clsDAL.Load_tkbLopTinChi_List(Ky_dang_ky)
            'Load phạm vi đăng ký của các môn
            dtPhamVi = clsDAL.Load_tkbPhamViDangKy_List(Ky_dang_ky)
            'Load thời gian trong học kỳ
            dtKyDangKy = clsDAL.Load_tkbHocKyDangKy_List(Ky_dang_ky)
            For idx_mon As Integer = 0 To dtMon.Rows.Count - 1
                Dim objMonTC As New MonTinChi
                objMonTC = ConvertMonTinChi(dtMon.Rows(idx_mon))
                'Lọc các lớp theo ID_mon_tc
                dtLop.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                'Add các lớp tín chỉ thuộc môn tín chỉ
                If dtLop.DefaultView.Count > 0 Then
                    'Add các lớp tín chỉ
                    For idx_lop As Integer = 0 To dtLop.DefaultView.Count - 1
                        Dim objLopTC As New LopTinChi
                        objLopTC = ConvertLopTinChi(dtLop.DefaultView.Item(idx_lop).Row)
                        objMonTC.dsLopTinChi.Add(objLopTC)
                    Next
                End If
                'Add phạm vi đăng ký của môn tín chỉ
                'Lọc phạm vi đăng ký theo ID_mon_tc
                dtPhamVi.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                If dtPhamVi.Rows.Count > 0 Then
                    For idx_pv As Integer = 0 To dtPhamVi.DefaultView.Count - 1
                        Dim objPhamVi As New PhamViDangKy
                        objPhamVi = ConvertPhamViDangKy(dtPhamVi.DefaultView.Item(idx_pv).Row)
                        objMonTC.dsPhamViDangKy.Add(objPhamVi)
                    Next
                End If
                arrMonTinChi.Add(objMonTC)
            Next
            'Thời gian trong học kỳ đăng ký
            mKy_dang_ky = Ky_dang_ky
            If dtKyDangKy.Rows.Count > 0 Then
                Dot = dtKyDangKy.Rows(0)("Dot")
                Hoc_ky = dtKyDangKy.Rows(0)("Hoc_ky")
                Nam_hoc = dtKyDangKy.Rows(0)("Nam_hoc")
                Tu_ngay = dtKyDangKy.Rows(0)("Tu_ngay")
                Den_ngay = dtKyDangKy.Rows(0)("Den_ngay")
                'Load kế hoạch khác
                mdtKeHoachKhac = clsDAL.Load_tkbKeHoachKhac_List(Hoc_ky, Nam_hoc)
            End If
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachHocPhan() As DataTable
            Dim dtMon As New DataTable
            Dim Add_new As Boolean = False
            dtMon.Columns.Add("ID_mon", GetType(Integer))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi = CType(arrMonTinChi(i), MonTinChi)
                Add_new = True
                For j As Integer = 0 To dtMon.Rows.Count - 1
                    If dtMon.Rows(j)("ID_mon") = objMonTC.ID_mon Then
                        Add_new = False
                        Exit For
                    End If
                Next
                If Add_new Then
                    Dim dr As DataRow = dtMon.NewRow
                    dr("ID_mon") = objMonTC.ID_mon
                    dr("Ten_mon") = objMonTC.Ten_mon + "(" + objMonTC.Ky_hieu + ")"
                    dtMon.Rows.Add(dr)
                End If
            Next
            Return dtMon
        End Function

        Public Function DanhSachKyHieuLop(ByVal ID_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("Ky_hieu_lop_tc1", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi = CType(arrMonTinChi(i), MonTinChi)
                If objMonTC.ID_mon = ID_mon Then
                    Dim dr As DataRow = dtLop.NewRow
                    dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                    dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                    dtLop.Rows.Add(dr)
                End If
            Next
            Return dtLop
        End Function

        Public Function getKyDangKy(ByVal Dot As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Dim clsDAL As New MonTinChi_DAL
            Dim dtKyDangKy As DataTable
            dtKyDangKy = clsDAL.Load_tkbHocKyDangKy_List(Dot, Hoc_ky, Nam_hoc)
            If dtKyDangKy.Rows.Count > 0 Then
                Return dtKyDangKy.Rows(0)(0)
            Else
                Return 0
            End If
        End Function


        Public Function DanhSachMonTinChi() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("Chon", GetType(Boolean))
            dtMon.Columns.Add("idx_mon", GetType(Integer))
            dtMon.Columns.Add("ID_mon_tc", GetType(Integer))
            dtMon.Columns.Add("ID_mon", GetType(Integer))            
            dtMon.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            'dtMon.Columns.Add("ID_lop_tc", GetType(Integer))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            dtMon.Columns.Add("So_tin_chi", GetType(Integer))
            dtMon.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtMon.Columns.Add("Ly_thuyet", GetType(Integer))
            dtMon.Columns.Add("Thuc_hanh", GetType(Integer))
            dtMon.Columns.Add("He_so", GetType(Integer))
            dtMon.Columns.Add("So_tien", GetType(Integer))
            dtMon.Columns.Add("Kien_thuc", GetType(Integer))
            dtMon.Columns.Add("Ky_hieu", GetType(String))
            dtMon.Columns.Add("ID_he", GetType(Integer))
            dtMon.Columns.Add("ID_khoa", GetType(Integer))
            dtMon.Columns.Add("Khoa_hoc", GetType(Integer))
            dtMon.Columns.Add("ID_nganh", GetType(Integer))
            dtMon.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi = CType(arrMonTinChi(i), MonTinChi)
                Dim dr As DataRow = dtMon.NewRow
                dr("Chon") = False
                dr("idx_mon") = i
                dr("ID_mon_tc") = objMonTC.ID_mon_tc
                dr("ID_mon") = objMonTC.ID_mon                
                dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc                
                dr("Ten_mon") = objMonTC.Ten_mon
                dr("So_tin_chi") = objMonTC.So_hoc_trinh
                dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                dr("Ly_thuyet") = objMonTC.Ly_thuyet
                dr("Thuc_hanh") = objMonTC.Thuc_hanh
                dr("He_so") = objMonTC.He_so
                dr("So_tien") = objMonTC.So_tien
                dr("Kien_thuc") = objMonTC.Kien_thuc
                dr("Ky_hieu") = objMonTC.Ky_hieu
                For j As Integer = 0 To objMonTC.dsPhamViDangKy.Count - 1
                    Dim objPV As PhamViDangKy = CType(objMonTC.dsPhamViDangKy.PhamViDangKy(j), PhamViDangKy)
                    dr("ID_he") = objPV.ID_he
                    dr("ID_khoa") = objPV.ID_khoa
                    dr("Khoa_hoc") = objPV.Khoa_hoc
                    dr("ID_nganh") = objPV.ID_nganh
                    dr("ID_chuyen_nganh") = objPV.ID_chuyen_nganh
                Next

                dtMon.Rows.Add(dr)
            Next
            Return dtMon
        End Function

        Public Function DanhSachMonTinChiTKB() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon_tc", GetType(Integer))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi = CType(arrMonTinChi(i), MonTinChi)
                Dim dr As DataRow = dtMon.NewRow
                dr("ID_mon_tc") = objMonTC.ID_mon_tc
                dr("Ten_mon") = objMonTC.Ten_mon + "(" + objMonTC.Ky_hieu_lop_tc + ")"
                dtMon.Rows.Add(dr)
            Next
            Return dtMon
        End Function

        Public Function DanhSachMonLopTinChi() As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("So_tin_chi", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)                    
                    If objLopTC.ID_lop_lt = 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                        If idx >= 0 Then
                            dr("ID_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_he
                            dr("ID_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_khoa
                            dr("Ten_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_he
                            dr("Ten_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_khoa
                        End If
                        dr("ID_mon_tc") = objMonTC.ID_mon_tc
                        dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                        dr("ID_mon") = objMonTC.ID_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dr("So_tin_chi") = objLopTC.So_tin_chi
                        dr("Chon") = False
                        dtLop.Rows.Add(dr)
                    End If
                Next
            Next
            dtLop.DefaultView.Sort = "Ten_mon, Ky_hieu_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachMonLopTinChi(ByVal ID_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                If objMonTC.ID_mon = ID_mon Then
                    For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                        Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                        If objLopTC.ID_lop_lt = 0 Then
                            Dim dr As DataRow = dtLop.NewRow
                            idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                            If idx >= 0 Then
                                dr("ID_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_he
                                dr("ID_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_khoa
                                dr("Ten_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_he
                                dr("Ten_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_khoa
                            End If
                            dr("ID_mon_tc") = objMonTC.ID_mon_tc
                            dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                            dr("ID_mon") = objMonTC.ID_mon
                            dr("Ten_mon") = objMonTC.Ten_mon
                            dr("ID_lop_tc") = objLopTC.ID_lop_tc
                            dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                            dtLop.Rows.Add(dr)
                        End If
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "Ten_mon, Ky_hieu_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachMonLopTinChi_TCT() As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                    If objLopTC.ID_lop_lt = 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                        If idx >= 0 Then
                            dr("ID_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_he
                            dr("ID_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_khoa
                            dr("Ten_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_he
                            dr("Ten_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Ten_khoa
                        End If
                        dr("ID_mon_tc") = objMonTC.ID_mon_tc
                        dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                        dr("ID_mon") = objMonTC.ID_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dtLop.Rows.Add(dr)
                    End If
                Next
            Next
            dtLop.DefaultView.Sort = "ID_he,ID_khoa,Ten_mon"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi(ByVal idx_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            If idx_mon >= 0 Then
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                    If objLopTC.ID_lop_lt = 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        dr("idx_lop") = i
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("STT_lop") = objLopTC.STT_lop
                        dr("So_sv_min") = objLopTC.So_sv_min
                        dr("So_sv_max") = objLopTC.So_sv_max
                        dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("CaID") = objLopTC.Ca_hoc
                        dr("Tu_ngay") = objLopTC.Tu_ngay
                        dr("Den_ngay") = objLopTC.Den_ngay
                        dtLop.Rows.Add(dr)
                    End If
                Next
            End If
            Return dtLop
        End Function

        Public Function DanhSachPhanGiaoVien(ByVal ID_bm As Integer) As DataTable
            Dim dtLop As New DataTable
            Dim gvs As New GiaoVien_BLL()
            Dim idx As Integer
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_cb", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_tin_chi", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                If objMonTC.ID_bm = ID_bm Or ID_bm = 0 Then
                    For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                        Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                        Dim dr As DataRow = dtLop.NewRow
                        'Thông tin môn
                        dr("idx_mon") = idx_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("So_tin_chi") = objMonTC.So_hoc_trinh
                        'Thông tin lớp
                        dr("idx_lop") = i
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("ID_cb") = objLopTC.ID_cb
                        idx = gvs.Tim_chi_so_theo_ID_cb(objLopTC.ID_cb)
                        If idx >= 0 Then
                            dr("Ho_ten") = gvs.Giaovien(idx).Ho_ten
                        End If
                        dtLop.Rows.Add(dr)
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "Ten_mon, Ten_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachPhanPhongHoc() As DataTable
            Dim dtLop As New DataTable
            Dim phs As New PhongHoc_BLL()
            Dim idx As Integer
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_tin_chi", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Ten_phong", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                    Dim dr As DataRow = dtLop.NewRow
                    'Thông tin môn
                    dr("idx_mon") = idx_mon
                    dr("Ten_mon") = objMonTC.Ten_mon
                    dr("So_tin_chi") = objMonTC.So_hoc_trinh
                    'Thông tin lớp
                    dr("idx_lop") = i
                    dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                    dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                    dr("ID_phong") = objLopTC.ID_phong
                    idx = phs.Tim_chi_so(objLopTC.ID_phong)
                    If idx >= 0 Then dr("Ten_phong") = phs.Phong_hoc(idx).So_phong
                    dtLop.Rows.Add(dr)
                Next
            Next
            dtLop.DefaultView.Sort = "Ten_mon, Ten_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi() As DataTable
            Dim dtLop As New DataTable
            Dim Ngay_dau, Ngay_cuoi As Date
            Dim Ky_hieu As String
            Dim Tuan_thu As Integer
            Dim phs As New PhongHoc_BLL()
            Dim gvs As New GiaoVien_BLL()
            Dim idx As Integer
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_tin_chi", GetType(Integer))
            dtLop.Columns.Add("Ly_thuyet", GetType(Integer))
            dtLop.Columns.Add("Thuc_hanh", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Giao_vien", GetType(String))
            dtLop.Columns.Add("Phong_hoc", GetType(String))
            'Add các cột tuần trong kỳ đăng ký
            Tuan_thu = DatePart(DateInterval.WeekOfYear, Tu_ngay)
            Ngay_dau = Tu_ngay
            Ngay_cuoi = Ngay_dau.AddDays(1)
            Do While Ngay_cuoi <= Den_ngay
                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                    dtLop.Columns.Add("T" + Tuan_thu.ToString)
                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Ngay_dau = Ngay_cuoi
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                End If
                Ngay_cuoi = Ngay_cuoi.AddDays(1)
            Loop

            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                    Dim dr As DataRow = dtLop.NewRow
                    'Thông tin môn
                    dr("idx_mon") = idx_mon
                    dr("Ky_hieu") = objMonTC.Ky_hieu
                    dr("Ten_mon") = objMonTC.Ten_mon
                    dr("So_tin_chi") = objMonTC.So_hoc_trinh
                    dr("Ly_thuyet") = objMonTC.Ly_thuyet
                    dr("Thuc_hanh") = objMonTC.Thuc_hanh
                    idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                    If idx >= 0 Then
                        dr("ID_he") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_he
                        dr("ID_khoa") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_khoa
                        dr("ID_nganh") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_nganh
                        dr("ID_chuyen_nganh") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).ID_chuyen_nganh
                        dr("Khoa_hoc") = objMonTC.dsPhamViDangKy.PhamViDangKy(idx).Khoa_hoc
                    End If
                    'Thông tin lớp
                    dr("idx_lop") = i
                    dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                    dr("So_sv_min") = objLopTC.So_sv_min
                    dr("So_sv_max") = objLopTC.So_sv_max
                    dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                    dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                    dr("Tu_ngay") = objLopTC.Tu_ngay
                    dr("Den_ngay") = objLopTC.Den_ngay
                    idx = gvs.Tim_chi_so_theo_ID_cb(objLopTC.ID_cb)
                    If idx >= 0 Then dr("Giao_vien") = gvs.Giaovien(idx).Ho_ten
                    idx = phs.Tim_chi_so(objLopTC.ID_phong)
                    If idx >= 0 Then dr("Phong_hoc") = phs.Phong_hoc(idx).So_phong
                    'Add thông tin thời gian học của từng lớp
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, objLopTC.Tu_ngay)
                    Ngay_dau = objLopTC.Tu_ngay
                    Ngay_cuoi = Ngay_dau.AddDays(1)
                    Do While Ngay_cuoi <= objLopTC.Den_ngay
                        If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                            If dtLop.Columns.Contains("T" + Tuan_thu.ToString) Then
                                'Kiểm tra xem tuần này có kế hoạch khác không?
                                Ky_hieu = CheckKeHoachKhac(mdtKeHoachKhac, Tuan_thu, dr("ID_he"), dr("ID_khoa"), dr("Khoa_hoc"), dr("ID_nganh"), dr("ID_chuyen_nganh"))
                                If Ky_hieu <> "" Then
                                    dr("T" + Tuan_thu.ToString) = Ky_hieu
                                Else
                                    dr("T" + Tuan_thu.ToString) = "H"
                                End If
                            End If
                            Ngay_cuoi = Ngay_cuoi.AddDays(1)
                            Ngay_dau = Ngay_cuoi
                            Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                        End If
                        Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Loop
                    dtLop.Rows.Add(dr)
                Next
            Next
            dtLop.DefaultView.Sort = "Ten_mon, Ten_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachNhomTinChi(ByVal idx_mon As Integer, ByVal ID_lop_lt As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            If idx_mon >= 0 Then
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As LopTinChi = CType(objMonTC.dsLopTinChi.LopTinChi(i), LopTinChi)
                    If objLopTC.ID_lop_lt = ID_lop_lt Then
                        Dim dr As DataRow = dtLop.NewRow
                        dr("idx_lop") = i
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("STT_lop") = objLopTC.STT_lop
                        dr("So_sv_min") = objLopTC.So_sv_min
                        dr("So_sv_max") = objLopTC.So_sv_max
                        dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                        dr("So_hoc_trinh") = objLopTC.So_tin_chi
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("CaID") = objLopTC.Ca_hoc
                        dr("Tu_ngay") = objLopTC.Tu_ngay
                        dr("Den_ngay") = objLopTC.Den_ngay
                        dtLop.Rows.Add(dr)
                    End If
                Next
            End If
            Return dtLop
        End Function

        Public Function DanhSachPhamViDangKy(ByVal idx_mon As Integer) As DataTable
            Dim dtPhamVi As New DataTable
            dtPhamVi.Columns.Add("ID_he", GetType(Integer))
            dtPhamVi.Columns.Add("ID_khoa", GetType(Integer))
            dtPhamVi.Columns.Add("Khoa_hoc", GetType(Integer))
            dtPhamVi.Columns.Add("ID_nganh", GetType(Integer))
            dtPhamVi.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            If idx_mon >= 0 Then
                Dim objMonTC As MonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), MonTinChi)
                For i As Integer = 0 To objMonTC.dsPhamViDangKy.Count - 1
                    Dim objPV As PhamViDangKy = CType(objMonTC.dsPhamViDangKy.PhamViDangKy(i), PhamViDangKy)
                    Dim dr As DataRow = dtPhamVi.NewRow
                    dr("ID_he") = objPV.ID_he
                    dr("ID_khoa") = objPV.ID_khoa
                    dr("Khoa_hoc") = objPV.Khoa_hoc
                    dr("ID_nganh") = objPV.ID_nganh
                    dr("ID_chuyen_nganh") = objPV.ID_chuyen_nganh
                    dtPhamVi.Rows.Add(dr)
                Next
            End If
            Return dtPhamVi
        End Function

        Public Function Load_DanhSachMonTinChi(ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Load_svChuongTrinhDaoTaoChiTietMonTinChi_List(Kien_thuc, Ky_thu, Bat_buoc, Tu_chon, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Load_MonTinChi(ByVal ID_mon As Integer, ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
        '    Try
        '        Dim obj As MonTinChi_DAL = New MonTinChi_DAL
        '        Return obj.Load_svChuongTrinhDaoTaoChiTietMonTinChi_List(Kien_thuc, Ky_thu, Bat_buoc, Tu_chon, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function Load_tkbHocKyDangKyQuyDinh_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Load_tkbHocKyDangKyQuyDinh_List(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_MonTinChi(ByVal objMonTinChi As MonTinChi) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Insert_MonTinChi(objMonTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MonTinChi(ByVal objMonTinChi As MonTinChi, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Update_MonTinChi(objMonTinChi, ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_MonTinChi(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Delete_MonTinChi(ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_MonTinChi(ByVal Hoc_ky_dk As Integer, ByVal ID_mon As Integer, ByVal So_tin_chi As Integer) As Boolean
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Check_MonTinChi(Hoc_ky_dk, ID_mon, So_tin_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_MonTinChi_Ten(ByVal Hoc_ky_dk As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Check_MonTinChi_Ten(Hoc_ky_dk, Ky_hieu_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_MonTinChi_TenUpdate(ByVal ID_mon_tc As Integer, ByVal Hoc_ky_dk As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Check_MonTinChi_TenUpdate(ID_mon_tc, Hoc_ky_dk, Ky_hieu_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LopTinChi(ByVal objLopTinChi As LopTinChi) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Insert_LopTinChi(objLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChiEdit(ByVal objLopTinChi As LopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Update_LopTinChiEdit(objLopTinChi, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChi(ByVal objLopTinChi As LopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Update_LopTinChi(objLopTinChi, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LopTinChi(ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Delete_LopTinChi(ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_PhamViDangKy(ByVal objPhamViDangKy As PhamViDangKy) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Insert_PhamViDangKy(objPhamViDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhamViDangKy(ByVal objPhamViDangKy As PhamViDangKy, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Update_PhamViDangKy(objPhamViDangKy, ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhamViDangKy(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Delete_PhamViDangKy(ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_tkbPhamViDangKyLop_List(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Dim obj As MonTinChi_DAL = New MonTinChi_DAL
            Return obj.Load_tkbPhamViDangKyLop_List(Ky_dang_ky, ID_dt)
        End Function

        Public Function Load_tkbPhamViDangKyLopChon_List(ByVal Ky_dang_ky As Integer, ByVal ID_lop As Integer) As DataTable
            Dim obj As MonTinChi_DAL = New MonTinChi_DAL
            Return obj.Load_tkbPhamViDangKyLopChon_List(Ky_dang_ky, ID_lop)
        End Function

        Public Function Insert_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Insert_tkbPhamViDangKyLop(ID_lop_tc, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function Delete_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Delete_tkbPhamViDangKyLop(ID_lop_tc, ID_lop)
            Catch ex As Exception
            End Try
        End Function
        Public Function Load_tkbKeHoachKhac_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Load_tkbKeHoachKhac_List(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_tkbKeHoachKyHieu_List() As DataTable
            Try
                Dim obj As MonTinChi_DAL = New MonTinChi_DAL
                Return obj.Load_tkbKeHoachKyHieu_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function CheckKeHoachKhac(ByVal dtKeHoachKhac As DataTable, ByVal Tuan_thu As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Dim Ky_hieu As String = ""
            For i As Integer = 0 To dtKeHoachKhac.Rows.Count - 1
                If (dtKeHoachKhac.Rows(i)("ID_he") = 0 Or (dtKeHoachKhac.Rows(i)("ID_he") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_he") = ID_he)) And _
                    (dtKeHoachKhac.Rows(i)("ID_khoa") = 0 Or (dtKeHoachKhac.Rows(i)("ID_khoa") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_khoa") = ID_khoa)) And _
                    (dtKeHoachKhac.Rows(i)("Khoa_hoc") = 0 Or (dtKeHoachKhac.Rows(i)("Khoa_hoc") > 0 AndAlso dtKeHoachKhac.Rows(i)("Khoa_hoc") = Khoa_hoc)) And _
                    (dtKeHoachKhac.Rows(i)("ID_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_nganh") = ID_nganh)) And _
                    (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = ID_chuyen_nganh)) Then
                    If DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Tu_ngay")) <= Tuan_thu And _
                        DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Den_ngay")) > Tuan_thu Then
                        Ky_hieu = dtKeHoachKhac.Rows(i)("Ky_hieu")
                    End If
                End If
            Next
            Return Ky_hieu
        End Function
        Private Function ConvertMonTinChi(ByVal drMonTinChi As DataRow) As MonTinChi
            Dim result As MonTinChi
            Try
                result = New MonTinChi
                If drMonTinChi("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drMonTinChi("ID_mon_tc").ToString(), Integer)
                If drMonTinChi("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drMonTinChi("Ky_dang_ky").ToString(), Integer)
                result.Ky_hieu_lop_tc = drMonTinChi("Ky_hieu_lop_tc").ToString()
                result.Ky_hieu = drMonTinChi("Ky_hieu").ToString()
                result.Ten_mon = drMonTinChi("Ten_mon").ToString()
                If drMonTinChi("ID_mon").ToString() <> "" Then result.ID_mon = CType(drMonTinChi("ID_mon").ToString(), Integer)
                If drMonTinChi("ID_bm").ToString() <> "" Then result.ID_bm = CType(drMonTinChi("ID_bm").ToString(), Integer)
                If drMonTinChi("So_tin_chi").ToString() <> "" Then result.So_hoc_trinh = CType(drMonTinChi("So_tin_chi").ToString(), Integer)
                If drMonTinChi("Ly_thuyet").ToString() <> "" Then result.Ly_thuyet = CType(drMonTinChi("Ly_thuyet").ToString(), Integer)
                If drMonTinChi("Thuc_hanh").ToString() <> "" Then result.Thuc_hanh = CType(drMonTinChi("Thuc_hanh").ToString(), Integer)
                If drMonTinChi("He_so").ToString() <> "" Then result.He_so = CType(drMonTinChi("He_so").ToString(), Integer)
                If drMonTinChi("So_tien").ToString() <> "" Then result.So_tien = CType(drMonTinChi("So_tien").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertLopTinChi(ByVal drtkbLopTinChi As DataRow) As LopTinChi
            Dim result As LopTinChi
            Try
                result = New LopTinChi
                If drtkbLopTinChi("ID_lop_tc").ToString() <> "" Then result.ID_lop_tc = CType(drtkbLopTinChi("ID_lop_tc").ToString(), Integer)
                If drtkbLopTinChi("ID_lop_lt").ToString() <> "" Then result.ID_lop_lt = CType(drtkbLopTinChi("ID_lop_lt").ToString(), Integer)
                If drtkbLopTinChi("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drtkbLopTinChi("ID_mon_tc").ToString(), Integer)
                If drtkbLopTinChi("STT_lop").ToString() <> "" Then result.STT_lop = CType(drtkbLopTinChi("STT_lop").ToString(), Integer)
                result.Ky_hieu_lop_tc = drtkbLopTinChi("Ky_hieu_lop_tc").ToString
                If drtkbLopTinChi("STT_lop_lt").ToString() <> "" Then result.STT_lop_lt = CType(drtkbLopTinChi("STT_lop_lt").ToString(), Integer)
                If drtkbLopTinChi("So_sv_min").ToString() <> "" Then result.So_sv_min = CType(drtkbLopTinChi("So_sv_min").ToString(), Integer)
                If drtkbLopTinChi("So_sv_max").ToString() <> "" Then result.So_sv_max = CType(drtkbLopTinChi("So_sv_max").ToString(), Integer)
                If drtkbLopTinChi("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drtkbLopTinChi("Tu_ngay").ToString(), Date)
                If drtkbLopTinChi("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drtkbLopTinChi("Den_ngay").ToString(), Date)
                If drtkbLopTinChi("Ca_hoc").ToString() <> "" Then result.Ca_hoc = CType(drtkbLopTinChi("Ca_hoc").ToString(), Integer)
                result.Ten_ca_hoc = drtkbLopTinChi("Ten_ca").ToString()
                If drtkbLopTinChi("So_tiet_tuan").ToString() <> "" Then result.So_tiet_tuan = CType(drtkbLopTinChi("So_tiet_tuan").ToString(), Integer)
                If drtkbLopTinChi("ID_phong").ToString() <> "" Then result.ID_phong = CType(drtkbLopTinChi("ID_phong").ToString(), Integer)
                If drtkbLopTinChi("ID_cb").ToString() <> "" Then result.ID_cb = CType(drtkbLopTinChi("ID_cb").ToString(), Integer)
                result.Huy_lop = drtkbLopTinChi("Huy_lop").ToString()
                result.Ly_do = drtkbLopTinChi("Ly_do").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertPhamViDangKy(ByVal drPhamViDangKy As DataRow) As PhamViDangKy
            Dim result As PhamViDangKy
            Try
                result = New PhamViDangKy
                If drPhamViDangKy("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drPhamViDangKy("ID_mon_tc").ToString(), Integer)
                If drPhamViDangKy("ID_he").ToString() <> "" Then result.ID_he = CType(drPhamViDangKy("ID_he").ToString(), Integer)
                result.Ten_he = drPhamViDangKy("Ten_he").ToString()
                If drPhamViDangKy("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drPhamViDangKy("ID_khoa").ToString(), Integer)
                result.Ten_khoa = drPhamViDangKy("Ten_khoa").ToString()
                If drPhamViDangKy("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drPhamViDangKy("Khoa_hoc").ToString(), Integer)
                If drPhamViDangKy("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drPhamViDangKy("ID_nganh").ToString(), Integer)
                If drPhamViDangKy("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drPhamViDangKy("ID_chuyen_nganh").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
        Public Sub Add(ByVal mon As MonTinChi)
            arrMonTinChi.Add(mon)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrMonTinChi.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_mon_tc As Integer) As Integer
            For i As Integer = 0 To arrMonTinChi.Count - 1
                If CType(arrMonTinChi(i), MonTinChi).ID_mon_tc = ID_mon_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Property MonTinChi(ByVal idx As Integer) As MonTinChi
            Get
                Return CType(Me.arrMonTinChi(idx), MonTinChi)
            End Get
            Set(ByVal Value As MonTinChi)
                Me.arrMonTinChi(idx) = Value
            End Set
        End Property
        Public Property Ky_dang_ky() As Integer
            Get
                Return mKy_dang_ky
            End Get
            Set(ByVal Value As Integer)
                mKy_dang_ky = Value
            End Set
        End Property
        Public Property Dot() As Integer
            Get
                Return mDot
            End Get
            Set(ByVal Value As Integer)
                mDot = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
            End Set
        End Property
    End Class
End Namespace
