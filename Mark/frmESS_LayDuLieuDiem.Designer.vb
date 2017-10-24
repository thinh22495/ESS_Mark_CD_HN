<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_LayDuLieuDiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_LayDuLieuDiem))
        Me.TreeViewLop = New ESS_Mark.TreeViewLop
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdLayDuLieu = New System.Windows.Forms.ToolStripButton
        Me.cmdDongBoDuLieu = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmbID_phong = New System.Windows.Forms.ComboBox
        Me.cmbDon_vi = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkDiemThanhPhan = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.fgTongHopNam = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.fgTongHopNam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeViewLop
        '
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 28)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(258, 537)
        Me.TreeViewLop.TabIndex = 101
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLayDuLieu, Me.cmdDongBoDuLieu, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 102
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdLayDuLieu
        '
        Me.cmdLayDuLieu.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.cmdLayDuLieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLayDuLieu.Name = "cmdLayDuLieu"
        Me.cmdLayDuLieu.Size = New System.Drawing.Size(117, 22)
        Me.cmdLayDuLieu.Text = "Lấy dữ liệu về"
        '
        'cmdDongBoDuLieu
        '
        Me.cmdDongBoDuLieu.Image = Global.ESS_Mark.My.Resources.Resources.Import
        Me.cmdDongBoDuLieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDongBoDuLieu.Name = "cmdDongBoDuLieu"
        Me.cmdDongBoDuLieu.Size = New System.Drawing.Size(129, 22)
        Me.cmdDongBoDuLieu.Text = "Đồng bộ dữ liệu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmbID_phong
        '
        Me.cmbID_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_phong.Location = New System.Drawing.Point(552, 29)
        Me.cmbID_phong.Name = "cmbID_phong"
        Me.cmbID_phong.Size = New System.Drawing.Size(228, 24)
        Me.cmbID_phong.TabIndex = 106
        '
        'cmbDon_vi
        '
        Me.cmbDon_vi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDon_vi.Location = New System.Drawing.Point(333, 28)
        Me.cmbDon_vi.Name = "cmbDon_vi"
        Me.cmbDon_vi.Size = New System.Drawing.Size(112, 24)
        Me.cmbDon_vi.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(457, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 24)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Tên đơn vị"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(258, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Từ đơn vị"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(552, 58)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(130, 24)
        Me.cmbNam_hoc.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(466, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 24)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Năm học:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(333, 58)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(280, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 24)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Học kỳ:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDiemThanhPhan
        '
        Me.chkDiemThanhPhan.Location = New System.Drawing.Point(489, 88)
        Me.chkDiemThanhPhan.Name = "chkDiemThanhPhan"
        Me.chkDiemThanhPhan.Size = New System.Drawing.Size(156, 24)
        Me.chkDiemThanhPhan.TabIndex = 111
        Me.chkDiemThanhPhan.Text = "Điểm thành phần"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(681, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 24)
        Me.CheckBox1.TabIndex = 112
        Me.CheckBox1.Text = "Điểm thi"
        '
        'fgTongHopNam
        '
        Me.fgTongHopNam.AllowEditing = False
        Me.fgTongHopNam.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fgTongHopNam.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fgTongHopNam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTongHopNam.BackColor = System.Drawing.Color.White
        Me.fgTongHopNam.Cols = New C1.Win.C1FlexGrid.ColumnCollection(5, 1, 0, 0, 0, 95, "0{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{TextAlignFixed:CenterCen" & _
                "ter;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{TextAlignFixed:CenterCenter;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{TextAlignFixed:CenterCenter;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{TextAlig" & _
                "nFixed:CenterCenter;}" & Global.Microsoft.VisualBasic.ChrW(9))
        Me.fgTongHopNam.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgTongHopNam.Location = New System.Drawing.Point(257, 118)
        Me.fgTongHopNam.Name = "fgTongHopNam"
        Me.fgTongHopNam.Rows.Count = 0
        Me.fgTongHopNam.Rows.Fixed = 0
        Me.fgTongHopNam.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopNam.Size = New System.Drawing.Size(535, 450)
        Me.fgTongHopNam.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopNam.Styles"))
        Me.fgTongHopNam.TabIndex = 113
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(289, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 24)
        Me.CheckBox2.TabIndex = 114
        Me.CheckBox2.Text = "Chọn tất cả"
        '
        'frmESS_LayDuLieuDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.fgTongHopNam)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkDiemThanhPhan)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbID_phong)
        Me.Controls.Add(Me.cmbDon_vi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_LayDuLieuDiem"
        Me.Text = "frmESS_LayDuLieuDiem"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.fgTongHopNam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewLop As ESS_Mark.TreeViewLop
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdLayDuLieu As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDongBoDuLieu As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbID_phong As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDon_vi As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkDiemThanhPhan As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents fgTongHopNam As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
