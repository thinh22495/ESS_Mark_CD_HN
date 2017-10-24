Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid

Public Class frmESS_TongHopDiemMonMain
    Private mID_he As Integer = 0
    Private dsID_lop As String = "0"
    Private mID_dt As Integer = 0
    Private mNien_khoa As String = ""
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private mdt_hp As DataTable
    Private mLan_thi As Integer = 1

    Private Sub frmESS_TongHopDiemMonMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmESS_TongHopDiemMonMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi thứ
        LoadComboBox()
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.Load_TreeView()
        SetUpDataGridView(grdViewDiem)
        cmbLan_thi.SelectedIndex = 0
        SetQuyenTruyCap(cmdSave, cmdTongHop, , )
        Loader = True
    End Sub

    Private Sub frmESS_TongHopDiemMonMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Function"
    Private Sub FormatDataView()
        Try
            grdViewDiem.Columns.Clear()
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
            'Không đủ điều kiện thi
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ten_lop"
                .DataPropertyName = "Ten_lop"
                .HeaderText = "Tên lớp"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col4)
            For i As Integer = 0 To mdt_hp.Rows.Count - 1
                Dim col As New DataGridViewTextBoxColumn
                col.Name = "ID_mon_sub" + mdt_hp.Rows(i).Item("ID_mon").ToString
                col.DataPropertyName = "ID_mon_sub" + mdt_hp.Rows(i).Item("ID_mon").ToString
                col.HeaderText = mdt_hp.Rows(i).Item("Ten_mon").ToString + " (" + mdt_hp.Rows(i).Item("So_hoc_trinh").ToString + " đvht)"
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                col.Width = 140
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.DefaultCellStyle.NullValue = ""
                col.ReadOnly = True
                Me.grdViewDiem.Columns.Add(col)
            Next
            'TBCBP
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "TBCHP_Main"
                .DataPropertyName = "TBCHP_Main"
                .HeaderText = "TBC Học phần"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col5)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckValidate() As Boolean
        If cmbHoc_ky.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn học kỳ trước khi tổng hợp")
            cmbHoc_ky.Focus()
            Return False
        End If
        If cmbNam_hoc.Text = "" Then
            Thongbao("Bạn phải chọn năm học trước khi tổng hợp")
            cmbNam_hoc.Focus()
            Return False
        End If
        If cmbLan_thi.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn lần thi trước khi tổng hợp")
            cmbLan_thi.Focus()
            Return False
        End If
        If TreeViewLop.Khoa_hoc <= 0 Then
            Thongbao("Bạn phải chọn đến khóa đào tạo !")
            Return False
        End If
        Return True
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
    Private Sub Add_MonHoc()
        Try
            If mID_dt = 0 Then Exit Sub
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc_NhomHocPhan(Ky_thu, mID_dt)
                'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TrvLop_ChuanHoa1_TreeNodeSelected_() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not TreeViewLop.ID_lop_list Is Nothing Then
                    mID_he = TreeViewLop.ID_he
                    dsID_lop = TreeViewLop.ID_lop_list
                    mNien_khoa = TreeViewLop.Nien_khoa
                    mID_dt = TreeViewLop.ID_dt_list
                    'Load danh sách các môn trong chương trình đào tạo khung
                    If mID_dt > 0 Then
                        clsCTDT = New ChuongTrinhDaoTao_BLL()
                        'Load môn học vào Combobox
                        Add_MonHoc()
                    End If
                    'Load danh sách sinh viên
                    Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            If mID_dt = 0 Or cmbID_mon.Text.Trim = "" Or cmbLan_hoc.Text.Trim = "" Or cmbLan_thi.Text.Trim = "" Then Exit Sub
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc_NhomHocPhaSub(Ky_thu, mID_dt, cmbID_mon.SelectedValue, cmbLan_hoc.Text, cmbLan_thi.Text, dsID_lop, mdtDanhSachSinhVien, mdt_hp)
                FormatDataView()
                grdViewDiem.DataSource = dt
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class