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
    Public Class QuyDinhSoTinChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_Load", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_QuyDinhSoTinChi_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyDinhSoTinChi(ByVal obj As QuyDinhSoTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(17) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", obj.ID_he)
                    para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
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
                    para(14) = New SqlParameter("@Tu_ngay1", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay1) Then
                        para(14).Value = DBNull.Value
                    Else
                        para(14).Value = CDate(obj.Tu_ngay1)
                    End If

                    para(15) = New SqlParameter("@Den_ngay1", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay1) Then
                        para(15).Value = DBNull.Value
                    Else
                        para(15).Value = CDate(obj.Den_ngay1)
                    End If

                    para(16) = New SqlParameter("@Tu_ngay2", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay2) Then
                        para(16).Value = DBNull.Value
                    Else
                        para(16).Value = CDate(obj.Tu_ngay2)
                    End If

                    para(17) = New SqlParameter("@Den_ngay2", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay2) Then
                        para(17).Value = DBNull.Value
                    Else
                        para(17).Value = CDate(obj.Den_ngay2)
                    End If
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Insert", para)
                Else
                    Dim para(17) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", obj.ID_he)
                    para(1) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", obj.Ky_dang_ky)
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
                    para(14) = New OracleParameter(":Tu_ngay1", obj.Tu_ngay1)
                    para(15) = New OracleParameter(":Den_ngay1", obj.Den_ngay1)
                    para(16) = New OracleParameter(":Tu_ngay2", obj.Tu_ngay2)
                    para(17) = New OracleParameter(":Den_ngay2", obj.Den_ngay2)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyDinhSoTinChi(ByVal obj As QuyDinhSoTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(17) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", obj.ID_he)
                    para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
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
                    para(14) = New SqlParameter("@Tu_ngay1", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay1) Then
                        para(14).Value = DBNull.Value
                    Else
                        para(14).Value = obj.Tu_ngay1
                    End If

                    para(15) = New SqlParameter("@Den_ngay1", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay1) Then
                        para(15).Value = DBNull.Value
                    Else
                        para(15).Value = obj.Den_ngay1
                    End If

                    para(16) = New SqlParameter("@Tu_ngay2", SqlDbType.DateTime)
                    If IsNothing(obj.Tu_ngay2) Then
                        para(16).Value = DBNull.Value
                    Else
                        para(16).Value = obj.Tu_ngay2
                    End If

                    para(17) = New SqlParameter("@Den_ngay2", SqlDbType.DateTime)
                    If IsNothing(obj.Den_ngay2) Then
                        para(17).Value = DBNull.Value
                    Else
                        para(17).Value = obj.Den_ngay2
                    End If
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Update", para)
                Else
                    Dim para(17) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", obj.ID_he)
                    para(1) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", obj.Ky_dang_ky)
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
                    para(14) = New OracleParameter(":Tu_ngay1", obj.Tu_ngay1)
                    para(15) = New OracleParameter(":Den_ngay1", obj.Den_ngay1)
                    para(16) = New OracleParameter(":Tu_ngay2", obj.Tu_ngay2)
                    para(17) = New OracleParameter(":Den_ngay2", obj.Den_ngay2)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_ChonDotDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbHocKyDangKyChonKyDangKy_Update", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbHocKyDangKyChonKyDangKy_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbQuyDinhSoTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    dt = UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_CheckExist", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    dt = UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_CheckExist", para)
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


