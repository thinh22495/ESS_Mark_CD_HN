'---------------------------------------------------------------------------
' Author : Nguyễn Xuân Vinh
' Company : NamVietJSC
' Created Date : 06/01/2014
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachSinhVienThiTotNghiep_ChinhTri_DAL

        Public Function DanhSachSinhVienThiTotNghiep_TheoKhoa(ByVal Khoa_hoc As Integer, ByVal ID_he As Integer) As DataTable
            Dim para(1) As SqlParameter
            para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
            para(1) = New SqlParameter("@ID_he", ID_he)
            Return UDB.SelectTableSP("Mark_DanhSachSinhVien_ChinhTri_Load_List", para)
        End Function

        Public Function DanhSachSinhVienThiTotNghiep_TheoLop(ByVal ID_lop As Integer) As DataTable
            Dim para(0) As SqlParameter
            para(0) = New SqlParameter("@ID_lop", ID_lop)
            Return UDB.SelectTableSP("Mark_DanhSachSinhVien_ChinhTri_TheoLop_Load_List", para)
        End Function

    End Class
End Namespace
