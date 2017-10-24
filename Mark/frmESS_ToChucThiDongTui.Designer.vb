<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThiDongTui
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThiDongTui))
        Me.txtSophach_tu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTui_thi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSo_sv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.chkAll2 = New System.Windows.Forms.CheckBox()
        Me.chkAll1 = New System.Windows.Forms.CheckBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnPrint3 = New System.Windows.Forms.Button()
        Me.btnPrint2 = New System.Windows.Forms.Button()
        Me.btnPrint1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTien_to = New System.Windows.Forms.TextBox()
        Me.trvPhongThi = New ESS_Mark.TreeViewPhongThi()
        Me.grvDanhSachThi = New DevExpress.XtraGrid.GridControl()
        Me.grdViewDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSBD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChuyen_nganh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhong_thi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGhi_chu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grvViewDanhSachThiChon = New DevExpress.XtraGrid.GridControl()
        Me.grdViewDanhSachThiChon = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvViewDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSophach_tu
        '
        Me.txtSophach_tu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSophach_tu.Location = New System.Drawing.Point(1052, 36)
        Me.txtSophach_tu.MaxLength = 8
        Me.txtSophach_tu.Name = "txtSophach_tu"
        Me.txtSophach_tu.Size = New System.Drawing.Size(42, 26)
        Me.txtSophach_tu.TabIndex = 59
        Me.txtSophach_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(940, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Số phách từ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTui_thi
        '
        Me.cmbTui_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTui_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTui_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbTui_thi.Location = New System.Drawing.Point(870, 36)
        Me.cmbTui_thi.Name = "cmbTui_thi"
        Me.cmbTui_thi.Size = New System.Drawing.Size(64, 27)
        Me.cmbTui_thi.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(789, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Túi thí số:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(916, 289)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(34, 18)
        Me.txtSo_sv.TabIndex = 102
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(782, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Tổng số sinh viên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(957, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 25)
        Me.btnAdd.TabIndex = 100
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Brown
        Me.btnDel.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(1029, 286)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(65, 25)
        Me.btnDel.TabIndex = 99
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'chkAll2
        '
        Me.chkAll2.AutoSize = True
        Me.chkAll2.BackColor = System.Drawing.Color.Transparent
        Me.chkAll2.Location = New System.Drawing.Point(282, 289)
        Me.chkAll2.Name = "chkAll2"
        Me.chkAll2.Size = New System.Drawing.Size(98, 23)
        Me.chkAll2.TabIndex = 104
        Me.chkAll2.Text = "Chọn tất cả"
        Me.chkAll2.UseVisualStyleBackColor = False
        '
        'chkAll1
        '
        Me.chkAll1.AutoSize = True
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(282, 38)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(98, 23)
        Me.chkAll1.TabIndex = 103
        Me.chkAll1.Text = "Chọn tất cả"
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(325, 537)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 29)
        Me.btnThoat.TabIndex = 131
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnPrint3
        '
        Me.btnPrint3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint3.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint3.Location = New System.Drawing.Point(661, 537)
        Me.btnPrint3.Name = "btnPrint3"
        Me.btnPrint3.Size = New System.Drawing.Size(203, 29)
        Me.btnPrint3.TabIndex = 130
        Me.btnPrint3.Text = "Bản Phách - Điểm số và chữ"
        Me.btnPrint3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint3.UseVisualStyleBackColor = True
        Me.btnPrint3.Visible = False
        '
        'btnPrint2
        '
        Me.btnPrint2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint2.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint2.Location = New System.Drawing.Point(878, 537)
        Me.btnPrint2.Name = "btnPrint2"
        Me.btnPrint2.Size = New System.Drawing.Size(168, 29)
        Me.btnPrint2.TabIndex = 129
        Me.btnPrint2.Text = "Bản hướng dẫn dồn túi"
        Me.btnPrint2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint2.UseVisualStyleBackColor = True
        Me.btnPrint2.Visible = False
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint1.Location = New System.Drawing.Point(121, 537)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(198, 29)
        Me.btnPrint1.TabIndex = 128
        Me.btnPrint1.Text = "Bản đối chiếu Phách - SBD"
        Me.btnPrint1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 537)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 29)
        Me.btnSave.TabIndex = 127
        Me.btnSave.Text = "Lập số phách"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(650, 22)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "ĐÓNG TÚI THI THỦ CÔNG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(940, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Tiền tố phách:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'txtTien_to
        '
        Me.txtTien_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTien_to.Location = New System.Drawing.Point(1052, 9)
        Me.txtTien_to.MaxLength = 2
        Me.txtTien_to.Name = "txtTien_to"
        Me.txtTien_to.Size = New System.Drawing.Size(42, 26)
        Me.txtTien_to.TabIndex = 59
        Me.txtTien_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTien_to.Visible = False
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 1)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 530)
        Me.trvPhongThi.TabIndex = 55
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvDanhSachThi.Location = New System.Drawing.Point(266, 67)
        Me.grvDanhSachThi.MainView = Me.grdViewDanhSachThi
        Me.grvDanhSachThi.Name = "grvDanhSachThi"
        Me.grvDanhSachThi.Size = New System.Drawing.Size(828, 213)
        Me.grvDanhSachThi.TabIndex = 133
        Me.grvDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachThi})
        '
        'grdViewDanhSachThi
        '
        Me.grdViewDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSBD, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colLop, Me.colChuyen_nganh, Me.colPhong_thi, Me.colGhi_chu})
        Me.grdViewDanhSachThi.GridControl = Me.grvDanhSachThi
        Me.grdViewDanhSachThi.Name = "grdViewDanhSachThi"
        Me.grdViewDanhSachThi.OptionsView.ShowAutoFilterRow = True
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
        '
        'colSBD
        '
        Me.colSBD.Caption = "Số BD"
        Me.colSBD.FieldName = "So_bao_danh"
        Me.colSBD.Name = "colSBD"
        Me.colSBD.OptionsColumn.ReadOnly = True
        Me.colSBD.Visible = True
        Me.colSBD.VisibleIndex = 1
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 2
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 3
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_snh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 4
        '
        'colLop
        '
        Me.colLop.Caption = "Lớp"
        Me.colLop.FieldName = "Ten_lop"
        Me.colLop.Name = "colLop"
        Me.colLop.OptionsColumn.ReadOnly = True
        Me.colLop.Visible = True
        Me.colLop.VisibleIndex = 5
        '
        'colChuyen_nganh
        '
        Me.colChuyen_nganh.Caption = "Nghề"
        Me.colChuyen_nganh.FieldName = "Chuyen_nganh"
        Me.colChuyen_nganh.Name = "colChuyen_nganh"
        Me.colChuyen_nganh.OptionsColumn.ReadOnly = True
        Me.colChuyen_nganh.Visible = True
        Me.colChuyen_nganh.VisibleIndex = 6
        '
        'colPhong_thi
        '
        Me.colPhong_thi.Caption = "Phòng thi"
        Me.colPhong_thi.FieldName = "Ten_phong"
        Me.colPhong_thi.Name = "colPhong_thi"
        Me.colPhong_thi.OptionsColumn.ReadOnly = True
        Me.colPhong_thi.Visible = True
        Me.colPhong_thi.VisibleIndex = 7
        '
        'colGhi_chu
        '
        Me.colGhi_chu.Caption = "Ghi chú"
        Me.colGhi_chu.FieldName = "Ghi_chu"
        Me.colGhi_chu.Name = "colGhi_chu"
        Me.colGhi_chu.OptionsColumn.ReadOnly = True
        Me.colGhi_chu.Visible = True
        Me.colGhi_chu.VisibleIndex = 8
        '
        'grvViewDanhSachThiChon
        '
        Me.grvViewDanhSachThiChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvViewDanhSachThiChon.Location = New System.Drawing.Point(266, 318)
        Me.grvViewDanhSachThiChon.MainView = Me.grdViewDanhSachThiChon
        Me.grvViewDanhSachThiChon.Name = "grvViewDanhSachThiChon"
        Me.grvViewDanhSachThiChon.Size = New System.Drawing.Size(828, 213)
        Me.grvViewDanhSachThiChon.TabIndex = 133
        Me.grvViewDanhSachThiChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachThiChon})
        '
        'grdViewDanhSachThiChon
        '
        Me.grdViewDanhSachThiChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.grdViewDanhSachThiChon.GridControl = Me.grvViewDanhSachThiChon
        Me.grdViewDanhSachThiChon.Name = "grdViewDanhSachThiChon"
        Me.grdViewDanhSachThiChon.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDanhSachThiChon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Chọn"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Chon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Số BD"
        Me.GridColumn2.FieldName = "So_bao_danh"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Mã SV"
        Me.GridColumn3.FieldName = "Ma_sv"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Họ tên"
        Me.GridColumn4.FieldName = "Ho_ten"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ngày sinh"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "Ngay_snh"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Lớp"
        Me.GridColumn6.FieldName = "Ten_lop"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Nghề"
        Me.GridColumn7.FieldName = "Chuyen_nganh"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Phòng thi"
        Me.GridColumn8.FieldName = "Ten_phong"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ghi chú"
        Me.GridColumn9.FieldName = "Ghi_chu"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DropDownButton1.DropDownControl = Me.PopupMenu1
        Me.DropDownButton1.Image = CType(resources.GetObject("DropDownButton1.Image"), System.Drawing.Image)
        Me.DropDownButton1.Location = New System.Drawing.Point(414, 537)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(135, 28)
        Me.DropDownButton1.TabIndex = 134
        Me.DropDownButton1.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Phiếu tổng hợp điêm thi tốt nghiệp ( mẫu 7c )"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Phiếu chấm điểm thi tốt nghiệp ( mẫu 7b )"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MaxItemId = 4
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1100, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1100, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1100, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Phiếu chấm điểm thi tốt nghiệp ( mẫu 7a )"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Phiếu chấm điểm thi tốt nghiệp ( mẫu 7d )"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'frmESS_ToChucThiDongTui
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1100, 566)
        Me.Controls.Add(Me.DropDownButton1)
        Me.Controls.Add(Me.grvViewDanhSachThiChon)
        Me.Controls.Add(Me.grvDanhSachThi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnPrint3)
        Me.Controls.Add(Me.btnPrint2)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkAll2)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtTien_to)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSophach_tu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTui_thi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_ToChucThiDongTui"
        Me.Text = "DONG TUI THI THU CONG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvViewDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trvPhongThi As ESS_Mark.TreeViewPhongThi
    Friend WithEvents txtSophach_tu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTui_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents chkAll2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnPrint3 As System.Windows.Forms.Button
    Friend WithEvents btnPrint2 As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTien_to As System.Windows.Forms.TextBox
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSBD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChuyen_nganh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhong_thi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grvViewDanhSachThiChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachThiChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
End Class
