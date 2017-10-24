Imports System.Drawing.Drawing2D
Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_BoMon_DanhSach
    Dim objBm_bll As New BoMon_BLL
    Private mID_bm As Integer
    Private mID_mon As Integer
    Private mID_cb As Integer
    Private Loader As Boolean = False

    Private Sub frmESS_BoMonList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            SetUpDataGridView(dgvBoMon)
            SetUpDataGridView(dgvMonHoc)
            SetUpDataGridView(dgvGiangVien)
            dgvBoMon.DataSource = objBm_bll.DanhSachBoMon()
            Dim rowCurr As DataGridViewRow = dgvBoMon.CurrentRow
            If Not rowCurr Is Nothing Then
                mID_bm = rowCurr.Cells("ID_bm").Value
                dgvMonHoc.DataSource = objBm_bll.DanhSachMonHoc(mID_bm)
                dgvGiangVien.DataSource = objBm_bll.DanhSachGiangVien(mID_bm)
            End If
            '
            SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdDelete)
            Loader = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_BoMonList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim objbm As New BoMon
            Dim frmESS_ As New frmESS_BoMon
            While True
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objbm = frmESS_.getValueFromUI()
                    If Not objBm_bll.CheckExist_Bomon(objbm.Ma_bo_mon) Then
                        objBm_bll.Insert_BoMon(objbm)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Reload()
                        Exit While
                    Else
                        Thongbao("Mã Bộ môn này đã tồn tại !", MsgBoxStyle.OkOnly)
                    End If
                Else
                    Exit While
                End If
            End While
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Dim objbm As BoMon
            Dim frmESS_ As New frmESS_BoMon
            Dim mMa_bm As String = ""
            'Kiểm tra đã chọn chưa
            If CheckSelectedBoMon() Then
                objbm = objBm_bll.Load_BoMon(mID_bm)
                mMa_bm = objbm.Ma_bo_mon
            Else : Exit Sub
            End If
            '
            While True
                frmESS_.setValueToUI(objbm)
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objbm = frmESS_.getValueFromUI()
                    objbm.ID_bm = mID_bm
                    If objbm.Ma_bo_mon = mMa_bm Then
                        objBm_bll.Update_BoMon(objbm)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Reload()
                        Exit While
                    Else
                        If Not objBm_bll.CheckExist_Bomon(objbm.Ma_bo_mon) Then
                            objBm_bll.Update_BoMon(objbm)
                            Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                            Reload()
                            Exit While
                        Else
                            Thongbao("Mã Bộ môn này đã tồn tại !", MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    Exit While
                End If
            End While
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            'Kiểm tra đã chọn chưa
            If CheckSelectedBoMon() Then
                If Thongbao("Bạn có muốn xóa không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    objBm_bll.Delete_BoMon(mID_bm)
                    Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                    Reload()
                End If
            Else : Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub btnThemMon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemMon.Click
        Try
            Dim frmESS_ As New frmESS_BoMonChonHocPhan
            Dim objMonHoc_bll As New MonHoc_BLL
            Dim objMonHoc As New MonHoc
            If CheckSelectedBoMon() Then
                frmESS_.ID_bm = mID_bm
            End If
            frmESS_.ShowDialog()
            If Not frmESS_.Thoat And frmESS_.MonHoc.Count > 0 Then
                For i As Integer = 0 To frmESS_.MonHoc.Count - 1
                    objMonHoc = frmESS_.MonHoc(i)
                    objMonHoc_bll.Update_MonHoc(objMonHoc, objMonHoc.ID_mon)
                Next
                Reload()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnThemGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemGV.Click
        Try
            Dim frmESS_ As New frmESS_BoMonChonGiaoVien
            Dim objBoMonGiangVien_bll As New BoMonGiangVIen_BLL
            Dim objBoMonGiangVien As New BoMonGiangVien
            If CheckSelectedBoMon() Then
                frmESS_.ID_bm = mID_bm
            End If
            frmESS_.ShowDialog()
            If Not frmESS_.Thoat And frmESS_.arrID_cb.Count > 0 Then
                For i As Integer = 0 To frmESS_.arrID_cb.Count - 1
                    objBoMonGiangVien.ID_cb = frmESS_.arrID_cb(i)
                    objBoMonGiangVien.ID_bm = mID_bm
                    If Not objBoMonGiangVien_bll.CheckExist_BoMonGiangVien(objBoMonGiangVien.ID_bm, objBoMonGiangVien.ID_cb) Then
                        objBoMonGiangVien_bll.Insert_BoMonGiangVien(objBoMonGiangVien)
                    End If
                Next
                Reload()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnXoaGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaGV.Click
        If Loader = False Then Exit Sub
        If CheckSelectedGiangVien() Then
            If Thongbao("Bạn có muốn xóa cán bộ này ra khỏi Bộ môn không ?", MsgBoxStyle.YesNo, ) = MsgBoxResult.Yes Then
                Dim objBoMonGiangVien As New BoMonGiangVIen_BLL
                objBoMonGiangVien.Delete_BoMonGiangVien(mID_bm, mID_cb)
                Reload()
            End If
        End If
    End Sub
    Private Sub btnXoaMon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaMon.Click
        If Loader = False Then Exit Sub
        Dim rowCurr As DataGridViewRow = dgvMonHoc.CurrentRow
        If Not rowCurr Is Nothing Then
            Dim ID_mon As Integer = rowCurr.Cells("ID_mon").Value
            If Thongbao("Bạn có muốn xóa Học phần này ra khỏi Bộ môn không ?", MsgBoxStyle.YesNo, ) = MsgBoxResult.Yes Then
                Dim objMonHoc_bll As New MonHoc_BLL
                Dim objMh As MonHoc = objMonHoc_bll.GetMonHoc(ID_mon)
                objMh.ID_bm = 0
                objMonHoc_bll.Update_MonHoc(objMh, ID_mon)
                Reload()
            End If
        End If
    End Sub

    Private Sub Reload()
        Try
            If Loader = False Then Exit Sub
            objBm_bll = New BoMon_BLL
            dgvBoMon.DataSource = objBm_bll.DanhSachBoMon()
            Dim rowCurr As DataGridViewRow = dgvBoMon.CurrentRow
            If Not rowCurr Is Nothing Then
                mID_bm = rowCurr.Cells("ID_bm").Value
                dgvMonHoc.DataSource = objBm_bll.DanhSachMonHoc(mID_bm)
                dgvGiangVien.DataSource = objBm_bll.DanhSachGiangVien(mID_bm)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridViewBoMon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBoMon.Click
        If Loader = False Then Exit Sub
        Dim rowCurr As DataGridViewRow = dgvBoMon.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_bm = rowCurr.Cells("ID_bm").Value
            dgvMonHoc.DataSource = objBm_bll.DanhSachMonHoc(mID_bm)
            dgvGiangVien.DataSource = objBm_bll.DanhSachGiangVien(mID_bm)
        End If
    End Sub
    Private Function CheckSelectedBoMon() As Boolean
        Dim rowCurr As DataGridViewRow = dgvBoMon.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_bm = rowCurr.Cells("ID_bm").Value
            Return True
        Else
            Thongbao("Bạn chưa chọn Bộ môn !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckSelectedMonHoc() As Boolean
        Dim rowCurr As DataGridViewRow = dgvMonHoc.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_mon = rowCurr.Cells("ID_mon").Value
            Return True
        Else
            Thongbao("Bạn chưa chọn Học phần !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckSelectedGiangVien() As Boolean
        Dim rowCurr As DataGridViewRow = dgvGiangVien.CurrentRow
        If Not rowCurr Is Nothing Then
            mID_cb = rowCurr.Cells("ID_cb").Value
            Return True
        Else
            Thongbao("Bạn chưa chọn giảng viên !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function


End Class
