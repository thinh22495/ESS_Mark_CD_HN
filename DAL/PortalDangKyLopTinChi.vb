'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Namespace DBManager
    Public Class PortalDangKyLopTinChi_DAL
        Public Function Load_QuyDinhSoTinChi_List(ByVal Ky_dang_ky As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_Load_KyDangKy", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbQuyDinhSoTinChi_Load_KyDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ky_dang_ky(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKy_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMax_KyDangKy() As DataTable
            Try
                Return UDB.SelectTableSP("sp_tkbHocKyDangKy_Max")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetChon_KyDangKy() As DataTable
            Try
                Return UDB.SelectTableSP("sp_tkbHocKyDangKy_Chon")
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Load_DanhSachNhomTuChon_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoNhomTuChon_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoNhomTuChon_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_MucHocPhiTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_ACC_MucHocPhiTinChi_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_ACC_MucHocPhiTinChi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChuongTrinhDaoTaoDangKy_List(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoDangKy_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_MonDangKy_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", ID_sv)
                    para(3) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_svMonDangKy_Load_List", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", ID_sv)
                    para(3) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_svMonDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_MonTinChiDuocDangKy_List(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(5) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(6) = New SqlParameter("@ID_dt", ID_dt)
                    para(7) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbMonTinChiDuocDangKy_Load_List", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(3) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(4) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(5) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(6) = New OracleParameter(":ID_dt", ID_dt)
                    para(7) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbMonTinChiDuocDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonTinChiDaDangKy_List(ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_tkbMonTinChiDaDangKy_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_tkbMonTinChiDaDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachLopDuocDangKy_List(ByVal ID_sv As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_DuocDangKy_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":dsID_mon_tc", dsID_mon_tc)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_DuocDangKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TKBLopDuocDangKy_List(ByVal dsID_mon_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_DuocDangKy", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":dsID_mon_tc", dsID_mon_tc)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_DuocDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachLopDaDangKy_List(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_DaDangKy_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":dsID_mon_tc", dsID_mon_tc)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_DaDangKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachLopDaDangKyAll_List(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_LoadAll_DaDangKy_List", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_LoadAll_DaDangKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachLopSoSinhVienDaDangKy_List(ByVal dsID_lop_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop_tc", dsID_lop_tc)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_SoSinhvienDangKy_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop_tc", dsID_lop_tc)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_SoSinhvienDangKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TKBLopDaDangKy_List(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_DaDangKy", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":dsID_mon_tc", dsID_mon_tc)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_Select_DaDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TKBLopDaDangKyAll_List(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_SelectAll_DaDangKy", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_PLAN_SukiensTinChi_SelectAll_DaDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Get_Tham_So_He_Thong(ByVal ID_tham_so As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_tham_so", ID_tham_so)
                    Return UDB.SelectTableSP("sp_ptGet_Tham_So_He_Thong", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_tham_so", ID_tham_so)
                    Return UDB.SelectTableSP("sp_ptGet_Tham_So_He_Thong", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_DaDangKy(ByVal ID_sv As Integer, ByVal Ky_dang_ky As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_ptCheck_DaDangKy", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_ptCheck_DaDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

