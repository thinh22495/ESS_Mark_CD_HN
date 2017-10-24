<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopHocTapNam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TongHopHocTapNam))
        Me.fgTongHopKy = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.chkThanh_phan = New System.Windows.Forms.CheckBox
        Me.chkGhi_chu = New System.Windows.Forms.CheckBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.optTenMon = New System.Windows.Forms.RadioButton
        Me.optKyHieu = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnPrint1 = New System.Windows.Forms.Button
        Me.btnXoa_TCT = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.btnTongHop = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTu_diem = New System.Windows.Forms.TextBox
        Me.txtDen_diem = New System.Windows.Forms.TextBox
        Me.ckLoc_theo_DTBCHT = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnIn_BC_DRL = New System.Windows.Forms.Button
        Me.ckTBMH_5 = New System.Windows.Forms.CheckBox
        Me.ckThi_5 = New System.Windows.Forms.CheckBox
        Me.ckMonVanHoa = New System.Windows.Forms.CheckBox
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgTongHopKy
        '
        Me.fgTongHopKy.AllowEditing = False
        Me.fgTongHopKy.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fgTongHopKy.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fgTongHopKy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTongHopKy.BackColor = System.Drawing.Color.White
        Me.fgTongHopKy.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.fgTongHopKy.Cols = New C1.Win.C1FlexGrid.ColumnCollection(10, 1, 0, 0, 0, 110, "")
        Me.fgTongHopKy.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgTongHopKy.Location = New System.Drawing.Point(264, 117)
        Me.fgTongHopKy.Name = "fgTongHopKy"
        Me.fgTongHopKy.Rows.Count = 0
        Me.fgTongHopKy.Rows.Fixed = 0
        Me.fgTongHopKy.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopKy.Size = New System.Drawing.Size(1017, 416)
        Me.fgTongHopKy.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopKy.Styles"))
        Me.fgTongHopKy.TabIndex = 120
        '
        'chkThanh_phan
        '
        Me.chkThanh_phan.AutoSize = True
        Me.chkThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.chkThanh_phan.Location = New System.Drawing.Point(458, 65)
        Me.chkThanh_phan.Name = "chkThanh_phan"
        Me.chkThanh_phan.Size = New System.Drawing.Size(176, 23)
        Me.chkThanh_phan.TabIndex = 126
        Me.chkThanh_phan.Text = "Hiển thị điểm thành phần"
        Me.chkThanh_phan.UseVisualStyleBackColor = False
        '
        'chkGhi_chu
        '
        Me.chkGhi_chu.AutoSize = True
        Me.chkGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.chkGhi_chu.Location = New System.Drawing.Point(294, 66)
        Me.chkGhi_chu.Name = "chkGhi_chu"
        Me.chkGhi_chu.Size = New System.Drawing.Size(153, 23)
        Me.chkGhi_chu.TabIndex = 125
        Me.chkGhi_chu.Text = "Hiển thị ghi chú điểm"
        Me.chkGhi_chu.UseVisualStyleBackColor = False
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(366, 33)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(119, 27)
        Me.cmbNam_hoc.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(1097, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(1197, 22)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(75, 27)
        Me.cmbKho_giay.TabIndex = 124
        Me.cmbKho_giay.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(508, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"Lần 1", "Cao nhất"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(569, 33)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(140, 27)
        Me.cmbLan_thi.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(285, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optTenMon
        '
        Me.optTenMon.AutoSize = True
        Me.optTenMon.BackColor = System.Drawing.Color.Transparent
        Me.optTenMon.Checked = True
        Me.optTenMon.Location = New System.Drawing.Point(458, 88)
        Me.optTenMon.Name = "optTenMon"
        Me.optTenMon.Size = New System.Drawing.Size(110, 23)
        Me.optTenMon.TabIndex = 128
        Me.optTenMon.TabStop = True
        Me.optTenMon.Text = "Theo tên môn"
        Me.optTenMon.UseVisualStyleBackColor = False
        '
        'optKyHieu
        '
        Me.optKyHieu.AutoSize = True
        Me.optKyHieu.BackColor = System.Drawing.Color.Transparent
        Me.optKyHieu.Location = New System.Drawing.Point(294, 88)
        Me.optKyHieu.Name = "optKyHieu"
        Me.optKyHieu.Size = New System.Drawing.Size(104, 23)
        Me.optKyHieu.TabIndex = 127
        Me.optKyHieu.Text = "Ký hiệu môn"
        Me.optKyHieu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.ChuyenLop
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(479, 535)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 28)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "Phân loại KQHT học phần"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(980, 536)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(110, 28)
        Me.btnExcel.TabIndex = 139
        Me.btnExcel.Text = "Xuất Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint1.Location = New System.Drawing.Point(259, 535)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(96, 29)
        Me.btnPrint1.TabIndex = 138
        Me.btnPrint1.Text = "In báo cáo"
        Me.btnPrint1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint1.UseVisualStyleBackColor = True
        Me.btnPrint1.Visible = False
        '
        'btnXoa_TCT
        '
        Me.btnXoa_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoa_TCT.Image = Global.ESS_Mark.My.Resources.Resources.ChuyenLop
        Me.btnXoa_TCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa_TCT.Location = New System.Drawing.Point(322, 535)
        Me.btnXoa_TCT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa_TCT.Name = "btnXoa_TCT"
        Me.btnXoa_TCT.Size = New System.Drawing.Size(157, 28)
        Me.btnXoa_TCT.TabIndex = 137
        Me.btnXoa_TCT.Text = "Phân loại KQHT lớp"
        Me.btnXoa_TCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa_TCT.UseVisualStyleBackColor = True
        Me.btnXoa_TCT.Visible = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(1195, 536)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 136
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnTongHop
        '
        Me.btnTongHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTongHop.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnTongHop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTongHop.Location = New System.Drawing.Point(882, 536)
        Me.btnTongHop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTongHop.Name = "btnTongHop"
        Me.btnTongHop.Size = New System.Drawing.Size(97, 28)
        Me.btnTongHop.TabIndex = 135
        Me.btnTongHop.Text = "Tổng hợp"
        Me.btnTongHop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTongHop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(265, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(952, 26)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "TỔNG HỢP KẾT QUẢ HỌC TẬP THEO NĂM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTu_diem
        '
        Me.txtTu_diem.Location = New System.Drawing.Point(886, 61)
        Me.txtTu_diem.Name = "txtTu_diem"
        Me.txtTu_diem.Size = New System.Drawing.Size(50, 26)
        Me.txtTu_diem.TabIndex = 146
        '
        'txtDen_diem
        '
        Me.txtDen_diem.Location = New System.Drawing.Point(1017, 61)
        Me.txtDen_diem.Name = "txtDen_diem"
        Me.txtDen_diem.Size = New System.Drawing.Size(50, 26)
        Me.txtDen_diem.TabIndex = 147
        '
        'ckLoc_theo_DTBCHT
        '
        Me.ckLoc_theo_DTBCHT.AutoSize = True
        Me.ckLoc_theo_DTBCHT.BackColor = System.Drawing.Color.Transparent
        Me.ckLoc_theo_DTBCHT.Location = New System.Drawing.Point(640, 64)
        Me.ckLoc_theo_DTBCHT.Name = "ckLoc_theo_DTBCHT"
        Me.ckLoc_theo_DTBCHT.Size = New System.Drawing.Size(169, 23)
        Me.ckLoc_theo_DTBCHT.TabIndex = 145
        Me.ckLoc_theo_DTBCHT.Text = "Lọc theo điểm TBCHT"
        Me.ckLoc_theo_DTBCHT.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(817, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Từ điểm:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(940, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Đến điểm:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIn_BC_DRL
        '
        Me.btnIn_BC_DRL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn_BC_DRL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_BC_DRL.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnIn_BC_DRL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIn_BC_DRL.Location = New System.Drawing.Point(1094, 536)
        Me.btnIn_BC_DRL.Name = "btnIn_BC_DRL"
        Me.btnIn_BC_DRL.Size = New System.Drawing.Size(99, 28)
        Me.btnIn_BC_DRL.TabIndex = 148
        Me.btnIn_BC_DRL.Text = "In báo cáo"
        Me.btnIn_BC_DRL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIn_BC_DRL.UseVisualStyleBackColor = True
        '
        'ckTBMH_5
        '
        Me.ckTBMH_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckTBMH_5.AutoSize = True
        Me.ckTBMH_5.BackColor = System.Drawing.Color.Transparent
        Me.ckTBMH_5.Location = New System.Drawing.Point(821, 93)
        Me.ckTBMH_5.Name = "ckTBMH_5"
        Me.ckTBMH_5.Size = New System.Drawing.Size(145, 23)
        Me.ckTBMH_5.TabIndex = 150
        Me.ckTBMH_5.Text = "Lọc TBCMH >= 5"
        Me.ckTBMH_5.UseVisualStyleBackColor = False
        '
        'ckThi_5
        '
        Me.ckThi_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckThi_5.AutoSize = True
        Me.ckThi_5.BackColor = System.Drawing.Color.Transparent
        Me.ckThi_5.Location = New System.Drawing.Point(640, 93)
        Me.ckThi_5.Name = "ckThi_5"
        Me.ckThi_5.Size = New System.Drawing.Size(137, 23)
        Me.ckThi_5.TabIndex = 149
        Me.ckThi_5.Text = "Lọc điểm thi >= 5"
        Me.ckThi_5.UseVisualStyleBackColor = False
        '
        'ckMonVanHoa
        '
        Me.ckMonVanHoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckMonVanHoa.AutoSize = True
        Me.ckMonVanHoa.Location = New System.Drawing.Point(715, 34)
        Me.ckMonVanHoa.Name = "ckMonVanHoa"
        Me.ckMonVanHoa.Size = New System.Drawing.Size(108, 23)
        Me.ckMonVanHoa.TabIndex = 151
        Me.ckMonVanHoa.Text = "Môn văn hóa"
        Me.ckMonVanHoa.UseVisualStyleBackColor = True
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(-1, -1)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 534)
        Me.TrvLop_ChuanHoa.TabIndex = 142
        '
        'frmESS_TongHopHocTapNam
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1280, 566)
        Me.Controls.Add(Me.ckMonVanHoa)
        Me.Controls.Add(Me.ckTBMH_5)
        Me.Controls.Add(Me.ckThi_5)
        Me.Controls.Add(Me.btnIn_BC_DRL)
        Me.Controls.Add(Me.txtTu_diem)
        Me.Controls.Add(Me.txtDen_diem)
        Me.Controls.Add(Me.ckLoc_theo_DTBCHT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnXoa_TCT)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnTongHop)
        Me.Controls.Add(Me.optTenMon)
        Me.Controls.Add(Me.optKyHieu)
        Me.Controls.Add(Me.fgTongHopKy)
        Me.Controls.Add(Me.chkThanh_phan)
        Me.Controls.Add(Me.chkGhi_chu)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_TongHopHocTapNam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TONG HOP KQHT NAM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkThanh_phan As System.Windows.Forms.CheckBox
    Friend WithEvents chkGhi_chu As System.Windows.Forms.CheckBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fgTongHopKy As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents optTenMon As System.Windows.Forms.RadioButton
    Friend WithEvents optKyHieu As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnXoa_TCT As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnTongHop As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents txtTu_diem As System.Windows.Forms.TextBox
    Friend WithEvents txtDen_diem As System.Windows.Forms.TextBox
    Friend WithEvents ckLoc_theo_DTBCHT As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnIn_BC_DRL As System.Windows.Forms.Button
    Friend WithEvents ckTBMH_5 As System.Windows.Forms.CheckBox
    Friend WithEvents ckThi_5 As System.Windows.Forms.CheckBox
    Friend WithEvents ckMonVanHoa As System.Windows.Forms.CheckBox
End Class
