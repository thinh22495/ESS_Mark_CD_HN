Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Imports System.IO
Namespace DBManager
    Public Class TongHopThongKe_DAL
        Public Sub New()

        End Sub
        Public Function ThongKe_Siso(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_SiSo", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_SiSo", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachSinhVienKhoaHoc(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KhoaHoc", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KhoaHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh vien dạt danh hieu cá nhan
        Public Function DanhSachSinhVien_DanhHieu_CaNhan(ByVal dsID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    Return UDB.SelectTableSP("STU_DanhHieuThiDuaCaNhan_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    Return UDB.SelectTableSP("STU_DanhHieuThiDuaCaNhan_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh vien dạt danh hieu Tập thể
        Public Function DanhSachSinhVien_DanhHieu_TapThe(ByVal dsID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    Return UDB.SelectTableSP("STU_DanhHieuThiDuaTapThe_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    Return UDB.SelectTableSP("STU_DanhHieuThiDuaTapThe_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Khoa
        Public Function Khoa() As DataTable
            Try
                Return UDB.SelectTableSP("STU_TK_Khoa")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KhoaHoc() As DataTable
            Try
                Return UDB.SelectTableSP("STU_TK_KhoaHoc")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên được khen thưởng theo khóa học
        Public Function DanhSachSinhVienKhoa(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_Khoa", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_Khoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HocBong() As DataTable
            Try
                Return UDB.SelectTableSP("STU_LoaiHocBong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Loai_TroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_Loai_TroCap", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_Loai_TroCap", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TongHop_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_TongHop_HocBong", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_TongHop_HocBong", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DSNganh(ByVal ID_he As Integer, ByVal Khoa_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DS_Nganh", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DS_Nganh", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DSSV_TheoNganh(ByVal ID_he As Integer, ByVal Khoa_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSV_TheoNganh", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSV_TheoNganh", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê DSSV được học bổng 
        Public Function Load_DSSV_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal ID_lop As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@ID_lop", ID_lop)
                    para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSV_HocBong", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":ID_lop", ID_lop)
                    para(4) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_TK_HoSo_TotNghiep", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên nước ngoài
        Public Function Load_DanhMuc_DoiTuong() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DoiTuong_Load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên nước ngoài
        Public Function Load_DS_MienGiam(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return UDB.SelectTableSP("STU_TK_DanhSachSinhVienMienGiam_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên Trợ cấp
        Public Function Load_DS_TroCap(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return UDB.SelectTableSP("STU_TK_DanhSachSinhVienTroCap_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên được khen thưởng theo khóa học
        Public Function DM_Khoa() As DataTable
            Try
                Return UDB.SelectTableSP("STU_Khoa_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Khoa của khóa học
        Public Function Khoa_Khoa_Hoc() As DataTable
            Try
                Return UDB.SelectTableSP("STU_TK_Khoa_Khoa_Hoc")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#Region "Khen thuong sinh viên"
        ' Danh sách sinh viên được khen thưởng theo khóa học
        Public Function DanhSachSinhVienKhenThuong(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KhenThuong", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KhenThuong", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên được khen thưởng theo khóa học
        Public Function DanhSachSinhVienNganh(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_Nganh", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_Nganh", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Ngành đào tạo
        Public Function NganhDaoTao() As DataTable
            Try
                Return UDB.SelectTableSP("STU_TK_NganhDT")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tập thể khen thưởng
        Public Function TapTheKhenThuong(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return UDB.SelectTableSP("STU_TK_DanhHieuThiDuaTapThe", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Kỷ luật"
        ' Danh sách sinh viên bị kỷ luật
        Public Function DanhSachSinhVienKyLuat(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KyLuat", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSTU_KyLuat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Hình thức xử lý
        Public Function HinhThuc_XuLy() As DataTable
            Try
                Return UDB.SelectTableSP("STU_TK_HinhThuc_XuLy")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Biến động sinh viên "
        ' Danh sác sv thôi học , ngừng học, nghỉ học, chuyển trường
        Public Function DanhSach_SinhVienThoiHoc_NEW(Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVThoiHoc_NEW", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVThoiHoc_NEW", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_SinhVienThoiHoc(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVThoiHoc", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVThoiHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên được xét học tiếp
        Public Function DanhSach_SinhVienHocTiep(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVHocTiep", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lops", dsID_lops)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSVHocTiep", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Báo cáo Mẫu thống kê sinh viên theo cơ cấu xã hội M1.1"
        ' Danh sách theo mẫu 1.1
        Public Function DanhSach_SinhVienCoCauXaHoi() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_Mau11")

                Else

                    Return UDB.SelectTableSP("STU_Mau11")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên 
        Public Function DanhSach_SinhVien() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien")
                Else
                    Return UDB.SelectTableSP("STU_DanhSachSinhVien")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Báo cáo Mẫu thống kê sinh viên nước ngoài M1.2"
        ' Danh sách theo mẫu 1.1
        Public Function DanhSach_SinhVienNuocNgoai(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_He)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau12", para)
                Else
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_He)
                    para(1) = New SqlParameter(":ID_khoa", ID_khoa)
                    para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau12", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Báo cáo Mẫu thống kê sinh viên thuộc diện ưu đãi và chính sách theo mẫu M1.3"
        Public Function DanhSach_SinhVienChinhSach(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_He)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau13", para)
                Else
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_He)
                    para(1) = New SqlParameter(":ID_khoa", ID_khoa)
                    para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau13", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_SinhVienTroCap(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_He)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau131", para)
                Else
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_He)
                    para(1) = New SqlParameter(":ID_khoa", ID_khoa)
                    para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau131", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Báo cáo Mẫu thống kê điểm học tập và rèn luyện theo mẫu 2.1"
        Public Function ThongKe_DiemHSSV(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_He)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau21", para)
                Else
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_He)
                    para(1) = New SqlParameter(":ID_khoa", ID_khoa)
                    para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Mau21", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function ThongKe_HocTap(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(2) As SqlParameter
        '            para(0) = New SqlParameter("@ID_he", ID_He)
        '            para(1) = New SqlParameter("@ID_khoa", ID_khoa)
        '            para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
        '            Return UDB.SelectTableSP("STU_Mau131", para)
        '        Else
        '            Dim para(2) As SqlParameter
        '            para(0) = New SqlParameter(":ID_he", ID_He)
        '            para(1) = New SqlParameter(":ID_khoa", ID_khoa)
        '            para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
        '            Return UDB.SelectTableSP("STU_Mau131", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        'Public Function ThongKe_RenLuyen(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(2) As SqlParameter
        '            para(0) = New SqlParameter("@ID_he", ID_He)
        '            para(1) = New SqlParameter("@ID_khoa", ID_khoa)
        '            para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
        '            Return UDB.SelectTableSP("STU_Mau131", para)
        '        Else
        '            Dim para(2) As SqlParameter
        '            para(0) = New SqlParameter(":ID_he", ID_He)
        '            para(1) = New SqlParameter(":ID_khoa", ID_khoa)
        '            para(2) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
        '            Return UDB.SelectTableSP("STU_Mau131", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
#End Region
#Region "Thống kê sinh viên tỉnh thành"
        ' Danh sách tỉnh thành
        Public Function DanhSach_TinhThanh(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_TinhThanh", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_TinhThanh", para)
                End If                
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách tỉnh thành
        Public Function DanhSach_Huyen(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_tinh As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_tinh", ID_tinh)
                    Return UDB.SelectTableSP("STU_TK_Huyen", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_tinh", ID_tinh)
                    Return UDB.SelectTableSP("STU_TK_Huyen", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách Sinh vien tỉnh thành
        Public Function DanhSachSV_TinhThanh(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSV_TinhThanh", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_TK_DSSV_TinhThanh", para)
                End If                
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách Sinh vien Huyen
        Public Function DanhSachSV_Huyen(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_tinh As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_tinh", ID_tinh)
                    Return UDB.SelectTableSP("STU_TK_DSSV_Huyen", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_tinh", ID_tinh)
                    Return UDB.SelectTableSP("STU_TK_DSSV_Huyen", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace



