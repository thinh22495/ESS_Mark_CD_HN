Public Class rptChungNhanTN_VietHan
    Public Sub New(ByVal dv As DataView, ByVal Ten_he As String, ByVal So_qd As String, ByVal ID_he As Integer)
        InitializeComponent()
        Me.DataSource = dv
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        'Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        'Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        'Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.txtHe.Text = Ten_he.ToString
        Me.txtQuyet_dinh.Text = So_qd.ToString
        Select Case ID_he
            Case 9, 10
                lbNien_khoa.Visible = True
                txtNien_khoa.Visible = True
            Case Else
                lbNien_khoa.Visible = False
                txtNien_khoa.Visible = False
        End Select
        Binding()
    End Sub

    Public Sub Binding()
        txtHo_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        txtNgay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        txtNoi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        txtChuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        txtGioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")

        txtChinh_tri.DataBindings.Add("Text", DataSource, "Chinh_tri", "{0:n1}")
        txtThuc_hanh_nghe.DataBindings.Add("Text", DataSource, "Thuc_hanh", "{0:n1}")
        txtLy_thuet_nghe.DataBindings.Add("Text", DataSource, "Ly_thuyet", "{0:n1}")
        TBCHT.DataBindings.Add("Text", DataSource, "Diem_toan_khoa", "{0:n1}")
        txtXep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
        txtNien_khoa.DataBindings.Add("Text", DataSource, "Nien_khoa")
    End Sub
End Class