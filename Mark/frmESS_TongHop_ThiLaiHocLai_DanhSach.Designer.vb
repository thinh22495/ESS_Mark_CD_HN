<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHop_ThiLaiHocLai_DanhSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblNoi_sinh = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmdInBangDiemRL = New System.Windows.Forms.ToolStripButton
        Me.cmdExportExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.grdViewDanhsachChitiet = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewDanhSachMon = New System.Windows.Forms.DataGridView
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.optHoc_Lai = New System.Windows.Forms.RadioButton
        Me.optThi_lai = New System.Windows.Forms.RadioButton
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoi_sinh
        '
        Me.lblNoi_sinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoi_sinh.BackColor = System.Drawing.Color.Transparent
        Me.lblNoi_sinh.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNoi_sinh.ForeColor = System.Drawing.Color.Black
        Me.lblNoi_sinh.Location = New System.Drawing.Point(335, 30)
        Me.lblNoi_sinh.Name = "lblNoi_sinh"
        Me.lblNoi_sinh.Size = New System.Drawing.Size(81, 23)
        Me.lblNoi_sinh.TabIndex = 11
        Me.lblNoi_sinh.Text = "Hệ đào tạo:"
        Me.lblNoi_sinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbID_he
        '
        Me.cmbID_he.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_he.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbID_he.ForeColor = System.Drawing.Color.Navy
        Me.cmbID_he.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbID_he.Location = New System.Drawing.Point(415, 29)
        Me.cmbID_he.MaxDropDownItems = 9
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(221, 24)
        Me.cmbID_he.TabIndex = 10
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(183, 29)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(104, 24)
        Me.cmbNam_hoc.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(108, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Năm học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(59, 29)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(43, 24)
        Me.cmbHoc_ky.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(-9, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Học kỳ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTongHop, Me.cmdInBangDiemRL, Me.cmdExportExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(394, 25)
        Me.ToolStrip.TabIndex = 91
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Image = Global.ESS_Mark.My.Resources.Resources.ThongKe
        Me.cmdTongHop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(207, 22)
        Me.cmdTongHop.Text = "Lấy danh sách học lại, thi lại"
        '
        'cmdInBangDiemRL
        '
        Me.cmdInBangDiemRL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInBangDiemRL.Name = "cmdInBangDiemRL"
        Me.cmdInBangDiemRL.Size = New System.Drawing.Size(156, 22)
        Me.cmdInBangDiemRL.Text = "In bảng điểm rèn luyện"
        Me.cmdInBangDiemRL.Visible = False
        '
        'cmdExportExcel
        '
        Me.cmdExportExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.cmdExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExportExcel.Name = "cmdExportExcel"
        Me.cmdExportExcel.Size = New System.Drawing.Size(110, 22)
        Me.cmdExportExcel.Text = "Xuất ra Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(642, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Khoá học:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKhoa_hoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbKhoa_hoc.ForeColor = System.Drawing.Color.Navy
        Me.cmbKhoa_hoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(711, 29)
        Me.cmbKhoa_hoc.MaxDropDownItems = 9
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(69, 24)
        Me.cmbKhoa_hoc.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(-1, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Chuyên ngành:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbID_chuyen_nganh.ForeColor = System.Drawing.Color.Navy
        Me.cmbID_chuyen_nganh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(100, 62)
        Me.cmbID_chuyen_nganh.MaxDropDownItems = 9
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(306, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 94
        '
        'grdViewDanhsachChitiet
        '
        Me.grdViewDanhsachChitiet.AllowUserToAddRows = False
        Me.grdViewDanhsachChitiet.AllowUserToDeleteRows = False
        Me.grdViewDanhsachChitiet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhsachChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhsachChitiet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhsachChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhsachChitiet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.grdViewDanhsachChitiet.Location = New System.Drawing.Point(12, 340)
        Me.grdViewDanhsachChitiet.Name = "grdViewDanhsachChitiet"
        Me.grdViewDanhsachChitiet.RowHeadersVisible = False
        Me.grdViewDanhsachChitiet.Size = New System.Drawing.Size(768, 225)
        Me.grdViewDanhsachChitiet.TabIndex = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 300
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'grdViewDanhSachMon
        '
        Me.grdViewDanhSachMon.AllowUserToAddRows = False
        Me.grdViewDanhSachMon.AllowUserToDeleteRows = False
        Me.grdViewDanhSachMon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSachMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhSachMon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSachMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ky_hieu, Me.Ten_mon, Me.So_hoc_trinh, Me.So_sv})
        Me.grdViewDanhSachMon.Location = New System.Drawing.Point(12, 91)
        Me.grdViewDanhSachMon.Name = "grdViewDanhSachMon"
        Me.grdViewDanhSachMon.RowHeadersVisible = False
        Me.grdViewDanhSachMon.Size = New System.Drawing.Size(768, 243)
        Me.grdViewDanhSachMon.TabIndex = 119
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.Ky_hieu.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ky_hieu.Frozen = True
        Me.Ky_hieu.HeaderText = "Mã môn học"
        Me.Ky_hieu.MinimumWidth = 130
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 130
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_mon.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ten_mon.HeaderText = "Tên môn học"
        Me.Ten_mon.MinimumWidth = 300
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 300
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.DataPropertyName = "So_hoc_trinh"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_hoc_trinh.DefaultCellStyle = DataGridViewCellStyle7
        Me.So_hoc_trinh.HeaderText = "Số học trình"
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.ReadOnly = True
        Me.So_hoc_trinh.Width = 103
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_sv.DefaultCellStyle = DataGridViewCellStyle8
        Me.So_sv.HeaderText = "Số SV"
        Me.So_sv.MinimumWidth = 100
        Me.So_sv.Name = "So_sv"
        Me.So_sv.ReadOnly = True
        '
        'cmbID_lop
        '
        Me.cmbID_lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_lop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbID_lop.ForeColor = System.Drawing.Color.Navy
        Me.cmbID_lop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbID_lop.Location = New System.Drawing.Point(486, 62)
        Me.cmbID_lop.MaxDropDownItems = 9
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(294, 24)
        Me.cmbID_lop.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(444, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Lớp:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optHoc_Lai
        '
        Me.optHoc_Lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optHoc_Lai.AutoSize = True
        Me.optHoc_Lai.BackColor = System.Drawing.Color.Transparent
        Me.optHoc_Lai.Checked = True
        Me.optHoc_Lai.Location = New System.Drawing.Point(570, 3)
        Me.optHoc_Lai.Name = "optHoc_Lai"
        Me.optHoc_Lai.Size = New System.Drawing.Size(66, 20)
        Me.optHoc_Lai.TabIndex = 123
        Me.optHoc_Lai.TabStop = True
        Me.optHoc_Lai.Text = "Học lại"
        Me.optHoc_Lai.UseVisualStyleBackColor = False
        '
        'optThi_lai
        '
        Me.optThi_lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optThi_lai.AutoSize = True
        Me.optThi_lai.BackColor = System.Drawing.Color.Transparent
        Me.optThi_lai.Location = New System.Drawing.Point(642, 3)
        Me.optThi_lai.Name = "optThi_lai"
        Me.optThi_lai.Size = New System.Drawing.Size(60, 20)
        Me.optThi_lai.TabIndex = 124
        Me.optThi_lai.Text = "Thi lại"
        Me.optThi_lai.UseVisualStyleBackColor = False
        '
        'frmESS_TongHop_ThiLaiHocLai_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.optThi_lai)
        Me.Controls.Add(Me.optHoc_Lai)
        Me.Controls.Add(Me.cmbID_lop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grdViewDanhsachChitiet)
        Me.Controls.Add(Me.grdViewDanhSachMon)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNoi_sinh)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmESS_TongHop_ThiLaiHocLai_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_TongHop_ThiLaiHocLai_DanhSach"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoi_sinh As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdInBangDiemRL As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExportExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents grdViewDanhsachChitiet As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewDanhSachMon As System.Windows.Forms.DataGridView
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optHoc_Lai As System.Windows.Forms.RadioButton
    Friend WithEvents optThi_lai As System.Windows.Forms.RadioButton
End Class
