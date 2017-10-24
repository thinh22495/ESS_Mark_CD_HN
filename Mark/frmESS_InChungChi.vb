Imports System.Drawing.Drawing2D
Imports System.IO
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports System.Collections.Generic
Public Class frmESS_InChungChi
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Private mTen_cc As String = ""
    Private mTrangThai As Boolean = False
    Private objInChungChi As New InChungChi_BLL

    Public Overloads Sub ShowDialog(ByVal ID_sv As Integer, ByVal Ten_cc As String)
        Try
            mID_sv = ID_sv
            mTen_cc = Ten_cc
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Show()
    End Sub

    Private Sub frmESS_InChungChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_ComBo()
        If mID_sv > 0 And mTen_cc <> "" Then
            Fill_Data()
        Else
            cmbGioi_tinh.SelectedIndex = -1
            cmbChuyen_nganh.SelectedValue = -1
            cmbTen_cc.SelectedIndex = -1
            cmbTen_tinh.SelectedValue = -1
            cmbTen_lop.SelectedValue = -1
            cmbXep_loai.SelectedValue = -1
        End If
        Loader = True
    End Sub
    Private Sub Fill_ComBo()
        FillCombo(cmbChuyen_nganh, "SELECT ID_chuyen_nganh,Chuyen_nganh FROM STU_ChuyenNganh")
        FillCombo(cmbXep_loai, "SELECT ID_xep_hang,Xep_hang FROM MARK_XepHangTotNghiep")
        FillCombo(cmbTen_tinh, "SELECT ID_tinh,Ten_tinh FROM STU_Tinh")
    End Sub

    Private Sub cmbChuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChuyen_nganh.SelectedIndexChanged
        Dim mID_chuyen_nganh As Integer = cmbChuyen_nganh.SelectedValue
        Dim dt As New DataTable
        If mID_chuyen_nganh > 0 Then
            dt = UDB.SelectTable("SELECT ID_lop,Ten_lop FROM STU_Lop where Khoa_hoc = 1 AND ID_chuyen_nganh = " & cmbChuyen_nganh.SelectedValue)
        Else
            dt = UDB.SelectTable("SELECT ID_lop,Ten_lop FROM STU_Lop where khoa_hoc = 1")
        End If
        FillCombo(cmbTen_lop, dt)
    End Sub
    Private Sub Fill_Data()
        Dim objChungChi As New InChungChi_BLL()
        Dim dt As DataTable = objChungChi.Load_ChungChi(mID_sv, mTen_cc)
        If dt.Rows.Count = 0 Then Exit Sub
        txtID_sv.Text = dt.Rows(0)("ID_sv").ToString
        txtMa_sv.Text = dt.Rows(0)("Ma_sv").ToString
        txtHo_ten.Text = dt.Rows(0)("Ho_ten").ToString
        cmbTen_tinh.Text = dt.Rows(0)("Ten_tinh")
        If dt.Rows(0)("Ngay_sinh").ToString.Trim <> "" Then
            dtpNgay_sinh.Value = dt.Rows(0)("Ngay_sinh")
        End If
        If dt.Rows(0)("Gioi_tinh").ToString.Trim <> "" Then
            cmbGioi_tinh.Text = dt.Rows(0)("Gioi_tinh").ToString
        End If
        If dt.Rows(0)("Ten_lop").ToString.Trim <> "" Then
            cmbTen_lop.Text = dt.Rows(0)("Ten_lop").ToString
        End If
        If dt.Rows(0)("Chuyen_nganh").ToString.Trim <> "" Then
            cmbChuyen_nganh.Text = dt.Rows(0)("Chuyen_nganh").ToString
        End If
        txtDiem.Text = dt.Rows(0)("Diem").ToString
        cmbXep_loai.Text = dt.Rows(0)("Xep_loai").ToString
        txtSo_hieu.Text = dt.Rows(0)("So_hieu").ToString
        txtSo_vao_so.Text = dt.Rows(0)("So_vao_so").ToString
        cmbTen_cc.Text = dt.Rows(0)("Ten_cc").ToString
        txtTu_ngay.Text = dt.Rows(0)("Tu_ngay").ToString
        txtDen_ngay.Text = dt.Rows(0)("Den_ngay").ToString
        txtTu_thang.Text = dt.Rows(0)("Tu_thang").ToString
        txtDen_thang.Text = dt.Rows(0)("Den_thang").ToString
    End Sub
    Private Sub getData(ByVal obj As InChungChi)
        obj.ID_sv = txtID_sv.Text.ToString
        obj.Ma_sv = txtMa_sv.Text.ToString
        obj.Ho_ten = txtHo_ten.Text.ToString.ToUpper
        If dtpNgay_sinh.Checked = True Then
            obj.Ngay_sinh = dtpNgay_sinh.Value
        End If
        obj.Gioi_tinh = cmbGioi_tinh.Text
        obj.Ten_tinh = cmbTen_tinh.Text.ToString
        obj.Chuyen_nganh = cmbChuyen_nganh.Text.ToString
        obj.Ten_lop = cmbTen_lop.Text.ToString
        obj.Diem = txtDiem.Text.ToString
        obj.Xep_loai = cmbXep_loai.Text.ToString
        obj.So_hieu = txtSo_hieu.Text.ToString
        obj.So_vao_so = txtSo_vao_so.Text.ToString
        obj.Ten_cc = cmbTen_cc.Text.ToString
        obj.Tu_ngay = txtTu_ngay.Text.ToString
        obj.Den_ngay = txtDen_ngay.Text.ToString
        obj.Tu_thang = txtTu_thang.Text.ToString
        obj.Den_thang = txtDen_thang.Text.ToString
    End Sub

    Private Sub ResetTextBox()
        txtDiem.Text = ""
        txtSo_hieu.Text = ""
        txtSo_vao_so.Text = ""
        txtTu_ngay.Text = ""
        txtDen_ngay.Text = ""
        txtTu_thang.Text = ""
        txtDen_thang.Text = ""
        txtID_sv.Text = ""
        txtMa_sv.Text = ""
        txtHo_ten.Text = ""
        dtpNgay_sinh.Value = DateTime.Now.Date
        cmbGioi_tinh.SelectedIndex = -1
        cmbChuyen_nganh.SelectedValue = -1
        cmbTen_cc.SelectedIndex = -1
        cmbTen_tinh.SelectedValue = -1
        cmbTen_lop.SelectedValue = -1
        cmbXep_loai.SelectedValue = -1
    End Sub

    Private Function checkValidate() As Boolean
        Dim valid As Boolean = True
        ErrorProvider1.Dispose()
        If txtHo_ten.Text = "" Then
            ErrorProvider1.SetError(txtHo_ten, "Bạn phải nhập họ tên")
            txtHo_ten.Focus()
            valid = False
        End If
        
        If txtID_sv.Text = "" Then
            ErrorProvider1.SetError(txtID_sv, "Bạn phải nhập ID SV")
            txtID_sv.Focus()
            valid = False
        End If

        If cmbChuyen_nganh.Text = "" Then
            ErrorProvider1.SetError(cmbChuyen_nganh, "Bạn phải nhập Chuyên ngành")
            cmbChuyen_nganh.Focus()
            valid = False
        End If

        If cmbTen_lop.Text = "" Then
            ErrorProvider1.SetError(cmbTen_lop, "Bạn phải nhập Tên lớp")
            cmbTen_lop.Focus()
            valid = False
        End If

        If cmbTen_cc.Text = "" Then
            ErrorProvider1.SetError(cmbTen_cc, "Bạn phải nhập Tên chứng chỉ")
            cmbTen_cc.Focus()
            valid = False
        End If

        If cmbXep_loai.Text = "" Then
            ErrorProvider1.SetError(cmbXep_loai, "Bạn phải nhập Xếp loại")
            cmbXep_loai.Focus()
            valid = False
        End If

        If txtDiem.Text.Length > 0 Then
            If Not IsNumeric(txtDiem.Text.Trim()) Then
                ErrorProvider1.SetError(txtDiem, "Bạn phải nhập điểm là số lớn hơn 0 và nhỏ hơn 11")
                txtDiem.Focus()
                valid = False
            Else
                If Convert.ToDouble(txtDiem.Text) < 0 Or Convert.ToDouble(txtDiem.Text) > 10 Then
                    ErrorProvider1.SetError(txtDiem, "Bạn phải nhập điểm là số lớn hơn 0 và nhỏ hơn 11")
                    txtDiem.Focus()
                    valid = False
                End If
            End If
        End If

        If txtTu_ngay.Text.Length > 0 Then
            If Not IsNumeric(txtTu_ngay.Text.Trim()) Then
                ErrorProvider1.SetError(txtTu_ngay, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 32")
                txtTu_ngay.Focus()
                valid = False
            Else
                If Convert.ToDouble(txtTu_ngay.Text) < 1 Or Convert.ToDouble(txtTu_ngay.Text) > 31 Then
                    ErrorProvider1.SetError(txtTu_ngay, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 32")
                    txtTu_ngay.Focus()
                    valid = False
                End If
            End If
        End If

        If txtDen_ngay.Text.Length > 0 Then
            If Not IsNumeric(txtDen_ngay.Text.Trim()) Then
                ErrorProvider1.SetError(txtDen_ngay, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 32")
                txtDen_ngay.Focus()
                valid = False
            Else
                If Convert.ToDouble(txtDen_ngay.Text) < 1 Or Convert.ToDouble(txtDen_ngay.Text) > 31 Then
                    ErrorProvider1.SetError(txtDen_ngay, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 32")
                    txtDen_ngay.Focus()
                    valid = False
                End If
            End If
        End If

        If txtTu_thang.Text.Length > 0 Then
            If Not IsNumeric(txtTu_thang.Text.Trim()) Then
                ErrorProvider1.SetError(txtTu_thang, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 13")
                txtTu_thang.Focus()
                valid = False
            Else
                If Convert.ToDouble(txtTu_thang.Text) < 1 Or Convert.ToDouble(txtTu_thang.Text) > 12 Then
                    ErrorProvider1.SetError(txtTu_thang, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 13")
                    txtTu_thang.Focus()
                    valid = False
                End If
            End If
        End If

        If txtDen_thang.Text.Length > 0 Then
            If Not IsNumeric(txtDen_thang.Text.Trim()) Then
                ErrorProvider1.SetError(txtDen_thang, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 13")
                txtDen_thang.Focus()
                valid = False
            Else
                If Convert.ToDouble(txtDen_thang.Text) < 1 Or Convert.ToDouble(txtDen_thang.Text) > 12 Then
                    ErrorProvider1.SetError(txtDen_thang, "Bạn phải nhập điểm là số lớn hơn 1 và nhỏ hơn 13")
                    txtDen_thang.Focus()
                    valid = False
                End If
            End If
        End If

        Return valid
    End Function

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim obj As New InChungChi
        If mID_sv > 0 And mTen_cc <> "" Then
            If checkValidate() Then
                getData(obj)
                objInChungChi.Update_InChungChi(obj, mID_sv, mTen_cc)
                Thongbao("Lưu hồ sơ thành công")
            End If
        Else
            If checkValidate() Then
                getData(obj)
                objInChungChi.Insert_InChungChi(obj)
                Thongbao("Lưu hồ sơ thành công")
                ResetTextBox()
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        mID_sv = -1
        mTen_cc = ""
        Me.Close()
    End Sub
End Class