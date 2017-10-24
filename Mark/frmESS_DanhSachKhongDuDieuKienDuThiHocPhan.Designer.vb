<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachKhongDuDieuKienDuThiHocPhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachKhongDuDieuKienDuThiHocPhan))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbLan_hoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TrvLop_ChuanHoa1 = New ESS_Mark.TrvLop_ChuanHoa
        Me.dtExcel = New System.Windows.Forms.DataGridView
        Me.colHocKy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNamHoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChuyenNganh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKhoaHoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTenLop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTenMon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMaSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoTen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTongTiet = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSoTietNghi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPhanTram = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDanhSachHocBuToanTruong = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(899, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(1005, 10)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 27)
        Me.cmbNam_hoc.TabIndex = 133
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(521, 10)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 27)
        Me.cmbHoc_ky.TabIndex = 131
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(455, 11)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 130
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(347, 40)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(767, 27)
        Me.cmbID_mon.TabIndex = 137
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(269, 41)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 136
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_hoc
        '
        Me.cmbLan_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_hoc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbLan_hoc.Location = New System.Drawing.Point(347, 10)
        Me.cmbLan_hoc.Name = "cmbLan_hoc"
        Me.cmbLan_hoc.Size = New System.Drawing.Size(64, 27)
        Me.cmbLan_hoc.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(271, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Lần học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(1040, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(83, 31)
        Me.cmdClose.TabIndex = 158
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(748, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(83, 31)
        Me.cmdExport.TabIndex = 159
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(251, 533)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 31)
        Me.cmdPrint.TabIndex = 160
        Me.cmdPrint.Text = "In danh sách"
        Me.cmdPrint.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(649, 533)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 31)
        Me.cmdSave.TabIndex = 160
        Me.cmdSave.Text = "Cập nhật"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(262, 74)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(861, 455)
        Me.grcDanhSach.TabIndex = 161
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colLy_do})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach.OptionsView.ShowViewCaption = True
        Me.grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 37
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 100
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 150
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
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 120
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 5
        Me.colLy_do.Width = 250
        '
        'TrvLop_ChuanHoa1
        '
        Me.TrvLop_ChuanHoa1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa1.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa1.dtLop = Nothing
        Me.TrvLop_ChuanHoa1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa1.Location = New System.Drawing.Point(-2, -1)
        Me.TrvLop_ChuanHoa1.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa1.Name = "TrvLop_ChuanHoa1"
        Me.TrvLop_ChuanHoa1.Size = New System.Drawing.Size(264, 568)
        Me.TrvLop_ChuanHoa1.TabIndex = 162
        '
        'dtExcel
        '
        Me.dtExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExcel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHocKy, Me.colNamHoc, Me.colHe, Me.colChuyenNganh, Me.colKhoaHoc, Me.colTenLop, Me.colTenMon, Me.colMaSV, Me.colHoTen, Me.colTongTiet, Me.colSoTietNghi, Me.colPhanTram})
        Me.dtExcel.Location = New System.Drawing.Point(286, 535)
        Me.dtExcel.Name = "dtExcel"
        Me.dtExcel.Size = New System.Drawing.Size(36, 29)
        Me.dtExcel.TabIndex = 273
        Me.dtExcel.Visible = False
        '
        'colHocKy
        '
        Me.colHocKy.DataPropertyName = "Hoc_ky"
        Me.colHocKy.HeaderText = "Học kỳ"
        Me.colHocKy.Name = "colHocKy"
        '
        'colNamHoc
        '
        Me.colNamHoc.DataPropertyName = "Nam_hoc"
        Me.colNamHoc.HeaderText = "Năm học"
        Me.colNamHoc.Name = "colNamHoc"
        '
        'colHe
        '
        Me.colHe.DataPropertyName = "Ten_he"
        Me.colHe.HeaderText = "Tên hệ"
        Me.colHe.Name = "colHe"
        '
        'colChuyenNganh
        '
        Me.colChuyenNganh.DataPropertyName = "Chuyen_nganh"
        Me.colChuyenNganh.HeaderText = "Chuyên ngành"
        Me.colChuyenNganh.Name = "colChuyenNganh"
        '
        'colKhoaHoc
        '
        Me.colKhoaHoc.DataPropertyName = "Khoa_hoc"
        Me.colKhoaHoc.HeaderText = "Khóa học"
        Me.colKhoaHoc.Name = "colKhoaHoc"
        '
        'colTenLop
        '
        Me.colTenLop.DataPropertyName = "Ten_lop"
        Me.colTenLop.HeaderText = "Tên lớp"
        Me.colTenLop.Name = "colTenLop"
        '
        'colTenMon
        '
        Me.colTenMon.DataPropertyName = "Ten_mon"
        Me.colTenMon.HeaderText = "Tên môn"
        Me.colTenMon.Name = "colTenMon"
        '
        'colMaSV
        '
        Me.colMaSV.DataPropertyName = "Ma_sv"
        Me.colMaSV.HeaderText = "Mã sinh viên"
        Me.colMaSV.Name = "colMaSV"
        '
        'colHoTen
        '
        Me.colHoTen.DataPropertyName = "Ho_ten"
        Me.colHoTen.HeaderText = "Họ tên"
        Me.colHoTen.Name = "colHoTen"
        '
        'colTongTiet
        '
        Me.colTongTiet.DataPropertyName = "Tong_tiet"
        Me.colTongTiet.HeaderText = "Tổng tiết"
        Me.colTongTiet.Name = "colTongTiet"
        '
        'colSoTietNghi
        '
        Me.colSoTietNghi.DataPropertyName = "So_tiet_nghi"
        Me.colSoTietNghi.HeaderText = "Số tiết nghỉ"
        Me.colSoTietNghi.Name = "colSoTietNghi"
        '
        'colPhanTram
        '
        Me.colPhanTram.DataPropertyName = "Phan_tram"
        Me.colPhanTram.HeaderText = "Phần trăm"
        Me.colPhanTram.Name = "colPhanTram"
        '
        'btnDanhSachHocBuToanTruong
        '
        Me.btnDanhSachHocBuToanTruong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDanhSachHocBuToanTruong.ImageIndex = 6
        Me.btnDanhSachHocBuToanTruong.ImageList = Me.ImgMain
        Me.btnDanhSachHocBuToanTruong.Location = New System.Drawing.Point(837, 533)
        Me.btnDanhSachHocBuToanTruong.Name = "btnDanhSachHocBuToanTruong"
        Me.btnDanhSachHocBuToanTruong.Size = New System.Drawing.Size(197, 31)
        Me.btnDanhSachHocBuToanTruong.TabIndex = 272
        Me.btnDanhSachHocBuToanTruong.Text = "Danh sách học bù toàn trường"
        '
        'frmESS_DanhSachKhongDuDieuKienDuThiHocPhan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1126, 568)
        Me.Controls.Add(Me.dtExcel)
        Me.Controls.Add(Me.btnDanhSachHocBuToanTruong)
        Me.Controls.Add(Me.TrvLop_ChuanHoa1)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmbLan_hoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DanhSachKhongDuDieuKienDuThiHocPhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_DanhSachKhongDuDieuKienDuThiHocPhan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbLan_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TrvLop_ChuanHoa1 As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents dtExcel As System.Windows.Forms.DataGridView
    Friend WithEvents colHocKy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamHoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChuyenNganh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKhoaHoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTenLop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTenMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMaSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoTen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTongTiet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoTietNghi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhanTram As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDanhSachHocBuToanTruong As DevExpress.XtraEditors.SimpleButton
End Class
