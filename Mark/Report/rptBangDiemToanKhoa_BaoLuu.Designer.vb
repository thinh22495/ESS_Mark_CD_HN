<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBangDiemToanKhoa_BaoLuu
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport
        Me.RptBangDiemToanKhoa_Sub12 = New ESS_Mark.rptBangDiemToanKhoa_Sub1
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.RptBangDiemToanKhoa_Sub1 = New ESS_Mark.rptBangDiemToanKhoa_Sub
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_mon = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_hoc_trinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCHP = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_nganh = New DevExpress.XtraReports.UI.XRLabel
        Me.Chuyen_nganh = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_he = New DevExpress.XtraReports.UI.XRLabel
        Me.Ma_sv = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.Que_quan = New DevExpress.XtraReports.UI.XRLabel
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRLabel
        Me.Ho_ten = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.tieu_de = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.TBCHT = New DevExpress.XtraReports.UI.XRLabel
        Me.Xep_loai = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.GHGHGH = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.RptBangDiemToanKhoa_Sub12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptBangDiemToanKhoa_Sub1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(425.0414!, 0.0!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = Me.RptBangDiemToanKhoa_Sub12
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(395.96!, 22.99999!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(23.00001!, 0.0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.RptBangDiemToanKhoa_Sub1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(395.9585!, 22.99999!)
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrTable1, Me.Ten_nganh, Me.Chuyen_nganh, Me.Ten_he, Me.Ma_sv, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.Que_quan, Me.Ngay_sinh, Me.Ho_ten, Me.XrLabel8, Me.XrLabel6, Me.XrLabel5, Me.tieu_de, Me.XrLine2, Me.XrLine1, Me.XrLabel3, Me.XrLabel2, Me.Tieu_de_ten_truong, Me.Tieu_de_ten_bo})
        Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.ReportHeader.HeightF = 271.0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(23.00001!, 236.0416!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(395.9585!, 34.9584!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.Ten_mon, Me.So_hoc_trinh, Me.XrTableCell5, Me.TBCHP})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "STT"
        Me.XrTableCell1.Weight = 0.27944264675068142
        '
        'Ten_mon
        '
        Me.Ten_mon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_mon.StylePriority.UseFont = False
        Me.Ten_mon.StylePriority.UsePadding = False
        Me.Ten_mon.StylePriority.UseTextAlignment = False
        Me.Ten_mon.Text = "TÊN MÔN (HỌC PHẦN)"
        Me.Ten_mon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Ten_mon.Weight = 2.3078828311497479
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.Text = " ĐVHT"
        Me.So_hoc_trinh.Weight = 0.42254220047402014
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Điểm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L1"
        Me.XrTableCell5.Weight = 0.37019041031752542
        '
        'TBCHP
        '
        Me.TBCHP.Multiline = True
        Me.TBCHP.Name = "TBCHP"
        Me.TBCHP.Text = "Điểm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L2"
        Me.TBCHP.Weight = 0.37019041031752542
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(425.0415!, 236.0416!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(395.96!, 34.9584!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell6})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "STT"
        Me.XrTableCell7.Weight = 0.27940389948769839
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "TÊN MÔN (HỌC PHẦN)"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 2.3078759098302295
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = " ĐVHT"
        Me.XrTableCell3.Weight = 0.42251546412034058
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Điểm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L1"
        Me.XrTableCell4.Weight = 0.37023380269694317
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Điểm L2"
        Me.XrTableCell6.Weight = 0.37023391108756626
        '
        'Ten_nganh
        '
        Me.Ten_nganh.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ten_nganh.LocationFloat = New DevExpress.Utils.PointFloat(550.1588!, 166.7917!)
        Me.Ten_nganh.Multiline = True
        Me.Ten_nganh.Name = "Ten_nganh"
        Me.Ten_nganh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_nganh.SizeF = New System.Drawing.SizeF(154.6627!, 23.00002!)
        Me.Ten_nganh.StylePriority.UseFont = False
        Me.Ten_nganh.StylePriority.UseTextAlignment = False
        Me.Ten_nganh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Chuyen_nganh
        '
        Me.Chuyen_nganh.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Chuyen_nganh.LocationFloat = New DevExpress.Utils.PointFloat(549.1588!, 189.7917!)
        Me.Chuyen_nganh.Multiline = True
        Me.Chuyen_nganh.Name = "Chuyen_nganh"
        Me.Chuyen_nganh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Chuyen_nganh.SizeF = New System.Drawing.SizeF(155.6627!, 23.00002!)
        Me.Chuyen_nganh.StylePriority.UseFont = False
        Me.Chuyen_nganh.StylePriority.UseTextAlignment = False
        Me.Chuyen_nganh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ten_he
        '
        Me.Ten_he.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ten_he.LocationFloat = New DevExpress.Utils.PointFloat(550.1588!, 143.7917!)
        Me.Ten_he.Multiline = True
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_he.SizeF = New System.Drawing.SizeF(154.6627!, 23.0!)
        Me.Ten_he.StylePriority.UseFont = False
        Me.Ten_he.StylePriority.UseTextAlignment = False
        Me.Ten_he.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ma_sv
        '
        Me.Ma_sv.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ma_sv.LocationFloat = New DevExpress.Utils.PointFloat(255.2165!, 143.7917!)
        Me.Ma_sv.Multiline = True
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ma_sv.SizeF = New System.Drawing.SizeF(169.742!, 23.00002!)
        Me.Ma_sv.StylePriority.UseFont = False
        Me.Ma_sv.StylePriority.UseTextAlignment = False
        Me.Ma_sv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(434.3254!, 166.7917!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(114.8334!, 23.00002!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Ngành:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(434.3254!, 189.7917!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(114.8334!, 22.99998!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Chuyên ngành:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(434.3254!, 143.7917!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(114.8334!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Hệ đào tạo :"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(175.5121!, 143.7917!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(79.70438!, 23.00002!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Mã số SV:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Que_quan
        '
        Me.Que_quan.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Que_quan.LocationFloat = New DevExpress.Utils.PointFloat(550.1589!, 120.7917!)
        Me.Que_quan.Multiline = True
        Me.Que_quan.Name = "Que_quan"
        Me.Que_quan.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Que_quan.SizeF = New System.Drawing.SizeF(154.6626!, 23.00002!)
        Me.Que_quan.StylePriority.UseFont = False
        Me.Que_quan.StylePriority.UseTextAlignment = False
        Me.Que_quan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ngay_sinh.LocationFloat = New DevExpress.Utils.PointFloat(255.2165!, 166.7918!)
        Me.Ngay_sinh.Multiline = True
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ngay_sinh.SizeF = New System.Drawing.SizeF(169.742!, 23.00002!)
        Me.Ngay_sinh.StylePriority.UseFont = False
        Me.Ngay_sinh.StylePriority.UseTextAlignment = False
        Me.Ngay_sinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ho_ten
        '
        Me.Ho_ten.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Ho_ten.LocationFloat = New DevExpress.Utils.PointFloat(255.2165!, 120.7917!)
        Me.Ho_ten.Multiline = True
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ho_ten.SizeF = New System.Drawing.SizeF(169.742!, 23.00002!)
        Me.Ho_ten.StylePriority.UseFont = False
        Me.Ho_ten.StylePriority.UseTextAlignment = False
        Me.Ho_ten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(434.3254!, 120.7917!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(114.8332!, 23.00002!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Nơi sinh :"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(175.5121!, 166.7918!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(79.70438!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Ngày sinh:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(175.5121!, 120.7917!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(79.70438!, 23.00001!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Họ và tên:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tieu_de
        '
        Me.tieu_de.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.tieu_de.LocationFloat = New DevExpress.Utils.PointFloat(23.00001!, 73.3333!)
        Me.tieu_de.Name = "tieu_de"
        Me.tieu_de.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tieu_de.SizeF = New System.Drawing.SizeF(798.0015!, 33.87498!)
        Me.tieu_de.StylePriority.UseFont = False
        Me.tieu_de.StylePriority.UseTextAlignment = False
        Me.tieu_de.Text = "BẢNG ĐIỂM TOÀN KHÓA"
        Me.tieu_de.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(574.4127!, 56.08333!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(145.8334!, 2.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(81.254!, 58.00001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(164.5417!, 2.083332!)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(460.5415!, 33.99998!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(350.7877!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Độc Lập - Tự Do - Hạnh Phúc"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(460.5415!, 11.99999!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(350.7877!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "CÔNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(27.5041!, 34.99997!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(308.1209!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CĐ KTKT TRUNG ƯƠNG"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(27.5041!, 12.00002!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(308.1209!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "LIÊN MINH HTX VIỆT NAM"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_chuc_danh1, Me.XrLabel1, Me.Tieu_de_nguoi_ky1, Me.XrLabel4, Me.XrLabel10, Me.TBCHT, Me.Xep_loai, Me.Tieu_de_noi_ky, Me.GHGHGH})
        Me.ReportFooter.HeightF = 193.0!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.StylePriority.UseTextAlignment = False
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(530.4166!, 93.49996!)
        Me.Tieu_de_chuc_danh1.Multiline = True
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(227.2915!, 23.00002!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(530.4166!, 67.37496!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(227.2915!, 23.00002!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "TRƯỞNG PHÒNG ĐÀO TẠO"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(539.4167!, 136.9166!)
        Me.Tieu_de_nguoi_ky1.Multiline = True
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(203.7835!, 23.00001!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(30.00001!, 7.000001!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(209.2165!, 23.00002!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "- Điểm trung bình chung học tập:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel4.Visible = False
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(30.00001!, 29.0!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(209.2165!, 22.99998!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "- Xếp loại tốt nghiệp:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel10.Visible = False
        '
        'TBCHT
        '
        Me.TBCHT.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.TBCHT.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT.LocationFloat = New DevExpress.Utils.PointFloat(239.2165!, 6.999969!)
        Me.TBCHT.Multiline = True
        Me.TBCHT.Name = "TBCHT"
        Me.TBCHT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TBCHT.SizeF = New System.Drawing.SizeF(169.4085!, 23.00001!)
        Me.TBCHT.StylePriority.UseBorders = False
        Me.TBCHT.StylePriority.UseFont = False
        Me.TBCHT.StylePriority.UseTextAlignment = False
        Me.TBCHT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.TBCHT.Visible = False
        '
        'Xep_loai
        '
        Me.Xep_loai.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Xep_loai.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Xep_loai.LocationFloat = New DevExpress.Utils.PointFloat(239.2165!, 28.99996!)
        Me.Xep_loai.Multiline = True
        Me.Xep_loai.Name = "Xep_loai"
        Me.Xep_loai.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Xep_loai.SizeF = New System.Drawing.SizeF(169.4085!, 23.0!)
        Me.Xep_loai.StylePriority.UseBorders = False
        Me.Xep_loai.StylePriority.UseFont = False
        Me.Xep_loai.StylePriority.UseTextAlignment = False
        Me.Xep_loai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Xep_loai.Visible = False
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(530.4166!, 6.999969!)
        Me.Tieu_de_noi_ky.Multiline = True
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(242.4124!, 23.00002!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.Text = "Hà nội, ngày 12/12/2012"
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GHGHGH
        '
        Me.GHGHGH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GHGHGH.LocationFloat = New DevExpress.Utils.PointFloat(530.4166!, 44.37497!)
        Me.GHGHGH.Multiline = True
        Me.GHGHGH.Name = "GHGHGH"
        Me.GHGHGH.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GHGHGH.SizeF = New System.Drawing.SizeF(227.2915!, 23.00002!)
        Me.GHGHGH.StylePriority.UseFont = False
        Me.GHGHGH.StylePriority.UseTextAlignment = False
        Me.GHGHGH.Text = "TL. HIỆU TRƯỞNG"
        Me.GHGHGH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptBangDiemToanKhoa_BaoLuu
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(7, 11, 40, 40)
        Me.Version = "10.1"
        CType(Me.RptBangDiemToanKhoa_Sub12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptBangDiemToanKhoa_Sub1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tieu_de As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_nganh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Chuyen_nganh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_he As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ma_sv As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Que_quan As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ho_ten As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TBCHT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Xep_loai As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GHGHGH As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents RptBangDiemToanKhoa_Sub1 As ESS_Mark.rptBangDiemToanKhoa_Sub
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents RptBangDiemToanKhoa_Sub11 As ESS_Mark.rptBangDiemToanKhoa_Sub1
    Private WithEvents RptBangDiemToanKhoa_Sub12 As ESS_Mark.rptBangDiemToanKhoa_Sub1
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents Ten_mon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_hoc_trinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHP As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
End Class
