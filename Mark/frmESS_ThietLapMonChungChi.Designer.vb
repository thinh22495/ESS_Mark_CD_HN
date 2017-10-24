<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThietLapMonChungChi
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmdGanMonChungChi = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.grdViewLoaiChungChi = New System.Windows.Forms.DataGridView
        Me.ID_chung_chi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Loai_chung_chi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewMonChungChi = New System.Windows.Forms.DataGridView
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu_m = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewLoaiChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewMonChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmdGanMonChungChi
        '
        Me.cmdGanMonChungChi.Image = Global.ESS_Mark.My.Resources.Resources.HosoSV
        Me.cmdGanMonChungChi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGanMonChungChi.Name = "cmdGanMonChungChi"
        Me.cmdGanMonChungChi.Size = New System.Drawing.Size(180, 22)
        Me.cmdGanMonChungChi.Text = "Môn học theo chứng chỉ"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGanMonChungChi, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(541, 25)
        Me.ToolStrip.TabIndex = 54
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(149, 22)
        Me.cmdDelete.Text = "Hủy môn chứng chỉ"
        '
        'grdViewLoaiChungChi
        '
        Me.grdViewLoaiChungChi.AllowUserToAddRows = False
        Me.grdViewLoaiChungChi.AllowUserToDeleteRows = False
        Me.grdViewLoaiChungChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewLoaiChungChi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewLoaiChungChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_chung_chi, Me.Ky_hieu, Me.Loai_chung_chi})
        Me.grdViewLoaiChungChi.Location = New System.Drawing.Point(1, 27)
        Me.grdViewLoaiChungChi.Name = "grdViewLoaiChungChi"
        Me.grdViewLoaiChungChi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdViewLoaiChungChi.Size = New System.Drawing.Size(539, 178)
        Me.grdViewLoaiChungChi.TabIndex = 48
        '
        'ID_chung_chi
        '
        Me.ID_chung_chi.DataPropertyName = "ID_chung_chi"
        Me.ID_chung_chi.HeaderText = "ID_chung_chi"
        Me.ID_chung_chi.Name = "ID_chung_chi"
        Me.ID_chung_chi.Visible = False
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu_cc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ky_hieu.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ky_hieu.FillWeight = 304.5686!
        Me.Ky_hieu.HeaderText = "Ký hiệu"
        Me.Ky_hieu.MinimumWidth = 100
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        '
        'Loai_chung_chi
        '
        Me.Loai_chung_chi.DataPropertyName = "Loai_chung_chi"
        Me.Loai_chung_chi.FillWeight = 281.7586!
        Me.Loai_chung_chi.HeaderText = "Loại chứng chỉ"
        Me.Loai_chung_chi.MinimumWidth = 400
        Me.Loai_chung_chi.Name = "Loai_chung_chi"
        Me.Loai_chung_chi.ReadOnly = True
        '
        'grdViewMonChungChi
        '
        Me.grdViewMonChungChi.AllowUserToAddRows = False
        Me.grdViewMonChungChi.AllowUserToDeleteRows = False
        Me.grdViewMonChungChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewMonChungChi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewMonChungChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_mon, Me.Ky_hieu_m, Me.Ten_mon})
        Me.grdViewMonChungChi.Location = New System.Drawing.Point(2, 219)
        Me.grdViewMonChungChi.Name = "grdViewMonChungChi"
        Me.grdViewMonChungChi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdViewMonChungChi.Size = New System.Drawing.Size(539, 259)
        Me.grdViewMonChungChi.TabIndex = 60
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID_mon"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.Visible = False
        '
        'Ky_hieu_m
        '
        Me.Ky_hieu_m.DataPropertyName = "Ky_hieu_m"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ky_hieu_m.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ky_hieu_m.FillWeight = 304.5686!
        Me.Ky_hieu_m.HeaderText = "Ký hiệu"
        Me.Ky_hieu_m.MinimumWidth = 100
        Me.Ky_hieu_m.Name = "Ky_hieu_m"
        Me.Ky_hieu_m.ReadOnly = True
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 281.7586!
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.MinimumWidth = 400
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        '
        'frmESS_ThietLapMonChungChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 482)
        Me.Controls.Add(Me.grdViewMonChungChi)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.grdViewLoaiChungChi)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_ThietLapMonChungChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_ThietLapMonChungChi"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewLoaiChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewMonChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdGanMonChungChi As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewLoaiChungChi As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_chung_chi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loai_chung_chi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewMonChungChi As System.Windows.Forms.DataGridView
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu_m As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
