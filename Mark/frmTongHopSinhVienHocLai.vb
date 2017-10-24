Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports System.Data.SqlClient

Public Class frmTongHopSinhVienHocLai
    Private clsDiem As Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private dt_main As DataTable

#Region "Form Events"
    Private Sub frmTongHopSinhVienThiLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TreeViewLop_NEW1.Load_TreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        cmbHienThi.SelectedIndex = 0    'Default thi lai
        'SetUpDataGridView(grdViewDanhsachChitiet)
        'SetUpDataGridView(grdViewDanhSachMon)
    End Sub
#End Region
    Private Sub grdViewDanhSachMon_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grdViewDanhSachMon.SelectionChanged
        Try

            Me.Cursor = Cursors.WaitCursor
            Try
                If Not grdViewDanhSachMon.GetFocusedDataRow() Is Nothing Then
                    Dim dv As DataView = grdViewDanhSachMon.DataSource
                    Dim row As DataRow = grdViewDanhSachMon.GetFocusedDataRow()
                    Dim Id_mon As Integer = row("Id_mon").ToString
                    If dv.Count > 0 Then
                        grcDanhSach.DataSource = clsDiem.Load_SinhVien(dt_main, Id_mon).DefaultView
                    Else
                        grcDanhSach.DataSource = Nothing
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Trang_thai As Integer = cmbHienThi.SelectedIndex
            Dim ID_he As Integer = TreeViewLop_NEW1.ID_he
            Dim mKhoa_hoc As Integer = 0
            Dim mID_chuyen_nganh As Integer = 0
            Dim mID_lop As Integer
            If TreeViewLop_NEW1.Khoa_hoc > 0 Then mKhoa_hoc = TreeViewLop_NEW1.Khoa_hoc
            If TreeViewLop_NEW1.ID_chuyen_nganh > 0 Then mID_chuyen_nganh = TreeViewLop_NEW1.ID_chuyen_nganh
            If TreeViewLop_NEW1.ID_lop > 0 Then mID_lop = TreeViewLop_NEW1.ID_lop
            If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And TreeViewLop_NEW1.ID_he > 0 Then
                clsDiem = New Diem_BLL()
                grcHocPhan.DataSource = clsDiem.TongHop_HocLai(cmbHoc_ky.Text, cmbNam_hoc.Text, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop, dt_main).DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Mon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_Mon.ItemClick
        Try
            Dim dv As DataView = grdViewDanhSachMon.DataSource
            Dim dt As DataTable = dv.Table.Copy
            Dim tieu_de1 As String = "DANH SÁCH CÁC MÔN HỌC LẠI HỌC KỲ" + cmbHoc_ky.Text + " NĂM HỌC " + cmbNam_hoc.Text
            Dim tieu_de2 As String = "KHÓA: " & TreeViewLop_NEW1.Khoa_hoc & ", " & TreeViewLop_NEW1.Tieu_de.ToUpper
            Dim frm As New rpt_TongHop_DSHocLai(dt, tieu_de1, tieu_de2)
            frm.Binding()
            frm.DataSource = dt
            PrintXtraReport(frm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_Chitiet_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_Chitiet.ItemClick
        Try
            Dim dv As DataView = grdViewDanhsachChitiet.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                Dim dv_mon As DataView = grdViewDanhSachMon.DataSource
                Dim row As DataRow = grdViewDanhSachMon.GetFocusedDataRow()
                Dim ten_mon As String = row("Ten_mon").ToString
                Dim tieu_de1 As String = "DSSV HỌC LẠI HỌC MÔN " + ten_mon.ToString.ToUpper + " HỌC KỲ" + cmbHoc_ky.Text + " NĂM HỌC " + cmbNam_hoc.Text
                Dim tieu_de2 As String = "KHÓA: " & TreeViewLop_NEW1.Khoa_hoc & ", " & TreeViewLop_NEW1.Tieu_de.ToUpper
                Dim frm As New rpt_TongHop_DSSV_HocLai(dt, tieu_de1, tieu_de2)
                frm.Binding()
                frm.DataSource = dt
                PrintXtraReport(frm)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDSMon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDSMon.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grdViewDanhSachMon)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDSSinhVien_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDSSinhVien.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grdViewDanhsachChitiet)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grcDanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grcDanhSach.Click

    End Sub

    Private Sub btnDanhSachHocBuToanTruong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDanhSachHocBuToanTruong.Click
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@Hoc_ky", cmbHoc_ky.Text)
            param(1) = New SqlParameter("@Nam_hoc", cmbNam_hoc.Text)
            Dim dt As DataTable = ESS.Machine.UDB.SelectTableSP("MARK_HOCBU_Tong_hop", param)
            dtExcel.DataSource = dt
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDataGridViewToExcel(dtExcel)
        Catch ex As Exception

        End Try
    End Sub
End Class