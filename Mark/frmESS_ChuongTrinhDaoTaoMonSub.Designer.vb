<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ChuongTrinhDaoTaoMonSub
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdViewMonNhomTuChon = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button
        Me.grdViewMonHoc = New System.Windows.Forms.DataGridView
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Ky_hieu2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTen_mon = New System.Windows.Forms.Label
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grdViewMonNhomTuChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewMonHoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdViewMonNhomTuChon
        '
        Me.grdViewMonNhomTuChon.AllowUserToAddRows = False
        Me.grdViewMonNhomTuChon.AllowUserToDeleteRows = False
        Me.grdViewMonNhomTuChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewMonNhomTuChon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewMonNhomTuChon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ky_hieu2, Me.Ten_mon2, Me.So_hoc_trinh2})
        Me.grdViewMonNhomTuChon.Location = New System.Drawing.Point(1, 334)
        Me.grdViewMonNhomTuChon.Name = "grdViewMonNhomTuChon"
        Me.grdViewMonNhomTuChon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdViewMonNhomTuChon.Size = New System.Drawing.Size(790, 231)
        Me.grdViewMonNhomTuChon.TabIndex = 59
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(654, 309)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 25)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'grdViewMonHoc
        '
        Me.grdViewMonHoc.AllowUserToAddRows = False
        Me.grdViewMonHoc.AllowUserToDeleteRows = False
        Me.grdViewMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewMonHoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ky_hieu, Me.Ten_mon, Me.So_hoc_trinh})
        Me.grdViewMonHoc.Location = New System.Drawing.Point(2, 30)
        Me.grdViewMonHoc.Name = "grdViewMonHoc"
        Me.grdViewMonHoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdViewMonHoc.Size = New System.Drawing.Size(790, 274)
        Me.grdViewMonHoc.TabIndex = 48
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Brown
        Me.btnDelete.Image = Global.ESS_Mark.My.Resources.Resources.Delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(729, 309)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 25)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Xoá"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Ky_hieu2
        '
        Me.Ky_hieu2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Ky_hieu2.DataPropertyName = "Ky_hieu2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ky_hieu2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ky_hieu2.FillWeight = 44.81769!
        Me.Ky_hieu2.Frozen = True
        Me.Ky_hieu2.HeaderText = "Ký hiệu"
        Me.Ky_hieu2.MinimumWidth = 100
        Me.Ky_hieu2.Name = "Ky_hieu2"
        Me.Ky_hieu2.ReadOnly = True
        '
        'Ten_mon2
        '
        Me.Ten_mon2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Ten_mon2.DataPropertyName = "Ten_mon2"
        Me.Ten_mon2.FillWeight = 185.0055!
        Me.Ten_mon2.Frozen = True
        Me.Ten_mon2.HeaderText = "Tên học phần"
        Me.Ten_mon2.MinimumWidth = 340
        Me.Ten_mon2.Name = "Ten_mon2"
        Me.Ten_mon2.ReadOnly = True
        Me.Ten_mon2.Width = 340
        '
        'So_hoc_trinh2
        '
        Me.So_hoc_trinh2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.So_hoc_trinh2.DataPropertyName = "So_hoc_trinh2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_hoc_trinh2.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_hoc_trinh2.FillWeight = 30.38883!
        Me.So_hoc_trinh2.HeaderText = "Số học trình"
        Me.So_hoc_trinh2.MinimumWidth = 100
        Me.So_hoc_trinh2.Name = "So_hoc_trinh2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Học phần:"
        '
        'lblTen_mon
        '
        Me.lblTen_mon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen_mon.Location = New System.Drawing.Point(138, 9)
        Me.lblTen_mon.Name = "lblTen_mon"
        Me.lblTen_mon.Size = New System.Drawing.Size(642, 16)
        Me.lblTen_mon.TabIndex = 61
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        Me.Ky_hieu.HeaderText = "Ký hiệu"
        Me.Ky_hieu.Name = "Ky_hieu"
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 281.7586!
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.MinimumWidth = 340
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.DataPropertyName = "So_hoc_trinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_hoc_trinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_hoc_trinh.FillWeight = 2.10072!
        Me.So_hoc_trinh.HeaderText = "Số học trình"
        Me.So_hoc_trinh.MinimumWidth = 80
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        '
        'frmESS_ChuongTrinhDaoTaoMonSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.lblTen_mon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdViewMonNhomTuChon)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdViewMonHoc)
        Me.Controls.Add(Me.btnDelete)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ChuongTrinhDaoTaoMonSub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_ChuongTrinhDaoTaoMonSub"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewMonNhomTuChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewMonHoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewMonNhomTuChon As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdViewMonHoc As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Ky_hieu2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTen_mon As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
