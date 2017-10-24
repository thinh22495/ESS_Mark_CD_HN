'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Wednesday, June 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class BoMonMonHoc_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_BoMonMonHoc(ByVal obj As BoMonMonHoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                    Return UDB.ExecuteSP("sp_PLAN_BoMonMonHoc_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(1) = New OracleParameter(":ID_mon", obj.ID_mon)
                    Return UDB.ExecuteSP("sp_PLAN_BoMonGiangVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BoMonMonHoc(ByVal ID_bm As Integer, ByVal ID_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", ID_bm)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.ExecuteSP("sp_PLAN_BoMonMonHoc_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", ID_bm)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.ExecuteSP("sp_PLAN_BoMonMonHoc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BoMonMonHoc(ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("sp_PLAN_BoMonMonHoc_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("sp_PLAN_BoMonMonHoc_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonMonHoc(ByVal ID_bm As Integer, ByVal ID_mon As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", ID_bm)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    dt = UDB.SelectTableSP("sp_PLAN_BoMonMonHoc_CheckExist", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", ID_bm)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    dt = UDB.SelectTableSP("sp_PLAN_BoMonMonHoc_CheckExist", para)
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


