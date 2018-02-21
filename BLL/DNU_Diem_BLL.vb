'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An Technology
' Created Date : Sunday, May 04, 2009
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
'Imports ESS.UniLibrary
Namespace Business
    Public Class DNU_Diem_BLL
        Private arrDiem As New ArrayList
        Private dsMonHoc As New ChuongTrinhDaoTaoChiTiet
        Private dsThanhPhanDiem As New ThanhPhanDiem
        Private dsXepHangTotNghiep As New XepHangTotNghiep
        Private dsXepLoaiChungChi As New XepLoaiChungChi
        Private dsXepLoaiHocTap As New XepLoaiHocTap
        Private mdtDanhSachSinhVien As DataTable
        Private mID_dv As String
        Private MucXuLy_KyLuat_HaLoaiTotNghiep As Integer
        Private QC As QuyCheDaoTao
        Private So_thanh_phan_chon As Integer = 0
#Region "Constructor"
        Sub New()

        End Sub
        Sub New(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal dsID_lop As String, ByVal dtDanhSachSinhVien As DataTable, ByVal Lan_hoc As Integer, Optional ByVal PhongThi As Boolean = False, Optional ByVal Chon_mac_dinh_tp As Boolean = False)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien
            'Khởi tạo quy chế
            QC = New QuyCheDaoTao(ID_he, 0)
            'Load các thành phần
            Load_ThanhPhanMon(ID_dv, ID_he, 0, "", ID_mon, dsID_lop, Chon_mac_dinh_tp, Lan_hoc)
            'Load dữ liệu điểm môn học
            If PhongThi Then
                Dim dsID_sv As String = ""
                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                    dsID_sv += mdtDanhSachSinhVien.Rows(i)("ID_sv").ToString + ","
                Next
                If dsID_sv <> "" Then
                    'Load dữ liệu điểm của danh sách sinh viên vào arrDiem
                    dsID_sv = Left(dsID_sv, Len(dsID_sv) - 1)
                    Load_Diem(ID_dv, dsID_lop, Hoc_ky, Nam_hoc, dsID_sv, ID_mon)
                End If
            Else
                Load_Diem(ID_dv, dsID_lop, 0, "", "", ID_mon, "")
            End If
        End Sub

        'Load điểm để tổng hợp học kỳ, năm học và toàn khoá
        Sub New(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal ID_bm_chinh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal dsID_dt As String, ByVal dtDanhSachSinhVien As DataTable, Optional ByVal Ky_thu As Integer = 0)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien
            'Khởi tạo quy chế
            QC = New QuyCheDaoTao(ID_he, dsID_dt)
            'Load môn thành phần
            Load_ThanhPhanMon(ID_dv, ID_he, Hoc_ky, Nam_hoc, 0, dsID_lop, False, 0)
            'Load xếp loại học tập
            Load_XepLoaiHocTap()
            Load_XepLoaiChungChi()
            'Load xếp hạng tốt nghiệp
            Load_XepHangTotNghiep()
            'Load danh sách các môn học
            Load_MonHocTrongDiem_TongHop(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, 0, dsID_dt, Ky_thu)
            'Load các môn học có trong bảng điểm
            Load_Diem(ID_dv, dsID_lop, Hoc_ky, Nam_hoc)
        End Sub
        Sub New(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "")
            mID_dv = ID_dv
            'Khởi tạo quy chế
            QC = New QuyCheDaoTao(ID_he, ID_dt)
            'Load xếp loại học tập
            Load_XepLoaiHocTap()
            'Load xếp hạng tốt nghiệp
            Load_XepHangTotNghiep()
            'Load danh sách các môn học
            Load_MonHocTrongDiem(ID_dv, "", 0, Hoc_ky, Nam_hoc, ID_sv, ID_dt)
            'Load các môn học có trong bảng điểm
            Load_Diem(ID_dv, "", Hoc_ky, Nam_hoc, ID_sv.ToString, 0, ID_dt)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrDiem.Count
            End Get
        End Property
        Public Sub Add(ByVal diem As Diem)
            arrDiem.Add(diem)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDiem.RemoveAt(idx)
        End Sub
        Public Property Diem(ByVal idx As Integer) As Diem
            Get
                Return CType(arrDiem(idx), Diem)
            End Get
            Set(ByVal Value As Diem)
                arrDiem(idx) = Value
            End Set
        End Property
        Public ReadOnly Property QuyChe() As QuyCheDaoTao
            Get
                Return QC
            End Get
        End Property

        Public ReadOnly Property MonHoc() As ChuongTrinhDaoTaoChiTiet
            Get
                Return dsMonHoc
            End Get
        End Property
        Public ReadOnly Property ThanhPhanDiem() As ThanhPhanDiem
            Get
                Return dsThanhPhanDiem
            End Get
        End Property
        Public ReadOnly Property SoThanhPhanDiem() As Integer
            Get
                Return So_thanh_phan_chon
            End Get
        End Property
#End Region
#Region "Function"
        Private Function ConvertDiem(ByVal dr As DataRow) As Diem
            Dim objDiem As New Diem
            objDiem.ID_diem = dr("ID_diem")
            objDiem.ID_dv = dr("ID_dv")
            objDiem.ID_sv = dr("ID_sv")
            objDiem.ID_mon = dr("ID_mon")
            objDiem.ID_dt = dr("ID_dt")
            objDiem.Hoc_ky = dr("Hoc_ky")
            objDiem.Nam_hoc = dr("Nam_hoc")
            objDiem.So_tiet = IIf(IsDBNull(dr("Ly_thuyet")), 0, dr("Ly_thuyet"))
            Return objDiem
        End Function
        Private Function ConvertDiemDanh(ByVal dr As DataRow) As DiemDanh
            Dim objDiemDanh As New DiemDanh
            objDiemDanh.Lan_hoc = dr.Item("Lan_hoc_dd")
            objDiemDanh.So_tiet_nghi = dr.Item("So_tiet_nghi")
            objDiemDanh.Thieu_bai_thuc_hanh = IIf(dr.Item("Thieu_bai_thuc_hanh").ToString = "", 0, dr.Item("Thieu_bai_thuc_hanh"))
            objDiemDanh.Ghi_chu = dr.Item("Ghi_chu").ToString
            objDiemDanh.Locked_dd = dr.Item("Locked_dd")
            Return objDiemDanh
        End Function
        Private Function ConvertDiemThanhPhan(ByVal dr As DataRow) As DiemThanhPhan
            Dim objDiemTP As New DiemThanhPhan
            objDiemTP.Lan_hoc = dr("Lan_hoc_tp")
            objDiemTP.ID_thanh_phan = dr("ID_thanh_phan")
            objDiemTP.Ty_le = dr("Ty_le")
            objDiemTP.Diem = dr("Diem")
            objDiemTP.Ly_do = dr("Ly_do")
            objDiemTP.Locked = dr("Locked_tp")
            Return objDiemTP
        End Function
        Private Function ConvertDiemThi(ByVal dr As DataRow) As DiemThi
            Dim objDiemThi As New DiemThi
            objDiemThi.Lan_hoc = dr("Lan_hoc_thi")
            objDiemThi.Lan_thi = dr("Lan_thi")
            objDiemThi.Diem_thi = dr("Diem_thi")
            objDiemThi.TBCHP = dr("TBCHP")
            objDiemThi.Ghi_chu = dr("Ghi_chu").ToString
            objDiemThi.Locked = dr("Locked")
            Return objDiemThi
        End Function
        Private Sub Load_Diem(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0, Optional ByVal dsID_dt As String = "")
            Dim clsDAL As New Diem_DAL
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            Dim objDiem As New Diem
            Dim Ly_do As String = ""
            'Lấy dữ liệu điểm thành phần và điểm thi
            dtDiem = clsDAL.Load_Diem_TongHop_List(ID_dv, dsID_lop, Hoc_ky, Nam_hoc, dsID_sv, ID_mon, dsID_dt)
            If dtDiem.Rows.Count > 0 Then
                For idx_diem As Integer = 0 To dtDiem.Rows.Count - 1
                    Try
                        If ID_diem <> dtDiem.Rows(idx_diem)("ID_diem") Then
                            If idx_diem > 0 Then arrDiem.Add(objDiem)
                            objDiem = New Diem
                            objDiem = ConvertDiem(dtDiem.Rows(idx_diem))
                            GoTo Add_diem
                        Else
Add_diem:
                            If (CInt("0" & dtDiem.Rows.Item(idx_diem).Item("ID_diem_danh").ToString) > 0) Then
                                Dim objDiemDanh As New DiemDanh
                                objDiemDanh = Me.ConvertDiemDanh(dtDiem.Rows.Item(idx_diem))
                                If (objDiem.dsDiemDanh.Tim_idx(objDiemDanh.Lan_hoc) = -1) Then
                                    objDiem.dsDiemDanh.Add(objDiemDanh)
                                End If
                            End If
                            If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_tp").ToString) > 0 Then
                                'Add các điểm thành phần vào object Điểm thành phần
                                Dim objDiemTP As New DiemThanhPhan
                                objDiemTP = ConvertDiemThanhPhan(dtDiem.Rows(idx_diem))
                                If (objDiem.dsDiemThanhPhan.Tim_idx(objDiemTP.ID_thanh_phan, objDiemTP.Lan_hoc) = -1) Then
                                    objDiem.dsDiemThanhPhan.Add(objDiemTP)
                                End If
                            End If
                            If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_thi").ToString) > 0 Then
                                'Add các điểm thi vào object Điểm thi
                                Dim objDiemThi As New DiemThi
                                objDiemThi = ConvertDiemThi(dtDiem.Rows(idx_diem))
                                If (objDiem.dsDiemThi.idx_diem_thi(objDiemThi.Lan_hoc, objDiemThi.Lan_thi) = -1) Then
                                    objDiem.dsDiemThi.Add(objDiemThi)
                                End If
                            End If
                        End If
                        ID_diem = dtDiem.Rows(idx_diem)("ID_diem")
                    Catch ex As Exception
                    End Try
                Next
                If ID_diem > 0 Then
                    arrDiem.Add(objDiem)
                End If
            End If
            'Cập nhật thông tin về không đủ đk dự thi, học lại, thi lại
            For i As Integer = 0 To arrDiem.Count - 1
                objDiem = CType(arrDiem(i), Diem)
                CapNhatThongTinDiem(dsThanhPhanDiem, objDiem)
            Next
        End Sub
        Private Sub CapNhatThongTinDiem(ByVal dsThanhPhanDiem As ThanhPhanDiem, ByRef objDiem As Diem)
            Dim Ly_do As String = ""
            Dim hoc_lai, thi_lai As Integer
            If objDiem.ID_sv = 18100 Then
                objDiem.ID_sv = 18100
            End If
            For lan_hoc As Integer = 1 To 5
                If (lan_hoc = 1) Or (lan_hoc > 1 And objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(lan_hoc - 1) > 0) Then
                    'Cập nhật thông tin không đủ điều kiện dự thi
                    Ly_do = QC.KhongDuDieuKienDuThi(lan_hoc, dsThanhPhanDiem, objDiem)
                    If Ly_do <> "" Then
                        Dim kddkThi As New DiemKhongDuDieuKienThi()
                        kddkThi.Lan_hoc = lan_hoc
                        kddkThi.Khong_du_dieu_kien_thi = 1
                        kddkThi.Ly_do_khong_du_dieu_kien_thi = Ly_do
                        objDiem.dsDiemKhongDuDKThi.Add(kddkThi)
                    End If
                End If
                'Cập nhật thông tin học lại
                hoc_lai = QC.HocLai(lan_hoc, objDiem.dsDiemThi)
                If hoc_lai Then
                    Dim hoclai As New DiemHocLai
                    hoclai.Lan_hoc = lan_hoc
                    objDiem.dsDiemHocLai.Add(hoclai)
                End If
                'Cập nhật thông tin thi lại
                For lan_thi As Integer = 1 To 3
                    thi_lai = QC.ThiLai(lan_hoc, lan_thi, objDiem.dsDiemThi)
                    If thi_lai Then
                        Dim thilai As New DiemThiLai
                        thilai.Lan_hoc = lan_hoc
                        thilai.Lan_thi = lan_thi
                        objDiem.dsDiemThiLai.Add(thilai)
                    End If
                Next
            Next
        End Sub
        Private Sub Load_MonHocTrongCTDT(ByVal dsID_dt As String, ByVal ID_bm_chinh As Integer)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DAL
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.Load_MonHocTrongCTDT(dsID_dt, ID_bm_chinh)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
                objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                dsMonHoc.Add(objCTDT)
            Next
        End Sub
        Private Sub Load_MonHocTrongDiem(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm_chinh As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal dsID_dt As String = "")
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DAL
            Dim fAdd As Boolean = False
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.Load_MonHocTrongDiem(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, ID_sv, dsID_dt)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
                'Kiểm tra xem có trùng môn không?
                fAdd = True
                For j As Integer = 0 To dsMonHoc.Count - 1
                    If dtMon.Rows(i)("ID_mon").ToString = dsMonHoc.ChuongTrinhDaoTaoChiTiet(j).ID_mon.ToString Then
                        fAdd = False
                    End If
                Next
                If fAdd Then
                    objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                    objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                    objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                    objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                    objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                    objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                    objCTDT.Mon_thi_TN = dtMon.Rows(i)("Mon_tot_nghiep")
                    dsMonHoc.Add(objCTDT)
                End If
            Next
        End Sub
        Private Sub Load_MonHocTrongDiem_TongHop(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm_chinh As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal dsID_dt As String = "", Optional ByVal Ky_thu As Integer = 0)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DAL
            Dim fAdd As Boolean = False
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.Load_MonHocTrongDiem_KyThu(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, ID_sv, dsID_dt, Ky_thu)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
                'Kiểm tra xem có trùng môn không?
                fAdd = True
                For j As Integer = 0 To dsMonHoc.Count - 1
                    If dtMon.Rows(i)("ID_mon").ToString = dsMonHoc.ChuongTrinhDaoTaoChiTiet(j).ID_mon.ToString Then
                        fAdd = False
                    End If
                Next
                If fAdd Then
                    objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                    objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                    objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                    objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                    objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                    objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                    objCTDT.Mon_thi_TN = dtMon.Rows(i)("Mon_tot_nghiep")
                    dsMonHoc.Add(objCTDT)
                End If
            Next
        End Sub
        Private Sub Load_XepLoaiHocTap()
            Dim dtXepLoai As DataTable
            Dim clsDAL As New Diem_DAL
            'Load các học phần thuộc các chương trình đào tạo
            dtXepLoai = clsDAL.Load_XepLoaiHocTap
            For i As Integer = 0 To dtXepLoai.Rows.Count - 1
                Dim objXepLoaiHocTap As New XepLoaiHocTap
                objXepLoaiHocTap.ID_xep_loai = dtXepLoai.Rows(i)("ID_xep_loai")
                objXepLoaiHocTap.Tu_diem = dtXepLoai.Rows(i)("Tu_diem")
                objXepLoaiHocTap.Den_diem = dtXepLoai.Rows(i)("Den_diem")
                objXepLoaiHocTap.Xep_loai = dtXepLoai.Rows(i)("Xep_loai")
                dsXepLoaiHocTap.Add(objXepLoaiHocTap)
            Next
        End Sub
        Private Sub Load_XepLoaiChungChi()
            Dim dtXepLoaiChungChi As DataTable
            Dim clsDAL As New Diem_DAL
            dtXepLoaiChungChi = clsDAL.Load_XepLoaiChungChi()
            For i As Integer = 0 To dtXepLoaiChungChi.Rows.Count - 1
                Dim objXepLoaiChungChi As New XepLoaiChungChi
                objXepLoaiChungChi.ID_xep_loai = dtXepLoaiChungChi.Rows(i)("ID_xep_hang")
                objXepLoaiChungChi.Tu_diem = dtXepLoaiChungChi.Rows(i)("Tu_diem")
                objXepLoaiChungChi.Den_diem = dtXepLoaiChungChi.Rows(i)("Den_diem")
                objXepLoaiChungChi.Xep_loai = dtXepLoaiChungChi.Rows(i)("Xep_hang")
                dsXepLoaiChungChi.Add(objXepLoaiChungChi)
            Next
        End Sub
        Private Sub Load_XepHangTotNghiep()
            Dim dtXepHangTotNghiep As DataTable
            Dim clsDAL As New Diem_DAL
            'Load các học phần thuộc các chương trình đào tạo
            dtXepHangTotNghiep = clsDAL.Load_XepHangTotNghiep()
            For i As Integer = 0 To dtXepHangTotNghiep.Rows.Count - 1
                Dim objXepHangTotNghiep As New XepHangTotNghiep
                objXepHangTotNghiep.ID_xep_hang = dtXepHangTotNghiep.Rows(i)("ID_xep_hang")
                objXepHangTotNghiep.Tu_diem = dtXepHangTotNghiep.Rows(i)("Tu_diem")
                objXepHangTotNghiep.Den_diem = dtXepHangTotNghiep.Rows(i)("Den_diem")
                objXepHangTotNghiep.Xep_hang = dtXepHangTotNghiep.Rows(i)("Xep_hang")
                dsXepHangTotNghiep.Add(objXepHangTotNghiep)
            Next
        End Sub
        Private Sub Load_ThanhPhanMon(ByVal ID_dv As String, ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal dsID_lop As String, ByVal Chon_mac_dinh_tp As Boolean, ByVal Lan_hoc As Integer)
            Dim dtThanhPhan As DataTable
            Dim clsDAL As New DNU_Diem_DAL
            Dim idx As Integer
            'Load các thành phần
            dtThanhPhan = clsDAL.Load_ThanhPhanMon(ID_he)
            For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                Dim objThanhPhan As New ThanhPhanDiem
                objThanhPhan.ID_thanh_phan = dtThanhPhan.Rows(i)("ID_thanh_phan")
                objThanhPhan.STT = dtThanhPhan.Rows(i)("STT")
                objThanhPhan.Ky_hieu = dtThanhPhan.Rows(i)("Ky_hieu")
                objThanhPhan.Ten_thanh_phan = dtThanhPhan.Rows(i)("Ten_thanh_phan")
                objThanhPhan.Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                If Chon_mac_dinh_tp = True Then objThanhPhan.Checked = dtThanhPhan.Rows(i)("Chon_mac_dinh")
                'objThanhPhan.Checked = dtThanhPhan.Rows(i)("Chon_mac_dinh")
                dsThanhPhanDiem.Add(objThanhPhan)
            Next
            'Update lại các thành phần theo tỷ lệ đã chọn
            dtThanhPhan = clsDAL.Load_ThanhPhanMon(ID_dv, Hoc_ky, Nam_hoc, dsID_lop, ID_mon, Lan_hoc)
            If dtThanhPhan.Rows.Count > 0 Then
                'Bỏ chọn mặc định
                For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                    dsThanhPhanDiem.ThanhPhanDiem(i).Checked = False
                Next
                'Check chọn theo thành phần đã chọn
                So_thanh_phan_chon = 0
                For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                    idx = dsThanhPhanDiem.Tim_idx(dtThanhPhan.Rows(i)("ID_thanh_phan"))
                    If idx >= 0 Then
                        dsThanhPhanDiem.ThanhPhanDiem(idx).Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                        dsThanhPhanDiem.ThanhPhanDiem(idx).Checked = True
                        So_thanh_phan_chon += 1
                    End If
                Next
            End If
        End Sub
        Public Function DanhSachDiemThiLan1(ByVal ID_mon As Integer, ByVal Lan_hoc As Integer) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1
            Dim TBCBP As Double = -1, TBCHP As Double = -1
            Dim Tong_SV_Du_DKDT, Tong_SV_KoDu_DKDT, Tong_SV_VangThi_CoPhep, Tong_SV_VangThi_KoPhep As Integer
            Tong_SV_Du_DKDT = 0
            Tong_SV_KoDu_DKDT = 0
            Tong_SV_VangThi_CoPhep = 0
            Tong_SV_VangThi_KoPhep = 0

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem", GetType(Integer))
            dtDiem.Columns.Add("idx_diem_thi", GetType(Integer))
            dtDiem.Columns.Add("ID_diem", GetType(Integer))
            dtDiem.Columns.Add("KhongDuDKThi")
            dtDiem.Columns.Add("TBCBP", GetType(Double))
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("TBCHP", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            dtDiem.Columns.Add("Tong_SV_Du_DKDT")
            dtDiem.Columns.Add("Tong_SV_KoDu_DKDT")
            dtDiem.Columns.Add("Tong_SV_VangThi_CoPhep")
            dtDiem.Columns.Add("Tong_SV_VangThi_KoPhep")

            'Gán dữ liệu vào bảng danh sách sinh viên
            For Each dr In dtDiem.Rows
                idx = Tim_idx(dr("ID_sv"), ID_mon)
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Lan_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx1).Diem
                                    dr.Item(("TP" & ID_thanh_phan.ToString)) = QC.DiemThanhPhan_lam_tron(DiemTP)
                                End If
                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Lan_hoc, 1)
                    'Gán vị trí của điểm thi trên mảng
                    dr.Item("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Lan_hoc, 1)
                    If objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc) > 0 Then
                        dr.Item("KhongDuDKThi") = "X"
                    End If
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = QC.DiemThi_lam_tron(Diem_thi)
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    'Tính điểm TBC bộ phận điểm thành phần
                    TBCBP = QC.DiemTBCBP(Lan_hoc, dsThanhPhanDiem, objDiem.dsDiemThanhPhan)
                    If TBCBP >= 0 Then
                        dr.Item("TBCBP") = Me.QC.FormatSoThapPhan(TBCBP, Me.QC.TBCBP_lam_tron)
                    End If
                    'Tính điểm TBC học phần
                    TBCHP = objDiem.dsDiemThi.TBCHP_lan(Lan_hoc, 1)
                    If (TBCHP >= 0) Then
                        dr.Item("TBCHP") = Me.QC.FormatSoThapPhan(TBCHP, Me.QC.TBCHP_lam_tron)
                    End If
                    dr.Item("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1)
                    dr.Item("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(Lan_hoc, 1)
                    If (((objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper <> "K") And (objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper <> "P")) And (objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper <> "V")) Then
                        Tong_SV_Du_DKDT += 1
                    End If
                    If (objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper = "K") Then
                        Tong_SV_KoDu_DKDT += 1
                    End If
                    If (objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper = "P") Then
                        Tong_SV_VangThi_CoPhep += 1
                    End If
                    If (objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1).ToUpper = "V") Then
                        Tong_SV_VangThi_KoPhep += 1
                    End If
                End If
            Next
            If dtDiem.Rows.Count > 0 Then
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Du_DKDT") = Tong_SV_Du_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KoDu_DKDT") = Tong_SV_KoDu_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_CoPhep") = Tong_SV_VangThi_CoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_KoPhep") = Tong_SV_VangThi_KoPhep
            End If
            Return dtDiem
        End Function
        'Dim dt As New DataTable
        '    dt.Columns.Add("Chon", GetType(Boolean))
        '    dt.Columns.Add("ID_sv", GetType(Integer))
        '    dt.Columns.Add("Ma_sv", GetType(String))
        '    dt.Columns.Add("Ho_ten", GetType(String))
        '    dt.Columns.Add("Ngay_sinh", GetType(Date))
        '    dt.Columns.Add("Ten_lop", GetType(String))
        '    dt.Columns.Add("TBCBP", GetType(Double))
        '    dt.Columns.Add("Ghi_chu")
        '    dt.Columns.Add("Tong_SV_Du_DKDT")

        '    If dtSub Is Nothing Then
        '        Return dt
        '    Else
        'Dim dr As DataRow
        '        For i As Integer = 0 To dtSub.DefaultView.Count - 1
        '            dr = dt.NewRow
        '            dr("ID_sv") = dtSub.DefaultView.Item(i)("ID_sv")
        '            dr("Ma_sv") = dtSub.DefaultView.Item(i)("Ma_sv")
        '            dr("Ho_ten") = dtSub.DefaultView.Item(i)("Ho_ten")
        '            dr("Ngay_sinh") = dtSub.DefaultView.Item(i)("Ngay_sinh")
        '            dr("Ten_lop") = dtSub.DefaultView.Item(i)("Ten_lop")
        '            dr("Chon") = False
        '            dt.Rows.Add(dr)
        '        Next
        '        Return dt
        '    End If
        Public Function DanhSachDiemThiLan1_ToChucThiTotNghiep(ByVal ID_mon As Integer, ByVal dtSub As DataTable) As DataTable
            Dim dtDiem As DataTable = dtSub.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            'Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim TBCBP As Double = -1
            Dim Tong_SV_Du_DKDT, Tong_SV_KoDu_DKDT, Tong_SV_VangThi_CoPhep, Tong_SV_VangThi_KoPhep As Integer
            Tong_SV_Du_DKDT = 0
            Tong_SV_KoDu_DKDT = 0
            Tong_SV_VangThi_CoPhep = 0
            Tong_SV_VangThi_KoPhep = 0

            dtDiem.Columns.Add("TBCBP", GetType(Double))
            dtDiem.Columns.Add("Ghi_chu")
            dtDiem.Columns.Add("Tong_SV_Du_DKDT")
            For Each dr In dtDiem.Rows
                idx = Tim_idx(dr("ID_sv"), ID_mon)
                If idx >= 0 Then
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    If objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(1) > 0 Then
                        dr.Item("KhongDuDKThi") = "X"
                    End If
                    'Tính điểm TBC bộ phận điểm thành phần
                    TBCBP = QC.DiemTBCBP(1, dsThanhPhanDiem, objDiem.dsDiemThanhPhan)
                    If TBCBP >= 0 Then
                        dr.Item("TBCBP") = Me.QC.FormatSoThapPhan(TBCBP, Me.QC.TBCBP_lam_tron)
                    End If
                    dr.Item("Ghi_chu") = ""
                    If (((objDiem.dsDiemThi.Ghi_chu_lan(1, 1).ToUpper <> "K") And (objDiem.dsDiemThi.Ghi_chu_lan(1, 1).ToUpper <> "P")) And (objDiem.dsDiemThi.Ghi_chu_lan(1, 1).ToUpper <> "V")) Then
                        Tong_SV_Du_DKDT += 1
                    End If
                End If
            Next
            If dtDiem.Rows.Count > 0 Then
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Du_DKDT") = Tong_SV_Du_DKDT
            End If
            Return dtDiem
        End Function
        Public Function DanhSachDiemThiLan1_ToChucThi(ByVal ID_mon As Integer, ByVal Lan_hoc As Integer) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                'If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString)
                'End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem")
            dtDiem.Columns.Add("idx_diem_thi")
            dtDiem.Columns.Add("ID_diem")
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("TBCHP")
            dtDiem.Columns.Add("TBCBP")
            dtDiem.Columns.Add("So_tin_chi", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            'Gán dữ liệu vào bảng danh sách sinh viên
            Dim So_tin_chi As Double = 0
            For m As Integer = 0 To dsMonHoc.Count - 1
                If dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).ID_mon = ID_mon Then
                    So_tin_chi = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).So_hoc_trinh
                    Exit For
                End If
            Next

            For Each dr In dtDiem.Rows
                idx = Tim_idx(dr("ID_sv"), ID_mon)
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                dr("So_tin_chi") = So_tin_chi
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Lan_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx1).Diem
                                    dr.Item(("TP" & ID_thanh_phan.ToString)) = QC.DiemThanhPhan_lam_tron(DiemTP)
                                End If
                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Lan_hoc, 1)
                    'Gán vị trí của điểm thi trên mảng
                    dr("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Lan_hoc, 1)
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = Diem_thi
                    Else
                        dr("Diem_thi") = DBNull.Value
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    If (objDiem.dsDiemThi.TBCHP_lan(Lan_hoc, 1) >= 0) Then
                        dr.Item("TBCHP") = objDiem.dsDiemThi.TBCHP_lan(Lan_hoc, 1)
                    End If
                    Dim TBCBP As Double = QC.DiemTBCBP(1, dsThanhPhanDiem, objDiem.dsDiemThanhPhan)
                    If TBCBP > 0 Then dr.Item("TBCBP") = TBCBP

                    dr.Item("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, 1)
                    dr.Item("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(Lan_hoc, 1)
                End If
            Next
            Return dtDiem
        End Function
        Public Function DanhSachDiemThiLan(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal ID_mon As Integer, ByVal Check_diem_lan1 As Boolean) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1
            Dim TBCBP As Double = -1, TBCHP As Double = -1

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem", GetType(Integer))
            dtDiem.Columns.Add("idx_diem_thi", GetType(Integer))
            dtDiem.Columns.Add("ID_diem", GetType(Integer))
            dtDiem.Columns.Add("KhongDuDKThi")
            dtDiem.Columns.Add("TBCBP", GetType(Double))
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("TBCHP", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            'Gán dữ liệu vào bảng danh sách sinh viên
            For i As Integer = dtDiem.Rows.Count - 1 To 0 Step -1
                If dtDiem.Rows(i).Item("ID_sv") = 210 Then
                    dtDiem.Rows(i).Item("ID_sv") = 210
                End If
                idx = Tim_idx(dtDiem.Rows(i)("ID_sv"), ID_mon)
                dtDiem.Rows(i)("Locked") = 0
                dtDiem.Rows(i)("idx_diem") = -1
                dtDiem.Rows(i)("idx_diem_thi") = -1
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    dtDiem.Rows(i)("idx_diem") = idx
                    'Nếu lần thi từ 2 trở lên thì chỉ đưa ra những sinh viên có điểm trước đó nhỏ hơn gDiem_thi_lai
                    If objDiem.Check_hien_thi(Lan_hoc, Lan_thi) Or (Lan_thi > 1 And Check_diem_lan1 = False) Then
                        If idx_mon >= 0 Then
                            'Gán các điểm thành phần vào cột điểm
                            For j As Integer = 0 To dsThanhPhanDiem.Count - 1
                                If dsThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                                    ID_thanh_phan = dsThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan
                                    'Tìm thành phần điểm theo ID_thanh_phan
                                    idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Lan_hoc)
                                    'Lấy điểm thành phần theo ID_thanh_phan
                                    If idx1 >= 0 Then
                                        DiemTP = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx1).Diem
                                        dtDiem.Rows.Item(i).Item("TP" & ID_thanh_phan.ToString) = QC.DiemThanhPhan_lam_tron(DiemTP)
                                    End If
                                End If
                            Next
                        End If
                        'Gán dữ liệu điểm thi
                        Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Lan_hoc, Lan_thi)
                        If objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc) > 0 Then
                            dtDiem.Rows(i).Item("KhongDuDKThi") = "X"
                        End If
                        'Tính điểm TBC bộ phận điểm thành phần
                        TBCBP = QC.DiemTBCBP(Lan_hoc, dsThanhPhanDiem, objDiem.dsDiemThanhPhan)
                        If TBCBP >= 0 Then
                            dtDiem.Rows(i)("TBCBP") = Me.QC.FormatSoThapPhan(TBCBP, Me.QC.TBCBP_lam_tron)
                        End If
                        If Diem_thi >= 0 Then
                            dtDiem.Rows(i)("Diem_thi") = QC.DiemThi_lam_tron(Diem_thi)
                        End If
                        'Tính điểm TBC Học phần
                        TBCHP = objDiem.dsDiemThi.TBCHP_lan(Lan_hoc, Lan_thi)
                        If (TBCHP >= 0) Then
                            dtDiem.Rows(i)("TBCHP") = Me.QC.FormatSoThapPhan(TBCHP, Me.QC.TBCHP_lam_tron)
                        End If
                        'Kiểm tra điểm thi lần này đã khoá chưa?
                        If objDiem.dsDiemThi.Diem_thi_lan_Locked(Lan_hoc, Lan_thi) Then
                            dtDiem.Rows.Item(i).Item("Locked") = 1
                        End If
                        dtDiem.Rows.Item(i).Item("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Lan_hoc, Lan_thi)
                        dtDiem.Rows.Item(i).Item("ID_diem") = objDiem.ID_diem
                        dtDiem.Rows.Item(i).Item("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi)
                    Else
                        dtDiem.Rows(i).Delete()
                    End If
                Else
                    If Lan_thi > 1 Then dtDiem.Rows(i).Delete()
                End If
            Next
            dtDiem.AcceptChanges()
            Return dtDiem
        End Function
        Public Function DanhSachDiemThanhPhan(ByVal ID_mon As Integer, ByVal Lan_hoc As Integer, Optional ByVal So_hoc_trinh As Integer = 0) As DataTable
            Dim dtDiemTP As DataTable = mdtDanhSachSinhVien.Copy
            Dim idx As Integer = -1, idx1 As Integer = -1, DiemTP As Double, ID_thanh_phan As Integer
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim TBCBP As Double
            'Add các cột điểm thành phần            
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If So_hoc_trinh > 0 Then
                    If i >= So_hoc_trinh Then
                        dsThanhPhanDiem.ThanhPhanDiem(i).Checked = False ' Load các thành phần theo số học trình
                    End If
                    If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                        dtDiemTP.Columns.Add("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString)
                        dtDiemTP.Columns("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString).DefaultValue = ""
                    End If
                Else
                    If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                        dtDiemTP.Columns.Add("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString)
                        dtDiemTP.Columns("TP" + dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString).DefaultValue = ""
                    End If
                End If
            Next
            dtDiemTP.Columns.Add("So_tiet_nghi", GetType(Integer))
            dtDiemTP.Columns.Add("Thieu_bai_thuc_hanh", GetType(Byte))
            'Thêm các cột điểm thi
            dtDiemTP.Columns.Add("TBCBP")
            dtDiemTP.Columns.Add("Ghi_chu")
            dtDiemTP.Columns.Add("ID_diem")
            dtDiemTP.Columns.Add("Locked")
            For r As Integer = dtDiemTP.Rows.Count - 1 To 0 Step -1
                idx = Tim_idx(dtDiemTP.Rows(r)("ID_sv"), ID_mon)
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    'Nếu lần học từ 2 trở đi thì chỉ hiển thị những sinh viên học lại
                    If (Lan_hoc = 1) Or (Lan_hoc > 1 AndAlso objDiem.Check_hien_thi(Lan_hoc)) Then
                        Dim Locked_tp As Integer = 0
                        'Gán số tiết nghỉ
                        idx = objDiem.dsDiemDanh.Tim_idx(Lan_hoc)
                        If (idx >= 0) Then
                            If objDiem.dsDiemDanh.DiemDanh(idx).So_tiet_nghi > 0 Then dtDiemTP.Rows(r)("So_tiet_nghi") = objDiem.dsDiemDanh.DiemDanh(idx).So_tiet_nghi
                            dtDiemTP.Rows(r)("Thieu_bai_thuc_hanh") = objDiem.dsDiemDanh.DiemDanh(idx).Thieu_bai_thuc_hanh
                        End If
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Lan_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx1).Diem
                                    dtDiemTP.Rows(r).Item(("TP" & ID_thanh_phan.ToString)) = QC.DiemThanhPhan_lam_tron(DiemTP)
                                    Locked_tp = objDiem.dsDiemThanhPhan.DiemThanhPhan(idx1).Locked
                                End If
                            End If
                        Next
                        TBCBP = QC.DiemTBCBP(Lan_hoc, Me.dsThanhPhanDiem, objDiem.dsDiemThanhPhan)
                        If (TBCBP >= 0) Then
                            dtDiemTP.Rows(r).Item("TBCBP") = Me.QC.FormatSoThapPhan(TBCBP, Me.QC.TBCBP_lam_tron)
                        Else
                            dtDiemTP.Rows(r).Item("TBCBP") = ""
                        End If
                        dtDiemTP.Rows(r).Item("Ghi_chu") = objDiem.dsDiemKhongDuDKThi.Ly_do_khong_du_dieu_kien_thi_lan(Lan_hoc)
                        dtDiemTP.Rows(r)("ID_diem") = objDiem.ID_diem
                        dtDiemTP.Rows(r)("Locked") = Locked_tp
                    Else
                        dtDiemTP.Rows(r).Delete()
                    End If
                Else
                    dtDiemTP.Rows(r)("Locked") = 0
                End If
            Next
            dtDiemTP.AcceptChanges()
            Return dtDiemTP
        End Function
        Public Function DanhSachThanhPhan() As DataTable
            Dim dtTP As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtTP.Columns.Add("Chon", GetType(Boolean))
            dtTP.Columns.Add("ID_thanh_phan", GetType(Integer))
            dtTP.Columns.Add("STT", GetType(Integer))
            dtTP.Columns.Add("Ky_hieu", GetType(String))
            dtTP.Columns.Add("Ten_thanh_phan", GetType(String))
            dtTP.Columns.Add("Ty_le", GetType(Integer))
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                Dim dr As DataRow
                dr = dtTP.NewRow
                With dsThanhPhanDiem.ThanhPhanDiem(i)
                    If .Checked Then
                        dr("Chon") = 1
                        Tong_ty_le += .Ty_le
                    Else
                        dr("Chon") = 0
                    End If
                    dr("ID_thanh_phan") = .ID_thanh_phan
                    dr("STT") = .STT
                    dr("Ky_hieu") = .Ky_hieu
                    dr("Ten_thanh_phan") = .Ten_thanh_phan
                    dr("Ty_le") = .Ty_le
                End With
                dtTP.Rows.Add(dr)
            Next
            Return dtTP
        End Function
        Public Function DanhSachThanhPhanChon() As DataTable
            Dim dtTP As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtTP.Columns.Add("Chon", GetType(Boolean))
            dtTP.Columns.Add("ID_thanh_phan", GetType(Integer))
            dtTP.Columns.Add("STT", GetType(Integer))
            dtTP.Columns.Add("Ky_hieu", GetType(String))
            dtTP.Columns.Add("Ten_thanh_phan", GetType(String))
            dtTP.Columns.Add("Ty_le", GetType(Integer))
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                With dsThanhPhanDiem.ThanhPhanDiem(i)
                    If .Checked Then
                        Dim dr As DataRow
                        dr = dtTP.NewRow
                        dr("Chon") = 1
                        Tong_ty_le += .Ty_le
                        dr("ID_thanh_phan") = .ID_thanh_phan
                        dr("STT") = .STT
                        dr("Ky_hieu") = .Ky_hieu
                        dr("Ten_thanh_phan") = .Ten_thanh_phan
                        dr("Ty_le") = .Ty_le
                        dtTP.Rows.Add(dr)
                    End If
                End With
            Next
            Return dtTP
        End Function
        Public Function DanhSachMonHoc() As DataTable
            Dim dtMonHoc As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtMonHoc.Columns.Add("ID_mon", GetType(Integer))
            dtMonHoc.Columns.Add("Ky_hieu", GetType(String))
            dtMonHoc.Columns.Add("Ten_mon", GetType(String))
            dtMonHoc.Columns.Add("So_hoc_trinh", GetType(Integer))
            For i As Integer = 0 To dsMonHoc.Count - 1
                Dim dr As DataRow
                dr = dtMonHoc.NewRow
                With dsMonHoc.ChuongTrinhDaoTaoChiTiet(i)
                    dr("ID_mon") = .ID_mon
                    dr("Ky_hieu") = .Ky_hieu
                    dr("Ten_mon") = .Ten_mon
                    dr("So_hoc_trinh") = .So_hoc_trinh
                End With
                dtMonHoc.Rows.Add(dr)
            Next
            Return dtMonHoc
        End Function
        Function PhanLoaiHocTap_Lop(ByVal dt_kqht As DataTable, ByVal ID_lops As String) As DataTable
            'Dinh nghia cac truong du lieu
            Dim clsDAL As New Diem_DAL
            Dim dt As DataTable = clsDAL.Load_PhanLoaiKetQuaHocTap(ID_lops)

            Dim dtXepLoaiHocTap As DataTable = clsDAL.Load_XepLoaiHocTap()
            For i As Integer = 0 To dtXepLoaiHocTap.Rows.Count - 1
                dt.Columns.Add("SL" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString, GetType(String))
                dt.Columns.Add("PT" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString, GetType(String))
            Next
            'Gan du lieu cho cac truong du lieu
            For j As Integer = 0 To dt.Rows.Count - 1
                For i As Integer = 0 To dtXepLoaiHocTap.Rows.Count - 1
                    dt_kqht.DefaultView.RowFilter = "1=1"
                    dt_kqht.DefaultView.RowFilter = "TBCHT<>'' AND ID_lop=" & dt.Rows(j).Item("ID_lop") & " AND ID_xep_loai=" & dtXepLoaiHocTap.Rows(i)("ID_xep_loai")

                    dt.Rows(j).Item("SL" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString) = IIf(dt_kqht.DefaultView.Count > 0, dt_kqht.DefaultView.Count, "")
                    dt.Rows(j).Item("PT" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString) = IIf(dt_kqht.DefaultView.Count > 0, Format(dt_kqht.DefaultView.Count * 100 / dt.Rows(j).Item("Tong_so"), "##.#"), "")
                Next
            Next

            Return dt
        End Function
        Function PhanLoaiHocTap_Mon(ByVal dt_kqht As DataTable) As DataTable
            'Dinh nghia cac truong du lieu
            Dim clsDAL As New Diem_DAL
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Tong_so", GetType(String))
            Dim dtXepLoai As DataTable = clsDAL.Load_XepLoaiHocTap
            For i As Integer = 0 To dtXepLoai.Rows.Count - 1
                If dtXepLoai.Rows(i).Item("Xep_loai").ToString <> "" Then
                    dt.Columns.Add("SL" + dtXepLoai.Rows(i)("ID_xep_loai").ToString, GetType(String))
                    dt.Columns.Add("PT" + dtXepLoai.Rows(i)("ID_xep_loai").ToString, GetType(String))
                End If
            Next

            Dim dr As DataRow
            For i As Integer = 0 To dsMonHoc.Count - 1
                dr = dt.NewRow
                dr("ID_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString
                dr("Ten_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ten_mon.ToString
                dt.Rows.Add(dr)
            Next

            'Gan du lieu cho cac truong du lieu
            For j As Integer = 0 To dt.Rows.Count - 1
                Dim Tong_so As Integer
                For i As Integer = 0 To dtXepLoai.Rows.Count - 1
                    If dtXepLoai.Rows(i).Item("Xep_loai").ToString <> "" Then
                        Dim Tong_xep_loai As Integer
                        Tong_so = 0
                        Tong_xep_loai = 0
                        For m As Integer = 0 To dt_kqht.Rows.Count - 1
                            If dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon")).ToString <> "" Then
                                Tong_so += 1
                                If Not IsNumeric(dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon"))) Then ' Truong hop diem bao gom ca lan 1 va lan 2
                                    Dim Arr() As String = Split(dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon")).Trim, "/")
                                    If Arr.Length > 1 Then
                                        If IsNumeric(Arr(1)) AndAlso dsXepLoaiHocTap.IDXepLoaiHocTap(Arr(1)) = dtXepLoai.Rows(i)("ID_xep_loai") Then Tong_xep_loai += 1
                                    ElseIf dtXepLoai.Rows(i)("ID_xep_loai") = 7 Then 'Vao cac Ly do chua co diem thi cho loai kem
                                        Tong_xep_loai += 1
                                    End If
                                Else
                                    If dsXepLoaiHocTap.IDXepLoaiHocTap(dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon"))) = dtXepLoai.Rows(i)("ID_xep_loai") Then Tong_xep_loai += 1
                                End If
                            End If
                        Next
                        If Tong_so = 0 Then Tong_so = 1
                        dt.Rows(j).Item("SL" + dtXepLoai.Rows(i)("ID_xep_loai").ToString) = IIf(Tong_xep_loai > 0, Tong_xep_loai, "")
                        dt.Rows(j).Item("PT" + dtXepLoai.Rows(i)("ID_xep_loai").ToString) = IIf(Tong_xep_loai > 0, Format(Tong_xep_loai * 100 / Tong_so, "##.#"), "")
                    End If
                Next
                dt.Rows(j).Item("Tong_so") = Tong_so
            Next

            Return dt
        End Function
        Public Function TongHopDiemHocKy(ByVal Lan_thi As Byte, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem1, So_ht_no As Double, Tong_so_hoc_trinh As Double
            Dim TBCHT, TBCHT1, TBCHP, TBCHP1 As Double
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai, So_mon_no As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT1", GetType(String))
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_ht_no", GetType(Double))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem1 = 0
                Tong_so_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                So_ht_no = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        TBCHP1 = diem.dsDiemThi.TBCHP_lan(1, 1)
                        TBCHP = diem.dsDiemThi.TBCHP_max
                        If ((TBCHP1 >= 0) And Not Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT) Then
                            Tong_diem1 = (Tong_diem1 + (TBCHP1 * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_diem = (Tong_diem + (TBCHP * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                        End If
                        '---------Add column----------------
                        If Hien_thi_diem_TP Then
                            Dim col As New DataColumn()
                            'Voi diem thanh phan
                            For j As Integer = 0 To diem.dsDiemThanhPhan.Count - 1
                                col = New DataColumn("T" + ID_mon.ToString + diem.dsDiemThanhPhan.DiemThanhPhan(j).ID_thanh_phan.ToString)
                                If Not dtTongHop.Columns.Contains(col.ColumnName) Then
                                    dtTongHop.Columns.Add(col)
                                End If
                                If (diem.dsDiemThanhPhan.DiemThanhPhan(j).Diem.ToString <> "") Then
                                    dr.Item(("T" & ID_mon.ToString & diem.dsDiemThanhPhan.DiemThanhPhan(j).ID_thanh_phan.ToString)) = QC.FormatSoThapPhan(QC.DiemThanhPhan_lam_tron(diem.dsDiemThanhPhan.DiemThanhPhan(j).Diem), QC.ThanhPhan_lam_tron)
                                End If
                            Next
                            'Voi diem thi
                            col = New DataColumn("T" + ID_mon.ToString + "Thi")
                            If Not dtTongHop.Columns.Contains(col.ColumnName) Then
                                dtTongHop.Columns.Add(col)
                            End If
                            If (Lan_thi = 1) Then
                                dr.Item(("T" & ID_mon.ToString & "Thi")) = diem.dsDiemThi.Diem_thi_lan1_view(Hien_thi_ghi_chu)
                            Else
                                dr.Item(("T" & ID_mon.ToString & "Thi")) = diem.dsDiemThi.Diem_thi_lan_cac_lan_view(Hien_thi_ghi_chu)
                            End If
                        End If
                        If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                            dtTongHop.Columns.Add("M" + ID_mon.ToString)
                        End If
                        '------------------End Column----------------------
                        If (dtTongHop.Columns.IndexOf(("M" & ID_mon.ToString)) = -1) Then
                            dtTongHop.Columns.Add(("M" & ID_mon.ToString))
                        End If
                        If (Lan_thi = 1) Then
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP1, QC.TBCHP_lam_tron)
                            End If
                        Else
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP, QC.TBCHP_lam_tron)
                            End If
                        End If
                        If diem.dsDiemThiLai.Thi_lai = 1 Then So_mon_thi_lai += 1
                        If diem.dsDiemHocLai.Hoc_lai = 1 Then So_mon_hoc_lai += 1
                        If TBCHP >= 0 And (TBCHP < QC.Diem_hoc_phan_dat) Then
                            So_mon_no += 1
                            So_ht_no = So_ht_no + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT1 = QC.DiemTBCHT_lam_tron((Tong_diem1 / Tong_so_hoc_trinh))
                    TBCHT = QC.DiemTBCHT_lam_tron((Tong_diem / Tong_so_hoc_trinh))
                    dr.Item("TBCHT1") = QC.FormatSoThapPhan(TBCHT1, QC.TBCHT_lam_tron)
                    dr.Item("TBCHT") = QC.FormatSoThapPhan(TBCHT, QC.TBCHT_lam_tron)
                    Dim objXepLoai As New XepLoaiHocTap
                    Dim Phan_tram_thi_lai As Integer = So_mon_thi_lai / dsMonHoc.Count
                    objXepLoai = QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT, Phan_tram_thi_lai)
                    dr.Item("ID_xep_loai") = objXepLoai.ID_xep_loai
                    dr.Item("Xep_loai") = objXepLoai.Xep_loai
                    dr.Item("Ly_do") = objXepLoai.Ghi_chu
                End If
                If (So_mon_no > 0) Then
                    dr.Item("So_mon_no") = So_mon_no
                End If
                If (So_mon_thi_lai > 0) Then
                    dr.Item("So_mon_thi_lai") = So_mon_thi_lai
                End If
                If (So_mon_hoc_lai > 0) Then
                    dr.Item("So_mon_hoc_lai") = So_mon_hoc_lai
                End If
                If (So_ht_no > 0) Then
                    dr.Item("So_ht_no") = So_ht_no
                End If
            Next
            Return dtTongHop
        End Function
        Public Function TongHopDiemHocKyXetHocBongDanhHieu(Optional ByRef ProgressBar As System.Windows.Forms.ProgressBar = Nothing) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem1 As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT1, TBCHP1, Diem_thi_nho_hon5 As Double
            Dim So_mon_no As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT1", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("Diem_thi_nho_hon5", GetType(Integer))
            ProgressBar.Minimum = 0
            ProgressBar.Maximum = dtTongHop.Rows.Count - 1
            ProgressBar.Step = 1
            ProgressBar.Value = 0
            Dim p As Integer = 0
            'Tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                ProgressBar.Value = p
                p += 1
                So_mon_no = 0
                Tong_diem1 = 0
                Tong_so_hoc_trinh = 0
                Diem_thi_nho_hon5 = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            TBCHP1 = diem.dsDiemThi.TBCHP_lan(1, 1)
                            Dim Diem_thi As Double
                            Diem_thi = diem.dsDiemThi.Diem_thi_lan(1, 1)
                            If ((TBCHP1 > 0) And Not Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT) Then
                                Tong_diem1 = (Tong_diem1 + (TBCHP1 * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                                Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                            End If
                            If (TBCHP1 < QC.Diem_hoc_phan_dat) Then
                                So_mon_no += 1
                            End If
                            If Diem_thi < 5 Then
                                Diem_thi_nho_hon5 += 1
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT1 = QC.DiemTBCHT_lam_tron((Tong_diem1 / Tong_so_hoc_trinh))
                    dr.Item("TBCHT1") = TBCHT1
                    Dim objXepLoai As New XepLoaiHocTap
                    Dim Phan_tram_thi_lai As Integer = So_mon_no / dsMonHoc.Count
                    objXepLoai = QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT1, Phan_tram_thi_lai)
                    dr.Item("ID_xep_loai") = objXepLoai.ID_xep_loai
                    dr.Item("Xep_loai") = objXepLoai.Xep_loai
                    dr.Item("Diem_thi_nho_hon5") = Diem_thi_nho_hon5
                End If
                dr.Item("So_mon_no") = So_mon_no
            Next
            Return dtTongHop
        End Function
        Public Function TongHopDiemHocTapNam(ByVal Lan_thi As Byte, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem1, So_ht_no As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT, TBCHT1, TBCHP, TBCHP1 As Double
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai, So_mon_no As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT1", GetType(String))
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_ht_no", GetType(Double))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            Dim DiemvaGhiChu As String = ""
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem1 = 0
                Tong_so_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Dim SoMonThiLai As Integer = 0
                So_ht_no = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        TBCHP1 = diem.dsDiemThi.TBCHP_lan(1, 1)
                        TBCHP = diem.dsDiemThi.TBCHP_max
                        If ((TBCHP1 >= 0) And Not Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT) Then
                            Tong_diem1 = (Tong_diem1 + (TBCHP1 * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_diem = (Tong_diem + (TBCHP * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                        End If
                        '---------Add column----------------
                        If Hien_thi_diem_TP Then
                            Dim col As New DataColumn()
                            'Voi diem thanh phan
                            For j As Integer = 0 To diem.dsDiemThanhPhan.Count - 1
                                col = New DataColumn("T" + ID_mon.ToString + diem.dsDiemThanhPhan.DiemThanhPhan(j).ID_thanh_phan.ToString)
                                If Not dtTongHop.Columns.Contains(col.ColumnName) Then
                                    dtTongHop.Columns.Add(col)
                                End If
                                If (diem.dsDiemThanhPhan.DiemThanhPhan(j).Diem.ToString <> "") Then
                                    dr.Item(("T" & ID_mon.ToString & diem.dsDiemThanhPhan.DiemThanhPhan(j).ID_thanh_phan.ToString)) = QC.DiemThanhPhan_lam_tron(diem.dsDiemThanhPhan.DiemThanhPhan(j).Diem)
                                End If
                            Next
                            'Voi diem thi
                            col = New DataColumn("T" + ID_mon.ToString + "Thi")
                            If Not dtTongHop.Columns.Contains(col.ColumnName) Then
                                dtTongHop.Columns.Add(col)
                            End If
                            If (Lan_thi = 1) Then
                                dr.Item(("T" & ID_mon.ToString & "Thi")) = diem.dsDiemThi.Diem_thi_lan1_view(Hien_thi_ghi_chu)
                            Else
                                dr.Item(("T" & ID_mon.ToString & "Thi")) = diem.dsDiemThi.Diem_thi_lan_cac_lan_view(Hien_thi_ghi_chu)
                            End If
                        End If
                        If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                            dtTongHop.Columns.Add("M" + ID_mon.ToString)
                        End If
                        '------------------End Column----------------------
                        If (dtTongHop.Columns.IndexOf(("M" & ID_mon.ToString)) = -1) Then
                            dtTongHop.Columns.Add(("M" & ID_mon.ToString))
                        End If
                        If (Lan_thi = 1) Then
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP1, QC.TBCHP_lam_tron)
                            End If
                        Else
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP, QC.TBCHP_lam_tron)
                            End If
                        End If
                        If diem.dsDiemThiLai.Thi_lai = 1 Then So_mon_thi_lai += 1
                        If diem.dsDiemHocLai.Hoc_lai = 1 Then So_mon_hoc_lai += 1
                        If TBCHP >= 0 And (TBCHP < QC.Diem_hoc_phan_dat) Then
                            So_mon_no += 1
                            So_ht_no = So_ht_no + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT1 = QC.DiemTBCHT_lam_tron((Tong_diem1 / Tong_so_hoc_trinh))
                    TBCHT = QC.DiemTBCHT_lam_tron((Tong_diem / Tong_so_hoc_trinh))
                    dr.Item("TBCHT1") = QC.FormatSoThapPhan(TBCHT1, QC.TBCHT_lam_tron)
                    dr.Item("TBCHT") = QC.FormatSoThapPhan(TBCHT, QC.TBCHT_lam_tron)
                    Dim objXepLoai As New XepLoaiHocTap
                    Dim Phan_tram_thi_lai As Integer = So_mon_thi_lai / dsMonHoc.Count
                    objXepLoai = QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT, Phan_tram_thi_lai)
                    dr.Item("ID_xep_loai") = objXepLoai.ID_xep_loai
                    dr.Item("Xep_loai") = objXepLoai.Xep_loai
                    dr.Item("Ly_do") = objXepLoai.Ghi_chu
                End If
                If (So_mon_no > 0) Then
                    dr.Item("So_mon_no") = So_mon_no
                End If
                If (So_mon_thi_lai > 0) Then
                    dr.Item("So_mon_thi_lai") = So_mon_thi_lai
                End If
                If (So_mon_hoc_lai > 0) Then
                    dr.Item("So_mon_hoc_lai") = So_mon_hoc_lai
                End If
                If (So_ht_no > 0) Then
                    dr.Item("So_ht_no") = So_ht_no
                End If
            Next
            Return dtTongHop
        End Function

        Public Function TongHopDiemHocTapToanKhoa(ByVal Hien_thi_ghi_chu As Boolean, ByVal Lan_thi As Integer) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem1, So_ht_no As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT, TBCHT1, TBCHP, TBCHP1 As Double
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai, So_mon_no As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT1", GetType(String))
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_ht_no", GetType(Double))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            Dim DiemvaGhiChu As String = ""
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem1 = 0
                Tong_so_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Dim SoMonThiLai As Integer = 0
                So_ht_no = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        TBCHP1 = diem.dsDiemThi.TBCHP_lan(1, 1)
                        TBCHP = diem.dsDiemThi.TBCHP_max
                        If ((TBCHP1 >= 0) And Not Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT) Then
                            Tong_diem1 = (Tong_diem1 + (TBCHP1 * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_diem = (Tong_diem + (TBCHP * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                            Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                        End If
                        If (dtTongHop.Columns.IndexOf(("M" & ID_mon.ToString)) = -1) Then
                            dtTongHop.Columns.Add(("M" & ID_mon.ToString))
                        End If
                        If (Lan_thi = 1) Then
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP1, QC.TBCHP_lam_tron)
                            End If
                        Else
                            If TBCHP1 >= 0 Then
                                dr.Item(("M" & ID_mon.ToString)) = QC.FormatSoThapPhan(TBCHP, QC.TBCHP_lam_tron)
                            End If
                        End If
                        If diem.dsDiemThiLai.Thi_lai = 1 Then So_mon_thi_lai += 1
                        If diem.dsDiemHocLai.Hoc_lai = 1 Then So_mon_hoc_lai += 1
                        If TBCHP >= 0 And (TBCHP < QC.Diem_hoc_phan_dat) And dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                            So_mon_no += 1
                            So_ht_no = So_ht_no + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT1 = QC.DiemTBCHT_lam_tron((Tong_diem1 / Tong_so_hoc_trinh))
                    TBCHT = QC.DiemTBCHT_lam_tron((Tong_diem / Tong_so_hoc_trinh))
                    dr.Item("TBCHT1") = QC.FormatSoThapPhan(TBCHT1, QC.TBCHT_lam_tron)
                    dr.Item("TBCHT") = QC.FormatSoThapPhan(TBCHT, QC.TBCHT_lam_tron)
                    Dim objXepLoai As New XepLoaiHocTap
                    Dim Phan_tram_thi_lai As Integer = So_mon_thi_lai / dsMonHoc.Count
                    objXepLoai = QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT, Phan_tram_thi_lai)
                    dr.Item("ID_xep_loai") = objXepLoai.ID_xep_loai
                    dr.Item("Xep_loai") = objXepLoai.Xep_loai
                    dr.Item("Ly_do") = objXepLoai.Ghi_chu
                End If
                If (So_mon_no > 0) Then
                    dr.Item("So_mon_no") = So_mon_no
                End If
                If (So_mon_thi_lai > 0) Then
                    dr.Item("So_mon_thi_lai") = So_mon_thi_lai
                End If
                If (So_mon_hoc_lai > 0) Then
                    dr.Item("So_mon_hoc_lai") = So_mon_hoc_lai
                End If
                If (So_ht_no > 0) Then
                    dr.Item("So_ht_no") = So_ht_no
                End If
            Next
            Return dtTongHop
        End Function
        Public Function TongHopDiemMonChungChi(ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer, ByVal GDTC As Boolean) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT, TBCHP As Double
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            'Add cac cot diem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Dim Ly_do As String = ""

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)

                    'Check mon thuoc ID_dt va cugn Loai chung chi moi tong hop
                    If idx_diem >= 0 AndAlso Tim_idx_MonChungChi(ID_mon, ID_dt, ID_chung_chi) >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        TBCHP = diem.dsDiemThi.TBCHP_max
                        Tong_diem += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        Tong_so_hoc_trinh += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        'Kiem tra cac mon trong ds mon cua chung chi voi chung chi GDQP
                        If GDTC = False AndAlso TBCHP < 5 Then Ly_do = "No mon"
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = QC.DiemTBCHT_lam_tron(((Tong_diem / CDbl(Tong_so_hoc_trinh))))
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepLoaiChungChi.IDXepLoaiChungChi(TBCHT)
                    dr("Xep_hang") = dsXepLoaiChungChi.XepLoaiChungChi(TBCHT)
                End If
                dr("Chon") = False
                dr("Ly_do") = Ly_do.Trim
            Next
            dtTongHop.DefaultView.RowFilter = "Ly_do='' AND TBCHT>=5"
            Return dtTongHop
        End Function
        Public Function TongHopDiem_XetTotNghiep() As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_DVHT_CacMon, Tong_DVHT_MonTN, Tong_DVHT_Mon_Thuong As Integer
            Dim TBCHP, Tong_Diem_CacMon, Tong_Diem_Mon_TN, Tong_Diem_Mon_Thuong, TBCHT_Ky As Double
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_tin_chi", GetType(Integer))
            'dtTongHop.Columns.Add("Nam_thu", GetType(Integer))
            dtTongHop.Columns.Add("LyDo_no_mon", GetType(String))
            dtTongHop.Columns.Add("LyDo_mon_batbuoc", GetType(String))
            dtTongHop.Columns.Add("LyDo_TBCHT_TL", GetType(String))
            dtTongHop.Columns.Add("So_tinchi_tichluy", GetType(String))
            dtTongHop.Columns.Add("HaBac_TotNghiep", GetType(String))
            dtTongHop.Columns.Add("LyDo_MonTN", GetType(String))
            

            Dim LyDo_no_mon_thuong, LyDo_no_mon_TN, LyDo_TBCHT_CacMonTN As String
            Dim LyDo_mon_batbuoc As String = ""
            Dim ID_dt As Integer

            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                If dr("ID_SV") = 1 Then
                    dr("ID_SV") = 1
                End If
                LyDo_no_mon_thuong = ""
                LyDo_no_mon_TN = ""
                LyDo_mon_batbuoc = ""

                TBCHT_Ky = 0
                Tong_Diem_CacMon = 0
                Tong_Diem_Mon_TN = 0
                Tong_Diem_Mon_Thuong = 0

                Tong_DVHT_CacMon = 0
                Tong_DVHT_Mon_Thuong = 0
                Tong_DVHT_MonTN = 0

                ID_dt = dr.Item("ID_dt")
                Dim So_TC_ThiLai As Double = 0
                Dim So_Mon_duoi45_5 As Integer = 0
                Dim So_Mon_duoi5 As Integer = 0
                LyDo_TBCHT_CacMonTN = ""

                'Tao dt de luu diem theo tung Hoc ky va Nam Hoc
                Dim dt_LuuKy As New DataTable
                dt_LuuKy.Columns.Add("Hoc_ky", GetType(Integer))
                dt_LuuKy.Columns.Add("Nam_hoc", GetType(String))
                Dim dt_LuuDiemKy As New DataTable
                dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
                dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
                dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
                dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))

                'Dua danh sach cac mon chua co diem
                Dim clsXetTN As New DanhSachTotNghiep_DAL
                Dim dt_LyDo_mon_batbuoc As DataTable = clsXetTN.Check_MonBatBuoc_SV_List(dr.Item("ID_SV"), mID_dv, 1, False)
                For j As Integer = 0 To dt_LyDo_mon_batbuoc.Rows.Count - 1
                    If LyDo_mon_batbuoc.Trim = "" Then
                        LyDo_mon_batbuoc = dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu").ToString.Trim
                    ElseIf dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu").ToString.Trim <> "" Then
                        LyDo_mon_batbuoc += ", " & dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu")
                    End If
                Next
                'If dr("ID_SV") = 73 Then
                '    dr("ID_SV") = 73
                'End If
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        TBCHP = Math.Round(diem.dsDiemThi.TBCHP_max, QC.TBCHP_lam_tron)
                        If diem.dsDiemThi.TBCHP_lan(1, 1) < 5 Then So_TC_ThiLai += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                        If TBCHP >= 0 Then
                            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                            If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                Tong_DVHT_CacMon += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_Diem_CacMon += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                'Tinh TBCHT cac mon thi tot nghiep
                                If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Mon_thi_TN = True Then
                                    Tong_DVHT_MonTN += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_Diem_Mon_TN += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Else
                                    Tong_DVHT_Mon_Thuong += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_Diem_Mon_Thuong += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If

                                '-----Xu ly voi diem TBC cac ky de tinh TBCKy--------
                                dt_LuuKy.DefaultView.RowFilter = "Hoc_ky=" & diem.Hoc_ky & " AND Nam_hoc='" & diem.Nam_hoc & "'"
                                If dt_LuuKy.DefaultView.Count <= 0 Then
                                    Dim dr_Ky As DataRow = dt_LuuKy.NewRow
                                    dr_Ky("Hoc_ky") = diem.Hoc_ky
                                    dr_Ky("Nam_hoc") = diem.Nam_hoc
                                    dt_LuuKy.Rows.Add(dr_Ky)
                                End If
                                Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
                                dr_CheckKy("Hoc_ky") = diem.Hoc_ky
                                dr_CheckKy("Nam_hoc") = diem.Nam_hoc
                                dr_CheckKy("Diem") = TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dr_CheckKy("So_TC") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dt_LuuDiemKy.Rows.Add(dr_CheckKy)
                                '----------------------------
                            End If
                        End If
                        If TBCHP < 5 Then
                            If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Mon_thi_TN = True Then
                                '<5 nhung >=4.5 voi 1 mon thi van tot nghiep
                                If TBCHP >= 4.5 Then
                                    So_Mon_duoi45_5 += 1
                                Else
                                    So_Mon_duoi5 += 1
                                End If
                                If LyDo_no_mon_TN.Trim = "" Then
                                    LyDo_no_mon_TN = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Math.Round(TBCHP, QC.TBCHP_lam_tron)
                                Else
                                    LyDo_no_mon_TN += ", " & dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Math.Round(TBCHP, QC.TBCHP_lam_tron)
                                End If
                            Else
                                If LyDo_no_mon_thuong.Trim = "" Then
                                    LyDo_no_mon_thuong = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Math.Round(TBCHP, QC.TBCHP_lam_tron)
                                Else
                                    LyDo_no_mon_thuong += ", " & dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Math.Round(TBCHP, QC.TBCHP_lam_tron)
                                End If
                            End If
                        End If
                    End If
                Next

                'Diem mon TN<5 nhung >=4.5 voi 1 mon thi van tot nghiep
                'If So_Mon_duoi45_5 = So_Mon_duoi45_5 Then LyDo_no_mon_TN = ""
                If LyDo_no_mon_TN.Trim <> "" Then LyDo_no_mon_thuong = LyDo_no_mon_thuong & ", " & LyDo_no_mon_TN
                If dr("ID_SV") = 181 Then
                    dr("ID_SV") = 181
                End If
                If Tong_DVHT_CacMon > 0 Then
                    'Tinh diem TBCKy cua cac ky
                    For k As Integer = 0 To dt_LuuKy.Rows.Count - 1
                        Dim TBC_TungKy As Double = 0
                        Dim So_DVHT_TungKy As Integer = 0
                        dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_LuuKy.Rows(k).Item("Hoc_ky") & " AND Nam_hoc='" & dt_LuuKy.Rows(k).Item("Nam_hoc") & "'"
                        For e As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
                            TBC_TungKy += dt_LuuDiemKy.DefaultView.Item(e)("Diem")
                            So_DVHT_TungKy += dt_LuuDiemKy.DefaultView.Item(e)("So_TC")
                        Next
                        If So_DVHT_TungKy > 0 Then TBCHT_Ky += TBC_TungKy / So_DVHT_TungKy
                    Next
                    'TInh TBCKy tu cac ky da co
                    If dt_LuuKy.Rows.Count > 0 Then TBCHT_Ky = TBCHT_Ky / dt_LuuKy.Rows.Count

                    'Xử lý điểm TBCHT theo các quy chế
                    Dim TBCHT_ToanKHoa As Double = QC.XuLy_Diem_TBCTK_TotNghiep(TBCHT_Ky, Tong_Diem_CacMon, Tong_DVHT_CacMon, Tong_Diem_Mon_Thuong, Tong_DVHT_Mon_Thuong, Tong_Diem_Mon_TN, Tong_DVHT_MonTN, So_Mon_duoi45_5, LyDo_TBCHT_CacMonTN)

                    'dr("LyDo_no_mon") = LyDo_no_mon_TN
                    'dr("LyDo_mon_batbuoc") = LyDo_mon_batbuoc
                    'If TBCHT_ToanKHoa < 5 Then dr("LyDo_TBCHT_TL") = "TBCHT: " & TBCHT_ToanKHoa & " <5"
                    'dr("TBCHT") = TBCHT_ToanKHoa
                    'dr("So_tin_chi") = Tong_DVHT_CacMon
                    'dr("LyDo_MonTN") = LyDo_TBCHT_CacMonTN

                    dr("LyDo_no_mon") = LyDo_no_mon_thuong 'LyDo_no_mon_TN
                    dr("LyDo_mon_batbuoc") = LyDo_mon_batbuoc
                    If TBCHT_ToanKHoa < 5 Then dr("LyDo_TBCHT_TL") = "TBCHT: " & TBCHT_ToanKHoa & " <5"
                    dr("TBCHT") = TBCHT_ToanKHoa
                    dr("So_tin_chi") = Tong_DVHT_CacMon
                    dr("LyDo_MonTN") = LyDo_TBCHT_CacMonTN

                    'Hạ một mức tốt nghiệp cho loại Xuất sắc và Giỏi nếu dơi vào:
                    '1. Nếu bị kỷ luật trên mức cảnh cáo
                    '2. Nếu bị thi lại quá số % cho phép so với Số học trình tích luỹ
                    If Tong_DVHT_CacMon <> 0 Then
                        So_TC_ThiLai = Math.Round(So_TC_ThiLai * 100 / Tong_DVHT_CacMon, QC.TBCHT_lam_tron)
                    Else
                        So_TC_ThiLai = 0
                    End If
                    Dim clsDal As New Diem_DAL
                    If So_TC_ThiLai > QC.PtramHoctrinhThilai_Hatotnghiep Or clsDal.CheckMucKyLuat_HaLoaiTotNghiep(dr.Item("ID_SV"), MucXuLy_KyLuat_HaLoaiTotNghiep) Then
                        dr("Xep_loai") = dsXepHangTotNghiep.XepHangTotNghiep(TBCHT_ToanKHoa, True)
                        dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT_ToanKHoa, True)
                        If So_TC_ThiLai > QC.PtramHoctrinhThilai_Hatotnghiep Then
                            dr("HaBac_TotNghiep") = "Hạ bậc tốt nghiệp do số học trình thi lại vượt quá số cho phép"
                        Else
                            dr("HaBac_TotNghiep") = "Vi phạm kỷ luật từ cảnh cáo trở lên"
                        End If
                    Else
                        dr("Xep_loai") = dsXepHangTotNghiep.XepHangTotNghiep(TBCHT_ToanKHoa, False)
                        dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT_ToanKHoa, False)
                    End If
                Else
                    dr("LyDo_TBCHT_TL") = "Chưa có TBCHT"
                    dr("TBCHT") = 0
                    dr("ID_xep_loai") = 0
                    dr("Xep_loai") = ""
                    dr("So_tin_chi") = 0
                End If
            Next
            Return dtTongHop
        End Function

        Function BangDiemSinhVien(ByVal dv As DataView) As DataTable
            Dim dt As New DataTable
            Dim dt_tonghop As DataTable
            dt = BangDiemChiTietSinhVien(dv.Item(0)("ID_SV"))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_tinh", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))

            dt.Columns.Add("TBCHT", GetType(String))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_loai", GetType(String))
            dt.Columns.Add("So_mon_no", GetType(Integer))
            dt.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dt.Columns.Add("So_mon_hoc_lai", GetType(Integer))


            dt_tonghop = TongHopDiemSinhVien(dv.Item(0)("ID_SV"))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Ma_sv") = dv.Item(0)("Ma_sv")
                dt.Rows(i).Item("Ho_ten") = dv.Item(0)("Ho_ten")
                If dv.Item(0)("Ngay_sinh").ToString.Trim <> "" Then dt.Rows(i).Item("Ngay_sinh") = dv.Item(0)("Ngay_sinh")
                dt.Rows(i).Item("Ten_tinh") = dv.Item(0)("Noi_sinh").ToString
                dt.Rows(i).Item("Ten_lop") = dv.Item(0)("Ten_lop").ToString
                dt.Rows(i).Item("Khoa_hoc") = dv.Item(0)("Khoa_hoc").ToString
                dt.Rows(i).Item("Nien_khoa") = dv.Item(0)("Nien_khoa").ToString
                dt.Rows(i).Item("Ten_he") = dv.Item(0)("Ten_he").ToString
                dt.Rows(i).Item("Ten_khoa") = dv.Item(0)("Ten_khoa").ToString
                dt.Rows(i).Item("Ten_nganh") = dv.Item(0)("Ten_nganh").ToString
                dt.Rows(i).Item("Chuyen_nganh") = dv.Item(0)("Chuyen_nganh").ToString

                dt.Rows(i).Item("TBCHT") = dt_tonghop.Rows(0).Item("TBCHT")
                dt.Rows(i).Item("ID_xep_loai") = dt_tonghop.Rows(0).Item("ID_xep_loai")
                dt.Rows(i).Item("Xep_loai") = dt_tonghop.Rows(0).Item("Xep_loai")
                dt.Rows(i).Item("So_mon_no") = dt_tonghop.Rows(0).Item("So_mon_no")
                dt.Rows(i).Item("So_mon_thi_lai") = dt_tonghop.Rows(0).Item("So_mon_thi_lai")
                dt.Rows(i).Item("So_mon_hoc_lai") = dt_tonghop.Rows(0).Item("So_mon_hoc_lai")
            Next
            Return dt
        End Function

        Private Function TongHopDiemSinhVien(ByVal ID_sv As Integer) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT, TBCHP As Double
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai, So_mon_no As Integer
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            Dim dr As DataRow
            dr = dtTongHop.NewRow

            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            Dim DiemvaGhiChu As String = ""
            So_mon_no = 0
            Tong_diem = 0
            Tong_so_hoc_trinh = 0
            So_mon_hoc_lai = 0
            So_mon_thi_lai = 0
            Dim SoMonThiLai As Integer = 0
            'Duyet cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                'Tim diem cua sinh vien nay
                idx_diem = Tim_idx(ID_sv, ID_mon)
                'Nếu sinh viên có điểm môn học này thì tính điểm
                If idx_diem >= 0 Then
                    Dim diem As Diem = arrDiem(idx_diem)
                    TBCHP = diem.dsDiemThi.TBCHP_max
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        Tong_diem = (Tong_diem + (TBCHP * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                        Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                    End If

                    If diem.dsDiemThiLai.Thi_lai = 1 Then So_mon_thi_lai += 1
                    If diem.dsDiemHocLai.Hoc_lai = 1 Then So_mon_hoc_lai += 1
                    If TBCHP >= 0 And (TBCHP < QC.Diem_hoc_phan_dat) Then
                        So_mon_no += 1
                    End If
                End If
            Next
            'Tính điểm TBCHT và xếp loại
            If (Tong_so_hoc_trinh > 0) Then
                TBCHT = QC.DiemTBCHT_lam_tron((Tong_diem / Tong_so_hoc_trinh))
                dr("TBCHT") = TBCHT
                Dim objXepLoai As New XepLoaiHocTap
                Dim Phan_tram_thi_lai As Integer = So_mon_thi_lai / dsMonHoc.Count
                objXepLoai = QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT, Phan_tram_thi_lai)
                dr("ID_xep_loai") = objXepLoai.ID_xep_loai
                dr("Xep_loai") = objXepLoai.Xep_loai
            End If
            If (So_mon_no > 0) Then
                dr("So_mon_no") = So_mon_no
            End If
            If (So_mon_thi_lai > 0) Then
                dr("So_mon_thi_lai") = So_mon_thi_lai
            End If
            If (So_mon_hoc_lai > 0) Then
                dr("So_mon_hoc_lai") = So_mon_hoc_lai
            End If
            dtTongHop.Rows.Add(dr)
            Return dtTongHop
        End Function
        Private Function BangDiemChiTietSinhVien(ByVal ID_SV As Integer) As DataTable
            Dim dtBangDiem As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
            dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
            dtBangDiem.Columns.Add("Ten_mon", GetType(String))
            dtBangDiem.Columns.Add("So_tin_chi", GetType(Integer))
            dtBangDiem.Columns.Add("TBCHP", GetType(String))
            dtBangDiem.Columns.Add("Khong_tinh_TBCHT", GetType(Integer))
            dtBangDiem.Columns.Add("Mon_Tot_Nghiep", GetType(Integer))
            dtBangDiem.Columns.Add("TBCMH1", GetType(String))
            dtBangDiem.Columns.Add("TBCMH2", GetType(String))
            dtBangDiem.Columns.Add("Nam_hoc", GetType(String))
            dtBangDiem.Columns.Add("Nam_hoc_show", GetType(String))
            dtBangDiem.Columns.Add("Hoc_ky_show", GetType(String))
            dtBangDiem.Columns.Add("STT", GetType(String))
            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(ID_SV, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm

                    dtBangDiem.DefaultView.Sort = "ID_mon"
                    If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        Dim dr As DataRow = dtBangDiem.NewRow
                        dr("ID_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        dr("Ky_hieu") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                        dr("Ten_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ten_mon
                        dr("So_tin_chi") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        dr("TBCMH1") = IIf(diem.dsDiemThi.TBCHP_lan(1, 1) >= 0, Math.Round(diem.dsDiemThi.TBCHP_lan(1, 1), QC.TBCHP_lam_tron), "")
                        dr("TBCMH2") = IIf(diem.dsDiemThi.TBCHP_lan(1, 2) >= 0, Math.Round(diem.dsDiemThi.TBCHP_lan(1, 2), QC.TBCHP_lam_tron), "")
                        dr("Khong_tinh_TBCHT") = IIf(dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT, 1, 0)
                        dr("Mon_Tot_Nghiep") = IIf(dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Mon_thi_TN, 1, 0)

                        dr("Nam_hoc") = diem.Nam_hoc
                        dr("Nam_hoc_show") = diem.Nam_hoc
                        dr("Hoc_ky_show") = diem.Hoc_ky
                        If diem.dsDiemThi.TBCHP_CoDiemKhacLan1_max() >= 0 Then dr("TBCHP") = Math.Round(diem.dsDiemThi.TBCHP_CoDiemKhacLan1_max(), QC.TBCHP_lam_tron)
                        'Add môn học vào bảng điểm
                        dtBangDiem.Rows.Add(dr)
                    End If
                End If
            Next
            dtBangDiem.DefaultView.Sort = "Khong_tinh_TBCHT ASC"
            dtBangDiem.DefaultView.AllowDelete = False
            dtBangDiem.DefaultView.AllowEdit = False
            dtBangDiem.DefaultView.AllowNew = False
            Return dtBangDiem
        End Function

        Private Sub Load_Diem_ThanhPhan(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer)
            Dim clsDAL As New Diem_DAL
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            'Lấy dữ liệu điểm thành phần và điểm thi
            If ID_mon_tc = 0 And ID_lop_tc = 0 Then 'Lop hanh chinh
                dtDiem = clsDAL.Load_KhongDuDKDuThiDiemTP_List(ID_dv, Hoc_ky, Nam_hoc, ID_mon)
            Else 'Lop tin chi
                dtDiem = clsDAL.Load_Diem_TongHopTinChi_List(ID_dv, Hoc_ky, Nam_hoc, ID_mon, ID_lop_tc, ID_mon_tc)
            End If

            For i As Integer = 0 To dtDiem.Rows.Count - 1
                Dim objDiem As New Diem
                objDiem.ID_mon = dtDiem.Rows(i).Item("ID_mon")
                objDiem.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                objDiem.dsDiemThanhPhan.Diem = dtDiem.Rows(i).Item("Diem")
                objDiem.dsDiemThanhPhan.Ty_le = dtDiem.Rows(i).Item("Ty_le")
                objDiem.Hoc_ky = dtDiem.Rows(i).Item("Hoc_ky")
                objDiem.Nam_hoc = dtDiem.Rows(i).Item("Nam_hoc")
                arrDiem.Add(objDiem)
            Next
        End Sub

        Public Function Tim_idx(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), Diem).ID_sv = ID_sv And CType(arrDiem(i), Diem).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx_MonChungChi(ByVal ID_mon As Integer, ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer) As Integer
            Dim clsDAL As New Diem_DAL
            Dim dt As DataTable = clsDAL.LoaLoaiChungChi_DSMon(ID_dt, ID_chung_chi)
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("ID_mon") = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx(ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), Diem).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Sub LuuDiemThi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer)
            Try
                For i As Integer = 0 To arrDiem.Count - 1
                    Dim objDiem As New Diem
                    Dim objDiemThi As New DiemThi
                    Dim ID_diem, idx_diem_thi As Integer
                    objDiem = CType(arrDiem(i), Diem)
                    idx_diem_thi = objDiem.dsDiemThi.idx_diem_thi(Lan_hoc, Lan_thi)
                    If idx_diem_thi >= 0 Then
                        objDiemThi = objDiem.dsDiemThi.DiemThi(idx_diem_thi)
                    Else
                        objDiemThi.Lan_thi = Lan_thi
                        objDiemThi.Diem_thi = -1
                    End If
                    If objDiem.ID_sv = 14722 Then
                        objDiem.ID_sv = 14722
                    End If
                    'Nếu chưa có môn học này thì insert
                    If objDiem.ID_diem <= 0 Then
                        ID_diem = Insert_Diem(objDiem)
                        objDiem.ID_diem = ID_diem
                    Else
                        ID_diem = objDiem.ID_diem
                        Update_Diem(objDiem, ID_diem)
                    End If
                    'Nếu không có điểm thành phần và điểm thì thì xoá điểm môn học
                    If objDiem.dsDiemThanhPhan.Count = 0 And objDiem.dsDiemThi.Count = 0 Then
                        Delete_Diem(objDiem.ID_diem)
                    Else
                        'Tính điểm TBCHP
                        Dim TBCHP As Double = 0
                        TBCHP = Me.QC.DiemTBCHP(Lan_hoc, Lan_thi, objDiem, Me.dsThanhPhanDiem)
                        TBCHP = Round_Mark(TBCHP)
                        objDiemThi.TBCHP = TBCHP
                        If ((objDiemThi.Diem_thi = -1) And (objDiemThi.Ghi_chu = "")) Then
                            Delete_DiemThi(ID_diem, Lan_hoc, Lan_thi)
                        ElseIf (Me.CheckExist_svDiemThi(ID_diem, Lan_hoc, Lan_thi) > 0) Then
                            Update_DiemThi(objDiemThi, ID_diem, Lan_thi)
                        Else
                            Insert_DiemThi(ID_diem, objDiemThi)
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Function Round_Mark(ByVal Diem_TBCMH As Double) As Double
            Diem_TBCMH = Math.Round(Diem_TBCMH, 2)
            If Diem_TBCMH > 0 Then
                Dim Diem As Double = Math.Truncate(Diem_TBCMH)
                Dim Diem_le As Double = Diem_TBCMH - Diem

                If Diem_le >= 0.25 And Diem_le < 0.75 Then Diem = Diem + 0.5
                If Diem_le >= 0.75 Then Diem = Diem + 1
                Return Diem
            Else
                Return 0
            End If
        End Function
        Public Sub LuuDiemThi_ImportExcel(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer)
            Try
                For i As Integer = 0 To arrDiem.Count - 1
                    Dim objDiem As New Diem
                    Dim objDiemThi As New DiemThi
                    Dim ID_diem, idx_diem_thi As Integer
                    objDiem = CType(arrDiem(i), Diem)
                    idx_diem_thi = objDiem.dsDiemThi.idx_diem_thi(Lan_thi, Lan_hoc)
                    If idx_diem_thi >= 0 Then
                        objDiemThi = objDiem.dsDiemThi.DiemThi(idx_diem_thi)
                    Else
                        objDiemThi.Lan_thi = Lan_thi
                        objDiemThi.Diem_thi = -1
                    End If
                    'Nếu chưa có môn học này thì insert
                    If objDiem.ID_diem <= 0 Then
                        ID_diem = Insert_Diem(objDiem)
                        objDiem.ID_diem = ID_diem
                    Else
                        ID_diem = objDiem.ID_diem
                    End If
                    'Nếu không có điểm thành phần và điểm thì thì xoá điểm môn học
                    If objDiem.dsDiemThanhPhan.Count = 0 And objDiem.dsDiemThi.Count = 0 Then
                        Delete_Diem(objDiem.ID_diem)
                    Else
                        Dim TBCHP As Double = Me.QC.DiemTBCHP(Lan_hoc, Lan_thi, objDiem, Me.dsThanhPhanDiem)
                        objDiemThi.TBCHP = TBCHP
                        If (objDiemThi.Diem_thi = -1) Then
                            Me.Delete_DiemThi(ID_diem, Lan_hoc, Lan_thi)
                        ElseIf (Me.CheckExist_svDiemThi(ID_diem, Lan_hoc, Lan_thi) > 0) Then
                            Me.Update_DiemThi(objDiemThi, ID_diem, Lan_thi)
                        Else
                            Me.Insert_DiemThi(ID_diem, objDiemThi)
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Insert_Diem(ByVal objDiem As Diem) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Insert_Diem(objDiem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Diem(ByVal objDiem As Diem, ByVal ID_diem As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_Diem(objDiem, ID_diem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Diem(ByVal ID_diem As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Delete_Diem(ID_diem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemThi(ByVal ID_diem As Integer, ByVal objDiemThi As DiemThi) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Insert_DiemThi(ID_diem, objDiemThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThi(ByVal objDiemThi As DiemThi, ByVal ID_diem As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_DiemThi(objDiemThi, ID_diem, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThiLock(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_DiemThiLock(ID_diem, Locked, Lan_hoc, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Lock_UnLock_Diem(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Lock_UnLock_Diem(ID_sv, ID_mon, Lan_hoc, Lan_thi, Locked)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemThi(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Delete_DiemThi(ID_diem, Lan_hoc, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemThi(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.CheckExist_DiemThi(ID_diem, Lan_hoc, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemDanh(ByVal ID_diem As Integer, ByVal objDiemDanh As DiemDanh) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Insert_DiemDanh(ID_diem, objDiemDanh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemDanh(ByVal objDiemDanh As DiemDanh, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_DiemDanh(objDiemDanh, ID_diem, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemDanh(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Delete_DiemDanh(ID_diem, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemDanh(ByVal ID_diem As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.CheckExist_DiemDanh(ID_diem, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.CheckExist_DiemThanhPhan(ID_diem, ID_thanh_phan, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemThanhPhan(ByVal ID_diem As Integer, ByVal objDiemThanhPhan As DiemThanhPhan) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Insert_DiemThanhPhan(ID_diem, objDiemThanhPhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThanhPhan(ByVal objDiemThanhPhan As DiemThanhPhan, ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_DiemThanhPhan(objDiemThanhPhan, ID_diem, ID_thanh_phan, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemThanhPhanLock(ByVal ID_diem As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Update_DiemThanhPhanLock(ID_diem, Locked)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.Delete_DiemThanhPhan(ID_diem, ID_thanh_phan, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DiemSinhVienToanKhoa_Nganh1TrungNganh2(ByVal ID_sv As Integer, ByVal dt_MonTrung As DataTable) As DataTable
            Dim dtDiem, mdt_MonTrung As New DataTable
            mdt_MonTrung = dt_MonTrung.Copy
            Dim idx_diem As Integer
            Dim Diem_chu As String

            dtDiem = dt_MonTrung.Clone
            dtDiem.Columns.Add("Chon", GetType(Boolean))
            dtDiem.Columns.Add("idx_diem", GetType(Integer))
            dtDiem.Columns.Add("TBCM", GetType(String))
            dtDiem.Columns.Add("Diem_chu", GetType(String))
            For i As Integer = 0 To dsMonHoc.Count - 1
                dt_MonTrung.DefaultView.Sort = "ID_mon"
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dt_MonTrung.DefaultView.Find(dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon) >= 0 Then
                    'ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim diem cua sinh vien nay
                    idx_diem = Tim_idx(ID_sv, dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim diem As Diem = arrDiem(idx_diem)
                        Dim dr As DataRow = dtDiem.NewRow
                        dr("idx_diem") = idx_diem
                        dr("ID_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        dr("Ky_hieu") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                        dr("Ten_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ten_mon
                        dr("So_hoc_trinh") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        dr("Hoc_ky") = diem.Hoc_ky
                        dr("Nam_hoc") = diem.Nam_hoc
                        If (diem.dsDiemThi.TBCHP_max >= 0) Then
                            dr.Item("TBCM") = diem.dsDiemThi.TBCHP_max
                        End If
                        dr("Chon") = False
                        'Add môn học vào bảng điểm
                        dtDiem.Rows.Add(dr)
                    End If
                End If
            Next

            Return dtDiem
        End Function
        Public Function XetHoc2ChuongTrinh(ByVal dt As DataTable) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double
            Dim dr As DataRow
            dtTongHop = dt.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("Ky_tich_luy", GetType(Integer))
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = DirectCast(Me.arrDiem.Item(idx_diem), Diem)
                            Diem_so = diem.dsDiemThi.TBCHP
                            If (Diem_so > 0) Then
                                Tong_diem = (Tong_diem + (Diem_so * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                                Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT = Me.QC.DiemTBCHT_lam_tron((Tong_diem / CDbl(Tong_so_hoc_trinh)))
                    dr.Item("TBCHT") = Strings.Format(TBCHT, "##.00")
                    Dim objXepLoai As New XepLoaiHocTap
                    objXepLoai = Me.QC.Xep_loai_hoc_tap(dsXepLoaiHocTap, TBCHT, 0)
                    dr.Item("Xep_loai") = objXepLoai.Xep_loai
                    Dim clsDAL As New Diem_DAL
                    dr.Item("Ky_tich_luy") = clsDAL.Get_KyTichLuy((dr.Item("ID_sv"))).Rows.Count
                    dr.Item("Chon") = False
                End If
            Next
            Return dtTongHop
        End Function

        Public Function KetQua_XetLenLop(ByVal dtLop As DataTable, ByVal Nam_hoc As String, ByRef dtHocTiep As DataTable, ByRef dtNgungHoc As DataTable, ByRef dtThoiHoc As DataTable) As DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHP As Double
            Dim dr As DataRow
            Dim mdtHocTiep, mdtNgungHoc, mdtThoiHoc As New DataTable

            mdtHocTiep.Columns.Add("ID_sv", GetType(Integer))
            mdtHocTiep.Columns.Add("Ma_sv", GetType(String))
            mdtHocTiep.Columns.Add("Ho_ten", GetType(String))
            mdtHocTiep.Columns.Add("Ngay_sinh", GetType(Date))
            mdtHocTiep.Columns.Add("ID_lop", GetType(Integer))
            mdtHocTiep.Columns.Add("Ten_lop", GetType(String))
            mdtHocTiep.Columns.Add("ID_lop_cu", GetType(Integer))
            mdtHocTiep.Columns.Add("Chon", GetType(Boolean))

            mdtNgungHoc = mdtHocTiep.Clone
            mdtNgungHoc.Columns.Add("Ly_do1", GetType(String))
            mdtNgungHoc.Columns.Add("Ly_do2", GetType(String))
            mdtThoiHoc = mdtHocTiep.Clone
            mdtThoiHoc.Columns.Add("Ly_do1", GetType(String))
            mdtThoiHoc.Columns.Add("Ly_do2", GetType(String))
            mdtThoiHoc.Columns.Add("Ly_do3", GetType(String))

            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In mdtDanhSachSinhVien.Rows
                Dim SoHTdiemDuoi5 As Integer = 0
                'Add cac nam hoc vao dt de kiem tra theo dieu kien hoc tap cua nam hoc
                Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
                Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
                Dim dt_NamHoc As New DataTable
                dt_NamHoc.Columns.Add("Nam_hoc", GetType(String))
                dt_NamHoc.Columns.Add("TBCHT_Nam", GetType(Double))
                dt_NamHoc.Columns.Add("TBCHT_SauXNam", GetType(Double))

                For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
                    Dim dr_kh As DataRow
                    dr_kh = dt_NamHoc.NewRow

                    If Nam_hoc = i & "-" & i + 1 Then
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_NamHoc.Rows.Add(dr_kh)
                        Exit For
                    Else
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_NamHoc.Rows.Add(dr_kh)
                    End If
                Next

                'Tao dt de luu diem theo tung Nam Hoc
                Dim dt_LuuDiemNam As New DataTable
                dt_LuuDiemNam.Columns.Add("Nam_hoc", GetType(String))
                dt_LuuDiemNam.Columns.Add("Diem", GetType(Double))
                dt_LuuDiemNam.Columns.Add("So_tc", GetType(Double))

                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Dim ID_dt As Integer = 0
                'Duyet cac mon hoc de gan diem tung mon vao nam hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    ID_dt = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_dt
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            'Chỉ tổng hợp những năm hiện tại
                            If diem.Nam_hoc <= Nam_hoc Then
                                TBCHP = diem.dsDiemThi.TBCHP_max
                                'Tính Số học trình tích luỹ
                                If TBCHP >= 0 Then
                                    Tong_diem += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                '************************
                                'Luu vao dt nay de sau nay tinh diem TBCHT nam hoc 
                                If TBCHP >= 0 Then
                                    Dim dr_CheckKy As DataRow = dt_LuuDiemNam.NewRow
                                    dr_CheckKy("Nam_hoc") = diem.Nam_hoc
                                    dr_CheckKy("Diem") = TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr_CheckKy("So_TC") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dt_LuuDiemNam.Rows.Add(dr_CheckKy)
                                    If TBCHP < 5 Then SoHTdiemDuoi5 += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                            End If
                        End If
                    End If
                Next

                ' Tinh diem TBCHT theo tung nam hoc
                Dim TBCHT_AllNam As Double = 0
                Dim So_hoc_trinh_All As Integer = 0
                For j As Integer = 0 To dt_NamHoc.Rows.Count - 1
                    Dim TBCHT_Nam As Double = 0
                    Dim So_hoc_trinh As Integer = 0
                    dt_LuuDiemNam.DefaultView.RowFilter = "Nam_hoc='" & dt_NamHoc.Rows(j).Item("Nam_hoc") & "'"
                    For i As Integer = 0 To dt_LuuDiemNam.DefaultView.Count - 1
                        TBCHT_Nam += dt_LuuDiemNam.DefaultView.Item(i)("Diem")
                        So_hoc_trinh += dt_LuuDiemNam.DefaultView.Item(i)("So_TC")
                    Next
                    TBCHT_AllNam += TBCHT_Nam
                    So_hoc_trinh_All += So_hoc_trinh
                    If So_hoc_trinh > 0 Then
                        TBCHT_Nam = QC.DiemTBCHT_lam_tron(TBCHT_Nam / So_hoc_trinh)
                        dt_NamHoc.Rows(j).Item("TBCHT_Nam") = TBCHT_Nam
                    Else
                        dt_NamHoc.Rows(j).Item("TBCHT_Nam") = 0
                    End If
                    'Neu la X nam hoc dau Add vao Nam de xet TBCHT tich luy den X nam dau < 4. ... thi thoi hoc
                    If So_hoc_trinh_All > 0 Then
                        dt_NamHoc.Rows(j).Item("TBCHT_SauXNam") = Me.QC.DiemTBCHT_lam_tron(TBCHT_AllNam / So_hoc_trinh_All)
                    End If
                Next

                'Kiem tra cac dieu kien cho sinh vien Hoc tiep, Ngung hoc, Thoi hoc

                '1. Check thời gian hoàn thành chương trình đào tạo
                Dim Ly_do1, Ly_do2, Ly_do3, Ly_do_NgungHoc1, Ly_do_NgungHoc2 As String
                Ly_do1 = ""
                Ly_do2 = ""
                Ly_do3 = ""
                Ly_do_NgungHoc1 = ""
                Ly_do_NgungHoc2 = ""
                Dim cls As ChuongTrinhDaoTao_BLL
                cls = New ChuongTrinhDaoTao_BLL(dr("ID_dt"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)

                'Con phai check tru di thoi gian ngung hoc co ly do nua moi OK :)
                If So_ky_ToiDa < So_ky_hienTai Then Ly_do1 = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa

                '2. Check cac dieu kien theo Nam hoc
                QC.DieukienThoihoc_Ngunghoc_TheoNam(dt_NamHoc, Nam_hoc, Ly_do_NgungHoc1, Ly_do2, Ly_do3)

                '3. Neu So hoc trinh cua cac mon co diem <5 tinh toi thoi diem hien tai (TongSo_DVHT_coDiem_duoi5)>25 hoặc >20 tuỳ từng quy chế ĐVHT thi ngung hoc
                If SoHTdiemDuoi5 > QC.TongSo_DVHT_coDiem_duoi5 Then Ly_do_NgungHoc2 = "Có khối lượng HP điểm<5 tính từ đầu khoá học " & SoHTdiemDuoi5 & ">" & QC.TongSo_DVHT_coDiem_duoi5 & " đvHT"

                '-----------Gan cac ly do vao dt-------------
                'Thoi hoc
                If Ly_do1.Trim <> "" Or Ly_do2.Trim <> "" Or Ly_do3.Trim <> "" Then
                    Dim dr_thoihoc As DataRow = mdtThoiHoc.NewRow
                    dr_thoihoc("Chon") = False
                    dr_thoihoc("ID_sv") = dr("ID_SV")
                    dr_thoihoc("Ma_sv") = dr("Ma_sv")
                    dr_thoihoc("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_thoihoc("Ngay_sinh") = dr("Ngay_sinh")
                    dr_thoihoc("ID_lop") = dr("ID_lop")
                    dr_thoihoc("Ten_lop") = dr("Ten_lop")
                    If Ly_do1.Trim <> "" Then dr_thoihoc("Ly_do1") = Ly_do1
                    If Ly_do2.Trim <> "" Then dr_thoihoc("Ly_do2") = Ly_do2
                    If Ly_do3.Trim <> "" Then dr_thoihoc("Ly_do3") = Ly_do3
                    mdtThoiHoc.Rows.Add(dr_thoihoc)
                End If
                'Ngung hoc
                If Ly_do_NgungHoc1.Trim <> "" Or Ly_do_NgungHoc2.Trim <> "" Then
                    Dim dr_ngunghoc As DataRow = mdtNgungHoc.NewRow
                    dr_ngunghoc("Chon") = False
                    dr_ngunghoc("ID_sv") = dr("ID_SV")
                    dr_ngunghoc("Ma_sv") = dr("Ma_sv")
                    dr_ngunghoc("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_ngunghoc("Ngay_sinh") = dr("Ngay_sinh")
                    dr_ngunghoc("ID_lop") = dr("ID_lop")
                    dr_ngunghoc("Ten_lop") = dr("Ten_lop")
                    If Ly_do_NgungHoc1.Trim <> "" Then dr_ngunghoc("Ly_do1") = Ly_do_NgungHoc1
                    If Ly_do_NgungHoc2.Trim <> "" Then dr_ngunghoc("Ly_do2") = Ly_do_NgungHoc2
                    mdtNgungHoc.Rows.Add(dr_ngunghoc)
                End If
                'Hoc tiep
                If Ly_do1.Trim = "" And Ly_do2.Trim = "" And Ly_do3.Trim = "" And Ly_do_NgungHoc1.Trim = "" And Ly_do_NgungHoc2.Trim = "" Then
                    Dim dr_hoctiep As DataRow = mdtHocTiep.NewRow
                    dr_hoctiep("Chon") = False
                    dr_hoctiep("ID_sv") = dr("ID_SV")
                    dr_hoctiep("Ma_sv") = dr("Ma_sv")
                    dr_hoctiep("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_hoctiep("Ngay_sinh") = dr("Ngay_sinh")
                    dr_hoctiep("ID_lop") = dr("ID_lop")
                    dr_hoctiep("Ten_lop") = dr("Ten_lop")
                    mdtHocTiep.Rows.Add(dr_hoctiep)
                End If
            Next

            'Duyet tung lop de dem so sinh vien hoc tiep, ngung hoc, thoi hoc
            Dim dtMain As New DataTable
            dtMain = dtLop.Copy
            dtMain.Columns.Add("Hoc_tiep", GetType(String))
            dtMain.Columns.Add("Ngung_hoc", GetType(String))
            dtMain.Columns.Add("Thoi_hoc", GetType(String))
            For l As Integer = 0 To dtMain.Rows.Count - 1
                mdtHocTiep.DefaultView.RowFilter = "1=1"
                mdtNgungHoc.DefaultView.RowFilter = "1=1"
                mdtThoiHoc.DefaultView.RowFilter = "1=1"
                mdtHocTiep.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")
                mdtNgungHoc.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")
                mdtThoiHoc.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")

                dtMain.Rows(l).Item("Hoc_tiep") = mdtHocTiep.DefaultView.Count
                dtMain.Rows(l).Item("Ngung_hoc") = mdtNgungHoc.DefaultView.Count
                dtMain.Rows(l).Item("Thoi_hoc") = mdtThoiHoc.DefaultView.Count
            Next

            dtHocTiep = mdtHocTiep.Copy
            dtThoiHoc = mdtThoiHoc.Copy
            dtNgungHoc = mdtNgungHoc.Copy
            Return dtMain
        End Function
        Public Function KetQua_XetLenLop40(ByVal dtLop As DataTable, ByVal Nam_hoc As String, ByRef dtHocTiep As DataTable, ByRef dtNgungHoc As DataTable, ByRef dtThoiHoc As DataTable) As DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHP As Double
            Dim dr As DataRow
            Dim mdtHocTiep, mdtNgungHoc, mdtThoiHoc As New DataTable

            mdtHocTiep.Columns.Add("ID_sv", GetType(Integer))
            mdtHocTiep.Columns.Add("Ma_sv", GetType(String))
            mdtHocTiep.Columns.Add("Ho_ten", GetType(String))
            mdtHocTiep.Columns.Add("Ngay_sinh", GetType(Date))
            mdtHocTiep.Columns.Add("ID_lop", GetType(Integer))
            mdtHocTiep.Columns.Add("Ten_lop", GetType(String))
            mdtHocTiep.Columns.Add("ID_lop_cu", GetType(Integer))
            mdtHocTiep.Columns.Add("Chon", GetType(Boolean))

            mdtNgungHoc = mdtHocTiep.Clone
            mdtNgungHoc.Columns.Add("Ly_do1", GetType(String))
            mdtNgungHoc.Columns.Add("Ly_do2", GetType(String))
            mdtThoiHoc = mdtHocTiep.Clone
            mdtThoiHoc.Columns.Add("Ly_do1", GetType(String))
            mdtThoiHoc.Columns.Add("Ly_do2", GetType(String))
            mdtThoiHoc.Columns.Add("Ly_do3", GetType(String))

            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In mdtDanhSachSinhVien.Rows
                Dim SoHTdiemDuoi5 As Integer = 0
                'Add cac nam hoc vao dt de kiem tra theo dieu kien hoc tap cua nam hoc
                Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
                Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
                Dim dt_NamHoc As New DataTable
                dt_NamHoc.Columns.Add("Nam_hoc", GetType(String))
                dt_NamHoc.Columns.Add("TBCHT_Nam", GetType(Double))
                dt_NamHoc.Columns.Add("TBCHT_SauXNam", GetType(Double))

                For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
                    Dim dr_kh As DataRow
                    dr_kh = dt_NamHoc.NewRow

                    If Nam_hoc = i & "-" & i + 1 Then
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_NamHoc.Rows.Add(dr_kh)
                        Exit For
                    Else
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_NamHoc.Rows.Add(dr_kh)
                    End If
                Next

                'Tao dt de luu diem theo tung Nam Hoc
                Dim dt_LuuDiemNam As New DataTable
                dt_LuuDiemNam.Columns.Add("Nam_hoc", GetType(String))
                dt_LuuDiemNam.Columns.Add("Diem", GetType(Double))
                dt_LuuDiemNam.Columns.Add("So_tc", GetType(Double))

                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Dim ID_dt As Integer = 0

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    ID_dt = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_dt
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            'Chỉ tổng hợp những năm hiện tại
                            If diem.Nam_hoc <= Nam_hoc Then
                                TBCHP = diem.dsDiemThi.TBCHP_max
                                'Tính Số học trình tích luỹ
                                If TBCHP >= 0 Then
                                    Tong_diem += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                '************************
                                'Luu vao dt nay de sau nay tinh diem TBCHT nam hoc 
                                If TBCHP >= 0 Then
                                    Dim dr_CheckKy As DataRow = dt_LuuDiemNam.NewRow
                                    dr_CheckKy("Nam_hoc") = diem.Nam_hoc
                                    dr_CheckKy("Diem") = TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr_CheckKy("So_TC") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dt_LuuDiemNam.Rows.Add(dr_CheckKy)
                                    If TBCHP < 5 Then SoHTdiemDuoi5 += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                            End If
                        End If
                    End If
                Next
                ' Tinh diem TBCHT nam hoc
                Dim TBCHT_AllNam As Double = 0
                Dim So_hoc_trinh_All As Integer = 0
                For j As Integer = 0 To dt_NamHoc.Rows.Count - 1
                    If dt_NamHoc.Rows(j).Item("Nam_hoc") <= Nam_hoc Then
                        Dim TBCHT_Nam As Double = 0
                        Dim So_hoc_trinh As Integer = 0
                        dt_LuuDiemNam.DefaultView.RowFilter = "Nam_hoc='" & dt_NamHoc.Rows(j).Item("Nam_hoc") & "'"
                        For i As Integer = 0 To dt_LuuDiemNam.DefaultView.Count - 1
                            TBCHT_Nam += dt_LuuDiemNam.DefaultView.Item(i)("Diem")
                            So_hoc_trinh += dt_LuuDiemNam.DefaultView.Item(i)("So_TC")
                        Next
                        If So_hoc_trinh > 0 Then
                            TBCHT_Nam = Me.QC.DiemTBCHT_lam_tron(((TBCHT_Nam / So_hoc_trinh)))
                            dt_NamHoc.Rows(j).Item("TBCHT_Nam") = TBCHT_Nam
                        Else
                            dt_NamHoc.Rows(j).Item("TBCHT_Nam") = 0
                        End If
                        TBCHT_AllNam += TBCHT_Nam
                        So_hoc_trinh_All += So_hoc_trinh
                        ' Neu la 2 nam hoc dau Add vao Nam de xet TBCHT 2 nam dau < 4 thi thoi hoc
                        If j = 1 AndAlso So_hoc_trinh_All > 0 Then
                            dt_NamHoc.Rows(j).Item("TBCHT_SauXNam") = QC.DiemTBCHT_lam_tron(((TBCHT_AllNam / So_hoc_trinh_All)))
                        End If
                        ' Neu la 3 nam hoc dau Add vao Nam de xet TBCHT 2 nam dau < 4.5 thi thoi hoc
                        If j = 2 AndAlso So_hoc_trinh_All > 0 Then
                            dt_NamHoc.Rows(j).Item("TBCHT_SauXNam") = QC.DiemTBCHT_lam_tron(((TBCHT_AllNam / So_hoc_trinh_All)))
                        End If
                        ' Neu la >=4 nam hoc dau Add vao Nam de xet TBCHT 2 nam dau < 4.8 thi thoi hoc
                        If j >= 3 AndAlso So_hoc_trinh_All > 0 Then
                            dt_NamHoc.Rows(j).Item("TBCHT_SauXNam") = QC.DiemTBCHT_lam_tron(((TBCHT_AllNam / So_hoc_trinh_All)))
                        End If
                    End If
                Next

                'Kiem tra cac dieu kien cho sinh vien Hoc tiep, Ngung hoc, Thoi hoc

                '1. Check thời gian hoàn thành chương trình đào tạo
                Dim Ly_do1, Ly_do2, Ly_do3, Ly_do_NgungHoc1, Ly_do_NgungHoc2 As String
                Ly_do1 = ""
                Ly_do2 = ""
                Ly_do3 = ""
                Ly_do_NgungHoc1 = ""
                Ly_do_NgungHoc2 = ""
                Dim cls As ChuongTrinhDaoTao_BLL
                cls = New ChuongTrinhDaoTao_BLL(dr("ID_dt"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                'Con phai check tru di thoi gian ngung hoc co ly do nua moi OK :)

                If So_ky_ToiDa < So_ky_hienTai Then Ly_do1 = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa

                '2. Check theo Nam hoc
                For i As Integer = 0 To dt_NamHoc.Rows.Count - 1
                    If dt_NamHoc.Rows(i).Item("Nam_hoc") <= Nam_hoc Then
                        '-	Nam hien tai TBCHT < 4 thi thoi hoc; 4<=TBCHT nam hien tai <5 thi ngung hoc
                        If Nam_hoc = dt_NamHoc.Rows(i).Item("Nam_hoc") AndAlso dt_NamHoc.Rows(i).Item("TBCHT_Nam").ToString.Trim <> "" Then
                            If dt_NamHoc.Rows(i).Item("TBCHT_Nam") < 4 Then Ly_do2 = dt_NamHoc.Rows(i).Item("TBCHT_Nam") & "<4"
                            If dt_NamHoc.Rows(i).Item("TBCHT_Nam") >= 4 And dt_NamHoc.Rows(i).Item("TBCHT_Nam") < 5 Then Ly_do_NgungHoc1 = "4<=" & dt_NamHoc.Rows(i).Item("TBCHT_Nam").ToString & "<5"
                        End If
                        '- Tu dau khoa hoc co TBCHT < 4.5 
                        If dt_NamHoc.Rows(i).Item("Nam_hoc") = Nam_hoc AndAlso dt_NamHoc.Rows(i).Item("TBCHT_SauXNam").ToString.Trim <> "" Then
                            If CType(dt_NamHoc.Rows(i).Item("TBCHT_SauXNam"), Double) < 4.5 Then Ly_do3 = dt_NamHoc.Rows(i).Item("TBCHT_SauXNam").ToString & "<4.5"
                        End If
                    End If
                Next

                '3. Neu So hoc trinh cua cac mon co diem <5 tinh toi thoi diem hien tai >25 dv HT thi ngung hoc
                If SoHTdiemDuoi5 > 20 Then Ly_do_NgungHoc2 = "Có khối lượng HP điểm<5 tính từ đầu khoá học " & SoHTdiemDuoi5 & ">20 đvHT"

                '-----------Gan cac ly do vao dt-------------
                'Thoi hoc
                If Ly_do1.Trim <> "" Or Ly_do2.Trim <> "" Or Ly_do3.Trim <> "" Then
                    Dim dr_thoihoc As DataRow = mdtThoiHoc.NewRow
                    dr_thoihoc("Chon") = False
                    dr_thoihoc("ID_sv") = dr("ID_SV")
                    dr_thoihoc("Ma_sv") = dr("Ma_sv")
                    dr_thoihoc("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_thoihoc("Ngay_sinh") = dr("Ngay_sinh")
                    dr_thoihoc("ID_lop") = dr("ID_lop")
                    dr_thoihoc("Ten_lop") = dr("Ten_lop")
                    If Ly_do1.Trim <> "" Then dr_thoihoc("Ly_do1") = Ly_do1
                    If Ly_do2.Trim <> "" Then dr_thoihoc("Ly_do2") = Ly_do2
                    If Ly_do3.Trim <> "" Then dr_thoihoc("Ly_do3") = Ly_do3
                    mdtThoiHoc.Rows.Add(dr_thoihoc)
                End If
                'Ngung hoc
                If Ly_do_NgungHoc1.Trim <> "" Or Ly_do_NgungHoc2.Trim <> "" Then
                    Dim dr_ngunghoc As DataRow = mdtNgungHoc.NewRow
                    dr_ngunghoc("Chon") = False
                    dr_ngunghoc("ID_sv") = dr("ID_SV")
                    dr_ngunghoc("Ma_sv") = dr("Ma_sv")
                    dr_ngunghoc("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_ngunghoc("Ngay_sinh") = dr("Ngay_sinh")
                    dr_ngunghoc("ID_lop") = dr("ID_lop")
                    dr_ngunghoc("Ten_lop") = dr("Ten_lop")
                    If Ly_do_NgungHoc1.Trim <> "" Then dr_ngunghoc("Ly_do1") = Ly_do_NgungHoc1
                    If Ly_do_NgungHoc2.Trim <> "" Then dr_ngunghoc("Ly_do2") = Ly_do_NgungHoc2
                    mdtNgungHoc.Rows.Add(dr_ngunghoc)
                End If
                'Hoc tiep
                If Ly_do1.Trim = "" And Ly_do2.Trim = "" And Ly_do3.Trim = "" And Ly_do_NgungHoc1.Trim = "" And Ly_do_NgungHoc2.Trim = "" Then
                    Dim dr_hoctiep As DataRow = mdtHocTiep.NewRow
                    dr_hoctiep("Chon") = False
                    dr_hoctiep("ID_sv") = dr("ID_SV")
                    dr_hoctiep("Ma_sv") = dr("Ma_sv")
                    dr_hoctiep("Ho_ten") = dr("Ho_ten")
                    If dr("Ngay_sinh").ToString <> "" Then dr_hoctiep("Ngay_sinh") = dr("Ngay_sinh")
                    dr_hoctiep("ID_lop") = dr("ID_lop")
                    dr_hoctiep("Ten_lop") = dr("Ten_lop")
                    mdtHocTiep.Rows.Add(dr_hoctiep)
                End If
            Next

            'Duyet tung lop de dem so sinh vien hoc tiep, ngung hoc, thoi hoc
            Dim dtMain As New DataTable
            dtMain = dtLop.Copy
            dtMain.Columns.Add("Hoc_tiep", GetType(String))
            dtMain.Columns.Add("Ngung_hoc", GetType(String))
            dtMain.Columns.Add("Thoi_hoc", GetType(String))
            For l As Integer = 0 To dtMain.Rows.Count - 1
                mdtHocTiep.DefaultView.RowFilter = "1=1"
                mdtNgungHoc.DefaultView.RowFilter = "1=1"
                mdtThoiHoc.DefaultView.RowFilter = "1=1"
                mdtHocTiep.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")
                mdtNgungHoc.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")
                mdtThoiHoc.DefaultView.RowFilter = "ID_lop=" & dtMain.Rows(l).Item("ID_lop")

                dtMain.Rows(l).Item("Hoc_tiep") = mdtHocTiep.DefaultView.Count
                dtMain.Rows(l).Item("Ngung_hoc") = mdtNgungHoc.DefaultView.Count
                dtMain.Rows(l).Item("Thoi_hoc") = mdtThoiHoc.DefaultView.Count
            Next

            dtHocTiep = mdtHocTiep.Copy
            dtThoiHoc = mdtThoiHoc.Copy
            dtNgungHoc = mdtNgungHoc.Copy
            Return dtMain
        End Function

        Function XetLuanVan(ByVal TBCTL As Double) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT As Double, TBCHP As Double, So_mon_no As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("Chon1", GetType(Boolean))
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            Dim clsXetMon As New DanhSachTotNghiep_DAL
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                dr("Chon1") = False

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False And dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Mon_thi_TN = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            TBCHP = diem.dsDiemThi.TBCHP_max
                            If TBCHP >= 0 Then
                                Tong_diem10 += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            'Tính số môn nợ
                            If TBCHP < 5 Then So_mon_no += 1
                        End If
                    End If
                Next
                'Kiem tra cac hoc phan bat buoc da hoc (Tru cac hoc phan thi TN)
                Dim dt_check_mon As DataTable = clsXetMon.Check_MonBatBuoc_SV_List(dr("ID_SV"), mID_dv, 0, False)
                Dim Ly_do As String = ""
                For j As Integer = 0 To dt_check_mon.Rows.Count - 1
                    If Ly_do.Trim = "" Then
                        Ly_do = dt_check_mon.Rows(j).Item("Ten_mon").ToString
                    Else
                        Ly_do += ", " & dt_check_mon.Rows(j).Item("Ten_mon").ToString
                    End If
                Next
                dr("Ly_do") = ""
                If Ly_do.Trim <> "" Then dr("Ly_do") = "Chưa có điểm môn bắt buộc: " & Ly_do.Trim
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem10 / Tong_so_hoc_trinh
                    dr("TBCHT") = QC.DiemTBCHT_lam_tron(TBCHT)
                    dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr("Xep_hang") = dsXepHangTotNghiep.XepHangTotNghiep(TBCHT, False)
                    dr("So_mon_no") = So_mon_no
                    dr("So_hoc_trinh") = Tong_so_hoc_trinh
                End If
            Next
            dtTongHop.DefaultView.RowFilter = "TBCHT>=" & TBCTL & " AND So_mon_no=0 AND Ly_do=''"
            Return dtTongHop
        End Function

        Function TongHop_XetThiNoThiTotNghiep() As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT As Double, TBCHP As Double, So_mon_no As Integer
            Dim clsXetMon As New DanhSachTotNghiep_DAL
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            Dim Ly_do As String = ""
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Ly_do = ""
                Dim Nam_hoc As String = CType(Right(dr("Nien_khoa"), 4), Integer) - 1 & "-" & CType(Right(dr("Nien_khoa"), 4), Integer)

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ''Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False And dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Mon_thi_TN = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            TBCHP = diem.dsDiemThi.TBCHP_max
                            If TBCHP >= 0 Then
                                Tong_diem += TBCHP * dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            'Tính số môn nợ
                            If TBCHP < 5 Then
                                So_mon_no += 1
                                If Ly_do.Trim = "" Then
                                    Ly_do = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ten_mon & "(" & Math.Round(TBCHP, QC.TBCHP_lam_tron) & ")"
                                Else
                                    Ly_do += "," & dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Ten_mon & "(" & Math.Round(TBCHP, QC.TBCHP_lam_tron) & ")"
                                End If
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem / Tong_so_hoc_trinh
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr("Xep_hang") = dsXepHangTotNghiep.XepHangTotNghiep(TBCHT, False)
                    If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                    dr("So_hoc_trinh") = Tong_so_hoc_trinh
                Else
                    Ly_do = "Chưa có điểm TBCHT"
                End If

                'Kiem tra cac hoc phan bat buoc da hoc (Tru cac hoc phan thi TN)
                Dim dt_check_mon As DataTable = clsXetMon.Check_MonBatBuoc_SV_List(dr("ID_SV"), mID_dv, 0, False)
                Dim Ly_do_mon As String = ""
                For j As Integer = 0 To dt_check_mon.Rows.Count - 1
                    If Ly_do_mon.Trim = "" Then
                        Ly_do_mon = dt_check_mon.Rows(j).Item("Ky_hieu").ToString
                    Else
                        Ly_do_mon += ", " & dt_check_mon.Rows(j).Item("Ky_hieu").ToString
                    End If
                Next
                If Ly_do_mon.Trim <> "" Then Ly_do = Ly_do & " - Chưa có điểm môn bắt buộc: " & Ly_do_mon.Trim
                If Ly_do.Trim <> "" Then dr("Ly_do") = Ly_do
            Next
            Return dtTongHop
        End Function

        Function ChuyenThi_LuanVan(ByVal ID_SV As Integer) As DataTable
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh, So_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double, So_mon_no As Integer, So_tin_chi As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            'Add cac cot diem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                So_tin_chi = 0
                dr("Chon1") = False

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim diem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim diem As Diem = arrDiem(idx_diem)
                            Diem_so = diem.dsDiemThi.TBCHP_max
                            If (Diem_so > 0) Then
                                Tong_diem = (Tong_diem + (Diem_so * Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh))
                                Tong_so_hoc_trinh = (Tong_so_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                            End If
                            So_hoc_trinh = (So_hoc_trinh + Me.dsMonHoc.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh)
                            If diem.dsDiemThi.TBCHP_max < QC.Diem_hoc_phan_dat Then So_mon_no += 1
                            If (Diem_so >= 0) Then
                                dr.Item(("M" & ID_mon.ToString)) = Diem_so.ToString
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If (Tong_so_hoc_trinh > 0) Then
                    TBCHT = (Tong_diem / Tong_so_hoc_trinh)
                    dr.Item("TBCHT") = Strings.Format(TBCHT, "##.00")
                    dr.Item("ID_xep_loai") = Me.dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr.Item("Xep_hang") = Me.dsXepHangTotNghiep.XepHangTotNghiep(TBCHT, False)
                    dr.Item("So_mon_no") = So_mon_no
                    dr.Item("So_hoc_trinh") = So_hoc_trinh
                End If
            Next
            dtTongHop.DefaultView.RowFilter = "ID_SV=" & ID_SV
            Return dtTongHop
        End Function

        Public Function DanhSachKhongDuDieuKienDuThiHocPhan(ByVal Lan_hoc As Integer, ByVal ID_mon As Integer) As DataTable
            Dim dtKDDKThi As DataTable = mdtDanhSachSinhVien.Copy
            Dim idx As Integer
            dtKDDKThi.Columns.Add("Ly_do", GetType(String))
            For r As Integer = dtKDDKThi.Rows.Count - 1 To 0 Step -1
                idx = Tim_idx(dtKDDKThi.Rows(r)("ID_sv"), ID_mon)
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                    'Kiểm tra xem có đủ điều kiện dự thi không
                    If objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc) > 0 Then
                        dtKDDKThi.Rows(r)("Ly_do") = objDiem.dsDiemKhongDuDKThi.Ly_do_khong_du_dieu_kien_thi_lan(Lan_hoc)
                    Else
                        dtKDDKThi.Rows(r).Delete()
                    End If
                Else
                    dtKDDKThi.Rows(r).Delete()
                End If
            Next
            dtKDDKThi.AcceptChanges()
            Return dtKDDKThi
        End Function

        Public Sub KeThuaDiemNganh1ChoNganh2(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal ID_diem As Integer)
            Dim idx As Integer = -1
            idx = Tim_idx(ID_sv, ID_mon)
            If idx >= 0 Then
                Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                    Dim objDiemTP As New DiemThanhPhan
                    objDiemTP = objDiem.dsDiemThanhPhan.DiemThanhPhan(i)
                    Insert_DiemThanhPhan(ID_diem, objDiemTP)
                Next
                For i As Integer = 0 To objDiem.dsDiemThi.Count - 1
                    Dim objDiemThi As New DiemThi
                    objDiem.dsDiemThi.DiemThi(i).Ghi_chu = "R"
                    objDiemThi = objDiem.dsDiemThi.DiemThi(i)
                    Insert_DiemThi(ID_diem, objDiemThi)
                Next
            End If
        End Sub

        Public Sub XoaDiemKeThuaDiemNganh1ChoNganh2(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal ID_diem As Integer, ByVal Lan_hoc As Integer)
            Dim idx As Integer = -1
            idx = Tim_idx(ID_sv, ID_mon)
            If idx >= 0 Then
                Dim objDiem As Diem = CType(arrDiem(idx), Diem)
                For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                    Delete_DiemThanhPhan(ID_diem, objDiem.dsDiemThanhPhan.DiemThanhPhan(i).ID_thanh_phan, Lan_hoc)
                Next
                For i As Integer = 0 To objDiem.dsDiemThi.Count - 1
                    Delete_DiemThi(ID_diem, Lan_hoc, objDiem.dsDiemThi.DiemThi(i).Lan_thi)
                Next
            End If
        End Sub
#End Region

#Region "Nhập điểm từ Excel"
        Private Function NewTable() As DataTable
            Dim dt As New DataTable
            Dim Col1 As New DataColumn("ID_sv", GetType(String))
            Dim Col2 As New DataColumn("Ma_sv", GetType(String))
            Dim Col3 As New DataColumn("Hoc_ky", GetType(Long))
            Dim Col4 As New DataColumn("Nam_hoc", GetType(String))
            Dim Col5 As New DataColumn("Lan_thi", GetType(Long))
            Dim Col6 As New DataColumn("ID_dv", GetType(String))
            Dim Col7 As New DataColumn("ID_mon", GetType(Long))
            Dim Col8 As New DataColumn("ID_thanh_phan", GetType(Long))
            Dim Col9 As New DataColumn("Ty_le", GetType(Long))
            Dim Col10 As New DataColumn("Diem", GetType(String))
            Dim Col11 As New DataColumn("Ghi_chu", GetType(String))
            Dim Col12 As New DataColumn("ID_dt", GetType(String))
            Dim Col13 As New DataColumn("Ho_ten", GetType(String))
            Dim Col14 As New DataColumn("Ten_lop", GetType(String))
            Dim Col15 As New DataColumn("Hoten_Order", GetType(String))
            Dim Col16 As New DataColumn("Locked", GetType(Byte))
            Dim Col17 As New DataColumn("ID_diem", GetType(Long))
            Dim Col18 As New DataColumn("ID_diem_main", GetType(Long))
            dt.Columns.Add(Col1)
            dt.Columns.Add(Col2)
            dt.Columns.Add(Col3)
            dt.Columns.Add(Col4)
            dt.Columns.Add(Col5)
            dt.Columns.Add(Col6)
            dt.Columns.Add(Col7)
            dt.Columns.Add(Col8)
            dt.Columns.Add(Col9)
            dt.Columns.Add(Col10)
            dt.Columns.Add(Col11)
            dt.Columns.Add(Col12)
            dt.Columns.Add(Col13)
            dt.Columns.Add(Col14)
            dt.Columns.Add(Col15)
            dt.Columns.Add(Col16)
            dt.Columns.Add(Col17)
            dt.Columns.Add(Col18)
            Return dt
        End Function

        Private Sub getThongtin_sinhvien(ByVal Ma_sv As String, ByVal ID_mon As Integer, ByRef ID_sv As String, ByRef Ho_ten As String, ByRef ID_dt As String, ByRef Ten_lop As String)
            Dim clsDAL As New Diem_DAL
            Dim dt As DataTable = clsDAL.getSinhVienInfor_DiemExcel(ID_mon, Ma_sv)

            If dt Is Nothing Then Exit Sub
            If dt.Rows.Count > 0 Then
                ID_sv = dt.Rows(0).Item("ID_sv")
                Ho_ten = IIf(IsDBNull(dt.Rows(0).Item("Ho_ten")), "", dt.Rows(0).Item("Ho_ten"))
                ID_dt = IIf(IsDBNull(dt.Rows(0).Item("ID_dt")), "", dt.Rows(0).Item("ID_dt"))
                Ten_lop = IIf(IsDBNull(dt.Rows(0).Item("Ten_lop")), "", dt.Rows(0).Item("Ten_lop"))
            Else
                ID_sv = ""
                Ho_ten = ""
                ID_dt = ""
                Ten_lop = ""
            End If

            ''Get theo thông tin ngành 2
            'If ID_dt = "0" Or ID_dt = "" Then ID_dt = clsDAL.getID_DT2_DiemExcel(ID_mon, Ma_sv)
            If ID_dt = "0" Then ID_dt = ""
        End Sub
        Private Sub AddRowTable(ByRef dt As DataTable, ByVal ID_sv As String, ByVal Ma_sv As String, ByVal Hoc_ky As Byte, ByVal Nam_hoc As String, ByVal Lan_thi As Byte, ByVal ID_dv As String, ByVal ID_mon As Long, ByVal ID_thanh_phan As Long, ByVal Ty_le As Byte, ByVal Diem As String, ByVal Ghi_chu As String, ByVal ID_dt As String, ByVal Ho_ten As String, ByVal Ten_lop As String, ByVal Locked As Byte, ByVal ID_diem As Long, ByVal ID_diem_main As Long)
            dt.DefaultView.Sort = "ID_sv"
            If dt.DefaultView.Find(ID_sv) < 0 Then
                Dim dr As DataRow
                dr = dt.NewRow
                dr.Item("ID_sv") = ID_sv
                dr.Item("Ma_sv") = Ma_sv
                dr.Item("Hoc_ky") = Hoc_ky
                dr.Item("Nam_hoc") = Nam_hoc
                dr.Item("Lan_thi") = Lan_thi
                dr.Item("ID_dv") = ID_dv
                dr.Item("ID_mon") = ID_mon
                dr.Item("ID_thanh_phan") = ID_thanh_phan
                dr.Item("Ty_le") = Ty_le
                dr.Item("Diem") = Diem
                dr.Item("Ghi_chu") = Ghi_chu
                dr.Item("ID_dt") = ID_dt
                dr.Item("Ho_ten") = Ho_ten
                dr.Item("Hoten_Order") = "" 'ConvertToNumber(strUnicode, Ho_ten)
                dr.Item("Ten_lop") = Ten_lop
                dr.Item("Locked") = Locked
                dr.Item("ID_diem") = ID_diem
                dr.Item("ID_diem_main") = ID_diem_main
                dt.Rows.Add(dr)
                dt.AcceptChanges()
            End If
        End Sub

        Private Function getDiem_Sinhvien(ByVal ID_dv As String, ByVal ID_sv As Long, ByVal ID_mon As Long) As DataTable
            Dim cls As New Diem_DAL
            Return cls.getDiemSinhVien_DiemExcel(ID_sv, ID_mon, ID_dv)
        End Function
        Function getDiemTP_Sinhvien(ByVal ID_dv As String, ByVal ID_sv As Long, ByVal ID_mon As Long, ByVal ID_thanh_phan As Integer) As DataTable
            Dim cls As New Diem_DAL
            Return cls.getDiemThanhPhanSinhVien_DiemExcel(ID_sv, ID_mon, ID_thanh_phan, ID_dv)
        End Function
        Public Function Load_DiemKyHieu_List() As DataTable
            Try
                Dim cls As New Diem_DAL
                Dim dt As DataTable = cls.Load_DiemKyHieu_List
                'Bổ sung thêm một dòng trắng
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Ky_hieu") = ""
                dt.Rows.Add(dr)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Check_DiemLanThi(ByVal Lan_thi As Integer, ByVal dt As DataTable) As String
            Dim Ly_do As String = ""
            For i As Integer = 0 To dt.Rows.Count - 1
                If Lan_thi = 2 Then
                    If dt.Rows(i).Item("Lan_thi") = 1 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then Ly_do = "Chưa có điểm thi lần 1"
                End If
                If Lan_thi = 3 Then
                    If dt.Rows(i).Item("Lan_thi") = 1 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then Ly_do = "Chưa có điểm thi lần 1"
                    If dt.Rows(i).Item("Lan_thi") = 2 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then
                        If Ly_do.Trim = "" Then
                            Ly_do = "Chưa có điểm thi lần 1"
                        Else
                            Ly_do = "Chưa có điểm thi lần 1 và lần 2"
                        End If
                    End If
                End If
            Next
            Return Ly_do
        End Function


        Public Sub Update_data(ByVal dt As DataTable, ByVal ID_dv As String, ByVal Hoc_ky As String, ByVal Nam_hoc As String, ByVal Lan_thi As Byte, _
                                              ByVal ID_mon As Long, ByVal FieldMa As String, ByVal FieldDiem As String, _
                                              ByRef dtDiem_TonTai As DataTable, ByRef dtDiem_MoiTonTai As DataTable, ByRef dtDiem_Sai As DataTable, ByRef dtDiem_MoiChuan As DataTable, _
                                               Optional ByVal ID_thanh_phan As Long = 0, Optional ByVal Ty_le As Long = 0)
            Dim i As Long
            Dim ID_sv, Ma_sv, Ho_ten, Ten_lop, ID_dt As String
            dtDiem_TonTai = NewTable()
            dtDiem_MoiTonTai = dtDiem_TonTai.Clone
            dtDiem_Sai = dtDiem_TonTai.Clone
            dtDiem_MoiChuan = dtDiem_TonTai.Clone

            For i = 0 To dt.Rows.Count - 1
                With dt.Rows(i)
                    Ma_sv = IIf(IsDBNull(.Item(FieldMa)), "", .Item(FieldMa))
                    If Trim(Ma_sv) <> "" Then
                        getThongtin_sinhvien(Ma_sv, ID_mon, ID_sv, Ho_ten, ID_dt, Ten_lop)
                        If Trim(ID_sv) <> "" Then
                            Dim Diem As String = IIf(IsDBNull(.Item(FieldDiem)), "", .Item(FieldDiem))
                            If Trim(Diem) = "" Then 'Du lieu diem khong hop le, do chưa có điểm
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Chưa có điểm", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf Not IsNumeric(Diem) Then 'Du lieu diem khong hop le do sai định dạng
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu điểm phải là giá trị số", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf CType(Diem, Double) > 10 Or CType(Diem, Double) < 0 Then 'Du lieu diem khong hop le do sai khung điểm chuẩn
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu điểm phải >=0 và <=10", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf ID_dt = "" Then 'Du lieu diem môn này không có trong CTrĐT của sinh viên
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Môn học này chưa có trong Chương trình đào tạo của sinh viên", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            Else 'Du lieu diem hop le theo điểm thành phần
                                If ID_thanh_phan = 0 Then 'Khong co diem thanh phan
                                    Dim dt_checkDulieu_Tontai As DataTable = getDiem_Sinhvien(ID_dv, CType(ID_sv, Long), ID_mon)
                                    Dim f As Boolean = False
                                    For c As Integer = 0 To dt_checkDulieu_Tontai.Rows.Count - 1
                                        'Load tat ca cac lan diem; Co the chi ton tai diem Main con diem thi thi chua va nguoc lai
                                        If dt_checkDulieu_Tontai.Rows(c).Item("ID_diem").ToString.Trim <> "" Then f = True
                                    Next
                                    If dt_checkDulieu_Tontai.Rows.Count > 0 AndAlso f Then  'Đã tồn tại dữ liệu
                                        If Lan_thi = 2 Then
                                            'Kiem tra import diem Lan 2 ma chua co diem lan 1 thi canh bao => du lieu sai
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count = 0 Then 'Chua co diem thi Lan 1
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Chưa có điểm thi lần 1", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                End If
                                            Else 'Dữ liệu ton tai hợp lý
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                                Dim ID_diem_main As Integer = 0
                                                If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then ID_diem_main = dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main")
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=2"
                                                If ID_diem_main > 0 Then 'Moi ton tai diem Main hoac diem Thanh phan chu' chua co diem thi
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, ID_diem_main)
                                                    End If
                                                Else 'Nhap moi hoan toan
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                    End If
                                                End If
                                            End If
                                        ElseIf Lan_thi = 3 Then
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            'If drGoal.Item("Diem1").ToString.Trim = "" Or drGoal.Item("Diem2").ToString.Trim = "" Then
                                            '    'Kiem tra import diem Lan 3 ma chua co diem lan 1 va 2 thi canh bao => du lieu sai
                                            '    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Phải chuyển về điểm lần thi 1", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'Else 'Co diem lan 1 va diem lan 2
                                            '    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '        'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            '        Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, drGoal.Item("Diem_thi"), "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'End If
                                        ElseIf Lan_thi = 1 Then
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count > 0 AndAlso dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString.Trim <> "" Then
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                    'Hien thi du lieu da co vao trong dtDiem_TonTai
                                                    Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem_thi").ToString, "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            End If
                                        End If

                                    Else 'Du lieu thanh cong
                                        If Lan_thi = 1 Then
                                            If dt_checkDulieu_Tontai.Rows.Count > 0 Then 'Moi ton tai diem Main hoac diem Thanh phan chu' chua co diem thi
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            Else 'Nhap moi hoan toan
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                End If
                                            End If
                                        Else 'Vi du lieu chua ton tai ma lai chuyen vao diem lan 2 thi la du lieu Sai
                                            dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Phải chuyển về điểm lần thi 1", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                            End If
                                        End If
                                    End If
                                Else 'Với điem thành phần
                                    Dim dt_checkDulieu_Tontai As DataTable
                                    dt_checkDulieu_Tontai = getDiemTP_Sinhvien(ID_dv, CType(ID_sv, Long), ID_mon, 0)
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "ID_thanh_phan=" & ID_thanh_phan
                                    If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then 'Điểm Main va thanh phan đã tồn tại trong CSDL
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                            'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc"), Lan_thi, ID_dv, ID_mon, ID_thanh_phan, dt_checkDulieu_Tontai.DefaultView.Item(0)("Ty_le"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem"), "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked_TP").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                        End If
                                    ElseIf dt_checkDulieu_Tontai.Rows.Count > 0 Then
                                        'Moi chi co diem thi hoac diem Main chu chua co diem thanh phan
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, dt_checkDulieu_Tontai.Rows(0).Item("ID_diem_main").ToString)
                                        End If
                                    Else 'Nhap moi
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, Diem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End With
            Next
        End Sub
#End Region

#Region "Tổng hợp thi lại, học lại"
        Function DanhSach_ToChucThiLai(ByVal dtSub As DataTable) As DataTable
            Dim dt As DataTable = dtSub.Copy
            dt.Columns.Add("TBCBP", GetType(Double))
            dt.Columns.Add("Ghi_chu")
            dt.Columns.Add("Tong_SV_Du_DKDT")
            Return dt
        End Function
        Public Function TongHopHocPhanThiLaiHocLai(ByVal Trang_thai As Integer) As DataTable
            Dim objDiem As Diem
            Dim dtHocPhan As New DataTable
            Dim drHocPhan As DataRow
            Dim So_sv As Integer

            dtHocPhan.Columns.Add("ID_mon", GetType(Integer))
            dtHocPhan.Columns.Add("Ky_hieu", GetType(String))
            dtHocPhan.Columns.Add("Ten_mon", GetType(String))
            dtHocPhan.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtHocPhan.Columns.Add("So_SV", GetType(Integer))
            dtHocPhan.Columns.Add("Khong_tinh_TBCHT", GetType(Boolean))
            For m As Integer = 0 To dsMonHoc.Count - 1
                drHocPhan = dtHocPhan.NewRow
                drHocPhan("ID_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).ID_mon
                drHocPhan("Ky_hieu") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).Ky_hieu
                drHocPhan("Ten_mon") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).Ten_mon
                drHocPhan("So_hoc_trinh") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).So_hoc_trinh
                drHocPhan("Khong_tinh_TBCHT") = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).Khong_tinh_TBCHT
                'Đếm số sinh viên
                So_sv = 0
                For i As Integer = 0 To arrDiem.Count - 1
                    objDiem = CType(arrDiem(i), Diem)
                    If objDiem.ID_mon = dsMonHoc.ChuongTrinhDaoTaoChiTiet(m).ID_mon Then
                        If Trang_thai = 0 Then  'Thi lại
                            If objDiem.dsDiemThiLai.Count > 0 Then
                                So_sv += 1
                            End If
                        Else    'Học lại, không đủ điều kiện dự thi
                            If objDiem.dsDiemHocLai.Count > 0 Or objDiem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(1) > 0 Then
                                So_sv += 1
                            End If
                        End If
                    End If
                Next
                If So_sv > 0 Then
                    drHocPhan("So_SV") = So_sv
                    dtHocPhan.Rows.Add(drHocPhan)
                End If
            Next
            dtHocPhan.AcceptChanges()
            Return dtHocPhan
        End Function
        Function DanhSachThiLaiHocLai(ByVal ID_mon As Integer, ByVal Trang_thai As Integer) As DataTable
            Dim dtTongHop, dt As New DataTable
            Dim idx_diem As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy

            'dt.Columns.Add("Chon", GetType(Boolean))
            'dt.Columns.Add("ID_sv", GetType(Integer))
            'dt.Columns.Add("Ma_sv", GetType(String))
            'dt.Columns.Add("Ho_ten", GetType(String))
            'dt.Columns.Add("Ngay_sinh", GetType(Date))
            'dt.Columns.Add("Ten_lop", GetType(String))
            dt = mdtDanhSachSinhVien.Clone
            dt.Columns.Add("TBCBP", GetType(Double))
            dt.Columns.Add("Ghi_chu")
            dt.Columns.Add("Tong_SV_Du_DKDT")
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                idx_diem = Tim_idx(dtTongHop.Rows(i).Item("ID_sv"), ID_mon)
                If idx_diem >= 0 Then
                    Dim diem As Diem = arrDiem(idx_diem)
                    If Trang_thai = 0 Then
                        If diem.dsDiemThiLai.Thi_lai > 0 Then   'Thi lại
                            dr = dt.NewRow()
                            dr("Chon") = False
                            dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                            dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                            dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                            If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                            dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                            dt.Rows.Add(dr)
                        End If
                    ElseIf Trang_thai = 1 Then 'Hoc lai, không đủ đk dự thi
                        If diem.dsDiemHocLai.Count > 0 Or diem.dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(1) Then
                            dr = dt.NewRow()
                            dr("Chon") = False
                            dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                            dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                            dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                            If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                            dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                            dt.Rows.Add(dr)
                        End If
                    End If
                End If
            Next
            Return dt
        End Function
#End Region

        Public Sub ChayQuery(ByVal Query As String)
            Dim clsDAL As New Diem_DAL
            'clsDAL.ChayQuery(Query)
        End Sub
        Public Function getID_Diem(ByVal ID_dv As String, ByVal ID_mon As Integer, ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.getID_Diem(ID_dv, ID_mon, ID_dt, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetID_DT(ByVal ID_SV As Integer) As Integer
            Try
                Dim obj As Diem_DAL = New Diem_DAL
                Return obj.GetID_DT(ID_SV)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function TongHop_DiemChoHocPhan_Ghep(ByVal ID_lops As String, ByVal ID_dt As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_main As Integer) As DataTable

        End Function

        Function TongHop_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, ByRef dt_main As DataTable) As DataTable
            Try
                Dim obj As DNU_Diem_DAL = New DNU_Diem_DAL
                Dim dt As DataTable = obj.TongHop_HocLai(Hoc_ky, Nam_hoc, ID_he, Khoa_hoc, ID_chuyen_nganh, ID_lops)
                dt_main = dt.Copy
                Dim dt1 As New DataTable
                dt1.Columns.Add("ID_mon", GetType(Integer))
                dt1.Columns.Add("Ky_hieu", GetType(String))
                dt1.Columns.Add("Ten_mon", GetType(String))
                dt1.Columns.Add("So_hoc_trinh", GetType(Double))
                dt1.Columns.Add("So_sv", GetType(Integer))
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("Diem") < 5 Then
                        dt1.DefaultView.RowFilter = "ID_mon=" & dt.Rows(i)("ID_mon")
                        If dt1.DefaultView.Count = 0 Then
                            Dim dr As DataRow
                            dr = dt1.NewRow
                            dr("ID_mon") = dt.DefaultView.Item(i)("ID_mon")
                            dr("Ky_hieu") = dt.DefaultView.Item(i)("Ky_hieu")
                            dr("Ten_mon") = dt.DefaultView.Item(i)("Ten_mon")
                            dr("So_hoc_trinh") = dt.DefaultView.Item(i)("So_hoc_trinh")
                            'dr("So_sv") = dt.DefaultView.Item(i)("So_sv")
                            dt1.Rows.Add(dr)
                        End If
                    End If
                Next
                For i As Integer = 0 To dt1.Rows.Count - 1
                    dt.DefaultView.RowFilter = "Diem<5 AND ID_mon=" & dt1.Rows(i)("ID_mon")
                    dt1.Rows(i)("So_sv") = dt.DefaultView.Count
                Next
                dt.DefaultView.RowFilter = "1=1"
                dt1.DefaultView.RowFilter = "1=1"
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function TongHop_ThiLai(ByVal Lan_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, ByRef dt_main As DataTable) As DataTable
            Try
                Dim obj As DNU_Diem_DAL = New DNU_Diem_DAL
                Dim dt As DataTable = obj.TongHop_ThiLai(Lan_hoc, Hoc_ky, Nam_hoc, ID_he, Khoa_hoc, ID_chuyen_nganh, ID_lops)
                dt_main = dt.Copy
                Dim dt1 As New DataTable
                dt1.Columns.Add("ID_mon", GetType(Integer))
                dt1.Columns.Add("Ky_hieu", GetType(String))
                dt1.Columns.Add("Ten_mon", GetType(String))
                dt1.Columns.Add("So_hoc_trinh", GetType(Double))
                dt1.Columns.Add("So_sv", GetType(Integer))
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("TBCHP") < 5 Then
                        dt1.DefaultView.RowFilter = "ID_mon=" & dt.Rows(i)("ID_mon")
                        If dt1.DefaultView.Count = 0 Then
                            Dim dr As DataRow
                            dr = dt1.NewRow
                            dr("ID_mon") = dt.DefaultView.Item(i)("ID_mon")
                            dr("Ky_hieu") = dt.DefaultView.Item(i)("Ky_hieu")
                            dr("Ten_mon") = dt.DefaultView.Item(i)("Ten_mon")
                            dr("So_hoc_trinh") = dt.DefaultView.Item(i)("So_hoc_trinh")
                            'dr("So_sv") = dt.DefaultView.Item(i)("So_sv")

                            dt1.Rows.Add(dr)
                        End If
                    End If
                Next
                For i As Integer = 0 To dt1.Rows.Count - 1
                    dt.DefaultView.RowFilter = "TBCHP<5 AND ID_mon=" & dt1.Rows(i)("ID_mon")
                    dt1.Rows(i)("So_sv") = dt.DefaultView.Count
                Next
                dt.DefaultView.RowFilter = "1=1"
                dt1.DefaultView.RowFilter = "1=1"
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Load_SinhVien(ByVal dt_main As DataTable, ByVal ID_mon As Integer) As DataTable
            Dim dt As DataTable = dt_main.Copy
            Dim dt_sv As New DataTable
            dt_sv.Columns.Add("Ma_sv", GetType(String))
            dt_sv.Columns.Add("Ho_ten", GetType(String))
            dt_sv.Columns.Add("Ngay_sinh", GetType(Date))
            dt_sv.Columns.Add("Ten_lop", GetType(String))

            dt.DefaultView.RowFilter = "Diem<5 AND ID_mon=" & ID_mon
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Dim dr As DataRow
                dr = dt_sv.NewRow
                dr("Ma_sv") = dt.DefaultView.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dt.DefaultView.Item(i)("Ho_ten").ToString
                If dt.DefaultView.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dt.DefaultView.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dt.DefaultView.Item(i)("Ten_lop").ToString
                dt_sv.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "1=1"
            dt_sv.DefaultView.RowFilter = "1=1"
            dt_sv.DefaultView.Sort = "Ten_lop,Ho_ten"
            Return dt_sv
        End Function

        Function Load_SinhVien_ThiLai(ByVal dt_main As DataTable, ByVal ID_mon As Integer) As DataTable
            Dim dt As DataTable = dt_main.Copy
            Dim dt_sv As New DataTable
            dt_sv.Columns.Add("Ma_sv", GetType(String))
            dt_sv.Columns.Add("Ho_ten", GetType(String))
            dt_sv.Columns.Add("Ngay_sinh", GetType(Date))
            dt_sv.Columns.Add("Ten_lop", GetType(String))

            dt.DefaultView.RowFilter = "TBCHP<5 AND ID_mon=" & ID_mon
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Dim dr As DataRow
                dr = dt_sv.NewRow
                dr("Ma_sv") = dt.DefaultView.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dt.DefaultView.Item(i)("Ho_ten").ToString
                If dt.DefaultView.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dt.DefaultView.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dt.DefaultView.Item(i)("Ten_lop").ToString
                dt_sv.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "1=1"
            dt_sv.DefaultView.RowFilter = "1=1"
            dt_sv.DefaultView.Sort = "Ten_lop,Ho_ten"
            Return dt_sv
        End Function
    End Class
End Namespace