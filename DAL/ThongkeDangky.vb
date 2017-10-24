'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ThongkeDangky_DAL
        Public Function ThongkeSinhvienDangkyTheoLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    para(7) = New SqlParameter("@Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoLop", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    para(7) = New OracleParameter(":Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoLop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienDangkyTheoHocPhan(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoHocphan", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoHocphan", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienChuaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    para(7) = New SqlParameter("@Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienChuaDangky", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    para(7) = New OracleParameter(":Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienChuaDangky", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienDaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New SqlParameter("@ID_lops", ID_lops)
                    para(7) = New SqlParameter("@Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDaDangky", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(6) = New OracleParameter(":ID_lops", ID_lops)
                    para(7) = New OracleParameter(":Dot", Dot)
                    Return UDB.SelectTableSP("PLAN_ThongkeSinhvienDaDangky", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


