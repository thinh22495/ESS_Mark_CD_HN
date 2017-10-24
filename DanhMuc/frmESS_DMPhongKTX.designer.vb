<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMPhongKTX
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbTang = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LabelThietBi = New System.Windows.Forms.Label
        Me.txtThietBi = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbParentsID = New System.Windows.Forms.ComboBox
        Me.LabelParent = New System.Windows.Forms.Label
        Me.LabelSucChua = New System.Windows.Forms.Label
        Me.LabelMa = New System.Windows.Forms.Label
        Me.txtMa = New System.Windows.Forms.TextBox
        Me.txtSucChua = New System.Windows.Forms.TextBox
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblSo_tien_mot_nguoi = New System.Windows.Forms.Label
        Me.txtSo_tien_mot_nguoi = New System.Windows.Forms.TextBox
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolStrip.TabIndex = 30
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESS.Catalogue.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESS.Catalogue.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS.Catalogue.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xoá"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS.Catalogue.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
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
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ESS.Catalogue.My.Resources.Resources.Cancel
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(52, 22)
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblSo_tien_mot_nguoi)
        Me.GroupBox1.Controls.Add(Me.txtSo_tien_mot_nguoi)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbTang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelThietBi)
        Me.GroupBox1.Controls.Add(Me.txtThietBi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbParentsID)
        Me.GroupBox1.Controls.Add(Me.LabelParent)
        Me.GroupBox1.Controls.Add(Me.LabelSucChua)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtSucChua)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(566, 200)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(9, 48)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(41, 16)
        Me.lbl.TabIndex = 92
        Me.lbl.Text = "Tầng"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(427, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTang
        '
        Me.cmbTang.FormattingEnabled = True
        Me.cmbTang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbTang.Location = New System.Drawing.Point(157, 44)
        Me.cmbTang.Name = "cmbTang"
        Me.cmbTang.Size = New System.Drawing.Size(264, 24)
        Me.cmbTang.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(427, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 30)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "(*)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelThietBi
        '
        Me.LabelThietBi.AutoSize = True
        Me.LabelThietBi.Location = New System.Drawing.Point(10, 136)
        Me.LabelThietBi.Name = "LabelThietBi"
        Me.LabelThietBi.Size = New System.Drawing.Size(137, 16)
        Me.LabelThietBi.TabIndex = 88
        Me.LabelThietBi.Text = "Ngành đào tạo        :"
        '
        'txtThietBi
        '
        Me.txtThietBi.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtThietBi.Location = New System.Drawing.Point(157, 134)
        Me.txtThietBi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtThietBi.MaxLength = 50
        Me.txtThietBi.Name = "txtThietBi"
        Me.txtThietBi.Size = New System.Drawing.Size(264, 23)
        Me.txtThietBi.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(427, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParentsID
        '
        Me.cmbParentsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParentsID.FormattingEnabled = True
        Me.cmbParentsID.Location = New System.Drawing.Point(157, 14)
        Me.cmbParentsID.Name = "cmbParentsID"
        Me.cmbParentsID.Size = New System.Drawing.Size(264, 24)
        Me.cmbParentsID.TabIndex = 85
        '
        'LabelParent
        '
        Me.LabelParent.AutoSize = True
        Me.LabelParent.Location = New System.Drawing.Point(10, 22)
        Me.LabelParent.Name = "LabelParent"
        Me.LabelParent.Size = New System.Drawing.Size(137, 16)
        Me.LabelParent.TabIndex = 84
        Me.LabelParent.Text = "Ngành đào tạo        :"
        '
        'LabelSucChua
        '
        Me.LabelSucChua.AutoSize = True
        Me.LabelSucChua.Location = New System.Drawing.Point(10, 106)
        Me.LabelSucChua.Name = "LabelSucChua"
        Me.LabelSucChua.Size = New System.Drawing.Size(137, 16)
        Me.LabelSucChua.TabIndex = 83
        Me.LabelSucChua.Text = "Ngành đào tạo        :"
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(10, 77)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(137, 16)
        Me.LabelMa.TabIndex = 82
        Me.LabelMa.Text = "Ngành đào tạo        :"
        '
        'txtMa
        '
        Me.txtMa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMa.Location = New System.Drawing.Point(157, 74)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 20
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(264, 23)
        Me.txtMa.TabIndex = 76
        '
        'txtSucChua
        '
        Me.txtSucChua.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSucChua.Location = New System.Drawing.Point(157, 104)
        Me.txtSucChua.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSucChua.MaxLength = 50
        Me.txtSucChua.Name = "txtSucChua"
        Me.txtSucChua.Size = New System.Drawing.Size(264, 23)
        Me.txtSucChua.TabIndex = 77
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 233)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(566, 289)
        Me.DataGridViewDM.TabIndex = 32
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblSo_tien_mot_nguoi
        '
        Me.lblSo_tien_mot_nguoi.AutoSize = True
        Me.lblSo_tien_mot_nguoi.Location = New System.Drawing.Point(10, 167)
        Me.lblSo_tien_mot_nguoi.Name = "lblSo_tien_mot_nguoi"
        Me.lblSo_tien_mot_nguoi.Size = New System.Drawing.Size(137, 16)
        Me.lblSo_tien_mot_nguoi.TabIndex = 94
        Me.lblSo_tien_mot_nguoi.Text = "Ngành đào tạo        :"
        '
        'txtSo_tien_mot_nguoi
        '
        Me.txtSo_tien_mot_nguoi.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSo_tien_mot_nguoi.Location = New System.Drawing.Point(157, 165)
        Me.txtSo_tien_mot_nguoi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSo_tien_mot_nguoi.MaxLength = 50
        Me.txtSo_tien_mot_nguoi.Name = "txtSo_tien_mot_nguoi"
        Me.txtSo_tien_mot_nguoi.Size = New System.Drawing.Size(264, 23)
        Me.txtSo_tien_mot_nguoi.TabIndex = 93
        '
        'frmESS_DMPhongKTX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 522)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DMPhongKTX"
        Me.Text = "frmESS_DMChuyenNganh"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtSucChua As System.Windows.Forms.TextBox
    Friend WithEvents LabelSucChua As System.Windows.Forms.Label
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbParentsID As System.Windows.Forms.ComboBox
    Friend WithEvents LabelParent As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelThietBi As System.Windows.Forms.Label
    Friend WithEvents txtThietBi As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTang As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_mot_nguoi As System.Windows.Forms.Label
    Friend WithEvents txtSo_tien_mot_nguoi As System.Windows.Forms.TextBox
End Class
