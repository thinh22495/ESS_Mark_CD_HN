<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BoMon_DanhSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_BoMon_DanhSach))
        Me.dgvBoMon = New System.Windows.Forms.DataGridView
        Me.ID_bm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_bm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_bm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_gv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvMonHoc = New System.Windows.Forms.DataGridView
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvGiangVien = New System.Windows.Forms.DataGridView
        Me.ID_cb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_cb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.btnXoaMon = New DevExpress.XtraEditors.SimpleButton
        Me.btnThemMon = New DevExpress.XtraEditors.SimpleButton
        Me.btnXoaGV = New DevExpress.XtraEditors.SimpleButton
        Me.btnThemGV = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgvBoMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMonHoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGiangVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBoMon
        '
        Me.dgvBoMon.AllowUserToAddRows = False
        Me.dgvBoMon.AllowUserToDeleteRows = False
        Me.dgvBoMon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBoMon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_bm, Me.Ma_bm, Me.Ten_bm, Me.So_mon, Me.So_gv})
        Me.dgvBoMon.Location = New System.Drawing.Point(0, 1)
        Me.dgvBoMon.Name = "dgvBoMon"
        Me.dgvBoMon.ReadOnly = True
        Me.dgvBoMon.Size = New System.Drawing.Size(392, 560)
        Me.dgvBoMon.TabIndex = 28
        '
        'ID_bm
        '
        Me.ID_bm.DataPropertyName = "ID_bm"
        Me.ID_bm.HeaderText = "ID Bộ môn"
        Me.ID_bm.Name = "ID_bm"
        Me.ID_bm.ReadOnly = True
        Me.ID_bm.Visible = False
        '
        'Ma_bm
        '
        Me.Ma_bm.DataPropertyName = "Ma_bo_mon"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_bm.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ma_bm.HeaderText = "Mã Bộ môn"
        Me.Ma_bm.MinimumWidth = 100
        Me.Ma_bm.Name = "Ma_bm"
        Me.Ma_bm.ReadOnly = True
        '
        'Ten_bm
        '
        Me.Ten_bm.DataPropertyName = "Bo_mon"
        Me.Ten_bm.FillWeight = 300.0!
        Me.Ten_bm.HeaderText = "Tên Bộ môn"
        Me.Ten_bm.MinimumWidth = 300
        Me.Ten_bm.Name = "Ten_bm"
        Me.Ten_bm.ReadOnly = True
        Me.Ten_bm.Width = 300
        '
        'So_mon
        '
        Me.So_mon.DataPropertyName = "So_mon"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_mon.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_mon.HeaderText = "Số học phần"
        Me.So_mon.MinimumWidth = 80
        Me.So_mon.Name = "So_mon"
        Me.So_mon.ReadOnly = True
        Me.So_mon.Width = 80
        '
        'So_gv
        '
        Me.So_gv.DataPropertyName = "So_giang_vien"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_gv.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_gv.HeaderText = "Số gv"
        Me.So_gv.MinimumWidth = 80
        Me.So_gv.Name = "So_gv"
        Me.So_gv.ReadOnly = True
        Me.So_gv.Width = 80
        '
        'dgvMonHoc
        '
        Me.dgvMonHoc.AllowUserToAddRows = False
        Me.dgvMonHoc.AllowUserToDeleteRows = False
        Me.dgvMonHoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonHoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_mon, Me.Ky_hieu, Me.Ten_mon})
        Me.dgvMonHoc.Location = New System.Drawing.Point(398, 39)
        Me.dgvMonHoc.Name = "dgvMonHoc"
        Me.dgvMonHoc.ReadOnly = True
        Me.dgvMonHoc.Size = New System.Drawing.Size(394, 244)
        Me.dgvMonHoc.TabIndex = 29
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID học phần"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.ReadOnly = True
        Me.ID_mon.Visible = False
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        Me.Ky_hieu.HeaderText = "Ký hiệu"
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 80
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 250.0!
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.MinimumWidth = 250
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 250
        '
        'dgvGiangVien
        '
        Me.dgvGiangVien.AllowUserToAddRows = False
        Me.dgvGiangVien.AllowUserToDeleteRows = False
        Me.dgvGiangVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGiangVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_cb, Me.Ma_cb, Me.Ho_ten})
        Me.dgvGiangVien.Location = New System.Drawing.Point(398, 320)
        Me.dgvGiangVien.Name = "dgvGiangVien"
        Me.dgvGiangVien.ReadOnly = True
        Me.dgvGiangVien.Size = New System.Drawing.Size(394, 205)
        Me.dgvGiangVien.TabIndex = 30
        '
        'ID_cb
        '
        Me.ID_cb.DataPropertyName = "ID_cb"
        Me.ID_cb.HeaderText = "ID cb"
        Me.ID_cb.Name = "ID_cb"
        Me.ID_cb.ReadOnly = True
        Me.ID_cb.Visible = False
        '
        'Ma_cb
        '
        Me.Ma_cb.DataPropertyName = "Ma_cb"
        Me.Ma_cb.HeaderText = "Mã CB"
        Me.Ma_cb.Name = "Ma_cb"
        Me.Ma_cb.ReadOnly = True
        Me.Ma_cb.Width = 80
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.FillWeight = 250.0!
        Me.Ho_ten.HeaderText = "Họ tên"
        Me.Ho_ten.MinimumWidth = 250
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 250
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(407, 531)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(89, 30)
        Me.cmdAdd.TabIndex = 265
        Me.cmdAdd.Text = "Thêm"
        '
        'ImgMain
        '
        Me.ImgMain.ImageStream = CType(resources.GetObject("ImgMain.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImgMain.Images.SetKeyName(0, "Add.png")
        Me.ImgMain.Images.SetKeyName(1, "Back.png")
        Me.ImgMain.Images.SetKeyName(2, "Bar Chart.png")
        Me.ImgMain.Images.SetKeyName(3, "Comment.png")
        Me.ImgMain.Images.SetKeyName(4, "Delete.png")
        Me.ImgMain.Images.SetKeyName(5, "Email.png")
        Me.ImgMain.Images.SetKeyName(6, "excel.ico")
        Me.ImgMain.Images.SetKeyName(7, "Exit.png")
        Me.ImgMain.Images.SetKeyName(8, "Info.png")
        Me.ImgMain.Images.SetKeyName(9, "Line Chart.png")
        Me.ImgMain.Images.SetKeyName(10, "Load.png")
        Me.ImgMain.Images.SetKeyName(11, "Loading.png")
        Me.ImgMain.Images.SetKeyName(12, "Modify.png")
        Me.ImgMain.Images.SetKeyName(13, "Next.png")
        Me.ImgMain.Images.SetKeyName(14, "Picture.png")
        Me.ImgMain.Images.SetKeyName(15, "Pie Chart.png")
        Me.ImgMain.Images.SetKeyName(16, "Print.png")
        Me.ImgMain.Images.SetKeyName(17, "Profile.png")
        Me.ImgMain.Images.SetKeyName(18, "Save.png")
        Me.ImgMain.Images.SetKeyName(19, "Search.png")
        Me.ImgMain.Images.SetKeyName(20, "Warning.png")
        Me.ImgMain.Images.SetKeyName(21, "word.ico")
        Me.ImgMain.Images.SetKeyName(22, "1665.ico")
        Me.ImgMain.Images.SetKeyName(23, "1669.ico")
        Me.ImgMain.Images.SetKeyName(24, "2402.ico")
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(696, 531)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(89, 30)
        Me.cmdClose.TabIndex = 262
        Me.cmdClose.Text = "Thoát"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ImageIndex = 12
        Me.cmdEdit.ImageList = Me.ImgMain
        Me.cmdEdit.Location = New System.Drawing.Point(504, 531)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 30)
        Me.cmdEdit.TabIndex = 263
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(601, 531)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(89, 30)
        Me.cmdDelete.TabIndex = 264
        Me.cmdDelete.Text = "Xóa"
        '
        'btnXoaMon
        '
        Me.btnXoaMon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoaMon.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaMon.Appearance.Options.UseFont = True
        Me.btnXoaMon.ImageIndex = 4
        Me.btnXoaMon.ImageList = Me.ImgMain
        Me.btnXoaMon.Location = New System.Drawing.Point(494, 3)
        Me.btnXoaMon.Name = "btnXoaMon"
        Me.btnXoaMon.Size = New System.Drawing.Size(89, 30)
        Me.btnXoaMon.TabIndex = 264
        Me.btnXoaMon.Text = "Xóa HP"
        '
        'btnThemMon
        '
        Me.btnThemMon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThemMon.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemMon.Appearance.Options.UseFont = True
        Me.btnThemMon.ImageIndex = 0
        Me.btnThemMon.ImageList = Me.ImgMain
        Me.btnThemMon.Location = New System.Drawing.Point(397, 3)
        Me.btnThemMon.Name = "btnThemMon"
        Me.btnThemMon.Size = New System.Drawing.Size(89, 30)
        Me.btnThemMon.TabIndex = 265
        Me.btnThemMon.Text = "Thêm HP"
        '
        'btnXoaGV
        '
        Me.btnXoaGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoaGV.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaGV.Appearance.Options.UseFont = True
        Me.btnXoaGV.ImageIndex = 4
        Me.btnXoaGV.ImageList = Me.ImgMain
        Me.btnXoaGV.Location = New System.Drawing.Point(494, 287)
        Me.btnXoaGV.Name = "btnXoaGV"
        Me.btnXoaGV.Size = New System.Drawing.Size(89, 30)
        Me.btnXoaGV.TabIndex = 264
        Me.btnXoaGV.Text = "Xóa CB"
        '
        'btnThemGV
        '
        Me.btnThemGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThemGV.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemGV.Appearance.Options.UseFont = True
        Me.btnThemGV.ImageIndex = 0
        Me.btnThemGV.ImageList = Me.ImgMain
        Me.btnThemGV.Location = New System.Drawing.Point(397, 287)
        Me.btnThemGV.Name = "btnThemGV"
        Me.btnThemGV.Size = New System.Drawing.Size(89, 30)
        Me.btnThemGV.TabIndex = 265
        Me.btnThemGV.Text = "Thêm CB"
        '
        'frmESS_BoMon_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.btnThemGV)
        Me.Controls.Add(Me.btnThemMon)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.btnXoaGV)
        Me.Controls.Add(Me.btnXoaMon)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.dgvGiangVien)
        Me.Controls.Add(Me.dgvMonHoc)
        Me.Controls.Add(Me.dgvBoMon)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_BoMon_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách Bộ môn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBoMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMonHoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGiangVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBoMon As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMonHoc As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGiangVien As System.Windows.Forms.DataGridView
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_bm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_bm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_bm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_gv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaMon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemMon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaGV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemGV As DevExpress.XtraEditors.SimpleButton
End Class
