'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, April 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class Tinh_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"       

        ' Load Tinh
        Public Function Load_Tinh_List() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then                    
                    Return UDB.SelectTableSP("sp_STU_Tinh_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_STU_Tinh_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Tinh(ByVal obj As Tinh) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ten_tinh", obj.Ten_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Insert", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ten_tinh", obj.Ten_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Tinh(ByVal obj As Tinh, ByVal ID_tinh As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_tinh", ID_tinh)
                    para(1) = New SqlParameter("@Ten_tinh", obj.Ten_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_tinh", ID_tinh)
                    para(1) = New OracleParameter(":Ten_tinh", obj.Ten_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Tinh(ByVal ID_tinh As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_tinh", ID_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_tinh", ID_tinh)
                    Return UDB.ExecuteSP("sp_STU_Tinh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


