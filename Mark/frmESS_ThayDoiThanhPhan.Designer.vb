<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThayDoiThanhPhan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdViewTP = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_thanh_phan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ty_le = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_thanh_phan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.grdViewTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdViewTP
        '
        Me.grdViewTP.AllowUserToDeleteRows = False
        Me.grdViewTP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewTP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.STT, Me.Ky_hieu, Me.Ten_thanh_phan, Me.Ty_le, Me.ID_thanh_phan})
        Me.grdViewTP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdViewTP.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdViewTP.Location = New System.Drawing.Point(0, 14)
        Me.grdViewTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdViewTP.Name = "grdViewTP"
        Me.grdViewTP.RowHeadersVisible = False
        Me.grdViewTP.Size = New System.Drawing.Size(534, 392)
        Me.grdViewTP.TabIndex = 84
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Width = 50
        '
        'STT
        '
        Me.STT.DataPropertyName = "STT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 50
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ky_hieu.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ky_hieu.HeaderText = "Ký hiệu"
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 80
        '
        'Ten_thanh_phan
        '
        Me.Ten_thanh_phan.DataPropertyName = "Ten_thanh_phan"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_thanh_phan.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ten_thanh_phan.HeaderText = "Tên thành phần"
        Me.Ten_thanh_phan.Name = "Ten_thanh_phan"
        Me.Ten_thanh_phan.ReadOnly = True
        Me.Ten_thanh_phan.Width = 200
        '
        'Ty_le
        '
        Me.Ty_le.DataPropertyName = "Ty_le"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ty_le.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ty_le.HeaderText = "Tỷ lệ/ Hệ số"
        Me.Ty_le.MinimumWidth = 150
        Me.Ty_le.Name = "Ty_le"
        Me.Ty_le.Width = 150
        '
        'ID_thanh_phan
        '
        Me.ID_thanh_phan.DataPropertyName = "ID_thanh_phan"
        Me.ID_thanh_phan.HeaderText = "ID_thanh_phan"
        Me.ID_thanh_phan.Name = "ID_thanh_phan"
        Me.ID_thanh_phan.Visible = False
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(151, 405)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 31)
        Me.btnThoat.TabIndex = 165
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 405)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 31)
        Me.btnSave.TabIndex = 164
        Me.btnSave.Text = "  Cập nhật thay đổi"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmESS_ThayDoiThanhPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 435)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grdViewTP)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ThayDoiThanhPhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "THAY DOI THANH PHAN DIEM"
        CType(Me.grdViewTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdViewTP As System.Windows.Forms.DataGridView
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_thanh_phan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ty_le As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_thanh_phan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
