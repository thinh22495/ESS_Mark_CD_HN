'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class LopTinChi_BLL
        Private aLops As New ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Ky_dang_ky As Integer)
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            Dim dt As DataTable = obj.Load_LopTinChi_List_TKB(Ky_dang_ky)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim lp As New LopTinChi(Ngay_tuan, So_tiet_ngay)
                lp.ID_lop_tc = CInt("0" + dt.Rows(i)("ID_lop_tc"))
                lp.ID_lop_lt = CInt("0" + dt.Rows(i)("ID_lop_lt"))
                lp.Ky_hieu_lop_tc = dt.Rows(i)("Ky_hieu_lop_tc").ToString()
                lp.Ky_hieu = dt.Rows(i)("Ky_hieu").ToString()
                lp.Ten_mon = dt.Rows(i)("Ten_mon").ToString()
                lp.ID_mon_tc = CInt("0" + dt.Rows(i)("ID_mon_tc").ToString())
                lp.So_sv_min = CInt("0" + dt.Rows(i)("So_sv_min").ToString())
                lp.So_sv_max = CInt("0" + dt.Rows(i)("So_sv_max").ToString())
                lp.So_tin_chi = CInt("0" + dt.Rows(i)("So_tin_chi").ToString())
                lp.So_tiet_tuan = CInt("0" + dt.Rows(i)("So_tiet_tuan").ToString())
                lp.Ly_thuyet = CInt("0" + dt.Rows(i)("Ly_thuyet").ToString())
                lp.Thuc_hanh = CInt("0" + dt.Rows(i)("Thuc_hanh").ToString())
                lp.STT_lop = CInt("0" + dt.Rows(i)("STT_lop").ToString())
                lp.STT_lop_lt = CInt("0" + dt.Rows(i)("STT_lop_lt").ToString())
                lp.Ca_hoc = CInt("0" + dt.Rows(i)("Ca_hoc").ToString())
                lp.Ten_ca_hoc = dt.Rows(i)("Ten_ca").ToString()
                lp.Tu_ngay = dt.Rows(i)("Tu_ngay")
                lp.Den_ngay = dt.Rows(i)("Den_ngay")
                lp.Ten_phong = dt.Rows(i)("Ten_phong").ToString
                lp.Ho_ten_gv = dt.Rows(i)("Ho_ten").ToString
                lp.Nhom_dang_ky = dt.Rows(i)("Nhom_dang_ky").ToString
                lp.ID_he = CInt("0" + dt.Rows(i)("ID_he").ToString())
                lp.Khoa_hoc = CInt("0" + dt.Rows(i)("Khoa_hoc").ToString())
                lp.ID_khoa = CInt("0" + dt.Rows(i)("ID_khoa").ToString())
                lp.ID_nganh = CInt("0" + dt.Rows(i)("ID_nganh").ToString())
                lp.ID_chuyen_nganh = CInt("0" + dt.Rows(i)("ID_chuyen_nganh").ToString())
                lp.ID_BM = CInt("0" + dt.Rows(i)("ID_BM").ToString())
                'lp.ID_phong = CInt("0" + dt.Rows(i)("ID_phong").ToString())
                aLops.Add(lp)
            Next
        End Sub
#End Region

#Region "Function"
        Public Function Tim_Ten_lop(ByVal ID_lop As Integer) As String
            For i As Integer = 0 To aLops.Count - 1
                Dim lp As LopTinChi = CType(aLops(i), LopTinChi)
                If lp.ID_lop_tc = ID_lop Then
                    Return lp.Ten_lop_tc
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_lop(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To alops.Count - 1
                Dim lp As LopTinChi = CType(aLops(i), LopTinChi)
                If lp.Ten_lop_tc = Ten_lop Then
                    Return lp.ID_lop_tc
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To aLops.Count - 1
                Dim lp As LopTinChi = CType(aLops(i), LopTinChi)
                If lp.Ten_lop_tc = Ten_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To aLops.Count - 1
                Dim lp As LopTinChi = CType(aLops(i), LopTinChi)
                If lp.ID_lop_tc = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.alops.Count
            End Get
        End Property
        Public Property Lop(ByVal idx As Integer) As LopTinChi
            Get
                Return CType(Me.alops(idx), LopTinChi)
            End Get
            Set(ByVal Value As LopTinChi)
                Me.alops(idx) = Value
            End Set
        End Property

        Function Load_LopSVDangKyTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            Dim dt As DataTable = obj.Load_LopSinhVienDangKyTinChi_List(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Chon") = False
            Next
            Return dt
        End Function
        Function Load_ThongKeSVLopTinChi1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            Dim dt As DataTable = obj.Load_ThongKeSVLopTinChi(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Chon") = False
            Next
            Return dt
        End Function

        Function Load_ThongKeSVDangKyTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            Dim dt As DataTable = obj.Load_ThongKeSinhVienDangKyTinChi_List(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops)
            Return dt
        End Function

        Public Sub Update_HuyLop(ByVal ID_lop_tc As Integer, ByVal HuyLop As Integer, ByVal Ly_do As String)
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            obj.Update_HuyLopTinChi(ID_lop_tc, HuyLop, Ly_do)
        End Sub
        Public Sub Update_HuyDangKySV(ByVal ID_lop_tc As Integer, ByVal ID_sv As Integer, ByVal Ly_do As String)
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            obj.Update_HuyDangKySV(ID_lop_tc, ID_sv, Ly_do)
        End Sub
        Public Sub Chuyen_Lop(ByVal Ky_dang_ky As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc_tu As Integer, ByVal ID_lop_tc_den As Integer, ByVal thu As Integer, ByVal tiet As Integer)
            Dim dtDSSV As DataTable
            Dim clsLopTC As New DanhSachLopTinChi_BLL(ID_mon_tc, ID_lop_tc_tu)
            dtDSSV = clsLopTC.Danh_sach_sinh_vien()
            'Duyệt toàn bộ danh sách sinh viên của lớp tín chỉ cần chuyển
            For i As Integer = 0 To dtDSSV.Rows.Count - 1
                If Check_TKB_SV(Ky_dang_ky, thu, tiet, dtDSSV.Rows(i)("ID_sv")) = True Then
                    'Update lại đến lớp tín chỉ mới
                    clsLopTC.Update_LopTinChi_Chuyen(dtDSSV.Rows(i)("ID_sv"), ID_lop_tc_tu, ID_lop_tc_den)
                End If
            Next
        End Sub
        Public Function Check_TKB_Lop(ByVal Ky_dang_ky As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc_tu As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            Dim dtDSSV As DataTable
            Dim clsLopTC As New DanhSachLopTinChi_BLL(ID_mon_tc, ID_lop_tc_tu)
            dtDSSV = clsLopTC.Danh_sach_sinh_vien()
            For i As Integer = 0 To dtDSSV.Rows.Count - 1
                If Check_TKB_SV(Ky_dang_ky, thu, tiet, dtDSSV.Rows(i)("ID_sv")) = False Then
                    Return False
                End If
            Next
            Return True
        End Function
        Public Function Check_TKB_SV(ByVal Ky_dang_ky As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal ID_sv As Integer) As Boolean
            Dim clsDK As New PortalDangKyLopTinChi_BLL
            Dim dtTKBLopDaDK As DataTable
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, Ky_dang_ky, "")
            For i As Integer = 0 To dtTKBLopDaDK.Rows.Count - 1
                If dtTKBLopDaDK.Rows(i)("thu") = thu And dtTKBLopDaDK.Rows(i)("tiet") = tiet Then
                    Return False
                End If
            Next
            Return True
        End Function
        Public Function Ky_dang_ky(ByVal Dot As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Dim clsDAL As New MonTinChi_DAL
            Dim dtKyDangKy As DataTable
            dtKyDangKy = clsDAL.Load_tkbHocKyDangKy_List(0, Hoc_ky, Nam_hoc)
            If dtKyDangKy.Rows.Count > 0 Then
                Return dtKyDangKy.Rows(0)("Ky_dang_ky")
            Else
                Return 0
            End If
        End Function
        Public Sub TKB_Lop_tin_chi(ByVal ID_lop_tc As Integer, ByRef thu As Integer, ByRef tiet As Integer)
            Dim obj As LopTinChi_DAL = New LopTinChi_DAL
            Dim dt As DataTable = obj.SuKiensLopTinChi(ID_lop_tc)
            If dt.Rows.Count > 0 Then
                thu = dt.Rows(0)("thu")
                tiet = dt.Rows(0)("tiet")
            Else
                thu = 0
                tiet = 0
            End If
        End Sub
#End Region
    End Class
End Namespace
