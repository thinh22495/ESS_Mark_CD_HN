'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 09, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class GiangVienMonDay_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_GiangVienMonDay(ByVal ID_cb As Integer, Optional ByVal ID_bm As Integer = 0, Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@ID_bm", ID_bm)
                    para(2) = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_GiaoVienMonDay_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", ID_mon)
                    para(1) = New OracleParameter(":ID_bm", ID_bm)
                    para(2) = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_GiaoVienMonDay_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_GiangVienMonDay(ByVal obj As GiangVienMonDay) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(1) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(2) = New SqlParameter("@ID_cb", obj.ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVienMonDay_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(1) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(2) = New OracleParameter(":ID_cb", obj.ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVienMonDay_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_cb", ID_cb)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.ExecuteSP("PLAN_GiaoVienMonDay_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_cb", ID_cb)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.ExecuteSP("PLAN_GiaoVienMonDay_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_cb", ID_cb)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_bm", ID_bm)
                    dt = UDB.SelectTableSP("PLAN_GiaoVienMonDay_CheckExist", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_cb", ID_cb)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_bm", ID_bm)
                    dt = UDB.SelectTableSP("PLAN_GiaoVienMonDay_CheckExist", para)
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
#End Region

    End Class
End Namespace


