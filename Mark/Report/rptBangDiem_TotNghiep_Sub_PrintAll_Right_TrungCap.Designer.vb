<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Right_TrungCap
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
        Me.lblThuc_hanh = New DevExpress.XtraReports.UI.XRLabel
        Me.lblXep_loai = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDiem_Thuc_hanh = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDiem_Ly_thuyet = New DevExpress.XtraReports.UI.XRLabel
        Me.lblDiem_Chinh_tri = New DevExpress.XtraReports.UI.XRLabel
        Me.lblLy_thuyet = New DevExpress.XtraReports.UI.XRLabel
        Me.lblChinh_tri = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 24.42!
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
        Me.XrTable2.SizeF = New System.Drawing.SizeF(390.63!, 24.42!)
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
        Me.So_thu_tu.Weight = 0.2448335799194083
        '
        'Ten_mon
        '
        Me.Ten_mon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_mon.StylePriority.UseFont = False
        Me.Ten_mon.StylePriority.UsePadding = False
        Me.Ten_mon.StylePriority.UseTextAlignment = False
        Me.Ten_mon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_mon.Weight = 2.8252939603565688
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.Weight = 0.31956228807203235
        '
        'TBCHP
        '
        Me.TBCHP.Name = "TBCHP"
        Me.TBCHP.Weight = 0.31009081604156186
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
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTBCHT, Me.XrLabel6, Me.lblThuc_hanh, Me.lblXep_loai, Me.XrLabel11, Me.XrLabel9, Me.lblDiem_Thuc_hanh, Me.XrLabel4, Me.lblDiem_Ly_thuyet, Me.lblDiem_Chinh_tri, Me.lblLy_thuyet, Me.lblChinh_tri, Me.XrLabel10})
        Me.ReportFooter.HeightF = 146.52!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'lblTBCHT
        '
        Me.lblTBCHT.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTBCHT.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTBCHT.LocationFloat = New DevExpress.Utils.PointFloat(324.15!, 73.25999!)
        Me.lblTBCHT.Multiline = True
        Me.lblTBCHT.Name = "lblTBCHT"
        Me.lblTBCHT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTBCHT.SizeF = New System.Drawing.SizeF(66.48!, 24.42!)
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
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 48.84!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(324.15!, 24.42!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "                               + Thực hành nghề nghiệp:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblThuc_hanh
        '
        Me.lblThuc_hanh.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblThuc_hanh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblThuc_hanh.LocationFloat = New DevExpress.Utils.PointFloat(324.15!, 48.84!)
        Me.lblThuc_hanh.Multiline = True
        Me.lblThuc_hanh.Name = "lblThuc_hanh"
        Me.lblThuc_hanh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblThuc_hanh.SizeF = New System.Drawing.SizeF(33.74!, 24.42!)
        Me.lblThuc_hanh.StylePriority.UseBorders = False
        Me.lblThuc_hanh.StylePriority.UseFont = False
        Me.lblThuc_hanh.StylePriority.UseTextAlignment = False
        Me.lblThuc_hanh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblXep_loai
        '
        Me.lblXep_loai.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblXep_loai.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai.LocationFloat = New DevExpress.Utils.PointFloat(324.15!, 97.67999!)
        Me.lblXep_loai.Multiline = True
        Me.lblXep_loai.Name = "lblXep_loai"
        Me.lblXep_loai.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblXep_loai.SizeF = New System.Drawing.SizeF(66.48!, 48.84!)
        Me.lblXep_loai.StylePriority.UseBorders = False
        Me.lblXep_loai.StylePriority.UseFont = False
        Me.lblXep_loai.StylePriority.UseTextAlignment = False
        Me.lblXep_loai.Text = "Trung bình"
        Me.lblXep_loai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.67999!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(324.15!, 48.84!)
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
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 73.25999!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(324.15!, 24.42!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "- Điểm trung bình chung học tập:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblDiem_Thuc_hanh
        '
        Me.lblDiem_Thuc_hanh.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblDiem_Thuc_hanh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiem_Thuc_hanh.LocationFloat = New DevExpress.Utils.PointFloat(357.89!, 48.84!)
        Me.lblDiem_Thuc_hanh.Multiline = True
        Me.lblDiem_Thuc_hanh.Name = "lblDiem_Thuc_hanh"
        Me.lblDiem_Thuc_hanh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDiem_Thuc_hanh.SizeF = New System.Drawing.SizeF(32.74!, 24.42!)
        Me.lblDiem_Thuc_hanh.StylePriority.UseBorders = False
        Me.lblDiem_Thuc_hanh.StylePriority.UseFont = False
        Me.lblDiem_Thuc_hanh.StylePriority.UseTextAlignment = False
        Me.lblDiem_Thuc_hanh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(324.15!, 24.42!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "- Thi tốt nghiệp:    + Chính trị:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblDiem_Ly_thuyet
        '
        Me.lblDiem_Ly_thuyet.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblDiem_Ly_thuyet.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiem_Ly_thuyet.LocationFloat = New DevExpress.Utils.PointFloat(357.89!, 24.42!)
        Me.lblDiem_Ly_thuyet.Multiline = True
        Me.lblDiem_Ly_thuyet.Name = "lblDiem_Ly_thuyet"
        Me.lblDiem_Ly_thuyet.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDiem_Ly_thuyet.SizeF = New System.Drawing.SizeF(32.74!, 24.42!)
        Me.lblDiem_Ly_thuyet.StylePriority.UseBorders = False
        Me.lblDiem_Ly_thuyet.StylePriority.UseFont = False
        Me.lblDiem_Ly_thuyet.StylePriority.UseTextAlignment = False
        Me.lblDiem_Ly_thuyet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblDiem_Chinh_tri
        '
        Me.lblDiem_Chinh_tri.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.lblDiem_Chinh_tri.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiem_Chinh_tri.LocationFloat = New DevExpress.Utils.PointFloat(357.89!, 0.0!)
        Me.lblDiem_Chinh_tri.Multiline = True
        Me.lblDiem_Chinh_tri.Name = "lblDiem_Chinh_tri"
        Me.lblDiem_Chinh_tri.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblDiem_Chinh_tri.SizeF = New System.Drawing.SizeF(32.74!, 24.42!)
        Me.lblDiem_Chinh_tri.StylePriority.UseBorders = False
        Me.lblDiem_Chinh_tri.StylePriority.UseFont = False
        Me.lblDiem_Chinh_tri.StylePriority.UseTextAlignment = False
        Me.lblDiem_Chinh_tri.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblLy_thuyet
        '
        Me.lblLy_thuyet.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblLy_thuyet.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLy_thuyet.LocationFloat = New DevExpress.Utils.PointFloat(324.15!, 24.42!)
        Me.lblLy_thuyet.Multiline = True
        Me.lblLy_thuyet.Name = "lblLy_thuyet"
        Me.lblLy_thuyet.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLy_thuyet.SizeF = New System.Drawing.SizeF(33.74!, 24.42!)
        Me.lblLy_thuyet.StylePriority.UseBorders = False
        Me.lblLy_thuyet.StylePriority.UseFont = False
        Me.lblLy_thuyet.StylePriority.UseTextAlignment = False
        Me.lblLy_thuyet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblChinh_tri
        '
        Me.lblChinh_tri.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.lblChinh_tri.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblChinh_tri.LocationFloat = New DevExpress.Utils.PointFloat(324.15!, 0.0!)
        Me.lblChinh_tri.Multiline = True
        Me.lblChinh_tri.Name = "lblChinh_tri"
        Me.lblChinh_tri.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblChinh_tri.SizeF = New System.Drawing.SizeF(33.74!, 24.42!)
        Me.lblChinh_tri.StylePriority.UseBorders = False
        Me.lblChinh_tri.StylePriority.UseFont = False
        Me.lblChinh_tri.StylePriority.UseTextAlignment = False
        Me.lblChinh_tri.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 24.42!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(324.15!, 24.42!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "                               + Lý thuyết tổng hợp nghề nghiệp:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptBangDiem_TotNghiep_Sub_PrintAll_Right_TrungCap
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
    Friend WithEvents lblThuc_hanh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblXep_loai As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDiem_Thuc_hanh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDiem_Ly_thuyet As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDiem_Chinh_tri As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLy_thuyet As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblChinh_tri As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
End Class
