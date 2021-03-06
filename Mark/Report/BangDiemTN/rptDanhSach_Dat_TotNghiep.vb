Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSach_Dat_TotNghiep
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao_1 As String = "", Optional ByVal Tieu_de_bao_cao_2 As String = "", Optional ByVal Tot_nghiep As Boolean = False, Optional ByVal No As Boolean = False)
        InitializeComponent()
        Dim dv As DataView = dtMain.DefaultView
        Dim dv2 As DataView = dtSub.DefaultView
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        Me.txtTong_so.Text = "Tổng số học sinh được công nhận tốt nghiệp: " & dtMain.Rows.Count & " học sinh"
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Dim numCol As Integer = dv2.Count - 1
        Dim childWidth As Double = Headrow.WidthF / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("Ten_mon").ToString
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow1.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            Headrow.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next
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
        If No = False Then
            Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv1")
            Ho_dem.DataBindings.Add("Text", DataSource, "Ho_dem1")
            txtTen.DataBindings.Add("Text", DataSource, "Ten1")
            Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh1", "{0:dd/MM/yyyy}")
            Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop1")
            Diem_toan_khoa.DataBindings.Add("Text", DataSource, "Diem_toan_khoa1", "{0:n1}")
            TBCHT.DataBindings.Add("Text", DataSource, "TBCHT1", "{0:n1}")
            TBCTN.DataBindings.Add("Text", DataSource, "TBCTN", "{0:n1}")
            Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang1")

            Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc1")
            Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
            Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh1")
            Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh1")
        Else
            Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
            Ho_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
            txtTen.DataBindings.Add("Text", DataSource, "Ten")
            Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
            Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
            Diem_toan_khoa.DataBindings.Add("Text", DataSource, "Diem_toan_khoa", "{0:n1}")
            TBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
            TBCTN.DataBindings.Add("Text", DataSource, "TBCTN", "{0:n1}")
            Xep_hang.DataBindings.Add("Text", DataSource, "Xep_hang")
            Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
            Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
            Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
            Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        End If
    End Sub
End Class