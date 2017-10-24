Imports ESS.BLL.Business
Public Class frmESS_ThayDoiThanhPhan
    Public mID_he As Integer = 0
    Private Function CheckValidate() As Boolean
        Dim dvTP As DataView = Me.grdViewTP.DataSource
        Dim Tong_ty_le As Integer = 0
        For i As Integer = 0 To dvTP.Count - 1
            If dvTP(i)("ID_thanh_phan").ToString = "" Then
                Thongbao("Bạn phải thêm thành phần trước khi lưu !")
                Return False
            End If
            If dvTP(i)("Chon") Then
                Tong_ty_le += dvTP(i)("Ty_le")
            End If
        Next
        If Tong_ty_le > 100 Or Tong_ty_le < 0 Then
            Thongbao("Bạn phải nhập tổng tỷ lệ > 0 và <=100 !")
            Return False
        Else
            Return True
        End If
    End Function
    Public Overloads Sub ShowDialog(ByVal dtTP As DataTable)
        Me.grdViewTP.DataSource = dtTP.DefaultView
        dtTP.DefaultView.AllowNew = False
        SetUpDataGridView(grdViewTP)
        Me.ShowDialog()
    End Sub

    Private Sub grdViewTP_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles grdViewTP.DataError
        Thongbao("Nhập sai kiểu dữ liệu !")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView
            grdViewTP.EndEdit()
            dv = grdViewTP.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim cls As New DanhMuc_BLL
            For i As Integer = 0 To dv.Count - 1
                If cls.DanhMuc_CheckName("MARK_ThanhPhanMon", "ID_thanh_phan", _
                IIf(dv.Item(i)("ID_thanh_phan").ToString = "", 0, dv.Item(i)("ID_thanh_phan"))) Then
                    cls.DanhMuc_Update("MARK_ThanhPhanMon", "ID_thanh_phan", dv.Item(i)("ID_thanh_phan"), _
                    "ID_he", mID_he, "STT", IIf(dv.Item(i)("STT").ToString = "", 0, dv.Item(i)("STT")), _
                    "Ky_hieu", dv.Item(i)("Ky_hieu").ToString, "Ten_thanh_phan", dv.Item(i)("Ten_thanh_phan").ToString, _
                    "Ty_le", IIf(dv.Item(i)("Ty_le").ToString = "", 0, dv.Item(i)("Ty_le")), _
                    "Chon_mac_dinh", 1)
                Else
                    If dv.Item(i)("STT").ToString <> "" And dv.Item(i)("Ky_hieu").ToString <> "" _
                    And dv.Item(i)("Ten_thanh_phan").ToString <> "" And dv.Item(i)("Ty_le").ToString <> "" Then
                        cls.DanhMuc_Insert("MARK_ThanhPhanMon", "ID_he", mID_he, "STT", _
                                            IIf(dv.Item(i)("STT").ToString = "", 0, dv.Item(i)("STT")), _
                                            "Ky_hieu", dv.Item(i)("Ky_hieu").ToString, "Ten_thanh_phan", dv.Item(i)("Ten_thanh_phan").ToString, _
                                            "Ty_le", IIf(dv.Item(i)("Ty_le").ToString = "", 0, dv.Item(i)("Ty_le")), _
                                            "Chon_mac_dinh", 1)
                    End If
                End If
            Next
            Thongbao("Bạn đã thêm thành công danh mục điểm thành phần !")
            Me.Tag = 0
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Tag = 0
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        grdViewTP.EndEdit()
        If CheckValidate() Then
            Me.Tag = 1
            Close()
        End If
    End Sub
End Class