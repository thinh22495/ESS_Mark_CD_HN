Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachNganh2_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ChuongTrinhNganh2_List(ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachNganh2_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachNganh2_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhNganh2_List(ByVal Ma_sv As String, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(1) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(2) = New SqlParameter("@Ma_sv", Ma_sv)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVienNganh2_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(1) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(2) = New OracleParameter(":Ma_sv", Ma_sv)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVienNganh2_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachMonNganh1TrungNganh2_List(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt2 As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", ID_dv)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@ID_dt2", ID_dt2)
                    Return UDB.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":ID_dt2", ID_dt2)
                    Return UDB.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachMonNganh1TrungNganh2DaChon_List(ByVal ID_dv As String, ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dv", ID_dv)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2DaChon_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dv", ID_dv)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2DaChon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Get_IDDT(ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer, ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_IDDT_Get_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_IDDT_Get_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_STU_DanhSachNganh2(ByVal obj As DanhSachNganh2) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_dt", obj.ID_dt2)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@So_QD", obj.So_qd)
                    para(5) = New SqlParameter("@Ngay_QD", obj.Ngay_qd)
                    para(6) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(7) = New SqlParameter("@Ngung_hoc", obj.Ngung_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Insert", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_dt", obj.ID_dt2)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":So_QD", obj.So_qd)
                    para(5) = New OracleParameter(":Ngay_QD", obj.Ngay_qd)
                    para(6) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(7) = New OracleParameter(":Ngung_hoc", obj.Ngung_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachNganh2(ByVal obj As DanhSachNganh2, ByVal ID_dt_old As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_dt_old", ID_dt_old)
                    para(2) = New SqlParameter("@ID_dt", obj.ID_dt2)
                    para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(5) = New SqlParameter("@So_QD", obj.So_qd)
                    para(6) = New SqlParameter("@Ngay_QD", obj.Ngay_qd)
                    para(7) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(8) = New SqlParameter("@Ngung_hoc", obj.Ngung_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Update", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_dt_old", ID_dt_old)
                    para(2) = New OracleParameter(":ID_dt", obj.ID_dt2)
                    para(3) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(5) = New OracleParameter(":So_QD", obj.So_qd)
                    para(6) = New OracleParameter(":Ngay_QD", obj.Ngay_qd)
                    para(7) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(8) = New OracleParameter(":Ngung_hoc", obj.Ngung_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_SinhVienNganh2_NgungHoc(ByVal ID_sv As Integer, ByVal ID_dt2 As Integer, ByVal Ngung_Hoc As Boolean) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_dt", ID_dt2)
                    para(2) = New SqlParameter("@Ngung_Hoc", Ngung_Hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2NgungHoc_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_dt", ID_dt2)
                    para(2) = New OracleParameter(":Ngung_Hoc", Ngung_Hoc)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2NgungHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_STU_DanhSachNganh2(ByVal ID_sv As Integer, ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DanhSachNganh2_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function Load_SinhVienInfor(ByVal Ma_sv As String) As DataTable
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(0) As SqlParameter
        '            para(0) = New SqlParameter("@Ma_sv", Ma_sv)
        '            Return UDB.SelectTableSP("STU_SinhVienInfor_Load_List", para)
        '        Else
        '            Dim para(0) As OracleParameter
        '            para(0) = New OracleParameter(":Ma_sv", Ma_sv)
        '            Return UDB.SelectTableSP("STU_SinhVienInfor_Load_List", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
#End Region

    End Class
End Namespace


