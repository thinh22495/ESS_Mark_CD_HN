'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, December 27, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KeHoachKhac_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachKhac(ByVal ID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    Return UDB.SelectTableSP("PLAN_KeHoachKhac_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    Return UDB.SelectTableSP("PLAN_KeHoachKhac_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachKhac_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachKhac_Load_List1")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachKhac_ThongBao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("PLAN_KeHoachKhac_ThongBao_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("PLAN_KeHoachKhac_ThongBao_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachKhac(ByVal obj As KeHoachKhac) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(10) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", obj.ID_he)
                    para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(4) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(5) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(7) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(8) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(9) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(10) = New SqlParameter("@Hien_thi", obj.Hien_thi)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Insert", para)
                Else
                    Dim para(10) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", obj.ID_he)
                    para(3) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(4) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(5) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(7) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(8) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(9) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(10) = New OracleParameter(":Hien_thi", obj.Hien_thi)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachKhac(ByVal obj As KeHoachKhac, ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(11) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_he", obj.ID_he)
                    para(4) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(5) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(6) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(7) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(8) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(9) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(10) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(11) = New SqlParameter("@Hien_thi", obj.Hien_thi)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Update", para)
                Else
                    Dim para(11) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_he", obj.ID_he)
                    para(4) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(5) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(6) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(7) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(8) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(9) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(10) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(11) = New OracleParameter(":Hien_thi", obj.Hien_thi)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachKhac(ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID", ID)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID", ID)
                    Return UDB.ExecuteSP("PLAN_KeHoachKhac_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KeHoachKhac(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal id_he As Integer, ByVal ky_hieu As String, ByVal tu_ngay As Date, ByVal den_ngay As Date) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@id_he", id_he)
                    para(3) = New SqlParameter("@ky_hieu", ky_hieu)
                    para(4) = New SqlParameter("@Tu_ngay", tu_ngay.Date)
                    para(5) = New SqlParameter("@Den_ngay", den_ngay.Date)
                    dt = UDB.SelectTableSP("PLAN_KeHoachKhac_CheckExist", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":id_he", id_he)
                    para(3) = New OracleParameter(":ky_hieu", ky_hieu)
                    para(4) = New OracleParameter(":Tu_ngay", tu_ngay)
                    para(5) = New OracleParameter(":Den_ngay", den_ngay)
                    dt = UDB.SelectTableSP("PLAN_KeHoachKhac_CheckExist", para)
                End If
                If dt.Rows.Count = 0 Then
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


