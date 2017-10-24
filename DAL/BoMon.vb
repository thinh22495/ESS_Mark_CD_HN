'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 03, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class BoMon_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_BoMon(ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_BoMon_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_BoMon_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BoMon_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_BoMon_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_BoMon(ByVal obj As BoMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ma_bo_mon", obj.Ma_bo_mon)
                    para(1) = New SqlParameter("@Bo_mon", obj.Bo_mon)
                    para(2) = New SqlParameter("@So_nhom", obj.So_nhom)
                    Return UDB.ExecuteSP("PLAN_BoMon_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ma_bo_mon", obj.Ma_bo_mon)
                    para(1) = New OracleParameter(":Bo_mon", obj.Bo_mon)
                    para(2) = New OracleParameter(":So_nhom", obj.So_nhom)
                    Return UDB.ExecuteSP("PLAN_BoMon_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BoMon(ByVal obj As BoMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(1) = New SqlParameter("@Ma_bo_mon", obj.Ma_bo_mon)
                    para(2) = New SqlParameter("@Bo_mon", obj.Bo_mon)
                    para(3) = New SqlParameter("@So_nhom", obj.So_nhom)
                    Return UDB.ExecuteSP("PLAN_BoMon_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(1) = New OracleParameter(":Ma_bo_mon", obj.Ma_bo_mon)
                    para(2) = New OracleParameter(":Bo_mon", obj.Bo_mon)
                    para(3) = New OracleParameter(":So_nhom", obj.So_nhom)
                    Return UDB.ExecuteSP("PLAN_BoMon_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BoMon(ByVal ID_bm As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.ExecuteSP("PLAN_BoMon_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.ExecuteSP("PLAN_BoMon_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMon(ByVal ID_bm As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    dt = UDB.SelectTableSP("PLAN_BoMon_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    dt = UDB.SelectTableSP("PLAN_BoMon_CheckExist", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMon(ByVal Ma_bo_mon As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_bo_mon", Ma_bo_mon)
                    dt = UDB.SelectTableSP("PLAN_BoMon_CheckExist_MaBoMon", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_bo_mon", Ma_bo_mon)
                    dt = UDB.SelectTableSP("PLAN_BoMon_CheckExist_MaBoMon", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_BoMon(ByVal ID_bm As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.ExecuteScalar("PLAN_BoMon_GetMaxID", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.ExecuteScalar("PLAN_BoMon_GetMaxID", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


