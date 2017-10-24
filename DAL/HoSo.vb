'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, April 17, 2008 
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports System.IO
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HoSo_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
#Region "FunctionSub"
        ' Load hồ sơ sub
        Public Function LoadHoSoSub(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVienSub_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVienSub_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New SqlParameter("@Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New SqlParameter("@So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New SqlParameter("@Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New SqlParameter("@Fax", dt.Rows(0)("Fax"))
                    para(5) = New SqlParameter("@Email", dt.Rows(0)("Email"))
                    para(6) = New SqlParameter("@ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New SqlParameter("@ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New SqlParameter("@Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New SqlParameter("@ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Insert", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New OracleParameter(":Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New OracleParameter(":So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New OracleParameter(":Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New OracleParameter(":Fax", dt.Rows(0)("Fax"))
                    para(5) = New OracleParameter(":Email", dt.Rows(0)("Email"))
                    para(6) = New OracleParameter(":ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New OracleParameter(":ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New OracleParameter(":Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New OracleParameter(":ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New SqlParameter("@Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New SqlParameter("@So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New SqlParameter("@Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New SqlParameter("@Fax", dt.Rows(0)("Fax"))
                    para(5) = New SqlParameter("@Email", dt.Rows(0)("Email"))
                    para(6) = New SqlParameter("@ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New SqlParameter("@ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New SqlParameter("@Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New SqlParameter("@ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Update", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New OracleParameter(":Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New OracleParameter(":So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New OracleParameter(":Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New OracleParameter(":Fax", dt.Rows(0)("Fax"))
                    para(5) = New OracleParameter(":Email", dt.Rows(0)("Email"))
                    para(6) = New OracleParameter(":ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New OracleParameter(":ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New OracleParameter(":Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New OracleParameter(":ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoSinhVienSub(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienSub_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoSoSinhVienSub(ByVal ID_sv As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    If UDB.SelectTableSP("STU_HoSoSinhVienSub_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    If UDB.SelectTableSP("STU_HoSoSinhVienSub_CheckExist", para).Rows.Count > 0 Then
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
        Public Function LoadID_dt_nganh2(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVien_Load_ID_dt_nganh2", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVien_Load_ID_dt_nganh2", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoSo_List(ByVal dsID_sv As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_sv", dsID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVien_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_sv)
                    Return UDB.SelectTableSP("STU_HoSoSinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoSoXoa_List() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_HoSoSinhVienXoa_Load_List")
                Else
                    Return UDB.SelectTableSP("STU_HoSoSinhVienXoa_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaSinhVien(ByVal Ma_sv As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                    para(0).Value = Ma_sv
                    If UDB.SelectTableSP("STU_HoSoSinhVien_Check_MaSV", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    If UDB.SelectTableSP("STU_HoSoSinhVien_Check_MaSV", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetID_SV(ByVal Ma_sv As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                    para(0).Value = Ma_sv
                    Dim dt As DataTable = UDB.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetImage(ByVal Ma_sv As String) As Byte()
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                    para(0).Value = Ma_sv
                    Dim dt As DataTable = UDB.SelectTableSP("STU_HoSoSinhVien_GetImage", para)
                    If dt.Rows.Count > 0 Then
                        If dt.Rows(0).Item("Anh").ToString <> "" Then Return CType(dt.Rows(0).Item("Anh"), Byte())
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_HoSoSinhVien_GetImage", para)
                    If dt.Rows.Count > 0 Then
                        If dt.Rows(0).Item("Anh").ToString <> "" Then Return CType(dt.Rows(0).Item("Anh"), Byte())
                    End If
                End If
                Return Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSo(ByVal obj As HoSo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(76) As SqlParameter
                    para(0) = New SqlParameter("@Anh", obj.Anh)
                    para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                    para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                    para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New SqlParameter("@Diem1", obj.Diem1)
                    para(25) = New SqlParameter("@Diem2", obj.Diem2)
                    para(26) = New SqlParameter("@Diem3", obj.Diem3)
                    para(27) = New SqlParameter("@Diem4", obj.Diem4)
                    para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                    para(29) = New SqlParameter("@SBD", obj.SBD)
                    para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                    para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                    para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New SqlParameter("@Lop", obj.Lop)
                    para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New SqlParameter("@UserID", obj.UserID)
                    para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New SqlParameter("@CMND", obj.CMND)
                    para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New SqlParameter("@Email", obj.Email)
                    para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(74) = New SqlParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(74) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(75) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                    para(76) = New SqlParameter("@IDCard", obj.IDCard)

                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Insert", para)
                Else
                    Dim para(75) As OracleParameter
                    para(0) = New OracleParameter(":Anh", obj.Anh)
                    para(1) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New OracleParameter(":Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New OracleParameter(":ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New OracleParameter(":Ton_giao", obj.Ton_giao)
                    para(8) = New OracleParameter(":ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New OracleParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New OracleParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New OracleParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New OracleParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New OracleParameter(":Que_quan", obj.Que_quan)
                    para(12) = New OracleParameter(":ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New OracleParameter(":Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New OracleParameter(":Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New OracleParameter(":ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New OracleParameter(":ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New OracleParameter(":ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New OracleParameter(":ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New OracleParameter(":Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New OracleParameter(":ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New OracleParameter(":Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New OracleParameter(":ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New OracleParameter(":Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New OracleParameter(":Diem1", obj.Diem1)
                    para(25) = New OracleParameter(":Diem2", obj.Diem2)
                    para(26) = New OracleParameter(":Diem3", obj.Diem3)
                    para(27) = New OracleParameter(":Diem4", obj.Diem4)
                    para(28) = New OracleParameter(":Tong_diem", obj.Tong_diem)
                    para(29) = New OracleParameter(":SBD", obj.SBD)
                    para(30) = New OracleParameter(":Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New OracleParameter(":Khoi_thi", obj.Khoi_thi)
                    para(32) = New OracleParameter(":Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New OracleParameter(":Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New OracleParameter(":Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New OracleParameter(":Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    para(37) = New OracleParameter(":Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New OracleParameter(":Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New OracleParameter(":Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New OracleParameter(":Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New OracleParameter(":ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New OracleParameter(":ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New OracleParameter(":Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New OracleParameter(":Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New OracleParameter(":Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New OracleParameter(":Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New OracleParameter(":ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New OracleParameter(":ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New OracleParameter(":Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New OracleParameter(":Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New OracleParameter(":Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New OracleParameter(":Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New OracleParameter(":ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New OracleParameter(":ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New OracleParameter(":Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New OracleParameter(":Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New OracleParameter(":Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New OracleParameter(":Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New OracleParameter(":Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New OracleParameter(":Hoten_Order", obj.Hoten_Order)
                    para(61) = New OracleParameter(":Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New OracleParameter(":Lop", obj.Lop)
                    para(63) = New OracleParameter(":Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New OracleParameter(":UserID", obj.UserID)
                    para(65) = New OracleParameter(":UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New OracleParameter(":UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New OracleParameter(":CMND", obj.CMND)
                    para(69) = New OracleParameter(":Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New OracleParameter(":Email", obj.Email)
                    para(71) = New OracleParameter(":NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New OracleParameter(":Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New OracleParameter(":Namsinh_me", obj.Namsinh_me)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(74) = New OracleParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(74) = New OracleParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(75) = New OracleParameter(":Noi_cap", obj.Noi_cap)
                    para(76) = New OracleParameter(":IDCard", obj.IDCard)

                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSo_KhoiPhuc(ByVal obj As HoSo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(76) As SqlParameter
                    para(0) = New SqlParameter("@Anh", obj.Anh)
                    para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                    para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                    para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New SqlParameter("@Diem1", obj.Diem1)
                    para(25) = New SqlParameter("@Diem2", obj.Diem2)
                    para(26) = New SqlParameter("@Diem3", obj.Diem3)
                    para(27) = New SqlParameter("@Diem4", obj.Diem4)
                    para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                    para(29) = New SqlParameter("@SBD", obj.SBD)
                    para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                    para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                    para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New SqlParameter("@Lop", obj.Lop)
                    para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New SqlParameter("@UserID", obj.UserID)
                    para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New SqlParameter("@CMND", obj.CMND)
                    para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New SqlParameter("@Email", obj.Email)
                    para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                    para(74) = New SqlParameter("@ID_sv", obj.ID_sv)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(76) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                    para(77) = New SqlParameter("@IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_KhoiPhuc_Insert", para)
                Else
                    Dim para(76) As OracleParameter
                    para(0) = New OracleParameter(":Anh", obj.Anh)
                    para(1) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New OracleParameter(":Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New OracleParameter(":ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New OracleParameter(":Ton_giao", obj.Ton_giao)
                    para(8) = New OracleParameter(":ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New OracleParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New OracleParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New OracleParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New OracleParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New OracleParameter(":Que_quan", obj.Que_quan)
                    para(12) = New OracleParameter(":ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New OracleParameter(":Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New OracleParameter(":Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New OracleParameter(":ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New OracleParameter(":ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New OracleParameter(":ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New OracleParameter(":ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New OracleParameter(":Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New OracleParameter(":ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New OracleParameter(":Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New OracleParameter(":ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New OracleParameter(":Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New OracleParameter(":Diem1", obj.Diem1)
                    para(25) = New OracleParameter(":Diem2", obj.Diem2)
                    para(26) = New OracleParameter(":Diem3", obj.Diem3)
                    para(27) = New OracleParameter(":Diem4", obj.Diem4)
                    para(28) = New OracleParameter(":Tong_diem", obj.Tong_diem)
                    para(29) = New OracleParameter(":SBD", obj.SBD)
                    para(30) = New OracleParameter(":Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New OracleParameter(":Khoi_thi", obj.Khoi_thi)
                    para(32) = New OracleParameter(":Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New OracleParameter(":Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New OracleParameter(":Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New OracleParameter(":Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    para(37) = New OracleParameter(":Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New OracleParameter(":Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New OracleParameter(":Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New OracleParameter(":Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New OracleParameter(":ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New OracleParameter(":ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New OracleParameter(":Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New OracleParameter(":Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New OracleParameter(":Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New OracleParameter(":Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New OracleParameter(":ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New OracleParameter(":ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New OracleParameter(":Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New OracleParameter(":Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New OracleParameter(":Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New OracleParameter(":Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New OracleParameter(":ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New OracleParameter(":ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New OracleParameter(":Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New OracleParameter(":Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New OracleParameter(":Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New OracleParameter(":Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New OracleParameter(":Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New OracleParameter(":Hoten_Order", obj.Hoten_Order)
                    para(61) = New OracleParameter(":Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New OracleParameter(":Lop", obj.Lop)
                    para(63) = New OracleParameter(":Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New OracleParameter(":UserID", obj.UserID)
                    para(65) = New OracleParameter(":UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New OracleParameter(":UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New OracleParameter(":CMND", obj.CMND)
                    para(69) = New OracleParameter(":Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New OracleParameter(":Email", obj.Email)
                    para(71) = New OracleParameter(":NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New OracleParameter(":Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New OracleParameter(":Namsinh_me", obj.Namsinh_me)
                    para(74) = New OracleParameter(":ID_sv", obj.ID_sv)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(75) = New OracleParameter(":Ngay_cap", DBNull.Value)
                    Else
                        para(75) = New OracleParameter(":Ngay_cap", obj.Ngay_cap)
                    End If
                    para(76) = New OracleParameter(":Noi_cap", obj.Noi_cap)
                    para(77) = New OracleParameter("@IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_KhoiPhuc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSoTemp(ByVal obj As HoSo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(76) As SqlParameter
                    para(0) = New SqlParameter("@Anh", obj.Anh)
                    para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                    para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                    para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New SqlParameter("@Diem1", obj.Diem1)
                    para(25) = New SqlParameter("@Diem2", obj.Diem2)
                    para(26) = New SqlParameter("@Diem3", obj.Diem3)
                    para(27) = New SqlParameter("@Diem4", obj.Diem4)
                    para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                    para(29) = New SqlParameter("@SBD", obj.SBD)
                    para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                    para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                    para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New SqlParameter("@Lop", obj.Lop)
                    para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New SqlParameter("@UserID", obj.UserID)
                    para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New SqlParameter("@CMND", obj.CMND)
                    para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New SqlParameter("@Email", obj.Email)
                    para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(74) = New SqlParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(74) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(75) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                    para(76) = New SqlParameter("@IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTemp_Insert", para)
                Else
                    Dim para(75) As OracleParameter
                    para(0) = New OracleParameter(":Anh", obj.Anh)
                    para(1) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New OracleParameter(":Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New OracleParameter(":ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New OracleParameter(":Ton_giao", obj.Ton_giao)
                    para(8) = New OracleParameter(":ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    para(9) = New OracleParameter(":Ngay_vao_doan", obj.Ngay_vao_doan)
                    para(10) = New OracleParameter(":Ngay_vao_dang", obj.Ngay_vao_dang)
                    para(11) = New OracleParameter(":Que_quan", obj.Que_quan)
                    para(12) = New OracleParameter(":ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New OracleParameter(":Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New OracleParameter(":Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New OracleParameter(":ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New OracleParameter(":ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New OracleParameter(":ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New OracleParameter(":ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New OracleParameter(":Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New OracleParameter(":ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New OracleParameter(":Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New OracleParameter(":ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New OracleParameter(":Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New OracleParameter(":Diem1", obj.Diem1)
                    para(25) = New OracleParameter(":Diem2", obj.Diem2)
                    para(26) = New OracleParameter(":Diem3", obj.Diem3)
                    para(27) = New OracleParameter(":Diem4", obj.Diem4)
                    para(28) = New OracleParameter(":Tong_diem", obj.Tong_diem)
                    para(29) = New OracleParameter(":SBD", obj.SBD)
                    para(30) = New OracleParameter(":Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New OracleParameter(":Khoi_thi", obj.Khoi_thi)
                    para(32) = New OracleParameter(":Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New OracleParameter(":Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New OracleParameter(":Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New OracleParameter(":Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    para(37) = New OracleParameter(":Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New OracleParameter(":Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New OracleParameter(":Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New OracleParameter(":Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New OracleParameter(":ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New OracleParameter(":ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New OracleParameter(":Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New OracleParameter(":Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New OracleParameter(":Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New OracleParameter(":Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New OracleParameter(":ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New OracleParameter(":ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New OracleParameter(":Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New OracleParameter(":Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New OracleParameter(":Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New OracleParameter(":Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New OracleParameter(":ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New OracleParameter(":ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New OracleParameter(":Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New OracleParameter(":Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New OracleParameter(":Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New OracleParameter(":Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New OracleParameter(":Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New OracleParameter(":Hoten_Order", obj.Hoten_Order)
                    para(61) = New OracleParameter(":Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New OracleParameter(":Lop", obj.Lop)
                    para(63) = New OracleParameter(":Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New OracleParameter(":UserID", obj.UserID)
                    para(65) = New OracleParameter(":UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(67) = New OracleParameter(":UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New OracleParameter(":CMND", obj.CMND)
                    para(69) = New OracleParameter(":Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New OracleParameter(":Email", obj.Email)
                    para(71) = New OracleParameter(":NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New OracleParameter(":Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New OracleParameter(":Namsinh_me", obj.Namsinh_me)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(74) = New OracleParameter(":Ngay_cap", DBNull.Value)
                    Else
                        para(74) = New OracleParameter(":Ngay_cap", obj.Ngay_cap)
                    End If
                    para(75) = New OracleParameter(":Noi_cap", obj.Noi_cap)
                    para(76) = New OracleParameter(":IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTemp_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSoXoa(ByVal obj As HoSo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(77) As SqlParameter
                    para(0) = New SqlParameter("@Anh", obj.Anh)
                    para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                    para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                    para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New SqlParameter("@Diem1", obj.Diem1)
                    para(25) = New SqlParameter("@Diem2", obj.Diem2)
                    para(26) = New SqlParameter("@Diem3", obj.Diem3)
                    para(27) = New SqlParameter("@Diem4", obj.Diem4)
                    para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                    para(29) = New SqlParameter("@SBD", obj.SBD)
                    para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                    para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                    para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New SqlParameter("@Lop", obj.Lop)
                    para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New SqlParameter("@UserID", obj.UserID)
                    para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New SqlParameter("@CMND", obj.CMND)
                    para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New SqlParameter("@Email", obj.Email)
                    para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                    para(74) = New SqlParameter("@ID_sv", obj.ID_sv)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(76) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                    para(77) = New SqlParameter("@IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienXoa_Insert", para)
                Else
                    Dim para(77) As OracleParameter
                    para(0) = New OracleParameter(":Anh", obj.Anh)
                    para(1) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(3) = New OracleParameter(":Ngay_sinh", DBNull.Value)
                    Else
                        para(3) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(4) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(5) = New OracleParameter(":ID_dan_toc", obj.ID_dan_toc)
                    para(6) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(7) = New OracleParameter(":Ton_giao", obj.Ton_giao)
                    para(8) = New OracleParameter(":ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    para(9) = New OracleParameter(":Ngay_vao_doan", obj.Ngay_vao_doan)
                    para(10) = New OracleParameter(":Ngay_vao_dang", obj.Ngay_vao_dang)
                    para(11) = New OracleParameter(":Que_quan", obj.Que_quan)
                    para(12) = New OracleParameter(":ID_tinh_ns", obj.ID_tinh_ns)
                    para(13) = New OracleParameter(":Dia_chi_tt", obj.Dia_chi_tt)
                    para(14) = New OracleParameter(":Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(15) = New OracleParameter(":ID_huyen_tt", obj.ID_huyen_tt)
                    para(16) = New OracleParameter(":ID_tinh_tt", obj.ID_tinh_tt)
                    para(17) = New OracleParameter(":ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(18) = New OracleParameter(":ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(19) = New OracleParameter(":Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(20) = New OracleParameter(":ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(21) = New OracleParameter(":Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(22) = New OracleParameter(":ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(23) = New OracleParameter(":Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(24) = New OracleParameter(":Diem1", obj.Diem1)
                    para(25) = New OracleParameter(":Diem2", obj.Diem2)
                    para(26) = New OracleParameter(":Diem3", obj.Diem3)
                    para(27) = New OracleParameter(":Diem4", obj.Diem4)
                    para(28) = New OracleParameter(":Tong_diem", obj.Tong_diem)
                    para(29) = New OracleParameter(":SBD", obj.SBD)
                    para(30) = New OracleParameter(":Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(31) = New OracleParameter(":Khoi_thi", obj.Khoi_thi)
                    para(32) = New OracleParameter(":Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(33) = New OracleParameter(":Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(34) = New OracleParameter(":Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(35) = New OracleParameter(":Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(36) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    para(37) = New OracleParameter(":Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(38) = New OracleParameter(":Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(39) = New OracleParameter(":Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(40) = New OracleParameter(":Ho_ten_cha", obj.Ho_ten_cha)
                    para(41) = New OracleParameter(":ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(42) = New OracleParameter(":ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(43) = New OracleParameter(":Ton_giao_cha", obj.Ton_giao_cha)
                    para(44) = New OracleParameter(":Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(45) = New OracleParameter(":Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(46) = New OracleParameter(":Ho_ten_me", obj.Ho_ten_me)
                    para(47) = New OracleParameter(":ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(48) = New OracleParameter(":ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(49) = New OracleParameter(":Ton_giao_me", obj.Ton_giao_me)
                    para(50) = New OracleParameter(":Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(51) = New OracleParameter(":Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(52) = New OracleParameter(":Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(53) = New OracleParameter(":ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(54) = New OracleParameter(":ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(55) = New OracleParameter(":Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(56) = New OracleParameter(":Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(57) = New OracleParameter(":Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(58) = New OracleParameter(":Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(59) = New OracleParameter(":Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(60) = New OracleParameter(":Hoten_Order", obj.Hoten_Order)
                    para(61) = New OracleParameter(":Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(62) = New OracleParameter(":Lop", obj.Lop)
                    para(63) = New OracleParameter(":Ngoai_ngu", obj.Ngoai_ngu)
                    para(64) = New OracleParameter(":UserID", obj.UserID)
                    para(65) = New OracleParameter(":UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(67) = New OracleParameter(":UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(67) = New OracleParameter(":Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(68) = New OracleParameter(":CMND", obj.CMND)
                    para(69) = New OracleParameter(":Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(70) = New OracleParameter(":Email", obj.Email)
                    para(71) = New OracleParameter(":NoiO_hiennay", obj.NoiO_hiennay)
                    para(72) = New OracleParameter(":Namsinh_cha", obj.Namsinh_cha)
                    para(73) = New OracleParameter(":Namsinh_me", obj.Namsinh_me)
                    para(74) = New OracleParameter(":ID_sv", obj.ID_sv)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(75) = New OracleParameter(":Ngay_cap", DBNull.Value)
                    Else
                        para(75) = New OracleParameter(":Ngay_cap", obj.Ngay_cap)
                    End If
                    para(76) = New OracleParameter(":Noi_cap", obj.Noi_cap)
                    para(77) = New OracleParameter(":IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienXoa_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSo(ByVal obj As HoSo, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(77) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Anh", obj.Anh)
                    para(2) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(3) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(4) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                    Else
                        para(4) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(5) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(6) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                    para(7) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                    para(8) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                    para(9) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(10) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                    Else
                        para(10) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(11) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                    Else
                        para(11) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(12) = New SqlParameter("@Que_quan", obj.Que_quan)
                    para(13) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                    para(14) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                    para(15) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(16) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                    para(17) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                    para(18) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(19) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(20) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(21) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(22) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(23) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(24) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(25) = New SqlParameter("@Diem1", obj.Diem1)
                    para(26) = New SqlParameter("@Diem2", obj.Diem2)
                    para(27) = New SqlParameter("@Diem3", obj.Diem3)
                    para(28) = New SqlParameter("@Diem4", obj.Diem4)
                    para(29) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                    para(30) = New SqlParameter("@SBD", obj.SBD)
                    para(31) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(32) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                    para(33) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(34) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(35) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(36) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(37) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    para(38) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(39) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(40) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(41) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                    para(42) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(43) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(44) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                    para(45) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(46) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(47) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                    para(48) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(49) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(50) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                    para(51) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(52) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(53) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(54) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(55) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(56) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(57) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(58) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(59) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(60) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(61) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                    para(62) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(63) = New SqlParameter("@Lop", obj.Lop)
                    para(64) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                    para(65) = New SqlParameter("@UserID", obj.UserID)
                    para(66) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(67) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(68) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(68) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(69) = New SqlParameter("@CMND", obj.CMND)
                    para(70) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(71) = New SqlParameter("@Email", obj.Email)
                    para(72) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                    para(73) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                    para(74) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                    If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                        para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                    Else
                        para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                    End If
                    para(76) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                    para(77) = New SqlParameter("@IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Update", para)
                Else
                    Dim para(77) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Anh", obj.Anh)
                    para(2) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(3) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    If obj.Ngay_sinh = Nothing Then
                        para(4) = New OracleParameter(":Ngay_sinh", DBNull.Value)
                    Else
                        para(4) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    End If
                    para(5) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(6) = New OracleParameter(":ID_dan_toc", obj.ID_dan_toc)
                    para(7) = New OracleParameter(":ID_quoc_tich", obj.ID_quoc_tich)
                    para(8) = New OracleParameter(":Ton_giao", obj.Ton_giao)
                    para(9) = New OracleParameter(":ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                    If obj.Ngay_vao_doan = Nothing Then
                        para(10) = New OracleParameter(":Ngay_vao_doan", DBNull.Value)
                    Else
                        para(10) = New OracleParameter(":Ngay_vao_doan", obj.Ngay_vao_doan)
                    End If
                    If obj.Ngay_vao_dang = Nothing Then
                        para(11) = New OracleParameter(":Ngay_vao_dang", DBNull.Value)
                    Else
                        para(11) = New OracleParameter(":Ngay_vao_dang", obj.Ngay_vao_dang)
                    End If
                    para(12) = New OracleParameter(":Que_quan", obj.Que_quan)
                    para(13) = New OracleParameter(":ID_tinh_ns", obj.ID_tinh_ns)
                    para(14) = New OracleParameter(":Dia_chi_tt", obj.Dia_chi_tt)
                    para(15) = New OracleParameter(":Xa_phuong_tt", obj.Xa_phuong_tt)
                    para(16) = New OracleParameter(":ID_huyen_tt", obj.ID_huyen_tt)
                    para(17) = New OracleParameter(":ID_tinh_tt", obj.ID_tinh_tt)
                    para(18) = New OracleParameter(":ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                    para(19) = New OracleParameter(":ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                    para(20) = New OracleParameter(":Dien_thoai_NR", obj.Dien_thoai_NR)
                    para(21) = New OracleParameter(":ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                    para(22) = New OracleParameter(":Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                    para(23) = New OracleParameter(":ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                    para(24) = New OracleParameter(":Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                    para(25) = New OracleParameter(":Diem1", obj.Diem1)
                    para(26) = New OracleParameter(":Diem2", obj.Diem2)
                    para(27) = New OracleParameter(":Diem3", obj.Diem3)
                    para(28) = New OracleParameter(":Diem4", obj.Diem4)
                    para(29) = New OracleParameter(":Tong_diem", obj.Tong_diem)
                    para(30) = New OracleParameter(":SBD", obj.SBD)
                    para(31) = New OracleParameter(":Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                    para(32) = New OracleParameter(":Khoi_thi", obj.Khoi_thi)
                    para(33) = New OracleParameter(":Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                    para(34) = New OracleParameter(":Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                    para(35) = New OracleParameter(":Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                    para(36) = New OracleParameter(":Nam_tot_nghiep", obj.Nam_tot_nghiep)
                    para(37) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    para(38) = New OracleParameter(":Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                    para(39) = New OracleParameter(":Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                    para(40) = New OracleParameter(":Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                    para(41) = New OracleParameter(":Ho_ten_cha", obj.Ho_ten_cha)
                    para(42) = New OracleParameter(":ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                    para(43) = New OracleParameter(":ID_dan_toc_cha", obj.ID_dan_toc_cha)
                    para(44) = New OracleParameter(":Ton_giao_cha", obj.Ton_giao_cha)
                    para(45) = New OracleParameter(":Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                    para(46) = New OracleParameter(":Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                    para(47) = New OracleParameter(":Ho_ten_me", obj.Ho_ten_me)
                    para(48) = New OracleParameter(":ID_quoc_tich_me", obj.ID_quoc_tich_me)
                    para(49) = New OracleParameter(":ID_dan_toc_me", obj.ID_dan_toc_me)
                    para(50) = New OracleParameter(":Ton_giao_me", obj.Ton_giao_me)
                    para(51) = New OracleParameter(":Ho_khau_TT_me", obj.Ho_khau_TT_me)
                    para(52) = New OracleParameter(":Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                    para(53) = New OracleParameter(":Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                    para(54) = New OracleParameter(":ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                    para(55) = New OracleParameter(":ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                    para(56) = New OracleParameter(":Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                    para(57) = New OracleParameter(":Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                    para(58) = New OracleParameter(":Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                    para(59) = New OracleParameter(":Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                    para(60) = New OracleParameter(":Dang_ky_hoc", obj.Dang_ky_hoc)
                    para(61) = New OracleParameter(":Hoten_Order", obj.Hoten_Order)
                    para(62) = New OracleParameter(":Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                    para(63) = New OracleParameter(":Lop", obj.Lop)
                    para(64) = New OracleParameter(":Ngoai_ngu", obj.Ngoai_ngu)
                    para(65) = New OracleParameter(":UserID", obj.UserID)
                    para(66) = New OracleParameter(":UserName_tiep_nhan", obj.UserName_tiep_nhan)
                    para(67) = New OracleParameter(":UserID_tiep_nhan", obj.UserID_tiep_nhan)
                    If obj.Ngay_nhap_hoc = Nothing Then
                        para(68) = New OracleParameter(":Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(68) = New OracleParameter(":Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                    End If
                    para(69) = New OracleParameter(":CMND", obj.CMND)
                    para(70) = New OracleParameter(":Dienthoai_canhan", obj.Dienthoai_canhan)
                    para(71) = New OracleParameter(":Email", obj.Email)
                    para(72) = New OracleParameter(":NoiO_hiennay", obj.NoiO_hiennay)
                    para(73) = New OracleParameter(":Namsinh_cha", obj.Namsinh_cha)
                    para(74) = New OracleParameter(":Namsinh_me", obj.Namsinh_me)
                    para(75) = New OracleParameter(":Noi_cap", obj.Noi_cap)
                    para(76) = New OracleParameter(":Ngay_cap", obj.Ngay_cap)
                    para(77) = New OracleParameter(":IDCard", obj.IDCard)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSo(ByVal strUpdate As String) As Integer
            Try
                Return UDB.Execute(strUpdate)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSoDTChinhSanh(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_HoSoDTChinhSach_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_HoSoDTChinhSach_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSoDTTroCap(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_HoSoDTTroCap_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_HoSoDTTroCap_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSo(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoXoa(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienXoa_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienXoa_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoTemp(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTemp_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTemp_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoTempMa_sv(ByVal Ma_sv As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTempMasv_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    Return UDB.ExecuteSP("STU_HoSoSinhVienTempMasv_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


