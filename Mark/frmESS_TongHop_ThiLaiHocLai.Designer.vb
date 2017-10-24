<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHop_ThiLaiHocLai
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
        Me.lblNoi_sinh = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdExportExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.grdDanhSachChuaChon = New System.Windows.Forms.DataGridView
        Me.grdDanhSachDaChon = New System.Windows.Forms.DataGridView
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdDanhSachChuaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDanhSachDaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExportExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 91
        Me.ToolStrip.Text = "ToolStrip1"
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
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(100, 61)
        Me.cmbID_chuyen_nganh.MaxDropDownItems = 9
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(306, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 94
        '
        'grdDanhSachChuaChon
        '
        Me.grdDanhSachChuaChon.AllowUserToAddRows = False
        Me.grdDanhSachChuaChon.AllowUserToDeleteRows = False
        Me.grdDanhSachChuaChon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSachChuaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdDanhSachChuaChon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSachChuaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSachChuaChon.Location = New System.Drawing.Point(0, 91)
        Me.grdDanhSachChuaChon.Name = "grdDanhSachChuaChon"
        Me.grdDanhSachChuaChon.RowHeadersVisible = False
        Me.grdDanhSachChuaChon.Size = New System.Drawing.Size(792, 243)
        Me.grdDanhSachChuaChon.TabIndex = 119
        '
        'grdDanhSachDaChon
        '
        Me.grdDanhSachDaChon.AllowUserToAddRows = False
        Me.grdDanhSachDaChon.AllowUserToDeleteRows = False
        Me.grdDanhSachDaChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSachDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdDanhSachDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSachDaChon.Location = New System.Drawing.Point(0, 363)
        Me.grdDanhSachDaChon.Name = "grdDanhSachDaChon"
        Me.grdDanhSachDaChon.RowHeadersVisible = False
        Me.grdDanhSachDaChon.Size = New System.Drawing.Size(792, 202)
        Me.grdDanhSachDaChon.TabIndex = 120
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbID_mon.ForeColor = System.Drawing.Color.Navy
        Me.cmbID_mon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbID_mon.Location = New System.Drawing.Point(486, 61)
        Me.cmbID_mon.MaxDropDownItems = 9
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(294, 24)
        Me.cmbID_mon.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(422, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Môn học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(542, 337)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(248, 25)
        Me.ToolStrip1.TabIndex = 123
        Me.ToolStrip1.Text = "Xoá sinh viên"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(124, 22)
        Me.cmdAdd.Text = "Thêm sinh viên"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(112, 22)
        Me.cmdDelete.Text = "Xoá sinh viên"
        '
        'frmESS_TongHop_ThiLaiHocLai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdDanhSachDaChon)
        Me.Controls.Add(Me.grdDanhSachChuaChon)
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
        Me.Name = "frmESS_TongHop_ThiLaiHocLai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_TongHop_ThiLaiHocLai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdDanhSachChuaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDanhSachDaChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents cmdExportExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents grdDanhSachChuaChon As System.Windows.Forms.DataGridView
    Friend WithEvents grdDanhSachDaChon As System.Windows.Forms.DataGridView
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
End Class
