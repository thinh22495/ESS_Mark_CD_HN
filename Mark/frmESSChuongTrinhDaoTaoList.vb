Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmESSChuongTrinhDaoTaoList
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_BLL
#Region "User Function"
    Private Sub LoadComboBox()
        Try
            Dim clsLop As New Lop_BLL(gobjUser.dsID_lop, 1, -1, 1)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub FormatDataViewCTDTChiTiet()
        Try
            grdViewCTDTChiTiet.Columns.Clear()
            grdViewCTDTChiTiet.AllowUserToOrderColumns = False

            'STT
            Dim col1 As New DataGridViewTextBoxColumn
            With col1
                .Name = "STT_mon"
                .DataPropertyName = "STT_mon"
                .HeaderText = "STT"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col1)

            'Phạm vi kiến thức
            Dim clsDM As New DanhMuc_BLL
            Dim dtKienThuc As DataTable
            dtKienThuc = clsDM.DanhMuc_Load("PLAN_ChuongTrinhDaoTaoKienThuc", "ID_kien_thuc", "Ten_kien_thuc")
            Dim col15 As New DataGridViewComboBoxColumn
            With col15
                .Name = "Kien_thuc"
                .DataPropertyName = "Kien_thuc"
                .HeaderText = "Khối kiến thức"
                .Width = 200
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .MaxDropDownItems = 10
                .FlatStyle = FlatStyle.Flat
                .DropDownWidth = 150
                .DataSource = dtKienThuc
                .ValueMember = "ID_kien_thuc"
                .DisplayMember = "Ten_kien_thuc"
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col15)

            'Ký hiệu
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ky_hieu"
                .DataPropertyName = "Ky_hieu"
                .HeaderText = "Ký hiệu"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col2)
            'Tên học phần
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ten_mon"
                .DataPropertyName = "Ten_mon"
                .HeaderText = "Tên học phần"
                .Width = 250
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col3)

            'Kỳ thứ
            Dim col0 As New DataGridViewTextBoxColumn
            With col0
                .Name = "Ky_thu"
                .DataPropertyName = "Ky_thu"
                .HeaderText = "Kỳ thứ"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col0)

            'Số học trình
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "So_hoc_trinh"
                .DataPropertyName = "So_hoc_trinh"
                .HeaderText = "Số đvht"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col4)

            'Hệ số
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "He_so"
                .DataPropertyName = "He_so"
                .HeaderText = "Hệ số"
                .Width = 30
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col5)

            'Lý thuyết
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Ly_thuyet"
                .DataPropertyName = "Ly_thuyet"
                .HeaderText = "Lý thuyết"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col7)

            'Thực hành
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Thuc_hanh"
                .DataPropertyName = "Thuc_hanh"
                .HeaderText = "Thực hành"
                .Width = 45
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col8)

            'Bài tập
            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Bai_tap"
                .DataPropertyName = "Bai_tap"
                .HeaderText = "Bài tập"
                .Width = 30
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col9)

            'Bài tập lớn
            Dim col10 As New DataGridViewTextBoxColumn
            With col10
                .Name = "Bai_tap_lon"
                .DataPropertyName = "Bai_tap_lon"
                .HeaderText = "Bài tập lớn"
                .Width = 35
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col10)
            'Thực tập
            Dim col13 As New DataGridViewTextBoxColumn
            With col13
                .Name = "Thuc_tap"
                .DataPropertyName = "Thuc_tap"
                .HeaderText = "Thực tập"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col13)
            'Tổng số tiết
            Dim col11 As New DataGridViewTextBoxColumn
            With col11
                .Name = "Tong_so_tiet"
                .DataPropertyName = "Tong_so_tiet"
                .HeaderText = "Tổng số tiết"
                .Width = 43
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col11)

            'Tự chọn
            Dim col12 As New DataGridViewCheckBoxColumn
            With col12
                .Name = "Tu_chon"
                .DataPropertyName = "Tu_chon"
                .HeaderText = "Tự chọn"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col12)
            'Không tính điểm
            Dim col14 As New DataGridViewCheckBoxColumn
            With col14
                .Name = "Khong_tinh_TBCHT"
                .DataPropertyName = "Khong_tinh_TBCHT"
                .HeaderText = "Không tính TBCHT"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col14)

            Dim col16 As New DataGridViewCheckBoxColumn
            With col16
                .Name = "Mon_thi_TN"
                .DataPropertyName = "Mon_tot_nghiep"
                .HeaderText = "Môn thi tốt nghiệp"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col16)

            'Mon main
            clsDM = New DanhMuc_BLL
            Dim dtMon_CTDT As DataTable
            dtMon_CTDT = clsDM.DanhMuc_Load("SELECT a.ID_mon,Ten_mon as Ten_mon_m FROM MARK_MonHoc a INNER JOIN PLAN_ChuongTrinhDaoTaoChiTiet b ON a.ID_mon=b.ID_mon WHERE ID_dt=" & mID_dt)
            Dim dr As DataRow
            dr = dtMon_CTDT.NewRow
            dr("ID_mon") = -1
            dr("Ten_mon_m") = ""
            dtMon_CTDT.Rows.Add(dr)

            Dim col20 As New DataGridViewComboBoxColumn
            With col20
                .Name = "ID_mon_main"
                .DataPropertyName = "ID_mon_main"
                .HeaderText = "Thuộc nhóm học phần"
                .Width = 150
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
                .DefaultCellStyle.NullValue = ""
                .MaxDropDownItems = 20
                .FlatStyle = FlatStyle.Flat
                .DropDownWidth = 150
                .DataSource = dtMon_CTDT
                .ValueMember = "ID_mon"
                .DisplayMember = "Ten_mon_m"
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col20)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub frmESS_ChuongTrinhDaoTaoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox
            LoadComboBox()
            SetUpDataGridView(grdViewCTDT)
            SetUpDataGridView(grdViewCTDTChiTiet)
            FormatDataViewCTDTChiTiet()
            'Load chương trình đào tạo
            clsCTDT = New ChuongTrinhDaoTao_BLL(gobjUser.dsID_dt)
            Me.grdViewCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
            Loader = True

            SetQuyenTruyCap(Button7, btnSave, Button2, Button5)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
    Private Sub grdViewCTDT_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewCTDT.Click, grdViewCTDT.CurrentCellChanged, grdViewCTDT.DataSourceChanged
        Try
            If Loader Then
                SetUpDataGridView(grdViewCTDTChiTiet)
                Dim dv As DataView = grdViewCTDT.DataSource
                If Not grdViewCTDT.CurrentRow Is Nothing Then
                    mID_dt = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_dt")
                    mID_he = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_he")
                Else
                    mID_dt = 0
                    mID_he = 0
                End If
                FormatDataViewCTDTChiTiet()
                'Load chương trình đào tạo chi tiết
                clsCTDT.Load_CTDTChiTiet(mID_dt)
                'Hiển thị các học phần
                grdViewCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt).DefaultView
                txtTong_so_mon.Text = grdViewCTDTChiTiet.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub grdViewCTDT_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles grdViewCTDT.DataError, grdViewCTDTChiTiet.DataError
        'Thongbao("Bạn nhập sai kiểu dữ liệu !")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            grdViewCTDT.EndEdit()
            grdViewCTDTChiTiet.EndEdit()
            'Update Số học trình ở chương trình đào tạo main
            Dim dvCTDT As DataView = grdViewCTDT.DataSource
            Dim idx As Integer = 0
            For i As Integer = 0 To dvCTDT.Count - 1
                'If dvCTDT.Item(i).Row.RowState = DataRowState.Modified Then
                'Tìm chương trình đào tạo trên
                idx = clsCTDT.Tim_idx(dvCTDT.Item(i)("ID_dt"))
                If idx >= 0 Then
                    Dim objCTDT As New ChuongTrinhDaoTao
                    objCTDT = clsCTDT.ChuongTrinhDaoTao(idx)
                    'Gán Số học trình thay đổi trên DataGridView
                    objCTDT.So_hoc_trinh = dvCTDT.Item(i)("So_hoc_trinh")
                    objCTDT.So_ky_hoc = dvCTDT.Item(i)("So_Ky_hoc")
                    objCTDT.So = dvCTDT.Item(i)("So")
                    'Update vào database
                    clsCTDT.Update_ChuongTrinhDaoTao(objCTDT, dvCTDT.Item(i)("ID_dt"))
                End If
                'End If
            Next
            'Update dữ liệu học phần ở chương trình đào tạo chi tiết
            Dim dvCTDTChiTiet As DataView = grdViewCTDTChiTiet.DataSource
            Dim idx1 As Integer = 0
            For i As Integer = 0 To dvCTDTChiTiet.Count - 1
                'If dvCTDTChiTiet.Item(i).Row.RowState = DataRowState.Modified Then
                'Tìm chương trình đào tạo
                idx = clsCTDT.Tim_idx(dvCTDTChiTiet.Item(i)("ID_dt"))
                If idx >= 0 Then
                    'Tìm môn
                    idx1 = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Tim_idx(dvCTDTChiTiet.Item(i)("ID_mon"))
                    If idx1 >= 0 Then
                        Dim objCTDTChiTiet As New ChuongTrinhDaoTaoChiTiet
                        objCTDTChiTiet = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(idx1)
                        'Gán các dữ liệu thay đổi trên DataGridView vào đối tượng
                        objCTDTChiTiet.STT_mon = dvCTDTChiTiet.Item(i)("STT_mon")
                        objCTDTChiTiet.So_hoc_trinh = dvCTDTChiTiet.Item(i)("So_hoc_trinh")
                        objCTDTChiTiet.Ky_thu = dvCTDTChiTiet.Item(i)("Ky_thu")
                        objCTDTChiTiet.He_so = dvCTDTChiTiet.Item(i)("He_so")
                        objCTDTChiTiet.Ly_thuyet = dvCTDTChiTiet.Item(i)("Ly_thuyet")
                        objCTDTChiTiet.Thuc_hanh = dvCTDTChiTiet.Item(i)("Thuc_hanh")
                        objCTDTChiTiet.Bai_tap = dvCTDTChiTiet.Item(i)("Bai_tap")
                        objCTDTChiTiet.Bai_tap_lon = dvCTDTChiTiet.Item(i)("Bai_tap_lon")
                        objCTDTChiTiet.Tu_chon = dvCTDTChiTiet.Item(i)("Tu_chon")
                        objCTDTChiTiet.Khong_tinh_TBCHT = dvCTDTChiTiet.Item(i)("Khong_tinh_TBCHT")
                        objCTDTChiTiet.Kien_thuc = dvCTDTChiTiet.Item(i)("Kien_thuc")
                        objCTDTChiTiet.Thuc_tap = dvCTDTChiTiet.Item(i)("Thuc_tap")
                        objCTDTChiTiet.Mon_thi_TN = dvCTDTChiTiet.Item(i)("Mon_thi_TN")
                        If dvCTDTChiTiet.Item(i)("ID_mon_main").ToString <> "" Then
                            objCTDTChiTiet.ID_mon_main = dvCTDTChiTiet.Item(i)("ID_mon_main")
                        Else
                            objCTDTChiTiet.ID_mon_main = 0
                        End If

                        'Update vào database
                        clsCTDT.Update_ChuongTrinhDaoTaoChiTiet(objCTDTChiTiet, dvCTDTChiTiet.Item(i)("ID_dt_mon"))
                    End If
                End If
                'End If
            Next
            'dvCTDT.Table.AcceptChanges()
            dvCTDTChiTiet.Table.AcceptChanges()
            Thongbao("Cập nhật thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim frmESS_ As New frmESS_ChuongTrinhDaotaoAdd
            frmESS_.ShowDialog(clsCTDT)
            If frmESS_.Tag = "1" Then
                'Load lại chương trình đào tạo
                Me.grdViewCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView

                grdViewCTDT.Rows(grdViewCTDT.Rows.Count - 1).Selected = True
                'Thêm môn học mới
                Dim frmESS_1 As New frmESS_ChuongTrinhDaoTaoChonMon
                Dim dtCTDTChiTiet As DataTable = grdViewCTDTChiTiet.DataSource.Table
                Dim ID_he, ID_dt_new As Integer
                ID_he = frmESS_.ID_he
                ID_dt_new = frmESS_.ID_dt_new
                frmESS_1.ShowDialog(clsCTDT, ID_he, ID_dt_new, dtCTDTChiTiet)
                If frmESS_1.Tag = "1" Then
                    'Hiển thị các học phần
                    grdViewCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(ID_dt_new).DefaultView
                    txtTong_so_mon.Text = grdViewCTDTChiTiet.DataSource.Count
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If grdViewCTDT.CurrentRow.Index >= 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá chương trình đào tạo này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim dv As DataView = grdViewCTDT.DataSource
                    Dim ID_dt As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_dt")
                    Dim idx As Integer
                    'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                    If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt) > 0 Then
                        idx = clsCTDT.Tim_idx(ID_dt)
                        If idx >= 0 Then
                            'Xoá các môn trong chương trình đào tạo khung
                            For i As Integer = 0 To clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Count - 1
                                Dim objCTDTChiTiet As New ChuongTrinhDaoTaoChiTiet
                                objCTDTChiTiet = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(i)
                                clsCTDT.Delete_ChuongTrinhDaoTaoChiTiet(objCTDTChiTiet.ID_dt_mon)
                            Next
                            'Xoá chương trình đào tạo
                            clsCTDT.Delete_ChuongTrinhDaoTao(clsCTDT.ChuongTrinhDaoTao(idx).ID_dt)
                            'Xoá khỏi object
                            clsCTDT.Remove(idx)
                            'Load lại chương trình đào tạo
                            Me.grdViewCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
                        End If
                    Else
                        Thongbao("Chương trình đào tạo này đã nhập điểm, bạn không thể xoá được")
                    End If
                End If
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_ChuongTrinhDaotaoSaoChep

                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(grvChuongTrinhDaoTaoList.GetSelectedRows.GetValue(0))

                Dim dv As DataView = grvChuongTrinhDaoTaoList.DataSource
                Dim ID_he As Integer = row("ID_he")
                Dim ID_khoa As Integer = row("ID_khoa")
                Dim Khoa_hoc As Integer = row("Khoa_hoc")
                Dim ID_chuyen_nganh As Integer = row("ID_chuyen_nganh")
                Dim ID_dt As Integer = row("ID_dt")
                Dim So As Integer = row("So")
                frmESS_.ShowDialog(clsCTDT, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_dt, So)
                'Load lại chương trình đào tạo mới tạo
                If frmESS_.Tag = "1" Then
                    Me.Load_Data_CTDT()
                    Thongbao("Đã sao chép thành công chương trình đào tạo")
                End If
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để sao chép")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If Not grdViewCTDT.CurrentRow Is Nothing Then
                Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoGanLop
                Dim dv As DataView = grdViewCTDT.DataSource
                Dim ID_he As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_he")
                Dim ID_khoa As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_khoa")
                Dim Khoa_hoc As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("Khoa_hoc")
                Dim ID_chuyen_nganh As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_chuyen_nganh")
                Dim ID_dt As Integer = dv.Item(grdViewCTDT.CurrentRow.Index).Item("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để gán lớp")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoChonMon
            Dim dtCTDTChiTiet As DataTable = grdViewCTDTChiTiet.DataSource.Table
            frmESS_.ShowDialog(clsCTDT, mID_he, mID_dt, dtCTDTChiTiet)
            If frmESS_.Tag = "1" Then
                'Hiển thị các học phần
                grdViewCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt).DefaultView
                txtTong_so_mon.Text = grdViewCTDTChiTiet.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá học phần này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dv As DataView = grdViewCTDTChiTiet.DataSource
                Dim ID_dt As Integer = dv.Item(grdViewCTDTChiTiet.CurrentRow.Index).Item("ID_dt")
                Dim ID_mon As Integer = dv.Item(grdViewCTDTChiTiet.CurrentRow.Index).Item("ID_mon")
                Dim ID_dt_mon As Integer = dv.Item(grdViewCTDTChiTiet.CurrentRow.Index).Item("ID_dt_mon")
                Dim idx, idx1 As Integer
                'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt, ID_mon) > 0 Then
                    'Xoá trong CSDL
                    clsCTDT.Delete_ChuongTrinhDaoTaoChiTiet(ID_dt_mon)
                    'Xoá object
                    idx = clsCTDT.Tim_idx(ID_dt)
                    If idx >= 0 Then
                        idx1 = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Tim_idx(ID_mon)
                        If idx1 >= 0 Then
                            clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Remove(idx1)
                        End If
                    End If
                    'Xoa DataGridView
                    dv.Item(grdViewCTDTChiTiet.CurrentRow.Index).Delete()
                    dv.Table.AcceptChanges()
                    Thongbao("Xoá học phần thành công")
                Else
                    Thongbao("Học phần này đã nhập điểm, bạn không thể xoá được")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim dv1 As DataView = grdViewCTDTChiTiet.DataSource
            Dim dt As DataTable = dv1.Table.Copy
            If dt.Rows.Count > 0 Then
                dt.Columns.Add("Tieu_de")
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dv_tmp As DataView = grdViewCTDT.DataSource
                    If dv_tmp.Count > 0 Then
                        dt.Rows(i).Item("Tieu_de") = "HỆ: " & dv_tmp.Item(grdViewCTDT.CurrentRow.Index).Item("Ten_he").ToString.ToUpper & "  KHOÁ: " & dv_tmp.Item(grdViewCTDT.CurrentRow.Index).Item("Khoa_hoc").ToString.ToUpper & "  CHUYÊN NGÀNH: " & dv_tmp.Item(grdViewCTDT.CurrentRow.Index).Item("Ten_chuyen_nganh").ToString.ToUpper
                    Else
                        dt.Rows(i).Item("Tieu_de") = ""
                    End If
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("CHUONG TRINH DAO TAO KHUNG", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoImport
        frmESS_.ShowDialog(clsCTDT)
        'Load lại chương trình đào tạo đã Imports
        If frmESS_.Tag = "1" Then
            Me.grdViewCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
        End If
    End Sub
End Class