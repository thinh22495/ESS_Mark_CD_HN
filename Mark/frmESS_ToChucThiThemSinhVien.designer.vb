<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThiThemSinhVien
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
        Me.cmbLocTheo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkAll1 = New System.Windows.Forms.CheckBox
        Me.chkAll2 = New System.Windows.Forms.CheckBox
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton
        Me.btnToTucThi = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.grdViewDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_dem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcViewDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grcViewDanhSachChon = New DevExpress.XtraGrid.GridControl
        Me.grdViewDanhSachChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_dem1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckKhong_du_dk = New System.Windows.Forms.CheckBox
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcViewDanhSachChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLocTheo
        '
        Me.cmbLocTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocTheo.FormattingEnabled = True
        Me.cmbLocTheo.Items.AddRange(New Object() {"Sinh viên thi lại", "Theo lớp hành chính", "Theo sinh viên tốt nghiệp", "Theo sinh viên làm luận văn", "Theo sinh viên đủ đk thi Chính trị"})
        Me.cmbLocTheo.Location = New System.Drawing.Point(500, 32)
        Me.cmbLocTheo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLocTheo.Name = "cmbLocTheo"
        Me.cmbLocTheo.Size = New System.Drawing.Size(236, 27)
        Me.cmbLocTheo.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(378, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Lọc sinh viên theo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll1
        '
        Me.chkAll1.AutoSize = True
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(269, 39)
        Me.chkAll1.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(98, 23)
        Me.chkAll1.TabIndex = 59
        Me.chkAll1.Text = "Chọn tất cả"
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'chkAll2
        '
        Me.chkAll2.AutoSize = True
        Me.chkAll2.BackColor = System.Drawing.Color.Transparent
        Me.chkAll2.Location = New System.Drawing.Point(296, 325)
        Me.chkAll2.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAll2.Name = "chkAll2"
        Me.chkAll2.Size = New System.Drawing.Size(98, 23)
        Me.chkAll2.TabIndex = 61
        Me.chkAll2.Text = "Chọn tất cả"
        Me.chkAll2.UseVisualStyleBackColor = False
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(714, 325)
        Me.txtSo_sv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(44, 21)
        Me.txtSo_sv.TabIndex = 98
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(555, 325)
        Me.lblTong_so.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(159, 21)
        Me.lblTong_so.TabIndex = 97
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(659, 26)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "CHỌN SINH VIÊN BỔ SUNG VÀO LẦN TỔ CHỨC THI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(-2, 0)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(264, 567)
        Me.TrvLop_ChuanHoa.TabIndex = 133
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnAdd.ImageIndex = 22
        Me.btnAdd.Location = New System.Drawing.Point(799, 317)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 30)
        Me.btnAdd.TabIndex = 179
        Me.btnAdd.Text = "Thêm"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Appearance.Options.UseFont = True
        Me.btnDel.Image = Global.ESS_Mark.My.Resources.Resources.Remove
        Me.btnDel.ImageIndex = 22
        Me.btnDel.Location = New System.Drawing.Point(871, 317)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 30)
        Me.btnDel.TabIndex = 180
        Me.btnDel.Text = "Xóa"
        '
        'btnToTucThi
        '
        Me.btnToTucThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToTucThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToTucThi.Appearance.Options.UseFont = True
        Me.btnToTucThi.Image = Global.ESS_Mark.My.Resources.Resources.Add
        Me.btnToTucThi.ImageIndex = 22
        Me.btnToTucThi.Location = New System.Drawing.Point(12, 567)
        Me.btnToTucThi.Name = "btnToTucThi"
        Me.btnToTucThi.Size = New System.Drawing.Size(124, 30)
        Me.btnToTucThi.TabIndex = 181
        Me.btnToTucThi.Text = "Bổ sung sinh viên"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.SimpleButton1.ImageIndex = 22
        Me.SimpleButton1.Location = New System.Drawing.Point(147, 567)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 30)
        Me.SimpleButton1.TabIndex = 182
        Me.SimpleButton1.Text = "Thoát"
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colHo_dem, Me.colTen})
        Me.grdViewDanhSach.GridControl = Me.grcViewDanhSach
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        Me.grdViewDanhSach.OptionsSelection.MultiSelect = True
        Me.grdViewDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDanhSach.OptionsView.ShowFooter = True
        Me.grdViewDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 53
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 83
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Width = 115
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 4
        Me.colNgay_sinh.Width = 71
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 5
        Me.colTen_lop.Width = 54
        '
        'colHo_dem
        '
        Me.colHo_dem.Caption = "Họ đệm"
        Me.colHo_dem.FieldName = "Ho_dem"
        Me.colHo_dem.Name = "colHo_dem"
        Me.colHo_dem.Visible = True
        Me.colHo_dem.VisibleIndex = 2
        Me.colHo_dem.Width = 151
        '
        'colTen
        '
        Me.colTen.Caption = "Tên"
        Me.colTen.FieldName = "Ten"
        Me.colTen.Name = "colTen"
        Me.colTen.Visible = True
        Me.colTen.VisibleIndex = 3
        Me.colTen.Width = 136
        '
        'grcViewDanhSach
        '
        Me.grcViewDanhSach.Location = New System.Drawing.Point(264, 66)
        Me.grcViewDanhSach.MainView = Me.grdViewDanhSach
        Me.grcViewDanhSach.Name = "grcViewDanhSach"
        Me.grcViewDanhSach.Size = New System.Drawing.Size(684, 241)
        Me.grcViewDanhSach.TabIndex = 183
        Me.grcViewDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSach})
        '
        'grcViewDanhSachChon
        '
        Me.grcViewDanhSachChon.Location = New System.Drawing.Point(264, 355)
        Me.grcViewDanhSachChon.MainView = Me.grdViewDanhSachChon
        Me.grcViewDanhSachChon.Name = "grcViewDanhSachChon"
        Me.grcViewDanhSachChon.Size = New System.Drawing.Size(684, 212)
        Me.grcViewDanhSachChon.TabIndex = 184
        Me.grcViewDanhSachChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachChon})
        '
        'grdViewDanhSachChon
        '
        Me.grdViewDanhSachChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.colHo_dem1, Me.GridColumn6})
        Me.grdViewDanhSachChon.GridControl = Me.grcViewDanhSachChon
        Me.grdViewDanhSachChon.Name = "grdViewDanhSachChon"
        Me.grdViewDanhSachChon.OptionsSelection.MultiSelect = True
        Me.grdViewDanhSachChon.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDanhSachChon.OptionsView.ShowFooter = True
        Me.grdViewDanhSachChon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Chọn"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Chon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 64
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã SV"
        Me.GridColumn2.FieldName = "Ma_sv"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "Ho_ten"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 169
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ngày sinh"
        Me.GridColumn4.FieldName = "Ngay_sinh"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 127
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên lớp"
        Me.GridColumn5.FieldName = "Ten_lop"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 87
        '
        'colHo_dem1
        '
        Me.colHo_dem1.Caption = "Họ đệm"
        Me.colHo_dem1.FieldName = "Ho_dem"
        Me.colHo_dem1.Name = "colHo_dem1"
        Me.colHo_dem1.Visible = True
        Me.colHo_dem1.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tên"
        Me.GridColumn6.FieldName = "Ten"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'ckKhong_du_dk
        '
        Me.ckKhong_du_dk.AutoSize = True
        Me.ckKhong_du_dk.BackColor = System.Drawing.Color.Transparent
        Me.ckKhong_du_dk.Location = New System.Drawing.Point(744, 35)
        Me.ckKhong_du_dk.Margin = New System.Windows.Forms.Padding(4)
        Me.ckKhong_du_dk.Name = "ckKhong_du_dk"
        Me.ckKhong_du_dk.Size = New System.Drawing.Size(195, 23)
        Me.ckKhong_du_dk.TabIndex = 185
        Me.ckKhong_du_dk.Text = "Lọc SV không đủ đk dự thi"
        Me.ckKhong_du_dk.UseVisualStyleBackColor = False
        '
        'frmESS_ToChucThiThemSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 599)
        Me.Controls.Add(Me.ckKhong_du_dk)
        Me.Controls.Add(Me.grcViewDanhSachChon)
        Me.Controls.Add(Me.grcViewDanhSach)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnToTucThi)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.chkAll2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLocTheo)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ToChucThiThemSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "BO SUNG SINH VIEN VAO DANH SACH"
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcViewDanhSachChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbLocTheo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnToTucThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdViewDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcViewDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grcViewDanhSachChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckKhong_du_dk As System.Windows.Forms.CheckBox
    Friend WithEvents colHo_dem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_dem1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
