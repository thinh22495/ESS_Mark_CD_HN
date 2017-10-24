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
    Public Class ThongKeSoLieuDuBao_DAL
        Public Function SoSinhVienHoc_TCDT_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh1", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh1", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DaTichLuy_Nganh1(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh1", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(4) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh1", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVienHoc_TCDT_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh2", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh2", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DaTichLuy_Nganh2(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh2", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(4) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh2", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DangKySom_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh1", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh1", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DangKySom_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh2", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh2", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

