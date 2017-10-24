Imports System
Imports System.Data
Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Public Class frmESS_ChayQuery

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If txtQuery.Text.Trim <> "" Then
            Dim cls As New Diem_BLL
            cls.ChayQuery(txtQuery.Text)
        End If
    End Sub
End Class