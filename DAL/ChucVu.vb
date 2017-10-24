'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ChucVu_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ChucVu(ByVal ID_chuc_vu As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                    Return UDB.SelectTableSP("PLAN_ChucVu_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuc_vu", ID_chuc_vu)
                    Return UDB.SelectTableSP("PLAN_ChucVu_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChucVu_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_ChucVu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChucVu(ByVal obj As ChucVu) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_chuc_vu", obj.Ma_chuc_vu)
                    para(1) = New SqlParameter("@Chuc_vu", obj.Chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_chuc_vu", obj.Ma_chuc_vu)
                    para(1) = New OracleParameter(":Chuc_vu", obj.Chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChucVu(ByVal obj As ChucVu, ByVal ID_chuc_vu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                    para(1) = New SqlParameter("@Ma_chuc_vu", obj.Ma_chuc_vu)
                    para(2) = New SqlParameter("@Chuc_vu", obj.Chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuc_vu", ID_chuc_vu)
                    para(1) = New OracleParameter(":Ma_chuc_vu", obj.Ma_chuc_vu)
                    para(2) = New OracleParameter(":Chuc_vu", obj.Chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChucVu(ByVal ID_chuc_vu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_chuc_vu", ID_chuc_vu)
                    Return UDB.ExecuteSP("PLAN_ChucVu_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChucVu(ByVal Ma_chuc_vu As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_chuc_vu", Ma_chuc_vu)
                    dt = UDB.SelectTableSP("PLAN_ChucVu_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_chuc_vu", Ma_chuc_vu)
                    dt = UDB.SelectTableSP("PLAN_ChucVu_CheckExist", para)
                End If
                If dt.Rows.Count = 0 Then
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


