<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_DS_ToChucThiPhach_CoDiem
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
        Me.Ho_dem = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRTableCell
        Me.Bang_so = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_chuc_danh4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_tinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Tieu_de_nguoi_ky4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tong_sv = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 25.54166!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(7.874958!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(793.125!, 25.54166!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.stt, Me.Ho_dem, Me.Ten, Me.Ngay_sinh, Me.Ten_tinh, Me.Ten_lop, Me.Bang_so, Me.XrTableCell20})
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
        'Ho_dem
        '
        Me.Ho_dem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Ho_dem.Name = "Ho_dem"
        Me.Ho_dem.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ho_dem.StylePriority.UseBorders = False
        Me.Ho_dem.StylePriority.UsePadding = False
        Me.Ho_dem.StylePriority.UseTextAlignment = False
        Me.Ho_dem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ho_dem.Weight = 0.54171603588347628
        '
        'Ten
        '
        Me.Ten.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Ten.Name = "Ten"
        Me.Ten.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten.StylePriority.UseBorders = False
        Me.Ten.StylePriority.UsePadding = False
        Me.Ten.StylePriority.UseTextAlignment = False
        Me.Ten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten.Weight = 0.26716094321392969
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Weight = 0.41227103880393068
        '
        'Ten_lop
        '
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Weight = 0.47482485940270408
        '
        'Bang_so
        '
        Me.Bang_so.Name = "Bang_so"
        Me.Bang_so.Weight = 0.29219676349179924
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Multiline = True
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Weight = 0.50701373305444741
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.Tieu_de_2, Me.Tieu_de_noi_ky, Me.XrLabel12, Me.Tieu_de_bao_cao, Me.XrLabel4, Me.XrLabel3, Me.Tieu_de_ten_truong, Me.Tieu_de_ten_bo})
        Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.ReportHeader.HeightF = 222.0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(29.16665!, 153.0833!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(771.8333!, 52.70833!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "(Kèm theo Quyết định số: ……../QĐ-CĐN, ngày ……tháng ……năm 20       của Hiệu trưởng" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " trường Cao đẳng nghề Nha Trang)"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_2
        '
        Me.Tieu_de_2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_2.LocationFloat = New DevExpress.Utils.PointFloat(29.16663!, 120.5833!)
        Me.Tieu_de_2.Name = "Tieu_de_2"
        Me.Tieu_de_2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_2.SizeF = New System.Drawing.SizeF(771.8333!, 20.70833!)
        Me.Tieu_de_2.StylePriority.UseFont = False
        Me.Tieu_de_2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(516.634!, 58.08328!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(263.3026!, 23.00002!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 46.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(247.4583!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "NHA TRANG"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_bao_cao
        '
        Me.Tieu_de_bao_cao.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 95.875!)
        Me.Tieu_de_bao_cao.Name = "Tieu_de_bao_cao"
        Me.Tieu_de_bao_cao.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao.SizeF = New System.Drawing.SizeF(771.8333!, 24.70833!)
        Me.Tieu_de_bao_cao.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
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
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(29.16665!, 22.99999!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(247.4583!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CAO ĐẲNG NGHỀ "
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(247.4583!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "UBND TỈNH KHÁNH HÒA"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 40.54166!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(7.874966!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(793.125!, 40.54166!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell9, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell14, Me.XrTableCell13})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "STT"
        Me.XrTableCell4.Weight = 0.12335317331314426
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Họ đệm"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.55329468340194587
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Tên"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 0.27287119405714277
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Ngày sinh"
        Me.XrTableCell7.Weight = 0.42108257825294249
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Lớp"
        Me.XrTableCell2.Weight = 0.48497383779680692
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.Text = "Điểm"
        Me.XrTableCell14.Weight = 0.29844205139236157
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.Text = "Ghi chú"
        Me.XrTableCell13.Weight = 0.51785049013526463
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tong_sv, Me.Tieu_de_nguoi_ky4, Me.Tieu_de_chuc_danh4})
        Me.ReportFooter.HeightF = 218.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tieu_de_chuc_danh4
        '
        Me.Tieu_de_chuc_danh4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh4.LocationFloat = New DevExpress.Utils.PointFloat(559.7501!, 10.00001!)
        Me.Tieu_de_chuc_danh4.Name = "Tieu_de_chuc_danh4"
        Me.Tieu_de_chuc_danh4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh4.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_chuc_danh4.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Nơi sinh"
        Me.XrTableCell1.Weight = 0.39225332249952044
        '
        'Ten_tinh
        '
        Me.Ten_tinh.Name = "Ten_tinh"
        Me.Ten_tinh.Weight = 0.38404477527519215
        '
        'Tieu_de_nguoi_ky4
        '
        Me.Tieu_de_nguoi_ky4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky4.LocationFloat = New DevExpress.Utils.PointFloat(559.7501!, 131.875!)
        Me.Tieu_de_nguoi_ky4.Name = "Tieu_de_nguoi_ky4"
        Me.Tieu_de_nguoi_ky4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky4.SizeF = New System.Drawing.SizeF(234.2499!, 23.0!)
        Me.Tieu_de_nguoi_ky4.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tong_sv
        '
        Me.Tong_sv.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Tong_sv.LocationFloat = New DevExpress.Utils.PointFloat(39.80401!, 10.00001!)
        Me.Tong_sv.Name = "Tong_sv"
        Me.Tong_sv.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tong_sv.SizeF = New System.Drawing.SizeF(322.841!, 22.99998!)
        Me.Tong_sv.StylePriority.UseFont = False
        Me.Tong_sv.StylePriority.UseTextAlignment = False
        Me.Tong_sv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rpt_DS_ToChucThiPhach_CoDiem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(19, 16, 40, 40)
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
    Friend WithEvents Tieu_de_bao_cao As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents stt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ho_dem As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_chuc_danh4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Bang_so As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_tinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_nguoi_ky4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tong_sv As DevExpress.XtraReports.UI.XRLabel
End Class
