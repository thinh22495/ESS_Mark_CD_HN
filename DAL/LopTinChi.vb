'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class LopTinChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_LopTinChi_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_LopTinChi_List(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_LopTinChi_List_TKB(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_TKB_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_TKB_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_LopSinhVienDangKyTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_tkbThongKeSinhVienDangKy_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_tkbThongKeSinhVienDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ThongKeSTU_LopTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_tkbThongKeSTU_LopTinChi_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_tkbThongKeSTU_LopTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ThongKeSinhVienDangKyTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_svMonDangKyTinChiDanhSachSinhVien_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_svMonDangKyTinChiDanhSachSinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub Update_HuyLopTinChi(ByVal ID_lop_tc As Integer, ByVal HuyLop As Integer, ByVal Ly_do As String)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@HuyLop", HuyLop)
                    para(2) = New SqlParameter("@Ly_do", Ly_do)
                    UDB.ExecuteSP("sp_tkbLopTinChiHuyLop_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":HuyLop", HuyLop)
                    para(2) = New OracleParameter(":Ly_do", Ly_do)
                    UDB.ExecuteSP("sp_tkbLopTinChiHuyLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update_HuyDangKySV(ByVal ID_lop_tc As Integer, ByVal ID_sv As Integer, ByVal Ly_do As String)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@Ly_do", Ly_do)
                    UDB.ExecuteSP("sp_tkbLopTinChiSinhVienHuyDangKy_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":Ly_do", Ly_do)
                    UDB.ExecuteSP("sp_tkbLopTinChiSinhVienHuyDangKy_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function SuKiensLopTinChi(ByVal ID_lop_tc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_Lop", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_Lop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


