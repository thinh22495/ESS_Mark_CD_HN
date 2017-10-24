<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ChuongTrinhDaoTaoList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ChuongTrinhDaoTaoList))
        Me.txtTong_so_mon = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelCTDT = New DevExpress.XtraEditors.PanelControl
        Me.grcCTDT = New DevExpress.XtraGrid.GridControl
        Me.grvChuongTrinhDaoTaoList = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTen_he = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKhoa_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChuyen_nganh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSoTinChi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_ky_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelCTDTChiTiet = New DevExpress.XtraEditors.PanelControl
        Me.grcCTDTChiTiet = New DevExpress.XtraGrid.GridControl
        Me.grvCTDTChiTiet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSTT_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKien_thuc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueKhoiKienThuc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_thu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_thuyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThuc_hanh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTong_so_tiet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTu_chon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNhom_tu_chon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKhong_tinh_TBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMon_tot_nghiep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_mon_main = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueID_mon_main = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLy_thuyet_nghe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThuc_hanh_nghe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBai_tap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTu_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.SpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_TheoKy = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_TheoKhoiKT = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdAdd_HP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdRemove_HP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdAdd_CT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdDelete_CT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdCopy = New DevExpress.XtraBars.BarButtonItem
        Me.cmdImport = New DevExpress.XtraBars.BarButtonItem
        Me.cmdUpdate_Diem = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRangBuoc = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdNhomTuChon = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGanLop = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLuu = New DevExpress.XtraEditors.SimpleButton
        Me.cmdHocPhan = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdCTDT = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.optTinh_DVHT = New System.Windows.Forms.CheckBox
        Me.cmdChungChi = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelCTDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCTDT.SuspendLayout()
        CType(Me.grcCTDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvChuongTrinhDaoTaoList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCTDTChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCTDTChiTiet.SuspendLayout()
        CType(Me.grcCTDTChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCTDTChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKhoiKienThuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueID_mon_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTong_so_mon
        '
        Me.txtTong_so_mon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTong_so_mon.BackColor = System.Drawing.Color.Transparent
        Me.txtTong_so_mon.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTong_so_mon.ForeColor = System.Drawing.Color.Maroon
        Me.txtTong_so_mon.Location = New System.Drawing.Point(1206, 212)
        Me.txtTong_so_mon.Name = "txtTong_so_mon"
        Me.txtTong_so_mon.Size = New System.Drawing.Size(34, 18)
        Me.txtTong_so_mon.TabIndex = 63
        Me.txtTong_so_mon.Text = "0"
        Me.txtTong_so_mon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ten_he"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Hệ đào tạo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 129
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 165
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ten_khoa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Khoa"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 166
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Khoa_hoc"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Khoá học"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 165
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ten_chuyen_nganh"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Chuyên ngành"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 160
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 165
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "So_hoc_trinh"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Số tín chỉ"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 166
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "So_Ky_hoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Số kỳ học tối đa"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 165
        '
        'PanelCTDT
        '
        Me.PanelCTDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCTDT.Controls.Add(Me.grcCTDT)
        Me.PanelCTDT.Location = New System.Drawing.Point(0, 0)
        Me.PanelCTDT.Name = "PanelCTDT"
        Me.PanelCTDT.Size = New System.Drawing.Size(1195, 202)
        Me.PanelCTDT.TabIndex = 71
        '
        'grcCTDT
        '
        Me.grcCTDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCTDT.Location = New System.Drawing.Point(2, 2)
        Me.grcCTDT.MainView = Me.grvChuongTrinhDaoTaoList
        Me.grcCTDT.Name = "grcCTDT"
        Me.grcCTDT.Size = New System.Drawing.Size(1191, 198)
        Me.grcCTDT.TabIndex = 0
        Me.grcCTDT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvChuongTrinhDaoTaoList})
        '
        'grvChuongTrinhDaoTaoList
        '
        Me.grvChuongTrinhDaoTaoList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTen_he, Me.colTen_khoa, Me.colKhoa_hoc, Me.colChuyen_nganh, Me.colSoTinChi, Me.colSo_ky_hoc, Me.colSo})
        Me.grvChuongTrinhDaoTaoList.GridControl = Me.grcCTDT
        Me.grvChuongTrinhDaoTaoList.GroupCount = 1
        Me.grvChuongTrinhDaoTaoList.Name = "grvChuongTrinhDaoTaoList"
        Me.grvChuongTrinhDaoTaoList.OptionsSelection.MultiSelect = True
        Me.grvChuongTrinhDaoTaoList.OptionsView.ShowAutoFilterRow = True
        Me.grvChuongTrinhDaoTaoList.OptionsView.ShowGroupPanel = False
        Me.grvChuongTrinhDaoTaoList.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTen_he, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTen_he
        '
        Me.colTen_he.Caption = "Trình độ"
        Me.colTen_he.FieldName = "Ten_he"
        Me.colTen_he.Name = "colTen_he"
        Me.colTen_he.OptionsColumn.AllowEdit = False
        Me.colTen_he.OptionsColumn.ReadOnly = True
        Me.colTen_he.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List
        Me.colTen_he.Width = 181
        '
        'colTen_khoa
        '
        Me.colTen_khoa.Caption = "Khoa"
        Me.colTen_khoa.FieldName = "Ten_khoa"
        Me.colTen_khoa.Name = "colTen_khoa"
        Me.colTen_khoa.OptionsColumn.AllowEdit = False
        Me.colTen_khoa.Visible = True
        Me.colTen_khoa.VisibleIndex = 0
        Me.colTen_khoa.Width = 181
        '
        'colKhoa_hoc
        '
        Me.colKhoa_hoc.Caption = "Khóa học"
        Me.colKhoa_hoc.FieldName = "Khoa_hoc"
        Me.colKhoa_hoc.Name = "colKhoa_hoc"
        Me.colKhoa_hoc.OptionsColumn.AllowEdit = False
        Me.colKhoa_hoc.Visible = True
        Me.colKhoa_hoc.VisibleIndex = 1
        Me.colKhoa_hoc.Width = 181
        '
        'colChuyen_nganh
        '
        Me.colChuyen_nganh.Caption = "Chuyên ngành"
        Me.colChuyen_nganh.FieldName = "Ten_chuyen_nganh"
        Me.colChuyen_nganh.Name = "colChuyen_nganh"
        Me.colChuyen_nganh.OptionsColumn.AllowEdit = False
        Me.colChuyen_nganh.Visible = True
        Me.colChuyen_nganh.VisibleIndex = 2
        Me.colChuyen_nganh.Width = 161
        '
        'colSoTinChi
        '
        Me.colSoTinChi.Caption = "Hệ số"
        Me.colSoTinChi.FieldName = "So_hoc_trinh"
        Me.colSoTinChi.Name = "colSoTinChi"
        Me.colSoTinChi.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colSoTinChi.Visible = True
        Me.colSoTinChi.VisibleIndex = 3
        Me.colSoTinChi.Width = 181
        '
        'colSo_ky_hoc
        '
        Me.colSo_ky_hoc.Caption = "Số kỳ học"
        Me.colSo_ky_hoc.FieldName = "So_ky_hoc"
        Me.colSo_ky_hoc.Name = "colSo_ky_hoc"
        Me.colSo_ky_hoc.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colSo_ky_hoc.Visible = True
        Me.colSo_ky_hoc.VisibleIndex = 4
        Me.colSo_ky_hoc.Width = 205
        '
        'colSo
        '
        Me.colSo.Caption = "Số"
        Me.colSo.FieldName = "So"
        Me.colSo.Name = "colSo"
        Me.colSo.Visible = True
        Me.colSo.VisibleIndex = 5
        '
        'PanelCTDTChiTiet
        '
        Me.PanelCTDTChiTiet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCTDTChiTiet.Controls.Add(Me.grcCTDTChiTiet)
        Me.PanelCTDTChiTiet.Location = New System.Drawing.Point(0, 242)
        Me.PanelCTDTChiTiet.Name = "PanelCTDTChiTiet"
        Me.PanelCTDTChiTiet.Size = New System.Drawing.Size(1195, 324)
        Me.PanelCTDTChiTiet.TabIndex = 76
        '
        'grcCTDTChiTiet
        '
        Me.grcCTDTChiTiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcCTDTChiTiet.Location = New System.Drawing.Point(2, 2)
        Me.grcCTDTChiTiet.MainView = Me.grvCTDTChiTiet
        Me.grcCTDTChiTiet.Name = "grcCTDTChiTiet"
        Me.grcCTDTChiTiet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueKhoiKienThuc, Me.SpinEdit1, Me.SpinEdit2, Me.lueID_mon_main})
        Me.grcCTDTChiTiet.Size = New System.Drawing.Size(1191, 320)
        Me.grcCTDTChiTiet.TabIndex = 0
        Me.grcCTDTChiTiet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCTDTChiTiet})
        '
        'grvCTDTChiTiet
        '
        Me.grvCTDTChiTiet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT_mon, Me.colKien_thuc, Me.colKy_hieu, Me.colTen_mon, Me.colKy_thu, Me.colSo_hoc_trinh, Me.colLy_thuyet, Me.colThuc_hanh, Me.colTong_so_tiet, Me.colTu_chon, Me.colNhom_tu_chon, Me.colKhong_tinh_TBCHT, Me.colMon_tot_nghiep, Me.colID_mon_main, Me.colLy_thuyet_nghe, Me.colThuc_hanh_nghe, Me.colBai_tap, Me.colTu_hoc})
        Me.grvCTDTChiTiet.GridControl = Me.grcCTDTChiTiet
        Me.grvCTDTChiTiet.GroupPanelText = "Hãy chọn và kéo cột bạn muốn nhóm vào đây"
        Me.grvCTDTChiTiet.Name = "grvCTDTChiTiet"
        Me.grvCTDTChiTiet.OptionsMenu.EnableColumnMenu = False
        Me.grvCTDTChiTiet.OptionsMenu.EnableFooterMenu = False
        Me.grvCTDTChiTiet.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvCTDTChiTiet.OptionsView.ColumnAutoWidth = False
        Me.grvCTDTChiTiet.OptionsView.ShowAutoFilterRow = True
        Me.grvCTDTChiTiet.OptionsView.ShowGroupPanel = False
        '
        'colSTT_mon
        '
        Me.colSTT_mon.Caption = "STT"
        Me.colSTT_mon.FieldName = "STT_mon"
        Me.colSTT_mon.Name = "colSTT_mon"
        Me.colSTT_mon.Visible = True
        Me.colSTT_mon.VisibleIndex = 0
        Me.colSTT_mon.Width = 42
        '
        'colKien_thuc
        '
        Me.colKien_thuc.Caption = "Khối kiến thức"
        Me.colKien_thuc.ColumnEdit = Me.lueKhoiKienThuc
        Me.colKien_thuc.FieldName = "Kien_thuc"
        Me.colKien_thuc.Name = "colKien_thuc"
        Me.colKien_thuc.Visible = True
        Me.colKien_thuc.VisibleIndex = 1
        Me.colKien_thuc.Width = 120
        '
        'lueKhoiKienThuc
        '
        Me.lueKhoiKienThuc.AutoHeight = False
        Me.lueKhoiKienThuc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKhoiKienThuc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kien_thuc", 100, "Kiến thức")})
        Me.lueKhoiKienThuc.DisplayMember = "Ten_kien_thuc"
        Me.lueKhoiKienThuc.DropDownRows = 5
        Me.lueKhoiKienThuc.Name = "lueKhoiKienThuc"
        Me.lueKhoiKienThuc.ValueMember = "ID_kien_thuc"
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.AllowEdit = False
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 2
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.AllowEdit = False
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 3
        Me.colTen_mon.Width = 154
        '
        'colKy_thu
        '
        Me.colKy_thu.Caption = "Kỳ"
        Me.colKy_thu.FieldName = "Ky_thu"
        Me.colKy_thu.Name = "colKy_thu"
        Me.colKy_thu.Visible = True
        Me.colKy_thu.VisibleIndex = 4
        Me.colKy_thu.Width = 37
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "Hệ số MH"
        Me.colSo_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 5
        Me.colSo_hoc_trinh.Width = 65
        '
        'colLy_thuyet
        '
        Me.colLy_thuyet.Caption = "Lý thuyết"
        Me.colLy_thuyet.FieldName = "Ly_thuyet"
        Me.colLy_thuyet.Name = "colLy_thuyet"
        Me.colLy_thuyet.Visible = True
        Me.colLy_thuyet.VisibleIndex = 6
        Me.colLy_thuyet.Width = 65
        '
        'colThuc_hanh
        '
        Me.colThuc_hanh.Caption = "Thực hành"
        Me.colThuc_hanh.FieldName = "Thuc_hanh"
        Me.colThuc_hanh.Name = "colThuc_hanh"
        Me.colThuc_hanh.Visible = True
        Me.colThuc_hanh.VisibleIndex = 7
        Me.colThuc_hanh.Width = 62
        '
        'colTong_so_tiet
        '
        Me.colTong_so_tiet.Caption = "Tổng tiết"
        Me.colTong_so_tiet.FieldName = "Tong_so_tiet"
        Me.colTong_so_tiet.Name = "colTong_so_tiet"
        Me.colTong_so_tiet.Visible = True
        Me.colTong_so_tiet.VisibleIndex = 10
        Me.colTong_so_tiet.Width = 57
        '
        'colTu_chon
        '
        Me.colTu_chon.Caption = "Tự chọn"
        Me.colTu_chon.FieldName = "Tu_chon"
        Me.colTu_chon.Name = "colTu_chon"
        Me.colTu_chon.Width = 56
        '
        'colNhom_tu_chon
        '
        Me.colNhom_tu_chon.Caption = "Nhóm tự chọn"
        Me.colNhom_tu_chon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNhom_tu_chon.FieldName = "Nhom_tu_chon"
        Me.colNhom_tu_chon.Name = "colNhom_tu_chon"
        Me.colNhom_tu_chon.Width = 61
        '
        'colKhong_tinh_TBCHT
        '
        Me.colKhong_tinh_TBCHT.Caption = "Không tính TBCHT"
        Me.colKhong_tinh_TBCHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKhong_tinh_TBCHT.FieldName = "Khong_tinh_TBCHT"
        Me.colKhong_tinh_TBCHT.Name = "colKhong_tinh_TBCHT"
        Me.colKhong_tinh_TBCHT.Visible = True
        Me.colKhong_tinh_TBCHT.VisibleIndex = 11
        Me.colKhong_tinh_TBCHT.Width = 105
        '
        'colMon_tot_nghiep
        '
        Me.colMon_tot_nghiep.Caption = "Môn tốt nghiệp"
        Me.colMon_tot_nghiep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMon_tot_nghiep.FieldName = "Mon_tot_nghiep"
        Me.colMon_tot_nghiep.Name = "colMon_tot_nghiep"
        Me.colMon_tot_nghiep.Visible = True
        Me.colMon_tot_nghiep.VisibleIndex = 12
        '
        'colID_mon_main
        '
        Me.colID_mon_main.Caption = "Thuộc nhóm học phần"
        Me.colID_mon_main.ColumnEdit = Me.lueID_mon_main
        Me.colID_mon_main.FieldName = "ID_mon_main"
        Me.colID_mon_main.Name = "colID_mon_main"
        Me.colID_mon_main.Visible = True
        Me.colID_mon_main.VisibleIndex = 13
        Me.colID_mon_main.Width = 50
        '
        'lueID_mon_main
        '
        Me.lueID_mon_main.AutoHeight = False
        Me.lueID_mon_main.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueID_mon_main.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_mon_m", "Thuộc nhóm học phần")})
        Me.lueID_mon_main.DisplayMember = "ID_mon"
        Me.lueID_mon_main.Name = "lueID_mon_main"
        Me.lueID_mon_main.ValueMember = "Ten_mon_m"
        '
        'colLy_thuyet_nghe
        '
        Me.colLy_thuyet_nghe.Caption = "Lý thuyết nghề"
        Me.colLy_thuyet_nghe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLy_thuyet_nghe.FieldName = "Ly_thuyet_nghe"
        Me.colLy_thuyet_nghe.Name = "colLy_thuyet_nghe"
        Me.colLy_thuyet_nghe.Visible = True
        Me.colLy_thuyet_nghe.VisibleIndex = 14
        Me.colLy_thuyet_nghe.Width = 28
        '
        'colThuc_hanh_nghe
        '
        Me.colThuc_hanh_nghe.Caption = "Thực hành nghề"
        Me.colThuc_hanh_nghe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colThuc_hanh_nghe.FieldName = "Thuc_hanh_nghe"
        Me.colThuc_hanh_nghe.Name = "colThuc_hanh_nghe"
        Me.colThuc_hanh_nghe.Visible = True
        Me.colThuc_hanh_nghe.VisibleIndex = 15
        '
        'colBai_tap
        '
        Me.colBai_tap.Caption = "Kiểm tra"
        Me.colBai_tap.FieldName = "Bai_tap"
        Me.colBai_tap.Name = "colBai_tap"
        Me.colBai_tap.Visible = True
        Me.colBai_tap.VisibleIndex = 8
        '
        'colTu_hoc
        '
        Me.colTu_hoc.Caption = "Tự học"
        Me.colTu_hoc.FieldName = "Tu_hoc"
        Me.colTu_hoc.Name = "colTu_hoc"
        Me.colTu_hoc.Visible = True
        Me.colTu_hoc.VisibleIndex = 9
        '
        'SpinEdit1
        '
        Me.SpinEdit1.AutoHeight = False
        Me.SpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Name = "SpinEdit1"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.AutoHeight = False
        Me.SpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Name = "SpinEdit2"
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
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_TheoKy), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_TheoKhoiKT)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_TheoKy
        '
        Me.cmdPrint_TheoKy.Caption = "In theo kỳ"
        Me.cmdPrint_TheoKy.Id = 0
        Me.cmdPrint_TheoKy.ImageIndex = 16
        Me.cmdPrint_TheoKy.Name = "cmdPrint_TheoKy"
        '
        'cmdPrint_TheoKhoiKT
        '
        Me.cmdPrint_TheoKhoiKT.Caption = "In theo khối kiến thức"
        Me.cmdPrint_TheoKhoiKT.Id = 1
        Me.cmdPrint_TheoKhoiKT.ImageIndex = 16
        Me.cmdPrint_TheoKhoiKT.Name = "cmdPrint_TheoKhoiKT"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_TheoKy, Me.cmdPrint_TheoKhoiKT, Me.cmdAdd_HP, Me.cmdRemove_HP, Me.cmdAdd_CT, Me.cmdDelete_CT, Me.cmdCopy, Me.cmdImport, Me.cmdUpdate_Diem, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 10
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1195, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(1195, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(1195, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'cmdAdd_HP
        '
        Me.cmdAdd_HP.Caption = "Thêm học phần"
        Me.cmdAdd_HP.Id = 2
        Me.cmdAdd_HP.ImageIndex = 0
        Me.cmdAdd_HP.Name = "cmdAdd_HP"
        '
        'cmdRemove_HP
        '
        Me.cmdRemove_HP.Caption = "Loại học phần"
        Me.cmdRemove_HP.Id = 3
        Me.cmdRemove_HP.ImageIndex = 4
        Me.cmdRemove_HP.Name = "cmdRemove_HP"
        '
        'cmdAdd_CT
        '
        Me.cmdAdd_CT.Caption = "Thêm"
        Me.cmdAdd_CT.Id = 4
        Me.cmdAdd_CT.ImageIndex = 0
        Me.cmdAdd_CT.Name = "cmdAdd_CT"
        '
        'cmdDelete_CT
        '
        Me.cmdDelete_CT.Caption = "Xóa"
        Me.cmdDelete_CT.Id = 5
        Me.cmdDelete_CT.ImageIndex = 4
        Me.cmdDelete_CT.Name = "cmdDelete_CT"
        '
        'cmdCopy
        '
        Me.cmdCopy.Caption = "Sao chép"
        Me.cmdCopy.Id = 6
        Me.cmdCopy.ImageIndex = 18
        Me.cmdCopy.Name = "cmdCopy"
        '
        'cmdImport
        '
        Me.cmdImport.Caption = "Nhập khẩu"
        Me.cmdImport.Id = 7
        Me.cmdImport.ImageIndex = 11
        Me.cmdImport.Name = "cmdImport"
        '
        'cmdUpdate_Diem
        '
        Me.cmdUpdate_Diem.Caption = "Cập nhật điểm theo CTĐT"
        Me.cmdUpdate_Diem.Id = 8
        Me.cmdUpdate_Diem.ImageIndex = 10
        Me.cmdUpdate_Diem.Name = "cmdUpdate_Diem"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(1102, 208)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(84, 30)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
        '
        'cmdRangBuoc
        '
        Me.cmdRangBuoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRangBuoc.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRangBuoc.Appearance.Options.UseFont = True
        Me.cmdRangBuoc.ImageIndex = 6
        Me.cmdRangBuoc.ImageList = Me.ImgMain
        Me.cmdRangBuoc.Location = New System.Drawing.Point(759, 208)
        Me.cmdRangBuoc.Name = "cmdRangBuoc"
        Me.cmdRangBuoc.Size = New System.Drawing.Size(114, 30)
        Me.cmdRangBuoc.TabIndex = 164
        Me.cmdRangBuoc.Text = "Ràng buộc HP"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(986, 208)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(111, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In báo cáo"
        '
        'cmdNhomTuChon
        '
        Me.cmdNhomTuChon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNhomTuChon.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNhomTuChon.Appearance.Options.UseFont = True
        Me.cmdNhomTuChon.ImageIndex = 14
        Me.cmdNhomTuChon.ImageList = Me.ImgMain
        Me.cmdNhomTuChon.Location = New System.Drawing.Point(642, 208)
        Me.cmdNhomTuChon.Name = "cmdNhomTuChon"
        Me.cmdNhomTuChon.Size = New System.Drawing.Size(113, 30)
        Me.cmdNhomTuChon.TabIndex = 164
        Me.cmdNhomTuChon.Text = "Nhóm tự chọn"
        '
        'cmdGanLop
        '
        Me.cmdGanLop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGanLop.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGanLop.Appearance.Options.UseFont = True
        Me.cmdGanLop.ImageIndex = 9
        Me.cmdGanLop.ImageList = Me.ImgMain
        Me.cmdGanLop.Location = New System.Drawing.Point(554, 208)
        Me.cmdGanLop.Name = "cmdGanLop"
        Me.cmdGanLop.Size = New System.Drawing.Size(85, 30)
        Me.cmdGanLop.TabIndex = 164
        Me.cmdGanLop.Text = "Gán lớp"
        '
        'cmdLuu
        '
        Me.cmdLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLuu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLuu.Appearance.Options.UseFont = True
        Me.cmdLuu.ImageIndex = 18
        Me.cmdLuu.ImageList = Me.ImgMain
        Me.cmdLuu.Location = New System.Drawing.Point(180, 208)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(103, 30)
        Me.cmdLuu.TabIndex = 164
        Me.cmdLuu.Text = "Cập nhật"
        '
        'cmdHocPhan
        '
        Me.cmdHocPhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHocPhan.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHocPhan.Appearance.Options.UseFont = True
        Me.cmdHocPhan.DropDownControl = Me.PopupMenu2
        Me.cmdHocPhan.ImageIndex = 3
        Me.cmdHocPhan.ImageList = Me.ImgMain
        Me.cmdHocPhan.Location = New System.Drawing.Point(444, 208)
        Me.cmdHocPhan.Name = "cmdHocPhan"
        Me.cmdHocPhan.Size = New System.Drawing.Size(106, 30)
        Me.cmdHocPhan.TabIndex = 163
        Me.cmdHocPhan.Text = "Học phần"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_HP), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdRemove_HP)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'cmdCTDT
        '
        Me.cmdCTDT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCTDT.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCTDT.Appearance.Options.UseFont = True
        Me.cmdCTDT.DropDownControl = Me.PopupMenu3
        Me.cmdCTDT.ImageIndex = 8
        Me.cmdCTDT.ImageList = Me.ImgMain
        Me.cmdCTDT.Location = New System.Drawing.Point(287, 208)
        Me.cmdCTDT.Name = "cmdCTDT"
        Me.cmdCTDT.Size = New System.Drawing.Size(154, 30)
        Me.cmdCTDT.TabIndex = 163
        Me.cmdCTDT.Text = "Khung chương trình"
        '
        'PopupMenu3
        '
        Me.PopupMenu3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_CT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdDelete_CT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImport), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdUpdate_Diem)})
        Me.PopupMenu3.Manager = Me.BarManager1
        Me.PopupMenu3.Name = "PopupMenu3"
        '
        'optTinh_DVHT
        '
        Me.optTinh_DVHT.AutoSize = True
        Me.optTinh_DVHT.Location = New System.Drawing.Point(2, 216)
        Me.optTinh_DVHT.Name = "optTinh_DVHT"
        Me.optTinh_DVHT.Size = New System.Drawing.Size(97, 20)
        Me.optTinh_DVHT.TabIndex = 170
        Me.optTinh_DVHT.Text = "Tính ĐVHT"
        Me.optTinh_DVHT.UseVisualStyleBackColor = True
        '
        'cmdChungChi
        '
        Me.cmdChungChi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChungChi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChungChi.Appearance.Options.UseFont = True
        Me.cmdChungChi.ImageIndex = 21
        Me.cmdChungChi.ImageList = Me.ImgMain
        Me.cmdChungChi.Location = New System.Drawing.Point(876, 208)
        Me.cmdChungChi.Name = "cmdChungChi"
        Me.cmdChungChi.Size = New System.Drawing.Size(105, 30)
        Me.cmdChungChi.TabIndex = 175
        Me.cmdChungChi.Text = "Chứng chỉ"
        '
        'frmESS_ChuongTrinhDaoTaoList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1195, 566)
        Me.Controls.Add(Me.cmdChungChi)
        Me.Controls.Add(Me.optTinh_DVHT)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdLuu)
        Me.Controls.Add(Me.cmdGanLop)
        Me.Controls.Add(Me.cmdNhomTuChon)
        Me.Controls.Add(Me.cmdRangBuoc)
        Me.Controls.Add(Me.cmdCTDT)
        Me.Controls.Add(Me.cmdHocPhan)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.PanelCTDTChiTiet)
        Me.Controls.Add(Me.PanelCTDT)
        Me.Controls.Add(Me.txtTong_so_mon)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_ChuongTrinhDaoTaoList"
        Me.Text = "QUAN LY KHUNG CHUONG TRINH DAO TAO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelCTDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCTDT.ResumeLayout(False)
        CType(Me.grcCTDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvChuongTrinhDaoTaoList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCTDTChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCTDTChiTiet.ResumeLayout(False)
        CType(Me.grcCTDTChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCTDTChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKhoiKienThuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueID_mon_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTong_so_mon As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelCTDT As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcCTDT As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvChuongTrinhDaoTaoList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTen_he As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKhoa_hoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoTinChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChuyen_nganh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_ky_hoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelCTDTChiTiet As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grcCTDTChiTiet As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCTDTChiTiet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSTT_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKien_thuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_thu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_thuyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThuc_hanh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTong_so_tiet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTu_chon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhom_tu_chon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKhong_tinh_TBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKhoiKienThuc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdRangBuoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_TheoKy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_TheoKhoiKT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGanLop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNhomTuChon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdHocPhan As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdAdd_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdRemove_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCTDT As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdAdd_CT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdDelete_CT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents colMon_tot_nghiep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_mon_main As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueID_mon_main As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents optTinh_DVHT As System.Windows.Forms.CheckBox
    Friend WithEvents cmdChungChi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate_Diem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colLy_thuyet_nghe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThuc_hanh_nghe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colBai_tap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTu_hoc As DevExpress.XtraGrid.Columns.GridColumn
End Class
