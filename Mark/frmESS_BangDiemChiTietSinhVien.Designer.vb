<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BangDiemChiTietSinhVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer ok
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTBC_tich_luy = New System.Windows.Forms.Label
        Me.lblXep_loai_hoc_luc = New System.Windows.Forms.Label
        Me.lblSo_mon_thi_lai = New System.Windows.Forms.Label
        Me.lblSo_mon_hoc_lai = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbID_bangdiem = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.TBCHT = New System.Windows.Forms.Label
        Me.TBCHT4 = New System.Windows.Forms.Label
        Me.Nam_daotao = New System.Windows.Forms.Label
        Me.Xep_loai_tn = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdChuyenNganh = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbAll = New System.Windows.Forms.CheckBox
        Me.grcViewDanhSachSinhVien = New DevExpress.XtraGrid.GridControl
        Me.grdViewDanhSachSinhVien = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcViewDiem = New DevExpress.XtraGrid.GridControl
        Me.grdViewDiem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCMH1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHP_HienThi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnBang_diem_nhom_ky = New DevExpress.XtraEditors.SimpleButton
        Me.btnDiemKT = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_lop
        '
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Location = New System.Drawing.Point(623, 67)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(117, 24)
        Me.cmbID_lop.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(541, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Chọn Lớp:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(754, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "TBC học tập:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(952, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Xếp loại học tập:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'lblTBC_tich_luy
        '
        Me.lblTBC_tich_luy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTBC_tich_luy.BackColor = System.Drawing.Color.Transparent
        Me.lblTBC_tich_luy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTBC_tich_luy.ForeColor = System.Drawing.Color.Red
        Me.lblTBC_tich_luy.Location = New System.Drawing.Point(870, 13)
        Me.lblTBC_tich_luy.Name = "lblTBC_tich_luy"
        Me.lblTBC_tich_luy.Size = New System.Drawing.Size(74, 21)
        Me.lblTBC_tich_luy.TabIndex = 116
        Me.lblTBC_tich_luy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTBC_tich_luy.Visible = False
        '
        'lblXep_loai_hoc_luc
        '
        Me.lblXep_loai_hoc_luc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXep_loai_hoc_luc.BackColor = System.Drawing.Color.Transparent
        Me.lblXep_loai_hoc_luc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai_hoc_luc.ForeColor = System.Drawing.Color.Red
        Me.lblXep_loai_hoc_luc.Location = New System.Drawing.Point(1071, 13)
        Me.lblXep_loai_hoc_luc.Name = "lblXep_loai_hoc_luc"
        Me.lblXep_loai_hoc_luc.Size = New System.Drawing.Size(100, 21)
        Me.lblXep_loai_hoc_luc.TabIndex = 118
        Me.lblXep_loai_hoc_luc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblXep_loai_hoc_luc.Visible = False
        '
        'lblSo_mon_thi_lai
        '
        Me.lblSo_mon_thi_lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_mon_thi_lai.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon_thi_lai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon_thi_lai.ForeColor = System.Drawing.Color.Red
        Me.lblSo_mon_thi_lai.Location = New System.Drawing.Point(1071, 50)
        Me.lblSo_mon_thi_lai.Name = "lblSo_mon_thi_lai"
        Me.lblSo_mon_thi_lai.Size = New System.Drawing.Size(100, 21)
        Me.lblSo_mon_thi_lai.TabIndex = 123
        Me.lblSo_mon_thi_lai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSo_mon_thi_lai.Visible = False
        '
        'lblSo_mon_hoc_lai
        '
        Me.lblSo_mon_hoc_lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_mon_hoc_lai.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon_hoc_lai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon_hoc_lai.ForeColor = System.Drawing.Color.Red
        Me.lblSo_mon_hoc_lai.Location = New System.Drawing.Point(870, 41)
        Me.lblSo_mon_hoc_lai.Name = "lblSo_mon_hoc_lai"
        Me.lblSo_mon_hoc_lai.Size = New System.Drawing.Size(74, 21)
        Me.lblSo_mon_hoc_lai.TabIndex = 122
        Me.lblSo_mon_hoc_lai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSo_mon_hoc_lai.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(952, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Số môn thi lại:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(754, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Số môn học lại:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Items.AddRange(New Object() {"Học kỳ", "Năm Học", "Toàn khoá học"})
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(128, 68)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(63, 24)
        Me.cmbKhoa_hoc.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(17, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Khoá học:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Items.AddRange(New Object() {"Học kỳ", "Năm Học", "Toàn khoá học"})
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(257, 69)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(278, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 127
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(199, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 24)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Nghề:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbID_bangdiem
        '
        Me.cmbID_bangdiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_bangdiem.Items.AddRange(New Object() {"Học kỳ", "Năm học", "Toàn khoá"})
        Me.cmbID_bangdiem.Location = New System.Drawing.Point(128, 10)
        Me.cmbID_bangdiem.Name = "cmbID_bangdiem"
        Me.cmbID_bangdiem.Size = New System.Drawing.Size(142, 24)
        Me.cmbID_bangdiem.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(17, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 24)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Bảng điểm:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(470, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 24)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Năm học:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(549, 12)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(117, 24)
        Me.cmbNam_hoc.TabIndex = 133
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(377, 12)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(71, 24)
        Me.cmbHoc_ky.TabIndex = 131
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(299, 13)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 130
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TBCHT
        '
        Me.TBCHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCHT.BackColor = System.Drawing.Color.Transparent
        Me.TBCHT.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT.Location = New System.Drawing.Point(797, 244)
        Me.TBCHT.Name = "TBCHT"
        Me.TBCHT.Size = New System.Drawing.Size(75, 21)
        Me.TBCHT.TabIndex = 134
        Me.TBCHT.Visible = False
        '
        'TBCHT4
        '
        Me.TBCHT4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCHT4.BackColor = System.Drawing.Color.Transparent
        Me.TBCHT4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT4.Location = New System.Drawing.Point(922, 244)
        Me.TBCHT4.Name = "TBCHT4"
        Me.TBCHT4.Size = New System.Drawing.Size(75, 21)
        Me.TBCHT4.TabIndex = 135
        Me.TBCHT4.Visible = False
        '
        'Nam_daotao
        '
        Me.Nam_daotao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nam_daotao.BackColor = System.Drawing.Color.Transparent
        Me.Nam_daotao.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Nam_daotao.Location = New System.Drawing.Point(1045, 244)
        Me.Nam_daotao.Name = "Nam_daotao"
        Me.Nam_daotao.Size = New System.Drawing.Size(75, 21)
        Me.Nam_daotao.TabIndex = 136
        Me.Nam_daotao.Visible = False
        '
        'Xep_loai_tn
        '
        Me.Xep_loai_tn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Xep_loai_tn.BackColor = System.Drawing.Color.Transparent
        Me.Xep_loai_tn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Xep_loai_tn.Location = New System.Drawing.Point(1165, 244)
        Me.Xep_loai_tn.Name = "Xep_loai_tn"
        Me.Xep_loai_tn.Size = New System.Drawing.Size(75, 21)
        Me.Xep_loai_tn.TabIndex = 137
        Me.Xep_loai_tn.Visible = False
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Items.AddRange(New Object() {"Học kỳ", "Năm Học", "Toàn khoá học"})
        Me.cmbID_he.Location = New System.Drawing.Point(128, 40)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(612, 24)
        Me.cmbID_he.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Hệ đào tạo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.SimpleButton1.Location = New System.Drawing.Point(10, 535)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(121, 27)
        Me.SimpleButton1.TabIndex = 147
        Me.SimpleButton1.Text = "In bảng điểm"
        '
        'cmdChuyenNganh
        '
        Me.cmdChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdChuyenNganh.Items.AddRange(New Object() {"Bảng điểm chuyên ngành chính", "Bảng điểm chuyên ngành 2"})
        Me.cmdChuyenNganh.Location = New System.Drawing.Point(955, 86)
        Me.cmdChuyenNganh.Name = "cmdChuyenNganh"
        Me.cmdChuyenNganh.Size = New System.Drawing.Size(183, 24)
        Me.cmdChuyenNganh.TabIndex = 150
        Me.cmdChuyenNganh.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(839, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Bảng điểm:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.BackColor = System.Drawing.Color.Transparent
        Me.cbAll.Location = New System.Drawing.Point(12, 98)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(100, 20)
        Me.cbAll.TabIndex = 151
        Me.cbAll.Text = "Chọn tất cả"
        Me.cbAll.UseVisualStyleBackColor = False
        '
        'grcViewDanhSachSinhVien
        '
        Me.grcViewDanhSachSinhVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grcViewDanhSachSinhVien.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grcViewDanhSachSinhVien.Location = New System.Drawing.Point(8, 124)
        Me.grcViewDanhSachSinhVien.MainView = Me.grdViewDanhSachSinhVien
        Me.grcViewDanhSachSinhVien.Name = "grcViewDanhSachSinhVien"
        Me.grcViewDanhSachSinhVien.Size = New System.Drawing.Size(379, 405)
        Me.grcViewDanhSachSinhVien.TabIndex = 186
        Me.grcViewDanhSachSinhVien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDanhSachSinhVien})
        '
        'grdViewDanhSachSinhVien
        '
        Me.grdViewDanhSachSinhVien.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh})
        Me.grdViewDanhSachSinhVien.GridControl = Me.grcViewDanhSachSinhVien
        Me.grdViewDanhSachSinhVien.Name = "grdViewDanhSachSinhVien"
        Me.grdViewDanhSachSinhVien.OptionsSelection.MultiSelect = True
        Me.grdViewDanhSachSinhVien.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDanhSachSinhVien.OptionsView.ShowFooter = True
        Me.grdViewDanhSachSinhVien.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 50
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 70
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 120
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 3
        Me.colNgay_sinh.Width = 68
        '
        'grcViewDiem
        '
        Me.grcViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcViewDiem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grcViewDiem.Location = New System.Drawing.Point(393, 124)
        Me.grcViewDiem.MainView = Me.grdViewDiem
        Me.grcViewDiem.Name = "grcViewDiem"
        Me.grcViewDiem.Size = New System.Drawing.Size(821, 405)
        Me.grcViewDiem.TabIndex = 187
        Me.grcViewDiem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewDiem})
        '
        'grdViewDiem
        '
        Me.grdViewDiem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon, Me.colTBCMH1, Me.colTBCHP_HienThi})
        Me.grdViewDiem.GridControl = Me.grcViewDiem
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.OptionsSelection.MultiSelect = True
        Me.grdViewDiem.OptionsView.ShowAutoFilterRow = True
        Me.grdViewDiem.OptionsView.ShowFooter = True
        Me.grdViewDiem.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 0
        Me.colKy_hieu.Width = 70
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên môn"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 540
        '
        'colTBCMH1
        '
        Me.colTBCMH1.Caption = "TBCMH lần 1"
        Me.colTBCMH1.DisplayFormat.FormatString = "n1"
        Me.colTBCMH1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTBCMH1.FieldName = "TBCMH1"
        Me.colTBCMH1.Name = "colTBCMH1"
        Me.colTBCMH1.Visible = True
        Me.colTBCMH1.VisibleIndex = 2
        Me.colTBCMH1.Width = 110
        '
        'colTBCHP_HienThi
        '
        Me.colTBCHP_HienThi.Caption = "TBCMH cao nhất"
        Me.colTBCHP_HienThi.FieldName = "TBCHP_HienThi"
        Me.colTBCHP_HienThi.Name = "colTBCHP_HienThi"
        Me.colTBCHP_HienThi.Visible = True
        Me.colTBCHP_HienThi.VisibleIndex = 3
        Me.colTBCHP_HienThi.Width = 100
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.SimpleButton2.Location = New System.Drawing.Point(451, 535)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(85, 27)
        Me.SimpleButton2.TabIndex = 147
        Me.SimpleButton2.Text = "Thoát"
        '
        'btnBang_diem_nhom_ky
        '
        Me.btnBang_diem_nhom_ky.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBang_diem_nhom_ky.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.btnBang_diem_nhom_ky.Location = New System.Drawing.Point(133, 535)
        Me.btnBang_diem_nhom_ky.Name = "btnBang_diem_nhom_ky"
        Me.btnBang_diem_nhom_ky.Size = New System.Drawing.Size(169, 27)
        Me.btnBang_diem_nhom_ky.TabIndex = 147
        Me.btnBang_diem_nhom_ky.Text = "In bảng điểm nhóm theo kỳ"
        '
        'btnDiemKT
        '
        Me.btnDiemKT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDiemKT.Image = Global.ESS_Mark.My.Resources.Resources.print1
        Me.btnDiemKT.Location = New System.Drawing.Point(306, 535)
        Me.btnDiemKT.Name = "btnDiemKT"
        Me.btnDiemKT.Size = New System.Drawing.Size(139, 27)
        Me.btnDiemKT.TabIndex = 188
        Me.btnDiemKT.Text = "Bảng điểm chi tiết SV"
        '
        'frmESS_BangDiemChiTietSinhVien
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1220, 566)
        Me.Controls.Add(Me.btnDiemKT)
        Me.Controls.Add(Me.grcViewDiem)
        Me.Controls.Add(Me.grcViewDanhSachSinhVien)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.cmdChuyenNganh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.btnBang_diem_nhom_ky)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbID_bangdiem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSo_mon_thi_lai)
        Me.Controls.Add(Me.lblSo_mon_hoc_lai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblXep_loai_hoc_luc)
        Me.Controls.Add(Me.lblTBC_tich_luy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbID_lop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Xep_loai_tn)
        Me.Controls.Add(Me.Nam_daotao)
        Me.Controls.Add(Me.TBCHT4)
        Me.Controls.Add(Me.TBCHT)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_BangDiemChiTietSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In bảng điểm sinh viên"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTBC_tich_luy As System.Windows.Forms.Label
    Friend WithEvents lblXep_loai_hoc_luc As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon_thi_lai As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon_hoc_lai As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbID_bangdiem As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents TBCHT As System.Windows.Forms.Label
    Friend WithEvents TBCHT4 As System.Windows.Forms.Label
    Friend WithEvents Nam_daotao As System.Windows.Forms.Label
    Friend WithEvents Xep_loai_tn As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdChuyenNganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbAll As System.Windows.Forms.CheckBox
    Friend WithEvents grcViewDanhSachSinhVien As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDanhSachSinhVien As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcViewDiem As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewDiem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCMH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHP_HienThi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBang_diem_nhom_ky As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDiemKT As DevExpress.XtraEditors.SimpleButton
End Class
