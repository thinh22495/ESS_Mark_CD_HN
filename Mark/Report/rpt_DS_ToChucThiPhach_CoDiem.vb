Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraReports.UI
Public Class rpt_DS_ToChucThiPhach_CoDiem
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de_bc As String = "")
        InitializeComponent()
        Dim dv As DataView = dtMain.DefaultView
        dv.RowFilter = "Diem_thi>=5"
        dv.Sort = "Ten_lop,Van_dau,Ten,Ho_dem"
        Dim dv2 As DataView = dtSub.DefaultView
        Dim dt As DataTable = dv.Table.Copy
        Me.DataSource = dv
        Me.Tieu_de_bao_cao.Text = Tieu_de_bc
        Me.Tieu_de_2.Text = dt.Rows(0).Item("Ten_he").ToString.ToUpper & " - " & " KHÓA THI NGÀY " & dt.Rows(0).Item("Ngay_thi").ToString
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Dim So_sv_duoi5 As Integer = 0
        Dim So_sv_tren5 As Integer = 0
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tong_sv.Text = "Danh sách này có " & dv.Count & " sinh viên"
        Binding()
    End Sub
    Public Sub Binding()
        Ho_dem.DataBindings.Add("Text", DataSource, "Ho_dem")
        Ten.DataBindings.Add("Text", DataSource, "Ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Bang_so.DataBindings.Add("Text", DataSource, "Diem_thi", "{0:n1}")
        Ten_tinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
    End Sub
End Class