<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopNoChungChi_
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmbPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmbID_chung_chi1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdViewChungChiNganh12 = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.optAllNganh12 = New System.Windows.Forms.CheckBox
        Me.optAllNganh11 = New System.Windows.Forms.CheckBox
        Me.btnThem1 = New System.Windows.Forms.Button
        Me.btnXoa1 = New System.Windows.Forms.Button
        Me.grdViewChungChiNganh11 = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLan_xet1 = New System.Windows.Forms.ComboBox
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.rGDTC = New System.Windows.Forms.RadioButton
        Me.rGDQP = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.trvLop1 = New ESS_Mark.TrvLop_ChuanHoa
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewChungChiNganh12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewChungChiNganh11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTongHop, Me.cmbPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 541)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(818, 25)
        Me.ToolStrip.TabIndex = 135
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
        'cmbPrint
        '
        Me.cmbPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.cmbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(94, 22)
        Me.cmbPrint.Text = "In báo cáo"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmbID_chung_chi1
        '
        Me.cmbID_chung_chi1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_chung_chi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chung_chi1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbID_chung_chi1.Location = New System.Drawing.Point(541, 29)
        Me.cmbID_chung_chi1.Name = "cmbID_chung_chi1"
        Me.cmbID_chung_chi1.Size = New System.Drawing.Size(171, 24)
        Me.cmbID_chung_chi1.TabIndex = 146
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Loại chứng chỉ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdViewChungChiNganh12
        '
        Me.grdViewChungChiNganh12.AllowUserToAddRows = False
        Me.grdViewChungChiNganh12.AllowUserToDeleteRows = False
        Me.grdViewChungChiNganh12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewChungChiNganh12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewChungChiNganh12.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChungChiNganh12.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grdViewChungChiNganh12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewChungChiNganh12.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.grdViewChungChiNganh12.Location = New System.Drawing.Point(255, 340)
        Me.grdViewChungChiNganh12.Name = "grdViewChungChiNganh12"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChungChiNganh12.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.grdViewChungChiNganh12.RowHeadersWidth = 30
        Me.grdViewChungChiNganh12.Size = New System.Drawing.Size(561, 198)
        Me.grdViewChungChiNganh12.TabIndex = 145
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Chon"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Chọn"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 50
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mã SV"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 220
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 90
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TBCHT"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn10.HeaderText = "TBC chứng chỉ"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Xep_hang"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn11.HeaderText = "Xếp loại"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 110
        '
        'optAllNganh12
        '
        Me.optAllNganh12.BackColor = System.Drawing.Color.Transparent
        Me.optAllNganh12.Location = New System.Drawing.Point(304, 316)
        Me.optAllNganh12.Name = "optAllNganh12"
        Me.optAllNganh12.Size = New System.Drawing.Size(102, 19)
        Me.optAllNganh12.TabIndex = 144
        Me.optAllNganh12.Text = "Chọn tất cả "
        Me.optAllNganh12.UseVisualStyleBackColor = False
        '
        'optAllNganh11
        '
        Me.optAllNganh11.BackColor = System.Drawing.Color.Transparent
        Me.optAllNganh11.Location = New System.Drawing.Point(286, 58)
        Me.optAllNganh11.Name = "optAllNganh11"
        Me.optAllNganh11.Size = New System.Drawing.Size(102, 19)
        Me.optAllNganh11.TabIndex = 143
        Me.optAllNganh11.Text = "Chọn tất cả "
        Me.optAllNganh11.UseVisualStyleBackColor = False
        '
        'btnThem1
        '
        Me.btnThem1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem1.BackColor = System.Drawing.Color.Transparent
        Me.btnThem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThem1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem1.ForeColor = System.Drawing.Color.Brown
        Me.btnThem1.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnThem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem1.Location = New System.Drawing.Point(686, 313)
        Me.btnThem1.Name = "btnThem1"
        Me.btnThem1.Size = New System.Drawing.Size(63, 25)
        Me.btnThem1.TabIndex = 142
        Me.btnThem1.Text = "Thêm"
        Me.btnThem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem1.UseVisualStyleBackColor = False
        '
        'btnXoa1
        '
        Me.btnXoa1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoa1.BackColor = System.Drawing.Color.Transparent
        Me.btnXoa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnXoa1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa1.ForeColor = System.Drawing.Color.Brown
        Me.btnXoa1.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnXoa1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa1.Location = New System.Drawing.Point(751, 313)
        Me.btnXoa1.Name = "btnXoa1"
        Me.btnXoa1.Size = New System.Drawing.Size(58, 25)
        Me.btnXoa1.TabIndex = 141
        Me.btnXoa1.Text = "Xoá"
        Me.btnXoa1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa1.UseVisualStyleBackColor = False
        '
        'grdViewChungChiNganh11
        '
        Me.grdViewChungChiNganh11.AllowUserToAddRows = False
        Me.grdViewChungChiNganh11.AllowUserToDeleteRows = False
        Me.grdViewChungChiNganh11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewChungChiNganh11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewChungChiNganh11.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChungChiNganh11.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.grdViewChungChiNganh11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewChungChiNganh11.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.grdViewChungChiNganh11.Location = New System.Drawing.Point(255, 78)
        Me.grdViewChungChiNganh11.Name = "grdViewChungChiNganh11"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChungChiNganh11.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.grdViewChungChiNganh11.RowHeadersWidth = 30
        Me.grdViewChungChiNganh11.Size = New System.Drawing.Size(561, 232)
        Me.grdViewChungChiNganh11.TabIndex = 140
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Chon"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Chọn"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 50
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn13.HeaderText = "Mã SV"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 120
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 220
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 90
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 90
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TBCHT"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn17.HeaderText = "TBC chứng chỉ"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 120
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Xep_hang"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn18.HeaderText = "Xếp loại"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 110
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(714, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "Lần xét:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSo_sv
        '
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(366, 30)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(40, 23)
        Me.labSo_sv.TabIndex = 137
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(191, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 23)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Tống số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_xet1
        '
        Me.cmbLan_xet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_xet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_xet1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbLan_xet1.Location = New System.Drawing.Point(774, 29)
        Me.cmbLan_xet1.Name = "cmbLan_xet1"
        Me.cmbLan_xet1.Size = New System.Drawing.Size(41, 24)
        Me.cmbLan_xet1.TabIndex = 148
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'rGDTC
        '
        Me.rGDTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rGDTC.AutoSize = True
        Me.rGDTC.BackColor = System.Drawing.Color.Transparent
        Me.rGDTC.Checked = True
        Me.rGDTC.Location = New System.Drawing.Point(509, 57)
        Me.rGDTC.Name = "rGDTC"
        Me.rGDTC.Size = New System.Drawing.Size(129, 20)
        Me.rGDTC.TabIndex = 149
        Me.rGDTC.TabStop = True
        Me.rGDTC.Text = "Giáo dục thể chất"
        Me.rGDTC.UseVisualStyleBackColor = False
        '
        'rGDQP
        '
        Me.rGDQP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rGDQP.AutoSize = True
        Me.rGDQP.BackColor = System.Drawing.Color.Transparent
        Me.rGDQP.Location = New System.Drawing.Point(667, 57)
        Me.rGDQP.Name = "rGDQP"
        Me.rGDQP.Size = New System.Drawing.Size(149, 20)
        Me.rGDQP.TabIndex = 150
        Me.rGDQP.Text = "Giáo dục quốc phòng"
        Me.rGDQP.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(597, 26)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "XÉT CẤP CHỨNG CHỈ CHO SINH VIÊN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trvLop1
        '
        Me.trvLop1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop1.BackColor = System.Drawing.Color.Transparent
        Me.trvLop1.dtLop = Nothing
        Me.trvLop1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trvLop1.Location = New System.Drawing.Point(0, 0)
        Me.trvLop1.Margin = New System.Windows.Forms.Padding(4)
        Me.trvLop1.Name = "trvLop1"
        Me.trvLop1.Size = New System.Drawing.Size(248, 537)
        Me.trvLop1.TabIndex = 152
        '
        'frmESS_TongHopNoChungChi_
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(818, 566)
        Me.Controls.Add(Me.trvLop1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rGDQP)
        Me.Controls.Add(Me.rGDTC)
        Me.Controls.Add(Me.cmbLan_xet1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.cmbID_chung_chi1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdViewChungChiNganh12)
        Me.Controls.Add(Me.optAllNganh12)
        Me.Controls.Add(Me.optAllNganh11)
        Me.Controls.Add(Me.btnThem1)
        Me.Controls.Add(Me.btnXoa1)
        Me.Controls.Add(Me.grdViewChungChiNganh11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.labSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmESS_TongHopNoChungChi_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XET CHUNG CHI SINH VIEN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewChungChiNganh12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewChungChiNganh11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbID_chung_chi1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdViewChungChiNganh12 As System.Windows.Forms.DataGridView
    Friend WithEvents optAllNganh12 As System.Windows.Forms.CheckBox
    Friend WithEvents optAllNganh11 As System.Windows.Forms.CheckBox
    Friend WithEvents btnThem1 As System.Windows.Forms.Button
    Friend WithEvents btnXoa1 As System.Windows.Forms.Button
    Friend WithEvents grdViewChungChiNganh11 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_xet1 As System.Windows.Forms.ComboBox
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents rGDTC As System.Windows.Forms.RadioButton
    Friend WithEvents rGDQP As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents trvLop1 As ESS_Mark.TrvLop_ChuanHoa
End Class
