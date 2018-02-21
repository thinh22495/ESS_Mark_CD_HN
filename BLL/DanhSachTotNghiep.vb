'Tungnk

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachTotNghiep_BLL
        Private mID_dv As String = ""
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachTotNghiep As New ArrayList
        Private arrDanhSachChuaTotNghiep As New ArrayList
        Private mID_dt As Integer = 0
        Private QC As QuyCheDaoTao
#Region "Constructor"
        Sub New()

        End Sub

        Sub New(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal DanhSachSinhVien As DataTable, ByVal TotNghiep As Byte, ByVal ID_dt As Integer)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_dt = ID_dt

                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Dim objDanhsachTotNghiep As DanhSachTotNghiep = Nothing
                Dim dr As DataRow = Nothing

                If TotNghiep = 1 Then 'Load danh sach da tot nghiep
                    Dim dt_TotNghiep As DataTable = obj.Load_DanhSachTotNghiep_List(dsID_lop)
                    arrDanhSachTotNghiep = New ArrayList
                    For Each dr In dt_TotNghiep.Rows
                        objDanhsachTotNghiep = ConvertingTotNghiep(dr)
                        arrDanhSachTotNghiep.Add(objDanhsachTotNghiep)
                    Next
                Else 'Load chua tot nghiep
                    Dim dt_ChuaTotNghiep As DataTable = obj.Load_DanhSachChuaTotNghiep_List(dsID_lop)
                    arrDanhSachChuaTotNghiep = New ArrayList
                    For Each dr In dt_ChuaTotNghiep.Rows
                        objDanhsachTotNghiep = ConvertingChuaTotNghiep(dr)
                        arrDanhSachChuaTotNghiep.Add(objDanhsachTotNghiep)
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        Public Sub Add_TotNghiep(ByVal DSTN As DanhSachTotNghiep)
            arrDanhSachTotNghiep.Add(DSTN)
        End Sub
        Public Sub Remove_TotNghiep(ByVal idx As Integer)
            arrDanhSachTotNghiep.RemoveAt(idx)
        End Sub
        Public Sub Add_ChuaTotNghiep(ByVal DSCTN As DanhSachTotNghiep)
            arrDanhSachChuaTotNghiep.Add(DSCTN)
        End Sub
        Public Sub Remove_ChuaTotNghiep(ByVal idx As Integer)
            arrDanhSachChuaTotNghiep.RemoveAt(idx)
        End Sub
        Public Function Tim_idx_TotNghiep(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
                If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Tim_idx_ChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachChuaTotNghiep.Count - 1
                If CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Function dtDanhSachTotNghiep(ByVal Lan_thu As Integer, ByVal Nam_hoc As String, ByVal Id_he As Integer) As DataTable
            QC = New QuyCheDaoTao(Id_he, 0)
            Dim dtDSTotNghiep As New DataTable
            dtDSTotNghiep.Columns.Add("Chon", GetType(Boolean))
            dtDSTotNghiep.Columns.Add("Lock", GetType(Boolean))
            dtDSTotNghiep.Columns.Add("ID_sv", GetType(Integer))
            dtDSTotNghiep.Columns.Add("ID_dt", GetType(Integer))
            dtDSTotNghiep.Columns.Add("Lan_thu", GetType(Integer))
            dtDSTotNghiep.Columns.Add("So_bang", GetType(Integer))
            dtDSTotNghiep.Columns.Add("TBCHT", GetType(Double))
            dtDSTotNghiep.Columns.Add("Diem_toan_khoa", GetType(Double))
            dtDSTotNghiep.Columns.Add("ID_xep_loai", GetType(Integer))
            dtDSTotNghiep.Columns.Add("Ma_sv", GetType(String))
            dtDSTotNghiep.Columns.Add("Ho_ten", GetType(String))
            dtDSTotNghiep.Columns.Add("Ho_ten_Hoa", GetType(String))
            dtDSTotNghiep.Columns.Add("Van_dau", GetType(String))
            dtDSTotNghiep.Columns.Add("Ho_dem", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_sinh", GetType(Date))
            dtDSTotNghiep.Columns.Add("Ngay_sinh_chuan", GetType(String))
            dtDSTotNghiep.Columns.Add("ID_Gioi_tinh")
            dtDSTotNghiep.Columns.Add("Gioi_tinh", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_lop", GetType(String))
            dtDSTotNghiep.Columns.Add("Xep_hang", GetType(String))
            dtDSTotNghiep.Columns.Add("Nam_hoc", GetType(String))
            dtDSTotNghiep.Columns.Add("Chuyen_nganh", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_nganh", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_khoa", GetType(String))
            dtDSTotNghiep.Columns.Add("Khoa_hoc", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_he", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_tinh", GetType(String))
            dtDSTotNghiep.Columns.Add("Nien_khoa", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_he_en", GetType(String))
            dtDSTotNghiep.Columns.Add("Loai_dao_tao", GetType(String))
            dtDSTotNghiep.Columns.Add("Loai_dao_tao_en", GetType(String))
            dtDSTotNghiep.Columns.Add("Ghi_chu", GetType(String))
            dtDSTotNghiep.Columns.Add("Trinh_do", GetType(String))
            dtDSTotNghiep.Columns.Add("So_QD", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_QD", GetType(Date))
            dtDSTotNghiep.Columns.Add("So_hieu", GetType(String))
            dtDSTotNghiep.Columns.Add("So_vao_so", GetType(String))
            dtDSTotNghiep.Columns.Add("Tu_thang", GetType(String))
            dtDSTotNghiep.Columns.Add("Tu_nam", GetType(String))
            dtDSTotNghiep.Columns.Add("Den_thang", GetType(String))
            dtDSTotNghiep.Columns.Add("Den_nam", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_vao_so", GetType(String))
            dtDSTotNghiep.Columns.Add("Thang_vao_so", GetType(String))
            dtDSTotNghiep.Columns.Add("Nam_vao_so", GetType(String))
            For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
                If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Nam_hoc = Nam_hoc Then
                    Dim row As DataRow = dtDSTotNghiep.NewRow()
                    row("Chon") = False
                    row("Lock") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Lock
                    row("ID_sv") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_sv
                    row("ID_dt") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_dt
                    row("Lan_thu") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Lan_thu
                    row("So_bang") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).So_bang
                    row("TBCHT") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).TBCHT
                    row("Diem_toan_khoa") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Diem_toan_khoa
                    row("ID_xep_loai") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_xep_loai
                    row("ID_Gioi_tinh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_gioi_tinh
                    row("Gioi_tinh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Gioi_tinh
                    row("Ma_sv") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ma_sv
                    row("Ho_ten") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ho_ten.ToString
                    row("Ho_ten_Hoa") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ho_ten.ToString.ToUpper
                    row("Van_dau") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Van_dau
                    row("Ho_dem") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ho_dem
                    row("Ten") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten
                    If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh
                    If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Month > 2 Then
                        If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day < 10 Then
                            row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Month & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Year
                        Else
                            row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Month & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Year
                        End If
                    Else
                        If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day < 10 Then
                            row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day & " / 0" & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Month & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Year
                        Else
                            row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Day & " / 0" & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Month & " / " & CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.Year
                        End If
                    End If
                    row("Ten_lop") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_lop
                    row("Xep_hang") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Xep_hang
                    row("Nam_hoc") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Nam_hoc
                    row("Chuyen_nganh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Chuyen_nganh
                    row("Ten_nganh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_nganh
                    row("Ten_khoa") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_khoa
                    row("Khoa_hoc") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Khoa_hoc
                    row("Ten_he") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_he
                    row("Ten_tinh") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_tinh
                    row("Nien_khoa") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Nien_khoa
                    row("Ten_he_en") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ten_he_en
                    row("Loai_dao_tao") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Loai_dao_tao
                    row("Loai_dao_tao_en") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Loai_dao_tao_en
                    row("Trinh_do") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Trinh_do
                    row("So_hieu") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).So_hieu
                    row("So_vao_so") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).So_vao_so
                    row("So_QD") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).So_QD
                    row("Tu_thang") = "8".ToString
                    row("Tu_nam") = Left(row("Nien_khoa").ToString, 4)
                    row("Den_thang") = "8".ToString
                    row("Den_nam") = Right(row("Nien_khoa").ToString, 4)
                    If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_QD.ToString <> "" Then
                        row("Ngay_QD") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Ngay_QD
                        Dim Ngay_QD As Date = Format(row("Ngay_QD"), "dd/MM/yyyy")
                        Dim Ngay_HT As Integer = Ngay_QD.Day
                        If Ngay_HT < 10 Then
                            row("Ngay_vao_so") = "0" & Ngay_HT.ToString
                        Else
                            row("Ngay_vao_so") = Ngay_HT.ToString
                        End If
                        row("Thang_vao_so") = Ngay_QD.Month.ToString
                        row("Nam_vao_so") = Ngay_QD.Year.ToString
                    End If
                    dtDSTotNghiep.Rows.Add(row)
                End If
            Next
            If Lan_thu > 0 Then dtDSTotNghiep.DefaultView.RowFilter = "Lan_thu=" & Lan_thu
            dtDSTotNghiep.AcceptChanges()
            Dim dv As DataView = dtDSTotNghiep.DefaultView
            dv.Sort = "Van_dau,Ten,Ho_dem"
            Return dv.Table
        End Function

        Function dtDanhSachChuaTotNghiep(ByVal Nam_hoc As String) As DataTable
            Dim dtDSChuaTotNghiep As New DataTable
            dtDSChuaTotNghiep.Columns.Add("Chon1", GetType(Boolean))
            dtDSChuaTotNghiep.Columns.Add("ID_sv", GetType(Integer))
            dtDSChuaTotNghiep.Columns.Add("ID_dt", GetType(Integer))
            dtDSChuaTotNghiep.Columns.Add("TBCHT1", GetType(Double))
            dtDSChuaTotNghiep.Columns.Add("Diem_toan_khoa1", GetType(Double))
            dtDSChuaTotNghiep.Columns.Add("ID_xep_loai1", GetType(Integer))
            dtDSChuaTotNghiep.Columns.Add("Ma_sv1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ho_ten1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Van_dau1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ho_dem1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ten1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ngay_sinh1", GetType(Date))
            dtDSChuaTotNghiep.Columns.Add("Gioi_tinh1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ten_lop1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Xep_hang1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Nam_hoc1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ly_do", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Khoa_hoc1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ten_he", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ten_tinh1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Nien_khoa1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Chuyen_nganh1", GetType(String))
            For i As Integer = 0 To arrDanhSachChuaTotNghiep.Count - 1
                If CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Nam_hoc = Nam_hoc Then
                    Dim row As DataRow = dtDSChuaTotNghiep.NewRow()
                    row("Chon1") = False
                    row("ID_sv") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).ID_sv
                    row("ID_dt") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).ID_dt
                    row("TBCHT1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).TBCHT
                    row("Diem_toan_khoa1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Diem_toan_khoa
                    row("ID_xep_loai1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).ID_xep_loai
                    row("Ma_sv1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ma_sv
                    row("Ho_ten1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ho_ten
                    row("Van_dau1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Van_dau
                    row("Ho_dem1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ho_dem
                    row("Ten1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ten
                    If CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ngay_sinh.ToString <> "" Then row("Ngay_sinh1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ngay_sinh
                    row("Ten_lop1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ten_lop
                    row("Xep_hang1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Xep_hang
                    row("Nam_hoc1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Nam_hoc
                    row("Ly_do") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ly_do
                    row("Khoa_hoc1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Khoa_hoc
                    row("Ten_he") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ten_he
                    row("Ten_tinh1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Ten_tinh
                    row("Nien_khoa1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Nien_khoa
                    row("Gioi_tinh1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Gioi_tinh
                    row("Chuyen_nganh1") = CType(arrDanhSachChuaTotNghiep(i), DanhSachTotNghiep).Chuyen_nganh
                    dtDSChuaTotNghiep.Rows.Add(row)
                End If
            Next
            dtDSChuaTotNghiep.AcceptChanges()
            Return dtDSChuaTotNghiep
        End Function

        Public Sub XetTotNghiep(ByVal ID_he As Integer, ByVal Nam_hoc As String, ByVal Lan_thu As Integer, ByVal ID_Bomon As Integer, Optional ByVal Chung_chu As Boolean = False)
            Try
                Dim No_HT As String
                Dim clsDiem As Diem_BLL
                clsDiem = New Diem_BLL(ID_he, mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
                Dim dtDiem As DataTable = clsDiem.TongHopDiem_XetTotNghiep()


                'Neu tot nghiep thi xoa sv neu o bang chua tot nghiep; kiem tra xem neu ton tai -> Update chua thi Insert
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    'If dtDiem.Rows(i)("ID_SV") = 1 Then
                    '    dtDiem.Rows(i)("ID_SV") = 1
                    'End If
                    No_HT = ""
                    'No_CC = ""

                    'Môn học có điểm F
                    If dtDiem.Rows(i).Item("LyDo_no_mon").ToString <> "" Then No_HT = "Nợ học phần: " & dtDiem.Rows(i).Item("LyDo_no_mon")
                    'Chưa học môn bắt buộc
                    If dtDiem.Rows(i).Item("LyDo_mon_batbuoc").ToString <> "" Then
                        If No_HT = "" Then
                            No_HT = "Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                        Else
                            No_HT &= "-Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                        End If
                    End If
                    'Điểm không đạt < 5
                    If dtDiem.Rows(i).Item("LyDo_TBCHT_TL").ToString <> "" Then
                        If No_HT = "" Then
                            No_HT = dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                        Else
                            No_HT &= "-" & dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                        End If
                    End If
                    'Thi tot nghiep voi quy che 40
                    If dtDiem.Rows(i).Item("Quy_che") = 40 AndAlso dtDiem.Rows(i).Item("LyDo_MonTN").ToString <> "" Then
                        If No_HT = "" Then
                            No_HT = dtDiem.Rows(i).Item("LyDo_MonTN").ToString
                        Else
                            No_HT &= "-" & dtDiem.Rows(i).Item("LyDo_MonTN").ToString
                        End If
                    End If

                    'Check nợ môn chứng chỉ
                    Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                    Dim dt_NoChungChi As DataTable = obj.Load_DanhSachChungChiSinhVienNo(dtDiem.Rows(i).Item("ID_dt"), dtDiem.Rows(i).Item("ID_sv"))
                    Dim NoCC As String = ""
                    For c As Integer = 0 To dt_NoChungChi.Rows.Count - 1
                        If NoCC.Trim = "" Then
                            NoCC = "Nợ chứng chỉ: " & dt_NoChungChi.Rows(c).Item("Loai_chung_chi").ToString
                        Else
                            NoCC += "; " & dt_NoChungChi.Rows(c).Item("Loai_chung_chi").ToString
                        End If
                    Next
                    If NoCC.Trim <> "" Then
                        If No_HT.Trim = "" Then
                            No_HT = NoCC
                        Else
                            No_HT += "; " & NoCC
                        End If
                    End If

                    'Check nợ khác
                    Dim dt_NoKhac As DataTable = obj.Load_DanhSachNoKhac(dtDiem.Rows(i).Item("ID_sv"))
                    Dim NoKhac As String = ""
                    If dt_NoKhac.Rows.Count > 0 Then NoKhac = "Nợ khác: " & dt_NoKhac.Rows(0).Item("Ly_do").ToString
                    If NoKhac.Trim <> "" Then
                        If No_HT.Trim = "" Then
                            No_HT = NoKhac
                        Else
                            No_HT += "; " & NoKhac
                        End If
                    End If
                    If dtDiem.Rows(i).Item("ID_SV") = 73 Then
                        dtDiem.Rows(i).Item("ID_SV") = 73
                    End If
                    'Xoá sinh viên khỏi danh sách Tốt nghiệp và Bổ sung vào danh sách Nợ tốt nghiệp rơi vào 3 đk trên
                    If No_HT.Trim <> "" Then
                        Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                        If idx >= 0 Then
                            Remove_TotNghiep(idx)
                            Delete_DanhSachTotNghiep(dtDiem.Rows(i).Item("ID_SV"), Lan_thu)
                        End If

                        Dim objChuaTN As New DanhSachTotNghiep
                        objChuaTN.Nam_hoc = Nam_hoc
                        objChuaTN.Lan_thu = Lan_thu
                        objChuaTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                        objChuaTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                        objChuaTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                        objChuaTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                        objChuaTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                        objChuaTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                        If IsNumeric(dtDiem.Rows(i).Item("Diem_toan_khoa")) Then
                            objChuaTN.Diem_toan_khoa = dtDiem.Rows(i).Item("Diem_toan_khoa")
                        Else
                            objChuaTN.Diem_toan_khoa = 0
                        End If

                        objChuaTN.ID_dt = mID_dt
                        objChuaTN.Ly_do = No_HT

                        Delete_DanhSachChuaTotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                        Insert_DanhSachChuaTotNghiep(objChuaTN)
                    Else 'Tốt nghiệp
                        Delete_DanhSachChuaTotNghiep(dtDiem.Rows(i).Item("ID_SV"))

                        Dim objTN As New DanhSachTotNghiep
                        objTN.Nam_hoc = Nam_hoc
                        objTN.Lan_thu = Lan_thu
                        objTN.So_bang = objTN.So_bang
                        objTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                        objTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                        objTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                        objTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                        objTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                        objTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                        objTN.Diem_toan_khoa = dtDiem.Rows(i).Item("Diem_toan_khoa")
                        objTN.Ghi_chu = dtDiem.Rows(i).Item("HaBac_TotNghiep").ToString

                        Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                        If idx >= 0 Then 'Update  
                            If CType(arrDanhSachTotNghiep(idx), DanhSachTotNghiep).Lan_thu = Lan_thu Then
                                Update_DanhSachTotNghiep(objTN, dtDiem.Rows(i).Item("ID_SV"))
                            End If
                        Else ' Insert
                            Insert_DanhSachTotNghiep(objTN)
                        End If
                    End If

                    '

                    'Loai những sinh viên nợ chứng chỉ

                    'Loai những sinh viên nợ tốt nghiệp như giấy tờ, học phí, ktx, thư viện....

                    'Load danh sách những sinh viên bị kỷ luật trong năm học xét tốt nghiệp

                    'Loại sinh viên nợ học phí

                Next
            Catch ex As Exception

            End Try
            
        End Sub

        Public Sub Update_SoVB(ByVal dv As DataView, ByVal Tu_so As Integer)
            For i As Integer = 0 To dv.Count - 1
                Dim objTN As New DanhSachTotNghiep
                objTN.ID_sv = dv.Table.Rows(i).Item("ID_sv")
                objTN.Lan_thu = dv.Table.Rows(i).Item("Lan_thu")
                objTN.So_bang = i + Tu_so
                objTN.TBCHT = dv.Table.Rows(i).Item("TBCHT")
                objTN.ID_xep_loai = dv.Table.Rows(i).Item("ID_xep_loai")
                objTN.Nam_hoc = dv.Table.Rows(i).Item("Nam_hoc")
                Update_DanhSachTotNghiep(objTN, dv.Table.Rows(i).Item("ID_SV"))
            Next
        End Sub

        Private Function dtDanhSachTotNghiep_lapVB(ByVal Nam_hoc As String) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("So_bang", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
                If CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Nam_hoc = Nam_hoc Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).ID_sv
                    row("So_bang") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).So_bang
                    row("Nam_hoc") = CType(arrDanhSachTotNghiep(i), DanhSachTotNghiep).Nam_hoc
                    dt.Rows.Add(row)
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function Insert_DanhSachTotNghiep(ByVal objDanhSachTotNghiep As DanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Insert_DanhSachTotNghiep(objDanhSachTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachTotNghiep(ByVal objDanhSachTotNghiep As DanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Update_DanhSachTotNghiep(objDanhSachTotNghiep, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachTotNghiep(ByVal ID_sv As Integer, ByVal Lan_thu As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Delete_DanhSachTotNghiep(ID_sv, Lan_thu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachChuaTotNghiep(ByVal objDanhSachChuaTotNghiep As DanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Insert_DanhSachChuaTotNghiep(objDanhSachChuaTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachChuaTotNghiep(ByVal objDanhSachChuaTotNghiep As DanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Update_DanhSachChuaTotNghiep(objDanhSachChuaTotNghiep, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.Delete_DanhSachChuaTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function ConvertingTotNghiep(ByVal drDanhSachTotNghiep As DataRow) As DanhSachTotNghiep
            Dim result As DanhSachTotNghiep
            Try
                result = New DanhSachTotNghiep
                If drDanhSachTotNghiep("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachTotNghiep("ID_sv").ToString(), Integer)
                If drDanhSachTotNghiep("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachTotNghiep("TBCHT").ToString(), Double)
                If drDanhSachTotNghiep("Diem_toan_khoa").ToString() <> "" Then result.Diem_toan_khoa = CType(drDanhSachTotNghiep("Diem_toan_khoa").ToString(), Double)
                If drDanhSachTotNghiep("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachTotNghiep("ID_xep_loai").ToString(), Integer)
                If drDanhSachTotNghiep("So_bang").ToString() <> "" Then result.So_bang = CType(drDanhSachTotNghiep("So_bang").ToString(), Integer)
                If drDanhSachTotNghiep("Lan_thu").ToString() <> "" Then result.Lan_thu = CType(drDanhSachTotNghiep("Lan_thu").ToString(), Integer)
                If drDanhSachTotNghiep("ID_Gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachTotNghiep("ID_gioi_tinh").ToString(), Integer)
                result.Gioi_tinh = drDanhSachTotNghiep("Gioi_tinh").ToString()
                result.Ma_sv = drDanhSachTotNghiep("Ma_sv").ToString()
                result.Ho_ten = drDanhSachTotNghiep("Ho_ten").ToString()
                result.Van_dau = drDanhSachTotNghiep("Van_dau").ToString()
                result.Ho_dem = drDanhSachTotNghiep("Ho_dem").ToString()
                result.Ten = drDanhSachTotNghiep("Ten").ToString()
                If drDanhSachTotNghiep("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = drDanhSachTotNghiep("Ngay_sinh")
                result.Gioi_tinh = drDanhSachTotNghiep("Gioi_tinh").ToString()
                result.Ten_lop = drDanhSachTotNghiep("Ten_lop").ToString()
                result.ID_dt = drDanhSachTotNghiep("ID_dts").ToString()
                result.Xep_hang = drDanhSachTotNghiep("Xep_hang").ToString()
                result.Nam_hoc = drDanhSachTotNghiep("Nam_hoc").ToString()

                result.Chuyen_nganh = drDanhSachTotNghiep("Chuyen_nganh").ToString()
                result.Ten_nganh = drDanhSachTotNghiep("Ten_nganh").ToString()
                result.Ten_khoa = drDanhSachTotNghiep("Ten_khoa").ToString()
                result.Khoa_hoc = drDanhSachTotNghiep("Khoa_hoc").ToString()
                result.Ten_he = drDanhSachTotNghiep("Ten_he").ToString()
                result.Ten_tinh = drDanhSachTotNghiep("Ten_tinh").ToString()
                result.Nien_khoa = drDanhSachTotNghiep("Nien_khoa").ToString()
                result.Ten_he_en = drDanhSachTotNghiep("Ten_he_en").ToString()
                result.Loai_dao_tao = drDanhSachTotNghiep("Loai_dao_tao").ToString()
                result.Loai_dao_tao_en = drDanhSachTotNghiep("Loai_dao_tao_en").ToString()
                result.Trinh_do = drDanhSachTotNghiep("Trinh_do").ToString()
                result.So_hieu = drDanhSachTotNghiep("So_hieu").ToString()
                result.So_vao_so = drDanhSachTotNghiep("So_vao_so").ToString()
                If drDanhSachTotNghiep("Ngay_QD").ToString() <> "" Then result.Ngay_QD = CType(drDanhSachTotNghiep("Ngay_QD"), Date)
                result.So_QD = drDanhSachTotNghiep("So_QD").ToString()
                result.Lock = drDanhSachTotNghiep("Lock").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function ConvertingChuaTotNghiep(ByVal drDanhSachChuaTotNghiep As DataRow) As DanhSachTotNghiep
            Dim result As DanhSachTotNghiep
            Try
                result = New DanhSachTotNghiep
                If drDanhSachChuaTotNghiep("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachChuaTotNghiep("ID_sv").ToString(), Integer)
                If drDanhSachChuaTotNghiep("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachChuaTotNghiep("TBCHT").ToString(), Double)
                If drDanhSachChuaTotNghiep("Diem_toan_khoa").ToString() <> "" Then result.Diem_toan_khoa = CType(drDanhSachChuaTotNghiep("Diem_toan_khoa").ToString(), Double)
                If drDanhSachChuaTotNghiep("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachChuaTotNghiep("ID_xep_loai").ToString(), Integer)

                result.Ma_sv = drDanhSachChuaTotNghiep("Ma_sv").ToString()
                result.Ho_ten = drDanhSachChuaTotNghiep("Ho_ten").ToString()
                result.Van_dau = drDanhSachChuaTotNghiep("Van_dau").ToString()
                result.Ho_dem = drDanhSachChuaTotNghiep("Ho_dem").ToString()
                result.Ten = drDanhSachChuaTotNghiep("Ten").ToString()

                If drDanhSachChuaTotNghiep("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = drDanhSachChuaTotNghiep("Ngay_sinh").ToString()
                result.Ten_lop = drDanhSachChuaTotNghiep("Ten_lop").ToString()
                result.ID_dt = drDanhSachChuaTotNghiep("ID_dts").ToString()
                result.Xep_hang = drDanhSachChuaTotNghiep("Xep_hang").ToString()
                result.Nam_hoc = drDanhSachChuaTotNghiep("Nam_hoc").ToString()
                result.Ly_do = drDanhSachChuaTotNghiep("Ly_do").ToString()
                result.Gioi_tinh = drDanhSachChuaTotNghiep("Gioi_tinh").ToString()
                result.Khoa_hoc = drDanhSachChuaTotNghiep("Khoa_hoc").ToString()
                result.Ten_he = drDanhSachChuaTotNghiep("Ten_he").ToString()
                result.Ten_tinh = drDanhSachChuaTotNghiep("Ten_tinh").ToString()
                result.Nien_khoa = drDanhSachChuaTotNghiep("Nien_khoa").ToString()
                result.Chuyen_nganh = drDanhSachChuaTotNghiep("Chuyen_nganh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Lap_van_bang(ByVal dv As DataView, ByVal Tu_so As Integer, ByRef Den_so As Integer) As DataView
            For i As Integer = 0 To dv.Count - 1

            Next
            Return dv
        End Function
        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.CapNhat_SoHieu(So_hieu, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.CapNhat_SoVaoSo(So_vao_so, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function getDenSo_VB(ByVal Tu_so As Integer, ByVal dv_main As DataView, ByVal Nam_hoc As String) As Integer
            Dim DenSo_VB As Integer = Tu_so + dv_main.Count
            Dim dv As DataView = dtDanhSachTotNghiep_lapVB(Nam_hoc).DefaultView
            dv.RowFilter = "So_bang>=" & Tu_so & " AND So_bang<=" & DenSo_VB
            If dv.Count > 0 Then Return -1

            Return DenSo_VB
        End Function
        Public Function CapNhat_QuyetDinh(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.CapNhat_QuyetDinh(So_QD, Ngay_QD, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_KHoa(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.CapNhat_KHoa(ID_sv, Lock)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_ChuaDat_TotNghiep(ByVal ID_lop As String, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.DanhSach_ChuaDat_TotNghiep(ID_lop, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function BangDiem_ThiTotNghiep_SV(ByVal ID_lop As String, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.BangDiem_ThiTotNghiep_SV(ID_lop, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKeTotNghiep() As DataTable
            Try
                Dim obj As DanhSachTotNghiep_DAL = New DanhSachTotNghiep_DAL
                Return obj.ThongKeTotNghiep()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
