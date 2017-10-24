<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiemThanhPhanLop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiemThanhPhanLop))
        Me.grdViewDiem = New System.Windows.Forms.DataGridView()
        Me.Trang_thai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox()
        Me.lblLan_cap = New System.Windows.Forms.Label()
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox()
        Me.lblLoai_chungchi = New System.Windows.Forms.Label()
        Me.cmbID_mon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLan_hoc = New System.Windows.Forms.ComboBox()
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox()
        Me.lblCot_diem = New System.Windows.Forms.Label()
        Me.cmbChonFile = New System.Windows.Forms.ComboBox()
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox()
        Me.lblBang_tinh = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblThanh_phan = New System.Windows.Forms.Label()
        Me.cmdDongBo = New System.Windows.Forms.Button()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa()
        Me.btHocBu = New DevExpress.XtraEditors.SimpleButton()
        Me.btKiemTraBu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTP_Diem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUnLock = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnBangDiemTP = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBaocao_ket_qua_thi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDanh_sach_du_thi = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPhieuKiemTra = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHocBu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTinChi = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnInTH = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnTH_TheoNguoiThu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDacBiet = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGianThu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThuong = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdAdd_CT = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdRemove_HP = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdAdd_HP = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrint_TheoKhoiKT = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrint_TheoKy = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrint = New DevExpress.XtraEditors.DropDownButton()
        Me.cb_Diem_la0 = New System.Windows.Forms.CheckBox()
        Me.optAll_Lop = New System.Windows.Forms.CheckBox()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdViewDiem
        '
        Me.grdViewDiem.AllowUserToAddRows = False
        Me.grdViewDiem.AllowUserToDeleteRows = False
        Me.grdViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDiem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Trang_thai, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 167)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(892, 361)
        Me.grdViewDiem.TabIndex = 83
        '
        'Trang_thai
        '
        Me.Trang_thai.HeaderText = "Trạng thái"
        Me.Trang_thai.Name = "Trang_thai"
        Me.Trang_thai.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ma_sv"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(415, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(499, 79)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 27)
        Me.cmbNam_hoc.TabIndex = 82
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(282, 79)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 79
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(348, 79)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 27)
        Me.cmbHoc_ky.TabIndex = 80
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(270, 109)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 77
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(348, 109)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(800, 27)
        Me.cmbID_mon.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(614, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Lần học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_hoc
        '
        Me.cmbLan_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_hoc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbLan_hoc.Location = New System.Drawing.Point(686, 79)
        Me.cmbLan_hoc.Name = "cmbLan_hoc"
        Me.cmbLan_hoc.Size = New System.Drawing.Size(64, 27)
        Me.cmbLan_hoc.TabIndex = 85
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(469, 42)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(114, 27)
        Me.cmbThanh_phan.TabIndex = 163
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(589, 47)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(174, 17)
        Me.lblCot_diem.TabIndex = 166
        Me.lblCot_diem.Text = "Cột dữ liệu điểm file Excel:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbChonFile
        '
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(365, 18)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 27)
        Me.cmbChonFile.TabIndex = 171
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(760, 42)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(114, 27)
        Me.cmbCot_diem.TabIndex = 165
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(275, 19)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(86, 24)
        Me.lblBang_tinh.TabIndex = 172
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdOpen)
        Me.GroupBox1.Controls.Add(Me.cmbMa_sv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbThanh_phan)
        Me.GroupBox1.Controls.Add(Me.lblThanh_phan)
        Me.GroupBox1.Controls.Add(Me.cmdDongBo)
        Me.GroupBox1.Controls.Add(Me.cmbCot_diem)
        Me.GroupBox1.Controls.Add(Me.lblCot_diem)
        Me.GroupBox1.Location = New System.Drawing.Point(266, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(882, 73)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hỗ trợ nhập điểm từ file Excel"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.HosoSV
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(13, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 29)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "Hướng dẫn sử dụng"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.ForeColor = System.Drawing.Color.Brown
        Me.cmdOpen.Image = Global.ESS_Mark.My.Resources.Resources.Folder
        Me.cmdOpen.Location = New System.Drawing.Point(209, 18)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(34, 25)
        Me.cmdOpen.TabIndex = 173
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(469, 11)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 27)
        Me.cmbMa_sv.TabIndex = 168
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(420, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Mã sv:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(350, 43)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 164
        Me.lblThanh_phan.Text = "Thành phần môn:"
        Me.lblThanh_phan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDongBo
        '
        Me.cmdDongBo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDongBo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDongBo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDongBo.Image = Global.ESS_Mark.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdDongBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDongBo.Location = New System.Drawing.Point(677, 12)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(197, 25)
        Me.cmdDongBo.TabIndex = 167
        Me.cmdDongBo.Text = "Đồng bộ dữ liệu từ Excel"
        Me.cmdDongBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(2, 1)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 529)
        Me.TrvLop_ChuanHoa.TabIndex = 175
        '
        'btHocBu
        '
        Me.btHocBu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btHocBu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHocBu.Appearance.Options.UseFont = True
        Me.btHocBu.Image = Global.ESS_Mark.My.Resources.Resources.LapSBD
        Me.btHocBu.ImageIndex = 22
        Me.btHocBu.Location = New System.Drawing.Point(401, 533)
        Me.btHocBu.Name = "btHocBu"
        Me.btHocBu.Size = New System.Drawing.Size(84, 30)
        Me.btHocBu.TabIndex = 177
        Me.btHocBu.Text = "Học bù"
        '
        'btKiemTraBu
        '
        Me.btKiemTraBu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btKiemTraBu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKiemTraBu.Appearance.Options.UseFont = True
        Me.btKiemTraBu.Image = Global.ESS_Mark.My.Resources.Resources.ChuongTrinhDaoTao
        Me.btKiemTraBu.ImageIndex = 22
        Me.btKiemTraBu.Location = New System.Drawing.Point(301, 534)
        Me.btKiemTraBu.Name = "btKiemTraBu"
        Me.btKiemTraBu.Size = New System.Drawing.Size(97, 30)
        Me.btKiemTraBu.TabIndex = 177
        Me.btKiemTraBu.Text = "Kiểm tra bù"
        '
        'btnTP_Diem
        '
        Me.btnTP_Diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTP_Diem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTP_Diem.Appearance.Options.UseFont = True
        Me.btnTP_Diem.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.btnTP_Diem.ImageIndex = 22
        Me.btnTP_Diem.Location = New System.Drawing.Point(489, 534)
        Me.btnTP_Diem.Name = "btnTP_Diem"
        Me.btnTP_Diem.Size = New System.Drawing.Size(138, 30)
        Me.btnTP_Diem.TabIndex = 177
        Me.btnTP_Diem.Text = "Thay đổi TP điểm"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave.ImageIndex = 22
        Me.btnSave.Location = New System.Drawing.Point(9, 533)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 30)
        Me.btnSave.TabIndex = 177
        Me.btnSave.Text = "Cập nhật"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(633, 533)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(94, 30)
        Me.btnExcel.TabIndex = 177
        Me.btnExcel.Text = "Xuất Excel"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Appearance.Options.UseFont = True
        Me.btnDel.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnDel.ImageIndex = 22
        Me.btnDel.Location = New System.Drawing.Point(196, 533)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(103, 30)
        Me.btnDel.TabIndex = 177
        Me.btnDel.Text = "Xóa điểm TP"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(945, 534)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 30)
        Me.btnThoat.TabIndex = 177
        Me.btnThoat.Text = "Thoát"
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.Image = Global.ESS_Mark.My.Resources.Resources.Locked
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.Location = New System.Drawing.Point(733, 534)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdLock.TabIndex = 177
        Me.cmdLock.Text = "Khóa điểm"
        '
        'cmdUnLock
        '
        Me.cmdUnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUnLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnLock.Appearance.Options.UseFont = True
        Me.cmdUnLock.Image = Global.ESS_Mark.My.Resources.Resources.MoKhoaDuLieu
        Me.cmdUnLock.ImageIndex = 23
        Me.cmdUnLock.Location = New System.Drawing.Point(839, 534)
        Me.cmdUnLock.Name = "cmdUnLock"
        Me.cmdUnLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdUnLock.TabIndex = 176
        Me.cmdUnLock.Text = "Mở khóa điểm"
        '
        'PopupMenu3
        '
        Me.PopupMenu3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnBangDiemTP), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.btnBaocao_ket_qua_thi, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.btnDanh_sach_du_thi, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cmdPhieuKiemTra, False), New DevExpress.XtraBars.LinkPersistInfo(Me.btnHocBu), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6)})
        Me.PopupMenu3.Manager = Me.BarManager1
        Me.PopupMenu3.Name = "PopupMenu3"
        '
        'btnBangDiemTP
        '
        Me.btnBangDiemTP.Caption = "Bảng điểm thành phần"
        Me.btnBangDiemTP.Id = 0
        Me.btnBangDiemTP.Name = "btnBangDiemTP"
        '
        'btnBaocao_ket_qua_thi
        '
        Me.btnBaocao_ket_qua_thi.Caption = "Báo cáo kết quả điểm thi, KT"
        Me.btnBaocao_ket_qua_thi.Id = 1
        Me.btnBaocao_ket_qua_thi.Name = "btnBaocao_ket_qua_thi"
        '
        'btnDanh_sach_du_thi
        '
        Me.btnDanh_sach_du_thi.Caption = "Danh sách dự thi"
        Me.btnDanh_sach_du_thi.Id = 2
        Me.btnDanh_sach_du_thi.Name = "btnDanh_sach_du_thi"
        '
        'cmdPhieuKiemTra
        '
        Me.cmdPhieuKiemTra.Caption = "Phiếu theo dõi KQ kiểm tra"
        Me.cmdPhieuKiemTra.Id = 3
        Me.cmdPhieuKiemTra.Name = "cmdPhieuKiemTra"
        '
        'btnHocBu
        '
        Me.btnHocBu.Caption = "Danh sách học bù"
        Me.btnHocBu.Id = 4
        Me.btnHocBu.Name = "btnHocBu"
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
        Me.BarManager1.Images = Me.imageCollection1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnBangDiemTP, Me.btnBaocao_ket_qua_thi, Me.btnDanh_sach_du_thi, Me.cmdPhieuKiemTra, Me.btnHocBu, Me.BarButtonItem6})
        Me.BarManager1.LargeImages = Me.imageCollection1
        Me.BarManager1.MaxItemId = 6
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1160, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(1160, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(1160, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Id = -1
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Id = -1
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Id = -1
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Id = -1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = -1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnTinChi
        '
        Me.btnTinChi.Id = -1
        Me.btnTinChi.Name = "btnTinChi"
        '
        'bbtnInTH
        '
        Me.bbtnInTH.Id = -1
        Me.bbtnInTH.Name = "bbtnInTH"
        '
        'bbtnTH_TheoNguoiThu
        '
        Me.bbtnTH_TheoNguoiThu.Id = -1
        Me.bbtnTH_TheoNguoiThu.Name = "bbtnTH_TheoNguoiThu"
        '
        'btnDacBiet
        '
        Me.btnDacBiet.Id = -1
        Me.btnDacBiet.Name = "btnDacBiet"
        '
        'btnGianThu
        '
        Me.btnGianThu.Id = -1
        Me.btnGianThu.Name = "btnGianThu"
        '
        'btnThuong
        '
        Me.btnThuong.Id = -1
        Me.btnThuong.Name = "btnThuong"
        '
        'cmdAdd_CT
        '
        Me.cmdAdd_CT.Id = -1
        Me.cmdAdd_CT.Name = "cmdAdd_CT"
        '
        'cmdRemove_HP
        '
        Me.cmdRemove_HP.Id = -1
        Me.cmdRemove_HP.Name = "cmdRemove_HP"
        '
        'cmdAdd_HP
        '
        Me.cmdAdd_HP.Id = -1
        Me.cmdAdd_HP.Name = "cmdAdd_HP"
        '
        'cmdPrint_TheoKhoiKT
        '
        Me.cmdPrint_TheoKhoiKT.Id = -1
        Me.cmdPrint_TheoKhoiKT.Name = "cmdPrint_TheoKhoiKT"
        '
        'cmdPrint_TheoKy
        '
        Me.cmdPrint_TheoKy.Id = -1
        Me.cmdPrint_TheoKy.Name = "cmdPrint_TheoKy"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.DropDownControl = Me.PopupMenu3
        Me.cmdPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint.Location = New System.Drawing.Point(87, 533)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 28)
        Me.cmdPrint.TabIndex = 224
        Me.cmdPrint.Text = "In báo cáo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cb_Diem_la0
        '
        Me.cb_Diem_la0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Diem_la0.BackColor = System.Drawing.Color.Transparent
        Me.cb_Diem_la0.Location = New System.Drawing.Point(348, 142)
        Me.cb_Diem_la0.Name = "cb_Diem_la0"
        Me.cb_Diem_la0.Size = New System.Drawing.Size(773, 24)
        Me.cb_Diem_la0.TabIndex = 229
        Me.cb_Diem_la0.Text = "Tự cập nhập điểm 0"
        Me.cb_Diem_la0.UseVisualStyleBackColor = False
        '
        'optAll_Lop
        '
        Me.optAll_Lop.AutoSize = True
        Me.optAll_Lop.Location = New System.Drawing.Point(9, 1)
        Me.optAll_Lop.Name = "optAll_Lop"
        Me.optAll_Lop.Size = New System.Drawing.Size(201, 23)
        Me.optAll_Lop.TabIndex = 246
        Me.optAll_Lop.Text = "Hiển thị các lớp trong trường"
        Me.optAll_Lop.UseVisualStyleBackColor = True
        Me.optAll_Lop.Visible = False
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Bảng tổng hợp điểm KTTX, ĐK"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'frmESS_NhapDiemThanhPhanLop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1160, 566)
        Me.Controls.Add(Me.optAll_Lop)
        Me.Controls.Add(Me.cb_Diem_la0)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.btHocBu)
        Me.Controls.Add(Me.btKiemTraBu)
        Me.Controls.Add(Me.btnTP_Diem)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdUnLock)
        Me.Controls.Add(Me.cmbChonFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_hoc)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblBang_tinh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_NhapDiemThanhPhanLop"
        Me.Text = "NHAP DIEM THANH PHAN THEO LOP HANH CHINH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents Trang_thai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents cmdDongBo As System.Windows.Forms.Button
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMa_sv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUnLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTP_Diem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btKiemTraBu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btHocBu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTinChi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnInTH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnTH_TheoNguoiThu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDacBiet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGianThu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThuong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAdd_CT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdRemove_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAdd_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_TheoKhoiKT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_TheoKy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnBangDiemTP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBaocao_ket_qua_thi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cb_Diem_la0 As System.Windows.Forms.CheckBox
    Friend WithEvents optAll_Lop As System.Windows.Forms.CheckBox
    Friend WithEvents btnDanh_sach_du_thi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPhieuKiemTra As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHocBu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
End Class
