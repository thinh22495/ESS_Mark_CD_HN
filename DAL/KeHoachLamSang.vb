'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, July 24, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KeHoachLamSang_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachLamSang(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachLamSang_MonHoc(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load_MonHoc", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load_MonHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachLamSang_BoMon(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load_BoMon", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachLamSang_Load_BoMon", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachLamSang(ByVal obj As KeHoachLamSang) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", obj.ID_kh_mon)
                    para(1) = New SqlParameter("@Nhom", obj.Nhom)
                    para(2) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(3) = New SqlParameter("@Tu_tuan", obj.Tu_tuan)
                    para(4) = New SqlParameter("@Den_tuan", obj.Den_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", obj.ID_kh_mon)
                    para(1) = New OracleParameter(":Nhom", obj.Nhom)
                    para(2) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(3) = New OracleParameter(":Tu_tuan", obj.Tu_tuan)
                    para(4) = New OracleParameter(":Den_tuan", obj.Den_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachLamSang(ByVal obj As KeHoachLamSang, ByVal ID_kh_ls As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_ls", ID_kh_ls)
                    para(1) = New SqlParameter("@ID_kh_mon", obj.ID_kh_mon)
                    para(2) = New SqlParameter("@Nhom", obj.Nhom)
                    para(3) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(4) = New SqlParameter("@Tu_tuan", obj.Tu_tuan)
                    para(5) = New SqlParameter("@Den_tuan", obj.Den_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_ls", ID_kh_ls)
                    para(1) = New OracleParameter(":ID_kh_mon", obj.ID_kh_mon)
                    para(2) = New OracleParameter(":Nhom", obj.Nhom)
                    para(3) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(4) = New OracleParameter(":Tu_tuan", obj.Tu_tuan)
                    para(5) = New OracleParameter(":Den_tuan", obj.Den_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachLamSang(ByVal ID_kh_ls As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_ls", ID_kh_ls)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_ls", ID_kh_ls)
                    Return UDB.ExecuteSP("PLAN_KeHoachLamSang_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


