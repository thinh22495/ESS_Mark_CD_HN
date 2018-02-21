'Tungnk
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachXetLenLop_BLL
        Private mID_dv As String = ""
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachXetLenLop As New ArrayList
        Private arrDanhSachXetLenLop_Nganh2 As New ArrayList
        Private mID_dt As Integer = 0
        Private QC As QuyCheDaoTao

#Region "Constructor"
        Sub New()

        End Sub
        Sub New(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_dt As Integer, ByVal DanhSachSinhVien As DataTable)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_dt = ID_dt
                QC = New QuyCheDaoTao(ID_he, ID_dt)

                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Dim dt As DataTable = obj.Load_DanhSachXetLenLop_List(mdsID_lop, ID_he, Khoa_hoc, ID_khoa, Hoc_ky, Nam_hoc)
                Dim objsvDanhSachXetLenLop As DanhSachXetLenLop = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachXetLenLop = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachXetLenLop = Converting(dr)
                    arrDanhSachXetLenLop.Add(objsvDanhSachXetLenLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer)
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Dim dt As DataTable = obj.Load_DanhSachHocTiepNganh2_List(ID_nganh)
                Dim objsvDanhSachXetLenLop As DanhSachXetLenLop = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachXetLenLop_Nganh2 = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachXetLenLop = Converting_Nganh2(dr)
                    arrDanhSachXetLenLop_Nganh2.Add(objsvDanhSachXetLenLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        'Public Sub LydoNgunghoc_FormatGrid(ByRef Lydo_Ngunghoc1 As String, ByRef Lydo_Ngunghoc2 As String, ByRef Lydo_Thoihoc1 As String, ByRef Lydo_Thoihoc2 As String)
        '    QC.LydoNgunghoc_FormatGrid(Lydo_Ngunghoc1, Lydo_Ngunghoc2, Lydo_Thoihoc1, Lydo_Thoihoc2)
        'End Sub

        Public Function Load_DanhSachNgungHocThoiHoc_Load_List(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Loai_qd As Integer) As DataTable
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Load_DanhSachNgungHocThoiHoc_Load_List(ID_lops, ID_he, Khoa_hoc, ID_khoa, Loai_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Load_DanhSach_SoQD(ByVal So_QD As String) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_QD", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Loai_QD", GetType(Integer))
            dt.Columns.Add("Ly_do2", GetType(String))
            dt.Columns.Add("ID_lop_cu", GetType(Integer))
            dt.Columns.Add("ID_lop_moi", GetType(Integer))
            dt.Columns.Add("Lop_moi", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))

            For i As Integer = 0 To arrDanhSachXetLenLop.Count - 1
                If CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).So_qd = So_QD Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_sv
                    row("Ma_sv") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ma_sv
                    row("Ho_ten") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ho_ten
                    row("Ngay_sinh") = Format(CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ngay_sinh, "dd/MM/yyyy")
                    row("Ten_lop") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ten_lop
                    row("ID_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_qd
                    row("Hoc_ky") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Hoc_ky
                    row("Nam_hoc") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Nam_hoc
                    row("Ngay_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ngay_qd
                    row("Loai_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Loai_qd
                    row("Ly_do2") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ly_do
                    row("ID_lop_cu") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_lop_cu
                    row("ID_lop_moi") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_lop_moi
                    row("Lop_moi") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Lop_moi
                    row("Ten_khoa") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ten_khoa
                    row("Chon") = False
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Function Load_DanhSach_QD_TrangThaiHoc(ByVal Loai_QD As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_QD", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Loai_QD", GetType(Integer))
            dt.Columns.Add("Ly_do", GetType(String))

            For i As Integer = 0 To arrDanhSachXetLenLop.Count - 1
                If CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Loai_qd = Loai_QD Then
                    dt.DefaultView.Sort = "ID_QD"
                    If dt.DefaultView.Find(CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_qd) < 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).ID_qd
                        row("So_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).So_qd
                        row("Hoc_ky") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Hoc_ky
                        row("Nam_hoc") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Nam_hoc
                        row("Ngay_qd") = Format(CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ngay_qd, "dd/MM/yyyy")
                        row("Loai_qd") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Loai_qd
                        row("Ly_do") = CType(arrDanhSachXetLenLop(i), DanhSachXetLenLop).Ly_do
                        dt.Rows.Add(row)
                    End If
                End If
            Next
            Return dt
        End Function

        Function Danh_sach_sinh_vien_chon(ByVal dv As DataView) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop_cu", GetType(Integer))
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = dv.Item(i)("ID_sv")
                        row("Ma_sv") = dv.Item(i)("Ma_sv")
                        row("Ho_ten") = dv.Item(i)("Ho_ten")
                        row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                        row("ID_lop") = dv.Item(i)("ID_lop")
                        row("Ten_lop") = dv.Item(i)("Ten_lop")
                        row("ID_lop_cu") = 0
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_QuyetDinhThoiHoc(ByVal objQuyetDinhThoiHoc As DanhSachXetLenLop) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Insert_QuyetDinhThoiHoc(objQuyetDinhThoiHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyetDinhThoiHoc(ByVal objQuyetDinhThoiHoc As DanhSachXetLenLop, ByVal ID_qd As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Update_QuyetDinhThoiHoc(objQuyetDinhThoiHoc, ID_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyetDinhThoiHoc(ByVal ID_qd As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Delete_QuyetDinhThoiHoc(ID_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Danh sach chi tiet
        Public Function Insert_QuyetDinhThoiHocChiTiet(ByVal objQuyetDinhThoiHocChiTiet As DanhSachXetLenLop) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Insert_QuyetDinhThoiHocChiTiet(objQuyetDinhThoiHocChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyetDinhThoiHocChiTiet(ByVal objQuyetDinhThoiHocChiTiet As DanhSachXetLenLop, ByVal ID_qd As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Update_QuyetDinhThoiHocChiTiet(objQuyetDinhThoiHocChiTiet, ID_qd, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyetDinhThoiHocChiTiet(ByVal ID_qd As Integer, ByVal ID_sv As Integer, ByVal ID_lop_cu As Integer, ByVal Loai_QD As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
                Return obj.Delete_QuyetDinhThoiHocChiTiet(ID_qd, ID_sv, ID_lop_cu, Loai_QD)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Function KetQua_XetLenLop(ByVal ID_he As Integer, ByVal dtLop As DataTable, ByVal Nam_hoc As String, ByVal ID_Bomon As Integer, ByRef dtHocTiep As DataTable, ByRef dtNgungHoc As DataTable, ByRef dtThoiHoc As DataTable) As DataTable
            Dim clsDiem As Diem_BLL
            clsDiem = New Diem_BLL(ID_he, mID_dv, ID_Bomon, 0, Nam_hoc, mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            Return clsDiem.KetQua_XetLenLop(dtLop, Nam_hoc, dtHocTiep, dtNgungHoc, dtThoiHoc)
        End Function


        Function XetLenLop_nganh2(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer) As DataTable
            'Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
            'Dim dt As DataTable = obj.Load_DanhSachHocTiepNganh2_List(ID_nganh)
            'dt.Columns.Add("Chon", GetType(Boolean))

            'Dim clsDiem As Diem_BLL
            'Dim Ly_do As String = ""
            'For i As Integer = 0 To dt.Rows.Count - 1
            '    Ly_do = ""
            '    'Check Nganh chinh TBCHT<2
            '    clsDiem = New Diem_BLL(ID_he, ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt1"))
            '    Dim dt_diemNganh As DataTable = clsDiem.BangDiemSinhVien(dt.DefaultView)
            '    If dt_diemNganh.Rows.Count > 0 AndAlso IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, dt_diemNganh.Rows(0)("TBC_tich_luy")) < 2 Then
            '        Ly_do = "Ngành chính xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy")
            '    End If
            '    'Check Nganh hoc thu 2 TBCHT<2
            '    clsDiem = New Diem_BLL(ID_he, ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt2"))
            '    dt_diemNganh = clsDiem.BangDiemSinhVien(dt.DefaultView)
            '    If dt_diemNganh.Rows.Count > 0 AndAlso IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, dt_diemNganh.Rows(0)("TBC_tich_luy")) < 2 Then
            '        If Ly_do.Trim = "" Then
            '            Ly_do = "Ngành học thứ 2 xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy").ToString
            '        Else
            '            Ly_do += ", Ngành học thứ 2 xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy").ToString
            '        End If
            '    End If

            '    'Check thoi gian hoc nganh nay
            '    Dim cls As ChuongTrinhDaoTao_BLL
            '    cls = New ChuongTrinhDaoTao_BLL(dt.Rows(i).Item("ID_dt1"))
            '    Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dt.Rows(i).Item("ID_dt1"))
            '    Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
            '    Dim NienKhoa_Dau As Integer = CType(Left(dt.Rows(i).Item("Nien_khoa"), 4), Integer)
            '    Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
            '    If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1
            '    If So_ky_ToiDa < So_ky_hienTai Then
            '        If Ly_do.Trim = "" Then
            '            Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
            '        Else
            '            Ly_do += ", Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
            '        End If
            '    End If

            '    dt.Rows(i).Item("Chon") = False
            '    dt.Rows(i).Item("Ly_do") = Ly_do
            'Next

            'dt.DefaultView.RowFilter = "Ly_do<>''"
            'Return dt
        End Function

        Function XetLenLop_Load2nganh(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer) As DataTable
            'Dim obj As DanhSachXetLenLop_DAL = New DanhSachXetLenLop_DAL
            'Dim dt As DataTable = obj.Load_DanhSachHocTiep2Nganh_List(ID_nganh)
            'dt.Columns.Add("Chon", GetType(Boolean))
            'dt.Columns.Add("Xep_loai1", GetType(String))
            'dt.Columns.Add("Xep_loai2", GetType(String))
            'dt.Columns.Add("TBCHT1", GetType(Double))
            'dt.Columns.Add("TBCHT2", GetType(Double))
            'dt.Columns.Add("So_ky", GetType(String))

            'Dim clsDiem As Diem_BLL
            'Dim Ly_do As String = ""
            'For i As Integer = 0 To dt.Rows.Count - 1
            '    Ly_do = ""
            '    'Check Nganh chinh TBCHT<2
            '    clsDiem = New Diem_BLL(ID_he, ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt1"))
            '    Dim dt_diemNganh As DataTable = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
            '    If dt_diemNganh.Rows.Count > 0 Then
            '        dt.Rows(i).Item("TBCHT1") = IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, Math.Round(dt_diemNganh.Rows(0)("TBC_tich_luy"), 2))
            '        dt.Rows(i).Item("Xep_loai1") = dt_diemNganh.Rows(0)("Xep_hang_hoc_luc").ToString
            '    End If
            '    'Check Nganh hoc thu 2 TBCHT<2
            '    clsDiem = New Diem_BLL(ID_he, ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt2"))
            '    dt_diemNganh = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
            '    If dt_diemNganh.Rows.Count > 0 Then
            '        dt.Rows(i).Item("TBCHT2") = IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, Math.Round(dt_diemNganh.Rows(0)("TBC_tich_luy"), 2))
            '        dt.Rows(i).Item("Xep_loai2") = dt_diemNganh.Rows(0)("Xep_hang_hoc_luc").ToString
            '    End If

            '    'Check thoi gian hoc nganh nay
            '    Dim cls As ChuongTrinhDaoTao_BLL
            '    cls = New ChuongTrinhDaoTao_BLL(dt.Rows(i).Item("ID_dt1"))
            '    Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dt.Rows(i).Item("ID_dt1"))
            '    Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
            '    Dim NienKhoa_Dau As Integer = CType(Left(dt.Rows(i).Item("Nien_khoa"), 4), Integer)
            '    Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
            '    If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1
            '    If So_ky_ToiDa < So_ky_hienTai Then
            '        If Ly_do.Trim = "" Then
            '            Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
            '        Else
            '            Ly_do += ", Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
            '        End If
            '    End If

            '    dt.Rows(i).Item("Chon") = False
            '    dt.Rows(i).Item("So_ky") = So_ky_hienTai & "/" & So_ky_ToiDa
            'Next

            'Return dt
        End Function
        Private Function Converting(ByVal drDanhSachXetLenLop As DataRow) As DanhSachXetLenLop
            Dim result As DanhSachXetLenLop
            Try
                result = New DanhSachXetLenLop
                If drDanhSachXetLenLop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachXetLenLop("ID_sv").ToString(), Integer)
                result.Ma_sv = drDanhSachXetLenLop("Ma_sv").ToString()
                result.Ho_ten = drDanhSachXetLenLop("Ho_ten").ToString()
                If drDanhSachXetLenLop("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachXetLenLop("Ngay_sinh").ToString(), Date)
                If drDanhSachXetLenLop("ID_qd").ToString() <> "" Then result.ID_qd = CType(drDanhSachXetLenLop("ID_qd").ToString(), Integer)
                If drDanhSachXetLenLop("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachXetLenLop("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhSachXetLenLop("Nam_hoc").ToString()
                result.So_qd = drDanhSachXetLenLop("So_qd").ToString()
                If drDanhSachXetLenLop("Ngay_qd").ToString() <> "" Then result.Ngay_qd = CType(drDanhSachXetLenLop("Ngay_qd").ToString(), Date)
                If drDanhSachXetLenLop("Loai_qd").ToString() <> "" Then result.Loai_qd = CType(drDanhSachXetLenLop("Loai_qd").ToString(), Integer)
                result.Ly_do = drDanhSachXetLenLop("Ly_do").ToString()
                If drDanhSachXetLenLop("ID_lop_cu").ToString() <> "" Then result.ID_lop_cu = CType(drDanhSachXetLenLop("ID_lop_cu").ToString(), Integer)
                If drDanhSachXetLenLop("ID_lop_moi").ToString() <> "" Then result.ID_lop_moi = CType(drDanhSachXetLenLop("ID_lop_moi").ToString(), Integer)
                result.Ten_lop = drDanhSachXetLenLop("Ten_lop").ToString()
                result.Lop_moi = drDanhSachXetLenLop("Lop_moi").ToString()
                result.Ten_khoa = drDanhSachXetLenLop("Ten_khoa").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Converting_Nganh2(ByVal drDanhSachXetLenLop As DataRow) As DanhSachXetLenLop
            Dim result As DanhSachXetLenLop
            Try
                result = New DanhSachXetLenLop
                If drDanhSachXetLenLop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachXetLenLop("ID_sv").ToString(), Integer)
                result.Ma_sv = drDanhSachXetLenLop("Ma_sv").ToString()
                result.Ho_ten = drDanhSachXetLenLop("Ho_ten").ToString()
                If drDanhSachXetLenLop("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachXetLenLop("Ngay_sinh").ToString(), Date)
                If drDanhSachXetLenLop("ID_dt1").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachXetLenLop("ID_dt1").ToString(), Integer)
                If drDanhSachXetLenLop("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drDanhSachXetLenLop("ID_dt2").ToString(), Integer)
                result.Nien_khoa = drDanhSachXetLenLop("Nien_khoa").ToString()
                result.Ly_do = drDanhSachXetLenLop("Ly_do").ToString()
                result.Ten_lop = drDanhSachXetLenLop("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class

End Namespace
