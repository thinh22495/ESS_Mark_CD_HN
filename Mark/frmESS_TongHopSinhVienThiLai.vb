Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_TongHopSinhVienThiLai
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private clsDiem As Diem_BLL
    Private mdtDanhSachSinhVien As New DataTable

#Region "Form Events"
    Private Sub frmESS_TongHopSinhVienThiLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TrvLop_ChuanHoa.Load_TreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        cmbHienThi.SelectedIndex = 0    'Default thi lai
        SetUpDataGridView(grdViewDanhsachChitiet)
        SetUpDataGridView(grdViewDanhSachMon)
    End Sub

    Private Sub frmESS_TongHopSinhVienThiLai_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
    Private Sub cmdExcel_Mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDanhSachMon)
            Dim dt As DataTable
            dt = grdViewDanhSachMon.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExcel_Chitiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDanhsachChitiet)
            Dim dt As DataTable
            dt = grdViewDanhsachChitiet.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub grdViewDanhSachMon_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewDanhSachMon.CurrentCellChanged
        Try
            If grdViewDanhSachMon.CurrentRow Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim dv As DataView = grdViewDanhSachMon.DataSource
                If dv.Count > 0 Then
                    grdViewDanhsachChitiet.DataSource = clsDiem.DanhSachThiLaiHocLai(dv.Item(grdViewDanhSachMon.CurrentRow.Index)("ID_mon"), cmbHienThi.SelectedIndex).DefaultView
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
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Trang_thai As Integer = cmbHienThi.SelectedIndex
        Dim ID_he As Integer = TrvLop_ChuanHoa.ID_he
        If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And TrvLop_ChuanHoa.ID_he > 0 And mdtDanhSachSinhVien.Rows.Count > 0 Then
            clsDiem = New Diem_BLL(ID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, cmbHoc_ky.SelectedIndex + 1, cmbNam_hoc.Text, dsID_lop, dsID_dt, mdtDanhSachSinhVien)
            grdViewDanhSachMon.DataSource = clsDiem.TongHopHocPhanThiLaiHocLai(cmbHienThi.SelectedIndex).DefaultView
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim dv As DataView = grdViewDanhSachMon.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de")
                dt.Columns.Add("ThiHoc_Lai")
                Dim ThiHoc_Lai As String = ""
                If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại"
                If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại"
                If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
                If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"

                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de") = TrvLop_ChuanHoa.Tieu_de.ToUpper
                    dt.Rows(i).Item("ThiHoc_Lai") = ThiHoc_Lai.ToUpper
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DanhSachThiHocLai_Mon", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            Dim dv As DataView = grdViewDanhsachChitiet.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy

                dt.Columns.Add("Tieu_de")
                dt.Columns.Add("ThiHoc_Lai")
                Dim ThiHoc_Lai As String = ""
                Dim dv_mon As DataView = grdViewDanhSachMon.DataSource
                If dv_mon.Count <= 0 Then Exit Sub
                If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại môn: " & dv_mon.Item(grdViewDanhSachMon.CurrentRow.Index)("Ten_mon").ToString
                If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại môn: " & dv_mon.Item(grdViewDanhSachMon.CurrentRow.Index)("Ten_mon").ToString
                If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
                If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"

                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de") = TrvLop_ChuanHoa.Tieu_de.ToUpper
                    dt.Rows(i).Item("ThiHoc_Lai") = ThiHoc_Lai.ToUpper
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DanhSachThiHocLai", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'Dim Tieu_de As String = ""
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDanhsachChitiet, Nothing)
            Dim dt As DataTable
            dt = grdViewDanhsachChitiet.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            'Dim clsExcel As New ExportToExcel
            'Dim Tieu_de As String = ""
            'clsExcel.ExportFromDataGridViewToExcel(grdViewDanhSachMon, Nothing)
            Dim dt As DataTable
            dt = grdViewDanhSachMon.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class