<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_DanhSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list. 1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_DanhSach))
        Me.txtSo_sv = New System.Windows.Forms.Label()
        Me.lblTong_so = New System.Windows.Forms.Label()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trvPhongThi = New ESS_Mark.TreeViewPhongThi()
        Me.btnToTucThi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd_sv = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSua_CTThi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa_TCT = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel_sv = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.grcViewDanhSachThi = New DevExpress.XtraGrid.GridControl()
        Me.grdViewDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSo_bao_danh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTen_phong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGhi_chu_thi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHo_dem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.btnAll_diem = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPhieuTheoDoi_LyThuyet = New DevExpress.XtraBars.BarButtonItem
        Me.btnPhieuTheoDoiKetQua_DanPT = New DevExpress.XtraBars.BarButtonItem
        Me.btnPhieuTheoDoiKetQua_BC = New DevExpress.XtraBars.BarButtonItem
        Me.btnTotNghiepLT_DanPhong = New DevExpress.XtraBars.BarButtonItem
        Me.btnTotNghiep_LT = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAll_diem = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPhieuTheoDoi_LyThuyet = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPhieuTheoDoiKetQua_DanPT = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPhieuTheoDoiKetQua_BC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTotNghiepLT_DanPhong = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTotNghiep_LT = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnTotNghiep_TH_DanPhong = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTotNghiep_TH = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdHocPhan = New DevExpress.XtraEditors.DropDownButton()
        Me.ckIn_ds_luanvan = New System.Windows.Forms.CheckBox()
        Me.btnTongHopSVThiChinhTri = New DevExpress.XtraEditors.SimpleButton()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.grcViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(1064, 41)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(34, 18)
        Me.txtSo_sv.TabIndex = 53
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(930, 41)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(134, 18)
        Me.lblTong_so.TabIndex = 52
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(273, 31)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(98, 23)
        Me.chkAll.TabIndex = 58
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(907, 26)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "DANH SÁCH TỔ CHỨC THI THEO KỲ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 41)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 487)
        Me.trvPhongThi.TabIndex = 54
        '
        'btnToTucThi
        '
        Me.btnToTucThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToTucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToTucThi.Appearance.Options.UseFont = True
        Me.btnToTucThi.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnToTucThi.ImageIndex = 22
        Me.btnToTucThi.Location = New System.Drawing.Point(5, 533)
        Me.btnToTucThi.Name = "btnToTucThi"
        Me.btnToTucThi.Size = New System.Drawing.Size(96, 30)
        Me.btnToTucThi.TabIndex = 178
        Me.btnToTucThi.Text = "Tổ chức thi"
        '
        'btnAdd_sv
        '
        Me.btnAdd_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_sv.Appearance.Options.UseFont = True
        Me.btnAdd_sv.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd_sv.ImageIndex = 22
        Me.btnAdd_sv.Location = New System.Drawing.Point(102, 533)
        Me.btnAdd_sv.Name = "btnAdd_sv"
        Me.btnAdd_sv.Size = New System.Drawing.Size(89, 30)
        Me.btnAdd_sv.TabIndex = 179
        Me.btnAdd_sv.Text = "Bổ sung sv"
        '
        'cmdSua_CTThi
        '
        Me.cmdSua_CTThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSua_CTThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSua_CTThi.Appearance.Options.UseFont = True
        Me.cmdSua_CTThi.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.cmdSua_CTThi.ImageIndex = 22
        Me.cmdSua_CTThi.Location = New System.Drawing.Point(193, 533)
        Me.cmdSua_CTThi.Name = "cmdSua_CTThi"
        Me.cmdSua_CTThi.Size = New System.Drawing.Size(108, 30)
        Me.cmdSua_CTThi.TabIndex = 180
        Me.cmdSua_CTThi.Text = "Sửa chi tiết thi"
        '
        'btnXoa_TCT
        '
        Me.btnXoa_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXoa_TCT.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_TCT.Appearance.Options.UseFont = True
        Me.btnXoa_TCT.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnXoa_TCT.ImageIndex = 22
        Me.btnXoa_TCT.Location = New System.Drawing.Point(304, 533)
        Me.btnXoa_TCT.Name = "btnXoa_TCT"
        Me.btnXoa_TCT.Size = New System.Drawing.Size(114, 30)
        Me.btnXoa_TCT.TabIndex = 181
        Me.btnXoa_TCT.Text = "Xóa tổ chức thi"
        '
        'btnDel_sv
        '
        Me.btnDel_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel_sv.Appearance.Options.UseFont = True
        Me.btnDel_sv.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnDel_sv.ImageIndex = 22
        Me.btnDel_sv.Location = New System.Drawing.Point(420, 533)
        Me.btnDel_sv.Name = "btnDel_sv"
        Me.btnDel_sv.Size = New System.Drawing.Size(103, 30)
        Me.btnDel_sv.TabIndex = 182
        Me.btnDel_sv.Text = "Xóa sinh viên"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(661, 533)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(94, 30)
        Me.btnExcel.TabIndex = 183
        Me.btnExcel.Text = "Xuất Excel"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(761, 533)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 30)
        Me.btnThoat.TabIndex = 182
        Me.btnThoat.Text = "Thoát"
        '
        'grcViewDanhSachThi
        '
        Me.grcViewDanhSachThi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcViewDanhSachThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grcViewDanhSachThi.Location = New System.Drawing.Point(270, 60)
        Me.grcViewDanhSachThi.MainView = Me.grdViewDanhSachThi
        Me.grcViewDanhSachThi.Name = "grcViewDanhSachThi"
        Me.grcViewDanhSachThi.Size = New System.Drawing.Size(828, 467)
        Me.grcViewDanhSachThi.TabIndex = 185
        Me.grcViewDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachThi})
        '
        'grdViewDanhSachThi
        '
        Me.grdViewDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSo_bao_danh, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTen_phong, Me.colGhi_chu_thi, Me.colHo_dem, Me.colTen})
        Me.grdViewDanhSachThi.GridControl = Me.grcViewDanhSachThi
        Me.grdViewDanhSachThi.Name = "grdViewDanhSachThi"
        Me.grdViewDanhSachThi.OptionsSelection.MultiSelect = True
        Me.grdViewDanhSachThi.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDanhSachThi.OptionsView.ShowFooter = True
        Me.grdViewDanhSachThi.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 50
        '
        'colSo_bao_danh
        '
        Me.colSo_bao_danh.Caption = "Số báo danh"
        Me.colSo_bao_danh.FieldName = "So_bao_danh"
        Me.colSo_bao_danh.Name = "colSo_bao_danh"
        Me.colSo_bao_danh.Visible = True
        Me.colSo_bao_danh.VisibleIndex = 1
        Me.colSo_bao_danh.Width = 65
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã sinh viên"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 2
        Me.colMa_sv.Width = 70
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Width = 120
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 5
        Me.colNgay_sinh.Width = 68
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 6
        Me.colTen_lop.Width = 77
        '
        'colTen_phong
        '
        Me.colTen_phong.Caption = "Tên phòng"
        Me.colTen_phong.FieldName = "Ten_phong"
        Me.colTen_phong.Name = "colTen_phong"
        Me.colTen_phong.Visible = True
        Me.colTen_phong.VisibleIndex = 7
        Me.colTen_phong.Width = 54
        '
        'colGhi_chu_thi
        '
        Me.colGhi_chu_thi.Caption = "Ghi chú thi"
        Me.colGhi_chu_thi.FieldName = "Ghi_chu_thi"
        Me.colGhi_chu_thi.Name = "colGhi_chu_thi"
        Me.colGhi_chu_thi.Visible = True
        Me.colGhi_chu_thi.VisibleIndex = 8
        Me.colGhi_chu_thi.Width = 106
        '
        'colHo_dem
        '
        Me.colHo_dem.Caption = "Họ đệm"
        Me.colHo_dem.FieldName = "Ho_dem"
        Me.colHo_dem.Name = "colHo_dem"
        Me.colHo_dem.Visible = True
        Me.colHo_dem.VisibleIndex = 3
        '
        'colTen
        '
        Me.colTen.Caption = "Tên"
        Me.colTen.FieldName = "Ten"
        Me.colTen.Name = "colTen"
        Me.colTen.Visible = True
        Me.colTen.VisibleIndex = 4
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem1, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem2, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem3, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem4, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.BarButtonItem5, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.btnAll_diem, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cmdPhieuTheoDoi_LyThuyet, False), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPhieuTheoDoiKetQua_DanPT), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPhieuTheoDoiKetQua_BC), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTotNghiepLT_DanPhong), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTotNghiep_LT), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Danh sách phòng thi"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.ImageIndex = 16
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "DS dan phong thi"
        Me.BarButtonItem2.Id = 10
        Me.BarButtonItem2.ImageIndex = 16
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "DS đánh phách phòng thi"
        Me.BarButtonItem3.Id = 11
        Me.BarButtonItem3.ImageIndex = 16
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "DS thi môn thực hành nghề"
        Me.BarButtonItem4.Id = 12
        Me.BarButtonItem4.ImageIndex = 16
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Bảng điểm theo phòng"
        Me.BarButtonItem5.Id = 13
        Me.BarButtonItem5.ImageIndex = 16
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Danh sách nộp bài thi tốt nghiệp ( mẫu 06 )"
        Me.BarButtonItem8.Id = 24
        Me.BarButtonItem8.ImageIndex = 16
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'btnAll_diem
        '
        Me.btnAll_diem.Caption = "Bảng điểm tổng hợp theo phòng"
        Me.btnAll_diem.Id = 14
        Me.btnAll_diem.Name = "btnAll_diem"
        '
        'cmdPhieuTheoDoi_LyThuyet
        '
        Me.cmdPhieuTheoDoi_LyThuyet.Caption = "Phiếu theo dõi KQ kiểm tra học kỳ (Lý thuyết)"
        Me.cmdPhieuTheoDoi_LyThuyet.Id = 15
        Me.cmdPhieuTheoDoi_LyThuyet.Name = "cmdPhieuTheoDoi_LyThuyet"
        '
        'btnPhieuTheoDoiKetQua_DanPT
        '
        Me.btnPhieuTheoDoiKetQua_DanPT.Caption = "Danh sách kiểm tra môn thực hành"
        Me.btnPhieuTheoDoiKetQua_DanPT.Id = 16
        Me.btnPhieuTheoDoiKetQua_DanPT.Name = "btnPhieuTheoDoiKetQua_DanPT"
        '
        'btnPhieuTheoDoiKetQua_BC
        '
        Me.btnPhieuTheoDoiKetQua_BC.Caption = "Danh sách kiểm tra môn lý thuyết"
        Me.btnPhieuTheoDoiKetQua_BC.Id = 17
        Me.btnPhieuTheoDoiKetQua_BC.Name = "btnPhieuTheoDoiKetQua_BC"
        '
        'btnTotNghiepLT_DanPhong
        '
        Me.btnTotNghiepLT_DanPhong.Caption = "Danh sách dự thi môn tốt nghiệp thực hành"
        Me.btnTotNghiepLT_DanPhong.Id = 18
        Me.btnTotNghiepLT_DanPhong.Name = "btnTotNghiepLT_DanPhong"
        '
        'btnTotNghiep_LT
        '
        Me.btnTotNghiep_LT.Caption = "Danh sách dự thi môn tốt nghiệp lý thuyết"
        Me.btnTotNghiep_LT.Id = 19
        Me.btnTotNghiep_LT.Name = "btnTotNghiep_LT"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Danh sách dán phòng thi"
        Me.BarButtonItem6.Id = 22
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Danh sách dán phòng thi tốt nghiệp"
        Me.BarButtonItem7.Id = 23
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kết quả thi kết thúc môn học"
        Me.BarButtonItem8.Id = 24
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("PopupMenu", New System.Guid("e259ec3f-8673-4306-bb4f-94322df1890e"))})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.btnAll_diem, Me.cmdPhieuTheoDoi_LyThuyet, Me.btnPhieuTheoDoiKetQua_DanPT, Me.btnPhieuTheoDoiKetQua_BC, Me.btnTotNghiepLT_DanPhong, Me.btnTotNghiep_LT, Me.btnTotNghiep_TH_DanPhong, Me.btnTotNghiep_TH, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 24
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1099, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(1099, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 566)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1099, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
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
        'btnTotNghiep_TH_DanPhong
        '
        Me.btnTotNghiep_TH_DanPhong.Caption = "Phiếu theo dõi phòng thi môn tốt nghiệp thực hành(Dán phòng thi)"
        Me.btnTotNghiep_TH_DanPhong.Id = 20
        Me.btnTotNghiep_TH_DanPhong.Name = "btnTotNghiep_TH_DanPhong"
        '
        'btnTotNghiep_TH
        '
        Me.btnTotNghiep_TH.Caption = "Phiếu theo dõi phòng thi môn tốt nghiệp thực hành"
        Me.btnTotNghiep_TH.Id = 21
        Me.btnTotNghiep_TH.Name = "btnTotNghiep_TH"
        '
        'cmdHocPhan
        '
        Me.cmdHocPhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdHocPhan.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHocPhan.Appearance.Options.UseFont = True
        Me.cmdHocPhan.DropDownControl = Me.PopupMenu2
        Me.cmdHocPhan.ImageIndex = 16
        Me.cmdHocPhan.ImageList = Me.ImgMain
        Me.cmdHocPhan.Location = New System.Drawing.Point(529, 533)
        Me.cmdHocPhan.Name = "cmdHocPhan"
        Me.cmdHocPhan.Size = New System.Drawing.Size(127, 30)
        Me.cmdHocPhan.TabIndex = 194
        Me.cmdHocPhan.Text = "In danh sách"
        '
        'ckIn_ds_luanvan
        '
        Me.ckIn_ds_luanvan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckIn_ds_luanvan.AutoSize = True
        Me.ckIn_ds_luanvan.Location = New System.Drawing.Point(809, 5)
        Me.ckIn_ds_luanvan.Name = "ckIn_ds_luanvan"
        Me.ckIn_ds_luanvan.Size = New System.Drawing.Size(101, 23)
        Me.ckIn_ds_luanvan.TabIndex = 199
        Me.ckIn_ds_luanvan.Text = "DS luận văn"
        Me.ckIn_ds_luanvan.UseVisualStyleBackColor = True
        Me.ckIn_ds_luanvan.Visible = False
        '
        'btnTongHopSVThiChinhTri
        '
        Me.btnTongHopSVThiChinhTri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTongHopSVThiChinhTri.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTongHopSVThiChinhTri.Appearance.Options.UseFont = True
        Me.btnTongHopSVThiChinhTri.Image = Global.ESS_Mark.My.Resources.Resources.HosoSV
        Me.btnTongHopSVThiChinhTri.ImageIndex = 22
        Me.btnTongHopSVThiChinhTri.Location = New System.Drawing.Point(847, 533)
        Me.btnTongHopSVThiChinhTri.Name = "btnTongHopSVThiChinhTri"
        Me.btnTongHopSVThiChinhTri.Size = New System.Drawing.Size(175, 30)
        Me.btnTongHopSVThiChinhTri.TabIndex = 204
        Me.btnTongHopSVThiChinhTri.Text = "Tổng hợp sv thi chính trị"
        Me.btnTongHopSVThiChinhTri.Visible = False
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Kết quả thi KT Mô đun (LT)"
        Me.BarButtonItem9.Id = 25
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Kết quả thi KT Mô đun (TH)"
        Me.BarButtonItem10.Id = 26
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'frmESS_ToChucThi_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1099, 566)
        Me.Controls.Add(Me.btnTongHopSVThiChinhTri)
        Me.Controls.Add(Me.ckIn_ds_luanvan)
        Me.Controls.Add(Me.cmdHocPhan)
        Me.Controls.Add(Me.grcViewDanhSachThi)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDel_sv)
        Me.Controls.Add(Me.btnXoa_TCT)
        Me.Controls.Add(Me.cmdSua_CTThi)
        Me.Controls.Add(Me.btnAdd_sv)
        Me.Controls.Add(Me.btnToTucThi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_ToChucThi_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH TO CHUC THI THEO KY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents trvPhongThi As ESS_Mark.TreeViewPhongThi
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnToTucThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSua_CTThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa_TCT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcViewDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_bao_danh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_phong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu_thi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_dem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdHocPhan As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ckIn_ds_luanvan As System.Windows.Forms.CheckBox
    Friend WithEvents btnAll_diem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTongHopSVThiChinhTri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPhieuTheoDoi_LyThuyet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPhieuTheoDoiKetQua_DanPT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPhieuTheoDoiKetQua_BC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTotNghiepLT_DanPhong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTotNghiep_LT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTotNghiep_TH_DanPhong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTotNghiep_TH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
End Class
