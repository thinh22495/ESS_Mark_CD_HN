﻿Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_ThamSoHeThong
#Region "Var"
    Private ClsThamsohethong As New ThamSoHeThong_BLL(gID_ph)
    Private dtThamsohethong As New DataTable
    Dim Loaded As Boolean = False
#End Region
#Region "Form Events"
    Private Sub frmESS_ThamSoHeThong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_data()
        Loaded = True

        SetQuyenTruyCap(, cmdSave, , )
    End Sub
#End Region
#Region "Control Events"

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim Co As Boolean = False
            If grvDanhSachThamSo.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grvDanhSachThamSo.DataSource
            If Thongbao("Bạn có thực sự muốn thay đổi không ? ", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i).Row.RowState = DataRowState.Modified Then
                        'ClsThamsohethong.aThamSoHeThongs.Remove(i)
                        Dim thamsohethong As New ThamSoHeThong
                        thamsohethong.ID_tham_so = dv.Item(i)("ID_tham_so")
                        If IsDBNull(dv.Item(i)("Gia_tri").ToString.Trim) Then
                            thamsohethong.Gia_tri = ""
                        Else
                            thamsohethong.Gia_tri = dv.Item(i)("Gia_tri")
                        End If
                        thamsohethong.Ten_tham_so = dv.Item(i)("Ten_tham_so")
                        thamsohethong.Ghi_chu = dv.Item(i)("Ghi_chu")
                        thamsohethong.ID_ph = dv.Item(i)("ID_ph")
                        thamsohethong.Active = dv.Item(i)("Active")
                        ClsThamsohethong.Update_ThamSoHeThong(thamsohethong)
                        Co = True
                    End If
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

#End Region
#Region "User Functions"
    Private Sub Load_data()
        ClsThamsohethong = New ThamSoHeThong_BLL(gID_ph)
        dtThamsohethong = ClsThamsohethong.Load_ThamSoHeThong
        grcDanhSachThamSo.DataSource = dtThamsohethong.DefaultView
    End Sub
#End Region

   
End Class