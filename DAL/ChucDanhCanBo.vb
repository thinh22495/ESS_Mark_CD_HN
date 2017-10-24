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
    Public Class ChucDanhCanBo_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ChucDanhCanBo(ByVal ID_chuc_danh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    Return UDB.SelectTableSP("PLAN_ChucDanh_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    Return UDB.SelectTableSP("PLAN_ChucDanh_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChucDanhCanBo_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_ChucDanh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChucDanhCanBo(ByVal obj As ChucDanhCanBo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_chuc_danh", obj.Ma_chuc_danh)
                    para(1) = New SqlParameter("@Chuc_danh", obj.Chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_chuc_danh", obj.Ma_chuc_danh)
                    para(1) = New OracleParameter(":Chuc_danh", obj.Chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChucDanhCanBo(ByVal obj As ChucDanhCanBo, ByVal ID_chuc_danh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    para(1) = New SqlParameter("@Ma_chuc_danh", obj.Ma_chuc_danh)
                    para(2) = New SqlParameter("@Chuc_danh", obj.Chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    para(1) = New OracleParameter(":Ma_chuc_danh", obj.Ma_chuc_danh)
                    para(2) = New OracleParameter(":Chuc_danh", obj.Chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChucDanhCanBo(ByVal ID_chuc_danh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuc_danh", ID_chuc_danh)
                    Return UDB.ExecuteSP("PLAN_ChucDanh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


