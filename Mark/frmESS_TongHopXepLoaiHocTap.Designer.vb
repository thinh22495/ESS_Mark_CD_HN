<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopXepLoaiHocTap
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
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TreeViewLop1 = New ESS_Mark.TreeViewLop
        Me.btnTong_hop = New DevExpress.XtraEditors.SimpleButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.FormattingEnabled = True
        Me.cmbHoc_ky.Items.AddRange(New Object() {"1", "2"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(336, 2)
        Me.cmbHoc_ky.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(52, 27)
        Me.cmbHoc_ky.TabIndex = 0
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.FormattingEnabled = True
        Me.cmbNam_hoc.Location = New System.Drawing.Point(471, 2)
        Me.cmbNam_hoc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(102, 27)
        Me.cmbNam_hoc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Học kỳ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Năm học:"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint.Location = New System.Drawing.Point(377, 442)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 31)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "In báo cáo"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(682, 2)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(359, 27)
        Me.ComboBox3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(581, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Loại tổng hợp:"
        '
        'TreeViewLop1
        '
        Me.TreeViewLop1.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop1.dtLop = Nothing
        Me.TreeViewLop1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop1.Location = New System.Drawing.Point(3, 2)
        Me.TreeViewLop1.Name = "TreeViewLop1"
        Me.TreeViewLop1.Size = New System.Drawing.Size(259, 471)
        Me.TreeViewLop1.TabIndex = 3
        '
        'btnTong_hop
        '
        Me.btnTong_hop.Image = Global.ESS_Mark.My.Resources.Resources.LapSBD
        Me.btnTong_hop.Location = New System.Drawing.Point(277, 442)
        Me.btnTong_hop.Name = "btnTong_hop"
        Me.btnTong_hop.Size = New System.Drawing.Size(94, 31)
        Me.btnTong_hop.TabIndex = 2
        Me.btnTong_hop.Text = "Tổng hợp"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(263, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(785, 375)
        Me.DataGridView1.TabIndex = 4
        '
        'frmESS_TongHopXepLoaiHocTap
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 476)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TreeViewLop1)
        Me.Controls.Add(Me.btnTong_hop)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmESS_TongHopXepLoaiHocTap"
        Me.Text = "Tổng hợp xếp loại học tập sinh viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TreeViewLop1 As ESS_Mark.TreeViewLop
    Friend WithEvents btnTong_hop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
