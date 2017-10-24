<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BoMonChonGiaoVien
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtTen_gv = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ID_cb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_cb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chuc_danh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chuc_vu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(583, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.ID_cb, Me.Ma_cb, Me.Ho_ten, Me.Chuc_danh, Me.Chuc_vu})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(583, 476)
        Me.DataGridView1.TabIndex = 29
        '
        'txtTen_gv
        '
        Me.txtTen_gv.Location = New System.Drawing.Point(196, 28)
        Me.txtTen_gv.Name = "txtTen_gv"
        Me.txtTen_gv.Size = New System.Drawing.Size(324, 23)
        Me.txtTen_gv.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 23)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Lọc theo họ tên giáo viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "chon"
        Me.Chon.FalseValue = "0"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.TrueValue = "1"
        Me.Chon.Width = 60
        '
        'ID_cb
        '
        Me.ID_cb.DataPropertyName = "ID_cb"
        Me.ID_cb.HeaderText = "ID cán bộ"
        Me.ID_cb.MinimumWidth = 100
        Me.ID_cb.Name = "ID_cb"
        Me.ID_cb.ReadOnly = True
        Me.ID_cb.Visible = False
        '
        'Ma_cb
        '
        Me.Ma_cb.DataPropertyName = "Ma_cb"
        Me.Ma_cb.HeaderText = "Mã cán bộ"
        Me.Ma_cb.MinimumWidth = 100
        Me.Ma_cb.Name = "Ma_cb"
        Me.Ma_cb.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.FillWeight = 180.0!
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.MinimumWidth = 180
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 180
        '
        'Chuc_danh
        '
        Me.Chuc_danh.DataPropertyName = "Chuc_danh"
        Me.Chuc_danh.HeaderText = "Chức danh"
        Me.Chuc_danh.MinimumWidth = 100
        Me.Chuc_danh.Name = "Chuc_danh"
        Me.Chuc_danh.ReadOnly = True
        '
        'Chuc_vu
        '
        Me.Chuc_vu.DataPropertyName = "Chuc_vu"
        Me.Chuc_vu.HeaderText = "Chức vụ"
        Me.Chuc_vu.Name = "Chuc_vu"
        Me.Chuc_vu.ReadOnly = True
        Me.Chuc_vu.Width = 90
        '
        'frmESS_BoMonChonGiaoVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTen_gv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmESS_BoMonChonGiaoVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_BoMonChonGiaoVien"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTen_gv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ID_cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chuc_danh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chuc_vu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
