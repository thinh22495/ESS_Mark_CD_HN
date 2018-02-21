<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetLuanVanThiTotNghiep
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabLuanVan = New System.Windows.Forms.TabPage()
        Me.grcViewLuanVan = New DevExpress.XtraGrid.GridControl()
        Me.grdViewLuanVan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TrvLop_ChuanHoa = New ESS_Mark.TrvLop_ChuanHoa()
        Me.labSo_sv = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTBCHT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabThiTotNghiep = New System.Windows.Forms.TabPage()
        Me.grcThiTotNghiep = New DevExpress.XtraGrid.GridControl()
        Me.grdViewThiTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TrvLop_ChuanHoa_ThiTN = New ESS_Mark.TrvLop_ChuanHoa()
        Me.lblSV_Thi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabNoThiTotNghiep = New System.Windows.Forms.TabPage()
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl()
        Me.grdViewNoThiTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TrvLop_ChuanHoa_NoThi = New ESS_Mark.TrvLop_ChuanHoa()
        Me.lblNoThi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnxet = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnThiTN = New System.Windows.Forms.Button()
        Me.btnLV = New System.Windows.Forms.Button()
        Me.cmbLan_xet = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbLan_xet_chuyen = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdChuyenLanXet = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtMon_tot_nghiep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabLuanVan.SuspendLayout()
        CType(Me.grcViewLuanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewLuanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabThiTotNghiep.SuspendLayout()
        CType(Me.grcThiTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewThiTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNoThiTotNghiep.SuspendLayout()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewNoThiTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabLuanVan)
        Me.TabControl1.Controls.Add(Me.TabThiTotNghiep)
        Me.TabControl1.Controls.Add(Me.TabNoThiTotNghiep)
        Me.TabControl1.Location = New System.Drawing.Point(0, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 482)
        Me.TabControl1.TabIndex = 102
        '
        'TabLuanVan
        '
        Me.TabLuanVan.Controls.Add(Me.grcViewLuanVan)
        Me.TabLuanVan.Controls.Add(Me.TrvLop_ChuanHoa)
        Me.TabLuanVan.Controls.Add(Me.labSo_sv)
        Me.TabLuanVan.Controls.Add(Me.Label4)
        Me.TabLuanVan.Controls.Add(Me.txtTBCHT)
        Me.TabLuanVan.Controls.Add(Me.Label1)
        Me.TabLuanVan.Location = New System.Drawing.Point(4, 28)
        Me.TabLuanVan.Name = "TabLuanVan"
        Me.TabLuanVan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLuanVan.Size = New System.Drawing.Size(784, 450)
        Me.TabLuanVan.TabIndex = 0
        Me.TabLuanVan.Text = "Luận văn"
        Me.TabLuanVan.UseVisualStyleBackColor = True
        '
        'grcViewLuanVan
        '
        Me.grcViewLuanVan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcViewLuanVan.Location = New System.Drawing.Point(261, 36)
        Me.grcViewLuanVan.MainView = Me.grdViewLuanVan
        Me.grcViewLuanVan.Name = "grcViewLuanVan"
        Me.grcViewLuanVan.Size = New System.Drawing.Size(520, 363)
        Me.grcViewLuanVan.TabIndex = 254
        Me.grcViewLuanVan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewLuanVan})
        '
        'grdViewLuanVan
        '
        Me.grdViewLuanVan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.grdViewLuanVan.GridControl = Me.grcViewLuanVan
        Me.grdViewLuanVan.Name = "grdViewLuanVan"
        Me.grdViewLuanVan.OptionsSelection.MultiSelect = True
        Me.grdViewLuanVan.OptionsView.ShowGroupPanel = False
        Me.grdViewLuanVan.OptionsView.ShowViewCaption = True
        Me.grdViewLuanVan.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Chọn"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Chon1"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 49
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mã SV"
        Me.GridColumn9.FieldName = "Ma_sv"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 68
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Họ tên"
        Me.GridColumn10.FieldName = "Ho_ten"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 105
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ngày sinh"
        Me.GridColumn11.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn11.FieldName = "Ngay_sinh"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 65
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Tên lớp"
        Me.GridColumn12.FieldName = "Ten_lop"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.GridColumn12.Width = 71
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "TBCHT"
        Me.GridColumn13.FieldName = "TBCHT"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 53
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Xếp hạng"
        Me.GridColumn14.FieldName = "Xep_hang"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        Me.GridColumn14.Width = 88
        '
        'TrvLop_ChuanHoa
        '
        Me.TrvLop_ChuanHoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa.dtLop = Nothing
        Me.TrvLop_ChuanHoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa.Location = New System.Drawing.Point(0, 0)
        Me.TrvLop_ChuanHoa.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa.Name = "TrvLop_ChuanHoa"
        Me.TrvLop_ChuanHoa.Size = New System.Drawing.Size(255, 399)
        Me.TrvLop_ChuanHoa.TabIndex = 108
        '
        'labSo_sv
        '
        Me.labSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(736, 0)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(40, 23)
        Me.labSo_sv.TabIndex = 107
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(594, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Tống số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTBCHT
        '
        Me.txtTBCHT.Location = New System.Drawing.Point(477, 4)
        Me.txtTBCHT.Name = "txtTBCHT"
        Me.txtTBCHT.Size = New System.Drawing.Size(54, 26)
        Me.txtTBCHT.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(262, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Điều kiện TBCHT>=:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabThiTotNghiep
        '
        Me.TabThiTotNghiep.Controls.Add(Me.grcThiTotNghiep)
        Me.TabThiTotNghiep.Controls.Add(Me.TrvLop_ChuanHoa_ThiTN)
        Me.TabThiTotNghiep.Controls.Add(Me.lblSV_Thi)
        Me.TabThiTotNghiep.Controls.Add(Me.Label3)
        Me.TabThiTotNghiep.Location = New System.Drawing.Point(4, 22)
        Me.TabThiTotNghiep.Name = "TabThiTotNghiep"
        Me.TabThiTotNghiep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabThiTotNghiep.Size = New System.Drawing.Size(784, 456)
        Me.TabThiTotNghiep.TabIndex = 1
        Me.TabThiTotNghiep.Text = "Thi tốt nghiệp"
        Me.TabThiTotNghiep.UseVisualStyleBackColor = True
        '
        'grcThiTotNghiep
        '
        Me.grcThiTotNghiep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcThiTotNghiep.Location = New System.Drawing.Point(261, 28)
        Me.grcThiTotNghiep.MainView = Me.grdViewThiTotNghiep
        Me.grcThiTotNghiep.Name = "grcThiTotNghiep"
        Me.grcThiTotNghiep.Size = New System.Drawing.Size(520, 398)
        Me.grcThiTotNghiep.TabIndex = 253
        Me.grcThiTotNghiep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewThiTotNghiep})
        '
        'grdViewThiTotNghiep
        '
        Me.grdViewThiTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn6})
        Me.grdViewThiTotNghiep.GridControl = Me.grcThiTotNghiep
        Me.grdViewThiTotNghiep.Name = "grdViewThiTotNghiep"
        Me.grdViewThiTotNghiep.OptionsSelection.MultiSelect = True
        Me.grdViewThiTotNghiep.OptionsView.ShowGroupPanel = False
        Me.grdViewThiTotNghiep.OptionsView.ShowViewCaption = True
        Me.grdViewThiTotNghiep.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon2"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 49
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mã SV"
        Me.GridColumn2.FieldName = "Ma_sv2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 68
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Họ tên"
        Me.GridColumn3.FieldName = "Ho_ten2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 105
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ngày sinh"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "Ngay_sinh2"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tên lớp"
        Me.GridColumn5.FieldName = "Ten_lop2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 71
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "TBCHT"
        Me.GridColumn7.FieldName = "TBCHT2"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 53
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Xếp hạng"
        Me.GridColumn6.FieldName = "Xep_hang2"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 88
        '
        'TrvLop_ChuanHoa_ThiTN
        '
        Me.TrvLop_ChuanHoa_ThiTN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa_ThiTN.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa_ThiTN.dtLop = Nothing
        Me.TrvLop_ChuanHoa_ThiTN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa_ThiTN.Location = New System.Drawing.Point(-2, 0)
        Me.TrvLop_ChuanHoa_ThiTN.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa_ThiTN.Name = "TrvLop_ChuanHoa_ThiTN"
        Me.TrvLop_ChuanHoa_ThiTN.Size = New System.Drawing.Size(264, 426)
        Me.TrvLop_ChuanHoa_ThiTN.TabIndex = 110
        '
        'lblSV_Thi
        '
        Me.lblSV_Thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSV_Thi.BackColor = System.Drawing.Color.Transparent
        Me.lblSV_Thi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSV_Thi.Location = New System.Drawing.Point(736, 2)
        Me.lblSV_Thi.Name = "lblSV_Thi"
        Me.lblSV_Thi.Size = New System.Drawing.Size(40, 23)
        Me.lblSV_Thi.TabIndex = 109
        Me.lblSV_Thi.Text = "0"
        Me.lblSV_Thi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(594, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Tống số sinh viên:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabNoThiTotNghiep
        '
        Me.TabNoThiTotNghiep.Controls.Add(Me.grcDanhSach)
        Me.TabNoThiTotNghiep.Controls.Add(Me.TrvLop_ChuanHoa_NoThi)
        Me.TabNoThiTotNghiep.Controls.Add(Me.lblNoThi)
        Me.TabNoThiTotNghiep.Controls.Add(Me.Label6)
        Me.TabNoThiTotNghiep.Location = New System.Drawing.Point(4, 22)
        Me.TabNoThiTotNghiep.Name = "TabNoThiTotNghiep"
        Me.TabNoThiTotNghiep.Size = New System.Drawing.Size(784, 456)
        Me.TabNoThiTotNghiep.TabIndex = 2
        Me.TabNoThiTotNghiep.Text = "Nợ thi tốt nghiệp"
        Me.TabNoThiTotNghiep.UseVisualStyleBackColor = True
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(261, 28)
        Me.grcDanhSach.MainView = Me.grdViewNoThiTotNghiep
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(520, 429)
        Me.grcDanhSach.TabIndex = 252
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewNoThiTotNghiep})
        '
        'grdViewNoThiTotNghiep
        '
        Me.grdViewNoThiTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colLy_do, Me.colTBCHT})
        Me.grdViewNoThiTotNghiep.GridControl = Me.grcDanhSach
        Me.grdViewNoThiTotNghiep.Name = "grdViewNoThiTotNghiep"
        Me.grdViewNoThiTotNghiep.OptionsSelection.MultiSelect = True
        Me.grdViewNoThiTotNghiep.OptionsView.ShowGroupPanel = False
        Me.grdViewNoThiTotNghiep.OptionsView.ShowViewCaption = True
        Me.grdViewNoThiTotNghiep.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã SV"
        Me.GridColumn1.FieldName = "Ma_sv3"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 54
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten3"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 1
        Me.colHo_ten.Width = 74
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh3"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 2
        Me.colNgay_sinh.Width = 51
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop3"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        Me.colTen_lop.Width = 47
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.OptionsColumn.ReadOnly = True
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 5
        Me.colLy_do.Width = 216
        '
        'colTBCHT
        '
        Me.colTBCHT.Caption = "TBCHT"
        Me.colTBCHT.FieldName = "TBCHT3"
        Me.colTBCHT.Name = "colTBCHT"
        Me.colTBCHT.OptionsColumn.ReadOnly = True
        Me.colTBCHT.Visible = True
        Me.colTBCHT.VisibleIndex = 4
        Me.colTBCHT.Width = 57
        '
        'TrvLop_ChuanHoa_NoThi
        '
        Me.TrvLop_ChuanHoa_NoThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvLop_ChuanHoa_NoThi.BackColor = System.Drawing.Color.Transparent
        Me.TrvLop_ChuanHoa_NoThi.dtLop = Nothing
        Me.TrvLop_ChuanHoa_NoThi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvLop_ChuanHoa_NoThi.Location = New System.Drawing.Point(-2, 1)
        Me.TrvLop_ChuanHoa_NoThi.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvLop_ChuanHoa_NoThi.Name = "TrvLop_ChuanHoa_NoThi"
        Me.TrvLop_ChuanHoa_NoThi.Size = New System.Drawing.Size(264, 456)
        Me.TrvLop_ChuanHoa_NoThi.TabIndex = 114
        '
        'lblNoThi
        '
        Me.lblNoThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoThi.BackColor = System.Drawing.Color.Transparent
        Me.lblNoThi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoThi.Location = New System.Drawing.Point(736, 2)
        Me.lblNoThi.Name = "lblNoThi"
        Me.lblNoThi.Size = New System.Drawing.Size(40, 23)
        Me.lblNoThi.TabIndex = 113
        Me.lblNoThi.Text = "0"
        Me.lblNoThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(594, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Tống số sinh viên:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(637, 26)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "XÉT SINH VIÊN ĐỦ ĐIỀU KIỆN LÀM ĐỒ ÁN/ LUẬN VĂN, THI TỐT NGHIỆP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.ESS_Mark.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(582, 536)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 28)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "In danh sách"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnxet
        '
        Me.btnxet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnxet.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.btnxet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxet.Location = New System.Drawing.Point(342, 536)
        Me.btnxet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxet.Name = "btnxet"
        Me.btnxet.Size = New System.Drawing.Size(91, 28)
        Me.btnxet.TabIndex = 135
        Me.btnxet.Text = "Xét"
        Me.btnxet.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(706, 536)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 28)
        Me.Button8.TabIndex = 136
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnThiTN
        '
        Me.btnThiTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThiTN.Image = Global.ESS_Mark.My.Resources.Resources.RaTruong
        Me.btnThiTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThiTN.Location = New System.Drawing.Point(433, 536)
        Me.btnThiTN.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThiTN.Name = "btnThiTN"
        Me.btnThiTN.Size = New System.Drawing.Size(148, 28)
        Me.btnThiTN.TabIndex = 137
        Me.btnThiTN.Text = "Chuyển sang thi TN"
        Me.btnThiTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThiTN.UseVisualStyleBackColor = True
        '
        'btnLV
        '
        Me.btnLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLV.Image = Global.ESS_Mark.My.Resources.Resources.NhapTruong
        Me.btnLV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLV.Location = New System.Drawing.Point(433, 536)
        Me.btnLV.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLV.Name = "btnLV"
        Me.btnLV.Size = New System.Drawing.Size(148, 28)
        Me.btnLV.TabIndex = 138
        Me.btnLV.Text = "Chuyển sang làm LV"
        Me.btnLV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLV.UseVisualStyleBackColor = True
        Me.btnLV.Visible = False
        '
        'cmbLan_xet
        '
        Me.cmbLan_xet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_xet.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_xet.Location = New System.Drawing.Point(147, 21)
        Me.cmbLan_xet.Name = "cmbLan_xet"
        Me.cmbLan_xet.Size = New System.Drawing.Size(50, 27)
        Me.cmbLan_xet.TabIndex = 241
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 242
        Me.Label11.Text = "Lần xét:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_xet_chuyen
        '
        Me.cmbLan_xet_chuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_xet_chuyen.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_xet_chuyen.Location = New System.Drawing.Point(375, 21)
        Me.cmbLan_xet_chuyen.Name = "cmbLan_xet_chuyen"
        Me.cmbLan_xet_chuyen.Size = New System.Drawing.Size(50, 27)
        Me.cmbLan_xet_chuyen.TabIndex = 254
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(223, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 23)
        Me.Label7.TabIndex = 255
        Me.Label7.Text = "Chuyển sang lần xét:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdChuyenLanXet
        '
        Me.cmdChuyenLanXet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChuyenLanXet.Image = Global.ESS_Mark.My.Resources.Resources.NhapTruong
        Me.cmdChuyenLanXet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChuyenLanXet.Location = New System.Drawing.Point(137, 536)
        Me.cmdChuyenLanXet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChuyenLanXet.Name = "cmdChuyenLanXet"
        Me.cmdChuyenLanXet.Size = New System.Drawing.Size(202, 28)
        Me.cmdChuyenLanXet.TabIndex = 256
        Me.cmdChuyenLanXet.Text = "Chuyển sang lần xét đã chọn"
        Me.cmdChuyenLanXet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdChuyenLanXet.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.ESS_Mark.My.Resources.Resources.RangBuocMonHoc
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(22, 536)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 28)
        Me.Button2.TabIndex = 255
        Me.Button2.Text = "In danh sách"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtMon_tot_nghiep
        '
        Me.txtMon_tot_nghiep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMon_tot_nghiep.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMon_tot_nghiep.Location = New System.Drawing.Point(501, 21)
        Me.txtMon_tot_nghiep.Name = "txtMon_tot_nghiep"
        Me.txtMon_tot_nghiep.Size = New System.Drawing.Size(283, 26)
        Me.txtMon_tot_nghiep.TabIndex = 257
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 23)
        Me.Label5.TabIndex = 258
        Me.Label5.Text = "Tiêu đề:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_XetLuanVanThiTotNghiep
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMon_tot_nghiep)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdChuyenLanXet)
        Me.Controls.Add(Me.cmbLan_xet_chuyen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbLan_xet)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnxet)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnThiTN)
        Me.Controls.Add(Me.btnLV)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_XetLuanVanThiTotNghiep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XET LUAN VAN, DU DIEU KIEN THI TOT NGHIEP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabLuanVan.ResumeLayout(False)
        Me.TabLuanVan.PerformLayout()
        CType(Me.grcViewLuanVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewLuanVan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabThiTotNghiep.ResumeLayout(False)
        CType(Me.grcThiTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewThiTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNoThiTotNghiep.ResumeLayout(False)
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewNoThiTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabLuanVan As System.Windows.Forms.TabPage
    Friend WithEvents TabThiTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents TabNoThiTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTBCHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSV_Thi As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNoThi As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThiTN As System.Windows.Forms.Button
    Friend WithEvents btnxet As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnLV As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrvLop_ChuanHoa_ThiTN As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents TrvLop_ChuanHoa_NoThi As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents TrvLop_ChuanHoa As ESS_Mark.TrvLop_ChuanHoa
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewNoThiTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcThiTotNghiep As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewThiTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcViewLuanVan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewLuanVan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdChuyenLanXet As System.Windows.Forms.Button
    Friend WithEvents cmbLan_xet_chuyen As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_xet As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtMon_tot_nghiep As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
