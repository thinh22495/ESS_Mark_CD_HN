Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachXetLenLop_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhSachXetLenLop_List(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@ID_lops", ID_lops)
                    para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLop_Load_List", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":ID_lops", ID_lops)
                    para(4) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DanhSachNgungHocThoiHoc_Load_List(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Loai_qd As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@ID_lops", ID_lops)
                    para(4) = New SqlParameter("@Loai_qd", Loai_qd)
                    Return UDB.SelectTableSP("STU_DanhSachNgungHocThoiHoc_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":ID_lops", ID_lops)
                    para(4) = New OracleParameter(":Loai_qd", Loai_qd)
                    Return UDB.SelectTableSP("STU_DanhSachNgungHocThoiHoc_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Load_DanhSachHocTiepNganh2_List(ByVal ID_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLopNganh2_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_nganh", ID_nganh)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLopNganh2_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DanhSachHocTiep2Nganh_List(ByVal ID_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLop2Nganh_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_nganh", ID_nganh)
                    Return UDB.SelectTableSP("STU_DanhSachXetLenLop2Nganh_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_QuyetDinhThoiHoc(ByVal obj As DanhSachXetLenLop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@So_qd", obj.So_qd)
                    para(3) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                    para(4) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                    para(5) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Dim dt As DataTable = UDB.SelectTableSP("MARK_QuyetDinhThoiHoc_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":So_qd", obj.So_qd)
                    para(3) = New OracleParameter(":Ngay_qd", obj.Ngay_qd)
                    para(4) = New OracleParameter(":Loai_qd", obj.Loai_qd)
                    para(5) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHoc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyetDinhThoiHoc(ByVal obj As DanhSachXetLenLop, ByVal ID_qd As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_qd", ID_qd)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@So_qd", obj.So_qd)
                    para(4) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                    para(5) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                    para(6) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHoc_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_qd", ID_qd)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":So_qd", obj.So_qd)
                    para(4) = New OracleParameter(":Ngay_qd", obj.Ngay_qd)
                    para(5) = New OracleParameter(":Loai_qd", obj.Loai_qd)
                    para(6) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyetDinhThoiHoc(ByVal ID_qd As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_qd", ID_qd)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHoc_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_qd", ID_qd)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHoc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Danh sach chi tiet
        Public Function Insert_QuyetDinhThoiHocChiTiet(ByVal obj As DanhSachXetLenLop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_qd", obj.ID_qd)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_lop_cu", obj.ID_lop_cu)
                    para(3) = New SqlParameter("@ID_lop_moi", obj.ID_lop_moi)
                    para(4) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_qd", obj.ID_qd)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_lop_cu", obj.ID_lop_cu)
                    para(3) = New OracleParameter(":ID_lop_moi", obj.ID_lop_moi)
                    para(4) = New OracleParameter(":Loai_qd", obj.Loai_qd)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyetDinhThoiHocChiTiet(ByVal obj As DanhSachXetLenLop, ByVal ID_qd As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_qd", ID_qd)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@ID_lop_cu", obj.ID_lop_cu)
                    para(3) = New SqlParameter("@ID_lop_moi", obj.ID_lop_moi)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_qd", ID_qd)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":ID_lop_cu", obj.ID_lop_cu)
                    para(3) = New OracleParameter(":ID_lop_moi", obj.ID_lop_moi)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyetDinhThoiHocChiTiet(ByVal ID_qd As Integer, ByVal ID_sv As Integer, ByVal ID_lop_cu As Integer, ByVal Loai_QD As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_qd", ID_qd)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@ID_lop_cu", ID_lop_cu)
                    para(3) = New SqlParameter("@Loai_QD", Loai_QD)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_qd", ID_qd)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":ID_lop_cu", ID_lop_cu)
                    para(3) = New OracleParameter(":Loai_QD", Loai_QD)
                    Return UDB.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

