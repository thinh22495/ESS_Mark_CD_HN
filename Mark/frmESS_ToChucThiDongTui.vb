Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_ToChucThiDongTui
    Private mID_thi As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mLan_thi As Integer = 0
    Private mDot_thi As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mTen_mon As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""
    Private Loader As Boolean = False
    Private clsTCThi As New TochucThi_BLL
    Private mdtDanhSachSinhVien As New DataTable
#Region "Form Events"
    Private Sub frmESS_ToChucThiDongTui_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SetUpDataGridView(grdViewDanhSachThi)
            'SetUpDataGridView(grdViewDanhSachThiChon)
            Loader = True
            SetQuyenTruyCap(, btnSave, , )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    'Private Sub frmESS_ToChucThiDongTui_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
    '    e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    'End Sub
#End Region

#Region "Control Events"
    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Try
            If Loader Then
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                mLan_thi = trvPhongThi.Lan_thi
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mTen_mon = trvPhongThi.Ten_mon
                mTen_phong = trvPhongThi.Phong_thi
                If cmbTui_thi.SelectedIndex >= 0 Then
                    'Load danh sach sinh vien chua dong tui
                    Me.grvDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienChuaDongTui(mID_thi, mID_phong_thi).DefaultView
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbTui_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTui_thi.SelectedIndexChanged
        If mID_thi > 0 Then
            'Load dữ liệu về tổ chức thi
            clsTCThi = New TochucThi_BLL(mID_thi)
            If cmbTui_thi.SelectedIndex >= 0 Then   'Load sinh viên theo từng túi
                Me.grvViewDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                txtSo_sv.Text = Me.grdViewDanhSachThiChon.DataSource.Count
            Else
                Me.grvViewDanhSachThiChon.DataSource = Nothing
                txtSo_sv.Text = 0
            End If
        Else
            Me.grvViewDanhSachThiChon.DataSource = Nothing
            txtSo_sv.Text = 0
        End If
    End Sub

    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub
    Private Sub chkAll2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll2.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSachThiChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll2.Checked
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv, ID_sv As Integer
            dv = grdViewDanhSachThi.DataSource
            dvChon = grdViewDanhSachThiChon.DataSource
            If dvChon Is Nothing Then dvChon.Table = dv.Table.Clone
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    Dim dr As DataRow
                    ID_sv = dv(i)("ID_sv")
                    clsTCThi.GanTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1, ID_sv)
                    dr = dvChon.Table.NewRow
                    dr.ItemArray = dv.Item(i).Row.ItemArray
                    dvChon.Table.Rows.Add(dr)
                    dv.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để thêm ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv, ID_sv As Integer
            dv = grdViewDanhSachThi.DataSource
            dvChon = grdViewDanhSachThiChon.DataSource
            If dvChon Is Nothing Then Exit Sub
            For i As Integer = dvChon.Count - 1 To 0 Step -1
                If dvChon.Item(i)("Chon") Then
                    Dim dr As DataRow
                    ID_sv = dvChon(i)("ID_sv")
                    clsTCThi.GanTuiThi(mID_thi, 0, ID_sv)
                    dr = dv.Table.NewRow
                    dr.ItemArray = dvChon.Item(i).Row.ItemArray
                    dr("Tui_so") = 0
                    dr("So_phach") = 0
                    dv.Table.Rows.Add(dr)
                    dvChon.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để xoá ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_tui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbTui_thi.SelectedIndex >= 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá túi thi này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    clsTCThi.XoaTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1)
                    'Load lai danh sach
                    Me.grvViewDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                    txtSo_sv.Text = Me.grdViewDanhSachThiChon.DataSource.Count
                    Thongbao("Đã xoá xong túi thi")
                End If
            Else
                Thongbao("Bạn phải chọn túi để xoá sinh viên ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

#Region "User Functions"
    Private Function CheckValidate() As Boolean
        If txtSo_sv.Text = "" Or txtSo_sv.Text = "0" Then
            Thongbao("Bạn phải bổ sung sinh viên trước")
            Return False
        End If
        If txtSophach_tu.Text = "" Or txtSophach_tu.Text = "0" Then
            Thongbao("Bạn phải xác định số phách bắt đầu")
            txtSophach_tu.Focus()
            Return False
        End If
        Return True
    End Function
#End Region
    Private Sub cmdPrint_DiemSoChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_BLL(mID_thi)
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If
                Dim dv As DataView = grdViewDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy  '= clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1)

                dt.Columns.Add("Lan_thi")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_mon")
                dt.Columns.Add("Ngay_thi")

                If dt.Rows.Count > 0 Then
                    dt.Rows(0).Item("Lan_thi") = mLan_thi
                    dt.Rows(0).Item("Ten_khoa") = ""
                    dt.Rows(0).Item("Hoc_ky") = mHoc_ky
                    dt.Rows(0).Item("Nam_hoc") = mNam_hoc
                    dt.Rows(0).Item("Ten_mon") = mTen_mon
                    dt.Rows(0).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                End If

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra1", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrin_HoiPhach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                Dim dv As DataView = grdViewDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra2", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_Full_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_BLL(mID_thi)
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If
                Dim dv As DataView = grdViewDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy
      
                dt.Columns.Add("Lan_thi")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_mon")
                dt.Columns.Add("Ngay_thi")

                If dt.Rows.Count > 0 Then
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)


                    dt.Rows(0).Item("Lan_thi") = mLan_thi
                    dt.Rows(0).Item("Ten_khoa") = ""
                    dt.Rows(0).Item("Hoc_ky") = mHoc_ky
                    dt.Rows(0).Item("Nam_hoc") = mNam_hoc
                    dt.Rows(0).Item("Ten_mon") = mTen_mon
                    dt.Rows(0).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                End If

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("PhachSinhVien_KiemTra", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If CheckValidate() Then
                If cmbTui_thi.SelectedIndex >= 0 Then
                    If clsTCThi.KiemTraSoPhach(mID_thi, txtSophach_tu.Text, txtSo_sv.Text) Then
                        clsTCThi.LapSoPhach(mID_thi, cmbTui_thi.SelectedIndex + 1, txtSophach_tu.Text)
                        'Load lai danh sach
                        Me.grvViewDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                        txtSo_sv.Text = Me.grdViewDanhSachThiChon.DataSource.Count
                        Thongbao("Đã lập xong số phách ")
                    Else
                        Thongbao("Giải phách này đã bị trùng với túi thi khác, bạn nhập lại số phách bắt đầu bằng số khác !")
                        txtSophach_tu.Focus()
                    End If
                Else
                    Thongbao("Bạn phải chọn túi để đánh số phách ")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    mHoc_ky = trvPhongThi.Hoc_ky
        '    mNam_hoc = trvPhongThi.Nam_hoc
        '    mLan_thi = trvPhongThi.Lan_thi
        '    mID_thi = trvPhongThi.ID_thi
        '    mID_phong_thi = trvPhongThi.ID_phong_thi
        '    If mID_thi > 0 Then
        '        Dim ID_dv As String = gobjUser.ID_dv
        '        Dim dsID_lop As String = ""
        '        'Load dữ liệu về tổ chức thi
        '        clsTCThi = New TochucThi_BLL(mID_thi)
        '        Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
        '        dt.Columns.Add("Tieu_de_ten_bo")
        '        dt.Columns.Add("Tieu_de_Ten_truong")
        '        dt.Columns.Add("Hoc_ky", GetType(Integer))
        '        dt.Columns.Add("Nam_hoc", GetType(String))
        '        dt.Columns.Add("Ten_ca", GetType(String))

        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Phach")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                Dim tieu_de_bao_cao As String = ""
                clsTCThi = New TochucThi_BLL(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                Dim dt_DS As DataTable = grdViewDanhSachThiChon.DataSource.Table
                If mID_phong_thi > 0 Then
                    dt_DS.DefaultView.RowFilter = "ID_phong_thi = " + mID_phong_thi.ToString
                    Dim rpt As New rpt_Phach_ToChucThi(dt_DS, tieu_de_bao_cao, dt)
                    rpt.Binding()
                    rpt.DataSource = dt_DS
                    PrintXtraReport(rpt)
                Else
                    Dim rpt As New rpt_Phach_ToChucThi(dt_DS, tieu_de_bao_cao, dt)
                    rpt.Binding()
                    rpt.DataSource = dt_DS
                    PrintXtraReport(rpt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint2.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_BLL(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Phach_Diem")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnPrint3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint3.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_BLL(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()

                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim dv_DS As DataView = grdViewDanhSachThiChon.DataSource
                'If mID_phong_thi > 0 Then
                'dt_DS.DefaultView.RowFilter = "ID_phong_thi = " + mID_phong_thi.ToString
                Dim rpt As New rpt_DS_ToChucThiPhach(dv_DS.ToTable)
                'rpt.Binding()
                'rpt.DataSource = dv_DS.ToTable
                PrintXtraReport(rpt)
                'Else
                '    Dim rpt As New rpt_Phach_ToChucThi(dt_DS)
                '    rpt.Binding()
                '    rpt.DataSource = dt_DS
                '    PrintXtraReport(rpt)
                'End If
            End If

            'Dim rpt As New rpt_DS_ToChucThiPhach(dt)
            'rpt.DataSource = dt
            'PrintXtraReport(rpt)
            'Dim frmESS_ As New frmESS_ReportView
            'frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Diem")
            'End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        '24/10/2017 tht
        Try
            Dim dv As DataView = grvViewDanhSachThiChon.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim Ten_mon As String = ""
            Dim Ten_lop As String = ","
            Dim Ten_phong As String = ""
            Dim dt_distintsc As New DataTable()
            dt_distintsc = dt.DefaultView.ToTable(True, "Ten_lop")
            For i As Integer = 0 To dt_distintsc.DefaultView.Count - 1
                Ten_lop = Ten_lop & dt_distintsc.Rows(i)("Ten_lop").ToString & ","
            Next
            Ten_lop = Ten_lop.ToString.Substring(1, Ten_lop.Length - 2)
            If dtMonHoc.Rows.Count > 0 Then
                Ten_mon = dtMonHoc.Rows(0)("Ten_mon")
            End If
            Ten_phong = dv.Item(0)("Ten_phong").ToString
            Dim rpt As New rpt_PhieuCham_DiemTN_7c(dt, Ten_mon, Ten_lop, Ten_phong)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        '24/10/2017 tht
        Try
            Dim dv As DataView = grvViewDanhSachThiChon.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim Ten_mon As String = ""
            Dim Ten_phong As String = ""
            If dtMonHoc.Rows.Count > 0 Then
                Ten_mon = dtMonHoc.Rows(0)("Ten_mon")
            End If
            Ten_phong = dv.Item(0)("Ten_phong").ToString
            Dim rpt As New rpt_PhieuCham_DiemTN_7b(dt, Ten_mon, Ten_phong)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        '24/10/2017 tht
        Try
            Dim dv As DataView = grvViewDanhSachThiChon.DataSource
            Dim dt As DataTable = dv.ToTable()
            If Not dt.Columns.Contains("Ghi_chu") Then dt.Columns.Add("Ghi_chu")
            For Each row As DataRow In dt.Rows
                row("Ghi_chu") = IIf(row("Ghi_chu_thi").ToString() <> "", "X", "")
            Next
            dv = dt.DefaultView
            Dim ID_mon As Integer = trvPhongThi.ID_mon
            Dim dtMonHoc As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM MARK_MonHoc WHERE ID_mon=" & ID_mon)
            Dim Ten_mon As String = ""
            Dim Ten_phong As String = ""
            If dtMonHoc.Rows.Count > 0 Then
                Ten_mon = dtMonHoc.Rows(0)("Ten_mon")
            End If
            Ten_phong = dv.Item(0)("Ten_phong").ToString
            Dim rpt As New rpt_PhieuCham_DiemTN_7a(dt, Ten_mon, Ten_phong)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            Dim dv As DataView = grvViewDanhSachThiChon.DataSource
            dv.RowFilter = "Chon = True"
            If dv.Count = 0 Then
                Thongbao("Bạn chưa chọn sinh viên nào !")
            ElseIf dv.Count > 1 Then
                Thongbao("Bạn chỉ được chọn từng sinh viên một !")
            Else
                Dim ID_sv As Integer = CInt(dv.Item(0)("ID_sv").ToString)
                Dim dtPlus As DataTable = ESS.Machine.UDB.SelectTable("Select * FROM STU_HoSoSinhVien WHERE ID_sv=" & ID_sv)
                Dim dt As DataTable
                dt = dv.ToTable
                dt.Columns.Add("Dia_chi", GetType(String))
                Dim row As DataRow = dt.NewRow
                row("Dia_chi") = dtPlus.Rows(0)("Dia_chi_tt").ToString
                dt.Rows.Add(row)
                Dim rpt As New rpt_PhieuCham_DiemTN_7d(dt)
                PrintXtraReport(rpt)
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class