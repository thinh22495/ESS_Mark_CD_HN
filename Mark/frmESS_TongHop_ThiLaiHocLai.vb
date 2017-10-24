Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_TongHop_ThiLaiHocLai
    Private mcls As TongHopThiLaiHocLai_BLL
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_BLL
    Private mNien_khoa As String = ""
    Private mID_dt As Integer = 0

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)

        Dim clsDM As New DanhMuc_BLL
        Dim dt As DataTable = clsDM.DanhMuc_Load("SELECT ID_he,Ten_he FROM STU_He")
        FillCombo(cmbID_he, dt)

        SetUpDataGridView(grdDanhSachChuaChon)
        SetUpDataGridView(grdDanhSachDaChon)
        FormatGridviewLopTinChi(grdDanhSachChuaChon)
        FormatGridviewLopTinChi(grdDanhSachDaChon)

        Loader = True
        mcls = New TongHopThiLaiHocLai_BLL
        grdDanhSachChuaChon.DataSource = mcls.ThiLaiHocLai_TheoMon_Load_List(0, 0, 0, 0, 0, 0, 0, "")
        grdDanhSachDaChon.DataSource = mcls.ThiLaiHocLai_TheoMon_Load_List(0, 0, 0, 0, 0, 0, 0, "")
    End Sub

    Private Sub frmESS_TongHop_ThiLaiHocLai_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub FormatGridviewLopTinChi(ByVal grdView As DataGridView)
        Dim col1 As New DataGridViewCheckBoxColumn
        With col1
            .Name = "Chon"
            .DataPropertyName = "Chon"
            .HeaderText = "Chọn"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.NullValue = ""
            .ReadOnly = False
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Mã sv"
            .DataPropertyName = "Ma_sv"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        'End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Họ tên"
            .DataPropertyName = "Ho_ten"
            .Visible = True
            .ReadOnly = True
            .Width = 240
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Tên lớp"
            .DataPropertyName = "Ten_lop"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .HeaderText = "Điểm cao nhất"
            .DataPropertyName = "TBCHT"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
        End With
    End Sub

    Private Sub cmbID_mon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged
        If Loader = False Then Exit Sub
        If cmbID_mon.Text = "" Then Exit Sub
        Dim mID_he As Integer = 0
        Dim mID_khoa As Integer = 0
        Dim mKhoa_hoc As Integer = 0
        Dim mID_chuyen_nganh As Integer = 0
        Dim mID_mon As Integer = 0
        Dim mHoc_ky As Integer = 0
        Dim mNam_hoc As String = ""
        If cmbID_he.Text <> "" Then mID_he = cmbID_he.SelectedValue
        If cmbKhoa_hoc.Text <> "" Then mKhoa_hoc = cmbKhoa_hoc.SelectedValue
        If cmbID_chuyen_nganh.Text <> "" Then mID_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue
        If cmbID_mon.Text <> "" Then mID_mon = cmbID_mon.SelectedValue
        If cmbHoc_ky.Text <> "" Then mHoc_ky = cmbHoc_ky.Text
        If cmbNam_hoc.Text <> "" Then mNam_hoc = cmbNam_hoc.Text

        grdDanhSachChuaChon.DataSource = mcls.ThiLaiHocLai_TheoMon_Load_List(mID_he, mID_khoa, mKhoa_hoc, mID_chuyen_nganh, 0, mID_mon, mHoc_ky, mNam_hoc)
        grdDanhSachDaChon.DataSource = mcls.ThiLaiHocLai_TheoMon_Load_List(mID_he, mID_khoa, mKhoa_hoc, mID_chuyen_nganh, 0, mID_mon, mHoc_ky, mNam_hoc)
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbID_he.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_BLL
            Dim dt As DataTable = clsDM.DanhMuc_Load("SELECT DISTINCT Khoa_hoc ,Khoa_hoc AS KH FROM STU_Lop WHERE ID_he=" & cmbID_he.SelectedValue)
            FillCombo(cmbKhoa_hoc, dt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbID_he.Text = "" Or cmbKhoa_hoc.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_BLL
            Dim dt As DataTable = clsDM.DanhMuc_Load("SELECT DISTINCT a.ID_chuyen_nganh,Chuyen_nganh FROM STU_Lop a INNER JOIN svChuyenNganh b ON a.ID_chuyen_nganh=b.ID_chuyen_nganh WHERE ID_he=" & cmbID_he.SelectedValue & " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
            FillCombo(cmbID_chuyen_nganh, dt)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try
            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
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
    'Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
    '    Try
    '        If Loader Then
    '            Add_MonHoc()
    '        End If
    '    Catch ex As Exception
    '        Thongbao(ex.Message)
    '    End Try
    'End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbID_chuyen_nganh.Text = "" Or cmbID_he.Text = "" Or cmbKhoa_hoc.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_BLL
            Dim dt As DataTable = clsDM.DanhMuc_Load("SELECT DISTINCT ID_dt,Nien_khoa FROM STU_Lop WHERE ID_he=" & cmbID_he.SelectedValue & " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue & " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue)
            If dt.Rows.Count = 0 Then Exit Sub
            mID_dt = dt.Rows(0)("ID_DT")
            mNien_khoa = dt.Rows(0)("Nien_khoa").ToString
            If mID_dt > 0 Then
                clsCTDT = New ChuongTrinhDaoTao_BLL(mID_dt, 0)
                Add_MonHoc()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class