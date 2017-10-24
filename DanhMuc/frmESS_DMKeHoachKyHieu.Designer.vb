<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMKeHoachKyHieu
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
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelBackColor = New System.Windows.Forms.Label
        Me.TextBoxTen = New System.Windows.Forms.TextBox
        Me.TextBoxKyHieu = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LabelTextColor = New System.Windows.Forms.Label
        Me.LabelShow = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxBackColor = New System.Windows.Forms.TextBox
        Me.TextBoxTextColor = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdSave, Me.cmdCancel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(622, 25)
        Me.ToolStrip.TabIndex = 62
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.Image = Global.ESS.Catalogue.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(91, 22)
        Me.cmdAdd.Text = "Thêm mới"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESS.Catalogue.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(101, 22)
        Me.cmdEdit.Text = "Sửa dữ liệu"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS.Catalogue.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(99, 22)
        Me.cmdDelete.Text = "Xoá dữ liệu"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESS.Catalogue.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 22)
        Me.cmdSave.Text = "Lưu dữ liệu"
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ESS.Catalogue.My.Resources.Resources.Cancel
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 22)
        Me.cmdCancel.Text = "Huỷ bỏ"
        Me.cmdCancel.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS.Catalogue.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelBackColor)
        Me.GroupBox1.Controls.Add(Me.TextBoxTen)
        Me.GroupBox1.Controls.Add(Me.TextBoxKyHieu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelTextColor)
        Me.GroupBox1.Controls.Add(Me.LabelShow)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxBackColor)
        Me.GroupBox1.Controls.Add(Me.TextBoxTextColor)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 94)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'LabelBackColor
        '
        Me.LabelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBackColor.Location = New System.Drawing.Point(184, 59)
        Me.LabelBackColor.Name = "LabelBackColor"
        Me.LabelBackColor.Size = New System.Drawing.Size(55, 20)
        Me.LabelBackColor.TabIndex = 6
        '
        'TextBoxTen
        '
        Me.TextBoxTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTen.Location = New System.Drawing.Point(337, 22)
        Me.TextBoxTen.MaxLength = 50
        Me.TextBoxTen.Name = "TextBoxTen"
        Me.TextBoxTen.Size = New System.Drawing.Size(264, 23)
        Me.TextBoxTen.TabIndex = 3
        Me.TextBoxTen.Text = "TextBox2"
        '
        'TextBoxKyHieu
        '
        Me.TextBoxKyHieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKyHieu.Location = New System.Drawing.Point(104, 22)
        Me.TextBoxKyHieu.MaxLength = 2
        Me.TextBoxKyHieu.Name = "TextBoxKyHieu"
        Me.TextBoxKyHieu.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxKyHieu.TabIndex = 1
        Me.TextBoxKyHieu.Text = "TextBox1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(245, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên ký hiệu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ký hiệu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(35, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Màu nền"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(268, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Màu chữ"
        '
        'LabelTextColor
        '
        Me.LabelTextColor.AutoSize = True
        Me.LabelTextColor.BackColor = System.Drawing.Color.Transparent
        Me.LabelTextColor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextColor.Location = New System.Drawing.Point(417, 61)
        Me.LabelTextColor.Name = "LabelTextColor"
        Me.LabelTextColor.Size = New System.Drawing.Size(53, 15)
        Me.LabelTextColor.TabIndex = 9
        Me.LabelTextColor.Text = "ABC xyz"
        Me.LabelTextColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelShow
        '
        Me.LabelShow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShow.Location = New System.Drawing.Point(546, 60)
        Me.LabelShow.Name = "LabelShow"
        Me.LabelShow.Size = New System.Drawing.Size(55, 16)
        Me.LabelShow.TabIndex = 11
        Me.LabelShow.Text = "ABC xyz"
        Me.LabelShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(476, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Thể hiện"
        '
        'TextBoxBackColor
        '
        Me.TextBoxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBackColor.Location = New System.Drawing.Point(104, 58)
        Me.TextBoxBackColor.Name = "TextBoxBackColor"
        Me.TextBoxBackColor.ReadOnly = True
        Me.TextBoxBackColor.Size = New System.Drawing.Size(74, 23)
        Me.TextBoxBackColor.TabIndex = 5
        Me.TextBoxBackColor.Text = "TextBox1"
        '
        'TextBoxTextColor
        '
        Me.TextBoxTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTextColor.Location = New System.Drawing.Point(337, 58)
        Me.TextBoxTextColor.Name = "TextBoxTextColor"
        Me.TextBoxTextColor.ReadOnly = True
        Me.TextBoxTextColor.Size = New System.Drawing.Size(74, 23)
        Me.TextBoxTextColor.TabIndex = 8
        Me.TextBoxTextColor.Text = "TextBox1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(5, 131)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewDM.Size = New System.Drawing.Size(612, 242)
        Me.DataGridViewDM.TabIndex = 175
        '
        'frmESS_DMKeHoachKyHieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 375)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_DMKeHoachKyHieu"
        Me.Text = "frmESS_KeHoachKyHieu"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelBackColor As System.Windows.Forms.Label
    Friend WithEvents TextBoxTen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKyHieu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelTextColor As System.Windows.Forms.Label
    Friend WithEvents LabelShow As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBackColor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTextColor As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
End Class
