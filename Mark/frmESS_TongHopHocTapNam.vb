Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Imports ESS_Reports

Public Class frmESS_TongHopHocTapNam
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_BLL

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub FormatFlexGrid(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Cols.Fixed = 1
        fg.Rows.Fixed = 2
        fg.Rows.DefaultSize = 20

        fg.Rows(0).Height = 60
        fg.Cols(0).Width = 20

        Format_fix_region(fg)
        Allow_merge(fg)
        'Ẩn tất cả các cột
        Dim dt As DataTable = fg.DataSource
        For i As Integer = 0 To dt.Columns.Count - 1
            fg.Cols(dt.Columns(i).ColumnName.ToString).Visible = False
        Next
        'Các cột hiển thị cố định
        fg.Cols("Ma_sv").Visible = True
        fg.Cols("Ma_sv").Caption = "Mã sinh viên"
        fg.Cols("Ma_sv").Width = 80
        fg.Cols("Ma_sv").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ho_ten").Visible = True
        fg.Cols("Ho_ten").Caption = "Họ và tên"
        fg.Cols("Ho_ten").Width = 160

        fg.Cols("Ten_lop").Visible = True
        fg.Cols("Ten_lop").Caption = "Tên lớp"
        fg.Cols("Ten_lop").TextAlign = TextAlignEnum.CenterCenter
        fg.Cols("Ten_lop").Width = 70

        fg.Cols("TBC_RL").Visible = True
        fg.Cols("TBC_RL").Caption = "Điểm RL"
        fg.Cols("TBC_RL").Width = 55
        fg.Cols("TBC_RL").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai_RL").Visible = True
        fg.Cols("Xep_loai_RL").Caption = "XL RL"
        fg.Cols("Xep_loai_RL").Width = 70

        'Format các cột môn học biến động theo số môn
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                'Hiển thị cột điểm
                fg.Cols("M" + .ID_mon.ToString).Visible = True
                'Gán tiêu đề cột điểm
                If optKyHieu.Checked Then
                    fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                Else
                    fg(0, "M" + .ID_mon.ToString) = .Ten_mon
                End If
                'Không cho Merging số học trình
                fg(1, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString + Encode(i)
                fg.Cols("M" + .ID_mon.ToString).Width = 60
                fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
            End With
        Next
        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHT"
        fg.Cols("TBCHT").Width = 55
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter


        fg.Cols("Xep_loai").Visible = True
        fg.Cols("Xep_loai").Caption = "Xếp loại"
        fg.Cols("Xep_loai").Width = 70

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Caption = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        'fg.Cols("Ly_do").Visible = True
        'fg.Cols("Ly_do").Caption = "Ghi chú"
        'fg.Cols("Ly_do").Width = 80
        'fg.Cols("Ly_do").TextAlign = TextAlignEnum.LeftCenter

        Set_Style(fg)
    End Sub
    Private Sub FormatFlexGrid_MainSub(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Cols.Fixed = 1
        fg.Rows.Fixed = 3
        fg.Rows.DefaultSize = 20

        fg.Rows(0).Height = 20
        fg.Cols(0).Width = 20

        Format_fix_region(fg)
        Allow_merge(fg)
        'Ẩn tất cả các cột
        Dim dt As DataTable = fg.DataSource
        For i As Integer = 0 To dt.Columns.Count - 1
            fg.Cols(dt.Columns(i).ColumnName.ToString).Visible = False
        Next
        'Các cột hiển thị cố định
        fg.Cols("Ma_sv").Visible = True
        fg(0, "Ma_sv") = "Mã sinh viên"
        fg(1, "Ma_sv") = "Mã sinh viên"
        fg.Cols("Ma_sv").Width = 80
        fg.Cols("Ma_sv").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ho_ten").Visible = True
        fg(0, "Ho_ten") = "Họ và tên"
        fg(1, "Ho_ten") = "Họ và tên"
        fg.Cols("Ho_ten").Width = 160

        fg.Cols("Ten_lop").Visible = True
        fg(0, "Ten_lop") = "Tên lớp"
        fg(1, "Ten_lop") = "Tên lớp"
        fg.Cols("Ten_lop").TextAlign = TextAlignEnum.CenterCenter
        fg.Cols("Ten_lop").Width = 70

        fg.Cols("TBCHT").Visible = True
        fg(0, "TBCHT") = "TBCHT"
        fg(1, "TBCHT") = "TBCHT"
        fg.Cols("TBCHT").Width = 55
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai").Visible = True
        fg(0, "Xep_loai") = "Xếp loại"
        fg(1, "Xep_loai") = "Xếp loại"
        fg.Cols("Xep_loai").Width = 70

        fg.Cols("So_mon_no").Visible = True
        fg(0, "So_mon_no") = "Nợ"
        fg(1, "So_mon_no") = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        Dim dt_main As DataTable = fgTongHopKy.DataSource
        'Format các cột môn học biến động theo số môn
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                If .Khong_tinh_TBCHT = False Then
                    'Hiển thị cột điểm
                    fg.Cols("M" + .ID_mon.ToString).Visible = True
                    'Gán tiêu đề cột điểm
                    If optKyHieu.Checked Then
                        fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                    Else
                        fg(0, "M" + .ID_mon.ToString) = .Ten_mon
                    End If
                    fg(1, "M" + .ID_mon.ToString) = "TBCM"
                    fg(2, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString + Encode(i)
                    fg.Cols("M" + .ID_mon.ToString).Width = 45
                    fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                    fg.Cols("M" + .ID_mon.ToString).StyleNew.Font = New Font("Arial", 10, FontStyle.Bold)
                    'Mon Sub
                    If chkThanh_phan.Checked Then
                        'Voi diem thi
                        Dim col As New DataColumn("T" + .ID_mon.ToString + "Thi")
                        If dt_main.Columns.Contains(col.ColumnName) Then
                            fg.Cols(col.ColumnName).Visible = True
                            If optKyHieu.Checked Then
                                fg(0, col.ColumnName) = .Ky_hieu
                            Else
                                fg(0, col.ColumnName) = .Ten_mon
                            End If
                            fg(1, col.ColumnName) = "Thi"
                            fg(2, col.ColumnName) = .So_hoc_trinh.ToString + Encode(i)
                            fg.Cols(col.ColumnName).Width = 40
                            fg.Cols(col.ColumnName).TextAlign = TextAlignEnum.CenterCenter
                        End If
                        'Voi diem thanh phan
                        For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                            col = New DataColumn("T" + .ID_mon.ToString + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString)
                            If dt_main.Columns.Contains(col.ColumnName) Then
                                fg.Cols(col.ColumnName).Visible = True
                                If optKyHieu.Checked Then
                                    fg(0, col.ColumnName) = .Ky_hieu
                                Else
                                    fg(0, col.ColumnName) = .Ten_mon
                                End If
                                fg(1, col.ColumnName) = clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Ky_hieu
                                fg(2, col.ColumnName) = .So_hoc_trinh.ToString + Encode(i)
                                fg.Cols(col.ColumnName).Width = 40
                                fg.Cols(col.ColumnName).TextAlign = TextAlignEnum.CenterCenter
                            End If
                        Next
                    End If
                End If
            End With
        Next
        Set_Style(fg)
    End Sub
    Private Function Encode(ByVal i As Integer) As String
        If i Mod 2 Then
            Return vbCr
        Else
            Return ""
        End If
    End Function
    Private Sub Allow_merge(ByVal fg As C1FlexGrid)
        fg.AllowMerging = AllowMergingEnum.FixedOnly
        If chkThanh_phan.Checked Then
            fg.Rows(0).AllowMerging = True
            fg.Rows(1).AllowMerging = True
            fg.Rows(2).AllowMerging = True
            For i As Integer = 0 To 26
                If i > 0 Then fg(2, i) = "Số học trình"
                fg.Cols(i).AllowMerging = True
            Next
        Else
            fg.Rows(1).AllowMerging = True
            For i As Integer = 1 To 26
                fg(1, i) = "Số học trình"
            Next
        End If
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.DarkSeaGreen
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Sub Set_Style(ByVal fg As C1FlexGrid)
        For i As Integer = fg.Rows.Fixed To fg.Rows.Count - 1
            For j As Integer = 18 To fg.Cols.Count - 1
                If j <> 22 Then
                    If fg(i, j).ToString <> "" AndAlso (IsNumeric(fg(i, j)) AndAlso fg(i, j) < 5) Then 'thi lại
                        fg.SetCellStyle(i, j, fg.Styles("ThiLai_Style"))
                    End If
                End If
            Next
            fg.Rows(i).Height = 35
        Next
    End Sub
    Public Shared Sub Flexgrid_setup(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        'Định nghĩa các kiểu để hiển thị      
        Dim Font_ As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim ThiLai_Style As CellStyle
        'ThucHanh_Style
        ThiLai_Style = fg.Styles.Add("ThiLai_Style")
        ThiLai_Style.BackColor = Color.Gray
        ThiLai_Style.Border.Color = Color.Gray
        ThiLai_Style.ForeColor = Color.Red
        ThiLai_Style.Font = Font_
        ThiLai_Style.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Function CheckValidate() As Boolean
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
        If TrvLop_ChuanHoa.Khoa_hoc <= 0 Then
            Thongbao("Bạn phải chọn đến khóa đào tạo !")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopHocTapNam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi thứ
        LoadComboBox()
        Flexgrid_setup(fgTongHopKy)
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TrvLop_ChuanHoa.Load_TreeView()
        cmbKho_giay.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        SetQuyenTruyCap(, btnTongHop, , )
    End Sub

    Private Sub frmESS_TongHopHocTapNam_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TrvLop_ChuanHoa_Select() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
                dsID_lop = TrvLop_ChuanHoa.ID_lop_list
                dsID_dt = TrvLop_ChuanHoa.ID_dt_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

    Private Sub btnTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTongHop.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If CheckValidate() Then
                Dim Tu_diem As Double = 0
                Dim Den_diem As Double = 0
                If txtTu_diem.Text.Trim <> "" Then
                    Tu_diem = Convert.ToDouble(txtTu_diem.Text)
                Else
                    Tu_diem = 0
                End If
                If txtDen_diem.Text.Trim <> "" Then
                    Den_diem = Convert.ToDouble(txtDen_diem.Text)
                Else
                    Den_diem = 0
                End If
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Nam_hoc As String = cmbNam_hoc.Text
                Dim ID_he As Integer = TrvLop_ChuanHoa.ID_he
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    ' Tổng hợp điểm rèn luyện
                    Dim obj_BLL As DiemRenLuyen_BLL
                    obj_BLL = New DiemRenLuyen_BLL(TrvLop_ChuanHoa.ID_lop_list)
                    Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenNam(cmbNam_hoc.Text)
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, Nam_hoc, dsID_lop, dsID_dt, mdtDanhSachSinhVien, ckMonVanHoa.Checked)
                    Dim dtTonghop As DataTable = clsDiem.TongHopDiemHocTapNam(cmbLan_thi.SelectedIndex + 1, chkGhi_chu.Checked, chkThanh_phan.Checked, dt_diemRL, ckLoc_theo_DTBCHT.Checked, Tu_diem, Den_diem, ckThi_5.Checked, ckTBMH_5.Checked)
                    If chkThanh_phan.Checked Then
                        fgTongHopKy.DataSource = dtTonghop
                        FormatFlexGrid_MainSub(fgTongHopKy)
                    Else
                        fgTongHopKy.DataSource = dtTonghop
                        FormatFlexGrid(fgTongHopKy)
                    End If
                Else
                    fgTongHopKy.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnXoa_TCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa_TCT.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If dsID_lop.Trim <> "" Then
                If fgTongHopKy.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopKy.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_Lop
                frmESS_.lbl.Text = TrvLop_ChuanHoa.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Lop(dt, dsID_lop)
                frmESS_.ShowDialog(dt_main, " Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If dsID_lop.Trim <> "" Then
                If fgTongHopKy.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopKy.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_mon
                frmESS_.lbl.Text = TrvLop_ChuanHoa.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Mon(dt)
                frmESS_.ShowDialog(dt_main, " Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao("Hãy chọn hiển thị theo điếm số và tổng hợp lại kết quả học tập !", MsgBoxStyle.Information)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim clsExcel As New ExportToExcel
                Dim Tieu_de As String = ""
                clsExcel.ExportFromC1flexgridToExcel(fgTongHopKy)
            Else
                Thongbao("Bạn phải tổng hợp dữ liệu điểm trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        Try
            GetReportHeader()
            Dim Tieu_de1, Tieu_de2 As String
            Dim dtMonHoc As DataTable
            Dim khoa_hoc As String = "KHÓA: " & TrvLop_ChuanHoa.Khoa_hoc & ", "
            Tieu_de1 = "BẢNG ĐIỂM TỔNG HỢP NĂM HỌC " & cmbNam_hoc.Text
            Tieu_de2 = khoa_hoc & TrvLop_ChuanHoa.Tieu_de
            dtMonHoc = clsDiem.DanhSachMonHoc
            Dim dtDiemTH As DataTable = fgTongHopKy.DataSource
            If dtDiemTH.Rows.Count > 0 Then
                Dim rpt As New rpt_TongHopTheoNam(dtDiemTH, dtMonHoc, Tieu_de1, Tieu_de2)
                rpt.DataSource = dtDiemTH
                PrintXtraReport(rpt)
            Else
                Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub btnIn_BC_DRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_BC_DRL.Click
        Try
            GetReportHeader()
            Dim Tieu_de1, Tieu_de2 As String
            Dim dtMonHoc As DataTable
            Dim khoa_hoc As String = "KHÓA: " & TrvLop_ChuanHoa.Khoa_hoc & ", "
            Tieu_de1 = "BẢNG ĐIỂM TỔNG HỢP NĂM HỌC " & cmbNam_hoc.Text
            Tieu_de2 = khoa_hoc & TrvLop_ChuanHoa.Tieu_de
            dtMonHoc = clsDiem.DanhSachMonHoc
            Dim dtTenMon As New DataTable
            If dtMonHoc.Rows.Count > 0 Then
                dtTenMon.Columns.Add("TenMon", GetType(String))
                dtTenMon.Columns.Add("TenMon_Chuan", GetType(String))
                For i As Integer = 0 To dtMonHoc.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dtTenMon.NewRow
                    dr("TenMon") = (i + 1)
                    dr("TenMon_Chuan") = dtMonHoc.Rows(i)("Ten_mon").ToString
                    dtTenMon.Rows.Add(dr)
                Next
            End If

            Dim dtDiemTH As DataTable = fgTongHopKy.DataSource
            If dtDiemTH.Rows.Count > 0 Then
                Dim rpt As New rpt_TongHopTheoNam(dtDiemTH, dtMonHoc, Tieu_de1, Tieu_de2, dtTenMon)
                rpt.DataSource = dtDiemTH
                PrintXtraReport(rpt)
            Else
                Thongbao("Không có dữ liệu", MsgBoxStyle.Information, "Thông báo")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class