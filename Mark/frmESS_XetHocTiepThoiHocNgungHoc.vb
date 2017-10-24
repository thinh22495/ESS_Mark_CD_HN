Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Machine
Public Class frmESS_XetHocTiepThoiHocNgungHoc
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private mID_dt As Integer = 0
    Private clsDSXetLenLop As DanhSachXetLenLop_BLL
    Private mdtHocTiep, mdtNgungHoc, mdtThoiHoc As DataTable

#Region "Form Events"
    Private Sub frmESS_XetHocTiepThoiHocNgungHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop1.Load_TreeView()
        SetUpDataGridView(grdViewMain)
        SetUpDataGridView(grdViewHocTiep)
        SetUpDataGridView(grdViewNgungHoc)
        SetUpDataGridView(grdViewThoiHoc)

        Add_Namhoc(cmbNam_hoc)
        SetQuyenTruyCap(, btnXet, btnQD, )
    End Sub
    Private Sub frmESS_XetHocTiepThoiHocNgungHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"
    Private Sub trvLop1_TreeNodeSelected_() Handles trvLop1.TreeNodeSelected_
        Try
            If Not trvLop1.ID_lop_list Is Nothing Then
                dsID_lop = trvLop1.ID_lop_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If mdtHocTiep Is Nothing Or mdtNgungHoc Is Nothing Or mdtThoiHoc Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewMain.DataSource
        If dv.Count > 0 Then
            Select Case sender.SelectedIndex.ToString
                Case 0
                    btnQD.Visible = False
                Case 1 'Hoc tiep
                    mdtHocTiep.DefaultView.RowFilter = "1=1"
                    mdtHocTiep.DefaultView.RowFilter = "ID_lop=" & dv.Item(grdViewMain.CurrentRow.Index)("ID_lop")
                    grdViewHocTiep.DataSource = mdtHocTiep.DefaultView
                    lblLop_hoctiep.Text = dv.Item(grdViewMain.CurrentRow.Index)("Ten_lop").ToString
                    lblSV_hoctiep.Text = mdtHocTiep.DefaultView.Count
                    btnQD.Visible = True
                Case 2  'Thoi hoc
                    mdtThoiHoc.DefaultView.RowFilter = "1=1"
                    mdtThoiHoc.DefaultView.RowFilter = "ID_lop=" & dv.Item(grdViewMain.CurrentRow.Index)("ID_lop")
                    grdViewThoiHoc.DataSource = mdtThoiHoc.DefaultView
                    lblLop_thoihoc.Text = dv.Item(grdViewMain.CurrentRow.Index)("Ten_lop").ToString
                    lblSV_ThoiHoc.Text = mdtThoiHoc.DefaultView.Count
                    btnQD.Visible = True
                Case 3 'Ngung hoc
                    mdtNgungHoc.DefaultView.RowFilter = "1=1"
                    mdtNgungHoc.DefaultView.RowFilter = "ID_lop=" & dv.Item(grdViewMain.CurrentRow.Index)("ID_lop")
                    grdViewNgungHoc.DataSource = mdtNgungHoc.DefaultView
                    lblLop_ngunghoc.Text = dv.Item(grdViewMain.CurrentRow.Index)("Ten_lop").ToString
                    lblSV_ngunghoc.Text = mdtNgungHoc.DefaultView.Count
                    btnQD.Visible = True
            End Select
        End If
    End Sub
#End Region
    Private Sub FillLoai_QD(ByVal cmb As ComboBox)
        Dim dt As New DataTable
        dt.Columns.Add("Loai_QD", GetType(Integer))
        dt.Columns.Add("Ten_loai", GetType(String))

        Dim dr As DataRow
        dr = dt.NewRow
        dr.Item("Loai_QD") = 1
        dr.Item("Ten_loai") = "Ngừng học"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("Loai_QD") = 2
        dr.Item("Ten_loai") = "Thôi học"
        dt.Rows.Add(dr)

        FillCombo(cmb, dt)
    End Sub

    'Private Sub FormatDataView_NgungHoc(ByVal Ly_do1 As String, ByVal Ly_do2 As String)
    Private Sub FormatDataView_NgungHoc()
        Try
            grdViewNgungHoc.Columns.Clear()
            Dim col1 As New DataGridViewCheckBoxColumn
            With col1
                .Name = "Chon"
                .DataPropertyName = "Chon"
                .HeaderText = "Chọn"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewNgungHoc.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sv"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 170
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col3)
            'TBCHP
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ngay_sinh"
                .DataPropertyName = "Ngay_sinh"
                .HeaderText = "Ngày sinh"
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .Width = 95
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col4)

            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "Ten_lop"
                .DataPropertyName = "Ten_lop"
                .HeaderText = "Tên lớp"
                .Width = 90
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col5)
           
            
            'Cac ly do
           

            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Tong_tiet_nam"
                .DataPropertyName = "Tong_tiet_nam"
                .HeaderText = "Tổng số tiết năm"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col7)

            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Tong_tiet_no"
                .DataPropertyName = "Tong_tiet_no"
                .HeaderText = "Số tiết nợ"
                .Width = 120
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col8)

            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Phan_tram_NH"
                .DataPropertyName = "Phan_tram_NH"
                .HeaderText = "Phần trăm nợ"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col9)

            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Ly_do_NgungHoc"
                .DataPropertyName = "Ly_do_NgungHoc"
                .HeaderText = "Lý do"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewNgungHoc.Columns.Add(col6)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    'Private Sub FormatDataView_ThoiHoc(ByVal Ly_do1 As String, ByVal Ly_do2 As String)
    Private Sub FormatDataView_ThoiHoc()
        Try
            grdViewThoiHoc.Columns.Clear()
            Dim col1 As New DataGridViewCheckBoxColumn
            With col1
                .Name = "Chon"
                .DataPropertyName = "Chon"
                .HeaderText = "Chọn"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewThoiHoc.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sv"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 170
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col3)
            'TBCHP
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ngay_sinh"
                .DataPropertyName = "Ngay_sinh"
                .HeaderText = "Ngày sinh"
                .DefaultCellStyle.Format = "dd/MM/yyyy"
                .Width = 95
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col4)

            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "Ten_lop"
                .DataPropertyName = "Ten_lop"
                .HeaderText = "Tên lớp"
                .Width = 90
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col5)

            'Cac ly do
           

            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Tong_tiet_nam"
                .DataPropertyName = "Tong_tiet_nam"
                .HeaderText = "Tổng số tiết năm"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col7)

            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Tong_tiet_no"
                .DataPropertyName = "Tong_tiet_no"
                .HeaderText = "Số tiết nợ"
                .Width = 120
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col8)

            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Phan_tram_TH"
                .DataPropertyName = "Phan_tram_TH"
                .HeaderText = "Phần trăm nợ"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col9)

            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Ly_do_ThoiHoc"
                .DataPropertyName = "Ly_do_ThoiHoc"
                .HeaderText = "Lý do"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewThoiHoc.Columns.Add(col6)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXet.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            Dim objLop As New Lop_BLL(dsID_lop, 1, -1, 1)
            Dim mdtLop As DataTable = objLop.Danh_sach_lop_dang_hoc()
            If cmbNam_hoc.Text.Trim <> "" Then

                mID_dt = trvLop1.ID_dt_list
                clsDSXetLenLop = New DanhSachXetLenLop_BLL(gobjUser.ID_dv, dsID_lop, trvLop1.ID_he, 0, 0, 0, "", mID_dt, mdtDanhSachSinhVien)
                grdViewMain.DataSource = clsDSXetLenLop.KetQua_XetLenLop(trvLop1.ID_he, mdtLop, cmbNam_hoc.Text, gobjUser.ID_Bomon, mdtHocTiep, mdtNgungHoc, mdtThoiHoc).DefaultView
                Thongbao("Kết quả tổng hợp !", MsgBoxStyle.Information)
                FormatDataView_ThoiHoc()
                FormatDataView_NgungHoc()
                'Dim Lydo_Ngunghoc1, Lydo_Ngunghoc2, Lydo_Thoihoc1, Lydo_Thoihoc2 As String
                'clsDSXetLenLop.LydoNgunghoc_FormatGrid(Lydo_Ngunghoc1, Lydo_Ngunghoc2, Lydo_Thoihoc1, Lydo_Thoihoc2)
                'FormatDataView_ThoiHoc(Lydo_Thoihoc1, Lydo_Thoihoc2)
                'FormatDataView_NgungHoc(Lydo_Ngunghoc1, Lydo_Ngunghoc2)
            Else
                Thongbao("Chọn học kỳ và năm học trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnThiTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThiTN.Click
        Try
            Dim dv1 As DataView
            Dim dt As New DataTable
            Dim Tieu_de1, Tieu_de2 As String
            If trvLop1.Tieu_de_Lop <> "" Then 'La Lop
                Tieu_de2 = trvLop1.Tieu_de_Lop.ToUpper
            Else
                Tieu_de2 = trvLop1.Tieu_de
            End If
            Dim Khoa_hoc As String = "Khóa học: " & trvLop1.Khoa_hoc
            Dim ID_chuyen_nganh As Integer = trvLop1.ID_chuyen_nganh
            Dim dtCN As DataTable = UDB.SelectTable("Select * from stu_ChuyenNganh where ID_chuyen_nganh = " & ID_chuyen_nganh)
            Dim Chuyen_nganh As String = "Nghề: " & dtCN.Rows(0)("Chuyen_nganh").ToString
            Select Case TabControl1.SelectedIndex
                Case 0
                    dv1 = grdViewMain.DataSource
                    dt.Columns.Add("Ten_lop")
                    dt.Columns.Add("Hoc_tiep")
                    dt.Columns.Add("Ngung_hoc")
                    dt.Columns.Add("Thoi_hoc")
                    For i As Integer = 0 To dv1.Count - 1
                        Dim dr As DataRow = dt.NewRow
                        dr("Ten_lop") = dv1.Item(i)("Ten_lop").ToString
                        dr("Hoc_tiep") = dv1.Item(i)("Hoc_tiep").ToString
                        dr("Ngung_hoc") = dv1.Item(i)("Ngung_hoc").ToString
                        dr("Thoi_hoc") = dv1.Item(i)("Thoi_hoc").ToString
                        dt.Rows.Add(dr)
                    Next
                Case 1 'Hoc tiep
                    Tieu_de1 = "DANH SÁCH SINH VIÊN ĐỦ ĐIỀU KIỆN HỌC TIẾP"
                    dv1 = grdViewHocTiep.DataSource
                    dt.Columns.Add("Ma_sv")
                    dt.Columns.Add("Ho_ten")
                    dt.Columns.Add("Ngay_sinh")
                    dt.Columns.Add("Ten_lop")
                    For i As Integer = 0 To dv1.Count - 1
                        Dim dr As DataRow = dt.NewRow
                        dr("Ma_sv") = dv1.Item(i)("Ma_sv").ToString
                        dr("Ho_ten") = dv1.Item(i)("Ho_ten").ToString
                        dr("Ngay_sinh") = dv1.Item(i)("Ngay_sinh")
                        dr("Ten_lop") = dv1.Item(i)("Ten_lop").ToString
                        dt.Rows.Add(dr)
                    Next
                    If dv1.Count > 0 Then
                        Dim rpt As New rptDanhSachHocTiep(dv1, Tieu_de1, Khoa_hoc, Chuyen_nganh)
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có nội dung báo cáo")
                        Exit Sub
                    End If
                Case 3 'Ngung hoc
                    Tieu_de1 = "DANH SÁCH SINH VIÊN LƯU BAN CHUYỂN XUỐNG HỌC KHÓA SAU"
                    dv1 = grdViewNgungHoc.DataSource
                    dt.Columns.Add("Ma_sv")
                    dt.Columns.Add("Ho_ten")
                    dt.Columns.Add("Ngay_sinh")
                    dt.Columns.Add("Ten_lop")
                    dt.Columns.Add("Tong_tiet_nam")
                    dt.Columns.Add("Tong_tiet_no")
                    dt.Columns.Add("Phan_tram_NH")
                    dt.Columns.Add("Ly_do_NgungHoc")
                    For i As Integer = 0 To dv1.Count - 1
                        Dim dr As DataRow = dt.NewRow
                        dr("Ma_sv") = dv1.Item(i)("Ma_sv").ToString
                        dr("Ho_ten") = dv1.Item(i)("Ho_ten").ToString
                        dr("Ngay_sinh") = dv1.Item(i)("Ngay_sinh")
                        dr("Ten_lop") = dv1.Item(i)("Ten_lop").ToString
                        dr("Tong_tiet_nam") = dv1.Item(i)("Tong_tiet_nam").ToString
                        dr("Tong_tiet_no") = dv1.Item(i)("Tong_tiet_no").ToString
                        dr("Phan_tram_NH") = dv1.Item(i)("Phan_tram_NH").ToString
                        dr("Ly_do_NgungHoc") = dv1.Item(i)("Ly_do_NgungHoc").ToString
                        dt.Rows.Add(dr)
                    Next
                    If dv1.Count > 0 Then
                        Dim rpt As New rptDanhSachNgungHoc(dv1, Tieu_de1, Khoa_hoc, Chuyen_nganh)
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có nội dung báo cáo")
                        Exit Sub
                    End If
                Case 2 'Thoi hoc
                    Tieu_de1 = "DẠNH SÁCH SINH VIÊN BUỘC THÔI HỌC"
                    dv1 = grdViewThoiHoc.DataSource
                    dt.Columns.Add("Ma_sv")
                    dt.Columns.Add("Ho_ten")
                    dt.Columns.Add("Ngay_sinh")
                    dt.Columns.Add("Ten_lop")
                    dt.Columns.Add("Tong_tiet_nam")
                    dt.Columns.Add("Tong_tiet_no")
                    dt.Columns.Add("Phan_tram_TH")
                    dt.Columns.Add("Ly_do_ThoiHoc")
                    For i As Integer = 0 To dv1.Count - 1
                        Dim dr As DataRow = dt.NewRow
                        dr("Ma_sv") = dv1.Item(i)("Ma_sv").ToString
                        dr("Ho_ten") = dv1.Item(i)("Ho_ten").ToString
                        dr("Ngay_sinh") = dv1.Item(i)("Ngay_sinh")
                        dr("Ten_lop") = dv1.Item(i)("Ten_lop").ToString
                        dr("Tong_tiet_nam") = dv1.Item(i)("Tong_tiet_nam").ToString
                        dr("Tong_tiet_no") = dv1.Item(i)("Tong_tiet_no").ToString
                        dr("Phan_tram_TH") = dv1.Item(i)("Phan_tram_TH").ToString
                        dr("Ly_do_ThoiHoc") = dv1.Item(i)("Ly_do_ThoiHoc").ToString
                        dt.Rows.Add(dr)
                    Next
                    If dv1.Count > 0 Then
                        Dim rpt As New rptDanhSachThoiHoc(dv1, Tieu_de1, Khoa_hoc, Chuyen_nganh)
                        PrintXtraReport(rpt)
                    Else
                        Thongbao("Không có nội dung báo cáo")
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLV.Click
        Try
            Dim clsExcel As New ExportToExcel
            Select Case TabControl1.SelectedIndex
                Case 0
                    If Not grdViewMain.DataSource Is Nothing Then
                        clsExcel.ExportFromDataGridViewToExcel(grdViewMain)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 1 'Hoc tiep
                    If Not grdViewHocTiep.DataSource Is Nothing Then
                        clsExcel.ExportFromDataGridViewToExcel(grdViewHocTiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 3 'Ngung hoc
                    If Not grdViewNgungHoc.DataSource Is Nothing Then
                        clsExcel.ExportFromDataGridViewToExcel(grdViewNgungHoc)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 2 'Thoi hoc
                    If Not grdViewThoiHoc.DataSource Is Nothing Then
                        clsExcel.ExportFromDataGridViewToExcel(grdViewThoiHoc)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnQD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQD.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            Dim dt As DataTable
            Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
            Select Case TabControl1.SelectedIndex
                Case 1 'Hoc tiep
                    If Not grdViewHocTiep.DataSource Is Nothing Then
                        If mdtHocTiep.DefaultView.Count > 0 Then
                            dt = clsDSXetLenLop.Danh_sach_sinh_vien_chon(mdtHocTiep.DefaultView)
                            FillLoai_QD(frmESS_.cmbLoai_qd)
                            frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)
                            mID_dt = trvLop1.ID_dt_list
                            For i As Integer = mdtHocTiep.DefaultView.Count - 1 To 0 Step -1
                                If mdtHocTiep.DefaultView.Item(i)("Chon") Then mdtHocTiep.DefaultView.Item(i).Delete()
                            Next
                            mdtHocTiep.AcceptChanges()
                            lblSV_hoctiep.Text = mdtHocTiep.DefaultView.Count
                        End If
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 3 'Ngung hoc
                    If Not grdViewNgungHoc.DataSource Is Nothing Then
                        If mdtNgungHoc.DefaultView.Count > 0 Then
                            dt = clsDSXetLenLop.Danh_sach_sinh_vien_chon(mdtNgungHoc.DefaultView)
                            FillLoai_QD(frmESS_.cmbLoai_qd)
                            frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)
                            mID_dt = trvLop1.ID_dt_list
                            For i As Integer = mdtNgungHoc.DefaultView.Count - 1 To 0 Step -1
                                If mdtNgungHoc.DefaultView.Item(i)("Chon") Then mdtNgungHoc.DefaultView.Item(i).Delete()
                            Next
                            mdtNgungHoc.AcceptChanges()
                            lblSV_ngunghoc.Text = mdtNgungHoc.DefaultView.Count
                        End If
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 2 'Thoi hoc
                    If Not grdViewThoiHoc.DataSource Is Nothing Then
                        If mdtThoiHoc.DefaultView.Count > 0 Then
                            dt = clsDSXetLenLop.Danh_sach_sinh_vien_chon(mdtThoiHoc.DefaultView)
                            FillLoai_QD(frmESS_.cmbLoai_qd)
                            frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)
                            mID_dt = trvLop1.ID_dt_list
                            For i As Integer = mdtThoiHoc.DefaultView.Count - 1 To 0 Step -1
                                If mdtThoiHoc.DefaultView.Item(i)("Chon") Then mdtThoiHoc.DefaultView.Item(i).Delete()
                            Next
                            mdtThoiHoc.AcceptChanges()
                            lblSV_ThoiHoc.Text = mdtThoiHoc.DefaultView.Count
                        End If
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub


End Class