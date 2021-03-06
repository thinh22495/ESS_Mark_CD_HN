Imports DevExpress.XtraReports.UI
Public Class rptMARK_TongHopKetQuaHocTap
    Friend WithEvents lb1 As DevExpress.XtraReports.UI.XRLabel
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "", Optional ByVal Tieu_de_bao_cao3 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng" & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ki1.Text = gTieu_de_nguoi_ki1
        Dim dv As DataView = dtSub.DefaultView
        Dim numCol As Integer = dv.Count - 1
        Dim childWidth As Double = HeaderCell.WidthF / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv(i).Row("Ten_mon") + vbCrLf + "(" & dv(i)("So_hoc_trinh") & " đvht)"
            lb.WidthF = childWidth
            lb.Multiline = True
            lb.HeightF = HeaderRow.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeaderCell.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        For j As Integer = 0 To numCol
            lb1 = New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = ValueRow.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            ValueRow.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "M" & dv(j).Row("ID_mon"))
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Me.Tieu_de_bao_cao2.Text = Tieu_de_bao_cao2
        Me.DataSource = dtMain
    End Sub

    Private Sub lb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb1.BeforePrint
        'MessageBox.Show(lb1.Text)
    End Sub

End Class