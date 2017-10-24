<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThanhPhanDiem
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
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.LabelOther = New System.Windows.Forms.Label
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.txtTen_thanh_phan = New System.Windows.Forms.TextBox
        Me.LabelTen = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.LabelMa = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optMac_dinh = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTy_le = New System.Windows.Forms.TextBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.txtSTT = New System.Windows.Forms.TextBox
        Me.txtKy_hieu = New System.Windows.Forms.TextBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 138)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(566, 384)
        Me.DataGridViewDM.TabIndex = 38
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS.Catalogue.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'LabelOther
        '
        Me.LabelOther.AutoSize = True
        Me.LabelOther.Location = New System.Drawing.Point(8, 79)
        Me.LabelOther.Name = "LabelOther"
        Me.LabelOther.Size = New System.Drawing.Size(101, 16)
        Me.LabelOther.TabIndex = 92
        Me.LabelOther.Text = "Tên thành phần:"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS.Catalogue.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xoá"
        '
        'txtTen_thanh_phan
        '
        Me.txtTen_thanh_phan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTen_thanh_phan.Location = New System.Drawing.Point(115, 76)
        Me.txtTen_thanh_phan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTen_thanh_phan.MaxLength = 50
        Me.txtTen_thanh_phan.Name = "txtTen_thanh_phan"
        Me.txtTen_thanh_phan.Size = New System.Drawing.Size(301, 22)
        Me.txtTen_thanh_phan.TabIndex = 90
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.Location = New System.Drawing.Point(53, 49)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(56, 16)
        Me.LabelTen.TabIndex = 89
        Me.LabelTen.Text = "Ký hiệu:"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESS.Catalogue.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(443, 20)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(31, 16)
        Me.LabelMa.TabIndex = 88
        Me.LabelMa.Text = "STT"
        Me.LabelMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ESS.Catalogue.My.Resources.Resources.Cancel
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(52, 22)
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESS.Catalogue.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESS.Catalogue.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.optMac_dinh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTy_le)
        Me.GroupBox1.Controls.Add(Me.cmbID_he)
        Me.GroupBox1.Controls.Add(Me.lblLoai_chungchi)
        Me.GroupBox1.Controls.Add(Me.LabelOther)
        Me.GroupBox1.Controls.Add(Me.txtTen_thanh_phan)
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.txtSTT)
        Me.GroupBox1.Controls.Add(Me.txtKy_hieu)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(566, 105)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'optMac_dinh
        '
        Me.optMac_dinh.AutoSize = True
        Me.optMac_dinh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optMac_dinh.Location = New System.Drawing.Point(454, 78)
        Me.optMac_dinh.Name = "optMac_dinh"
        Me.optMac_dinh.Size = New System.Drawing.Size(80, 20)
        Me.optMac_dinh.TabIndex = 99
        Me.optMac_dinh.Text = "Mặc định"
        Me.optMac_dinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optMac_dinh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Tỷ lệ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTy_le
        '
        Me.txtTy_le.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTy_le.Location = New System.Drawing.Point(480, 43)
        Me.txtTy_le.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTy_le.MaxLength = 10
        Me.txtTy_le.Name = "txtTy_le"
        Me.txtTy_le.Size = New System.Drawing.Size(54, 22)
        Me.txtTy_le.TabIndex = 95
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Location = New System.Drawing.Point(115, 15)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(301, 24)
        Me.cmbID_he.TabIndex = 94
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(14, 15)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(95, 24)
        Me.lblLoai_chungchi.TabIndex = 93
        Me.lblLoai_chungchi.Text = "Hệ đào tạo:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSTT
        '
        Me.txtSTT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSTT.Location = New System.Drawing.Point(480, 17)
        Me.txtSTT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSTT.MaxLength = 10
        Me.txtSTT.Name = "txtSTT"
        Me.txtSTT.Size = New System.Drawing.Size(54, 22)
        Me.txtSTT.TabIndex = 84
        '
        'txtKy_hieu
        '
        Me.txtKy_hieu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtKy_hieu.Location = New System.Drawing.Point(115, 46)
        Me.txtKy_hieu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKy_hieu.MaxLength = 50
        Me.txtKy_hieu.Name = "txtKy_hieu"
        Me.txtKy_hieu.Size = New System.Drawing.Size(301, 22)
        Me.txtKy_hieu.TabIndex = 85
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdClose, Me.cmdSave, Me.cmdCancel})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(566, 25)
        Me.ToolStrip.TabIndex = 36
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_ThanhPhanDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 522)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_ThanhPhanDiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_ThanhPhanDiem"
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelOther As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTen_thanh_phan As System.Windows.Forms.TextBox
    Friend WithEvents LabelTen As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSTT As System.Windows.Forms.TextBox
    Friend WithEvents txtKy_hieu As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents optMac_dinh As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTy_le As System.Windows.Forms.TextBox
End Class
