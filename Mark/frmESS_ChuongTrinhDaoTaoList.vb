Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Catalogue
Imports ESS.Machine
Imports System
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Public Class frmESS_ChuongTrinhDaoTaoList
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private Loader As Boolean = False
    Private clsDM As New DanhMuc_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private dtKienThuc1 As DataTable
    Private dtMon_CTDT As DataTable

    Private clsLop As New Lop_BLL(gobjUser.dsID_lop, -1, 1, 0)
#Region "User Function"

    Private Sub Load_Data_CTDT()
        'Load chương trình đào tạo
        clsCTDT = New ChuongTrinhDaoTao_BLL(gobjUser.dsID_dt)
        grcCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
    End Sub
#End Region
#Region "Form Events"
    Private Sub frmESS_ChuongTrinhDaoTaoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim dt As DataTable
            'dt = ESS.Machine.UDB.SelectTable("SELECT DISTINCT Quy_che, N'Quy chế ' + CONVERT(nvarchar(10),Quy_che) Ten_quy_che FROM MARK_ThamSoQuyChe")
            RepositoryItemLookUpEdit1.DataSource = ESS.Machine.UDB.SelectTable("SELECT DISTINCT Quy_che, N'Quy chế ' + CONVERT(nvarchar(10),Quy_che) Ten_quy_che FROM MARK_ThamSoQuyChe")
            RepositoryItemLookUpEdit1.DisplayMember = "Ten_quy_che"
            RepositoryItemLookUpEdit1.ValueMember = "Quy_che"
            Dim colQuy_che As New LookUpColumnInfo()
            colQuy_che.FieldName = "Ten_quy_che"
            colQuy_che.Caption = "Quy chế"
            'Dim colHoTen As New LookUpColumnInfo
            'colHoTen.FieldName = "Ho_ten"
            'colHoTen.Caption = "Ho ten"
            RepositoryItemLookUpEdit1.Columns.Add(colQuy_che)
            'RepositoryItemLookUpEdit1.Columns.Add(colHoTen)
            AddHandler RepositoryItemLookUpEdit1.CustomDisplayText, AddressOf RepositoryItemLookUpEdit1_CustomDisplayText

            'grvChuongTrinhDaoTaoList.Columns(0).ColumnEdit = editor
            '' add the second column bound to the same field for easier reference
            'grvChuongTrinhDaoTaoList.Columns.AddField("Number").VisibleIndex = 1

            'lookUpEdit1.Properties.Assign(editor)
            'lookUpEdit1.EditValue = 0

            dtKienThuc1 = clsDM.DanhMuc_Load("PLAN_ChuongTrinhDaoTaoKienThuc", "ID_kien_thuc", "Ten_kien_thuc")
            Me.Load_Data_CTDT()
            SetQuyenTruyCap(cmdLuu, cmdAdd_CT, cmdCopy, cmdDelete_CT)
            SetQuyenTruyCap(, cmdAdd_HP, , cmdRemove_HP)
            SetQuyenTruyCap(, cmdLuu, cmdCTDT, cmdHocPhan)
            Loader = True
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



    Private Sub grvChuongTrinhDaoTaoList_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvChuongTrinhDaoTaoList.SelectionChanged
        Try
            If Loader Then
                Dim rowIndex As Integer = -1
                If grvChuongTrinhDaoTaoList.GetSelectedRows.Length = 0 Then Exit Sub
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                If rowIndex < 0 Then Exit Sub
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)
                If Not row Is Nothing Then
                    mID_dt = row("ID_dt")
                    mID_he = row("ID_he")

                    'Mon main
                    clsDM = New DanhMuc_BLL

                    dtMon_CTDT = clsDM.DanhMuc_Load("SELECT a.ID_mon,Ten_mon as Ten_mon_m FROM MARK_MonHoc a INNER JOIN PLAN_ChuongTrinhDaoTaoChiTiet b ON a.ID_mon=b.ID_mon WHERE ID_dt=" & mID_dt)


                    'Load chương trình đào tạo chi tiết
                    clsCTDT.Load_CTDTChiTiet(mID_dt)
                    'Hiển thị các học phần
                    grcCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt).DefaultView
                    lueKhoiKienThuc.DataSource = dtKienThuc1
                    lueID_mon_main.DataSource = dtMon_CTDT
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLuu.Click
        Try

            Dim dvCTDT As DataView = grvChuongTrinhDaoTaoList.DataSource
            ''Update số tín chỉ ở chương trình đào tạo main


            Dim idx As Integer = 0
            For i As Integer = 0 To dvCTDT.Count - 1
                If dvCTDT.Item(i).Row.RowState = DataRowState.Modified Then
                    'Tìm chương trình đào tạo trên
                    idx = clsCTDT.Tim_idx(dvCTDT.Item(i)("ID_dt"))
                    If idx >= 0 Then
                        Dim objCTDT As New ChuongTrinhDaoTao
                        objCTDT = clsCTDT.ChuongTrinhDaoTao(idx)
                        'Gán số tín chỉ thay đổi trên DataGridView
                        objCTDT.So_hoc_trinh = dvCTDT.Item(i)("So_hoc_trinh")
                        objCTDT.So_ky_hoc = dvCTDT.Item(i)("So_Ky_hoc")
                        objCTDT.Quy_che = dvCTDT.Item(i)("Quy_che")
                        Dim SQL As String = "UPDATE PLAN_ChuongTrinhDaoTao SET Ap_dung_quy_che = " & dvCTDT.Item(i)("Quy_che") & " WHERE ID_dt = " & dvCTDT.Item(i)("ID_dt") & ""
                        ESS.Machine.UDB.Execute(SQL)
                        'Update vào database
                        clsCTDT.Update_ChuongTrinhDaoTao(objCTDT, dvCTDT.Item(i)("ID_dt"))
                    End If
                End If
            Next
            'Update dữ liệu học phần ở chương trình đào tạo chi tiết
            'Dim dvCTDTChiTiet As DataView = grdViewCTDTChiTiet.DataSource
            Dim dvCTDTChiTiet As DataView = grvCTDTChiTiet.DataSource
            Dim idx1 As Integer = 0
            For i As Integer = 0 To dvCTDTChiTiet.Count - 1
                If dvCTDTChiTiet.Item(i).Row.RowState = DataRowState.Modified Then
                    'Tìm chương trình đào tạo
                    idx = clsCTDT.Tim_idx(dvCTDTChiTiet.Item(i)("ID_dt"))
                    If idx >= 0 Then
                        'Tìm Học phần
                        idx1 = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Tim_idx(dvCTDTChiTiet.Item(i)("ID_mon"))
                        If idx1 >= 0 Then
                            Dim objCTDTChiTiet As New ChuongTrinhDaoTaoChiTiet
                            objCTDTChiTiet = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(idx1)
                            'Gán các dữ liệu thay đổi trên DataGridView vào đối tượng
                            objCTDTChiTiet.STT_mon = dvCTDTChiTiet.Item(i)("STT_mon")
                            objCTDTChiTiet.Ky_thu = dvCTDTChiTiet.Item(i)("Ky_thu")
                            objCTDTChiTiet.He_so = dvCTDTChiTiet.Item(i)("He_so")
                            objCTDTChiTiet.Ly_thuyet = dvCTDTChiTiet.Item(i)("Ly_thuyet")
                            objCTDTChiTiet.Thuc_hanh = dvCTDTChiTiet.Item(i)("Thuc_hanh")
                            objCTDTChiTiet.Bai_tap = dvCTDTChiTiet.Item(i)("Bai_tap")
                            objCTDTChiTiet.Bai_tap_lon = dvCTDTChiTiet.Item(i)("Bai_tap_lon")
                            objCTDTChiTiet.Tu_hoc = dvCTDTChiTiet.Item(i)("Tu_hoc")
                            objCTDTChiTiet.Tu_chon = dvCTDTChiTiet.Item(i)("Tu_chon")
                            objCTDTChiTiet.Khong_tinh_TBCHT = dvCTDTChiTiet.Item(i)("Khong_tinh_TBCHT")
                            objCTDTChiTiet.Kien_thuc = dvCTDTChiTiet.Item(i)("Kien_thuc")
                            objCTDTChiTiet.Nhom_tu_chon = dvCTDTChiTiet.Item(i)("Nhom_tu_chon")
                            objCTDTChiTiet.Tu_hoc = dvCTDTChiTiet.Item(i)("Tu_hoc")
                            Dim Tinh_HT As Double = 0
                            If optTinh_DVHT.Checked Then
                                If dvCTDTChiTiet.Item(i)("Ly_thuyet").ToString <> "" Then
                                    If dvCTDTChiTiet.Item(i)("Ly_thuyet") > 0 Then
                                        Tinh_HT = (dvCTDTChiTiet.Item(i)("Ly_thuyet") / 15)
                                    End If
                                End If
                                If dvCTDTChiTiet.Item(i)("Thuc_hanh").ToString <> "" Then
                                    If dvCTDTChiTiet.Item(i)("Thuc_hanh") > 0 Then
                                        Tinh_HT = Tinh_HT + (dvCTDTChiTiet.Item(i)("Thuc_hanh") / 40)
                                    End If
                                End If

                                Tinh_HT = Math.Round(Tinh_HT + 0.000000001, 0)
                                objCTDTChiTiet.So_hoc_trinh = Tinh_HT ' dvCTDTChiTiet.Item(i)("So_hoc_trinh_tien_quyet")
                            Else
                                objCTDTChiTiet.So_hoc_trinh = dvCTDTChiTiet.Item(i)("So_hoc_trinh")
                            End If
                            objCTDTChiTiet.So_hoc_trinh_tien_quyet = dvCTDTChiTiet.Item(i)("So_hoc_trinh_tien_quyet")
                            objCTDTChiTiet.Mon_thi_TN = dvCTDTChiTiet.Item(i)("Mon_tot_nghiep")
                            objCTDTChiTiet.Mon_thi_TN_thuc_hanh = dvCTDTChiTiet.Item(i)("Mon_tot_nghiep_thuc_hanh")
                            If dvCTDTChiTiet.Item(i)("ID_mon_main").ToString <> "" Then
                                objCTDTChiTiet.ID_mon_main = dvCTDTChiTiet.Item(i)("ID_mon_main")
                            Else
                                objCTDTChiTiet.ID_mon_main = 0
                            End If
                            objCTDTChiTiet.Ly_thuyet_nghe = dvCTDTChiTiet.Item(i)("Ly_thuyet_nghe")
                            objCTDTChiTiet.Thuc_hanh_nghe = dvCTDTChiTiet.Item(i)("Thuc_hanh_nghe")
                            'Update vào database
                            clsCTDT.Update_ChuongTrinhDaoTaoChiTiet(objCTDTChiTiet, dvCTDTChiTiet.Item(i)("ID_dt_mon"))
                        End If
                    End If
                End If
            Next
            Call grvChuongTrinhDaoTaoList_SelectionChanged(Nothing, Nothing)
            Thongbao("Cập nhật thành công")
            'Me.Load_Data_CTDT()

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_CT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd_CT.ItemClick
        Try
            Dim frmESS_ As New frmESS_ChuongTrinhDaotaoAdd
            frmESS_.ShowDialog(clsCTDT)
            If frmESS_.Tag = "1" Then
                'Load lại chương trình đào tạo
                Me.grcCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
                'Thêm Học phần mới
                Dim frmESS_1 As New frmESS_ChuongTrinhDaoTaoChonMon
                Dim dtCTDTChiTiet As DataTable = grvCTDTChiTiet.DataSource.Table
                Dim ID_he, ID_dt_new As Integer
                ID_he = frmESS_.ID_he
                ID_dt_new = frmESS_.ID_dt_new
                frmESS_1.ShowDialog(clsCTDT, ID_he, ID_dt_new, dtCTDTChiTiet)
                If frmESS_1.Tag = "1" Then
                    'Hiển thị các học phần
                    grcCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(ID_dt_new).DefaultView
                    txtTong_so_mon.Text = grvCTDTChiTiet.DataSource.Count
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_CT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdDelete_CT.ItemClick
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá chương trình đào tạo này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(grvChuongTrinhDaoTaoList.GetSelectedRows.GetValue(0))
                    Dim ID_dt As Integer = row("ID_dt")
                    Dim idx As Integer
                    'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                    'If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt) > 0 Then
                    idx = clsCTDT.Tim_idx(ID_dt)
                    If idx >= 0 Then
                        'Xoá các Học phần trong chương trình đào tạo khung
                        For i As Integer = 0 To clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.Count - 1
                            Dim objCTDTChiTiet As New ChuongTrinhDaoTaoChiTiet
                            objCTDTChiTiet = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(i)
                            clsCTDT.Delete_ChuongTrinhDaoTaoChiTiet(objCTDTChiTiet.ID_dt_mon)
                        Next
                        'Xóa ràng buộc Học phần
                        For i As Integer = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoRangBuoc.Count - 1 To 0 Step -1
                            Dim objCTDTRangBuoc As New ChuongTrinhDaoTaoMonHocRangBuoc
                            objCTDTRangBuoc = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i)
                            clsCTDT.XoaMonRangBuoc(objCTDTRangBuoc.ID_dt, objCTDTRangBuoc.ID_mon, objCTDTRangBuoc.ID_mon_rb)
                        Next
                        ' Xóa nhóm tự chọn
                        For i As Integer = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoNhomTuChon.Count - 1 To 0 Step -1
                            Dim objCTDTNhomTuChon As New ChuongTrinhDaoTaoNhomTuChon
                            objCTDTNhomTuChon = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoNhomTuChon.ChuongTrinhDaoTaoNhomTuChon(i)
                            clsCTDT.XoaNhomTuChon(objCTDTNhomTuChon.ID_dt, objCTDTNhomTuChon.Nhom_tu_chon)
                        Next
                        'Save Log 
                        Dim Noi_dung As String
                        Noi_dung = "Xoá chương trình đào tạo"
                        Noi_dung += " Hệ " + clsCTDT.ChuongTrinhDaoTao(idx).Ten_he
                        Noi_dung += " Khoa " + clsCTDT.ChuongTrinhDaoTao(idx).Ten_khoa
                        Noi_dung += " Khoá " + clsCTDT.ChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                        Noi_dung += " Chuyên ngành " + clsCTDT.ChuongTrinhDaoTao(idx).Chuyen_nganh
                        SaveLog(LoaiSuKien.Xoa, Noi_dung)
                        'Xoá chương trình đào tạo
                        clsCTDT.Delete_ChuongTrinhDaoTao(clsCTDT.ChuongTrinhDaoTao(idx).ID_dt)
                        'Xoá khỏi object
                        clsCTDT.Remove(idx)
                        Load_Data_CTDT()
                        Thongbao("Xoá chương trình đào tạo thành công")
                    End If
                    'Else
                    '    Thongbao("Chương trình đào tạo này đã nhập điểm, bạn không thể xoá được")
                    'End If
                End If
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCopy.ItemClick
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

    Private Sub cmdImport_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImport.ItemClick
        Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoImport
        frmESS_.ShowDialog(clsCTDT)
        'Load lại chương trình đào tạo đã Imports
        If frmESS_.Tag = "1" Then
            Me.Load_Data_CTDT()
        End If
    End Sub

    Private Sub cmdAdd_HP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd_HP.ItemClick
        Try
            Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoChonMon

            Dim rowIndex As Integer = -1
            rowIndex = grvCTDTChiTiet.GetSelectedRows.GetValue(0)
            If rowIndex < 0 Then Exit Sub


            Dim dtCTDTChiTiet As DataTable = grvCTDTChiTiet.DataSource.Table
            frmESS_.ShowDialog(clsCTDT, mID_he, mID_dt, dtCTDTChiTiet)
            If frmESS_.Tag = "1" Then
                Me.Load_Data_CTDT()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_HP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRemove_HP.ItemClick
        Try
            If Thongbao("Chắc chắn bạn muốn xoá học phần này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim rowIndex As Integer = -1
                rowIndex = grvCTDTChiTiet.GetSelectedRows.GetValue(0)
                Dim row As DataRow = grvCTDTChiTiet.GetDataRow(rowIndex)

                Dim dv As DataView = grvCTDTChiTiet.DataSource
                Dim ID_dt As Integer = row("ID_dt")
                Dim ID_mon As Integer = row("ID_mon")
                Dim Ten_mon As String = row("Ten_mon").ToString
                Dim ID_dt_mon As Integer = row("ID_dt_mon")
                Dim idx, idx1 As Integer
                'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                ' If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt, ID_mon) > 0 Then
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
                'Save Log 
                Dim Noi_dung As String
                Noi_dung = "Xoá học phần " + Ten_mon + " trong chương trình đào tạo"
                Noi_dung += " Hệ " + clsCTDT.ChuongTrinhDaoTao(idx).Ten_he
                Noi_dung += " Khoa " + clsCTDT.ChuongTrinhDaoTao(idx).Ten_khoa
                Noi_dung += " Khoá " + clsCTDT.ChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                Noi_dung += " Chuyên ngành " + clsCTDT.ChuongTrinhDaoTao(idx).Chuyen_nganh
                SaveLog(LoaiSuKien.Xoa, Noi_dung)
                'Xoa DataGridView
                dv.Item(rowIndex).Delete()
                dv.Table.AcceptChanges()
                Thongbao("Xoá học phần thành công")
                'Else
                '    Thongbao("Học phần này đã nhập điểm, bạn không thể xoá được")
                'End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_TheoKy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_TheoKy.ItemClick
        Try
            Dim dv1 As DataView = grvCTDTChiTiet.DataSource
            If dv1.Count <= 0 Then Exit Sub
            Dim dt As DataTable = dv1.Table.Copy
            Dim dtMain As DataTable = dv1.ToTable(True, "Ky_thu")
            Dim Tieu_de_bao_cao As String = ""
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)
                Tieu_de_bao_cao = "HỆ: " & row("Ten_he").ToString.ToUpper & "  KHOÁ: " & row("Khoa_hoc").ToString.ToUpper & "  CHUYÊN NGÀNH: " & row("Ten_chuyen_nganh").ToString.ToUpper
            Else
                Tieu_de_bao_cao = ""
            End If
            'Dim rpt As New rptESS_ChuongTrinhDaoTaoKhung(dtMain, dt, Tieu_de_bao_cao)
            Dim rpt As New rpt_Khung_CTDT_TheoKy(dtMain, dt, Tieu_de_bao_cao)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_TheoKhoiKT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_TheoKhoiKT.ItemClick
        Try
            'Devexpress Report. modified by anhnt
            Dim dv1 As DataView = grvCTDTChiTiet.DataSource
            If dv1.Count <= 0 Then Exit Sub
            Dim dt As DataTable = dv1.Table.Copy
            Dim paraString(1) As String
            paraString(0) = "Kien_thuc"
            paraString(1) = "Ten_kien_thuc"
            Dim dtMain As DataTable = dv1.ToTable(True, paraString)
            Dim Tieu_de_bao_cao As String = ""
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)
                Tieu_de_bao_cao = "HỆ: " & row("Ten_he").ToString.ToUpper & "  KHOÁ: " & row("Khoa_hoc").ToString.ToUpper & "  CHUYÊN NGÀNH: " & row("Ten_chuyen_nganh").ToString.ToUpper
            Else
                Tieu_de_bao_cao = ""
            End If
            'Dim rpt As New rptESS_ChuongTrinhDaoTaoKhungKT(dtMain, dt, Tieu_de_bao_cao)
            Dim rpt As New rpt_Khung_CTDT_KhoiKienThuc(dtMain, dt, Tieu_de_bao_cao)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdNhomTuChon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNhomTuChon.Click
        Try
            Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoMonChon

            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)

                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập nhóm Học phần tự chọn !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdGanLop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGanLop.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoGanLop
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)
                Dim ID_he As Integer = row("ID_he")
                Dim ID_khoa As Integer = row("ID_khoa")
                Dim Khoa_hoc As Integer = row("Khoa_hoc")
                Dim ID_chuyen_nganh As Integer = row("ID_chuyen_nganh")
                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để gán lớp")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRangBuoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRangBuoc.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_ChuongTrinhDaoTaoRangBuocMonHoc
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)

                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập các ràng buộc !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdChungChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChungChi.Click
        Try
            Dim frm As New frmESS_ChuongTrinhDaoTao_ThietLapMonChungChi
            If Not grvCTDTChiTiet.GetFocusedDataRow Is Nothing Then
                Dim ID_dt As Integer = grvCTDTChiTiet.GetFocusedDataRow()("ID_dt")
                frm.ShowDialog(ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập nhóm môn tự chọn !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdUpdate_Diem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUpdate_Diem.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dv As DataView = grvChuongTrinhDaoTaoList.DataSource
            If Not grvChuongTrinhDaoTaoList.GetFocusedDataRow Is Nothing Then
                Dim SQL As String = ""
                Dim SQL1 As String = ""

                mID_dt = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("ID_dt")
                Dim mID_chuyen_nganh As Integer = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("ID_chuyen_nganh")
                Dim mKhoa_hoc As Integer = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("Khoa_hoc")
                Dim mID_he As Integer = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("ID_he")
                Dim mNien_khoa As String = ""
                Dim mID_lop As String = ""
                Dim dtCheck As DataTable
                '-----------Tien Hanh Update----------- 
                Dim dt_sv As DataTable = UDB.SelectTable("SELECT DISTINCT ID_lop, Nien_khoa FROM STU_LOP WHERE Tinh_chat=1 and ID_he=" & mID_he & " AND Khoa_hoc=" & mKhoa_hoc & " AND ID_dt=" & mID_dt)
                If dt_sv.Rows.Count > 0 Then
                    mNien_khoa = dt_sv.Rows(0)("Nien_khoa").ToString
                    For k As Integer = 0 To dt_sv.Rows.Count - 1
                        mID_lop += dt_sv.Rows(k)("ID_lop").ToString & ","
                    Next
                    Dim Lop As String = mID_lop.Substring(0, mID_lop.Length - 1)
                    'mID_lop = dt_sv.Rows(0)("ID_lop").ToString
                    Dim dtDSSV As DataTable = UDB.SelectTable("select DISTINCT a.ID_sv from STU_HoSoSinhVien a inner join STU_DanhSach b on a.ID_sv = b.ID_sv inner join STU_Lop c on c.ID_lop = b.ID_lop where b.ID_lop In ( " & Lop & ")")
                    Dim dv_ctdt As DataView = grvCTDTChiTiet.DataSource
                    For i As Integer = 0 To dv_ctdt.Count - 1
                        Dim mHoc_ky As Integer
                        Dim mNam_hoc As String = ""
                        HocKy_Nam_Hoc(dv_ctdt.Item(i)("Ky_thu"), mNien_khoa, mHoc_ky, mNam_hoc)
                        If mHoc_ky > 0 And mNam_hoc <> "" Then
                            SQL = "UPDATE MARK_Diem SET Hoc_ky=" & mHoc_ky & ", Nam_hoc='" & mNam_hoc & "' WHERE ID_dt=" & mID_dt & _
                            " AND ID_mon =" & dv_ctdt.Item(i)("ID_mon")
                            If dtDSSV.Rows.Count > 0 Then
                                For j As Integer = 0 To dtDSSV.Rows.Count - 1
                                    dtCheck = UDB.SelectTable("Select * from Mark_diem where Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_sv = " & dtDSSV.Rows(j)("ID_sv") & " AND ID_mon = " & dv_ctdt.Item(i)("ID_mon") & " AND ID_dt = " & mID_dt)
                                    If dtCheck.Rows.Count = 0 Then
                                        SQL1 = "UPDATE MARK_Diem set ID_dt = " & mID_dt & " where Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_sv = " & dtDSSV.Rows(j)("ID_sv") & " AND ID_mon = " & dv_ctdt.Item(i)("ID_mon")
                                        Try
                                            UDB.Execute(SQL1)
                                        Catch ex As Exception
                                            Thongbao("Kiểm tra lại dữ liệu !", MsgBoxStyle.Information)
                                        End Try
                                    End If
                                Next
                            End If
                            Try
                                UDB.Execute(SQL)
                            Catch ex As Exception
                                Thongbao("Kiểm tra lại dữ liệu !", MsgBoxStyle.Information)
                            End Try
                        End If
                    Next
                    Thongbao("Cập nhật thành công !", MsgBoxStyle.Information)
                End If
            Else
                mID_dt = 0
            End If

        Catch ex As Exception
            Exit Sub
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Const NotFoundText As String = "???"
    Private Sub RepositoryItemLookUpEdit1_CustomDisplayText(sender As Object, e As CustomDisplayTextEventArgs) Handles RepositoryItemLookUpEdit1.CustomDisplayText
        Try
            Dim props As RepositoryItemLookUpEdit
            If TypeOf sender Is LookUpEdit Then
                props = (TryCast(sender, LookUpEdit)).Properties
            Else
                props = TryCast(sender, RepositoryItemLookUpEdit)
            End If

            If props IsNot Nothing AndAlso (TypeOf e.Value Is Integer) Then
                Dim row As Object = props.GetDataSourceRowByKeyValue(e.Value)
                If row Is Nothing Then
                    e.DisplayText = NotFoundText
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class