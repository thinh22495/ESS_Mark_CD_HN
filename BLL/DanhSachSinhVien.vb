'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachSinhVien_BLL
        Private arrDanhSach As ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                If ID_lops = "" Then ID_lops = "0"
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Dim dt As DataTable = obj.Load_List_DanhSachSinhVien_List(ID_lops)
                Dim objDanhSachSinhVien As DanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Converting(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Load_List_DanhSachSinhVien_List(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Dim dt As DataTable = obj.Load_List_DanhSachSinhVien_List(ID_lops)
                dt.Columns.Add("Chon", Type.GetType("System.Boolean"))
                For Each row As DataRow In dt.Rows
                    row("Chon") = False
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub New(ByVal Bien_lai As Boolean, ByVal abc As Integer, ByVal ID_sv As Integer)
            Try
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Dim dt As DataTable = obj.Load_SinhVien(ID_sv)
                Dim objDanhSachSinhVien As DanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Converting(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_lops As String, ByVal ID_svs As String)
            Try
                If ID_lops = "" Then ID_lops = "0"
                If ID_svs = "" Then ID_svs = "-1"
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Dim dt As DataTable = obj.Load_List_DanhSachSinhVien_NotIn_List(ID_lops, ID_svs)
                Dim objDanhSachSinhVien As DanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Converting(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Property DanhSachSinhVien(ByVal idx As Integer) As DanhSachSinhVien
            Get
                Return CType(arrDanhSach(idx), DanhSachSinhVien)
            End Get
            Set(ByVal Value As DanhSachSinhVien)
                arrDanhSach(idx) = Value
            End Set
        End Property
        Public ReadOnly Property Count() As Integer
            Get
                Return arrDanhSach.Count
            End Get
        End Property
        ' Cập nhật ảnh sinh viên 
        Public Sub UpdateImage(ByVal ID_sv As Integer, ByVal ar() As Byte)
            Try
                Dim obj As New DanhSachSinhVien_DAL
                obj.UpdateImage(ID_sv, ar)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' Cập nhật mat khau sinh viên 
        Public Sub Update_DanhSachSinhVien_QuyenTruyCap(ByVal objDanhSachSinhVien As DanhSachSinhVien)
            Try
                Dim obj As New DanhSachSinhVien_DAL
                obj.Update_DanhSachSinhVien_QuyenTruyCap(objDanhSachSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateNgoaiNganSachArr(ByVal ID_SV As Integer, ByVal Ngoai_ngan_sach As Integer)
            Dim idx As Integer = Tim_idx(ID_SV)

            If idx >= 0 Then
                Dim obj As New DanhSachSinhVien
                obj = CType(arrDanhSach(idx), DanhSachSinhVien)
                obj.Ngoai_ngan_sach = Ngoai_ngan_sach

                Dim objDal As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                objDal.Update_SinhVienNgoaiNganSach(ID_SV, Ngoai_ngan_sach)
            End If
        End Sub

        Private Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSach.Count - 1
                If CType(arrDanhSach(i), DanhSachSinhVien).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Danh_sach_sinh_vien_thitotnghiep(ByVal ID_lops As String) As DataTable
            Try
                Dim clsDAL As New TochucThi_DAL
                Dim dt_duocthitotnghiep As DataTable = clsDAL.Load_ToChucThi_TotNghiep_Load(ID_lops)
                dt_duocthitotnghiep.DefaultView.Sort = "ID_SV"

                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ho_dem", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                dt.Columns.Add("Van_dau", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))

                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    If dt_duocthitotnghiep.DefaultView.Find(ds.ID_sv) >= 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ho_dem") = ds.Ho_dem
                        row("Ten") = ds.Ten
                        row("Van_dau") = ds.Van_dau
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("ID_he") = ds.ID_he
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Quy_che") = ds.Quy_che
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("Khoa_hoc") = ds.Khoa_hoc
                        dt.Rows.Add(row)
                    End If
                Next
                dt.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_lamluanvan(ByVal ID_lops As String) As DataTable
            Try
                Dim clsDAL As New TochucThi_DAL
                Dim dt_lamluanvan As DataTable = clsDAL.Load_ToChucThi_LamLuanVan_Load(ID_lops)
                dt_lamluanvan.DefaultView.Sort = "ID_SV"

                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ho_dem", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                dt.Columns.Add("Van_dau", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    If dt_lamluanvan.DefaultView.Find(ds.ID_sv) >= 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ho_dem") = ds.Ho_dem
                        row("Ten") = ds.Ten
                        row("Van_dau") = ds.Van_dau
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("ID_he") = ds.ID_he
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Quy_che") = ds.Quy_che
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("Khoa_hoc") = ds.Khoa_hoc
                        dt.Rows.Add(row)
                    End If
                Next
                dt.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVien_DuThiChinhTri(ByVal ID_lops As String) As DataTable
            Try
                Dim clsDAL As New TochucThi_DAL
                Dim dt_DSThiChinhTri As DataTable = clsDAL.Load_ToChucThi_ChinhTri(ID_lops)
                dt_DSThiChinhTri.DefaultView.Sort = "ID_SV"

                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ho_dem", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                dt.Columns.Add("Van_dau", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))

                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    If dt_DSThiChinhTri.DefaultView.Find(ds.ID_sv) >= 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ho_dem") = ds.Ho_dem
                        row("Ten") = ds.Ten
                        row("Van_dau") = ds.Van_dau
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("ID_he") = ds.ID_he
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Quy_che") = ds.Quy_che
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("Khoa_hoc") = ds.Khoa_hoc
                        dt.Rows.Add(row)
                    End If
                Next
                dt.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Danh_sach_sinh_vien_in_the_sinh_vien(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As New DanhSachSinhVien_DAL
                Dim Ngay_nhap_hoc, Ngay_ra_truong As String
                Dim dtsv As DataTable = obj.DanhSachSinhVien_LamThe(ID_lops)
                Dim dt As New DataTable
                dt.Columns.Add("Anh", GetType(Byte()))
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Que_quan", GetType(String))
                dt.Columns.Add("Nganh_TS", GetType(String))
                dt.Columns.Add("Xep_loai_tot_nghiep", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Nam_thu", GetType(Integer))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(String))
                dt.Columns.Add("Ngay_ra_truong", GetType(String))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                'dt.Columns.Add("So_the_thu_vien", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    dtsv.DefaultView.RowFilter = "ID_sv=" & ds.ID_sv
                    If dtsv.DefaultView.Count > 0 And dtsv.DefaultView.Item(0)("Anh").length > 0 Then
                        row("Anh") = CType(dtsv.DefaultView.Item(0)("Anh"), Byte())
                    End If
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    row("Nien_khoa") = ds.Nien_khoa
                    row("ID_he") = ds.ID_he
                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                    row("Tong_diem") = ds.Tong_diem
                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                    row("SBD") = ds.SBD
                    row("Quy_che") = ds.Quy_che
                    row("Dia_chi_tt") = ds.Dia_chi_tt
                    row("Que_quan") = ds.Que_quan
                    row("Khoa_hoc") = ds.Khoa_hoc
                    row("Nganh_TS") = ds.Ten_nganh
                    row("Ten_he") = ds.Ten_he
                    row("Chuyen_nganh") = ds.Chuyen_nganh
                    row("Nam_thu") = ds.Nam_thu
                    row("CMND") = ds.CMND
                    row("Ngay_cap") = ds.Ngay_cap
                    row("Noi_cap") = ds.Noi_cap
                    row("Ngay_nhap_hoc") = ds.Ngay_nhap_hoc
                    Try
                        Ngay_nhap_hoc = ds.Nien_khoa.Substring(0, 4)
                        Ngay_ra_truong = ds.Nien_khoa.Substring(5, 4)
                    Catch ex As Exception
                        Ngay_nhap_hoc = ""
                        Ngay_ra_truong = ""
                    End Try
                    'If ds.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = ds.Ngay_nhap_hoc
                    row("Ngay_nhap_hoc") = "09/" & Ngay_nhap_hoc
                    row("Ngay_ra_truong") = "08/" & Ngay_ra_truong
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien() As DataTable
            Try
                Dim dt As New DataTable
                Dim Ngay_nhap_hoc, Ngay_ra_truong As String
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ho_dem", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                dt.Columns.Add("Van_dau", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Nam_thu", GetType(Integer))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(String))
                dt.Columns.Add("Ngay_ra_truong", GetType(String))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Trang_thai_hoc", GetType(Integer))
                dt.Columns.Add("Van_hoa", GetType(Boolean))
                dt.Columns.Add("Trang_thai", GetType(Boolean))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    If ds.Trang_thai_hoc = 1 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ho_dem") = ds.Ho_dem
                        row("Ten") = ds.Ten
                        row("Van_dau") = ds.Van_dau
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("Nam_thu") = ds.Nam_thu
                        row("ID_he") = ds.ID_he
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Quy_che") = ds.Quy_che
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("Khoa_hoc") = ds.Khoa_hoc
                        row("Ten_he") = ds.Ten_he
                        row("Ten_nganh") = ds.Ten_nganh
                        row("Chuyen_nganh") = ds.Chuyen_nganh
                        row("CMND") = ds.CMND
                        row("Trang_thai_hoc") = ds.Trang_thai_hoc
                        If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                        row("Noi_cap") = ds.Noi_cap
                        Try
                            Ngay_nhap_hoc = ds.Nien_khoa.Substring(0, 4)
                            Ngay_ra_truong = ds.Nien_khoa.Substring(5, 4)
                        Catch ex As Exception
                            Ngay_nhap_hoc = ""
                            Ngay_ra_truong = ""
                        End Try
                        'If ds.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = ds.Ngay_nhap_hoc
                        row("Ngay_nhap_hoc") = "09/" & Ngay_nhap_hoc
                        row("Ngay_ra_truong") = "08/" & Ngay_ra_truong
                        row("Van_hoa") = ds.Van_hoa
                        row("Trang_thai") = ds.Trang_thai
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_bang_diem(ByVal ID_lops As String) As DataTable
            Dim cls As New DanhSachSinhVien_DAL
            Dim dt As DataTable = cls.Load_SinhVienBangDiem(ID_lops)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt

            'dt.Columns.Add("Chon", Type.GetType("System.Boolean"))
            'For Each row As DataRow In dt.Rows
            '    row("Chon") = False
            'Next
            'Return dt
            'Try
            '    Dim dt As New DataTable
            '    dt.Columns.Add("Chon", GetType(Boolean))
            '    dt.Columns.Add("ID_sv", GetType(Integer))
            '    dt.Columns.Add("ID_dt", GetType(Integer))
            '    dt.Columns.Add("ID_dt2", GetType(Integer))
            '    dt.Columns.Add("Ma_sv", GetType(String))
            '    dt.Columns.Add("Ho_ten", GetType(String))
            '    dt.Columns.Add("Ngay_sinh", GetType(Date))
            '    dt.Columns.Add("Ten_he", GetType(String))
            '    dt.Columns.Add("Ten_khoa", GetType(String))
            '    dt.Columns.Add("Khoa_hoc", GetType(String))
            '    dt.Columns.Add("Ten_nganh", GetType(String))
            '    dt.Columns.Add("Chuyen_nganh", GetType(String))
            '    dt.Columns.Add("Ten_tinh", GetType(String))
            '    dt.Columns.Add("Ten_lop", GetType(String))
            '    dt.Columns.Add("Nien_khoa", GetType(String))

            '    For i As Integer = 0 To arrDanhSach.Count - 1
            '        Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
            '        Dim row As DataRow = dt.NewRow()
            '        row("Chon") = False
            '        row("ID_sv") = ds.ID_sv
            '        row("ID_dt") = ds.ID_dt1
            '        row("ID_dt2") = ds.ID_dt2
            '        row("Ma_sv") = ds.Ma_sv
            '        row("Ho_ten") = ds.Ho_ten
            '        row("Ngay_sinh") = ds.Ngay_sinh
            '        row("Ten_tinh") = ds.Noi_sinh                    
            '        row("Ten_lop") = ds.Ten_lop
            '        row("Nien_khoa") = ds.Nien_khoa
            '        dt.Rows.Add(row)
            '    Next
            '    Return dt
            'Catch ex As Exception
            '    Throw ex
            'End Try
        End Function

        Public Function Danh_sach_sinh_vien(ByVal dt_SVdatontai As DataTable) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt_SVdatontai.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    If dt_SVdatontai.DefaultView.Find(ds.ID_sv) < 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien(ByVal arrID_sv() As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    For j As Integer = 0 To arrID_sv.Length - 1
                        If ds.ID_sv = arrID_sv(j) Then
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = ds.Ngay_sinh
                            row("ID_lop") = ds.ID_lop
                            row("Ten_lop") = ds.Ten_lop
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên theo một số  ID_sv đã xác định
        Public Function Danh_sach_sinh_vien_can_bo(ByVal arrID_sv As ArrayList) As DataTable
            Try
                Dim obj As New CanBoLop_BLL
                Dim dtCBL As New DataTable
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(String))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_chuc_danh", GetType(Integer))
                dt.Columns.Add("Chuc_danh", GetType(String))
                dt.Columns.Add("Chuc_danh_kiem", GetType(String))
                dt.Columns.Add("Nam_bat_dau", GetType(Integer))
                dt.Columns.Add("Nam_ket_thuc", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    For j As Integer = 0 To arrID_sv.Count - 1
                        Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                        If ds.ID_sv = arrID_sv(j) Then
                            dtCBL = obj.Load_CanBoLop_ListID_svs(ds.ID_sv)
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = Format(ds.Ngay_sinh, "dd/MM/yyyy")
                            row("Gioi_tinh") = ds.Gioi_tinh
                            row("Noi_sinh") = ds.Noi_sinh
                            row("Ten_lop") = ds.Ten_lop
                            If dtCBL.Rows.Count > 0 Then
                                row("ID_chuc_danh") = IIf(IsDBNull(dtCBL.Rows(0).Item("ID_chuc_danh")), 0, dtCBL.Rows(0).Item("ID_chuc_danh"))
                                row("Chuc_danh") = IIf(IsDBNull(dtCBL.Rows(0).Item("Chuc_danh")), "", dtCBL.Rows(0).Item("Chuc_danh"))
                                row("Chuc_danh_kiem") = IIf(IsDBNull(dtCBL.Rows(0).Item("Chuc_danh_kiem")), "", dtCBL.Rows(0).Item("Chuc_danh_kiem"))
                                row("Nam_bat_dau") = IIf(IsDBNull(dtCBL.Rows(0).Item("Nam_bat_dau")), Year(Now), dtCBL.Rows(0).Item("Nam_bat_dau"))
                                row("Nam_ket_thuc") = IIf(IsDBNull(dtCBL.Rows(0).Item("Nam_ket_thuc")), Year(Now), dtCBL.Rows(0).Item("Nam_ket_thuc"))
                            Else
                                row("ID_chuc_danh") = 0
                                row("Chuc_danh") = ""
                                row("Chuc_danh_kiem") = ""
                                row("Nam_bat_dau") = Year(Now)
                                row("Nam_ket_thuc") = Year(Now)
                            End If
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_TruyCap() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Active", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Mat_khau", GetType(String))
                dt.Columns.Add("Mat_khau_NgaySinh", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Active") = ds.Active
                    row("ID_sv") = ds.ID_sv
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = IIf(ds.Ngay_sinh.Year < 1900, System.DBNull.Value, ds.Ngay_sinh)
                    row("ID_lop") = ds.ID_lop
                    row("Mat_khau") = ds.Mat_khau
                    row("Mat_khau_NgaySinh") = getMat_khau(ds.Ngay_sinh)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVien_LamThe(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As New DanhSachSinhVien_DAL
                Dim dt_ds As DataTable = obj.DanhSachSinhVien_LamThe(ID_lops)
                Dim dt As New DataTable
                dt.Columns.Add("Truong")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Dia_chi_tt")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Noi_tru", GetType(Byte))
                dt.Columns.Add("Ngoai_tru", GetType(Byte))
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Nganh_hoc")
                dt.Columns.Add("So_the_thu_vien")
                Dim r As DataRow
                For i As Integer = 0 To dt_ds.Rows.Count - 1
                    r = dt.NewRow
                    'r("Truong") = "HỌC VIỆN NGÂN HÀNG"
                    r("Ho_ten") = dt_ds.Rows(i)("Ho_ten")
                    r("Ngay_sinh") = dt_ds.Rows(i)("Ngay_sinh")
                    r("Dia_chi_tt") = dt_ds.Rows(i)("Dia_chi_tt")
                    r("Ma_sv") = dt_ds.Rows(i)("Ma_sv")
                    If dt_ds.Rows(i)("ID_phong_ktx").ToString <> "" Then r("Noi_tru") = 1
                    If dt_ds.Rows(i)("ID_phong_ktx").ToString = "" Then r("Ngoai_tru") = 1
                    r("Khoa_hoc") = dt_ds.Rows(i)("Khoa_hoc")
                    r("Nganh_hoc") = dt_ds.Rows(i)("Ten_nganh")
                    r("Ten_lop") = dt_ds.Rows(i)("Ten_lop")
                    r("So_the_thu_vien") = ""
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachSinhVien_DuyetTuyen(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As New DanhSachSinhVien_DAL
                Dim dt_ds As DataTable = obj.DanhSachSinhVien_LamThe(ID_lops)
                Dim dt As New DataTable
                dt.Columns.Add("SBD")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh")
                dt.Columns.Add("Nganh_tuyen_sinh")
                dt.Columns.Add("Ten_tinh")
                dt.Columns.Add("Ten_huyen")
                dt.Columns.Add("Ten_dt")
                dt.Columns.Add("Ten_kv")
                dt.Columns.Add("Diem1")
                dt.Columns.Add("Diem2")
                dt.Columns.Add("Diem3")
                dt.Columns.Add("Diem_thuong")
                dt.Columns.Add("Tong_diem")
                Dim r As DataRow
                For i As Integer = 0 To dt_ds.Rows.Count - 1
                    r = dt.NewRow
                    r("SBD") = dt_ds.Rows(i)("SBD")
                    r("Ho_ten") = dt_ds.Rows(i)("Ho_ten")
                    r("Ngay_sinh") = CDate(dt_ds.Rows(i)("Ngay_sinh")).Date
                    r("Gioi_tinh") = dt_ds.Rows(i)("Gioi_tinh")
                    r("Nganh_tuyen_sinh") = dt_ds.Rows(i)("Nganh_tuyen_sinh")
                    r("Ten_tinh") = dt_ds.Rows(i)("Ten_tinh")
                    r("Ten_huyen") = dt_ds.Rows(i)("Ten_huyen")
                    r("Ten_dt") = dt_ds.Rows(i)("Ten_dt")
                    r("Ten_kv") = dt_ds.Rows(i)("Ten_kv")
                    r("Diem1") = dt_ds.Rows(i)("Diem1")
                    r("Diem2") = dt_ds.Rows(i)("Diem2")
                    r("Diem3") = dt_ds.Rows(i)("Diem3")
                    r("Diem_thuong") = dt_ds.Rows(i)("Diem_thuong")
                    r("Tong_diem") = dt_ds.Rows(i)("Tong_diem")
                    dt.Rows.Add(r)
                Next                
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function getMat_khau(ByVal Ngay_sinh As Date) As String
            If Ngay_sinh.Year < 1900 Then Return ""
            Dim Ngay, Thang As String
            Ngay = Ngay_sinh.Day
            Thang = Ngay_sinh.Month
            If Ngay.Length <= 1 Then Ngay = "0" & Ngay
            If Thang.Length <= 1 Then Thang = "0" & Thang
            Return Ngay & Thang & Ngay_sinh.Year
        End Function
        'Tính số sinh viên nam
        Public Function So_sv_nam() As Integer
            Dim So_sv As Integer = 0
            Try
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim objDanhSach As DanhSachSinhVien = arrDanhSach(i)
                    If objDanhSach.ID_gioi_tinh = 0 Then
                        So_sv += 1
                    End If
                Next
                Return So_sv
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function So_sv_nu() As Integer
            Dim So_sv As Integer = 0
            Try
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim objDanhSach As DanhSachSinhVien = arrDanhSach(i)
                    If objDanhSach.ID_gioi_tinh = 1 Then
                        So_sv += 1
                    End If
                Next
                Return So_sv
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachSinhVien(ByVal objDanhSachSinhVien As DanhSachSinhVien) As Integer
            Try
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Return obj.Insert_DanhSachSinhVien(objDanhSachSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachSinhVien(ByVal objDanhSachSinhVien As DanhSachSinhVien, ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Return obj.Update_DanhSachSinhVien(objDanhSachSinhVien, ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_svDanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Return obj.Delete_DanhSachSinhVien(ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanhSachSinhVien As DataRow) As DanhSachSinhVien
            Dim result As DanhSachSinhVien
            Try
                result = New DanhSachSinhVien
                If drDanhSachSinhVien("Trang_thai_hoc").ToString() <> "" Then result.Trang_thai_hoc = CType(drDanhSachSinhVien("Trang_thai_hoc").ToString(), Integer)
                If drDanhSachSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachSinhVien("ID_sv").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachSinhVien("ID_dt").ToString(), Integer)
                If drDanhSachSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSachSinhVien("ID_lop").ToString(), Integer)
                If drDanhSachSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachSinhVien("ID_gioi_tinh").ToString(), Integer)
                result.Mat_khau = drDanhSachSinhVien("Mat_khau").ToString()
                result.Active = drDanhSachSinhVien("Active").ToString()
                result.Quy_che = drDanhSachSinhVien("Quy_che")
                result.Da_tot_nghiep = drDanhSachSinhVien("Da_tot_nghiep").ToString()
                result.Ngoai_ngan_sach = drDanhSachSinhVien("Ngoai_ngan_sach").ToString()
                result.Ten_lop = drDanhSachSinhVien("Ten_lop").ToString()
                result.Ma_sv = drDanhSachSinhVien("Ma_sv").ToString()
                result.Ho_ten = drDanhSachSinhVien("Ho_ten").ToString()
                result.Ho_dem = drDanhSachSinhVien("Ho_dem").ToString()
                result.Ten = drDanhSachSinhVien("Ten").ToString()
                result.Van_dau = drDanhSachSinhVien("Van_dau").ToString()
                If drDanhSachSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachSinhVien("Ngay_sinh").ToString(), Date)
                If drDanhSachSinhVien("Ngay_cap").ToString() <> "" Then result.Ngay_cap = CType(drDanhSachSinhVien("Ngay_cap").ToString(), Date)
                If drDanhSachSinhVien("Ngay_nhap_hoc").ToString() <> "" Then result.Ngay_nhap_hoc = CType(drDanhSachSinhVien("Ngay_nhap_hoc").ToString(), Date)
                result.Gioi_tinh = drDanhSachSinhVien("Gioi_tinh").ToString()
                result.Noi_sinh = drDanhSachSinhVien("Noi_sinh").ToString()
                result.Nien_khoa = drDanhSachSinhVien("Nien_khoa").ToString()
                result.ID_doi_tuong_TC = IIf(drDanhSachSinhVien("ID_doi_tuong_TC").ToString() = "", 0, drDanhSachSinhVien("ID_doi_tuong_TC"))
                result.ID_doi_tuong_TS = IIf(drDanhSachSinhVien("ID_doi_tuong_TS").ToString() = "", 0, drDanhSachSinhVien("ID_doi_tuong_TS"))
                result.Tong_diem = IIf(drDanhSachSinhVien("Tong_diem").ToString() = "", 0, drDanhSachSinhVien("Tong_diem"))
                result.SBD = drDanhSachSinhVien("SBD").ToString()
                result.Dia_chi_tt = drDanhSachSinhVien("Dia_chi_tt").ToString()
                result.Ten_khoa = drDanhSachSinhVien("Ten_khoa").ToString()
                result.Nam_thu = drDanhSachSinhVien("Nam_thu")
                result.Ten_he = drDanhSachSinhVien("Ten_he").ToString
                result.Ten_nganh = drDanhSachSinhVien("Ten_nganh").ToString
                result.Noi_cap = drDanhSachSinhVien("Noi_cap").ToString
                result.CMND = drDanhSachSinhVien("CMND").ToString
                result.Que_quan = drDanhSachSinhVien("Que_quan").ToString
                result.Van_hoa = drDanhSachSinhVien("Van_hoa").ToString
                result.Chuyen_nganh = drDanhSachSinhVien("Chuyen_nganh").ToString
                result.Khoa_hoc = IIf(drDanhSachSinhVien("Khoa_hoc").ToString() = "", 0, drDanhSachSinhVien("Khoa_hoc"))
                result.ID_he = IIf(drDanhSachSinhVien("ID_he").ToString() = "", 0, drDanhSachSinhVien("ID_he"))
                If drDanhSachSinhVien("Trang_thai").ToString() <> "" Then result.Trang_thai = CType(drDanhSachSinhVien("Trang_thai").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

        ' Danh sách sinh viên không qua convert
        Public Function Danh_sach_sinh_vien(ByVal ID_lops As String) As DataTable
            Try
                If ID_lops = "" Then ID_lops = "0"
                Dim obj As DanhSachSinhVien_DAL = New DanhSachSinhVien_DAL
                Dim dt As DataTable = obj.Load_List_DanhSachSinhVien_List(ID_lops)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
