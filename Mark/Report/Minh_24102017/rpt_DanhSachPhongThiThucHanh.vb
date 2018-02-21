Public Class rpt_DanhSachPhongThiThucHanh

    Public Sub New(ByVal dv As DataView)

        ' This call is required by the designer.
        InitializeComponent()
        Me.DataSource = dv
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        ' Add any initialization after the InitializeComponent() call.
        Binding()
    End Sub
    Public Sub Binding()
        xHo_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        xTen.DataBindings.Add("Text", DataSource, "Ten")
        xLop.DataBindings.Add("Text", DataSource, "Ten_lop")
    End Sub
End Class