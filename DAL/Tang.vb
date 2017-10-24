'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class Tang_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_Tang_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_Tang_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Tang(ByVal obj As Tang) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_tang", obj.Ma_tang)
                    para(1) = New SqlParameter("@Ten_tang", obj.Ten_tang)
                    Return UDB.ExecuteSP("PLAN_Tang_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_tang", obj.Ma_tang)
                    para(1) = New OracleParameter(":Ten_tang", obj.Ten_tang)
                    Return UDB.ExecuteSP("PLAN_Tang_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Tang(ByVal obj As Tang, ByVal ID_TANG As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_TANG", ID_TANG)
                    para(1) = New SqlParameter("@Ma_tang", obj.Ma_tang)
                    para(2) = New SqlParameter("@Ten_tang", obj.Ten_tang)
                    Return UDB.ExecuteSP("PLAN_Tang_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_TANG", ID_TANG)
                    para(1) = New OracleParameter(":Ma_tang", obj.Ma_tang)
                    para(2) = New OracleParameter(":Ten_tang", obj.Ten_tang)
                    Return UDB.ExecuteSP("PLAN_Tang_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Tang(ByVal ID_TANG As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_TANG", ID_TANG)
                    Return UDB.ExecuteSP("PLAN_Tang_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_TANG", ID_TANG)
                    Return UDB.ExecuteSP("PLAN_Tang_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Tang(ByVal Ma_TANG As Integer) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_TANG", Ma_TANG)
                    dt = UDB.SelectTableSP("PLAN_Tang_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_TANG", Ma_TANG)
                    dt = UDB.SelectTableSP("PLAN_Tang_CheckExist", para)
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


