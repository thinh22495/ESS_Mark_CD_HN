<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhanLoai_KQHT_nam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.btnPrint_KQHT_Khoa = New System.Windows.Forms.Button
        Me.btnPrint_KQHT_Lop = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.cmbHe = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(278, 14)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(135, 25)
        Me.cmbNam_hoc.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(185, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 27)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(50, 14)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(69, 27)
        Me.lblLan_cap.TabIndex = 100
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(126, 14)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(57, 25)
        Me.cmbHoc_ky.TabIndex = 101
        '
        'btnPrint_KQHT_Khoa
        '
        Me.btnPrint_KQHT_Khoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint_KQHT_Khoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint_KQHT_Khoa.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint_KQHT_Khoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint_KQHT_Khoa.Location = New System.Drawing.Point(205, 108)
        Me.btnPrint_KQHT_Khoa.Name = "btnPrint_KQHT_Khoa"
        Me.btnPrint_KQHT_Khoa.Size = New System.Drawing.Size(152, 32)
        Me.btnPrint_KQHT_Khoa.TabIndex = 135
        Me.btnPrint_KQHT_Khoa.Text = "Phân loại theo Khóa"
        Me.btnPrint_KQHT_Khoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint_KQHT_Khoa.UseVisualStyleBackColor = True
        '
        'btnPrint_KQHT_Lop
        '
        Me.btnPrint_KQHT_Lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint_KQHT_Lop.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnPrint_KQHT_Lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint_KQHT_Lop.Location = New System.Drawing.Point(53, 108)
        Me.btnPrint_KQHT_Lop.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint_KQHT_Lop.Name = "btnPrint_KQHT_Lop"
        Me.btnPrint_KQHT_Lop.Size = New System.Drawing.Size(151, 32)
        Me.btnPrint_KQHT_Lop.TabIndex = 134
        Me.btnPrint_KQHT_Lop.Text = "Phân loại KQHT lớp"
        Me.btnPrint_KQHT_Lop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint_KQHT_Lop.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(358, 108)
        Me.Button8.Margin = New System.Windows.Forms.Padding(5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 32)
        Me.Button8.TabIndex = 133
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'cmbHe
        '
        Me.cmbHe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHe.Location = New System.Drawing.Point(126, 63)
        Me.cmbHe.Name = "cmbHe"
        Me.cmbHe.Size = New System.Drawing.Size(287, 25)
        Me.cmbHe.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(33, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 27)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Hệ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPhanLoai_KQHT_nam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 154)
        Me.Controls.Add(Me.cmbHe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrint_KQHT_Khoa)
        Me.Controls.Add(Me.btnPrint_KQHT_Lop)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Name = "frmPhanLoai_KQHT_nam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPhanLoai_KQHT"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint_KQHT_Khoa As System.Windows.Forms.Button
    Friend WithEvents btnPrint_KQHT_Lop As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents cmbHe As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
