Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports ESS.Catalogue
Partial Public Class frmESS_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Dim Loader As Boolean = False
    Public Sub New()
        InitializeComponent()
        InitEditors()
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
    End Sub

    Private Sub frmESS_Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            SaveLog(LoaiSuKien.Them, "Người dùng: " & gobjUser.UserName & " - đăng xuất khỏi hệ thống")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub InitEditors()
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
        biStyle.EditValue = RibMain.RibbonStyle
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        If UCheckVersion() = "1" Then
            End
        End If

        'Đăng nhập chương trình
        Dim frm As New frmESS_Login
        frm.ShowDialog()
        'Đăng nhập thành công
        If frm.Tag = 1 Then
            RibMain.ForceInitialize()
            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = RibMain.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                mnuPainStyle.ItemLinks.Add(item)
            Next skin
            'Load chuc nang
            Load_chuc_nang()
            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If

    End Sub

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub


    Private Sub ribMain_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibMain.ItemClick
        If Not e.Item.Tag Is Nothing AndAlso IsNumeric(e.Item.Tag) Then
            Show_form(e.Item.Tag, e.Item.Caption)
        End If
    End Sub

    Private Sub biStyle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biStyle.EditValueChanged
        RibMain.RibbonStyle = CType(biStyle.EditValue, RibbonControlStyle)
    End Sub

    Private Sub mnuPainStyle_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPainStyle.Popup
        For Each link As BarItemLink In mnuPainStyle.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = defaultLookAndFeel1.LookAndFeel.ActiveSkinName
        Next link
    End Sub


#Region "Funs"
    Private Sub Show_form(ByVal FunctionID As String, ByVal Caption As String)
        Try
            gFunctionID = FunctionID
            Dim frmESS_ As Form = Nothing
            Select Case FunctionID
                Case 316
                    frmESS_ = New frmESS_KhoaDulieuDiemThiTheoPhong
                Case 317
                    frmESS_ = New frmESS_KhoaDiemHocPhanDotThi
                Case 318
                    frmESS_ = New frmESS_KhoaDuLieuDiemThanhPhanLop
                Case 319
                    frmESS_ = New frmESS_KhoaDulieuDiemThiLopHC
                Case 320
                    frmESS_ = New frmESS_ThanhPhanDiem
                Case 321
                    frmESS_ = New frmESS_ChangePassword
                Case 322
                    frmESS_ = New frmESS_ThamSoQuyChe
                Case 3210
                    frmESS_ = New frmESS_DanhSachKhongDuDieuKienDuThiHocPhan
                Case 3211
                    frmESS_ = New frmESS_DMNganhDaoTao
                Case 3212
                    frmESS_ = New frmESS_DMChuyenNganh
                Case 3213
                    frmESS_ = New frmESS_DMXepHangHocLuc
                Case 3214
                    frmESS_ = New frmESS_DMXepHangTotNghiep
                Case 3215
                    frmESS_ = New frmESS_DMXepHangNamDaoTao
                Case 3216
                    frmESS_ = New frmESS_DMXepLoaiHocTap
                Case 3217
                    frmESS_ = New frmESS_DMLoaiChungChi
                Case 3218
                    frmESS_ = New frmESS_DMXepLoaiChungChi
                Case 3219
                    frmESS_ = New frmESS_TieuDeBaoCao(gobjUser)
                Case 3220
                    frmESS_ = New frmESS_DMPhongHoc
                Case 3221
                    frmESS_ = New frmESS_DMTienHocBu
                Case 3222
                    frmESS_ = New frmESS_DMToaNha
                Case 3223
                    frmESS_ = New frmESS_DMTang
                Case 3224
                    frmESS_ = New frmESS_BoMon_DanhSach
                Case 3225
                    frmESS_ = New frmESS_DM_MonHoc(gobjUser)

                Case 32201
                    frmESS_ = New frmESS_DMHeDaoTao
                Case 323
                    frmESS_ = New frmESS_ChuongTrinhDaoTaoList
                Case 325
                    frmESS_ = New frmESS_ToChucThi_DanhSach
                Case 326
                    frmESS_ = New frmESS_DanhSachKhongDuDieuKienDuThiHocPhi
                Case 327
                    frmESS_ = New frmESS_ToChucThiDongTui
                Case 328
                    'frmESS_ = New frmESS_TongHopSinhVienThiLai
                    'frmESS_ = New frmTongHopThiLai
                    'Case 330
                    '    frmESS_ = New frmESS_XetLenLop
                Case 340
                    frmESS_ = New frmTongHopSinhVienHocLai
                    'Case 341
                    '    frmESS_ = New frmTongHopSinhVienHocLai_NopTien
                    'frmTongHopTienHocLai()
                    'frmTongHopSinhVienHocLai_Tien
                    'Case 342
                    '    frmESS_ = New frmTongHopTienThiLai
                Case 329
                    frmESS_ = New frmESS_DongTuiThi
                Case 332
                    frmESS_ = New frmESS_NhapDiemThanhPhanLop
                Case 333
                    frmESS_ = New frmESS_NhapDiemThiLop
                Case 3312
                    frmESS_ = New frmESS_DiemRenLuyen
                    'Case 334
                    '    frmESS_ = New frmESS_NhapDiemExcel
                Case 335
                    frmESS_ = New frmESS_NhapDiemThiPhong
                    'Case 336
                    '    frmESS_ = New frmESS_TongHop_ThiLaiHocLai_DanhSach
                Case 339
                    frmESS_ = New frmESS_NhapDiemTuiThi
                Case 3310
                    frmESS_ = New frmESS_NhapDiemThiSBD
                Case 3311
                    frmESS_ = New frmESS_NhapDiemSoPhach
                Case 353
                    frmESS_ = New frmESS_TongHopHocKy
                Case 354 'Tong hop diem theo nam
                    frmESS_ = New frmESS_TongHopHocTapNam
                Case 355
                    frmESS_ = New frmESS_TongHopHocToanKhoa
                    'Case 3511
                    '    frmESS_ = New frmESS_TongHopDiemMonMain
                Case 3512
                    frmESS_ = New frmESS_BangDiemChiTietSinhVien
                Case 3513
                    frmESS_ = New frmESS_TongHopNoChungChi_
                Case 361
                    frmESS_ = New frmESS_XetHocTiepThoiHocNgungHoc
                Case 362
                    frmESS_ = New frmESS_QuyetDinhThoiHocList
                Case 363
                    frmESS_ = New frmESS_XetLuanVanThiTotNghiep
                    'Case 364
                    '    frmESS_ = New frmESS_PhanCongThucTap
                    'Case 365
                    '    frmESS_ = New frmESS_NoKhacKhiXetTotNghiep
                Case 366
                    frmESS_ = New frmESS_XetTotNghiep
                    'Case 367
                    '    frmESS_ = New frmESS_TongHopChung
                Case 368
                    frmESS_ = New frmESS_InChungChi_List
                Case 3226
                    frmESS_ = New frmESS_DMKhoiKienThuc
            End Select
            If Not frmESS_ Is Nothing Then
                frmESS_.Text = Caption
                Me.FormSelected(frmESS_)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub Load_chuc_nang()
        'Chương trình đào tạo
        Dim idx As Integer = 0
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 18 Then
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                xBarItem.Width = 500
                mnuChuongTrinhDaoTao.AddItem(xBarItem)
                ribChuongTrinhDaoTao.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next

        'Tổ chức thi
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 10 Then
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuToChucThi.AddItem(xBarItem)
                RibToChucThi.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next

        'Quá trình điểm
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 3 Then
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuQuaTrinhDiem.AddItem(xBarItem)
                RibQuaTrinhDiem.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next

        'Tổng hợp báo cáo
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 5 Then
                ' Add Item to NavBarGroup
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuTongHopBaoCao.AddItem(xBarItem)
                RibTongHopBaoCao.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next


        'Xét duyệt
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 11 Then
                ' Add Item to NavBarGroup
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuXetDuyet.AddItem(xBarItem)
                RibXetDuyet.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next

        'Tìm kiếm
        'idx = 0
        'For i As Integer = 0 To gobjUser.Quyen.Count - 1
        '    If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 4 Then
        '        ' Add Item to NavBarGroup
        '        Dim xBarItem As New BarButtonItem
        '        xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
        '        xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
        '        xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
        '        xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
        '        xBarItem.ImageIndex = idx
        '        xBarItem.RibbonStyle = RibbonItemStyles.Large
        '        mnuTimKiem.AddItem(xBarItem)
        '        RibTimKiem.Groups(0).ItemLinks.Add(xBarItem)
        '        idx += 1
        '    End If
        'Next

        'Danh mục
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 2 Then
                ' Add Item to NavBarGroup
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuDanhMuc.AddItem(xBarItem)
                RibDanhMuc.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next

        'Hệ thống
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 1 Then
                ' Add Item to NavBarGroup
                Dim xBarItem As New BarButtonItem
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large
                mnuHeThong.AddItem(xBarItem)
                RibHeThong.Groups(0).ItemLinks.Add(xBarItem)
                idx += 1
            End If
        Next
    End Sub
    'Private Sub HienThi_ESSchuc_nang()
    '    Dim idx As Integer = 0
    '    'Sinh vien Nhap truong
    '    For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
    '        If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 9 Then

    '            Dim xBarItem As New BarButtonItem
    '            'xBarItem = BarMain.Items.Item(0)
    '            xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
    '            xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
    '            xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
    '            xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
    '            xBarItem.ImageIndex = idx
    '            mnuHeThong.AddItem(xBarItem)
    '            ribHeThong.Groups(0).ItemLinks.Add(xBarItem)
    '            idx += 1
    '        End If
    '    Next


    'End Sub
    Private Function CheckFormExist(ByVal frmESS_ As Form) As Boolean
        For Each frmESS_Children As Form In Me.MdiChildren
            If frmESS_Children.Name = frmESS_.Name Then
                frmESS_Children.Select()
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub FormSelected(ByVal frmESS_ As Form)
        If CheckFormExist(frmESS_) Then Exit Sub
        'frmESS_.Text = "Mã chức năng " & FunctionID
        'staInfomation.Caption = "CHỨC NĂNG: " & frmESS_.Text & " - NGƯỜI DÙNG: " & gobjUser.FullName.ToUpper & " - PHÒNG: " & gobjUser.Phong_ban.ToUpper & " -ĐANG SỬ DỤNG"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub
#End Region


End Class
