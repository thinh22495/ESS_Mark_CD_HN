
Imports C1.Win.C1Report
Imports ESS.BLL.Business
Module mdlBaoCaoTongHop
    Private Const gDonvi_do As Double = 567 '=1 cm . Chuyển đổi từ hệ số đo Twips sang Centimeter
    Private Const gPointToCm As Double = 28.3   '=1 cm. Chuyển đổi từ hệ số đo Point sang Centimeter
    Private Const PageWidthA4 As Double = gDonvi_do * 21
    Private Const PageHeightA4 As Double = gDonvi_do * 29.7
    Private Const PageWidthA3 As Double = gDonvi_do * 29.7
    Private Const PageHeightA3 As Double = gDonvi_do * 42

    Public Sub TaoBaoCaoTongHopDiem(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de_hoc_trinh As String, ByVal clsDiem As Diem_BLL)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 2.5
        objBaocao.PageHeaderHeight1 = gDonvi_do * 0.5
        objBaocao.DetailHeight = gDonvi_do * 0.9
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de_hoc_trinh = Tieu_de_hoc_trinh
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.5
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 5
        objBaoCaoChiTiet.FieldID = "TBCHT"
        objBaoCaoChiTiet.FieldName = "TBCHT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.3
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Xep_loai"
        objBaoCaoChiTiet.FieldName = "Xếp loại"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "So_mon_no"
        objBaoCaoChiTiet.FieldName = "Nợ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Add group số học trình
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "So_hoc_trinh"
        objBaoCaoChiTiet.FieldName = "Số học trình"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeFix
        objBaoCaoChiTiet.FieldTop = gDonvi_do * 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.LineTop = True
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)
        'Tạo các cột môn học
        Dim So_hoc_phan As Integer = 0
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            If clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                So_hoc_phan += 1
            End If
        Next
        FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (So_hoc_phan)
        FieldLeft = FieldSizeFix * gDonvi_do
        'Thiết lập các trường môn học báo cáo
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                If .Khong_tinh_TBCHT = False Then
                    'Add Môn học
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "M" + .ID_mon.ToString
                    objBaoCaoChiTiet.FieldName = .Ten_mon.ToString
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.So_hoc_trinh = .So_hoc_trinh
                    objBaoCaoChiTiet.ColFix = False
                    objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                    'Add group số học trình
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "So_hoc_trinh" + .ID_mon.ToString
                    objBaoCaoChiTiet.FieldName = .So_hoc_trinh.ToString
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                    objBaoCaoChiTiet.FieldTop = gDonvi_do * 2
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
                    objBaoCaoChiTiet.FieldLeft = FieldLeft
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.ColFix = False
                    objBaoCaoChiTiet.LineTop = True
                    objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)
                    FieldLeft += FieldWidth
                End If
            End With
        Next
        objBaocao.TaoBaoCao()
    End Sub
    Public Sub TaoBaoCaoTongHopDiemChiTiet(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de_hoc_trinh As String, ByVal clsDiem As Diem_BLL, ByVal dtDiemTH As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldSizeGroup, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 2.5
        objBaocao.PageHeaderHeight1 = gDonvi_do * 0.5
        objBaocao.DetailHeight = gDonvi_do * 0.9
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de_hoc_trinh = Tieu_de_hoc_trinh
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.5
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 5
        objBaoCaoChiTiet.FieldID = "TBCHT"
        objBaoCaoChiTiet.FieldName = "TBCHT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.3
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Xep_loai"
        objBaoCaoChiTiet.FieldName = "Xếp loại"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "So_mon_no"
        objBaoCaoChiTiet.FieldName = "Nợ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Add group số học trình
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "So_hoc_trinh"
        objBaoCaoChiTiet.FieldName = "Số học trình"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeFix
        objBaoCaoChiTiet.FieldTop = gDonvi_do * 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.LineTop = True
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)
        'Tạo các cột môn học
        'Đếm số thành phần điểm
        Dim So_thanh_phan As Integer = 0
        For i As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
            If clsDiem.ThanhPhanDiem.ThanhPhanDiem(i).Checked Then
                So_thanh_phan += 1
            End If
        Next
        'Cộng thêm cột điểm Thi và TBCHP
        So_thanh_phan += 2
        Dim So_hoc_phan As Integer = 0
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            If clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                So_hoc_phan += 1
            End If
        Next
        FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (So_thanh_phan)
        FieldLeft = FieldSizeFix * gDonvi_do
        For i As Integer = 0 To clsDiem.MonHoc.Count - 1
            FieldSizeGroup = 0
            With clsDiem.MonHoc.ChuongTrinhDaoTaoChiTiet(i)
                If .Khong_tinh_TBCHT = False Then
                    'Voi diem thanh phan
                    Dim col As New DataColumn("T" + .ID_mon.ToString + "Thi")
                    For j As Integer = 0 To clsDiem.ThanhPhanDiem.Count - 1
                        col = New DataColumn("T" + .ID_mon.ToString + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString)
                        If dtDiemTH.Columns.Contains(col.ColumnName) Then
                            objBaoCaoChiTiet = New BaoCaoChiTietTruong
                            objBaoCaoChiTiet.STT = i + 7
                            objBaoCaoChiTiet.FieldID = "T" + .ID_mon.ToString + clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).ID_thanh_phan.ToString
                            objBaoCaoChiTiet.FieldName = clsDiem.ThanhPhanDiem.ThanhPhanDiem(j).Ky_hieu
                            objBaoCaoChiTiet.FieldType = 1
                            objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                            objBaoCaoChiTiet.FieldTop = gDonvi_do * 1
                            objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                            objBaoCaoChiTiet.FieldAlign = 2
                            objBaoCaoChiTiet.FieldObject = 1
                            objBaoCaoChiTiet.ColFix = False
                            objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                            FieldSizeGroup += FieldWidth / gDonvi_do
                            FieldLeft += FieldWidth
                        End If
                    Next
                    'Voi diem thi
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "T" + .ID_mon.ToString + "Thi"
                    objBaoCaoChiTiet.FieldName = "Thi"
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                    objBaoCaoChiTiet.FieldTop = gDonvi_do * 1
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.ColFix = False
                    objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                    FieldSizeGroup += FieldWidth / gDonvi_do
                    FieldLeft += FieldWidth
                    'Voi TBCHP
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "M" + .ID_mon.ToString
                    objBaoCaoChiTiet.FieldName = "TBC"
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                    objBaoCaoChiTiet.FieldTop = gDonvi_do * 1
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.ColFix = False
                    objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                    FieldSizeGroup += FieldWidth / gDonvi_do
                    FieldLeft += FieldWidth
                    'Add group tên môn
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "Ten_mon" + .ID_mon.ToString
                    objBaoCaoChiTiet.FieldName = .Ten_mon
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldSizeGroup
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                    objBaoCaoChiTiet.FieldLeft = FieldLeft - FieldSizeGroup * gDonvi_do
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.ColFix = False
                    objBaoCaoChiTiet.LineTop = False
                    objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)
                    'Add group số học trình
                    objBaoCaoChiTiet = New BaoCaoChiTietTruong
                    objBaoCaoChiTiet.STT = i + 7
                    objBaoCaoChiTiet.FieldID = "So_hoc_trinh" + .ID_mon.ToString
                    objBaoCaoChiTiet.FieldName = .So_hoc_trinh.ToString
                    objBaoCaoChiTiet.FieldType = 1
                    objBaoCaoChiTiet.FieldSize = FieldSizeGroup
                    objBaoCaoChiTiet.FieldTop = gDonvi_do * 2
                    objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
                    objBaoCaoChiTiet.FieldLeft = FieldLeft - FieldSizeGroup * gDonvi_do
                    objBaoCaoChiTiet.FieldAlign = 2
                    objBaoCaoChiTiet.FieldObject = 1
                    objBaoCaoChiTiet.ColFix = False
                    objBaoCaoChiTiet.LineTop = True
                    objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)
                End If
            End With
        Next
        objBaocao.TaoBaoCao()
    End Sub
    Public Sub TaoBaoCaoBangDiemThanhPhan(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldSizeGroup, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1.5
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.5
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "So_tiet_nghi"
        objBaoCaoChiTiet.FieldName = "Số tiết nghỉ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Cộng cột ghi chú cuối cùng
        FieldLeft = FieldSizeFix * gDonvi_do
        FieldSizeFix += 3.8
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm môn thành phần
            FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (dtTP.Rows.Count + 1)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New BaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 4
                objBaoCaoChiTiet.FieldID = "TP" + dtTP.Rows(i)("ID_thanh_phan").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ten_thanh_phan").ToString + " (" + dtTP.Rows(i)("Ty_le").ToString + ")"
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                FieldLeft += FieldWidth
                FieldSizeGroup += FieldWidth / gDonvi_do
            Next
            'Voi TBCHP
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            objBaoCaoChiTiet.STT = 10
            objBaoCaoChiTiet.FieldID = "TBCBP"
            objBaoCaoChiTiet.FieldName = "TBC"
            objBaoCaoChiTiet.FieldType = 1
            objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
            objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
            objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
            objBaoCaoChiTiet.FieldAlign = 2
            objBaoCaoChiTiet.FieldObject = 1
            objBaoCaoChiTiet.ColFix = False
            objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            FieldLeft += FieldWidth
            FieldSizeGroup += FieldWidth / gDonvi_do
        End If
        'Add group thanh phan
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 11
        objBaoCaoChiTiet.FieldID = "Ten_mon"
        objBaoCaoChiTiet.FieldName = "Điểm thành phần"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeGroup
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldLeft = FieldLeft - (FieldSizeGroup * gDonvi_do)
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.ColFix = False
        objBaoCaoChiTiet.LineTop = False
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 11
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 3.8
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        objBaocao.TaoBaoCao_DiemThanhPhan()
    End Sub
    Public Sub TaoBaoCaoBangDiemThiHocPhan(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable, ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldSizeGroup, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1.5
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo.ToUpper
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = "1"
            objBaocao.Tieu_de_chuc_danh2 = "2"
            objBaocao.Tieu_de_nguoi_ky1 = "3"
            objBaocao.Tieu_de_nguoi_ky2 = "- Số đã đạt điểm từ 5.0 đến 6.5: "
            objBaocao.Tieu_de_noi_ky = "- Số đã đạt điểm dưới 5.0: "
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.5
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Cộng cột điểm thi, TBCHP, ghi chú cuối cùng
        FieldLeft = FieldSizeFix * gDonvi_do
        FieldSizeFix += 4.5
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm môn thành phần
            FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (dtTP.Rows.Count + 1)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New BaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 4
                objBaoCaoChiTiet.FieldID = "TP" + dtTP.Rows(i)("ID_thanh_phan").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ten_thanh_phan").ToString + " (" + dtTP.Rows(i)("Ty_le").ToString + ")"
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                FieldLeft += FieldWidth
                FieldSizeGroup += FieldWidth / gDonvi_do
            Next
            'Voi TBCHP
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            objBaoCaoChiTiet.STT = 10
            objBaoCaoChiTiet.FieldID = "TBCBP"
            objBaoCaoChiTiet.FieldName = "TBC"
            objBaoCaoChiTiet.FieldType = 1
            objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
            objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
            objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
            objBaoCaoChiTiet.FieldAlign = 2
            objBaoCaoChiTiet.FieldObject = 1
            objBaoCaoChiTiet.ColFix = False
            objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            FieldLeft += FieldWidth
            FieldSizeGroup += FieldWidth / gDonvi_do
        End If
        'Add group thanh phan
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 11
        objBaoCaoChiTiet.FieldID = "Ten_mon"
        objBaoCaoChiTiet.FieldName = "Điểm thành phần"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeGroup
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldLeft = FieldLeft - (FieldSizeGroup * gDonvi_do)
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.ColFix = False
        objBaoCaoChiTiet.LineTop = False
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCHP"
        objBaoCaoChiTiet.FieldName = "TBCHP"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.3
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_DiemThi_LopHC(XS, Gioi, Kha, TB, KDat)
    End Sub
    Public Sub TaoBaoCaoBangDiemThiHocPhanTheoSoPhach(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable, ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldSizeGroup, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1.5
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo.ToUpper
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = "1"
            objBaocao.Tieu_de_chuc_danh2 = "2"
            objBaocao.Tieu_de_nguoi_ky1 = "3"
            objBaocao.Tieu_de_nguoi_ky2 = "- Số đã đạt điểm từ 5.0 đến 6.5: "
            objBaocao.Tieu_de_noi_ky = "- Số đã đạt điểm dưới 5.0: "
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "So_phach"
        objBaoCaoChiTiet.FieldName = "Số phách"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Cộng cột điểm thi, TBCHP, ghi chú cuối cùng
        FieldLeft = FieldSizeFix * gDonvi_do
        FieldSizeFix += 7
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm môn thành phần
            FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (dtTP.Rows.Count + 1)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New BaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 4
                objBaoCaoChiTiet.FieldID = "TP" + dtTP.Rows(i)("ID_thanh_phan").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ten_thanh_phan").ToString + " (" + dtTP.Rows(i)("Ty_le").ToString + ")"
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                FieldLeft += FieldWidth
                FieldSizeGroup += FieldWidth / gDonvi_do
            Next
            'Voi TBCHP
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            objBaoCaoChiTiet.STT = 10
            objBaoCaoChiTiet.FieldID = "TBCBP"
            objBaoCaoChiTiet.FieldName = "TBC"
            objBaoCaoChiTiet.FieldType = 1
            objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
            objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
            objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
            objBaoCaoChiTiet.FieldAlign = 2
            objBaoCaoChiTiet.FieldObject = 1
            objBaoCaoChiTiet.ColFix = False
            objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            FieldLeft += FieldWidth
            FieldSizeGroup += FieldWidth / gDonvi_do
        End If
        'Add group thanh phan
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 11
        objBaoCaoChiTiet.FieldID = "Ten_mon"
        objBaoCaoChiTiet.FieldName = "Điểm thành phần"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeGroup
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldLeft = FieldLeft - (FieldSizeGroup * gDonvi_do)
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.ColFix = False
        objBaoCaoChiTiet.LineTop = False
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCHP"
        objBaoCaoChiTiet.FieldName = "TBCHP"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 3
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_DiemThi_LopHC(XS, Gioi, Kha, TB, KDat)
    End Sub
    Public Sub TaoBaoCaoBangDiemThiHocPhanTheoSoBaoDanh(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable, ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth, FieldSizeGroup, FieldLeft, FieldSizeFix As Double
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Trừ đi lề trái và lề phải
        PageWidth = PageWidth - (2 * gDonvi_do)
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1.5
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo.ToUpper
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = "1"
            objBaocao.Tieu_de_chuc_danh2 = "2"
            objBaocao.Tieu_de_nguoi_ky1 = "3"
            objBaocao.Tieu_de_nguoi_ky2 = "- Số đã đạt điểm từ 5.0 đến 6.5: "
            objBaocao.Tieu_de_noi_ky = "- Số đã đạt điểm dưới 5.0: "
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "So_bao_danh"
        objBaoCaoChiTiet.FieldName = "Số báo danh"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "So_phach"
        objBaoCaoChiTiet.FieldName = "Số phách"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        For i As Integer = 0 To objBaocao.BaoCaoChiTiet.Count - 1
            FieldSizeFix += objBaocao.BaoCaoChiTiet.BaoCaoChiTietTruong(i).FieldSize
        Next
        'Cộng cột điểm thi, TBCHP, ghi chú cuối cùng
        FieldLeft = FieldSizeFix * gDonvi_do
        FieldSizeFix += 7
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm môn thành phần
            FieldWidth = (PageWidth - FieldSizeFix * gDonvi_do) / (dtTP.Rows.Count + 1)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New BaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 4
                objBaoCaoChiTiet.FieldID = "TP" + dtTP.Rows(i)("ID_thanh_phan").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ten_thanh_phan").ToString + " (" + dtTP.Rows(i)("Ty_le").ToString + ")"
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
                objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                FieldLeft += FieldWidth
                FieldSizeGroup += FieldWidth / gDonvi_do
            Next
            'Voi TBCHP
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            objBaoCaoChiTiet.STT = 10
            objBaoCaoChiTiet.FieldID = "TBCBP"
            objBaoCaoChiTiet.FieldName = "TBC"
            objBaoCaoChiTiet.FieldType = 1
            objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
            objBaoCaoChiTiet.FieldTop = gDonvi_do * 0.5
            objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1
            objBaoCaoChiTiet.FieldAlign = 2
            objBaoCaoChiTiet.FieldObject = 1
            objBaoCaoChiTiet.ColFix = False
            objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            objBaoCaoChiTiet = New BaoCaoChiTietTruong
            FieldLeft += FieldWidth
            FieldSizeGroup += FieldWidth / gDonvi_do
        End If
        'Add group thanh phan
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 11
        objBaoCaoChiTiet.FieldID = "Ten_mon"
        objBaoCaoChiTiet.FieldName = "Điểm thành phần"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldSizeGroup
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 0.5
        objBaoCaoChiTiet.FieldLeft = FieldLeft - (FieldSizeGroup * gDonvi_do)
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaoCaoChiTiet.ColFix = False
        objBaoCaoChiTiet.LineTop = False
        objBaocao.BaoCaoGroup.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCHP"
        objBaoCaoChiTiet.FieldName = "TBCHP"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 3
        objBaoCaoChiTiet.FieldHeight = gDonvi_do * 1.5
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_DiemThi_LopHC(XS, Gioi, Kha, TB, KDat)
    End Sub
    Public Sub TaoBaoCaoDanhSachThi(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal Tieu_de4 As String, ByVal dtTP As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        objBaocao.Tieu_de4 = Tieu_de4
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_ten_truong = "KHOA, BỘ MÔN: ........................"
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_SV"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.3
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ngay_sinh"
        objBaoCaoChiTiet.FieldName = "Ngày sinh"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2.1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường môn học báo cáo
        'Add các cột điểm thành phần
        Dim width As Double = 0
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm môn thành phần
            'width = FieldWidth
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New BaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 5
                objBaoCaoChiTiet.FieldID = "TP" + dtTP.Rows(i)("ID_thanh_phan").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ky_hieu")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = 2
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                'FieldWidth += FieldWidth / gDonvi_do
                FieldWidth = FieldWidth - 2
            Next
        End If

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "So_to"
        objBaoCaoChiTiet.FieldName = "Số tờ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 0
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ky_nop"
        objBaoCaoChiTiet.FieldName = "Ký nộp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 0
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        FieldWidth = PageWidth - (1 + 2.3 + 4 + 2.5 + 5 + dtTP.Rows.Count * 2) * gDonvi_do

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ghi_chu_thi"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        objBaocao.TaoBaoCao_Modify()
    End Sub
    Public Sub TaoBaoCaoXetSVHoc2ChuyenNganh(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3


        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv1"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten1"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        FieldWidth = PageWidth - (0.8 + 2.2 + 4 + 2 + 2.5) * gDonvi_do
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_CongHoaDocLap_Cap3()
    End Sub
    Public Sub TaoBaoCao_PhanThucTap(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal Tieu_de4 As String)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As BaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        objBaocao.Tieu_de4 = Tieu_de4


        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv2"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten2"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop2"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        FieldWidth = PageWidth - (0.8 + 2.2 + 4 + 2 + 2.5) * gDonvi_do
        objBaoCaoChiTiet = New BaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "Noi_thuc_tap"
        objBaoCaoChiTiet.FieldName = "Nơi thực tập"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_CongHoaDocLap_Cap4()
    End Sub
End Module