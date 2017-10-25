'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, May 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class Diem_DAL

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
                    Return UDB.SelectTableSP("MARK_ThanhPhanMon_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("MARK_ThanhPhanMon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ThanhPhanMon(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_mon As Integer, Optional ByVal Lan_hoc As Integer = 1) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lops", ID_lops)
                    para(3) = New SqlParameter("@ID_mon", ID_mon)
                    para(4) = New SqlParameter("@ID_dv", ID_dv)
                    para(5) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    Return UDB.SelectTableSP("MARK_ThanhPhanMonDiem_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter("@ID_lops", ID_lops)
                    para(3) = New OracleParameter("@ID_mon", ID_mon)
                    para(4) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("MARK_ThanhPhanMonDiem_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@ID_mon", ID_mon)
                    para(2) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_Diem_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_Diem_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemTongHop_Load_List", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    para(6) = New OracleParameter(":dsID_dt", dsID_dt)
                    Return UDB.SelectTableSP("MARK_DiemTongHop_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemTinChiTongHop_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(4) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_DiemTinChiTongHop_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_KhongDuDKDuThiDiemTPTongHop_List", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(3) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_KhongDuDKDuThiDiemTPTongHop_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemThi_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_DiemThi_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    para(3) = New OracleParameter(":dsID_lop", dsID_lop)
                    para(4) = New OracleParameter(":dsID_sv", dsID_sv)
                    para(5) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Load_List", para)
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
                    Return UDB.SelectTableSP("MARK_DiemThi_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@ID_mon", ID_mon)
                    para(2) = New OracleParameter("@ID_dv", ID_dv)
                    Return UDB.SelectTableSP("MARK_DiemThi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemQuyDoi() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_DiemQuyDoi_List")
                Else
                    Return UDB.SelectTableSP("MARK_DiemQuyDoi_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepLoaiHocTap() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTap_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTap_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepLoaiChungChi() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepLoaiChungChi_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepLoaiChungChi_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangHocLuc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepHangHocLuc_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepHangHocLuc_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangNamDaoTao() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepHangNamDaoTao_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepHangNamDaoTao_Load_List")
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
                    Return UDB.SelectTableSP("STU_DanhSachNganh2_GetKy_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_DanhSachNganh2_GetKy_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_XepHangTotNghiep() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepHangTotNghiep_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepHangTotNghiep_Load_List")
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
                    Return UDB.SelectTableSP("MARK_Diem_Insert", para).Rows(0)(0)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", obj.ID_dv)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(4) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.SelectTableSP("MARK_Diem_Insert", para).Rows(0)(0)
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
                    dt = UDB.SelectTableSP("MARK_DiemChuyenKy_Check", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_dv", obj.ID_dv)
                    dt = UDB.SelectTableSP("MARK_DiemChuyenKy_Check", para)
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
                    Return UDB.SelectTableSP("MARK_DiemChuyenKy_Update", para).Rows(0)(0)
                    'Dim dt As DataTable = UDB.SelectTableSP("MARK_DiemChuyenKy_Update", para)
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
                    Return UDB.SelectTableSP("MARK_DiemChuyenKy_Update", para).Rows(0)(0)
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
                    Return UDB.ExecuteSP("MARK_Diem_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_dv", obj.ID_dv)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(4) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(5) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(6) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("MARK_Diem_Update", para)
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
                    Return UDB.ExecuteSP("MARK_Diem_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    Return UDB.ExecuteSP("MARK_Diem_Delete", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThi_Insert", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThi_Insert", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThi_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_GhiChu_KhongDuDK(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Id_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                Return UDB.ExecuteSP("MARK_DiemThi_Update_KhongDuDK", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_GhiChu_NhapHocMuon(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Id_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                Return UDB.ExecuteSP("MARK_DiemThi_Update_NhapHocMuon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThi_KhongDuDK(ByVal objDiemThi As DiemThi, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Id_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                para(3) = New SqlParameter("@Ghi_chu", objDiemThi.Ghi_chu)
                Return UDB.ExecuteSP("MARK_Update_GhiChu_KhongDuDK", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThi_NhapHocMuon(ByVal objDiemThi As DiemThi, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Id_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                para(3) = New SqlParameter("@Ghi_chu", objDiemThi.Ghi_chu)
                Return UDB.ExecuteSP("MARK_Update_GhiChu_NhapHocMuon", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(3) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(4) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("MARK_DiemLock_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Lock_Diem_Nhanh(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Id_khoa As Integer = 0, Optional ByVal Id_chuyen_nganh As Integer = 0, Optional ByVal Id_lop As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Id_chuyen_nganh", Id_chuyen_nganh)
                para(4) = New SqlParameter("@Id_lop", Id_lop)
                para(5) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.ExecuteSP("Mark_Lock_Diem_Nhanh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Lock_Diem_TP_Nhanh(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Id_khoa As Integer = 0, Optional ByVal Id_chuyen_nganh As Integer = 0, Optional ByVal Id_lop As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Id_chuyen_nganh", Id_chuyen_nganh)
                para(4) = New SqlParameter("@Id_lop", Id_lop)
                para(5) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.ExecuteSP("Mark_Lock_Diem_TP_Nhanh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UnLock_Diem_Nhanh(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Id_khoa As Integer = 0, Optional ByVal Id_chuyen_nganh As Integer = 0, Optional ByVal Id_lop As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Id_chuyen_nganh", Id_chuyen_nganh)
                para(4) = New SqlParameter("@Id_lop", Id_lop)
                para(5) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.ExecuteSP("Mark_UnLock_Diem_Nhanh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UnLock_Diem_TP_Nhanh(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Id_khoa As Integer = 0, Optional ByVal Id_chuyen_nganh As Integer = 0, Optional ByVal Id_lop As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Id_chuyen_nganh", Id_chuyen_nganh)
                para(4) = New SqlParameter("@Id_lop", Id_lop)
                para(5) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.ExecuteSP("Mark_UnLock_Diem_TP_Nhanh", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(3) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("MARK_DiemThiLock_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThi_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    Return UDB.ExecuteSP("MARK_DiemThi_Delete", para)
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
                    dt = UDB.SelectTableSP("MARK_DiemThi_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":Lan_thi", Lan_thi)
                    dt = UDB.SelectTableSP("MARK_DiemThi_CheckExist", para)
                    Return dt.Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemDanh(ByVal ID_diem As Integer, ByVal obj As DiemDanh) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                    para(2) = New SqlParameter("@So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(4) = New SqlParameter("@Locked_dd", obj.Locked_dd)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(6) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    para(7) = New SqlParameter("@So_tiet_nghi_th", obj.So_tiet_nghi_th)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", obj.Lan_hoc)
                    para(2) = New OracleParameter(":So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(4) = New OracleParameter(":Locked_dd", obj.Locked_dd)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(6) = New OracleParameter(":Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemDanh(ByVal obj As DiemDanh, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(4) = New SqlParameter("@Locked_dd", obj.Locked_dd)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(6) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    para(7) = New SqlParameter("@So_tiet_nghi_th", obj.So_tiet_nghi_th)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(4) = New OracleParameter(":Locked_dd", obj.Locked_dd)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(6) = New OracleParameter(":Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemDanh_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Delete", para)
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
                    dt = UDB.SelectTableSP("MARK_DiemDanh_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(1) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("MARK_DiemDanh_CheckExist", para)
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
                    dt = UDB.SelectTableSP("MARK_DiemThanhPhan_CheckExist", para)
                    Return dt.Rows.Count
                Else
                    Dim para(2) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    dt = UDB.SelectTableSP("MARK_DiemThanhPhan_CheckExist", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Insert", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Insert", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhanLock_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Locked", Locked)
                    Return UDB.ExecuteSP("MARK_DiemThanhPhanLock_Update", para)
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
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(2) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("MARK_DiemThanhPhan_Delete", para)
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
                    Return UDB.SelectTableSP("STU_GetSinhVienInfor", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("STU_GetSinhVienInfor", para)
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
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Excel_GetDiemSinhVien", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_thanh_phan", ID_thanh_phan)
                    para(3) = New OracleParameter(":ID_dv", ID_dv)
                    Return UDB.SelectTableSP("MARK_DiemThanhPhan_Excel_GetDiemSinhVien", para)
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
                    Return UDB.SelectTableSP("MARK_Diem_Excel_GetDiemSinhVien", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_dv", ID_dv)
                    Return UDB.SelectTableSP("MARK_Diem_Excel_GetDiemSinhVien", para)
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

                    Dim dt As DataTable = UDB.SelectTableSP("STU_GetID_DT2", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_dt")
                    Else
                        Return 0
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)

                    Dim dt As DataTable = UDB.SelectTableSP("STU_GetID_DT2", para)
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

                    Dim dt As DataTable = UDB.SelectTableSP("STU_MucKyLuat_Check_HaLoaiTotNghiep", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Muc_xu_ly", Muc_xu_ly)

                    Dim dt As DataTable = UDB.SelectTableSP("STU_MucKyLuat_Check_HaLoaiTotNghiep", para)
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
                    Return UDB.SelectTableSP("MARK_LoaiChungChi_DSMonChungChi_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_chung_chi", ID_chung_chi)
                    Return UDB.SelectTableSP("MARK_LoaiChungChi_DSMonChungChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DiemKyHieu_List() As DataTable
            Try
                Return UDB.SelectTableSP("MARK_DiemKyHieu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhanLoaiKetQuaHocTap(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_PhanLoaiKetQuaHocTap_Lop_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_PhanLoaiKetQuaHocTap_Lop_List", para)
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
                    Dim dt As DataTable = UDB.SelectTableSP("MARK_Diem_ID_diem", para)
                    If dt.Rows.Count > 0 Then Return dt.Rows(0)("ID_diem")
                    Return 0
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_dt", ID_dt)
                    para(3) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("MARK_Diem_ID_diem", para).Rows(0)(0)
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
                    dt = UDB.SelectTableSP("MARK_GetID_dt", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0).Item("ID_DT")
                    Else
                        Return 0
                    End If
                Else
                    Dim para(0) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":ID_SV", ID_SV)
                    dt = UDB.SelectTableSP("MARK_GetID_dt", para)
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
        Public Function Load_Diem_Theo_Mon_REPORT_CDN(ByVal dsID_lop As String, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dt As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsIDLop", dsID_lop)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    dt = UDB.SelectTableSP("MARK_DIEM_LOAD_LIST_QD62", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        Public Function Load_BANGDIEM_REPORT(ByVal ID_sv As Integer) As DataTable
            Dim dt As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    dt = UDB.SelectTableSP("MARK_BANGDIEM_REPORT", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        'Cao dang nghe HN
        Public Function Load_ThanhPhan_HocBu(ByVal Lan_hoc As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Dim dt As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(1) = New SqlParameter("@id_lops", ID_lops)
                    para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(4) = New SqlParameter("@ID_mon", ID_mon)
                    dt = UDB.SelectTableSP("MARK_THANHPHANDIEM_HOCBU", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        Public Function Load_Diem_thanhPhan_Single(ByVal Lan_hoc As Integer, ByVal ID_lops As String, ByVal ID_thanh_phan As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Dim dt As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(1) = New SqlParameter("@id_lops", ID_lops)
                    para(2) = New SqlParameter("@id_thanh_phan", ID_thanh_phan)
                    para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(5) = New SqlParameter("@ID_mon", ID_mon)
                    dt = UDB.SelectTableSP("MARK_HOCBU_Load_DiemTP_Single", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        Public Function Update_DiemKiemTraBu(ByVal id_diem_tp As Integer, ByVal Diem As Single, ByVal Lan_kiem_tra As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@id_diem_tp", id_diem_tp)
                    para(1) = New SqlParameter("@Diem", Diem)
                    para(2) = New SqlParameter("@lan_kiem_tra", Lan_kiem_tra)
                    Return UDB.ExecuteSP("MARK_KIEMTRABU_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemKiemTraBu(ByVal id_diem_tp As Integer, ByVal Diem As Single, ByVal Lan_kiem_tra As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@id_diem_tp", id_diem_tp)
                    para(1) = New SqlParameter("@Diem", Diem)
                    para(2) = New SqlParameter("@lan_kiem_tra", Lan_kiem_tra)
                    Return UDB.ExecuteSP("MARK_KIEMTRABU_INSERT", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemKiemTraBu(ByVal id_diem_tp As Integer, ByVal Lan_kiem_tra As Integer) As Boolean
            Dim dt As DataTable = Nothing
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@id_diem_tp", id_diem_tp)
                    para(1) = New SqlParameter("@lan_kiem_tra", Lan_kiem_tra)
                    dt = UDB.SelectTableSP("MARK_KIEMTRABU_CheckExist", para)
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
        Public Function Load_HocBu(ByVal Lan_hoc As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Dim dt As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(1) = New SqlParameter("@id_lops", ID_lops)
                    para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(4) = New SqlParameter("@ID_mon", ID_mon)
                    dt = UDB.SelectTableSP("[MARK_HOCBU_Load_So_Tiet]", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function
        Public Function Insert_HocBu(ByVal id_diem As Integer, ByVal So_tiet_hoc_lt As Integer, ByVal So_tiet_hoc_th As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@id_diem", id_diem)
                    para(1) = New SqlParameter("@So_tiet_hoc_lt", So_tiet_hoc_lt)
                    para(2) = New SqlParameter("@So_tiet_hoc_th", So_tiet_hoc_th)
                    para(3) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    Return UDB.ExecuteSP("MARK_HOCBU_INSERT", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemDanh_NEW(ByVal obj As DiemDanh, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem", ID_diem)
                    para(1) = New SqlParameter("@Lan_hoc", Lan_hoc)
                    para(2) = New SqlParameter("@So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New SqlParameter("@Hash_code", obj.Hash_code)
                    para(4) = New SqlParameter("@Locked_dd", obj.Locked_dd)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(6) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    para(7) = New SqlParameter("@So_tiet_nghi_th", obj.So_tiet_nghi_th)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Update_NEW", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem", ID_diem)
                    para(1) = New OracleParameter(":Lan_hoc", Lan_hoc)
                    para(2) = New OracleParameter(":So_tiet_nghi", obj.So_tiet_nghi)
                    para(3) = New OracleParameter(":Hash_code", obj.Hash_code)
                    para(4) = New OracleParameter(":Locked_dd", obj.Locked_dd)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(6) = New OracleParameter(":Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                    Return UDB.ExecuteSP("MARK_DiemDanh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'vinhnx
        Function DanhSachMon_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lops)
                Return UDB.SelectTableSP("Mark_DanhSach_MonHoc_HocLai_vinhnx", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function DanhSachSinhVien_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("Mark_TongHopTienHocLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Mark_TongHopTienHocLai(ByVal Id_Mon As Integer, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Id_Mon", Id_Mon)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@ID_lop", ID_lop)
                para(5) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("Mark_TongHopTienHocLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Function DanhSachSinhVien_ThiLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String)
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("Mark_TongHopTienThiLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function MARK_LietKeCacDiemThanhPhan_Load(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_LietKeCacDiemThanhPhan_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Load_DiemTP_TheoSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Id_lop As Integer, ByVal Id_mon As Integer, ByVal Lan_hoc As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Id_lop", Id_lop)
                para(3) = New SqlParameter("@Id_mon", Id_mon)
                para(4) = New SqlParameter("@Lan_hoc", Lan_hoc)
                Return UDB.SelectTableSP("rpt_MARK_DiemThanhPhan_TheoSV", para)
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
                Return UDB.SelectTableSP("Mark_DanhSach_TongHopHocLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        
#Region "Tong hop, Thong ke"
        Function dt_DanhSachLop(ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_khoa", ID_khoa)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_LOP", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function dt_DanhSachLop_CoDiem(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", Id_he)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_SINHVIEN_LOP_HK_NH", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Function dt_DanhSachSinhVienLop(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_SINHVIEN_LOP", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function dt_DanhSachSinhVienKhoa(ByVal ID_khoa As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_Khoa", ID_khoa)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_SINHVIEN_KHOA", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function dt_DanhSachSinhVienLop_HocKy_NamHoc(ByVal ID_lop As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_SINHVIEN_LOP_HK_NH", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function dt_DanhSachDiemTheoSinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_DIEM_LOP", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function dt_DanhSachDiemTheoSinhVien_MonTN(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return UDB.SelectTableSP("MARK_DanhSachDiem_MonTotNghiep", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function dt_DanhSachDiemTheoSinhVien_TheoNam(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_DIEM_THEONAM", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function dt_DSHocLai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_HOCLAI", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function dt_DSThiLai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_TONGHOP_DANHSACH_THILAI", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVien_NoTheoHocPhan(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("Mark_DanhSachSinhVien_NoTheoHocPhan", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

