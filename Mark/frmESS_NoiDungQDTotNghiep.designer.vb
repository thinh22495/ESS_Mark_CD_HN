<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NoiDungQDTotNghiep
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
        Me.txtSo_QD = New System.Windows.Forms.TextBox
        Me.dtmNgay_hop = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnChung_nhan = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'txtSo_QD
        '
        Me.txtSo_QD.Location = New System.Drawing.Point(139, 17)
        Me.txtSo_QD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSo_QD.MaxLength = 100
        Me.txtSo_QD.Name = "txtSo_QD"
        Me.txtSo_QD.Size = New System.Drawing.Size(116, 22)
        Me.txtSo_QD.TabIndex = 107
        '
        'dtmNgay_hop
        '
        Me.dtmNgay_hop.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNgay_hop.Location = New System.Drawing.Point(139, 47)
        Me.dtmNgay_hop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtmNgay_hop.Name = "dtmNgay_hop"
        Me.dtmNgay_hop.ShowCheckBox = True
        Me.dtmNgay_hop.Size = New System.Drawing.Size(116, 22)
        Me.dtmNgay_hop.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(41, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Số quyết định:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Ngày quyết định:"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Location = New System.Drawing.Point(12, 90)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 33)
        Me.btnPrint.TabIndex = 111
        Me.btnPrint.Text = "In QĐ tốt nghiệp"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(255, 90)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 33)
        Me.btnClose.TabIndex = 111
        Me.btnClose.Text = "Thoát"
        '
        'btnChung_nhan
        '
        Me.btnChung_nhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChung_nhan.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnChung_nhan.Appearance.Options.UseFont = True
        Me.btnChung_nhan.Location = New System.Drawing.Point(130, 90)
        Me.btnChung_nhan.Name = "btnChung_nhan"
        Me.btnChung_nhan.Size = New System.Drawing.Size(122, 33)
        Me.btnChung_nhan.TabIndex = 111
        Me.btnChung_nhan.Text = "In giấy chứng nhận"
        '
        'frmESS_NoiDungQDTotNghiep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 135)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnChung_nhan)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtmNgay_hop)
        Me.Controls.Add(Me.txtSo_QD)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_NoiDungQDTotNghiep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_NoiDungQDTotNghiep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_QD As System.Windows.Forms.TextBox
    Friend WithEvents dtmNgay_hop As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChung_nhan As DevExpress.XtraEditors.SimpleButton
End Class
