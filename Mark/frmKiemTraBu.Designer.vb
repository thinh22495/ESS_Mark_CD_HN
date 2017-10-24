<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKiemTraBu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_hoc = New System.Windows.Forms.ComboBox
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_diem_tp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_thanh_phan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_diem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_KT_Bu1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_KT_bu2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_KT_Bu3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_KT_Bu4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_KT_Bu5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.lbTen_Mon = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbLanKT = New System.Windows.Forms.ComboBox
        Me.cbThanhPhan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Lần học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_hoc
        '
        Me.cmbLan_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_hoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLan_hoc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbLan_hoc.Location = New System.Drawing.Point(533, 12)
        Me.cmbLan_hoc.Name = "cmbLan_hoc"
        Me.cmbLan_hoc.Size = New System.Drawing.Size(64, 24)
        Me.cmbLan_hoc.TabIndex = 94
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
        Me.grdViewDiem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ma_sv, Me.Ho_ten, Me.Ten_lop, Me.ID_diem_tp, Me.Diem, Me.ID_sv, Me.ID_mon, Me.ID_thanh_phan, Me.ID_diem, Me.Diem_KT_Bu1, Me.Diem_KT_bu2, Me.Diem_KT_Bu3, Me.Diem_KT_Bu4, Me.Diem_KT_Bu5})
        Me.grdViewDiem.Location = New System.Drawing.Point(-4, 68)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(1041, 428)
        Me.grdViewDiem.TabIndex = 92
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ma_sv.HeaderText = "Mã sinh viên"
        Me.Ma_sv.MinimumWidth = 120
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 120
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ho_ten.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 170
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Lớp"
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 80
        '
        'ID_diem_tp
        '
        Me.ID_diem_tp.DataPropertyName = "ID_diem_tp"
        Me.ID_diem_tp.HeaderText = "ID_diem_tp"
        Me.ID_diem_tp.Name = "ID_diem_tp"
        Me.ID_diem_tp.Visible = False
        '
        'Diem
        '
        Me.Diem.DataPropertyName = "Diem"
        Me.Diem.HeaderText = "Điểm lần 1"
        Me.Diem.Name = "Diem"
        Me.Diem.Width = 80
        '
        'ID_sv
        '
        Me.ID_sv.HeaderText = "ID_sv"
        Me.ID_sv.Name = "ID_sv"
        Me.ID_sv.Visible = False
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID_mon"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.Visible = False
        '
        'ID_thanh_phan
        '
        Me.ID_thanh_phan.DataPropertyName = "ID_thanh_phan"
        Me.ID_thanh_phan.HeaderText = "ID_thanh_phan"
        Me.ID_thanh_phan.Name = "ID_thanh_phan"
        Me.ID_thanh_phan.Visible = False
        '
        'ID_diem
        '
        Me.ID_diem.DataPropertyName = "ID_diem"
        Me.ID_diem.HeaderText = "ID_diem"
        Me.ID_diem.Name = "ID_diem"
        Me.ID_diem.Visible = False
        '
        'Diem_KT_Bu1
        '
        Me.Diem_KT_Bu1.DataPropertyName = "Diem_KT_Bu1"
        Me.Diem_KT_Bu1.HeaderText = "Điểm KT bù 1"
        Me.Diem_KT_Bu1.Name = "Diem_KT_Bu1"
        Me.Diem_KT_Bu1.Visible = False
        '
        'Diem_KT_bu2
        '
        Me.Diem_KT_bu2.DataPropertyName = "Diem_KT_bu2"
        Me.Diem_KT_bu2.HeaderText = "Điểm KT Bù 2"
        Me.Diem_KT_bu2.Name = "Diem_KT_bu2"
        Me.Diem_KT_bu2.Visible = False
        '
        'Diem_KT_Bu3
        '
        Me.Diem_KT_Bu3.HeaderText = "Điểm KT Bù 3"
        Me.Diem_KT_Bu3.Name = "Diem_KT_Bu3"
        Me.Diem_KT_Bu3.Visible = False
        '
        'Diem_KT_Bu4
        '
        Me.Diem_KT_Bu4.HeaderText = "Điểm KT Bù 4"
        Me.Diem_KT_Bu4.Name = "Diem_KT_Bu4"
        Me.Diem_KT_Bu4.Visible = False
        '
        'Diem_KT_Bu5
        '
        Me.Diem_KT_Bu5.HeaderText = "Điểm KT Bù 5"
        Me.Diem_KT_Bu5.Name = "Diem_KT_Bu5"
        Me.Diem_KT_Bu5.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(338, 12)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 24)
        Me.cmbNam_hoc.TabIndex = 91
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLan_cap.Location = New System.Drawing.Point(35, 9)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 88
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(111, 12)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 89
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(-7, 39)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(102, 24)
        Me.lblLoai_chungchi.TabIndex = 86
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTen_Mon
        '
        Me.lbTen_Mon.AutoSize = True
        Me.lbTen_Mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTen_Mon.Location = New System.Drawing.Point(108, 43)
        Me.lbTen_Mon.Name = "lbTen_Mon"
        Me.lbTen_Mon.Size = New System.Drawing.Size(51, 17)
        Me.lbTen_Mon.TabIndex = 95
        Me.lbTen_Mon.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(603, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Lần kiểm tra bù"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbLanKT
        '
        Me.cbLanKT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLanKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLanKT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLanKT.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbLanKT.Location = New System.Drawing.Point(728, 13)
        Me.cbLanKT.Name = "cbLanKT"
        Me.cbLanKT.Size = New System.Drawing.Size(64, 24)
        Me.cbLanKT.TabIndex = 97
        '
        'cbThanhPhan
        '
        Me.cbThanhPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThanhPhan.FormattingEnabled = True
        Me.cbThanhPhan.Location = New System.Drawing.Point(728, 43)
        Me.cbThanhPhan.Name = "cbThanhPhan"
        Me.cbThanhPhan.Size = New System.Drawing.Size(222, 21)
        Me.cbThanhPhan.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(617, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Thành phần "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(831, 16)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(99, 17)
        Me.chkLoc.TabIndex = 100
        Me.chkLoc.Text = "Lọc kiểm tra bù"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(831, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Cập nhật"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Button2.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(940, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 33)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmKiemTraBu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 538)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkLoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbThanhPhan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbLanKT)
        Me.Controls.Add(Me.lbTen_Mon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_hoc)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Name = "frmKiemTraBu"
        Me.Text = "Nhập điểm kiểm tra bù"
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents lbTen_Mon As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbLanKT As System.Windows.Forms.ComboBox
    Friend WithEvents cbThanhPhan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_diem_tp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_thanh_phan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_diem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_KT_Bu1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_KT_bu2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_KT_Bu3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_KT_Bu4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_KT_Bu5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
