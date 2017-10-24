<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTongHopSinhVienHocLai_NopTien
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTongHopSinhVienHocLai_NopTien))
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHienThi = New System.Windows.Forms.ComboBox
        Me.TreeViewLop_NEW1 = New ESS_Mark.TreeViewLop_NEW
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grdViewDanhSachMon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdTongHop = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdPrint_Mon1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_Chitiet1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdPrint_Mon = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_Chitiet = New DevExpress.XtraBars.BarButtonItem
        Me.btnDSMon = New DevExpress.XtraBars.BarButtonItem
        Me.btnDSSinhVien = New DevExpress.XtraBars.BarButtonItem
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdExport = New DevExpress.XtraEditors.DropDownButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grdViewDanhsachChitiet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLan_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiem_thi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbChon_tat_ca_Giay_to = New System.Windows.Forms.CheckBox
        Me.btnDa_nop_tien = New DevExpress.XtraEditors.SimpleButton
        Me.grcDaNopTien = New DevExpress.XtraGrid.GridControl
        Me.grdNopTien = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColDa_nop_tien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDaNopTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNopTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(475, 6)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(113, 24)
        Me.cmbNam_hoc.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(401, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(299, 6)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 113
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(360, 6)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(38, 24)
        Me.cmbHoc_ky.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(745, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Hiển thị theo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.UseWaitCursor = True
        Me.Label2.Visible = False
        '
        'cmbHienThi
        '
        Me.cmbHienThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHienThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHienThi.Items.AddRange(New Object() {"Thi lại", "Học lại"})
        Me.cmbHienThi.Location = New System.Drawing.Point(842, 6)
        Me.cmbHienThi.Name = "cmbHienThi"
        Me.cmbHienThi.Size = New System.Drawing.Size(127, 24)
        Me.cmbHienThi.TabIndex = 120
        Me.cmbHienThi.UseWaitCursor = True
        Me.cmbHienThi.Visible = False
        '
        'TreeViewLop_NEW1
        '
        Me.TreeViewLop_NEW1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop_NEW1.dtLop = Nothing
        Me.TreeViewLop_NEW1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewLop_NEW1.Location = New System.Drawing.Point(-2, 1)
        Me.TreeViewLop_NEW1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeViewLop_NEW1.Name = "TreeViewLop_NEW1"
        Me.TreeViewLop_NEW1.Size = New System.Drawing.Size(267, 561)
        Me.TreeViewLop_NEW1.TabIndex = 121
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhan.Location = New System.Drawing.Point(266, 36)
        Me.grcHocPhan.MainView = Me.grdViewDanhSachMon
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(703, 125)
        Me.grcHocPhan.TabIndex = 250
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachMon})
        '
        'grdViewDanhSachMon
        '
        Me.grdViewDanhSachMon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon, Me.colSo_sv, Me.colSo_hoc_trinh})
        Me.grdViewDanhSachMon.GridControl = Me.grcHocPhan
        Me.grdViewDanhSachMon.Name = "grdViewDanhSachMon"
        Me.grdViewDanhSachMon.OptionsSelection.MultiSelect = True
        Me.grdViewDanhSachMon.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.ReadOnly = True
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 0
        Me.colKy_hieu.Width = 137
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 312
        '
        'colSo_sv
        '
        Me.colSo_sv.Caption = "Số sinh viên"
        Me.colSo_sv.FieldName = "So_sv"
        Me.colSo_sv.Name = "colSo_sv"
        Me.colSo_sv.Visible = True
        Me.colSo_sv.VisibleIndex = 2
        Me.colSo_sv.Width = 113
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "Hệ số"
        Me.colSo_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 3
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdTongHop.ImageIndex = 11
        Me.cmdTongHop.ImageList = Me.ImgMain
        Me.cmdTongHop.Location = New System.Drawing.Point(282, 528)
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(89, 31)
        Me.cmdTongHop.TabIndex = 252
        Me.cmdTongHop.Text = "Tổng hợp"
        '
        'ImgMain
        '
        Me.ImgMain.ImageStream = CType(resources.GetObject("ImgMain.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImgMain.Images.SetKeyName(0, "Add.png")
        Me.ImgMain.Images.SetKeyName(1, "Back.png")
        Me.ImgMain.Images.SetKeyName(2, "Bar Chart.png")
        Me.ImgMain.Images.SetKeyName(3, "Comment.png")
        Me.ImgMain.Images.SetKeyName(4, "Delete.png")
        Me.ImgMain.Images.SetKeyName(5, "Email.png")
        Me.ImgMain.Images.SetKeyName(6, "excel.ico")
        Me.ImgMain.Images.SetKeyName(7, "Exit.png")
        Me.ImgMain.Images.SetKeyName(8, "Info.png")
        Me.ImgMain.Images.SetKeyName(9, "Line Chart.png")
        Me.ImgMain.Images.SetKeyName(10, "Load.png")
        Me.ImgMain.Images.SetKeyName(11, "Loading.png")
        Me.ImgMain.Images.SetKeyName(12, "Modify.png")
        Me.ImgMain.Images.SetKeyName(13, "Next.png")
        Me.ImgMain.Images.SetKeyName(14, "Picture.png")
        Me.ImgMain.Images.SetKeyName(15, "Pie Chart.png")
        Me.ImgMain.Images.SetKeyName(16, "Print.png")
        Me.ImgMain.Images.SetKeyName(17, "Profile.png")
        Me.ImgMain.Images.SetKeyName(18, "Save.png")
        Me.ImgMain.Images.SetKeyName(19, "Search.png")
        Me.ImgMain.Images.SetKeyName(20, "Warning.png")
        Me.ImgMain.Images.SetKeyName(21, "word.ico")
        '
        'cmdPrint_Mon1
        '
        Me.cmdPrint_Mon1.Caption = "Danh sách môn"
        Me.cmdPrint_Mon1.Id = 15
        Me.cmdPrint_Mon1.Name = "cmdPrint_Mon1"
        '
        'cmdPrint_Chitiet1
        '
        Me.cmdPrint_Chitiet1.Caption = "Danh sách sinh viên"
        Me.cmdPrint_Chitiet1.Id = 16
        Me.cmdPrint_Chitiet1.Name = "cmdPrint_Chitiet1"
        '
        'BarManager1
        '
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_Mon1, Me.cmdPrint_Chitiet1, Me.cmdPrint_Mon, Me.cmdPrint_Chitiet, Me.btnDSMon, Me.btnDSSinhVien})
        Me.BarManager1.MaxItemId = 21
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PaintStyleName = "Office2003"
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(973, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(973, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 566)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(973, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'cmdPrint_Mon
        '
        Me.cmdPrint_Mon.Caption = "Danh sách môn"
        Me.cmdPrint_Mon.Id = 17
        Me.cmdPrint_Mon.Name = "cmdPrint_Mon"
        '
        'cmdPrint_Chitiet
        '
        Me.cmdPrint_Chitiet.Caption = "Danh sách sinh viên"
        Me.cmdPrint_Chitiet.Id = 18
        Me.cmdPrint_Chitiet.Name = "cmdPrint_Chitiet"
        '
        'btnDSMon
        '
        Me.btnDSMon.Caption = "Danh sách môn"
        Me.btnDSMon.Id = 19
        Me.btnDSMon.Name = "btnDSMon"
        '
        'btnDSSinhVien
        '
        Me.btnDSSinhVien.Caption = "Danh sách sinh viên"
        Me.btnDSSinhVien.Id = 20
        Me.btnDSSinhVien.Name = "btnDSSinhVien"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(700, 528)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 31)
        Me.cmdClose.TabIndex = 261
        Me.cmdClose.Text = "Thoát"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_Mon), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_Chitiet)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDSMon), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDSSinhVien)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(463, 528)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(114, 31)
        Me.cmdPrintList.TabIndex = 256
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.DropDownControl = Me.PopupMenu2
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(581, 528)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(114, 31)
        Me.cmdExport.TabIndex = 266
        Me.cmdExport.Text = "Xuất Excel"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(266, 189)
        Me.grcDanhSach.MainView = Me.grdViewDanhsachChitiet
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(703, 172)
        Me.grcDanhSach.TabIndex = 271
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhsachChitiet})
        '
        'grdViewDanhsachChitiet
        '
        Me.grdViewDanhsachChitiet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colLan_hoc, Me.colDiem_thi, Me.colTBCHP, Me.colGhi_chu})
        Me.grdViewDanhsachChitiet.GridControl = Me.grcDanhSach
        Me.grdViewDanhsachChitiet.Name = "grdViewDanhsachChitiet"
        Me.grdViewDanhsachChitiet.OptionsSelection.MultiSelect = True
        Me.grdViewDanhsachChitiet.OptionsView.ShowGroupPanel = False
        Me.grdViewDanhsachChitiet.OptionsView.ShowViewCaption = True
        Me.grdViewDanhsachChitiet.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 40
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 76
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 116
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 3
        Me.colNgay_sinh.Width = 76
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 92
        '
        'colLan_hoc
        '
        Me.colLan_hoc.Caption = "Lần học"
        Me.colLan_hoc.FieldName = "Lan_hoc"
        Me.colLan_hoc.Name = "colLan_hoc"
        Me.colLan_hoc.OptionsColumn.ReadOnly = True
        Me.colLan_hoc.Visible = True
        Me.colLan_hoc.VisibleIndex = 5
        Me.colLan_hoc.Width = 92
        '
        'colDiem_thi
        '
        Me.colDiem_thi.Caption = "Điểm thi"
        Me.colDiem_thi.FieldName = "Diem_thi"
        Me.colDiem_thi.Name = "colDiem_thi"
        Me.colDiem_thi.OptionsColumn.ReadOnly = True
        Me.colDiem_thi.Visible = True
        Me.colDiem_thi.VisibleIndex = 6
        Me.colDiem_thi.Width = 92
        '
        'colTBCHP
        '
        Me.colTBCHP.Caption = "TBCHP"
        Me.colTBCHP.FieldName = "TBCHP"
        Me.colTBCHP.Name = "colTBCHP"
        Me.colTBCHP.OptionsColumn.ReadOnly = True
        Me.colTBCHP.Visible = True
        Me.colTBCHP.VisibleIndex = 7
        Me.colTBCHP.Width = 98
        '
        'cbChon_tat_ca_Giay_to
        '
        Me.cbChon_tat_ca_Giay_to.AutoSize = True
        Me.cbChon_tat_ca_Giay_to.Location = New System.Drawing.Point(266, 167)
        Me.cbChon_tat_ca_Giay_to.Name = "cbChon_tat_ca_Giay_to"
        Me.cbChon_tat_ca_Giay_to.Size = New System.Drawing.Size(100, 20)
        Me.cbChon_tat_ca_Giay_to.TabIndex = 276
        Me.cbChon_tat_ca_Giay_to.Text = "Chọn tất cả"
        Me.cbChon_tat_ca_Giay_to.UseVisualStyleBackColor = True
        '
        'btnDa_nop_tien
        '
        Me.btnDa_nop_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDa_nop_tien.ImageIndex = 15
        Me.btnDa_nop_tien.ImageList = Me.ImgMain
        Me.btnDa_nop_tien.Location = New System.Drawing.Point(372, 528)
        Me.btnDa_nop_tien.Name = "btnDa_nop_tien"
        Me.btnDa_nop_tien.Size = New System.Drawing.Size(89, 31)
        Me.btnDa_nop_tien.TabIndex = 281
        Me.btnDa_nop_tien.Text = "Nộp tiền"
        '
        'grcDaNopTien
        '
        Me.grcDaNopTien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDaNopTien.Location = New System.Drawing.Point(266, 367)
        Me.grcDaNopTien.MainView = Me.grdNopTien
        Me.grcDaNopTien.Name = "grcDaNopTien"
        Me.grcDaNopTien.Size = New System.Drawing.Size(703, 155)
        Me.grcDaNopTien.TabIndex = 286
        Me.grcDaNopTien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNopTien})
        '
        'grdNopTien
        '
        Me.grdNopTien.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDa_nop_tien, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn1})
        Me.grdNopTien.GridControl = Me.grcDaNopTien
        Me.grdNopTien.Name = "grdNopTien"
        Me.grdNopTien.OptionsSelection.MultiSelect = True
        Me.grdNopTien.OptionsView.ShowGroupPanel = False
        Me.grdNopTien.OptionsView.ShowViewCaption = True
        Me.grdNopTien.ViewCaption = "DANH SÁCH SINH VIÊN NỘP TIỀN HỌC LẠI"
        '
        'ColDa_nop_tien
        '
        Me.ColDa_nop_tien.Caption = "Trạng thái"
        Me.ColDa_nop_tien.FieldName = "Da_nop_tien"
        Me.ColDa_nop_tien.Name = "ColDa_nop_tien"
        Me.ColDa_nop_tien.Visible = True
        Me.ColDa_nop_tien.VisibleIndex = 0
        Me.ColDa_nop_tien.Width = 49
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã SV"
        Me.GridColumn2.FieldName = "Ma_sv"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 76
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "Ho_ten"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 116
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ngày sinh"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "Ngay_sinh"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 76
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên lớp"
        Me.GridColumn5.FieldName = "Ten_lop"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 92
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Lần học"
        Me.GridColumn6.FieldName = "Lan_hoc"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 92
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Điểm thi"
        Me.GridColumn7.FieldName = "Diem_thi"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 92
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "TBCHP"
        Me.GridColumn8.FieldName = "TBCHP"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 98
        '
        'colGhi_chu
        '
        Me.colGhi_chu.Caption = "Ghi chú"
        Me.colGhi_chu.FieldName = "Ghi_chu"
        Me.colGhi_chu.Name = "colGhi_chu"
        Me.colGhi_chu.Visible = True
        Me.colGhi_chu.VisibleIndex = 8
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ghi chú"
        Me.GridColumn1.FieldName = "Ghi_chu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'frmTongHopSinhVienHocLai_NopTien
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(973, 566)
        Me.Controls.Add(Me.grcDaNopTien)
        Me.Controls.Add(Me.btnDa_nop_tien)
        Me.Controls.Add(Me.cbChon_tat_ca_Giay_to)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdTongHop)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Controls.Add(Me.TreeViewLop_NEW1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbHienThi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTongHopSinhVienHocLai_NopTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTongHopSinhVienThiLai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDaNopTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNopTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbHienThi As System.Windows.Forms.ComboBox
    Friend WithEvents TreeViewLop_NEW1 As ESS_Mark.TreeViewLop_NEW
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachMon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdTongHop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdPrint_Mon1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_Chitiet1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_Mon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_Chitiet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents cmdExport As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents btnDSMon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDSSinhVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhsachChitiet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLan_hoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiem_thi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbChon_tat_ca_Giay_to As System.Windows.Forms.CheckBox
    Friend WithEvents btnDa_nop_tien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDaNopTien As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNopTien As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColDa_nop_tien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu As DevExpress.XtraGrid.Columns.GridColumn
End Class
