'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class NhomDoiTuong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_NhomDoiTuong() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_NhomDoiTuong_Load")
                Else
                    Return UDB.SelectTableSP("STU_NhomDoiTuong_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NhomDoiTuong(ByVal ID_nhom_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                    Return UDB.SelectTableSP("STU_NhomDoiTuong_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_nhom_dt", ID_nhom_dt)
                    Return UDB.SelectTableSP("STU_NhomDoiTuong_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NhomDoiTuong(ByVal obj As NhomDoiTuong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_nhom", obj.Ma_nhom)
                    para(1) = New SqlParameter("@Ten_nhom", obj.Ten_nhom)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_nhom", obj.Ma_nhom)
                    para(1) = New OracleParameter(":Ten_nhom", obj.Ten_nhom)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NhomDoiTuong(ByVal obj As NhomDoiTuong, ByVal ID_nhom_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                    para(1) = New SqlParameter("@Ma_nhom", obj.Ma_nhom)
                    para(2) = New SqlParameter("@Ten_nhom", obj.Ten_nhom)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_nhom_dt", ID_nhom_dt)
                    para(1) = New OracleParameter(":Ma_nhom", obj.Ma_nhom)
                    para(2) = New OracleParameter(":Ten_nhom", obj.Ten_nhom)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NhomDoiTuong(ByVal ID_nhom_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_nhom_dt", ID_nhom_dt)
                    Return UDB.ExecuteSP("STU_NhomDoiTuong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


