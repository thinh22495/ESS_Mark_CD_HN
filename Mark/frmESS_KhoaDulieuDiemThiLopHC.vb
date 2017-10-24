Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_KhoaDulieuDiemThiLopHC
    Private mID_he As Integer = 0
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private So_diem_thi As Integer = 0
    Private Lam_tron_TBCHP As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private mLan_thi As Integer = 1

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Dim cls As New ThamSoHeThong_BLL
            So_diem_thi = cls.Doc_tham_so("So_diem_thi")
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            Add_LanThi(cmbLan_thi, So_diem_thi)
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
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
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
            'TBCHP
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "TBCHP"
                .DataPropertyName = "TBCHP"
                .HeaderText = "TBC MH"
                .Width = 50
                .DefaultCellStyle.Format = "N" + Lam_tron_TBCHP.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col4)
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
            'Điểm thi
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Diem_thi"
                .DataPropertyName = "Diem_thi"
                .HeaderText = "Thi (" + (100 - Tong_ty_le).ToString + ")"
                .Width = 50
                .DefaultCellStyle.Format = "N" + Lam_tron_diem_thi.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'Ghi chú
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Ghi chú"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col7)
            'Locked
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col8)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub KhoaDuLieu()
        Try
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Then    'Edit
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
#End Region

    Private Sub frmESS_KhoaDulieuDiemThiLopHC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TrvLop_ChuanHoa.Load_TreeView()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, cmdLock, cmdUnLock, )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_KhoaDulieuDiemThiLopHC_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

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
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, Lan_hoc)
                        If cmbLan_thi.SelectedValue = 1 Then
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(ID_mon, Lan_hoc).DefaultView
                        Else
                            grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(Lan_hoc, cmbLan_thi.SelectedValue, ID_mon, chkNot_show_all.Checked).DefaultView
                        End If
                        FormatDataView()
                        KhoaDuLieu()
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thi.SelectedIndexChanged
        If Loader Then
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
            mLan_thi = cmbLan_thi.SelectedValue
            If mLan_thi = 1 Then
                Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(ID_mon, Lan_hoc).DefaultView
            Else
                Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(Lan_hoc, mLan_thi, ID_mon, chkNot_show_all.Checked).DefaultView
            End If
            KhoaDuLieu()
        End If
    End Sub


    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Try
            If Thongbao("Chắc chắn bạn muốn khóa điểm thi của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("TBCHP").ToString <> "" Then
                        clsDiem.Update_DiemThiLock(dtDiem.Rows(i)("ID_diem"), 1, cmbLan_hoc.SelectedIndex + 1, cmbLan_thi.SelectedValue)
                    End If
                Next
                'Load lại dữ liệu điểm
                cmbMonHoc_SelectedIndexChanged(sender, e)
                Thongbao("Đã khoá điểm thành công !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUnLock.Click
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmESS_KhoaDiemThiNhanh
        frm.ShowDialog()
    End Sub
End Class