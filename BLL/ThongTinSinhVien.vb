Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ThongTinSinhVien_BLL
        Private obj As New ThongTinSinhVien
        Property ThongTinSinhVien() As ThongTinSinhVien
            Get
                Return obj
            End Get
            Set(ByVal value As ThongTinSinhVien)
                obj = value
            End Set
        End Property

#Region "Constructor"
        Sub New(ByVal ID_sv As Integer, Optional ByVal full As Boolean = False)
            Try
                If full Then
                    Dim objPt_dal As New PortalHosoSinhVien_DAL
                    Dim dt As DataTable = objPt_dal.Load_ThongTinSinhVien_Full(ID_sv)
                    ThongTinSinhVien = ConvertingFull(dt.Rows(0))
                Else
                    Dim objPt_dal As New PortalHosoSinhVien_DAL
                    Dim dt As DataTable = objPt_dal.Load_ThongTinSinhVien(ID_sv)
                    ThongTinSinhVien = Converting(dt.Rows(0))
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Login"

#End Region

#Region "Function"
        Private Function ConvertingFull(ByVal drThongTinSinhVien As DataRow) As ThongTinSinhVien
            Dim result As ThongTinSinhVien
            Try
                result = New ThongTinSinhVien
                result.Ma_sv = drThongTinSinhVien("Ma_sv").ToString()
                result.Ho_ten = drThongTinSinhVien("Ho_ten").ToString()
                If drThongTinSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drThongTinSinhVien("Ngay_sinh").ToString(), Date)
                If drThongTinSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drThongTinSinhVien("ID_lop").ToString(), Integer)
                result.Ten_lop = drThongTinSinhVien("Ten_lop").ToString()
                If drThongTinSinhVien("ID_he").ToString() <> "" Then result.ID_he = CType(drThongTinSinhVien("ID_he").ToString(), Integer)
                If drThongTinSinhVien("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drThongTinSinhVien("ID_khoa").ToString(), Integer)
                If drThongTinSinhVien("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drThongTinSinhVien("ID_chuyen_nganh").ToString(), Integer)
                If drThongTinSinhVien("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drThongTinSinhVien("Khoa_hoc").ToString(), Integer)
                result.Nien_khoa = drThongTinSinhVien("Nien_khoa").ToString()
                If drThongTinSinhVien("ID_dt").ToString() <> "" Then result.ID_dt = CType(drThongTinSinhVien("ID_dt").ToString(), Integer)
                result.Ten_he = drThongTinSinhVien("Ten_he").ToString()
                result.Ten_khoa = drThongTinSinhVien("Ten_khoa").ToString()
                If drThongTinSinhVien("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drThongTinSinhVien("ID_nganh").ToString(), Integer)
                result.Chuyen_nganh = drThongTinSinhVien("Chuyen_nganh").ToString()
                result.Ten_nganh = drThongTinSinhVien("Ten_nganh").ToString()
                If drThongTinSinhVien("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drThongTinSinhVien("ID_dt2").ToString(), Integer)
                result.Co_van_hoc_tap = drThongTinSinhVien("Co_van_hoc_tap").ToString()
                If drThongTinSinhVien("Ngoai_ngan_sach").ToString() <> "" Then result.Ngoai_ngan_sach = drThongTinSinhVien("Ngoai_ngan_sach").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Converting(ByVal drThongTinSinhVien As DataRow) As ThongTinSinhVien
            Dim result As ThongTinSinhVien
            Try
                result = New ThongTinSinhVien
                result.Ma_sv = drThongTinSinhVien("ma_sv").ToString()
                result.ho_ten = drThongTinSinhVien("ho_ten").ToString()
                If drThongTinSinhVien("id_lop").ToString() <> "" Then result.ID_lop = CType(drThongTinSinhVien("id_lop").ToString(), Integer)
                If drThongTinSinhVien("id_dt").ToString() <> "" Then result.id_dt = CType(drThongTinSinhVien("id_dt").ToString(), Integer)
                result.ten_lop = drThongTinSinhVien("ten_lop").ToString()
                If drThongTinSinhVien("id_he").ToString() <> "" Then result.id_he = CType(drThongTinSinhVien("id_he").ToString(), Integer)
                If drThongTinSinhVien("id_khoa").ToString() <> "" Then result.id_khoa = CType(drThongTinSinhVien("id_khoa").ToString(), Integer)
                If drThongTinSinhVien("khoa_hoc").ToString() <> "" Then result.khoa_hoc = CType(drThongTinSinhVien("khoa_hoc").ToString(), Integer)
                If drThongTinSinhVien("id_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drThongTinSinhVien("id_chuyen_nganh").ToString(), Integer)
                If drThongTinSinhVien("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drThongTinSinhVien("ID_nganh").ToString(), Integer)
                result.Ten_he = drThongTinSinhVien("Ten_he").ToString()
                result.Ten_khoa = drThongTinSinhVien("Ten_khoa").ToString()
                result.chuyen_nganh = drThongTinSinhVien("chuyen_nganh").ToString()
                result.ten_nganh = drThongTinSinhVien("ten_nganh").ToString()
                If drThongTinSinhVien("id_dt2").ToString() <> "" Then result.ID_dt2 = CType(drThongTinSinhVien("id_dt2").ToString(), Integer)
                result.Co_van_hoc_tap = drThongTinSinhVien("Co_van_hoc_tap").ToString() & " (ĐT: " & drThongTinSinhVien("Dien_thoai").ToString() & "; Email: " & drThongTinSinhVien("Email").ToString() & ")"
                result.Noi_sinh = drThongTinSinhVien("Noi_sinh").ToString()
                result.Gioi_tinh = drThongTinSinhVien("Gioi_tinh").ToString()
                If drThongTinSinhVien("Ngoai_ngan_sach").ToString() <> "" Then result.Ngoai_ngan_sach = drThongTinSinhVien("Ngoai_ngan_sach").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace

