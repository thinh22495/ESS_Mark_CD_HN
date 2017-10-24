Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_TongHop_ThiLaiHocLai_DanhSach
    Private mcls As TongHopThiLaiHocLai_BLL
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mNien_khoa As String = ""
    Private mID_dt As Integer = 0

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Dim frmESS_ As New frmESS_TongHop_ThiLaiHocLai
        frmESS_.ShowDialog()
    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_DanhSach_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_DanhSach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_DanhSach_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
End Class