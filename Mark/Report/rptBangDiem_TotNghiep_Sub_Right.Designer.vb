<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBangDiem_TotNghiep_Sub_Right
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
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.So_thu_tu = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_mon = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_hoc_trinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCHP = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.lblTBCHT = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblHocTrinh_CN = New DevExpress.XtraReports.UI.XRLabel
        Me.lblXep_loai = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCN_Diem = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCS_Nganh_Diem = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDiem_ThucTap = New DevExpress.XtraReports.UI.XRLabel
        Me.lblHocTrinh_CS_Nganh = New DevExpress.XtraReports.UI.XRLabel
        Me.lblHocTrinh_ThucTap = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 20.4167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(380.1747!, 20.4167!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.So_thu_tu, Me.Ten_mon, Me.So_hoc_trinh, Me.TBCHP})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'So_thu_tu
        '
        Me.So_thu_tu.Name = "So_thu_tu"
        Me.So_thu_tu.Text = "STT"
        Me.So_thu_tu.Weight = 0.34502657432822631
        '
        'Ten_mon
        '
        Me.Ten_mon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_mon.StylePriority.UseFont = False
        Me.Ten_mon.StylePriority.UsePadding = False
        Me.Ten_mon.StylePriority.UseTextAlignment = False
        Me.Ten_mon.Text = "TÊN MÔN (HỌC PHẦN)"
        Me.Ten_mon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_mon.Weight = 2.4980234552674565
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.Text = "SỐ ĐVHT"
        Me.So_hoc_trinh.Weight = 0.37885268622831014
        '
        'TBCHP
        '
        Me.TBCHP.Name = "TBCHP"
        Me.TBCHP.Text = "ĐIỂM"
        Me.TBCHP.Weight = 0.3788528578257081
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTBCHT, Me.XrLabel6, Me.lblHocTrinh_CN, Me.lblXep_loai, Me.XrLabel11, Me.XrLabel9, Me.lblCN_Diem, Me.XrLabel4, Me.lblCS_Nganh_Diem, Me.lblDiem_ThucTap, Me.lblHocTrinh_CS_Nganh, Me.lblHocTrinh_ThucTap, Me.XrLabel10})
        Me.ReportFooter.HeightF = 115.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'lblTBCHT
        '
        Me.lblTBCHT.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTBCHT.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTBCHT.LocationFloat = New DevExpress.Utils.PointFloat(300.1747!, 69.00002!)
        Me.lblTBCHT.Multiline = True
        Me.lblTBCHT.Name = "lblTBCHT"
        Me.lblTBCHT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTBCHT.SizeF = New System.Drawing.SizeF(80.0!, 23.0!)
        Me.lblTBCHT.StylePriority.UseBorders = False
        Me.lblTBCHT.StylePriority.UseFont = False
        Me.lblTBCHT.StylePriority.UseTextAlignment = False
        Me.lblTBCHT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 46.00002!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(300.1747!, 22.99998!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "                                + Chuyên ngành"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblHocTrinh_CN
        '
        Me.lblHocTrinh_CN.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblHocTrinh_CN.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHocTrinh_CN.LocationFloat = New DevExpress.Utils.PointFloat(300.1747!, 46.00002!)
        Me.lblHocTrinh_CN.Multiline = True
        Me.lblHocTrinh_CN.Name = "lblHocTrinh_CN"
        Me.lblHocTrinh_CN.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHocTrinh_CN.SizeF = New System.Drawing.SizeF(40.0!, 23.0!)
        Me.lblHocTrinh_CN.StylePriority.UseBorders = False
        Me.lblHocTrinh_CN.StylePriority.UseFont = False
        Me.lblHocTrinh_CN.StylePriority.UseTextAlignment = False
        Me.lblHocTrinh_CN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblXep_loai
        '
        Me.lblXep_loai.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblXep_loai.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai.LocationFloat = New DevExpress.Utils.PointFloat(300.1747!, 92.00002!)
        Me.lblXep_loai.Multiline = True
        Me.lblXep_loai.Name = "lblXep_loai"
        Me.lblXep_loai.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblXep_loai.SizeF = New System.Drawing.SizeF(80.0!, 23.0!)
        Me.lblXep_loai.StylePriority.UseBorders = False
        Me.lblXep_loai.StylePriority.UseFont = False
        Me.lblXep_loai.StylePriority.UseTextAlignment = False
        Me.lblXep_loai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 92.00002!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(300.1747!, 22.99998!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "- Xếp loại tốt nghiệp:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 69.00002!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(300.1747!, 22.99998!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "- Điểm trung bình chung học tập:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblCN_Diem
        '
        Me.lblCN_Diem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblCN_Diem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCN_Diem.LocationFloat = New DevExpress.Utils.PointFloat(340.1747!, 46.00002!)
        Me.lblCN_Diem.Multiline = True
        Me.lblCN_Diem.Name = "lblCN_Diem"
        Me.lblCN_Diem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCN_Diem.SizeF = New System.Drawing.SizeF(40.0!, 23.0!)
        Me.lblCN_Diem.StylePriority.UseBorders = False
        Me.lblCN_Diem.StylePriority.UseFont = False
        Me.lblCN_Diem.StylePriority.UseTextAlignment = False
        Me.lblCN_Diem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(300.1747!, 23.00002!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "- Thực tập tốt nghiệp:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblCS_Nganh_Diem
        '
        Me.lblCS_Nganh_Diem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblCS_Nganh_Diem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCS_Nganh_Diem.LocationFloat = New DevExpress.Utils.PointFloat(340.1747!, 23.00002!)
        Me.lblCS_Nganh_Diem.Multiline = True
        Me.lblCS_Nganh_Diem.Name = "lblCS_Nganh_Diem"
        Me.lblCS_Nganh_Diem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCS_Nganh_Diem.SizeF = New System.Drawing.SizeF(40.0!, 23.0!)
        Me.lblCS_Nganh_Diem.StylePriority.UseBorders = False
        Me.lblCS_Nganh_Diem.StylePriority.UseFont = False
        Me.lblCS_Nganh_Diem.StylePriority.UseTextAlignment = False
        Me.lblCS_Nganh_Diem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblDiem_ThucTap
        '
        Me.lblDiem_ThucTap.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.lblDiem_ThucTap.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiem_ThucTap.LocationFloat = New DevExpress.Utils.PointFloat(340.1747!, 0.0!)
        Me.lblDiem_ThucTap.Multiline = True
        Me.lblDiem_ThucTap.Name = "lblDiem_ThucTap"
        Me.lblDiem_ThucTap.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDiem_ThucTap.SizeF = New System.Drawing.SizeF(40.0!, 23.00001!)
        Me.lblDiem_ThucTap.StylePriority.UseBorders = False
        Me.lblDiem_ThucTap.StylePriority.UseFont = False
        Me.lblDiem_ThucTap.StylePriority.UseTextAlignment = False
        Me.lblDiem_ThucTap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblHocTrinh_CS_Nganh
        '
        Me.lblHocTrinh_CS_Nganh.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblHocTrinh_CS_Nganh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHocTrinh_CS_Nganh.LocationFloat = New DevExpress.Utils.PointFloat(300.1747!, 23.00002!)
        Me.lblHocTrinh_CS_Nganh.Multiline = True
        Me.lblHocTrinh_CS_Nganh.Name = "lblHocTrinh_CS_Nganh"
        Me.lblHocTrinh_CS_Nganh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHocTrinh_CS_Nganh.SizeF = New System.Drawing.SizeF(40.0!, 23.0!)
        Me.lblHocTrinh_CS_Nganh.StylePriority.UseBorders = False
        Me.lblHocTrinh_CS_Nganh.StylePriority.UseFont = False
        Me.lblHocTrinh_CS_Nganh.StylePriority.UseTextAlignment = False
        Me.lblHocTrinh_CS_Nganh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblHocTrinh_ThucTap
        '
        Me.lblHocTrinh_ThucTap.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.lblHocTrinh_ThucTap.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHocTrinh_ThucTap.LocationFloat = New DevExpress.Utils.PointFloat(300.1747!, 0.0!)
        Me.lblHocTrinh_ThucTap.Multiline = True
        Me.lblHocTrinh_ThucTap.Name = "lblHocTrinh_ThucTap"
        Me.lblHocTrinh_ThucTap.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblHocTrinh_ThucTap.SizeF = New System.Drawing.SizeF(40.0!, 23.00001!)
        Me.lblHocTrinh_ThucTap.StylePriority.UseBorders = False
        Me.lblHocTrinh_ThucTap.StylePriority.UseFont = False
        Me.lblHocTrinh_ThucTap.StylePriority.UseTextAlignment = False
        Me.lblHocTrinh_ThucTap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.00002!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(300.1747!, 22.99998!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "- Thi tốt nghiệp:      + Cơ sở ngành"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptBangDiem_TotNghiep_Sub_Right
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents So_thu_tu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_mon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_hoc_trinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHP As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents lblTBCHT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHocTrinh_CN As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblXep_loai As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCN_Diem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCS_Nganh_Diem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDiem_ThucTap As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHocTrinh_CS_Nganh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHocTrinh_ThucTap As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
End Class
