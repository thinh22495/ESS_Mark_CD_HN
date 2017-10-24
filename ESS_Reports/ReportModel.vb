'Coded By: AnhNT
'Created date: 22/3/2012
'Company: Thien An ESS Co.,Ltd
Imports ESS.BLL.Business
Imports DevExpress.XtraReports.UI
Public Class ReportModel
#Region "Var"
    Public Shared HeaderTable As Dictionary(Of String, CellReport)
    Public Shared ValueTable As Dictionary(Of String, CellReport)
    Public Shared HeaderDynamicTable1 As Dictionary(Of String, CellReport)
    Public Shared HeaderDynamicTable2 As Dictionary(Of String, CellReport)
    Public Shared ListHeaderDynamicTable As List(Of Dictionary(Of String, CellReport))
#End Region
    Public Shared Sub Init()
        HeaderTable = New Dictionary(Of String, CellReport)()
        ValueTable = New Dictionary(Of String, CellReport)()
        HeaderDynamicTable1 = New Dictionary(Of String, CellReport)()
        HeaderDynamicTable2 = New Dictionary(Of String, CellReport)()
        ListHeaderDynamicTable = New List(Of Dictionary(Of String, CellReport))()
    End Sub
#Region "Tieu de bao cao"
    'Tieu de bao cao
    Public Shared Tieu_de_ten_bo As String = ""
    Public Shared Tieu_de_ten_truong As String = ""
    Public Shared Tieu_de_noi_ki As String = ""
    Public Shared Tieu_de_chuc_danh1 As String = ""
    Public Shared Tieu_de_chuc_danh2 As String = ""
    Public Shared Tieu_de_chuc_danh3 As String = ""
    Public Shared Tieu_de_chuc_danh4 As String = ""
    Public Shared Tieu_de_nguoi_ki1 As String = ""
    Public Shared Tieu_de_nguoi_ki2 As String = ""
    Public Shared Tieu_de_nguoi_ki3 As String = ""
    Public Shared Tieu_de_nguoi_ki4 As String = ""
    Public Shared Sub GetReportHeader(ByVal ID_dv As String, ByVal userID As Integer)
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(ID_dv, userID)
        'Fill Value Tieu_de_bao_cao
        If objBaoCaoTieuDe.Count <= 0 Then Exit Sub
        Tieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
        Tieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
        Tieu_de_noi_ki = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
        Tieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
        Tieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
        Tieu_de_chuc_danh3 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh3
        Tieu_de_chuc_danh4 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh4
        Tieu_de_nguoi_ki1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
        Tieu_de_nguoi_ki2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
        Tieu_de_nguoi_ki3 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky3
        Tieu_de_nguoi_ki4 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky4
    End Sub
#End Region
End Class

