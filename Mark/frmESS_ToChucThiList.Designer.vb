<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThiList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list. 1
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
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.grdViewDanhSachThi = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.So_bao_danh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu_thi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.Label3 = New System.Windows.Forms.Label
        Me.trvPhongThi = New ESS_Mark.TreeViewPhongThi
        Me.btnToTucThi = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd_sv = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSua_CTThi = New DevExpress.XtraEditors.SimpleButton
        Me.btnXoa_TCT = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel_sv = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrint1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(867, 41)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(34, 18)
        Me.txtSo_sv.TabIndex = 53
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(733, 41)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(134, 18)
        Me.lblTong_so.TabIndex = 52
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(273, 31)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(98, 23)
        Me.chkAll.TabIndex = 58
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'grdViewDanhSachThi
        '
        Me.grdViewDanhSachThi.AllowUserToAddRows = False
        Me.grdViewDanhSachThi.AllowUserToDeleteRows = False
        Me.grdViewDanhSachThi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSachThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhSachThi.BackgroundColor = System.Drawing.Color.White
        Me.grdViewDanhSachThi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSachThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSachThi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.So_bao_danh, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.Ten_phong, Me.Ghi_chu_thi})
        Me.grdViewDanhSachThi.Location = New System.Drawing.Point(265, 62)
        Me.grdViewDanhSachThi.Name = "grdViewDanhSachThi"
        Me.grdViewDanhSachThi.RowHeadersVisible = False
        Me.grdViewDanhSachThi.Size = New System.Drawing.Size(636, 466)
        Me.grdViewDanhSachThi.TabIndex = 57
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Width = 67
        '
        'So_bao_danh
        '
        Me.So_bao_danh.DataPropertyName = "So_bao_danh"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_bao_danh.DefaultCellStyle = DataGridViewCellStyle1
        Me.So_bao_danh.HeaderText = "Số BD"
        Me.So_bao_danh.Name = "So_bao_danh"
        Me.So_bao_danh.ReadOnly = True
        Me.So_bao_danh.Width = 76
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ma_sv.HeaderText = "Mã sinh viên"
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 110
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ho_ten.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 93
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 94
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ten_lop.HeaderText = "Lớp"
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 59
        '
        'Ten_phong
        '
        Me.Ten_phong.DataPropertyName = "Ten_phong"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_phong.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ten_phong.HeaderText = "Phòng thi"
        Me.Ten_phong.Name = "Ten_phong"
        Me.Ten_phong.ReadOnly = True
        Me.Ten_phong.Width = 90
        '
        'Ghi_chu_thi
        '
        Me.Ghi_chu_thi.DataPropertyName = "Ghi_chu_thi"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ghi_chu_thi.DefaultCellStyle = DataGridViewCellStyle7
        Me.Ghi_chu_thi.HeaderText = "Ghi chú"
        Me.Ghi_chu_thi.Name = "Ghi_chu_thi"
        Me.Ghi_chu_thi.ReadOnly = True
        Me.Ghi_chu_thi.Width = 80
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(710, 26)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "DANH SÁCH TỔ CHỨC THI THEO KỲ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 41)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 487)
        Me.trvPhongThi.TabIndex = 54
        '
        'btnToTucThi
        '
        Me.btnToTucThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToTucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToTucThi.Appearance.Options.UseFont = True
        Me.btnToTucThi.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnToTucThi.ImageIndex = 22
        Me.btnToTucThi.Location = New System.Drawing.Point(5, 533)
        Me.btnToTucThi.Name = "btnToTucThi"
        Me.btnToTucThi.Size = New System.Drawing.Size(96, 30)
        Me.btnToTucThi.TabIndex = 178
        Me.btnToTucThi.Text = "Tổ chức thi"
        '
        'btnAdd_sv
        '
        Me.btnAdd_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_sv.Appearance.Options.UseFont = True
        Me.btnAdd_sv.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd_sv.ImageIndex = 22
        Me.btnAdd_sv.Location = New System.Drawing.Point(102, 533)
        Me.btnAdd_sv.Name = "btnAdd_sv"
        Me.btnAdd_sv.Size = New System.Drawing.Size(89, 30)
        Me.btnAdd_sv.TabIndex = 179
        Me.btnAdd_sv.Text = "Bổ sung sv"
        '
        'cmdSua_CTThi
        '
        Me.cmdSua_CTThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSua_CTThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSua_CTThi.Appearance.Options.UseFont = True
        Me.cmdSua_CTThi.Image = Global.ESS_Mark.My.Resources.Resources.Edit
        Me.cmdSua_CTThi.ImageIndex = 22
        Me.cmdSua_CTThi.Location = New System.Drawing.Point(193, 533)
        Me.cmdSua_CTThi.Name = "cmdSua_CTThi"
        Me.cmdSua_CTThi.Size = New System.Drawing.Size(108, 30)
        Me.cmdSua_CTThi.TabIndex = 180
        Me.cmdSua_CTThi.Text = "Sửa chi tiết thi"
        '
        'btnXoa_TCT
        '
        Me.btnXoa_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXoa_TCT.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_TCT.Appearance.Options.UseFont = True
        Me.btnXoa_TCT.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnXoa_TCT.ImageIndex = 22
        Me.btnXoa_TCT.Location = New System.Drawing.Point(304, 533)
        Me.btnXoa_TCT.Name = "btnXoa_TCT"
        Me.btnXoa_TCT.Size = New System.Drawing.Size(114, 30)
        Me.btnXoa_TCT.TabIndex = 181
        Me.btnXoa_TCT.Text = "Xóa tổ chức thi"
        '
        'btnDel_sv
        '
        Me.btnDel_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel_sv.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel_sv.Appearance.Options.UseFont = True
        Me.btnDel_sv.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnDel_sv.ImageIndex = 22
        Me.btnDel_sv.Location = New System.Drawing.Point(420, 533)
        Me.btnDel_sv.Name = "btnDel_sv"
        Me.btnDel_sv.Size = New System.Drawing.Size(103, 30)
        Me.btnDel_sv.TabIndex = 182
        Me.btnDel_sv.Text = "Xóa sinh viên"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(525, 533)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(94, 30)
        Me.btnExcel.TabIndex = 183
        Me.btnExcel.Text = "Xuất Excel"
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Appearance.Options.UseFont = True
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageIndex = 22
        Me.btnPrint1.Location = New System.Drawing.Point(620, 533)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(119, 30)
        Me.btnPrint1.TabIndex = 184
        Me.btnPrint1.Text = "In DS phòng thi"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(745, 533)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 30)
        Me.btnThoat.TabIndex = 182
        Me.btnThoat.Text = "Thoát"
        '
        'frmESS_ToChucThiList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(902, 566)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDel_sv)
        Me.Controls.Add(Me.btnXoa_TCT)
        Me.Controls.Add(Me.cmdSua_CTThi)
        Me.Controls.Add(Me.btnAdd_sv)
        Me.Controls.Add(Me.btnToTucThi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.grdViewDanhSachThi)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_ToChucThiList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH TO CHUC THI THEO KY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents trvPhongThi As ESS_Mark.TreeViewPhongThi
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewDanhSachThi As System.Windows.Forms.DataGridView
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents So_bao_danh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu_thi As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnToTucThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSua_CTThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa_TCT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel_sv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
