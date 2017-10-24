Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_PhongHoc_DanhSach
    Dim Loader As Boolean = False
    Dim mID_phong As Integer = 0
    Dim mNode As New TreeNode
    Dim objPhongHoc_bll As New PhongHoc_BLL

    Private Sub trvPhongHoc_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvPhongHoc.AfterSelect
        If Not e.Node Is Nothing AndAlso CType(e.Node.Tag, String) <> "" And Loader Then
            mNode = trvPhongHoc.SelectedNode
            LoadPhongHoc(e.Node)
        End If
    End Sub
    Private Sub FillTreeview(ByVal trvPhong As TreeView)
        Dim objPhongHoc_bll As New PhongHoc_BLL
        Dim dt As DataTable = objPhongHoc_bll.DanhSachPhongHoc
        Dim dr As DataRow
        Dim ID_co_so As Integer = 0, ID_tang As Integer = 0, ID_nha As Integer = 0, i As Integer = -1, j As Integer = -1, k As Integer = 0, l As Integer = 0
        Dim kt_nha As Boolean = False
        If dt Is Nothing Then Exit Sub
        For Each dr In dt.Rows
            If ID_co_so = dr.Item("ID_co_so") Then

Nha:
                If ID_nha = dr.Item("ID_nha") Then
ESSTang:
                    If ID_tang = dr.Item("ID_tang") Then
Phong:
                        l = l + 1
                    Else
                        'Add node 1, PLAN_TANG
                        k = k + 1
                        trvPhong.Nodes.Item(i).Nodes.Item(j).Nodes.Add("Tầng: " & dr.Item("ten_tang"))
                        trvPhong.Nodes(i).Nodes(j).Nodes(k).Tag = dr.Item("ID_co_so") & "#" & dr.Item("ID_nha") & "#" & dr.Item("ID_tang")
                        trvPhong.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 2
                        trvPhong.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 2
                        l = -1
                        'Add node 2, so phong
                        GoTo Phong
                    End If
                Else
                    'Add node 0, toa nha
                    j = j + 1
                    trvPhong.Nodes.Item(i).Nodes.Add("Nhà: " & dr.Item("Ten_nha"))
                    trvPhong.Nodes(i).Nodes(j).Tag = dr.Item("ID_co_so") & "#" & dr.Item("ID_nha")
                    trvPhong.Nodes(i).Nodes(j).ImageIndex = 1
                    k = -1
                    ID_tang = 0
                    GoTo ESSTang
                End If
            Else
                'Add node 0, Co so dao tao
                i = i + 1
                trvPhong.Nodes.Add("Cơ sở đào tạo: " & dr.Item("Ten_co_so"))
                trvPhong.Nodes(i).Tag = dr.Item("ID_co_so")
                trvPhong.Nodes(i).ImageIndex = 1
                j = -1
                ID_nha = 0
                GoTo Nha
            End If
            ID_co_so = dr.Item("ID_co_so")
            ID_nha = dr.Item("ID_nha")
            ID_tang = dr.Item("ID_tang")
        Next
    End Sub
    Private Sub frmESS_PhongHocList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillTreeview(trvPhongHoc)
        SetUpDataGridView(dgvPhongHoc)
        dgvPhongHoc.DataSource = objPhongHoc_bll.DanhSachPhongHoc().DefaultView
        Loader = True

        SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdDelete)
    End Sub
    Private Sub frmESS_PhongHocList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim objPhongHoc As New PhongHoc
            Dim frmESS_ As New frmESS_PhongHoc
            While True
                ' Điền các giá trị tòa nhà, tầng vào from PhongHoc
                If Not mNode.Tag Is Nothing AndAlso CType(mNode.Tag, String) <> "" And Loader Then
                    Dim arr() As String = CType(mNode.Tag, String).Split("#")
                    objPhongHoc.ID_co_so = arr(0)
                    If arr.Length >= 2 Then objPhongHoc.ID_nha = arr(1)
                    If arr.Length >= 3 Then objPhongHoc.ID_tang = arr(2)
                    frmESS_.setValueToUI(objPhongHoc)
                End If
                ' Hiển thị form PhongHoc, lấy giá trị và insert
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objPhongHoc = frmESS_.getValueFromUI()
                    If Not objPhongHoc_bll.CheckExist_TenPhongHoc(objPhongHoc.ID_co_so, objPhongHoc.ID_nha, objPhongHoc.ID_tang, objPhongHoc.So_phong) Then
                        objPhongHoc_bll.Insert_PhongHoc(objPhongHoc)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Reload()
                        Exit While
                    Else
                        Thongbao("Số phòng này đã tồn tại !", MsgBoxStyle.OkOnly)
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
            Dim objPhongHoc As New PhongHoc
            Dim frmESS_ As New frmESS_PhongHoc
            Dim So_phong As String = ""
            'Kiểm tra đã chọn phòng học chưa
            Dim rowCurr As DataGridViewRow = dgvPhongHoc.CurrentRow
            If Not rowCurr Is Nothing Then
                mID_phong = rowCurr.Cells("ID_phong").Value
                So_phong = rowCurr.Cells("So_phong").Value
                objPhongHoc = objPhongHoc_bll.GetPhongHoc(mID_phong)
            Else
                Thongbao("Bạn hãy chọn 1 phòng để sửa !", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            ' Gán giá trị, hiển thị form PhongHoc, lấy giá trị và update
            While True
                frmESS_.setValueToUI(objPhongHoc)
                frmESS_.ShowDialog()
                If Not frmESS_.Thoat Then
                    objPhongHoc = frmESS_.getValueFromUI()
                    objPhongHoc.ID_phong = mID_phong
                    If So_phong = objPhongHoc.So_phong Then
                        objPhongHoc_bll.Update_PhongHoc(objPhongHoc, mID_phong)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Reload()
                        Exit While
                    Else
                        If Not objPhongHoc_bll.CheckExist_TenPhongHoc(objPhongHoc.ID_co_so, objPhongHoc.ID_nha, objPhongHoc.ID_tang, objPhongHoc.So_phong) Then
                            objPhongHoc_bll.Update_PhongHoc(objPhongHoc, mID_phong)
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
            ' Kiểm tra đã chọn phòng
            Dim rowCurr As DataGridViewRow = dgvPhongHoc.CurrentRow
            If Not rowCurr Is Nothing Then
                mID_phong = rowCurr.Cells("ID_phong").Value
            Else
                Thongbao("Bạn hãy chọn 1 phòng để sửa !", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            ' Xóa phòng
            If Thongbao("Bạn có muốn xóa không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                objPhongHoc_bll.Delete_PhongHoc(mID_phong)
                Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                '
                Reload()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub Reload(Optional ByVal status As Integer = 0)
        If status = 1 Then
            trvPhongHoc.Nodes.Clear()
            FillTreeview(trvPhongHoc)
        End If
        objPhongHoc_bll = New PhongHoc_BLL
        dgvPhongHoc.DataSource = objPhongHoc_bll.DanhSachPhongHoc().DefaultView
        LoadPhongHoc(mNode)
    End Sub
    Private Sub LoadPhongHoc(ByVal Node As TreeNode)
        If Not mNode.Tag Is Nothing Then
            Dim arr() As String = CType(Node.Tag, String).Split("#")
            Dim DieuKien As String = "ID_co_so=" & arr(0)
            If arr.Length >= 2 Then DieuKien &= " AND ID_nha=" & arr(1)
            If arr.Length >= 3 Then DieuKien &= " AND ID_tang=" & arr(2)
            Dim dv As DataView = dgvPhongHoc.DataSource
            dv.RowFilter = DieuKien
            txtSucChua.Text = "0"
            For i As Integer = 0 To dv.Count - 1
                txtSucChua.Text = CType(CInt(txtSucChua.Text) + CInt(dv(i)("Suc_chua")), String)
            Next
            txtSoPhong.Text = dv.Count.ToString
        End If
    End Sub


End Class