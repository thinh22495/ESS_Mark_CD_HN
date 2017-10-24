<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_PhongHoc_DanhSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.trvPhongHoc = New System.Windows.Forms.TreeView
        Me.dgvPhongHoc = New System.Windows.Forms.DataGridView
        Me.ID_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ten_tang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Suc_chua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ten_loai_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thiet_bi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtSucChua = New System.Windows.Forms.Label
        Me.txtSoPhong = New System.Windows.Forms.Label
        Me.lblNam = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPhongHoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 27
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
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xoá"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.trvPhongHoc)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 537)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Giảng đường"
        '
        'trvPhongHoc
        '
        Me.trvPhongHoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongHoc.Location = New System.Drawing.Point(7, 23)
        Me.trvPhongHoc.Name = "trvPhongHoc"
        Me.trvPhongHoc.Size = New System.Drawing.Size(242, 505)
        Me.trvPhongHoc.TabIndex = 0
        '
        'dgvPhongHoc
        '
        Me.dgvPhongHoc.AllowUserToAddRows = False
        Me.dgvPhongHoc.AllowUserToDeleteRows = False
        Me.dgvPhongHoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPhongHoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhongHoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_phong, Me.So_phong, Me.ten_tang, Me.Suc_chua, Me.ten_loai_phong, Me.Thiet_bi})
        Me.dgvPhongHoc.Location = New System.Drawing.Point(263, 49)
        Me.dgvPhongHoc.Name = "dgvPhongHoc"
        Me.dgvPhongHoc.ReadOnly = True
        Me.dgvPhongHoc.Size = New System.Drawing.Size(531, 516)
        Me.dgvPhongHoc.TabIndex = 29
        '
        'ID_phong
        '
        Me.ID_phong.DataPropertyName = "ID_phong"
        Me.ID_phong.HeaderText = "ID phòng"
        Me.ID_phong.Name = "ID_phong"
        Me.ID_phong.ReadOnly = True
        Me.ID_phong.Visible = False
        '
        'So_phong
        '
        Me.So_phong.DataPropertyName = "so_phong"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_phong.DefaultCellStyle = DataGridViewCellStyle1
        Me.So_phong.HeaderText = "Phòng số"
        Me.So_phong.MinimumWidth = 110
        Me.So_phong.Name = "So_phong"
        Me.So_phong.ReadOnly = True
        Me.So_phong.Width = 110
        '
        'ten_tang
        '
        Me.ten_tang.DataPropertyName = "ten_tang"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ten_tang.DefaultCellStyle = DataGridViewCellStyle2
        Me.ten_tang.HeaderText = "Tầng"
        Me.ten_tang.MinimumWidth = 60
        Me.ten_tang.Name = "ten_tang"
        Me.ten_tang.ReadOnly = True
        Me.ten_tang.Width = 60
        '
        'Suc_chua
        '
        Me.Suc_chua.DataPropertyName = "suc_chua"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Suc_chua.DefaultCellStyle = DataGridViewCellStyle3
        Me.Suc_chua.HeaderText = "Sức chứa"
        Me.Suc_chua.MinimumWidth = 100
        Me.Suc_chua.Name = "Suc_chua"
        Me.Suc_chua.ReadOnly = True
        '
        'ten_loai_phong
        '
        Me.ten_loai_phong.DataPropertyName = "ten_loai_phong"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ten_loai_phong.DefaultCellStyle = DataGridViewCellStyle4
        Me.ten_loai_phong.HeaderText = "Loại phòng"
        Me.ten_loai_phong.MinimumWidth = 150
        Me.ten_loai_phong.Name = "ten_loai_phong"
        Me.ten_loai_phong.ReadOnly = True
        Me.ten_loai_phong.Width = 150
        '
        'Thiet_bi
        '
        Me.Thiet_bi.DataPropertyName = "thiet_bi"
        Me.Thiet_bi.HeaderText = "Thiết bị"
        Me.Thiet_bi.MinimumWidth = 250
        Me.Thiet_bi.Name = "Thiet_bi"
        Me.Thiet_bi.ReadOnly = True
        Me.Thiet_bi.Width = 250
        '
        'txtSucChua
        '
        Me.txtSucChua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSucChua.BackColor = System.Drawing.Color.Transparent
        Me.txtSucChua.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSucChua.ForeColor = System.Drawing.Color.Maroon
        Me.txtSucChua.Location = New System.Drawing.Point(748, 28)
        Me.txtSucChua.Name = "txtSucChua"
        Me.txtSucChua.Size = New System.Drawing.Size(46, 18)
        Me.txtSucChua.TabIndex = 33
        Me.txtSucChua.Text = "0"
        Me.txtSucChua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSoPhong
        '
        Me.txtSoPhong.BackColor = System.Drawing.Color.Transparent
        Me.txtSoPhong.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSoPhong.ForeColor = System.Drawing.Color.Maroon
        Me.txtSoPhong.Location = New System.Drawing.Point(380, 28)
        Me.txtSoPhong.Name = "txtSoPhong"
        Me.txtSoPhong.Size = New System.Drawing.Size(77, 18)
        Me.txtSoPhong.TabIndex = 32
        Me.txtSoPhong.Text = "0"
        Me.txtSoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNam
        '
        Me.lblNam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNam.BackColor = System.Drawing.Color.Transparent
        Me.lblNam.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNam.Location = New System.Drawing.Point(584, 28)
        Me.lblNam.Name = "lblNam"
        Me.lblNam.Size = New System.Drawing.Size(158, 18)
        Me.lblNam.TabIndex = 31
        Me.lblNam.Text = "Tổng số sức chứa:"
        Me.lblNam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_so
        '
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(263, 28)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(111, 18)
        Me.lblTong_so.TabIndex = 30
        Me.lblTong_so.Text = "Tổng số phòng:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_PhongHocList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.txtSucChua)
        Me.Controls.Add(Me.txtSoPhong)
        Me.Controls.Add(Me.lblNam)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.dgvPhongHoc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmESS_PhongHocList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách phòng học"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPhongHoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents trvPhongHoc As System.Windows.Forms.TreeView
    Friend WithEvents dgvPhongHoc As System.Windows.Forms.DataGridView
    Friend WithEvents txtSucChua As System.Windows.Forms.Label
    Friend WithEvents txtSoPhong As System.Windows.Forms.Label
    Friend WithEvents lblNam As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents ID_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ten_tang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Suc_chua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ten_loai_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thiet_bi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
