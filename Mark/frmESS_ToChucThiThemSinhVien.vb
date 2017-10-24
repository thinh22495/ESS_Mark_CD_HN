Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_ToChucThiThemSinhVien
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mLan_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private Loader As Boolean = False
    Private mID_he As Integer = 0

    Private clsDiem As Diem_BLL

#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer, ByVal ID_mon As Integer)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mLan_thi = Lan_thi
        mID_mon = ID_mon
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ToChucThiThemSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TrvLop_ChuanHoa.Load_TreeView()
        'SetUpDataGridView(grdViewDanhSach)
        'SetUpDataGridView(grdViewDanhSachChon)
        cmbLocTheo.SelectedIndex = 1

        clsDiem = New Diem_BLL
        Dim objDanhSach As New DanhSachSinhVien_BLL(-1)
        Dim dtDanhSachSinhVien As New DataTable
        dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
        grcViewDanhSachChon.DataSource = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien).DefaultView
    End Sub
    Private Sub frmESS_ToChucThiThemSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "User Function"
    Private Sub Load_sinh_vien()
        Dim dsID_lop As String = TrvLop_ChuanHoa.ID_lop_list
        mID_he = TrvLop_ChuanHoa.ID_he
        'Load danh sách sinh viên
        Dim dtDanhSachSinhVien As New DataTable
        Select Case cmbLocTheo.SelectedIndex
            Case 0  'Danh sách thi lại lớp hành chính
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien

                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                Dim dt As New DataTable
                If ckKhong_du_dk.Checked = True Then
                    dt = clsDiem.DanhSachThiLaiHocLai(mID_mon, 1)
                Else
                    dt = clsDiem.DanhSachThiLaiHocLai(mID_mon, 0)
                End If
                grcViewDanhSach.DataSource = dt.DefaultView
            Case 1  'Danh sách lớp
                If mLan_thi = 1 Then
                    'Load sinh vien theo lớp
                    Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, mHoc_ky, mNam_hoc, dsID_lop, CType(TrvLop_ChuanHoa.ID_dt_list, Integer), dtDanhSachSinhVien)
                    Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)

                    grcViewDanhSach.DataSource = dt.DefaultView
                End If
            Case 2  'Danh sách tốt nghiệp
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_thitotnghiep(dsID_lop)
                'clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, mHoc_ky, mNam_hoc, dsID_lop, CType(TrvLop_ChuanHoa.ID_dt_list, Integer), dtDanhSachSinhVien)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)

                grcViewDanhSach.DataSource = dt.DefaultView
            Case 3  'Danh sách làm luận văn
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_lamluanvan(dsID_lop)
                'clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, mHoc_ky, mNam_hoc, dsID_lop, CType(TrvLop_ChuanHoa.ID_dt_list, Integer), dtDanhSachSinhVien)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)

                grcViewDanhSach.DataSource = dt.DefaultView

            Case 4  ' Danh sách thi chính trị
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.DanhSachSinhVien_DuThiChinhTri(dsID_lop)
                'clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                clsDiem = New Diem_BLL(mID_he, gobjUser.ID_dv, gobjUser.ID_Bomon, mHoc_ky, mNam_hoc, dsID_lop, CType(TrvLop_ChuanHoa.ID_dt_list, Integer), dtDanhSachSinhVien)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)
                grcViewDanhSach.DataSource = dt.DefaultView
        End Select
    End Sub
#End Region
#Region "Control Events"
    Private Sub TrvLop_ChuanHoa_Select() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If TrvLop_ChuanHoa.ID_lop_list > 0 Then
                Load_sinh_vien()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbLocTheo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocTheo.SelectedIndexChanged
        Try
            If TrvLop_ChuanHoa.ID_lop_list > 0 AndAlso cmbLocTheo.SelectedIndex >= 0 Then
                Load_sinh_vien()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub
    Private Sub chkAll2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll2.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSachChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll2.Checked
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv As Integer = 0
            dv = grdViewDanhSach.DataSource
            dvChon = grdViewDanhSachChon.DataSource
            If dvChon Is Nothing Then dvChon.Table = dv.Table.Clone
            dvChon.Sort = "ID_sv"
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") AndAlso dvChon.Find(dv.Item(i)("ID_SV")) < 0 Then
                    Dim dr As DataRow
                    dr = dvChon.Table.NewRow
                    dr.ItemArray = dv.Item(i).Row.ItemArray
                    dvChon.Table.Rows.Add(dr)
                    dv.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để thêm ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = 0
        Close()
    End Sub
#End Region

    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = 1
        Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv As Integer = 0
            dv = grdViewDanhSach.DataSource
            dvChon = grdViewDanhSachChon.DataSource
            If dvChon Is Nothing Then dvChon.Table = dv.Table.Clone
            dvChon.Sort = "ID_sv"
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") AndAlso dvChon.Find(dv.Item(i)("ID_SV")) < 0 Then
                    Dim dr As DataRow
                    dr = dvChon.Table.NewRow
                    dr.ItemArray = dv.Item(i).Row.ItemArray
                    dvChon.Table.Rows.Add(dr)
                    dv.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để thêm ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv As Integer = 0
            dv = grdViewDanhSach.DataSource
            dvChon = grdViewDanhSachChon.DataSource
            If dvChon Is Nothing Then Exit Sub
            For i As Integer = dvChon.Count - 1 To 0 Step -1
                If dvChon.Item(i)("Chon") Then
                    Dim dr As DataRow
                    dr = dv.Table.NewRow
                    dr.ItemArray = dvChon.Item(i).Row.ItemArray
                    dv.Table.Rows.Add(dr)
                    dvChon.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để xoá ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnToTucThi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToTucThi.Click
        Me.Tag = 1
        Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub ckKhong_du_dk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckKhong_du_dk.CheckedChanged
        Load_sinh_vien()
    End Sub
End Class