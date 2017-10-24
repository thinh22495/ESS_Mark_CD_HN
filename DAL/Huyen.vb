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
    Public Class Huyen_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_Huyen() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_STU_Huyen_Load")
                Else
                    Return UDB.SelectTableSP("sp_STU_Huyen_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Huyen(ByVal obj As Huyen) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_tinh", obj.ID_tinh)
                    para(1) = New SqlParameter("@Ten_huyen", obj.Ten_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_tinh", obj.ID_tinh)
                    para(1) = New OracleParameter(":Ten_huyen", obj.Ten_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Huyen(ByVal obj As Huyen, ByVal ID_huyen As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_huyen", ID_huyen)
                    para(1) = New SqlParameter("@ID_tinh", obj.ID_tinh)
                    para(2) = New SqlParameter("@Ten_huyen", obj.Ten_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_huyen", ID_huyen)
                    para(1) = New OracleParameter(":ID_tinh", obj.ID_tinh)
                    para(2) = New OracleParameter(":Ten_huyen", obj.Ten_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Huyen(ByVal ID_huyen As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_huyen", ID_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_huyen", ID_huyen)
                    Return UDB.ExecuteSP("sp_STU_Huyen_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


