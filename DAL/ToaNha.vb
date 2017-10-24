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
    Public Class ToaNha_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ToaNha_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_ToaNha_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ToaNha(ByVal obj As ToaNha) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                    para(1) = New SqlParameter("@Ma_nha", obj.Ma_nha)
                    para(2) = New SqlParameter("@Ten_nha", obj.Ten_nha)
                    Return UDB.ExecuteSP("PLAN_ToaNha_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_co_so", obj.ID_co_so)
                    para(1) = New OracleParameter(":Ma_nha", obj.Ma_nha)
                    para(2) = New OracleParameter(":Ten_nha", obj.Ten_nha)
                    Return UDB.ExecuteSP("PLAN_ToaNha_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ToaNha(ByVal ID_nha As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_nha", ID_nha)
                    Return UDB.ExecuteSP("PLAN_ToaNha_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_nha", ID_nha)
                    Return UDB.ExecuteSP("PLAN_ToaNha_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


