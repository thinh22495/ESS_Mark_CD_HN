'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhHieu_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhHieu_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DanhHieu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhHieu(ByVal obj As DanhHieu) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Danh_hieu", obj.Danh_hieu)
                    para(1) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                    para(2) = New SqlParameter("@Den_diem", obj.Den_diem)
                    Return UDB.ExecuteSP("STU_DanhHieu_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Danh_hieu", obj.Danh_hieu)
                    para(1) = New OracleParameter(":Tu_diem", obj.Tu_diem)
                    para(2) = New OracleParameter(":Den_diem", obj.Den_diem)
                    Return UDB.ExecuteSP("STU_DanhHieu_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhHieu(ByVal obj As DanhHieu, ByVal ID_danh_hieu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_danh_hieu", ID_danh_hieu)
                    para(1) = New SqlParameter("@Danh_hieu", obj.Danh_hieu)
                    para(2) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                    para(3) = New SqlParameter("@Den_diem", obj.Den_diem)
                    Return UDB.ExecuteSP("STU_DanhHieu_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_danh_hieu", ID_danh_hieu)
                    para(1) = New OracleParameter(":Danh_hieu", obj.Danh_hieu)
                    para(2) = New OracleParameter(":Tu_diem", obj.Tu_diem)
                    para(3) = New OracleParameter(":Den_diem", obj.Den_diem)
                    Return UDB.ExecuteSP("STU_DanhHieu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhHieu(ByVal ID_danh_hieu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_danh_hieu", ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieu_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_danh_hieu", ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieu_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


