'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, October 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LoaiChungChiDanhSachMon_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DSSinhVienChungChi(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_LoaiChungChi_DSSinhVien_Load_List", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_LoaiChungChi_DSSinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_LoaiChungChiDanhSachMon(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("MARK_LoaiChungChiDanhSachMon_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("MARK_LoaiChungChiDanhSachMon_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal id_mon As Integer, ByVal id_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                    para(1) = New SqlParameter("@ID_mon", id_mon)
                    para(2) = New SqlParameter("@ID_dt", id_dt)
                    UDB.ExecuteSP("MARK_LoaiChungChiDanhSachMon_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_chung_chi", ID_chung_chi)
                    para(1) = New OracleParameter(":ID_mon", id_mon)
                    para(2) = New OracleParameter(":ID_dt", id_dt)
                    UDB.ExecuteSP("MARK_LoaiChungChiDanhSachMon_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                    para(1) = New SqlParameter("@ID_mon", ID_mon)
                    para(2) = New SqlParameter("@ID_dt", ID_dt)
                    UDB.ExecuteSP("MARK_LoaiChungChiDanhSachMon_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_chung_chi", ID_chung_chi)
                    para(1) = New OracleParameter(":ID_mon", ID_mon)
                    para(2) = New OracleParameter(":ID_dt", ID_dt)
                    UDB.ExecuteSP("MARK_LoaiChungChiDanhSachMon_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChungChiTheoSinhVien(ByVal obj As LoaiChungChiDanhSachMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(2) = New SqlParameter("@ID_chung_chi", obj.ID_chung_chi)
                    para(3) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                    para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                    para(5) = New SqlParameter("@TBCHT", obj.TBCHT)
                    UDB.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(2) = New OracleParameter(":ID_chung_chi", obj.ID_chung_chi)
                    para(3) = New OracleParameter(":Lan_xet", obj.Lan_xet)
                    para(4) = New OracleParameter(":ID_xep_loai", obj.ID_xep_loai)
                    para(5) = New OracleParameter(":TBCHT", obj.TBCHT)
                    UDB.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChungChiTheoSinhVien(ByVal obj As LoaiChungChiDanhSachMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(2) = New SqlParameter("@ID_chung_chi", obj.ID_chung_chi)
                    para(3) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                    UDB.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(2) = New OracleParameter(":ID_chung_chi", obj.ID_chung_chi)
                    para(3) = New OracleParameter(":Lan_xet", obj.Lan_xet)
                    UDB.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


