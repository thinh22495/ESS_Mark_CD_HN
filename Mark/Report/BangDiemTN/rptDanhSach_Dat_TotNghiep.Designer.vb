<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDanhSach_Dat_TotNghiep
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.stt = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ma_sv = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ho_dem = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtTen = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_tinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Diem_toan_khoa = New DevExpress.XtraReports.UI.XRTableCell
        Me.ValueRow = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCTN = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCHT = New DevExpress.XtraReports.UI.XRTableCell
        Me.Xep_hang = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRLabel
        Me.Chuyen_nganh = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_he = New DevExpress.XtraReports.UI.XRLabel
        Me.Khoa_hoc = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Tieu_de_bao_cao1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.HeadRow1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.Headrow = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.txtTong_so = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky2 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 20.54166!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(9.874958!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1059.583!, 20.54166!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.stt, Me.Ma_sv, Me.Ho_dem, Me.txtTen, Me.Ngay_sinh, Me.Ten_tinh, Me.Diem_toan_khoa, Me.ValueRow, Me.TBCTN, Me.TBCHT, Me.Xep_hang, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'stt
        '
        Me.stt.Name = "stt"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.stt.Summary = XrSummary1
        Me.stt.Weight = 0.12077185087451969
        '
        'Ma_sv
        '
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.StylePriority.UseTextAlignment = False
        Me.Ma_sv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.Ma_sv.Weight = 0.37315405051599915
        '
        'Ho_dem
        '
        Me.Ho_dem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Ho_dem.Name = "Ho_dem"
        Me.Ho_dem.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ho_dem.StylePriority.UseBorders = False
        Me.Ho_dem.StylePriority.UsePadding = False
        Me.Ho_dem.StylePriority.UseTextAlignment = False
        Me.Ho_dem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ho_dem.Weight = 0.57073898029448433
        '
        'txtTen
        '
        Me.txtTen.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.StylePriority.UseBorders = False
        Me.txtTen.Weight = 0.22627730649271544
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.StylePriority.UseTextAlignment = False
        Me.Ngay_sinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Ngay_sinh.Weight = 0.2904386470585214
        '
        'Ten_tinh
        '
        Me.Ten_tinh.Name = "Ten_tinh"
        Me.Ten_tinh.StylePriority.UseTextAlignment = False
        Me.Ten_tinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Ten_tinh.Weight = 0.32560085283109641
        '
        'Diem_toan_khoa
        '
        Me.Diem_toan_khoa.Name = "Diem_toan_khoa"
        Me.Diem_toan_khoa.StylePriority.UseTextAlignment = False
        Me.Diem_toan_khoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Diem_toan_khoa.Weight = 0.15775263085111288
        '
        'ValueRow
        '
        Me.ValueRow.Name = "ValueRow"
        Me.ValueRow.Weight = 1.0099347179881142
        '
        'TBCTN
        '
        Me.TBCTN.Name = "TBCTN"
        Me.TBCTN.StylePriority.UseTextAlignment = False
        Me.TBCTN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TBCTN.Weight = 0.19470246779659586
        '
        'TBCHT
        '
        Me.TBCHT.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT.Multiline = True
        Me.TBCHT.Name = "TBCHT"
        Me.TBCHT.StylePriority.UseFont = False
        Me.TBCHT.StylePriority.UseTextAlignment = False
        Me.TBCHT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TBCHT.Weight = 0.13630279126310033
        '
        'Xep_hang
        '
        Me.Xep_hang.Name = "Xep_hang"
        Me.Xep_hang.Text = "Trung bình khá"
        Me.Xep_hang.Weight = 0.36765209566693491
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Weight = 0.23833726612515582
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 37.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 40.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Ten_lop, Me.Chuyen_nganh, Me.Ten_he, Me.Khoa_hoc, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel1, Me.Tieu_de_ten_truong, Me.XrLine1, Me.Tieu_de_bao_cao1, Me.Tieu_de_ten_bo, Me.XrLabel2})
        Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.ReportHeader.HeightF = 136.0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        '
        'Ten_lop
        '
        Me.Ten_lop.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Ten_lop.LocationFloat = New DevExpress.Utils.PointFloat(936.0833!, 102.9166!)
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_lop.SizeF = New System.Drawing.SizeF(133.3746!, 23.0!)
        Me.Ten_lop.StylePriority.UseFont = False
        Me.Ten_lop.StylePriority.UseTextAlignment = False
        Me.Ten_lop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Chuyen_nganh
        '
        Me.Chuyen_nganh.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Chuyen_nganh.LocationFloat = New DevExpress.Utils.PointFloat(581.9366!, 102.9166!)
        Me.Chuyen_nganh.Name = "Chuyen_nganh"
        Me.Chuyen_nganh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Chuyen_nganh.SizeF = New System.Drawing.SizeF(255.7916!, 23.0!)
        Me.Chuyen_nganh.StylePriority.UseFont = False
        Me.Chuyen_nganh.StylePriority.UseTextAlignment = False
        Me.Chuyen_nganh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_he
        '
        Me.Ten_he.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Ten_he.LocationFloat = New DevExpress.Utils.PointFloat(303.8117!, 102.9166!)
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_he.SizeF = New System.Drawing.SizeF(184.1249!, 23.0!)
        Me.Ten_he.StylePriority.UseFont = False
        Me.Ten_he.StylePriority.UseTextAlignment = False
        Me.Ten_he.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Khoa_hoc
        '
        Me.Khoa_hoc.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Khoa_hoc.LocationFloat = New DevExpress.Utils.PointFloat(93.04153!, 102.9166!)
        Me.Khoa_hoc.Name = "Khoa_hoc"
        Me.Khoa_hoc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Khoa_hoc.SizeF = New System.Drawing.SizeF(97.16656!, 23.0!)
        Me.Khoa_hoc.StylePriority.UseFont = False
        Me.Khoa_hoc.StylePriority.UseTextAlignment = False
        Me.Khoa_hoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(854.9584!, 102.9166!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(81.12482!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Lớp học:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(513.3118!, 102.9166!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(68.62488!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Ngành:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(237.2701!, 102.9166!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(66.54156!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Hệ ĐT:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(663.208!, 22.99999!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(406.25!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(663.208!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(406.25!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(10.87497!, 22.99999!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(406.25!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CĐ NGHỀ KTCN VIỆT NAM - HÀN QUỐC"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(101.804!, 45.99997!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(226.0!, 8.999996!)
        '
        'Tieu_de_bao_cao1
        '
        Me.Tieu_de_bao_cao1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao1.LocationFloat = New DevExpress.Utils.PointFloat(10.87497!, 63.54166!)
        Me.Tieu_de_bao_cao1.Name = "Tieu_de_bao_cao1"
        Me.Tieu_de_bao_cao1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao1.SizeF = New System.Drawing.SizeF(1058.583!, 28.70833!)
        Me.Tieu_de_bao_cao1.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao1.Text = "DANH SÁCH HỌC SINH TỐT NGHIỆP"
        Me.Tieu_de_bao_cao1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(10.87497!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(406.25!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "UỶ BAN NHÂN DÂN TỈNH NGHỆ AN"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.87497!, 102.9166!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(82.16656!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Khóa học:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 81.54166!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(9.874966!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1059.583!, 81.54166!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell1, Me.XrTableCell9, Me.XrTableCell7, Me.XrTableCell11, Me.XrTableCell12, Me.HeadRow1, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell3, Me.XrTableCell13})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "TT"
        Me.XrTableCell4.Weight = 0.12335317331314426
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Mã SV"
        Me.XrTableCell1.Weight = 0.38112959984642042
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Họ và tên"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 0.81405140589597613
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Ngày sinh"
        Me.XrTableCell7.Weight = 0.29664722125316967
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "Nơi sinh"
        Me.XrTableCell11.Weight = 0.33255951534957118
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "TBC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TK"
        Me.XrTableCell12.Weight = 0.16112386592956368
        '
        'HeadRow1
        '
        Me.HeadRow1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrTable3})
        Me.HeadRow1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.HeadRow1.Name = "HeadRow1"
        Me.HeadRow1.StylePriority.UseFont = False
        Me.HeadRow1.Weight = 1.0315206406190032
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00003433228!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(265.7717!, 22.99999!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Kết quả tốt nghiệp"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable3
        '
        Me.XrTable3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 22.99999!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(265.8547!, 58.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Headrow})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'Headrow
        '
        Me.Headrow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Headrow.Name = "Headrow"
        Me.Headrow.StylePriority.UseFont = False
        Me.Headrow.Weight = 3
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "TBTN"
        Me.XrTableCell2.Weight = 0.19886420139710465
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "ĐXL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TN"
        Me.XrTableCell5.Weight = 0.13921619462108364
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.Text = "XHTN"
        Me.XrTableCell3.Weight = 0.37551002309166148
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Multiline = True
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.Text = "GHI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CHÚ"
        Me.XrTableCell13.Weight = 0.24343158823070413
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_noi_ky, Me.txtTong_so, Me.Tieu_de_nguoi_ky3, Me.Tieu_de_chuc_danh3, Me.Tieu_de_nguoi_ky1, Me.Tieu_de_chuc_danh1, Me.Tieu_de_chuc_danh2, Me.Tieu_de_nguoi_ky2})
        Me.ReportFooter.HeightF = 164.8334!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(745.5836!, 10.00001!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(328.4166!, 22.99998!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtTong_so
        '
        Me.txtTong_so.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtTong_so.LocationFloat = New DevExpress.Utils.PointFloat(10.87497!, 3.999996!)
        Me.txtTong_so.Name = "txtTong_so"
        Me.txtTong_so.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTong_so.SizeF = New System.Drawing.SizeF(561.0122!, 22.99999!)
        Me.txtTong_so.StylePriority.UseFont = False
        Me.txtTong_so.StylePriority.UseTextAlignment = False
        Me.txtTong_so.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tieu_de_nguoi_ky3
        '
        Me.Tieu_de_nguoi_ky3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky3.LocationFloat = New DevExpress.Utils.PointFloat(816.4168!, 141.8334!)
        Me.Tieu_de_nguoi_ky3.Name = "Tieu_de_nguoi_ky3"
        Me.Tieu_de_nguoi_ky3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky3.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_nguoi_ky3.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh3
        '
        Me.Tieu_de_chuc_danh3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh3.LocationFloat = New DevExpress.Utils.PointFloat(816.4168!, 36.04164!)
        Me.Tieu_de_chuc_danh3.Name = "Tieu_de_chuc_danh3"
        Me.Tieu_de_chuc_danh3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh3.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh3.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(12.95827!, 141.8334!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(12.95827!, 36.04164!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat(404.4585!, 36.04164!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky2
        '
        Me.Tieu_de_nguoi_ky2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky2.LocationFloat = New DevExpress.Utils.PointFloat(404.4585!, 141.8333!)
        Me.Tieu_de_nguoi_ky2.Name = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky2.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_nguoi_ky2.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptDanhSach_Dat_TotNghiep
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(54, 39, 37, 40)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de_bao_cao1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents stt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ho_dem As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ValueRow As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents HeadRow1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_nguoi_ky2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTen As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTong_so As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Xep_hang As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents Headrow As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Chuyen_nganh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_he As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Khoa_hoc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ma_sv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCTN As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_tinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Diem_toan_khoa As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
End Class
