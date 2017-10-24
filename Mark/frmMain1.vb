Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports ESS.Catalogue
Partial Public Class frmMain1
    Inherits RibbonForm
    Dim Loader As Boolean = False
#Region "User Functions"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.     
        'UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
    End Sub
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
                    frmESS_ = New frmESS_ThamSoHeThong
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
                Case 32201
                    frmESS_ = New frmESS_DMHeDaoTao
                Case 3219
                    frmESS_ = New frmESS_TieuDeBaoCao(gobjUser)
                Case 3221
                    frmESS_ = New frmESS_DMMonHoc
                Case 3222
                    frmESS_ = New frmESS_DMCoSoDaoTao
                Case 3223
                    frmESS_ = New frmESS_DMToaNha
                Case 3224
                    frmESS_ = New frmESS_DMTang
                Case 3225
                    frmESS_ = New frmESS_DMPhongHoc
                Case 323
                    'frmESS_ = New frmESSChuongTrinhDaoTaoList
                    frmESS_ = New frmESS_ChuongTrinhDaoTaoList
                Case 325
                    frmESS_ = New frmESS_ToChucThiList
                Case 326
                    frmESS_ = New frmESS_DanhSachKhongDuDieuKienDuThiHocPhi
                Case 327
                    frmESS_ = New frmESS_ToChucThiDongTui
                Case 328
                    frmESS_ = New frmTongHopSinhVienThiLai

                Case 330
                    frmESS_ = New frmTongHopSinhVienHocLai

                Case 329
                    frmESS_ = New frmESS_DongTuiThi
                Case 332
                    frmESS_ = New frmESS_NhapDiemThanhPhanLop
                Case 333
                    frmESS_ = New frmESS_NhapDiemThiLop
                    'Case 334
                    '    frmESS_ = New frmESS_NhapDiemExcel
                Case 335
                    frmESS_ = New frmESS_NhapDiemThiPhong
                Case 336
                    frmESS_ = New frmESS_TongHop_ThiLaiHocLai_DanhSach
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
                Case 3511
                    frmESS_ = New frmESS_TongHopDiemMonMain
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
                Case 364
                    frmESS_ = New frmESS_PhanCongThucTap
                Case 365
                    frmESS_ = New frmESS_NoKhacKhiXetTotNghiep
                Case 366
                    frmESS_ = New frmESS_XetTotNghiep
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
        Dim idx As Integer = 0
        'Chương trình đào tạo
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 18 Then

                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavChuongTrinhDaoTao.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuChuongTrinhDaoTao.AddItem(xBarItem)
                idx += 1
            End If
        Next
        'Quản lý và tổ chức thi
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 10 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavToChucThi.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuToChucThi.AddItem(xBarItem)
                idx += 1
            End If
        Next
        'Quá trình điểm
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 3 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavQuaTrinhDiem.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuQuaTrinhDiem.AddItem(xBarItem)
                idx += 1
            End If
        Next


        'Tong hop Bao cao
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 5 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavTongHopBaoCao.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuTongHopBaoCao.AddItem(xBarItem)
                idx += 1
            End If
        Next
        'Xét duyệt
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 11 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavXetDuyet.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuXetDuyet.AddItem(xBarItem)
                idx += 1
            End If
        Next

        'Tim Kiem
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 4 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavTimKiem.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuTimKiem.AddItem(xBarItem)
                idx += 1
            End If
        Next


        'Danh muc
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 2 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavDanhMuc.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuDanhMuc.AddItem(xBarItem)
                idx += 1
            End If
        Next

        'Hệ thống
        idx = 0
        For i As Integer = 0 To gobjUser.Quyen.Count - 1
            If gobjUser.Quyen.Quyen(i).ID_nhom_quyen = 1 Then
                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavHeThong.ItemLinks.Add(NavItem)

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.Quyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.Quyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                menuHeThong.AddItem(xBarItem)
                idx += 1
            End If
        Next
    End Sub

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
        staInfomation.Caption = "CHỨC NĂNG: " & frmESS_.Text & " - NGƯỜI DÙNG: " & gobjUser.FullName & " - HÒM THƯ: " & gobjUser.Email & " -ĐANG SỬ DỤNG"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub
#End Region

    Private Sub frmMain1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCheckVersion() = "1" Then
            End
        End If

        'Đăng nhập chương trình
        Dim frm As New frmESS_Login
        frm.ShowDialog()
        'Đăng nhập thành công
        If frm.Tag = 1 Then
            'Load chuc nang
            Load_chuc_nang()

            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = RibMain.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                menuStyle.ItemLinks.Add(item)
            Next skin

            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If
    End Sub

    Private Sub frmMain1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            SaveLog(LoaiSuKien.Them, "Người dùng: " & gobjUser.UserName & " - đăng xuất khỏi hệ thống")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub NavBarMain_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMain.LinkClicked
        If Not e.Link.Item Is Nothing Then
            Show_form(e.Link.Item.Tag, e.Link.Item.Caption)
        End If
    End Sub

    Private Sub RibMain_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibMain.ItemClick
        If Not e.Item.Tag Is Nothing Then
            Show_form(e.Link.Item.Tag, e.Link.Item.Caption)
        End If
    End Sub

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        DefaultLookAndFeelMain.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub


End Class