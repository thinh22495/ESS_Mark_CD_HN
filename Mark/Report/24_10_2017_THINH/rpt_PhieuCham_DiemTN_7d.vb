Public Class rpt_PhieuCham_DiemTN_7d
    Public Sub New(ByVal dt As DataTable)
        InitializeComponent()
        Me.DataSource = dt
        Me.Tieu_de_ngay.Text = " Ngày" & Date.Now.Day.ToString & " tháng " & Date.Now.Month.ToString & " năm " & Date.Now.Year.ToString
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Binding()
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Que_quan.DataBindings.Add("Text", DataSource, "Dia_chi")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Nghe.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
    End Sub
End Class