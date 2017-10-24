Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports System.Data.SqlClient

Public Class frmESS_DanhSachKhongDuDieuKienDuThiHocPhan
    Private mID_he As Integer = 0
    Private dsID_lop As String = "0"
    Private mNien_khoa As String = ""
    Private dsID_dt As String = "0"
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mdtDanhSachSinhVien As New DataTable
    Private mLan_thi As Integer = 1


#Region "Function"
    Private Function CompareData(ByVal dt As DataTable, ByVal dt1 As DataTable) As Boolean
        If dt Is Nothing Or dt1 Is Nothing Then Return False
        If dt.Rows.Count <> dt1.Rows.Count Then Return False
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_mon") <> dt1.Rows(i)("ID_mon") Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub Add_MonHoc()
        Try
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                'Nếu danh sách môn học không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TrvLop_ChuanHoa1.Load_TreeView()
            Loader = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TrvLop_ChuanHoa1_Select() Handles TrvLop_ChuanHoa1.TreeNodeSelected_
        Try
            If Loader Then
                If Not TrvLop_ChuanHoa1.ID_lop_list Is Nothing Then
                    mID_he = TrvLop_ChuanHoa1.ID_he
                    dsID_lop = TrvLop_ChuanHoa1.ID_lop_list
                    dsID_dt = TrvLop_ChuanHoa1.ID_dt_list
                    mNien_khoa = TrvLop_ChuanHoa1.Nien_khoa
                    'Load danh sách các môn trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        clsCTDT = New ChuongTrinhDaoTao_BLL(dsID_dt, gobjUser.ID_Bomon)
                        'Load môn học vào Combobox
                        Add_MonHoc()
                    End If
                    'Load danh sách sinh viên
                    Dim objDanhSach As New DanhSachSinhVien_BLL(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    'Load danh sách điểm
                    cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy

                dt.Columns.Add("Tieu_de1")
                dt.Columns.Add("Tieu_de2")
                dt.Columns.Add("Chuc_danh1")
                dt.Columns.Add("Chuc_danh2")
                dt.Columns.Add("Nguoi_ky1")
                dt.Columns.Add("Nguoi_ky2")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Chuc_danh1") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
                    dt.Rows(i).Item("Chuc_danh2") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
                    dt.Rows(i).Item("Nguoi_ky1") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    dt.Rows(i).Item("Nguoi_ky2") = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    dt.Rows(i).Item("Tieu_de1") = "Học kỳ: " & cmbHoc_ky.Text.Trim & " Năm học: " & cmbNam_hoc.Text.Trim
                    dt.Rows(i).Item("Tieu_de2") = TrvLop_ChuanHoa1.Tieu_de.ToUpper
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("DS KhongDu DKThi", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged
        Try
            'Load danh sách điểm của sinh viên
            Try
                If Loader Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim Lan_hoc As Integer = cmbLan_hoc.SelectedIndex + 1
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        clsDiem = New Diem_BLL(mID_he, ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, Lan_hoc)
                        grcDanhSach.DataSource = clsDiem.DanhSachKhongDuDieuKienDuThiHocPhan(Lan_hoc, ID_mon).DefaultView
                        grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN: " & grvDanhSach.RowCount
                    Else
                        grcDanhSach.DataSource = Nothing
                        grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN: 0"
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim dv As DataView = grvDanhSach.DataSource
        Dim clsDiem As New Diem_BLL
        For i As Integer = 0 To dv.Count - 1
            Dim ID_diem As Integer = clsDiem.getID_Diem("P1", cmbID_mon.SelectedValue, dv.Item(i)("ID_dt"), dv.Item(i)("ID_sv"))
            Dim obj As New Diem
            obj.ID_sv = dv.Item(i)("ID_sv")
            obj.ID_dt = dv.Item(i)("ID_dt")
            obj.ID_dv = "P1"
            obj.ID_mon = cmbID_mon.SelectedValue
            obj.Hoc_ky = cmbHoc_ky.Text
            obj.Nam_hoc = cmbNam_hoc.Text

            Dim objDiemThi As New DiemThi
            objDiemThi.Ghi_chu = "K"
            If dv.Item(i)("Ly_do") = "Điểm TBCBP =0" Then objDiemThi.Ghi_chu = ""
            objDiemThi.Diem_thi = 0
            objDiemThi.Lan_hoc = cmbLan_hoc.Text
            objDiemThi.Lan_thi = 1
            objDiemThi.TBCHP = 0
            If ID_diem <= 0 Then
                ID_diem = clsDiem.Insert_Diem(obj)
                clsDiem.Insert_DiemThi(ID_diem, objDiemThi)
            Else
                clsDiem.Update_Diem(obj, ID_diem)
                If clsDiem.CheckExist_svDiemThi(ID_diem, cmbLan_hoc.Text, 1) <= 0 Then clsDiem.Insert_DiemThi(ID_diem, objDiemThi)
            End If
        Next
        Thongbao("Cập nhật thành công !", MsgBoxStyle.Information)
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportToExcel
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSach, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDanhSachHocBuToanTruong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDanhSachHocBuToanTruong.Click
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@Hoc_ky", cmbHoc_ky.Text)
            param(1) = New SqlParameter("@Nam_hoc", cmbNam_hoc.Text)
            Dim dt As DataTable = ESS.Machine.UDB.SelectTableSP("MARK_HOCBU_Tong_hop", param)
            dtExcel.DataSource = dt
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDataGridViewToExcel(dtExcel)
        Catch ex As Exception

        End Try
    End Sub
End Class