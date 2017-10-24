'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, July 08, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class He_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_He_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_He_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_He(ByVal obj As He) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_he", obj.Ma_he)
                    para(1) = New SqlParameter("@Ten_he", obj.Ten_he)
                    Return UDB.ExecuteSP("STU_He_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_he", obj.Ma_he)
                    para(1) = New OracleParameter(":Ten_he", obj.Ten_he)
                    Return UDB.ExecuteSP("STU_He_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_He(ByVal obj As He, ByVal ID_he As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Ma_he", obj.Ma_he)
                    para(2) = New SqlParameter("@Ten_he", obj.Ten_he)
                    Return UDB.ExecuteSP("STU_He_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Ma_he", obj.Ma_he)
                    para(2) = New OracleParameter(":Ten_he", obj.Ten_he)
                    Return UDB.ExecuteSP("STU_He_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_He(ByVal ID_he As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_he", ID_he)
                    Return UDB.ExecuteSP("STU_He_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_he", ID_he)
                    Return UDB.ExecuteSP("STU_He_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_He(ByVal Ma_he As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_he", Ma_he)
                    dt = UDB.SelectTableSP("STU_He_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_he", Ma_he)
                    dt = UDB.SelectTableSP("STU_He_CheckExist", para)
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


