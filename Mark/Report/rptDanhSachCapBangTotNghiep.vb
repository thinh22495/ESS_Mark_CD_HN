﻿Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rptDanhSachCapBangTotNghiep
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de_bao_cao1 As String = "", Optional ByVal Tieu_de_bao_cao2 As String = "")
        InitializeComponent()
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & GetReportDate()
        'Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_bao_cao1.Text = Tieu_de_bao_cao1
        Me.Tieu_de_bao_cao2.Text = Tieu_de_bao_cao2
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Binding()
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")
    End Sub
End Class