'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, August 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HocKyDangKy_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_HocKyDangKy_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_HocKyDangKy_Load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_HocKyDangKy(ByVal obj As HocKyDangKy) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Dot", obj.Dot)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_HocKyDangKy_CheckExist", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Dot", obj.Dot)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_HocKyDangKy_CheckExist", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_HocKyDangKy(ByVal obj As HocKyDangKy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Dot", obj.Dot)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(4) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Dot", obj.Dot)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(4) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocKyDangKy(ByVal obj As HocKyDangKy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Dot", obj.Dot)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(4) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Dot", obj.Dot)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(4) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocKyDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("PLAN_HocKyDangKy_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_HocKyDangKy_DaTonTai(ByVal obj As HocKyDangKy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Dot", obj.Dot)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("PLAN_KyDangKy_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Dot", obj.Dot)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("PLAN_KyDangKy_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_HocKyDangKy_TonTai(ByVal obj As HocKyDangKy) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Dot", obj.Dot)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_CheckMonTinChiTonTai_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Dot", obj.Dot)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_CheckMonTinChiTonTai_Load_List", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


