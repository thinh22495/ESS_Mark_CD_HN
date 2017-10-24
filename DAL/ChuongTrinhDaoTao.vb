'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ChuongTrinhDaoTao_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ChuongTrinhDaoTao_List(ByVal dsID_dt As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao_SaoChep(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@So", So)
                Dim dt As New DataTable
                dt = UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTao_Lop_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Load_Lop_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Load_Lop_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTaoChiTiet_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonHocTrongCTDT(ByVal dsID_dt As String, ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@dsID_dt", dsID_dt)
                    para(1) = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietMon_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(1) = New OracleParameter(":dsID_dt", dsID_dt)
                    para(1) = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietMon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTaoMonRangBuoc_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoMonRangBuoc_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoMonRangBuoc_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

       

        Public Function Load_MonHocTrongDiem(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal dsID_dt As String = "") As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(3) = New SqlParameter("@ID_bm", ID_bm)
                    para(4) = New SqlParameter("@ID_sv", ID_sv)
                    para(5) = New SqlParameter("@ID_dv", ID_dv)
                    para(6) = New SqlParameter("@dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietDiem_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_bm", ID_bm)
                    para(4) = New OracleParameter(":ID_sv", ID_sv)
                    para(5) = New OracleParameter(":ID_dv", ID_dv)
                    para(6) = New OracleParameter(":dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietDiem_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonHocTrongDiem_KyThu(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal dsID_dt As String = "", Optional ByVal Ky_thu As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(3) = New SqlParameter("@ID_bm", ID_bm)
                    para(4) = New SqlParameter("@ID_sv", ID_sv)
                    para(5) = New SqlParameter("@ID_dv", ID_dv)
                    para(6) = New SqlParameter("@dsID_dt", dsID_dt)
                    para(7) = New SqlParameter("@Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietDiemTongHop_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_bm", ID_bm)
                    para(4) = New OracleParameter(":ID_sv", ID_sv)
                    para(5) = New OracleParameter(":ID_dv", ID_dv)
                    para(6) = New OracleParameter(":dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietDiemTongHop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChuongTrinhDaoTao(ByVal obj As ChuongTrinhDaoTao) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", obj.ID_he)
                    para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                    para(5) = New SqlParameter("@So_ky_hoc", obj.So_ky_hoc)
                    para(6) = New SqlParameter("@So", obj.So)
                    Dim dt As DataTable = UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", obj.ID_he)
                    para(1) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(3) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(4) = New OracleParameter(":So_hoc_trinh", obj.So_hoc_trinh)
                    para(5) = New OracleParameter(":So_ky_hoc", obj.So_ky_hoc)
                    para(6) = New OracleParameter(":So", obj.So)
                    Dim dt As DataTable = UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_Insert", para)
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
        Public Function Update_ChuongTrinhDaoTao(ByVal obj As ChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(5) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                    para(6) = New SqlParameter("@So_ky_hoc", obj.So_ky_hoc)
                    para(7) = New SqlParameter("@So", obj.So)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(5) = New OracleParameter(":So_hoc_trinh", obj.So_hoc_trinh)
                    para(6) = New OracleParameter(":So_ky_hoc", obj.So_ky_hoc)
                    para(7) = New OracleParameter(":So", obj.So)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChuongTrinhDaoTao_Lop(ByVal ID_lop As Integer, ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Update_Lop", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Update_Lop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChuongTrinhDaoTao(ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(4) = New SqlParameter("@So", So)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_CheckExist", para).Rows(0)(0)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_CheckExist", para).Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_ChuongTrinhDaoTao_Diem(ByVal ID_dt As Integer, Optional ByVal ID_mon As Integer = 0) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_CheckExist_Diem", para).Rows(0)(0)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_CheckExist_Diem", para).Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChuongTrinhDaoTaoChiTiet(ByVal obj As ChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim para(21) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@Ky_thu", obj.Ky_thu)
                para(3) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(6) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(7) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                para(8) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                para(9) = New SqlParameter("@Tu_chon", obj.Tu_chon)
                para(10) = New SqlParameter("@STT_mon", obj.STT_mon)
                para(11) = New SqlParameter("@He_so", obj.He_so)
                para(12) = New SqlParameter("@Kien_thuc", obj.Kien_thuc)
                para(13) = New SqlParameter("@Khong_tinh_TBCHT", obj.Khong_tinh_TBCHT)
                para(14) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(15) = New SqlParameter("@Mon_tot_nghiep", obj.Mon_thi_TN)
                para(16) = New SqlParameter("@Mon_tot_nghiep_thuc_hanh", obj.Mon_thi_TN_thuc_hanh)
                para(17) = New SqlParameter("@So_hoc_trinh_tien_quyet", obj.So_hoc_trinh_tien_quyet)
                para(18) = New SqlParameter("@Tu_hoc", obj.Tu_hoc)
                para(19) = New SqlParameter("@Ma_khoa_phu_trach", obj.Ma_khoa_phu_trach)
                para(20) = New SqlParameter("@Mon_main", obj.ID_mon_main)
                para(21) = New SqlParameter("@Nhom_mon_sub", obj.Nhom_mon_sub)
                Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoChiTiet_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChuongTrinhDaoTaoChiTiet_Import(ByVal obj As ChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim para(15) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@Ky_thu", obj.Ky_thu)
                para(3) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(6) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(7) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                para(8) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                para(9) = New SqlParameter("@Tu_chon", obj.Tu_chon)
                para(10) = New SqlParameter("@STT_mon", obj.STT_mon)
                para(11) = New SqlParameter("@He_so", obj.He_so)
                para(12) = New SqlParameter("@Kien_thuc", obj.Kien_thuc)
                para(13) = New SqlParameter("@Khong_tinh_TBCHT", obj.Khong_tinh_TBCHT)
                para(14) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(15) = New SqlParameter("@Mon_thi_TN", obj.Mon_thi_TN)
                Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoChiTiet_Insert_Import", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PLAN_ChuongTrinhDaoTaoChiTiet(ByVal obj As ChuongTrinhDaoTaoChiTiet, ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim para(21) As SqlParameter
                para(0) = New SqlParameter("@ID_dt_mon", ID_dt_mon)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@Ky_thu", obj.Ky_thu)
                para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(5) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(6) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(7) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(8) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                para(9) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                para(10) = New SqlParameter("@Tu_chon", obj.Tu_chon)
                para(11) = New SqlParameter("@STT_mon", obj.STT_mon)
                para(12) = New SqlParameter("@He_so", obj.He_so)
                para(13) = New SqlParameter("@Kien_thuc", obj.Kien_thuc)
                para(14) = New SqlParameter("@Khong_tinh_TBCHT", obj.Khong_tinh_TBCHT)
                para(15) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(16) = New SqlParameter("@Mon_thi_TN", obj.Mon_thi_TN)
                para(17) = New SqlParameter("@Mon_tot_nghiep_thuc_hanh", obj.Mon_thi_TN_thuc_hanh)
                para(18) = New SqlParameter("@Mon_main", obj.ID_mon_main)
                para(19) = New SqlParameter("@Ly_thuyet_nghe", obj.Ly_thuyet_nghe)
                para(20) = New SqlParameter("@Thuc_hanh_nghe", obj.Thuc_hanh_nghe)
                para(21) = New SqlParameter("@Tu_hoc", obj.Tu_hoc)
                Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoChiTiet_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PLAN_ChuongTrinhDaoTaoChiTiet(ByVal ID_dt_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt_mon", ID_dt_mon)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoChiTiet_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt_mon", ID_dt_mon)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoChiTiet_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_PLAN_ChuongTrinhDaoTaoRangBuoc(ByVal obj As ChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_rb", obj.ID_rb)
                    para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(3) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                    para(4) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_rb", obj.ID_rb)
                    para(1) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":ID_mon_rb", obj.ID_mon_rb)
                    para(4) = New OracleParameter(":Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChuongTrinhDaoTaoRangBuoc(ByVal obj As ChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(2) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                    para(3) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_RangBuoc_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(1) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(2) = New OracleParameter(":ID_mon_rb", obj.ID_mon_rb)
                    para(3) = New OracleParameter(":Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTao_RangBuoc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function Insert_PLAN_ChuongTrinhDaoTaoRangBuoc(ByVal obj As ChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(2) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                    para(3) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(1) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(2) = New OracleParameter(":ID_mon_rb", obj.ID_mon_rb)
                    para(3) = New OracleParameter(":Loai_rang_buoc", obj.Loai_rang_buoc)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_PLAN_ChuongTrinhDaoTaoRangBuoc(ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@ID_mon_rb", ID_mon_rb)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", ID_mon)
                    para(1) = New OracleParameter(":ID_mon_rb", ID_mon_rb)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachMonHoc_NhomHocPhan(ByVal Ky_thu As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ky_thu", Ky_thu)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhep_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhep_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonHoc_NhomHocPhanSub(ByVal Ky_thu As Integer, ByVal ID_dt As Integer, ByVal ID_mon_main As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ky_thu", Ky_thu)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    para(2) = New SqlParameter("@ID_mon_main", ID_mon_main)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhepSub_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhepSub_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonHoc_NhomHocPhan_TinhDiemTBCHP(ByVal Ky_thu As Integer, ByVal ID_dt As Integer, ByVal ID_mon_main As Integer, ByVal ID_lops As String, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Ky_thu", Ky_thu)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    para(2) = New SqlParameter("@ID_mon_main", ID_mon_main)
                    para(3) = New SqlParameter("@ID_lops", ID_lops)
                    para(4) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(5) = New SqlParameter("@Lan_thi", Lan_thi)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhep_TinhDiemTBCHT_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_thu", Ky_thu)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTiet_HocPhanGhep_TinhDiemTBCHT_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "Portal"
        Public Function Load_ChuyenNganh_List(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal khoa_hoc As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim sID_dt As String = ""
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@khoa_hoc", khoa_hoc)
                    Return UDB.SelectTableSP("ptChuongTrinhDaoTao_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":khoa_hoc", khoa_hoc)
                    Return UDB.SelectTableSP("ptChuongTrinhDaoTao_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


