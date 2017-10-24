<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BoMonChonHocPhan
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
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_tieng_anh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtTen_mh = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMaMon = New System.Windows.Forms.Label
        Me.txtMa_Mon = New System.Windows.Forms.TextBox
        Me.optAll1 = New System.Windows.Forms.CheckBox
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
        Me.ToolStrip1.Size = New System.Drawing.Size(605, 25)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.ID_mon, Me.Ky_hieu, Me.Ten_mon, Me.Ten_tieng_anh})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(605, 476)
        Me.DataGridView1.TabIndex = 29
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.FalseValue = "False"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.TrueValue = "True"
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID học phần"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.ReadOnly = True
        Me.ID_mon.Visible = False
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        Me.Ky_hieu.HeaderText = "Mã Học phần"
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 120
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 360.0!
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.MinimumWidth = 360
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 360
        '
        'Ten_tieng_anh
        '
        Me.Ten_tieng_anh.DataPropertyName = "Ten_tieng_anh"
        Me.Ten_tieng_anh.HeaderText = "Tên tiếng Anh"
        Me.Ten_tieng_anh.MinimumWidth = 200
        Me.Ten_tieng_anh.Name = "Ten_tieng_anh"
        Me.Ten_tieng_anh.ReadOnly = True
        Me.Ten_tieng_anh.Width = 300
        '
        'txtTen_mh
        '
        Me.txtTen_mh.Location = New System.Drawing.Point(282, 28)
        Me.txtTen_mh.Name = "txtTen_mh"
        Me.txtTen_mh.Size = New System.Drawing.Size(205, 23)
        Me.txtTen_mh.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(211, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tên học phần:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMaMon
        '
        Me.lblMaMon.BackColor = System.Drawing.Color.Transparent
        Me.lblMaMon.Location = New System.Drawing.Point(6, 28)
        Me.lblMaMon.Name = "lblMaMon"
        Me.lblMaMon.Size = New System.Drawing.Size(124, 23)
        Me.lblMaMon.TabIndex = 38
        Me.lblMaMon.Text = "Lọc theo mã học phần:"
        Me.lblMaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_Mon
        '
        Me.txtMa_Mon.Location = New System.Drawing.Point(126, 28)
        Me.txtMa_Mon.Name = "txtMa_Mon"
        Me.txtMa_Mon.Size = New System.Drawing.Size(79, 23)
        Me.txtMa_Mon.TabIndex = 39
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(493, 28)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(107, 22)
        Me.optAll1.TabIndex = 41
        Me.optAll1.Text = "Chọn tất cả"
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'frmESS_BoMonChonHocPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.txtMa_Mon)
        Me.Controls.Add(Me.lblMaMon)
        Me.Controls.Add(Me.txtTen_mh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmESS_BoMonChonHocPhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_BoMonChonMonHoc"
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
    Friend WithEvents txtTen_mh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMaMon As System.Windows.Forms.Label
    Friend WithEvents txtMa_Mon As System.Windows.Forms.TextBox
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_tieng_anh As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
