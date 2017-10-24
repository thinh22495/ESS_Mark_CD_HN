'---------------------------------------------------------------------------
' Author : Tungnk
' Company : Thiên An ESS
' Created Date : Saturday, July 26, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachTotNghiep_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhSachTotNghiep_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachTOTNGHIEP_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachTOTNGHIEP_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DanhSachChuaTotNghiep_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachCHUATOTNGHIEP_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachCHUATOTNGHIEP_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DanhSachChungChiSinhVienNo(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("MARK_LoaiChungChiTheoSinhVienNo_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("MARK_LoaiChungChiTheoSinhVienNo_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DanhSachNoKhac(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("MARK_NoKhacKhiXetTotNghiep_NoXetTotNghiep", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("MARK_NoKhacKhiXetTotNghiep_NoXetTotNghiep", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachTotNghiep(ByVal obj As DanhSachTotNghiep) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", obj.ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(7) = New SqlParameter("@Diem_toan_khoa", obj.Diem_toan_khoa)
                Return UDB.ExecuteSP("STU_DanhSachTotNghiep_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachTotNghiep(ByVal obj As DanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(7) = New SqlParameter("@Diem_toan_khoa", obj.Diem_toan_khoa)
                Return UDB.ExecuteSP("STU_DanhSachTotNghiep_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachTotNghiep(ByVal ID_sv As Integer, ByVal Lan_thu As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_thu", Lan_thu)
                Return UDB.ExecuteSP("STU_DanhSachTotNghiep_Delete", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachChuaTotNghiep(ByVal obj As DanhSachTotNghiep) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                    para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(5) = New SqlParameter("@Diem_toan_khoa", obj.Diem_toan_khoa)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":TBCHT", obj.TBCHT)
                    para(2) = New OracleParameter(":ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(4) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachChuaTotNghiep(ByVal obj As DanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                    para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":TBCHT", obj.TBCHT)
                    para(2) = New OracleParameter(":ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachChuaTotNghiep_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Check_MonBatBuoc_SV_LuanVan_List(ByVal ID_SV As Integer, ByVal ID_dv As String, ByVal KhongKTra_NhungMon_TN As Integer, ByVal Van_hoa As Boolean) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", ID_SV)
                para(1) = New SqlParameter("@ID_dv", ID_dv)
                para(2) = New SqlParameter("@Ktra_Mon_TN", KhongKTra_NhungMon_TN)
                para(3) = New SqlParameter("@Van_hoa", Van_hoa)
                Return UDB.SelectTableSP("STU_DanhSachTotNghiep_Check_MonBatBuoc_LuanVan_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Check_MonBatBuoc_SV_List(ByVal ID_SV As Integer, ByVal ID_dv As String, ByVal KhongKTra_NhungMon_TN As Integer, ByVal Van_hoa As Boolean) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", ID_SV)
                para(1) = New SqlParameter("@ID_dv", ID_dv)
                para(2) = New SqlParameter("@Ktra_Mon_TN", KhongKTra_NhungMon_TN)
                para(3) = New SqlParameter("@Van_hoa", Van_hoa)
                Return UDB.SelectTableSP("STU_DanhSachTotNghiep_Check_MonBatBuoc_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_hieu", So_hieu)
                Return UDB.ExecuteSP("SoHieu_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_vao_so", So_vao_so)
                Return UDB.ExecuteSP("SoVaoSo_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_QuyetDinh(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_QD", So_QD)
                para(2) = New SqlParameter("@Ngay_QD", Ngay_QD)
                Return UDB.ExecuteSP("QuyetDinh_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_KHoa(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lock", Lock)
                Return UDB.ExecuteSP("TotNghiep_CapNhat_Lock", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_ChuaDat_TotNghiep(ByVal ID_lop As String, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lop)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("STU_DanhSach_ChuaDat_TotNghiep_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function BangDiem_ThiTotNghiep_SV(ByVal ID_lop As String, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lop)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("Mark_BangDiemThiTotNghiep_Load_LIST", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKeTotNghiep() As DataTable
            Try
                Return UDB.SelectTableSP("MARK_THONGKETOTNGHIEP")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

