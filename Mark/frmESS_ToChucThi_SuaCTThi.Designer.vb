<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_SuaCTThi
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
        Me.cmbDot_thi = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtThoi_gian = New System.Windows.Forms.TextBox
        Me.dtpNgay_thi = New System.Windows.Forms.DateTimePicker
        Me.cmbCo_so = New System.Windows.Forms.ComboBox
        Me.cmbCa_thi = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbNhom_tiet = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbToa_nha = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbmPhong = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbTang = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDot_thi
        '
        Me.cmbDot_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thi.FormattingEnabled = True
        Me.cmbDot_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbDot_thi.Location = New System.Drawing.Point(104, 80)
        Me.cmbDot_thi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbDot_thi.Name = "cmbDot_thi"
        Me.cmbDot_thi.Size = New System.Drawing.Size(179, 27)
        Me.cmbDot_thi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Đợt thi:"
        '
        'txtThoi_gian
        '
        Me.txtThoi_gian.Location = New System.Drawing.Point(104, 182)
        Me.txtThoi_gian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtThoi_gian.Name = "txtThoi_gian"
        Me.txtThoi_gian.Size = New System.Drawing.Size(179, 26)
        Me.txtThoi_gian.TabIndex = 3
        '
        'dtpNgay_thi
        '
        Me.dtpNgay_thi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgay_thi.Location = New System.Drawing.Point(104, 48)
        Me.dtpNgay_thi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpNgay_thi.Name = "dtpNgay_thi"
        Me.dtpNgay_thi.ShowCheckBox = True
        Me.dtpNgay_thi.Size = New System.Drawing.Size(179, 26)
        Me.dtpNgay_thi.TabIndex = 4
        '
        'cmbCo_so
        '
        Me.cmbCo_so.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCo_so.FormattingEnabled = True
        Me.cmbCo_so.Location = New System.Drawing.Point(104, 215)
        Me.cmbCo_so.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCo_so.Name = "cmbCo_so"
        Me.cmbCo_so.Size = New System.Drawing.Size(179, 27)
        Me.cmbCo_so.TabIndex = 0
        '
        'cmbCa_thi
        '
        Me.cmbCa_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCa_thi.FormattingEnabled = True
        Me.cmbCa_thi.Items.AddRange(New Object() {"Sáng", "Chiều", "Tối"})
        Me.cmbCa_thi.Location = New System.Drawing.Point(104, 113)
        Me.cmbCa_thi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCa_thi.Name = "cmbCa_thi"
        Me.cmbCa_thi.Size = New System.Drawing.Size(179, 27)
        Me.cmbCa_thi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buổi thi:"
        '
        'cmbNhom_tiet
        '
        Me.cmbNhom_tiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom_tiet.FormattingEnabled = True
        Me.cmbNhom_tiet.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNhom_tiet.Location = New System.Drawing.Point(104, 147)
        Me.cmbNhom_tiet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNhom_tiet.Name = "cmbNhom_tiet"
        Me.cmbNhom_tiet.Size = New System.Drawing.Size(179, 27)
        Me.cmbNhom_tiet.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ca thi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Thời gian:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ngày thi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cơ sở:"
        '
        'cmbToa_nha
        '
        Me.cmbToa_nha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToa_nha.FormattingEnabled = True
        Me.cmbToa_nha.Location = New System.Drawing.Point(104, 248)
        Me.cmbToa_nha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbToa_nha.Name = "cmbToa_nha"
        Me.cmbToa_nha.Size = New System.Drawing.Size(81, 27)
        Me.cmbToa_nha.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 255)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tòa nhà"
        '
        'cbmPhong
        '
        Me.cbmPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmPhong.FormattingEnabled = True
        Me.cbmPhong.Location = New System.Drawing.Point(104, 284)
        Me.cbmPhong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbmPhong.Name = "cbmPhong"
        Me.cbmPhong.Size = New System.Drawing.Size(179, 27)
        Me.cbmPhong.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 290)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Phòng:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmPhong)
        Me.GroupBox1.Controls.Add(Me.dtpNgay_thi)
        Me.GroupBox1.Controls.Add(Me.cmbDot_thi)
        Me.GroupBox1.Controls.Add(Me.txtThoi_gian)
        Me.GroupBox1.Controls.Add(Me.cmbCa_thi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbNhom_tiet)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbCo_so)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbTang)
        Me.GroupBox1.Controls.Add(Me.cmbToa_nha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(329, 323)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chỉnh sửa chi tiết thi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 252)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tầng:"
        '
        'cmbTang
        '
        Me.cmbTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTang.FormattingEnabled = True
        Me.cmbTang.Location = New System.Drawing.Point(237, 249)
        Me.cmbTang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTang.Name = "cmbTang"
        Me.cmbTang.Size = New System.Drawing.Size(46, 27)
        Me.cmbTang.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(291, 287)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 19)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "(*)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(291, 151)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "(*)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(291, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 19)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "(*)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(291, 84)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "(*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(291, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "(*)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave.ImageIndex = 22
        Me.btnSave.Location = New System.Drawing.Point(35, 345)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 30)
        Me.btnSave.TabIndex = 182
        Me.btnSave.Text = "Cập nhật"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(126, 345)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 30)
        Me.btnThoat.TabIndex = 186
        Me.btnThoat.Text = "Thoát"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_ToChucThi_SuaCTThi
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 388)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "frmESS_ToChucThi_SuaCTThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa chi tiết thi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbDot_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtThoi_gian As System.Windows.Forms.TextBox
    Friend WithEvents dtpNgay_thi As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCo_so As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCa_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNhom_tiet As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbToa_nha As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbmPhong As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbTang As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
