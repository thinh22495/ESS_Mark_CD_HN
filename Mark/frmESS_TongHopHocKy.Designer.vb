<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopHocKy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TongHopHocKy))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.fgTongHopKy = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.chkGhi_chu = New System.Windows.Forms.CheckBox
        Me.chkThanh_phan = New System.Windows.Forms.CheckBox
        Me.optKyHieu = New System.Windows.Forms.RadioButton
        Me.optTenMon = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDen_diem = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTu_diem = New System.Windows.Forms.TextBox
        Me.ckLoc_theo_DTBCHT = New System.Windows.Forms.CheckBox
        Me.ckThi_5 = New System.Windows.Forms.CheckBox
        Me.ckTBMH_5 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnIn_BC_DRL = New System.Windows.Forms.Button
        Me.btnPrint1 = New System.Windows.Forms.Button
        Me.btnXoa_TCT = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.btnTongHop = New System.Windows.Forms.Button
        Me.btnDS_no_mon = New System.Windows.Forms.Button
        Me.ckMonVanHoa = New System.Windows.Forms.CheckBox
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(383, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(464, 30)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(119, 27)
        Me.cmbNam_hoc.TabIndex = 99
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(265, 30)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 96
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(331, 30)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(50, 27)
        Me.cmbHoc_ky.TabIndex = 97
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
        Me.fgTongHopKy.Location = New System.Drawing.Point(264, 116)
        Me.fgTongHopKy.Name = "fgTongHopKy"
        Me.fgTongHopKy.Rows.Count = 0
        Me.fgTongHopKy.Rows.Fixed = 0
        Me.fgTongHopKy.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopKy.Size = New System.Drawing.Size(975, 418)
        Me.fgTongHopKy.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopKy.Styles"))
        Me.fgTongHopKy.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(605, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"Lần 1", "Cao nhất"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(666, 30)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(78, 27)
        Me.cmbLan_thi.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(1076, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(1155, 30)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(75, 27)
        Me.cmbKho_giay.TabIndex = 108
        Me.cmbKho_giay.Visible = False
        '
        'chkGhi_chu
        '
        Me.chkGhi_chu.AutoSize = True
        Me.chkGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.chkGhi_chu.Location = New System.Drawing.Point(294, 63)
        Me.chkGhi_chu.Name = "chkGhi_chu"
        Me.chkGhi_chu.Size = New System.Drawing.Size(153, 23)
        Me.chkGhi_chu.TabIndex = 112
        Me.chkGhi_chu.Text = "Hiển thị ghi chú điểm"
        Me.chkGhi_chu.UseVisualStyleBackColor = False
        '
        'chkThanh_phan
        '
        Me.chkThanh_phan.AutoSize = True
        Me.chkThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.chkThanh_phan.Location = New System.Drawing.Point(458, 62)
        Me.chkThanh_phan.Name = "chkThanh_phan"
        Me.chkThanh_phan.Size = New System.Drawing.Size(176, 23)
        Me.chkThanh_phan.TabIndex = 113
        Me.chkThanh_phan.Text = "Hiển thị điểm thành phần"
        Me.chkThanh_phan.UseVisualStyleBackColor = False
        '
        'optKyHieu
        '
        Me.optKyHieu.AutoSize = True
        Me.optKyHieu.BackColor = System.Drawing.Color.Transparent
        Me.optKyHieu.Location = New System.Drawing.Point(294, 86)
        Me.optKyHieu.Name = "optKyHieu"
        Me.optKyHieu.Size = New System.Drawing.Size(104, 23)
        Me.optKyHieu.TabIndex = 114
        Me.optKyHieu.Text = "Ký hiệu môn"
        Me.optKyHieu.UseVisualStyleBackColor = False
        '
        'optTenMon
        '
        Me.optTenMon.AutoSize = True
        Me.optTenMon.BackColor = System.Drawing.Color.Transparent
        Me.optTenMon.Checked = True
        Me.optTenMon.Location = New System.Drawing.Point(458, 86)
        Me.optTenMon.Name = "optTenMon"
        Me.optTenMon.Size = New System.Drawing.Size(110, 23)
        Me.optTenMon.TabIndex = 115
        Me.optTenMon.TabStop = True
        Me.optTenMon.Text = "Theo tên môn"
        Me.optTenMon.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, -1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(860, 26)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "TỔNG HỢP KẾT QUẢ HỌC TẬP THEO KỲ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDen_diem
        '
        Me.txtDen_diem.Location = New System.Drawing.Point(841, 83)
        Me.txtDen_diem.Name = "txtDen_diem"
        Me.txtDen_diem.Size = New System.Drawing.Size(50, 26)
        Me.txtDen_diem.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(764, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Đến điểm:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(641, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Từ điểm:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTu_diem
        '
        Me.txtTu_diem.Location = New System.Drawing.Point(710, 83)
        Me.txtTu_diem.Name = "txtTu_diem"
        Me.txtTu_diem.Size = New System.Drawing.Size(50, 26)
        Me.txtTu_diem.TabIndex = 138
        '
        'ckLoc_theo_DTBCHT
        '
        Me.ckLoc_theo_DTBCHT.AutoSize = True
        Me.ckLoc_theo_DTBCHT.BackColor = System.Drawing.Color.Transparent
        Me.ckLoc_theo_DTBCHT.Location = New System.Drawing.Point(640, 63)
        Me.ckLoc_theo_DTBCHT.Name = "ckLoc_theo_DTBCHT"
        Me.ckLoc_theo_DTBCHT.Size = New System.Drawing.Size(169, 23)
        Me.ckLoc_theo_DTBCHT.TabIndex = 113
        Me.ckLoc_theo_DTBCHT.Text = "Lọc theo điểm TBCHT"
        Me.ckLoc_theo_DTBCHT.UseVisualStyleBackColor = False
        '
        'ckThi_5
        '
        Me.ckThi_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckThi_5.AutoSize = True
        Me.ckThi_5.BackColor = System.Drawing.Color.Transparent
        Me.ckThi_5.Location = New System.Drawing.Point(1093, 62)
        Me.ckThi_5.Name = "ckThi_5"
        Me.ckThi_5.Size = New System.Drawing.Size(137, 23)
        Me.ckThi_5.TabIndex = 113
        Me.ckThi_5.Text = "Lọc điểm thi >= 5"
        Me.ckThi_5.UseVisualStyleBackColor = False
        '
        'ckTBMH_5
        '
        Me.ckTBMH_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckTBMH_5.AutoSize = True
        Me.ckTBMH_5.BackColor = System.Drawing.Color.Transparent
        Me.ckTBMH_5.Location = New System.Drawing.Point(1093, 87)
        Me.ckTBMH_5.Name = "ckTBMH_5"
        Me.ckTBMH_5.Size = New System.Drawing.Size(145, 23)
        Me.ckTBMH_5.TabIndex = 113
        Me.ckTBMH_5.Text = "Lọc TBCMH >= 5"
        Me.ckTBMH_5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(199, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 28)
        Me.Button2.TabIndex = 137
        Me.Button2.Text = "DS Xét HB"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.ChuyenLop
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(449, 536)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 28)
        Me.Button1.TabIndex = 134
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
        Me.btnExcel.Location = New System.Drawing.Point(827, 536)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(110, 28)
        Me.btnExcel.TabIndex = 133
        Me.btnExcel.Text = "Xuất Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnIn_BC_DRL
        '
        Me.btnIn_BC_DRL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn_BC_DRL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_BC_DRL.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnIn_BC_DRL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIn_BC_DRL.Location = New System.Drawing.Point(940, 536)
        Me.btnIn_BC_DRL.Name = "btnIn_BC_DRL"
        Me.btnIn_BC_DRL.Size = New System.Drawing.Size(102, 28)
        Me.btnIn_BC_DRL.TabIndex = 132
        Me.btnIn_BC_DRL.Text = "In báo cáo"
        Me.btnIn_BC_DRL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIn_BC_DRL.UseVisualStyleBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint1.Location = New System.Drawing.Point(70, 536)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(96, 28)
        Me.btnPrint1.TabIndex = 132
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
        Me.btnXoa_TCT.Location = New System.Drawing.Point(292, 536)
        Me.btnXoa_TCT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa_TCT.Name = "btnXoa_TCT"
        Me.btnXoa_TCT.Size = New System.Drawing.Size(157, 28)
        Me.btnXoa_TCT.TabIndex = 131
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
        Me.Button8.Location = New System.Drawing.Point(1153, 536)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 130
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnTongHop
        '
        Me.btnTongHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTongHop.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnTongHop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTongHop.Location = New System.Drawing.Point(725, 536)
        Me.btnTongHop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTongHop.Name = "btnTongHop"
        Me.btnTongHop.Size = New System.Drawing.Size(97, 28)
        Me.btnTongHop.TabIndex = 129
        Me.btnTongHop.Text = "Tổng hợp"
        Me.btnTongHop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTongHop.UseVisualStyleBackColor = True
        '
        'btnDS_no_mon
        '
        Me.btnDS_no_mon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDS_no_mon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDS_no_mon.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnDS_no_mon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDS_no_mon.Location = New System.Drawing.Point(1046, 536)
        Me.btnDS_no_mon.Name = "btnDS_no_mon"
        Me.btnDS_no_mon.Size = New System.Drawing.Size(102, 28)
        Me.btnDS_no_mon.TabIndex = 139
        Me.btnDS_no_mon.Text = "DS nợ môn"
        Me.btnDS_no_mon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDS_no_mon.UseVisualStyleBackColor = True
        '
        'ckMonVanHoa
        '
        Me.ckMonVanHoa.AutoSize = True
        Me.ckMonVanHoa.Location = New System.Drawing.Point(750, 32)
        Me.ckMonVanHoa.Name = "ckMonVanHoa"
        Me.ckMonVanHoa.Size = New System.Drawing.Size(108, 23)
        Me.ckMonVanHoa.TabIndex = 140
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
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(-3, -1)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 537)
        Me.TrvLop_ChuanHoa.TabIndex = 136
        '
        'frmESS_TongHopHocKy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1238, 566)
        Me.Controls.Add(Me.ckMonVanHoa)
        Me.Controls.Add(Me.btnDS_no_mon)
        Me.Controls.Add(Me.txtTu_diem)
        Me.Controls.Add(Me.txtDen_diem)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnIn_BC_DRL)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnXoa_TCT)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnTongHop)
        Me.Controls.Add(Me.optTenMon)
        Me.Controls.Add(Me.optKyHieu)
        Me.Controls.Add(Me.fgTongHopKy)
        Me.Controls.Add(Me.ckTBMH_5)
        Me.Controls.Add(Me.ckThi_5)
        Me.Controls.Add(Me.ckLoc_theo_DTBCHT)
        Me.Controls.Add(Me.chkThanh_phan)
        Me.Controls.Add(Me.chkGhi_chu)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_TongHopHocKy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TONG HOP KET QUA HOC TAP THEO KỲ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents fgTongHopKy As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents chkGhi_chu As System.Windows.Forms.CheckBox
    Friend WithEvents chkThanh_phan As System.Windows.Forms.CheckBox
    Friend WithEvents optKyHieu As System.Windows.Forms.RadioButton
    Friend WithEvents optTenMon As System.Windows.Forms.RadioButton
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnXoa_TCT As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnTongHop As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDen_diem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTu_diem As System.Windows.Forms.TextBox
    Friend WithEvents ckLoc_theo_DTBCHT As System.Windows.Forms.CheckBox
    Friend WithEvents btnIn_BC_DRL As System.Windows.Forms.Button
    Friend WithEvents ckThi_5 As System.Windows.Forms.CheckBox
    Friend WithEvents ckTBMH_5 As System.Windows.Forms.CheckBox
    Friend WithEvents btnDS_no_mon As System.Windows.Forms.Button
    Friend WithEvents ckMonVanHoa As System.Windows.Forms.CheckBox
End Class
