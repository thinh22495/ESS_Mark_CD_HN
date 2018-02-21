Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Public Class frmESS_TongHopHocToanKhoa
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_BLL

#Region "Function"
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

        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHT"
        fg.Cols("TBCHT").Width = 50
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai").Visible = True
        fg.Cols("Xep_loai").Caption = "Xếp loai"
        fg.Cols("Xep_loai").Width = 80

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Caption = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        'fg.Cols("Ly_do").Visible = True
        'fg.Cols("Ly_do").Caption = "Ghi chú"
        'fg.Cols("Ly_do").Width = 80
        'fg.Cols("Ly_do").TextAlign = TextAlignEnum.LeftCenter

        'Format các cột môn học biến động theo số môn
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                'Hiển thị cột điểm
                fg.Cols("M" + .ID_mon.ToString).Visible = True
                'Gán tiêu đề cột điểm
                If optMaMon.Checked Then
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

        fg.Cols("TBCHT1").Visible = True
        fg(0, "TBCHT1") = "TBCHT1"
        fg(1, "TBCHT1") = "TBCHT1"
        fg.Cols("TBCHT1").Width = 55
        fg.Cols("TBCHT1").TextAlign = TextAlignEnum.CenterCenter

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

        Dim dt_main As DataTable = fgTongHopToanKhoa.DataSource
        'Format các cột môn học biến động theo số môn
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                If .Khong_tinh_TBCHT = False Then
                    'Hiển thị cột điểm
                    fg.Cols("M" + .ID_mon.ToString).Visible = True
                    'Gán tiêu đề cột điểm
                    If optMaMon.Checked Then
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
                            If optMaMon.Checked Then
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
                                If optMaMon.Checked Then
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
        fg.Rows(1).AllowMerging = True
        For i As Integer = 1 To 26
            fg(1, i) = "Số học trình"
        Next
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.DarkSeaGreen
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
        fg.Styles.Fixed.WordWrap = True
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

#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopToanKhoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TrvLop_ChuanHoa.Load_TreeView()
        Flexgrid_setup(fgTongHopToanKhoa)
        cmbKho_giay.SelectedIndex = 3
        SetQuyenTruyCap(, btnTongHop, , )
    End Sub

    Private Sub frmESS_TongHopToanKhoa_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
#End Region

    Private Sub btnTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTongHop.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            GetReportHeader()
            Dim ID_dv As String = gobjUser.ID_dv
            Dim ID_he As Integer = TrvLop_ChuanHoa.ID_he
            If TrvLop_ChuanHoa.Khoa_hoc > 0 Then
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, dsID_dt, mdtDanhSachSinhVien)
                    Dim dtTonghop As DataTable = clsDiem.TongHopDiemHocTapToanKhoa(chkGhi_chu.Checked, 2, chkThanh_phan.Checked)
                    Dim dtMonHoc As DataTable
                    dtMonHoc = clsDiem.DanhSachMonHoc
                    Dim dtAll As New DataTable
                    dtAll.Columns.Add("ID_sv", GetType(Integer))
                    dtAll.Columns.Add("Ma_sv", GetType(String))
                    dtAll.Columns.Add("Ho_ten", GetType(String))
                    dtAll.Columns.Add("Ngay_sinh", GetType(Date))
                    dtAll.Columns.Add("Gioi_tinh", GetType(String))
                    dtAll.Columns.Add("Ten_lop", GetType(String))
                    dtAll.Columns.Add("Ten_he", GetType(String))
                    dtAll.Columns.Add("Ten_nganh", GetType(String))
                    dtAll.Columns.Add("Nien_khoa", GetType(String))
                    dtAll.Columns.Add("Khoa_hoc", GetType(String))
                    dtAll.Columns.Add("Chuyen_nganh", GetType(String))
                    dtAll.Columns.Add("Ten_khoa", GetType(String))
                    dtAll.Columns.Add("Dia_chi_tt", GetType(String))

                    For i As Integer = 0 To dtMonHoc.Rows.Count - 1
                        dtAll.Columns.Add("M" & dtMonHoc.Rows(i)("ID_mon"), GetType(String))
                    Next
                    dtAll.Columns.Add("TBCHT1", GetType(Double))
                    dtAll.Columns.Add("TBCHT", GetType(Double))
                    dtAll.Columns.Add("ID_Xep_loai", GetType(Integer))
                    dtAll.Columns.Add("Xep_loai", GetType(String))
                    dtAll.Columns.Add("Diem_quy_doi", GetType(Double))
                    dtAll.Columns.Add("TBC_MR", GetType(Double))
                    dtAll.Columns.Add("TBC_RL", GetType(Double))
                    dtAll.Columns.Add("ID_Xep_loai_RL", GetType(String))
                    dtAll.Columns.Add("Xep_loai_RL", GetType(String))
                    dtAll.Columns.Add("so_mon_no", GetType(Integer))
                    dtAll.Columns.Add("So_trinh_thi_lai", GetType(Double))
                    dtAll.Columns.Add("Ten_mon_no", GetType(String))
                    dtAll.Columns.Add("Danh_hieu_thi_dua", GetType(String))
                    Dim obj_BLL As DiemRenLuyen_BLL
                    obj_BLL = New DiemRenLuyen_BLL(TrvLop_ChuanHoa.ID_lop_list)
                    Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenKhoa
                    Dim TongDiemRL As Integer = 0
                    Dim ID_XepLoai_RL As Integer = 0
                    Dim XepLoai_RL As String = ""
                    For j As Integer = 0 To dtTonghop.Rows.Count - 1
                        For k As Integer = 0 To dt_diemRL.Rows.Count - 1
                            If dt_diemRL.Rows(k).Item("ID_SV") = dtTonghop.Rows(j)("Id_sv") Then
                                TongDiemRL = dt_diemRL.Rows(k).Item("Tong_diem")
                                XepLoai_RL = dt_diemRL.Rows(k).Item("Xep_loai")
                                ID_XepLoai_RL = dt_diemRL.Rows(k).Item("ID_Xep_loai")
                            End If
                        Next
                        Dim dr As DataRow
                        dr = dtAll.NewRow
                        dr("Ma_sv") = dtTonghop.Rows(j)("Ma_sv").ToString
                        dr("Ho_ten") = dtTonghop.Rows(j)("Ho_ten").ToString
                        If dtTonghop.Rows(j)("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTonghop.Rows(j)("Ngay_sinh").ToString
                        dr("Gioi_tinh") = dtTonghop.Rows(j)("Gioi_tinh").ToString
                        dr("Ten_lop") = dtTonghop.Rows(j)("Ten_lop").ToString
                        dr("Ten_he") = dtTonghop.Rows(j)("Ten_he").ToString
                        dr("Ten_nganh") = dtTonghop.Rows(j)("Ten_nganh").ToString
                        dr("Nien_khoa") = dtTonghop.Rows(j)("Nien_khoa").ToString
                        dr("Khoa_hoc") = dtTonghop.Rows(j)("Khoa_hoc").ToString
                        dr("Chuyen_nganh") = dtTonghop.Rows(j)("Chuyen_nganh").ToString
                        dr("Ten_khoa") = dtTonghop.Rows(j)("Ten_khoa").ToString
                        dr("Dia_chi_tt") = dtTonghop.Rows(j)("Dia_chi_tt").ToString
                        For f As Integer = 0 To dtMonHoc.Rows.Count - 1
                            dr("M" & dtMonHoc.Rows(f)("Id_mon")) = dtTonghop.Rows(j)("M" & dtMonHoc.Rows(f)("Id_mon")).ToString
                        Next
                        If dtTonghop.Rows(j)("TBCHT1").ToString <> "" Then
                            dr("TBCHT1") = dtTonghop.Rows(j)("TBCHT1")
                        Else
                            dr("TBCHT1") = 0
                        End If
                        If dtTonghop.Rows(j)("TBCHT").ToString <> "" Then
                            dr("TBCHT") = dtTonghop.Rows(j)("TBCHT1")
                        Else
                            dr("TBCHT") = 0
                        End If
                        If dtTonghop.Rows(j)("ID_Xep_loai").ToString <> "" Then dr("ID_Xep_loai") = dtTonghop.Rows(j)("ID_Xep_loai").ToString
                        dr("Xep_loai") = dtTonghop.Rows(j)("Xep_loai").ToString
                        dr("TBC_RL") = TongDiemRL
                        dr("Xep_loai_RL") = XepLoai_RL
                        dr("ID_Xep_loai_RL") = ID_XepLoai_RL
                        If dr("TBCHT") > 0 Then
                            If TongDiemRL < 30 Then
                                dr("Diem_quy_doi") = -1
                                dr("TBC_MR") = -1 + dr("TBCHT")
                            ElseIf TongDiemRL >= 30 And TongDiemRL <= 35 Then
                                dr("Diem_quy_doi") = -0.7
                                dr("TBC_MR") = -0.7 + dr("TBCHT")
                            ElseIf TongDiemRL >= 36 And TongDiemRL <= 40 Then
                                dr("Diem_quy_doi") = -0.5
                                dr("TBC_MR") = -0.5 + dr("TBCHT")
                            ElseIf TongDiemRL >= 41 And TongDiemRL <= 45 Then
                                dr("Diem_quy_doi") = -0.3
                                dr("TBC_MR") = -0.3 + dr("TBCHT")
                            ElseIf TongDiemRL >= 46 And TongDiemRL <= 49 Then
                                dr("Diem_quy_doi") = -0.1
                                dr("TBC_MR") = -0.1 + dr("TBCHT")
                            ElseIf TongDiemRL >= 50 And TongDiemRL <= 55 Then
                                dr("Diem_quy_doi") = 0
                                dr("TBC_MR") = 0 + dr("TBCHT")
                            ElseIf TongDiemRL >= 56 And TongDiemRL <= 59 Then
                                dr("Diem_quy_doi") = 0.1
                                dr("TBC_MR") = 0.1 + dr("TBCHT")
                            ElseIf TongDiemRL >= 60 And TongDiemRL <= 64 Then
                                dr("Diem_quy_doi") = 0.2
                                dr("TBC_MR") = 0.2 + dr("TBCHT")
                            ElseIf TongDiemRL >= 65 And TongDiemRL <= 69 Then
                                dr("Diem_quy_doi") = 0.4
                                dr("TBC_MR") = 0.4 + dr("TBCHT")
                            ElseIf TongDiemRL >= 70 And TongDiemRL <= 74 Then
                                dr("Diem_quy_doi") = 0.5
                                dr("TBC_MR") = 0.5 + dr("TBCHT")
                            ElseIf TongDiemRL >= 75 And TongDiemRL <= 79 Then
                                dr("Diem_quy_doi") = 0.6
                                dr("TBC_MR") = 0.6 + dr("TBCHT")
                            ElseIf TongDiemRL >= 80 And TongDiemRL <= 84 Then
                                dr("Diem_quy_doi") = 0.7
                                dr("TBC_MR") = 0.7 + dr("TBCHT")
                            ElseIf TongDiemRL >= 85 And TongDiemRL <= 89 Then
                                dr("Diem_quy_doi") = 0.8
                                dr("TBC_MR") = 0.8 + dr("TBCHT")
                            ElseIf TongDiemRL >= 90 And TongDiemRL <= 94 Then
                                dr("Diem_quy_doi") = 0.9
                                dr("TBC_MR") = 0.9 + dr("TBCHT")
                            ElseIf TongDiemRL >= 95 And TongDiemRL <= 100 Then
                                dr("Diem_quy_doi") = 1
                                dr("TBC_MR") = 1 + dr("TBCHT")
                            End If
                        End If
                        dr("Ten_mon_no") = dtTonghop.Rows(j)("Ten_mon_no")
                        dr("So_mon_no") = dtTonghop.Rows(j)("So_mon_no")
                        dr("So_trinh_thi_lai") = dtTonghop.Rows(j)("So_trinh_thi_lai")
                        If dr("So_trinh_thi_lai").ToString = "" Then
                            If CType(dr("TBCHT"), Double) <= 10 And CType(dr("TBCHT"), Double) >= 9 Then
                                dr("Danh_hieu_thi_dua") = "HSXS"
                            ElseIf CType(dr("TBCHT"), Double) < 9 And CType(dr("TBCHT"), Double) >= 8 Then
                                dr("Danh_hieu_thi_dua") = "HSG"
                            ElseIf CType(dr("TBCHT"), Double) < 8 And CType(dr("TBCHT"), Double) >= 7 Then
                                dr("Danh_hieu_thi_dua") = "HSK"
                            Else
                                dr("Danh_hieu_thi_dua") = ""
                            End If
                        End If
                        dtAll.Rows.Add(dr)
                    Next
                    If chkThanh_phan.Checked Then
                        fgTongHopToanKhoa.DataSource = dtAll
                        FormatFlexGrid_MainSub(fgTongHopToanKhoa)
                    Else
                        fgTongHopToanKhoa.DataSource = dtAll
                        FormatFlexGrid(fgTongHopToanKhoa)
                    End If
                Else
                    fgTongHopToanKhoa.DataSource = Nothing
                End If
            Else
                Thongbao("Bạn phải chọn đến khóa đào tạo !")
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
                If fgTongHopToanKhoa.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopToanKhoa.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_Lop
                frmESS_.lbl.Text = TrvLop_ChuanHoa.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Lop(dt, dsID_lop)
                frmESS_.ShowDialog(dt_main, "")
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
                If fgTongHopToanKhoa.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopToanKhoa.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_mon
                frmESS_.lbl.Text = TrvLop_ChuanHoa.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Mon(dt)
                frmESS_.ShowDialog(dt_main, "")
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
            Dim clsExcel As New ExportToExcel
            'Dim Tieu_de As String = ""
            'clsExcel.ExportFromC1flexgridToExcel(fgTongHopToanKhoa).
            Dim dt As DataTable
            dt = fgTongHopToanKhoa.DataSource
            ExportToExcel(dt.DefaultView)
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
            If cmbLan_thi.SelectedIndex = 0 Then
                Tieu_de1 = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP VÀ RÈN LUYỆN TOÀN KHÓA "
            Else
                Tieu_de1 = "BẢNG TỔNG HỢP KẾT QUẢ HỌC TẬP VÀ RÈN LUYỆN TOÀN KHÓA "
            End If
            Tieu_de2 = khoa_hoc & TrvLop_ChuanHoa.Tieu_de
            dtMonHoc = clsDiem.DanhSachMonHoc
            Dim dtTenMon As New DataTable
            If dtMonHoc.Rows.Count > 0 Then
                dtTenMon.Columns.Add("TenMon", GetType(String))
                For i As Integer = 0 To dtMonHoc.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dtTenMon.NewRow
                    dr("TenMon") = (i + 1)
                    dtTenMon.Rows.Add(dr)
                Next
            End If
            Dim dtDiemTH As DataTable = fgTongHopToanKhoa.DataSource
            If dtDiemTH.Rows.Count > 0 Then
                Dim rpt As New rpt_TongHopToanKhoa(dtDiemTH, dtMonHoc, Tieu_de1, Tieu_de2, dtTenMon)
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

   
End Class