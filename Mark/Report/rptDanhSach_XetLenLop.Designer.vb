<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDanhSach_XetLenLop
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
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.stt = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Tieu_de_bao_cao = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Tieu_de2 = New DevExpress.XtraReports.UI.XRLabel
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.table2 = New DevExpress.XtraReports.UI.XRTable
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.Ma_sv = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ho_ten = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Tong_tiet = New DevExpress.XtraReports.UI.XRTableCell
        Me.He_so_no = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_mon_no = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_mon_no = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_nguoi_ky4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.table1 = New DevExpress.XtraReports.UI.XRTable
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(755.3334!, 0.0!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label3.SizeF = New System.Drawing.SizeF(358.6666!, 23.0!)
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseTextAlignment = False
        Me.label3.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableCell3
        '
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.Text = "Tên lớp"
        Me.tableCell3.Weight = 0.21985730494871486
        '
        'stt
        '
        Me.stt.Name = "stt"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.stt.Summary = XrSummary1
        Me.stt.Weight = 0.16008172308066881
        '
        'tableCell1
        '
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.Text = "Mã sinh viên"
        Me.tableCell1.Weight = 0.38862403014609326
        '
        'Ten_lop
        '
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Weight = 0.21985728604267343
        '
        'tableCell4
        '
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.Text = "STT"
        Me.tableCell4.Weight = 0.16008172308066881
        '
        'Tieu_de_bao_cao
        '
        Me.Tieu_de_bao_cao.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 86.04164!)
        Me.Tieu_de_bao_cao.Name = "Tieu_de_bao_cao"
        Me.Tieu_de_bao_cao.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao.SizeF = New System.Drawing.SizeF(1104.0!, 28.00001!)
        Me.Tieu_de_bao_cao.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de2, Me.Tieu_de_bao_cao, Me.label4, Me.label3, Me.Tieu_de_ten_truong, Me.Tieu_de_ten_bo, Me.Tieu_de_noi_ky})
        Me.ReportHeader.HeightF = 162.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Tieu_de2
        '
        Me.Tieu_de2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 114.0417!)
        Me.Tieu_de2.Name = "Tieu_de2"
        Me.Tieu_de2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de2.SizeF = New System.Drawing.SizeF(1104.0!, 28.00001!)
        Me.Tieu_de2.StylePriority.UseFont = False
        Me.Tieu_de2.StylePriority.UseTextAlignment = False
        Me.Tieu_de2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(755.3334!, 22.99999!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label4.SizeF = New System.Drawing.SizeF(358.6666!, 23.0!)
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 22.99999!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(404.0834!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CĐ NGHỀ CNC HÀ NỘI"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(404.0834!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "UBND TP HÀ NỘI"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(858.8333!, 53.04166!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(255.1667!, 23.0!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 40.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'table2
        '
        Me.table2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(1104.0!, 22.0!)
        Me.table2.StylePriority.UseBorders = False
        Me.table2.StylePriority.UseFont = False
        Me.table2.StylePriority.UseTextAlignment = False
        Me.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.stt, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.Tong_tiet, Me.He_so_no, Me.So_mon_no, Me.Ten_mon_no})
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1
        '
        'Ma_sv
        '
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.Weight = 0.38862410293288074
        '
        'Ho_ten
        '
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.Ho_ten.StylePriority.UsePadding = False
        Me.Ho_ten.StylePriority.UseTextAlignment = False
        Me.Ho_ten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ho_ten.Weight = 0.65037492965157728
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Weight = 0.42387567878743926
        '
        'Tong_tiet
        '
        Me.Tong_tiet.Name = "Tong_tiet"
        Me.Tong_tiet.Weight = 0.26975452152844681
        '
        'He_so_no
        '
        Me.He_so_no.Name = "He_so_no"
        Me.He_so_no.Weight = 0.26456096061893641
        '
        'So_mon_no
        '
        Me.So_mon_no.Name = "So_mon_no"
        Me.So_mon_no.Weight = 0.29696008814777919
        '
        'Ten_mon_no
        '
        Me.Ten_mon_no.Name = "Ten_mon_no"
        Me.Ten_mon_no.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.Ten_mon_no.StylePriority.UsePadding = False
        Me.Ten_mon_no.StylePriority.UseTextAlignment = False
        Me.Ten_mon_no.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_mon_no.Weight = 1.8381722895910695
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4, Me.tableCell1, Me.tableCell5, Me.tableCell2, Me.tableCell3, Me.XrTableCell1, Me.XrTableCell4, Me.XrTableCell3, Me.XrTableCell2})
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1
        '
        'tableCell5
        '
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.Text = "Họ tên"
        Me.tableCell5.Weight = 0.65037496254211935
        '
        'tableCell2
        '
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.Text = "Ngày sinh"
        Me.tableCell2.Weight = 0.42387571900640986
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Số tiết nợ"
        Me.XrTableCell1.Weight = 0.26975454360112977
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Hệ số nợ"
        Me.XrTableCell4.Weight = 0.26456074022814163
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Số môn nợ"
        Me.XrTableCell3.Weight = 0.29696041971898079
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Tên môn nợ"
        Me.XrTableCell2.Weight = 1.8381729923170758
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 40.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_nguoi_ky4, Me.Tieu_de_chuc_danh4, Me.Tieu_de_nguoi_ky3, Me.Tieu_de_chuc_danh3, Me.Tieu_de_nguoi_ky2, Me.Tieu_de_chuc_danh2})
        Me.ReportFooter.HeightF = 158.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tieu_de_nguoi_ky4
        '
        Me.Tieu_de_nguoi_ky4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky4.LocationFloat = New DevExpress.Utils.PointFloat(888.625!, 118.7916!)
        Me.Tieu_de_nguoi_ky4.Name = "Tieu_de_nguoi_ky4"
        Me.Tieu_de_nguoi_ky4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky4.SizeF = New System.Drawing.SizeF(193.125!, 22.99999!)
        Me.Tieu_de_nguoi_ky4.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh4
        '
        Me.Tieu_de_chuc_danh4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh4.LocationFloat = New DevExpress.Utils.PointFloat(888.625!, 21.99999!)
        Me.Tieu_de_chuc_danh4.Name = "Tieu_de_chuc_danh4"
        Me.Tieu_de_chuc_danh4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh4.SizeF = New System.Drawing.SizeF(193.125!, 23.0!)
        Me.Tieu_de_chuc_danh4.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky3
        '
        Me.Tieu_de_nguoi_ky3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky3.LocationFloat = New DevExpress.Utils.PointFloat(432.7501!, 118.7916!)
        Me.Tieu_de_nguoi_ky3.Name = "Tieu_de_nguoi_ky3"
        Me.Tieu_de_nguoi_ky3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky3.SizeF = New System.Drawing.SizeF(197.125!, 22.99999!)
        Me.Tieu_de_nguoi_ky3.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh3
        '
        Me.Tieu_de_chuc_danh3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh3.LocationFloat = New DevExpress.Utils.PointFloat(432.7501!, 21.99999!)
        Me.Tieu_de_chuc_danh3.Name = "Tieu_de_chuc_danh3"
        Me.Tieu_de_chuc_danh3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh3.SizeF = New System.Drawing.SizeF(197.125!, 23.0!)
        Me.Tieu_de_chuc_danh3.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky2
        '
        Me.Tieu_de_nguoi_ky2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky2.LocationFloat = New DevExpress.Utils.PointFloat(7.000007!, 118.7916!)
        Me.Tieu_de_nguoi_ky2.Name = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky2.SizeF = New System.Drawing.SizeF(209.125!, 22.99999!)
        Me.Tieu_de_nguoi_ky2.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat(7.000007!, 22.0!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF(209.125!, 23.0!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.Text = "NGƯỜI LẬP BIỂU"
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.PageHeader.HeightF = 25.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'table1
        '
        Me.table1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(1104.0!, 25.0!)
        Me.table1.StylePriority.UseBorders = False
        Me.table1.StylePriority.UseFont = False
        Me.table1.StylePriority.UseTextAlignment = False
        Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.Detail.HeightF = 22.0!
        Me.Detail.Name = "Detail"
        '
        'rptDanhSach_XetLenLop
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter, Me.PageHeader})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(24, 12, 40, 40)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "10.1"
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents stt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_bao_cao As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents Ma_sv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ho_ten As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Tieu_de_nguoi_ky4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tong_tiet As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents He_so_no As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_mon_no As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_mon_no As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
End Class
