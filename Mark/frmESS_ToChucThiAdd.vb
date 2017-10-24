Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_ToChucThiAdd
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_he As Integer = 0
    Private mLan_thi As Integer = 0
    Private mDot_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mTen_lop_tc As String = ""
    Private mNien_khoa As String = ""
    Private mKhoa_hoc As Integer = 0
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private clsTCThi As New TochucThi_BLL
    Private dv_phong_chon As DataView
#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ToChucThiAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
        LoadComboBox()
        'Đặt học kỳ, năm hoc theo giá trị ở form tổ chức thi chính
        cmbHoc_ky.SelectedValue = mHoc_ky
        cmbNam_hoc.Text = mNam_hoc
        cmbOrder.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        cmbDot_thi.SelectedIndex = 0
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TrvLop_ChuanHoa.Load_TreeView()
        'SetUpDataGridView(grdViewDanhSachThi)
        Loader = True
    End Sub
    Private Sub frmESS_ToChucThiAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TrvLop_ChuanHoa_Select() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If Loader Then
                If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
                    dsID_lop = TrvLop_ChuanHoa.ID_lop_list
                    dsID_dt = TrvLop_ChuanHoa.ID_dt_list
                    mNien_khoa = TrvLop_ChuanHoa.Nien_khoa
                    mID_he = TrvLop_ChuanHoa.ID_he
                    mKhoa_hoc = TrvLop_ChuanHoa.Khoa_hoc
                    'Load danh sách các môn trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        clsCTDT = New ChuongTrinhDaoTao_BLL(dsID_dt, gobjUser.ID_Bomon)
                        'Load môn học vào Combobox
                        Add_MonHoc()
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub chkHienThiAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHienThiAll.CheckedChanged
        Add_MonHoc()
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

    Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thi.SelectedIndexChanged, cmbDot_thi.SelectedIndexChanged, cmbID_mon.SelectedIndexChanged
        If Loader Then
            If cmbID_mon.Text.Trim <> "" Then mID_mon = cmbID_mon.SelectedValue
            If mHoc_ky > 0 And mNam_hoc <> "" And mID_mon > 0 And cmbLan_thi.SelectedItem > 0 And cmbDot_thi.SelectedItem > 0 And cmbID_mon.SelectedValue > 0 Then
                'If (clsTCThi.Count = 0) Or (cmbLan_thi.SelectedItem <> mLan_thi) Or (cmbDot_thi.SelectedItem <> mDot_thi) Then
                mLan_thi = cmbLan_thi.SelectedItem
                mDot_thi = cmbDot_thi.SelectedItem
                'Xoa thong tin to chuc thi 
                If clsTCThi.Count > 0 Then
                    For i As Integer = 0 To clsTCThi.Count - 1
                        clsTCThi.Remove(i)
                    Next
                End If
                'Kiểm tra xem môn này đã được tổ chức thi chưa?
                Dim ID_thi As Integer
                Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                If dt_TTT.Rows.Count > 0 Then
                    ID_thi = dt_TTT.Rows(0).Item("ID_thi")
                Else
                    ID_thi = -1
                End If

                'Môn này đã tổ chức thi rồi
                If ID_thi > 0 Then
                    'Load lại dữ liệu đã tổ chức thi
                    clsTCThi = New TochucThi_BLL(ID_thi)
                    Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(0).ID_thi).DefaultView
                    txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count
                    txtSo_phong.Text = clsTCThi.ToChucThi(0).dsPhongThi.Count
                    dtpNgay_thi.Value = clsTCThi.ToChucThi(0).Ngay_thi
                    cmbCa.SelectedIndex = clsTCThi.ToChucThi(0).Ca_thi
                    cmbNhom_tiet.SelectedIndex = clsTCThi.ToChucThi(0).Nhom_tiet
                    txtThoi_gian.Text = clsTCThi.ToChucThi(0).Thoi_gian
                    txtThoi_gian.Text = clsTCThi.ToChucThi(0).Thoi_gian_lam_bai

                    'dv_phong_chon.Table = New DataTable
                    'dv_phong_chon.Table.Columns.Add("ID_phong_thi", GetType(Integer))
                    'dv_phong_chon.Table.Columns.Add("ID_phong", GetType(Integer))
                    'dv_phong_chon.Table.Columns.Add("Ten_phong_main", GetType(String))
                    'dv_phong_chon.Table.Columns.Add("Suc_chua", GetType(Integer))
                    'dv_phong_chon.Table.Columns.Add("So_sv", GetType(Integer))
                    'dv_phong_chon.Table.Columns.Add("Chon", GetType(Boolean))
                    'For i As Integer = 0 To clsTCThi.ToChucThi(0).dsPhongThi.Count - 1
                    '    Dim dr As DataRow = dv_phong_chon.Table.NewRow
                    '    dr("Chon") = False
                    '    dr("ID_phong_thi") = clsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(i).ID_phong_thi
                    '    dr("ID_phong") = clsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(i).ID_phong
                    '    If dt.DefaultView.Item(i)("Suc_chua").ToString <> "" Then
                    '        dr("Suc_chua") = dt.DefaultView.Item(i)("Suc_chua")
                    '    Else
                    '        dr("Suc_chua") = 0
                    '    End If
                    '    dr("So_sv") = 0
                    '    dr("Ten_phong_main") = dt.DefaultView.Item(i)("Ten_nha").ToString & "-" & dt.DefaultView.Item(i)("So_phong").ToString
                    '    dt_main.Rows.Add(dr)
                    'Next
                Else
                    dv_phong_chon = Nothing
                    Dim objTCThi As New TochucThi
                    objTCThi.Hoc_ky = mHoc_ky
                    objTCThi.Nam_hoc = mNam_hoc
                    objTCThi.ID_he = mID_he
                    objTCThi.ID_khoa = 0
                    objTCThi.Lan_thi = mLan_thi
                    objTCThi.Dot_thi = mDot_thi
                    objTCThi.ID_mon = mID_mon
                    objTCThi.Ngay_thi = dtpNgay_thi.Value
                    objTCThi.Ca_thi = cmbCa.SelectedIndex
                    objTCThi.Nhom_tiet = cmbNhom_tiet.SelectedIndex
                    objTCThi.Thoi_gian = txtThoi_gian.Text
                    objTCThi.Thoi_gian_lam_bai = txtThoi_gian_lam_bai.Text
                    clsTCThi.Add(objTCThi)
                    Me.grcViewDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                End If
                'End If
            End If
        End If


    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnChon_phongthi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckValidate() Then
        Dim frmESS_ As New frmESS_ToChucThiPhong
        frmESS_.ShowDialog(clsTCThi, CType(txtSo_sv.Text, Integer))
        Dim idx_thi As Integer = 0
        If frmESS_.Tag = 1 Then
            dv_phong_chon = frmESS_.grdViewPhongThi.DataSource
        End If
    End Sub
#End Region

#Region "User Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try
            Dim dt As DataTable
            'Lấy tất cả các môn trong chương trình đào tạo khung
            If chkHienThiAll.Checked Then
                dt = clsCTDT.DanhSachMonHoc()
                'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            Else    'Lấy các môn trong chương trình đào tạo khung theo học kỳ, năm học
                Dim Ky_thu As Integer
                Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                Dim Nam_hoc As String = cmbNam_hoc.Text
                Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
                If Ky_thu > 0 Then
                    dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                    'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
                    If Not CompareData(dt, cmbID_mon.DataSource) Then
                        FillCombo(cmbID_mon, dt)
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckValidate() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        If txtSo_sv.Text = "" Or txtSo_sv.Text = "0" Then
            Call SetErrPro(txtSo_sv, ErrorProvider1, "Bạn phải bổ sung sinh viên trước !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_sv
        End If
        If cmbCa.Text.Trim = "" Then
            Call SetErrPro(cmbCa, ErrorProvider1, "Bạn hãy chọn nhập Ca thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbCa
        End If
        If dtpNgay_thi.Checked = False Then
            Call SetErrPro(dtpNgay_thi, ErrorProvider1, "Bạn hãy chọn ngày thi !")
            If CtrlErr Is Nothing Then CtrlErr = dtpNgay_thi
        End If
        If cmbID_mon.Text.Trim = "" Then
            Call SetErrPro(cmbID_mon, ErrorProvider1, "Bạn hãy chọn học phần !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_mon
        End If
        If cmbNhom_tiet.Text = "" Then
            Call SetErrPro(cmbNhom_tiet, ErrorProvider1, "Bạn hãy chọn nhập nhóm tiết thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNhom_tiet
        End If
        'If IsNumeric(txtThoi_gian_lam_bai.Text) <> "" Then
        '    Call SetErrPro(txtThoi_gian_lam_bai, ErrorProvider1, "Bạn nhập sai thời gian !")
        '    If CtrlErr Is Nothing Then CtrlErr = txtThoi_gian_lam_bai
        'End If
        'If CInt(txtThoi_gian_lam_bai.Text.Trim) <= 0 Then
        '    Call SetErrPro(txtThoi_gian_lam_bai, ErrorProvider1, "Thời gian làm bài phải > 0 !")
        '    If CtrlErr Is Nothing Then CtrlErr = txtThoi_gian_lam_bai
        'End If
        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckValidate = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckValidate = False
        CtrlErr.Focus()
    End Function
    Private Function CompareData(ByVal dt As DataTable, ByVal dt1 As DataTable) As Boolean
        If dt Is Nothing Or dt1 Is Nothing Then Return False
        If dt.Rows.Count <> dt1.Rows.Count Then Return False
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_mon") <> dt1.Rows(i)("ID_mon") Then
                Return False
            End If
        Next
        Return True
    End Function
#End Region

    Private Sub cmdLopTinChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TrvLop_ChuanHoa.SendToBack()
        cmbID_mon.DataSource = Nothing
        chkHienThiAll.Enabled = False

        cmbHoc_ky.Enabled = False
        cmbNam_hoc.Enabled = False
        cmbID_mon.Enabled = False
    End Sub

    Private Sub cmdLopHC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chkHienThiAll.Enabled = True

        cmbHoc_ky.Enabled = True
        cmbNam_hoc.Enabled = True
        cmbID_mon.Enabled = True
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim ID_thi_tmp As Integer = 0
                    Dim Edit As Boolean = False
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        ID_thi_tmp = dt_TTT.Rows(0).Item("ID_thi")
                        If (cmbCa.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Ca_thi")), 0, dt_TTT.Rows(0).Item("Ca_thi")) Or cmbNhom_tiet.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Nhom_tiet")), 0, dt_TTT.Rows(0).Item("Nhom_tiet")) Or dtpNgay_thi.Value <> dt_TTT.Rows(0).Item("Ngay_thi").ToString) Then
                            Edit = True
                            clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, txtThoi_gian_lam_bai.Text)
                        End If
                    Else
                        clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, txtThoi_gian_lam_bai.Text)
                    End If
                    Dim idx_thi As Integer = 0
                    Dim dv As DataView = grdViewDanhSachThi.DataSource
                    clsTCThi.Fill_GhiChu(dv, ID_thi_tmp)
                    clsTCThi.TocChucThi(idx_thi, txtSo_sv.Text, Convert.ToInt32(cmbDot_thi.Text), dtpNgay_thi.Value, cmbCa.SelectedIndex, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, cmbOrder.SelectedIndex, ID_thi_tmp, Edit, dv_phong_chon)
                    'Load lại danh sách sinh viên
                    Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                    Me.Tag = 1
                    Thongbao("Đã tổ chức thi thành công")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If clsTCThi.Count > 0 Then
            Dim frmESS_ As New frmESS_ToChucThiThemSinhVien
            frmESS_.ShowDialog(mHoc_ky, mNam_hoc, mLan_thi, mID_mon)
            If frmESS_.Tag = 1 Then
                Dim dtDanhSachSinhVien As New DataTable
                Dim objTCThi As New TochucThi
                dtDanhSachSinhVien = frmESS_.grdViewDanhSachChon.DataSource.Table

                Dim clsDiem As Diem_BLL
                Dim dt_KDDKDT, dt_KDDKDT_HocTap As DataTable
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien)
                dt_KDDKDT_HocTap = clsDiem.DanhSachKhongDuDieuKienDuThiHocPhan(1, mID_mon)

                objTCThi = clsTCThi.ToChucThi(0)
                dt_KDDKDT = clsTCThi.DanhSachKDDK_DuThi(dsID_lop, mHoc_ky, mNam_hoc, dt_KDDKDT_HocTap)
                dt_KDDKDT.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                    dt_KDDKDT.DefaultView.RowFilter = "1=1"
                    If chkDieuKienThi.Checked Then
                        If dt_KDDKDT.DefaultView.Find(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 AndAlso objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New TochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then
                                objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            End If
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    Else
                        If objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New TochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then
                                objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            End If
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            'Tim neu trong danh sach KDDKDT thi update Ghi chu
                            dt_KDDKDT.DefaultView.RowFilter = "ID_SV=" & objTCThiChiTiet.ID_sv
                            If dt_KDDKDT.DefaultView.Count > 0 Then objTCThiChiTiet.Ghi_chu_thi = dt_KDDKDT.DefaultView.Item(0)("Ly_do").ToString
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    End If
                Next
                'Load lai danh sach sinh vien
                Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count
            End If
        Else
            Thongbao("Bạn phải nhập lần thi, đợt thi và môn thi để tổ chức thi!")
        End If
    End Sub

    Private Sub btnDel_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dvDanhSachSinhVien As DataView
            dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
            If Not dvDanhSachSinhVien Is Nothing Then
                Dim So_sv As Integer = 0
                If clsTCThi.Count > 0 Then
                    Dim objTCThi As New TochucThi
                    Dim idx_sv As Integer
                    objTCThi = clsTCThi.ToChucThi(0)
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien.Item(i)("Chon") Then
                            idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv"))
                            If idx_sv >= 0 Then
                                objTCThi.dsChiTietSinhVien.Remove(idx_sv)
                                So_sv += 1
                            End If
                        End If
                    Next
                    'Load lai danh sach sinh vien
                    Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                    txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count
                End If
                If So_sv > 0 Then
                    Thongbao("Đã xoá khỏi danh sách tổ chức thi " + So_sv.ToString + " sinh viên ")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        clsTCThi.UpdateLai_TochucThi(dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, dt_TTT.Rows(0).Item("ID_thi"))
                        Thongbao("Đã cập nhật thành công thông tin tổ chức thi thành công")
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If clsTCThi.Count > 0 Then
                Dim So_dau As String
                So_dau = InputBox("Nhập số bắt đầu của số báo danh:", "", 1)
                If IsNumeric(So_dau) Then
                    If So_dau > 0 Then

                        Dim idx_thi As Integer = 0
                        clsTCThi.LapSoBaoDanh(idx_thi, So_dau, cmbOrder.SelectedIndex)
                        'Load lai danh sach sinh vien với số báo danh mới
                        Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView

                    Else
                        Thongbao("Bạn phải nhập bắt đầu số báo danh lớn hơn 0")
                    End If
                Else
                    Thongbao("Bạn phải nhập số báo danh là chữ số")
                End If
            Else
                Thongbao("Bạn phải có danh sách sinh viên để lập số báo danh")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnPrint1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim ID_thi_tmp As Integer = 0
                    Dim Edit As Boolean = False
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        ID_thi_tmp = dt_TTT.Rows(0).Item("ID_thi")
                        If (cmbCa.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Ca_thi")), 0, dt_TTT.Rows(0).Item("Ca_thi")) Or cmbNhom_tiet.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Nhom_tiet")), 0, dt_TTT.Rows(0).Item("Nhom_tiet")) Or dtpNgay_thi.Value <> dt_TTT.Rows(0).Item("Ngay_thi").ToString) Then
                            Edit = True
                            clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, txtThoi_gian_lam_bai.Text)
                        End If
                    Else
                        clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, txtThoi_gian_lam_bai.Text)
                    End If
                    Dim idx_thi As Integer = 0
                    Dim dv As DataView = grdViewDanhSachThi.DataSource
                    clsTCThi.Fill_GhiChu(dv, ID_thi_tmp)
                    clsTCThi.TocChucThi(idx_thi, txtSo_sv.Text, Convert.ToInt32(cmbDot_thi.Text), dtpNgay_thi.Value, cmbCa.SelectedIndex, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, cmbOrder.SelectedIndex, ID_thi_tmp, Edit, dv_phong_chon)
                    'Load lại danh sách sinh viên
                    Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                    Me.Tag = 1
                    Thongbao("Đã tổ chức thi thành công")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnToTucThi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToTucThi.Click
        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        clsTCThi.UpdateLai_TochucThi(dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtThoi_gian.Text, dt_TTT.Rows(0).Item("ID_thi"))
                        Thongbao("Đã cập nhật thành công thông tin tổ chức thi thành công")
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_sv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_sv.Click
        If clsTCThi.Count > 0 Then
            Dim frmESS_ As New frmESS_ToChucThiThemSinhVien
            frmESS_.ShowDialog(mHoc_ky, mNam_hoc, mLan_thi, mID_mon)
            If frmESS_.Tag = 1 Then
                Dim dtDanhSachSinhVien As New DataTable
                Dim objTCThi As New TochucThi
                dtDanhSachSinhVien = frmESS_.grdViewDanhSachChon.DataSource.Table

                Dim clsDiem As Diem_BLL
                Dim dt_KDDKDT, dt_KDDKDT_HocTap As DataTable
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien)
                dt_KDDKDT_HocTap = clsDiem.DanhSachKhongDuDieuKienDuThiHocPhan(1, mID_mon)

                objTCThi = clsTCThi.ToChucThi(0)
                dt_KDDKDT = clsTCThi.DanhSachKDDK_DuThi(dsID_lop, mHoc_ky, mNam_hoc, dt_KDDKDT_HocTap)
                dt_KDDKDT.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                    dt_KDDKDT.DefaultView.RowFilter = "1=1"
                    If chkDieuKienThi.Checked Then
                        If dt_KDDKDT.DefaultView.Find(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 AndAlso objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New TochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            objTCThiChiTiet.Ho_dem = dtDanhSachSinhVien.Rows(i)("Ho_dem")
                            objTCThiChiTiet.Ten = dtDanhSachSinhVien.Rows(i)("Ten")
                            objTCThiChiTiet.Van_dau = dtDanhSachSinhVien.Rows(i)("Van_dau")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then
                                objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            End If
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    Else
                        If objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New TochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            objTCThiChiTiet.Ho_dem = dtDanhSachSinhVien.Rows(i)("Ho_dem")
                            objTCThiChiTiet.Ten = dtDanhSachSinhVien.Rows(i)("Ten")
                            objTCThiChiTiet.Van_dau = dtDanhSachSinhVien.Rows(i)("Van_dau")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then
                                objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            End If
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            'Tim neu trong danh sach KDDKDT thi update Ghi chu
                            dt_KDDKDT.DefaultView.RowFilter = "ID_SV=" & objTCThiChiTiet.ID_sv
                            If dt_KDDKDT.DefaultView.Count > 0 Then objTCThiChiTiet.Ghi_chu_thi = dt_KDDKDT.DefaultView.Item(0)("Ly_do").ToString
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    End If
                Next
                'Load lai danh sach sinh vien
                Dim dvDSSV As DataView = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                dvDSSV.Sort = "Van_dau,Ten,Ho_Dem"
                Me.grcViewDanhSachThi.DataSource = dvDSSV
                txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count
            End If
        Else
            Thongbao("Bạn phải nhập lần thi, đợt thi và môn thi để tổ chức thi!")
        End If
    End Sub

    Private Sub btnDel_sv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel_sv.Click
        Try
            Dim dvDanhSachSinhVien As DataView
            dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
            If Not dvDanhSachSinhVien Is Nothing Then
                Dim So_sv As Integer = 0
                If clsTCThi.Count > 0 Then
                    Dim objTCThi As New TochucThi
                    Dim idx_sv As Integer
                    objTCThi = clsTCThi.ToChucThi(0)
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien.Item(i)("Chon") Then
                            idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv"))
                            If idx_sv >= 0 Then
                                objTCThi.dsChiTietSinhVien.Remove(idx_sv)
                                So_sv += 1
                            End If
                        End If
                    Next
                    'Load lai danh sach sinh vien
                    Me.grcViewDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                    txtSo_sv.Text = Me.grdViewDanhSachThi.DataSource.Count
                End If
                If So_sv > 0 Then
                    Thongbao("Đã xoá khỏi danh sách tổ chức thi " + So_sv.ToString + " sinh viên ")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            If clsTCThi.Count > 0 Then
                Dim So_dau As String
                So_dau = InputBox("Nhập số bắt đầu của số báo danh:", "", 1)
                If IsNumeric(So_dau) Then
                    If So_dau > 0 Then
                        Dim idx_thi As Integer = 0
                        clsTCThi.LapSoBaoDanh(idx_thi, So_dau, cmbOrder.SelectedIndex)
                        'Load lai danh sach sinh vien với số báo danh mới
                        'If chkDieuKienThi.Checked Then
                        '    Dim dv As DataView = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                        '    dv.RowFilter = "Ghi_chu_thi = ''"
                        '    Me.grdViewDanhSachThi.DataSource = dv
                        'Else
                        Dim dvDSSV As DataView = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                        dvDSSV.Sort = "Van_dau,Ten,Ho_dem"
                        Me.grcViewDanhSachThi.DataSource = dvDSSV
                        'End If
                    Else
                        Thongbao("Bạn phải nhập bắt đầu số báo danh lớn hơn 0")
                    End If
                Else
                    Thongbao("Bạn phải nhập số báo danh là chữ số")
                End If
            Else
                Thongbao("Bạn phải có danh sách sinh viên để lập số báo danh")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub btnChon_phongthi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChon_phongthi.Click
        'If CheckValidate() Then
        Dim frmESS_ As New frmESS_ToChucThiPhong
        frmESS_.ShowDialog(clsTCThi, CType(txtSo_sv.Text, Integer))
        Dim idx_thi As Integer = 0
        If frmESS_.Tag = 1 Then
            dv_phong_chon = frmESS_.grdViewPhongThi.DataSource
        End If
    End Sub

    Private Sub chkDieuKienThi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDieuKienThi.CheckedChanged
        Dim dv As DataView = grdViewDanhSachThi.DataSource
        If dv.Count > 0 Then
            dv.RowFilter = "Ghi_chu_thi = ''"
            grcViewDanhSachThi.DataSource = dv
            txtSo_sv.Text = dv.Count
        End If
    End Sub
End Class