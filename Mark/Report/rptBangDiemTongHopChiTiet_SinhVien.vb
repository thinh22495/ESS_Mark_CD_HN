Imports DevExpress.XtraReports.UI
Imports System.Drawing.Drawing2D
Public Class rptBangDiemTongHopChiTiet_SinhVien
    Public Sub New(ByVal dvMain As DataView, ByVal dvTP As DataView)
        InitializeComponent()
        dvMain.Sort = "Nam_hoc_nhom ASC"
        Me.DataSource = dvMain
        Dim numCol As Integer = dvTP.Count - 1
        Dim childWidth As Double = ValueKiem_tra.WidthF / (numCol + 1)
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
            ValueKiem_tra.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "TP" & dvTP(j).Row("ID_thanh_phan"), "{0:n1}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Binding()
    End Sub


    Public Sub Binding()
        txtHo_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        txtMa_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        txtNgay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        txtNoi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        txtLop_hoc.DataBindings.Add("Text", DataSource, "Ten_lop")
        txtChuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        txtKhoa_hoc.DataBindings.Add("Text", DataSource, "Nien_khoa")
        txtTen_he.DataBindings.Add("Text", DataSource, "Ten_he")

        txtSo_lan_KT.DataBindings.Add("Text", DataSource, "So_lan_KT")
        txtThi_L1.DataBindings.Add("Text", DataSource, "Lan1_HienThi", "{0:n1}")
        txtThi_L2.DataBindings.Add("Text", DataSource, "Lan_Max_HienThi", "{0:n1}")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        txtTen_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        txtHe_so.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        txtNam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc_nhom")
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Nam_hoc_nhom")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub
End Class