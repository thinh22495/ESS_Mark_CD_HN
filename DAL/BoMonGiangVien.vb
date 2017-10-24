'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, June 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class BoMonGiangVien_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_BoMonGiangVien(ByVal obj As BoMonGiangVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(1) = New SqlParameter("@ID_bm", obj.ID_bm)
                    Return UDB.ExecuteSP("PLAN_BoMonGiangVien_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(1) = New OracleParameter(":ID_bm", obj.ID_bm)
                    Return UDB.ExecuteSP("PLAN_BoMonGiangVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", ID_bm)
                    para(1) = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_BoMonGiangVien_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", ID_bm)
                    para(1) = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_BoMonGiangVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_GiangVien(ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_BoMonGiangVien_Load_GiangVien", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_BoMonGiangVien_Load_GiangVien", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BoMon(ByVal ID_cb As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_BoMonGiangVien_Load_BoMon", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_BoMonGiangVien_Load_BoMon", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", ID_bm)
                    para(1) = New SqlParameter("@ID_cb", ID_cb)
                    dt = UDB.SelectTableSP("PLAN_BoMonGiangVien_CheckExist", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", ID_bm)
                    para(1) = New OracleParameter(":ID_cb", ID_cb)
                    dt = UDB.SelectTableSP("PLAN_BoMonGiangVien_CheckExist", para)
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


