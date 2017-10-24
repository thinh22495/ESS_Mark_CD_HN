'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Friday, August 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class CoSoDaoTao_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_CoSoDaoTao_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_PLAN_CoSoDaoTao_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_CoSoDaoTao(ByVal obj As CoSoDaoTao) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_co_so", obj.Ma_co_so)
                    para(1) = New SqlParameter("@Ten_co_so", obj.Ten_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_co_so", obj.Ma_co_so)
                    para(1) = New OracleParameter(":Ten_co_so", obj.Ten_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_CoSoDaoTao(ByVal obj As CoSoDaoTao, ByVal ID_co_so As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_co_so", ID_co_so)
                    para(1) = New SqlParameter("@Ma_co_so", obj.Ma_co_so)
                    para(2) = New SqlParameter("@Ten_co_so", obj.Ten_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_co_so", ID_co_so)
                    para(1) = New OracleParameter(":Ma_co_so", obj.Ma_co_so)
                    para(2) = New OracleParameter(":Ten_co_so", obj.Ten_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_CoSoDaoTao(ByVal ID_co_so As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_co_so", ID_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_co_so", ID_co_so)
                    Return UDB.ExecuteSP("sp_PLAN_CoSoDaoTao_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_CoSoDaoTao(ByVal Ma_co_so As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_co_so", Ma_co_so)
                    dt = UDB.SelectTableSP("sp_PLAN_CoSoDaoTao_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_co_so", Ma_co_so)
                    dt = UDB.SelectTableSP("sp_PLAN_CoSoDaoTao_CheckExist", para)
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


