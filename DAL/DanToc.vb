'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class DanToc_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanToc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_STU_DanToc_Load")
                Else
                    Return UDB.SelectTableSP("sp_STU_DanToc_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function        
        Public Function Insert_DanToc(ByVal obj As DanToc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dan_toc", obj.Ma_dan_toc)
                    para(1) = New SqlParameter("@Dan_toc", obj.Dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dan_toc", obj.Ma_dan_toc)
                    para(1) = New OracleParameter(":Dan_toc", obj.Dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanToc(ByVal obj As DanToc, ByVal ID_dan_toc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_dan_toc", ID_dan_toc)
                    para(1) = New SqlParameter("@Ma_dan_toc", obj.Ma_dan_toc)
                    para(2) = New SqlParameter("@Dan_toc", obj.Dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_dan_toc", ID_dan_toc)
                    para(1) = New OracleParameter(":Ma_dan_toc", obj.Ma_dan_toc)
                    para(2) = New OracleParameter(":Dan_toc", obj.Dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanToc(ByVal ID_dan_toc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dan_toc", ID_dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dan_toc", ID_dan_toc)
                    Return UDB.ExecuteSP("sp_STU_DanToc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


