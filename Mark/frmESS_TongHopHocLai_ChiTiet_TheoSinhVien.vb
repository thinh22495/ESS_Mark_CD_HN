Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmESS_TongHopHocLai_ChiTiet_TheoSinhVien
    Private Loader As Boolean = False
    Private Id_he As Integer = -1
    Private Khoa_hoc As Integer = -1
    Private Id_khoa As Integer = -1
    Private Id_chuyen_nganh As Integer = -1
    Private Id_lop As Integer = -1
    Public ID_dt, ID_sv As Integer
    Private clsDiem As New Diem_BLL
    Private dt_BangdiemMain As DataTable
    Private Sub frmESS_TongHopHocLai_ChiTiet_TheoSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadComboBox()
        Loader = True
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
            Dim dt As New DataTable
            Dim clsDM As New DanhMuc_BLL
            'Load combobox Hệ đào tạo
            dt = clsDM.LoadDanhMuc("Select ID_he,Ten_he from  STU_He")
            FillCombo(cmbID_he, dt)
            dt = clsLop.Khoa_hoc()
            FillCombo(cmbKhoa_hoc, dt)
            dt = clsDM.LoadDanhMuc("Select distinct ID_khoa,Ten_khoa from  STU_Khoa")
            FillCombo(cmbID_khoa, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Loader Then
                Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
                Dim dtLop As DataTable = clsLop.Danh_sach_lop_dang_hoc()
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " AND ID_he=" & cmbID_he.SelectedValue
                dtLop.DefaultView.RowFilter = dk
                FillCombo(cmbID_lop, dtLop.DefaultView.Table, "ID_lop", "Ten_lop")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
                Dim dtLop As DataTable = clsLop.Danh_sach_lop_dang_hoc()
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " AND ID_he=" & cmbID_he.SelectedValue
                If cmbKhoa_hoc.Text.Trim <> "" Then dk += " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                dtLop.DefaultView.RowFilter = dk
                FillCombo(cmbID_lop, dtLop.DefaultView.Table, "ID_lop", "Ten_lop")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct cn.ID_chuyen_nganh,cn.Chuyen_nganh from  STU_Lop l inner join  STU_ChuyenNganh cn On l.ID_chuyen_nganh=cn.ID_chuyen_nganh where " & dk)
                FillCombo(cmbID_chuyen_nganh, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loader Then
                Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
                Dim dtLop As DataTable = clsLop.Danh_sach_lop_dang_hoc()
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " AND ID_he=" & cmbID_he.SelectedValue
                If cmbKhoa_hoc.Text.Trim <> "" Then dk += " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                If cmbID_khoa.Text.Trim <> "" Then dk += " AND Id_khoa=" & cmbID_khoa.SelectedValue
                If cmbID_chuyen_nganh.Text.Trim <> "" Then dk += " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                dtLop.DefaultView.RowFilter = dk
                FillCombo(cmbID_lop, dtLop.DefaultView.Table, "ID_lop", "Ten_lop")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_lop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_lop.SelectedIndexChanged
        If cmbID_lop.SelectedValue > 0 And Loader Then
            Dim clsDS As New DanhSachSinhVien_BLL(cmbID_lop.SelectedValue)
            Dim dtSinhVien As DataTable = clsDS.Danh_sach_sinh_vien_bang_diem(cmbID_lop.SelectedValue)
            If cmbID_lop.Text.Trim <> "" Then
                Me.grcViewDanhSachSinhVien.DataSource = dtSinhVien.DefaultView
            Else
                Me.grcViewDanhSachSinhVien.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub LoadBangDiem(ByVal ID_he As Integer, ByVal ID_sv As Integer, ByVal ID_dt As Integer)
        Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
        Dim dt As DataTable = dv.Table.Copy
        dt.DefaultView.RowFilter = "ID_SV=" & ID_sv
        Me.grcViewDiem.DataSource = Nothing
        If dv.Count > 0 Then
            Dim clsDiem As New BangDiemCaNhan_BLL(ID_he, gobjUser.ID_dv, dt.DefaultView, ID_dt, 0, "")
            dt_BangdiemMain = clsDiem.BangDiem()
            Me.grcViewDiem.DataSource = dt_BangdiemMain.DefaultView
            'Return dt_BangdiemMain.DefaultView
        End If
    End Sub
    Private Sub grdViewDanhSachSinhVien_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdViewDanhSachSinhVien.FocusedRowChanged
        Try
            If Loader Then
                Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
                If Not grdViewDanhSachSinhVien.GetFocusedDataRow() Is Nothing AndAlso cmbID_lop.Text.Trim <> "" Then
                    Dim row As DataRow = grdViewDanhSachSinhVien.GetFocusedDataRow()
                    ID_sv = row("ID_sv").ToString
                    If cmbID_chuyen_nganh.SelectedIndex = 0 Then
                        ID_dt = row("ID_dt").ToString
                    Else
                        ID_dt = IIf(row("ID_dt2").ToString = "", 1, row("ID_dt2").ToString)
                    End If
                    LoadBangDiem(cmbID_he.SelectedValue, ID_sv, ID_dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class