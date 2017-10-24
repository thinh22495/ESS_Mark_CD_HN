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
    Public Class Khoa_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_Khoa_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_Khoa_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Khoa(ByVal obj As Khoa) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_khoa", obj.Ma_khoa)
                    para(1) = New SqlParameter("@Ten_khoa", obj.Ten_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_khoa", obj.Ma_khoa)
                    para(1) = New OracleParameter(":Ten_khoa", obj.Ten_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Khoa(ByVal obj As Khoa, ByVal ID_khoa As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(1) = New SqlParameter("@Ma_khoa", obj.Ma_khoa)
                    para(2) = New SqlParameter("@Ten_khoa", obj.Ten_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(1) = New OracleParameter(":Ma_khoa", obj.Ma_khoa)
                    para(2) = New OracleParameter(":Ten_khoa", obj.Ten_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Khoa(ByVal ID_khoa As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_khoa", ID_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_khoa", ID_khoa)
                    Return UDB.ExecuteSP("STU_Khoa_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Khoa(ByVal Ma_khoa As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_khoa", Ma_khoa)
                    dt = UDB.SelectTableSP("STU_Khoa_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_khoa", Ma_khoa)
                    dt = UDB.SelectTableSP("STU_Khoa_CheckExist", para)
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


