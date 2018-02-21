Public Class rpt_DSTheoDoiNgayHocTap
    Public Sub New(Optional ByVal Lop As String = "", Optional ByVal dt As DataTable = Nothing)
        InitializeComponent()
        Me.Ten_lop.Text = "Lớp: " & Lop
        'Me.ReportFooter.PrintAtBottom = True
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & " tháng" & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Binding()
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
    End Sub
End Class