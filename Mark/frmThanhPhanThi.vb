Imports ESS.Entity
Imports ESS

Public Class frmThanhPhanThi
    Private mdsID_lop As String = ""
    Private mID_mon As Integer = 0
    Private Sub grvDanhSach_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvDanhSach.DataSourceChanged
        Try
            grvDanhSach.BestFitColumns()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub New(ByVal dsID_lops As String, ByVal ID_mon As Integer, ByVal dsThanhPhanThi As Generic.List(Of ThanhPhanThi))

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim dtThanhPhanDiemThi As DataTable = New DAL.DiemThiChiTiet_DAL().LoadAll()
        If Not dtThanhPhanDiemThi.Columns.Contains("Chon") Then dtThanhPhanDiemThi.Columns.Add("Chon", GetType(Boolean))
        For index As Integer = 0 To dtThanhPhanDiemThi.Rows.Count - 1
            dtThanhPhanDiemThi.Rows(index)("Chon") = False
            For Each thanhPhan As ThanhPhanThi In dsThanhPhanThi
                If thanhPhan.ID_thanh_phan = dtThanhPhanDiemThi.Rows(index)("ID_thanh_phan_thi") Then
                    dtThanhPhanDiemThi.Rows(index)("Chon") = True
                End If
            Next
        Next
        mdsID_lop = dsID_lops
        mID_mon = ID_mon
        grcDanhSach.DataSource = dtThanhPhanDiemThi


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            grvDanhSach.MoveLast()
            grvDanhSach.MoveFirst()
            Dim dv As DataView = grvDanhSach.DataSource
            Dim ID_lops() As String = mdsID_lop.Split(",")
            For index As Integer = 0 To ID_lops.Length - 1
                Dim ID_lop As Integer = ID_lops(index)
                For j As Integer = 0 To dv.Count - 1
                    Dim ID_thanh_phan_thi As Integer = dv.Item(j)("ID_thanh_phan_thi")
                    Dim SQL As String = "DELETE MARK_MonHoc_ThanhPhanThi WHERE ID_lop =" & ID_lop & " AND ID_mon=" & mID_mon & " AND ID_thanh_phan_thi = " & ID_thanh_phan_thi
                    ESS.Machine.UDB.Execute(SQL)
                    If dv.Item(j)("Chon") Then
                        SQL = "INSERT INTO MARK_MonHoc_ThanhPhanThi(ID_lop,ID_mon,ID_thanh_phan_thi)" & _
                        " VALUES(" & ID_lop & "," & mID_mon & "," & ID_thanh_phan_thi & ")"
                        ESS.Machine.UDB.Execute(SQL)
                    End If
                Next

            Next
            MessageBox.Show("Đã cập nhật thành công, hãy chọn lại môn học để load lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class