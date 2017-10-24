'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Thursday, August 28, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class Nganh_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_Nganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_Nganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Nganh(ByVal obj As Nganh) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_nganh", obj.Ma_nganh)
                    para(1) = New SqlParameter("@Ten_nganh", obj.Ten_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_nganh", obj.Ma_nganh)
                    para(1) = New OracleParameter(":Ten_nganh", obj.Ten_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Nganh(ByVal obj As Nganh, ByVal ID_nganh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(1) = New SqlParameter("@Ma_nganh", obj.Ma_nganh)
                    para(2) = New SqlParameter("@Ten_nganh", obj.Ten_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(1) = New OracleParameter(":Ma_nganh", obj.Ma_nganh)
                    para(2) = New OracleParameter(":Ten_nganh", obj.Ten_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Nganh(ByVal ID_nganh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_nganh", ID_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_nganh", ID_nganh)
                    Return UDB.ExecuteSP("sp_STU_Nganh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Nganh(ByVal Ma_nganh As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_nganh", Ma_nganh)
                    dt = UDB.SelectTableSP("sp_STU_Nganh_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_nganh", Ma_nganh)
                    dt = UDB.SelectTableSP("sp_STU_Nganh_CheckExist", para)
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


