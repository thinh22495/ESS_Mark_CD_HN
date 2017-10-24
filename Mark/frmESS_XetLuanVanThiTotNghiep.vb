Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_XetLuanVanThiTotNghiep
    Dim dt_ds_lv, dt_ds_thi As DataTable
    Dim clsXet As DanhSachLuanVanThiNoTotNghiep_BLL
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0

#Region "Form Events"
    Private Sub frmESS_XetLuanVan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TrvLop_ChuanHoa.Load_TreeView()
        'SetUpDataGridView(grdViewLuanVan)
        Me.TrvLop_ChuanHoa_ThiTN.Load_TreeView()
        'SetUpDataGridView(grdViewThiTotNghiep)
        Me.TrvLop_ChuanHoa_NoThi.Load_TreeView()
        'SetUpDataGridView(grdViewNoThiTotNghiep)

        SetQuyenTruyCap(, btnxet, btnLV, btnThiTN)
    End Sub

    Private Sub frmESS_XetLuanVan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TrvLop_ChuanHoa_TreeNodeSelected_() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
                If cmbLan_xet.Text.Trim = "" Then Exit Sub
                mID_he = TrvLop_ChuanHoa.ID_he
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(TrvLop_ChuanHoa.ID_lop_list)
                dt_ds_lv = objDanhSach.Danh_sach_sinh_vien
                'Load danh sach sinh thuoc dien da xet lam luan van
                If TrvLop_ChuanHoa.ID_chuyen_nganh > 0 Then mID_dt = TrvLop_ChuanHoa.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, TrvLop_ChuanHoa.ID_lop_list, mID_dt, dt_ds_lv)
                Dim dt As DataTable = clsXet.Load_DanhSach_LuanVan(cmbLan_xet.Text)
                grcViewLuanVan.DataSource = dt.DefaultView
                labSo_sv.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TrvLop_ChuanHoa_ThiTN_Select() Handles TrvLop_ChuanHoa_ThiTN.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa_ThiTN.ID_lop_list Is Nothing Then
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(TrvLop_ChuanHoa_ThiTN.ID_lop_list)
                dt_ds_thi = objDanhSach.Danh_sach_sinh_vien

                ' Load danh sach sinh thuoc dien da xet thi TN
                If TrvLop_ChuanHoa_ThiTN.ID_chuyen_nganh > 0 Then mID_dt = TrvLop_ChuanHoa_ThiTN.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, TrvLop_ChuanHoa_ThiTN.ID_lop_list, mID_dt, dt_ds_thi)
                Dim dt As DataTable = clsXet.Load_DanhSach_ThiTotNghiep(cmbLan_xet.Text)
                grcThiTotNghiep.DataSource = dt.DefaultView
                lblSV_Thi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TrvLop_ChuanHoa_NoThi_Select() Handles TrvLop_ChuanHoa_NoThi.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa_NoThi.ID_lop_list Is Nothing Then
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(TrvLop_ChuanHoa_NoThi.ID_lop_list)
                Dim mdtSinhVien_NoTN As DataTable = objDanhSach.Danh_sach_sinh_vien

                'Load danh sach sinh thuoc dien no tot nghiep
                If TrvLop_ChuanHoa_NoThi.ID_chuyen_nganh > 0 Then mID_dt = TrvLop_ChuanHoa_NoThi.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, TrvLop_ChuanHoa_NoThi.ID_lop_list, mID_dt, mdtSinhVien_NoTN)
                Dim dt As DataTable = clsXet.Load_DanhSach_NoTotNghiep
                grcDanhSach.DataSource = dt.DefaultView
                lblNoThi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub txtTBCHT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTBCHT.KeyPress
        ErrorProvider1.Dispose()
        e.Handled = HandleNumberKey(e.KeyChar, ".")
    End Sub
#End Region

#Region "Function"


#End Region

    Private Sub PrinLuanVan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView = grdViewLuanVan.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy

                dt.Columns.Add("Tieu_de")


                dt.Rows(0).Item("Tieu_de") = TrvLop_ChuanHoa.Tieu_de

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS LuanVan", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrinThiTotNghiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView = grdViewThiTotNghiep.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de")
                dt.Rows(0).Item("Tieu_de") = TrvLop_ChuanHoa.Tieu_de

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS ThiTotNghiep", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrinNoThiTotNghiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView = grdViewNoThiTotNghiep.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy

                dt.Columns.Add("Tieu_de")


                dt.Rows(0).Item("Tieu_de") = TrvLop_ChuanHoa.Tieu_de

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS NoTotNghiep", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Select Case sender.SelectedIndex.ToString
            Case 0
                btnThiTN.Visible = True
                btnLV.Visible = False
            Case 1
                btnThiTN.Visible = False
                btnLV.Visible = True
        End Select
    End Sub
    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxet.Click
        Try
            If txtTBCHT.Text.Trim = "" Then
                Thongbao("Hãy nhập điểm tích luỹ cần xét !", MsgBoxStyle.Information)
                Call SetErrPro(txtTBCHT, ErrorProvider1, "Nhập điểm tích luỹ cần xét !")
                txtTBCHT.Focus()
            ElseIf IsNumeric(txtTBCHT.Text.Trim) Then
                If TrvLop_ChuanHoa.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If
                Dim dt_luanvan, dt_Thi, dt_NoThi As DataTable
                clsXet.XetLuanVan(mID_he, txtTBCHT.Text.Trim, cmbLan_xet.Text, dt_luanvan, dt_Thi, dt_NoThi)
                grcViewLuanVan.DataSource = dt_luanvan.DefaultView
                labSo_sv.Text = dt_luanvan.DefaultView.Count

                grcThiTotNghiep.DataSource = dt_Thi.DefaultView
                lblSV_Thi.Text = dt_Thi.Rows.Count
                grcDanhSach.DataSource = dt_NoThi.DefaultView
                lblNoThi.Text = dt_NoThi.Rows.Count
            End If
            labSo_sv.Text = grdViewLuanVan.DataSource.Count
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXoa_TCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThiTN.Click
        Try
            'Xoá danh sách luận văn rồi Insert vào danh sách Thi tốt nghiệp
            Dim dv As DataView = grdViewLuanVan.DataSource
            If dv.Count > 0 Then
                clsXet.ChuyenThiTotNghiep(dv, cmbLan_xet.Text)
                'Load danh sach sinh thuoc dien da xet lam luan van
                clsXet = New DanhSachLuanVanThiNoTotNghiep_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, TrvLop_ChuanHoa.ID_lop_list, 0, dt_ds_lv)
                Dim dt As DataTable = clsXet.Load_DanhSach_LuanVan(cmbLan_xet.Text)
                grcViewLuanVan.DataSource = dt.DefaultView
                labSo_sv.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub btnLV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLV.Click
        Try
            'Xoá danh sách Thi tốt nghiệp rồi Insert vào danh sách luận văn
            Dim dv As DataView = grdViewThiTotNghiep.DataSource
            If dv.Count > 0 Then
                clsXet.ChuyenLamLuanVan(dv, cmbLan_xet.Text)
                'Load danh sach sinh thuoc dien da xet thi TN
                clsXet = New DanhSachLuanVanThiNoTotNghiep_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, TrvLop_ChuanHoa_ThiTN.ID_lop_list, 0, dt_ds_thi)
                Dim dt As DataTable = clsXet.Load_DanhSach_ThiTotNghiep(cmbLan_xet.Text)
                grcThiTotNghiep.DataSource = dt.DefaultView
                lblSV_Thi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            GetReportHeader()
            Dim dv As DataView
            Dim Tieu_de1, Tieu_de2 As String
            Dim Thi As Integer = 0
            Select Case TabControl1.SelectedIndex.ToString
                Case 0
                    If Not grdViewLuanVan.DataSource Is Nothing Then
                        dv = grdViewLuanVan.DataSource
                        If dv.Count = 0 Then Exit Sub
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                    Tieu_de1 = "DANH SÁCH SINH VIÊN LÀM KHÓA LUẬN"
                    Tieu_de2 = TrvLop_ChuanHoa.Tieu_de.ToUpper
                Case 1
                    Thi = 1
                    If Not grdViewThiTotNghiep.DataSource Is Nothing Then
                        dv = grdViewThiTotNghiep.DataSource
                        If dv.Count = 0 Then Exit Sub
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                    Tieu_de1 = "DANH SÁCH SINH VIÊN ĐỦ ĐIỀU KIỆN THI TỐT NGHIỆP"
                    Tieu_de2 = TrvLop_ChuanHoa_ThiTN.Tieu_de.ToUpper
                Case 2
                    Thi = 2
                    If Not grdViewNoThiTotNghiep.DataSource Is Nothing Then
                        dv = grdViewNoThiTotNghiep.DataSource
                        If dv.Count = 0 Then Exit Sub
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                    Dim Id_chuyen_nganh As Integer = TrvLop_ChuanHoa_NoThi.ID_chuyen_nganh
                    Tieu_de1 = "DANH SÁCH SINH VIÊN KHÔNG ĐỦ ĐIỀU KIỆN THI TỐT NGHIỆP"

                    Tieu_de2 = TrvLop_ChuanHoa_NoThi.Tieu_de.ToUpper
            End Select
            If Thi < 2 Then
                Dim rpt As New rptMark_DanhSachSinhVien_ThiTotNghiep(dv, Thi, Tieu_de1, Tieu_de2)
                PrintXtraReport(rpt)
            Else
                Dim rpt As New rptMark_DanhSachSinhVien_NoThiTotNghiep(dv, Thi, Tieu_de1, Tieu_de2)
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdChuyenLanXet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChuyenLanXet.Click
        If cmbLan_xet_chuyen.Text.Trim = "" Then
            Thongbao("Hãy chọn lần xét !")
            Exit Sub
        End If
        Dim dv As DataView
        Dim SQL As String
        Dim clsDM As New DanhMuc_BLL
        If Thongbao("Bạn có muốn chuyển sinh viên đã chọn từ kết quả xét này sang lần " & cmbLan_xet_chuyen.Text & " không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Select Case TabControl1.SelectedIndex.ToString
                Case 0
                    If Not grdViewLuanVan.DataSource Is Nothing Then
                        dv = grdViewLuanVan.DataSource
                        For i As Integer = 0 To dv.Count - 1
                            If dv.Item(i)("Chon1") Then
                                SQL = "UPDATE Mark_DanhSachLuanVan SET Lan_xet=" & cmbLan_xet_chuyen.Text & " WHERE ID_SV=" & dv.Item(i)("ID_SV")
                                clsDM.Execute(SQL)
                            End If
                        Next
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 1
                    If Not grdViewThiTotNghiep.DataSource Is Nothing Then
                        dv = grdViewThiTotNghiep.DataSource
                        For i As Integer = 0 To dv.Count - 1
                            If dv.Item(i)("Chon2") Then
                                SQL = "UPDATE Mark_DanhSachThiTotNghiep SET Lan_xet=" & cmbLan_xet_chuyen.Text & " WHERE ID_SV=" & dv.Item(i)("ID_SV")
                                clsDM.Execute(SQL)
                            End If
                        Next
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select

            Dim dt As DataTable = clsXet.Load_DanhSach_ThiTotNghiep(cmbLan_xet.Text)
            grcDanhSach.DataSource = dt.DefaultView
            lblSV_Thi.Text = dt.DefaultView.Count
        End If
    End Sub

    Private Sub cmbLan_xet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_xet.SelectedIndexChanged

    End Sub
End Class