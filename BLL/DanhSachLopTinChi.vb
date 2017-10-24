'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class DanhSachLopTinChi_BLL
        Private arrDanhSach As ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal mID_mon_tc As Integer, ByVal mID_lop_tc As Integer)
            Try
                Dim clsLopTC As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Dim dt As DataTable = clsLopTC.Load_DanhSachSinhVienLopTinChi_List(mID_mon_tc, mID_lop_tc)
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
        Public Function Danh_sach_sinh_vien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachLopTinChi(ByVal objDanhSachLopTinChi As DanhSachLopTinChi) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Insert_DanhSachLopTinChi(objDanhSachLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachLopTinChi(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal Duyet As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Update_DanhSachLopTinChi(ID_sv, Ky_dang_ky, Duyet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChi(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Rut_bot_hoc_phan As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Update_LopTinChi(ID_sv, ID_lop_tc, Rut_bot_hoc_phan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChi_Chuyen(ByVal ID_sv As Integer, ByVal ID_lop_tc_tu As Integer, ByVal ID_lop_tc_den As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Update_LopTinChi_Chuyen(ID_sv, ID_lop_tc_tu, ID_lop_tc_den)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachLopTinChi(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Delete_DanhSachLopTinChi(ID_sv, dsKy_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_LopTinChi(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
                Return obj.Delete_LopTinChi(ID_sv, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drDanhSachSinhVien As DataRow) As DanhSachSinhVien
            Dim result As DanhSachSinhVien
            Try
                result = New DanhSachSinhVien
                If drDanhSachSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachSinhVien("ID_sv").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachSinhVien("ID_dt").ToString(), Integer)
                If drDanhSachSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSachSinhVien("ID_lop").ToString(), Integer)
                If drDanhSachSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachSinhVien("ID_gioi_tinh").ToString(), Integer)
                result.Mat_khau = drDanhSachSinhVien("Mat_khau").ToString()
                result.Active = drDanhSachSinhVien("Active").ToString()
                result.Da_tot_nghiep = drDanhSachSinhVien("Da_tot_nghiep").ToString()
                result.Ten_lop = drDanhSachSinhVien("Ten_lop").ToString()
                result.Ma_sv = drDanhSachSinhVien("Ma_sv").ToString()
                result.Ho_ten = drDanhSachSinhVien("Ho_ten").ToString()
                If drDanhSachSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachSinhVien("Ngay_sinh").ToString(), Date)
                result.Gioi_tinh = drDanhSachSinhVien("Gioi_tinh").ToString()
                result.Noi_sinh = drDanhSachSinhVien("Noi_sinh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function ThongTnLopTInChi_Select(ByVal ID_lop_tc As Integer) As DataTable
            Dim clsLopTC As DanhSachSinhVienLopTinChi_DAL = New DanhSachSinhVienLopTinChi_DAL
            Dim dt As DataTable = clsLopTC.ThongTnLopTInChi_Select(ID_lop_tc)
            Return dt
        End Function

        Function DanhSachSinhVien_ToChucThi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As DanhSachSinhVien = CType(arrDanhSach(i), DanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = ds.Ngay_sinh
                    row("Ten_lop") = ds.Ten_lop
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace