<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDanhSachSinhVienDuDienKienThi
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xTT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xHo_dem = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xTen = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xLop = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xNgay_sinh = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xNoi_sinh = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xGhi_chu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblMon_thi = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xNguoi_ky_1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(746.0001!, 24.99999!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.xTT, Me.xHo_dem, Me.xTen, Me.xLop, Me.xNgay_sinh, Me.xNoi_sinh, Me.xGhi_chu})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 0.5000000357947435R
        '
        'xTT
        '
        Me.xTT.Name = "xTT"
        Me.xTT.Weight = 0.51924538377351537R
        '
        'xHo_dem
        '
        Me.xHo_dem.Name = "xHo_dem"
        Me.xHo_dem.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.xHo_dem.StylePriority.UsePadding = False
        Me.xHo_dem.StylePriority.UseTextAlignment = False
        Me.xHo_dem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xHo_dem.Weight = 1.5870979817014519R
        '
        'xTen
        '
        Me.xTen.Name = "xTen"
        Me.xTen.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.xTen.StylePriority.UsePadding = False
        Me.xTen.StylePriority.UseTextAlignment = False
        Me.xTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xTen.Weight = 0.82222775847588836R
        '
        'xLop
        '
        Me.xLop.Name = "xLop"
        Me.xLop.StylePriority.UseTextAlignment = False
        Me.xLop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xLop.Weight = 1.008808615937947R
        '
        'xNgay_sinh
        '
        Me.xNgay_sinh.Name = "xNgay_sinh"
        Me.xNgay_sinh.Weight = 0.96412466716002065R
        '
        'xNoi_sinh
        '
        Me.xNoi_sinh.Name = "xNoi_sinh"
        Me.xNoi_sinh.StylePriority.UseTextAlignment = False
        Me.xNoi_sinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xNoi_sinh.Weight = 1.0758350300041766R
        '
        'xGhi_chu
        '
        Me.xGhi_chu.Name = "xGhi_chu"
        Me.xGhi_chu.StylePriority.UseTextAlignment = False
        Me.xGhi_chu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xGhi_chu.Weight = 1.5226605271522557R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 38.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.lblMon_thi, Me.XrLabel1, Me.XrLine1, Me.XrLine2, Me.Tieu_de_ten_truong, Me.Tieu_de_ten_bo, Me.XrLabel3, Me.XrLabel4})
        Me.ReportHeader.HeightF = 149.5!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 124.5!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(746.0!, 24.99999!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "STT"
        Me.XrTableCell1.Weight = 0.4375R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "TT"
        Me.XrTableCell2.Weight = 0.45433993321641208R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Họ và tên"
        Me.XrTableCell3.Weight = 2.1081600667835878R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Lớp"
        Me.XrTableCell4.Weight = 0.88270763161994181R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Ngày sinh"
        Me.XrTableCell5.Weight = 0.84361031867224157R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Nơi sinh"
        Me.XrTableCell6.Weight = 0.94135403057844969R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Ghi chú"
        Me.XrTableCell7.Weight = 1.3323280191293672R
        '
        'lblMon_thi
        '
        Me.lblMon_thi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblMon_thi.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 85.5!)
        Me.lblMon_thi.Name = "lblMon_thi"
        Me.lblMon_thi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMon_thi.SizeF = New System.Drawing.SizeF(746.0!, 23.0!)
        Me.lblMon_thi.StylePriority.UseFont = False
        Me.lblMon_thi.StylePriority.UseTextAlignment = False
        Me.lblMon_thi.Text = "DỰ THI TỐT NGHIỆP CHÍNH TRỊ (ĐỢT 2 - NĂM 2017)"
        Me.lblMon_thi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 62.5!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(746.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "DANH SÁCH HỌC SINH SINH VIÊN"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(71.95825!, 47.10417!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(202.0833!, 2.083332!)
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(473.9584!, 47.10417!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(160.0833!, 2.083332!)
        Me.XrLine2.StylePriority.UseBorderWidth = False
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.89581!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(356.25!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CĐ KTKT TRUNG ƯƠNG"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.8124981!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(356.25!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.Text = "LIÊN MINH HTX VIỆT NAM"
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(372.25!, 0.8124981!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(373.25!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(372.25!, 23.81249!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(373.25!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Độc Lập - Tự Do - Hạnh Phúc"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.xNguoi_ky_1, Me.XrLabel6, Me.Tieu_de_noi_ky, Me.Tieu_de_chuc_danh1, Me.Tieu_de_nguoi_ky1})
        Me.ReportFooter.HeightF = 141.875!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(478.9999!, 46.62499!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(257.0001!, 22.99995!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "HIỆU TRƯỞNG"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xNguoi_ky_1
        '
        Me.xNguoi_ky_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xNguoi_ky_1.LocationFloat = New DevExpress.Utils.PointFloat(46.625!, 118.875!)
        Me.xNguoi_ky_1.Name = "xNguoi_ky_1"
        Me.xNguoi_ky_1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xNguoi_ky_1.SizeF = New System.Drawing.SizeF(257.0001!, 22.99995!)
        Me.xNguoi_ky_1.StylePriority.UseFont = False
        Me.xNguoi_ky_1.StylePriority.UseTextAlignment = False
        Me.xNguoi_ky_1.Text = "Phạm Cường"
        Me.xNguoi_ky_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(46.625!, 11.8125!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(257.0001!, 22.99999!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "PHÒNG ĐÀO TẠO"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(478.9999!, 0.0!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(257.0001!, 22.99999!)
        Me.Tieu_de_noi_ky.StylePriority.UseFont = False
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.Text = "Hà nội, ngày 02/03/1989"
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(478.9999!, 23.625!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(257.0001!, 22.99999!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.Text = "CHỦ TỊCH HỘI ĐỒNG THI"
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(478.9999!, 118.875!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(257.0001!, 22.99995!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.Text = "Nguyễn Văn A"
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptDanhSachSinhVienDuDienKienThi
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(50, 31, 38, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMon_thi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xTT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xHo_dem As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xTen As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xLop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xNgay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xNoi_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xGhi_chu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xNguoi_ky_1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
End Class
