Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptBangDiemTBCHP_Dynamic
    Dim so_tt As Integer = 0
    Public Sub New(Optional ByVal Ten_hoc_phan As String = "", Optional ByVal He As String = "", Optional ByVal Chuyen_nganh As String = "", Optional ByVal Ten_lop As String = "", Optional ByVal dtSub1 As DataTable = Nothing, Optional ByVal dtSub2 As DataTable = Nothing, Optional ByVal tieu_de As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Ten_hoc_phan.Text = Ten_hoc_phan
        Me.He.Text = He
        Me.Chuyen_nganh.Text = Chuyen_nganh
        Me.Ten_lop.Text = Ten_lop

        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4

        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng" & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de.Text = tieu_de

        Dim dv As DataView = dtSub1.DefaultView
        Dim dv2 As DataView = dtSub2.DefaultView
        Dim numCol As Integer = dv2.Count - 1
        Dim childWidth As Double = HeadRow.WidthF / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv2(i).Row("Ky_hieu")
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow1.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow.Controls.Add(lb)
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
            lb1.DataBindings.Add("Text", DataSource, "TP" & dv2(j).Row("ID_thanh_phan"), "{0:n1}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Diem3.DataBindings.Add("Text", DataSource, "Diem_thi")
        DiemTB.DataBindings.Add("Text", DataSource, "TBCHP", "{0:n1}")
    End Sub

    Private Sub stt_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles stt.BeforePrint
        so_tt = so_tt + 1
        Me.stt.Text = so_tt
    End Sub
End Class