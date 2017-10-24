<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TimKiemSinhVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.labSoSv = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.grdDanhSachSinhVien = New System.Windows.Forms.DataGridView
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpNgay_sinh = New System.Windows.Forms.DateTimePicker
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.cmdSearch = New System.Windows.Forms.ToolStripButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSo_BD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarlHoSo = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.cmdChose = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDanhSachSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolBarlHoSo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBarlHoSo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 180
        '
        'labSoSv
        '
        Me.labSoSv.BackColor = System.Drawing.Color.Transparent
        Me.labSoSv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSoSv.ForeColor = System.Drawing.Color.Red
        Me.labSoSv.Location = New System.Drawing.Point(665, 120)
        Me.labSoSv.Name = "labSoSv"
        Me.labSoSv.Size = New System.Drawing.Size(46, 19)
        Me.labSoSv.TabIndex = 188
        Me.labSoSv.Text = "0"
        Me.labSoSv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(565, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Số Sv :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdDanhSachSinhVien
        '
        Me.grdDanhSachSinhVien.AllowUserToAddRows = False
        Me.grdDanhSachSinhVien.AllowUserToDeleteRows = False
        Me.grdDanhSachSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSachSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSachSinhVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSachSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop})
        Me.grdDanhSachSinhVien.Location = New System.Drawing.Point(1, 149)
        Me.grdDanhSachSinhVien.Name = "grdDanhSachSinhVien"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSachSinhVien.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdDanhSachSinhVien.RowHeadersVisible = False
        Me.grdDanhSachSinhVien.Size = New System.Drawing.Size(725, 296)
        Me.grdDanhSachSinhVien.TabIndex = 186
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 150
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(500, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 24)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "Khoá:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_sinh
        '
        Me.dtpNgay_sinh.Checked = False
        Me.dtpNgay_sinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_sinh.Location = New System.Drawing.Point(581, 62)
        Me.dtpNgay_sinh.Name = "dtpNgay_sinh"
        Me.dtpNgay_sinh.ShowCheckBox = True
        Me.dtpNgay_sinh.Size = New System.Drawing.Size(130, 20)
        Me.dtpNgay_sinh.TabIndex = 184
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhoa_hoc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(581, 31)
        Me.cmbKhoa_hoc.MaxDropDownItems = 5
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(130, 24)
        Me.cmbKhoa_hoc.TabIndex = 179
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_khoa.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbID_khoa.Location = New System.Drawing.Point(114, 61)
        Me.cmbID_khoa.MaxDropDownItems = 5
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(261, 24)
        Me.cmbID_khoa.TabIndex = 171
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.ESS_Mark.My.Resources.Resources.Search
        Me.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(85, 22)
        Me.cmdSearch.Text = "&Tìm kiếm"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(719, 30)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "TÌM KIẾM SINH VIÊN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSo_BD
        '
        Me.txtSo_BD.Location = New System.Drawing.Point(581, 91)
        Me.txtSo_BD.Name = "txtSo_BD"
        Me.txtSo_BD.Size = New System.Drawing.Size(130, 20)
        Me.txtSo_BD.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(500, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Số BD :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(114, 120)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(261, 20)
        Me.txtMa_sv.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Mã sv:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Location = New System.Drawing.Point(114, 91)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(261, 20)
        Me.txtHo_ten.TabIndex = 173
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Họ và tên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarlHoSo
        '
        Me.ToolBarlHoSo.AddNewItem = Nothing
        Me.ToolBarlHoSo.BackColor = System.Drawing.Color.Transparent
        Me.ToolBarlHoSo.CountItem = Nothing
        Me.ToolBarlHoSo.DeleteItem = Nothing
        Me.ToolBarlHoSo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarlHoSo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolBarlHoSo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSearch, Me.cmdChose, Me.cmdClose})
        Me.ToolBarlHoSo.Location = New System.Drawing.Point(0, 449)
        Me.ToolBarlHoSo.MoveFirstItem = Nothing
        Me.ToolBarlHoSo.MoveLastItem = Nothing
        Me.ToolBarlHoSo.MoveNextItem = Nothing
        Me.ToolBarlHoSo.MovePreviousItem = Nothing
        Me.ToolBarlHoSo.Name = "ToolBarlHoSo"
        Me.ToolBarlHoSo.PositionItem = Nothing
        Me.ToolBarlHoSo.Size = New System.Drawing.Size(727, 25)
        Me.ToolBarlHoSo.TabIndex = 170
        Me.ToolBarlHoSo.Text = "BindingNavigator1"
        '
        'cmdChose
        '
        Me.cmdChose.Image = Global.ESS_Mark.My.Resources.Resources.DangNhap
        Me.cmdChose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChose.Name = "cmdChose"
        Me.cmdChose.Size = New System.Drawing.Size(62, 22)
        Me.cmdChose.Text = "&Chọn"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 24)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Khoa:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbID_he.Location = New System.Drawing.Point(114, 31)
        Me.cmbID_he.MaxDropDownItems = 5
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(261, 24)
        Me.cmbID_he.TabIndex = 180
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Hệ đào tạo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "Ngày sinh :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_TimKiemSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 474)
        Me.Controls.Add(Me.labSoSv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grdDanhSachSinhVien)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpNgay_sinh)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSo_BD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHo_ten)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBarlHoSo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmESS_TimKiemSinhVien"
        Me.Text = "frmESS_TimKiemSinhVien"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDanhSachSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolBarlHoSo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBarlHoSo.ResumeLayout(False)
        Me.ToolBarlHoSo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents labSoSv As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdDanhSachSinhVien As System.Windows.Forms.DataGridView
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_sinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSo_BD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBarlHoSo As System.Windows.Forms.BindingNavigator
    Friend WithEvents cmdSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdChose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
