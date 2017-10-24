Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Library
Imports ESS.Entity.Entity
Public Class frmESS_PhanCongThucTap
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private mclsDSTT As DanhSachThuctap_BLL

#Region "Form Events"
    Private Sub frmESS_PhanCongThucTap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính 
        Me.TrvLop_ChuanHoa.Load_TreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewNoiThucTap)
        SetQuyenTruyCap(, btnAdd, , btnDel)
    End Sub
    Private Sub frmESS_PhanCongThucTap_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll1.Checked
            Next
        End If
    End Sub
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewNoiThucTap.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon1") = optAll.Checked
            Next
        End If
    End Sub
    Private Sub TrvLop_ChuanHoa_TreeNodeSelected_() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        Try
            If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
                dsID_lop = TrvLop_ChuanHoa.ID_lop_list

                'Danh sách sinh viên thực tập
                mclsDSTT = New DanhSachThuctap_BLL(dsID_lop)
                Dim dt As DataTable = mclsDSTT.DanhSachThucTap()
                grdViewNoiThucTap.DataSource = dt.DefaultView

                'Lay danh sach sinh vien thuoc dien thuc tap
                Dim ID_svs As String = ""
                If dt.Rows.Count > 0 Then ID_svs = dt.Rows(0).Item("ID_svs").ToString

                'Load danh sách sinh viên để chọn vào danh sách thực tập (da loai sinh vien da xet thuc tap trong danh sach)
                Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop, ID_svs)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtNoi_thuctap.Text.Trim = "" Then
                Thongbao("Bạn phải nhập nơi thực tập cho sinh viên !", MsgBoxStyle.Information)
            Else
                If grdViewDanhSach.CurrentRow Is Nothing Then Exit Sub
                Dim dv As DataView = grdViewDanhSach.DataSource
                Dim dv2 As DataView = grdViewNoiThucTap.DataSource
                For i As Integer = dv.Count - 1 To 0 Step -1
                    If dv.Item(i)("Chon") Then
                        Dim objDSTT As New DanhSachThuctap
                        objDSTT.Ngay_sinh = dv.Item(i).Item("Ngay_sinh")
                        objDSTT.Noi_thuc_tap = txtNoi_thuctap.Text.Trim
                        objDSTT.ID_sv = dv.Item(i).Item("ID_SV")
                        objDSTT.Ma_sv = dv.Item(i).Item("Ma_sv").ToString
                        objDSTT.Ho_ten = dv.Item(i).Item("Ho_ten").ToString
                        objDSTT.Ten_lop = dv.Item(i).Item("Ten_lop").ToString

                        mclsDSTT.Insert_DanhSachThuctap(objDSTT)
                        mclsDSTT.Add(objDSTT)
                        grdViewNoiThucTap.DataSource = mclsDSTT.DanhSachThucTap.DefaultView
                        dv.Item(i).Row.Delete()
                    End If
                Next
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv As DataView = grdViewNoiThucTap.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon1") Then
                    'Day lai danh sach sinh vien
                    Dim dr As DataRow
                    dr = mdtDanhSachSinhVien.NewRow
                    dr.Item("ID_SV") = dv.Item(i).Item("ID_sv")
                    dr.Item("Ma_sv") = dv.Item(i).Item("Ma_sv2")
                    dr.Item("Ho_ten") = dv.Item(i).Item("Ho_ten2")
                    dr.Item("Ngay_sinh") = dv.Item(i).Item("Ngay_sinh2")
                    dr.Item("Ten_lop") = dv.Item(i).Item("Ten_lop2")
                    dr.Item("Chon") = False
                    mdtDanhSachSinhVien.Rows.Add(dr)

                    'Xoa ban ghi khoi CSDL va bo nhớ
                    mclsDSTT.Delete_DanhSachThuctap(dv.Item(i).Item("ID_sv"))
                    Dim idx As Integer = mclsDSTT.Tim_idx(dv.Item(i).Item("ID_sv"))
                    If idx >= 0 Then
                        mclsDSTT.Remove(idx)
                    End If
                End If
            Next
            grdViewNoiThucTap.DataSource = mclsDSTT.DanhSachThucTap.DefaultView
            grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewNoiThucTap.DataSource Is Nothing Then
                Dim dv As DataView = grdViewNoiThucTap.DataSource
                Dim Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4 As String
                Tieu_de1 = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM"
                Tieu_de2 = "Độc lập - Tự do - Hạnh phúc"
                Tieu_de3 = "DANH SÁCH SINH VIÊN ĐƯỢC PHÂN THỰC TẬP"
                Tieu_de4 = TrvLop_ChuanHoa.Tieu_de_KhoaHoc.ToUpper
                TaoBaoCao_PhanThucTap(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4)

                C1Report1.DataSource.Recordset = dv.Table
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(C1Report1)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewNoiThucTap, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

  
End Class