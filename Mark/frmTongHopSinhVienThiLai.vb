Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmTongHopSinhVienThiLai
    Private clsDiem As DNU_Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private dt_main As DataTable

#Region "Form Events"
    Private Sub frmTongHopSinhVienThiLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TreeViewLop_NEW1.Load_TreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        cmbLanHoc.SelectedIndex = 0    'Default thi lai
        SetUpDataGridView(grdViewDanhsachChitiet)
        SetUpDataGridView(grdViewDanhSachMon)
    End Sub

    Private Sub frmTongHopSinhVienThiLai_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    'Private Sub TreeViewLop_NEW1_Select() Handles TreeViewLop_NEW1.TreeNodeSelected_
    '    Try
    '        If Not TreeViewLop_NEW1.ID_lop_list Is Nothing Then
    '            'Load danh sách sinh viên
    '            Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
    '            mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
    '        End If
    '    Catch ex As Exception
    '        Thongbao(ex.Message)
    '    End Try
    'End Sub
    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Trang_thai As Integer = cmbLanHoc.SelectedIndex
            Dim ID_he As Integer = TreeViewLop_NEW1.ID_he
            Dim mKhoa_hoc As Integer = 0
            Dim mID_chuyen_nganh As Integer = 0
            Dim mID_lop As Integer
            Dim Lan_hoc As Integer = CType(cmbLanHoc.Text, Integer)
            If TreeViewLop_NEW1.Khoa_hoc > 0 Then mKhoa_hoc = TreeViewLop_NEW1.Khoa_hoc
            If TreeViewLop_NEW1.ID_chuyen_nganh > 0 Then mID_chuyen_nganh = TreeViewLop_NEW1.ID_chuyen_nganh
            If TreeViewLop_NEW1.ID_lop > 0 Then mID_lop = TreeViewLop_NEW1.ID_lop
            If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And TreeViewLop_NEW1.ID_he > 0 Then
                clsDiem = New DNU_Diem_BLL()
                grdViewDanhSachMon.DataSource = clsDiem.TongHop_ThiLai(Lan_hoc, cmbHoc_ky.Text, cmbNam_hoc.Text, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop, dt_main).DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExcel_Mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel_Mon.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            clsExcel.ExportFromDataGridViewToExcel(grdViewDanhSachMon)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExcel_Chitiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel_Chitiet.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            clsExcel.ExportFromDataGridViewToExcel(grdViewDanhsachChitiet)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub grdViewDanhSachMon_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewDanhSachMon.CurrentCellChanged
        Try
            If grdViewDanhSachMon.CurrentRow Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = grdViewDanhSachMon.DataSource
                If dv.Count > 0 Then
                    grdViewDanhsachChitiet.DataSource = clsDiem.Load_SinhVien_ThiLai(dt_main, dv.Item(grdViewDanhSachMon.CurrentRow.Index)("ID_mon")).DefaultView
                Else
                    grdViewDanhsachChitiet.DataSource = Nothing
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdPrint_Mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_Mon.Click
        Try
            Dim dv As DataView = grdViewDanhSachMon.DataSource
            Dim dt As DataTable = dv.Table.Copy
            Dim tieu_de1 As String = "DANH SÁCH CÁC MÔN THI LẠI HỌC KỲ" + cmbHoc_ky.Text + " NĂM HỌC " + cmbNam_hoc.Text
            Dim tieu_de2 As String = TreeViewLop_NEW1.Tieu_de.ToUpper
            Dim frm As New rpt_TongHop_DSHocLai(dt, tieu_de1, tieu_de2)
            frm.Binding()
            frm.DataSource = dt
            PrintXtraReport(frm)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdPrint_Chitiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_Chitiet.Click
        Try
            Dim dv As DataView = grdViewDanhsachChitiet.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                Dim dv_mon As DataView = grdViewDanhSachMon.DataSource
                Dim tieu_de1 As String = "DSSV THI LẠI THI MÔN " + dv_mon.Item(grdViewDanhSachMon.CurrentRow.Index)("Ten_mon").ToString.ToUpper + " HỌC KỲ" + cmbHoc_ky.Text + " NĂM HỌC " + cmbNam_hoc.Text
                Dim tieu_de2 As String = TreeViewLop_NEW1.Tieu_de.ToUpper
                Dim frm As New rpt_TongHop_DSSV_HocLai(dt, tieu_de1, tieu_de2)
                frm.Binding()
                frm.DataSource = dt
                PrintXtraReport(frm)
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class