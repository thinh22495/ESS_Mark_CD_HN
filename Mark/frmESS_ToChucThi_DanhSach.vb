
Imports System
Imports System.Data
Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library

Public Class frmESS_ToChucThi_DanhSach
    Private mID_he As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon As Integer = 0
    Private mID_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mPhong_thi As String = ""
    Private mNgay_thi As String = ""
    Private mLan_thi As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsTCThi As New TochucThi_BLL
    Private clsDiem As New Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
#Region "Form Events"
    Private Sub frmESS_ToChucThiList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'SetUpDataGridView(grdViewDanhSachThi)
            Loader = True
            SetQuyenTruyCap(btnAdd_sv, btnToTucThi, btnXoa_TCT, btnDel_sv)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_ToChucThiList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Try
            If Loader Then
                Dim dtDanhSachSinhVien As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                mTen_mon = trvPhongThi.Ten_mon
                mPhong_thi = trvPhongThi.Phong_thi
                If mID_thi > 0 Then
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                        Dim dvDSSV As DataView = dtDanhSachSinhVien.DefaultView
                        dvDSSV.Sort = "Van_dau,Ten,Ho_dem"
                        Me.grcViewDanhSachThi.DataSource = dvDSSV
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                        dtDanhSachSinhVien.DefaultView.Sort = "Van_dau,Ten,Ho_dem"
                        Me.grcViewDanhSachThi.DataSource = dtDanhSachSinhVien.DefaultView
                    End If
                    txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count

                    Dim dtDiemTH As DataTable
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dt As DataTable = clsTCThi.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If

                Else
                    Me.grcViewDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub menuPrintDotThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim mCa_thi, mNhom_tiet As String

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                    End If
                    Dim dt_dsPhong As DataTable = clsTCThi.DanhSachPhongThi(mID_thi)
                    For r As Integer = 0 To dt_dsPhong.Rows.Count - 1
                        Dim dtDiemTH As DataTable
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, dt_dsPhong.Rows(r).Item("ID_phong_thi"))
                        If dtDanhSachSinhVien.Rows.Count > 0 Then
                            'Lấy danh sách các ID_lop
                            For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                                If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                    dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                End If
                            Next
                            If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                            'Load dữ liệu điểm
                            clsDiem = New Diem_BLL(mID_he, ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                            dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        End If

                        If mCa_thi = "0" Then mCa_thi = "Sáng"
                        If mCa_thi = "1" Then mCa_thi = "Chiều"
                        If mCa_thi = "2" Then mCa_thi = "Tối"
                        If mNhom_tiet = 0 Then
                            mNhom_tiet = 1
                        ElseIf mNhom_tiet = 1 Then
                            mNhom_tiet = 2
                        ElseIf mNhom_tiet = 2 Then
                            mNhom_tiet = 3
                        End If

                        dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                        dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                        dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                        dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                        dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                        dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                        dtDiemTH.Columns.Add("Tieu_de_ten_bo")
                        dtDiemTH.Columns.Add("Tieu_de_Ten_truong")

                        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                            dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI LẦN " & mLan_thi
                            dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                            dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                            dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                            dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                            dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                            dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                            dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                            dtDiemTH.Rows(i).Item("Ten_phong") = dt_dsPhong.Rows(r).Item("Ten_phong")
                            dtDiemTH.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
                        Next

                        Dim frmESS_ As New frmESS_ReportView
                        frmESS_.ShowDialog_PrintAll("DS THI THEO PHONG", dtDiemTH)
                    Next
                End If
                Thongbao("Đã in xong danh sách đợt thi !")
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

    Private Sub cmdThiTotNghiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                    End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If

                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))


                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = "Môn thi: " & mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet

                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS THI TOT NGHIEP THEO PHONG", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_PhachDiemSoChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, Thoi_gian As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Thoi_gian = ""
                Dim mTen_he As String = trvPhongThi.Ten_he
                If mID_thi > 0 Then
                    If mID_phong_thi <= 0 Then Exit Sub
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        Thoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"

                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ten_ca", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ten_ca") = mCa_thi
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = Thoi_gian
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra1", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_PhachHoiPhach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, Thoi_gian As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Thoi_gian = ""
                Dim mTen_he As String = trvPhongThi.Ten_he
                If mID_thi > 0 Then
                    If mID_phong_thi <= 0 Then Exit Sub
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        Thoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"

                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ten_ca", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ten_ca") = mCa_thi

                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = Thoi_gian
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra2", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_FullPhachDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, Thoi_gian As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Thoi_gian = ""
                Dim mTen_he As String = trvPhongThi.Ten_he
                If mID_thi > 0 Then
                    If mID_phong_thi <= 0 Then Exit Sub
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        Thoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"

                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ten_ca", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))



                'Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ten_ca") = mCa_thi

                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = Thoi_gian
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_ThiVanDap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, Thoi_gian As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Thoi_gian = ""
                Dim mTen_he As String = trvPhongThi.Ten_he
                If mID_thi > 0 Then
                    If mID_phong_thi <= 0 Then Exit Sub
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_BLL(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        Thoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"

                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ten_ca", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ten_ca") = mCa_thi
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = Thoi_gian
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("ThiVanDap", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPhanPhongThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frmESS_ As New frmESS_ToChucThiPhanPhong
            If mID_thi > 0 Then
                clsTCThi = New TochucThi_BLL(trvPhongThi.Hoc_ky, trvPhongThi.Nam_hoc, gobjUser.ID_Bomon)
                frmESS_.ShowDialog(mID_thi, clsTCThi)
                If frmESS_.Save = True Then
                    'Load lại danh sách phòng thi
                End If
            Else
                Thongbao("Bạn hãy chọn phòng thi", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            Thongbao(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frmESS_ As New frmESS_ToChucThiAdd
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            frmESS_.ShowDialog(mHoc_ky, mNam_hoc)
            If frmESS_.Tag = 1 Then
                trvPhongThi.ReLoad()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnXoa_TCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If mID_thi > 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá tổ chức thi không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Xoá sinh viên
                    clsTCThi.Delete_TochucThiChiTiet(mID_thi, "0")
                    'Xoá phòng thi
                    clsTCThi.Delete_ToChucThiTheoPhong(mID_thi, "0")
                    'Xoá tổ chức thi
                    clsTCThi.Delete_TochucThi(mID_thi)
                    'Load lại cây tổ chức thi
                    trvPhongThi.ReLoad()
                    'Load lại danh sách sinh viên
                    Me.grcViewDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                    Thongbao("Đã xoá xong tổ chức thi !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If mID_phong_thi > 0 Then
                Dim frmESS_ As New frmESS_ToChucThiThemSinhVien
                frmESS_.ShowDialog(mHoc_ky, mNam_hoc, 1, mID_mon)
                If frmESS_.Tag = 1 Then
                    Dim dvDanhSachSinhVien As DataView
                    dvDanhSachSinhVien = frmESS_.grdViewDanhSachChon.DataSource
                    If Not dvDanhSachSinhVien Is Nothing AndAlso dvDanhSachSinhVien.Count > 0 Then
                        Dim So_sv As Integer = 0
                        dvDanhSachSinhVien.Sort = "Ma_sv"
                        For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                            If clsTCThi.ToChucThi(0).dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) < 0 Then
                                'Đưa số 0 vào trước số VD 001,002
                                Dim SoBD As String = ""
                                SoBD = "0000" + (clsTCThi.ToChucThi(0).dsChiTietSinhVien.Count + i + 1).ToString
                                'Tính độ dài của số báo danh
                                SoBD = clsTCThi.XuLy_Xau_SoBD(SoBD, dvDanhSachSinhVien.Count)

                                Dim objThiChiTiet As New TochucThiChiTiet
                                objThiChiTiet.ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                                objThiChiTiet.ID_thi = mID_thi
                                objThiChiTiet.ID_phong_thi = mID_phong_thi
                                objThiChiTiet.OrderBy = "ZZZ"   'Đưa sinh viên vào cuối danh sách
                                objThiChiTiet.So_bao_danh = SoBD
                                clsTCThi.Insert_TochucThiChiTiet(objThiChiTiet)
                                So_sv += 1
                            End If
                        Next
                        If So_sv > 0 Then
                            'Load lại danh sách sinh viên
                            Call trvPhongThi_Select()
                            Thongbao("Đã thêm thành công " + So_sv.ToString + " sinh viên vào danh sách thi !")
                        Else
                            Thongbao("Những sinh viên này đã có trong danh sách thi !")
                        End If
                    End If
                End If
            Else
                Thongbao("Bạn phải chọn đến phòng thi để thêm sinh viên !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If mID_thi > 0 Then
                Dim dvDanhSachSinhVien As DataView
                Dim ID_sv As Integer, So_sv As Integer
                dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
                If Not dvDanhSachSinhVien Is Nothing Then
                    So_sv = 0
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien(i)("Chon") Then
                            ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                            clsTCThi.Delete_TochucThiChiTiet(mID_thi, ID_sv)
                            So_sv += 1
                        End If
                    Next
                End If
                If So_sv > 0 Then
                    'Load lại danh sách sinh viên
                    Call trvPhongThi_Select()
                    Thongbao("Đã xoá thành công " + So_sv.ToString + " sinh viên ra khỏi danh sách thi !")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    Dim dt As DataTable = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim rpt As New rpt_DS_ToChucThi(dtDiemTH, dtTP)
                rpt.DataSource = dtDiemTH
                PrintXtraReport(rpt)
                'Dim frmESS_ As New frmESS_ReportView
                'frmESS_.ShowDialog("DS THI THEO PHONG", dtDiemTH)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default


        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDanhSachThi.DataSource Is Nothing Then
        '        Dim dtDiemTH As DataTable
        '        Dim mCa_thi, mNhom_tiet, mThoi_gian As String
        '        mID_he = trvPhongThi.ID_he
        '        mHoc_ky = trvPhongThi.Hoc_ky
        '        mNam_hoc = trvPhongThi.Nam_hoc
        '        mID_mon = trvPhongThi.ID_mon
        '        mLan_thi = trvPhongThi.Lan_thi
        '        mID_thi = trvPhongThi.ID_thi
        '        mID_phong_thi = trvPhongThi.ID_phong_thi
        '        Dim mTen_he As String = trvPhongThi.Ten_he
        '        If mID_thi > 0 Then
        '            Dim ID_dv As String = gobjUser.ID_dv
        '            Dim dsID_lop As String = ""
        '            Dim dtDanhSachSinhVien As DataTable
        '            'Load dữ liệu về tổ chức thi
        '            clsTCThi = New TochucThi_BLL(mID_thi)
        '            Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
        '            If dt.Rows.Count > 0 Then
        '                mNgay_thi = dt.Rows(0).Item("Ngay_thi")
        '                mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
        '                mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
        '                mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
        '            End If
        '            If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
        '                dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
        '            Else    'Load tất cả sinh viên của tổ chức thi
        '                dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
        '            End If
        '            If dtDanhSachSinhVien.Rows.Count > 0 Then
        '                Dim dsID_dt As String = ""
        '                'Lấy danh sách các ID_lop
        '                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
        '                    If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
        '                        dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
        '                        dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
        '                    End If
        '                Next
        '                If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
        '                If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
        '                'Load dữ liệu điểm
        '                clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
        '                'If mLan_thi = 1 Then
        '                dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
        '                'Else
        '                '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
        '                'End If
        '            End If
        '        End If
        '        If mCa_thi = "0" Then mCa_thi = "Sáng"
        '        If mCa_thi = "1" Then mCa_thi = "Chiều"
        '        If mCa_thi = "2" Then mCa_thi = "Tối"
        '        If mNhom_tiet = 0 Then
        '            mNhom_tiet = 1
        '        ElseIf mNhom_tiet = 1 Then
        '            mNhom_tiet = 2
        '        ElseIf mNhom_tiet = 2 Then
        '            mNhom_tiet = 3
        '        End If

        '        dtDiemTH.Columns.Add("Tieu_de", GetType(String))
        '        dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
        '        dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
        '        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
        '        dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
        '        dtDiemTH.Columns.Add("Ca_thi", GetType(String))
        '        dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
        '        dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
        '        dtDiemTH.Columns.Add("Ten_he", GetType(String))
        '        dtDiemTH.Columns.Add("Thoi_gian", GetType(String))


        '        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
        '            dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
        '            dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
        '            dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
        '            dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
        '            dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
        '            dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
        '            dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
        '            dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
        '            dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
        '            dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
        '            dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
        '        Next

        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog("DS THI THEO PHONG", dtDiemTH)
        '    Else
        '        Thongbao("Bạn phải chọn học phần tổ chức thi trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    Dim clsExcel As New ExportToExcel
        '    Dim Tieu_de As String = ""
        '    clsExcel.ExportFromDataGridViewToExcel(grdViewDanhSachThi, Nothing)
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdSua_CTThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnToTucThi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToTucThi.Click
        Try
            Dim frmESS_ As New frmESS_ToChucThiAdd
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            frmESS_.ShowDialog(mHoc_ky, mNam_hoc)
            If frmESS_.Tag = 1 Then
                trvPhongThi.ReLoad()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_sv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_sv.Click
        Try
            If mID_phong_thi > 0 Then
                Dim frmESS_ As New frmESS_ToChucThiThemSinhVien
                frmESS_.ShowDialog(mHoc_ky, mNam_hoc, 1, mID_mon)
                If frmESS_.Tag = 1 Then
                    Dim dvDanhSachSinhVien As DataView
                    dvDanhSachSinhVien = frmESS_.grdViewDanhSachChon.DataSource
                    If Not dvDanhSachSinhVien Is Nothing AndAlso dvDanhSachSinhVien.Count > 0 Then
                        Dim So_sv As Integer = 0
                        dvDanhSachSinhVien.Sort = "Ma_sv"
                        For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                            If clsTCThi.ToChucThi(0).dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) < 0 Then
                                'Đưa số 0 vào trước số VD 001,002
                                Dim SoBD As String = ""
                                SoBD = "0000" + (clsTCThi.ToChucThi(0).dsChiTietSinhVien.Count + i + 1).ToString
                                'Tính độ dài của số báo danh
                                SoBD = clsTCThi.XuLy_Xau_SoBD(SoBD, dvDanhSachSinhVien.Count)

                                Dim objThiChiTiet As New TochucThiChiTiet
                                objThiChiTiet.ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                                objThiChiTiet.ID_thi = mID_thi
                                objThiChiTiet.ID_phong_thi = mID_phong_thi
                                objThiChiTiet.OrderBy = "ZZZ"   'Đưa sinh viên vào cuối danh sách
                                objThiChiTiet.So_bao_danh = SoBD
                                clsTCThi.Insert_TochucThiChiTiet(objThiChiTiet)
                                So_sv += 1
                            End If
                        Next
                        If So_sv > 0 Then
                            'Load lại danh sách sinh viên
                            Call trvPhongThi_Select()
                            Thongbao("Đã thêm thành công " + So_sv.ToString + " sinh viên vào danh sách thi !")
                        Else
                            Thongbao("Những sinh viên này đã có trong danh sách thi !")
                        End If
                    End If
                End If
            Else
                Thongbao("Bạn phải chọn đến phòng thi để thêm sinh viên !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSua_CTThi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSua_CTThi.Click
        Try
            If mID_phong_thi <= 0 Then
                Thongbao("Bạn hãy chọn 1 phòng thi để sửa")
            Else
                Dim frmESS_ As New frmESS_ToChucThi_SuaCTThi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                frmESS_.ShowDialog(mID_phong_thi)
                If frmESS_.Tag = 1 Then
                    trvPhongThi.ReLoad()
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnXoa_TCT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa_TCT.Click
        Try
            If mID_thi > 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá tổ chức thi không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Xoá sinh viên
                    clsTCThi.Delete_TochucThiChiTiet(mID_thi, "0")
                    'Xoá phòng thi
                    clsTCThi.Delete_ToChucThiTheoPhong(mID_thi, "0")
                    'Xoá tổ chức thi
                    clsTCThi.Delete_TochucThi(mID_thi)
                    'Load lại cây tổ chức thi
                    trvPhongThi.ReLoad()
                    'Load lại danh sách sinh viên
                    Me.grcViewDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                    Thongbao("Đã xoá xong tổ chức thi !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_sv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_sv.Click
        Try
            If mID_thi > 0 Then
                Dim dvDanhSachSinhVien As DataView
                Dim ID_sv As Integer, So_sv As Integer
                dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
                If Not dvDanhSachSinhVien Is Nothing Then
                    So_sv = 0
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien(i)("Chon") Then
                            ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                            clsTCThi.Delete_TochucThiChiTiet(mID_thi, ID_sv)
                            So_sv += 1
                        End If
                    Next
                End If
                If So_sv > 0 Then
                    'Load lại danh sách sinh viên
                    Call trvPhongThi_Select()
                    Thongbao("Đã xoá thành công " + So_sv.ToString + " sinh viên ra khỏi danh sách thi !")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    Dim dt As DataTable = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH SINH VIÊN THI HỌC KỲ " & mHoc_ky & " LẦN THI " & mLan_thi
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi

                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim rpt As New rpt_DS_ToChucThi(dtDiemTH, dtTP)
                rpt.DataSource = dtDiemTH
                PrintXtraReport(rpt)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    Dim dt As DataTable = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH SINH VIÊN DỰ THI"
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim rpt As New rpt_DS_ToChucThi_Mau2(dtDiemTH, dtTP)
                rpt.DataSource = dtDiemTH
                PrintXtraReport(rpt)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    Dim dt As DataTable = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim Tieu_de_BC As String = ""
                If ckIn_ds_luanvan.Checked = True Then
                    Tieu_de_BC = "DANH SÁCH SINH VIÊN DỰ THI MÔN "
                Else
                    Tieu_de_BC = "DANH SÁCH SINH VIÊN DỰ THI MÔN "
                End If
                Dim rpt3 As New rpt_DS_ToChucThiPhach(dtDiemTH, dtTP, Tieu_de_BC)
                rpt3.DataSource = dtDiemTH
                PrintXtraReport(rpt3)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    Dim dt As DataTable = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim Tieu_de_BC As String = ""
                If ckIn_ds_luanvan.Checked = True Then
                    Tieu_de_BC = "DANH SÁCH BẢO VỆ ĐỒ ÁN/KHÓA LUẬN MÔN "
                Else
                    Tieu_de_BC = "DANH SÁCH THI MÔN "
                End If
                Dim rpt3 As New rpt_DS_ToChucThiPhach_THNghe(dtDiemTH, dtTP, Tieu_de_BC)
                rpt3.DataSource = dtDiemTH
                PrintXtraReport(rpt3)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachThi.DataSource Is Nothing Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mThoi_gian, mThoi_gian_lam_bai As String
                mID_he = trvPhongThi.ID_he
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                Dim mTen_he As String = trvPhongThi.Ten_he
                Dim dtDanhSachSinhVien As DataTable
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    'Load dữ liệu về tổ chức thi
                    Dim clsTCT As New TochucThi_BLL
                    ' Check nếu ID_phong > 0 thì Load danh sách tổ chức thi pheo phòng còn không check theo cả khóa đợt thi
                    Dim dt As DataTable
                    If mID_phong_thi > 0 Then
                        dt = clsTCT.Load_ToChucThi_Phong(mID_phong_thi)
                    Else
                        dt = clsTCT.Load_ToChucThi_TheoDot(mID_thi)
                    End If
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                        mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    End If
                    'clsTCThi = New TochucThi_BLL(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi").ToString
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet").ToString
                    '    mThoi_gian = dt.Rows(0).Item("Thoi_gian").ToString
                    '    mThoi_gian_lam_bai = dt.Rows(0).Item("Thoi_gian_lam_bai").ToString
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        Dim dsID_dt As String = ""
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                dsID_dt += dtDanhSachSinhVien.Rows(i)("ID_dt").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        If dsID_dt <> "" Then dsID_dt = Mid(dsID_dt, 1, Len(dsID_dt) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_BLL(mID_he, ID_dv, 0, mHoc_ky, mNam_hoc, dsID_lop, dsID_dt, dtDanhSachSinhVien)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, 1)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If
                dtDiemTH.Columns.Add("Tieu_de", GetType(String))
                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(Integer))
                dtDiemTH.Columns.Add("Ten_he", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian", GetType(String))
                dtDiemTH.Columns.Add("Thoi_gian_lam_bai", GetType(String))
                dtDiemTH.Columns.Add("Khong_du_dk_thi", GetType(String))
                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    If mNgay_thi.ToString <> "" Then
                        dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    End If
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ten_he") = mTen_he
                    dtDiemTH.Rows(i).Item("Thoi_gian") = mThoi_gian
                    dtDiemTH.Rows(i).Item("Thoi_gian_lam_bai") = mThoi_gian_lam_bai
                    dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = dtDiemTH.Rows(i).Item("Ghi_chu_thi")
                    If dtDiemTH.Rows(i).Item("Khong_du_dk_thi") <> "" Then dtDiemTH.Rows(i).Item("Khong_du_dk_thi") = "X"
                Next
                Dim dtTP As DataTable = clsDiem.MARK_LietKeCacDiemThanhPhan_Load(mHoc_ky, mNam_hoc)
                'Dim dtDiemTH_Sort As DataTable = dtDiemTH.Copy
                dtDiemTH.DefaultView.Sort = "So_bao_danh"
                Dim Tieu_de_BC As String = "DANH SÁCH  SINH VIÊN ĐƯỢC CÔNG NHẬN TỐT NGHIỆP MÔN" & trvPhongThi.Ten_mon.ToString.ToUpper
                Dim rpt3 As New rpt_DS_ToChucThiPhach_CoDiem(dtDiemTH, dtTP, Tieu_de_BC)
                rpt3.DataSource = dtDiemTH
                PrintXtraReport(rpt3)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnAll_diem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAll_diem.ItemClick
        'Try
        '    Dim ID_dv As String = gobjUser.ID_dv
        '    Dim ID_he As Integer = trvPhongThi.ID_he

        '    Dim Tieu_de1, Tieu_de2 As String
        '    Dim dtMonHoc As DataTable

        '    Dim obj As DanhSachTotNghiep_BLL = New DanhSachTotNghiep_BLL
        '    Dim dtSV_ChuaDat As DataTable = obj.DanhSach_ChuaDat_TotNghiep(dsID_lop_TN, cmbNam_hoc.Text)

        '    If dtSV_ChuaDat.Rows.Count > 0 Then
        '        clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, dtSV_ChuaDat)
        '        Dim dt As DataTable = clsDiem.TongHopMonThiTotNghiep(False, 2, False)
        '        Tieu_de1 = "DSSV CHƯA ĐẠT KẾT QUẢ THI TỐT NGHIỆP LẦN " & cmbLan_thu.Text & " NĂM HỌC " & cmbNam_hoc.Text
        '        Tieu_de2 = khoa_hoc & TrvLop_ChuanHoa1.Tieu_de
        '        dtMonHoc = clsDiem.DanhSachMonTotNghiep
        '        If dt.Rows.Count > 0 Then
        '            Dim rpt As New rptDanhSach_ChuaDat_TotNghiep(dt, dtMonHoc, Tieu_de1, Tieu_de2)
        '            rpt.DataSource = dt
        '            PrintXtraReport(rpt)
        '        Else
        '            Thongbao("Chưa có sinh viên nào để In !", MsgBoxStyle.Information, "Thông báo")
        '            Exit Sub
        '        End If
        '    Else
        '        Thongbao("Chưa có sinh viên nào để In!")
        '        Exit Sub
        '    End If
        'Catch
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub btnExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grdViewDanhSachThi)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnTongHopSVThiChinhTri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTongHopSVThiChinhTri.Click
        Dim frm As New frmTongHopSinhVienThiTotNghiepChinhTri
        frm.ShowDialog()
    End Sub
     
    Private Sub cmdPhieuTheoDoi_LyThuyet_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPhieuTheoDoi_LyThuyet.ItemClick

    End Sub

    Private Sub btnPhieuTheoDoiKetQua_DanPT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPhieuTheoDoiKetQua_DanPT.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "PHIẾU THEO DÕI KẾT QUẢ KIỂM TRA HỌC KỲ " & trvPhongThi.Hoc_ky & " NĂM HỌC " & trvPhongThi.Nam_hoc
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = "Môn học/mô-đun: " & dtMonHoc.Rows(0)("Ten_mon")
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rpt_DS_ToChucThi_PhieuTheoDoi_LyThuyet(dv, dtPlus)
            PrintXtraReport(rpt)
            'If cmbID_mon.Text <> "" Then
            '    
            '    PrintXtraReport(rpt)
            'End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnPhieuTheoDoiKetQua_BC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPhieuTheoDoiKetQua_BC.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "PHIẾU THEO DÕI KẾT QUẢ KIỂM TRA HỌC KỲ " & trvPhongThi.Hoc_ky & " NĂM HỌC " & trvPhongThi.Nam_hoc
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = "Môn học/mô-đun: " & dtMonHoc.Rows(0)("Ten_mon")
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rpt_DS_ToChucThi_PhieuTheoDoi_LyThuyet_BC(dv, dtPlus)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTotNghiepLT_DanPhong.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "PHIẾU THEO DÕI KẾT QUẢ THI TỐT NGHIỆP NĂM HỌC " & trvPhongThi.Nam_hoc & " HỆ " & newRow("Ten_he").ToString().ToUpper()
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = dtMonHoc.Rows(0)("Ten_mon") & "(LỚP: " & newRow("Ten_lop").ToString() & " )"
                newRow("Ten_mon") = "MÔN THI: " & newRow("Ten_mon").ToString().ToUpper()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rptTotNghiepLyThuyet_DanPhong(dv, dtPlus)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnTotNghiep_LT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTotNghiep_LT.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "PHIẾU THEO DÕI KẾT QUẢ THI TỐT NGHIỆP NĂM HỌC " & trvPhongThi.Nam_hoc & " HỆ " & newRow("Ten_he").ToString().ToUpper()
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = dtMonHoc.Rows(0)("Ten_mon") & "(LỚP: " & newRow("Ten_lop").ToString() & " )"
                newRow("Ten_mon") = "MÔN THI: " & newRow("Ten_mon").ToString().ToUpper()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rptTotNghiepLyThuyet(dv, dtPlus)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "DANH SÁCH KIỂM TRA HỌC KỲ " & trvPhongThi.Hoc_ky & " NĂM HỌC " & trvPhongThi.Nam_hoc
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = dtMonHoc.Rows(0)("Ten_mon") & "(LỚP: " & newRow("Ten_lop").ToString() & " )"
                newRow("Ten_mon") = "MÔN THI: " & newRow("Ten_mon").ToString().ToUpper()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rptTotNghiepLyThuyet(dv, dtPlus)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Try
            GetReportHeader()
            Dim dv As DataView = grcViewDanhSachThi.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_phong_thi As Integer = trvPhongThi.ID_phong_thi
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtPhongThi As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_TochucThiPhong WHERE ID_phong_thi=" & ID_phong_thi)
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim dtHe As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_He WHERE ID_he=" & trvPhongThi.ID_he)
            Dim dtPlus As New DataTable
            dtPlus.Columns.Add("Ten_mon")
            dtPlus.Columns.Add("Ten_lop")
            dtPlus.Columns.Add("Thoi_gian_thi")
            dtPlus.Columns.Add("Ngay_thi")
            dtPlus.Columns.Add("Phong_thi")
            dtPlus.Columns.Add("Tieu_de_bao_cao")
            dtPlus.Columns.Add("Ten_he")
            Dim newRow As DataRow = dtPlus.NewRow
            If dtHe.Rows.Count > 0 Then
                newRow("Ten_he") = dtHe.Rows(0)("Ten_he")
            End If
            newRow("Tieu_de_bao_cao") = "DANH SÁCH DỰ THI TỐT NGHIỆP NĂM HỌC " & trvPhongThi.Nam_hoc & " HỆ " & newRow("Ten_he").ToString().ToUpper()
            If dtPhongThi.Rows.Count > 0 Then
                newRow("Phong_thi") = dtPhongThi.Rows(0)("Ten_phong")
                newRow("Thoi_gian_thi") = dtPhongThi.Rows(0)("Thoi_gian")
                newRow("Ngay_thi") = DateTime.Parse(dtPhongThi.Rows(0)("Ngay_thi").ToString()).Date.ToShortDateString()
            End If
            If dv.Count > 0 Then
                newRow("Ten_lop") = dv.Item(0)("Ten_lop").ToString()
            End If
            If dtMonHoc.Rows.Count > 0 Then
                newRow("Ten_mon") = dtMonHoc.Rows(0)("Ten_mon") & "(LỚP: " & newRow("Ten_lop").ToString() & " )"
                newRow("Ten_mon") = "MÔN THI: " & newRow("Ten_mon").ToString().ToUpper()
            End If
            dtPlus.Rows.Add(newRow)
            Dim rpt As New rptTotNghiepLyThuyet(dv, dtPlus)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class