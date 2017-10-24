Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Catalogue
Imports ESS.Machine
Imports ESS.Entity
Imports DevExpress.XtraReports.UI

Public Class frmESS_NhapDiemThiLop
    Private mID_he As Integer = 0
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private mLan_thi As Integer = 1
    Dim xlsFileName As String = ""
    Private dt As New DataTable

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            Add_LanThi(cmbLan_thi, 3)
            'Set default lần học là 1
            cmbLan_hoc.SelectedIndex = 0
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            'If Ky_thu > 0 Then
            'dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            If gobjUser.ID_Bomon > 0 Then 'Chi load mon theo giang vien khi USER do thuoc Bo mon (phai phan quyen user do thuoc BM)
                dt = clsCTDT.DanhSachMonHoc(Ky_thu, Hoc_ky, Nam_hoc, gobjUser.UserName.Trim)
            Else
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            End If
            'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
            If Not CompareData(dt, cmbID_mon.DataSource) Then
                FillCombo(cmbID_mon, dt)
            End If
            'End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc(ByVal dsID_lops As String)
        Try
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            'If Ky_thu > 0 Then
            'dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            If gobjUser.ID_Bomon > 0 Then 'Chi load mon theo giang vien khi USER do thuoc Bo mon (phai phan quyen user do thuoc BM)
                dt = clsCTDT.DanhSachMonHoc(Ky_thu, Hoc_ky, Nam_hoc, gobjUser.UserName.Trim, dsID_lops)
            Else
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            End If
            'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
            If Not CompareData(dt, cmbID_mon.DataSource) Then
                FillCombo(cmbID_mon, dt)
            End If
            'End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
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
    Private Sub FormatDataView(ByVal dtKyHieuDiem As DataTable)
        Try
            grdViewDiem.Columns.Clear()
            'Trạng thái
            Dim col1 As New DataGridViewImageColumn
            With col1
                .Name = "imgLock"
                .HeaderText = "TT"
                .Width = 30
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sinh viên"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 200
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)

            'Các thành phần điểm
            Dim Tong_ty_le As Integer = 0
            For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    Dim col As New DataGridViewTextBoxColumn
                    With clsDiem.ThanhPhanDiem.ThanhPhanDiem(i)
                        col.Name = "TP" + .ID_thanh_phan.ToString
                        col.DataPropertyName = "TP" + .ID_thanh_phan.ToString
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 40
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                        col.ReadOnly = True
                        Tong_ty_le += .Ty_le
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            ''


            'TBCBP
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "TBCBP"
                .DataPropertyName = "TBCBP"
                .HeaderText = "TBCBP"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col5)
            'Điểm thi
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Diem_thi"
                .DataPropertyName = "Diem_thi"
                .HeaderText = "Thi"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'TBCHP
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "TBCHP"
                .DataPropertyName = "TBCHP"
                .HeaderText = "Điểm HP"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
                .DefaultCellStyle.Format = ".##"
            End With
            Me.grdViewDiem.Columns.Add(col7)
            ''
            'Các thành phần điểm THI
            For i As Integer = 0 To clsDiem.GetDsThanhPhanThi.Count - 1
                Dim col As New DataGridViewTextBoxColumn
                With clsDiem.GetDsThanhPhanThi(i)
                    col.Name = "Thi." + .ID_thanh_phan.ToString
                    col.DataPropertyName = "Thi." + .ID_thanh_phan.ToString
                    col.HeaderText = .Ky_hieu + " (" + .Phan_tram.ToString + ")"
                    col.ToolTipText = .Ten_thanh_phan
                    col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    col.Width = 60
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    col.DefaultCellStyle.NullValue = ""
                End With
                Me.grdViewDiem.Columns.Add(col)
            Next
            'Không đủ điều kiện thi
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "KhongDuDKThi"
                .DataPropertyName = "KhongDuDKThi"
                .HeaderText = "Không đủ ĐK Thi"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col4)

            'Văn hóa
            Dim col10 As New DataGridViewCheckBoxColumn
            With col10
                .Name = "Van_hoa"
                .DataPropertyName = "Van_hoa"
                .HeaderText = "Văn hóa"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col10)


            'Ghi chú
            Dim col8 As New DataGridViewComboBoxColumn
            With col8
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Ghi chú"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .MaxDropDownItems = 20
                .FlatStyle = FlatStyle.Standard
                .DropDownWidth = 80
                .DataSource = dtKyHieuDiem
                .ValueMember = "Ky_hieu"
                .DisplayMember = "Ky_hieu"
            End With
            Me.grdViewDiem.Columns.Add(col8)
            'Locked
            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col9)


        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Quyen_Khoa_Diem()
        Try
            Dim idx_quyen As Integer
            idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
            If idx_quyen >= 0 Then
                If gobjUser.Quyen.Quyen(idx_quyen).Xoa = 0 Then
                    'Disable nút khoá và mở khóa
                    cmdLock.Enabled = True
                    cmdUnLock.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ReadOnly_Diem()
        Try
            Dim idx_quyen As Integer
            idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
            If idx_quyen >= 0 Then
                If gobjUser.Quyen.Quyen(idx_quyen).Sua = 0 Then
                    'ReadOnly toan bo diem thi
                    For i As Integer = 0 To grdViewDiem.RowCount - 1
                        If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Or grdViewDiem.Rows(i).Cells("Ghi_chu").Value.ToString <> "" Then
                            grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub KhoaDuLieu(ByRef Lock_diem As Boolean)
        Try
            Lock_diem = False
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    If Lock_diem = False Then Lock_diem = True
                    grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Or grdViewDiem.Rows(i).Cells("Ghi_chu").Value.ToString <> "" Then    'Edit
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Edit
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    Else    'Add new
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Add
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    End If
                End If
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Function Doc_so(ByVal str As String) As String
        Select Case str
            Case "0" : Return "Không"
            Case "0.1" : Return "Không, một"
            Case "0.2" : Return "Không, hai"
            Case "0.3" : Return "Không, ba"
            Case "0.4" : Return "Không, bốn"
            Case "0.5" : Return "Không, năm"
            Case "0.6" : Return "Không, sáu"
            Case "0.7" : Return "Không, bảy"
            Case "0.8" : Return "Không, tám"
            Case "0.9" : Return "Không, chín"

            Case "1" : Return "Một"
            Case "1.1" : Return "Một, một"
            Case "1.2" : Return "Một, hai"
            Case "1.3" : Return "Một, ba"
            Case "1.4" : Return "Một, bốn"
            Case "1.5" : Return "Một, năm"
            Case "1.6" : Return "Một, sáu"
            Case "1.7" : Return "Một, bảy"
            Case "1.8" : Return "Một, tám"
            Case "1.9" : Return "Một, chín"

            Case "2" : Return "Hai"
            Case "2.1" : Return "Hai, một"
            Case "2.2" : Return "Hai, hai"
            Case "2.3" : Return "Hai, ba"
            Case "2.4" : Return "Hai, bốn"
            Case "2.5" : Return "Hai, năm"
            Case "2.6" : Return "Hai, sáu"
            Case "2.7" : Return "Hai, bảy"
            Case "2.8" : Return "Hai, tám"
            Case "2.9" : Return "Hai, chín"

            Case "3" : Return "Ba"
            Case "3.1" : Return "Ba, một"
            Case "3.2" : Return "Ba, hai"
            Case "3.3" : Return "Ba, ba"
            Case "3.4" : Return "Ba, bốn"
            Case "3.5" : Return "Ba, năm"
            Case "3.6" : Return "Ba, sáu"
            Case "3.7" : Return "Ba, bảy"
            Case "3.8" : Return "Ba, tám"
            Case "3.9" : Return "Ba, chín"

            Case "4" : Return "Bốn"
            Case "4.1" : Return "Bốn, một"
            Case "4.2" : Return "Bốn, hai"
            Case "4.3" : Return "Bốn, ba"
            Case "4.4" : Return "Bốn, bốn"
            Case "4.5" : Return "Bốn, năm"
            Case "4.6" : Return "Bốn, sáu"
            Case "4.7" : Return "Bốn, bảy"
            Case "4.8" : Return "Bốn, tám"
            Case "4.9" : Return "Bốn, chín"

            Case "5" : Return "Năm"
            Case "5.1" : Return "Năm, một"
            Case "5.2" : Return "Năm, hai"
            Case "5.3" : Return "Năm, ba"
            Case "5.4" : Return "Năm, bốn"
            Case "5.5" : Return "Năm, năm"
            Case "5.6" : Return "Năm, sáu"
            Case "5.7" : Return "Năm, bảy"
            Case "5.8" : Return "Năm, tám"
            Case "5.9" : Return "Năm, chín"

            Case "6" : Return "Sáu"
            Case "6.1" : Return "Sáu, một"
            Case "6.2" : Return "Sáu, hai"
            Case "6.3" : Return "Sáu, ba"
            Case "6.4" : Return "Sáu, bốn"
            Case "6.5" : Return "Sáu, năm"
            Case "6.6" : Return "Sáu, sáu"
            Case "6.7" : Return "Sáu, bảy"
            Case "6.8" : Return "Sáu, tám"
            Case "6.9" : Return "Sáu, chín"

            Case "7" : Return "Bẩy"
            Case "7.1" : Return "Bẩy, một"
            Case "7.2" : Return "Bẩy, hai"
            Case "7.3" : Return "Bẩy, ba"
            Case "7.4" : Return "Bẩy, bốn"
            Case "7.5" : Return "Bẩy, năm"
            Case "7.6" : Return "Bẩy, sáu"
            Case "7.7" : Return "Bẩy, bảy"
            Case "7.8" : Return "Bẩy, tám"
            Case "7.9" : Return "Bẩy, chín"

            Case "8" : Return "Tám"
            Case "8.1" : Return "Tám, một"
            Case "8.2" : Return "Tám, hai"
            Case "8.3" : Return "Tám, ba"
            Case "8.4" : Return "Tám, bốn"
            Case "8.5" : Return "Tám, năm"
            Case "8.6" : Return "Tám, sáu"
            Case "8.7" : Return "Tám, bảy"
            Case "8.8" : Return "Tám, tám"
            Case "8.9" : Return "Tám, chín"

            Case "9" : Return "Chín"
            Case "9.1" : Return "Chín, một"
            Case "9.2" : Return "Chín, hai"
            Case "9.3" : Return "Chín, ba"
            Case "9.4" : Return "Chín, bốn"
            Case "9.5" : Return "Chín, năm"
            Case "9.6" : Return "Chín, sáu"
            Case "9.7" : Return "Chín, bảy"
            Case "9.8" : Return "Chín, tám"
            Case "9.9" : Return "Chín, chín"

            Case "10" : Return "Mười"
        End Select
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TrvLop_ChuanHoa.Load_TreeView()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, btnSave, , btnDel)
            Quyen_Khoa_Diem()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemThiLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TrvLop_ChuanHoa_Select() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If Loader Then
                If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
                    mID_he = TrvLop_ChuanHoa.ID_he
                    dsID_lop = TrvLop_ChuanHoa.ID_lop_list
                    dsID_dt = TrvLop_ChuanHoa.ID_dt_list
                    mNien_khoa = TrvLop_ChuanHoa.Nien_khoa
                    'Load danh sách các môn trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        clsCTDT = New ChuongTrinhDaoTao_BLL(dsID_dt, gobjUser.ID_Bomon)
                        'Load môn học vào Combobox
                        Add_MonHoc()
                    End If
                    'Load danh sách sinh viên
                    Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    'Load danh sách điểm
                    cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged
        Try
            'Load danh sách điểm của sinh viên
            Try
                If Loader Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim ID_chuyen_nganh As Integer = TrvLop_ChuanHoa.ID_chuyen_nganh
                    Dim dtDiemKyHieu As DataTable
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, Lan_hoc)
                        If cmbLan_hoc.SelectedIndex + 1 = 1 And cmbLan_thi.SelectedValue = 1 Then
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(ID_mon, Lan_hoc).DefaultView
                        Else
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(Lan_hoc, cmbLan_thi.SelectedValue, ID_mon, cb_Diem_la0.Checked).DefaultView
                        End If
                        dtDiemKyHieu = clsDiem.Load_DiemKyHieu_List
                        FormatDataView(dtDiemKyHieu)
                        Dim Lock_diem As Boolean = False
                        ReadOnly_Diem()
                        KhoaDuLieu(Lock_diem)
                        If Lock_diem = True Then
                            btnDel.Enabled = False
                            btnSave.Enabled = False
                            cmdLock.Enabled = False
                            cmdUnLock.Enabled = True
                        Else
                            btnDel.Enabled = True
                            btnSave.Enabled = True
                            cmdLock.Enabled = True
                            cmdUnLock.Enabled = False
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    SetQuyenTruyCap(, btnSave, , btnDel)
                    Quyen_Khoa_Diem()
                    'If gobjUser.ID_khoa > 0 And cmbID_mon.Text <> "" Then
                    '    If Check_Mon_TheoKhoa(gobjUser.ID_khoa, cmbID_mon.SelectedValue) = False Then
                    '        btnSave.Enabled = False
                    '        btnDel.Enabled = False
                    '        cmdLock.Enabled = False
                    '        cmdUnLock.Enabled = False
                    '    End If
                    'End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_hoc.SelectedIndexChanged, cmbLan_thi.SelectedIndexChanged
        Try
            'Load danh sách điểm của sinh viên
            Try
                If Loader Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim dtDiemKyHieu As DataTable
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        'clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, Lan_hoc)
                        clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, True, , Lan_hoc)
                        If cmbLan_hoc.SelectedIndex + 1 = 1 And cmbLan_thi.SelectedValue = 1 Then
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(ID_mon, Lan_hoc).DefaultView
                        Else
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(Lan_hoc, cmbLan_thi.SelectedValue, ID_mon, cb_Diem_la0.Checked).DefaultView
                        End If
                        dtDiemKyHieu = clsDiem.Load_DiemKyHieu_List
                        FormatDataView(dtDiemKyHieu)
                        Dim Lock_diem As Boolean = False
                        ReadOnly_Diem()
                        KhoaDuLieu(Lock_diem)
                        If Lock_diem = True Then
                            btnDel.Enabled = False
                            btnSave.Enabled = False
                            cmdLock.Enabled = False
                            cmdUnLock.Enabled = True
                        Else
                            btnDel.Enabled = True
                            btnSave.Enabled = True
                            cmdLock.Enabled = True
                            cmdUnLock.Enabled = False
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    SetQuyenTruyCap(, btnSave, , btnDel)
                    Quyen_Khoa_Diem()
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub mnuPrint_DanSachThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dtDanhSach As DataTable
                dtDanhSach = grdViewDiem.DataSource.Table
                dtDanhSach.Columns.Add("Tieu_de", GetType(String))
                dtDanhSach.Columns.Add("Hoc_ky", GetType(String))
                dtDanhSach.Columns.Add("Nam_hoc", GetType(String))
                dtDanhSach.Columns.Add("Ten_mon", GetType(String))
                dtDanhSach.Columns.Add("Ngay_thi", GetType(String))
                dtDanhSach.Columns.Add("Ca_thi", GetType(String))
                dtDanhSach.Columns.Add("Nhom_tiet", GetType(String))
                dtDanhSach.Columns.Add("Ten_phong", GetType(String))


                For i As Integer = 0 To dtDanhSach.Rows.Count - 1
                    dtDanhSach.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI LẦN " & mLan_thi
                    dtDanhSach.Rows(i).Item("Hoc_ky") = cmbHoc_ky.SelectedIndex + 1
                    dtDanhSach.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
                    dtDanhSach.Rows(i).Item("Ten_mon") = cmbID_mon.Text
                    dtDanhSach.Rows(i).Item("Ten_phong") = ""
                    dtDanhSach.Rows(i).Item("Ngay_thi") = ""
                    dtDanhSach.Rows(i).Item("Ca_thi") = ""
                    dtDanhSach.Rows(i).Item("Nhom_tiet") = ""
                Next
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS THI THEO PHONG", dtDanhSach)
            Else
                Thongbao("Bạn phải chọn lớp để in danh sách phòng thi theo lớp")
            End If
        Catch ex As Exception
            'Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SQL As String = ""
        Dim dt As DataTable
        SQL = "SELECT * FROM svDiem WHERE ID_dv='ABC'"
        dt = UDB.SelectTable(SQL)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim ID_diem As Integer = clsDiem.getID_Diem("P1", dt.Rows(i).Item("ID_mon"), dt.Rows(i).Item("ID_dt"), dt.Rows(i).Item("ID_sv"))
            If ID_diem <= 0 Then
                SQL = "UPDATE svDiem set ID_dv='P1' WHERE ID_diem=" & dt.Rows(i).Item("ID_diem")
                UDB.Execute(SQL)
            End If
        Next
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub cmbChonFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChonFile.SelectedIndexChanged
        If cmbChonFile.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            If xlsFileName.Trim <> "" Then
                Try
                    dt = New DataTable
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    da.Fill(dt)
                    Dim dt_tp, dt_tp_excel, dt_maSV As New DataTable
                    dt_tp_excel.Columns.Add("ID_TP_E", GetType(Integer))
                    dt_tp_excel.Columns.Add("Ten_TP_E", GetType(String))
                    If dt.Columns.Count > 0 Then
                        For j As Integer = 0 To dt.Columns.Count - 1
                            Dim dr As DataRow = dt_tp_excel.NewRow
                            dr("ID_TP_E") = j
                            dr("Ten_TP_E") = dt.Columns(j).ColumnName
                            dt_tp_excel.Rows.Add(dr)
                        Next
                    End If
                    FillCombo(cmbCot_diem, dt_tp_excel)
                    dt_maSV = dt_tp_excel.Copy
                    FillCombo(cmbMa_sv, dt_maSV)

                    dt_tp.Columns.Add("ID_TP", GetType(Integer))
                    dt_tp.Columns.Add("Ten_TP", GetType(String))

                    Dim dr1 As DataRow = dt_tp.NewRow
                    dr1("ID_tp") = 1
                    dr1("Ten_TP") = "Điểm thi"
                    dt_tp.Rows.Add(dr1)
                    FillCombo(cmbThanh_phan, dt_tp)
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        With dlgOpenFile
            .InitialDirectory = Application.StartupPath
            .Filter = "Tệp Excel|*.xls"
            .FilterIndex = 1
        End With
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            xlsFileName = dlgOpenFile.FileName
            Dim xlsFile As String = xlsFileName.Trim.ToLower.Substring(xlsFileName.Trim.Length - 3, 3)
            If xlsFile = "xls" Then
                Try
                    cmbChonFile.Items.Clear()
                    Dim conADO As New ADODB.Connection
                    Dim myrs As New ADODB.Recordset
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
                    While Not myrs.EOF
                        If myrs.Fields("TABLE_NAME").Value.ToString.Length > 0 Then
                            If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) = "$" Then
                                cmbChonFile.Items.Add(myrs.Fields("TABLE_NAME").Value)
                            End If
                        End If
                        myrs.MoveNext()
                    End While
                    myrs.Close()
                    If cmbChonFile.Items.Count > 0 Then
                        cmbChonFile.SelectedIndex = 0
                    End If
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdDongBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongBo.Click
        'Try
        Dim dv As DataView = grdViewDiem.DataSource
        For i As Integer = 0 To dv.Count - 1
            Dim dk As String = cmbMa_sv.Text & "=" & "'" & dv.Item(i)("Ma_sv").Trim.ToString & "'"
            dt.DefaultView.RowFilter = dk
            'Dim dvf As DataView = dt.DefaultView
            If dt.DefaultView.Count > 0 Then
                dv.Item(i)("Diem_thi") = dt.DefaultView.Item(0)(cmbCot_diem.Text)
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Các bước nhập điểm thi qua Excel: "
        str = str + vbCrLf
        str = str + "1. Chọn biểu tượng folder để mở file excel" + vbCrLf
        str = str + "2. Chọn Sheet của file excel" + vbCrLf
        str = str + "3. Chọn cột Mã sinh viên" + vbCrLf
        str = str + "4. Người dùng lần lượt chọn Cột điểm thi của file excel tương ứng với Cột điểm thi" + vbCrLf
        str = str + "5. Chọn Đồng bộ dữ liệu từ Excel" + vbCrLf
        Thongbao(str, MsgBoxStyle.Information)
    End Sub

    Private Sub optDiem_la0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDS_thi_lai.CheckedChanged
        Try
            If grdViewDiem.DataSource Is Nothing Then Exit Sub
            Dim dv_KhongDuDK As DataView = grdViewDiem.DataSource
            If cbDS_thi_lai.Checked = True Then
                For i As Integer = dv_KhongDuDK.Count - 1 To 0 Step -1
                    If dv_KhongDuDK.Item(i)("Diem_thi").ToString = "" Then
                        dv_KhongDuDK.Item(i).Delete()
                    End If
                Next
                grdViewDiem.DataSource = dv_KhongDuDK
                Dim dv2 As DataView = grdViewDiem.DataSource
                For j As Integer = dv2.Count - 1 To 0 Step -1
                    If dv_KhongDuDK.Item(j)("KhongDuDKThi").ToString <> "" Or dv_KhongDuDK.Item(j)("Diem_thi") >= 5 Or dv_KhongDuDK.Item(j)("TBCHP") = 0 Then
                        dv_KhongDuDK.Item(j).Delete()
                    End If
                Next
                grdViewDiem.DataSource = dv2
            Else
                Call cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            grdViewDiem.EndEdit()
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
            Dim Lan_thi As Integer = cmbLan_thi.SelectedValue
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim ID_dt As Integer = 0
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""

            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                If Not dtDiem.Rows(i)("Ghi_chu").ToString = "X" Then
                    If Not IsNumeric(dtDiem.Rows(i)("Diem_thi")) Then dtDiem.Rows(i)("Diem_thi") = 0
                    Dim objDiem As New Diem
                    Dim objDiemThi As New DiemThi
                    ''Tính điểm thi dựa vào điểm chi tiết
                    Dim dsThanhPhanThi As Generic.List(Of ThanhPhanThi) = clsDiem.GetDsThanhPhanThi()
                    Dim Diem_thi As Double = 0
                    Dim isDiemThiThanhPhan As Boolean = False
                    Dim mListDiemThiChiTiet As New Generic.List(Of DiemThiChiTiet)
                    For index As Integer = 0 To dsThanhPhanThi.Count - 1
                        isDiemThiThanhPhan = True
                        Dim ID_thanh_phan As Integer = dsThanhPhanThi(index).ID_thanh_phan
                        Dim temp As Double = 0
                        If dtDiem.Columns.Contains("Thi." & ID_thanh_phan) Then
                            temp = IIf(IsNumeric(dtDiem.Rows(i)("Thi." & ID_thanh_phan)), dtDiem.Rows(i)("Thi." & ID_thanh_phan), 0)
                        End If
                        Dim Phan_tram As Double = dsThanhPhanThi(index).Phan_tram
                        Diem_thi += temp * Phan_tram / 100
                        Dim obj As New DiemThiChiTiet()
                        obj.Diem = temp
                        obj.ThanhPhanThi.ID_thanh_phan = ID_thanh_phan
                        mListDiemThiChiTiet.Add(obj)
                    Next
                    If isDiemThiThanhPhan Then dtDiem.Rows(i)("Diem_thi") = Diem_thi
                    ''
                    'Nếu chưa có môn học này thì insert thêm vào object điểm
                    If idx_diem = -1 Then
                        objDiem.Hoc_ky = Hoc_ky
                        objDiem.Nam_hoc = Nam_hoc
                        objDiem.ID_mon = ID_mon
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                        objDiem.ID_dv = gobjUser.ID_dv
                        objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                        clsDiem.Add(objDiem)
                    Else
                        objDiem = clsDiem.Diem(idx_diem)
                        objDiem.Hoc_ky = Hoc_ky
                        objDiem.Nam_hoc = Nam_hoc
                    End If
                    'Nếu là nhập mới điểm thi thì insert thêm object điểm thi mới
                    If idx_diem_thi = -1 Then
                        objDiemThi.Lan_hoc = Lan_hoc
                        objDiemThi.Lan_thi = Lan_thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiemThi.Hash_code = (Lan_thi.ToString + "-" + dtDiem.Rows(i)("Diem_thi").ToString + "-" + dtDiem.Rows(i)("Ghi_chu").ToString).ToString.GetHashCode
                        objDiem.dsDiemThi.Add(objDiemThi)
                        objDiemThi.DiemThiChiTiet = mListDiemThiChiTiet
                        Noi_dung_Add += vbCrLf & " -Mã SV:" & dtDiem.Rows(i)("Ma_SV") & " -Họ tên:" & dtDiem.Rows(i)("Ho_ten").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    Else

                        Noi_dung_Edit += vbCrLf & " -Mã SV:" & dtDiem.Rows(i)("Ma_SV") & " -Họ tên:" & dtDiem.Rows(i)("Ho_ten").ToString & " Điểm cũ:" & objDiemThi.Diem_thi.ToString & " Sửa thành:" & dtDiem.Rows(i)("Diem_thi").ToString
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                            objDiem.dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiem.dsDiemThi.DiemThi(idx_diem_thi).Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiem.dsDiemThi.DiemThi(idx_diem_thi).Hash_code = (Lan_thi.ToString + "-" + dtDiem.Rows(i)("Diem_thi").ToString + "-" + dtDiem.Rows(i)("Ghi_chu").ToString).ToString.GetHashCode
                        objDiem.dsDiemThi.DiemThi(idx_diem_thi).DiemThiChiTiet = mListDiemThiChiTiet
                    End If
                    ''

                    ''
                Else
                    If idx_diem >= 0 And idx_diem_thi >= 0 Then
                        clsDiem.Diem(idx_diem).dsDiemThi.DiemThi(idx_diem_thi).Diem_thi = -1
                    End If
                End If
            Next

            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Bổ sung điểm thi học phần môn: " & cmbID_mon.Text.Trim & " -Lần học " & cmbLan_hoc.Text & " -Lần thi " & cmbLan_thi.Text & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            If Noi_dung_Edit.Trim <> "" Then
                Noi_dung_Edit = "Sửa điểm thi học phần môn: " & cmbID_mon.Text.Trim & " -Lần học " & cmbLan_hoc.Text & " -Lần thi " & cmbLan_thi.Text & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Edit
                SaveLog(LoaiSuKien.Sua, Noi_dung_Edit)
            End If
            'Lưu điểm thi
            clsDiem.LuuDiemThi(Lan_hoc, Lan_thi)
            'Load lại dữ liệu điểm
            Call cmbLan_thi_SelectedIndexChanged(Nothing, Nothing)
            ' Cập nhật = K với sinh viên không đủ đk thi
            Dim dv_KhongDuDK As DataView = grdViewDiem.DataSource
            Dim clsDiem_KD As New Diem_BLL
            For i As Integer = 0 To dv_KhongDuDK.Count - 1
                If dv_KhongDuDK.Item(i)("Ghi_chu").ToString = "" Then
                    Dim ID_diem As Integer = clsDiem_KD.getID_Diem("P1", cmbID_mon.SelectedValue, dv_KhongDuDK.Item(i)("ID_dt"), dv_KhongDuDK.Item(i)("ID_sv"))
                    Dim objDiemThi_KD As New DiemThi
                    objDiemThi_KD.Ghi_chu = "K"
                    clsDiem.Update_GhiChu_KhongDuDK(ID_diem, Lan_hoc, Lan_thi)
                    If dv_KhongDuDK.Item(i)("KhongDuDKThi").ToString <> "" Then
                        clsDiem.Update_DiemThi_KhongDuDK(objDiemThi_KD, ID_diem, Lan_hoc, Lan_thi)
                    End If
                End If
            Next
            Call cmbLan_thi_SelectedIndexChanged(Nothing, Nothing)
            cmdLock_Click(Nothing, Nothing)
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                Dim Lan_thi As Integer = cmbLan_thi.SelectedValue
                Dim ID_diem As Integer
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("Diem_thi").ToString <> "" Then
                        ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                        clsDiem.Delete_DiemThi(ID_diem, Lan_hoc, Lan_thi)
                        dtDiem.Rows(i)("Diem_thi") = DBNull.Value
                        dtDiem.Rows(i)("TBCHP") = DBNull.Value
                    End If
                Next
                'Load lại dữ liệu điểm
                Call cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnKyHieu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKyHieu.Click
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
    End Sub

    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Try
            Dim re As DialogResult = MessageBox.Show("Bạn có muốn khóa điểm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If re = Windows.Forms.DialogResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("TBCHP").ToString <> "" Then
                        clsDiem.Update_DiemThiLock(dtDiem.Rows(i)("ID_diem"), 1, cmbLan_hoc.SelectedIndex + 1, cmbLan_thi.SelectedValue)
                    End If
                Next
                'Load lại dữ liệu điểm
                cmbMonHoc_SelectedIndexChanged(sender, e)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnLock.Click
        Try
            If Thongbao("Chắc chắn bạn muốn mở khóa điểm thi của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("TBCHP").ToString <> "" Then
                        clsDiem.Update_DiemThiLock(dtDiem.Rows(i)("ID_diem"), 0, cmbLan_hoc.SelectedIndex + 1, cmbLan_thi.SelectedValue)
                    End If
                Next
                'Load lại dữ liệu điểm
                cmbMonHoc_SelectedIndexChanged(sender, e)
                Thongbao("Đã mở khoá điểm thành công !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDS_thi_lai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If grdViewDiem.DataSource Is Nothing Then Exit Sub
        '    Dim dv_KhongDuDK As DataView = grdViewDiem.DataSource
        '    For i As Integer = dv_KhongDuDK.Count - 1 To 0 Step -1
        '        If dv_KhongDuDK.Item(i)("Diem_thi").ToString = "" Then
        '            dv_KhongDuDK.Item(i).Delete()
        '        End If
        '    Next
        '    grdViewDiem.DataSource = dv_KhongDuDK
        '    Dim dv2 As DataView = grdViewDiem.DataSource
        '    For j As Integer = dv2.Count - 1 To 0 Step -1
        '        If dv_KhongDuDK.Item(j)("KhongDuDKThi").ToString <> "" Or dv_KhongDuDK.Item(j)("Diem_thi") >= 5 Or dv_KhongDuDK.Item(j)("TBCHP") = 0 Then
        '            dv_KhongDuDK.Item(j).Delete()
        '        End If
        '    Next
        '    grdViewDiem.DataSource = dv2
        '    Dim tieu_de1, Tieu_de2 As String
        '    tieu_de1 = "DANH SÁCH THI LẠI MÔN " + cmbID_mon.Text.ToString.ToUpper
        '    Tieu_de2 = "HỌC KỲ " + cmbHoc_ky.Text.ToString + " NĂM HỌC " + cmbNam_hoc.Text.ToString

        '    Dim rpt As New rptDanhSachThiLai(dv2, tieu_de1, Tieu_de2)
        '    PrintXtraReport(rpt)
        '    Call cmbLan_thi_SelectedIndexChanged(Nothing, Nothing)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btBaoCaoNhapDiemXong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim re As DialogResult = MessageBox.Show("Điểm sẽ được khóa lại và phần mềm sẽ gửi báo cáo đến phòng đào tạo là bạn đã hoàn thành điểm môn này. Bạn chắc chắn là đã hoàn thành nhập điểm cho môn này và các điểm này là chuẩn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        '    If re = Windows.Forms.DialogResult.Yes Then
        '        Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
        '        For i As Integer = 0 To dtDiem.Rows.Count - 1
        '            If dtDiem.Rows(i)("TBCHP").ToString <> "" Then
        '                clsDiem.Update_DiemThiLock(dtDiem.Rows(i)("ID_diem"), 1, cmbLan_hoc.SelectedIndex + 1, cmbLan_thi.SelectedValue)
        '            End If
        '        Next
        '        'Load lại dữ liệu điểm
        '        cmbMonHoc_SelectedIndexChanged(sender, e)
        '        Thongbao("Báo cáo hoàn thành nhập điểm của bạn đã được gửi thành công. Điểm thi đã được khóa lại!")
        '        btBaoCaoNhapDiemXong.Enabled = False
        '    End If

        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub cb_Diem_la0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Diem_la0.CheckedChanged
        If grdViewDiem.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewDiem.DataSource
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Diem_thi").ToString = "" Then
                dv.Item(i)("Diem_thi") = 0
            End If
        Next
    End Sub

    Private Sub grdViewDiem_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles grdViewDiem.CellPainting
        'If e.ColumnIndex = 3 AndAlso e.RowIndex <> -1 Then

        '    Using gridBrush As Brush = New SolidBrush(Me.grdViewDiem.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

        '        Using gridLinePen As Pen = New Pen(gridBrush)
        '            ' Clear cell  
        '            e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

        '            ' Draw line (bottom border and right border of current cell)  
        '            'If next row cell has different content, only draw bottom border line of current cell  
        '            If e.RowIndex < grdViewDiem.Rows.Count - 2 AndAlso grdViewDiem.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
        '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        '            End If

        '            ' Draw right border line of current cell  
        '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

        '            ' draw/fill content in current cell, and fill only one cell of multiple same cells  
        '            If Not e.Value Is Nothing Then
        '                If e.RowIndex > 0 AndAlso grdViewDiem.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
        '                Else
        '                    e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
        '                End If
        '            End If

        '            e.Handled = True
        '        End Using
        '    End Using
        'End If
    End Sub

    Private Sub optAll_Lop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll_Lop.CheckedChanged
        'Try
        '    Me.TrvLop_ChuanHoa.Load_TreeView(optAll_Lop.Checked)
        'Catch ex As Exception
        'End Try
    End Sub
    'Function Check_Mon_TheoKhoa(ByVal mID_khoa As Integer, ByVal mID_mon As Integer) As Boolean
    '    Dim clsDM As New DanhMuc_BLL
    '    Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT ID_mon FROM MARK_MONHOC WHERE ID_mon=" & mID_mon & " AND ID_khoa_nhap_diem=" & mID_khoa)
    '    If dt.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    Private Sub btnSave_VH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_VH.Click
        If grdViewDiem.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewDiem.DataSource
        For i As Integer = 0 To dv.Count - 1
            If CType(dv.Item(i)("Van_hoa"), Boolean) = True Then
                UDB.Execute("UPDATE STU_HoSoSinhVien Set Van_hoa = 1 WHERE ID_sv = " & dv.Item(i)("ID_sv"))
            Else
                UDB.Execute("UPDATE STU_HoSoSinhVien Set Van_hoa = 0 WHERE ID_sv = " & dv.Item(i)("ID_sv"))
            End If
        Next
        MessageBox.Show("Bạn cập nhật thành công !", "Thông báo !", MessageBoxButtons.OK)
        TrvLop_ChuanHoa_Select()
    End Sub

    Private Sub btnInBangDiem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInBangDiem.ItemClick
        Try
            GetReportHeader()
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Ten_hoc_phan, He As String, Chuyen_nganh As String, Lop As String
                Dim tieu_de As String = ""
                Dim ID_Lop As Integer = TrvLop_ChuanHoa.ID_lop_list
                If ID_Lop > 0 Then
                    Ten_hoc_phan = cmbID_mon.Text
                    Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
                    Dim dv_tmp As DataView = dtDiemTH.DefaultView
                    He = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Ten_he").ToString
                    Chuyen_nganh = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Chuyen_nganh").ToString
                    Lop = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Ten_lop").ToString
                    'tieu_de = "KẾT QUẢ HỌC TẬP " & cmbLan_hoc.Text & " LẦN THI " & cmbLan_hoc.Text & " HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                    If CType(cmbLan_hoc.Text, Integer) = 1 And CType(cmbLan_thi.Text, Integer) = 1 Then
                        tieu_de = "KẾT QUẢ HỌC TẬP HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                    ElseIf CType(cmbLan_hoc.Text, Integer) > 1 Or CType(cmbLan_thi.Text, Integer) > 1 Then
                        tieu_de = "KẾT QUẢ HỌC TẬP LẦN HỌC " & cmbLan_hoc.Text & ", LẦN THI " & cmbLan_thi.Text & ", HỌC KỲ " & cmbHoc_ky.Text & ", NĂM HỌC " & cmbNam_hoc.Text
                    End If
                    Dim dtTP As DataTable
                    dtTP = clsDiem.DanhSachThanhPhanChon
                    Dim frm As New rptBangDiemTBCHP_Dynamic(Ten_hoc_phan, He, Chuyen_nganh, Lop, dtDiemTH, dtTP, tieu_de)
                    frm.DataSource = dtDiemTH
                    PrintXtraReport(frm)
                End If
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDanhSachDuThi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDanhSachDuThi.ItemClick
        Try
            If grdViewDiem.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDiem.DataSource
            Dim rpt As New rptDanhSachDuThi(dv, cmbHoc_ky.Text, cmbID_mon.Text, cmbLan_thi.Text)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDanhSachNoMon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDanhSachNoMon.ItemClick
        Try
            GetReportHeader()
            Dim cls As New Diem_BLL
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim ID_lop As Integer = TrvLop_ChuanHoa.ID_lop_list
            Dim dv As DataView = cls.DanhSachSinhVien_NoTheoHocPhan(ID_mon, ID_lop).DefaultView
            dv.RowFilter = "Diem_thi < 5 Or Diem_HP < 5"
            Dim Tieu_de As String = TrvLop_ChuanHoa.Tieu_de
            If ID_mon > 0 And ID_lop.ToString <> "" Then
                Dim rpt As New rptDanhSachSinhVienNoTheoHocPhan(dv, Tieu_de, cmbHoc_ky.Text, cmbNam_hoc.Text)
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnTP_Diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTP_Diem.Click
        Dim frm As New frmThanhPhanThi(dsID_lop, cmbID_mon.SelectedValue, clsDiem.GetDsThanhPhanThi)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            Dim report As New rpt_DiemTongKetMonHoc_Mau05a(dv, cmbID_mon.Text)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class