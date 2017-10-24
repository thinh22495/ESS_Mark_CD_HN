<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain1))
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.staInfomation = New DevExpress.XtraBars.BarListItem
        Me.RibMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.imgMain2 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuChuongTrinhDaoTao = New DevExpress.XtraBars.BarSubItem
        Me.menuToChucThi = New DevExpress.XtraBars.BarSubItem
        Me.menuQuaTrinhDiem = New DevExpress.XtraBars.BarSubItem
        Me.menuTongHopBaoCao = New DevExpress.XtraBars.BarSubItem
        Me.menuXetDuyet = New DevExpress.XtraBars.BarSubItem
        Me.menuStyle = New DevExpress.XtraBars.BarSubItem
        Me.menuTimKiem = New DevExpress.XtraBars.BarButtonGroup
        Me.menuDanhMuc = New DevExpress.XtraBars.BarButtonGroup
        Me.menuHeThong = New DevExpress.XtraBars.BarButtonGroup
        Me.NavBarMain = New DevExpress.XtraNavBar.NavBarControl
        Me.NavHeThong = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavChuongTrinhDaoTao = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavToChucThi = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavQuaTrinhDiem = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavTongHopBaoCao = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavXetDuyet = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavTimKiem = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavDanhMuc = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem
        Me.imgMain1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DefaultLookAndFeelMain = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarAndDockingMain = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.imgChucNang = New System.Windows.Forms.ImageList(Me.components)
        Me.mdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.staInfomation)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 501)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibMain
        Me.RibbonStatusBar.Size = New System.Drawing.Size(904, 25)
        '
        'staInfomation
        '
        Me.staInfomation.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.staInfomation.Appearance.Options.UseFont = True
        Me.staInfomation.Caption = "PHẦN MỀM QUẢN LÝ HỌC TẬP"
        Me.staInfomation.Hint = "PHẦN MỀM QUẢN LÝ HỌC TẬP"
        Me.staInfomation.Id = 25
        Me.staInfomation.Name = "staInfomation"
        '
        'RibMain
        '
        Me.RibMain.AllowMinimizeRibbon = False
        Me.RibMain.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibMain.ExpandCollapseItem.Id = 0
        Me.RibMain.ExpandCollapseItem.Name = ""
        Me.RibMain.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        Me.RibMain.Images = Me.imgMain2
        Me.RibMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibMain.ExpandCollapseItem, Me.menuChuongTrinhDaoTao, Me.menuToChucThi, Me.menuQuaTrinhDiem, Me.menuTongHopBaoCao, Me.menuXetDuyet, Me.menuStyle, Me.staInfomation, Me.menuTimKiem, Me.menuDanhMuc, Me.menuHeThong})
        Me.RibMain.Location = New System.Drawing.Point(0, 0)
        Me.RibMain.MaxItemId = 29
        Me.RibMain.Name = "RibMain"
        Me.RibMain.PageHeaderItemLinks.Add(Me.menuStyle)
        Me.RibMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibMain.Size = New System.Drawing.Size(904, 48)
        Me.RibMain.StatusBar = Me.RibbonStatusBar
        '
        'imgMain2
        '
        Me.imgMain2.ImageStream = CType(resources.GetObject("imgMain2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMain2.TransparentColor = System.Drawing.Color.Magenta
        Me.imgMain2.Images.SetKeyName(0, "1.png")
        Me.imgMain2.Images.SetKeyName(1, "2.png")
        Me.imgMain2.Images.SetKeyName(2, "3.png")
        Me.imgMain2.Images.SetKeyName(3, "4.png")
        Me.imgMain2.Images.SetKeyName(4, "5.png")
        Me.imgMain2.Images.SetKeyName(5, "6.png")
        Me.imgMain2.Images.SetKeyName(6, "7.png")
        Me.imgMain2.Images.SetKeyName(7, "8.png")
        Me.imgMain2.Images.SetKeyName(8, "9.png")
        Me.imgMain2.Images.SetKeyName(9, "10.png")
        Me.imgMain2.Images.SetKeyName(10, "12.png")
        Me.imgMain2.Images.SetKeyName(11, "13.png")
        '
        'menuChuongTrinhDaoTao
        '
        Me.menuChuongTrinhDaoTao.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuChuongTrinhDaoTao.Appearance.Options.UseFont = True
        Me.menuChuongTrinhDaoTao.Caption = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.menuChuongTrinhDaoTao.Hint = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.menuChuongTrinhDaoTao.Id = 2
        Me.menuChuongTrinhDaoTao.ImageIndex = 0
        Me.menuChuongTrinhDaoTao.MenuCaption = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.menuChuongTrinhDaoTao.Name = "menuChuongTrinhDaoTao"
        Me.menuChuongTrinhDaoTao.ShowMenuCaption = True
        '
        'menuToChucThi
        '
        Me.menuToChucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuToChucThi.Appearance.Options.UseFont = True
        Me.menuToChucThi.Caption = "QUẢN LÝ & TỔ CHỨC THI"
        Me.menuToChucThi.Hint = "QUẢN LÝ & TỔ CHỨC THI"
        Me.menuToChucThi.Id = 14
        Me.menuToChucThi.ImageIndex = 1
        Me.menuToChucThi.MenuCaption = "QUẢN LÝ & TỔ CHỨC THI"
        Me.menuToChucThi.Name = "menuToChucThi"
        Me.menuToChucThi.ShowMenuCaption = True
        '
        'menuQuaTrinhDiem
        '
        Me.menuQuaTrinhDiem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuQuaTrinhDiem.Appearance.Options.UseFont = True
        Me.menuQuaTrinhDiem.Caption = "QUÁ TRÌNH ĐIỂM"
        Me.menuQuaTrinhDiem.Hint = "QUÁ TRÌNH ĐIỂM"
        Me.menuQuaTrinhDiem.Id = 18
        Me.menuQuaTrinhDiem.ImageIndex = 2
        Me.menuQuaTrinhDiem.MenuCaption = "TỔNG HỢP BÁO CÁO"
        Me.menuQuaTrinhDiem.Name = "menuQuaTrinhDiem"
        Me.menuQuaTrinhDiem.ShowMenuCaption = True
        Me.menuQuaTrinhDiem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menuTongHopBaoCao
        '
        Me.menuTongHopBaoCao.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuTongHopBaoCao.Appearance.Options.UseFont = True
        Me.menuTongHopBaoCao.Caption = "THỐNG KÊ TỔNG HỢP"
        Me.menuTongHopBaoCao.Hint = "THỐNG KÊ TỔNG HỢP"
        Me.menuTongHopBaoCao.Id = 21
        Me.menuTongHopBaoCao.ImageIndex = 3
        Me.menuTongHopBaoCao.MenuCaption = "THỐNG KÊ TỔNG HỢP"
        Me.menuTongHopBaoCao.Name = "menuTongHopBaoCao"
        Me.menuTongHopBaoCao.ShowMenuCaption = True
        '
        'menuXetDuyet
        '
        Me.menuXetDuyet.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuXetDuyet.Appearance.Options.UseFont = True
        Me.menuXetDuyet.Caption = "XÉT DUYỆT"
        Me.menuXetDuyet.Hint = "XÉT DUYỆT"
        Me.menuXetDuyet.Id = 22
        Me.menuXetDuyet.ImageIndex = 4
        Me.menuXetDuyet.MenuCaption = "XÉT DUYỆT"
        Me.menuXetDuyet.Name = "menuXetDuyet"
        Me.menuXetDuyet.ShowMenuCaption = True
        Me.menuXetDuyet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menuStyle
        '
        Me.menuStyle.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.menuStyle.Appearance.Options.UseFont = True
        Me.menuStyle.Caption = "Main Style"
        Me.menuStyle.Hint = "Main Style"
        Me.menuStyle.Id = 23
        Me.menuStyle.MenuCaption = "Main Style"
        Me.menuStyle.Name = "menuStyle"
        Me.menuStyle.ShowMenuCaption = True
        '
        'menuTimKiem
        '
        Me.menuTimKiem.Caption = "TÌM KIẾM"
        Me.menuTimKiem.Hint = "TÌM KIẾM"
        Me.menuTimKiem.Id = 26
        Me.menuTimKiem.ImageIndex = 10
        Me.menuTimKiem.MenuCaption = "TÌM KIẾM"
        Me.menuTimKiem.Name = "menuTimKiem"
        Me.menuTimKiem.ShowMenuCaption = True
        '
        'menuDanhMuc
        '
        Me.menuDanhMuc.Caption = "QUẢN LÝ DANH MỤC"
        Me.menuDanhMuc.Hint = "QUẢN LÝ DANH MỤC"
        Me.menuDanhMuc.Id = 27
        Me.menuDanhMuc.ImageIndex = 11
        Me.menuDanhMuc.MenuCaption = "QUẢN LÝ DANH MỤC"
        Me.menuDanhMuc.Name = "menuDanhMuc"
        Me.menuDanhMuc.ShowMenuCaption = True
        '
        'menuHeThong
        '
        Me.menuHeThong.Caption = "QUẢN TRỊ HỆ THỐNG"
        Me.menuHeThong.Hint = "QUẢN TRỊ HỆ THỐNG"
        Me.menuHeThong.Id = 28
        Me.menuHeThong.ImageIndex = 9
        Me.menuHeThong.MenuCaption = "QUẢN TRỊ HỆ THỐNG"
        Me.menuHeThong.Name = "menuHeThong"
        Me.menuHeThong.ShowMenuCaption = True
        '
        'NavBarMain
        '
        Me.NavBarMain.ActiveGroup = Me.NavHeThong
        Me.NavBarMain.AllowSelectedLink = True
        Me.NavBarMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarMain.EachGroupHasSelectedLink = True
        Me.NavBarMain.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarMain.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavChuongTrinhDaoTao, Me.NavToChucThi, Me.NavQuaTrinhDiem, Me.NavTongHopBaoCao, Me.NavXetDuyet, Me.NavTimKiem, Me.NavDanhMuc, Me.NavHeThong})
        Me.NavBarMain.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1})
        Me.NavBarMain.LargeImages = Me.imgMain1
        Me.NavBarMain.Location = New System.Drawing.Point(0, 48)
        Me.NavBarMain.Name = "NavBarMain"
        Me.NavBarMain.OptionsNavPane.ExpandedWidth = 256
        Me.NavBarMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NavBarMain.Size = New System.Drawing.Size(258, 453)
        Me.NavBarMain.SmallImages = Me.imgMain2
        Me.NavBarMain.TabIndex = 112
        Me.NavBarMain.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Blue")
        '
        'NavHeThong
        '
        Me.NavHeThong.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavHeThong.Appearance.Options.UseFont = True
        Me.NavHeThong.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavHeThong.AppearanceBackground.Options.UseFont = True
        Me.NavHeThong.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavHeThong.AppearanceHotTracked.Options.UseFont = True
        Me.NavHeThong.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavHeThong.AppearancePressed.Options.UseFont = True
        Me.NavHeThong.Caption = "QUẢN TRỊ HỆ THỐNG"
        Me.NavHeThong.Expanded = True
        Me.NavHeThong.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavHeThong.LargeImageIndex = 9
        Me.NavHeThong.Name = "NavHeThong"
        Me.NavHeThong.SmallImageIndex = 9
        '
        'NavChuongTrinhDaoTao
        '
        Me.NavChuongTrinhDaoTao.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavChuongTrinhDaoTao.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.NavChuongTrinhDaoTao.Appearance.Options.UseFont = True
        Me.NavChuongTrinhDaoTao.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavChuongTrinhDaoTao.AppearanceBackground.Options.UseFont = True
        Me.NavChuongTrinhDaoTao.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavChuongTrinhDaoTao.AppearanceHotTracked.Options.UseFont = True
        Me.NavChuongTrinhDaoTao.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavChuongTrinhDaoTao.AppearancePressed.Options.UseFont = True
        Me.NavChuongTrinhDaoTao.Caption = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.NavChuongTrinhDaoTao.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavChuongTrinhDaoTao.LargeImageIndex = 0
        Me.NavChuongTrinhDaoTao.Name = "NavChuongTrinhDaoTao"
        Me.NavChuongTrinhDaoTao.SelectedLinkIndex = 0
        Me.NavChuongTrinhDaoTao.SmallImageIndex = 0
        '
        'NavToChucThi
        '
        Me.NavToChucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavToChucThi.Appearance.Options.UseFont = True
        Me.NavToChucThi.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavToChucThi.AppearanceBackground.Options.UseFont = True
        Me.NavToChucThi.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavToChucThi.AppearanceHotTracked.Options.UseFont = True
        Me.NavToChucThi.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavToChucThi.AppearancePressed.Options.UseFont = True
        Me.NavToChucThi.Caption = "QUẢN LÝ & TỔ CHỨC THI"
        Me.NavToChucThi.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavToChucThi.LargeImageIndex = 1
        Me.NavToChucThi.Name = "NavToChucThi"
        Me.NavToChucThi.SmallImageIndex = 1
        '
        'NavQuaTrinhDiem
        '
        Me.NavQuaTrinhDiem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavQuaTrinhDiem.Appearance.Options.UseFont = True
        Me.NavQuaTrinhDiem.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavQuaTrinhDiem.AppearanceBackground.Options.UseFont = True
        Me.NavQuaTrinhDiem.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavQuaTrinhDiem.AppearanceHotTracked.Options.UseFont = True
        Me.NavQuaTrinhDiem.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavQuaTrinhDiem.AppearancePressed.Options.UseFont = True
        Me.NavQuaTrinhDiem.Caption = "QUÁ TRÌNH ĐIỂM"
        Me.NavQuaTrinhDiem.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavQuaTrinhDiem.LargeImageIndex = 2
        Me.NavQuaTrinhDiem.Name = "NavQuaTrinhDiem"
        Me.NavQuaTrinhDiem.SmallImageIndex = 2
        '
        'NavTongHopBaoCao
        '
        Me.NavTongHopBaoCao.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavTongHopBaoCao.Appearance.Options.UseFont = True
        Me.NavTongHopBaoCao.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavTongHopBaoCao.AppearanceBackground.Options.UseFont = True
        Me.NavTongHopBaoCao.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavTongHopBaoCao.AppearanceHotTracked.Options.UseFont = True
        Me.NavTongHopBaoCao.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavTongHopBaoCao.AppearancePressed.Options.UseFont = True
        Me.NavTongHopBaoCao.Caption = "TỔNG HỢP"
        Me.NavTongHopBaoCao.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavTongHopBaoCao.LargeImageIndex = 3
        Me.NavTongHopBaoCao.Name = "NavTongHopBaoCao"
        Me.NavTongHopBaoCao.SmallImageIndex = 3
        '
        'NavXetDuyet
        '
        Me.NavXetDuyet.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavXetDuyet.Appearance.Options.UseFont = True
        Me.NavXetDuyet.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavXetDuyet.AppearanceBackground.Options.UseFont = True
        Me.NavXetDuyet.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavXetDuyet.AppearanceHotTracked.Options.UseFont = True
        Me.NavXetDuyet.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavXetDuyet.AppearancePressed.Options.UseFont = True
        Me.NavXetDuyet.Caption = "XÉT DUYỆT"
        Me.NavXetDuyet.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavXetDuyet.LargeImageIndex = 4
        Me.NavXetDuyet.Name = "NavXetDuyet"
        Me.NavXetDuyet.SmallImageIndex = 4
        '
        'NavTimKiem
        '
        Me.NavTimKiem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavTimKiem.Appearance.Options.UseFont = True
        Me.NavTimKiem.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavTimKiem.AppearanceBackground.Options.UseFont = True
        Me.NavTimKiem.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavTimKiem.AppearanceHotTracked.Options.UseFont = True
        Me.NavTimKiem.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavTimKiem.AppearancePressed.Options.UseFont = True
        Me.NavTimKiem.Caption = "TÌM KIẾM"
        Me.NavTimKiem.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavTimKiem.LargeImageIndex = 10
        Me.NavTimKiem.Name = "NavTimKiem"
        Me.NavTimKiem.SmallImageIndex = 10
        '
        'NavDanhMuc
        '
        Me.NavDanhMuc.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavDanhMuc.Appearance.Options.UseFont = True
        Me.NavDanhMuc.AppearanceBackground.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavDanhMuc.AppearanceBackground.Options.UseFont = True
        Me.NavDanhMuc.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavDanhMuc.AppearanceHotTracked.Options.UseFont = True
        Me.NavDanhMuc.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.NavDanhMuc.AppearancePressed.Options.UseFont = True
        Me.NavDanhMuc.Caption = "QUẢN LÝ DANH MỤC"
        Me.NavDanhMuc.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavDanhMuc.LargeImageIndex = 11
        Me.NavDanhMuc.Name = "NavDanhMuc"
        Me.NavDanhMuc.SmallImageIndex = 11
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavBarItem1.Appearance.Options.UseFont = True
        Me.NavBarItem1.AppearanceDisabled.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavBarItem1.AppearanceDisabled.Options.UseFont = True
        Me.NavBarItem1.AppearanceHotTracked.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavBarItem1.AppearanceHotTracked.Options.UseFont = True
        Me.NavBarItem1.AppearancePressed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.NavBarItem1.AppearancePressed.Options.UseFont = True
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'imgMain1
        '
        Me.imgMain1.ImageStream = CType(resources.GetObject("imgMain1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMain1.TransparentColor = System.Drawing.Color.Magenta
        Me.imgMain1.Images.SetKeyName(0, "1.png")
        Me.imgMain1.Images.SetKeyName(1, "2.png")
        Me.imgMain1.Images.SetKeyName(2, "3.png")
        Me.imgMain1.Images.SetKeyName(3, "4.png")
        Me.imgMain1.Images.SetKeyName(4, "5.png")
        Me.imgMain1.Images.SetKeyName(5, "6.png")
        Me.imgMain1.Images.SetKeyName(6, "7.png")
        Me.imgMain1.Images.SetKeyName(7, "8.png")
        Me.imgMain1.Images.SetKeyName(8, "9.png")
        Me.imgMain1.Images.SetKeyName(9, "10.png")
        Me.imgMain1.Images.SetKeyName(10, "12.png")
        Me.imgMain1.Images.SetKeyName(11, "13.png")
        '
        'DefaultLookAndFeelMain
        '
        Me.DefaultLookAndFeelMain.LookAndFeel.SkinName = "Blue"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.menuChuongTrinhDaoTao)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibMain
        '
        'BarAndDockingMain
        '
        Me.BarAndDockingMain.LookAndFeel.SkinName = "Blue"
        Me.BarAndDockingMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.BarAndDockingMain.PropertiesBar.AllowLinkLighting = False
        '
        'imgChucNang
        '
        Me.imgChucNang.ImageStream = CType(resources.GetObject("imgChucNang.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgChucNang.TransparentColor = System.Drawing.Color.Transparent
        Me.imgChucNang.Images.SetKeyName(0, "text_code_c.ico")
        Me.imgChucNang.Images.SetKeyName(1, "alarmclock.ico")
        Me.imgChucNang.Images.SetKeyName(2, "angel.ico")
        Me.imgChucNang.Images.SetKeyName(3, "application.ico")
        Me.imgChucNang.Images.SetKeyName(4, "battery.ico")
        Me.imgChucNang.Images.SetKeyName(5, "bell.ico")
        Me.imgChucNang.Images.SetKeyName(6, "book_blue.ico")
        Me.imgChucNang.Images.SetKeyName(7, "books.ico")
        Me.imgChucNang.Images.SetKeyName(8, "bottle.ico")
        Me.imgChucNang.Images.SetKeyName(9, "box.ico")
        Me.imgChucNang.Images.SetKeyName(10, "box_closed.ico")
        Me.imgChucNang.Images.SetKeyName(11, "box_software.ico")
        Me.imgChucNang.Images.SetKeyName(12, "box_white.ico")
        Me.imgChucNang.Images.SetKeyName(13, "branch_element_new.ico")
        Me.imgChucNang.Images.SetKeyName(14, "breakpoint_into.ico")
        Me.imgChucNang.Images.SetKeyName(15, "brush2.ico")
        Me.imgChucNang.Images.SetKeyName(16, "bug_green.ico")
        Me.imgChucNang.Images.SetKeyName(17, "calculator.ico")
        Me.imgChucNang.Images.SetKeyName(18, "camera.ico")
        Me.imgChucNang.Images.SetKeyName(19, "candle.ico")
        Me.imgChucNang.Images.SetKeyName(20, "carabiner.ico")
        Me.imgChucNang.Images.SetKeyName(21, "cd.ico")
        Me.imgChucNang.Images.SetKeyName(22, "coffeebean_enterprise_new.ico")
        Me.imgChucNang.Images.SetKeyName(23, "colors.ico")
        Me.imgChucNang.Images.SetKeyName(24, "compass.ico")
        Me.imgChucNang.Images.SetKeyName(25, "component_new.ico")
        Me.imgChucNang.Images.SetKeyName(26, "cpu.ico")
        Me.imgChucNang.Images.SetKeyName(27, "cube_blue_add.ico")
        Me.imgChucNang.Images.SetKeyName(28, "cube_molecule.ico")
        Me.imgChucNang.Images.SetKeyName(29, "cubes.ico")
        Me.imgChucNang.Images.SetKeyName(30, "cup.ico")
        Me.imgChucNang.Images.SetKeyName(31, "debug.ico")
        Me.imgChucNang.Images.SetKeyName(32, "die.ico")
        Me.imgChucNang.Images.SetKeyName(33, "drink_blue.ico")
        Me.imgChucNang.Images.SetKeyName(34, "dude2.ico")
        Me.imgChucNang.Images.SetKeyName(35, "element_find.ico")
        Me.imgChucNang.Images.SetKeyName(36, "element_into.ico")
        Me.imgChucNang.Images.SetKeyName(37, "element_preferences.ico")
        Me.imgChucNang.Images.SetKeyName(38, "element_previous.ico")
        Me.imgChucNang.Images.SetKeyName(39, "factory.ico")
        Me.imgChucNang.Images.SetKeyName(40, "film.ico")
        Me.imgChucNang.Images.SetKeyName(41, "flag_blue.ico")
        Me.imgChucNang.Images.SetKeyName(42, "flashlight.ico")
        Me.imgChucNang.Images.SetKeyName(43, "gauge.ico")
        Me.imgChucNang.Images.SetKeyName(44, "ghost.ico")
        Me.imgChucNang.Images.SetKeyName(45, "graphics-tablet.ico")
        Me.imgChucNang.Images.SetKeyName(46, "hammer.ico")
        Me.imgChucNang.Images.SetKeyName(47, "headphones.ico")
        Me.imgChucNang.Images.SetKeyName(48, "hourglass.ico")
        Me.imgChucNang.Images.SetKeyName(49, "house.ico")
        Me.imgChucNang.Images.SetKeyName(50, "houses.ico")
        Me.imgChucNang.Images.SetKeyName(51, "jar.ico")
        Me.imgChucNang.Images.SetKeyName(52, "joystick.ico")
        Me.imgChucNang.Images.SetKeyName(53, "keyboard.ico")
        Me.imgChucNang.Images.SetKeyName(54, "keyboard_key.ico")
        Me.imgChucNang.Images.SetKeyName(55, "laptop2.ico")
        Me.imgChucNang.Images.SetKeyName(56, "layout_horizontal.ico")
        Me.imgChucNang.Images.SetKeyName(57, "loudspeaker.ico")
        Me.imgChucNang.Images.SetKeyName(58, "loudspeaker2.ico")
        Me.imgChucNang.Images.SetKeyName(59, "megaphone.ico")
        Me.imgChucNang.Images.SetKeyName(60, "modem.ico")
        Me.imgChucNang.Images.SetKeyName(61, "modem_earth.ico")
        Me.imgChucNang.Images.SetKeyName(62, "movie_pause.ico")
        Me.imgChucNang.Images.SetKeyName(63, "oszillograph.ico")
        Me.imgChucNang.Images.SetKeyName(64, "palette_text.ico")
        Me.imgChucNang.Images.SetKeyName(65, "registry.ico")
        Me.imgChucNang.Images.SetKeyName(66, "scanner.ico")
        Me.imgChucNang.Images.SetKeyName(67, "step_add.ico")
        '
        'mdiManager
        '
        Me.mdiManager.Controller = Me.BarAndDockingMain
        Me.mdiManager.MdiParent = Me
        '
        'frmMain1
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(904, 526)
        Me.Controls.Add(Me.NavBarMain)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain1"
        Me.Ribbon = Me.RibMain
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents NavChuongTrinhDaoTao As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavToChucThi As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavQuaTrinhDiem As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavTongHopBaoCao As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents DefaultLookAndFeelMain As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents menuChuongTrinhDaoTao As DevExpress.XtraBars.BarSubItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Private WithEvents imgMain1 As System.Windows.Forms.ImageList
    Private WithEvents imgMain2 As System.Windows.Forms.ImageList
    Friend WithEvents menuToChucThi As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuQuaTrinhDiem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarAndDockingMain As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents imgChucNang As System.Windows.Forms.ImageList
    Friend WithEvents menuTongHopBaoCao As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuXetDuyet As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuStyle As DevExpress.XtraBars.BarSubItem
    Friend WithEvents NavBarMain As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents staInfomation As DevExpress.XtraBars.BarListItem
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents mdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents NavXetDuyet As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavTimKiem As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavDanhMuc As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavHeThong As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents menuTimKiem As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents menuDanhMuc As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents menuHeThong As DevExpress.XtraBars.BarButtonGroup


End Class
