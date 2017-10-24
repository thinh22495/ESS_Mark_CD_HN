Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine

Public Class frmTongHopSinhVienThiTotNghiepChinhTri
    Private mID_dt_new As Integer
    Private mclsCTDT As ChuongTrinhDaoTao_BLL
    Private clsLop As New Lop_BLL(gobjUser.dsID_lop, -1, -1, 1)
    Private loaded As Boolean = False
    Private Sub LoadComboBox()
        Try
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)

            'Load combobox khoa đào tạo
            dt = clsLop.Khoa()
            FillCombo(cmbID_khoa, dt)

            'Load combobox khoa đào tạo
            dt = clsLop.Khoa_hoc()
            FillCombo(cmbKhoa_hoc, dt)

            'Load combobox chuyên ngành đào tạo
            dt = clsLop.Chuyen_nganh_dao_tao()
            FillCombo(cmbID_chuyen_nganh, dt)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmTongHopSinhVienThiTotNghiepChinhTri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox
        LoadComboBox()
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(cmdSave)
        loaded = True
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                dt = cls.LoadDanhMuc("Select distinct ID_khoa,Ten_khoa from  STU_Khoa")
                FillCombo(cmbID_khoa, dt)
                If cmbLop.Text.Trim = "" Then
                    Me.grcDanhSach.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct l.Khoa_hoc,l.Khoa_hoc from  STU_Lop l where " & dk)
                FillCombo(cmbKhoa_hoc, dt)
                If cmbLop.Text.Trim = "" Then
                    Me.grcDanhSach.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct cn.ID_chuyen_nganh,cn.Chuyen_nganh from  STU_Lop l inner join  STU_ChuyenNganh cn On l.ID_chuyen_nganh=cn.ID_chuyen_nganh where " & dk)
                FillCombo(cmbID_chuyen_nganh, dt)
                If cmbLop.Text.Trim = "" Then
                    Me.grcDanhSach.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                If cmbID_chuyen_nganh.SelectedValue > 0 Then dk += " And l.ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                dt = cls.LoadDanhMuc("Select DISTINCT ID_Lop, Ten_lop from stu_Lop l where " & dk)
                FillCombo(cmbLop, dt)
                If cmbLop.Text.Trim = "" Then
                    Me.grcDanhSach.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        'Try
        '    If loaded Then
        '        If cmbID_chuyen_nganh.SelectedValue < 0 Then Exit Sub
        '        Dim dt As DataTable = UDB.SelectTable("Select ID_lop, Ten_lop from Stu_lop where ID_chuyen_nganh = " & cmbID_chuyen_nganh.SelectedValue)
        '        FillCombo(cmbLop, dt)
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If cmbLop.SelectedValue < 0 Then
            Thongbao("Bạn phải chọn 1 lớp để tổng hợp")
            Exit Sub
        Else
            Dim ID_lop As Integer = cmbLop.SelectedValue
            Dim cls As New TochucThi_BLL
            Dim dv As DataView = cls.Load_DiemThi_ChinhTri(ID_lop).DefaultView
            If dv.Count < 0 Then Exit Sub
            dv.RowFilter = "Diem_thi_max >=5 "
            cls.DELETE_SinhVienThiChinhTri(ID_lop)
            For i As Integer = 0 To dv.Count - 1
                Dim ID_sv As Integer = dv.Item(i)("ID_sv")
                Dim Diem_thi As Double = dv.Item(i)("Diem_thi_max")
                cls.Insert_SinhVienThiChinhTri(ID_sv, Diem_thi)
            Next
            Thongbao("Bạn đã tổng hợp sinh viên đủ điều kiện thi môn Chính trị thành công !")
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim cls As New DanhSachSinhVienThiTotNghiep_ChinhTri_BLL
            Dim dv As DataView = cls.DanhSachSinhVienThiTotNghiep_TheoKhoa(cmbKhoa_hoc.Text, cmbID_he.SelectedValue).DefaultView
            If dv.Count > 0 Then
                Dim tieu_de As String = "HỆ: " & cmbID_he.Text.ToString.ToUpper & "KHÓA HỌC: " & cmbKhoa_hoc.Text
                Dim rpt As New rptDanhSachDuDieuKienThiChinhTri(dv, tieu_de)
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            Thongbao("Không có dữ liệu để in báo cáo !")
        End Try
    End Sub

    Private Sub cmbLop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLop.SelectedIndexChanged
        If cmbLop.SelectedValue > 0 And loaded Then
            Dim cls As New DanhSachSinhVienThiTotNghiep_ChinhTri_BLL
            Dim dv As DataView = cls.DanhSachSinhVienThiTotNghiep_TheoLop(cmbLop.SelectedValue).DefaultView
            If cmbLop.Text.Trim <> "" Then
                Me.grcDanhSach.DataSource = dv
            Else
                Me.grcDanhSach.DataSource = Nothing
            End If
        End If
    End Sub
End Class