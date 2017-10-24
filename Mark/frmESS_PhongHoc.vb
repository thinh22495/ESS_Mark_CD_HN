Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_PhongHoc
    Private mThoat As Boolean
    Dim LoaderCombobox As Boolean = False
    Property Thoat() As Boolean
        Get
            Return mThoat
        End Get
        Set(ByVal value As Boolean)
            mThoat = value
        End Set
    End Property

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If ValidForm() Then
            Thoat = False
            Me.Close()
        End If
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Thoat = True
        Me.Close()
    End Sub

    Private Sub frmESS_PhongHoc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCombox()
    End Sub
    Private Sub frmESS_PhongHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Public Function getValueFromUI() As PhongHoc
        Dim objPhongHoc As PhongHoc = New PhongHoc
        Try
            objPhongHoc.ID_nha = CType(cmbID_nha.SelectedValue, Integer)
            objPhongHoc.ID_tang = CType(cmbID_tang.SelectedValue, Integer)
            objPhongHoc.So_phong = CType(txtSo_phong.Text, String)
            objPhongHoc.Suc_chua = CType(txtSuc_chua.Text, Integer)
            objPhongHoc.So_sv = CType(txtSo_sv.Text, Integer)
            objPhongHoc.ID_loai_phong = CType(cmbID_loai_phong.SelectedValue, Integer)
            objPhongHoc.Thiet_bi = CType(txtThiet_bi.Text, String)
            objPhongHoc.ID_co_so = CType(cmbID_co_so.SelectedValue, Integer)
            objPhongHoc.Ten_co_so = CType(cmbID_co_so.Text, String)
            objPhongHoc.Khong_ToChucThi = 1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Return objPhongHoc
    End Function
    Public Sub setValueToUI(ByVal objPhongHoc As PhongHoc)
        Try
            LoadCombox()
            '
            cmbID_nha.SelectedValue = objPhongHoc.ID_nha
            cmbID_tang.SelectedValue = objPhongHoc.ID_tang
            txtSo_phong.Text = objPhongHoc.So_phong
            txtSuc_chua.Text = objPhongHoc.Suc_chua
            txtSo_sv.Text = objPhongHoc.So_sv
            cmbID_loai_phong.SelectedValue = objPhongHoc.ID_loai_phong
            txtThiet_bi.Text = objPhongHoc.Thiet_bi
            cmbID_co_so.SelectedValue = objPhongHoc.ID_co_so
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Sub LoadCombox()
        If LoaderCombobox = True Then Exit Sub
        Dim objToaNha As New ToaNha_BLL
        FillCombo(cmbID_nha, objToaNha.DanhMucToaNha)
        Dim objTang As New Tang_BLL
        FillCombo(cmbID_tang, objTang.DanhMucTang)
        Dim objLoaiPhong As New LoaiPhong_BLL
        FillCombo(cmbID_loai_phong, objLoaiPhong.DanhMucLoaiPhong)
        Dim clsDM As New ESS.Catalogue.clsDanh_muc
        Dim dt As New DataTable
        dt = clsDM.CatalogueLoad("PLAN_CoSoDaoTao")
        FillCombo(cmbID_co_so, dt, "ID_co_so", "Ten_co_so")

        LoaderCombobox = True
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If cmbID_tang.SelectedValue = 0 Then
            Me.ErrorProvider1.SetError(cmbID_tang, "Bạn phải nhập tầng !")
            cmbID_tang.Focus()
            ValidForm = False
        ElseIf cmbID_nha.SelectedValue = 0 Then
            Me.ErrorProvider1.SetError(cmbID_nha, "Phải nhập toà nhà !")
            cmbID_nha.Focus()
            ValidForm = False
        ElseIf Trim(txtSo_phong.Text) = "" Then
            Me.ErrorProvider1.SetError(txtSo_phong, "Phải nhập số phòng !")
            txtSo_phong.Focus()
            ValidForm = False
        ElseIf cmbID_loai_phong.SelectedValue = 0 Then
            Me.ErrorProvider1.SetError(cmbID_loai_phong, "Phải nhập loại phòng !")
            cmbID_loai_phong.Focus()
            ValidForm = False
        ElseIf cmbID_co_so.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(cmbID_co_so, "Phải nhập cơ sở đào tạo !")
            cmbID_co_so.Focus()
            ValidForm = False
        Else
            If txtSo_sv.Text <> "" Then
                If Not IsNumeric(txtSo_sv.Text) Then
                    Me.ErrorProvider1.SetError(txtSo_sv, "Số sinh viên phải là số !")
                    txtSo_sv.Focus()
                    ValidForm = False
                    Exit Function
                ElseIf Val(CType(txtSo_sv.Text, Long)) < 0 Then
                    Me.ErrorProvider1.SetError(txtSo_sv, "Số sinh viên không được âm!")
                    txtSo_sv.Focus()
                    ValidForm = False
                    Exit Function
                End If
                If txtSuc_chua.Text <> "" Then
                    If Not IsNumeric(txtSuc_chua.Text) Then
                        Me.ErrorProvider1.SetError(txtSuc_chua, "Sức chứa phải là số!")
                        txtSuc_chua.Focus()
                        ValidForm = False
                        Exit Function
                    ElseIf Val(CType(txtSuc_chua.Text, Long)) < 0 Then
                        Me.ErrorProvider1.SetError(txtSuc_chua, "Sức chứa không được âm!")
                        txtSuc_chua.Focus()
                        ValidForm = False
                        Exit Function
                    End If
                End If
                If Val(CType(txtSo_sv.Text, Long)) > Val(CType(txtSuc_chua.Text, Long)) Then
                    Thongbao("Số sinh viên phải nhỏ hơn hoặc bằng số chứa của phòng!")
                    txtSo_sv.Focus()
                    ValidForm = False
                    Exit Function
                End If
            End If
        End If
    End Function


End Class