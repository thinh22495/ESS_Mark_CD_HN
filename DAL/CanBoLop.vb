'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, May 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class CanBoLop_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_CanBoLop_List(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return UDB.SelectTableSP("STU_CanBoLop_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_CanBoLop(ByVal obj As CanBoLop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Nam_bat_dau", obj.Nam_bat_dau)
                    para(2) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                    para(3) = New SqlParameter("@Chuc_danh_kiem", obj.Chuc_danh_kiem)
                    para(4) = New SqlParameter("@Nam_ket_thuc", obj.Nam_ket_thuc)
                    Return UDB.ExecuteSP("STU_CanBoLop_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Nam_bat_dau", obj.Nam_bat_dau)
                    para(2) = New OracleParameter(":ID_chuc_danh", obj.ID_chuc_danh)
                    para(3) = New OracleParameter(":Chuc_danh_kiem", obj.Chuc_danh_kiem)
                    para(4) = New OracleParameter(":Nam_ket_thuc", obj.Nam_ket_thuc)
                    Return UDB.ExecuteSP("STU_CanBoLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_CanBoLop(ByVal obj As CanBoLop, ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                    para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    para(3) = New SqlParameter("@Chuc_danh_kiem", obj.Chuc_danh_kiem)
                    para(4) = New SqlParameter("@Nam_ket_thuc", obj.Nam_ket_thuc)
                    Return UDB.ExecuteSP("STU_CanBoLop_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Nam_bat_dau", Nam_bat_dau)
                    para(2) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    para(3) = New OracleParameter(":Chuc_danh_kiem", obj.Chuc_danh_kiem)
                    para(4) = New OracleParameter(":Nam_ket_thuc", obj.Nam_ket_thuc)
                    Return UDB.ExecuteSP("STU_CanBoLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_CanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                    para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    Return UDB.ExecuteSP("STU_CanBoLop_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Nam_bat_dau", Nam_bat_dau)
                    para(2) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    Return UDB.ExecuteSP("STU_CanBoLop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_CanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                    para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    If UDB.SelectTableSP("STU_CanBoLop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Nam_bat_dau", Nam_bat_dau)
                    para(2) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    If UDB.SelectTableSP("STU_CanBoLop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


