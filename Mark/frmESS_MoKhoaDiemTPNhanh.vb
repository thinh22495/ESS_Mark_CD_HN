Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmESS_MoKhoaDiemTPNhanh
    Private Loader As Boolean = False
    Private Id_he As Integer = -1
    Private Khoa_hoc As Integer = -1
    Private Id_khoa As Integer = -1
    Private Id_chuyen_nganh As Integer = -1
    Private Id_lop As Integer = -1
    Private clsDiem As New Diem_BLL
    Private Sub frmESS_KhoaDiemNhanh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadComboBox()
        Loader = True
        'cmbHoc_ky.SelectedIndex = -1
        'cmbNam_hoc.Text = ""
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
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbID_he_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged
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

    Private Sub btLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLock.Click
        Try
            If cmbID_he.Text = "" And cmbKhoa_hoc.Text = "" And cmbID_khoa.Text = "" And cmbID_chuyen_nganh.Text = "" And cmbID_lop.Text = "" Then
                Thongbao("Bạn hãy chọn các điều kiện cần thiết để khóa điểm thi !", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            Dim Hoc_ky As Integer = 0
            Dim Nam_hoc As String = ""
            If cmbHoc_ky.Text <> "" Then Hoc_ky = CType(cmbHoc_ky.Text, Integer)
            If cmbNam_hoc.Text <> "" Then Nam_hoc = cmbNam_hoc.Text
            If cmbID_he.Text <> "" Then Id_he = cmbID_he.SelectedValue
            If cmbID_khoa.Text <> "" Then Id_khoa = cmbID_khoa.SelectedValue
            If cmbID_chuyen_nganh.Text <> "" Then Id_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue
            If cmbID_lop.Text <> "" Then Id_lop = cmbID_lop.SelectedValue
            If cmbKhoa_hoc.Text <> "" Then Khoa_hoc = CType(cmbKhoa_hoc.Text, Integer)
            clsDiem.Lock_Diem_TP_Nhanh(Id_he, Khoa_hoc, Id_khoa, Id_chuyen_nganh, Id_lop, Hoc_ky, Nam_hoc)
            Thongbao("Bạn đã khóa điểm thành công !", MsgBoxStyle.Information, "Thông báo")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub btUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUnLock.Click
        Try
            If cmbID_he.Text = "" And cmbKhoa_hoc.Text = "" And cmbID_khoa.Text = "" And cmbID_chuyen_nganh.Text = "" And cmbID_lop.Text = "" Then
                Thongbao("Bạn hãy chọn các điều kiện cần thiết để khóa điểm thi !", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            Dim Hoc_ky As Integer = 0
            Dim Nam_hoc As String = ""
            If cmbHoc_ky.Text <> "" Then Hoc_ky = CType(cmbHoc_ky.Text, Integer)
            If cmbNam_hoc.Text <> "" Then Nam_hoc = cmbNam_hoc.Text
            If cmbID_he.Text <> "" Then Id_he = cmbID_he.SelectedValue
            If cmbID_khoa.Text <> "" Then Id_khoa = cmbID_khoa.SelectedValue
            If cmbID_chuyen_nganh.Text <> "" Then Id_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue
            If cmbID_lop.Text <> "" Then Id_lop = cmbID_lop.SelectedValue
            If cmbKhoa_hoc.Text <> "" Then Khoa_hoc = CType(cmbKhoa_hoc.Text, Integer)
            clsDiem.UnLock_Diem_TP_Nhanh(Id_he, Khoa_hoc, Id_khoa, Id_chuyen_nganh, Id_lop, Hoc_ky, Nam_hoc)
            Thongbao("Bạn đã mở khóa điểm thành công !", MsgBoxStyle.Information, "Thông báo")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_KhoaDiemNhanh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
End Class