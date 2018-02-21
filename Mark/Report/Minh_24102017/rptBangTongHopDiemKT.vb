Imports DevExpress.XtraReports.UI

Public Class rptBangTongHopDiemKT
    Public Sub New(ByVal dvHeSo1 As DataView, ByVal dvHeSo2 As DataView, ByVal dvSource As DataView, ByVal Ten_mon_hoc As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DataSource = dvSource
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.lbl_Ten_mon_hoc.Text = Ten_mon_hoc
        Me.lbl_Lop.Text = dvSource.Item(0)("Ten_lop").ToString

        Me.XrLine1.SizeF = New SizeF(Tieu_de_ten_truong.SizeF.Width / 2, 2)
        Me.XrLine1.LocationF = New PointF(Tieu_de_ten_truong.SizeF.Width / 4, Tieu_de_ten_truong.LocationF.Y + Tieu_de_ten_truong.SizeF.Height + 1)

        If dvHeSo1.Count > 0 Then
            DrawReportDataBingHeSo1(dvHeSo1.ToTable, xTable_HeSo1)
            Me.xTieu_de_diem_tx.Text = "Điểm KT thường xuyên (Hệ số " & dvHeSo1.Item(0)("Ty_le").ToString & ")"
        End If
        If dvHeSo2.Count > 0 Then
            Me.xTieu_de_diem_dk.Text = "Điểm KT định kỳ (Hệ số " & dvHeSo2.Item(0)("Ty_le").ToString & ")"
            DrawReportDataBingHeSo1(dvHeSo2.ToTable, xTable_HeSo2)
        End If

        'Me.Ten_hoc_phan.Text = Ten_hoc_phan
        'Me.He.Text = He
        'Me.Chuyen_nganh.Text = Chuyen_nganh
        'Me.Ten_lop.Text = Ten_lop
        'Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        'Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & " Ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        ' Add any initialization after the InitializeComponent() call.


        Binding()
    End Sub
    Private Sub DrawReportDataBingHeSo1(ByVal dt As DataTable, ByVal Ten_Cot As XRTableCell)
        Dim w As Decimal = Ten_Cot.WidthF
        If dt.Rows.Count > 0 Then
            Ten_Cot.Name = "TP" & dt.Rows(dt.Rows.Count - 1)("ID_thanh_phan")
            Ten_Cot.DataBindings.Add("Text", DataSource, Ten_Cot.Name)
            w = w / dt.Rows.Count
        End If
        If dt.Rows.Count > 1 Then
            For idx As Integer = 0 To dt.Rows.Count - 2
                Dim cell As New XRTableCell
                cell.Name = "TP" & dt.Rows(idx)("ID_thanh_phan")
                rowtable2.InsertCell(cell, Ten_Cot.Index)
                cell.DataBindings.Add("Text", DataSource, cell.Name)
                cell.WidthF = w
            Next
        End If
    End Sub
    Private Sub Binding()
        xHo_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        xDiem_TBC.DataBindings.Add("Text", DataSource, "TBCBP")
        xSo_gio_nghi.DataBindings.Add("Text", DataSource, "So_tiet_nghi")
        xGhi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

End Class