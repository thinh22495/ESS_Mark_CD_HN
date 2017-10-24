Public Class rpt_PhieuCham_DiemTN_7b
    Public Sub New(ByVal dt As DataTable, Optional ByVal Ten_mon As String = "", Optional ByVal Ten_phong As String = "")
        InitializeComponent()
        Me.DataSource = dt
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_ngay.Text = "Ngày " & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Me.Mon_thi.Text = Ten_mon
        Me.Phong_thi.Text = Ten_phong
        Binding()
    End Sub
    Public Sub Binding()
        So_phach.DataBindings.Add("Text", DataSource, "So_phach")
    End Sub
End Class