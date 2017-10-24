<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_InChungChi
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.Label = New System.Windows.Forms.Label
        Me.txtID_sv = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpNgay_sinh = New System.Windows.Forms.DateTimePicker
        Me.cmbGioi_tinh = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDiem = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSo_hieu = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTu_ngay = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtDen_ngay = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTu_thang = New System.Windows.Forms.TextBox
        Me.cmbTen_cc = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDen_thang = New System.Windows.Forms.TextBox
        Me.cmbTen_tinh = New System.Windows.Forms.ComboBox
        Me.cmbChuyen_nganh = New System.Windows.Forms.ComboBox
        Me.cmbTen_lop = New System.Windows.Forms.ComboBox
        Me.cmbXep_loai = New System.Windows.Forms.ComboBox
        Me.txtSo_vao_so = New System.Windows.Forms.TextBox
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(54, 38)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(51, 19)
        Me.Label.TabIndex = 0
        Me.Label.Text = "ID SV:"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID_sv
        '
        Me.txtID_sv.Location = New System.Drawing.Point(118, 35)
        Me.txtID_sv.Name = "txtID_sv"
        Me.txtID_sv.Size = New System.Drawing.Size(147, 26)
        Me.txtID_sv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã SV:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(118, 67)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(230, 26)
        Me.txtMa_sv.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ tên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Location = New System.Drawing.Point(118, 99)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(230, 26)
        Me.txtHo_ten.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày sinh:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giới tính:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tên tỉnh:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Chuyên ngành:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tên lớp:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_sinh
        '
        Me.dtpNgay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgay_sinh.Location = New System.Drawing.Point(118, 131)
        Me.dtpNgay_sinh.Name = "dtpNgay_sinh"
        Me.dtpNgay_sinh.ShowCheckBox = True
        Me.dtpNgay_sinh.Size = New System.Drawing.Size(147, 26)
        Me.dtpNgay_sinh.TabIndex = 2
        '
        'cmbGioi_tinh
        '
        Me.cmbGioi_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGioi_tinh.FormattingEnabled = True
        Me.cmbGioi_tinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cmbGioi_tinh.Location = New System.Drawing.Point(118, 162)
        Me.cmbGioi_tinh.Name = "cmbGioi_tinh"
        Me.cmbGioi_tinh.Size = New System.Drawing.Size(147, 27)
        Me.cmbGioi_tinh.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Điểm:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiem
        '
        Me.txtDiem.Location = New System.Drawing.Point(436, 37)
        Me.txtDiem.Name = "txtDiem"
        Me.txtDiem.Size = New System.Drawing.Size(99, 26)
        Me.txtDiem.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Xếp loại:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Số hiệu:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_hieu
        '
        Me.txtSo_hieu.Location = New System.Drawing.Point(436, 104)
        Me.txtSo_hieu.Name = "txtSo_hieu"
        Me.txtSo_hieu.Size = New System.Drawing.Size(99, 26)
        Me.txtSo_hieu.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(352, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Số vào sổ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(364, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tên CC:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(363, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Từ ngày:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTu_ngay
        '
        Me.txtTu_ngay.Location = New System.Drawing.Point(436, 200)
        Me.txtTu_ngay.Name = "txtTu_ngay"
        Me.txtTu_ngay.Size = New System.Drawing.Size(99, 26)
        Me.txtTu_ngay.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(356, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 19)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Đến ngày:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDen_ngay
        '
        Me.txtDen_ngay.Location = New System.Drawing.Point(436, 262)
        Me.txtDen_ngay.Name = "txtDen_ngay"
        Me.txtDen_ngay.Size = New System.Drawing.Size(99, 26)
        Me.txtDen_ngay.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(362, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Từ tháng"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTu_thang
        '
        Me.txtTu_thang.Location = New System.Drawing.Point(436, 229)
        Me.txtTu_thang.Name = "txtTu_thang"
        Me.txtTu_thang.Size = New System.Drawing.Size(99, 26)
        Me.txtTu_thang.TabIndex = 1
        '
        'cmbTen_cc
        '
        Me.cmbTen_cc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTen_cc.FormattingEnabled = True
        Me.cmbTen_cc.Items.AddRange(New Object() {"15", "3G - MAG", "3G - SMAW", "CAD/CAM", "CCNA", "H2T - CNTT Căn bản", "Kỹ năng lập trình vi điều khiển PIC", "Kỹ năng thực hành lắp đặt điện", "Kỹ năng thực hành PLC S200", "Lập trình gia công trên máy phay CNC", "Lập trình gia công trên máy tiện CNC", "Thiết kế cơ khí với INVENTOR", "Thiết kế mạch điện tử", "Thiết kế trang WEB", "Tiếng Anh", "", "", ""})
        Me.cmbTen_cc.Location = New System.Drawing.Point(436, 167)
        Me.cmbTen_cc.Name = "cmbTen_cc"
        Me.cmbTen_cc.Size = New System.Drawing.Size(299, 27)
        Me.cmbTen_cc.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(352, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 19)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Đến tháng:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDen_thang
        '
        Me.txtDen_thang.Location = New System.Drawing.Point(436, 296)
        Me.txtDen_thang.Name = "txtDen_thang"
        Me.txtDen_thang.Size = New System.Drawing.Size(99, 26)
        Me.txtDen_thang.TabIndex = 1
        '
        'cmbTen_tinh
        '
        Me.cmbTen_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTen_tinh.FormattingEnabled = True
        Me.cmbTen_tinh.Location = New System.Drawing.Point(118, 194)
        Me.cmbTen_tinh.Name = "cmbTen_tinh"
        Me.cmbTen_tinh.Size = New System.Drawing.Size(147, 27)
        Me.cmbTen_tinh.TabIndex = 3
        '
        'cmbChuyen_nganh
        '
        Me.cmbChuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChuyen_nganh.FormattingEnabled = True
        Me.cmbChuyen_nganh.Location = New System.Drawing.Point(118, 226)
        Me.cmbChuyen_nganh.Name = "cmbChuyen_nganh"
        Me.cmbChuyen_nganh.Size = New System.Drawing.Size(230, 27)
        Me.cmbChuyen_nganh.TabIndex = 3
        '
        'cmbTen_lop
        '
        Me.cmbTen_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTen_lop.FormattingEnabled = True
        Me.cmbTen_lop.Location = New System.Drawing.Point(118, 262)
        Me.cmbTen_lop.Name = "cmbTen_lop"
        Me.cmbTen_lop.Size = New System.Drawing.Size(147, 27)
        Me.cmbTen_lop.TabIndex = 3
        '
        'cmbXep_loai
        '
        Me.cmbXep_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbXep_loai.FormattingEnabled = True
        Me.cmbXep_loai.Location = New System.Drawing.Point(436, 71)
        Me.cmbXep_loai.Name = "cmbXep_loai"
        Me.cmbXep_loai.Size = New System.Drawing.Size(187, 27)
        Me.cmbXep_loai.TabIndex = 3
        '
        'txtSo_vao_so
        '
        Me.txtSo_vao_so.Location = New System.Drawing.Point(436, 135)
        Me.txtSo_vao_so.Name = "txtSo_vao_so"
        Me.txtSo_vao_so.Size = New System.Drawing.Size(99, 26)
        Me.txtSo_vao_so.TabIndex = 1
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(671, 339)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 28)
        Me.btnThoat.TabIndex = 206
        Me.btnThoat.Text = "Thoát"
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(579, 339)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(89, 28)
        Me.btnLuu.TabIndex = 205
        Me.btnLuu.Text = "Lưu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMa_sv)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.txtID_sv)
        Me.GroupBox1.Controls.Add(Me.txtDen_ngay)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbTen_cc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbXep_loai)
        Me.GroupBox1.Controls.Add(Me.cmbChuyen_nganh)
        Me.GroupBox1.Controls.Add(Me.txtDen_thang)
        Me.GroupBox1.Controls.Add(Me.txtTu_thang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtHo_ten)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbTen_lop)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbTen_tinh)
        Me.GroupBox1.Controls.Add(Me.txtTu_ngay)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbGioi_tinh)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dtpNgay_sinh)
        Me.GroupBox1.Controls.Add(Me.txtSo_vao_so)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSo_hieu)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDiem)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 329)
        Me.GroupBox1.TabIndex = 207
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chứng chỉ"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_InChungChi
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmESS_InChungChi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents txtID_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_sinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGioi_tinh As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiem As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSo_hieu As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTu_ngay As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDen_ngay As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTu_thang As System.Windows.Forms.TextBox
    Friend WithEvents cmbTen_cc As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDen_thang As System.Windows.Forms.TextBox
    Friend WithEvents cmbTen_tinh As System.Windows.Forms.ComboBox
    Friend WithEvents cmbChuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTen_lop As System.Windows.Forms.ComboBox
    Friend WithEvents cmbXep_loai As System.Windows.Forms.ComboBox
    Friend WithEvents txtSo_vao_so As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
