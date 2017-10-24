<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMMucHocPhiTinChi
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
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbOption2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbOption0 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbOption1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkOption3 = New System.Windows.Forms.CheckBox
        Me.chkOption4 = New System.Windows.Forms.CheckBox
        Me.chkOption5 = New System.Windows.Forms.CheckBox
        Me.LabelMa = New System.Windows.Forms.Label
        Me.txtOption7 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOption8 = New System.Windows.Forms.TextBox
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkOption6 = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip.SuspendLayout()
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
        Me.ToolStrip.Size = New System.Drawing.Size(579, 25)
        Me.ToolStrip.TabIndex = 34
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
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(19, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 23)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Hệ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOption2
        '
        Me.cmbOption2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption2.Enabled = False
        Me.cmbOption2.Location = New System.Drawing.Point(75, 58)
        Me.cmbOption2.MaxDropDownItems = 5
        Me.cmbOption2.Name = "cmbOption2"
        Me.cmbOption2.Size = New System.Drawing.Size(469, 24)
        Me.cmbOption2.TabIndex = 158
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(550, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 24)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(137, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 24)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOption0
        '
        Me.cmbOption0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption0.ItemHeight = 16
        Me.cmbOption0.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbOption0.Location = New System.Drawing.Point(75, 28)
        Me.cmbOption0.Name = "cmbOption0"
        Me.cmbOption0.Size = New System.Drawing.Size(56, 24)
        Me.cmbOption0.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Học kỳ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOption1
        '
        Me.cmbOption1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption1.Items.AddRange(New Object() {"1", "2"})
        Me.cmbOption1.Location = New System.Drawing.Point(440, 28)
        Me.cmbOption1.Name = "cmbOption1"
        Me.cmbOption1.Size = New System.Drawing.Size(104, 24)
        Me.cmbOption1.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(364, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Năm học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(550, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 24)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkOption3
        '
        Me.chkOption3.AutoSize = True
        Me.chkOption3.BackColor = System.Drawing.Color.Transparent
        Me.chkOption3.Location = New System.Drawing.Point(75, 89)
        Me.chkOption3.Name = "chkOption3"
        Me.chkOption3.Size = New System.Drawing.Size(133, 20)
        Me.chkOption3.TabIndex = 167
        Me.chkOption3.Text = "Ngoài ngân sách"
        Me.chkOption3.UseVisualStyleBackColor = False
        '
        'chkOption4
        '
        Me.chkOption4.AutoSize = True
        Me.chkOption4.BackColor = System.Drawing.Color.Transparent
        Me.chkOption4.Location = New System.Drawing.Point(214, 89)
        Me.chkOption4.Name = "chkOption4"
        Me.chkOption4.Size = New System.Drawing.Size(149, 20)
        Me.chkOption4.TabIndex = 168
        Me.chkOption4.Text = "Học chương trình 2"
        Me.chkOption4.UseVisualStyleBackColor = False
        '
        'chkOption5
        '
        Me.chkOption5.AutoSize = True
        Me.chkOption5.BackColor = System.Drawing.Color.Transparent
        Me.chkOption5.Location = New System.Drawing.Point(369, 89)
        Me.chkOption5.Name = "chkOption5"
        Me.chkOption5.Size = New System.Drawing.Size(69, 20)
        Me.chkOption5.TabIndex = 169
        Me.chkOption5.Text = "Học lại"
        Me.chkOption5.UseVisualStyleBackColor = False
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.BackColor = System.Drawing.Color.Transparent
        Me.LabelMa.Location = New System.Drawing.Point(1, 119)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(72, 16)
        Me.LabelMa.TabIndex = 171
        Me.LabelMa.Text = "Tính chất:"
        '
        'txtOption7
        '
        Me.txtOption7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption7.Location = New System.Drawing.Point(75, 116)
        Me.txtOption7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption7.MaxLength = 100
        Me.txtOption7.Name = "txtOption7"
        Me.txtOption7.Size = New System.Drawing.Size(195, 23)
        Me.txtOption7.TabIndex = 170
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(306, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Số tiền/1 tín chỉ:"
        '
        'txtOption8
        '
        Me.txtOption8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption8.Location = New System.Drawing.Point(422, 116)
        Me.txtOption8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption8.MaxLength = 7
        Me.txtOption8.Name = "txtOption8"
        Me.txtOption8.Size = New System.Drawing.Size(122, 23)
        Me.txtOption8.TabIndex = 172
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 147)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewDM.Size = New System.Drawing.Size(574, 359)
        Me.DataGridViewDM.TabIndex = 174
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(276, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "(*)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(550, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "(*)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkOption6
        '
        Me.chkOption6.AutoSize = True
        Me.chkOption6.BackColor = System.Drawing.Color.Transparent
        Me.chkOption6.Location = New System.Drawing.Point(453, 88)
        Me.chkOption6.Name = "chkOption6"
        Me.chkOption6.Size = New System.Drawing.Size(91, 20)
        Me.chkOption6.TabIndex = 177
        Me.chkOption6.Text = "Miễn giảm"
        Me.chkOption6.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_DMMucHocPhiTinChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkOption6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOption8)
        Me.Controls.Add(Me.LabelMa)
        Me.Controls.Add(Me.txtOption7)
        Me.Controls.Add(Me.chkOption5)
        Me.Controls.Add(Me.chkOption4)
        Me.Controls.Add(Me.chkOption3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbOption0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbOption1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbOption2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_DMMucHocPhiTinChi"
        Me.Text = "frmESS_MucHocPhiTinChi"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
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
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbOption2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbOption0 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbOption1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkOption3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOption4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOption5 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents txtOption7 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOption8 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkOption6 As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
