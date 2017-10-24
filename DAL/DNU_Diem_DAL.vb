'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An Technology
' Created Date : Sunday, May 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DNU_Diem_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "Function"
        Public Function Load_ThanhPhanMon(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_svThanhPhanMon_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_svThanhPhanMon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ThanhPhanMon(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_mon As Integer, ByVal Lan_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lops", ID_lops)
                    para(3) = New SqlParameter("@ID_mon", ID_mon)
                    para(4) = New SqlParameter("@ID_dv", ID_dv)
                    para(5) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    Return UDB.SelectTableSP("sp_svThanhPhanMonDiem_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter("@ID_lops", ID_lops)
                    para(3) = New OracleParameter("@ID_mon", ID_mon)
                    para(4) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svThanhPhanMonDiem_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemThanhPhan(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@ID_mon", ID_mon)
                    para(2) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Diem_List(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiem_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiem_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Diem_TongHop_List(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0, Optional ByVal dsID_dt As String = "") As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    para(6) = New SqlParameter("@dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("sp_svDiemTongHop_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    para(6) = New OracleParameter(":dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("sp_svDiemTongHop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Diem_TongHopTinChi_List(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lop_tc As Integer, ByVal ID_mon_tc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", ID_dv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(3) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(4) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemTinChiTongHop_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(4) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemTinChiTongHop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhongDuDKDuThiDiemTP_List(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", ID_dv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(3) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svKhongDuDKDuThiDiemTPTongHop_List", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svKhongDuDKDuThiDiemTPTongHop_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemThi_List(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemThi_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemThi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemThanhPhan_List(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                    para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemThi(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThi_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@ID_mon", ID_mon)
                    para(2) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemQuyDoi() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svDiemQuyDoi_List")
                Else
                    Return UDB.SelectTableSP("sp_svDiemQuyDoi_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepLoaiHocTap() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svXepLoaiHocTap_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_svXepLoaiHocTap_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepLoaiChungChi() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svXepLoaiChungChi_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_svXepLoaiChungChi_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangHocLuc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svXepHangHocLuc_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_svXepHangHocLuc_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangNamDaoTao() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svXepHangNamDaoTao_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_svXepHangNamDaoTao_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Get_KyTichLuy(ByVal ID_sv As Long) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_svDanhSachNganh2_GetKy_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_svDanhSachNganh2_GetKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangTotNghiep() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svXepHangTotNghiep_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_svXepHangTotNghiep_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_Diem(ByVal obj As Diem) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", obj.ID_dv)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(3) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(4) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    Return UDB.SelectTableSP("sp_svDiem_Insert", para).Rows(0)(0)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", obj.ID_dv)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(4) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.SelectTableSP("sp_svDiem_Insert", para).Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Khi chuyen mon tu chuong trinh dao tao nay sang CTDT khac; update lai diem
        Public Function CheckExist_DiemChuyenKy(ByVal obj As Diem) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_dv", obj.ID_dv)
                    dt = UDB.SelectTableSP("sp_svDiemChuyenKy_Check", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_dv", obj.ID_dv)
                    dt = UDB.SelectTableSP("sp_svDiemChuyenKy_Check", para)
                    Return dt.Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemChuyenKy(ByVal obj As Diem) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", obj.ID_dv)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(3) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(4) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    Return UDB.SelectTableSP("sp_svDiemChuyenKy_Update", para).Rows(0)(0)
                    'Dim dt As DataTable = UDB.SelectTableSP("sp_svDiemChuyenKy_Update", para)
                    'If dt.Rows.Count > 0 Then
                    '    Return dt.Rows(0)(0)
                    'Else
                    '    Return 0
                    'End If
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", obj.ID_dv)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(4) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.SelectTableSP("sp_svDiemChuyenKy_Update", para).Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Diem(ByVal obj As Diem, ByVal ID_diem As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@ID_dv", obj.ID_dv)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(4) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(5) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(6) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("sp_svDiem_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_dv", obj.ID_dv)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(4) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(5) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(6) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("sp_svDiem_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Diem(ByVal ID_diem As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    Return UDB.ExecuteSP("sp_svDiem_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    Return UDB.ExecuteSP("sp_svDiem_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemThi(ByVal ID_diem As Integer, ByVal obj As DiemThi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                    para(3) = New SqlParameter("@Diem_thi", obj.Diem_thi)
                    para(4) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(5) = New SqlParameter("@Locked", obj.Locked)
                    para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(7) = New SqlParameter("@TBCHP", obj.TBCHP)
                    Return UDB.ExecuteSP("sp_svDiemThi_Insert", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", obj.Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", obj.Lan_thi)
                    para(3) = New OracleParameter(":Diem_thi", obj.Diem_thi)
                    para(4) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(5) = New OracleParameter(":Locked", obj.Locked)
                    para(6) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(7) = New OracleParameter(":TBCHP", obj.TBCHP)
                    Return UDB.ExecuteSP("sp_svDiemThi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThi(ByVal obj As DiemThi, ByVal ID_diem As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(3) = New SqlParameter("@Diem_thi", obj.Diem_thi)
                    para(4) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(5) = New SqlParameter("@Locked", obj.Locked)
                    para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(7) = New SqlParameter("@TBCHP", obj.TBCHP)
                    Return UDB.ExecuteSP("sp_svDiemThi_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", obj.Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Diem_thi", obj.Diem_thi)
                    para(4) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(5) = New OracleParameter(":Locked", obj.Locked)
                    para(6) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(7) = New OracleParameter(":TBCHP", obj.TBCHP)
                    Return UDB.ExecuteSP("sp_svDiemThi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThiLock(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(3) = New SqlParameter("@Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LockDiem(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(3) = New SqlParameter("@Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function Lock_UnLock_Diem(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal Locked As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(3) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(4) = New SqlParameter("@Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(3) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(4) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UnLockDiem(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(3) = New SqlParameter("@Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThiLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemThi(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    Return UDB.ExecuteSP("sp_svDiemThi_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    Return UDB.ExecuteSP("sp_svDiemThi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemThi(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                    dt = UDB.SelectTableSP("sp_svDiemThi_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    dt = UDB.SelectTableSP("sp_svDiemThi_CheckExist", para)
                    Return dt.Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemDanh(ByVal ID_diem As Integer, ByVal obj As DiemDanh) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                    para(2) = New SqlParameter("@So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(4) = New SqlParameter("@Locked_dd", obj.Locked_dd)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(6) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", obj.Lan_hoc)
                    para(2) = New OracleParameter(":So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(4) = New OracleParameter(":Locked_dd", obj.Locked_dd)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(6) = New OracleParameter(":Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemDanh(ByVal obj As DiemDanh, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(4) = New SqlParameter("@Locked_dd", obj.Locked_dd)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(6) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(4) = New OracleParameter(":Locked_dd", obj.Locked_dd)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(6) = New OracleParameter(":Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemDanh(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("sp_svDiemDanh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemDanh(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("sp_svDiemDanh_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(1) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("sp_svDiemDanh_CheckExist", para)
                    Return dt.Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                    para(2) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("sp_svDiemThanhPhan_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("sp_svDiemThanhPhan_CheckExist", para)
                    Return dt.Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemThanhPhan(ByVal ID_diem As Integer, ByVal obj As DiemThanhPhan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                    para(2) = New SqlParameter("@ID_thanh_phan", obj.ID_thanh_phan)
                    para(3) = New SqlParameter("@Diem", obj.Diem)
                    para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(5) = New SqlParameter("@Ty_le", obj.Ty_le)
                    para(6) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(7) = New SqlParameter("@Locked_tp", obj.Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Insert", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", obj.Lan_hoc)
                    para(2) = New OracleParameter(":ID_thanh_phan", obj.ID_thanh_phan)
                    para(3) = New OracleParameter(":Diem", obj.Diem)
                    para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(5) = New OracleParameter(":Ty_le", obj.Ty_le)
                    para(6) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(7) = New OracleParameter(":Locked_tp", obj.Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThanhPhan(ByVal obj As DiemThanhPhan, ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                    para(3) = New SqlParameter("@Diem", obj.Diem)
                    para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(5) = New SqlParameter("@Ty_le", obj.Ty_le)
                    para(6) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(7) = New SqlParameter("@Locked_tp", obj.Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(3) = New OracleParameter(":Diem", obj.Diem)
                    para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(5) = New OracleParameter(":Ty_le", obj.Ty_le)
                    para(6) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(7) = New OracleParameter(":Locked_tp", obj.Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThanhPhanLock(ByVal ID_diem As Integer, ByVal Locked As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhanLock_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhanLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                    para(2) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("sp_svDiemThanhPhan_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSinhVienInfor_DiemExcel(ByVal ID_mon As Integer, ByVal Ma_sv As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svGetSinhVienInfor", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("sp_svGetSinhVienInfor", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDiemThanhPhanSinhVien_DiemExcel(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_thanh_phan As Integer, ByVal ID_dv As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                    para(3) = New SqlParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Excel_GetDiemSinhVien", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(3) = New OracleParameter(":ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiemThanhPhan_Excel_GetDiemSinhVien", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDiemSinhVien_DiemExcel(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dv As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiem_Excel_GetDiemSinhVien", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    Return UDB.SelectTableSP("sp_svDiem_Excel_GetDiemSinhVien", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_DT2_DiemExcel(ByVal ID_mon As Integer, ByVal Ma_sv As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)

                    Dim dt As DataTable = UDB.SelectTableSP("sp_svGetID_DT2", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_dt")
                    Else
                        Return 0
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)

                    Dim dt As DataTable = UDB.SelectTableSP("sp_svGetID_DT2", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_dt")
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckMucKyLuat_HaLoaiTotNghiep(ByVal ID_sv As Integer, ByVal Muc_xu_ly As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Muc_xu_ly", Muc_xu_ly)

                    Dim dt As DataTable = UDB.SelectTableSP("sp_svMucKyLuat_Check_HaLoaiTotNghiep", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Muc_xu_ly", Muc_xu_ly)

                    Dim dt As DataTable = UDB.SelectTableSP("sp_svMucKyLuat_Check_HaLoaiTotNghiep", para)
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

        Public Function LoaLoaiChungChi_DSMon(ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                    Return UDB.SelectTableSP("sp_svLoaiChungChi_DSMonChungChi_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_chung_chi", ID_chung_chi)
                    Return UDB.SelectTableSP("sp_svLoaiChungChi_DSMonChungChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DiemKyHieu_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_svDiemKyHieu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhanLoaiKetQuaHocTap(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_svPhanLoaiKetQuaHocTap_Lop_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("sp_svPhanLoaiKetQuaHocTap_Lop_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

        Public Function getID_Diem(ByVal ID_dv As String, ByVal ID_mon As Integer, ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", ID_dv)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_dt", ID_dt)
                    para(3) = New SqlParameter("@ID_sv", ID_sv)
                    Dim dt As DataTable = UDB.SelectTableSP("sp_svDiem_ID_diem", para)
                    If dt.Rows.Count > 0 Then Return dt.Rows(0)("ID_diem")
                    Return 0
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_dt", ID_dt)
                    para(3) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_svDiem_ID_diem", para).Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetID_DT(ByVal ID_SV As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_SV", ID_SV)
                    dt = UDB.SelectTableSP("sp_svGetID_dt", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_DT")
                    Else
                        Return 0
                    End If
                Else
                    Dim para(0) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_SV", ID_SV)
                    dt = UDB.SelectTableSP("sp_svGetID_dt", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_DT")
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Function TongHop_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
        '    Try
        '        Dim para(5) As SqlParameter
        '        para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
        '        para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
        '        para(2) = New SqlParameter("@ID_he", ID_he)
        '        para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
        '        para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
        '        para(5) = New SqlParameter("@ID_lop", ID_lop)
        '        Return UDB.SelectTableSP("sp_svDanhSach_TongHop_HocLai_Tungnk", para)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Function TongHop_ThiLai(ByVal Lan_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_he", ID_he)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("sp_svDanhSach_TongHop_ThiLai_Vinhnx", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function TongHop_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("Mark_DanhSach_TongHop_HocLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace