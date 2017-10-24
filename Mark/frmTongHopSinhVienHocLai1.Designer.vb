<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTongHopSinhVienHocLai1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrint_Mon = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_Chitiet = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbExcel = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdExcel_Mon = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExcel_Chitiet = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewDanhSachMon = New System.Windows.Forms.DataGridView
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewDanhsachChitiet = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHienThi = New System.Windows.Forms.ComboBox
        Me.TreeViewLop_NEW1 = New ESS_Mark.TreeViewLop_NEW
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(444, 31)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(113, 24)
        Me.cmbNam_hoc.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(370, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(265, 31)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 113
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(326, 31)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(38, 24)
        Me.cmbHoc_ky.TabIndex = 114
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTongHop, Me.cmdPrint, Me.cmbExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 111
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Image = Global.ESS_Mark.My.Resources.Resources.Import
        Me.cmdTongHop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(90, 22)
        Me.cmdTongHop.Text = "Tổng hợp"
        '
        'cmdPrint
        '
        Me.cmdPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint_Mon, Me.cmdPrint_Chitiet})
        Me.cmdPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(103, 22)
        Me.cmdPrint.Text = "In báo cáo"
        '
        'cmdPrint_Mon
        '
        Me.cmdPrint_Mon.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint_Mon.Name = "cmdPrint_Mon"
        Me.cmdPrint_Mon.Size = New System.Drawing.Size(204, 22)
        Me.cmdPrint_Mon.Text = "Danh sách môn"
        '
        'cmdPrint_Chitiet
        '
        Me.cmdPrint_Chitiet.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmdPrint_Chitiet.Name = "cmdPrint_Chitiet"
        Me.cmdPrint_Chitiet.Size = New System.Drawing.Size(204, 22)
        Me.cmdPrint_Chitiet.Text = "Danh sách sinh viên"
        '
        'cmbExcel
        '
        Me.cmbExcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExcel_Mon, Me.cmdExcel_Chitiet})
        Me.cmbExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.cmbExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExcel.Name = "cmbExcel"
        Me.cmbExcel.Size = New System.Drawing.Size(102, 22)
        Me.cmbExcel.Text = "Xuất Excel"
        '
        'cmdExcel_Mon
        '
        Me.cmdExcel_Mon.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.cmdExcel_Mon.Name = "cmdExcel_Mon"
        Me.cmdExcel_Mon.Size = New System.Drawing.Size(204, 22)
        Me.cmdExcel_Mon.Text = "Danh sách môn"
        '
        'cmdExcel_Chitiet
        '
        Me.cmdExcel_Chitiet.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.cmdExcel_Chitiet.Name = "cmdExcel_Chitiet"
        Me.cmdExcel_Chitiet.Size = New System.Drawing.Size(204, 22)
        Me.cmdExcel_Chitiet.Text = "Danh sách sinh viên"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewDanhSachMon
        '
        Me.grdViewDanhSachMon.AllowUserToAddRows = False
        Me.grdViewDanhSachMon.AllowUserToDeleteRows = False
        Me.grdViewDanhSachMon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSachMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhSachMon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSachMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ky_hieu, Me.Ten_mon, Me.So_hoc_trinh, Me.So_sv})
        Me.grdViewDanhSachMon.Location = New System.Drawing.Point(266, 60)
        Me.grdViewDanhSachMon.Name = "grdViewDanhSachMon"
        Me.grdViewDanhSachMon.RowHeadersVisible = False
        Me.grdViewDanhSachMon.Size = New System.Drawing.Size(526, 275)
        Me.grdViewDanhSachMon.TabIndex = 117
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.Ky_hieu.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ky_hieu.Frozen = True
        Me.Ky_hieu.HeaderText = "Mã môn học"
        Me.Ky_hieu.MinimumWidth = 130
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 130
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_mon.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ten_mon.HeaderText = "Tên môn học"
        Me.Ten_mon.MinimumWidth = 300
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 300
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.DataPropertyName = "So_hoc_trinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_hoc_trinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_hoc_trinh.HeaderText = "Số học trình"
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.ReadOnly = True
        Me.So_hoc_trinh.Width = 110
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_sv.DefaultCellStyle = DataGridViewCellStyle4
        Me.So_sv.HeaderText = "Số SV"
        Me.So_sv.MinimumWidth = 100
        Me.So_sv.Name = "So_sv"
        Me.So_sv.ReadOnly = True
        '
        'grdViewDanhsachChitiet
        '
        Me.grdViewDanhsachChitiet.AllowUserToAddRows = False
        Me.grdViewDanhsachChitiet.AllowUserToDeleteRows = False
        Me.grdViewDanhsachChitiet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhsachChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhsachChitiet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhsachChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhsachChitiet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.grdViewDanhsachChitiet.Location = New System.Drawing.Point(266, 341)
        Me.grdViewDanhsachChitiet.Name = "grdViewDanhsachChitiet"
        Me.grdViewDanhsachChitiet.RowHeadersVisible = False
        Me.grdViewDanhsachChitiet.Size = New System.Drawing.Size(526, 225)
        Me.grdViewDanhsachChitiet.TabIndex = 118
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 300
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(564, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Hiển thị theo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.UseWaitCursor = True
        Me.Label2.Visible = False
        '
        'cmbHienThi
        '
        Me.cmbHienThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHienThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHienThi.Items.AddRange(New Object() {"Thi lại", "Học lại"})
        Me.cmbHienThi.Location = New System.Drawing.Point(661, 31)
        Me.cmbHienThi.Name = "cmbHienThi"
        Me.cmbHienThi.Size = New System.Drawing.Size(127, 24)
        Me.cmbHienThi.TabIndex = 120
        Me.cmbHienThi.UseWaitCursor = True
        Me.cmbHienThi.Visible = False
        '
        'TreeViewLop_NEW1
        '
        Me.TreeViewLop_NEW1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop_NEW1.dtLop = Nothing
        Me.TreeViewLop_NEW1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewLop_NEW1.Location = New System.Drawing.Point(-2, 24)
        Me.TreeViewLop_NEW1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeViewLop_NEW1.Name = "TreeViewLop_NEW1"
        Me.TreeViewLop_NEW1.Size = New System.Drawing.Size(267, 538)
        Me.TreeViewLop_NEW1.TabIndex = 121
        '
        'frmTongHopSinhVienHocLai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.TreeViewLop_NEW1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbHienThi)
        Me.Controls.Add(Me.grdViewDanhsachChitiet)
        Me.Controls.Add(Me.grdViewDanhSachMon)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTongHopSinhVienHocLai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTongHopSinhVienThiLai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhSachMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhsachChitiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewDanhSachMon As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewDanhsachChitiet As System.Windows.Forms.DataGridView
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdPrint_Mon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_Chitiet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbExcel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdExcel_Mon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExcel_Chitiet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbHienThi As System.Windows.Forms.ComboBox
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreeViewLop_NEW1 As ESS_Mark.TreeViewLop_NEW
End Class
