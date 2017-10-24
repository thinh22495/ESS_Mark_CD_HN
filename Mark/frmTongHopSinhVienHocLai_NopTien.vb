Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmTongHopSinhVienHocLai_NopTien
    Private clsDiem As Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private dt_main As DataTable
    Private ID_he As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mID_chuyen_nganh As Integer = 0
    Private mID_lop As Integer = 0
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
                        grcDanhSach.DataSource = clsDiem.Load_SinhVien_Tien(dt_main, Id_mon).DefaultView
                        Load_DS_DaNopTien()
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
                grcHocPhan.DataSource = clsDiem.TongHop_HocLai_Tien(cmbHoc_ky.Text, cmbNam_hoc.Text, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop, dt_main).DefaultView
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

    Private Sub cbChon_tat_ca_Giay_to_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChon_tat_ca_Giay_to.CheckedChanged
        Dim dvSV As DataView
        dvSV = grdViewDanhsachChitiet.DataSource
        If Not dvSV Is Nothing Then
            For i As Integer = 0 To dvSV.Count - 1
                dvSV.Item(i)("Chon") = cbChon_tat_ca_Giay_to.Checked
            Next
        End If
    End Sub

    Private Sub btnDa_nop_tien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDa_nop_tien.Click
        Dim objTienThiLaiHocLai_BLL As New TienHocLaiThiLai_BLL
        Dim ID_mon As Integer = 0
        Dim dvMon As DataView = grdViewDanhSachMon.DataSource
        If dvMon.Count < 0 Then Exit Sub
        ID_mon = grdViewDanhSachMon.GetRowCellValue(grdViewDanhSachMon.FocusedRowHandle, "ID_mon")
        Dim objTienThiLaiHocLai As New TienHocLaiThiLai
        Dim dvSV As New DataView
        dvSV = grdViewDanhsachChitiet.DataSource
        If dvSV.Count > 0 Then
            For i As Integer = 0 To dvSV.Count - 1
                objTienThiLaiHocLai.ID_mon = ID_mon
                objTienThiLaiHocLai.ID_sv = dvSV.Item(i).Item("ID_sv")
                objTienThiLaiHocLai.Lan_hoc = dvSV.Item(i).Item("Lan_hoc")
                objTienThiLaiHocLai.Hoc_ky = CType(cmbHoc_ky.Text, Integer)
                objTienThiLaiHocLai.Nam_hoc = cmbNam_hoc.Text
                objTienThiLaiHocLai.Trang_thai = 1
                objTienThiLaiHocLai.Da_nop_tien = 0
                objTienThiLaiHocLai.Ghi_chu = dvSV.Item(i).Item("Ghi_chu")
                objTienThiLaiHocLai_BLL.Insert_TienHocLaiThiLai(objTienThiLaiHocLai)
                If dvSV.Item(i).Item("Chon") Then
                    If objTienThiLaiHocLai_BLL.CheckExist_HocLaiThiLai(ID_mon, dvSV.Item(i).Item("ID_sv"), dvSV.Item(i).Item("Lan_hoc")) Then
                        objTienThiLaiHocLai.Da_nop_tien = dvSV.Item(i).Item("Chon")
                        objTienThiLaiHocLai_BLL.Update_TienHocLaiThiLai(objTienThiLaiHocLai)
                    End If
                End If
            Next
        End If
        Thongbao("Bạn đã nộp tiền thành công !")
        Call grdViewDanhSachMon_SelectionChanged(Nothing, Nothing)
    End Sub
    Private Sub Load_DS_DaNopTien()
        Try
            Dim objTienThiLaiHocLai_BLL As New TienHocLaiThiLai_BLL
            Dim dv As DataView = grdViewDanhsachChitiet.DataSource
            Dim mID_mon As Integer = grdViewDanhSachMon.GetRowCellValue(grdViewDanhSachMon.FocusedRowHandle, "ID_mon")
            ID_he = TreeViewLop_NEW1.ID_he
            If TreeViewLop_NEW1.Khoa_hoc > 0 Then mKhoa_hoc = TreeViewLop_NEW1.Khoa_hoc
            If TreeViewLop_NEW1.ID_chuyen_nganh > 0 Then mID_chuyen_nganh = TreeViewLop_NEW1.ID_chuyen_nganh
            If TreeViewLop_NEW1.ID_lop > 0 Then mID_lop = TreeViewLop_NEW1.ID_lop
            Dim dvDaNop As DataView = objTienThiLaiHocLai_BLL.DanhSachSinhVien_DaNop(cmbHoc_ky.Text, cmbNam_hoc.Text, ID_he, mKhoa_hoc, mID_chuyen_nganh, mID_lop).DefaultView
            dvDaNop.RowFilter = "ID_mon = " & mID_mon
            grcDaNopTien.DataSource = dvDaNop
            'dvDaNop.RowFilter = "1=1"
            dvDaNop.Sort = "Ten_lop,Ho_ten"
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class