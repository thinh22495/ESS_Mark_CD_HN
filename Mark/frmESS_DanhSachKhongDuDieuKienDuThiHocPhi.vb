Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_DanhSachKhongDuDieuKienDuThiHocPhi
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable

    Private clsXet As DanhSachKhongThi_BLL

    Private Lam_tron_TBCHP As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_BLL


#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Load_danhsach_khongduDKDT()
        Try
            Try
                If Loader Then
                    'Load danh sách điểm của sinh viên
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    If mdtDanhSachSinhVien.Rows.Count > 0 Then
                        clsXet = New DanhSachKhongThi_BLL(Hoc_ky, Nam_hoc, dsID_lop)
                        Dim dt As DataTable = clsXet.Danh_sach_sinh_vien_no_HocTap
                        labSo_sv.Text = dt.Rows.Count
                        grcDanhSachKDK.DataSource = dt.DefaultView

                        Dim dv As DataView
                        If optDanh_sach.Checked Then
                            dv = clsXet.DanhSachKhongDuDieuKienDuThi_LopHC(dt, mdtDanhSachSinhVien).DefaultView
                            grcDanhSachThi.DataSource = dv
                            lblSo_sv.Text = dv.Count
                        End If

                        If optHocPhi_Ky.Checked Then
                            dv = clsXet.DanhSachKhongDuDieuKienDuThi_NoHocPhiKy(Hoc_ky, Nam_hoc, dsID_lop).DefaultView
                            grcDanhSachThi.DataSource = dv
                            lblSo_sv.Text = dv.Count
                        End If
                    Else
                        grcDanhSachThi.DataSource = Nothing
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TrvLop_ChuanHoa1.Load_TreeView()
            Loader = True
            SetQuyenTruyCap(, cmdAdd, , cmdDelete)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TrvLop_ChuanHoa1_Select() Handles TrvLop_ChuanHoa1.TreeNodeSelected_
        Try
            If Loader Then
                If Not TrvLop_ChuanHoa1.ID_lop_list Is Nothing Then
                    dsID_lop = TrvLop_ChuanHoa1.ID_lop_list
                    Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    'Load danh sách điểm
                    Load_danhsach_khongduDKDT()
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optHoc_tap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDanh_sach.CheckedChanged, optHocPhi_Ky.CheckedChanged
        Try
            If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And dsID_lop.Trim <> "0" Then
                Load_danhsach_khongduDKDT()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim dv As DataView = grvDanhSachThi.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New DanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.Hoc_ky = cmbHoc_ky.Text.Trim
                    obj.Nam_hoc = cmbNam_hoc.Text.Trim
                    obj.Ly_do = dv.Table.Rows(i).Item("Ly_do")
                    clsXet.Insert_DanhSachKhongThi(obj)
                End If
            Next

            Load_danhsach_khongduDKDT()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim dv As DataView = grvDanhSachKDK.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New DanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.Hoc_ky = cmbHoc_ky.Text.Trim
                    obj.Nam_hoc = cmbNam_hoc.Text.Trim
                    clsXet.Delete_DanhSachKhongThi(obj)
                End If
            Next

            Load_danhsach_khongduDKDT()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub chkAll1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachKDK.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView = grvDanhSachKDK.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy

                dt.Columns.Add("Tieu_de1")
                dt.Columns.Add("Tieu_de2")
                dt.Columns.Add("Chuc_danh1")
                dt.Columns.Add("Chuc_danh2")
                dt.Columns.Add("Nguoi_ky1")
                dt.Columns.Add("Nguoi_ky2")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dt.Rows.Count - 1

                    dt.Rows(i).Item("Chuc_danh1") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
                    dt.Rows(i).Item("Chuc_danh2") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
                    dt.Rows(i).Item("Nguoi_ky1") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    dt.Rows(i).Item("Nguoi_ky2") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2

                    dt.Rows(i).Item("Tieu_de1") = "Học kỳ: " & cmbHoc_ky.Text.Trim & " Năm học: " & cmbNam_hoc.Text.Trim
                    dt.Rows(i).Item("Tieu_de2") = TrvLop_ChuanHoa1.Tieu_de.ToUpper
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS KhongDu DKThi", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            Load_danhsach_khongduDKDT()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSachKDK, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
#End Region
End Class