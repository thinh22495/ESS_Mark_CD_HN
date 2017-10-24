Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Machine
Public Class frmESS_XetTotNghiep
    Private dsID_lop_TN As String = "0"
    Private dsID_lop_ChuaTN As String = "0"
    Private mdtDanhSachSinhVien_TN As New DataTable
    Private mdtDanhSachSinhVien_ChuaTN As New DataTable
    Private clsDSXetTN As DanhSachTotNghiep_BLL
    Private mID_dt As Integer = 0
    Dim flag As Boolean = False
    Private No As Boolean = False
    Private clsDiem As New Diem_BLL

#Region "Form Events"
    Private Sub frmESS_XetTotNghiep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TrvLop_ChuanHoa1.Load_TreeView()
        Me.TrvLop_ChuanHoa2.Load_TreeView()

        Add_Namhoc(cmbNam_hoc)
        Add_Namhoc(cmbNam_hoc_CTN)
        flag = True
        SetQuyenTruyCap(, cmdXetTN, cmdLapSB, )
    End Sub
    Private Sub frmESS_XetTotNghiep_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"
    Private Sub TrvLop_ChuanHoa1_Select() Handles TrvLop_ChuanHoa1.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa1.ID_lop_list Is Nothing Then
                dsID_lop_TN = TrvLop_ChuanHoa1.ID_lop_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop_TN)
                mdtDanhSachSinhVien_TN = objDanhSach.Danh_sach_sinh_vien
                If TrvLop_ChuanHoa1.ID_chuyen_nganh > 0 Then
                    mID_dt = TrvLop_ChuanHoa1.ID_dt_list
                Else
                    mID_dt = 0
                End If
                clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_TN, mdtDanhSachSinhVien_TN, 1, mID_dt)
                If cmbNam_hoc.Text.Trim <> "" Then
                    Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim, TrvLop_ChuanHoa1.ID_he).DefaultView
                    grcTotNghiep.DataSource = dv
                    If dv.Count > 0 Then
                        Dim dt As DataTable = dv.Table.Copy
                        Dim clsDM As New DanhMuc_BLL
                        Dim dt_XepHang As DataTable = clsDM.LoadDanhMuc("SELECT ID_xep_hang,Xep_hang FROM MARK_XepHangTotNghiep_TC")
                        Dim str As String = ""
                        For i As Integer = 0 To dt_XepHang.Rows.Count - 1
                            dt.DefaultView.RowFilter = "ID_xep_loai=" & dt_XepHang.Rows(i)("ID_xep_hang")
                            If dt.DefaultView.Count > 0 Then str = str + "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%"
                        Next
                        'lblXet_TN.Text = str
                    End If
                End If
                labSo_sv.Text = grcTotNghiep.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub TrvLop_ChuanHoa2_Select() Handles TrvLop_ChuanHoa2.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa2.ID_lop_list Is Nothing Then
                dsID_lop_ChuaTN = TrvLop_ChuanHoa2.ID_lop_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop_ChuaTN)
                mdtDanhSachSinhVien_ChuaTN = objDanhSach.Danh_sach_sinh_vien
                If TrvLop_ChuanHoa2.ID_chuyen_nganh > 0 Then
                    mID_dt = TrvLop_ChuanHoa2.ID_dt_list
                Else
                    mID_dt = 0
                End If

                clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_ChuaTN, mdtDanhSachSinhVien_ChuaTN, 0, mID_dt)
                If cmbNam_hoc.Text.Trim <> "" Then
                    Dim dv As DataView = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                    grcNoTotNghiep.DataSource = dv
                End If
                lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub cmbNam_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNam_hoc.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        If flag Then
            If cmbNam_hoc.Text.Trim <> "" Then
                If TrvLop_ChuanHoa1.ID_chuyen_nganh > 0 Then
                    mID_dt = TrvLop_ChuanHoa1.ID_dt_list
                    clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_TN, mdtDanhSachSinhVien_TN, 1, mID_dt)
                    Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim, TrvLop_ChuanHoa1.ID_he).DefaultView
                    grcTotNghiep.DataSource = dv
                    labSo_sv.Text = grcTotNghiep.DataSource.Count
                End If
            End If
        End If
    End Sub

    Private Sub cmbNam_hoc_CTN_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNam_hoc_CTN.SelectedIndexChanged
        If flag Then
            If cmbNam_hoc_CTN.Text.Trim <> "" Then
                If TrvLop_ChuanHoa2.ID_chuyen_nganh > 0 Then
                    mID_dt = TrvLop_ChuanHoa2.ID_dt_list

                    clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_ChuaTN, mdtDanhSachSinhVien_ChuaTN, 0, mID_dt)
                    Dim dv As DataView = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                    grcNoTotNghiep.DataSource = dv

                    lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count
                End If
            End If
        End If
    End Sub





    Private Sub cmbLapSo_VB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbNam_hoc.Text.Trim <> "" And (txtTu_so_so_hieu.Text.Trim <> "" AndAlso IsNumeric(txtTu_so_so_hieu.Text.Trim)) Then
                Dim dv As DataView = grcTotNghiep.DataSource
                If dv.Count > 0 Then
                    'clsDSXetTN.CapNhat_ESSSoVB1(dv, txtTu_so_so_hieu.Text)
                    If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
                        Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                        Exit Sub
                    End If
                    mID_dt = TrvLop_ChuanHoa1.ID_dt_list

                    clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_TN, mdtDanhSachSinhVien_TN, 1, mID_dt)
                    dv = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim, TrvLop_ChuanHoa1.ID_he).DefaultView
                    grcTotNghiep.DataSource = dv
                End If
            Else
                Thongbao("Hãy chọn năm học và đánh số bắt đầu lập văn bằng dạng số nguyên !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtTu_so_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTu_so_so_hieu.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar)
    End Sub
    Private Sub cmdPrint_DS_nototnghiep_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_nototnghiep.ItemClick
        Try
            Dim dv As DataView = grcNoTotNghiep.DataSource
            If dv.Count > 0 Then
                dv.Table.Columns.Add("Tieu_de_ten_bo")
                dv.Table.Columns.Add("Tieu_de_Ten_truong")
                dv.Table.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
                dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
                Dim Tieu_de As String = ""
                If TrvLop_ChuanHoa2.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de = TrvLop_ChuanHoa2.Tieu_de_Lop.ToUpper
                Else
                    Tieu_de = TrvLop_ChuanHoa2.Tieu_de
                End If
                dv.Table.Rows(0).Item("Tieu_de") = Tieu_de

                'Dim frmESS_ As New frmESS_ReportView
                'frmESS_.ShowDialog_RFix("DS CHUA TOT NGHIEP", dv.Table)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_QD_totnghiep_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_QD_totnghiep.ItemClick
        Try
            'If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
            'Dim dv As DataView = grvTotNghiep.DataSource
            'dv.RowFilter = "Chon='True'"
            'Dim rpt As New rptGiayChungNhan_TotNghiep(dv)
            'PrintXtraReport(rpt)
            'cbChon.Checked = False

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_BD_toankhoa_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_BD_toankhoa.ItemClick
        'Try
        '    Dim objBaocao As New BaoCao
        '    Dim dv As DataView = grcTotNghiep.DataSource
        '    If dv.Count > 0 Then

        '        If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
        '            Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
        '            Exit Sub
        '        End If
        '        mID_dt = TrvLop_ChuanHoa1.ID_dt_list

        '        Dim clsDiem As Diem_BLL
        '        clsDiem = New Diem_BLL(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, mdtDanhSachSinhVien_TN)
        '        Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(grvTotNghiep.GetFocusedDataRow()("ID_SV"), 0, "")

        '        dt.Columns.Add("Tieu_de_ten_bo")
        '        dt.Columns.Add("Tieu_de_Ten_truong")
        '        dt.Columns.Add("Tieu_de_chuc_danh3")
        '        dt.Columns.Add("Tieu_de_chuc_danh4")
        '        dt.Columns.Add("Tieu_de_nguoi_ky3")
        '        dt.Columns.Add("Tieu_de_nguoi_ky4")
        '        dt.Columns.Add("Ma_sv")
        '        dt.Columns.Add("Ho_ten")
        '        dt.Columns.Add("Ngay_sinh")
        '        dt.Columns.Add("Ten_he")
        '        dt.Columns.Add("Ten_khoa")
        '        dt.Columns.Add("Khoa_hoc")
        '        dt.Columns.Add("Ten_nganh")
        '        dt.Columns.Add("Chuyen_nganh")
        '        dt.Columns.Add("Ten_tinh")
        '        dt.Columns.Add("Ten_lop")
        '        dt.Columns.Add("Nien_khoa")

        '        dt.Columns.Add("TBCHT")
        '        dt.Columns.Add("XEP_LOAI")
        '        dt.Columns.Add("TBC_RL")
        '        dt.Columns.Add("Xep_loai_RL")

        '        Dim obj_Bussines As DiemRenLuyen_Bussines
        '        obj_Bussines = New DiemRenLuyen_Bussines(TrvLop_ChuanHoa1.ID_lop_list)
        '        Dim dt_diemRL As DataTable = obj_Bussines.TongHop_DiemRenLuyenKhoa
        '        Dim TongDiemRL As Integer = 0
        '        Dim XepLoai_RL As String = ""
        '        For j As Integer = 0 To dt_diemRL.Rows.Count - 1
        '            If dt_diemRL.Rows(j).Item("ID_SV") = grvTotNghiep.GetFocusedDataRow()("ID_SV") Then
        '                TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
        '                XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
        '            End If
        '        Next

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        '        For i As Integer = 0 To dt.Rows.Count - 1
        '            dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
        '            dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

        '            dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
        '            dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
        '            dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
        '            dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


        '            dt.Rows(i).Item("Ma_sv") = grvTotNghiep.GetFocusedDataRow()("Ma_sv").ToString
        '            dt.Rows(i).Item("Ho_ten") = grvTotNghiep.GetFocusedDataRow()("Ho_ten").ToString
        '            dt.Rows(i).Item("Ngay_sinh") = grvTotNghiep.GetFocusedDataRow()("Ngay_sinh").ToString.Trim
        '            dt.Rows(i).Item("Ten_he") = grvTotNghiep.GetFocusedDataRow()("Ten_he").ToString
        '            dt.Rows(i).Item("Ten_khoa") = grvTotNghiep.GetFocusedDataRow()("Ten_khoa").ToString
        '            dt.Rows(i).Item("Khoa_hoc") = grvTotNghiep.GetFocusedDataRow()("Khoa_hoc").ToString
        '            dt.Rows(i).Item("Ten_nganh") = grvTotNghiep.GetFocusedDataRow()("Ten_nganh").ToString
        '            dt.Rows(i).Item("Chuyen_nganh") = grvTotNghiep.GetFocusedDataRow()("Chuyen_nganh").ToString
        '            dt.Rows(i).Item("Ten_tinh") = grvTotNghiep.GetFocusedDataRow()("Ten_tinh").ToString
        '            dt.Rows(i).Item("Ten_lop") = grvTotNghiep.GetFocusedDataRow()("Ten_lop").ToString
        '            dt.Rows(i).Item("Nien_khoa") = grvTotNghiep.GetFocusedDataRow()("Nien_khoa").ToString

        '            dt.Rows(i).Item("TBCHT") = grvTotNghiep.GetFocusedDataRow()("TBCHT").ToString
        '            dt.Rows(i).Item("XEP_LOAI") = grvTotNghiep.GetFocusedDataRow()("XEP_hang").ToString
        '            dt.Rows(i).Item("TBC_RL") = TongDiemRL
        '            dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
        '        Next
        '        Dim dvMain As DataView = dt.DefaultView
        '        Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
        '        Dim frm As New rpt_BangDiemTotNghiep(tieu_de, dt)
        '        frm.SetupDatasource(dvMain)
        '        PrintXtraReport(frm)
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmdXetTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXetTN.Click
        If cmbNam_hoc.Text.Trim <> "" And cmbLan_thu.Text.Trim <> "" Then
            If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            mID_dt = TrvLop_ChuanHoa1.ID_dt_list

            clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_TN, mdtDanhSachSinhVien_TN, 1, mID_dt)
            clsDSXetTN.XetTotNghiep(TrvLop_ChuanHoa1.ID_he, cmbNam_hoc.Text, cmbLan_thu.Text, gobjUser.ID_Bomon, optChungChi.Checked)

            Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim, TrvLop_ChuanHoa1.ID_he).DefaultView
            grcTotNghiep.DataSource = dv
            labSo_sv.Text = grcTotNghiep.DataSource.Count

            clsDSXetTN = New DanhSachTotNghiep_BLL(gobjUser.ID_dv, dsID_lop_ChuaTN, mdtDanhSachSinhVien_ChuaTN, 0, mID_dt)
            If cmbNam_hoc.Text.Trim <> "" Then
                dv = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                grcNoTotNghiep.DataSource = dv
            End If
            lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count

            Thongbao("Xét tốt nghiệp thành công !", MsgBoxStyle.Information)
        Else
            Thongbao("Bạn phải chọn Năm học và Lần xét khi xét tốt nghiệp !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Select Case TabControl1.SelectedIndex.ToString
                Case 0
                    If Not grcTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 1
                    If Not grcNoTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvNoTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Try
        '    Dim objBaocao As New BaoCao
        '    Dim dv As DataView = grcTotNghiep.DataSource
        '    If dv.Count > 0 Then

        '        If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
        '            Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
        '            Exit Sub
        '        End If
        '        mID_dt = TrvLop_ChuanHoa1.ID_dt_list

        '        Dim clsDiem As Diem_BLL
        '        clsDiem = New Diem_BLL(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, mdtDanhSachSinhVien_TN)
        '        Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(grvTotNghiep.GetFocusedDataRow()("ID_SV"), 0, "")

        '        dt.Columns.Add("Tieu_de_ten_bo")
        '        dt.Columns.Add("Tieu_de_Ten_truong")
        '        dt.Columns.Add("Tieu_de_chuc_danh3")
        '        dt.Columns.Add("Tieu_de_chuc_danh4")
        '        dt.Columns.Add("Tieu_de_nguoi_ky3")
        '        dt.Columns.Add("Tieu_de_nguoi_ky4")
        '        dt.Columns.Add("Ma_sv")
        '        dt.Columns.Add("Ho_ten")
        '        dt.Columns.Add("Ngay_sinh")
        '        dt.Columns.Add("Ten_he")
        '        dt.Columns.Add("Ten_khoa")
        '        dt.Columns.Add("Khoa_hoc")
        '        dt.Columns.Add("Ten_nganh")
        '        dt.Columns.Add("Chuyen_nganh")
        '        dt.Columns.Add("Ten_tinh")
        '        dt.Columns.Add("Ten_lop")
        '        dt.Columns.Add("Nien_khoa")

        '        dt.Columns.Add("TBCHT")
        '        dt.Columns.Add("XEP_LOAI")
        '        dt.Columns.Add("TBC_RL")
        '        dt.Columns.Add("Xep_loai_RL")

        '        Dim obj_Bussines As DiemRenLuyen_Bussines
        '        obj_Bussines = New DiemRenLuyen_Bussines(TrvLop_ChuanHoa1.ID_lop_list)
        '        Dim dt_diemRL As DataTable = obj_Bussines.TongHop_DiemRenLuyenKhoa
        '        Dim TongDiemRL As Integer = 0
        '        Dim XepLoai_RL As String = ""
        '        For j As Integer = 0 To dt_diemRL.Rows.Count - 1
        '            If dt_diemRL.Rows(j).Item("ID_SV") = grvTotNghiep.GetFocusedDataRow()("ID_SV") Then
        '                TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
        '                XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
        '            End If
        '        Next

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        '        For i As Integer = 0 To dt.Rows.Count - 1
        '            dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
        '            dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

        '            dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
        '            dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
        '            dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
        '            dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


        '            dt.Rows(i).Item("Ma_sv") = grvTotNghiep.GetFocusedDataRow()("Ma_sv").ToString
        '            dt.Rows(i).Item("Ho_ten") = grvTotNghiep.GetFocusedDataRow()("Ho_ten").ToString
        '            dt.Rows(i).Item("Ngay_sinh") = grvTotNghiep.GetFocusedDataRow()("Ngay_sinh").ToString.Trim
        '            dt.Rows(i).Item("Ten_he") = grvTotNghiep.GetFocusedDataRow()("Ten_he").ToString
        '            dt.Rows(i).Item("Ten_khoa") = grvTotNghiep.GetFocusedDataRow()("Ten_khoa").ToString
        '            dt.Rows(i).Item("Khoa_hoc") = grvTotNghiep.GetFocusedDataRow()("Khoa_hoc").ToString
        '            dt.Rows(i).Item("Ten_nganh") = grvTotNghiep.GetFocusedDataRow()("Ten_nganh").ToString
        '            dt.Rows(i).Item("Chuyen_nganh") = grvTotNghiep.GetFocusedDataRow()("Chuyen_nganh").ToString
        '            dt.Rows(i).Item("Ten_tinh") = grvTotNghiep.GetFocusedDataRow()("Ten_tinh").ToString
        '            dt.Rows(i).Item("Ten_lop") = grvTotNghiep.GetFocusedDataRow()("Ten_lop").ToString
        '            dt.Rows(i).Item("Nien_khoa") = grvTotNghiep.GetFocusedDataRow()("Nien_khoa").ToString

        '            dt.Rows(i).Item("TBCHT") = grvTotNghiep.GetFocusedDataRow()("TBCHT").ToString
        '            dt.Rows(i).Item("XEP_LOAI") = grvTotNghiep.GetFocusedDataRow()("XEP_hang").ToString
        '            dt.Rows(i).Item("TBC_RL") = TongDiemRL
        '            dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
        '        Next
        '        Dim dvMain As DataView = dt.DefaultView
        '        Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
        '        Dim frm As New rpt_BangDiemTotNghiep_Full(tieu_de, dt)
        '        frm.SetupDatasource(dvMain)
        '        PrintXtraReport(frm)
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmdPrint_DS_totnghiep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_totnghiep.ItemClick
        'Try
        '    Dim dv As DataView = grcTotNghiep.DataSource
        '    If dv.Count > 0 Then
        '        dv.Table.Columns.Add("Tieu_de_ten_bo")
        '        dv.Table.Columns.Add("Tieu_de_Ten_truong")

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        '        dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
        '        dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

        '        Dim frmESS_ As New frmESS_XemBaoCao
        '        frmESS_.ShowDialog_RFix("DS TOT NGHIEP", dv.Table)
        '    End If
        'Catch ex As Exception
        'End Try
        '''Try
        '''    Dim dv As DataView = grcTotNghiep.DataSource
        '''    If dv.Count = 0 Then Exit Sub
        '''    dv.Sort = "Ma_sv"
        '''    Me.Cursor = Cursors.WaitCursor
        '''    Dim Tieu_de1 As String = ""
        '''    Dim Tieu_de2 As String = ""
        '''    Dim Tieu_de3 As String = ""

        '''    Tieu_de1 = "DANH SÁCH TỐT NGHIỆP HỆ " & TrvLop_ChuanHoa1.Ten_he.ToUpper
        '''    If TrvLop_ChuanHoa1.Khoa_hoc Then
        '''        Tieu_de1 = Tieu_de1 + " KHÓA: " & TrvLop_ChuanHoa1.Khoa_hoc
        '''    End If
        '''    If TrvLop_ChuanHoa1.Ten_lop <> "" Then
        '''        Tieu_de1 = Tieu_de1 + "  LỚP: " & TrvLop_ChuanHoa1.Ten_lop.ToUpper
        '''    End If
        '''    Tieu_de2 = "(Kèm theo quyết định Công nhận tốt nghiệp số ................."
        '''    Tieu_de3 = "ngày ............... của Hiệu trưởng Trường Cao Đẳng Công Nghiệp Phúc Yêu)"

        '''    If dv.Count > 0 Then
        '''        Dim dt As DataTable = dv.Table.Copy
        '''        Dim clsDM As New DanhMuc_Bussines
        '''        Dim dt_XepHang As DataTable = clsDM.LoadDanhMuc("SELECT ID_xep_hang,Xep_hang FROM MARK_XepHangTotNghiep_TC")
        '''        Dim str As String = ""
        '''        For i As Integer = 0 To dt_XepHang.Rows.Count - 1
        '''            dt.DefaultView.RowFilter = "ID_xep_loai=" & dt_XepHang.Rows(i)("ID_xep_hang")
        '''            If dt.DefaultView.Count > 0 Then
        '''                If str.Trim = "" Then
        '''                    str = "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & dt.DefaultView.Count & " sv (" & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%)"
        '''                Else
        '''                    str = str + vbCrLf & "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & dt.DefaultView.Count & " sv (" & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%)"
        '''                End If
        '''            End If
        '''        Next
        '''        lblXet_TN.Text = str
        '''        Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMark_DanhSachSinhVien_TotNghiep", dv, Tieu_de1, Tieu_de2, Tieu_de3, str)
        '''        frmESS_.ShowDialog()
        '''    End If
        '''    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub cbChon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChon.CheckedChanged
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        For Each dr As DataRowView In dv
            dr("Chon") = cbChon.Checked
        Next
    End Sub

    Private Sub cmdSave_QD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_QD.Click
        Try
            If txtSo_QD.Text.Trim = "" Or dtmNgay_QD.Checked = False Then
                Thongbao("Hãy chọn ngày QĐ và số QĐ !")
                Exit Sub
            End If
            Dim dv As DataView = grvTotNghiep.DataSource
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    dr("So_QD") = txtSo_QD.Text.Trim
                    dr("Ngay_QD") = dtmNgay_QD.Value
                    clsDSXetTN.CapNhat_QuyetDinh(dr("So_QD"), dr("Ngay_QD"), dr("ID_SV"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'Try
        '    If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
        '        Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
        '        Exit Sub
        '    End If
        '    Dim objBaocao As New BaoCao
        '    Dim dv As DataView = grcTotNghiep.DataSource
        '    'If dv.Count > 0 Then
        '    For r As Integer = 0 To dv.Count - 1
        '        Dim clsDiem As Diem_BLL
        '        clsDiem = New Diem_BLL(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, mdtDanhSachSinhVien_TN)
        '        mID_dt = TrvLop_ChuanHoa1.ID_dt_list
        '        If dv.Item(r)("Chon") Then
        '            Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(dv.Item(r)("ID_SV"), 0, "")

        '            dt.Columns.Add("Tieu_de_ten_bo")
        '            dt.Columns.Add("Tieu_de_Ten_truong")
        '            dt.Columns.Add("Tieu_de_chuc_danh3")
        '            dt.Columns.Add("Tieu_de_chuc_danh4")
        '            dt.Columns.Add("Tieu_de_nguoi_ky3")
        '            dt.Columns.Add("Tieu_de_nguoi_ky4")
        '            dt.Columns.Add("Ma_sv")
        '            dt.Columns.Add("Ho_ten")
        '            dt.Columns.Add("Ngay_sinh")
        '            dt.Columns.Add("Ten_he")
        '            dt.Columns.Add("Ten_khoa")
        '            dt.Columns.Add("Khoa_hoc")
        '            dt.Columns.Add("Ten_nganh")
        '            dt.Columns.Add("Chuyen_nganh")
        '            dt.Columns.Add("Ten_tinh")
        '            dt.Columns.Add("Ten_lop")
        '            dt.Columns.Add("Nien_khoa")

        '            dt.Columns.Add("TBCHT")
        '            dt.Columns.Add("XEP_LOAI")
        '            dt.Columns.Add("TBC_RL")
        '            dt.Columns.Add("Xep_loai_RL")

        '            Dim obj_Bussines As DiemRenLuyen_Bussines
        '            obj_Bussines = New DiemRenLuyen_Bussines(TrvLop_ChuanHoa1.ID_lop_list)
        '            Dim dt_diemRL As DataTable = obj_Bussines.TongHop_DiemRenLuyenKhoa
        '            Dim TongDiemRL As Integer = 0
        '            Dim XepLoai_RL As String = ""
        '            For j As Integer = 0 To dt_diemRL.Rows.Count - 1
        '                If dt_diemRL.Rows(j).Item("ID_SV") = dv.Item(r)("ID_SV") Then
        '                    TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
        '                    XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
        '                End If
        '            Next

        '            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        '            For i As Integer = 0 To dt.Rows.Count - 1
        '                dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
        '                dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

        '                dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
        '                dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
        '                dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
        '                dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


        '                dt.Rows(i).Item("Ma_sv") = dv.Item(r)("Ma_sv").ToString
        '                dt.Rows(i).Item("Ho_ten") = dv.Item(r)("Ho_ten").ToString
        '                dt.Rows(i).Item("Ngay_sinh") = dv.Item(r)("Ngay_sinh").ToString.Trim
        '                dt.Rows(i).Item("Ten_he") = dv.Item(r)("Ten_he").ToString
        '                dt.Rows(i).Item("Ten_khoa") = dv.Item(r)("Ten_khoa").ToString
        '                dt.Rows(i).Item("Khoa_hoc") = dv.Item(r)("Khoa_hoc").ToString
        '                dt.Rows(i).Item("Ten_nganh") = dv.Item(r)("Ten_nganh").ToString
        '                dt.Rows(i).Item("Chuyen_nganh") = dv.Item(r)("Chuyen_nganh").ToString
        '                dt.Rows(i).Item("Ten_tinh") = dv.Item(r)("Ten_tinh").ToString
        '                dt.Rows(i).Item("Ten_lop") = dv.Item(r)("Ten_lop").ToString
        '                dt.Rows(i).Item("Nien_khoa") = dv.Item(r)("Nien_khoa").ToString

        '                dt.Rows(i).Item("TBCHT") = dv.Item(r)("TBCHT").ToString
        '                dt.Rows(i).Item("XEP_LOAI") = dv.Item(r)("XEP_hang").ToString
        '                dt.Rows(i).Item("TBC_RL") = TongDiemRL
        '                dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
        '            Next
        '            Dim dvMain As DataView = dt.DefaultView
        '            Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
        '            Dim f As New rpt_BangDiemTotNghiep_Full(tieu_de, dt)
        '            f.SetupDatasource(dvMain)
        '            Hide_PrintXtraReport(f)
        '            f.Print()
        '        End If
        '    Next
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnInBang_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInBang_TN.ItemClick
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        dv.RowFilter = "Chon='True'"
        If dv.Count = 0 Then Exit Sub
        'Dim rpt As New rptBangTotNghiep_All(dv)
        'PrintXtraReport(rpt)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim cls As New DanhMuc_BLL

        Dim dv As DataView = grvTotNghiep.DataSource
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                cls.Execute("Update Mark_DanhSachTotNghiep Set Lan_thu=1 WHERE ID_SV=" & dv.Item(i)("ID_SV"))
            End If
        Next
        TrvLop_ChuanHoa1_Select()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim cls As New DanhMuc_BLL

        Dim dv As DataView = grvTotNghiep.DataSource
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                cls.Execute("Update Mark_DanhSachTotNghiep Set Lan_thu=2 WHERE ID_SV=" & dv.Item(i)("ID_SV"))
            End If
        Next
        TrvLop_ChuanHoa1_Select()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        dv.RowFilter = "Chon='True'"
        If dv.Count = 0 Then Exit Sub
        'Dim rpt As New rptBangTotNghiep_VIEW(dv)
        'PrintXtraReport(rpt)
    End Sub

    Private Sub btnLap_so_vb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLap_so_SoHieu.Click
        Try
            If txtDo_dai_So_hieu.Text = "" Or (txtDo_dai_So_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_hieu.Text.Trim)) Or txtTienTo_SoHieu.Text.Trim = "" Or txtTu_so_so_hieu.Text = "" Or (txtTu_so_so_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_so_so_hieu.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số hiệu bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_so_so_hieu.Text
            Dim Do_dai As Integer = txtDo_dai_So_hieu.Text.Trim
            Dim dv As DataView = grvTotNghiep.DataSource
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_BLL
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_hieu") = txtTienTo_SoHieu.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    clsDSXetTN.CapNhat_SoHieu(dr("So_hieu"), dr("ID_SV"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_SoVaoSo.Click
        Try
            If txtDo_dai_So_van_bang.Text = "" Or (txtDo_dai_So_van_bang.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_van_bang.Text.Trim)) Or txtTien_to_SoVaoSo.Text.Trim = "" Or txtTu_So_SoVaoSo.Text = "" Or (txtTu_So_SoVaoSo.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_So_SoVaoSo.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số vào sổ bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_So_SoVaoSo.Text
            Dim dv As DataView = grvTotNghiep.DataSource
            Dim Do_dai As Integer = txtDo_dai_So_van_bang.Text.Trim
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_BLL
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_vao_so") = txtTien_to_SoVaoSo.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    clsDSXetTN.CapNhat_SoVaoSo(dr("So_vao_so"), dr("ID_SV"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            If grcTotNghiep.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grcTotNghiep.DataSource
            Dim tieu_de As String = "DANH SÁCH CẤP PHÁT BẰNG"
            'Dim rpt As New rptDanhSachPhatBangTN(dv, tieu_de)
            'PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Dim dv As DataView = grvTotNghiep.DataSource
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    clsDSXetTN.CapNhat_KHoa(dr("ID_SV"), dr("Lock"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdTongHop_XetTN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTongHop_XetTN.ItemClick
        'clsDSXetTN = New DanhSachTotNghiep_BLL
        'Dim dv As DataView = clsDSXetTN.Mark_TotNghiep_ThongKe.DefaultView

        'Dim rpt As New rptMark_ThongKe_TotNghiep(dv)
        'PrintXtraReport(rpt)
    End Sub

    Private Sub cmdLapSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLapSB.Click

    End Sub

    Private Sub btnChung_nhan_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChung_nhan_TN.ItemClick
        Try
            GetReportHeader()
            If grcTotNghiep.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grcTotNghiep.DataSource
            dv.RowFilter = "Chon=True"
            If dv.Count > 0 Then
                Dim cls As New rptDiem_ToanKhoa_SV_BLL
                Dim ID_dt As Integer = TrvLop_ChuanHoa1.ID_dt_list
                Dim Mon_CT, Mon_TH, Mon_LT As Double
                Dim dt As DataTable = dv.ToTable
                dt.Columns.Add("Chinh_tri", GetType(Double))
                dt.Columns.Add("Ly_thuyet", GetType(Double))
                dt.Columns.Add("Thuc_hanh", GetType(Double))
                Dim dtDTCT As DataTable = UDB.SelectTable("SELECT ID_mon, Mon_tot_nghiep, Thuc_hanh_nghe, Ly_thuyet_nghe, Kien_thuc FROM Plan_ChuongTrinhDaoTaoChiTiet WHERE ID_dt = " & ID_dt & " AND Mon_tot_nghiep = 'True'")
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dtDTCT.Rows.Count > 0 Then
                        For j As Integer = 0 To dtDTCT.Rows.Count - 1
                            If CType(dtDTCT.Rows(j)("Thuc_hanh_nghe"), Boolean) = True Then
                                Mon_TH = cls.Diem_ChungNhan(dt.Rows(i)("ID_sv"), dtDTCT.Rows(j)("ID_mon"))
                                dt.Rows(i)("Thuc_hanh") = Mon_TH
                            ElseIf CType(dtDTCT.Rows(j)("Ly_thuyet_nghe"), Boolean) = True Then
                                Mon_LT = cls.Diem_ChungNhan(dt.Rows(i)("ID_sv"), dtDTCT.Rows(j)("ID_mon"))
                                dt.Rows(i)("Ly_thuyet") = Mon_LT
                            ElseIf dtDTCT.Rows(j)("Kien_thuc") = 11 Then
                                Mon_CT = cls.Diem_ChungNhan(dt.Rows(i)("ID_sv"), dtDTCT.Rows(j)("ID_mon"))
                                dt.Rows(i)("Chinh_tri") = Mon_CT
                            End If
                        Next
                    End If
                Next
                Dim Ngay_qd As Date = CType(dv.Item(0)("Ngay_qd"), Date)
                Dim Ten_he As String = "Đã được công nhận tốt nghiệp trình độ " & dv.Item(0)("Ten_he").ToString & ", hệ Chính Quy"
                Dim So_QD As String = "Theo quyết định số " & dv.Item(0)("So_qd") & " ngày " & Ngay_qd.ToShortDateString & " của Trường"
                Dim rpt As New rptChungNhanTN_VietHan(dt.DefaultView, Ten_he, So_QD, TrvLop_ChuanHoa1.ID_he)
                PrintXtraReport(rpt)
            Else
                Thongbao("Bạn chưa chọn sinh viên nào")
            End If
            dv.RowFilter = "1=1"
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDS_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDS_TN.ItemClick
        Try
            If grvTotNghiep.DataSource Is Nothing Then
                Thongbao("Dữ liệu trống", MsgBoxStyle.Information, "Thông báo")
            ElseIf TrvLop_ChuanHoa1.ID_lop_list < 0 Then
                Thongbao("Bạn hãy chọn lớp cần In danh sách", MsgBoxStyle.Information, "Thông báo")
            ElseIf cmbLan_thu.Text = "" Then
                Thongbao("Bạn hãy chọn Lần xét TN", MsgBoxStyle.Information, "Thông báo")
            Else
                Dim dv As DataView = grvTotNghiep.DataSource
                Dim bao_cao_tieu_de1, bao_cao_tieu_de2 As String
                bao_cao_tieu_de1 = "DANH SÁCH SINH VIÊN ĐẠT KẾT QUẢ THI TỐT NGHIỆP " & dv.Item(0)("Ten_he").ToString.ToUpper
                bao_cao_tieu_de2 = "NGHỀ: " & dv.Item(0)("Chuyen_nganh").ToString.ToUpper & ", KHÓA: " & dv.Item(0)("Khoa_hoc").ToString.ToUpper & ", NIÊN KHÓA: " & dv.Item(0)("Nien_khoa").ToString.ToUpper
                dv.Sort = "Van_dau,Ten,Ho_dem"
                Dim rpt As New rptDanhSachTotNghiep(dv, bao_cao_tieu_de1, bao_cao_tieu_de2)
                rpt.DataSource = dv
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            'Thongbao(ex.Message)
        End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDS_chua_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDS_chua_TN.ItemClick
        Try
            If grvNoTotNghiep.DataSource Is Nothing Then
                Thongbao("Dữ liệu trống", MsgBoxStyle.Information, "Thông báo")
            ElseIf TrvLop_ChuanHoa2.ID_lop_list < 0 Then
                Thongbao("Bạn hãy chọn lớp cần In danh sách", MsgBoxStyle.Information, "Thông báo")
            ElseIf cmbLan_thu.Text = "" Then
                Thongbao("Bạn hãy chọn Lần xét TN", MsgBoxStyle.Information, "Thông báo")
            Else
                Dim dv As DataView = grvNoTotNghiep.DataSource
                Dim bao_cao_tieu_de1, bao_cao_tieu_de2 As String
                bao_cao_tieu_de1 = "DANH SÁCH SINH VIÊN KHÔNG ĐẠT KẾT QUẢ THI TỐT NGHIỆP " & dv.Item(0)("Ten_he1").ToString.ToUpper
                bao_cao_tieu_de2 = "NGHỀ: " & dv.Item(0)("Chuyen_nganh1").ToString.ToUpper & ", KHÓA: " & dv.Item(0)("Khoa_hoc1").ToString.ToUpper & ", NIÊN KHÓA: " & dv.Item(0)("Nien_khoa1").ToString.ToUpper
                Dim dt As DataTable = dv.Table.Copy
                Dim rpt As New rptDanhSachChuaTotNghiep(dt, bao_cao_tieu_de1, bao_cao_tieu_de2)
                rpt.DataSource = dt.DefaultView
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            'Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnBang_diem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBang_diem.ItemClick
        Try
            Dim dvSinhVien As DataView = grvTotNghiep.DataSource
            Dim row As DataRow = grvNoTotNghiep.GetFocusedDataRow()


            Dim obj_BLL As DiemRenLuyen_BLL
            obj_BLL = New DiemRenLuyen_BLL(TrvLop_ChuanHoa1.ID_lop_list)
            Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenKhoa
            Dim TongDiemRL As Integer = 0
            Dim XepLoai_RL As String = ""

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Id_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Ngay_QD_chu", GetType(String))
            dt.Columns.Add("Diem_toan_khoa", GetType(Double))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("Ten_tinh", GetType(String))
            dt.Columns.Add("Ghi_chu", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Trinh_do", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("TBC_RL", GetType(Double))
            dt.Columns.Add("Xep_loai_RL", GetType(String))
            'dt.Columns.Add("Ten_he_view", GetType(String))
            For i As Integer = 0 To dvSinhVien.Count - 1
                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dvSinhVien.Item(i)("Id_sv") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Chon") = dvSinhVien.Item(i)("Chon")
                dr("ID_sv") = dvSinhVien.Item(i)("ID_sv").ToString
                dr("Ma_sv") = dvSinhVien.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dvSinhVien.Item(i)("Ho_ten").ToString
                If dvSinhVien.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                dr("Gioi_tinh") = dvSinhVien.Item(i)("Gioi_tinh").ToString
                dr("TBCHT") = dvSinhVien.Item(i)("TBCHT")
                dr("Diem_toan_khoa") = dvSinhVien.Item(i)("Diem_toan_khoa")
                dr("Xep_hang") = dvSinhVien.Item(i)("Xep_hang")
                If dvSinhVien.Item(i)("So_QD").ToString <> "" Then dr("So_QD") = dvSinhVien.Item(i)("So_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then dr("Ngay_QD") = dvSinhVien.Item(i)("Ngay_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then
                    Dim Ngay_QD As Date = dvSinhVien.Item(i)("Ngay_QD")
                    dr("Ngay_QD_chu") = dvSinhVien.Item(i)("So_QD").ToString & "/CĐN KTCN Ngày " & Ngay_QD.Day & " tháng " & Ngay_QD.Month & " năm " & Ngay_QD.Year
                Else
                    dr("Ngay_QD_chu") = "Ngày .... tháng ...... năm ....... "
                End If
                dr("Ten_tinh") = dvSinhVien.Item(i)("Ten_tinh").ToString
                dr("Ghi_chu") = dvSinhVien.Item(i)("Ghi_chu").ToString
                dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                dr("Trinh_do") = dvSinhVien.Item(i)("Trinh_do").ToString
                dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                dr("TBC_RL") = TongDiemRL
                dr("Xep_loai_RL") = XepLoai_RL
                dt.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "Chon = 'True'"
            Dim dict As Dictionary(Of String, DataView) = New Dictionary(Of String, DataView)
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            For Each drv As DataRowView In dt.DefaultView
                Dim dv As DataView = obj.Load_BangDiemToanKhoa_SV(drv("ID_sv")).DefaultView
                dict.Add(drv("ID_sv"), dv)
            Next
            Dim tieu_de As String = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP"
            Dim rpt As New rptBangDiemTotNghiep_NNT(dt.DefaultView, dict, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub ckNo_TN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckNo_TN.CheckedChanged
        If grvNoTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvNoTotNghiep.DataSource
        For Each dr As DataRowView In dv
            dr("Chon1") = ckNo_TN.Checked
        Next
    End Sub

    Private Sub btnBang_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBang_TN.ItemClick
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        dv.RowFilter = "Chon='True'"
        If dv.Count = 0 Then Exit Sub
        Dim rpt As New rptBangTotNghiep_CNC(dv)
        PrintXtraReport(rpt)
    End Sub


    Private Sub btnBangDiem_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBangDiem_TN.ItemClick
        No = True
        GetReportHeader()
        Me.Cursor = Cursors.WaitCursor
        Try
            If cmbNam_hoc.Text.Trim <> "" And cmbLan_thu.Text.Trim <> "" Then
                If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If

                Dim ID_dv As String = gobjUser.ID_dv
                Dim ID_he As Integer = TrvLop_ChuanHoa1.ID_he

                Dim Tieu_de1, Tieu_de2 As String
                Dim dtMonHoc As DataTable
                Dim khoa_hoc As String = "KHÓA: " & TrvLop_ChuanHoa1.Khoa_hoc & ", "

                Dim dvSV_dat As DataView = grvTotNghiep.DataSource
                Dim dtSV_dat As DataTable = dvSV_dat.ToTable

                If dtSV_dat.Rows.Count > 0 Then
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, dtSV_dat)
                    Dim dt As DataTable = clsDiem.TongHopMonThiTotNghiep(False, 2, False)
                    If cmbLan_thu.Text = 1 Then
                        Tieu_de1 = "DANH SÁCH SINH VIÊN ĐẠT KẾT QUẢ THI TỐT NGHIỆP " & dvSV_dat.Item(0)("Ten_he").ToString.ToUpper
                    Else
                        Tieu_de1 = "DANH SÁCH SINH VIÊN ĐẠT KẾT QUẢ THI TỐT NGHIỆP LẦN 2 " & dvSV_dat.Item(0)("Ten_he").ToString.ToUpper
                    End If
                    Tieu_de2 = "NGHỀ: " & dvSV_dat.Item(0)("Chuyen_nganh").ToString.ToUpper & ", KHÓA: " & dvSV_dat.Item(0)("Khoa_hoc").ToString.ToUpper & ", NIÊN KHÓA: " & dvSV_dat.Item(0)("Nien_khoa").ToString.ToUpper
                    dtMonHoc = clsDiem.DanhSachMonTotNghiep
                    If dt.Rows.Count > 0 Then
                        Dim rpt As New rptDanhSach_Dat_TotNghiep(dt, dtMonHoc, Tieu_de1, Tieu_de2, True, No)
                        rpt.DataSource = dt
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
                        Exit Sub
                    End If
                Else
                    Thongbao("Chưa có sinh viên nào để In!")
                    Exit Sub
                End If
            Else
                Thongbao("Bạn phải chọn Năm học và Lần xét tốt nghiệp !", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnBangDiem_TN_ChuaDat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBangDiem_TN_ChuaDat.ItemClick
        GetReportHeader()
        Me.Cursor = Cursors.WaitCursor
        Try
            No = False
            If cmbNam_hoc_CTN.Text.Trim <> "" Then
                If TrvLop_ChuanHoa2.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If

                Dim ID_dv As String = gobjUser.ID_dv
                Dim ID_he As Integer = TrvLop_ChuanHoa2.ID_he

                Dim Tieu_de1, Tieu_de2 As String
                Dim dtMonHoc As DataTable
                Dim khoa_hoc As String = "KHÓA: " & TrvLop_ChuanHoa2.Khoa_hoc & ", "

                Dim dvSV_dat As DataView = grcNoTotNghiep.DataSource
                Dim dtSV_dat As DataTable = dvSV_dat.Table

                If dtSV_dat.Rows.Count > 0 Then
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_ChuaTN, mID_dt, dtSV_dat)
                    Dim dt As DataTable = clsDiem.TongHopMonThiTotNghiep(False, 2, False)
                    Tieu_de1 = "DANH SÁCH SINH VIÊN KHÔNG ĐẠT KẾT QUẢ THI TỐT NGHIỆP " & dvSV_dat.Item(0)("Ten_he").ToString.ToUpper
                    Tieu_de2 = "NGHỀ: " & dvSV_dat.Item(0)("Chuyen_nganh1").ToString.ToUpper & ", KHÓA: " & dvSV_dat.Item(0)("Khoa_hoc1").ToString.ToUpper & ", NIÊN KHÓA: " & dvSV_dat.Item(0)("Nien_khoa1").ToString.ToUpper
                    dtMonHoc = clsDiem.DanhSachMonTotNghiep
                    If dt.Rows.Count > 0 Then
                        Dim rpt As New rptDanhSach_Dat_TotNghiep(dt, dtMonHoc, Tieu_de1, Tieu_de2, True, No)
                        rpt.DataSource = dt
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
                        Exit Sub
                    End If
                Else
                    Thongbao("Chưa có sinh viên nào để In!")
                    Exit Sub
                End If
            Else
                Thongbao("Bạn phải chọn Năm học và Lần xét tốt nghiệp !", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BangDiem_Dat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BangDiem_Dat.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If cmbNam_hoc.Text.Trim <> "" And cmbLan_thu.Text.Trim <> "" Then
                If TrvLop_ChuanHoa1.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If

                Dim ID_dv As String = gobjUser.ID_dv
                Dim ID_he As Integer = TrvLop_ChuanHoa1.ID_he
                Dim mID_chuyen_nganh As Integer = TrvLop_ChuanHoa1.ID_chuyen_nganh
                Dim dtNghe As DataTable = UDB.SelectTable("Select Chuyen_nganh from stu_chuyennganh where id_chuyen_nganh = " & mID_chuyen_nganh)
                Dim Tieu_de1, Tieu_de2 As String
                Dim dtMonHoc As DataTable
                Dim khoa_hoc As String = "KHÓA: " & TrvLop_ChuanHoa1.Khoa_hoc & ", "

                Dim obj As DanhSachTotNghiep_BLL = New DanhSachTotNghiep_BLL
                Dim dtSV_dat As DataTable = obj.BangDiem_ThiTotNghiep_SV(dsID_lop_TN, cmbNam_hoc.Text)
                If dtSV_dat.Rows.Count > 0 Then
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop_TN, mID_dt, dtSV_dat)
                    Dim dt As DataTable = clsDiem.TongHopMonThiTotNghiep(False, 2, False)
                    Tieu_de1 = "KẾT QUẢ THI TỐT NGHIỆP CAO ĐẲNG NGHỀ, KHÓA 1, NIÊN KHÓA 2010-2013 "
                    Tieu_de2 = "NGHỀ: " & dtNghe.Rows(0)("Chuyen_nganh").ToString
                    dtMonHoc = clsDiem.DanhSachMonTotNghiep
                    If dt.Rows.Count > 0 Then
                        Dim rpt As New rptDanhSach_Dat_TotNghiep_BangDIem(dt, dtMonHoc, Tieu_de1, Tieu_de2)
                        rpt.DataSource = dt
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
                        Exit Sub
                    End If
                Else
                    Thongbao("Chưa có sinh viên nào để In!")
                    Exit Sub
                End If
            Else
                Thongbao("Bạn phải chọn Năm học và Lần xét tốt nghiệp !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnThong_ke_XL_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThong_ke_XL.ItemClick
        Dim obj As New DanhSachTotNghiep_BLL
        Dim dv As DataView = obj.ThongKeTotNghiep.DefaultView
        Dim rpt As New rpt_BaoCaoTongKet_KetQuaThiTN(dv)
        PrintXtraReport(rpt)
    End Sub

    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        Dim rpt As New rptInChungChi
        PrintXtraReport(rpt)
    End Sub

    Private Sub btnDS_cap_bang_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDS_cap_bang_TN.ItemClick
        Try
            If grvTotNghiep.DataSource Is Nothing Then
                Thongbao("Dữ liệu trống", MsgBoxStyle.Information, "Thông báo")
            ElseIf TrvLop_ChuanHoa1.ID_lop_list < 0 Then
                Thongbao("Bạn hãy chọn lớp cần In danh sách", MsgBoxStyle.Information, "Thông báo")
            ElseIf cmbLan_thu.Text = "" Then
                Thongbao("Bạn hãy chọn Lần xét TN", MsgBoxStyle.Information, "Thông báo")
            Else
                Dim dv As DataView = grvTotNghiep.DataSource
                Dim bao_cao_tieu_de1, bao_cao_tieu_de2 As String
                bao_cao_tieu_de1 = "DANH SÁCH SINH VIÊN ĐƯỢC CẤP BẰNG TỐT NGHIỆP " & dv.Item(0)("Ten_he").ToString.ToUpper
                bao_cao_tieu_de2 = "NGHỀ: " & dv.Item(0)("Chuyen_nganh").ToString.ToUpper & ", KHÓA: " & dv.Item(0)("Khoa_hoc").ToString.ToUpper & ", NIÊN KHÓA: " & dv.Item(0)("Nien_khoa").ToString.ToUpper
                dv.Sort = "Van_dau,Ten,Ho_dem"
                Dim rpt As New rptDanhSachCapBangTotNghiep(dv, bao_cao_tieu_de1, bao_cao_tieu_de2)
                rpt.DataSource = dv
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            'Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Bang_diem_TN_Mau2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Bang_diem_TN_Mau2.ItemClick
        Try
            Dim dvSinhVien As DataView = grvTotNghiep.DataSource
            Dim row As DataRow = grvNoTotNghiep.GetFocusedDataRow()


            Dim obj_BLL As DiemRenLuyen_BLL
            obj_BLL = New DiemRenLuyen_BLL(TrvLop_ChuanHoa1.ID_lop_list)
            Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenKhoa
            Dim TongDiemRL As Integer = 0
            Dim XepLoai_RL As String = ""

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Id_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Ngay_QD_chu", GetType(String))
            dt.Columns.Add("Diem_toan_khoa", GetType(Double))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("Ten_tinh", GetType(String))
            dt.Columns.Add("Ghi_chu", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Trinh_do", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("TBC_RL", GetType(Double))
            dt.Columns.Add("Xep_loai_RL", GetType(String))
            'dt.Columns.Add("Ten_he_view", GetType(String))
            For i As Integer = 0 To dvSinhVien.Count - 1
                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dvSinhVien.Item(i)("Id_sv") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Chon") = dvSinhVien.Item(i)("Chon")
                dr("ID_sv") = dvSinhVien.Item(i)("ID_sv").ToString
                dr("Ma_sv") = dvSinhVien.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dvSinhVien.Item(i)("Ho_ten").ToString
                If dvSinhVien.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                dr("Gioi_tinh") = dvSinhVien.Item(i)("Gioi_tinh").ToString
                dr("TBCHT") = dvSinhVien.Item(i)("TBCHT")
                dr("Diem_toan_khoa") = dvSinhVien.Item(i)("Diem_toan_khoa")
                dr("Xep_hang") = dvSinhVien.Item(i)("Xep_hang")
                If dvSinhVien.Item(i)("So_QD").ToString <> "" Then dr("So_QD") = dvSinhVien.Item(i)("So_QD") & "/QĐ-CĐN"
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then dr("Ngay_QD") = dvSinhVien.Item(i)("Ngay_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then
                    Dim Ngay_QD As Date = dvSinhVien.Item(i)("Ngay_QD")
                    dr("Ngay_QD_chu") = "Ngày " & Ngay_QD.Day & " tháng " & Ngay_QD.Month & " năm " & Ngay_QD.Year & " của Hiệu trưởng trường Cao đẳng nghề Nha Trang"
                Else
                    dr("Ngay_QD_chu") = "Ngày .... tháng ...... năm ....... của Hiệu trưởng trường Cao đẳng nghề Nha Trang"
                End If
                dr("Ten_tinh") = dvSinhVien.Item(i)("Ten_tinh").ToString
                dr("Ghi_chu") = dvSinhVien.Item(i)("Ghi_chu").ToString
                dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                dr("Trinh_do") = dvSinhVien.Item(i)("Trinh_do").ToString
                dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                dr("TBC_RL") = TongDiemRL
                dr("Xep_loai_RL") = XepLoai_RL
                dt.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "Chon = 'True'"
            Dim dict As Dictionary(Of String, DataView) = New Dictionary(Of String, DataView)
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            For Each drv As DataRowView In dt.DefaultView
                Dim dv As DataView = obj.Load_BangDiemToanKhoa_SV(drv("ID_sv")).DefaultView
                dict.Add(drv("ID_sv"), dv)
            Next
            Dim tieu_de As String = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP"
            Dim rpt As New rptBangDiemTotNghiep_NNT_Mau2(dt.DefaultView, dict, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        Try
            Dim dvSinhVien As DataView = grvTotNghiep.DataSource
            Dim row As DataRow = grvNoTotNghiep.GetFocusedDataRow()


            Dim obj_BLL As DiemRenLuyen_BLL
            obj_BLL = New DiemRenLuyen_BLL(TrvLop_ChuanHoa1.ID_lop_list)
            Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenKhoa
            Dim TongDiemRL As Integer = 0
            Dim XepLoai_RL As String = ""

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Id_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Ngay_QD_chu", GetType(String))
            dt.Columns.Add("Diem_toan_khoa", GetType(Double))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("Ten_tinh", GetType(String))
            dt.Columns.Add("Ghi_chu", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Trinh_do", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("TBC_RL", GetType(Double))
            dt.Columns.Add("Xep_loai_RL", GetType(String))
            'dt.Columns.Add("Ten_he_view", GetType(String))
            For i As Integer = 0 To dvSinhVien.Count - 1
                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dvSinhVien.Item(i)("Id_sv") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Chon") = dvSinhVien.Item(i)("Chon")
                dr("ID_sv") = dvSinhVien.Item(i)("ID_sv").ToString
                dr("Ma_sv") = dvSinhVien.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dvSinhVien.Item(i)("Ho_ten").ToString
                If dvSinhVien.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                dr("Gioi_tinh") = dvSinhVien.Item(i)("Gioi_tinh").ToString
                dr("TBCHT") = dvSinhVien.Item(i)("TBCHT")
                dr("Diem_toan_khoa") = dvSinhVien.Item(i)("Diem_toan_khoa")
                dr("Xep_hang") = dvSinhVien.Item(i)("Xep_hang")
                If dvSinhVien.Item(i)("So_QD").ToString <> "" Then dr("So_QD") = dvSinhVien.Item(i)("So_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then dr("Ngay_QD") = dvSinhVien.Item(i)("Ngay_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then
                    Dim Ngay_QD As Date = dvSinhVien.Item(i)("Ngay_QD")
                    dr("Ngay_QD_chu") = dvSinhVien.Item(i)("So_QD").ToString & "/CĐN KTCN Ngày " & Ngay_QD.Day & " tháng " & Ngay_QD.Month & " năm " & Ngay_QD.Year
                Else
                    dr("Ngay_QD_chu") = "Ngày .... tháng ...... năm ....... "
                End If
                dr("Ten_tinh") = dvSinhVien.Item(i)("Ten_tinh").ToString
                dr("Ghi_chu") = dvSinhVien.Item(i)("Ghi_chu").ToString
                dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                dr("Trinh_do") = dvSinhVien.Item(i)("Trinh_do").ToString
                dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                dr("TBC_RL") = TongDiemRL
                dr("Xep_loai_RL") = XepLoai_RL
                dt.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "Chon = 'True'"
            Dim dict As Dictionary(Of String, DataView) = New Dictionary(Of String, DataView)
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            For Each drv As DataRowView In dt.DefaultView
                Dim dv As DataView = obj.Load_BangDiemToanKhoa_SV(drv("ID_sv")).DefaultView
                dict.Add(drv("ID_sv"), dv)
            Next
            Dim tieu_de As String = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP"
            Dim rpt As New rptBangDiemTotNghiep_Mau2(dt.DefaultView, dict, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        Try
            Dim dvSinhVien As DataView = grvTotNghiep.DataSource
            Dim row As DataRow = grvNoTotNghiep.GetFocusedDataRow()


            Dim obj_BLL As DiemRenLuyen_BLL
            obj_BLL = New DiemRenLuyen_BLL()
            Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenKhoa
            Dim TongDiemRL As Integer = 0
            Dim XepLoai_RL As String = ""

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Id_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Ngay_QD_chu", GetType(String))
            dt.Columns.Add("Diem_toan_khoa", GetType(Double))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("Ten_tinh", GetType(String))
            dt.Columns.Add("Ghi_chu", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Trinh_do", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("TBC_RL", GetType(Double))
            dt.Columns.Add("Xep_loai_RL", GetType(String))
            'dt.Columns.Add("Ten_he_view", GetType(String))
            For i As Integer = 0 To dvSinhVien.Count - 1
                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dvSinhVien.Item(i)("Id_sv") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Chon") = dvSinhVien.Item(i)("Chon")
                dr("ID_sv") = dvSinhVien.Item(i)("ID_sv").ToString
                dr("Ma_sv") = dvSinhVien.Item(i)("Ma_sv").ToString
                dr("Ho_ten") = dvSinhVien.Item(i)("Ho_ten").ToString
                If dvSinhVien.Item(i)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh")
                dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                dr("Gioi_tinh") = dvSinhVien.Item(i)("Gioi_tinh").ToString
                dr("TBCHT") = dvSinhVien.Item(i)("TBCHT")
                dr("Diem_toan_khoa") = dvSinhVien.Item(i)("Diem_toan_khoa")
                dr("Xep_hang") = dvSinhVien.Item(i)("Xep_hang")
                If dvSinhVien.Item(i)("So_QD").ToString <> "" Then dr("So_QD") = dvSinhVien.Item(i)("So_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then dr("Ngay_QD") = dvSinhVien.Item(i)("Ngay_QD")
                If dvSinhVien.Item(i)("Ngay_QD").ToString <> "" Then
                    Dim Ngay_QD As Date = dvSinhVien.Item(i)("Ngay_QD")
                    dr("Ngay_QD_chu") = dvSinhVien.Item(i)("So_QD").ToString & "/CĐN KTCN Ngày " & Ngay_QD.Day & " tháng " & Ngay_QD.Month & " năm " & Ngay_QD.Year
                Else
                    dr("Ngay_QD_chu") = "Ngày .... tháng ...... năm ....... "
                End If
                dr("Ten_tinh") = dvSinhVien.Item(i)("Ten_tinh").ToString
                dr("Ghi_chu") = dvSinhVien.Item(i)("Ghi_chu").ToString
                dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                dr("Trinh_do") = dvSinhVien.Item(i)("Trinh_do").ToString
                dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                dr("TBC_RL") = TongDiemRL
                dr("Xep_loai_RL") = XepLoai_RL
                dt.Rows.Add(dr)
            Next
            dt.DefaultView.RowFilter = "Chon = 'True'"
            Dim dict As Dictionary(Of String, DataView) = New Dictionary(Of String, DataView)
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            For Each drv As DataRowView In dt.DefaultView
                Dim dv As DataView = obj.Load_BangDiemToanKhoa_SV(drv("ID_sv")).DefaultView
                dict.Add(drv("ID_sv"), dv)
            Next
            Dim tieu_de As String = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP"
            Dim rpt As New rptBangDiemTotNghiep_VanHoa(dt.DefaultView, dict, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnBang_diem_hoc_tap_nhom_ky_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBang_diem_hoc_tap_nhom_ky.ItemClick
        Try
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            Dim objRL As New DiemRenLuyen_BLL(TrvLop_ChuanHoa1.ID_lop_list)
            Dim cls As New Diem_BLL
            Dim row As DataRow = grvTotNghiep.GetDataRow(grvTotNghiep.GetSelectedRows.GetValue(0))
            Dim ID_sv As Integer = row("ID_sv")
            Dim dt As DataTable = obj.Load_BangDiemToanKhoa_SV(ID_sv)
            dt.Columns.Add("TBC_ky")
            dt.Columns.Add("Xep_hang_ky")
            dt.Columns.Add("Xep_hang_rl")
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dvRL As DataView = objRL.TongHop_DiemRenLuyenKy(dt.Rows(i)("Hoc_ky"), dt.Rows(i)("Nam_hoc")).DefaultView
                dvRL.RowFilter = "ID_sv = " & ID_sv
                If dvRL.Count > 0 Then
                    dt.Rows(i)("Xep_hang_rl") = dvRL.Item(0)("Xep_loai")
                Else
                    dt.Rows(i)("Xep_hang_rl") = ""
                End If
                dvRL.RowFilter = "1=1"
                Dim dt_diem As DataTable = cls.dt_DanhSachDiemTheoSinhVien(ID_sv, dt.Rows(i)("Hoc_ky"), dt.Rows(i)("Nam_hoc"))
                Dim TBCHP As Double = 0
                TBCHP = dt_diem.Rows(0)("Tong_Diem") / dt_diem.Rows(0)("So_hoc_trinh")
                dt.Rows(i)("TBC_ky") = Math.Round(TBCHP, 1)
                If TBCHP >= 9 Then 'XS;
                    dt.Rows(i)("Xep_hang_ky") = "Xuất sắc"
                ElseIf TBCHP < 9 And TBCHP >= 8 Then 'Gioi
                    dt.Rows(i)("Xep_hang_ky") = "Giỏi"
                ElseIf TBCHP < 8 And TBCHP >= 7 Then 'Kha
                    dt.Rows(i)("Xep_hang_ky") = "Khá"
                ElseIf TBCHP < 7 And TBCHP >= 6 Then 'TB kha
                    dt.Rows(i)("Xep_hang_ky") = "TB Khá"
                ElseIf TBCHP < 6 And TBCHP >= 5 Then 'TB 
                    dt.Rows(i)("Xep_hang_ky") = "Trung bình"
                ElseIf TBCHP < 5 And TBCHP >= 4 Then 'Yeu
                    dt.Rows(i)("Xep_hang_ky") = "Yếu"
                Else 'Kem
                    dt.Rows(i)("Xep_hang_ky") = "Kém"
                End If
            Next
            'Dim rpt As New rptBangDiemSinhVien_NhomHocKy(dt.DefaultView)
            'PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class