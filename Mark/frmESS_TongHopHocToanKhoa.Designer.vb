<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopHocToanKhoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TongHopHocToanKhoa))
        Me.fgTongHopToanKhoa = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.chkGhi_chu = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.optTenMon = New System.Windows.Forms.RadioButton
        Me.optMaMon = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.chkThanh_phan = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnPrint1 = New System.Windows.Forms.Button
        Me.btnXoa_TCT = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.btnTongHop = New System.Windows.Forms.Button
        CType(Me.fgTongHopToanKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgTongHopToanKhoa
        '
        Me.fgTongHopToanKhoa.AllowEditing = False
        Me.fgTongHopToanKhoa.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fgTongHopToanKhoa.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fgTongHopToanKhoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTongHopToanKhoa.BackColor = System.Drawing.Color.White
        Me.fgTongHopToanKhoa.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.fgTongHopToanKhoa.Cols = New C1.Win.C1FlexGrid.ColumnCollection(10, 1, 0, 0, 0, 110, "")
        Me.fgTongHopToanKhoa.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgTongHopToanKhoa.Location = New System.Drawing.Point(264, 54)
        Me.fgTongHopToanKhoa.Name = "fgTongHopToanKhoa"
        Me.fgTongHopToanKhoa.Rows.Count = 0
        Me.fgTongHopToanKhoa.Rows.Fixed = 0
        Me.fgTongHopToanKhoa.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopToanKhoa.Size = New System.Drawing.Size(872, 478)
        Me.fgTongHopToanKhoa.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopToanKhoa.Styles"))
        Me.fgTongHopToanKhoa.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(972, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(1054, 22)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(76, 27)
        Me.cmbKho_giay.TabIndex = 116
        Me.cmbKho_giay.Visible = False
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'chkGhi_chu
        '
        Me.chkGhi_chu.AutoSize = True
        Me.chkGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.chkGhi_chu.Location = New System.Drawing.Point(447, 25)
        Me.chkGhi_chu.Name = "chkGhi_chu"
        Me.chkGhi_chu.Size = New System.Drawing.Size(153, 23)
        Me.chkGhi_chu.TabIndex = 120
        Me.chkGhi_chu.Text = "Hiển thị ghi chú điểm"
        Me.chkGhi_chu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Số sinh viên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_sv
        '
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(97, 23)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(94, 24)
        Me.lblSo_sv.TabIndex = 122
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optTenMon
        '
        Me.optTenMon.AutoSize = True
        Me.optTenMon.BackColor = System.Drawing.Color.Transparent
        Me.optTenMon.Checked = True
        Me.optTenMon.Location = New System.Drawing.Point(178, 24)
        Me.optTenMon.Name = "optTenMon"
        Me.optTenMon.Size = New System.Drawing.Size(110, 23)
        Me.optTenMon.TabIndex = 123
        Me.optTenMon.TabStop = True
        Me.optTenMon.Text = "Theo tên môn"
        Me.optTenMon.UseVisualStyleBackColor = False
        '
        'optMaMon
        '
        Me.optMaMon.AutoSize = True
        Me.optMaMon.BackColor = System.Drawing.Color.Transparent
        Me.optMaMon.Location = New System.Drawing.Point(309, 24)
        Me.optMaMon.Name = "optMaMon"
        Me.optMaMon.Size = New System.Drawing.Size(110, 23)
        Me.optMaMon.TabIndex = 124
        Me.optMaMon.Text = "Theo mã môn"
        Me.optMaMon.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(943, 26)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "TỔNG HỢP KẾT QUẢ HỌC TẬP TOÀN KHÓA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(0, 53)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 479)
        Me.TrvLop_ChuanHoa.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(831, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"Lần 1", "Cao nhất"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(897, 23)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(75, 27)
        Me.cmbLan_thi.TabIndex = 150
        Me.cmbLan_thi.Visible = False
        '
        'chkThanh_phan
        '
        Me.chkThanh_phan.AutoSize = True
        Me.chkThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.chkThanh_phan.Location = New System.Drawing.Point(606, 25)
        Me.chkThanh_phan.Name = "chkThanh_phan"
        Me.chkThanh_phan.Size = New System.Drawing.Size(176, 23)
        Me.chkThanh_phan.TabIndex = 151
        Me.chkThanh_phan.Text = "Hiển thị điểm thành phần"
        Me.chkThanh_phan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.ChuyenLop
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(647, 535)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 29)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "Phân loại KQHT học phần"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(118, 535)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(110, 29)
        Me.btnExcel.TabIndex = 145
        Me.btnExcel.Text = "Xuất Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint1.Location = New System.Drawing.Point(235, 535)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(96, 29)
        Me.btnPrint1.TabIndex = 144
        Me.btnPrint1.Text = "In báo cáo"
        Me.btnPrint1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint1.UseVisualStyleBackColor = True
        '
        'btnXoa_TCT
        '
        Me.btnXoa_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoa_TCT.Image = Global.ESS_Mark.My.Resources.Resources.ChuyenLop
        Me.btnXoa_TCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa_TCT.Location = New System.Drawing.Point(490, 535)
        Me.btnXoa_TCT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa_TCT.Name = "btnXoa_TCT"
        Me.btnXoa_TCT.Size = New System.Drawing.Size(157, 29)
        Me.btnXoa_TCT.TabIndex = 143
        Me.btnXoa_TCT.Text = "Phân loại KQHT lớp"
        Me.btnXoa_TCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa_TCT.UseVisualStyleBackColor = True
        Me.btnXoa_TCT.Visible = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(338, 535)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 29)
        Me.Button8.TabIndex = 142
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnTongHop
        '
        Me.btnTongHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTongHop.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnTongHop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTongHop.Location = New System.Drawing.Point(13, 535)
        Me.btnTongHop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTongHop.Name = "btnTongHop"
        Me.btnTongHop.Size = New System.Drawing.Size(97, 29)
        Me.btnTongHop.TabIndex = 141
        Me.btnTongHop.Text = "Tổng hợp"
        Me.btnTongHop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTongHop.UseVisualStyleBackColor = True
        '
        'frmESS_TongHopHocToanKhoa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1135, 566)
        Me.Controls.Add(Me.chkThanh_phan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.btnXoa_TCT)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnTongHop)
        Me.Controls.Add(Me.optMaMon)
        Me.Controls.Add(Me.optTenMon)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkGhi_chu)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.fgTongHopToanKhoa)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_TongHopHocToanKhoa"
        Me.Text = "TONG HOP KQHT TOAN KHOA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fgTongHopToanKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fgTongHopToanKhoa As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents chkGhi_chu As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents optTenMon As System.Windows.Forms.RadioButton
    Friend WithEvents optMaMon As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnXoa_TCT As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnTongHop As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents chkThanh_phan As System.Windows.Forms.CheckBox
End Class
