<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBangDiem_TotNghiep_Sub_PrintAll_Right_2_Dau_Diem
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
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.ChinhTri_Diem = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.ThucHanh_HocTrinh = New DevExpress.XtraReports.UI.XRLabel
        Me.LyThuyet_HocTrinh = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTBCHT = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblXep_loai = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.ThucHanh_Diem = New DevExpress.XtraReports.UI.XRLabel
        Me.LyThuyet_Diem = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 21.42!
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
        Me.XrTable2.SizeF = New System.Drawing.SizeF(383.64!, 21.42!)
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
        Me.So_thu_tu.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.So_thu_tu.Name = "So_thu_tu"
        Me.So_thu_tu.StylePriority.UseFont = False
        Me.So_thu_tu.Weight = 0.24615952240214184
        '
        'Ten_mon
        '
        Me.Ten_mon.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_mon.StylePriority.UseFont = False
        Me.Ten_mon.StylePriority.UsePadding = False
        Me.Ten_mon.StylePriority.UseTextAlignment = False
        Me.Ten_mon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_mon.Weight = 2.5675792982812018
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.So_hoc_trinh.StylePriority.UseFont = False
        Me.So_hoc_trinh.StylePriority.UsePadding = False
        Me.So_hoc_trinh.StylePriority.UseTextAlignment = False
        Me.So_hoc_trinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.So_hoc_trinh.Weight = 0.34286163445694945
        '
        'TBCHP
        '
        Me.TBCHP.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.TBCHP.Name = "TBCHP"
        Me.TBCHP.StylePriority.UseFont = False
        Me.TBCHP.Weight = 0.47697540006600009
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
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2, Me.ChinhTri_Diem, Me.XrLabel1, Me.ThucHanh_HocTrinh, Me.LyThuyet_HocTrinh, Me.lblTBCHT, Me.XrLabel6, Me.lblXep_loai, Me.XrLabel11, Me.XrLabel9, Me.ThucHanh_Diem, Me.LyThuyet_Diem, Me.XrLabel10})
        Me.ReportFooter.HeightF = 172.1!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(297.08!, 30.58003!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(86.56012!, 22.41999!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 30.58!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(297.08!, 22.42!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "* Các môn thi tốt nghiệp:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ChinhTri_Diem
        '
        Me.ChinhTri_Diem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ChinhTri_Diem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ChinhTri_Diem.LocationFloat = New DevExpress.Utils.PointFloat(297.08!, 53.00003!)
        Me.ChinhTri_Diem.Multiline = True
        Me.ChinhTri_Diem.Name = "ChinhTri_Diem"
        Me.ChinhTri_Diem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ChinhTri_Diem.SizeF = New System.Drawing.SizeF(86.56012!, 22.41999!)
        Me.ChinhTri_Diem.StylePriority.UseBorders = False
        Me.ChinhTri_Diem.StylePriority.UseFont = False
        Me.ChinhTri_Diem.StylePriority.UseTextAlignment = False
        Me.ChinhTri_Diem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 53.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(297.08!, 22.42!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "                                         + Chính trị"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ThucHanh_HocTrinh
        '
        Me.ThucHanh_HocTrinh.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.ThucHanh_HocTrinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ThucHanh_HocTrinh.LocationFloat = New DevExpress.Utils.PointFloat(563.7468!, 67.25995!)
        Me.ThucHanh_HocTrinh.Multiline = True
        Me.ThucHanh_HocTrinh.Name = "ThucHanh_HocTrinh"
        Me.ThucHanh_HocTrinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ThucHanh_HocTrinh.SizeF = New System.Drawing.SizeF(36.19998!, 22.42006!)
        Me.ThucHanh_HocTrinh.StylePriority.UseBorders = False
        Me.ThucHanh_HocTrinh.StylePriority.UseFont = False
        Me.ThucHanh_HocTrinh.StylePriority.UseTextAlignment = False
        Me.ThucHanh_HocTrinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.ThucHanh_HocTrinh.Visible = False
        '
        'LyThuyet_HocTrinh
        '
        Me.LyThuyet_HocTrinh.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.LyThuyet_HocTrinh.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LyThuyet_HocTrinh.LocationFloat = New DevExpress.Utils.PointFloat(563.7468!, 44.84002!)
        Me.LyThuyet_HocTrinh.Multiline = True
        Me.LyThuyet_HocTrinh.Name = "LyThuyet_HocTrinh"
        Me.LyThuyet_HocTrinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LyThuyet_HocTrinh.SizeF = New System.Drawing.SizeF(36.19998!, 22.42001!)
        Me.LyThuyet_HocTrinh.StylePriority.UseBorders = False
        Me.LyThuyet_HocTrinh.StylePriority.UseFont = False
        Me.LyThuyet_HocTrinh.StylePriority.UseTextAlignment = False
        Me.LyThuyet_HocTrinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.LyThuyet_HocTrinh.Visible = False
        '
        'lblTBCHT
        '
        Me.lblTBCHT.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTBCHT.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTBCHT.LocationFloat = New DevExpress.Utils.PointFloat(239.7883!, 120.26!)
        Me.lblTBCHT.Multiline = True
        Me.lblTBCHT.Name = "lblTBCHT"
        Me.lblTBCHT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTBCHT.SizeF = New System.Drawing.SizeF(143.8417!, 22.42!)
        Me.lblTBCHT.StylePriority.UseBorders = False
        Me.lblTBCHT.StylePriority.UseFont = False
        Me.lblTBCHT.StylePriority.UseTextAlignment = False
        Me.lblTBCHT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.84!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(297.08!, 22.42!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "                                         + Thực hành nghề"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblXep_loai
        '
        Me.lblXep_loai.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblXep_loai.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai.LocationFloat = New DevExpress.Utils.PointFloat(239.7885!, 149.68!)
        Me.lblXep_loai.Multiline = True
        Me.lblXep_loai.Name = "lblXep_loai"
        Me.lblXep_loai.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblXep_loai.SizeF = New System.Drawing.SizeF(143.8415!, 22.41999!)
        Me.lblXep_loai.StylePriority.UseBorders = False
        Me.lblXep_loai.StylePriority.UseFont = False
        Me.lblXep_loai.StylePriority.UseTextAlignment = False
        Me.lblXep_loai.Text = "trung bình khá"
        Me.lblXep_loai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 149.68!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(239.7883!, 22.41999!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "* Xếp loại tốt nghiệp:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 120.26!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(239.7883!, 22.42!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ThucHanh_Diem
        '
        Me.ThucHanh_Diem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ThucHanh_Diem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ThucHanh_Diem.LocationFloat = New DevExpress.Utils.PointFloat(297.0799!, 97.84!)
        Me.ThucHanh_Diem.Multiline = True
        Me.ThucHanh_Diem.Name = "ThucHanh_Diem"
        Me.ThucHanh_Diem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ThucHanh_Diem.SizeF = New System.Drawing.SizeF(86.55014!, 22.42002!)
        Me.ThucHanh_Diem.StylePriority.UseBorders = False
        Me.ThucHanh_Diem.StylePriority.UseFont = False
        Me.ThucHanh_Diem.StylePriority.UseTextAlignment = False
        Me.ThucHanh_Diem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'LyThuyet_Diem
        '
        Me.LyThuyet_Diem.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.LyThuyet_Diem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LyThuyet_Diem.LocationFloat = New DevExpress.Utils.PointFloat(297.08!, 75.41999!)
        Me.LyThuyet_Diem.Multiline = True
        Me.LyThuyet_Diem.Name = "LyThuyet_Diem"
        Me.LyThuyet_Diem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LyThuyet_Diem.SizeF = New System.Drawing.SizeF(86.56012!, 22.42001!)
        Me.LyThuyet_Diem.StylePriority.UseBorders = False
        Me.LyThuyet_Diem.StylePriority.UseFont = False
        Me.LyThuyet_Diem.StylePriority.UseTextAlignment = False
        Me.LyThuyet_Diem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 75.42!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(297.08!, 22.42!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "                + Lý thuyết nghề"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptBangDiem_TotNghiep_Sub_PrintAll_Right_2_Dau_Diem
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
    Friend WithEvents So_hoc_trinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHP As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents lblTBCHT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblXep_loai As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ThucHanh_Diem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LyThuyet_Diem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ten_mon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ThucHanh_HocTrinh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LyThuyet_HocTrinh As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ChinhTri_Diem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
