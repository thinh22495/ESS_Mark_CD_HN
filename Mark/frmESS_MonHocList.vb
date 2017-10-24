Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_MonHocList
    Dim Loader As Boolean = False
    Dim mID_mon As Integer = 0
    Dim objMonHoc_bll As MonHoc_BLL
    Dim dtHe As DataTable
    Dim dtNhomHP As DataTable



    Private Sub frmESS__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim clsDM As New DanhMuc_BLL
            dtHe = clsDM.DanhMuc_Load("STU_He", "ID_he", "Ten_he")
            dtNhomHP = clsDM.DanhMuc_Load("PLAN_MonHocNhomHocPhan", "ID_nhom_hp", "Ten_nhom")

            Load_MonHoc()
            'Set Security
            SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdDelete)
            Loader = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmESS_MonHocList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub



    Private Sub Load_MonHoc()
        objMonHoc_bll = New MonHoc_BLL
        grcDanhSachHP.DataSource = objMonHoc_bll.DanhSachMonHoc().DefaultView
        lukNhom_hp.DataSource = dtNhomHP
        lukTrinhDo.DataSource = dtHe
    End Sub

    Private Function CheckSelectedGridView() As Boolean
        Dim rowIndex As Integer = -1
        rowIndex = grvDanhSachHP.GetSelectedRows().GetValue(0)
        Dim row As DataRow = grvDanhSachHP.GetDataRow(rowIndex)

        If Not row Is Nothing Then
            mID_mon = row("ID_mon")
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function




    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Dim objMonHoc As New MonHoc
            Dim KyHieu As String = ""
            Dim frmESS_ As New frmESS_MonHoc
            Dim So_phong As String = ""
            'Kiểm tra đã chọn học phần chưa
            If CheckSelectedGridView() Then
                objMonHoc = objMonHoc_bll.GetMonHoc(mID_mon)
                KyHieu = objMonHoc.Ky_hieu
            Else : Exit Sub
            End If
            ' Gán giá trị, hiển thị form MonHoc, lấy giá trị và update
            While True
                frmESS_.setValueToUI(objMonHoc)
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objMonHoc = frmESS_.getValueFromUI()
                    'Kiem tra ma mon học
                    If objMonHoc.Ky_hieu = KyHieu Then
                        objMonHoc_bll.Update_MonHoc(objMonHoc, mID_mon)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Load_MonHoc()
                        Exit While
                    Else
                        'Kiem tra ton tai ma mon
                        If Not objMonHoc_bll.CheckExistKyHieu(objMonHoc.Ky_hieu, objMonHoc.ID_he) Then
                            objMonHoc_bll.Update_MonHoc(objMonHoc, mID_mon)
                            Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                            Load_MonHoc()
                            Exit While
                        Else
                            Thongbao("Mã Học phần trong hệ đã tồn tại !", MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    Exit While
                End If
            End While
        Catch ex As Exception
            Thongbao("Lỗ trong quá trình cập nhật !", MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            ' Kiểm tra đã chọn phòng
            If CheckSelectedGridView() = False Then Exit Sub
            ' Xóa phòng
            If Thongbao("Bạn có muốn xóa không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                objMonHoc_bll.Delete_MonHoc(mID_mon)
                Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                Load_MonHoc()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim objMonHoc As New MonHoc
            Dim frmESS_ As New frmESS_MonHoc
            While True
                ' Hiển thị form MonHoc, lấy giá trị và insert
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objMonHoc = frmESS_.getValueFromUI()
                    If Not objMonHoc_bll.CheckExistKyHieu(objMonHoc.Ky_hieu, objMonHoc.ID_he) Then
                        objMonHoc_bll.Insert_MonHoc(objMonHoc)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Load_MonHoc()
                        Exit While
                    Else
                        Thongbao("Ký hiệu mã Học phần cho hệ này đã được tạo rồi !", MsgBoxStyle.OkOnly)
                    End If
                Else
                    Exit While
                End If
            End While
        Catch ex As Exception
            Thongbao("Lỗ trong quá trình cập nhật !", MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class