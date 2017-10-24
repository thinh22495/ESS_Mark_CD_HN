<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMPhongHoc
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
        Me.components = New System.ComponentModel.Container
        Me.cboCoSo = New System.Windows.Forms.ComboBox
        Me.cboToaNha = New System.Windows.Forms.ComboBox
        Me.cboTang = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSoPhong = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSucChua = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboLoaiPhong = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbAmThanh = New System.Windows.Forms.CheckBox
        Me.cbMayTinh = New System.Windows.Forms.CheckBox
        Me.cbTiVi = New System.Windows.Forms.CheckBox
        Me.cbMayChieu = New System.Windows.Forms.CheckBox
        Me.grdDMPhongHoc = New System.Windows.Forms.DataGridView
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.grdDMPhongHoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCoSo
        '
        Me.cboCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCoSo.FormattingEnabled = True
        Me.cboCoSo.Location = New System.Drawing.Point(83, 13)
        Me.cboCoSo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCoSo.Name = "cboCoSo"
        Me.cboCoSo.Size = New System.Drawing.Size(154, 27)
        Me.cboCoSo.TabIndex = 0
        '
        'cboToaNha
        '
        Me.cboToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToaNha.FormattingEnabled = True
        Me.cboToaNha.Location = New System.Drawing.Point(326, 13)
        Me.cboToaNha.Margin = New System.Windows.Forms.Padding(4)
        Me.cboToaNha.Name = "cboToaNha"
        Me.cboToaNha.Size = New System.Drawing.Size(154, 27)
        Me.cboToaNha.TabIndex = 0
        '
        'cboTang
        '
        Me.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTang.FormattingEnabled = True
        Me.cboTang.Location = New System.Drawing.Point(609, 13)
        Me.cboTang.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTang.Name = "cboTang"
        Me.cboTang.Size = New System.Drawing.Size(59, 27)
        Me.cboTang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cơ sở:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tòa nhà:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tầng:"
        '
        'txtSoPhong
        '
        Me.txtSoPhong.Location = New System.Drawing.Point(83, 47)
        Me.txtSoPhong.Name = "txtSoPhong"
        Me.txtSoPhong.Size = New System.Drawing.Size(154, 26)
        Me.txtSoPhong.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Số phòng:"
        '
        'txtSucChua
        '
        Me.txtSucChua.Location = New System.Drawing.Point(326, 47)
        Me.txtSucChua.Name = "txtSucChua"
        Me.txtSucChua.Size = New System.Drawing.Size(154, 26)
        Me.txtSucChua.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sức chứa:"
        '
        'CboLoaiPhong
        '
        Me.CboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLoaiPhong.FormattingEnabled = True
        Me.CboLoaiPhong.Location = New System.Drawing.Point(609, 46)
        Me.CboLoaiPhong.Margin = New System.Windows.Forms.Padding(4)
        Me.CboLoaiPhong.Name = "CboLoaiPhong"
        Me.CboLoaiPhong.Size = New System.Drawing.Size(155, 27)
        Me.CboLoaiPhong.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(521, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Loại phòng:"
        '
        'cbAmThanh
        '
        Me.cbAmThanh.AutoSize = True
        Me.cbAmThanh.Location = New System.Drawing.Point(83, 82)
        Me.cbAmThanh.Name = "cbAmThanh"
        Me.cbAmThanh.Size = New System.Drawing.Size(86, 23)
        Me.cbAmThanh.TabIndex = 3
        Me.cbAmThanh.Text = "Âm thanh"
        Me.cbAmThanh.UseVisualStyleBackColor = True
        '
        'cbMayTinh
        '
        Me.cbMayTinh.AutoSize = True
        Me.cbMayTinh.Location = New System.Drawing.Point(237, 82)
        Me.cbMayTinh.Name = "cbMayTinh"
        Me.cbMayTinh.Size = New System.Drawing.Size(81, 23)
        Me.cbMayTinh.TabIndex = 4
        Me.cbMayTinh.Text = "Máy tính"
        Me.cbMayTinh.UseVisualStyleBackColor = True
        '
        'cbTiVi
        '
        Me.cbTiVi.AutoSize = True
        Me.cbTiVi.Location = New System.Drawing.Point(391, 82)
        Me.cbTiVi.Name = "cbTiVi"
        Me.cbTiVi.Size = New System.Drawing.Size(49, 23)
        Me.cbTiVi.TabIndex = 4
        Me.cbTiVi.Text = "Tivi"
        Me.cbTiVi.UseVisualStyleBackColor = True
        '
        'cbMayChieu
        '
        Me.cbMayChieu.AutoSize = True
        Me.cbMayChieu.Location = New System.Drawing.Point(536, 82)
        Me.cbMayChieu.Name = "cbMayChieu"
        Me.cbMayChieu.Size = New System.Drawing.Size(91, 23)
        Me.cbMayChieu.TabIndex = 4
        Me.cbMayChieu.Text = "Máy chiếu"
        Me.cbMayChieu.UseVisualStyleBackColor = True
        '
        'grdDMPhongHoc
        '
        Me.grdDMPhongHoc.AllowUserToAddRows = False
        Me.grdDMPhongHoc.AllowUserToDeleteRows = False
        Me.grdDMPhongHoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDMPhongHoc.BackgroundColor = System.Drawing.Color.White
        Me.grdDMPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDMPhongHoc.GridColor = System.Drawing.SystemColors.Control
        Me.grdDMPhongHoc.Location = New System.Drawing.Point(5, 119)
        Me.grdDMPhongHoc.Name = "grdDMPhongHoc"
        Me.grdDMPhongHoc.ReadOnly = True
        Me.grdDMPhongHoc.Size = New System.Drawing.Size(766, 274)
        Me.grdDMPhongHoc.TabIndex = 5
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Image = Global.ESS.Catalogue.My.Resources.Resources.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(547, 406)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(82, 27)
        Me.cmdCancel.TabIndex = 17
        Me.cmdCancel.Text = "Hủy"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = Global.ESS.Catalogue.My.Resources.Resources.Add
        Me.cmdAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(120, 406)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(82, 27)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = Global.ESS.Catalogue.My.Resources.Resources.Delete
        Me.cmdDelete.Location = New System.Drawing.Point(290, 406)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(82, 27)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.Image = Global.ESS.Catalogue.My.Resources.Resources.Close
        Me.cmdClose.Location = New System.Drawing.Point(375, 406)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(82, 27)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Enabled = False
        Me.cmdSave.Image = Global.ESS.Catalogue.My.Resources.Resources.Save
        Me.cmdSave.Location = New System.Drawing.Point(461, 406)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(82, 27)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "Lưu"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.Image = Global.ESS.Catalogue.My.Resources.Resources.Edit
        Me.cmdEdit.Location = New System.Drawing.Point(204, 406)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(82, 27)
        Me.cmdEdit.TabIndex = 15
        Me.cmdEdit.Text = "Sửa"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_DMPhongHoc
        '
        Me.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 440)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.grdDMPhongHoc)
        Me.Controls.Add(Me.cbMayChieu)
        Me.Controls.Add(Me.cbTiVi)
        Me.Controls.Add(Me.cbMayTinh)
        Me.Controls.Add(Me.cbAmThanh)
        Me.Controls.Add(Me.txtSucChua)
        Me.Controls.Add(Me.txtSoPhong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboLoaiPhong)
        Me.Controls.Add(Me.cboTang)
        Me.Controls.Add(Me.cboToaNha)
        Me.Controls.Add(Me.cboCoSo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmESS_DMPhongHoc"
        Me.Text = "Danh mục phòng học"
        CType(Me.grdDMPhongHoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCoSo As System.Windows.Forms.ComboBox
    Friend WithEvents cboToaNha As System.Windows.Forms.ComboBox
    Friend WithEvents cboTang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSoPhong As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSucChua As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbAmThanh As System.Windows.Forms.CheckBox
    Friend WithEvents cbMayTinh As System.Windows.Forms.CheckBox
    Friend WithEvents cbTiVi As System.Windows.Forms.CheckBox
    Friend WithEvents cbMayChieu As System.Windows.Forms.CheckBox
    Friend WithEvents grdDMPhongHoc As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
