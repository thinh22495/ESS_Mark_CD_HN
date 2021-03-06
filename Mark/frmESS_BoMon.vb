Imports System.Drawing.Drawing2D
Imports ESS.Entity.Entity
Public Class frmESS_BoMon
    Private mThoat As Boolean
    Private Sub frmESS_BoMon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        'e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Property Thoat() As Boolean
        Get
            Return mThoat
        End Get
        Set(ByVal value As Boolean)
            mThoat = value
        End Set
    End Property

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If ValidForm() = False Then Exit Sub
        Thoat = False
        Me.Close()
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Thoat = True
        Me.Close()
    End Sub

    Public Function getValueFromUI() As BoMon
        Dim obj As New BoMon
        Try
            obj.Ma_bo_mon = txtMa_Bo_Mon.Text
            obj.Bo_mon = txtBo_Mon.Text
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Return obj
    End Function
    Public Sub setValueToUI(ByVal obj As BoMon)
        Try
            txtBo_Mon.Text = obj.Bo_mon
            txtMa_Bo_Mon.Text = obj.ma_bo_mon
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If txtMa_Bo_Mon.Text = "" Then
            Me.ErrorProvider1.SetError(txtMa_Bo_Mon, "Bạn phải nhập mã Bộ môn !")
            txtMa_Bo_Mon.Focus()
            ValidForm = False
        ElseIf txtBo_Mon.Text = "" Then
            Me.ErrorProvider1.SetError(txtBo_Mon, "Phải nhập tên Bộ môn !")
            txtBo_Mon.Focus()
            ValidForm = False
        End If
    End Function
End Class
'dd