Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_XetLenLop
    Private clsDiem As Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private dt_main As DataTable
    Private mNien_khoa As String = ""
    Private dvMonHoc, dvSinhVien As DataView
    Private ID_he As Integer = -1
    Private mKhoa_hoc As Integer = 0
    Private mID_chuyen_nganh As Integer = 0
    Private mID_lop As Integer = -1
    Private Ky_thu As Integer
    Private Hoc_ky As Integer = -1
    Private Nam_hoc As String = ""

    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"

    Private Sub frmTongHopHocLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        Me.TrvLop.Load_TreeView()
    End Sub
    Private Sub TrvLop_TreeNodeSelected_() Handles TrvLop.TreeNodeSelected_
        Try
            If Not TrvLop.ID_lop_list Is Nothing Then
                dsID_lop = TrvLop.ID_lop_list
                dsID_dt = TrvLop.ID_dt_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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
            .Width = 200
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
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .HeaderText = "TBCHT"
            .DataPropertyName = "TBCHT"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col6 As New DataGridViewTextBoxColumn
        With col6
            .HeaderText = "Số trình nợ"
            .DataPropertyName = "So_trinh_no"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col7 As New DataGridViewTextBoxColumn
        With col7
            .HeaderText = "Tổng tiết nợ"
            .DataPropertyName = "Tong_tiet"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col8 As New DataGridViewTextBoxColumn
        With col8
            .HeaderText = "Tên môn nợ"
            .DataPropertyName = "Ten_mon_no"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Dim col9 As New DataGridViewTextBoxColumn
        With col9
            .HeaderText = "Số môn nợ"
            .DataPropertyName = "So_mon_no"
            .Visible = True
            .ReadOnly = True
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
            .Add(col6)
            .Add(col9)
            .Add(col7)
            .Add(col8)
        End With
    End Sub


    Private Sub btnTong_hop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTong_hop.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim ID_dv As String = gobjUser.ID_dv
            Dim ID_he As Integer = TrvLop.ID_he
            If TrvLop.Khoa_hoc > 0 Then
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    clsDiem = New Diem_BLL(ID_he, ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, dsID_dt, mdtDanhSachSinhVien)
                    Dim dt As DataTable = clsDiem.XetLenLop()
                    Dim dv As DataView = dt.DefaultView
                    dv.RowFilter = "Ten_mon_no <> '' "
                    dv.Sort = "Tong_tiet DESC"
                    grvSinh_vien.DataSource = dv
                    FormatDataGrid_DSSV(grvSinh_vien)
                    'lblSo_sv.Text = dt.Rows.Count
                Else
                    grvSinh_vien.DataSource = Nothing
                End If
            Else
                Thongbao("Bạn phải chọn đến khóa đào tạo !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            clsExcel.ExportFromDataGridViewToExcel(grvSinh_vien)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim dvSinhVien As DataView = grvSinh_vien.DataSource
            Dim tieu_de, tieu_de2 As String
            'Dim Ten_mon As String = dvMonHoc.Item(grvSinh_vien.CurrentRow.Index)("Ten_mon").ToString.ToUpper
            If dvSinhVien Is Nothing Then Exit Sub
            tieu_de = "TỔNG HỢP SỐ MÔN NỢ CỦA SINH VIÊN "
            tieu_de2 = "KHÓA: " & TrvLop.Khoa_hoc & ", " & TrvLop.Tieu_de.ToString.ToUpper
            Dim rpt As New rptDanhSach_XetLenLop(dvSinhVien, tieu_de, tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

   
End Class