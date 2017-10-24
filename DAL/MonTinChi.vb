'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, July 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class MonTinChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_tkbMonTinChi_List(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbMonTinChi_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbMonTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_tkbLopTinChi_List(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbLopTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_tkbPhamViDangKy_List(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKy_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_tkbKeHoachKhac_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbKeHoachKhac_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbKeHoachKhac_List", para)

                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PLAN_KeHoachKyHieu_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_PLAN_KeHoachKyHieu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_tkbHocKyDangKy_List(ByVal Ky_dang_ky As Integer) As DataTable
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

        Public Function Load_tkbHocKyDangKy_List(ByVal Dot As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Dot", Dot)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKyDot_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Dot", Dot)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKyDot_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_PLAN_ChuongTrinhDaoTaoChiTietMonTinChi_List(ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@Kien_thuc", Kien_thuc)
                    para(1) = New SqlParameter("@Bat_buoc", Bat_buoc)
                    para(2) = New SqlParameter("@Tu_chon", Tu_chon)
                    para(3) = New SqlParameter("@ID_he", ID_he)
                    para(4) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(7) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(8) = New SqlParameter("@Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoChiTietMonTinChi_Load_List", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":Kien_thuc", Kien_thuc)
                    para(1) = New OracleParameter(":Bat_buoc", Bat_buoc)
                    para(2) = New OracleParameter(":Tu_chon", Tu_chon)
                    para(3) = New OracleParameter(":ID_he", ID_he)
                    para(4) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(5) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(6) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(7) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(8) = New OracleParameter(":Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("sp_PLAN_ChuongTrinhDaoTaoChiTietMonTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_tkbHocKyDangKyQuyDinh_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKyQuyDinh_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("sp_tkbHocKyDangKyQuyDinh_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_MonTinChi(ByVal obj As MonTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                    para(1) = New SqlParameter("@Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                    para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(3) = New SqlParameter("@So_tin_chi", obj.So_hoc_trinh)
                    para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                    para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                    para(6) = New SqlParameter("@He_so", obj.He_so)
                    para(7) = New SqlParameter("@So_tien", obj.So_tien)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", obj.Ky_dang_ky)
                    para(1) = New OracleParameter(":Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":So_tin_chi", obj.So_hoc_trinh)
                    para(4) = New OracleParameter(":Ly_thuyet", obj.Ly_thuyet)
                    para(5) = New OracleParameter(":Thuc_hanh", obj.Thuc_hanh)
                    para(6) = New OracleParameter(":He_so", obj.He_so)
                    para(7) = New OracleParameter(":So_tien", obj.So_tien)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MonTinChi(ByVal obj As MonTinChi, ByVal ID_mon_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    para(1) = New SqlParameter("@Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                    para(2) = New SqlParameter("@So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("sp_tkbMonTinChi_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    para(1) = New OracleParameter(":Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                    para(2) = New OracleParameter("@So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("sp_tkbMonTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MonTinChi(ByVal ID_mon_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    Return UDB.ExecuteSP("sp_tkbMonTinChi_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    Return UDB.ExecuteSP("sp_tkbMonTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_MonTinChi(ByVal Ky_dang_ky As Integer, ByVal ID_mon As Integer, ByVal So_tin_chi As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@So_tin_chi", So_tin_chi)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckMon", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":So_tin_chi", So_tin_chi)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckMon", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_MonTinChi_Ten(ByVal Ky_dang_ky As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckTen", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckTen", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_MonTinChi_TenUpdate(ByVal ID_mon_tc As Integer, ByVal Ky_dang_ky As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                    para(2) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckTen_Update", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                    para(2) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbMonTinChi_CheckTen_Update", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LopTinChi(ByVal obj As LopTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(13) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_lt", obj.ID_lop_lt)
                    para(1) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(2) = New SqlParameter("@STT_lop", obj.STT_lop)
                    para(3) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                    para(4) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                    para(5) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                    para(6) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(7) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(8) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(9) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(10) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                    para(11) = New SqlParameter("@Huy_lop", obj.Huy_lop)
                    para(12) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(13) = New SqlParameter("@Nhom_dang_ky", obj.Nhom_dang_ky)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbLopTinChi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(13) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_lt", obj.ID_lop_lt)
                    para(1) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(2) = New OracleParameter(":STT_lop", obj.STT_lop)
                    para(3) = New OracleParameter(":So_sv_min", obj.So_sv_min)
                    para(4) = New OracleParameter(":So_sv_max", obj.So_sv_max)
                    para(5) = New OracleParameter(":So_tiet_tuan", obj.So_tiet_tuan)
                    para(6) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(7) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(8) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(9) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(10) = New OracleParameter(":Ca_hoc", obj.Ca_hoc)
                    para(11) = New OracleParameter(":Huy_lop", obj.Huy_lop)
                    para(12) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(13) = New OracleParameter(":Nhom_dang_ky", obj.Nhom_dang_ky)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_tkbLopTinChi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChiEdit(ByVal obj As LopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                    para(2) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                    para(3) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                    para(4) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(5) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(6) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)

                    Return UDB.ExecuteSP("sp_tkbLopTinChi_UpdateEdit", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":So_sv_min", obj.So_sv_min)
                    para(2) = New OracleParameter(":So_sv_max", obj.So_sv_max)
                    para(3) = New OracleParameter(":So_tiet_tuan", obj.So_tiet_tuan)
                    para(4) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(5) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(6) = New OracleParameter(":Ca_hoc", obj.Ca_hoc)
                    Return UDB.ExecuteSP("sp_tkbLopTinChi_UpdateEdit", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_LopTinChi(ByVal obj As LopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(14) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@ID_lop_lt", obj.ID_lop_lt)
                    para(2) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(3) = New SqlParameter("@STT_lop", obj.STT_lop)
                    para(4) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                    para(5) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                    para(6) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                    para(7) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(8) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(9) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(10) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(11) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                    para(12) = New SqlParameter("@Huy_lop", obj.Huy_lop)
                    para(13) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(14) = New SqlParameter("@Nhom_dang_ky", obj.Nhom_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbLopTinChi_Update", para)
                Else
                    Dim para(13) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":ID_lop_lt", obj.ID_lop_lt)
                    para(2) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(3) = New OracleParameter(":STT_lop", obj.STT_lop)
                    para(4) = New OracleParameter(":So_sv_min", obj.So_sv_min)
                    para(5) = New OracleParameter(":So_sv_max", obj.So_sv_max)
                    para(6) = New OracleParameter(":So_tiet_tuan", obj.So_tiet_tuan)
                    para(7) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(8) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(9) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(10) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(11) = New OracleParameter(":Ca_hoc", obj.Ca_hoc)
                    para(12) = New OracleParameter(":Huy_lop", obj.Huy_lop)
                    para(13) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(14) = New OracleParameter(":Nhom_dang_ky", obj.Nhom_dang_ky)
                    Return UDB.ExecuteSP("sp_tkbLopTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LopTinChi(ByVal ID_lop_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    Return UDB.ExecuteSP("sp_tkbLopTinChi_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    Return UDB.ExecuteSP("sp_tkbLopTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_PhamViDangKy(ByVal obj As PhamViDangKy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhamViDangKy(ByVal obj As PhamViDangKy, ByVal ID_mon_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhamViDangKy(ByVal ID_mon_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKy_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_tkbPhamViDangKyLop_List(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKyLop_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKyLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_tkbPhamViDangKyLopChon_List(ByVal Ky_dang_ky As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKyLopChon_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.SelectTableSP("sp_tkbPhamViDangKyLopChon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKyLop_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKyLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKyLop_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_tkbPhamViDangKyLop_Delete", para)
                End If
            Catch ex As Exception
            End Try
        End Function
#End Region
    End Class
End Namespace


