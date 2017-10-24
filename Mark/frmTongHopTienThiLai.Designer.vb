<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTongHopTienThiLai
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grvMon_hoc = New System.Windows.Forms.DataGridView
        Me.grvSinh_vien = New System.Windows.Forms.DataGridView
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.btnTong_hop = New DevExpress.XtraEditors.SimpleButton
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbTongMon = New System.Windows.Forms.Label
        Me.lbSoSinhVien = New System.Windows.Forms.Label
        Me.Check_All = New System.Windows.Forms.CheckBox
        Me.TreeViewLop_DSMon = New ESS_Mark.TreeViewLop_NEW
        Me.cdmDa_nop_tien = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grvMon_hoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvSinh_vien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.FormattingEnabled = True
        Me.cmbHoc_ky.Location = New System.Drawing.Point(367, 4)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(121, 27)
        Me.cmbHoc_ky.TabIndex = 1
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.FormattingEnabled = True
        Me.cmbNam_hoc.Location = New System.Drawing.Point(595, 4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(121, 27)
        Me.cmbNam_hoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Học kỳ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Năm học:"
        '
        'grvMon_hoc
        '
        Me.grvMon_hoc.AllowUserToAddRows = False
        Me.grvMon_hoc.AllowUserToDeleteRows = False
        Me.grvMon_hoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvMon_hoc.BackgroundColor = System.Drawing.Color.White
        Me.grvMon_hoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvMon_hoc.Location = New System.Drawing.Point(273, 37)
        Me.grvMon_hoc.Name = "grvMon_hoc"
        Me.grvMon_hoc.ReadOnly = True
        Me.grvMon_hoc.Size = New System.Drawing.Size(784, 257)
        Me.grvMon_hoc.TabIndex = 3
        '
        'grvSinh_vien
        '
        Me.grvSinh_vien.AllowUserToAddRows = False
        Me.grvSinh_vien.AllowUserToDeleteRows = False
        Me.grvSinh_vien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvSinh_vien.BackgroundColor = System.Drawing.Color.White
        Me.grvSinh_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvSinh_vien.Location = New System.Drawing.Point(276, 330)
        Me.grvSinh_vien.Name = "grvSinh_vien"
        Me.grvSinh_vien.Size = New System.Drawing.Size(784, 198)
        Me.grvSinh_vien.TabIndex = 3
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(593, 537)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(102, 30)
        Me.btnExcel.TabIndex = 184
        Me.btnExcel.Text = "Xuất Excel"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnPrint.ImageIndex = 22
        Me.btnPrint.Location = New System.Drawing.Point(481, 537)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 30)
        Me.btnPrint.TabIndex = 183
        Me.btnPrint.Text = "In DS học lại"
        '
        'btnTong_hop
        '
        Me.btnTong_hop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTong_hop.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTong_hop.Appearance.Options.UseFont = True
        Me.btnTong_hop.Image = Global.ESS_Mark.My.Resources.Resources.LapSBD
        Me.btnTong_hop.ImageIndex = 22
        Me.btnTong_hop.Location = New System.Drawing.Point(279, 537)
        Me.btnTong_hop.Name = "btnTong_hop"
        Me.btnTong_hop.Size = New System.Drawing.Size(84, 30)
        Me.btnTong_hop.TabIndex = 182
        Me.btnTong_hop.Text = "Tổng hợp"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(696, 537)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(91, 30)
        Me.btnThoat.TabIndex = 185
        Me.btnThoat.Text = "Thoát"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DANH SÁCH SINH VIÊN ĐÃ HỌC LẠI"
        '
        'lbTongMon
        '
        Me.lbTongMon.AutoSize = True
        Me.lbTongMon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTongMon.ForeColor = System.Drawing.Color.Red
        Me.lbTongMon.Location = New System.Drawing.Point(742, 9)
        Me.lbTongMon.Name = "lbTongMon"
        Me.lbTongMon.Size = New System.Drawing.Size(0, 19)
        Me.lbTongMon.TabIndex = 2
        '
        'lbSoSinhVien
        '
        Me.lbSoSinhVien.AutoSize = True
        Me.lbSoSinhVien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSoSinhVien.ForeColor = System.Drawing.Color.Red
        Me.lbSoSinhVien.Location = New System.Drawing.Point(275, 305)
        Me.lbSoSinhVien.Name = "lbSoSinhVien"
        Me.lbSoSinhVien.Size = New System.Drawing.Size(0, 19)
        Me.lbSoSinhVien.TabIndex = 188
        '
        'Check_All
        '
        Me.Check_All.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check_All.AutoSize = True
        Me.Check_All.Location = New System.Drawing.Point(949, 304)
        Me.Check_All.Name = "Check_All"
        Me.Check_All.Size = New System.Drawing.Size(98, 23)
        Me.Check_All.TabIndex = 189
        Me.Check_All.Text = "Chọn tất cả"
        Me.Check_All.UseVisualStyleBackColor = True
        '
        'TreeViewLop_DSMon
        '
        Me.TreeViewLop_DSMon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop_DSMon.dtLop = Nothing
        Me.TreeViewLop_DSMon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewLop_DSMon.Location = New System.Drawing.Point(6, 4)
        Me.TreeViewLop_DSMon.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeViewLop_DSMon.Name = "TreeViewLop_DSMon"
        Me.TreeViewLop_DSMon.Size = New System.Drawing.Size(261, 565)
        Me.TreeViewLop_DSMon.TabIndex = 187
        '
        'cdmDa_nop_tien
        '
        Me.cdmDa_nop_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cdmDa_nop_tien.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdmDa_nop_tien.Appearance.Options.UseFont = True
        Me.cdmDa_nop_tien.Image = Global.ESS_Mark.My.Resources.Resources.PhongHoc
        Me.cdmDa_nop_tien.ImageIndex = 22
        Me.cdmDa_nop_tien.Location = New System.Drawing.Point(367, 537)
        Me.cdmDa_nop_tien.Name = "cdmDa_nop_tien"
        Me.cdmDa_nop_tien.Size = New System.Drawing.Size(108, 30)
        Me.cdmDa_nop_tien.TabIndex = 182
        Me.cdmDa_nop_tien.Text = "Đã nộp tiền"
        '
        'frmTongHopHocLai
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 571)
        Me.Controls.Add(Me.Check_All)
        Me.Controls.Add(Me.lbSoSinhVien)
        Me.Controls.Add(Me.TreeViewLop_DSMon)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cdmDa_nop_tien)
        Me.Controls.Add(Me.btnTong_hop)
        Me.Controls.Add(Me.grvSinh_vien)
        Me.Controls.Add(Me.grvMon_hoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbTongMon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTongHopHocLai"
        Me.Text = "frmTongHopHocLai"
        CType(Me.grvMon_hoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvSinh_vien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grvMon_hoc As System.Windows.Forms.DataGridView
    Friend WithEvents grvSinh_vien As System.Windows.Forms.DataGridView
    Friend WithEvents btnTong_hop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTongMon As System.Windows.Forms.Label
    Friend WithEvents TreeViewLop_DSMon As ESS_Mark.TreeViewLop_NEW
    Friend WithEvents lbSoSinhVien As System.Windows.Forms.Label
    Friend WithEvents Check_All As System.Windows.Forms.CheckBox
    Friend WithEvents cdmDa_nop_tien As DevExpress.XtraEditors.SimpleButton
End Class
