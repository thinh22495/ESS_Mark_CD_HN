Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports ESS.Catalogue
Imports ESS.Machine
Public Class frmESS_InChungChi_List
    Private Sub frmESS_InChungChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub
    Private Sub Load_Data()
        Try
            Dim objInChungChi As New InChungChi_BLL
            Dim dt As DataTable = objInChungChi.InChungChi_Load_List()
            dt.Columns.Add("Chon", Type.GetType("System.Boolean"))
            For Each row As DataRow In dt.Rows
                row("Chon") = False
            Next
            Dim dv As DataView = dt.DefaultView
            dv.Sort = "Ten_cc,Van_dau,Ten,Ho_dem ASC"
            grcDanhSach.DataSource = dv
            grvDanhSach.ViewCaption = "DANH SÁCH IN CHỨNG CHỈ"
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnLap_so_SoHieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLap_so_SoHieu.Click
        Try
            Dim objInChungChi As New InChungChi_BLL
            If txtDo_dai_So_hieu.Text = "" Or (txtDo_dai_So_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_hieu.Text.Trim)) Or txtTienTo_SoHieu.Text.Trim = "" Or txtTu_so_so_hieu.Text = "" Or (txtTu_so_so_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_so_so_hieu.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số hiệu bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_so_so_hieu.Text
            Dim Do_dai As Integer = txtDo_dai_So_hieu.Text.Trim
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_BLL
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_hieu") = txtTienTo_SoHieu.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    objInChungChi.CapNhat_SoHieu(dr("So_hieu"), dr("ID_SV"), dr("Ten_cc"))
                End If
            Next
            grcDanhSach.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_SoVaoSo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_SoVaoSo.Click
        Try
            Dim objInChungChi As New InChungChi_BLL
            If txtDo_dai_So_van_bang.Text = "" Or (txtDo_dai_So_van_bang.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_van_bang.Text.Trim)) Or txtTien_to_SoVaoSo.Text.Trim = "" Or txtTu_So_SoVaoSo.Text = "" Or (txtTu_So_SoVaoSo.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_So_SoVaoSo.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số vào sổ bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_So_SoVaoSo.Text
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            Dim Do_dai As Integer = txtDo_dai_So_van_bang.Text.Trim
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_BLL
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_vao_so") = txtTien_to_SoVaoSo.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    objInChungChi.CapNhat_SoVaoSo(dr("So_vao_so"), dr("ID_SV"), dr("Ten_cc"))
                End If
            Next
            grcDanhSach.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ckChonAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckChonAll.CheckedChanged
        Dim dv As DataView = GetFilteredDataView(grcDanhSach)
        For Each dr As DataRowView In dv
            dr("Chon") = ckChonAll.Checked
        Next
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            dv.RowFilter = "Chon = True"
            If dv.Count = 0 Then Exit Sub
            Dim rpt As New rptInChungChi(dv)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub grvDanhSach_ColumnFilterChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvDanhSach.ColumnFilterChanged
        grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN IN CHỨNG CHỈ: " & grvDanhSach.DataRowCount
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Load_Data()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub tbnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnThem.Click
        Dim frm As New frmESS_InChungChi
        frm.ShowDialog()
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Try
            Dim id_sv As Integer = 0
            Dim Ten_cc As String = ""
            id_sv = grvDanhSach.GetRowCellValue(grvDanhSach.FocusedRowHandle, "ID_sv")
            Ten_cc = grvDanhSach.GetRowCellValue(grvDanhSach.FocusedRowHandle, "Ten_cc")
            If id_sv > 0 And Ten_cc <> "" Then
                Dim frm As New frmESS_InChungChi
                frm.ShowDialog(id_sv, Ten_cc)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnXoa.Click
        Dim id_sv As Integer = 0
        Dim Ten_cc As String = ""
        id_sv = grvDanhSach.GetRowCellValue(grvDanhSach.FocusedRowHandle, "ID_sv")
        Ten_cc = grvDanhSach.GetRowCellValue(grvDanhSach.FocusedRowHandle, "Ten_cc")
        If id_sv > 0 And Ten_cc <> "" Then
            Dim re As New DialogResult
            re = Thongbao("Bạn chắc chắn muốn xóa bản ghi này không", MsgBoxStyle.YesNo, "Thông báo")
            If re = DialogResult.Yes Then
                Dim objInChungChi As New InChungChi_BLL
                objInChungChi.Delete_InChungChi(id_sv, Ten_cc)
                Thongbao("Xóa thông tin thành công")
                Load_Data()
            End If
        End If
    End Sub
End Class