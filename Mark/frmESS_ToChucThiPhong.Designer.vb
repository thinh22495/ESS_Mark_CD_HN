<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThiPhong
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbID_nha = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong_main = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewPhongThi = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSuc_chua = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSV_Con = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkCheck = New System.Windows.Forms.CheckBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewPhongThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_nha
        '
        Me.cmbID_nha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_nha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nha.Location = New System.Drawing.Point(59, 31)
        Me.cmbID_nha.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbID_nha.Name = "cmbID_nha"
        Me.cmbID_nha.Size = New System.Drawing.Size(237, 27)
        Me.cmbID_nha.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-34, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Toà nhà:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_sv.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_sv.HeaderText = "Số sinh viên/phòng"
        Me.So_sv.Name = "So_sv"
        Me.So_sv.Width = 160
        '
        'Ten_phong
        '
        Me.Ten_phong.DataPropertyName = "Ten_phong"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_phong.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ten_phong.HeaderText = "Phòng thi"
        Me.Ten_phong.Name = "Ten_phong"
        Me.Ten_phong.ReadOnly = True
        Me.Ten_phong.Width = 150
        '
        'Ten_phong_main
        '
        Me.Ten_phong_main.HeaderText = "Tên phòng main"
        Me.Ten_phong_main.Name = "Ten_phong_main"
        '
        'grdViewPhongThi
        '
        Me.grdViewPhongThi.AllowUserToAddRows = False
        Me.grdViewPhongThi.AllowUserToDeleteRows = False
        Me.grdViewPhongThi.BackgroundColor = System.Drawing.Color.White
        Me.grdViewPhongThi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewPhongThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewPhongThi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_phong_main, Me.Ten_phong, Me.So_sv})
        Me.grdViewPhongThi.Location = New System.Drawing.Point(0, 95)
        Me.grdViewPhongThi.Margin = New System.Windows.Forms.Padding(4)
        Me.grdViewPhongThi.Name = "grdViewPhongThi"
        Me.grdViewPhongThi.RowHeadersVisible = False
        Me.grdViewPhongThi.Size = New System.Drawing.Size(674, 275)
        Me.grdViewPhongThi.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(390, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Đã tổ chức:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuc_chua
        '
        Me.lblSuc_chua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSuc_chua.BackColor = System.Drawing.Color.Transparent
        Me.lblSuc_chua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuc_chua.Location = New System.Drawing.Point(498, 33)
        Me.lblSuc_chua.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuc_chua.Name = "lblSuc_chua"
        Me.lblSuc_chua.Size = New System.Drawing.Size(54, 24)
        Me.lblSuc_chua.TabIndex = 91
        Me.lblSuc_chua.Text = "0"
        Me.lblSuc_chua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(367, 33)
        Me.lblSo_sv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(49, 24)
        Me.lblSo_sv.TabIndex = 93
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(306, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Số sv:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSV_Con
        '
        Me.lblSV_Con.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSV_Con.BackColor = System.Drawing.Color.Transparent
        Me.lblSV_Con.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSV_Con.Location = New System.Drawing.Point(624, 32)
        Me.lblSV_Con.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSV_Con.Name = "lblSV_Con"
        Me.lblSV_Con.Size = New System.Drawing.Size(71, 24)
        Me.lblSV_Con.TabIndex = 95
        Me.lblSV_Con.Text = "0"
        Me.lblSV_Con.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(532, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Còn lại:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(600, 26)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "CHỌN PHÒNG THI THEO SỐ SINH VIÊN TƯƠNG ỨNG"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Location = New System.Drawing.Point(12, 65)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(320, 23)
        Me.chkCheck.TabIndex = 132
        Me.chkCheck.Text = "Không kiểm tra số lượng sinh viên tối đa / phòng"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.ESS_Mark.My.Resources.Resources.LapSBD
        Me.SimpleButton1.ImageIndex = 22
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 377)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 30)
        Me.SimpleButton1.TabIndex = 182
        Me.SimpleButton1.Text = "Chọn phòng"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.SimpleButton2.ImageIndex = 22
        Me.SimpleButton2.Location = New System.Drawing.Point(111, 377)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(73, 30)
        Me.SimpleButton2.TabIndex = 183
        Me.SimpleButton2.Text = "Thoát"
        '
        'frmESS_ToChucThiPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 411)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.chkCheck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSV_Con)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSuc_chua)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_nha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdViewPhongThi)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ToChucThiPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "CHON PHONG THEO SO SINH VIEN DU THI"
        CType(Me.grdViewPhongThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_nha As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong_main As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewPhongThi As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSuc_chua As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSV_Con As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkCheck As System.Windows.Forms.CheckBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
