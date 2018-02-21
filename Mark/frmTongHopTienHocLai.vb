Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmTongHopTienHocLai
    Private clsDiem As Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private dt_main As DataTable
    Private mNien_khoa As String = ""
    Private dvMonHoc, dvSinhVien As DataView
    Private ID_he As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mID_chuyen_nganh As Integer = 0
    Private mID_lop As Integer = 0
    Private Ky_thu As Integer
    Private Hoc_ky As Integer = 0
    Private Nam_hoc As String = ""
    Private Sub frmTongHopHocLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TreeViewLop_DSMon.Load_TreeView()
        'Me.TreeViewLop_DSSV.Load_TreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        FormatDataGrid_DSMon(grvMon_hoc)
        FormatDataGrid_DSSV(grvSinh_vien)
    End Sub
    Private Sub FormatDataGrid_DSMon(ByVal grdView As DataGridView)
        SetUpDataGridView(grvMon_hoc)
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .HeaderText = "Mã môn học"
            .DataPropertyName = "Ky_hieu"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Tên môn học"
            .DataPropertyName = "Ten_mon"
            .Visible = True
            .ReadOnly = True
            .Width = 350
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Số học trình"
            .DataPropertyName = "So_hoc_trinh"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "ID"
            .DataPropertyName = "Id_mon"
            .Visible = False
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
        End With
    End Sub

    Private Sub FormatDataGrid_DSSV(ByVal grdView As DataGridView)
        SetUpDataGridView(grvSinh_vien)
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .HeaderText = "Mã SV"
            .DataPropertyName = "Ma_sv"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Họ tên"
            .DataPropertyName = "Ho_ten"
            .Visible = True
            .ReadOnly = True
            .Width = 250
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Ngày sinh"
            .DataPropertyName = "Ngay_sinh"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Format = "dd/MM/yyyy"
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Tên lớp"
            .DataPropertyName = "Ten_lop"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .HeaderText = "Lần học"
            .DataPropertyName = "Lan_hoc"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        Dim col6 As New DataGridViewTextBoxColumn
        With col6
            .HeaderText = "Điểm thi"
            .DataPropertyName = "Diem_thi"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        Dim col7 As New DataGridViewTextBoxColumn
        With col7
            .HeaderText = "TBCMH"
            .DataPropertyName = "TBCHP"
            .Visible = True
            .ReadOnly = True
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col8 As New DataGridViewCheckBoxColumn
        With col8
            .HeaderText = "Chọn"
            .DataPropertyName = "Chon"
            .Visible = True
            .ReadOnly = False
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
            .Add(col6)
            .Add(col7)
            .Add(col8)
        End With
    End Sub

    Private Sub btnTong_hop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTong_hop.Click, cdmDa_nop_tien.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                clsDiem = New Diem_BLL()
                ID_he = TreeViewLop_DSMon.ID_he
                Hoc_ky = cmbHoc_ky.SelectedValue
                Nam_hoc = cmbNam_hoc.Text
                If ID_he > 0 Then
                    If TreeViewLop_DSMon.Khoa_hoc > 0 Then mKhoa_hoc = TreeViewLop_DSMon.Khoa_hoc
                    If TreeViewLop_DSMon.ID_chuyen_nganh > 0 Then mID_chuyen_nganh = TreeViewLop_DSMon.ID_chuyen_nganh
                    If TreeViewLop_DSMon.ID_lop > 0 Then mID_lop = TreeViewLop_DSMon.ID_lop
                    If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And TreeViewLop_DSMon.ID_he > 0 Then
                        dvMonHoc = clsDiem.DanhSachMon_HocLai(Hoc_ky, Nam_hoc, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop).DefaultView
                        dvMonHoc.Sort = "Ten_mon"
                        grvMon_hoc.DataSource = dvMonHoc
                    End If
                    If dvMonHoc.Count > 0 Then
                        lbTongMon.Text = "Tổng số môn: " & dvMonHoc.Count
                    Else
                        lbTongMon.Text = "Tổng số môn: 0 "
                    End If
                Else
                    Thongbao("Bạn hãy chọn hệ", MsgBoxStyle.Information, "Thông báo")
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grvMon_hoc_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvMon_hoc.CurrentCellChanged
        Try
            clsDiem = New Diem_BLL()
            Try
                If grvMon_hoc.CurrentRow Is Nothing Then Exit Sub
                Dim dv As DataView = grvMon_hoc.DataSource
                If dv.Count > 0 Then
                    Dim mId_mon As Integer = dv.Item(grvMon_hoc.CurrentRow.Index)("ID_mon")
                    ID_he = TreeViewLop_DSMon.ID_he
                    If TreeViewLop_DSMon.Khoa_hoc > 0 Then mKhoa_hoc = TreeViewLop_DSMon.Khoa_hoc
                    If TreeViewLop_DSMon.ID_chuyen_nganh > 0 Then mID_chuyen_nganh = TreeViewLop_DSMon.ID_chuyen_nganh
                    If TreeViewLop_DSMon.ID_lop > 0 Then mID_lop = TreeViewLop_DSMon.ID_lop
                    dvSinhVien = clsDiem.DanhSachSinhVien_HocLai(cmbHoc_ky.Text, cmbNam_hoc.Text, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop).DefaultView
                    dvSinhVien.RowFilter = "Id_mon = " & mId_mon
                    grvSinh_vien.DataSource = dvSinhVien
                    If dvSinhVien.Count > 0 Then
                        lbSoSinhVien.Text = "Tổng số sinh viên: " & dvSinhVien.Count
                    Else
                        lbSoSinhVien.Text = "Tổng số sinh viên: 0 "
                    End If
                Else
                    grvSinh_vien.DataSource = Nothing
                    lbSoSinhVien.Text = "Tổng số sinh viên: 0 "
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'clsExcel.ExportFromDataGridViewToExcel(grvSinh_vien)
            Dim dt As DataTable
            dt = grvSinh_vien.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub TreeViewLop_DSMon_TreeNodeSelected_() Handles TreeViewLop_DSMon.TreeNodeSelected_
    '    Try
    '        DS_SinhVien()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim dvSinhVien As DataView = grvSinh_vien.DataSource
            Dim dvMonHoc As DataView = grvMon_hoc.DataSource
            Dim tieu_de, tieu_de2 As String
            Dim Ten_mon As String = dvMonHoc.Item(grvMon_hoc.CurrentRow.Index)("Ten_mon").ToString.ToUpper
            If dvSinhVien Is Nothing Then Exit Sub
            tieu_de = "DANH SÁCH SINH VIÊN HỌC LẠI MÔN " + Ten_mon
            tieu_de2 = " HỌC KỲ " + cmbHoc_ky.Text + " NĂM HỌC " + cmbNam_hoc.Text
            Dim rpt As New rptDanhSachThiLai(dvSinhVien, tieu_de, tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub Check_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_All.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvSinh_vien.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = Check_All.Checked
            Next
            grvSinh_vien.DataSource = dvDanhSachSinhVien
        End If
    End Sub
End Class