Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class rpt_Phach_ToChucThi
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal dt As DataTable = Nothing)
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng" & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        'Me.Phong_thi1.Text = dt.Rows(0)("Ten_phong").ToString
        Me.Ngay_thi1.Text = Format(CType(dt.Rows(0)("Ngay_thi"), Date), "dd/MM/yyyy")
        Me.Ten_mon1.Text = dt.Rows(0)("Ten_mon").ToString

        'Me.Phong_thi2.Text = dt.Rows(0)("Ten_phong").ToString
        Me.Ngay_thi2.Text = Format(CType(dt.Rows(0)("Ngay_thi"), Date), "dd/MM/yyyy")
        Me.Ten_mon2.Text = dt.Rows(0)("Ten_mon").ToString
    End Sub
    Public Sub Binding()
        SBD.DataBindings.Add("Text", DataSource, "So_bao_danh")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        So_phach1.DataBindings.Add("Text", DataSource, "So_phach")
        So_phach2.DataBindings.Add("Text", DataSource, "So_phach")
        Phong_thi1.DataBindings.Add("Text", DataSource, "Ten_phong")
        Phong_thi1.DataBindings.Add("Text", DataSource, "Ten_phong")
        Phong_thi2.DataBindings.Add("Text", DataSource, "Ten_phong")
    End Sub

End Class