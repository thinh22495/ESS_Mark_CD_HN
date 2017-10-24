<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DongTuiThi
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
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSo_sinhvien_Max = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbTui_thi = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSophach_tu = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.trvPhongThi = New ESS_Mark.TreeViewPhongThi
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.So_bao_danh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_phach = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu_thi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtSo_sv_cat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnPrint3 = New System.Windows.Forms.Button
        Me.btnPrint2 = New System.Windows.Forms.Button
        Me.btnPrint1 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(916, 35)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(47, 18)
        Me.txtSo_sv.TabIndex = 116
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(776, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Tổng số sinh viên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_sinhvien_Max
        '
        Me.txtSo_sinhvien_Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sinhvien_Max.Location = New System.Drawing.Point(608, 31)
        Me.txtSo_sinhvien_Max.MaxLength = 8
        Me.txtSo_sinhvien_Max.Name = "txtSo_sinhvien_Max"
        Me.txtSo_sinhvien_Max.Size = New System.Drawing.Size(42, 26)
        Me.txtSo_sinhvien_Max.TabIndex = 110
        Me.txtSo_sinhvien_Max.Text = "50"
        Me.txtSo_sinhvien_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(482, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 24)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Số SV tối đa/ 1 túi:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTui_thi
        '
        Me.cmbTui_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTui_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTui_thi.Location = New System.Drawing.Point(729, 31)
        Me.cmbTui_thi.Name = "cmbTui_thi"
        Me.cmbTui_thi.Size = New System.Drawing.Size(41, 27)
        Me.cmbTui_thi.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(656, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Túi thí số:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSophach_tu
        '
        Me.txtSophach_tu.Location = New System.Drawing.Point(91, 31)
        Me.txtSophach_tu.MaxLength = 8
        Me.txtSophach_tu.Name = "txtSophach_tu"
        Me.txtSophach_tu.Size = New System.Drawing.Size(42, 26)
        Me.txtSophach_tu.TabIndex = 118
        Me.txtSophach_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Số phách từ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 54)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 482)
        Me.trvPhongThi.TabIndex = 106
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.So_bao_danh, Me.So_phach, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.Ten_phong, Me.Ghi_chu_thi})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(266, 62)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        Me.grdViewDanhSach.RowHeadersVisible = False
        Me.grdViewDanhSach.Size = New System.Drawing.Size(697, 474)
        Me.grdViewDanhSach.TabIndex = 119
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon1.Width = 67
        '
        'So_bao_danh
        '
        Me.So_bao_danh.DataPropertyName = "So_bao_danh"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_bao_danh.DefaultCellStyle = DataGridViewCellStyle1
        Me.So_bao_danh.HeaderText = "Số BD"
        Me.So_bao_danh.Name = "So_bao_danh"
        Me.So_bao_danh.ReadOnly = True
        Me.So_bao_danh.Width = 76
        '
        'So_phach
        '
        Me.So_phach.DataPropertyName = "So_phach"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_phach.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_phach.HeaderText = "Số phách"
        Me.So_phach.Name = "So_phach"
        Me.So_phach.Width = 91
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ma_sv.HeaderText = "Mã sinh viên"
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 110
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ho_ten.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 93
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 94
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ten_lop.HeaderText = "Lớp"
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 59
        '
        'Ten_phong
        '
        Me.Ten_phong.DataPropertyName = "Ten_phong"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_phong.DefaultCellStyle = DataGridViewCellStyle7
        Me.Ten_phong.HeaderText = "Phòng thi"
        Me.Ten_phong.Name = "Ten_phong"
        Me.Ten_phong.ReadOnly = True
        Me.Ten_phong.Width = 90
        '
        'Ghi_chu_thi
        '
        Me.Ghi_chu_thi.DataPropertyName = "Ghi_chu_thi"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ghi_chu_thi.DefaultCellStyle = DataGridViewCellStyle8
        Me.Ghi_chu_thi.HeaderText = "Ghi chú"
        Me.Ghi_chu_thi.Name = "Ghi_chu_thi"
        Me.Ghi_chu_thi.Width = 80
        '
        'txtSo_sv_cat
        '
        Me.txtSo_sv_cat.Location = New System.Drawing.Point(260, 31)
        Me.txtSo_sv_cat.MaxLength = 8
        Me.txtSo_sv_cat.Name = "txtSo_sv_cat"
        Me.txtSo_sv_cat.Size = New System.Drawing.Size(42, 26)
        Me.txtSo_sv_cat.TabIndex = 121
        Me.txtSo_sv_cat.Text = "10"
        Me.txtSo_sv_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(135, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Cắt số SV/Phòng:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(713, 537)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 29)
        Me.btnThoat.TabIndex = 126
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnPrint3
        '
        Me.btnPrint3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint3.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint3.Location = New System.Drawing.Point(485, 537)
        Me.btnPrint3.Name = "btnPrint3"
        Me.btnPrint3.Size = New System.Drawing.Size(203, 29)
        Me.btnPrint3.TabIndex = 125
        Me.btnPrint3.Text = "Bản Phách - Điểm số và chữ"
        Me.btnPrint3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint3.UseVisualStyleBackColor = True
        '
        'btnPrint2
        '
        Me.btnPrint2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint2.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint2.Location = New System.Drawing.Point(311, 537)
        Me.btnPrint2.Name = "btnPrint2"
        Me.btnPrint2.Size = New System.Drawing.Size(168, 29)
        Me.btnPrint2.TabIndex = 124
        Me.btnPrint2.Text = "Bản hướng dẫn dồn túi"
        Me.btnPrint2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint2.UseVisualStyleBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint1.Location = New System.Drawing.Point(107, 537)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(198, 29)
        Me.btnPrint1.TabIndex = 123
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
        Me.btnSave.Size = New System.Drawing.Size(103, 29)
        Me.btnSave.TabIndex = 122
        Me.btnSave.Text = "Đóng túi thi"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(585, 22)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "ĐÓNG TÚI THI TỰ ĐỘNG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmESS_DongTuiThi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(963, 566)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnPrint3)
        Me.Controls.Add(Me.btnPrint2)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSo_sv_cat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.txtSophach_tu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.txtSo_sinhvien_Max)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTui_thi)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DongTuiThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DONG TUI THI TU DONG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trvPhongThi As ESS_Mark.TreeViewPhongThi
    Friend WithEvents txtSo_sinhvien_Max As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTui_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSophach_tu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents So_bao_danh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_phach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu_thi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSo_sv_cat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnPrint3 As System.Windows.Forms.Button
    Friend WithEvents btnPrint2 As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
