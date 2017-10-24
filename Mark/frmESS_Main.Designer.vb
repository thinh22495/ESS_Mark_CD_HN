Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmESS_Main

#Region "Designer generated code"
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_Main))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.RibMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.pmAppMain = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.mnuPainStyle = New DevExpress.XtraBars.BarSubItem
        Me.biStyle = New DevExpress.XtraBars.BarEditItem
        Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.mnuChuongTrinhDaoTao = New DevExpress.XtraBars.BarSubItem
        Me.mnuToChucThi = New DevExpress.XtraBars.BarSubItem
        Me.mnuQuaTrinhDiem = New DevExpress.XtraBars.BarSubItem
        Me.mnuTongHopBaoCao = New DevExpress.XtraBars.BarSubItem
        Me.mnuXetDuyet = New DevExpress.XtraBars.BarSubItem
        Me.mnuDanhMuc = New DevExpress.XtraBars.BarSubItem
        Me.mnuHeThong = New DevExpress.XtraBars.BarSubItem
        Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribChuongTrinhDaoTao = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgChuongTrinhDaoTao = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibToChucThi = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgToChucThi = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibQuaTrinhDiem = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgQuaTrinhDiem = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibTongHopBaoCao = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgTongHop = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibXetDuyet = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgXetDuyet = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibHeThong = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgHeThong = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibDanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgDanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.pcAppMenuFileLabels = New DevExpress.XtraEditors.PanelControl
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.ribgQuanLyDiem = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repositoryItemSpinEdit1
        '
        Me.repositoryItemSpinEdit1.AutoHeight = False
        Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemSpinEdit1.IsFloatValue = False
        Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'RibMain
        '
        Me.RibMain.ApplicationButtonDropDownControl = Me.pmAppMain
        Me.RibMain.ApplicationButtonText = Nothing
        Me.RibMain.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))})
        '
        '
        '
        Me.RibMain.ExpandCollapseItem.Id = 0
        Me.RibMain.ExpandCollapseItem.Name = ""
        Me.RibMain.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        Me.RibMain.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RibMain.Images = Me.imageCollection1
        Me.RibMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibMain.ExpandCollapseItem, Me.mnuPainStyle, Me.biStyle, Me.mnuChuongTrinhDaoTao, Me.mnuToChucThi, Me.mnuQuaTrinhDiem, Me.mnuTongHopBaoCao, Me.mnuXetDuyet, Me.mnuDanhMuc, Me.mnuHeThong})
        Me.RibMain.LargeImages = Me.imageCollection2
        Me.RibMain.Location = New System.Drawing.Point(0, 0)
        Me.RibMain.MaxItemId = 152
        Me.RibMain.Name = "RibMain"
        Me.RibMain.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.ribbonPageCategory1})
        Me.RibMain.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
        Me.RibMain.PageHeaderItemLinks.Add(Me.biStyle)
        Me.RibMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribChuongTrinhDaoTao, Me.RibToChucThi, Me.RibQuaTrinhDiem, Me.RibTongHopBaoCao, Me.RibXetDuyet, Me.RibHeThong, Me.RibDanhMuc})
        Me.RibMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.RepositoryItemPictureEdit1, Me.riicStyle})
        Me.RibMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibMain.SelectedPage = Me.ribChuongTrinhDaoTao
        Me.RibMain.ShowToolbarCustomizeItem = False
        Me.RibMain.Size = New System.Drawing.Size(1093, 148)
        Me.RibMain.StatusBar = Me.ribbonStatusBar1
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuChuongTrinhDaoTao)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuToChucThi)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuQuaTrinhDiem)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuTongHopBaoCao)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuXetDuyet)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuHeThong)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuDanhMuc)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuPainStyle)
        Me.RibMain.Toolbar.ShowCustomizeItem = False
        '
        'pmAppMain
        '
        Me.pmAppMain.BottomPaneControlContainer = Nothing
        Me.pmAppMain.Name = "pmAppMain"
        Me.pmAppMain.Ribbon = Me.RibMain
        Me.pmAppMain.RightPaneControlContainer = Nothing
        Me.pmAppMain.ShowRightPane = True
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.Images.SetKeyName(0, "M1.png")
        Me.imageCollection1.Images.SetKeyName(1, "M2.png")
        Me.imageCollection1.Images.SetKeyName(2, "M3.png")
        Me.imageCollection1.Images.SetKeyName(3, "M4.png")
        Me.imageCollection1.Images.SetKeyName(4, "1 (1).png")
        Me.imageCollection1.Images.SetKeyName(5, "1 (2).png")
        Me.imageCollection1.Images.SetKeyName(6, "1 (3).png")
        Me.imageCollection1.Images.SetKeyName(7, "1 (4).png")
        Me.imageCollection1.Images.SetKeyName(8, "1 (5).png")
        Me.imageCollection1.Images.SetKeyName(9, "1 (6).png")
        Me.imageCollection1.Images.SetKeyName(10, "1 (7).png")
        Me.imageCollection1.Images.SetKeyName(11, "1 (8).png")
        Me.imageCollection1.Images.SetKeyName(12, "1 (9).png")
        Me.imageCollection1.Images.SetKeyName(13, "1 (10).png")
        Me.imageCollection1.Images.SetKeyName(14, "1 (11).png")
        Me.imageCollection1.Images.SetKeyName(15, "1 (23).png")
        Me.imageCollection1.Images.SetKeyName(16, "1 (12).png")
        Me.imageCollection1.Images.SetKeyName(17, "1 (13).png")
        Me.imageCollection1.Images.SetKeyName(18, "1 (14).png")
        Me.imageCollection1.Images.SetKeyName(19, "1 (24).png")
        Me.imageCollection1.Images.SetKeyName(20, "1 (25).png")
        Me.imageCollection1.Images.SetKeyName(21, "1 (15).png")
        Me.imageCollection1.Images.SetKeyName(22, "1 (16).png")
        Me.imageCollection1.Images.SetKeyName(23, "1 (17).png")
        Me.imageCollection1.Images.SetKeyName(24, "1 (30).png")
        Me.imageCollection1.Images.SetKeyName(25, "1 (18).png")
        Me.imageCollection1.Images.SetKeyName(26, "1 (19).png")
        Me.imageCollection1.Images.SetKeyName(27, "1 (20).png")
        Me.imageCollection1.Images.SetKeyName(28, "1 (21).png")
        Me.imageCollection1.Images.SetKeyName(29, "1 (22).png")
        Me.imageCollection1.Images.SetKeyName(30, "1 (26).png")
        Me.imageCollection1.Images.SetKeyName(31, "1 (27).png")
        Me.imageCollection1.Images.SetKeyName(32, "1 (28).png")
        Me.imageCollection1.Images.SetKeyName(33, "1 (29).png")
        Me.imageCollection1.Images.SetKeyName(34, "1 (31).png")
        Me.imageCollection1.Images.SetKeyName(35, "1 (32).png")
        '
        'mnuPainStyle
        '
        Me.mnuPainStyle.Caption = "GIAO DIỆN"
        Me.mnuPainStyle.Description = "GIAO DIỆN"
        Me.mnuPainStyle.Hint = "GIAO DIỆN"
        Me.mnuPainStyle.Id = 7
        Me.mnuPainStyle.ImageIndex = 30
        Me.mnuPainStyle.Name = "mnuPainStyle"
        '
        'biStyle
        '
        Me.biStyle.Edit = Me.riicStyle
        Me.biStyle.Hint = "Ribbon Style"
        Me.biStyle.Id = 96
        Me.biStyle.Name = "biStyle"
        Me.biStyle.Width = 75
        '
        'riicStyle
        '
        Me.riicStyle.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.riicStyle.Appearance.Options.UseFont = True
        Me.riicStyle.AutoHeight = False
        Me.riicStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicStyle.Name = "riicStyle"
        '
        'mnuChuongTrinhDaoTao
        '
        Me.mnuChuongTrinhDaoTao.Caption = "Chương Trình Đào Tạo"
        Me.mnuChuongTrinhDaoTao.Description = "Chương Trình Đào Tạo"
        Me.mnuChuongTrinhDaoTao.Hint = "Chương Trình Đào Tạo"
        Me.mnuChuongTrinhDaoTao.Id = 127
        Me.mnuChuongTrinhDaoTao.ImageIndex = 10
        Me.mnuChuongTrinhDaoTao.Name = "mnuChuongTrinhDaoTao"
        '
        'mnuToChucThi
        '
        Me.mnuToChucThi.Caption = "Quản trị hệ thống"
        Me.mnuToChucThi.Description = "Quản trị hệ thống"
        Me.mnuToChucThi.Hint = "Quản trị hệ thống"
        Me.mnuToChucThi.Id = 129
        Me.mnuToChucThi.ImageIndex = 12
        Me.mnuToChucThi.MenuCaption = "Hệ thống"
        Me.mnuToChucThi.Name = "mnuToChucThi"
        '
        'mnuQuaTrinhDiem
        '
        Me.mnuQuaTrinhDiem.Caption = "Quá Trình Điểm"
        Me.mnuQuaTrinhDiem.Description = "Quá Trình Điểm"
        Me.mnuQuaTrinhDiem.Hint = "Quá Trình Điểm"
        Me.mnuQuaTrinhDiem.Id = 138
        Me.mnuQuaTrinhDiem.ImageIndex = 17
        Me.mnuQuaTrinhDiem.Name = "mnuQuaTrinhDiem"
        '
        'mnuTongHopBaoCao
        '
        Me.mnuTongHopBaoCao.Caption = "Tổng Hợp Báo Cáo"
        Me.mnuTongHopBaoCao.Description = "Tổng Hợp Báo Cáo"
        Me.mnuTongHopBaoCao.Hint = "Tổng Hợp Báo Cáo"
        Me.mnuTongHopBaoCao.Id = 139
        Me.mnuTongHopBaoCao.ImageIndex = 1
        Me.mnuTongHopBaoCao.Name = "mnuTongHopBaoCao"
        '
        'mnuXetDuyet
        '
        Me.mnuXetDuyet.Caption = "Xét Duyệt"
        Me.mnuXetDuyet.Description = "Xét Duyệt"
        Me.mnuXetDuyet.Hint = "Xét Duyệt"
        Me.mnuXetDuyet.Id = 145
        Me.mnuXetDuyet.ImageIndex = 15
        Me.mnuXetDuyet.Name = "mnuXetDuyet"
        '
        'mnuDanhMuc
        '
        Me.mnuDanhMuc.Caption = "Danh Mục"
        Me.mnuDanhMuc.Description = "Danh Mục"
        Me.mnuDanhMuc.Hint = "Danh Mục"
        Me.mnuDanhMuc.Id = 147
        Me.mnuDanhMuc.ImageIndex = 8
        Me.mnuDanhMuc.Name = "mnuDanhMuc"
        '
        'mnuHeThong
        '
        Me.mnuHeThong.Caption = "Hệ Thống"
        Me.mnuHeThong.Description = "Hệ Thống"
        Me.mnuHeThong.Hint = "Hệ Thống"
        Me.mnuHeThong.Id = 148
        Me.mnuHeThong.ImageIndex = 3
        Me.mnuHeThong.Name = "mnuHeThong"
        '
        'imageCollection2
        '
        Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection2.Images.SetKeyName(0, "M1.png")
        Me.imageCollection2.Images.SetKeyName(1, "M2.png")
        Me.imageCollection2.Images.SetKeyName(2, "M3.png")
        Me.imageCollection2.Images.SetKeyName(3, "M4.png")
        '
        'ribbonPageCategory1
        '
        Me.ribbonPageCategory1.Name = "ribbonPageCategory1"
        Me.ribbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage4})
        Me.ribbonPageCategory1.Text = "Chọn"
        '
        'ribbonPage4
        '
        Me.ribbonPage4.Name = "ribbonPage4"
        Me.ribbonPage4.Text = "Chọn"
        '
        'ribChuongTrinhDaoTao
        '
        Me.ribChuongTrinhDaoTao.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgChuongTrinhDaoTao})
        Me.ribChuongTrinhDaoTao.Name = "ribChuongTrinhDaoTao"
        Me.ribChuongTrinhDaoTao.Text = "Chương Trinh Đào Tạo"
        '
        'ribgChuongTrinhDaoTao
        '
        Me.ribgChuongTrinhDaoTao.Name = "ribgChuongTrinhDaoTao"
        ToolTipTitleItem1.Text = "HỆ THỐNG"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.ribgChuongTrinhDaoTao.SuperTip = SuperToolTip1
        Me.ribgChuongTrinhDaoTao.Text = "Chương trình đào tạo"
        '
        'RibToChucThi
        '
        Me.RibToChucThi.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgToChucThi})
        Me.RibToChucThi.Name = "RibToChucThi"
        Me.RibToChucThi.Text = "Quản Lý Và Tổ Chức Thi"
        '
        'ribgToChucThi
        '
        Me.ribgToChucThi.Name = "ribgToChucThi"
        Me.ribgToChucThi.Text = "Quản lý & tổ chức thi"
        '
        'RibQuaTrinhDiem
        '
        Me.RibQuaTrinhDiem.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgQuaTrinhDiem})
        Me.RibQuaTrinhDiem.Name = "RibQuaTrinhDiem"
        Me.RibQuaTrinhDiem.Text = "Quá Trình Điểm"
        '
        'ribgQuaTrinhDiem
        '
        Me.ribgQuaTrinhDiem.Name = "ribgQuaTrinhDiem"
        Me.ribgQuaTrinhDiem.Text = "Quá trình điểm"
        '
        'RibTongHopBaoCao
        '
        Me.RibTongHopBaoCao.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgTongHop})
        Me.RibTongHopBaoCao.Name = "RibTongHopBaoCao"
        Me.RibTongHopBaoCao.Text = "Tổng Hợp"
        '
        'ribgTongHop
        '
        Me.ribgTongHop.Name = "ribgTongHop"
        Me.ribgTongHop.Text = "Tổng hợp báo cáo"
        '
        'RibXetDuyet
        '
        Me.RibXetDuyet.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgXetDuyet})
        Me.RibXetDuyet.Name = "RibXetDuyet"
        Me.RibXetDuyet.Text = "Xét Duyệt"
        '
        'ribgXetDuyet
        '
        Me.ribgXetDuyet.Name = "ribgXetDuyet"
        Me.ribgXetDuyet.Text = "Xét duyệt"
        '
        'RibHeThong
        '
        Me.RibHeThong.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgHeThong})
        Me.RibHeThong.Name = "RibHeThong"
        Me.RibHeThong.Text = "Hệ Thống"
        '
        'ribgHeThong
        '
        Me.ribgHeThong.Name = "ribgHeThong"
        Me.ribgHeThong.Text = "Quản trị hệ thống"
        '
        'RibDanhMuc
        '
        Me.RibDanhMuc.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgDanhMuc})
        Me.RibDanhMuc.Name = "RibDanhMuc"
        Me.RibDanhMuc.Text = "Danh Mục"
        '
        'ribgDanhMuc
        '
        Me.ribgDanhMuc.Name = "ribgDanhMuc"
        Me.ribgDanhMuc.Text = "Quản lý danh mục"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.AllowFocused = False
        Me.RepositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'ribbonStatusBar1
        '
        Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 560)
        Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
        Me.ribbonStatusBar1.Ribbon = Me.RibMain
        Me.ribbonStatusBar1.Size = New System.Drawing.Size(1093, 23)
        '
        'imageCollection3
        '
        Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
        Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection3.Images.SetKeyName(0, "M1.png")
        Me.imageCollection3.Images.SetKeyName(1, "M2.png")
        Me.imageCollection3.Images.SetKeyName(2, "M3.png")
        Me.imageCollection3.Images.SetKeyName(3, "M4.png")
        '
        'pcAppMenuFileLabels
        '
        Me.pcAppMenuFileLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcAppMenuFileLabels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcAppMenuFileLabels.Location = New System.Drawing.Point(10, 19)
        Me.pcAppMenuFileLabels.Name = "pcAppMenuFileLabels"
        Me.pcAppMenuFileLabels.Size = New System.Drawing.Size(300, 143)
        Me.pcAppMenuFileLabels.TabIndex = 2
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.labelControl1.LineVisible = True
        Me.labelControl1.Location = New System.Drawing.Point(10, 0)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(300, 19)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Recent Documents:"
        '
        'panelControl1
        '
        Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelControl1.Location = New System.Drawing.Point(0, 0)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(10, 162)
        Me.panelControl1.TabIndex = 1
        '
        'defaultLookAndFeel1
        '
        Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        '
        'xtraTabbedMdiManager1
        '
        Me.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager1.MdiParent = Me
        '
        'ribgQuanLyDiem
        '
        Me.ribgQuanLyDiem.Name = "ribgQuanLyDiem"
        ToolTipTitleItem2.Text = "TỔNG HỢP"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        Me.ribgQuanLyDiem.SuperTip = SuperToolTip2
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "GIAO DIỆN"
        Me.BarSubItem1.Description = "GIAO DIỆN"
        Me.BarSubItem1.Hint = "GIAO DIỆN"
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.ImageIndex = 7
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'frmESS_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1093, 583)
        Me.Controls.Add(Me.ribbonStatusBar1)
        Me.Controls.Add(Me.RibMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmESS_Main"
        Me.Ribbon = Me.RibMain
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar1
        Me.Text = "PHẦN MỀM QUẢN LÝ HỌC TẬP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private components As System.ComponentModel.IContainer
    Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    'Private ribMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Private imageCollection1 As DevExpress.Utils.ImageCollection
    Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents mnuPainStyle As DevExpress.XtraBars.BarSubItem
    Private pmAppMain As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private imageCollection2 As DevExpress.Utils.ImageCollection
    Private ribbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    'Private pccAppMenu As PopupControlContainer
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private pcAppMenuFileLabels As DevExpress.XtraEditors.PanelControl
    Private imageCollection3 As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents biStyle As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riicStyle As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ribChuongTrinhDaoTao As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgChuongTrinhDaoTao As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuChuongTrinhDaoTao As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuToChucThi As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ribgQuanLyDiem As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibToChucThi As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgToChucThi As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibQuaTrinhDiem As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgQuaTrinhDiem As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuQuaTrinhDiem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuTongHopBaoCao As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RibTongHopBaoCao As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibXetDuyet As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibHeThong As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents mnuXetDuyet As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuDanhMuc As DevExpress.XtraBars.BarSubItem
    Private WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuHeThong As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ribgTongHop As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribgXetDuyet As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribgHeThong As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibDanhMuc As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgDanhMuc As DevExpress.XtraBars.Ribbon.RibbonPageGroup

End Class
