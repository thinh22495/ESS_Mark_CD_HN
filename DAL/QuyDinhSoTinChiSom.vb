'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, July 07, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class QuyDinhSoTinChiSom_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_QuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChiSom_Load", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChiSom_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_QuyDinhSoTinChiSom_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChiSom_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyDinhSoTinChiSom(ByVal obj As QuyDinhSoTinChiSom) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(16) As SqlParameter
                    para(0) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(1) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@So_tin_chi_min_bt", obj.So_tin_chi_min_bt)
                    para(5) = New SqlParameter("@So_tin_chi_max_bt", obj.So_tin_chi_max_bt)
                    para(6) = New SqlParameter("@So_tin_chi_option_bt", obj.So_tin_chi_option_bt)
                    para(7) = New SqlParameter("@Check_so_tin_chi_min_bt", obj.Check_so_tin_chi_min_bt)
                    para(8) = New SqlParameter("@Check_so_tin_chi_max_bt", obj.Check_so_tin_chi_max_bt)
                    para(9) = New SqlParameter("@So_tin_chi_min_yeu", obj.So_tin_chi_min_yeu)
                    para(10) = New SqlParameter("@So_tin_chi_max_yeu", obj.So_tin_chi_max_yeu)
                    para(11) = New SqlParameter("@So_tin_chi_option_yeu", obj.So_tin_chi_option_yeu)
                    para(12) = New SqlParameter("@Check_so_tin_chi_min_yeu", obj.Check_so_tin_chi_min_yeu)
                    para(13) = New SqlParameter("@Check_so_tin_chi_max_yeu", obj.Check_so_tin_chi_max_yeu)
                    para(14) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay) Then
                        para(14).Value = DBNull.Value
                    Else
                        para(14).Value = CDate(obj.Tu_ngay)
                    End If

                    para(15) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay) Then
                        para(15).Value = DBNull.Value
                    Else
                        para(15).Value = CDate(obj.Den_ngay)
                    End If
                    para(16) = New SqlParameter("@id_he", obj.ID_he)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Insert", para)
                Else
                    Dim para(15) As OracleParameter
                    para(0) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(1) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":So_tin_chi_min_bt", obj.So_tin_chi_min_bt)
                    para(5) = New OracleParameter(":So_tin_chi_max_bt", obj.So_tin_chi_max_bt)
                    para(6) = New OracleParameter(":So_tin_chi_option_bt", obj.So_tin_chi_option_bt)
                    para(7) = New OracleParameter(":Check_so_tin_chi_min_bt", obj.Check_so_tin_chi_min_bt)
                    para(8) = New OracleParameter(":Check_so_tin_chi_max_bt", obj.Check_so_tin_chi_max_bt)
                    para(9) = New OracleParameter(":So_tin_chi_min_yeu", obj.So_tin_chi_min_yeu)
                    para(10) = New OracleParameter(":So_tin_chi_max_yeu", obj.So_tin_chi_max_yeu)
                    para(11) = New OracleParameter(":So_tin_chi_option_yeu", obj.So_tin_chi_option_yeu)
                    para(12) = New OracleParameter(":Check_so_tin_chi_min_yeu", obj.Check_so_tin_chi_min_yeu)
                    para(13) = New OracleParameter(":Check_so_tin_chi_max_yeu", obj.Check_so_tin_chi_max_yeu)
                    para(14) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(15) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_QuyDinhSoTinChiSom(ByVal obj As QuyDinhSoTinChiSom) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(16) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", obj.ID_he)
                    para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(4) = New SqlParameter("@So_tin_chi_min_bt", obj.So_tin_chi_min_bt)
                    para(5) = New SqlParameter("@So_tin_chi_max_bt", obj.So_tin_chi_max_bt)
                    para(6) = New SqlParameter("@So_tin_chi_option_bt", obj.So_tin_chi_option_bt)
                    para(7) = New SqlParameter("@Check_so_tin_chi_min_bt", obj.Check_so_tin_chi_min_bt)
                    para(8) = New SqlParameter("@Check_so_tin_chi_max_bt", obj.Check_so_tin_chi_max_bt)
                    para(9) = New SqlParameter("@So_tin_chi_min_yeu", obj.So_tin_chi_min_yeu)
                    para(10) = New SqlParameter("@So_tin_chi_max_yeu", obj.So_tin_chi_max_yeu)
                    para(11) = New SqlParameter("@So_tin_chi_option_yeu", obj.So_tin_chi_option_yeu)
                    para(12) = New SqlParameter("@Check_so_tin_chi_min_yeu", obj.Check_so_tin_chi_min_yeu)
                    para(13) = New SqlParameter("@Check_so_tin_chi_max_yeu", obj.Check_so_tin_chi_max_yeu)
                    para(14) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay) Then
                        para(14).Value = DBNull.Value
                    Else
                        para(14).Value = CDate(obj.Tu_ngay)
                    End If

                    para(15) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay) Then
                        para(15).Value = DBNull.Value
                    Else
                        para(15).Value = CDate(obj.Den_ngay)
                    End If
                    para(16) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Update", para)
                Else
                    Dim para(16) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", obj.ID_he)
                    para(1) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(4) = New OracleParameter(":So_tin_chi_min_bt", obj.So_tin_chi_min_bt)
                    para(5) = New OracleParameter(":So_tin_chi_max_bt", obj.So_tin_chi_max_bt)
                    para(6) = New OracleParameter(":So_tin_chi_option_bt", obj.So_tin_chi_option_bt)
                    para(7) = New OracleParameter(":Check_so_tin_chi_min_bt", obj.Check_so_tin_chi_min_bt)
                    para(8) = New OracleParameter(":Check_so_tin_chi_max_bt", obj.Check_so_tin_chi_max_bt)
                    para(9) = New OracleParameter(":So_tin_chi_min_yeu", obj.So_tin_chi_min_yeu)
                    para(10) = New OracleParameter(":So_tin_chi_max_yeu", obj.So_tin_chi_max_yeu)
                    para(11) = New OracleParameter(":So_tin_chi_option_yeu", obj.So_tin_chi_option_yeu)
                    para(12) = New OracleParameter(":Check_so_tin_chi_min_yeu", obj.Check_so_tin_chi_min_yeu)
                    para(13) = New OracleParameter(":Check_so_tin_chi_max_yeu", obj.Check_so_tin_chi_max_yeu)
                    para(14) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(15) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(16) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_QuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Delete", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChiSom_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    dt = UDB.SelectTableSP("sp_tkbQuyDinhSoTinChiSom_CheckExist", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    dt = UDB.SelectTableSP("sp_tkbQuyDinhSoTinChiSom_CheckExist", para)
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


