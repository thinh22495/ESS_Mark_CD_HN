﻿Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_ChangePassword
#Region "Form Event"
    Private Sub frmESS_ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
        txtUserName.Text = gobjUser.UserName
        txtPassWord.Text = gPassWord
    End Sub
    Private Sub frmESS_ChangePassword_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_ChangePassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then Call HandleNextTAB(Me)
    End Sub
#End Region

#Region "ToolBar Event"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

    Private Sub btnLogOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOn.Click
        Try
            Dim cls As New ThamSoHeThong_BLL(9) ' Phan he system
            If cls.Doc_tham_so("ldapCheck").ToString = 1 Then
                Thongbao("Hệ thống sử dụng User LDAP bạn không thể đổi password được ! ")
                Exit Sub
            End If
            If txtNewPassword.Text.Trim().Equals("") Then
                Thongbao("Bạn phải nhập mật khẩu mới !")
                Me.txtPassWord.Focus()
            ElseIf txtConfirm.Text.Trim().Equals("") Then
                Thongbao("Bạn phải nhập xác nhận mật khẩu mới !")
                Me.txtConfirm.Focus()
            ElseIf txtConfirm.Text.Trim() <> txtNewPassword.Text.Trim Then
                Thongbao("Bạn nhập xác nhận mật khẩu mới không đúng !")
                Me.txtConfirm.Focus()
            Else
                Dim UserID As Integer = gobjUser.UserID
                Dim NewPassWord As String
                NewPassWord = txtNewPassword.Text
                Dim clsUser As New Users_BLL()
                clsUser.ChangePassword(UserID, NewPassWord)
                Thongbao("Bạn đã thay đổi mật khẩu thành công !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class