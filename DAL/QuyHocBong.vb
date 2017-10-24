'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class QuyHocBong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_QuyHocBong_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_QuyHocBong_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_QuyHocBong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyHocBong(ByVal obj As QuyHocBong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_quy", obj.ID_quy)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@Tu_khoa", obj.Tu_khoa)
                    para(5) = New SqlParameter("@Den_khoa", obj.Den_khoa)
                    para(6) = New SqlParameter("@Sotien_ngansach", obj.Sotien_ngansach)
                    para(7) = New SqlParameter("@Sotien_khac", obj.Sotien_khac)
                    para(8) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Insert", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_quy", obj.ID_quy)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":Tu_khoa", obj.Tu_khoa)
                    para(5) = New OracleParameter(":Den_khoa", obj.Den_khoa)
                    para(6) = New OracleParameter(":Sotien_ngansach", obj.Sotien_ngansach)
                    para(7) = New OracleParameter(":Sotien_khac", obj.Sotien_khac)
                    para(8) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyHocBong(ByVal obj As QuyHocBong, ByVal ID_hb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@ID_hb", ID_hb)
                    para(1) = New SqlParameter("@ID_quy", obj.ID_quy)
                    para(2) = New SqlParameter("@ID_he", obj.ID_he)
                    para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(5) = New SqlParameter("@Tu_khoa", obj.Tu_khoa)
                    para(6) = New SqlParameter("@Den_khoa", obj.Den_khoa)
                    para(7) = New SqlParameter("@Sotien_ngansach", obj.Sotien_ngansach)
                    para(8) = New SqlParameter("@Sotien_khac", obj.Sotien_khac)
                    para(9) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Update", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":ID_hb", ID_hb)
                    para(1) = New OracleParameter(":ID_quy", obj.ID_quy)
                    para(2) = New OracleParameter(":ID_he", obj.ID_he)
                    para(3) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(5) = New OracleParameter(":Tu_khoa", obj.Tu_khoa)
                    para(6) = New OracleParameter(":Den_khoa", obj.Den_khoa)
                    para(7) = New OracleParameter(":Sotien_ngansach", obj.Sotien_ngansach)
                    para(8) = New OracleParameter(":Sotien_khac", obj.Sotien_khac)
                    para(9) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBong(ByVal ID_hb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_hb", ID_hb)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_hb", ID_hb)
                    Return UDB.ExecuteSP("STU_QuyHocBong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyHocBong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_quy As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_quy", ID_quy)
                    If UDB.SelectTableSP("STU_QuyHocBong_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_quy", ID_quy)
                    If UDB.SelectTableSP("STU_QuyHocBong_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "Function Loại quỹ học bổng"
        Public Function Load_LoaiQuy_List() As DataTable
            Try
                Return UDB.SelectTableSP("ACC_LoaiQuy_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiQuy(ByVal obj As LoaiQuy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Loai_quy", obj.Loai_quy)
                    para(1) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Loai_quy", obj.Loai_quy)
                    para(1) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiQuy(ByVal obj As LoaiQuy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_quy", obj.ID_quy)
                    para(1) = New SqlParameter("@Loai_quy", obj.Loai_quy)
                    para(2) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_quy", obj.ID_quy)
                    para(1) = New OracleParameter(":Loai_quy", obj.Loai_quy)
                    para(2) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiQuy(ByVal ID_quy As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_quy", ID_quy)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_quy", ID_quy)
                    Return UDB.ExecuteSP("ACC_LoaiQuy_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiQuy(ByVal Loai_quy As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Loai_quy", Loai_quy)
                    If UDB.SelectTableSP("ACC_LoaiQuy_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Loai_quy", Loai_quy)
                    If UDB.SelectTableSP("ACC_LoaiQuy_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region


    End Class
End Namespace


