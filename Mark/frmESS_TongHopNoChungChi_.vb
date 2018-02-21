Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_TongHopNoChungChi_
    Private clsDiem As New Diem_BLL
    Private clsChungChi As LoaiChungChiDanhSachMon_BLL
    Private dsID_lop As String = "0"
    Private mID_he As Integer = 0

#Region "Form Events"
    Private Sub frmESS_TongHopNoChungChi__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewChungChiNganh11)
        SetUpDataGridView(grdViewChungChiNganh12)
        LoadComboBox()
        Me.trvLop1.Load_TreeView()
        SetQuyenTruyCap(, cmdTongHop, btnThem1, btnXoa1)
    End Sub
    Private Sub frmESS_TongHopNoChungChi__Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Function"
    Private Sub LoadComboBox()
        Try
            Dim cls As New DanhMuc_BLL
            Dim dt As DataTable = cls.DanhMuc_Load("MARK_LoaiChungChi", "ID_chung_chi", "Loai_chung_chi")
            FillCombo(cmbID_chung_chi1, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Control Events"
    Private Sub trvLop1_TreeNodeSelected_() Handles trvLop1.TreeNodeSelected_
        Try
            If Not trvLop1.ID_lop_list Is Nothing Then
                dsID_lop = trvLop1.ID_lop_list
                mID_he = trvLop1.ID_he
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewChungChiNganh12.DataSource Is Nothing Then
                'Dim clsExcel As New ExportToExcel
                'Dim Tieu_de As String = ""
                'clsExcel.ExportFromDataGridViewToExcel(grdViewChungChiNganh12)
                Dim dt As DataTable
                dt = grdViewChungChiNganh12.DataSource
                ExportToExcel(dt.DefaultView)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint.Click
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewChungChiNganh12.DataSource Is Nothing Then
        '        Dim dv As DataView = grdViewChungChiNganh12.DataSource
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4 As String
        '        Tieu_de1 = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        '        Tieu_de2 = "Độc lập - Tự do - Hạnh phúc"
        '        Tieu_de3 = "DANH SÁCH SINH VIÊN ĐƯỢC CẤP CHỨNG CHỈ " & cmbID_chung_chi1.Text.ToUpper
        '        Tieu_de4 = trvLop1.Tieu_de.ToUpper
        '        TaoBaoCao_PhanThucTap(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4)

        '        C1Report1.DataSource.Recordset = dv.Table
        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog(C1Report1)
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbID_chung_chi1.Text.Trim = "" Or cmbLan_xet1.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại chứng chỉ và Lần xét !", MsgBoxStyle.Information)
            Else
                Me.Cursor = Cursors.WaitCursor
                clsChungChi = New LoaiChungChiDanhSachMon_BLL(dsID_lop)

                Dim ID_dt As Integer = trvLop1.ID_dt_list
                Dim dt As DataTable = clsChungChi.DSSV_ChuaXetTheoLanXet(cmbID_chung_chi1.SelectedValue)
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, ID_dt, dt)
                Dim dv As DataView = clsDiem.TongHopDiemMonChungChi(ID_dt, cmbID_chung_chi1.SelectedValue, rGDTC.Checked).DefaultView

                grdViewChungChiNganh11.DataSource = dv
                labSo_sv.Text = dv.Count
                grdViewChungChiNganh12.DataSource = clsChungChi.DSSV_DaXetTheoLanXet(cmbID_chung_chi1.SelectedValue, cmbLan_xet1.Text).DefaultView
                'End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optAllNganh11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllNganh11.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewChungChiNganh11.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAllNganh11.Checked
            Next
            grdViewChungChiNganh11.DataSource = dvDanhSachSinhVien
        End If
    End Sub

    Private Sub optAllNganh12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllNganh12.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewChungChiNganh12.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAllNganh12.Checked
            Next
            grdViewChungChiNganh12.DataSource = dvDanhSachSinhVien
        End If
    End Sub

    Private Sub btnThem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem1.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbID_chung_chi1.Text.Trim = "" Or cmbLan_xet1.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại chứng chỉ và Lần xét !", MsgBoxStyle.Information)
            Else
                Dim dv As DataView = grdViewChungChiNganh11.DataSource
                Dim obj As LoaiChungChiDanhSachMon
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        obj = New LoaiChungChiDanhSachMon
                        obj.ID_sv = dv.Item(i)("ID_sv")
                        obj.ID_dt = trvLop1.ID_dt_list
                        obj.ID_chung_chi = cmbID_chung_chi1.SelectedValue
                        obj.Lan_xet = cmbLan_xet1.Text
                        obj.ID_xep_loai = dv.Item(i)("ID_xep_loai")
                        obj.TBCHT = dv.Item(i)("TBCHT")
                        clsChungChi.Insert_ChungChiTheoSinhVien(obj)
                    End If
                Next
                cmbID_chung_chi1_SelectedIndexChanged(sender, e)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnXoa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa1.Click
        Try
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            Dim obj As LoaiChungChiDanhSachMon
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") = True Then
                    obj = New LoaiChungChiDanhSachMon
                    obj.ID_sv = dv.Item(i)("ID_sv")
                    obj.ID_dt = dv.Item(i)("ID_dt")
                    obj.ID_chung_chi = dv.Item(i)("ID_chung_chi")
                    obj.Lan_xet = dv.Item(i)("Lan_xet")
                    clsChungChi.Delete_ChungChiTheoSinhVien(obj)
                End If
            Next
            cmbID_chung_chi1_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_chung_chi1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chung_chi1.SelectedIndexChanged, cmbLan_xet1.SelectedIndexChanged
        Try
            If cmbID_chung_chi1.Text.Trim <> "" And cmbLan_xet1.Text.Trim <> "" And trvLop1.ID_chuyen_nganh > 0 Then
                Dim ID_dt As Integer = trvLop1.ID_dt_list
                clsChungChi = New LoaiChungChiDanhSachMon_BLL(dsID_lop)
                Dim dt As DataTable = clsChungChi.DSSV_ChuaXetTheoLanXet(cmbID_chung_chi1.SelectedValue)
                clsDiem = New Diem_BLL(mid_he, gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, ID_dt, dt)
                Dim dv As DataView = clsDiem.TongHopDiemMonChungChi(ID_dt, cmbID_chung_chi1.SelectedValue, rGDTC.Checked).DefaultView

                grdViewChungChiNganh11.DataSource = dv
                labSo_sv.Text = dv.Count
                grdViewChungChiNganh12.DataSource = clsChungChi.DSSV_DaXetTheoLanXet(cmbID_chung_chi1.SelectedValue, cmbLan_xet1.Text).DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


End Class