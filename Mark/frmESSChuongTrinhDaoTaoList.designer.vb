<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESSChuongTrinhDaoTaoList
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESSChuongTrinhDaoTaoList))
        Me.grdViewCTDT = New System.Windows.Forms.DataGridView
        Me.Ten_he = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Khoa_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_chuyen_nganh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_Ky_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewCTDTChiTiet = New System.Windows.Forms.DataGridView
        Me.txtTong_so_mon = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grdViewCTDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewCTDTChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdViewCTDT
        '
        Me.grdViewCTDT.AllowUserToAddRows = False
        Me.grdViewCTDT.AllowUserToDeleteRows = False
        Me.grdViewCTDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewCTDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewCTDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewCTDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_he, Me.Ten_khoa, Me.Khoa_hoc, Me.Ten_chuyen_nganh, Me.So_Ky_hoc, Me.So_hoc_trinh, Me.So})
        Me.grdViewCTDT.Location = New System.Drawing.Point(0, 29)
        Me.grdViewCTDT.Name = "grdViewCTDT"
        Me.grdViewCTDT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdViewCTDT.Size = New System.Drawing.Size(792, 151)
        Me.grdViewCTDT.TabIndex = 58
        '
        'Ten_he
        '
        Me.Ten_he.DataPropertyName = "Ten_he"
        Me.Ten_he.HeaderText = "Trình độ đào tạo"
        Me.Ten_he.MinimumWidth = 129
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.ReadOnly = True
        '
        'Ten_khoa
        '
        Me.Ten_khoa.DataPropertyName = "Ten_khoa"
        Me.Ten_khoa.HeaderText = "Tên khoa"
        Me.Ten_khoa.MinimumWidth = 120
        Me.Ten_khoa.Name = "Ten_khoa"
        Me.Ten_khoa.ReadOnly = True
        '
        'Khoa_hoc
        '
        Me.Khoa_hoc.DataPropertyName = "Khoa_hoc"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Khoa_hoc.DefaultCellStyle = DataGridViewCellStyle5
        Me.Khoa_hoc.HeaderText = "Khoá học"
        Me.Khoa_hoc.MinimumWidth = 80
        Me.Khoa_hoc.Name = "Khoa_hoc"
        Me.Khoa_hoc.ReadOnly = True
        '
        'Ten_chuyen_nganh
        '
        Me.Ten_chuyen_nganh.DataPropertyName = "Ten_chuyen_nganh"
        Me.Ten_chuyen_nganh.HeaderText = "Chuyên ngành"
        Me.Ten_chuyen_nganh.MinimumWidth = 160
        Me.Ten_chuyen_nganh.Name = "Ten_chuyen_nganh"
        Me.Ten_chuyen_nganh.ReadOnly = True
        '
        'So_Ky_hoc
        '
        Me.So_Ky_hoc.DataPropertyName = "So_Ky_hoc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_Ky_hoc.DefaultCellStyle = DataGridViewCellStyle6
        Me.So_Ky_hoc.HeaderText = "Kỳ học tối đa"
        Me.So_Ky_hoc.MinimumWidth = 100
        Me.So_Ky_hoc.Name = "So_Ky_hoc"
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.DataPropertyName = "So_hoc_trinh"
        Me.So_hoc_trinh.HeaderText = "Số học trình"
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        '
        'So
        '
        Me.So.DataPropertyName = "So"
        Me.So.HeaderText = "Số"
        Me.So.Name = "So"
        Me.So.Visible = False
        '
        'grdViewCTDTChiTiet
        '
        Me.grdViewCTDTChiTiet.AllowUserToAddRows = False
        Me.grdViewCTDTChiTiet.AllowUserToDeleteRows = False
        Me.grdViewCTDTChiTiet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewCTDTChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewCTDTChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewCTDTChiTiet.Location = New System.Drawing.Point(0, 208)
        Me.grdViewCTDTChiTiet.Name = "grdViewCTDTChiTiet"
        Me.grdViewCTDTChiTiet.ShowCellErrors = False
        Me.grdViewCTDTChiTiet.ShowCellToolTips = False
        Me.grdViewCTDTChiTiet.Size = New System.Drawing.Size(792, 331)
        Me.grdViewCTDTChiTiet.TabIndex = 59
        '
        'txtTong_so_mon
        '
        Me.txtTong_so_mon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTong_so_mon.BackColor = System.Drawing.Color.Transparent
        Me.txtTong_so_mon.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTong_so_mon.ForeColor = System.Drawing.Color.Maroon
        Me.txtTong_so_mon.Location = New System.Drawing.Point(753, 185)
        Me.txtTong_so_mon.Name = "txtTong_so_mon"
        Me.txtTong_so_mon.Size = New System.Drawing.Size(34, 18)
        Me.txtTong_so_mon.TabIndex = 63
        Me.txtTong_so_mon.Text = "0"
        Me.txtTong_so_mon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTong_so.Location = New System.Drawing.Point(590, 185)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(163, 18)
        Me.lblTong_so.TabIndex = 62
        Me.lblTong_so.Text = "Tổng số học phần:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.ImageKey = "Print.ico"
        Me.Button9.Location = New System.Drawing.Point(206, 180)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(103, 29)
        Me.Button9.TabIndex = 75
        Me.Button9.Text = "In báo cáo"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(105, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 29)
        Me.Button5.TabIndex = 74
        Me.Button5.Text = "Xoá môn"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1, 180)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 29)
        Me.Button6.TabIndex = 73
        Me.Button6.Text = "Thêm môn"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(628, 538)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 29)
        Me.Button8.TabIndex = 81
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.ESS_Mark.My.Resources.Resources.DoiChieuDuLieu
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(466, 538)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(154, 29)
        Me.Button7.TabIndex = 80
        Me.Button7.Text = "Gán CTrĐT cho lớp"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.ESS_Mark.My.Resources.Resources.Copy
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(317, 538)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 29)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Sao chép CTrĐT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(210, 538)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 29)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Xoá CTrĐT"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(94, 538)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 29)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Thêm CTrĐT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(-1, 538)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 29)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "Cập nhật"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(414, 22)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "QUẢN LÝ CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Warning.png")
        Me.ImageList1.Images.SetKeyName(1, "Add.png")
        Me.ImageList1.Images.SetKeyName(2, "Back.png")
        Me.ImageList1.Images.SetKeyName(3, "Bar Chart.png")
        Me.ImageList1.Images.SetKeyName(4, "Comment.png")
        Me.ImageList1.Images.SetKeyName(5, "Delete.png")
        Me.ImageList1.Images.SetKeyName(6, "Email.png")
        Me.ImageList1.Images.SetKeyName(7, "Exit.png")
        Me.ImageList1.Images.SetKeyName(8, "Info.png")
        Me.ImageList1.Images.SetKeyName(9, "Line Chart.png")
        Me.ImageList1.Images.SetKeyName(10, "Load.png")
        Me.ImageList1.Images.SetKeyName(11, "Loading.png")
        Me.ImageList1.Images.SetKeyName(12, "Modify.png")
        Me.ImageList1.Images.SetKeyName(13, "Next.png")
        Me.ImageList1.Images.SetKeyName(14, "Picture.png")
        Me.ImageList1.Images.SetKeyName(15, "Pie Chart.png")
        Me.ImageList1.Images.SetKeyName(16, "Print.png")
        Me.ImageList1.Images.SetKeyName(17, "Profile.png")
        Me.ImageList1.Images.SetKeyName(18, "Save.png")
        Me.ImageList1.Images.SetKeyName(19, "Search.png")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(330, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 29)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Import CTD"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmESS_ChuongTrinhDaoTaoList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtTong_so_mon)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.grdViewCTDTChiTiet)
        Me.Controls.Add(Me.grdViewCTDT)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_ChuongTrinhDaoTaoList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH CHUONG TRINH DAO TAO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewCTDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewCTDTChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdViewCTDT As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewCTDTChiTiet As System.Windows.Forms.DataGridView
    Friend WithEvents txtTong_so_mon As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ten_he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Khoa_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_chuyen_nganh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_Ky_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
