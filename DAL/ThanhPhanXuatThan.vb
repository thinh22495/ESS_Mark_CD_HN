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
    Public Class ThanhPhanXuatThan_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"

        Public Function Load_ThanhPhanXuatThan() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_ThanhPhanXuatThan_Load")
                Else
                    Return UDB.SelectTableSP("STU_ThanhPhanXuatThan_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ThanhPhanXuatThan(ByVal obj As ThanhPhanXuatThan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ten_thanh_phan", obj.Ten_thanh_phan)
                    Return UDB.ExecuteSP("STU_ThanhPhanXuatThan_Insert", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ten_thanh_phan", obj.Ten_thanh_phan)
                    Return UDB.ExecuteSP("STU_ThanhPhanXuatThan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ThanhPhanXuatThan(ByVal obj As ThanhPhanXuatThan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_thanh_phan", obj.ID_thanh_phan)
                    para(1) = New SqlParameter("@Ten_thanh_phan", obj.Ten_thanh_phan)
                    Return UDB.ExecuteSP("STU_ThanhPhanXuatThan_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_thanh_phan", obj.ID_thanh_phan)
                    para(1) = New OracleParameter(":Ten_thanh_phan", obj.Ten_thanh_phan)
                    Return UDB.ExecuteSP("STU_ThanhPhanXuatThan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ThanhPhanXuatThan(ByVal obj As ThanhPhanXuatThan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_tinh", obj.ID_thanh_phan)
                    Return UDB.ExecuteSP("STU_Tinh_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_tinh", obj.ID_thanh_phan)
                    Return UDB.ExecuteSP("STU_Tinh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


