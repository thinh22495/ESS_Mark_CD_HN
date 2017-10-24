'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, June 06, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class TochucThi_BLL
        Private arrTochucThi As New ArrayList
        Private dsMonHoc As New ChuongTrinhDaoTaoChiTiet

#Region "Constructor"
        Sub New()

        End Sub
        Sub New(ByVal ID_thi As Integer)
            Dim clsTCThi As New TochucThi_DAL
            Dim dtThi As DataTable = clsTCThi.Load_TochucThi(ID_thi)
            If dtThi.Rows.Count > 0 Then
                'Add các lần tổ chức thi
                Dim objTCThi As New TochucThi
                objTCThi = ConvertToTocChucThi(dtThi.Rows(0))
                'Add phòng thi của lần tổ chức thi
                Dim dtPhong As DataTable = clsTCThi.Load_DanhsachPhongThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtPhong.Rows.Count - 1
                    Dim objPhongThi As New ToChucThiPhong
                    objPhongThi = ConvertToTocChucThiPhongThi(dtPhong.Rows(j))
                    objTCThi.dsPhongThi.Add(objPhongThi)
                Next
                'Add danh sách sinh viên của lần tổ chức thi
                Dim dtSinhVien As DataTable = clsTCThi.Load_DanhsachSinhVien(objTCThi.ID_thi)
                For j As Integer = 0 To dtSinhVien.Rows.Count - 1
                    Dim objSV As New TochucThiChiTiet
                    objSV = ConvertToTocChucThiChiTiet(dtSinhVien.Rows(j))
                    objTCThi.dsChiTietSinhVien.Add(objSV)
                Next
                arrTochucThi.Add(objTCThi)
            End If
        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_bm_chinh As Integer)
            Dim clsTCThi As New TochucThi_DAL
            Dim dtThi As DataTable = clsTCThi.Load_DanhsachTochucThi(Hoc_ky, Nam_hoc, ID_bm_chinh)
            For i As Integer = 0 To dtThi.Rows.Count - 1
                'Add các lần tổ chức thi
                Dim objTCThi As New TochucThi
                objTCThi = ConvertToTocChucThi(dtThi.Rows(i))
                'Add phòng thi của lần tổ chức thi
                Dim dtPhong As DataTable = clsTCThi.Load_DanhsachPhongThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtPhong.Rows.Count - 1
                    Dim objPhongThi As New ToChucThiPhong
                    objPhongThi = ConvertToTocChucThiPhongThi(dtPhong.Rows(j))
                    objTCThi.dsPhongThi.Add(objPhongThi)
                Next
                Dim dtTuiThi As DataTable = clsTCThi.Load_DanhsachTuiThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtTuiThi.Rows.Count - 1
                    Dim objTuiThi As New ToChucThiDongTui
                    objTuiThi = ConvertToTocChucThiDongTui(dtTuiThi.Rows(j))
                    objTCThi.dsTuiThi.Add(objTuiThi)
                Next
                arrTochucThi.Add(objTCThi)
            Next
        End Sub
#End Region
#Region "Function"
        Function XuLy_Xau_SoBD(ByVal str As String, ByVal So_SV As Integer) As String
            Return Right(str, (So_SV + ToChucThi(0).dsChiTietSinhVien.Count).ToString.Length)
        End Function
        Public Function DanhSachMonToChucThi_TheoTui() As DataTable
            Dim dtThi As New DataTable
            dtThi.Columns.Add("ID_thi", GetType(Integer))
            dtThi.Columns.Add("ID_he", GetType(Integer))
            dtThi.Columns.Add("Ten_he", GetType(String))
            dtThi.Columns.Add("ID_khoa", GetType(Integer))
            dtThi.Columns.Add("Ten_khoa", GetType(String))
            dtThi.Columns.Add("ID_mon", GetType(Integer))
            dtThi.Columns.Add("Ten_mon", GetType(String))
            dtThi.Columns.Add("Lan_thi", GetType(Integer))
            dtThi.Columns.Add("Dot_thi", GetType(Integer))
            dtThi.Columns.Add("Ngay_thi", GetType(Date))
            dtThi.Columns.Add("Ca_thi", GetType(String))
            dtThi.Columns.Add("Tui_so", GetType(Integer))
            dtThi.Columns.Add("Nhom_tiet", GetType(String))
            For i As Integer = 0 To arrTochucThi.Count - 1
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(i), TochucThi)
                For j As Integer = 0 To objTCThi.dsTuiThi.Count - 1
                    Dim dr As DataRow
                    dr = dtThi.NewRow
                    dr("ID_thi") = objTCThi.ID_thi
                    dr("ID_he") = objTCThi.ID_he
                    dr("Ten_he") = objTCThi.Ten_he
                    dr("ID_khoa") = objTCThi.ID_khoa
                    dr("Ten_khoa") = objTCThi.Ten_khoa
                    dr("ID_mon") = objTCThi.ID_mon
                    dr("Ten_mon") = objTCThi.Ten_mon
                    dr("Lan_thi") = objTCThi.Lan_thi
                    dr("Dot_thi") = objTCThi.Dot_thi
                    dr("Ngay_thi") = objTCThi.Ngay_thi
                    dr("Ca_thi") = objTCThi.Ca_thi
                    dr("Tui_so") = objTCThi.dsTuiThi.TochucThiTui(j).Tui_so
                    dr("Nhom_tiet") = objTCThi.Nhom_tiet
                    dtThi.Rows.Add(dr)
                Next
            Next
            Return dtThi
        End Function
        Public Sub Update(ByVal ID_thi As Integer, ByVal Ca_thi As Integer, ByVal Ngay_thi As String, ByVal Nhom_tiet As Integer, ByVal Thoi_gian As String, ByVal Thoi_gian_lam_bai As String)
            Dim midx As Integer = Tim_idx(ID_thi)
            If midx <= 0 Then midx = 0

            CType(arrTochucThi(midx), TochucThi).Ca_thi = Ca_thi
            CType(arrTochucThi(midx), TochucThi).Ngay_thi = Ngay_thi
            CType(arrTochucThi(midx), TochucThi).Nhom_tiet = Nhom_tiet
            CType(arrTochucThi(midx), TochucThi).Thoi_gian = Thoi_gian
            CType(arrTochucThi(midx), TochucThi).Thoi_gian_lam_bai = Thoi_gian_lam_bai
        End Sub
        Public Sub Add(ByVal TCThi As TochucThi)
            arrTochucThi.Add(TCThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrTochucThi.RemoveAt(idx)
        End Sub
        Public Function Load_ToChucThi_Phong(ByVal Id_phong_thi As Integer) As DataTable
            Try
                Dim objTCT As New TochucThi_DAL
                Return objTCT.Load_ToChucThiPhong(Id_phong_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ToChucThi_TheoDot(ByVal ID_thi As Integer) As DataTable
            Try
                Dim objTCT As New TochucThi_DAL
                Return objTCT.Load_ToChucThi_TheoDot(ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        
        Public Function DanhSachMonToChucThi() As DataTable
            Dim dtThi As New DataTable
            dtThi.Columns.Add("ID_thi", GetType(Integer))
            dtThi.Columns.Add("ID_he", GetType(Integer))
            dtThi.Columns.Add("Ten_he", GetType(String))
            dtThi.Columns.Add("ID_khoa", GetType(Integer))
            dtThi.Columns.Add("Ten_khoa", GetType(String))
            dtThi.Columns.Add("ID_mon", GetType(Integer))
            dtThi.Columns.Add("Ten_mon", GetType(String))
            dtThi.Columns.Add("Lan_thi", GetType(Integer))
            dtThi.Columns.Add("Dot_thi", GetType(Integer))
            dtThi.Columns.Add("Ngay_thi", GetType(Date))
            dtThi.Columns.Add("ID_phong_thi", GetType(Integer))
            dtThi.Columns.Add("Ten_phong", GetType(String))
            dtThi.Columns.Add("Ca_thi", GetType(String))
            dtThi.Columns.Add("Tui_so", GetType(Integer))
            dtThi.Columns.Add("Nhom_tiet", GetType(String))
            dtThi.Columns.Add("Thoi_gian", GetType(String))
            dtThi.Columns.Add("Thoi_gian_lam_bai", GetType(String))
            For i As Integer = 0 To arrTochucThi.Count - 1
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(i), TochucThi)
                For j As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                    Dim dr As DataRow
                    dr = dtThi.NewRow
                    dr("ID_thi") = objTCThi.ID_thi
                    dr("ID_he") = objTCThi.ID_he
                    dr("Ten_he") = objTCThi.Ten_he
                    dr("ID_khoa") = objTCThi.ID_khoa
                    dr("Ten_khoa") = objTCThi.Ten_khoa
                    dr("ID_mon") = objTCThi.ID_mon
                    dr("Ten_mon") = objTCThi.Ten_mon
                    dr("Lan_thi") = objTCThi.Lan_thi
                    dr("Dot_thi") = objTCThi.Dot_thi
                    dr("Ngay_thi") = objTCThi.Ngay_thi
                    dr("Ca_thi") = objTCThi.Ca_thi
                    dr("Tui_so") = objTCThi.dsChiTietSinhVien.Tui_so
                    dr("Nhom_tiet") = objTCThi.Nhom_tiet
                    dr("Thoi_gian") = objTCThi.Thoi_gian
                    dr("Thoi_gian_lam_bai") = objTCThi.Thoi_gian_lam_bai
                    dr("ID_phong_thi") = objTCThi.dsPhongThi.TochucThiPhong(j).ID_phong_thi
                    dr("Ten_phong") = objTCThi.dsPhongThi.TochucThiPhong(j).Ten_phong
                    dtThi.Rows.Add(dr)
                Next
            Next
            Return dtThi
        End Function
        Function DanhSachKDDK_DuThi(ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dt_no_HocTap As DataTable) As DataTable
            Dim dt, dt_NoHocPhi As DataTable
            dt_NoHocPhi = DanhSachKDDK_DuThi_HocPhi(ID_lops, Hoc_ky, Nam_hoc)
            dt = dt_no_HocTap.Copy
            dt.DefaultView.Sort = "ID_SV"
            For i As Integer = 0 To dt_NoHocPhi.Rows.Count - 1
                If dt.DefaultView.Find(dt_NoHocPhi.Rows(i).Item("ID_SV")) < 0 Then
                    Dim dr As DataRow
                    dr = dt.NewRow
                    dr("ID_SV") = dt_NoHocPhi.Rows(i).Item("ID_SV")
                    dr("Ly_do") = dt_NoHocPhi.Rows(i).Item("Ly_do").ToString
                    dt.Rows.Add(dr)
                End If
            Next
            Return dt
        End Function
        Private Function DanhSachKDDK_DuThi_HocPhi(ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dt_KhongThi As DataTable
            Dim clsTCThi As New TochucThi_DAL
            dt_KhongThi = clsTCThi.Load_SinhVien_KDDKDuThi(ID_lops, Hoc_ky, Nam_hoc)
            Return dt_KhongThi
        End Function
        Public Function DanhSachSinhVienTheoDotThi(ByVal ID_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Van_dau", GetType(String))
            dtSinhVien.Columns.Add("Ten_tinh", GetType(String))
            dtSinhVien.Columns.Add("Ho_dem", GetType(String))
            dtSinhVien.Columns.Add("Ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten_order", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Khoa_hoc", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            dtSinhVien.Columns.Add("Quy_che", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                'Loai nhung sinh vien khong du dieu kien du thi
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)

                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    Dim dr As DataRow
                    dr = dtSinhVien.NewRow
                    With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                        dr("Chon") = 0
                        dr("ID_sv") = .ID_sv
                        dr("ID_dt") = .ID_dt1
                        dr("ID_he") = .ID_he
                        dr("So_bao_danh") = .So_bao_danh
                        dr("So_phach") = .So_phach
                        dr("Ma_sv") = .Ma_sv
                        dr("Ho_ten") = .Ho_ten
                        dr("Van_dau") = .Van_dau
                        dr("Ho_dem") = .Ho_dem
                        dr("Ten") = .Ten
                        dr("Ho_ten_order") = .Ho_ten_order
                        If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                        dr("ID_lop") = .ID_lop
                        dr("Ten_lop") = .Ten_lop
                        dr("Ten_tinh") = .Ten_tinh
                        dr("Khoa_hoc") = .Khoa_hoc
                        dr("Ten_phong") = .Ten_phong
                        dr("Ghi_chu_thi") = .Ghi_chu_thi
                        dr("OrderBy") = .OrderBy
                        dr("Quy_che") = .Quy_che
                    End With
                    dtSinhVien.Rows.Add(dr)
                Next
            End If
            dtSinhVien.DefaultView.Sort = "Van_dau,Ten,Ho_dem ASC"
            Return dtSinhVien
        End Function

        Public Function DanhSachSBDSoPhachTheoPhongThi(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                            dr("Ten_phong") = .Ten_phong
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienTheoTuiThi_HuongDan(ByVal ID_thi As Integer, ByVal Tui_so As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = Tui_so Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("ID_he") = .ID_he
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Tui_so") = .Tui_so
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            dr("Ngay_sinh") = .Ngay_sinh
                            dr("ID_lop") = .ID_lop
                            dr("Ten_lop") = .Ten_lop
                            dr("Ten_phong") = .Ten_phong
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "Ten_phong,So_bao_danh"
            Return dtSinhVien
        End Function

        Public Function DanhSachSinhVienTheoTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_dem", GetType(String))
            dtSinhVien.Columns.Add("Ten", GetType(String))
            dtSinhVien.Columns.Add("Van_dau", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Quy_che", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Chuyen_nganh", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))

            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = Tui_so Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("ID_he") = .ID_he
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Tui_so") = .Tui_so
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            dr("Ho_dem") = .Ho_dem
                            dr("Ten") = .Ten
                            dr("Van_dau") = .Van_dau
                            dr("Ngay_sinh") = .Ngay_sinh
                            dr("ID_lop") = .ID_lop
                            dr("ID_phong_thi") = .ID_phong_thi
                            dr("Ten_lop") = .Ten_lop
                            dr("Chuyen_nganh") = .Chuyen_nganh
                            dr("Ten_phong") = .Ten_phong
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("Quy_che") = .Quy_che
                            dr("OrderBy") = .OrderBy
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienChuaDongTui(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_dem", GetType(String))
            dtSinhVien.Columns.Add("Ten", GetType(String))
            dtSinhVien.Columns.Add("Van_dau", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("Quy_che", GetType(Integer))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Chuyen_nganh", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                If ID_phong_thi > 0 Then
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = 0 _
                            And objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                            Dim dr As DataRow
                            dr = dtSinhVien.NewRow
                            With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                                dr("Chon") = 0
                                dr("ID_ds_thi") = .ID_ds_thi
                                dr("ID_sv") = .ID_sv
                                dr("ID_dt") = .ID_dt1
                                dr("ID_he") = .ID_he
                                dr("So_bao_danh") = .So_bao_danh
                                dr("So_phach") = .So_phach
                                dr("Tui_so") = .Tui_so
                                dr("Ma_sv") = .Ma_sv
                                dr("Ho_ten") = .Ho_ten
                                dr("Ho_dem") = .Ho_dem
                                dr("Ten") = .Ten
                                dr("Van_dau") = .Van_dau
                                dr("Ngay_sinh") = .Ngay_sinh
                                dr("ID_lop") = .ID_lop
                                dr("Ten_lop") = .Ten_lop
                                dr("Chuyen_nganh") = .Chuyen_nganh
                                dr("ID_phong_thi") = .ID_phong_thi
                                dr("Ten_phong") = .Ten_phong
                                dr("Ghi_chu_thi") = .Ghi_chu_thi
                                dr("Quy_che") = .Quy_che
                                dr("OrderBy") = .OrderBy
                            End With
                            dtSinhVien.Rows.Add(dr)
                        End If
                    Next
                Else
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = 0 Then
                            Dim dr As DataRow
                            dr = dtSinhVien.NewRow
                            With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                                dr("Chon") = 0
                                dr("ID_ds_thi") = .ID_ds_thi
                                dr("ID_sv") = .ID_sv
                                dr("ID_dt") = .ID_dt1
                                dr("ID_he") = .ID_he
                                dr("So_bao_danh") = .So_bao_danh
                                dr("So_phach") = .So_phach
                                dr("Tui_so") = .Tui_so
                                dr("Ma_sv") = .Ma_sv
                                dr("Ho_ten") = .Ho_ten
                                dr("Ho_dem") = .Ho_dem
                                dr("Ten") = .Ten
                                dr("Chuyen_nganh") = .Chuyen_nganh
                                dr("Van_dau") = .Van_dau
                                dr("Ngay_sinh") = .Ngay_sinh
                                dr("ID_lop") = .ID_lop
                                dr("Ten_lop") = .Ten_lop
                                dr("ID_phong_thi") = .ID_phong_thi
                                dr("Ten_phong") = .Ten_phong
                                dr("Ghi_chu_thi") = .Ghi_chu_thi
                                dr("OrderBy") = .OrderBy
                            End With
                            dtSinhVien.Rows.Add(dr)
                        End If
                    Next
                End If
            End If
            dtSinhVien.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
            Return dtSinhVien
        End Function

        Public Function DanhSachSinhVienTheoDongTui_TheoPhongThi(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_dem", GetType(String))
            dtSinhVien.Columns.Add("Ten", GetType(String))
            dtSinhVien.Columns.Add("Van_dau", GetType(String))
            dtSinhVien.Columns.Add("Ten_tinh", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            dtSinhVien.Columns.Add("Quy_che", GetType(Integer))
            dtSinhVien.Columns.Add("Khoa_hoc", GetType(String))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            dr("Ho_dem") = .Ho_dem
                            dr("Ten") = .Ten
                            dr("Van_dau") = .Van_dau
                            dr("Ngay_sinh") = .Ngay_sinh
                            dr("Ten_tinh") = .Ten_tinh
                            dr("ID_lop") = .ID_lop
                            dr("ID_he") = .ID_he
                            dr("Ten_lop") = .Ten_lop
                            dr("Ten_phong") = .Ten_phong
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                            dr("Quy_che") = .Quy_che
                            dr("Khoa_hoc") = .Khoa_hoc
                            dr("Tui_so") = .Tui_so
                            dr("ID_phong_thi") = .ID_phong_thi
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "So_bao_danh"
            Return dtSinhVien
        End Function


        Public Function DanhSachSinhVienDongTuiThi(ByVal ID_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    Dim dr As DataRow
                    dr = dtSinhVien.NewRow
                    With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                        dr("Chon") = 0
                        dr("ID_ds_thi") = .ID_ds_thi
                        dr("ID_sv") = .ID_sv
                        dr("ID_dt") = .ID_dt1
                        dr("So_bao_danh") = .So_bao_danh
                        dr("So_phach") = .So_phach
                        dr("Tui_so") = .Tui_so
                        dr("Ma_sv") = .Ma_sv
                        dr("Ho_ten") = .Ho_ten
                        dr("Ngay_sinh") = .Ngay_sinh
                        dr("ID_lop") = .ID_lop
                        dr("ID_he") = .ID_he
                        dr("Ten_lop") = .Ten_lop
                        dr("ID_phong_thi") = .ID_phong_thi
                        dr("Ten_phong") = .Ten_phong
                        dr("Ghi_chu_thi") = .Ghi_chu_thi
                        dr("OrderBy") = .OrderBy
                    End With
                    dtSinhVien.Rows.Add(dr)
                Next
            End If
            dtSinhVien.DefaultView.Sort = "OrderBy"
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienTheoPhongThi(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("ID_he", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_dem", GetType(String))
            dtSinhVien.Columns.Add("Ten", GetType(String))
            dtSinhVien.Columns.Add("Van_dau", GetType(String))
            dtSinhVien.Columns.Add("Ten_tinh", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("Khoa_hoc", GetType(String))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            dtSinhVien.Columns.Add("Quy_che", GetType(Integer))
            dtSinhVien.Columns.Add("Dia_chi_tt", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            dr("Ho_dem") = .Ho_dem
                            dr("Ten") = .Ten
                            dr("Van_dau") = .Van_dau
                            dr("Ngay_sinh") = .Ngay_sinh
                            dr("Khoa_hoc") = .Khoa_hoc
                            dr("Ten_tinh") = .Ten_tinh
                            dr("ID_lop") = .ID_lop
                            dr("ID_he") = .ID_he
                            dr("Ten_lop") = .Ten_lop
                            dr("Ten_phong") = .Ten_phong
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                            dr("Quy_che") = .Quy_che
                            dr("Dia_chi_tt") = .Dia_chi_tt
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
            Return dtSinhVien
        End Function
        Public Function DanhSachTuiThi(ByVal ID_thi As Integer) As DataTable
            Dim dtTuiThi As New DataTable
            dtTuiThi.Columns.Add("Tui_so", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    dtTuiThi.DefaultView.Sort = "Tui_so"
                    If dtTuiThi.DefaultView.Find(objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so) < 0 Then
                        Dim dr As DataRow
                        dr = dtTuiThi.NewRow
                        dr("Tui_so") = objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so
                        dtTuiThi.Rows.Add(dr)
                    End If
                Next
            End If
            dtTuiThi.AcceptChanges()
            Return dtTuiThi
        End Function
        Public Function DanhSachPhongThi(ByVal ID_thi As Integer) As DataTable
            Dim dtPhongThi As New DataTable
            dtPhongThi.Columns.Add("ID_phong_thi", GetType(Integer))
            dtPhongThi.Columns.Add("Ten_phong", GetType(String))
            dtPhongThi.Columns.Add("So_sv", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New TochucThi
                objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                    Dim dr As DataRow
                    dr = dtPhongThi.NewRow
                    With objTCThi.dsPhongThi.TochucThiPhong(i)
                        dr("ID_phong_thi") = .ID_phong_thi
                        dr("Ten_phong") = .Ten_phong
                        dr("So_sv") = .So_sv
                    End With
                    dtPhongThi.Rows.Add(dr)
                Next
            End If
            dtPhongThi.AcceptChanges()
            Return dtPhongThi
        End Function
        Public Function CheckExist_svTochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Dot_thi As Integer) As DataTable
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Check_MARK_TochucThi(Hoc_ky, Nam_hoc, ID_he, ID_khoa, ID_mon, Lan_thi, Dot_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub TaoDanhSachPhongThi(ByVal idx_thi As Integer, ByVal So_sv As Integer, ByVal Dot_thi As Integer, ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Thoi_gian As String, ByVal dv_phong As DataView)
            Dim objTCThi As New TochucThi
            objTCThi = arrTochucThi(idx_thi)
            For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                objTCThi.dsPhongThi.Remove(0)
            Next
            For i As Integer = 0 To dv_phong.Count - 1
                If dv_phong.Item(i)("Chon") Then
                    Dim objPhongThi As New ToChucThiPhong
                    objPhongThi.ID_phong_thi = dv_phong.Item(i)("ID_phong_thi")
                    objPhongThi.ID_phong = dv_phong.Item(i)("ID_phong")
                    objPhongThi.So_sv = dv_phong.Item(i)("So_sv")
                    objPhongThi.Dot_thi = Dot_thi
                    objPhongThi.Ngay_thi = Ngay_thi
                    objPhongThi.Ca_thi = Ca_thi
                    objPhongThi.Nhom_tiet = Nhom_tiet
                    objPhongThi.Thoi_gian = Thoi_gian
                    objPhongThi.Ten_phong = dv_phong.Item(i)("Ten_phong_main").ToString
                    objTCThi.dsPhongThi.Add(objPhongThi)
                End If
            Next
        End Sub

        Private Sub Update_GhiChuThi(ByVal dv1 As DataView)

        End Sub

        Public Sub TocChucThi(ByVal idx_thi As Integer, ByVal So_sv As Integer, ByVal Dot_thi As Integer, ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Thoi_gian As String, ByVal OrderBy As Integer, ByVal ID_thi_tmp As Integer, ByVal Edit As Boolean, ByVal dv_phong As DataView)
            Dim objTCThi As New TochucThi
            objTCThi = arrTochucThi(idx_thi)
            Dim dvSinhVien As DataView = DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
            Dim idx_sv As Integer = 0
            Dim ID_thi As Integer

            'Sắp xếp danh sách sinh viên
            If OrderBy <= 2 Then
                For i As Integer = 0 To dvSinhVien.Table.Rows.Count - 1
                    Select Case OrderBy
                        Case 0  'Theo họ và tên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ho_ten_order").ToString
                        Case 1  'Theo mã sinh viên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                        Case 2  'Theo lớp - mã sinh viên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ten_lop").ToString + dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                    End Select
                Next
                dvSinhVien.Sort = "Van_dau,Ten,Ho_dem"
            End If
            'Kiem tra xem da to chuc thi chua?

            ID_thi = ID_thi_tmp
            If ID_thi <= 0 Then
                'Insert to chuc thi
                ID_thi = Insert_TochucThi(objTCThi)
            Else
                'Xoa du lieu da to chuc thi
                Dim ID_phong_this As String = "0"
                For i As Integer = 0 To dv_phong.Count - 1
                    If dv_phong.Item(i)("Khong_thay_doi") Then ID_phong_this += "," & dv_phong.Item(i)("ID_phong_thi")
                Next
                Delete_ToChucThiTheoPhong(ID_thi, ID_phong_this)
                Delete_TochucThiChiTiet(ID_thi, ID_phong_this)

                Dim midx As Integer = Tim_idx(ID_thi)
                If midx >= 0 AndAlso Edit Then
                    Update_TochucThi(objTCThi, ID_thi)
                End If
            End If
            'Tạo danh sách phòng thi tương ứng với số phòng thi
            TaoDanhSachPhongThi(idx_thi, So_sv, Dot_thi, Ngay_thi, Ca_thi, Nhom_tiet, Thoi_gian, dv_phong)
            'Duyệt danh sách phong thi
            For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                'Insert phong thi
                If idx_sv <= dvSinhVien.Count - 1 Then
                    Dim ID_phong_thi As Integer = objTCThi.dsPhongThi.TochucThiPhong(i).ID_phong_thi
                    If ID_phong_thi <> 0 Then
                        For k As Integer = 0 To dv_phong.Count - 1
                            If dv_phong.Item(k)("ID_phong_thi") = ID_phong_thi AndAlso dv_phong.Item(k)("Khong_thay_doi") = False Then
                                For j As Integer = 1 To objTCThi.dsPhongThi.TochucThiPhong(i).So_sv
                                    If idx_sv <= dvSinhVien.Count - 1 Then
                                        'Insert sinh vien
                                        Dim objTCThiChiTiet As New TochucThiChiTiet
                                        objTCThiChiTiet.ID_sv = dvSinhVien.Item(idx_sv)("ID_sv")
                                        objTCThiChiTiet.So_bao_danh = dvSinhVien.Item(idx_sv)("So_bao_danh").ToString
                                        objTCThiChiTiet.OrderBy = dvSinhVien.Item(idx_sv)("OrderBy").ToString
                                        objTCThiChiTiet.ID_thi = ID_thi
                                        objTCThiChiTiet.ID_phong_thi = ID_phong_thi
                                        objTCThiChiTiet.Ghi_chu_thi = dvSinhVien.Item(idx_sv)("Ghi_chu_thi").ToString
                                        Insert_TochucThiChiTiet(objTCThiChiTiet)
                                        idx_sv += 1
                                    Else
                                        Exit Sub
                                    End If
                                Next
                            End If
                        Next
                    Else
                        ID_phong_thi = Insert_ToChucThiPhong(objTCThi.dsPhongThi.TochucThiPhong(i))
                        'Duyệt số sinh viên của phòng thi
                        For j As Integer = 1 To objTCThi.dsPhongThi.TochucThiPhong(i).So_sv
                            If idx_sv <= dvSinhVien.Count - 1 Then
                                'Insert sinh vien
                                Dim objTCThiChiTiet As New TochucThiChiTiet
                                objTCThiChiTiet.ID_sv = dvSinhVien.Item(idx_sv)("ID_sv")
                                objTCThiChiTiet.So_bao_danh = dvSinhVien.Item(idx_sv)("So_bao_danh").ToString
                                objTCThiChiTiet.OrderBy = dvSinhVien.Item(idx_sv)("OrderBy").ToString
                                objTCThiChiTiet.ID_thi = ID_thi
                                objTCThiChiTiet.ID_phong_thi = ID_phong_thi
                                objTCThiChiTiet.Ghi_chu_thi = dvSinhVien.Item(idx_sv)("Ghi_chu_thi").ToString
                                Insert_TochucThiChiTiet(objTCThiChiTiet)
                                idx_sv += 1
                            Else
                                Exit Sub
                            End If
                        Next
                    End If
                Else
                    Exit Sub
                End If
            Next
        End Sub
        Public Sub LapSoBaoDanh(ByVal idx_thi As Integer, ByVal Tu_so As Integer, ByVal OrderBy As Integer)
            Try
                If arrTochucThi.Count > 0 Then
                    Dim objTCThi As New TochucThi
                    Dim So_sv As Integer = 0
                    Dim SoBD As String = ""
                    Dim ID_sv, idx_sv As Integer
                    objTCThi = arrTochucThi(idx_thi)
                    So_sv = objTCThi.dsChiTietSinhVien.Count
                    'Sắp xếp danh sách sinh viên
                    Dim dvSinhVien As DataView = DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                    dvSinhVien.Sort = "Van_dau,Ten,Ho_dem"
                    'If OrderBy <= 2 Then
                    '    For i As Integer = 0 To dvSinhVien.Table.Rows.Count - 1
                    '        Select Case OrderBy
                    '            Case 0  'Theo họ và tên
                    '                dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ho_ten_order").ToString
                    '            Case 1  'Theo mã sinh viên
                    '                dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                    '            Case 2  'Theo lớp - mã sinh viên
                    '                dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ten_lop").ToString + dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                    '        End Select
                    '    Next
                    '    dvSinhVien.Sort = "OrderBy"
                    'End If
                    For i As Integer = 0 To dvSinhVien.Count - 1
                        'Đưa số 0 vào trước số VD 001, 002
                        SoBD = "0000" + (Tu_so + i).ToString
                        'Tính độ dài của số báo danh
                        SoBD = Right(SoBD, (So_sv + Tu_so).ToString.Length)
                        ID_sv = dvSinhVien.Item(i)("ID_sv")
                        idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(ID_sv)
                        If idx_sv >= 0 Then
                            objTCThi.dsChiTietSinhVien.TochucThiChiTiet(idx_sv).So_bao_danh = SoBD
                        End If
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Fill_GhiChu(ByVal dv As DataView, ByVal ID_thi As Integer)
            Try
                Dim idx_thi As Integer = 0
                idx_thi = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    Dim objTCThi As New TochucThi
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        For j As Integer = 0 To dv.Count - 1
                            If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_sv = dv.Item(j)("ID_sv") Then
                                objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Ghi_chu_thi = dv.Item(j)("Ghi_chu_thi").ToString
                            End If
                        Next
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub GanTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal ID_sv As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New TochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim idx_sv As Integer
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(ID_sv)
                    If idx_sv >= 0 Then
                        objTCThi.dsChiTietSinhVien.TochucThiChiTiet(idx_sv).Tui_so = Tui_so
                        'Update vào CSDL
                        Update_TochucThiChiTiet(objTCThi.dsChiTietSinhVien.TochucThiChiTiet(idx_sv), objTCThi.dsChiTietSinhVien.TochucThiChiTiet(idx_sv).ID_ds_thi)
                    End If
                End If
            End If
        End Sub
        Public Sub XoaTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New TochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = Tui_so Then
                            objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = 0
                            objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).So_phach = 0
                            'Update vào CSDL
                            Update_TochucThiChiTiet(objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_ds_thi)
                        End If
                    Next
                End If
            End If
        End Sub
        Public Function KiemTraSoPhach(ByVal ID_thi As Integer, ByVal So_phach_tu As Integer, ByVal So_sv As Integer) As Boolean
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New TochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    For So_phach As Integer = So_phach_tu To So_phach_tu + So_sv
                        For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                            If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).So_phach = So_phach Then
                                Return False
                            End If
                        Next
                    Next
                End If
            End If
            Return True
        End Function
        Public Sub LapSoPhach(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal So_phach_tu As Integer, Optional ByVal Tien_to As String = "")
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New TochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim so_phach As Integer = 0
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).Tui_so = Tui_so Then
                            objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).So_phach = Tien_to & So_phach_tu + so_phach
                            so_phach += 1
                            'Update vào CSDL
                            Update_TochucThiChiTiet(objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_ds_thi)
                        End If
                    Next
                End If
            End If
        End Sub
        Private Function Tim_idx(ByVal ID_thi As Integer) As Integer
            For i As Integer = 0 To arrTochucThi.Count - 1
                If CType(arrTochucThi(i), TochucThi).ID_thi = ID_thi Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Insert_TochucThi(ByVal objTochucThi As TochucThi) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Insert_TochucThi(objTochucThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TochucThi(ByVal objTochucThi As TochucThi, ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Update_TochucThi(objTochucThi, ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function UpdateLai_TochucThi(ByVal Ngay_thi As Date, ByVal Nhom_tiet As Integer, ByVal Thoi_gian As String, ByVal ID_thi As Integer) As Integer
            Try
                Dim objTCThi As New TochucThi
                objTCThi = arrTochucThi(0)
                objTCThi.Ngay_thi = Ngay_thi
                objTCThi.Nhom_tiet = Nhom_tiet
                objTCThi.Thoi_gian = Thoi_gian

                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Update_TochucThi(objTCThi, ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_TochucThi(ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Delete_TochucThi(ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ToChucThiPhong(ByVal objToChucThiPhong As ToChucThiPhong) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Insert_ToChucThiPhong(objToChucThiPhong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ToChucThiPhong(ByVal objToChucThiPhong As ToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Update_ToChucThiPhong(objToChucThiPhong, ID_phong_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ToChucThiTheoPhong(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Delete_ToChucThiTheoPhong(ID_thi, ID_phong_this)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_TochucThiChiTiet(ByVal objTochucThiChiTiet As TochucThiChiTiet) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Insert_TochucThiChiTiet(objTochucThiChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TochucThiChiTiet(ByVal objTochucThiChiTiet As TochucThiChiTiet, ByVal ID_ds_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Update_TochucThiChiTiet(objTochucThiChiTiet, ID_ds_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_TochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Delete_TochucThiChiTiet(ID_thi, ID_phong_this)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_TochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Delete_TochucThiChiTiet(ID_thi, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function ConvertToTocChucThi(ByVal dr As DataRow) As TochucThi
            Dim objTCThi As New TochucThi
            objTCThi.ID_thi = dr("ID_thi")
            objTCThi.Hoc_ky = dr("Hoc_ky")
            objTCThi.Nam_hoc = dr("Nam_hoc")
            objTCThi.ID_he = dr("ID_he")
            objTCThi.Ten_he = dr("Ten_he")
            objTCThi.ID_khoa = dr("ID_khoa")
            objTCThi.Ten_khoa = dr("Ten_khoa").ToString
            objTCThi.ID_mon = dr("ID_mon")
            objTCThi.Ten_mon = dr("Ten_mon")
            objTCThi.Lan_thi = dr("Lan_thi")
            objTCThi.Thoi_gian = dr("Thoi_gian").ToString
            objTCThi.Dot_thi = dr("Dot_thi")
            objTCThi.Ngay_thi = dr("Ngay_thi")
            objTCThi.Ca_thi = IIf(IsDBNull(dr("Ca_thi")), 0, dr("Ca_thi"))
            objTCThi.Nhom_tiet = IIf(IsDBNull(dr("Nhom_tiet")), 0, dr("Nhom_tiet"))
            Return objTCThi
        End Function
        Private Function ConvertToTocChucThiPhongThi(ByVal dr As DataRow) As ToChucThiPhong
            Dim objPhongThi As New ToChucThiPhong
            objPhongThi.ID_phong_thi = dr("ID_phong_thi")
            objPhongThi.Ten_phong = dr("Ten_phong")
            objPhongThi.So_sv = dr("So_sv")
            Return objPhongThi
        End Function
        Private Function ConvertToTocChucThiDongTui(ByVal dr As DataRow) As ToChucThiDongTui
            Dim obj As New ToChucThiDongTui
            obj.Tui_so = dr("Tui_so")
            obj.ID_thi = dr("ID_thi")
            Return obj
        End Function
        Private Function ConvertToTocChucThiChiTiet(ByVal dr As DataRow) As TochucThiChiTiet
            Dim objSV As New TochucThiChiTiet
            objSV.ID_ds_thi = dr("ID_ds_thi")
            objSV.ID_thi = dr("ID_thi")
            objSV.ID_sv = dr("ID_sv")
            objSV.Ma_sv = dr("Ma_sv")
            objSV.Ho_ten = dr("Ho_ten")
            objSV.Ho_dem = dr("Ho_dem")
            objSV.Ten = dr("Ten")
            objSV.Van_dau = dr("Van_dau")
            objSV.Quy_che = dr("Quy_che")
            If dr("Ngay_sinh").ToString.Trim <> "" Then
                objSV.Ngay_sinh = dr("Ngay_sinh")
            End If
            objSV.ID_lop = dr("ID_lop")
            objSV.Ten_lop = dr("Ten_lop").ToString
            objSV.Chuyen_nganh = dr("Chuyen_nganh").ToString
            objSV.Ten_tinh = dr("Ten_tinh").ToString
            objSV.ID_dt1 = dr("ID_dt")
            objSV.So_bao_danh = dr("So_bao_danh")
            objSV.So_phach = dr("So_phach")
            objSV.Tui_so = dr("Tui_so")
            objSV.ID_phong_thi = dr("ID_phong_thi")
            objSV.Ten_phong = dr("Ten_phong")
            objSV.Ghi_chu_thi = dr("Ghi_chu_thi")
            objSV.OrderBy = dr("OrderBy")
            objSV.Khoa_hoc = dr("Khoa_hoc")
            objSV.Dia_chi_tt = dr("Dia_chi_tt")
            Return objSV
        End Function

        Function Load_DotThi(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thi As Integer) As DataTable
            Dim clsTCThi As New TochucThi_DAL
            Dim dt As DataTable = clsTCThi.Load_DotThi(ID_he, Hoc_ky, Nam_hoc, Dot_thi)
            Dim dtMain As New DataTable

            dtMain.Columns.Add("ID_thi", GetType(Integer))
            dtMain.Columns.Add("Ngay_thi", GetType(Date))
            dtMain.Columns.Add("Thoi_gian", GetType(String))
            dtMain.Columns.Add("Ten_mon", GetType(String))
            dtMain.Columns.Add("Ten_he", GetType(String))
            dtMain.Columns.Add("Ten_phong", GetType(String))
            dtMain.Columns.Add("Tieu_de_ten_bo", GetType(String))
            dtMain.Columns.Add("Tieu_de_Ten_truong", GetType(String))
            dtMain.Columns.Add("Tieu_de1", GetType(String))
            dtMain.Columns.Add("Tieu_de2", GetType(String))
            dtMain.Columns.Add("Ghi_chu", GetType(String))

            For i As Integer = 0 To dt.Rows.Count - 1
                dtMain.DefaultView.Sort = "ID_thi"
                If dtMain.DefaultView.Find(dt.Rows(i).Item("ID_thi")) < 0 Then
                    Dim dr As DataRow
                    dr = dtMain.NewRow
                    dr("ID_thi") = dt.Rows(i).Item("ID_thi")
                    dr("Ngay_thi") = dt.Rows(i).Item("Ngay_thi")
                    dr("Thoi_gian") = "Nhóm tiết " & dt.Rows(i).Item("Thoi_gian")
                    dr("Ten_mon") = dt.Rows(i).Item("Ten_mon")
                    dr("Ten_he") = dt.Rows(i).Item("Ten_he")
                    dtMain.Rows.Add(dr)
                End If
            Next

            For i As Integer = 0 To dtMain.Rows.Count - 1
                Dim Hoi_truong As String = ""
                dt.DefaultView.RowFilter = "1=1"
                dt.DefaultView.RowFilter = "ID_thi=" & dtMain.Rows(i).Item("ID_thi")
                For j As Integer = 0 To dt.DefaultView.Count - 1
                    If Hoi_truong.Trim <> "" Then
                        Hoi_truong += ", " & dt.DefaultView.Item(j)("Ten_phong").ToString
                    Else
                        Hoi_truong = dt.DefaultView.Item(j)("Ten_phong").ToString
                    End If
                Next
                dtMain.Rows(i).Item("Ten_phong") = Hoi_truong.Trim
            Next

            Return dtMain
        End Function

        '-----------------Dong tui thi-------------------

        Private Function CheckExist_svDuTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal SoSV_Max As Integer) As Boolean
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Dim dt As DataTable = obj.Check_SosvDuTuiThi(ID_thi, Tui_so, SoSV_Max)
                If dt.Rows.Count > 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub DongTuiThi(ByVal dt_phong As DataTable, ByVal dt_dsthi As DataTable, ByVal ID_thi As Integer, ByVal SoSvMotTui_Max As Integer, ByVal SoSV_LanChia_TuiThi As Integer, ByVal So_phach_tu As Integer)
            Try
                Dim mdt_dsthi As New DataTable
                mdt_dsthi = dt_dsthi.Copy
                Dim i, j, s As Integer
                Dim TongSoSV As Integer = mdt_dsthi.Rows.Count
                Dim SoSV_PhongThi_DaChia As Integer = 0
                Dim SoSV_PhongThi_DaChia_tmp As Integer = 0
                mdt_dsthi.DefaultView.Sort = "ID_phong_thi"

                Dim SoSV_ConDu As Integer = TongSoSV Mod SoSvMotTui_Max
                Dim SoTui As Integer = (TongSoSV - SoSV_ConDu) / SoSvMotTui_Max
                If SoSV_ConDu > 0 Then SoTui += 1

                mdt_dsthi.Columns.Add("Lan_duyet", GetType(Integer))
                For i = 0 To mdt_dsthi.DefaultView.Count - 1
                    mdt_dsthi.Rows(i).Item("Tui_so") = 0
                    mdt_dsthi.Rows(i).Item("Lan_duyet") = 0
                Next
                While mdt_dsthi.DefaultView.Count > 0
                    For s = 1 To SoTui
                        'Neu so sv du theo so tui da chia thi chi ktra theo so sv du do
                        If s = SoTui AndAlso SoSV_ConDu > 0 Then SoSvMotTui_Max = SoSV_ConDu
                        'mdt_dsthi.DefaultView.RowFilter = "1=1"
                        mdt_dsthi.DefaultView.RowFilter = "Tui_so=" & s
                        Dim Lan_duyet As Integer = 0
                        Dim So_Sv_1tui As Integer = mdt_dsthi.DefaultView.Count
                        While So_Sv_1tui < SoSvMotTui_Max
                            Lan_duyet += 1
                            Dim ID_phong As Integer = 0
                            Dim SoSV_Max As Integer = 0
                            'Tim phong con sv chua xep voi gia tri lon nhat
                            For p As Integer = 0 To dt_phong.Rows.Count - 1
                                mdt_dsthi.DefaultView.RowFilter = "Tui_so=0 AND ID_phong_thi=" & dt_phong.Rows(p).Item("ID_phong_thi")
                                If SoSV_Max < mdt_dsthi.DefaultView.Count Then
                                    SoSV_Max = mdt_dsthi.DefaultView.Count
                                    ID_phong = dt_phong.Rows(p).Item("ID_phong_thi")
                                End If
                            Next

                            For i = 0 To dt_phong.Rows.Count - 1
                                'Lay cho phong con nhieu sv nhat chia truoc de tranh tinh trang ve sau chi con sv phong cuoi
                                If dt_phong.Rows(i).Item("ID_phong_thi") = ID_phong Then
                                    'Kiem tra neu phong con so sv chua xep vao tui thi -> xep vao tui
                                    mdt_dsthi.DefaultView.RowFilter = "Tui_so>0 AND ID_phong_thi=" & dt_phong.Rows(i).Item("ID_phong_thi")
                                    If mdt_dsthi.DefaultView.Count < dt_phong.Rows(i).Item("So_sv") Then
                                        'TInh so sv con co the chia
                                        mdt_dsthi.DefaultView.RowFilter = "Tui_so=0 AND ID_phong_thi=" & dt_phong.Rows(i).Item("ID_phong_thi")
                                        Dim So_SV As Integer = mdt_dsthi.DefaultView.Count
                                        For j = 0 To So_SV - 1
                                            mdt_dsthi.DefaultView.RowFilter = "Tui_so=" & s
                                            If mdt_dsthi.DefaultView.Count = SoSvMotTui_Max Then Exit While
                                            mdt_dsthi.DefaultView.RowFilter = "Tui_so=" & s & " AND Lan_duyet=" & Lan_duyet & " AND ID_phong_thi=" & dt_phong.Rows(i).Item("ID_phong_thi")
                                            If mdt_dsthi.DefaultView.Count < SoSV_LanChia_TuiThi Then
                                                mdt_dsthi.DefaultView.RowFilter = "Tui_so=0 AND ID_phong_thi=" & dt_phong.Rows(i).Item("ID_phong_thi")
                                                If mdt_dsthi.DefaultView.Count > 0 Then
                                                    mdt_dsthi.DefaultView.Item(0)("Lan_duyet") = Lan_duyet
                                                    mdt_dsthi.DefaultView.Item(0)("Tui_so") = s
                                                    If s = SoTui Then SoSvMotTui_Max = SoSvMotTui_Max - 1
                                                End If
                                            Else
                                                Exit For
                                            End If
                                        Next
                                    End If
                                End If
                            Next
                        End While
                    Next
                    mdt_dsthi.DefaultView.RowFilter = "Tui_so=0"
                End While
                mdt_dsthi.DefaultView.RowFilter = "1=1"
                mdt_dsthi.DefaultView.Sort = "Tui_so,Ten_phong,So_bao_danh"


                Dim so_phach As Integer = 0
                For i = 0 To mdt_dsthi.DefaultView.Count - 1
                    Dim objTochucThiChiTiet As New TochucThiChiTiet
                    objTochucThiChiTiet.ID_ds_thi = mdt_dsthi.DefaultView.Item(i)("ID_ds_thi")
                    objTochucThiChiTiet.ID_thi = ID_thi
                    objTochucThiChiTiet.ID_sv = mdt_dsthi.DefaultView.Item(i)("ID_SV")
                    objTochucThiChiTiet.ID_phong_thi = mdt_dsthi.DefaultView.Item(i)("ID_phong_thi")
                    objTochucThiChiTiet.So_bao_danh = mdt_dsthi.DefaultView.Item(i)("So_bao_danh")
                    objTochucThiChiTiet.So_phach = so_phach + So_phach_tu
                    objTochucThiChiTiet.Tui_so = mdt_dsthi.DefaultView.Item(i)("Tui_so")
                    objTochucThiChiTiet.Ghi_chu_thi = mdt_dsthi.DefaultView.Item(i)("Ghi_chu_thi")
                    objTochucThiChiTiet.OrderBy = mdt_dsthi.DefaultView.Item(i)("OrderBy")

                    Update_TochucThiChiTiet(objTochucThiChiTiet, mdt_dsthi.DefaultView.Item(i)("ID_ds_thi"))
                    so_phach += 1
                Next
            Catch ex As Exception
            End Try


            '            Try
            '                Dim i, j, s As Integer
            '                Dim TongSoSV As Integer = dt_dsthi.Rows.Count
            '                Dim SoSV_PhongThi_DaChia As Integer = 0
            '                Dim SoSV_PhongThi_DaChia_tmp As Integer = 0
            '                dt_dsthi.DefaultView.Sort = "ID_phong_thi"
            '                Dim SoSvMotTui_Max_tmp As Integer = SoSvMotTui_Max

            '                Dim SoSV_ConDu As Integer = TongSoSV Mod SoSvMotTui_Max
            '                Dim SoTui As Integer = (TongSoSV - SoSV_ConDu) / SoSvMotTui_Max
            '                If SoSV_ConDu > 0 Then SoTui += 1
            '                Dim f As Boolean = True
            '                For i = 0 To dt_phong.Rows.Count - 1 'Liet ke voi moi Phong thi de do sinh vien vao Tui thi theo so sv cua lan chia cho tui-Tham so he thong
            'VetCan:             For j = 1 To SoTui ' Insert sinh vien vao tung tui thi
            '                        dt_dsthi.DefaultView.RowFilter = "1=1"
            '                        dt_dsthi.DefaultView.RowFilter = "Tui_so=" & j
            '                        SoSvMotTui_Max = SoSvMotTui_Max_tmp
            '                        ' Truong hop la tui cuoi cung co so sv le ko du 1 lan chia
            '                        If j = SoTui And SoSV_ConDu > 0 Then SoSvMotTui_Max = SoSV_ConDu
            '                        If dt_dsthi.DefaultView.Count < SoSvMotTui_Max Then 'Chua du so sinh vien cua Tui thi thi insert vao tui thi
            '                            If SoSV_PhongThi_DaChia < dt_phong.Rows(i).Item("So_sv") Then 'Neu So sinh vien cua phong thi con
            '                                Dim tmp As Integer = SoSV_PhongThi_DaChia
            '                                If dt_phong.Rows(i).Item("So_sv") - SoSV_PhongThi_DaChia > SoSV_LanChia_TuiThi Then 'Neu so sinh vien cua phong thi con du chia theo so lan chia vao tui thi
            '                                    For s = tmp + SoSV_PhongThi_DaChia_tmp To tmp + SoSV_PhongThi_DaChia_tmp + SoSV_LanChia_TuiThi - 1
            '                                        'Insert tung sinh vien vao tui thi tuong ung

            '                                        dt_dsthi.Rows(s).Item("Tui_so") = j
            '                                        SoSV_PhongThi_DaChia += 1
            '                                        If dt_dsthi.DefaultView.Count = SoSvMotTui_Max Then Exit For
            '                                    Next
            '                                Else 'Neu so sinh vien cua phong thi khong con du chia cho lan chia vao tui thi
            '                                    For s = tmp + SoSV_PhongThi_DaChia_tmp To dt_phong.Rows(i).Item("So_sv") + SoSV_PhongThi_DaChia_tmp - 1
            '                                        'Insert tung sinh vien vao tui thi tuong ung

            '                                        dt_dsthi.Rows(s).Item("Tui_so") = j
            '                                        SoSV_PhongThi_DaChia += 1
            '                                        If dt_dsthi.DefaultView.Count = SoSvMotTui_Max Then Exit For
            '                                    Next
            '                                    If SoSV_PhongThi_DaChia = dt_phong.Rows(i).Item("So_sv") Then
            '                                        SoSV_PhongThi_DaChia_tmp += SoSV_PhongThi_DaChia
            '                                        SoSV_PhongThi_DaChia = 0
            '                                        Exit For
            '                                    End If
            '                                End If
            '                                If SoSV_PhongThi_DaChia < dt_phong.Rows(i).Item("So_sv") Then GoTo VetCan
            '                            End If
            '                        End If
            '                    Next
            '                Next
            '                dt_dsthi.DefaultView.Sort = "Tui_so,So_bao_danh"
            '                dt_dsthi.DefaultView.RowFilter = "1=1"

            '                Dim so_phach As Integer = 0
            '                For i = 0 To dt_dsthi.DefaultView.Count - 1
            '                    Dim objTochucThiChiTiet As New TochucThiChiTiet
            '                    objTochucThiChiTiet.ID_ds_thi = dt_dsthi.DefaultView.Item(i)("ID_ds_thi")
            '                    objTochucThiChiTiet.ID_thi = ID_thi
            '                    objTochucThiChiTiet.ID_sv = dt_dsthi.DefaultView.Item(i)("ID_SV")
            '                    objTochucThiChiTiet.ID_phong_thi = dt_dsthi.DefaultView.Item(i)("ID_phong_thi")
            '                    objTochucThiChiTiet.So_bao_danh = dt_dsthi.DefaultView.Item(i)("So_bao_danh")
            '                    objTochucThiChiTiet.So_phach = so_phach + So_phach_tu
            '                    objTochucThiChiTiet.Tui_so = dt_dsthi.DefaultView.Item(i)("Tui_so")
            '                    objTochucThiChiTiet.Ghi_chu_thi = dt_dsthi.DefaultView.Item(i)("Ghi_chu_thi")
            '                    objTochucThiChiTiet.OrderBy = dt_dsthi.DefaultView.Item(i)("OrderBy")

            '                    Update_TochucThiChiTiet(objTochucThiChiTiet, dt_dsthi.DefaultView.Item(i)("ID_ds_thi"))
            '                    so_phach += 1
            '                Next
            '            Catch ex As Exception
            '            End Try
        End Sub

        Function CatSoVanBang(ByVal So_van_bang As String, ByVal Do_dai As Integer) As String
            So_van_bang = Right(So_van_bang, Do_dai)
            Return So_van_bang
        End Function

        Public Sub LapSoPhach_DongTuiThi(ByVal ID_thi As Integer, ByVal So_phach_tu As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New TochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim so_phach As Integer = 0
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), TochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).So_phach = So_phach_tu + so_phach
                        so_phach += 1
                        'Update vào CSDL
                        Update_TochucThiChiTiet(objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.TochucThiChiTiet(i).ID_ds_thi)
                    Next
                End If
            End If
        End Sub
        Public Function Load_DiemThi_ChinhTri(ByVal ID_lop As Integer) As DataTable
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Load_DiemThi_ChinhTri(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_SinhVienThiChinhTri(ByVal ID_sv As Integer, ByVal Diem_thi As Double) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.Insert_SinhVienThiChinhTri(ID_sv, Diem_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DELETE_SinhVienThiChinhTri(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As TochucThi_DAL = New TochucThi_DAL
                Return obj.DELETE_SinhVienThiChinhTri(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrTochucThi.Count
            End Get
        End Property
        Public Property ToChucThi(ByVal idx As Integer) As TochucThi
            Get
                Return CType(arrTochucThi(idx), TochucThi)
            End Get
            Set(ByVal Value As TochucThi)
                arrTochucThi(idx) = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
