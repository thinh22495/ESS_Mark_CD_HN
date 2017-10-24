Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_ThamSoQuyChe
#Region "Var"
    Private ClsQC As New QuyCheDaoTao
    Private dtThamsoQC As New DataTable
    Dim Loaded As Boolean = False
#End Region
#Region "Form Events"
    Private Sub frmESS_ThamSoQuyChe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdThamSoQC)
        Load_data()
        Loaded = True
        SetQuyenTruyCap(, cmdSave, , )
    End Sub
#End Region
#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim Co As Boolean = False
            If Me.grdThamSoQC.DataSource Is Nothing Then Exit Sub
            grdThamSoQC.EndEdit()
            Dim dv As DataView = grdThamSoQC.DataSource
            If Thongbao("Bạn có thực sự muốn thay đổi không ? ", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
                For i As Integer = 0 To dv.Count - 1
                    ClsQC.Update_ThamSoQuyChe(dv.Item(i)("ID_tham_so_qc"), dv.Item(i)("Gia_tri"))
                    Co = True
                Next
                If Not Co Then
                    Load_data()
                    Thongbao("Chưa thay đổi được ", MsgBoxStyle.OkOnly)
                Else
                    Thongbao("Đã thay đổi thành công ", MsgBoxStyle.OkOnly)
                End If
            Else
                Load_data()
            End If
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
#End Region
#Region "User Functions"
    Private Sub Load_data()
        dtThamsoQC = ClsQC.Load_DanhSach_BangQC
        Me.grdThamSoQC.DataSource = dtThamsoQC.DefaultView
    End Sub
#End Region
End Class