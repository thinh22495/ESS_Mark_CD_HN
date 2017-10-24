'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity

Namespace DBManager
    Public Class DanhSachSinhVien_DAL

#Region "Constructor"
        Public Sub New()

        End Sub
#End Region

#Region "Function"
        Public Function DanhSachSinhVien_LamThe(ByVal ID_lops As String) As DataTable
            Try
                Try
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(0) As SqlParameter
                        para(0) = New SqlParameter("@ID_lops", ID_lops)
                        Return UDB.SelectTableSP("STU_DanhSachSinhVien_LamThe", para)
                    Else
                        Dim para(0) As OracleParameter
                        para(0) = New OracleParameter(":ID_lops", ID_lops)
                        Return UDB.SelectTableSP("STU_DanhSachSinhVien_LamThe", para)
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật ảnh sinh viên    www
        Public Sub UpdateImage(ByVal ID_sv As Integer, ByVal ar() As Byte)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim p(1) As SqlParameter
                    p(0) = New SqlParameter("@ID_sv", SqlDbType.Int, 4)
                    If Not IsDBNull(ar) Then
                        p(1) = New SqlParameter("@Anh", SqlDbType.Image, ar.Length)
                    Else
                        p(1) = New SqlParameter("@Anh", SqlDbType.Image, 16)
                    End If
                    p(1).Value = ar
                    p(0).Value = ID_sv
                    UDB.ExecuteSP("STU_UpdateImage", p)
                Else
                    Dim p(1) As OracleParameter
                    p(0) = New OracleParameter(":ID_sv", OracleType.Int16, 4)
                    If Not IsDBNull(ar) Then
                        p(1) = New OracleParameter(":Anh", OracleType.Blob, ar.Length)
                    Else
                        p(1) = New OracleParameter(":Anh", OracleType.Blob, 16)
                    End If
                    p(1).Value = ar
                    p(0).Value = ID_sv
                    UDB.ExecuteSP("STU_UpdateImage", p)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Load_List_DanhSachSinhVien_List(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return UDB.SelectTableSP("STU_DanhSachSinhVien_Diem_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_SinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_Load_IDSV", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_Load_IDSV", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_List_DanhSachSinhVien_NotIn_List(ByVal ID_lops As String, ByVal ID_svs As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    para(1) = New SqlParameter("@ID_svs", ID_svs)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_NotIN_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    para(1) = New OracleParameter(":ID_svs", ID_svs)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien_NotIN_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_List_DanhSachSinhVien_List(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ma_sv As String, ByVal SBD As String, ByVal Ho_ten As String, ByVal Ngay_sinh As String, Optional ByVal ID_chuyen_nganh As Integer = 0, Optional ByVal Ma_nganh As String = "") As DataTable
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ma_sv", Ma_sv)
                para(4) = New SqlParameter("@SBD", SBD)
                para(5) = New SqlParameter("@Ho_ten", Ho_ten)
                para(6) = New SqlParameter("@Ngay_sinh", Ngay_sinh)
                para(7) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(8) = New SqlParameter("@Ma_nganh", Ma_nganh)
                Return UDB.SelectTableSP("STU_DanhSachSinhVien_HeKhoaKhoaHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_List_DanhSachSinhVien_List(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Ma_nganh As String) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@Ma_nganh", Ma_nganh)
                Return UDB.SelectTableSP("STU_DanhSachSinhVien_HeKhoaKhoaHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachSinhVien(ByVal obj As DanhSachSinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(1) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                    para(2) = New SqlParameter("@Active", obj.Active)
                    para(3) = New SqlParameter("@Da_tot_nghiep", obj.Da_tot_nghiep)
                    Return UDB.ExecuteSP("STU_DanhSach_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(1) = New OracleParameter(":Mat_khau", obj.Mat_khau)
                    para(2) = New OracleParameter(":Active", obj.Active)
                    para(3) = New OracleParameter(":Da_tot_nghiep", obj.Da_tot_nghiep)
                    Return UDB.ExecuteSP("STU_DanhSach_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_DanhSachSinhVien(ByVal obj As DanhSachSinhVien, ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    para(2) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                    para(3) = New SqlParameter("@Active", obj.Active)
                    para(4) = New SqlParameter("@Da_tot_nghiep", obj.Da_tot_nghiep)
                    Return UDB.ExecuteSP("STU_DanhSach_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    para(2) = New OracleParameter(":Mat_khau", obj.Mat_khau)
                    para(3) = New OracleParameter(":Active", obj.Active)
                    para(4) = New OracleParameter(":Da_tot_nghiep", obj.Da_tot_nghiep)
                    Return UDB.ExecuteSP("STU_DanhSach_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_DanhSachSinhVien(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_DanhSachSinhVien_QuyenTruyCap(ByVal obj As DanhSachSinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(2) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                    para(3) = New SqlParameter("@Active", obj.Active)
                    Return UDB.ExecuteSP("STU_DanhSach_CapQuyenSinhVien_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(2) = New OracleParameter(":Mat_khau", obj.Mat_khau)
                    para(3) = New OracleParameter(":Active", obj.Active)
                    Return UDB.ExecuteSP("STU_DanhSach_CapQuyenSinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_SinhVienBangDiem(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_BangDiemSinhVienInfor_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_BangDiemSinhVienInfor_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_SinhVienNgoaiNganSach(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Ngoai_ngan_sach", Ngoai_ngan_sach)
                    Return UDB.ExecuteSP("STU_DanhSachNgoaiNganSach_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Ngoai_ngan_sach", Ngoai_ngan_sach)
                    Return UDB.ExecuteSP("STU_DanhSachNgoaiNganSach_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


