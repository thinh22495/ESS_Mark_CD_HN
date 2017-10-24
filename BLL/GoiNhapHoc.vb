Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class GoiNhapHoc_BLL
        Private arrSinhVien As New ArrayList
        Private dtKhoanNop As DataTable
        Private dtKhoanDaNop As DataTable
        Private dtBienLai As DataTable ' Luu giữ bảng ID_bien_lai
       
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As GoiNhaphoc_DAL = New GoiNhaphoc_DAL
                Dim dt As DataTable = obj.Load_GoiNhapHoc_List()
                Dim objGoiNhapHoc As GoiNhapHoc = Nothing
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objGoiNhapHoc = Converting(dr)
                    arrSinhVien.Add(objGoiNhapHoc)
                Next                
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal dsID_sv As String)
            Try
                Dim obj As GoiNhaphoc_DAL = New GoiNhaphoc_DAL
                Dim dt As DataTable = obj.Load_GoiNhapHoc_BoXung_List(dsID_sv)
                Dim objGoiNhapHoc As GoiNhapHoc = Nothing
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objGoiNhapHoc = Converting(dr)
                    arrSinhVien.Add(objGoiNhapHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal Nam_hoc As String, ByVal ID_he As Integer)
            Try
                Dim obj As New GoiNhaphoc_DAL
                dtKhoanNop = obj.KhoanNop(ID_he)
                dtKhoanDaNop = obj.KhoanDaNop(Nam_hoc, ID_he)
                dtBienLai = obj.LoadID_bien_lai(Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Function"
        ' Tìm ID_bien lai theo sinh viên
        Public Function GetID_bien_lai(ByVal ID_sv As Integer, ByVal Noi_dung As String) As Integer
            Try
                Dim ID_bien_lai As Integer = 0
                For i As Integer = 0 To dtBienLai.Rows.Count - 1
                    If dtBienLai.Rows(i)("ID_sv") = ID_sv And Noi_dung = dtBienLai.Rows(i)("Noi_dung") Then
                        ID_bien_lai = dtBienLai.Rows(i)("ID_bien_lai")
                        Exit For
                    End If
                Next
                Return ID_bien_lai
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load khoan nop
        Public Function KhoanNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim dtDaNop As DataTable = KhoanDaNop(ID_sv)
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_thu_chi", GetType(String))
                dt.Columns.Add("Ten_thu_chi", GetType(String))
                dt.Columns.Add("So_tien", GetType(Integer))
                For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    If dtDaNop Is Nothing Then
                        row("Chon") = False
                    Else
                        Dim dk As String = "ID_thu_chi=" & dtKhoanNop.Rows(i).Item("ID_thu_chi")
                        dtDaNop.DefaultView.RowFilter = dk
                        If dtDaNop.DefaultView.Count > 0 Then
                            row("Chon") = True
                        Else
                            row("Chon") = False
                        End If
                    End If
                    row("ID_thu_chi") = dtKhoanNop.Rows(i).Item("ID_thu_chi")
                    row("Ten_thu_chi") = dtKhoanNop.Rows(i).Item("Ten_thu_chi")
                    row("So_tien") = dtKhoanNop.Rows(i).Item("So_tien")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_thu_chi", GetType(String))
                dt.Columns.Add("Ten_thu_chi", GetType(String))
                dt.Columns.Add("So_tien", GetType(Integer))
                For i As Integer = 0 To dtKhoanDaNop.Rows.Count - 1
                    If dtKhoanDaNop.Rows(i).Item("ID_sv") = ID_sv Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = dtKhoanDaNop.Rows(i).Item("ID_sv")
                        row("ID_thu_chi") = dtKhoanDaNop.Rows(i).Item("ID_thu_chi")
                        row("Ten_thu_chi") = dtKhoanDaNop.Rows(i).Item("Ten_thu_chi")
                        row("So_tien") = dtKhoanDaNop.Rows(i).Item("So_tien")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan chua nộp
        Public Function KhoanChuaNop(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dtDaNop As DataTable = KhoanDaNop(ID_sv)
                ' Cac khoan phải nộp
                Dim dtNop As DataTable = dtKhoanNop
                For i As Integer = 0 To dtDaNop.Rows.Count - 1
                    Dim idx As Integer = dtNop.Rows.Count - 1
                    For j As Integer = 0 To idx
                        If j > idx Then Exit For
                        If dtDaNop.Rows(i).Item("ID_thu_chi") = dtNop.Rows(j).Item("ID_thu_chi") Then
                            dtNop.Rows(j).Delete()
                            dtNop.AcceptChanges()
                            idx -= 1
                        End If
                    Next
                Next
                Return dtNop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien đã gọi nhập học
        Public Function DanhSachSv_DaGoi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Integer))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As GoiNhapHoc = CType(arrSinhVien(i), GoiNhapHoc)
                    If nh.Dang_ky_hoc = 1 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Dang_ky_hoc") = nh.Dang_ky_hoc
                        row("ID_sv") = nh.ID_sv
                        row("SBD") = nh.SBD
                        row("Ho_ten") = nh.Ho_ten
                        If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                        row("Tong_diem") = nh.Tong_diem
                        If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                        row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                        row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                        row("Khoi_thi") = nh.Khoi_thi
                        row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien chưa gọi nhập học
        Public Function DanhSachSv_ChuaGoi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As GoiNhapHoc = CType(arrSinhVien(i), GoiNhapHoc)
                    If nh.UserName_tiep_nhan = "" Then
                        Dim row As DataRow = dt.NewRow()
                        row("Dang_ky_hoc") = False
                        row("ID_sv") = nh.ID_sv
                        row("SBD") = nh.SBD
                        row("Ho_ten") = nh.Ho_ten
                        If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                        row("Tong_diem") = nh.Tong_diem
                        If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                        row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                        row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                        row("Khoi_thi") = nh.Khoi_thi
                        row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien chua goi và đã gọi nhập học
        Public Function DanhSachSv() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(String))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                dt.Columns.Add("So_tien", GetType(String))
                dt.Columns.Add("Nguoi_thu", GetType(String))
                dt.Columns.Add("Lop", GetType(String))
                dt.Columns.Add("Xep_loai_tot_nghiep", GetType(String))
                dt.Columns.Add("Ten_huyen", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As GoiNhapHoc = CType(arrSinhVien(i), GoiNhapHoc)
                    Dim row As DataRow = dt.NewRow()
                    row("Dang_ky_hoc") = nh.Dang_ky_hoc
                    row("So_tien") = nh.So_tien
                    row("Nguoi_thu") = nh.Nguoi_thu
                    row("ID_sv") = nh.ID_sv
                    row("SBD") = nh.SBD
                    row("Ho_ten") = nh.Ho_ten
                    If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                    row("Tong_diem") = nh.Tong_diem
                    If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                    row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                    row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                    row("Khoi_thi") = nh.Khoi_thi
                    row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                    row("Lop") = nh.Lop
                    row("Xep_loai_tot_nghiep") = nh.Xep_loai_tot_nghiep
                    row("Ten_huyen") = nh.TenHuyen
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function UpdateTable(ByVal objNH As GoiNhapHoc) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As GoiNhapHoc = CType(arrSinhVien(i), GoiNhapHoc)
                    If nh.ID_sv = objNH.ID_sv Then nh = objNH ' Cập nhật mới                    
                    Dim row As DataRow = dt.NewRow()
                    If nh.UserName_tiep_nhan = "" Then
                        row("Dang_ky_hoc") = False
                    Else
                        row("Dang_ky_hoc") = True
                    End If
                    row("ID_sv") = nh.ID_sv
                    row("SBD") = nh.SBD
                    row("Ho_ten") = nh.Ho_ten
                    If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                    row("Tong_diem") = nh.Tong_diem
                    If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                    row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                    row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                    row("Khoi_thi") = nh.Khoi_thi
                    row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật đăng ký học
        Public Sub UpdateDangKyHoc(ByVal objNhapHoc As GoiNhapHoc)
            Try
                Dim obj As New GoiNhaphoc_DAL
                obj.UpdateDangKyHoc(objNhapHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ' Xóa đăng ký học
        Public Sub DeleteDangKyHoc(ByVal objNhapHoc As GoiNhapHoc)
            Try
                Dim obj As New GoiNhaphoc_DAL
                obj.DeleteDangKyHoc(objNhapHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Function Converting(ByVal drGoiNhapHoc As DataRow) As GoiNhapHoc
            Dim result As GoiNhapHoc
            Try
                result = New GoiNhapHoc
                If drGoiNhapHoc("ID_sv").ToString() <> "" Then result.ID_sv = CType(drGoiNhapHoc("ID_sv").ToString(), Integer)
                result.Dang_ky_hoc = CType(drGoiNhapHoc("Dang_ky_hoc"), Integer)
                result.Ho_ten = drGoiNhapHoc("Ho_ten").ToString()
                If drGoiNhapHoc("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drGoiNhapHoc("Ngay_sinh").ToString(), Date)
                If drGoiNhapHoc("Tong_diem").ToString() <> "" Then result.Tong_diem = CType(drGoiNhapHoc("Tong_diem").ToString(), Single)
                If drGoiNhapHoc("Ngay_nhap_hoc").ToString() <> "" Then result.Ngay_nhap_hoc = CType(drGoiNhapHoc("Ngay_nhap_hoc").ToString(), Date)
                If drGoiNhapHoc("UserName_tiep_nhan").ToString() <> "" Then result.UserName_tiep_nhan = CType(drGoiNhapHoc("UserName_tiep_nhan").ToString(), String)
                result.Khoi_thi = drGoiNhapHoc("Khoi_thi").ToString()
                result.Nganh_tuyen_sinh = drGoiNhapHoc("Nganh_tuyen_sinh").ToString()
                result.SBD = drGoiNhapHoc("SBD").ToString()
                If drGoiNhapHoc("UserID_tiep_nhan").ToString() <> "" Then result.UserID_tiep_nhan = CType(drGoiNhapHoc("UserID_tiep_nhan").ToString(), Integer)
                result.Lop = drGoiNhapHoc("Lop").ToString()
                If drGoiNhapHoc("So_tien").ToString() <> "" Then result.So_tien = CType(drGoiNhapHoc("So_tien").ToString(), Integer)
                result.Nguoi_thu = drGoiNhapHoc("Nguoi_thu").ToString()
                result.Xep_loai_tot_nghiep = drGoiNhapHoc("Xep_loai_tot_nghiep").ToString()
                result.TenHuyen = drGoiNhapHoc("Ten_huyen").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region

#End Region

        Public Function GetThongTinLop(ByVal ID_lop As Integer) As DataTable
            Try
                Dim obj As New GoiNhaphoc_DAL
                Return obj.GetThongTinLop(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetSoSinhVien_Lop(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As New GoiNhaphoc_DAL
                Return obj.GetSoSinhVien_Lop(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadSinhVien_DaNhap_Lop(ByVal Khoa_hoc As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                Dim obj As New GoiNhaphoc_DAL
                Return obj.LoadSinhVien_DaNhap_Lop(Khoa_hoc, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace