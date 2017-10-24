<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMHeSoHocPhi
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOption3 = New System.Windows.Forms.TextBox
        Me.cmbOption0 = New System.Windows.Forms.ComboBox
        Me.LabelOption3 = New System.Windows.Forms.Label
        Me.LabelOption0 = New System.Windows.Forms.Label
        Me.txtOption2 = New System.Windows.Forms.TextBox
        Me.LabelOption2 = New System.Windows.Forms.Label
        Me.LabelOption1 = New System.Windows.Forms.Label
        Me.txtOption1 = New System.Windows.Forms.TextBox
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.ToolStrip.Size = New System.Drawing.Size(458, 25)
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOption3)
        Me.GroupBox1.Controls.Add(Me.cmbOption0)
        Me.GroupBox1.Controls.Add(Me.LabelOption3)
        Me.GroupBox1.Controls.Add(Me.LabelOption0)
        Me.GroupBox1.Controls.Add(Me.txtOption2)
        Me.GroupBox1.Controls.Add(Me.LabelOption2)
        Me.GroupBox1.Controls.Add(Me.LabelOption1)
        Me.GroupBox1.Controls.Add(Me.txtOption1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(458, 140)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(277, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 30)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(277, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(277, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'txtOption3
        '
        Me.txtOption3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption3.Location = New System.Drawing.Point(132, 107)
        Me.txtOption3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption3.MaxLength = 7
        Me.txtOption3.Name = "txtOption3"
        Me.txtOption3.Size = New System.Drawing.Size(139, 23)
        Me.txtOption3.TabIndex = 86
        '
        'cmbOption0
        '
        Me.cmbOption0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption0.FormattingEnabled = True
        Me.cmbOption0.Location = New System.Drawing.Point(132, 14)
        Me.cmbOption0.Name = "cmbOption0"
        Me.cmbOption0.Size = New System.Drawing.Size(289, 24)
        Me.cmbOption0.TabIndex = 85
        '
        'LabelOption3
        '
        Me.LabelOption3.AutoSize = True
        Me.LabelOption3.Location = New System.Drawing.Point(10, 114)
        Me.LabelOption3.Name = "LabelOption3"
        Me.LabelOption3.Size = New System.Drawing.Size(65, 16)
        Me.LabelOption3.TabIndex = 88
        Me.LabelOption3.Text = "Ngành 2:"
        '
        'LabelOption0
        '
        Me.LabelOption0.AutoSize = True
        Me.LabelOption0.Location = New System.Drawing.Point(10, 22)
        Me.LabelOption0.Name = "LabelOption0"
        Me.LabelOption0.Size = New System.Drawing.Size(85, 16)
        Me.LabelOption0.TabIndex = 84
        Me.LabelOption0.Text = "Hệ đào tạo :"
        '
        'txtOption2
        '
        Me.txtOption2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption2.Location = New System.Drawing.Point(132, 76)
        Me.txtOption2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption2.MaxLength = 7
        Me.txtOption2.Name = "txtOption2"
        Me.txtOption2.Size = New System.Drawing.Size(139, 23)
        Me.txtOption2.TabIndex = 83
        '
        'LabelOption2
        '
        Me.LabelOption2.AutoSize = True
        Me.LabelOption2.Location = New System.Drawing.Point(10, 82)
        Me.LabelOption2.Name = "LabelOption2"
        Me.LabelOption2.Size = New System.Drawing.Size(118, 16)
        Me.LabelOption2.TabIndex = 85
        Me.LabelOption2.Text = "Ngoài ngân sách:"
        '
        'LabelOption1
        '
        Me.LabelOption1.AutoSize = True
        Me.LabelOption1.Location = New System.Drawing.Point(10, 52)
        Me.LabelOption1.Name = "LabelOption1"
        Me.LabelOption1.Size = New System.Drawing.Size(54, 16)
        Me.LabelOption1.TabIndex = 82
        Me.LabelOption1.Text = "Học lại:"
        '
        'txtOption1
        '
        Me.txtOption1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption1.Location = New System.Drawing.Point(132, 45)
        Me.txtOption1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption1.MaxLength = 7
        Me.txtOption1.Name = "txtOption1"
        Me.txtOption1.Size = New System.Drawing.Size(139, 23)
        Me.txtOption1.TabIndex = 76
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 165)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(458, 357)
        Me.DataGridViewDM.TabIndex = 32
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_DMHeSoHocPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 522)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DMHeSoHocPhi"
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
    Friend WithEvents txtOption1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbOption0 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelOption0 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOption2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption2 As System.Windows.Forms.Label
    Friend WithEvents txtOption3 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
