Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Library
Imports System.Collections.Generic
Public Class frmESS_BangDiemChiTietSinhVien
    Private Loader As Boolean = False
    Dim obj_BLL As DiemRenLuyen_BLL
    Public ID_dt, ID_sv As Integer
    Private dt_BangdiemMain As DataTable
    'Private row As DataRow = grdViewDanhSachSinhVien.GetFocusedDataRow()

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)

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
    Private Sub LoadBangDiem(ByVal ID_he As Integer, ByVal ID_sv As Integer, ByVal ID_dt As Integer)
        Dim Hoc_ky As Integer = 0
        Dim Nam_hoc As String = ""
        'Load bảng điểm sinh viên
        If cmbID_bangdiem.SelectedIndex = 0 Then
            Hoc_ky = cmbHoc_ky.Text
            Nam_hoc = cmbNam_hoc.Text
        End If
        If cmbID_bangdiem.SelectedIndex = 1 Then Nam_hoc = cmbNam_hoc.Text

        Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
        Dim dt As DataTable = dv.Table.Copy
        dt.DefaultView.RowFilter = "ID_SV=" & ID_sv
        lblXep_loai_hoc_luc.Text = ""
        lblSo_mon_hoc_lai.Text = ""
        lblSo_mon_thi_lai.Text = ""
        lblTBC_tich_luy.Text = ""
        Me.grcViewDiem.DataSource = Nothing
        If dv.Count > 0 Then
            Dim clsDiem As New BangDiemCaNhan_BLL(ID_he, gobjUser.ID_dv, dt.DefaultView, ID_dt, Hoc_ky, Nam_hoc)
            dt_BangdiemMain = clsDiem.BangDiem()
            If dt_BangdiemMain.Rows.Count > 0 Then
                lblXep_loai_hoc_luc.Text = dt_BangdiemMain.Rows(0).Item("Xep_loai").ToString
                lblSo_mon_hoc_lai.Text = dt_BangdiemMain.Rows(0).Item("So_mon_hoc_lai").ToString
                lblSo_mon_thi_lai.Text = dt_BangdiemMain.Rows(0).Item("So_mon_thi_lai").ToString
                lblTBC_tich_luy.Text = dt_BangdiemMain.Rows(0).Item("TBCHT").ToString
                Me.grcViewDiem.DataSource = dt_BangdiemMain.DefaultView
            End If
        End If
    End Sub
    Private Function LoadBangDiemLin(ByVal ID_he As Integer, ByVal ID_sv As Integer, ByVal ID_dt As Integer) As DataView
        Dim Hoc_ky As Integer = 0
        Dim Nam_hoc As String = ""
        'Load bảng điểm sinh viên
        If cmbID_bangdiem.SelectedIndex = 0 Then
            Hoc_ky = cmbHoc_ky.Text
            Nam_hoc = cmbNam_hoc.Text
        End If
        If cmbID_bangdiem.SelectedIndex = 1 Then Nam_hoc = cmbNam_hoc.Text
        Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
        Dim dt As DataTable = dv.Table.Copy
        dt.DefaultView.RowFilter = "ID_SV=" & ID_sv

        lblXep_loai_hoc_luc.Text = ""
        lblSo_mon_hoc_lai.Text = ""
        lblSo_mon_thi_lai.Text = ""
        lblTBC_tich_luy.Text = ""
        Me.grcViewDiem.DataSource = Nothing
        If dv.Count > 0 Then
            Dim clsDiem As New BangDiemCaNhan_BLL(ID_he, gobjUser.ID_dv, dt.DefaultView, ID_dt, Hoc_ky, Nam_hoc)
            dt_BangdiemMain = clsDiem.BangDiem()
        End If
        Return dt_BangdiemMain.DefaultView
    End Function
#End Region
    Private Sub frmESS_BangDiemChiTietSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        FillCombo(cmbID_he, "SELECT ID_he, Ten_he FROM STU_He")
        Loader = True
    End Sub
    Private Sub frmESS_BangDiemChiTietSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
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
            obj_BLL = New DiemRenLuyen_BLL(cmbID_lop.SelectedValue)
        End If
    End Sub
    Private Sub grdViewSinhVien_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_bangdiem.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
       
    End Sub
    'Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged, cmbID_chuyen_nganh.SelectedIndexChanged, cmbKhoa_hoc.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
    '    Try
    '        If Loader Then
    '            Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
    '            Dim dtLop As DataTable = clsLop.Danh_sach_lop_dang_hoc()
    '            Dim dk As String = "1=1"
    '            If cmbID_he.SelectedValue > 0 Then dk += " AND ID_he=" & cmbID_he.SelectedValue
    '            If cmbKhoa_hoc.Text.Trim <> "" Then dk += " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
    '            If cmbID_chuyen_nganh.Text.Trim <> "" Then dk += " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
    '            dtLop.DefaultView.RowFilter = dk
    '            FillCombo(cmbID_lop, dtLop.DefaultView.Table, "ID_lop", "Ten_lop")
    '            If cmbID_lop.Text.Trim = "" Then
    '                Me.grcViewDanhSachSinhVien.DataSource = Nothing
    '                grcViewDiem.DataSource = Nothing
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim clsExcel As New ExportToExcel
        '        Dim Tieu_de As String = ""
        '        clsExcel.ExportFromDataGridViewToExcel(grdViewDiem)
        '    Else
        '        Thongbao("Chưa có dữ liệu !")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbID_bangdiem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_bangdiem.SelectedIndexChanged
        If cmbID_bangdiem.SelectedIndex = 0 Then
            cmbHoc_ky.Enabled = True
            cmbNam_hoc.Enabled = True

        End If
        If cmbID_bangdiem.SelectedIndex = 1 Then
            cmbHoc_ky.Enabled = False
            cmbNam_hoc.Enabled = True

        End If
        If cmbID_bangdiem.SelectedIndex = 2 Then
            cmbHoc_ky.Enabled = False
            cmbNam_hoc.Enabled = False

        End If
    End Sub

    Private Sub cmdPrint_BangDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objBaocao As New BaoCao
            Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
            If dv.Count > 0 Then
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim ReportNam As String = "BangDiem_ToanKhoa_NienChe_LienThong"
                Dim dt_diemRL As DataTable

                If cmbID_bangdiem.SelectedIndex > 1 Then
                    dt_diemRL = obj_BLL.TongHop_DiemRenLuyenKhoa
                End If
                If cmbID_bangdiem.SelectedIndex = 0 Then
                    Hoc_ky = cmbHoc_ky.Text
                    Nam_hoc = cmbNam_hoc.Text
                    ReportNam = "BangDiem_Ky_NienChe"
                    dt_diemRL = obj_BLL.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
                End If
                If cmbID_bangdiem.SelectedIndex = 1 Then
                    ReportNam = "BangDiem_Nam_NienChe"
                    Nam_hoc = cmbNam_hoc.Text
                    dt_diemRL = obj_BLL.TongHop_DiemRenLuyenNam(Nam_hoc)
                End If

                Dim dt As DataTable = dt_BangdiemMain.Copy

                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")

                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = grdViewDanhSachSinhVien.GetFocusedDataRow()("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    dt.Rows(i).Item("TBC_RL") = TongDiemRL
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(ReportNam, dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objBaocao As New BaoCao
            Dim Ho_ten, Ngay_sinh, Ma_sv, Chuyen_nganh, Ten_nganh, Ten_tinh As String
            Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
            If dv.Count > 0 Then
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim ReportNam As String = "BangDiem_ToanKhoa_TamThoi_NienChe"
                Dim dt_diemRL As DataTable

                If cmbID_bangdiem.SelectedIndex > 1 Then
                    dt_diemRL = obj_BLL.TongHop_DiemRenLuyenKhoa
                End If
                If cmbID_bangdiem.SelectedIndex = 0 Then
                    Hoc_ky = cmbHoc_ky.Text
                    Nam_hoc = cmbNam_hoc.Text
                    Dim dvSnhVien As DataView = grdViewDanhSachSinhVien.DataSource
                    If dvSnhVien.Count > 0 Then
                        Dim row As DataRow = grdViewDanhSachSinhVien.GetFocusedDataRow()
                        Ma_sv = row("Ma_sv").ToString
                        Ho_ten = row("Ho_ten").ToString
                        Ngay_sinh = FormatDateTime(row("Ngay_sinh").ToString, DateFormat.ShortDate)
                        Chuyen_nganh = row("Chuyen_nganh").ToString
                        Ten_nganh = row("Ten_nganh").ToString
                        Ten_tinh = row("Ten_tinh").ToString
                    Else
                        Thongbao("Bạn hãy chọn sinh viên cần In", MsgBoxStyle.Information, "Thông báo")
                    End If
                    Dim tieu_de As String = "BẢNG ĐIỂM HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                    Dim dv_Diem1 As DataView = grdViewDiem.DataSource
                    Dim dtMain As DataTable = dv_Diem1.Table
                    If dv_Diem1.Count > 0 Then
                        Dim frm As New frmBangDiemKy_SV(dtMain, tieu_de, Ma_sv, Ho_ten, Ngay_sinh, Chuyen_nganh, Ten_nganh, Ten_tinh)
                        frm.DataSource = dv_Diem1
                        frm.Binding()
                        PrintXtraReport(frm)
                    Else
                        Thongbao("Không có dữ liệu để In", MsgBoxStyle.Information, "Thông báo")
                    End If
                End If
                If cmbID_bangdiem.SelectedIndex = 1 Then
                    ReportNam = "BangDiem_Nam_NienChe"
                    Nam_hoc = cmbNam_hoc.Text
                    dt_diemRL = obj_BLL.TongHop_DiemRenLuyenNam(Nam_hoc)
                End If

                Dim dt As DataTable = dt_BangdiemMain.Copy

                dt.Columns.Add("Thong_bao")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")

                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = grdViewDanhSachSinhVien.GetFocusedDataRow()("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                For i As Integer = 0 To dt.Rows.Count - 1
                    'dt.Rows(i).Item("Thong_bao") = txtThongBao.Text.Trim
                    dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    dt.Rows(i).Item("TBC_RL") = TongDiemRL
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(ReportNam, dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            GetReportHeader()
            If cmbID_bangdiem.SelectedIndex = 0 Then
                Dim dvSinhVien As DataView = grdViewDanhSachSinhVien.DataSource
                Dim obj_BLL As DiemRenLuyen_BLL
                obj_BLL = New DiemRenLuyen_BLL(cmbID_lop.SelectedValue)
                Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenNam(cmbNam_hoc.Text)
                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("Id_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("Id_he", GetType(String))
                dt.Columns.Add("ID_dt", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ho_ten_gv", GetType(String))
                dt.Columns.Add("Dien_thoai", GetType(String))
                dt.Columns.Add("Email", GetType(String))
                dt.Columns.Add("Dienthoai_khoa", GetType(String))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("TBC_RL", GetType(Double))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
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
                    dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh").ToString
                    dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                    dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                    dr("ID_dt") = dvSinhVien.Item(i)("ID_dt").ToString
                    dr("ID_he") = dvSinhVien.Item(i)("ID_he").ToString
                    dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                    dr("Ho_ten_gv") = dvSinhVien.Item(i)("Ho_ten_gv").ToString
                    dr("Dien_thoai") = dvSinhVien.Item(i)("Dien_thoai").ToString
                    dr("Email") = dvSinhVien.Item(i)("Email").ToString
                    dr("Dienthoai_khoa") = dvSinhVien.Item(i)("Dienthoai_khoa").ToString
                    dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                    dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                    dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                    dr("TBC_RL") = TongDiemRL
                    dr("Xep_loai_RL") = XepLoai_RL
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.RowFilter = "Chon = 'True'"
                ''''''''''''''''''''''''''''
                Dim dict As Dictionary(Of Integer, DataView) = New Dictionary(Of Integer, DataView)
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                For Each drv As DataRowView In dt.DefaultView
                    Dim dv As DataView = LoadBangDiemLin(drv("ID_he"), drv("ID_sv"), drv("ID_dt"))
                    dict.Add(drv("ID_sv"), dv)
                    drv("TBCHT") = dv(0).Item("TBCHT")
                    drv("Xep_loai") = dv(0).Item("Xep_loai")
                Next
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                Dim tieu_de As String = "PHIẾU BÁO KẾT QUẢ HỌC TẬP VÀ RÈN LUYỆN HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                Dim Tieu_de2 As String = "Nhà trường thông báo kết quả học tập, rèn luyện Học kỳ " & cmbHoc_ky.Text & " của học sinh, sinh viên như sau:"
                Dim rpt As New rptBangDiem_NamHoc(dt.DefaultView, dict, tieu_de, Tieu_de2)
                PrintXtraReport(rpt)
            ElseIf cmbID_bangdiem.SelectedIndex = 1 Then
                Dim dvSinhVien As DataView = grdViewDanhSachSinhVien.DataSource
                Dim obj_BLL As DiemRenLuyen_BLL
                obj_BLL = New DiemRenLuyen_BLL(cmbID_lop.SelectedValue)
                Dim dt_diemRL As DataTable = obj_BLL.TongHop_DiemRenLuyenNam(cmbNam_hoc.Text)
                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("Id_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("Id_he", GetType(String))
                dt.Columns.Add("ID_dt", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ho_ten_gv", GetType(String))
                dt.Columns.Add("Dien_thoai", GetType(String))
                dt.Columns.Add("Email", GetType(String))
                dt.Columns.Add("Dienthoai_khoa", GetType(String))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("TBC_RL", GetType(Double))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
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
                    dr("Ngay_sinh") = dvSinhVien.Item(i)("Ngay_sinh").ToString
                    dr("Ten_lop") = dvSinhVien.Item(i)("Ten_lop").ToString
                    dr("Nien_khoa") = dvSinhVien.Item(i)("Nien_khoa").ToString
                    dr("ID_dt") = dvSinhVien.Item(i)("ID_dt").ToString
                    dr("ID_he") = dvSinhVien.Item(i)("ID_he").ToString
                    dr("Ten_he") = dvSinhVien.Item(i)("Ten_he").ToString
                    dr("Ho_ten_gv") = dvSinhVien.Item(i)("Ho_ten_gv").ToString
                    dr("Dien_thoai") = dvSinhVien.Item(i)("Dien_thoai").ToString
                    dr("Email") = dvSinhVien.Item(i)("Email").ToString
                    dr("Dienthoai_khoa") = dvSinhVien.Item(i)("Dienthoai_khoa").ToString
                    dr("Chuyen_nganh") = dvSinhVien.Item(i)("Chuyen_nganh").ToString
                    dr("Ten_nganh") = dvSinhVien.Item(i)("Ten_nganh").ToString
                    dr("Ten_khoa") = dvSinhVien.Item(i)("Ten_khoa").ToString
                    dr("TBC_RL") = TongDiemRL
                    dr("Xep_loai_RL") = XepLoai_RL
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.RowFilter = "Chon = 'True'"
                ''''''''''''''''''''''''''''
                Dim dict As Dictionary(Of Integer, DataView) = New Dictionary(Of Integer, DataView)
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                For Each drv As DataRowView In dt.DefaultView
                    Dim dv As DataView = LoadBangDiemLin(drv("ID_he"), drv("ID_sv"), drv("ID_dt"))
                    dict.Add(drv("ID_sv"), dv)
                    drv("TBCHT") = dv(0).Item("TBCHT")
                    drv("Xep_loai") = dv(0).Item("Xep_loai")
                Next
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                Dim tieu_de As String = "PHIẾU BÁO KẾT QUẢ HỌC TẬP VÀ RÈN LUYÊN " & vbNewLine & _
                "HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                Dim Tieu_de2 As String = "Nhà trường thông báo kết quả học tập, rèn luyện Học kỳ " & cmbHoc_ky.Text & " của học sinh, sinh viên như sau:"
                Dim rpt As New rptBangDiem_NamHoc(dt.DefaultView, dict, tieu_de, Tieu_de2)
                PrintXtraReport(rpt)
            Else
                Dim dvSinhVien As DataView = grdViewDanhSachSinhVien.DataSource
                dvSinhVien.RowFilter = "Chon = 'True'"
                Dim dict As Dictionary(Of Integer, DataView) = New Dictionary(Of Integer, DataView)
                Dim dtsv As DataTable = dvSinhVien.ToTable
                dtsv.Columns.Add("TBCHT", GetType(Double))
                dtsv.Columns.Add("Xep_loai", GetType(String))
                For Each drv As DataRowView In dtsv.DefaultView
                    Dim dv As DataView = LoadBangDiemLin(drv("ID_he"), drv("ID_sv"), drv("ID_dt"))
                    dict.Add(drv("ID_sv"), dv)
                    drv("TBCHT") = dv(0).Item("TBCHT")
                    drv("Xep_loai") = dv(0).Item("Xep_loai")
                Next
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                Dim tieu_de As String = "BẢNG KẾT QUẢ HỌC TẬP"
                Dim rpt As New rptBangDiemToanKhoa_Moi(dtsv.DefaultView, dict, tieu_de)
                PrintXtraReport(rpt)
                dvSinhVien.RowFilter = "1=1"
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim dv3 As DataView = grdViewDanhSachSinhVien.DataSource
        'ID_sv = dv3.Item(grdViewDanhSachSinhVien.CurrentRow.Index).Item("ID_sv").ToString
        'Dim a As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
        'Dim dv As DataView = a.Load_DiemToanKhoa_SV(ID_sv).DefaultView
        'Dim tieu_de As String = "BẢNG ĐIỂM"
        'Dim frm As New rptBangTotNghiep(ID_sv)
        'PrintXtraReport(frm)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim dv As New DataView
        'dv = grdViewDiem.DataSource
        'If dv.Count = 0 Then Exit Sub
        'For i As Integer = 0 To dv.Count - 1
        '    grdViewDiem.Rows(i).Cells(0).Value = ckAll.Checked
        'Next
        'grdViewDiem.DataSource = dv
        'For i As Integer = 0 To grdViewDiem.RowCount - 1
        '    grdViewDiem.Rows(i).Cells(0).Value = ckAll.Checked
        'Next
    End Sub

    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dvSinhVien As DataView = grdViewDanhSachSinhVien.DataSource
        Dim Hoc_ky As Integer = 0
        Dim Nam_hoc As String = ""
        Dim Ho_ten, Ngay_sinh, Ma_sv, Chuyen_nganh, Ten_nganh, Ten_tinh, Ten_he As String
        Hoc_ky = cmbHoc_ky.Text
        Nam_hoc = cmbNam_hoc.Text
        Dim tieu_de As String = "BẢNG KẾT QUẢ HỌC TẬP"
        If dvSinhVien.Count > 0 Then
            Dim row As DataRow = grdViewDanhSachSinhVien.GetFocusedDataRow()
            Ma_sv = row("Ma_sv").ToString
            Ho_ten = row("Ho_ten").ToString
            Ngay_sinh = FormatDateTime(row("Ngay_sinh").ToString, DateFormat.ShortDate)
            Chuyen_nganh = row("Chuyen_nganh").ToString
            Ten_nganh = row("Ten_nganh").ToString
            Ten_tinh = row("Ten_tinh").ToString
            Ten_he = row("Ten_he").ToString
        Else
            Thongbao("Bạn hãy chọn sinh viên cần In", MsgBoxStyle.Information, "Thông báo")
        End If
        Dim dv_Diem1 As DataView = grdViewDiem.DataSource
        Dim dtMain As DataTable = dv_Diem1.Table
        If dv_Diem1.Count > 0 Then
            Dim frm As New rptBangDiemToanKhoa_BaoLuu(dtMain, tieu_de, Ma_sv, Ho_ten, Ngay_sinh, Chuyen_nganh, Ten_nganh, Ten_tinh, Ten_he)
            frm.SetupDatasource(dv_Diem1)
            PrintXtraReport(frm)
        Else
            Thongbao("Không có dữ liệu để In", MsgBoxStyle.Information, "Thông báo")
        End If
    End Sub


    Private Sub cbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSachSinhVien.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = cbAll.Checked
            Next
        End If

        'For i As Integer = 0 To grdViewDanhSachSinhVien.RowCount - 1
        '    grcViewDanhSachSinhVien.Rows(i).Cells(0).Value = cbAll.Checked
        'Next
        'Dim checked As Boolean = cbAll.Checked
        'Dim dv As New DataView
        'dv = grdViewDanhSachSinhVien.DataSource
        'For Each dr As DataRowView In dv
        '    dr("Chon") = checked
        'Next

        'Dim dv As New DataView
        'dv = grdViewDanhSach.DataSource
        'If dv.Count = 0 Then Exit Sub
        'For i As Integer = 0 To dv.Count - 1
        '    dv.Item(i).Row.Item("Chon") = optAll.Checked
        'Next
        'grdViewDanhSach.DataSource = dv
    End Sub

    Private Sub grdViewDanhSachSinhVien_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdViewDanhSachSinhVien.FocusedRowChanged
        Try
            If Loader Then
                Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
                If Not grdViewDanhSachSinhVien.GetFocusedDataRow() Is Nothing AndAlso cmbID_lop.Text.Trim <> "" Then
                    Dim row As DataRow = grdViewDanhSachSinhVien.GetFocusedDataRow()
                    ID_sv = row("ID_sv").ToString
                    ID_dt = row("ID_dt").ToString
                    'If cmdChuyenNganh.SelectedIndex = 0 Then
                    '    ID_dt = row("ID_dt").ToString
                    'Else
                    '    ID_dt = IIf(row("ID_dt2").ToString = "", 1, row("ID_dt2").ToString)
                    'End If
                    LoadBangDiem(cmbID_he.SelectedValue, ID_sv, ID_dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBang_diem_nhom_ky.Click
        Try
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            Dim objRL As New DiemRenLuyen_BLL(cmbID_lop.SelectedValue)
            Dim cls As New Diem_BLL
            Dim row As DataRow = grdViewDanhSachSinhVien.GetDataRow(grdViewDanhSachSinhVien.GetSelectedRows.GetValue(0))
            Dim ID_sv As Integer = row("ID_sv")
            Dim dt As DataTable = obj.Load_BangDiemToanKhoa_SV(ID_sv)
            Dim dtMonTN As DataTable = cls.dt_DanhSachDiemTheoSinhVien_MonTN(ID_sv)
            dt.Columns.Add("TBC_ky")
            dt.Columns.Add("Xep_hang_ky")
            dt.Columns.Add("Xep_hang_rl")
            dt.Columns.Add("TBCHP_max")
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
                If dt.Rows(i)("TBCHP2").ToString <> "" Or dt.Rows(i)("TBCHP_2_1").ToString <> "" Then
                    dt.Rows(i)("TBCHP_max") = dt.Rows(i)("TBCHP")
                Else
                    dt.Rows(i)("TBCHP_max") = ""
                End If
            Next
            Dim rpt As New rptBangDiemSinhVien_NhomHocKy(dt.DefaultView, dtMonTN.DefaultView)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDiemKT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiemKT.Click
        Try
            GetReportHeader()
            If grcViewDiem.DataSource Is Nothing Then Exit Sub
            Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL
            Dim row As DataRow = grdViewDanhSachSinhVien.GetDataRow(grdViewDanhSachSinhVien.GetSelectedRows.GetValue(0))
            Dim ID_sv As Integer = row("ID_sv")
            Dim dt As DataTable = obj.Load_BangDiemToanKhoa_SV(ID_sv)
            dt.Columns.Add("So_lan_KT", GetType(Integer))
            dt.Columns.Add("Lan1_HienThi", GetType(String))
            dt.Columns.Add("Lan_Max_HienThi", GetType(String))
            Dim dtDiemTP As DataTable = obj.Load_DiemThanhPhan_BySV_Mon(ID_sv, 0)
            Dim dtTP As DataTable = obj.LoadThanhPhanMon_BySV(ID_sv)
            If dt.Rows.Count > 0 Then
                For j As Integer = 0 To dt.Rows.Count - 1
                    Dim Lan_hoc_Max_mon As Integer = 0
                    Dim dtMax_lanHoc As DataTable
                    dtMax_lanHoc = ESS.Machine.UDB.SelectTable("SELECT DISTINCT max(Lan_hoc) Lan_hoc FROM Mark_DiemThi dt INNER JOIN Mark_Diem d ON d.ID_diem = dt.ID_diem WHERE ID_sv = " & ID_sv & " AND ID_mon = " & dt.Rows(j)("ID_mon") & " AND ID_dt = " & ID_dt)
                    If dtMax_lanHoc.Rows.Count > 0 Then
                        Lan_hoc_Max_mon = dtMax_lanHoc.Rows(0)(0)
                        Dim So_lan_kt As Integer = 0
                        For i As Integer = 0 To dtTP.Rows.Count - 1
                            Dim col As New DataColumn()
                            col = New DataColumn("TP" + dtTP.Rows(i)("ID_thanh_phan").ToString)
                            If Not dt.Columns.Contains(col.ColumnName) Then
                                dt.Columns.Add(col)
                            End If
                            dtDiemTP.DefaultView.RowFilter = "ID_mon=" & dt.Rows(j)("ID_mon") & " AND ID_thanh_phan=" & dtTP.Rows(i)("ID_thanh_phan") & " AND Lan_hoc = " & Lan_hoc_Max_mon
                            If dtDiemTP.DefaultView.Count > 0 Then
                                dt.Rows(j)("TP" + dtTP.Rows(i)("ID_thanh_phan").ToString) = dtDiemTP.DefaultView.Item(0)("Diem")
                                So_lan_kt += 1
                            End If
                        Next
                        dt.Rows(j)("So_lan_KT") = So_lan_kt
                        If Lan_hoc_Max_mon > 1 Then
                            dt.Rows(j)("Lan1_HienThi") = ""
                        Else
                            dt.Rows(j)("Lan1_HienThi") = dt.Rows(j)("DiemThi_L1")
                        End If
                        If dt.Rows(j)("DiemThi_L1").ToString = dt.Rows(j)("DiemThi_L2").ToString Then
                            dt.Rows(j)("Lan_Max_HienThi") = ""
                        Else
                            dt.Rows(j)("Lan_Max_HienThi") = dt.Rows(j)("DiemThi_L2")
                        End If
                    End If
                Next
            End If
            Dim rpt As New rptBangDiemTongHopChiTiet_SinhVien(dt.DefaultView, dtTP.DefaultView)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Loader = False Or cmbID_he.SelectedValue <= 0 Then Exit Sub
            Dim sql As String = "SELECT DISTINCT Khoa_hoc, Khoa_hoc FROM STU_Lop WHERE ID_he = " & cmbID_he.SelectedValue
            FillCombo(cmbKhoa_hoc, sql)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader = False Or cmbID_he.SelectedValue <= 0 Or cmbKhoa_hoc.SelectedValue <= 0 Then Exit Sub
            Dim sql As String = "SELECT DISTINCT cn.ID_chuyen_nganh, Chuyen_nganh FROM STU_Lop l INNER JOIN STU_ChuyenNganh cn ON cn.ID_chuyen_nganh = l.ID_chuyen_nganh WHERE ID_he = " & cmbID_he.SelectedValue & " AND Khoa_hoc = " & cmbKhoa_hoc.SelectedValue
            FillCombo(cmbID_chuyen_nganh, sql)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loader = False Or cmbID_he.SelectedValue <= 0 Or cmbKhoa_hoc.SelectedValue <= 0 Or cmbID_chuyen_nganh.SelectedValue <= 0 Then Exit Sub
            Dim sql As String = "SELECT ID_lop, Ten_lop FROM STU_Lop WHERE ID_he = " & cmbID_he.SelectedValue & " AND Khoa_hoc = " & cmbKhoa_hoc.Text & " AND ID_chuyen_nganh = " & cmbID_chuyen_nganh.SelectedValue
            FillCombo(cmbID_lop, sql)
            Loader = True
            If cmbID_lop.Text.Trim = "" Then
                Me.grcViewDanhSachSinhVien.DataSource = Nothing
                grcViewDiem.DataSource = Nothing
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class