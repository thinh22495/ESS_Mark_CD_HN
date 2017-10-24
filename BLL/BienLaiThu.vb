'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, July 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class BienLaiThu_BLL
        Private arrBienLaiThu As New ArrayList
        Private dtDsThuChi As DataTable ' Bảng danh sách thu chi cua sinh viên (Dùng trong load Hồ sơ sinh viên)
#Region "Constructor"
        Sub New()

        End Sub
        ' Khởi tạo biên lại thu theo môn tin chỉ
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer)
            Dim dtBL, dtBLChiTiet As DataTable
            'Load biên lai
            dtBL = Load_BienLaiThu_List(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            'Load biên lai chi tiết
            dtBLChiTiet = Load_BienLaiThuChiChiTiet_List(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            For i As Integer = 0 To dtBL.Rows.Count - 1
                Dim objBL As New BienLaiThu
                'Chhuyển datarow thành object
                objBL = ConvertBienLaiThu(dtBL.Rows(i))
                For j As Integer = 0 To dtBLChiTiet.Rows.Count - 1
                    If objBL.ID_bien_lai = dtBLChiTiet.Rows(j)("ID_bien_lai") Then
                        Dim objBLChiTiet As New BienLaiThuChiTiet
                        'Chhuyển datarow thành object
                        objBLChiTiet = ConvertBienLaiThuChiTiet(dtBLChiTiet.Rows(j))
                        'Add một object
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                'Add một object
                arrBienLaiThu.Add(objBL)
            Next
        End Sub
        Sub New(ByVal ID_bien_lai As Integer)
            Dim dtBL, dtBLChiTiet As DataTable
            'Load biên lai
            dtBL = Load_BienLaiThu(ID_bien_lai)
            'Load biên lai chi tiết
            dtBLChiTiet = Load_BienLaiThuChiChiTiet(ID_bien_lai)
            For i As Integer = 0 To dtBL.Rows.Count - 1
                Dim objBL As New BienLaiThu
                'Chhuyển datarow thành object
                objBL = ConvertBienLaiThu(dtBL.Rows(i))
                For j As Integer = 0 To dtBLChiTiet.Rows.Count - 1
                    If objBL.ID_bien_lai = dtBLChiTiet.Rows(j)("ID_bien_lai") Then
                        Dim objBLChiTiet As New BienLaiThuChiTiet
                        'Chhuyển datarow thành object
                        objBLChiTiet = ConvertBienLaiThuChiTiet(dtBLChiTiet.Rows(j))
                        'Add một object
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                'Add một object
                arrBienLaiThu.Add(objBL)
            Next
        End Sub
        ' Khởi tạo danh sách thu chi (Dùng trong load Hồ sơ sinh viên)
        Sub New(ByVal ID_sv As Integer, ByVal Hoso As Boolean)
            Try
                Dim obj As New BienLaiThu_DAL
                dtDsThuChi = obj.Load_DanhSach_ThuChi_List(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        Public Sub AddHocPhi(ByRef dtDSSV As DataTable)
            Try
                dtDSSV.Columns.Add("Hoc_phi", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Hoc_phi") = HocPhi_Ky(dtDSSV.Rows(i)("ID_sv"))
                Next
            Catch ex As Exception

            End Try
        End Sub
        Public Function HocPhi_Ky(ByVal id_sv As Integer) As String
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim obj As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                If obj.ID_sv = id_sv Then
                    Return obj.So_tien.ToString
                End If
            Next
            Return ""
        End Function
        Public Sub Add(ByVal CTDT As BienLaiThu)
            arrBienLaiThu.Add(CTDT)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrBienLaiThu.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return arrBienLaiThu.Count
            End Get
        End Property
        Public Property BienLaiThu(ByVal idx As Integer) As BienLaiThu
            Get
                Return CType(arrBienLaiThu(idx), BienLaiThu)
            End Get
            Set(ByVal Value As BienLaiThu)
                arrBienLaiThu(idx) = Value
            End Set
        End Property
        Public Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                If CType(arrBienLaiThu(i), BienLaiThu).ID_sv = ID_sv And CType(arrBienLaiThu(i), BienLaiThu).Huy_phieu = False Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function DanhSachBienLaiThuHocPhan(ByVal ID_thu_chi As Integer, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByVal Huy_phieu As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim idx As Integer
            'Add thêm các cột về biên lai
            dtDanhSach.Columns.Add("idx_bl", GetType(Integer))
            dtDanhSach.Columns.Add("Dot_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Lan_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Nguoi_thu", GetType(String))
            dtDanhSach.Columns.Add("Huy_phieu", GetType(Boolean))
            dtDanhSach.Columns.Add("Ngoai_te", GetType(String))
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                If objBL.ThuTheoHocPhan Then
                    Dim dr As DataRow = dtDanhSach.NewRow
                    dr("idx_bl") = i
                    dr("Dot_thu") = objBL.Dot_thu
                    dr("Lan_thu") = objBL.Lan_thu
                    dr("Nguoi_thu") = objBL.Nguoi_thu
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("Huy_phieu") = objBL.Huy_phieu
                    dr("Ngoai_te") = objBL.Ngoai_te
                    dr("So_phieu") = objBL.So_phieu
                    dr("Ma_sv") = objBL.Ma_sv
                    dr("Ho_ten") = objBL.Ho_ten
                    dr("So_phieu") = objBL.So_phieu
                    dr("So_tien") = objBL.So_tien
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("ID_bien_lai") = objBL.ID_bien_lai
                    If ID_mon > 0 Then
                        If Ky_hieu_lop_tc <> "" Then
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, ID_thu_chi, ID_mon, Ky_hieu_lop_tc)
                        Else
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, ID_thu_chi, ID_mon)
                        End If
                        If idx >= 0 Then
                            dr("So_tien") = objBL.dsBienLaiChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                    dr("Noi_dung") = objBL.Noi_dung
                    If dr("So_tien").ToString <> "" And dr("Huy_phieu") = Huy_phieu Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        Public Function DanhSachBienLaiThuHocKy(ByVal ID_thu_chi As Integer, ByVal Huy_phieu As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai            
            dtDanhSach.Columns.Add("idx_bl", GetType(Integer))
            dtDanhSach.Columns.Add("Dot_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Lan_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Nguoi_thu", GetType(String))
            dtDanhSach.Columns.Add("Huy_phieu", GetType(Boolean))
            dtDanhSach.Columns.Add("Ngoai_te", GetType(String))
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            dtDanhSach.Columns.Add("ID_hoc_phi", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                If Not objBL.ThuTheoHocPhan Then
                    Dim dr As DataRow = dtDanhSach.NewRow
                    dr("idx_bl") = i
                    dr("Dot_thu") = objBL.Dot_thu
                    dr("Lan_thu") = objBL.Lan_thu
                    dr("Nguoi_thu") = objBL.Nguoi_thu
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("Huy_phieu") = objBL.Huy_phieu
                    dr("Ngoai_te") = objBL.Ngoai_te
                    dr("So_phieu") = objBL.So_phieu
                    dr("Ma_sv") = objBL.Ma_sv
                    dr("Ho_ten") = objBL.Ho_ten
                    dr("ID_bien_lai") = objBL.ID_bien_lai
                    ' neu da dong 1 trong 2 loai hoc phi
                    If objBL.dsBienLaiChiTiet.Tim_ID_thu_chi(24) = 24 Or objBL.dsBienLaiChiTiet.Tim_ID_thu_chi(25) = 25 Then
                        dr("ID_hoc_phi") = objBL.ID_bien_lai
                    Else
                        dr("ID_hoc_phi") = 0
                    End If
                    So_tien = 0
                    For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                        If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                    Next
                    If So_tien > 0 Then
                        dr("So_tien") = So_tien
                    End If
                    dr("Noi_dung") = objBL.Noi_dung
                    If dr("So_tien").ToString <> "" And dr("Huy_phieu") = Huy_phieu Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        Public Function DanhSachBienLaiThuHocKy_GoiNhapHoc(ByVal ID_thu_chi As Integer, ByVal Huy_phieu As Boolean, ByVal Nguoi_thu As String) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai     
            dtDanhSach.Columns.Add("ID_sv", GetType(Integer))
            dtDanhSach.Columns.Add("idx_bl", GetType(Integer))
            dtDanhSach.Columns.Add("Dot_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Lan_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Nguoi_thu", GetType(String))
            dtDanhSach.Columns.Add("Huy_phieu", GetType(Boolean))
            dtDanhSach.Columns.Add("Ngoai_te", GetType(String))
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            dtDanhSach.Columns.Add("ID_hoc_phi", GetType(Integer))
            dtDanhSach.Columns.Add("Ten_tinh", GetType(String))
            dtDanhSach.Columns.Add("Ten_huyen", GetType(String))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                If Not objBL.ThuTheoHocPhan And objBL.Noi_dung = "Thu phí nhập học" Then
                    Dim dr As DataRow = dtDanhSach.NewRow
                    dr("ID_sv") = objBL.ID_sv
                    dr("idx_bl") = i
                    dr("Dot_thu") = objBL.Dot_thu
                    dr("Lan_thu") = objBL.Lan_thu
                    dr("Nguoi_thu") = objBL.Nguoi_thu
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("Huy_phieu") = objBL.Huy_phieu
                    dr("Ngoai_te") = objBL.Ngoai_te
                    dr("So_phieu") = objBL.So_phieu
                    dr("Ma_sv") = objBL.Ma_sv
                    dr("Ho_ten") = objBL.Ho_ten
                    dr("ID_bien_lai") = objBL.ID_bien_lai                    
                    ' neu da dong 1 trong 2 loai hoc phi
                    If objBL.dsBienLaiChiTiet.Tim_ID_thu_chi(24) = 24 Or objBL.dsBienLaiChiTiet.Tim_ID_thu_chi(25) = 25 Then
                        dr("ID_hoc_phi") = objBL.ID_bien_lai
                    Else
                        dr("ID_hoc_phi") = 0
                    End If
                    So_tien = 0
                    For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                        If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                    Next
                    If So_tien > 0 Then
                        dr("So_tien") = So_tien
                    End If
                    dr("Noi_dung") = objBL.Noi_dung
                    dr("Ten_tinh") = objBL.Ten_tinh
                    dr("Ten_huyen") = objBL.Ten_huyen
                    If Nguoi_thu <> "" Then
                        If objBL.Nguoi_thu = Nguoi_thu Then
                            If dr("So_tien").ToString <> "" And objBL.Huy_phieu = Huy_phieu Then dtDanhSach.Rows.Add(dr)
                        End If
                    Else
                        If dr("So_tien").ToString <> "" And objBL.Huy_phieu = Huy_phieu Then dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        Public Function DanhSach_KhoanNop_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal idx_bl As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim Phan_tram_MG, idx1 As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.Load_KhoanNop_HocKy_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền            
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Nop_tien", GetType(Boolean))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
                dtKhoanNop.Rows(i)("Nop_tien") = True
            Next

            If idx_bl >= 0 Then ' Nếu sửa phiếu
                Dim objBLChiTiet As BienLaiThuChiTiet
                objBLChiTiet = CType(arrBienLaiThu(idx_bl), BienLaiThu).dsBienLaiChiTiet
                For i As Integer = dtKhoanNop.Rows.Count - 1 To 0 Step -1
                    Dim objBL As BienLaiThu
                    objBL = CType(arrBienLaiThu(idx_bl), BienLaiThu)
                    idx1 = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                    If idx1 >= 0 And objBL.ID_sv = ID_sv Then
                        dtKhoanNop.Rows(i)("Nop_tien") = True
                        dtKhoanNop.Rows(i)("So_tien_nop") = objBLChiTiet.BienLaiChiTiet(idx1).So_tien
                    Else
                        dtKhoanNop.Rows(i).Delete()
                    End If
                Next
            Else
                For i As Integer = dtKhoanNop.Rows.Count - 1 To 0 Step -1
                    dtKhoanNop.Rows(i)("Nop_tien") = True
                Next
            End If
            dtKhoanNop.AcceptChanges()
            Return dtKhoanNop
        End Function
        Public Function TongHop_KhoanNop_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, Optional ByVal dsID_lop As String = "") As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.Load_KhoanNop_HocKy_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền                        
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBLChiTiet As BienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), BienLaiThu).dsBienLaiChiTiet
                    Dim objBL As BienLaiThu
                    objBL = CType(arrBienLaiThu(j), BienLaiThu)
                    If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp
                        idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtKhoanNop.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtKhoanNop.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtKhoanNop.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtKhoanNop.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtKhoanNop.Rows
                Tong_tien += dr("So_tien")
                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                Tong_tien_nop += dr("So_tien_nop")
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop

            ' Các khoản chi
            Dim dtChi As DataTable
            Dim objChi As New BienLaiThu_DAL
            dtChi = objChi.Load_BienLaiChi(Hoc_ky, Nam_hoc, dsID_lop, 0, 0, ID_sv)
            Dim Tong_tien_chi As Double = 0
            For i As Integer = 0 To dtChi.Rows.Count - 1
                Tong_tien_chi += IIf(dtChi.Rows(i)("So_tien").ToString = "", 0, dtChi.Rows(i)("So_tien"))
            Next
            If Tong_Thieu_thua < 0 Then ' Nếu thừa tiền                        
                Tong_Thieu_thua = Tong_Thieu_thua + Tong_tien_chi
            End If
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
        'Chỉ Tổng hợp khoản nộp học phí theo kỳ
        Public Function TongHop_NopHocPhi_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.Load_KhoanNop_HocKy_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền                        
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") Then ' Nếu là nộp học phí
                    Dim Tong_So_tien_da_nop As Integer = 0
                    Dim Thieu_thua As Integer = 0
                    For j As Integer = 0 To arrBienLaiThu.Count - 1
                        Dim objBLChiTiet As BienLaiThuChiTiet
                        objBLChiTiet = CType(arrBienLaiThu(j), BienLaiThu).dsBienLaiChiTiet
                        Dim objBL As BienLaiThu
                        objBL = CType(arrBienLaiThu(j), BienLaiThu)
                        If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                            If idx >= 0 Then
                                Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                                Thieu_thua += dtKhoanNop.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            End If
                        End If
                    Next
                    dtKhoanNop.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                    dtKhoanNop.Rows(i)("Thieu_thua") = Thieu_thua
                End If
            Next
            dtKhoanNop.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtKhoanNop.Rows
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 And dr("Hoc_phi") Then
                    Tong_tien += dr("So_tien")
                    Tong_tien_mien_giam += dr("So_tien_mien_giam")
                    Tong_tien_nop += dr("So_tien_nop")
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function Load_BienLaiThu(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Load_BienLaiThu(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Load_BienLaiThu_List(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSo_phieu() As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.getSo_phieu()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_bien_lai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.getID_bien_lai(ID_sv, Hoc_ky, Nam_hoc, Dot_thu, Lan_thu, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_sv(ByVal Ma_sv As String) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.getID_sv(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThuChiChiTiet(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Load_BienLaiThuChiTiet(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThuChiChiTiet_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Load_BienLaiThuChiTiet_List(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_BienLaiThu(ByVal objBienLaiThu As BienLaiThu) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Insert_BienLaiThu(objBienLaiThu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BienLaiThu(ByVal objBienLaiThu As BienLaiThu, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Update_BienLaiThu(objBienLaiThu, ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BienLaiThu_HuyPhieu(ByVal ID_bien_lai As Integer, ByVal Ly_do As String) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Update_BienLaiThu_HuyPhieu(ID_bien_lai, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThu(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Delete_BienLaiThu(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_BienLaiThuChiTiet(ByVal objBienLaiThuChiTiet As BienLaiThuChiTiet) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Insert_BienLaiThuChiTiet(objBienLaiThuChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BienLaiThuChiTiet(ByVal objBienLaiThuChiTiet As BienLaiThuChiTiet, ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Update_BienLaiThuChiTiet(objBienLaiThuChiTiet, ID_bien_lai_sub)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThuChiTiet(ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Delete_BienLaiThuChiTiet(ID_bien_lai_sub)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BienLaiThuChiTiet_IDBienLai(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                Return obj.Delete_BienLaiThuChiTiet_IDBienLai(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function ConvertBienLaiThu(ByVal drBienLaiThu As DataRow) As BienLaiThu
            Dim result As BienLaiThu
            Try
                result = New BienLaiThu
                If drBienLaiThu("ID_sv").ToString() <> "" Then result.ID_sv = CType(drBienLaiThu("ID_sv").ToString(), Integer)
                result.Ma_sv = drBienLaiThu("Ma_sv").ToString()
                result.Ho_ten = drBienLaiThu("Ho_ten").ToString()
                result.Ten_lop = drBienLaiThu("Ten_lop").ToString()
                If drBienLaiThu("ID_bien_lai").ToString() <> "" Then result.ID_bien_lai = CType(drBienLaiThu("ID_bien_lai").ToString(), Integer)
                If drBienLaiThu("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drBienLaiThu("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drBienLaiThu("Nam_hoc").ToString()
                If drBienLaiThu("Dot_thu").ToString() <> "" Then result.Dot_thu = CType(drBienLaiThu("Dot_thu").ToString(), Integer)
                If drBienLaiThu("Lan_thu").ToString() <> "" Then result.Lan_thu = CType(drBienLaiThu("Lan_thu").ToString(), Integer)
                If drBienLaiThu("ID_sv").ToString() <> "" Then result.ID_sv = CType(drBienLaiThu("ID_sv").ToString(), Integer)
                result.Thu_chi = drBienLaiThu("Thu_chi").ToString()
                If drBienLaiThu("So_phieu").ToString() <> "" Then result.So_phieu = CType(drBienLaiThu("So_phieu").ToString(), Integer)
                If drBienLaiThu("Ngay_thu").ToString() <> "" Then result.Ngay_thu = CType(drBienLaiThu("Ngay_thu").ToString(), Date)
                result.Noi_dung = drBienLaiThu("Noi_dung").ToString()
                result.So_tien = drBienLaiThu("So_tien").ToString()
                result.So_tien_chu = drBienLaiThu("So_tien_chu").ToString()
                result.Ngoai_te = drBienLaiThu("Ngoai_te").ToString()
                result.Huy_phieu = drBienLaiThu("Huy_phieu").ToString()
                result.Ghi_chu = drBienLaiThu("Ghi_chu").ToString()
                result.Nguoi_thu = drBienLaiThu("Nguoi_thu").ToString()
                result.Printed = drBienLaiThu("Printed").ToString()
                result.Ten_tinh = drBienLaiThu("Ten_tinh").ToString()
                result.Ten_huyen = drBienLaiThu("Ten_huyen").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertBienLaiThuChiTiet(ByVal drsvBienLaiThuChiTiet As DataRow) As BienLaiThuChiTiet
            Dim result As BienLaiThuChiTiet
            Try
                result = New BienLaiThuChiTiet
                If drsvBienLaiThuChiTiet("ID_bien_lai_sub").ToString() <> "" Then result.ID_bien_lai_sub = CType(drsvBienLaiThuChiTiet("ID_bien_lai_sub").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_bien_lai").ToString() <> "" Then result.ID_bien_lai = CType(drsvBienLaiThuChiTiet("ID_bien_lai").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drsvBienLaiThuChiTiet("ID_thu_chi").ToString(), Integer)
                'If drsvBienLaiThuChiTiet("ID_mon").ToString() <> "" Then result.ID_mon = CType(drsvBienLaiThuChiTiet("ID_mon").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drsvBienLaiThuChiTiet("ID_mon_tc").ToString(), Integer)
                'result.Ky_hieu_lop_tc = drsvBienLaiThuChiTiet("Ky_hieu_lop_tc").ToString()
                If drsvBienLaiThuChiTiet("So_tien").ToString() <> "" Then result.So_tien = CType(drsvBienLaiThuChiTiet("So_tien").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#Region "Tổng hợp các khoản thu khác"
        Public Function TongHop_DanhSachSv_Nop_HocKy(ByVal dtSv As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Toan_khoa As Boolean, ByVal ID_thu_chi As Integer, ByRef ProgressBar As System.Windows.Forms.ProgressBar) As DataTable
            Try                
                Dim dt As DataTable
                dt = dtSv.Copy
                dt.Columns.Add("So_tien", GetType(Integer))
                dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dt.Columns.Add("So_tien_nop", GetType(Integer))
                dt.Columns.Add("So_tien_da_nop", GetType(Integer))
                dt.Columns.Add("Thieu_thua", GetType(Integer))
                dt.Columns.Add("Hoan_thanh_nop", GetType(Integer))

                ProgressBar.Minimum = 0
                ProgressBar.Maximum = dtSv.Rows.Count - 1
                ProgressBar.Step = 1
                ProgressBar.Value = 0

                Dim obj As New BienLaiThu_DAL
                For i As Integer = 0 To dt.Rows.Count - 1
                    ProgressBar.Value = i
                    ' Load khoản nộp học kỳ của sinh viên
                    Dim dvKhoanNop As New DataView
                    If Toan_khoa Then
                        dvKhoanNop = obj.Load_KhoanNop_HocKy_List(0, "", dt.Rows(i)("ID_sv")).DefaultView
                        ' Xoa cac khoan thuoc hoc ky nam hoc khac
                        For j As Integer = dvKhoanNop.Count - 1 To 0 Step -1
                            If CInt(dvKhoanNop.Item(j)("Nam_hoc").ToString.Substring(0, 4)) > CInt(Nam_hoc.Substring(0, 4)) Then
                                dvKhoanNop.Item(j).Delete()
                            ElseIf CInt(dvKhoanNop.Item(j)("Nam_hoc").ToString.Substring(0, 4)) = CInt(Nam_hoc.Substring(0, 4)) Then
                                If dvKhoanNop.Item(j)("Hoc_ky") > Hoc_ky Then
                                    dvKhoanNop.Item(j).Delete()
                                End If
                            End If
                        Next
                    Else
                        dvKhoanNop = obj.Load_KhoanNop_HocKy_List(Hoc_ky, Nam_hoc, dt.Rows(i)("ID_sv")).DefaultView
                    End If
                    Dim dk1 As String = "1=1"
                    If ID_thu_chi > 0 Then dk1 += " And ID_thu_chi=" & ID_thu_chi
                    dvKhoanNop.RowFilter = dk1
                    'Tính các cột số tiền
                    Dim So_tien As Double = 0
                    Dim So_tien_mien_giam As Double = 0
                    Dim So_tien_nop As Double = 0
                    Dim So_tien_da_nop As Double = 0
                    Dim Thieu_thua As Double = 0
                    Dim Phan_tram_MG As Double = 0
                    For j As Integer = 0 To dvKhoanNop.Count - 1
                        So_tien += IIf(dvKhoanNop.Item(j)("So_tien").ToString = "", 0, dvKhoanNop.Item(j)("So_tien"))
                        'Miễn giảm sinh viên
                        Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(dvKhoanNop.Item(j)("Hoc_ky"), dvKhoanNop.Item(j)("Nam_hoc"), CInt(dvKhoanNop.Item(j)("ID_sv")))
                        If clsMGHP.Count > 0 Then
                            Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
                        Else
                            Phan_tram_MG = 0
                        End If
                        If dvKhoanNop.Item(j)("Hoc_phi") And Phan_tram_MG > 0 Then
                            So_tien_mien_giam += (IIf(dvKhoanNop.Item(j)("So_tien").ToString = "", 0, dvKhoanNop.Item(j)("So_tien")) * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm                         
                        End If
                    Next
                    So_tien_nop = So_tien - So_tien_mien_giam
                    ' Load các khoản đã nộp
                    Dim dtNop As DataTable
                    dtNop = obj.TongHopDaNopHocPhi_TheoKy(dt.Rows(i)("ID_sv"))
                    Dim dk As String = "1=1"
                    If Not Toan_khoa Then
                        dk += " And Hoc_ky=" & Hoc_ky & " And Nam_hoc='" & Nam_hoc & "'"
                    Else
                        ' Xoa cac khoan thuoc hoc ky nam hoc khac
                        If dt.Rows(i)("ID_sv") = 44068 Then
                            dk = dk
                        End If
                        For j As Integer = dtNop.Rows.Count - 1 To 0 Step -1
                            If CInt(dtNop.Rows(j)("Nam_hoc").ToString.Substring(0, 4)) > CInt(Nam_hoc.Substring(0, 4)) Then
                                dtNop.Rows(j).Delete()
                            ElseIf CInt(dtNop.Rows(j)("Nam_hoc").ToString.Substring(0, 4)) = CInt(Nam_hoc.Substring(0, 4)) Then
                                If dtNop.Rows(j)("Hoc_ky") > Hoc_ky Then
                                    dtNop.Rows(j).Delete()
                                End If
                            End If
                        Next
                    End If
                    If ID_thu_chi > 0 Then dk += " And ID_thu_chi=" & ID_thu_chi
                    dtNop.DefaultView.RowFilter = dk
                    For j As Integer = 0 To dtNop.DefaultView.Count - 1
                        So_tien_da_nop += IIf(dtNop.DefaultView.Item(j)("So_tien_da_nop").ToString = "", 0, dtNop.DefaultView.Item(j)("So_tien_da_nop"))
                    Next
                    Thieu_thua += So_tien_nop - So_tien_da_nop
                    '-----Tinh so tien chi----------
                    ' Các khoản chi
                    Dim dtChi As DataTable
                    dtChi = obj.Load_BienLaiChi(Hoc_ky, Nam_hoc, "", ID_thu_chi, 0, dt.Rows(i)("ID_sv"))
                    Dim Tong_tien_chi As Double = 0
                    For k As Integer = 0 To dtChi.Rows.Count - 1
                        If dtChi.Rows(k)("ID_sv") = dt.Rows(i)("ID_sv") Then
                            Tong_tien_chi += IIf(dtChi.Rows(k)("So_tien").ToString = "", 0, dtChi.Rows(k)("So_tien"))
                        End If
                    Next
                    If Thieu_thua < 0 Then ' Nếu thừa tiền                        
                        Thieu_thua = Thieu_thua + Tong_tien_chi
                    End If
                    '-----Tinh so tien chi----------
                    If So_tien > 0 Then dt.Rows(i)("So_tien") = So_tien
                    If So_tien_mien_giam > 0 Then dt.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                    If So_tien_nop > 0 Then dt.Rows(i)("So_tien_nop") = So_tien_nop
                    If So_tien_da_nop > 0 Then dt.Rows(i)("So_tien_da_nop") = So_tien_da_nop
                    dt.Rows(i)("Thieu_thua") = Thieu_thua
                    If Thieu_thua <= 0 Then
                        dt.Rows(i)("Hoan_thanh_nop") = 1
                    Else
                        dt.Rows(i)("Hoan_thanh_nop") = 0
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachBienLaiThuHocKy_SinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Toan_khoa As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai      
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("Ngay_sinh", GetType(Date))
            dtDanhSach.Columns.Add("Hoc_ky", GetType(Integer))
            dtDanhSach.Columns.Add("Nam_hoc", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                Dim dr As DataRow = dtDanhSach.NewRow
                dr("Ma_sv") = objBL.Ma_sv
                dr("Ho_ten") = objBL.Ho_ten
                dr("Ngay_sinh") = objBL.Ngay_sinh
                dr("Hoc_ky") = objBL.Hoc_ky
                dr("Nam_hoc") = objBL.Nam_hoc
                dr("So_phieu") = objBL.So_phieu
                dr("Ngay_thu") = objBL.Ngay_thu
                dr("Noi_dung") = objBL.Noi_dung
                dr("ID_bien_lai") = objBL.ID_bien_lai
                So_tien = 0
                For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                    If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                Next
                If So_tien > 0 Then
                    dr("So_tien") = So_tien
                End If
                If Toan_khoa Then
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        If objBL.Nam_hoc.Substring(5, 4) < Nam_hoc.Substring(5, 4) Then
                            dtDanhSach.Rows.Add(dr)
                        ElseIf objBL.Nam_hoc.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                            If objBL.Hoc_ky <= Hoc_ky Then
                                dtDanhSach.Rows.Add(dr)
                            End If
                        End If
                    End If
                Else
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
#End Region
#Region "Load tài chính Hồ Sơ sinh Viên"
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_hoan_tra", GetType(Double))
                dt.Columns.Add("So_tien_giam", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("So_tien_con_no", GetType(Double))
                Dim dr As DataRow                            
                Dim dtHP_ky As DataTable
                dtHP_ky = DanhSachHocPhi_TheoHocKy(ID_sv) ' Lấy danh sách nộp học phí theo học kỳ               
                Dim dtThuChi As DataTable
                dtThuChi = DanhSach_ThuChi() ' Danh sách thu chi
                Dim Nam_hoc As String = ""
                dtHP_ky.DefaultView.Sort = "Nam_hoc"
                For i As Integer = 0 To dtHP_ky.DefaultView.Count - 1 ' Tính toán dữ liêu của từng năm học
                    If Nam_hoc <> dtHP_ky.DefaultView.Item(i)("Nam_hoc") Then
                        dr = dt.NewRow
                        Dim So_tien_nop As Integer = 0
                        Dim So_tien_giam As Integer = 0
                        Dim So_tien_da_nop As Integer = 0
                        Dim So_tien_con_no As Integer = 0
                        Dim So_tien_hoan_tra As Integer = 0
                        For j As Integer = 0 To dtHP_ky.Rows.Count - 1 ' Tính số tiền nộp và số tiền miễn giảm
                            If dtHP_ky.DefaultView.Item(i)("Nam_hoc") = dtHP_ky.Rows(j)("Nam_hoc") Then
                                So_tien_nop += IIf(dtHP_ky.Rows(j)("So_tien_nop").ToString = "", 0, dtHP_ky.Rows(j)("So_tien_nop"))
                                So_tien_giam += IIf(dtHP_ky.Rows(j)("So_tien_mien_giam").ToString = "", 0, dtHP_ky.Rows(j)("So_tien_mien_giam"))
                            End If
                        Next
                        ' Lọc ra tiền nộp học phí của năm học
                        If dtThuChi.Rows.Count > 0 Then dtThuChi.DefaultView.RowFilter = "Thu_chi='Thu' And Hoc_phi=True And Nam_hoc='" & dtHP_ky.DefaultView.Item(i)("Nam_hoc") & "'"
                        If dtThuChi.DefaultView.Count > 0 Then
                            So_tien_da_nop = dtThuChi.DefaultView.Item(0)("So_tien")
                            So_tien_con_no = So_tien_nop - So_tien_da_nop
                            If So_tien_da_nop > So_tien_nop Then So_tien_hoan_tra = So_tien_da_nop - So_tien_nop
                        Else
                            So_tien_con_no = So_tien_nop
                        End If
                        dr("Nam_hoc") = dtHP_ky.DefaultView.Item(i)("Nam_hoc")
                        dr("So_tien_nop") = So_tien_nop
                        dr("So_tien_giam") = So_tien_giam
                        dr("So_tien_da_nop") = So_tien_da_nop
                        dr("So_tien_con_no") = So_tien_con_no
                        dr("So_tien_hoan_tra") = So_tien_hoan_tra
                        dt.Rows.Add(dr)
                        Nam_hoc = dtHP_ky.DefaultView.Item(i)("Nam_hoc")
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi_TheoMon(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
                Dim dt As DataTable
                dt = obj.Load_BienLaiThu_MonDangKy_List(0, "", -1, ID_sv)
                'Add thêm cột số tiền                
                Dim dtHocPhanThu As New DataTable
                dtHocPhanThu.Columns.Add("Hoc_ky", GetType(Integer))
                dtHocPhanThu.Columns.Add("Nam_hoc", GetType(String))
                dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(0, "", ID_sv)
                Dim dtMG As DataTable
                dtMG = clsMGHP.DanhSach_MG()
                'Tính các cột số tiền
                Dim r As DataRow
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim So_tien_mien_giam As Integer = 0
                    For j As Integer = 0 To dtMG.Rows.Count - 1
                        If dtMG.Rows(j)("Hoc_ky") = dt.Rows(i)("Hoc_ky") And dtMG.Rows(j)("Nam_hoc") = dt.Rows(i)("Nam_hoc") Then
                            So_tien_mien_giam += (dt.Rows(i)("So_tien") * dtMG.Rows(j)("Phan_tram") / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm                             
                        End If
                    Next
                    r = dtHocPhanThu.NewRow
                    r("Hoc_ky") = dt.Rows(i)("Hoc_ky")
                    r("Nam_hoc") = dt.Rows(i)("Nam_hoc")
                    r("So_tien_mien_giam") = So_tien_mien_giam
                    r("So_tien_nop") = dt.Rows(i)("So_tien") - So_tien_mien_giam
                    dtHocPhanThu.Rows.Add(r)
                Next
                Return dtHocPhanThu
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi_TheoHocKy(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
                'Lấy danh sách các khoản nộp 
                Dim dt As DataTable
                dt = obj.Load_KhoanNop_HocKy_List(0, "", ID_sv)
                'Add thêm cột số tiền     
                Dim dtKhoanNop As New DataTable
                dtKhoanNop.Columns.Add("Hoc_ky", GetType(Integer))
                dtKhoanNop.Columns.Add("Nam_hoc", GetType(String))
                dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(0, "", ID_sv)
                Dim dtMG As DataTable
                dtMG = clsMGHP.DanhSach_MG()
                'Tính các cột số tiền
                Dim r As DataRow
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If dt.Rows(i)("Hoc_phi") Then
                        Dim So_tien_mien_giam As Integer = 0
                        For j As Integer = 0 To dtMG.Rows.Count - 1
                            If dtMG.Rows(j)("Hoc_ky") = dt.Rows(i)("Hoc_ky") And dtMG.Rows(j)("Nam_hoc") = dt.Rows(i)("Nam_hoc") Then
                                So_tien_mien_giam += (dt.Rows(i)("So_tien") * dtMG.Rows(j)("Phan_tram") / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm                             
                            End If
                        Next
                        r = dtKhoanNop.NewRow
                        r("Hoc_ky") = dt.Rows(i)("Hoc_ky")
                        r("Nam_hoc") = dt.Rows(i)("Nam_hoc")
                        r("So_tien_mien_giam") = So_tien_mien_giam
                        r("So_tien_nop") = dt.Rows(i)("So_tien") - So_tien_mien_giam
                        dtKhoanNop.Rows.Add(r)
                    End If
                Next
                dtKhoanNop.AcceptChanges()
                Return dtKhoanNop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách thu chi của một sinh viên (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSach_ThuChi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("So_tien", GetType(Integer))
                dt.Columns.Add("Thu_chi")
                dt.Columns.Add("Hoc_phi")
                Dim dr As DataRow
                Dim Nam_hoc As String = ""
                Dim Ten_thu_chi As String = ""
                Dim Thu_chi As Boolean = False
                For Each r As DataRow In dtDsThuChi.Rows
                    If Nam_hoc <> r("Nam_hoc") Or Ten_thu_chi <> r("Ten_thu_chi") Or Thu_chi <> r("Thu_chi") Then
                        dr = dt.NewRow
                        Dim So_tien As Integer = 0
                        For Each r1 As DataRow In dtDsThuChi.Rows
                            If r("Nam_hoc") = r1("Nam_hoc") And r("Ten_thu_chi") = r1("Ten_thu_chi") And r("Thu_chi") = r1("Thu_chi") Then
                                So_tien += r1("So_tien")
                            End If
                        Next
                        dr("Nam_hoc") = r("Nam_hoc")
                        dr("Ten_thu_chi") = r("Ten_thu_chi")
                        dr("So_tien") = So_tien
                        If r("Thu_chi") Then
                            dr("Thu_chi") = "Thu"
                        Else
                            dr("Thu_chi") = "Chi"
                        End If
                        dr("Hoc_phi") = r("Hoc_phi")
                        dt.Rows.Add(dr)
                        Nam_hoc = r("Nam_hoc")
                        Ten_thu_chi = r("Ten_thu_chi")
                        Thu_chi = r("Thu_chi")
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MucHocPhiTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim cls As New BienLaiThu_DAL
                Return cls.Load_MucHocPhiTinChi_List(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Tin chi"
        Public Function DanhSachHocPhanBienLaiThu(ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer, ByVal idx_bl As Integer, Optional ByVal Lan_thu As Integer = 0) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim idx As Integer
            Dim Phan_tram_MG As Double
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.Load_BienLaiThu_MonDangKy_List(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.Load_BienLaiThu_MonDaThu_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số học trình)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien") = So_tien
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("So_tien_nop") = So_tien - So_tien_mien_giam
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            If idx_bl >= 0 Then
                Dim objBLChiTiet As BienLaiThuChiTiet
                objBLChiTiet = CType(arrBienLaiThu(idx_bl), BienLaiThu).dsBienLaiChiTiet
                Dim objBL As BienLaiThu
                objBL = CType(arrBienLaiThu(idx_bl), BienLaiThu)
                If Lan_thu <> 1 Then
                    'Duyệt xóa học phần đã thu của lần khác
                    For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                        For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                            If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") And _
                                dtHocPhanDaThu.Rows(j)("Lan_thu") <> objBL.Lan_thu Then
                                dtHocPhanThu.Rows(i).Delete()
                                dtHocPhanThu.AcceptChanges()
                                Exit For
                            End If
                        Next
                    Next
                End If
                'Tích chọn số môn đã thu lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                    If idx >= 0 Then
                        dtHocPhanThu.Rows(i)("Chon") = True
                    End If
                Next
            Else
                'Duyệt xóa học phần đã thu của lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                        If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") Then
                            dtHocPhanThu.Rows(i).Delete()
                            dtHocPhanThu.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
            End If
            Return dtHocPhanThu
        End Function
        Private Function DanhSachHocPhanBienLaiThu_TheoKy(ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim Phan_tram_MG As Integer
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.Load_BienLaiThu_MonDangKy_List(Hoc_ky, Nam_hoc, 0, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.Load_BienLaiThu_MonDaThu_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số học trình)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien") = So_tien
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("So_tien_nop") = So_tien - So_tien_mien_giam
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            Return dtHocPhanThu
        End Function
        Public Function TongHop_HocPhi(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Boolean, ByVal ID_he As Integer) As DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim dtTongHop As New DataTable
            Dim dtKy, dtMon, dtNop As New DataTable
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam, So_tien_tra_lai As Integer
            So_tien_tra_lai = 0
            Dim Phan_tram_MG As Double
            Dim fg As Boolean = False
            dtTongHop.Columns.Add("Hoc_ky", GetType(String))
            dtTongHop.Columns.Add("Nam_hoc", GetType(String))
            dtTongHop.Columns.Add("So_tien_phai_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_tra_lai", GetType(Integer))
            dtTongHop.Columns.Add("Thieu_thua", GetType(Integer))
            'Lấy các khoản phải nộp theo học kỳ
            dtKy = obj.TongHopThuHocKy(ID_sv)
            For i As Integer = 0 To dtKy.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtKy.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtKy.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + dtKy.Rows(i)("So_tien_phai_nop")
                        dtTongHop.Rows(j)("So_tien_mien_giam") += CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + dtKy.Rows(i)("So_tien_mien_giam")
                        dtTongHop.Rows(j)("So_tien_tra_lai") += CInt("0" + dtTongHop.Rows(j)("So_tien_tra_lai").ToString) + So_tien_tra_lai
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtKy.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtKy.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = dtKy.Rows(i)("So_tien_phai_nop")
                    dr("So_tien_mien_giam") = dtKy.Rows(i)("So_tien_mien_giam")
                    dr("So_tien_tra_lai") = IIf(IsDBNull(dtKy.Rows(i)("So_tien_tra_lai")), 0, dtKy.Rows(i)("So_tien_tra_lai"))
                    dr("So_tien_nop") = dtKy.Rows(i)("So_tien_phai_nop") - dtKy.Rows(i)("So_tien_mien_giam")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản phải nộp thông qua đăng ký học phần tín chỉ
            dtMon = obj.TongHopThuMonDangKy(ID_sv)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim dtMucHocPhi As DataTable = Load_MucHocPhiTinChi_List(dtMon.Rows(i)("Hoc_ky"), dtMon.Rows(i)("Nam_hoc"), ID_he)
                Hoc_lai = CType(dtMon.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtMon.Rows(i)("Chuyen_nganh2"), Boolean)
                Phan_tram_MG = dtMon.Rows(i)("Phan_tram_mien_giam")
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số học trình)
                So_tien = Don_gia * dtMon.Rows(i)("He_so") * dtMon.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtMon.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtMon.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + So_tien
                        dtTongHop.Rows(j)("So_tien_mien_giam") = CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + So_tien_mien_giam
                        dtTongHop.Rows(j)("So_tien_tra_lai") += CInt("0" + dtTongHop.Rows(j)("So_tien_tra_lai").ToString) + So_tien_tra_lai
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtMon.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtMon.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = So_tien
                    dr("So_tien_mien_giam") = So_tien_mien_giam
                    dr("So_tien_nop") = So_tien - So_tien_mien_giam
                    dr("So_tien_tra_lai") = 0
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản sinh viên đã nộp học phí 
            dtNop = obj.TongHopDaNopHocPhi(ID_sv)
            For i As Integer = 0 To dtNop.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtNop.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtNop.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_da_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_da_nop").ToString) + dtNop.Rows(i)("So_tien_da_nop")
                        dtTongHop.Rows(j)("Thieu_thua") = dtTongHop.Rows(j)("So_tien_nop") - dtTongHop.Rows(j)("So_tien_da_nop") + dtTongHop.Rows(j)("So_tien_tra_lai")
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtNop.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtNop.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = 0
                    dr("So_tien_mien_giam") = 0
                    dr("So_tien_da_nop") = dtNop.Rows(i)("So_tien_da_nop")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                If dtTongHop.Rows(i)("So_tien_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_nop") = 0
                If dtTongHop.Rows(i)("So_tien_da_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_da_nop") = 0
                dtTongHop.Rows(i)("Thieu_thua") = dtTongHop.Rows(i)("So_tien_nop") - dtTongHop.Rows(i)("So_tien_da_nop") + dtTongHop.Rows(i)("So_tien_tra_lai")
            Next
            Return dtTongHop
        End Function
        Public Function TongHop_HocPhan_BienLaiThu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal Dot_thu As Integer) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim idx As Integer
            Dim Phan_tram_MG As Double
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.Load_BienLaiThu_MonDangKy_List(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Add thêm cột số tiền                        
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                If dtHocPhanThu.Rows(i)("Hoc_lai") = False And Phan_tram_MG > 0 Then
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = (dtHocPhanThu.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien_nop") = dtHocPhanThu.Rows(i)("So_tien") - dtHocPhanThu.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBLChiTiet As BienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), BienLaiThu).dsBienLaiChiTiet
                    Dim objBL As BienLaiThu
                    objBL = CType(arrBienLaiThu(j), BienLaiThu)
                    If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp                        
                        idx = objBL.dsBienLaiChiTiet.Tim_mon_tc(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon_tc"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtHocPhanThu.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtHocPhanThu.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtHocPhanThu.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtHocPhanThu.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtHocPhanThu.Rows
                Tong_tien += dr("So_tien")
                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                Tong_tien_nop += dr("So_tien_nop")
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            ' Tổng hợp số tiền nộp học phí theo kỳ
            Dim dtHP_Ky As DataTable
            dtHP_Ky = TongHop_NopHocPhi_HocKy(Hoc_ky, Nam_hoc, ID_sv)
            If dtHP_Ky.Rows.Count > 0 Then
                For Each r As DataRow In dtHP_Ky.Rows
                    Tong_tien += r("So_tien")
                    Tong_tien_mien_giam += r("So_tien_mien_giam")
                    Tong_tien_nop += r("So_tien_nop")
                    Tong_tien_da_nop += r("So_tien_da_nop")
                Next
            End If
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
#End Region
#Region "Tổng hợp học phí theo tín chỉ "
        Public Function TongHop_DanhSachSv_Nop_HocPhi_1(ByVal dtSv As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_thu_chi", GetType(Integer))
            dt.Columns.Add("So_tien", GetType(Double))
            dt.Columns.Add("So_tien_mien_giam", GetType(Double))
            dt.Columns.Add("So_tien_nop", GetType(Double))
            dt.Columns.Add("So_tien_da_nop", GetType(Double))
            dt.Columns.Add("Thieu_thua", GetType(Double))
            dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
            Dim row As DataRow
            For Each r As DataRow In dtSv.Rows
                Dim dt_th As DataTable = TongHop_HocPhi(r("ID_sv"), r("Ngoai_ngan_sach"), ID_he)
                Dim dv As DataView = dt_th.DefaultView
                dv.RowFilter = "Hoc_ky=" & Hoc_ky & " AND Nam_hoc='" & Nam_hoc & "'"
                row = dt.NewRow
                row("ID_sv") = r("ID_sv")
                row("Ma_sv") = r("Ma_sv")
                row("Ho_ten") = r("Ho_ten")
                row("Ngay_sinh") = r("Ngay_sinh")
                row("Ten_lop") = r("Ten_lop")
                row("ID_lop") = r("ID_lop")
                row("Ten_khoa") = r("Ten_khoa")
                row("Khoa_hoc") = r("Khoa_hoc")
                row("Hoc_ky") = Hoc_ky
                row("Nam_hoc") = Nam_hoc
                If dt_th.Rows.Count > 0 Then
                    row("So_tien") = dv(0)("So_tien_phai_nop")
                    row("So_tien_mien_giam") = dv(0)("So_tien_mien_giam")
                    row("So_tien_nop") = dv(0)("So_tien_nop")
                    row("So_tien_da_nop") = dv(0)("So_tien_da_nop")
                    row("Thieu_thua") = dv(0)("Thieu_thua")
                    If IIf(row("Thieu_thua").ToString = "", 0, row("Thieu_thua")) <= 0 Then
                        row("Hoan_thanh_nop") = 1
                    Else
                        row("Hoan_thanh_nop") = 0
                    End If
                End If
                dt.Rows.Add(row)
            Next
            dt.AcceptChanges()
            dt.DefaultView.AllowDelete = False
            dt.DefaultView.AllowEdit = False
            dt.DefaultView.AllowNew = False
            Return dt
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocPhi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal Toan_khoa As Boolean, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ của các sinh viên
            If Toan_khoa Then
                dtHocPhanThu = obj.Load_BienLaiThu_MonDangKyDanhSach_List(0, "", 0, dsID_lop)
            Else
                dtHocPhanThu = obj.Load_BienLaiThu_MonDangKyDanhSach_List(Hoc_ky, Nam_hoc, 0, dsID_lop)
            End If
            'Add thêm cột số tiền                        
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Thieu_thua", GetType(Integer))
            ' Xóa bỏ những khoản phải nộp ngoài học kỳ tổng hợp nếu tổng hợp từ đầu khóa học đến kỳ được chọn
            For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                If Toan_khoa Then
                    If dtHocPhanThu.Rows(i)("Nam_hoc").ToString.Substring(5, 4) > Nam_hoc.Substring(5, 4) Then
                        dtHocPhanThu.Rows(i).Delete()
                    ElseIf dtHocPhanThu.Rows(i)("Nam_hoc").ToString.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                        If dtHocPhanThu.Rows(i)("Hoc_ky") > Hoc_ky Then
                            dtHocPhanThu.Rows(i).Delete()
                        End If
                    End If
                End If
            Next
            dtHocPhanThu.AcceptChanges()
            'Tính các cột số tiền
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_BLL(dtHocPhanThu.Rows(i)("Hoc_ky"), dtHocPhanThu.Rows(i)("Nam_hoc"), CInt(dtHocPhanThu.Rows(i)("ID_sv")))
                If clsMGHP.Count > 0 Then
                    Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
                Else
                    Phan_tram_MG = 0
                End If
                If dtHocPhanThu.Rows(i)("Hoc_lai") = False And Phan_tram_MG > 0 Then
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = (dtHocPhanThu.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien_nop") = dtHocPhanThu.Rows(i)("So_tien") - dtHocPhanThu.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBL As BienLaiThu
                    objBL = CType(arrBienLaiThu(j), BienLaiThu)
                    Dim objBLChiTiet As BienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), BienLaiThu).dsBienLaiChiTiet
                    If objBL.ID_sv = dtHocPhanThu.Rows(i)("ID_sv") And objBL.Huy_phieu = False And objBL.Hoc_ky = dtHocPhanThu.Rows(i)("Hoc_ky") And objBL.Nam_hoc = dtHocPhanThu.Rows(i)("Nam_hoc") Then ' Nếu đã nộp
                        idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtHocPhanThu.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtHocPhanThu.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtHocPhanThu.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtHocPhanThu.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_thu_chi", GetType(Integer))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
            Dim row As DataRow
            Dim ID_sv As Integer = 0
            For Each r As DataRow In dtHocPhanThu.Rows
                If ID_sv <> r("ID_sv") Then
                    Dim Tong_tien As Integer = 0
                    Dim Tong_tien_mien_giam As Integer = 0
                    Dim Tong_tien_nop As Integer = 0
                    Dim Tong_tien_da_nop As Integer = 0
                    Dim Tong_Thieu_thua As Integer = 0
                    Tinh_tien_Hoc_phan(dtHocPhanThu, r, ID_mon, Ky_hieu_lop_tc, Tong_tien, Tong_tien_mien_giam, Tong_tien_nop, Tong_tien_da_nop, Tong_Thieu_thua)
                    ' Tổng hợp số tiền nộp học phí theo kỳ
                    Dim dtHP_Ky As DataTable
                    dtHP_Ky = TongHop_NopHocPhi_HocKy(r("Hoc_ky"), r("Nam_hoc"), ID_sv)
                    If dtHP_Ky.Rows.Count > 0 Then
                        For Each r1 As DataRow In dtHP_Ky.Rows
                            Tong_tien += r1("So_tien")
                            Tong_tien_mien_giam += r1("So_tien_mien_giam")
                            Tong_tien_nop += r1("So_tien_nop")
                            Tong_tien_da_nop += r1("So_tien_da_nop")
                        Next
                    End If
                    row = dt.NewRow
                    row("ID_sv") = r("ID_sv")
                    row("Ma_sv") = r("Ma_sv")
                    row("Ho_ten") = r("Ho_ten")
                    row("Ngay_sinh") = r("Ngay_sinh")
                    row("Ten_lop") = r("Ten_lop")
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    row("So_tien") = Tong_tien
                    row("So_tien_mien_giam") = Tong_tien_mien_giam
                    row("So_tien_nop") = Tong_tien_nop
                    row("So_tien_da_nop") = Tong_tien_da_nop
                    row("Thieu_thua") = Tong_Thieu_thua
                    If Tong_Thieu_thua <= 0 Then
                        row("Hoan_thanh_nop") = 1
                    Else
                        row("Hoan_thanh_nop") = 0
                    End If
                    If Tong_tien > 0 And Tong_tien_nop > 0 Then dt.Rows.Add(row) ' Nếu phải nộp tiền và sau khi miễn giảm vẫn phải nộp thêm thì add
                    ID_sv = r("ID_sv")
                End If
            Next
            dt.AcceptChanges()
            dt.DefaultView.AllowDelete = False
            dt.DefaultView.AllowEdit = False
            dt.DefaultView.AllowNew = False
            Return dt
        End Function
        Private Sub Tinh_tien_Hoc_phan(ByVal dtHocPhanThu As DataTable, ByVal r As DataRow, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByRef Tong_tien As Integer, ByRef Tong_tien_mien_giam As Integer, ByRef Tong_tien_nop As Integer, ByRef Tong_tien_da_nop As Integer, ByRef Tong_Thieu_thua As Integer)
            Try
                For Each dr As DataRow In dtHocPhanThu.Rows
                    If ID_mon > 0 Then
                        If dr("ID_sv") = r("ID_sv") And dr("ID_mon") = ID_mon Then
                            If Ky_hieu_lop_tc <> "" Then
                                If dr("Ky_hieu_lop_tc") = Ky_hieu_lop_tc Then
                                    Tong_tien += dr("So_tien")
                                    Tong_tien_mien_giam += dr("So_tien_mien_giam")
                                    Tong_tien_nop += dr("So_tien_nop")
                                    ' Nếu học kỳ và năm học đã có tiền nộp
                                    If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                        Tong_tien_da_nop += dr("So_tien_da_nop")
                                    End If
                                End If
                            Else
                                Tong_tien += dr("So_tien")
                                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                                Tong_tien_nop += dr("So_tien_nop")
                                ' Nếu học kỳ và năm học đã có tiền nộp
                                If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                    Tong_tien_da_nop += dr("So_tien_da_nop")
                                End If
                            End If
                        End If
                    Else
                        If dr("ID_sv") = r("ID_sv") Then
                            Tong_tien += dr("So_tien")
                            Tong_tien_mien_giam += dr("So_tien_mien_giam")
                            Tong_tien_nop += dr("So_tien_nop")
                            ' Nếu học kỳ và năm học đã có tiền nộp
                            If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                Tong_tien_da_nop += dr("So_tien_da_nop")
                            End If
                        End If
                    End If
                Next
                Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function DanhSachBienLaiThuHocPhiMon_SinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByVal Toan_khoa As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai      
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("Ngay_sinh", GetType(Date))
            dtDanhSach.Columns.Add("Hoc_ky", GetType(Integer))
            dtDanhSach.Columns.Add("Nam_hoc", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As BienLaiThu = CType(arrBienLaiThu(i), BienLaiThu)
                Dim dr As DataRow = dtDanhSach.NewRow
                dr("Ma_sv") = objBL.Ma_sv
                dr("Ho_ten") = objBL.Ho_ten
                dr("Ngay_sinh") = objBL.Ngay_sinh
                dr("Hoc_ky") = objBL.Hoc_ky
                dr("Nam_hoc") = objBL.Nam_hoc
                dr("So_phieu") = objBL.So_phieu
                dr("Ngay_thu") = objBL.Ngay_thu
                dr("Noi_dung") = objBL.Noi_dung
                dr("ID_bien_lai") = objBL.ID_bien_lai
                So_tien = 0
                For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                    If ID_mon > 0 Then ' Nếu theo môn chon
                        If Ky_hieu_lop_tc <> "" Then
                            If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = ID_mon And objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).Ky_hieu_lop_tc = Ky_hieu_lop_tc Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                        Else
                            If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = ID_mon Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                        End If
                    Else ' Không theo môn chọn tổng hợp ra tất cả các môn
                        If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon <> 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                    End If
                Next
                If So_tien > 0 Then
                    dr("So_tien") = So_tien
                End If
                If Toan_khoa Then
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        If objBL.Nam_hoc.Substring(5, 4) < Nam_hoc.Substring(5, 4) Then
                            dtDanhSach.Rows.Add(dr)
                        ElseIf objBL.Nam_hoc.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                            If objBL.Hoc_ky <= Hoc_ky Then
                                dtDanhSach.Rows.Add(dr)
                            End If
                        End If
                    End If
                Else
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        ' Tổng hợp thu học phí theo lớp
        Public Function TongHop_HocPhi_TheoLop(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Boolean, ByVal ID_he As Integer) As DataTable
            Dim obj As BienLaiThu_DAL = New BienLaiThu_DAL
            Dim dtTongHop As New DataTable
            Dim dtKy, dtMon, dtNop As New DataTable
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Phan_tram_MG As Double
            Dim fg As Boolean = False
            dtTongHop.Columns.Add("Hoc_ky", GetType(String))
            dtTongHop.Columns.Add("Nam_hoc", GetType(String))
            dtTongHop.Columns.Add("So_tien_phai_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtTongHop.Columns.Add("Thieu_thua", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Don_gia", GetType(Integer))
            dtTongHop.Columns.Add("Phan_tram_mien_giam", GetType(Double))
            'Lấy các khoản phải nộp theo học kỳ
            dtKy = obj.TongHopThuHocKy(ID_sv)
            For i As Integer = 0 To dtKy.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtKy.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtKy.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + dtKy.Rows(i)("So_tien_phai_nop")
                        dtTongHop.Rows(j)("So_tien_mien_giam") += CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + dtKy.Rows(i)("So_tien_mien_giam")
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtKy.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtKy.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = dtKy.Rows(i)("So_tien_phai_nop")
                    dr("So_tien_mien_giam") = dtKy.Rows(i)("So_tien_mien_giam")
                    dr("So_tien_nop") = dtKy.Rows(i)("So_tien_phai_nop") - dtKy.Rows(i)("So_tien_mien_giam")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản phải nộp thông qua đăng ký học phần tín chỉ
            dtMon = obj.TongHopThuMonDangKy(ID_sv)
            Dim So_hoc_trinh As Integer = 0
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim dtMucHocPhi As DataTable = Load_MucHocPhiTinChi_List(dtMon.Rows(i)("Hoc_ky"), dtMon.Rows(i)("Nam_hoc"), ID_he)
                Hoc_lai = CType(dtMon.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtMon.Rows(i)("Chuyen_nganh2"), Boolean)
                Phan_tram_MG = dtMon.Rows(i)("Phan_tram_mien_giam")
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số học trình)
                So_tien = Don_gia * dtMon.Rows(i)("He_so") * dtMon.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtMon.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtMon.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + So_tien
                        dtTongHop.Rows(j)("So_tien_mien_giam") = CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + So_tien_mien_giam
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                So_hoc_trinh += IIf(dtMon.Rows(i)("So_hoc_trinh").ToString = "", 0, dtMon.Rows(i)("So_hoc_trinh"))
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtMon.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtMon.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = So_tien
                    dr("So_tien_mien_giam") = So_tien_mien_giam
                    dr("So_tien_nop") = So_tien - So_tien_mien_giam
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản sinh viên đã nộp học phí 
            dtNop = obj.TongHopDaNopHocPhi(ID_sv)
            For i As Integer = 0 To dtNop.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtNop.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtNop.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_da_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_da_nop").ToString) + dtNop.Rows(i)("So_tien_da_nop")
                        dtTongHop.Rows(j)("Thieu_thua") = dtTongHop.Rows(j)("So_tien_nop") - dtTongHop.Rows(j)("So_tien_da_nop")

                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtNop.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtNop.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = 0
                    dr("So_tien_mien_giam") = 0
                    dr("So_tien_da_nop") = dtNop.Rows(i)("So_tien_da_nop")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                If dtTongHop.Rows(i)("So_tien_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_nop") = 0
                If dtTongHop.Rows(i)("So_tien_da_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_da_nop") = 0
                dtTongHop.Rows(i)("Thieu_thua") = dtTongHop.Rows(i)("So_tien_nop") - dtTongHop.Rows(i)("So_tien_da_nop")
                dtTongHop.Rows(i)("Don_gia") = Don_gia
                dtTongHop.Rows(i)("Phan_tram_mien_giam") = Phan_tram_MG
                dtTongHop.Rows(i)("So_hoc_trinh") = So_hoc_trinh
            Next
            Return dtTongHop
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocPhi_TheoLop(ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim dtSv As DataTable
                Dim obj As New BienLaiThu_DAL
                dtSv = obj.Load_DanhSachSv(dsID_lop)
                ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
                Dim dt As New DataTable
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(Integer))
                dt.Columns.Add("Don_gia", GetType(Double))
                dt.Columns.Add("So_tien", GetType(Double))
                dt.Columns.Add("Phan_tram_mien_giam", GetType(Double))
                dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("Thieu_thua", GetType(Integer))
                dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
                Dim row As DataRow
                For Each r As DataRow In dtSv.Rows
                    Dim dt_th As DataTable = TongHop_HocPhi_TheoLop(r("ID_sv"), r("Ngoai_ngan_sach"), ID_he)
                    If dt_th.Rows.Count > 0 Then
                        row = dt.NewRow
                        row("Ho_ten") = r("Ho_ten")
                        row("Ho_ten") = r("Ho_ten")
                        row("Ma_dt") = r("Ma_dt")
                        row("Ten_lop") = r("Ten_lop")
                        row("ID_lop") = r("ID_lop")
                        row("Ten_khoa") = r("Ten_khoa")
                        row("Khoa_hoc") = r("Khoa_hoc")
                        row("Hoc_ky") = Hoc_ky
                        row("Nam_hoc") = Nam_hoc
                        row("So_tien") = dt_th.Rows(0)("So_tien_phai_nop")
                        row("So_tien_mien_giam") = dt_th.Rows(0)("So_tien_mien_giam")
                        If IIf(dt_th.Rows(0)("So_tien_nop").ToString = "", 0, dt_th.Rows(0)("So_tien_nop")) > 0 Then row("So_tien_nop") = dt_th.Rows(0)("So_tien_nop")
                        If IIf(dt_th.Rows(0)("So_tien_da_nop").ToString = "", 0, dt_th.Rows(0)("So_tien_da_nop")) > 0 Then row("So_tien_da_nop") = dt_th.Rows(0)("So_tien_da_nop")
                        If IIf(dt_th.Rows(0)("Thieu_thua").ToString = "", 0, dt_th.Rows(0)("Thieu_thua")) > 0 Then row("Thieu_thua") = dt_th.Rows(0)("Thieu_thua")
                        If IIf(dt_th.Rows(0)("Thieu_thua").ToString = "", 0, dt_th.Rows(0)("Thieu_thua")) <= 0 Then
                            row("Hoan_thanh_nop") = 1
                        Else
                            row("Hoan_thanh_nop") = 0
                        End If
                        row("So_hoc_trinh") = dt_th.Rows(0)("So_hoc_trinh")
                        If IIf(dt_th.Rows(0)("Phan_tram_mien_giam").ToString = "", 0, dt_th.Rows(0)("Phan_tram_mien_giam")) > 0 Then row("Phan_tram_mien_giam") = dt_th.Rows(0)("Phan_tram_mien_giam")
                        If IIf(dt_th.Rows(0)("Don_gia").ToString = "", 0, dt_th.Rows(0)("Don_gia")) > 0 Then row("Don_gia") = dt_th.Rows(0)("Don_gia")
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_Khoa(ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim obj As New BienLaiThu_DAL
                Return obj.Load_Lop_Khoa(Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#End Region
    End Class
End Namespace
