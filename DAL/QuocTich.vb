'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, April 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class QuocTich_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_QuocTich() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_STU_QuocTich_Load")
                Else
                    Return UDB.SelectTableSP("sp_STU_QuocTich_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuocTich(ByVal obj As QuocTich) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_quoc_tich", obj.Ma_quoc_tich)
                    para(1) = New SqlParameter("@Quoc_tich", obj.Quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_quoc_tich", obj.Ma_quoc_tich)
                    para(1) = New OracleParameter(":Quoc_tich", obj.Quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuocTich(ByVal obj As QuocTich) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(1) = New SqlParameter("@Ma_quoc_tich", obj.Ma_quoc_tich)
                    para(2) = New SqlParameter("@Quoc_tich", obj.Quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(1) = New OracleParameter(":Ma_quoc_tich", obj.Ma_quoc_tich)
                    para(2) = New OracleParameter(":Quoc_tich", obj.Quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuocTich(ByVal ID_quoc_tich As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_quoc_tich", ID_quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_quoc_tich", ID_quoc_tich)
                    Return UDB.ExecuteSP("sp_STU_QuocTich_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


