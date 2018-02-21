Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Machine
Imports DevExpress.XtraReports.UI

Public Class frmESS_NhapDiemThanhPhanLop
    Private mID_he As Integer = 0
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private mdtMonHoc As DataTable
    Dim xlsFileName As String = ""
    Private dt As New DataTable

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
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
            If gobjUser.ID_Bomon > 0 Then 'Chi load mon theo giang vien khi USER do thuoc Bo mon (phai phan quyen user do thuoc BM)
                dt = clsCTDT.DanhSachMonHoc(Ky_thu, Hoc_ky, Nam_hoc, gobjUser.UserName.Trim)
            Else
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            End If

            mdtMonHoc = dt.Copy
            'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
            If Not CompareData(dt, cmbID_mon.DataSource) Then
                FillCombo(cmbID_mon, dt)
            End If
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
            If gobjUser.ID_Bomon > 0 Then 'Chi load mon theo giang vien khi USER do thuoc Bo mon (phai phan quyen user do thuoc BM)
                dt = clsCTDT.DanhSachMonHoc(Ky_thu, Hoc_ky, Nam_hoc, gobjUser.UserName.Trim, dsID_lops)
            Else
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
            End If

            mdtMonHoc = dt.Copy
            'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
            If Not CompareData(dt, cmbID_mon.DataSource) Then
                FillCombo(cmbID_mon, dt)
            End If
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
    Private Sub FormatDataView()
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
                .Width = 90
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_dem"
                .DataPropertyName = "Ho_dem"
                .HeaderText = "Họ đệm"
                .Width = 180
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)
            Dim col31 As New DataGridViewTextBoxColumn
            With col31
                .Name = "Ten"
                .DataPropertyName = "Ten"
                .HeaderText = "Tên"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col31)
            'Các thành phần điểm
            For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    Dim col As New DataGridViewTextBoxColumn
                    With clsDiem.ThanhPhanDiem.ThanhPhanDiem(i)
                        col.Name = "TP" + .ID_thanh_phan.ToString
                        col.DataPropertyName = "TP" + .ID_thanh_phan.ToString
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 50
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'TBCBP
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "TBCBP"
                .DataPropertyName = "TBCBP"
                .HeaderText = "TBCBP"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'Locked
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col7)
            'TBCBP
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Không đủ đk dự thi"
                .Width = 170
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col8)

            'Số tiết nghỉ
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "So_tiet_nghi"
                .DataPropertyName = "So_tiet_nghi"
                .HeaderText = "Số tiết nghỉ"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col4)

            'Thiếu bài thực hành
            Dim col5 As New DataGridViewCheckBoxColumn
            With col5
                .Name = "Thieu_bai_thuc_hanh"
                .DataPropertyName = "Thieu_bai_thuc_hanh"
                .HeaderText = "Thiếu bài TH"
                .Width = 70
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col5)
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
                    'ReadOnly toan bo diem thanh phan bi khoa
                    For i As Integer = 0 To grdViewDiem.RowCount - 1
                        For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                            If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                                If Not grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).Value Is Nothing _
                                AndAlso grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).Value.ToString <> "" Then
                                    grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).ReadOnly = True
                                End If
                            End If
                        Next
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub KhoaDuLieu(ByRef Lock_diem As Boolean)
        Try
            Lock_diem = False
            Dim Checked As Boolean = False
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                Checked = False
                For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                    If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                        If Not grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).Value Is Nothing _
                        AndAlso grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).Value.ToString <> "" Then
                            Checked = True
                            Exit For
                        End If
                    End If
                Next
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    If Lock_diem = False Then Lock_diem = True
                    'ReadOnly toan bo diem thanh phan bi khoa
                    For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                        If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked AndAlso grdViewDiem.Rows(i).Cells("Locked").Value = True Then grdViewDiem.Rows(i).Cells("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString).ReadOnly = True
                    Next
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If Checked Then 'Edit
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Edit
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    Else    'Add New
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
    Private Sub cmdPrint_DanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dt As DataTable = grdViewDiem.DataSource.Table
            Dim dt_Main As DataTable = dt.Copy
            If dt_Main.Rows.Count > 0 Then
                dt_Main.Columns.Add("Ten_mon")
                dt_Main.Columns.Add("Hoc_ky")
                dt_Main.Columns.Add("Nam_hoc")

                For i As Integer = 0 To dt_Main.Rows.Count - 1

                    dt_Main.Rows(i).Item("Ten_mon") = "Học phần: " & cmbID_mon.Text
                    dt_Main.Rows(i).Item("Hoc_ky") = cmbHoc_ky.Text
                    dt_Main.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("BangDiem_KiemTraHocPhan", dt_Main)
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Load_DS(ByVal dsID_lop As String, ByVal Dieu_kien As Boolean)
        Try
            Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
            Dim dtSoure As DataTable = objDanhSach.Danh_sach_sinh_vien
            If dtSoure.Rows.Count > 0 Then
                If Dieu_kien = True Then
                    mdtDanhSachSinhVien = dtSoure
                Else
                    mdtDanhSachSinhVien = dtSoure.Select("Trang_thai = 0").CopyToDataTable
                End If
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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
                        Add_MonHoc(dsID_lop)
                    End If
                    'Load danh sách sinh viên
                    'Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    'mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    Load_DS(dsID_lop, chk_ds_day_du.Checked)
                    'Load danh sách điểm
                    cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Load_Ds_nhap_diem_thanh_phan()
        Try
            If Loader Then
                'Load danh sách điểm của sinh viên
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                Dim Nam_hoc As String = cmbNam_hoc.Text
                Dim ID_mon As Integer = cmbID_mon.SelectedValue
                Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                    clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True, Lan_hoc)
                    ' Nếu chua có thành phần điểm đã chọn thì load số bài điểm thành phần mặc định theo số ĐV học trình
                    If clsDiem.SoThanhPhanDiem = 0 Then
                        Dim So_hoc_trinh As Integer = 0
                        For i As Integer = 0 To mdtMonHoc.Rows.Count - 1
                            If mdtMonHoc.Rows(i)("ID_mon") = ID_mon Then
                                So_hoc_trinh = mdtMonHoc.Rows(i)("So_hoc_trinh")
                                Exit For
                            End If
                        Next
                        'grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc, So_hoc_trinh).DefaultView
                        grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
                    Else
                        grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
                    End If
                Else
                    grdViewDiem.DataSource = Nothing
                End If
                FormatDataView()
                ReadOnly_Diem()
                Dim Lock_diem As Boolean = False
                KhoaDuLieu(Lock_diem)
                If Lock_diem = True Then
                    btnDel.Enabled = False
                    btnSave.Enabled = False
                    btnTP_Diem.Enabled = False
                    cmdLock.Enabled = False
                    cmdUnLock.Enabled = True
                Else
                    btnDel.Enabled = True
                    btnSave.Enabled = True
                    btnTP_Diem.Enabled = True
                    cmdLock.Enabled = True
                    cmdUnLock.Enabled = False
                End If
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
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged, cmbLan_hoc.SelectedIndexChanged
        Try
            'Try
            '    If Loader Then
            '        'Load danh sách điểm của sinh viên
            '        Dim ID_dv As String = gobjUser.ID_dv
            '        Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            '        Dim Nam_hoc As String = cmbNam_hoc.Text
            '        Dim ID_mon As Integer = cmbID_mon.SelectedValue
            '        Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
            '        If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
            '            clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True, Lan_hoc)
            '            ' Nếu chua có thành phần điểm đã chọn thì load số bài điểm thành phần mặc định theo số ĐV học trình
            '            If clsDiem.SoThanhPhanDiem = 0 Then
            '                Dim So_hoc_trinh As Integer = 0
            '                For i As Integer = 0 To mdtMonHoc.Rows.Count - 1
            '                    If mdtMonHoc.Rows(i)("ID_mon") = ID_mon Then
            '                        So_hoc_trinh = mdtMonHoc.Rows(i)("So_hoc_trinh")
            '                        Exit For
            '                    End If
            '                Next
            '                'grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc, So_hoc_trinh).DefaultView
            '                grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
            '            Else
            '                grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
            '            End If
            '        Else
            '            grdViewDiem.DataSource = Nothing
            '        End If
            '        FormatDataView()
            '        ReadOnly_Diem()
            '        Dim Lock_diem As Boolean = False
            '        KhoaDuLieu(Lock_diem)
            '        If Lock_diem = True Then
            '            btnDel.Enabled = False
            '            btnSave.Enabled = False
            '            btnTP_Diem.Enabled = False
            '            cmdLock.Enabled = False
            '            cmdUnLock.Enabled = True
            '        Else
            '            btnDel.Enabled = True
            '            btnSave.Enabled = True
            '            btnTP_Diem.Enabled = True
            '            cmdLock.Enabled = True
            '            cmdUnLock.Enabled = False
            '        End If
            '    End If
            '    SetQuyenTruyCap(, btnSave, , btnDel)
            '    Quyen_Khoa_Diem()
            '    'If gobjUser.ID_khoa > 0 And cmbID_mon.Text <> "" Then
            '    '    If Check_Mon_TheoKhoa(gobjUser.ID_khoa, cmbID_mon.SelectedValue) = False Then
            '    '        btnSave.Enabled = False
            '    '        btnDel.Enabled = False
            '    '        cmdLock.Enabled = False
            '    '        cmdUnLock.Enabled = False
            '    '    End If
            '    'End If
            'Catch ex As Exception
            '    Thongbao(ex.Message)
            'End Try
            Load_Ds_nhap_diem_thanh_phan()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub grdViewDiem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
        Try
            For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                    If e.ColumnIndex = grdViewDiem.Columns("TP" + clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).ID_thanh_phan.ToString).Index Then
                        If Not grdViewDiem.CurrentCell.Value Is Nothing AndAlso grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewDiem.CurrentCell.Value) Then
                            Thongbao("Bạn phải nhập điểm là số !")
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        End If
                        If Not grdViewDiem.CurrentCell.Value Is Nothing AndAlso grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso (grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentCell.Value > 10) Then
                            Thongbao("Bạn phải nhập điểm là số từ 0 đến 10 !")
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    '    Dim frmESS_ As New frmESS_ToolNhapDiemThanhPhanLop
    '    frmESS_.ShowDialog()
    'End Sub

    'Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
    '    Dim frmESS_ As New frmESS_ToolNhapDiemThiLop
    '    frmESS_.ShowDialog()
    'End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim ID_diem As Integer
                Dim ID_thanh_phan As Integer
                Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                    If ID_diem > 0 Then
                        'Xoá các thành phần điểm
                        For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                            If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                                ID_thanh_phan = clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan
                                If dtDiem.Rows(i)("TP" & ID_thanh_phan.ToString).ToString <> "" Then
                                    clsDiem.Delete_DiemThanhPhan(ID_diem, ID_thanh_phan, Lan_hoc)
                                    dtDiem.Rows(i)("TP" & ID_thanh_phan.ToString) = DBNull.Value
                                End If
                            End If
                        Next
                    End If
                Next
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'Dim Tieu_de As String = ""
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)

            Dim dt As DataTable
            dt = grdViewDiem.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnTP_Diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmESS_ As New frmESS_ThayDoiThanhPhan
        frmESS_.mID_he = TrvLop_ChuanHoa.ID_he
        Dim ID_mon As Integer = cmbID_mon.SelectedValue
        Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
        Dim dtTP As DataTable = clsDiem.DanhSachThanhPhan
        frmESS_.ShowDialog(dtTP)
        'Update lai cac thanh phan
        If frmESS_.Tag = 1 Then
            dtTP = frmESS_.grdViewTP.DataSource.Table
            For i As Integer = 0 To dtTP.Rows.Count - 1
                Dim objTP As New ThanhPhanDiem
                objTP.Checked = dtTP.Rows(i)("Chon")
                objTP.ID_thanh_phan = dtTP.Rows(i)("ID_thanh_phan")
                objTP.STT = dtTP.Rows(i)("STT")
                objTP.Ky_hieu = dtTP.Rows(i)("Ky_hieu")
                objTP.Ten_thanh_phan = dtTP.Rows(i)("Ten_thanh_phan")
                objTP.Ty_le = dtTP.Rows(i)("Ty_le")
                clsDiem.ThanhPhanDiem.ThanhPhanDiem(i) = objTP
            Next
            'Load lai cac thanh phan            
            Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
            FormatDataView()
            Dim Lock_diem As Boolean = False
            KhoaDuLieu(Lock_diem)
            If Lock_diem = True Then
                btnDel.Enabled = False
                btnSave.Enabled = False
                btnTP_Diem.Enabled = False
            Else
                btnDel.Enabled = True
                btnSave.Enabled = True
                btnTP_Diem.Enabled = True
            End If
        Else
            cmbMonHoc_SelectedIndexChanged(sender, e)
        End If
    End Sub

    '---------------------------------------------
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

                    For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                        If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                            Dim col As New DataGridViewTextBoxColumn
                            With clsDiem.ThanhPhanDiem.ThanhPhanDiem(i)
                                Dim dr As DataRow = dt_tp.NewRow
                                dr("ID_tp") = .ID_thanh_phan
                                dr("Ten_TP") = .Ky_hieu
                                dt_tp.Rows.Add(dr)
                            End With
                        End If
                    Next
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
        Dim dv As DataView = grdViewDiem.DataSource
        For i As Integer = 0 To dv.Count - 1
            Dim dk As String = cmbMa_sv.Text & "=" & "'" & dv.Item(i)("Ma_sv").ToString & "'"
            dt.DefaultView.RowFilter = dk
            If dt.DefaultView.Count > 0 Then
                dv.Item(i)("TP" & cmbThanh_phan.SelectedValue) = dt.DefaultView.Item(0)(cmbCot_diem.Text)
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Các bước nhập điểm thành phần qua Excel: "
        str = str + vbCrLf
        str = str + "1. Chọn biểu tượng folder để mở file excel" + vbCrLf
        str = str + "2. Chọn Sheet của file excel" + vbCrLf
        str = str + "3. Chọn cột Mã sinh viên" + vbCrLf
        str = str + "4. Người dùng lần lượt chọn Thành Phần môn của file excel tương ứng với Thành Phần điểm" + vbCrLf
        str = str + "5. Chọn Đồng bộ dữ liệu từ Excel" + vbCrLf
        Thongbao(str, MsgBoxStyle.Information)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim ID_Lop As Integer = TrvLop_ChuanHoa.ID_lop_list
        '    If ID_Lop > 0 Then
        '        Dim a As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
        '        Dim dv As DataView = a.rpt_DSDiemChuyenCan(ID_Lop).DefaultView
        '        Dim frm As New rptDSNhapDiemChuyenCan(ID_Lop)
        '        Dim dt As New DataTable
        '        dt.Columns.Add("Ma_sv")
        '        dt.Columns.Add("Ho_ten")
        '        dt.Columns.Add("Ngay_sinh")
        '        dt.Columns.Add("Goi_tinh")
        '        If dv.Count > 0 Then
        '            For i As Integer = 0 To dv.Count - 1
        '                Dim dr As DataRow
        '                dr = dt.NewRow
        '                dr("Ma_sv") = dv.Item(i)("Ma_sv")
        '                dr("Ho_ten") = dv.Item(i)("Ho_ten")
        '                dr("Ngay_sinh") = CType(dv.Item(i)("Ngay_sinh"), Date).ToString("dd/MM/yyyy")
        '                dr("Goi_tinh") = dv.Item(i)("Goi_tinh")
        '                dt.Rows.Add(dr)
        '            Next
        '        End If
        '        frm.DataSource = dt.DefaultView
        '        frm.Binding()
        '        PrintXtraReport(frm)
        '    End If
        'Catch ex As Exception
        '    Thongbao("Hãy chọn lớp cần In", MsgBoxStyle.Information, "Thông báo")
        'End Try
    End Sub

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnTP_Diem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTP_Diem.Click
        Dim frmESS_ As New frmESS_ThayDoiThanhPhan
        frmESS_.mID_he = TrvLop_ChuanHoa.ID_he
        Dim ID_mon As Integer = cmbID_mon.SelectedValue
        Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
        Dim dtTP As DataTable = clsDiem.DanhSachThanhPhan
        frmESS_.ShowDialog(dtTP)
        'Update lai cac thanh phan
        If frmESS_.Tag = 1 Then
            dtTP = frmESS_.grdViewTP.DataSource.Table
            For i As Integer = 0 To dtTP.Rows.Count - 1
                Dim objTP As New ThanhPhanDiem
                objTP.Checked = dtTP.Rows(i)("Chon")
                objTP.ID_thanh_phan = dtTP.Rows(i)("ID_thanh_phan")
                objTP.STT = dtTP.Rows(i)("STT")
                objTP.Ky_hieu = dtTP.Rows(i)("Ky_hieu")
                objTP.Ten_thanh_phan = dtTP.Rows(i)("Ten_thanh_phan")
                objTP.Ty_le = dtTP.Rows(i)("Ty_le")
                clsDiem.ThanhPhanDiem.ThanhPhanDiem(i) = objTP
            Next
            'Load lai cac thanh phan            
            Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
            FormatDataView()
            Dim Lock_diem As Boolean = False
            KhoaDuLieu(Lock_diem)
            If Lock_diem = True Then
                btnDel.Enabled = False
                btnSave.Enabled = False
                btnTP_Diem.Enabled = False
            Else
                btnDel.Enabled = True
                btnSave.Enabled = True
                btnTP_Diem.Enabled = True
            End If
        Else
            cmbMonHoc_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            grdViewDiem.EndEdit()
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
            Dim ID_dt As Integer = 0
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim ID_diem As Integer
            Dim Noi_dung_Add As String = ""
            Dim ID_tp As String = "0"
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                Dim objDiem As New Diem
                Dim objDiemDanh As New DiemDanh
                Dim objDiemTP As New DiemThanhPhan
                'Nếu chưa có điểm thì insert vào bảng điểm môn học
                If ID_diem = 0 Then
                    objDiem.Hoc_ky = Hoc_ky
                    objDiem.Nam_hoc = Nam_hoc
                    objDiem.ID_mon = ID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")

                    ID_diem = clsDiem.Insert_Diem(objDiem)
                    dtDiem.Rows(i)("ID_diem") = ID_diem
                Else
                    objDiem.Hoc_ky = Hoc_ky
                    objDiem.Nam_hoc = Nam_hoc
                    objDiem.ID_mon = ID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")

                    clsDiem.Update_Diem(objDiem, ID_diem)
                End If
                Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString
                'Cập nhật số tiết nghỉ
                If dtDiem.Rows(i)("So_tiet_nghi").ToString <> "" Or dtDiem.Rows(i)("Thieu_bai_thuc_hanh").ToString <> "0" Then
                    objDiemDanh.Lan_hoc = Lan_hoc
                    objDiemDanh.So_tiet_nghi = IIf(dtDiem.Rows(i)("So_tiet_nghi").ToString = "", 0, dtDiem.Rows(i)("So_tiet_nghi"))
                    objDiemDanh.Thieu_bai_thuc_hanh = IIf(dtDiem.Rows(i)("Thieu_bai_thuc_hanh").ToString = "", 0, dtDiem.Rows(i)("Thieu_bai_thuc_hanh"))
                    'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                    objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemDanh.Lan_hoc.ToString + "-" + objDiemDanh.So_tiet_nghi.ToString).ToString.GetHashCode
                    objDiemTP.Locked = dtDiem.Rows(i)("Locked")
                    'Update
                    If clsDiem.CheckExist_svDiemDanh(ID_diem, Lan_hoc) > 0 Then
                        clsDiem.Update_DiemDanh(objDiemDanh, ID_diem, Lan_hoc)
                    ElseIf objDiemDanh.So_tiet_nghi > 0 Or objDiemDanh.Thieu_bai_thuc_hanh Then    'Insert
                        clsDiem.Insert_DiemDanh(ID_diem, objDiemDanh)
                    End If
                Else
                    'Xoá số tiết nghỉ
                    clsDiem.Delete_DiemDanh(ID_diem, Lan_hoc)
                End If
                'Duyệt các điểm thành phần
                For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                    Dim NoiDung As String = ""
                    If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                        With clsDiem.ThanhPhanDiem.ThanhPhanDiem(j)
                            If dtDiem.Rows(i)("TP" + .ID_thanh_phan.ToString).ToString <> "" Then
                                objDiemTP.Lan_hoc = Lan_hoc
                                objDiemTP.ID_thanh_phan = .ID_thanh_phan
                                objDiemTP.Ty_le = .Ty_le
                                objDiemTP.Diem = dtDiem.Rows(i)("TP" + .ID_thanh_phan.ToString)
                                'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                                objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                                objDiemTP.Locked = dtDiem.Rows(i)("Locked")
                                'Update
                                If clsDiem.CheckExist_svDiemThanhPhan(ID_diem, .ID_thanh_phan, Lan_hoc) > 0 Then
                                    clsDiem.Update_DiemThanhPhan(objDiemTP, ID_diem, .ID_thanh_phan, Lan_hoc)
                                Else    'Insert
                                    clsDiem.Insert_DiemThanhPhan(ID_diem, objDiemTP)
                                End If
                                NoiDung += " TP: " & .Ky_hieu & "-Điểm: " & dtDiem.Rows(i)("TP" + .ID_thanh_phan.ToString)
                            Else
                                'Xoá điểm thành phần
                                clsDiem.Delete_DiemThanhPhan(ID_diem, .ID_thanh_phan, Lan_hoc)
                            End If
                        End With
                    Else
                        'Xoá điểm thành phần không chọn
                        clsDiem.Delete_DiemThanhPhan(ID_diem, clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan, Lan_hoc)
                        If Not ID_tp.Split(",").Contains(clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString()) Then
                            ID_tp += "," & clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan
                        End If
                    End If
                    If NoiDung.Trim <> "" Then Noi_dung_Add += NoiDung
                Next
            Next

            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Cập nhật điểm thành phần môn: " & cmbID_mon.Text.Trim & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            Dim sql As String = "delete from MARK_DiemThanhPhan where Lan_hoc = " & cmbLan_hoc.Text & " AND ID_diem in( " & _
                       "select ID_diem from mark_diem where ID_mon = " & cmbID_mon.SelectedValue & " and ID_sv in(SELECT ID_sv from stu_Danhsach where ID_lop In( " & TrvLop_ChuanHoa.ID_lop_list & " ) " & _
                       " and ID_thanh_phan In(" & ID_tp & ")))"
            UDB.Execute(sql)
            cmbMonHoc_SelectedIndexChanged(sender, e)
            cmdLock_Click_1(Nothing, Nothing)
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
            Dim dt As DataView = grdViewDiem.DataSource
            ExportToExcel(dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim ID_diem As Integer
                Dim ID_thanh_phan As Integer
                Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                    If ID_diem > 0 Then
                        'Xoá các thành phần điểm
                        For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                            If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                                ID_thanh_phan = clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan
                                If dtDiem.Rows(i)("TP" & ID_thanh_phan.ToString).ToString <> "" Then
                                    clsDiem.Delete_DiemThanhPhan(ID_diem, ID_thanh_phan, Lan_hoc)
                                    dtDiem.Rows(i)("TP" & ID_thanh_phan.ToString) = DBNull.Value
                                End If
                            End If
                        Next
                    End If
                Next
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub cmdLock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Try
            Dim re As DialogResult = MessageBox.Show("Bạn có muốn khóa điểm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If re = Windows.Forms.DialogResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("ID_diem").ToString <> "" Then
                        clsDiem.Update_DiemThanhPhanLock(dtDiem.Rows(i)("ID_diem"), 1)
                    End If
                Next
                cmdLock.Enabled = False
                cmdUnLock.Enabled = True
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
            If Thongbao("Chắc chắn bạn muốn mở khóa điểm thành phần của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("ID_diem").ToString <> "" Then
                        clsDiem.Update_DiemThanhPhanLock(dtDiem.Rows(i)("ID_diem"), 0)
                    End If
                Next
                cmdLock.Enabled = True
                cmdUnLock.Enabled = False
                'Load lại dữ liệu điểm
                cmbMonHoc_SelectedIndexChanged(sender, e)
                Thongbao("Đã mở khoá điểm thành công !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btKiemTraBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKiemTraBu.Click
        If cmbID_mon.SelectedIndex >= 0 Then
            Dim f As New frmKiemTraBu
            f.ShowDialog(cmbID_mon.SelectedValue, TrvLop_ChuanHoa.ID_lop_list, cmbHoc_ky.SelectedValue, cmbNam_hoc.SelectedValue)
        End If
    End Sub

    Private Sub btHocBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHocBu.Click
        If cmbID_mon.SelectedIndex >= 0 Then
            Dim f As New frmHocBu(cmbID_mon.SelectedValue, TrvLop_ChuanHoa.ID_lop_list, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, Convert.ToInt32(cmbLan_hoc.Text))
            f.ShowDialog()
        End If
    End Sub
    Public Sub refreshDiemTP()
        Try
            Try
                If Loader Then
                    'Load danh sách điểm của sinh viên
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                        ' Nếu chua có thành phần điểm đã chọn thì load số bài điểm thành phần mặc định theo số ĐV học trình
                        If clsDiem.SoThanhPhanDiem = 0 Then
                            Dim So_hoc_trinh As Integer = 0
                            For i As Integer = 0 To mdtMonHoc.Rows.Count - 1
                                If mdtMonHoc.Rows(i)("ID_mon") = ID_mon Then
                                    So_hoc_trinh = mdtMonHoc.Rows(i)("So_hoc_trinh")
                                    Exit For
                                End If
                            Next
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc, So_hoc_trinh).DefaultView
                        Else
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Lan_hoc).DefaultView
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    FormatDataView()
                    Dim Lock_diem As Boolean = False
                    KhoaDuLieu(Lock_diem)
                    If Lock_diem = True Then
                        btnDel.Enabled = False
                        btnSave.Enabled = False
                        btnTP_Diem.Enabled = False
                    Else
                        btnDel.Enabled = True
                        btnSave.Enabled = True
                        btnTP_Diem.Enabled = True
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnBangDiemTP_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBangDiemTP.ItemClick
        GetReportHeader()
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Ten_hoc_phan, He As String, Chuyen_nganh As String, Lop As String
                Dim tieu_de As String = ""
                Dim ID_Lop As Integer = TrvLop_ChuanHoa.ID_lop_list
                Dim ID_Mon As Integer = cmbID_mon.SelectedValue
                Dim Lan_hoc As Integer = CType(cmbLan_hoc.Text, Integer)
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                Dim para(2) As SqlClient.SqlParameter
                para(0) = New SqlClient.SqlParameter("@ID_lop", ID_Lop)
                para(1) = New SqlClient.SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlClient.SqlParameter("@Nam_hoc", Nam_hoc)

                Dim dt As DataTable = ESS.Machine.UDB.SelectTableSP("Load_ThanhPhanDiem_ID_lop", para)

                If ID_Lop > 0 Then
                    Ten_hoc_phan = cmbID_mon.Text
                    Dim dtDiemTH As New DataTable
                    dtDiemTH = grdViewDiem.DataSource.Table()
                    dtDiemTH.Columns.Add("Khong_du_dk", GetType(String))
                    For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                        If dtDiemTH.Rows(i)("Ghi_chu").ToString <> "" Then
                            dtDiemTH.Rows(i)("Khong_du_dk") = "Cấm thi"
                        End If
                    Next
                    Dim dv_tmp As DataView = dtDiemTH.DefaultView
                    He = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Ten_he").ToString
                    Chuyen_nganh = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Chuyen_nganh").ToString
                    Lop = dv_tmp.Item(grdViewDiem.CurrentRow.Index).Item("Ten_lop").ToString
                    Dim dtTP As DataTable
                    dtTP = clsDiem.DanhSachThanhPhanChon
                    tieu_de = "BẢNG GHI ĐIỂM"
                    Dim tieu_de2 As String = " HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                    Dim tieu_de3 As String = "Môn: " & cmbID_mon.Text
                    Dim tieu_de4 As String = "Ngày kiểm tra hết môn: ........................... "
                    Dim frm As New rptBangDiemThanhPhan_Dynamic(Lop, dtDiemTH.DefaultView, dtTP.DefaultView, tieu_de, tieu_de2, tieu_de3, tieu_de4)
                    PrintXtraReport(frm)
                End If
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
            Call cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDS_theo_doi_ngay_HT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaocao_ket_qua_thi.ItemClick
        Try
            GetReportHeader()
            If grdViewDiem.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDiem.DataSource
            Dim rpt As New rptBaoCaoKetQuaDiemThi_KiemTra_DiemTB_DiemTK(dv)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbThanh_phan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbThanh_phan.SelectedIndexChanged

    End Sub

    Private Sub cb_Diem_la0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Diem_la0.CheckedChanged
        If grdViewDiem.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewDiem.DataSource
        Dim ID_thanh_phan As Integer
        For i As Integer = 0 To dv.Count - 1
            For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                If clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Checked Then
                    ID_thanh_phan = clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan
                    If dv.Item(i)("TP" + ID_thanh_phan.ToString).ToString = "" Then
                        dv.Item(i)("TP" + ID_thanh_phan.ToString) = 0
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub btnDanh_sach_du_thi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDanh_sach_du_thi.ItemClick
        Try
            GetReportHeader()
            Dim cls As New Diem_BLL
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim ID_lop As Integer = TrvLop_ChuanHoa.ID_lop_list
            Dim dt As DataTable = cls.DanhSachSinhVien_NoTheoHocPhan(ID_mon, ID_lop)
            Dim Tieu_de As String = TrvLop_ChuanHoa.Tieu_de
            If ID_mon > 0 And ID_lop.ToString <> "" Then
                Dim rpt As New rptDanhSachSinhVienNoTheoHocPhan(dt.DefaultView, Tieu_de, cmbHoc_ky.Text, cmbNam_hoc.Text)
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    'Private Sub cmdPhieuKiemTra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPhieuKiemTra.ItemClick
    '    Try
    '        GetReportHeader()
    '        Dim dv As DataView = grdViewDiem.DataSource
    '        If cmbID_mon.Text <> "" Then
    '            Dim rpt As New rpt_DS_ToChucThi_PhieuTheoDoi_LyThuyet(dv, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbID_mon.Text)
    '            PrintXtraReport(rpt)
    '        End If
    '    Catch ex As Exception
    '        Thongbao(ex.Message)
    '    End Try
    'End Sub


    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            Dim tieu_de As String = ""
            Dim ID_Lop As Integer = TrvLop_ChuanHoa.ID_lop_list
            Dim ID_Mon As Integer = cmbID_mon.SelectedValue
            Dim Lan_hoc As Integer = CType(cmbLan_hoc.Text, Integer)
            Dim Hoc_ky As Integer = 0
            Dim Nam_hoc As String = ""
            Hoc_ky = cmbHoc_ky.Text
            Nam_hoc = cmbNam_hoc.Text
            Dim para(2) As SqlClient.SqlParameter
            para(0) = New SqlClient.SqlParameter("@ID_lop", ID_Lop)
            para(1) = New SqlClient.SqlParameter("@Hoc_ky", Hoc_ky)
            para(2) = New SqlClient.SqlParameter("@Nam_hoc", Nam_hoc)

            Dim dt As DataTable = ESS.Machine.UDB.SelectTableSP("Load_ThanhPhanDiem_ID_lop", para)
            Dim dvHeSo2 As DataView
            Dim dtHeSo1 As DataTable = dt.Select("Ty_le = 1").CopyToDataTable()

            dvHeSo2 = dt.DefaultView
            dvHeSo2.RowFilter = "Ty_le = 2"

            Dim report As New rptBangTongHopDiemKT(dtHeSo1.DefaultView, dvHeSo2, dv, cmbID_mon.Text)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_ds_day_du_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ds_day_du.CheckedChanged
        Try
            Load_DS(TrvLop_ChuanHoa.ID_lop_list, chk_ds_day_du.Checked)
            Load_Ds_nhap_diem_thanh_phan()
        Catch ex As Exception

        End Try
    End Sub
End Class