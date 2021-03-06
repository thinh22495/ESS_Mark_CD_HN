Imports DevExpress.XtraReports.UI
Public Class rpt_TongHopTheoNam
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal Tieu_de_bao_cao_2 As String = "", Optional ByVal dtTen_mon As DataTable = Nothing)
        InitializeComponent()
        Dim dv As DataView = dtMain.DefaultView
        Dim dv2 As DataView = dtSub.DefaultView
        Dim dv3 As DataView = dtTen_mon.DefaultView

        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de_bao_cao
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4

        Dim numCol As Integer = dv2.Count - 1
        Dim childWidth As Double = HeadRow_ten_mon.WidthF / (numCol + 1)
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            ValueRow.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "M" & dv2(j).Row("ID_mon"))
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next

        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("So_hoc_trinh")
            lb.WidthF = childWidth
            lb.HeightF = XrTable_hoc_trinh.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow_hoc_trinh.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("Ten_mon")
            lb.WidthF = childWidth
            lb.HeightF = XrTable5.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow_ten_mon.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv3(i).Row("TenMon")
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow4.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow_TT_mon.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
        So_mon_no.DataBindings.Add("Text", DataSource, "So_mon_no")
        ten_mon_no.DataBindings.Add("Text", DataSource, "Ten_mon_no")
        Me.DataSource = dtMain
    End Sub

End Class