<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetLenLop
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
        Me.grvSinh_vien = New System.Windows.Forms.DataGridView
        Me.lbTongMon = New System.Windows.Forms.Label
        Me.lbSoSinhVien = New System.Windows.Forms.Label
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.btnTong_hop = New DevExpress.XtraEditors.SimpleButton
        Me.TrvLop = New ESS_Mark.TrvLop_ChuanHoa
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
        Me.cmbHoc_ky.Visible = False
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.FormattingEnabled = True
        Me.cmbNam_hoc.Location = New System.Drawing.Point(595, 4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(121, 27)
        Me.cmbNam_hoc.TabIndex = 1
        Me.cmbNam_hoc.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Học kỳ:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Năm học:"
        Me.Label2.Visible = False
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
        Me.grvSinh_vien.Location = New System.Drawing.Point(276, 37)
        Me.grvSinh_vien.Name = "grvSinh_vien"
        Me.grvSinh_vien.ReadOnly = True
        Me.grvSinh_vien.Size = New System.Drawing.Size(645, 491)
        Me.grvSinh_vien.TabIndex = 3
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
        Me.lbTongMon.Visible = False
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
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageIndex = 22
        Me.btnThoat.Location = New System.Drawing.Point(580, 537)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(91, 30)
        Me.btnThoat.TabIndex = 185
        Me.btnThoat.Text = "Thoát"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = Global.ESS_Mark.My.Resources.Resources.Excel
        Me.btnExcel.ImageIndex = 22
        Me.btnExcel.Location = New System.Drawing.Point(477, 537)
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
        Me.btnPrint.Location = New System.Drawing.Point(365, 537)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 30)
        Me.btnPrint.TabIndex = 183
        Me.btnPrint.Text = "In danh sách"
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
        'TrvLop
        '
        Me.TrvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop.dtLop = Nothing
        Me.TrvLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop.Location = New System.Drawing.Point(4, 4)
        Me.TrvLop.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop.Name = "TrvLop"
        Me.TrvLop.Size = New System.Drawing.Size(264, 563)
        Me.TrvLop.TabIndex = 189
        '
        'frmESS_XetLenLop
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 571)
        Me.Controls.Add(Me.TrvLop)
        Me.Controls.Add(Me.lbSoSinhVien)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnTong_hop)
        Me.Controls.Add(Me.grvSinh_vien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbTongMon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmESS_XetLenLop"
        Me.Text = "frmTongHopHocLai"
        CType(Me.grvSinh_vien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grvSinh_vien As System.Windows.Forms.DataGridView
    Friend WithEvents btnTong_hop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbTongMon As System.Windows.Forms.Label
    Friend WithEvents lbSoSinhVien As System.Windows.Forms.Label
    Friend WithEvents TrvLop As ESS_Mark.TrvLop_ChuanHoa
End Class
