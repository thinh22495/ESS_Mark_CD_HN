<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDanhSach_ChuaDat_TotNghiep_BangDiem
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
        Me.Ho_ten = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRTableCell
        Me.ValueRow = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Tieu_de_bao_cao2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.HeadRow1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable2.SizeF = New System.Drawing.SizeF(774.125!, 20.54166!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.stt, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.ValueRow, Me.XrTableCell20})
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
        Me.Ma_sv.Weight = 0.44288776298504884
        '
        'Ho_ten
        '
        Me.Ho_ten.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ho_ten.StylePriority.UseBorders = False
        Me.Ho_ten.StylePriority.UsePadding = False
        Me.Ho_ten.StylePriority.UseTextAlignment = False
        Me.Ho_ten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ho_ten.Weight = 0.65107419349904894
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Weight = 0.37021183527953183
        '
        'Ten_lop
        '
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Weight = 0.25272335115617639
        '
        'ValueRow
        '
        Me.ValueRow.Name = "ValueRow"
        Me.ValueRow.Weight = 0.79148745705895418
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Multiline = True
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Weight = 0.29897616283014422
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 40.0!
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.Tieu_de_bao_cao2, Me.XrLine2, Me.XrLine1, Me.Tieu_de_noi_ky, Me.Tieu_de_bao_cao1, Me.XrLabel4, Me.XrLabel3, Me.Tieu_de_ten_truong, Me.Tieu_de_ten_bo})
        Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.ReportHeader.HeightF = 172.0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        '
        'Tieu_de_bao_cao2
        '
        Me.Tieu_de_bao_cao2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_bao_cao2.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 124.5833!)
        Me.Tieu_de_bao_cao2.Name = "Tieu_de_bao_cao2"
        Me.Tieu_de_bao_cao2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao2.SizeF = New System.Drawing.SizeF(773.9999!, 23.00002!)
        Me.Tieu_de_bao_cao2.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(550.384!, 45.99999!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(155.0!, 8.999996!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(86.125!, 68.99999!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(185.0!, 8.999996!)
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(535.384!, 62.08328!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(244.5526!, 23.00002!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tieu_de_bao_cao1
        '
        Me.Tieu_de_bao_cao1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao1.LocationFloat = New DevExpress.Utils.PointFloat(9.874956!, 100.875!)
        Me.Tieu_de_bao_cao1.Name = "Tieu_de_bao_cao1"
        Me.Tieu_de_bao_cao1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao1.SizeF = New System.Drawing.SizeF(774.125!, 23.70834!)
        Me.Tieu_de_bao_cao1.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(463.0833!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(330.9167!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(463.0833!, 22.99999!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(330.9167!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(9.874956!, 22.99999!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(337.75!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CAO ĐẲNG NGHỀ"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(9.874971!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(337.75!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "UBND THÀNH PHỒ HÀ NỘI"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 60.54166!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(9.874966!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(774.125!, 60.54166!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell1, Me.XrTableCell9, Me.XrTableCell7, Me.XrTableCell2, Me.HeadRow1, Me.XrTableCell13})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "STT"
        Me.XrTableCell4.Weight = 0.12335317331314426
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Mã SV"
        Me.XrTableCell1.Weight = 0.45235402526594914
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
        Me.XrTableCell9.Text = "Họ tên"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 0.66499015986492116
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Ngày sinh"
        Me.XrTableCell7.Weight = 0.37812489472764238
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Lớp"
        Me.XrTableCell2.Weight = 0.258124651810933
        '
        'HeadRow1
        '
        Me.HeadRow1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.HeadRow1.Name = "HeadRow1"
        Me.HeadRow1.StylePriority.UseFont = False
        Me.HeadRow1.Weight = 0.808404649727123
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.Text = "Ghi chú"
        Me.XrTableCell13.Weight = 0.30536585072467742
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_chuc_danh2, Me.Tieu_de_nguoi_ky1, Me.Tieu_de_chuc_danh1})
        Me.ReportFooter.HeightF = 218.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(519.7501!, 184.9167!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.Text = "BAN THƯ KÝ"
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(519.7502!, 22.12506!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.Text = "BAN THƯ KÝ"
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 46.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(337.75!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CÔNG NGHỆ CAO HÀ NỘI"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat(519.7501!, 45.12507!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.Text = "BAN THƯ KÝ"
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptDanhSach_ChuaDat_TotNghiep
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(29, 16, 40, 40)
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents stt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ho_ten As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ValueRow As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents HeadRow1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ma_sv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_bao_cao2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
End Class
