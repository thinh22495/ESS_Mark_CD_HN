Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_ThietLapMonChungChi
    Private mID_dt As Integer
    Private mID_chung_chi As Integer
    Private mID_mon As Integer
    Private mLoader As Boolean = False
    Dim dtMonChungChi As DataTable
    Private mcls As New LoaiChungChiDanhSachMon_BLL

    Public Overloads Sub ShowDialog(ByVal ID_dt As Integer)
        mID_dt = ID_dt
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ThietLapMonChungChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewLoaiChungChi)
        SetUpDataGridView(grdViewMonChungChi)
        grdViewLoaiChungChi.ReadOnly = True
        grdViewMonChungChi.ReadOnly = True
        ShowGridView()
        mLoader = True
    End Sub
    Private Sub grdViewLoaiChungChi_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewLoaiChungChi.SelectionChanged
        If mLoader Then
            ShowGridViewMonChungChi()
        End If
    End Sub
    Private Sub cmdGanMonChungChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGanMonChungChi.Click
        Dim frmESS_ As New frmESS_ChonMonHocChungChi
        frmESS_.ID_dt = mID_dt
        frmESS_.ShowDialog()
        If frmESS_.Thoat = False Then
            mID_chung_chi = frmESS_.ID_chung_chi
            For i As Integer = 0 To frmESS_.MonHoc.Count - 1
                mcls.Insert_LoaiChungChiDanhSachMon(mID_chung_chi, CType(frmESS_.MonHoc(i), MonHoc).ID_mon, mID_dt)
            Next
            ShowGridView()
        End If
    End Sub
    Private Sub ShowGridView()
        dtMonChungChi = mcls.Load_LoaiChungChiDanhSachMon(mID_dt)
        If dtMonChungChi.Rows.Count = 0 Then Exit Sub
        Dim para(2) As String
        para(0) = "ID_chung_chi"
        para(1) = "Ky_hieu_cc"
        para(2) = "Loai_chung_chi"
        Dim dtLoaiChungChi As DataTable = SelectDistinct(dtMonChungChi, para)
        grdViewLoaiChungChi.DataSource = dtLoaiChungChi.DefaultView
        ShowGridViewMonChungChi()
    End Sub
    Private Sub ShowGridViewMonChungChi()
        If CheckSelectedGridViewLoaiChungChi() Then
            Dim dv As DataView = dtMonChungChi.DefaultView
            dv.RowFilter = "ID_chung_chi=" & mID_chung_chi
            grdViewMonChungChi.DataSource = dv
        End If
    End Sub
    Private Function CheckSelectedGridViewLoaiChungChi() As Boolean
        Dim rowCurr As DataGridViewRow = grdViewLoaiChungChi.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_chung_chi = rowCurr.Cells("ID_chung_chi").Value
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckSelectedGridViewMonChungChi() Then
            mcls.Delete_LoaiChungChiDanhSachMon(mID_chung_chi, mID_mon, mID_dt)
            ShowGridView()
        End If
    End Sub
    Private Function CheckSelectedGridViewMonChungChi() As Boolean
        Dim rowCurr As DataGridViewRow = grdViewMonChungChi.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_mon = rowCurr.Cells("ID_mon").Value
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class