<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_Phach_ToChucThi
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.STT1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SBD = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ho_ten = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_phach1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.STT2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_phach2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Diem_so = New DevExpress.XtraReports.UI.XRTableCell
        Me.Diem_chu = New DevExpress.XtraReports.UI.XRTableCell
        Me.Sua_diem = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Ngay_thi2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ngay_thi1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Phong_thi2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_mon2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Phong_thi1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_mon1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 24.99999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(767.0!, 24.99999!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.STT1, Me.SBD, Me.Ho_ten, Me.Ten_lop, Me.So_phach1, Me.XrTableCell17, Me.STT2, Me.So_phach2, Me.Diem_so, Me.Diem_chu, Me.Sua_diem})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'STT1
        '
        Me.STT1.Name = "STT1"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.STT1.Summary = XrSummary1
        Me.STT1.Weight = 0.16215778733791864
        '
        'SBD
        '
        Me.SBD.Name = "SBD"
        Me.SBD.Weight = 0.16753585148976727
        '
        'Ho_ten
        '
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Weight = 0.71170150627524253
        '
        'Ten_lop
        '
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Weight = 0.27591249249593791
        '
        'So_phach1
        '
        Me.So_phach1.Name = "So_phach1"
        Me.So_phach1.Weight = 0.25277064894137691
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.Weight = 0.18546243938660012
        '
        'STT2
        '
        Me.STT2.Name = "STT2"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.STT2.Summary = XrSummary2
        Me.STT2.Weight = 0.15596480040071528
        '
        'So_phach2
        '
        Me.So_phach2.Name = "So_phach2"
        Me.So_phach2.Weight = 0.24494785124817298
        '
        'Diem_so
        '
        Me.Diem_so.Name = "Diem_so"
        Me.Diem_so.Weight = 0.28503934221130922
        '
        'Diem_chu
        '
        Me.Diem_chu.Name = "Diem_chu"
        Me.Diem_chu.Weight = 0.28895068510570293
        '
        'Sua_diem
        '
        Me.Sua_diem.Name = "Sua_diem"
        Me.Sua_diem.Weight = 0.26955659510725644
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Ngay_thi2, Me.XrLabel2, Me.XrLabel4, Me.Ngay_thi1, Me.Phong_thi2, Me.Ten_mon2, Me.Phong_thi1, Me.Ten_mon1, Me.XrLabel3, Me.XrLabel1, Me.XrLabel9, Me.XrLabel7, Me.XrLabel6, Me.Tieu_de_bao_cao})
        Me.ReportHeader.HeightF = 126.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Ngay_thi2
        '
        Me.Ngay_thi2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Ngay_thi2.LocationFloat = New DevExpress.Utils.PointFloat(535.3333!, 93.0!)
        Me.Ngay_thi2.Name = "Ngay_thi2"
        Me.Ngay_thi2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ngay_thi2.SizeF = New System.Drawing.SizeF(233.6667!, 23.0!)
        Me.Ngay_thi2.StylePriority.UseFont = False
        Me.Ngay_thi2.StylePriority.UseTextAlignment = False
        Me.Ngay_thi2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 93.00003!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(71.54166!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Ngày thi:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 92.99997!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(72.54163!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Ngày thi:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ngay_thi1
        '
        Me.Ngay_thi1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Ngay_thi1.LocationFloat = New DevExpress.Utils.PointFloat(82.54164!, 93.00003!)
        Me.Ngay_thi1.Name = "Ngay_thi1"
        Me.Ngay_thi1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ngay_thi1.SizeF = New System.Drawing.SizeF(324.8751!, 22.99998!)
        Me.Ngay_thi1.StylePriority.UseFont = False
        Me.Ngay_thi1.StylePriority.UseTextAlignment = False
        Me.Ngay_thi1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Phong_thi2
        '
        Me.Phong_thi2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Phong_thi2.LocationFloat = New DevExpress.Utils.PointFloat(535.3333!, 69.12498!)
        Me.Phong_thi2.Name = "Phong_thi2"
        Me.Phong_thi2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Phong_thi2.SizeF = New System.Drawing.SizeF(233.6667!, 23.0!)
        Me.Phong_thi2.StylePriority.UseFont = False
        Me.Phong_thi2.StylePriority.UseTextAlignment = False
        Me.Phong_thi2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_mon2
        '
        Me.Ten_mon2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Ten_mon2.LocationFloat = New DevExpress.Utils.PointFloat(535.3333!, 46.12503!)
        Me.Ten_mon2.Name = "Ten_mon2"
        Me.Ten_mon2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_mon2.SizeF = New System.Drawing.SizeF(233.6667!, 23.0!)
        Me.Ten_mon2.StylePriority.UseFont = False
        Me.Ten_mon2.StylePriority.UseTextAlignment = False
        Me.Ten_mon2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Phong_thi1
        '
        Me.Phong_thi1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Phong_thi1.LocationFloat = New DevExpress.Utils.PointFloat(82.54164!, 69.12505!)
        Me.Phong_thi1.Name = "Phong_thi1"
        Me.Phong_thi1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Phong_thi1.SizeF = New System.Drawing.SizeF(324.8751!, 22.99998!)
        Me.Phong_thi1.StylePriority.UseFont = False
        Me.Phong_thi1.StylePriority.UseTextAlignment = False
        Me.Phong_thi1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_mon1
        '
        Me.Ten_mon1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Ten_mon1.LocationFloat = New DevExpress.Utils.PointFloat(82.54164!, 46.125!)
        Me.Ten_mon1.Name = "Ten_mon1"
        Me.Ten_mon1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_mon1.SizeF = New System.Drawing.SizeF(324.8751!, 23.0!)
        Me.Ten_mon1.StylePriority.UseFont = False
        Me.Ten_mon1.StylePriority.UseTextAlignment = False
        Me.Ten_mon1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 69.12502!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(71.54166!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Phòng thi:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 46.1251!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(71.54166!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Môn:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 69.125!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(72.54163!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Phòng thi:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 46.12503!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(72.54163!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Môn:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(305.2083!, 46.12504!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_bao_cao
        '
        Me.Tieu_de_bao_cao.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.Tieu_de_bao_cao.Name = "Tieu_de_bao_cao"
        Me.Tieu_de_bao_cao.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao.SizeF = New System.Drawing.SizeF(309.7916!, 46.12503!)
        Me.Tieu_de_bao_cao.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 24.99999!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(767.0!, 24.99999!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell1, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell2, Me.XrTableCell10, Me.XrTableCell8, Me.XrTableCell11, Me.XrTableCell9, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "STT"
        Me.XrTableCell4.Weight = 0.16215778733791864
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "SBD"
        Me.XrTableCell5.Weight = 0.16753585148976727
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Họ tên"
        Me.XrTableCell1.Weight = 0.71170138691053031
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Lớp"
        Me.XrTableCell6.Weight = 0.27591249249593791
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Số phách"
        Me.XrTableCell7.Weight = 0.25277076830608908
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Weight = 0.18546243938660012
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "STT"
        Me.XrTableCell10.Weight = 0.15596480040071528
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "Số phách"
        Me.XrTableCell8.Weight = 0.24494785124817298
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "Điểm số"
        Me.XrTableCell11.Weight = 0.28503934221130922
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "Điểm chữ"
        Me.XrTableCell9.Weight = 0.28895068510570293
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Điểm sửa"
        Me.XrTableCell3.Weight = 0.26955659510725644
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.Tieu_de_noi_ky})
        Me.ReportFooter.HeightF = 146.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 40.99998!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(309.2083!, 35.58331!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Cán bộ chấm thi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Ký ghi rõ họ tên)"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(463.7917!, 18.00001!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(309.2083!, 22.99998!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.Text = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rpt_Phach_ToChucThi
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(24, 17, 40, 40)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents STT1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SBD As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ho_ten As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_phach1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents STT2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_phach2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Diem_so As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Diem_chu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Sua_diem As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Phong_thi2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_mon2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Phong_thi1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_mon1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ngay_thi2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ngay_thi1 As DevExpress.XtraReports.UI.XRLabel
End Class
