<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiemThiLop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiemThiLop))
        Me.cmbID_mon = New System.Windows.Forms.ComboBox()
        Me.lblLoai_chungchi = New System.Windows.Forms.Label()
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox()
        Me.lblLan_cap = New System.Windows.Forms.Label()
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox()
        Me.cb_Diem_la0 = New System.Windows.Forms.CheckBox()
        Me.grdViewDiem = New System.Windows.Forms.DataGridView()
        Me.cmbLan_hoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbChonFile = New System.Windows.Forms.ComboBox()
        Me.lblBang_tinh = New System.Windows.Forms.Label()
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox()
        Me.lblCot_diem = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox()
        Me.lblThanh_phan = New System.Windows.Forms.Label()
        Me.cmdDongBo = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.cbDS_thi_lai = New System.Windows.Forms.CheckBox()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKyHieu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUnLock = New DevExpress.XtraEditors.SimpleButton()
        Me.optAll_Lop = New System.Windows.Forms.CheckBox()
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa()
        Me.btnSave_VH = New DevExpress.XtraEditors.SimpleButton()
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdPrint = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnInBangDiem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDanhSachDuThi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDanhSachNoMon = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.btnTP_Diem = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_ds_day_du = New System.Windows.Forms.CheckBox()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(341, 107)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(877, 27)
        Me.cmbID_mon.TabIndex = 91
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(263, 107)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 90
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(341, 77)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(45, 27)
        Me.cmbHoc_ky.TabIndex = 93
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(275, 77)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 92
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(463, 77)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(107, 27)
        Me.cmbNam_hoc.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(393, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(698, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Location = New System.Drawing.Point(758, 77)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(66, 27)
        Me.cmbLan_thi.TabIndex = 97
        '
        'cb_Diem_la0
        '
        Me.cb_Diem_la0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Diem_la0.BackColor = System.Drawing.Color.Transparent
        Me.cb_Diem_la0.Location = New System.Drawing.Point(349, 135)
        Me.cb_Diem_la0.Name = "cb_Diem_la0"
        Me.cb_Diem_la0.Size = New System.Drawing.Size(303, 24)
        Me.cb_Diem_la0.TabIndex = 98
        Me.cb_Diem_la0.Text = "Tự cập nhập điểm 0"
        Me.cb_Diem_la0.UseVisualStyleBackColor = False
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
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 164)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.ShowCellErrors = False
        Me.grdViewDiem.ShowCellToolTips = False
        Me.grdViewDiem.ShowRowErrors = False
        Me.grdViewDiem.Size = New System.Drawing.Size(954, 364)
        Me.grdViewDiem.TabIndex = 99
        '
        'cmbLan_hoc
        '
        Me.cmbLan_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_hoc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbLan_hoc.Location = New System.Drawing.Point(650, 77)
        Me.cmbLan_hoc.Name = "cmbLan_hoc"
        Me.cmbLan_hoc.Size = New System.Drawing.Size(42, 27)
        Me.cmbLan_hoc.TabIndex = 152
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(574, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Lần học:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbChonFile
        '
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(97, 17)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 27)
        Me.cmbChonFile.TabIndex = 160
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(9, 18)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(83, 24)
        Me.lblBang_tinh.TabIndex = 161
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(474, 11)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 27)
        Me.cmbMa_sv.TabIndex = 168
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(425, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Mã sv:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(756, 44)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(189, 27)
        Me.cmbCot_diem.TabIndex = 165
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(588, 49)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(174, 17)
        Me.lblCot_diem.TabIndex = 166
        Me.lblCot_diem.Text = "Cột dữ liệu điểm file Excel:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbThanh_phan)
        Me.GroupBox1.Controls.Add(Me.lblThanh_phan)
        Me.GroupBox1.Controls.Add(Me.cmbMa_sv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdDongBo)
        Me.GroupBox1.Controls.Add(Me.cmbCot_diem)
        Me.GroupBox1.Controls.Add(Me.lblCot_diem)
        Me.GroupBox1.Controls.Add(Me.cmdOpen)
        Me.GroupBox1.Controls.Add(Me.lblBang_tinh)
        Me.GroupBox1.Controls.Add(Me.cmbChonFile)
        Me.GroupBox1.Location = New System.Drawing.Point(272, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(948, 73)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hỗ trợ nhập điểm từ file Excel"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.HosoSV
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 29)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "Hướng dẫn sử dụng"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(474, 44)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(114, 27)
        Me.cmbThanh_phan.TabIndex = 170
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(355, 45)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 171
        Me.lblThanh_phan.Text = "Cột điểm thi:"
        Me.lblThanh_phan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDongBo
        '
        Me.cmdDongBo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDongBo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDongBo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDongBo.Image = Global.ESS_Mark.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdDongBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDongBo.Location = New System.Drawing.Point(754, 12)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(189, 25)
        Me.cmdDongBo.TabIndex = 167
        Me.cmdDongBo.Text = "Đồng bộ dữ liệu từ Excel"
        Me.cmdDongBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOpen
        '
        Me.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.ForeColor = System.Drawing.Color.Brown
        Me.cmdOpen.Image = Global.ESS_Mark.My.Resources.Resources.Folder
        Me.cmdOpen.Location = New System.Drawing.Point(207, 18)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(34, 25)
        Me.cmdOpen.TabIndex = 162
        '
        'cbDS_thi_lai
        '
        Me.cbDS_thi_lai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDS_thi_lai.BackColor = System.Drawing.Color.Transparent
        Me.cbDS_thi_lai.Location = New System.Drawing.Point(522, 137)
        Me.cbDS_thi_lai.Name = "cbDS_thi_lai"
        Me.cbDS_thi_lai.Size = New System.Drawing.Size(149, 21)
        Me.cbDS_thi_lai.TabIndex = 172
        Me.cbDS_thi_lai.Text = "Danh sách thi lại"
        Me.cbDS_thi_lai.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(1065, 533)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 30)
        Me.btnThoat.TabIndex = 185
        Me.btnThoat.Text = "Thoát"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(538, 533)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(94, 30)
        Me.btnExcel.TabIndex = 184
        Me.btnExcel.Text = "Xuất Excel"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Appearance.Options.UseFont = True
        Me.btnDel.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnDel.ImageIndex = 22
        Me.btnDel.Location = New System.Drawing.Point(93, 533)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(131, 30)
        Me.btnDel.TabIndex = 182
        Me.btnDel.Text = "Xóa điểm theo lớp"
        '
        'btnKyHieu
        '
        Me.btnKyHieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnKyHieu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKyHieu.Appearance.Options.UseFont = True
        Me.btnKyHieu.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.btnKyHieu.ImageIndex = 22
        Me.btnKyHieu.Location = New System.Drawing.Point(776, 533)
        Me.btnKyHieu.Name = "btnKyHieu"
        Me.btnKyHieu.Size = New System.Drawing.Size(147, 30)
        Me.btnKyHieu.TabIndex = 179
        Me.btnKyHieu.Text = "Ký hiệu, ghi chú điểm"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave.ImageIndex = 22
        Me.btnSave.Location = New System.Drawing.Point(6, 533)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 30)
        Me.btnSave.TabIndex = 181
        Me.btnSave.Text = "Cập nhật"
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.Image = Global.ESS_Mark.My.Resources.Resources.Locked
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.Location = New System.Drawing.Point(334, 533)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(95, 30)
        Me.cmdLock.TabIndex = 180
        Me.cmdLock.Text = "Khóa điểm"
        '
        'cmdUnLock
        '
        Me.cmdUnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUnLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnLock.Appearance.Options.UseFont = True
        Me.cmdUnLock.Image = Global.ESS_Mark.My.Resources.Resources.MoKhoaDuLieu
        Me.cmdUnLock.ImageIndex = 23
        Me.cmdUnLock.Location = New System.Drawing.Point(432, 533)
        Me.cmdUnLock.Name = "cmdUnLock"
        Me.cmdUnLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdUnLock.TabIndex = 178
        Me.cmdUnLock.Text = "Mở khóa điểm"
        '
        'optAll_Lop
        '
        Me.optAll_Lop.AutoSize = True
        Me.optAll_Lop.Location = New System.Drawing.Point(13, 6)
        Me.optAll_Lop.Name = "optAll_Lop"
        Me.optAll_Lop.Size = New System.Drawing.Size(201, 23)
        Me.optAll_Lop.TabIndex = 187
        Me.optAll_Lop.Text = "Hiển thị các lớp trong trường"
        Me.optAll_Lop.UseVisualStyleBackColor = True
        Me.optAll_Lop.Visible = False
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(1, 31)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 499)
        Me.TrvLop_ChuanHoa.TabIndex = 171
        '
        'btnSave_VH
        '
        Me.btnSave_VH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave_VH.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave_VH.Appearance.Options.UseFont = True
        Me.btnSave_VH.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave_VH.ImageIndex = 22
        Me.btnSave_VH.Location = New System.Drawing.Point(926, 533)
        Me.btnSave_VH.Name = "btnSave_VH"
        Me.btnSave_VH.Size = New System.Drawing.Size(136, 30)
        Me.btnSave_VH.TabIndex = 188
        Me.btnSave_VH.Text = "Cập nhật HS lớp VH"
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.DropDownControl = Me.PopupMenu3
        Me.cmdPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint.Location = New System.Drawing.Point(227, 533)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 30)
        Me.cmdPrint.TabIndex = 229
        Me.cmdPrint.Text = "In báo cáo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PopupMenu3
        '
        Me.PopupMenu3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnInBangDiem), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDanhSachDuThi), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.btnDanhSachNoMon, False), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.PopupMenu3.Manager = Me.BarManager1
        Me.PopupMenu3.Name = "PopupMenu3"
        '
        'btnInBangDiem
        '
        Me.btnInBangDiem.Caption = "In bảng điểm theo môn"
        Me.btnInBangDiem.Id = 3
        Me.btnInBangDiem.Name = "btnInBangDiem"
        '
        'btnDanhSachDuThi
        '
        Me.btnDanhSachDuThi.Caption = "Danh sách dự thi"
        Me.btnDanhSachDuThi.Id = 4
        Me.btnDanhSachDuThi.Name = "btnDanhSachDuThi"
        '
        'btnDanhSachNoMon
        '
        Me.btnDanhSachNoMon.Caption = "Danh sách nợ môn"
        Me.btnDanhSachNoMon.Id = 5
        Me.btnDanhSachNoMon.Name = "btnDanhSachNoMon"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Điểm tổng kết môn học"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnInBangDiem, Me.btnDanhSachDuThi, Me.btnDanhSachNoMon, Me.BarButtonItem1})
        Me.BarManager1.LargeImages = Me.imageCollection1
        Me.BarManager1.MaxItemId = 7
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1227, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(1227, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(1227, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'btnTP_Diem
        '
        Me.btnTP_Diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTP_Diem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTP_Diem.Appearance.Options.UseFont = True
        Me.btnTP_Diem.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.btnTP_Diem.ImageIndex = 22
        Me.btnTP_Diem.Location = New System.Drawing.Point(635, 533)
        Me.btnTP_Diem.Name = "btnTP_Diem"
        Me.btnTP_Diem.Size = New System.Drawing.Size(138, 30)
        Me.btnTP_Diem.TabIndex = 234
        Me.btnTP_Diem.Text = "Thay đổi TP điểm thi"
        '
        'chk_ds_day_du
        '
        Me.chk_ds_day_du.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_ds_day_du.BackColor = System.Drawing.Color.Transparent
        Me.chk_ds_day_du.Location = New System.Drawing.Point(711, 137)
        Me.chk_ds_day_du.Name = "chk_ds_day_du"
        Me.chk_ds_day_du.Size = New System.Drawing.Size(149, 21)
        Me.chk_ds_day_du.TabIndex = 239
        Me.chk_ds_day_du.Text = "Danh sách đầy đủ"
        Me.chk_ds_day_du.UseVisualStyleBackColor = False
        '
        'frmESS_NhapDiemThiLop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1227, 566)
        Me.Controls.Add(Me.chk_ds_day_du)
        Me.Controls.Add(Me.btnTP_Diem)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.btnSave_VH)
        Me.Controls.Add(Me.optAll_Lop)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnKyHieu)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdUnLock)
        Me.Controls.Add(Me.cbDS_thi_lai)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbLan_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.cb_Diem_la0)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_NhapDiemThiLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Diem_la0 As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents cmbLan_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmbMa_sv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDongBo As System.Windows.Forms.Button
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents cbDS_thi_lai As System.Windows.Forms.CheckBox
    Friend WithEvents btnKyHieu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUnLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents optAll_Lop As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave_VH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnInBangDiem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDanhSachDuThi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDanhSachNoMon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTP_Diem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chk_ds_day_du As System.Windows.Forms.CheckBox
End Class
