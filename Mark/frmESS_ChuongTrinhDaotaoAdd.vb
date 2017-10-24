Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity

Public Class frmESS_ChuongTrinhDaotaoAdd
    Private mID_dt_new As Integer
    Private mclsCTDT As ChuongTrinhDaoTao_BLL
    Private clsLop As New Lop_BLL(gobjUser.dsID_lop, -1, -1, 1)
    Private loaded As Boolean = False
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_BLL)
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)

            'Load combobox khoa đào tạo
            dt = clsLop.Khoa()
            FillCombo(cmbID_khoa, dt)

            'Load combobox khoa đào tạo
            dt = clsLop.Khoa_hoc()
            FillCombo(cmbKhoa_hoc, dt)

            'Load combobox chuyên ngành đào tạo
            dt = clsLop.Chuyen_nganh_dao_tao()
            FillCombo(cmbID_chuyen_nganh, dt)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Function CheckValidate() As Boolean
        If cmbID_he.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn hệ đào tạo")
            cmbID_he.Focus()
            Return False
        End If
        If cmbID_khoa.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoa đào tạo")
            cmbID_khoa.Focus()
            Return False
        End If
        If cmbKhoa_hoc.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoá đào tạo")
            cmbKhoa_hoc.Focus()
            Return False
        End If
        If cmbID_chuyen_nganh.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn chuyên ngành đào tạo")
            cmbID_chuyen_nganh.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub frmESS_ChuongTrinhDaotaoSaoChep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox
        LoadComboBox()
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(cmdSave)
        loaded = True
    End Sub
    Private Sub frmESS_ChuongTrinhDaotaoAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Public ReadOnly Property ID_dt_new() As Integer
        Get
            Return mID_dt_new
        End Get
    End Property
    Public ReadOnly Property ID_he() As Integer
        Get
            Return cmbID_he.SelectedValue
        End Get
    End Property

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        'If loaded = False Then Exit Sub
        ''Load combobox khoa đào tạo
        'Dim dv As DataView = clsLop.Khoa().DefaultView
        'dv.RowFilter = "ID_he=" & cmbID_he.SelectedValue
        'FillCombo(cmbID_khoa, dv.Table)
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                dt = cls.LoadDanhMuc("Select distinct ID_khoa,Ten_khoa from  STU_Khoa")
                FillCombo(cmbID_khoa, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        'If loaded = False Then Exit Sub
        ''Load combobox khoa đào tạo
        'Dim dv As DataView = clsLop.Khoa_hoc().DefaultView
        'dv.RowFilter = "ID_he=" & cmbID_he.SelectedValue
        'FillCombo(cmbKhoa_hoc, dv.Table)
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct l.Khoa_hoc,l.Khoa_hoc from  STU_Lop l where " & dk)
                FillCombo(cmbKhoa_hoc, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If loaded Then
                Dim cls As New DanhMuc_BLL
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct cn.ID_chuyen_nganh,cn.Chuyen_nganh from  STU_Lop l inner join  STU_ChuyenNganh cn On l.ID_chuyen_nganh=cn.ID_chuyen_nganh where " & dk)
                FillCombo(cmbID_chuyen_nganh, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub mnuClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            If mclsCTDT.CheckExist_ChuongTrinhDaoTao(cmbID_he.SelectedValue, cmbID_khoa.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_chuyen_nganh.SelectedValue, cmbSo.Text) = 0 Then
                Dim objCTDT As New ChuongTrinhDaoTao
                objCTDT.ID_he = cmbID_he.SelectedValue
                objCTDT.ID_khoa = cmbID_khoa.SelectedValue
                objCTDT.Khoa_hoc = cmbKhoa_hoc.SelectedValue
                objCTDT.ID_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue

                objCTDT.Ten_he = cmbID_he.Text
                objCTDT.Ten_khoa = cmbID_khoa.Text
                objCTDT.Chuyen_nganh = cmbID_chuyen_nganh.Text
                objCTDT.So = cmbSo.Text
                'Insert vao Database
                mID_dt_new = mclsCTDT.Insert_ChuongTrinhDaoTao(objCTDT)
                'Insert vao object
                objCTDT.ID_dt = ID_dt_new
                mclsCTDT.Add(objCTDT)
                Me.Tag = "1"
                Me.Close()
            Else
                Thongbao("Chương trình đào tạo này đã tồn tại, bạn không thể tạo được")
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = "0"
        Me.Close()
    End Sub

End Class