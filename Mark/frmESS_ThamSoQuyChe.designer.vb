<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThamSoQuyChe
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdThamSoQC = New System.Windows.Forms.DataGridView
        Me.Quy_che = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_tham_so = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_tham_so = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gia_tri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdThamSoQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 541)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdThamSoQC
        '
        Me.grdThamSoQC.AllowUserToAddRows = False
        Me.grdThamSoQC.AllowUserToDeleteRows = False
        Me.grdThamSoQC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdThamSoQC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThamSoQC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdThamSoQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThamSoQC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quy_che, Me.Ma_tham_so, Me.Ten_tham_so, Me.Gia_tri})
        Me.grdThamSoQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdThamSoQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdThamSoQC.Location = New System.Drawing.Point(0, 0)
        Me.grdThamSoQC.Name = "grdThamSoQC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThamSoQC.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdThamSoQC.Size = New System.Drawing.Size(792, 541)
        Me.grdThamSoQC.TabIndex = 25
        '
        'Quy_che
        '
        Me.Quy_che.DataPropertyName = "Quy_che"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quy_che.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quy_che.HeaderText = "Quy chế"
        Me.Quy_che.MinimumWidth = 100
        Me.Quy_che.Name = "Quy_che"
        Me.Quy_che.ReadOnly = True
        '
        'Ma_tham_so
        '
        Me.Ma_tham_so.DataPropertyName = "Ma_tham_so"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ma_tham_so.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ma_tham_so.HeaderText = "Mã tham số"
        Me.Ma_tham_so.MinimumWidth = 200
        Me.Ma_tham_so.Name = "Ma_tham_so"
        Me.Ma_tham_so.ReadOnly = True
        Me.Ma_tham_so.Width = 200
        '
        'Ten_tham_so
        '
        Me.Ten_tham_so.DataPropertyName = "Ten_tham_so"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_tham_so.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ten_tham_so.HeaderText = "Tên tham số"
        Me.Ten_tham_so.MinimumWidth = 500
        Me.Ten_tham_so.Name = "Ten_tham_so"
        Me.Ten_tham_so.ReadOnly = True
        Me.Ten_tham_so.Width = 500
        '
        'Gia_tri
        '
        Me.Gia_tri.DataPropertyName = "Gia_tri"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Gia_tri.DefaultCellStyle = DataGridViewCellStyle5
        Me.Gia_tri.HeaderText = "Giá trị"
        Me.Gia_tri.MinimumWidth = 100
        Me.Gia_tri.Name = "Gia_tri"
        '
        'frmESS_ThamSoQuyChe
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdThamSoQC)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_ThamSoQuyChe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAP THAM SO THEO QUY CHE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdThamSoQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdThamSoQC As System.Windows.Forms.DataGridView
    Friend WithEvents Quy_che As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_tham_so As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_tham_so As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gia_tri As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
