<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThiAdd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnChon_phongthi = New DevExpress.XtraEditors.SimpleButton
        Me.txtThoi_gian = New System.Windows.Forms.TextBox
        Me.txtThoi_gian_lam_bai = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbNhom_tiet = New System.Windows.Forms.ComboBox
        Me.cmbCa = New System.Windows.Forms.ComboBox
        Me.txtSo_phong = New System.Windows.Forms.TextBox
        Me.chkDieuKienThi = New System.Windows.Forms.CheckBox
        Me.chkHienThiAll = New System.Windows.Forms.CheckBox
        Me.cmbDot_thi = New System.Windows.Forms.ComboBox
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpNgay_thi = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbOrder = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnPrint1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnToTucThi = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd_sv = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel_sv = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa
        Me.grcViewDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grdViewDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_bao_danh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_phong = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu_thi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_dem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnChon_phongthi)
        Me.GroupBox1.Controls.Add(Me.txtThoi_gian)
        Me.GroupBox1.Controls.Add(Me.txtThoi_gian_lam_bai)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbNhom_tiet)
        Me.GroupBox1.Controls.Add(Me.cmbCa)
        Me.GroupBox1.Controls.Add(Me.txtSo_phong)
        Me.GroupBox1.Controls.Add(Me.chkDieuKienThi)
        Me.GroupBox1.Controls.Add(Me.chkHienThiAll)
        Me.GroupBox1.Controls.Add(Me.cmbDot_thi)
        Me.GroupBox1.Controls.Add(Me.cmbLan_thi)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbID_mon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpNgay_thi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbOrder)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(267, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(538, 230)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin tổ chức thi"
        '
        'btnChon_phongthi
        '
        Me.btnChon_phongthi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChon_phongthi.Appearance.Options.UseFont = True
        Me.btnChon_phongthi.Image = Global.ESS_Mark.My.Resources.Resources.LapSBD
        Me.btnChon_phongthi.ImageIndex = 22
        Me.btnChon_phongthi.Location = New System.Drawing.Point(76, 163)
        Me.btnChon_phongthi.Name = "btnChon_phongthi"
        Me.btnChon_phongthi.Size = New System.Drawing.Size(97, 30)
        Me.btnChon_phongthi.TabIndex = 182
        Me.btnChon_phongthi.Text = "Chọn phòng"
        '
        'txtThoi_gian
        '
        Me.txtThoi_gian.Location = New System.Drawing.Point(76, 134)
        Me.txtThoi_gian.Margin = New System.Windows.Forms.Padding(4)
        Me.txtThoi_gian.Name = "txtThoi_gian"
        Me.txtThoi_gian.Size = New System.Drawing.Size(240, 26)
        Me.txtThoi_gian.TabIndex = 63
        Me.txtThoi_gian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThoi_gian_lam_bai
        '
        Me.txtThoi_gian_lam_bai.Location = New System.Drawing.Point(439, 134)
        Me.txtThoi_gian_lam_bai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtThoi_gian_lam_bai.MaxLength = 3
        Me.txtThoi_gian_lam_bai.Name = "txtThoi_gian_lam_bai"
        Me.txtThoi_gian_lam_bai.Size = New System.Drawing.Size(31, 26)
        Me.txtThoi_gian_lam_bai.TabIndex = 63
        Me.txtThoi_gian_lam_bai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(324, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 28)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Thời gian làm bài:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(2, 133)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 28)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Thời gian:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNhom_tiet
        '
        Me.cmbNhom_tiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom_tiet.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNhom_tiet.Location = New System.Drawing.Point(457, 66)
        Me.cmbNhom_tiet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNhom_tiet.Name = "cmbNhom_tiet"
        Me.cmbNhom_tiet.Size = New System.Drawing.Size(54, 27)
        Me.cmbNhom_tiet.TabIndex = 61
        '
        'cmbCa
        '
        Me.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCa.Items.AddRange(New Object() {"Sáng", "Chiều", "Tối"})
        Me.cmbCa.Location = New System.Drawing.Point(252, 66)
        Me.cmbCa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCa.Name = "cmbCa"
        Me.cmbCa.Size = New System.Drawing.Size(121, 27)
        Me.cmbCa.TabIndex = 59
        '
        'txtSo_phong
        '
        Me.txtSo_phong.BackColor = System.Drawing.Color.White
        Me.txtSo_phong.ForeColor = System.Drawing.Color.White
        Me.txtSo_phong.Location = New System.Drawing.Point(27, 164)
        Me.txtSo_phong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSo_phong.Name = "txtSo_phong"
        Me.txtSo_phong.Size = New System.Drawing.Size(40, 26)
        Me.txtSo_phong.TabIndex = 13
        Me.txtSo_phong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSo_phong.Visible = False
        '
        'chkDieuKienThi
        '
        Me.chkDieuKienThi.AutoSize = True
        Me.chkDieuKienThi.BackColor = System.Drawing.Color.Transparent
        Me.chkDieuKienThi.Location = New System.Drawing.Point(76, 200)
        Me.chkDieuKienThi.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDieuKienThi.Name = "chkDieuKienThi"
        Me.chkDieuKienThi.Size = New System.Drawing.Size(443, 23)
        Me.chkDieuKienThi.TabIndex = 57
        Me.chkDieuKienThi.Text = "Loại những sinh viên không đủ điều kiện dự thi theo danh sách đã lập"
        Me.chkDieuKienThi.UseVisualStyleBackColor = False
        '
        'chkHienThiAll
        '
        Me.chkHienThiAll.AutoSize = True
        Me.chkHienThiAll.Enabled = False
        Me.chkHienThiAll.Location = New System.Drawing.Point(76, 137)
        Me.chkHienThiAll.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHienThiAll.Name = "chkHienThiAll"
        Me.chkHienThiAll.Size = New System.Drawing.Size(290, 23)
        Me.chkHienThiAll.TabIndex = 14
        Me.chkHienThiAll.Text = "Hiển thị tất cả các học phần của các học kỳ"
        Me.chkHienThiAll.UseVisualStyleBackColor = True
        Me.chkHienThiAll.Visible = False
        '
        'cmbDot_thi
        '
        Me.cmbDot_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbDot_thi.Location = New System.Drawing.Point(353, 26)
        Me.cmbDot_thi.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDot_thi.Name = "cmbDot_thi"
        Me.cmbDot_thi.Size = New System.Drawing.Size(41, 27)
        Me.cmbDot_thi.TabIndex = 11
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(452, 26)
        Me.cmbLan_thi.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(38, 27)
        Me.cmbLan_thi.TabIndex = 1
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(76, 26)
        Me.cmbHoc_ky.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(40, 27)
        Me.cmbHoc_ky.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(474, 134)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 28)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "(phút)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Học kỳ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(372, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Lần thi:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(76, 101)
        Me.cmbID_mon.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(426, 27)
        Me.cmbID_mon.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-26, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Học phần:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thi
        '
        Me.dtpNgay_thi.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thi.Location = New System.Drawing.Point(76, 66)
        Me.dtpNgay_thi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgay_thi.Name = "dtpNgay_thi"
        Me.dtpNgay_thi.Size = New System.Drawing.Size(106, 26)
        Me.dtpNgay_thi.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(-5, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ngày thi:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(191, 26)
        Me.cmbNam_hoc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(104, 27)
        Me.cmbNam_hoc.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(100, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Năm học:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.Items.AddRange(New Object() {"Họ và tên", "Mã sinh viên", "Lớp - mã sinh viên", "Không sắp xếp"})
        Me.cmbOrder.Location = New System.Drawing.Point(367, 166)
        Me.cmbOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(135, 27)
        Me.cmbOrder.TabIndex = 5
        Me.cmbOrder.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(273, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sắp xếp theo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(284, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 28)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Đợt thi:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Buổi thi:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(379, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 28)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Ca thi:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(599, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Số phòng:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(562, 267)
        Me.txtSo_sv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(71, 21)
        Me.txtSo_sv.TabIndex = 55
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(411, 268)
        Me.lblTong_so.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(138, 16)
        Me.lblTong_so.TabIndex = 54
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(285, 265)
        Me.chkAll.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(98, 23)
        Me.chkAll.TabIndex = 56
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(330, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(361, 22)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "TỔ CHỨC THI"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Appearance.Options.UseFont = True
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.DoiChieuDuLieu
        Me.btnPrint1.ImageIndex = 22
        Me.btnPrint1.Location = New System.Drawing.Point(6, 555)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(96, 30)
        Me.btnPrint1.TabIndex = 178
        Me.btnPrint1.Text = "Tổ chức thi"
        '
        'btnToTucThi
        '
        Me.btnToTucThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToTucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToTucThi.Appearance.Options.UseFont = True
        Me.btnToTucThi.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.btnToTucThi.ImageIndex = 22
        Me.btnToTucThi.Location = New System.Drawing.Point(105, 555)
        Me.btnToTucThi.Name = "btnToTucThi"
        Me.btnToTucThi.Size = New System.Drawing.Size(120, 30)
        Me.btnToTucThi.TabIndex = 179
        Me.btnToTucThi.Text = "Sửa thông tin thi"
        '
        'btnAdd_sv
        '
        Me.btnAdd_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_sv.Appearance.Options.UseFont = True
        Me.btnAdd_sv.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd_sv.ImageIndex = 22
        Me.btnAdd_sv.Location = New System.Drawing.Point(228, 555)
        Me.btnAdd_sv.Name = "btnAdd_sv"
        Me.btnAdd_sv.Size = New System.Drawing.Size(138, 30)
        Me.btnAdd_sv.TabIndex = 179
        Me.btnAdd_sv.Text = "Bổ sung sinh viên"
        '
        'btnDel_sv
        '
        Me.btnDel_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel_sv.Appearance.Options.UseFont = True
        Me.btnDel_sv.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnDel_sv.ImageIndex = 22
        Me.btnDel_sv.Location = New System.Drawing.Point(369, 555)
        Me.btnDel_sv.Name = "btnDel_sv"
        Me.btnDel_sv.Size = New System.Drawing.Size(103, 30)
        Me.btnDel_sv.TabIndex = 179
        Me.btnDel_sv.Text = "Xóa sinh viên"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Copy
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(474, 555)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(120, 30)
        Me.btnExcel.TabIndex = 180
        Me.btnExcel.Text = "Lập số báo danh"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.SimpleButton1.ImageIndex = 22
        Me.SimpleButton1.Location = New System.Drawing.Point(597, 555)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(78, 30)
        Me.SimpleButton1.TabIndex = 181
        Me.SimpleButton1.Text = "Thoát"
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(-3, -1)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 555)
        Me.TrvLop_ChuanHoa.TabIndex = 138
        '
        'grcViewDanhSachThi
        '
        Me.grcViewDanhSachThi.Location = New System.Drawing.Point(267, 292)
        Me.grcViewDanhSachThi.MainView = Me.grdViewDanhSachThi
        Me.grcViewDanhSachThi.Name = "grcViewDanhSachThi"
        Me.grcViewDanhSachThi.Size = New System.Drawing.Size(538, 256)
        Me.grcViewDanhSachThi.TabIndex = 182
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
        Me.colChon.Width = 44
        '
        'colSo_bao_danh
        '
        Me.colSo_bao_danh.Caption = "SBD"
        Me.colSo_bao_danh.FieldName = "So_bao_danh"
        Me.colSo_bao_danh.Name = "colSo_bao_danh"
        Me.colSo_bao_danh.Visible = True
        Me.colSo_bao_danh.VisibleIndex = 1
        Me.colSo_bao_danh.Width = 34
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 2
        Me.colMa_sv.Width = 59
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Width = 69
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 5
        Me.colNgay_sinh.Width = 54
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 6
        Me.colTen_lop.Width = 54
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
        Me.colGhi_chu_thi.Width = 71
        '
        'colHo_dem
        '
        Me.colHo_dem.Caption = "Họ đệm"
        Me.colHo_dem.FieldName = "Ho_dem"
        Me.colHo_dem.Name = "colHo_dem"
        Me.colHo_dem.Visible = True
        Me.colHo_dem.VisibleIndex = 3
        Me.colHo_dem.Width = 88
        '
        'colTen
        '
        Me.colTen.Caption = "Tên"
        Me.colTen.FieldName = "Ten"
        Me.colTen.Name = "colTen"
        Me.colTen.Visible = True
        Me.colTen.VisibleIndex = 4
        Me.colTen.Width = 59
        '
        'frmESS_ToChucThiAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 588)
        Me.Controls.Add(Me.grcViewDanhSachThi)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnDel_sv)
        Me.Controls.Add(Me.btnAdd_sv)
        Me.Controls.Add(Me.btnToTucThi)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmESS_ToChucThiAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Tổ chức thi mới"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSo_phong As System.Windows.Forms.TextBox
    Friend WithEvents cmbDot_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_thi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents chkHienThiAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkDieuKienThi As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtThoi_gian_lam_bai As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbNhom_tiet As System.Windows.Forms.ComboBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtThoi_gian As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnToTucThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChon_phongthi As DevExpress.XtraEditors.SimpleButton
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
End Class
