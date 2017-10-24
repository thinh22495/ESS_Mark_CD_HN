'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, July 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class BienLaiThu_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_BienLaiChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                    para(4) = New SqlParameter("@Thu_chi", Thu_chi)
                    para(5) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiChi_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(3) = New OracleParameter(":ID_thu_chi", ID_thu_chi)
                    para(4) = New OracleParameter("@Thu_chi", Thu_chi)
                    para(5) = New OracleParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachSv(ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_DoiTuong_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_DoiTuong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_Khoa(ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Lop_Load_Khoa_hoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Lop_Load_Khoa_hoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSach_ThuChi_List(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_Load_DanhSach_ThuChi_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_Load_DanhSach_ThuChi_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu(ByVal ID_bien_lai As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                    para(4) = New SqlParameter("@Thu_chi", Thu_chi)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(3) = New OracleParameter(":ID_thu_chi", ID_thu_chi)
                    para(4) = New OracleParameter("@Thu_chi", Thu_chi)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThuChiTiet(ByVal ID_bien_lai As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    Return UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    Return UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThuChiTiet_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                    para(4) = New SqlParameter("@Thu_chi", Thu_chi)
                    Return UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(3) = New OracleParameter(":ID_thu_chi", ID_thu_chi)
                    para(4) = New OracleParameter("@Thu_chi", Thu_chi)
                    Return UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhoanNop_HocKy_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_KhoanNop_HocKy_SinhVien_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_thu_chi", ID_sv)
                    Return UDB.SelectTableSP("STU_KhoanNop_HocKy_SinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachSinhVienKhoanNop_HocKy_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_KhoanNop_HocKy_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_KhoanNop_HocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_MonDaThu_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangDaThu_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_thu_chi", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangDaThu_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_MonDangKy_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                    para(3) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangKy_Load_List", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", Dot_thu)
                    para(3) = New OracleParameter(":ID_thu_chi", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_MonDangKyDanhSach_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                    para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangKyDanhSach_Load_List", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", Dot_thu)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("ACC_BienLaiThu_MonDangKyDanhSach_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSo_phieu() As Long
            Dim intID_bien_lai As Integer = getMaxID_bien_lai()
            Dim dtdata As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", intID_bien_lai)
                    dtdata = UDB.SelectTableSP("ACC_BienLaiThu_GetSoPhieu", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", intID_bien_lai)
                    dtdata = UDB.SelectTableSP("ACC_BienLaiThu_GetSoPhieu", para)
                End If
                If dtdata.Rows.Count > 0 Then
                    Return dtdata.Rows(0).Item(0) + 1
                Else
                    Return 1
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Private Function getMaxID_bien_lai() As Long
            Try
                Dim dtData As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    dtData = UDB.SelectTableSP("ACC_BienLaiThu_GetMaxID")
                Else
                    dtData = UDB.SelectTableSP("ACC_BienLaiThu_GetMaxID")
                End If
                If dtData.Rows(0).Item(0).ToString = "" Then
                    Return 0
                Else
                    Return dtData.Rows(0).Item(0)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Public Function getID_sv(ByVal Ma_sv As String) As Long
            Dim dtData As New DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                dtData = UDB.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                dtData = UDB.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
            End If
            If dtData.Rows.Count > 0 Then
                Return dtData.Rows(0).Item(0)
            Else
                Return 0
            End If
        End Function
        Public Function getID_bien_lai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                    para(3) = New SqlParameter("@Lan_thu", Lan_thu)
                    para(4) = New SqlParameter("@ID_sv", ID_sv)
                    para(5) = New SqlParameter("@Thu_chi", Thu_chi)
                    para(6) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThu_getID_bien_lai", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":Dot_thu", Dot_thu)
                    para(3) = New OracleParameter(":Lan_thu", Lan_thu)
                    para(4) = New OracleParameter(":ID_sv", ID_sv)
                    para(5) = New OracleParameter(":Thu_chi", Thu_chi)
                    para(6) = New OracleParameter(":ID_thu_chi", ID_thu_chi)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThu_getID_bien_lai", para)
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
        Public Function Insert_BienLaiThu(ByVal obj As BienLaiThu) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(15) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@Dot_thu", obj.Dot_thu)
                    para(3) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                    para(4) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(5) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                    para(6) = New SqlParameter("@So_phieu", obj.So_phieu)
                    para(7) = New SqlParameter("@Ngay_thu", obj.Ngay_thu)
                    para(8) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(9) = New SqlParameter("@So_tien", obj.So_tien)
                    para(10) = New SqlParameter("@So_tien_chu", obj.So_tien_chu)
                    para(11) = New SqlParameter("@Ngoai_te", obj.Ngoai_te)
                    para(12) = New SqlParameter("@Huy_phieu", obj.Huy_phieu)
                    para(13) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(14) = New SqlParameter("@Nguoi_thu", obj.Nguoi_thu)
                    para(15) = New SqlParameter("@Printed", obj.Printed)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThu_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(15) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":Dot_thu", obj.Dot_thu)
                    para(3) = New OracleParameter(":Lan_thu", obj.Lan_thu)
                    para(4) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(5) = New OracleParameter(":Thu_chi", obj.Thu_chi)
                    para(6) = New OracleParameter(":So_phieu", obj.So_phieu)
                    para(7) = New OracleParameter(":Ngay_thu", obj.Ngay_thu)
                    para(8) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(9) = New OracleParameter(":So_tien", obj.So_tien)
                    para(10) = New OracleParameter(":So_tien_chu", obj.So_tien_chu)
                    para(11) = New OracleParameter(":Ngoai_te", obj.Ngoai_te)
                    para(12) = New OracleParameter(":Huy_phieu", obj.Huy_phieu)
                    para(13) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(14) = New OracleParameter(":Nguoi_thu", obj.Nguoi_thu)
                    para(15) = New OracleParameter(":Printed", obj.Printed)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThu_Insert", para)
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
        Public Function Update_BienLaiThu(ByVal obj As BienLaiThu, ByVal ID_bien_lai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(16) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Dot_thu", obj.Dot_thu)
                    para(4) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                    para(5) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(6) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                    para(7) = New SqlParameter("@So_phieu", obj.So_phieu)
                    para(8) = New SqlParameter("@Ngay_thu", obj.Ngay_thu)
                    para(9) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(10) = New SqlParameter("@So_tien", obj.So_tien)
                    para(11) = New SqlParameter("@So_tien_chu", obj.So_tien_chu)
                    para(12) = New SqlParameter("@Ngoai_te", obj.Ngoai_te)
                    para(13) = New SqlParameter("@Huy_phieu", obj.Huy_phieu)
                    para(14) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(15) = New SqlParameter("@Nguoi_thu", obj.Nguoi_thu)
                    para(16) = New SqlParameter("@Printed", obj.Printed)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_Update", para)
                Else
                    Dim para(16) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Dot_thu", obj.Dot_thu)
                    para(4) = New OracleParameter(":Lan_thu", obj.Lan_thu)
                    para(5) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(6) = New OracleParameter(":Thu_chi", obj.Thu_chi)
                    para(7) = New OracleParameter(":So_phieu", obj.So_phieu)
                    para(8) = New OracleParameter(":Ngay_thu", obj.Ngay_thu)
                    para(9) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(10) = New OracleParameter(":So_tien", obj.So_tien)
                    para(11) = New OracleParameter(":So_tien_chu", obj.So_tien_chu)
                    para(12) = New OracleParameter(":Ngoai_te", obj.Ngoai_te)
                    para(13) = New OracleParameter(":Huy_phieu", obj.Huy_phieu)
                    para(14) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(15) = New OracleParameter(":Nguoi_thu", obj.Nguoi_thu)
                    para(16) = New OracleParameter(":Printed", obj.Printed)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BienLaiThu_HuyPhieu(ByVal ID_bien_lai As Integer, ByVal Ly_do As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    para(1) = New SqlParameter("@Ly_do", Ly_do)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_HuyPhieu_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    para(1) = New OracleParameter(":Ly_do", Ly_do)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_HuyPhieu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThu(ByVal ID_bien_lai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    Return UDB.ExecuteSP("ACC_BienLaiThu_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_BienLaiThuChiTiet(ByVal obj As BienLaiThuChiTiet) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", obj.ID_bien_lai)
                    para(1) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                    para(2) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(3) = New SqlParameter("@So_tien", obj.So_tien)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", obj.ID_bien_lai)
                    para(1) = New OracleParameter(":ID_thu_chi", obj.ID_thu_chi)
                    para(2) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(3) = New OracleParameter(":So_tien", obj.So_tien)
                    Dim dt As DataTable = UDB.SelectTableSP("ACC_BienLaiThuChiTiet_Insert", para)
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
        Public Function Update_BienLaiThuChiTiet(ByVal obj As BienLaiThuChiTiet, ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai_sub", ID_bien_lai_sub)
                    para(1) = New SqlParameter("@ID_bien_lai", obj.ID_bien_lai)
                    para(2) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                    para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New SqlParameter("@So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai_sub", ID_bien_lai_sub)
                    para(1) = New OracleParameter(":ID_bien_lai", obj.ID_bien_lai)
                    para(2) = New OracleParameter(":ID_thu_chi", obj.ID_thu_chi)
                    para(3) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New OracleParameter(":So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThuChiTiet(ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai_sub", ID_bien_lai_sub)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai_sub", ID_bien_lai_sub)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThuChiTiet_IDBienLai(ByVal ID_bien_lai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_IDBienLai_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_bien_lai", ID_bien_lai)
                    Return UDB.ExecuteSP("ACC_BienLaiThuChiTiet_IDBienLai_Delete", para)
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
                    Return UDB.SelectTableSP("ACC_MucHocPhiTinChi_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("ACC_MucHocPhiTinChi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuHocKy(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopThuHocKy", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopThuHocKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuMonDangKy(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopThuMonDangKy", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopThuMonDangKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopDaNopHocPhi(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhi", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopDaNopHocPhi_TheoKy(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhi_TheoKy", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhi_TheoKy", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


