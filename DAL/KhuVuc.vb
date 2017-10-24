'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class KhuVuc_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        ' Load Tinh
        Public Function Load_KhuVuc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_STU_KhuVuc_Load")
                Else
                    Return UDB.SelectTableSP("sp_STU_KhuVuc_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function        
        Public Function Insert_KhuVuc(ByVal obj As KhuVuc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_kv", obj.Ma_kv)
                    para(1) = New SqlParameter("@Ten_kv", obj.Ten_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_kv", obj.Ma_kv)
                    para(1) = New OracleParameter(":Ten_kv", obj.Ten_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhuVuc(ByVal obj As KhuVuc, ByVal ID_kv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kv", ID_kv)
                    para(1) = New SqlParameter("@Ma_kv", obj.Ma_kv)
                    para(2) = New SqlParameter("@Ten_kv", obj.Ten_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kv", ID_kv)
                    para(1) = New OracleParameter(":Ma_kv", obj.Ma_kv)
                    para(2) = New OracleParameter(":Ten_kv", obj.Ten_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhuVuc(ByVal ID_kv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kv", ID_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kv", ID_kv)
                    Return UDB.ExecuteSP("sp_STU_KhuVuc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


