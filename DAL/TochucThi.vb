'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, June 06, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class TochucThi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhsachTochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_bm As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_bm", ID_bm)
                Return UDB.SelectTableSP("MARK_TochucThi_Load_List", para)
            Else
                Dim para(2) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":ID_bm", ID_bm)
                Return UDB.SelectTableSP("MARK_TochucThi_Load_List", para)
            End If
        End Function
        Public Function Load_TochucThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThi_Load", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThi_Load", para)
            End If
        End Function
        Public Function Load_ToChucThiPhong(ByVal ID_phong_thi As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_Phong_thi", ID_phong_thi)
                Return UDB.SelectTableSP("MARK_Load_TochucThiPhong", para)
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Function Load_ToChucThi_TheoDot(ByVal ID_thi As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_Load_TochucThi_TheoDot", para)
            Catch ex As Exception
                Throw ex
            End Try

        End Function
        Public Function Load_DanhsachPhongThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThiPhong_Load_List", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThiPhong_Load_List", para)
            End If
        End Function
        Public Function Load_DanhsachTuiThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThi_TuiThi_Load_List", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThi_TuiThi_Load_List", para)
            End If
        End Function
        Public Function Load_DanhsachSinhVien(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThiChiTiet_Load_List", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return UDB.SelectTableSP("MARK_TochucThiChiTiet_Load_List", para)
            End If
        End Function
        Public Function Check_MARK_TochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Dot_thi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    'Dim dt As DataTable
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@ID_mon", ID_mon)
                    para(5) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(6) = New SqlParameter("@Dot_thi", Dot_thi)
                    Return UDB.SelectTableSP("MARK_TochucThi_CheckExist", para)
                    'If dt.Rows.Count > 0 Then
                    '    Return dt.Rows(0).Item("ID_thi")
                    'Else
                    '    Return -1
                    'End If
                Else
                    Dim para(6) As OracleParameter
                    'Dim dt As DataTable
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":ID_mon", ID_mon)
                    para(5) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(6) = New OracleParameter(":Dot_thi", Dot_thi)
                    Return UDB.SelectTableSP("MARK_TochucThi_CheckExist", para)
                    'If dt.Rows.Count > 0 Then
                    '    Return dt.Rows(0).Item("ID_thi")
                    'Else
                    '    Return -1
                    'End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Insert_TochucThi(ByVal obj As TochucThi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(11) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", obj.ID_he)
                    para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(4) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(5) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                    para(6) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(7) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(8) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(9) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(10) = New SqlParameter("@Thoi_gian", obj.Thoi_gian)
                    para(11) = New SqlParameter("@Thoi_gian_lam_bai", obj.Thoi_gian_lam_bai)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", obj.ID_he)
                    para(3) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(4) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(5) = New OracleParameter(":Lan_thi", obj.Lan_thi)
                    para(6) = New OracleParameter(":Dot_thi", obj.Dot_thi)
                    para(7) = New OracleParameter(":Ngay_thi", obj.Ngay_thi)
                    para(8) = New OracleParameter(":Ca_thi", obj.Ca_thi)
                    para(9) = New OracleParameter(":Nhom_tiet", obj.Nhom_tiet)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThi_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TochucThi(ByVal obj As TochucThi, ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(12) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_he", obj.ID_he)
                    para(4) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(5) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(6) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                    para(7) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(8) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(9) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(10) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(11) = New SqlParameter("@Thoi_gian", obj.Thoi_gian)
                    para(12) = New SqlParameter("@Thoi_gian_lam_bai", obj.Thoi_gian_lam_bai)
                    Return UDB.ExecuteSP("MARK_TochucThi_Update", para)
                Else
                    Dim para(10) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_he", obj.ID_he)
                    para(4) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(5) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(6) = New OracleParameter(":Lan_thi", obj.Lan_thi)
                    para(7) = New OracleParameter(":Dot_thi", obj.Dot_thi)
                    para(8) = New OracleParameter(":Ngay_thi", obj.Ngay_thi)
                    para(9) = New OracleParameter(":Ca_thi", obj.Ca_thi)
                    para(10) = New OracleParameter(":Nhom_tiet", obj.Nhom_tiet)
                    Return UDB.ExecuteSP("MARK_TochucThi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_TochucThi(ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    Return UDB.ExecuteSP("MARK_TochucThi_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return UDB.ExecuteSP("MARK_TochucThi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Insert_ToChucThiPhong(ByVal obj As ToChucThiPhong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(1) = New SqlParameter("@Ten_phong", obj.Ten_phong)
                    para(2) = New SqlParameter("@So_sv", obj.So_sv)
                    para(3) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(4) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(5) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(6) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(7) = New SqlParameter("@Thoi_gian", obj.Thoi_gian)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThiPhong_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ten_phong", obj.Ten_phong)
                    para(1) = New OracleParameter(":So_sv", obj.So_sv)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThiPhong_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ToChucThiPhong(ByVal obj As ToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                    para(1) = New SqlParameter("@Ten_phong", obj.Ten_phong)
                    para(2) = New SqlParameter("@So_sv", obj.So_sv)
                    para(3) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(4) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(5) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(6) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(7) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(8) = New SqlParameter("@Thoi_gian", obj.Thoi_gian)
                    Return UDB.ExecuteSP("MARK_TochucThiPhong_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_phong_thi", ID_phong_thi)
                    para(1) = New OracleParameter(":Ten_phong", obj.Ten_phong)
                    para(2) = New OracleParameter(":So_sv", obj.So_sv)
                    Return UDB.ExecuteSP("MARK_TochucThiPhong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        
        Public Function Delete_ToChucThiTheoPhong(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@ID_phong_thi", ID_phong_this)
                    Return UDB.ExecuteSP("MARK_TochucThiPhong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return UDB.ExecuteSP("MARK_TochucThiPhong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_TochucThiChiTiet(ByVal obj As TochucThiChiTiet) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", obj.ID_thi)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                    para(3) = New SqlParameter("@So_bao_danh", obj.So_bao_danh)
                    para(4) = New SqlParameter("@So_phach", obj.So_phach)
                    para(5) = New SqlParameter("@Tui_so", obj.Tui_so)
                    para(6) = New SqlParameter("@Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(7) = New SqlParameter("@OrderBy", obj.OrderBy)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThiChiTiet_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", obj.ID_thi)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_phong_thi", obj.ID_phong_thi)
                    para(3) = New OracleParameter(":So_bao_danh", obj.So_bao_danh)
                    para(4) = New OracleParameter(":So_phach", obj.So_phach)
                    para(5) = New OracleParameter(":Tui_so", obj.Tui_so)
                    para(6) = New OracleParameter(":Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(7) = New OracleParameter(":OrderBy", obj.OrderBy)
                    Dim dt As DataTable
                    dt = UDB.SelectTableSP("MARK_TochucThiChiTiet_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TochucThiChiTiet(ByVal obj As TochucThiChiTiet, ByVal ID_ds_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_ds_thi", ID_ds_thi)
                    para(1) = New SqlParameter("@ID_thi", obj.ID_thi)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                    para(4) = New SqlParameter("@So_bao_danh", obj.So_bao_danh)
                    para(5) = New SqlParameter("@So_phach", obj.So_phach)
                    para(6) = New SqlParameter("@Tui_so", obj.Tui_so)
                    para(7) = New SqlParameter("@Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(8) = New SqlParameter("@OrderBy", obj.OrderBy)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Update", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_ds_thi", ID_ds_thi)
                    para(1) = New OracleParameter(":ID_thi", obj.ID_thi)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_phong_thi", obj.ID_phong_thi)
                    para(4) = New OracleParameter(":So_bao_danh", obj.So_bao_danh)
                    para(5) = New OracleParameter(":So_phach", obj.So_phach)
                    para(6) = New OracleParameter(":Tui_so", obj.Tui_so)
                    para(7) = New OracleParameter(":Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(8) = New OracleParameter(":OrderBy", obj.OrderBy)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_TochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@ID_phong_thi", ID_phong_this)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_TochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Delete_SV", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("MARK_TochucThiChiTiet_Delete_SV", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DotThi(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Dot_thi", Dot_thi)
                Return UDB.SelectTableSP("MARK_Load_LichThiTheoDot_Load_List", para)
            Else
                Dim para(3) As OracleParameter
                para(0) = New OracleParameter(":ID_he", ID_he)
                para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(3) = New OracleParameter(":Dot_thi", Dot_thi)
                Return UDB.SelectTableSP("MARK_Load_LichThiTheoDot_Load_List", para)
            End If
        End Function

        Public Function Check_SosvDuTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal SoSV_Max As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@Tui_so", Tui_so)
                    para(2) = New SqlParameter("@SoSV_Max", SoSV_Max)
                    Return UDB.SelectTableSP("MARK_TochucThi_SoSVDongTui_CheckExist", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    para(1) = New OracleParameter(":Tui_so", Tui_so)
                    para(2) = New OracleParameter(":SoSV_Max", SoSV_Max)
                    Return UDB.SelectTableSP("MARK_TochucThi_SoSVDongTui_CheckExist", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_SinhVien_KDDKDuThi(ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                Return UDB.SelectTableSP("STU_DanhSachKhongThi_Load_List", para)
            Else
                Dim para(2) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":ID_lops", ID_lops)
                Return UDB.SelectTableSP("STU_DanhSachKhongThi_Load_List", para)
            End If
        End Function

        Public Function Load_ToChucThi_TotNghiep_Load(ByVal ID_lops As String) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return UDB.SelectTableSP("MARK_TochucThi_TotNghiep_Load", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_lops", ID_lops)
                Return UDB.SelectTableSP("MARK_TochucThi_TotNghiep_Load", para)
            End If
        End Function

        Public Function Load_ToChucThi_ChinhTri(ByVal ID_lops As String) As DataTable
            Dim para(0) As SqlParameter
            para(0) = New SqlParameter("@ID_lops", ID_lops)
            Return UDB.SelectTableSP("MARK_TochucThi_ChinhTri_Load", para)
        End Function

        Public Function Load_ToChucThi_LamLuanVan_Load(ByVal ID_lops As String) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return UDB.SelectTableSP("MARK_TochucThi_LamLuanVan_Load", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_lops", ID_lops)
                Return UDB.SelectTableSP("MARK_TochucThi_TotNghiep_Load", para)
            End If
        End Function

        Public Function Load_DiemThi_ChinhTri(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("MARK_DiemChinhTri_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_SinhVienThiChinhTri(ByVal ID_sv As Integer, ByVal Diem_thi As Double) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Diem_thi", Diem_thi)
                Return UDB.ExecuteSP("Mark_SinhVienThiChinhTri_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DELETE_SinhVienThiChinhTri(ByVal ID_lop As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.ExecuteSP("Mark_SinhVienThiChinhTri_DELETE", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


