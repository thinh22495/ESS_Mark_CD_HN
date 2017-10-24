<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_InChungChi_List
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGioi_tinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_tinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colXep_loai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_vao_so = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_cc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDo_dai_So_van_bang = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDo_dai_So_hieu = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTien_to_SoVaoSo = New System.Windows.Forms.TextBox
        Me.btnSave_SoVaoSo = New System.Windows.Forms.Button
        Me.txtTu_So_SoVaoSo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTienTo_SoHieu = New System.Windows.Forms.TextBox
        Me.btnLap_so_SoHieu = New System.Windows.Forms.Button
        Me.txtTu_so_so_hieu = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ckChonAll = New System.Windows.Forms.CheckBox
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton
        Me.tbnThem = New DevExpress.XtraEditors.SimpleButton
        Me.tbnXoa = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(447, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(278, 24)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "DANH SÁCH IN CHỨNG CHỈ"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grcDanhSach.Location = New System.Drawing.Point(12, 98)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(1109, 339)
        Me.grcDanhSach.TabIndex = 188
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTT, Me.colID_sv, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colGioi_tinh, Me.colTen_tinh, Me.colDiem, Me.colXep_loai, Me.colSo_hieu, Me.colSo_vao_so, Me.colTen_cc, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowFooter = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach.OptionsView.ShowViewCaption = True
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 1
        Me.colSTT.Width = 41
        '
        'colID_sv
        '
        Me.colID_sv.Caption = "ID SV"
        Me.colID_sv.FieldName = "ID_sv"
        Me.colID_sv.Name = "colID_sv"
        Me.colID_sv.Visible = True
        Me.colID_sv.VisibleIndex = 2
        Me.colID_sv.Width = 52
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 3
        Me.colMa_sv.Width = 79
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 4
        Me.colHo_ten.Width = 87
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 5
        Me.colNgay_sinh.Width = 80
        '
        'colGioi_tinh
        '
        Me.colGioi_tinh.Caption = "Giới tính"
        Me.colGioi_tinh.FieldName = "Gioi_tinh"
        Me.colGioi_tinh.Name = "colGioi_tinh"
        Me.colGioi_tinh.Visible = True
        Me.colGioi_tinh.VisibleIndex = 6
        Me.colGioi_tinh.Width = 58
        '
        'colTen_tinh
        '
        Me.colTen_tinh.Caption = "Tên tỉnh"
        Me.colTen_tinh.FieldName = "Ten_tinh"
        Me.colTen_tinh.Name = "colTen_tinh"
        Me.colTen_tinh.Visible = True
        Me.colTen_tinh.VisibleIndex = 7
        Me.colTen_tinh.Width = 58
        '
        'colDiem
        '
        Me.colDiem.Caption = "Điểm"
        Me.colDiem.FieldName = "Diem"
        Me.colDiem.Name = "colDiem"
        Me.colDiem.Visible = True
        Me.colDiem.VisibleIndex = 10
        Me.colDiem.Width = 58
        '
        'colXep_loai
        '
        Me.colXep_loai.Caption = "Xếp loại"
        Me.colXep_loai.FieldName = "Xep_loai"
        Me.colXep_loai.Name = "colXep_loai"
        Me.colXep_loai.Visible = True
        Me.colXep_loai.VisibleIndex = 11
        Me.colXep_loai.Width = 58
        '
        'colSo_hieu
        '
        Me.colSo_hieu.Caption = "So_hieu"
        Me.colSo_hieu.FieldName = "So_hieu"
        Me.colSo_hieu.Name = "colSo_hieu"
        Me.colSo_hieu.Visible = True
        Me.colSo_hieu.VisibleIndex = 12
        Me.colSo_hieu.Width = 58
        '
        'colSo_vao_so
        '
        Me.colSo_vao_so.Caption = "Số vào sổ"
        Me.colSo_vao_so.FieldName = "So_vao_so"
        Me.colSo_vao_so.Name = "colSo_vao_so"
        Me.colSo_vao_so.Visible = True
        Me.colSo_vao_so.VisibleIndex = 13
        Me.colSo_vao_so.Width = 58
        '
        'colTen_cc
        '
        Me.colTen_cc.Caption = "Tên CC"
        Me.colTen_cc.FieldName = "Ten_cc"
        Me.colTen_cc.Name = "colTen_cc"
        Me.colTen_cc.Visible = True
        Me.colTen_cc.VisibleIndex = 14
        Me.colTen_cc.Width = 58
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Từ ngày"
        Me.GridColumn1.FieldName = "Tu_ngay"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 15
        Me.GridColumn1.Width = 58
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Đến ngày"
        Me.GridColumn2.FieldName = "Den_ngay"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 16
        Me.GridColumn2.Width = 58
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Từ tháng"
        Me.GridColumn3.FieldName = "Tu_thang"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 17
        Me.GridColumn3.Width = 58
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Đến tháng"
        Me.GridColumn4.FieldName = "Den_thang"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 18
        Me.GridColumn4.Width = 109
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Chọn"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Chon"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nghề"
        Me.GridColumn6.FieldName = "Chuyen_nganh"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Lớp"
        Me.GridColumn7.FieldName = "Ten_lop"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(707, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 23)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "Độ dài số:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDo_dai_So_van_bang
        '
        Me.txtDo_dai_So_van_bang.Location = New System.Drawing.Point(782, 71)
        Me.txtDo_dai_So_van_bang.MaxLength = 2
        Me.txtDo_dai_So_van_bang.Name = "txtDo_dai_So_van_bang"
        Me.txtDo_dai_So_van_bang.Size = New System.Drawing.Size(38, 21)
        Me.txtDo_dai_So_van_bang.TabIndex = 201
        Me.txtDo_dai_So_van_bang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(704, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 23)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "Độ dài số:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDo_dai_So_hieu
        '
        Me.txtDo_dai_So_hieu.Location = New System.Drawing.Point(782, 42)
        Me.txtDo_dai_So_hieu.MaxLength = 2
        Me.txtDo_dai_So_hieu.Name = "txtDo_dai_So_hieu"
        Me.txtDo_dai_So_hieu.Size = New System.Drawing.Size(38, 21)
        Me.txtDo_dai_So_hieu.TabIndex = 199
        Me.txtDo_dai_So_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(521, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 23)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Từ số:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTien_to_SoVaoSo
        '
        Me.txtTien_to_SoVaoSo.Location = New System.Drawing.Point(454, 67)
        Me.txtTien_to_SoVaoSo.MaxLength = 8
        Me.txtTien_to_SoVaoSo.Name = "txtTien_to_SoVaoSo"
        Me.txtTien_to_SoVaoSo.Size = New System.Drawing.Size(59, 21)
        Me.txtTien_to_SoVaoSo.TabIndex = 197
        Me.txtTien_to_SoVaoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave_SoVaoSo
        '
        Me.btnSave_SoVaoSo.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnSave_SoVaoSo.Location = New System.Drawing.Point(647, 68)
        Me.btnSave_SoVaoSo.Name = "btnSave_SoVaoSo"
        Me.btnSave_SoVaoSo.Size = New System.Drawing.Size(30, 24)
        Me.btnSave_SoVaoSo.TabIndex = 196
        Me.btnSave_SoVaoSo.UseVisualStyleBackColor = True
        '
        'txtTu_So_SoVaoSo
        '
        Me.txtTu_So_SoVaoSo.Location = New System.Drawing.Point(574, 68)
        Me.txtTu_So_SoVaoSo.MaxLength = 8
        Me.txtTu_So_SoVaoSo.Name = "txtTu_So_SoVaoSo"
        Me.txtTu_So_SoVaoSo.Size = New System.Drawing.Size(67, 21)
        Me.txtTu_So_SoVaoSo.TabIndex = 195
        Me.txtTu_So_SoVaoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(305, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 23)
        Me.Label9.TabIndex = 194
        Me.Label9.Text = "Số vào sổ - Tiền tố:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(521, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 23)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Từ số:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTienTo_SoHieu
        '
        Me.txtTienTo_SoHieu.Location = New System.Drawing.Point(454, 42)
        Me.txtTienTo_SoHieu.MaxLength = 8
        Me.txtTienTo_SoHieu.Name = "txtTienTo_SoHieu"
        Me.txtTienTo_SoHieu.Size = New System.Drawing.Size(59, 21)
        Me.txtTienTo_SoHieu.TabIndex = 192
        Me.txtTienTo_SoHieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLap_so_SoHieu
        '
        Me.btnLap_so_SoHieu.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.btnLap_so_SoHieu.Location = New System.Drawing.Point(647, 43)
        Me.btnLap_so_SoHieu.Name = "btnLap_so_SoHieu"
        Me.btnLap_so_SoHieu.Size = New System.Drawing.Size(30, 24)
        Me.btnLap_so_SoHieu.TabIndex = 191
        Me.btnLap_so_SoHieu.UseVisualStyleBackColor = True
        '
        'txtTu_so_so_hieu
        '
        Me.txtTu_so_so_hieu.Location = New System.Drawing.Point(574, 43)
        Me.txtTu_so_so_hieu.MaxLength = 8
        Me.txtTu_so_so_hieu.Name = "txtTu_so_so_hieu"
        Me.txtTu_so_so_hieu.Size = New System.Drawing.Size(67, 21)
        Me.txtTu_so_so_hieu.TabIndex = 190
        Me.txtTu_so_so_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(305, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 23)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Số hiệu bằng - Tiền tố:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckChonAll
        '
        Me.ckChonAll.AutoSize = True
        Me.ckChonAll.Location = New System.Drawing.Point(12, 74)
        Me.ckChonAll.Name = "ckChonAll"
        Me.ckChonAll.Size = New System.Drawing.Size(82, 17)
        Me.ckChonAll.TabIndex = 203
        Me.ckChonAll.Text = "Chọn tất cả"
        Me.ckChonAll.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(954, 443)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 28)
        Me.btnPrint.TabIndex = 204
        Me.btnPrint.Text = "In chứng chỉ"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Location = New System.Drawing.Point(1046, 443)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 28)
        Me.btnThoat.TabIndex = 204
        Me.btnThoat.Text = "Thoát"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(587, 443)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 28)
        Me.btnRefresh.TabIndex = 204
        Me.btnRefresh.Text = "Refresh"
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Location = New System.Drawing.Point(771, 443)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(89, 28)
        Me.btnSua.TabIndex = 205
        Me.btnSua.Text = "Sửa"
        '
        'tbnThem
        '
        Me.tbnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbnThem.Location = New System.Drawing.Point(679, 443)
        Me.tbnThem.Name = "tbnThem"
        Me.tbnThem.Size = New System.Drawing.Size(89, 28)
        Me.tbnThem.TabIndex = 206
        Me.tbnThem.Text = "Thêm mới"
        '
        'tbnXoa
        '
        Me.tbnXoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbnXoa.Location = New System.Drawing.Point(862, 443)
        Me.tbnXoa.Name = "tbnXoa"
        Me.tbnXoa.Size = New System.Drawing.Size(89, 28)
        Me.tbnXoa.TabIndex = 207
        Me.tbnXoa.Text = "Xóa"
        '
        'frmESS_InChungChi_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 473)
        Me.Controls.Add(Me.tbnXoa)
        Me.Controls.Add(Me.tbnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ckChonAll)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDo_dai_So_van_bang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDo_dai_So_hieu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTien_to_SoVaoSo)
        Me.Controls.Add(Me.btnSave_SoVaoSo)
        Me.Controls.Add(Me.txtTu_So_SoVaoSo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTienTo_SoHieu)
        Me.Controls.Add(Me.btnLap_so_SoHieu)
        Me.Controls.Add(Me.txtTu_so_so_hieu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmESS_InChungChi_List"
        Me.Text = "In chứng chỉ"
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGioi_tinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_tinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colXep_loai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_vao_so As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_cc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDo_dai_So_van_bang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDo_dai_So_hieu As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTien_to_SoVaoSo As System.Windows.Forms.TextBox
    Friend WithEvents btnSave_SoVaoSo As System.Windows.Forms.Button
    Friend WithEvents txtTu_So_SoVaoSo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTienTo_SoHieu As System.Windows.Forms.TextBox
    Friend WithEvents btnLap_so_SoHieu As System.Windows.Forms.Button
    Friend WithEvents txtTu_so_so_hieu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ckChonAll As System.Windows.Forms.CheckBox
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbnXoa As DevExpress.XtraEditors.SimpleButton
End Class
