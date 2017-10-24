Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class GoiNhaphoc_DAL
#Region "Constructor"
        Public Sub New()

        End Sub
#End Region
#Region "Function"
        Public Function LoadID_bien_lai(ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("ACC_BienLaiID_load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("ACC_BienLaiID_load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan phai nop
        Public Function KhoanNop(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_KhoanNop", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_KhoanNop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_KhoanDaNop", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_KhoanDaNop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_KhoanDaNopNamHoc", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    para(1) = New OracleParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_KhoanDaNopNamHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Các khoản da nop cua sinh vien theo id_sv
        Public Function KhoanDaNopCuaSinhVienTrongNam(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_KhoanDaNopCuaSinhVienTrongNam", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter("@ID_sv", ID_sv)
                    para(1) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_KhoanDaNop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_GoiNhapHoc_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_GoiNhapHoc_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_GoiNhapHoc_BoXung_List(ByVal dsID_sv As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_sv", dsID_sv)
                    Return UDB.SelectTableSP("STU_GoiNhapHoc_BoXung_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_sv", dsID_sv)
                    Return UDB.SelectTableSP("STU_GoiNhapHoc_BoXung_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật đăng ký học
        Public Sub UpdateDangKyHoc(ByVal objNhapHoc As GoiNhapHoc)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", objNhapHoc.ID_sv)
                    para(1) = New SqlParameter("@UserName_tiep_nhan", objNhapHoc.UserName_tiep_nhan)
                    If objNhapHoc.Ngay_nhap_hoc = Nothing Then
                        para(2) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                    Else
                        para(2) = New SqlParameter("@Ngay_nhap_hoc", objNhapHoc.Ngay_nhap_hoc)
                    End If
                    para(3) = New SqlParameter("@Dang_ky_hoc", objNhapHoc.Dang_ky_hoc)
                    para(4) = New SqlParameter("@UserID_tiep_nhan", objNhapHoc.UserID_tiep_nhan)
                    para(5) = New SqlParameter("@Lop", objNhapHoc.Lop)
                    para(6) = New SqlParameter("@Xep_loai_tot_nghiep", objNhapHoc.Xep_loai_tot_nghiep)
                    para(7) = New SqlParameter("@Nganh_tuyen_sinh", objNhapHoc.Nganh_tuyen_sinh)
                    UDB.ExecuteSP("STU_UpdateNhapHoc", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", objNhapHoc.ID_sv)
                    para(1) = New OracleParameter(":UserName_tiep_nhan", objNhapHoc.UserName_tiep_nhan)
                    para(2) = New OracleParameter(":Ngay_nhap_hoc", objNhapHoc.Ngay_nhap_hoc)
                    para(3) = New OracleParameter(":Dang_ky_hoc", objNhapHoc.Dang_ky_hoc)
                    para(4) = New OracleParameter(":UserID_tiep_nhan", objNhapHoc.UserID_tiep_nhan)
                    para(5) = New OracleParameter("@Lop", objNhapHoc.Lop)
                    para(6) = New OracleParameter("@Xep_loai_tot_nghiep", objNhapHoc.Xep_loai_tot_nghiep)
                    para(7) = New OracleParameter("@Nganh_tuyen_sinh", objNhapHoc.Nganh_tuyen_sinh)
                    UDB.ExecuteSP("STU_UpdateNhapHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub DeleteDangKyHoc(ByVal objNhapHoc As GoiNhapHoc)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", objNhapHoc.ID_sv)
                    UDB.Execute("STU_DeleteNhapHoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", objNhapHoc.ID_sv)
                    UDB.Execute("STU_DeleteNhapHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

        Function GetThongTinLop(ByVal ID_lop As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.SelectTableSP("STU_GoiNhapHoc_ThongTinLop", para)
                Else
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function GetSoSinhVien_Lop(ByVal ID_lop As Integer) As Integer
            Dim dtdata As New DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    dtdata = UDB.SelectTableSP("STU_DanhSach_SySo", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    dtdata = UDB.SelectTableSP("STU_DanhSach_SySo", para)
                End If
                If dtdata.Rows.Count > 0 Then
                    Return dtdata.Rows(0).Item(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Function LoadSinhVien_DaNhap_Lop(ByVal Khoa_hoc As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.SelectTableSP("STU_GoiNhapHoc_Roi_Load_List", para)
                Else
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

