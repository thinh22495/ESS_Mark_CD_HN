Imports System.Windows.Forms
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmESS_DMPhongHoc
    Private mEdit As Boolean = False
    Private mID_phong As Integer = 0
    Private Loader As Boolean = False
    Private mIdx As Integer = 0

    Private Sub frmESS_DMPhongHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdDMPhongHoc)
        FormatDataGrid_CanBo(grdDMPhongHoc)
        Call Load_DS()
        Enabled_Control(False)
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
        Fill_Combo()
    End Sub
    Private Sub Load_DS()
        Try
            Dim clsDanhMucPhong As New DanhMucPhong_BLL
            Dim dv As DataView = grdDMPhongHoc.DataSource
            grdDMPhongHoc.DataSource = clsDanhMucPhong.PhongHoc_Load_List.DefaultView
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Get_ID_Phong()
        Dim dv As New DataView
        dv = grdDMPhongHoc.DataSource
        If dv.Count = 0 Then Exit Sub
        mID_phong = dv.Item(mIdx)("ID_phong")
    End Sub
    Public Sub Fill_Combo()
        Try
            Dim dtCoSo As DataTable = UDB.SelectTable("Select Id_co_so,Ten_co_so FROM Plan_CoSoDaotao Order By Ten_Co_so Asc")
            Dim dtTang As DataTable = UDB.SelectTable("Select ID_Tang, Ten_tang From Plan_tang Order by Ten_tang asc")
            Dim dtLoaiPhong As DataTable = UDB.SelectTable("Select Id_loai_phong, Ten_loai_phong from PLAN_LOAIPHONG Order by Ten_loai_phong asc")
            FillCombo(cboCoSo, dtCoSo)
            FillCombo(cboTang, dtTang)
            FillCombo(CboLoaiPhong, dtLoaiPhong)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub FormatDataGrid_CanBo(ByVal grdView As DataGridView)

        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .HeaderText = "Tên cơ sở"
            .DataPropertyName = "Ten_co_so"
            .Visible = True
            .ReadOnly = True
            .Width = 170
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Tên nhà"
            .DataPropertyName = "Ten_nha"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Tên tầng"
            .DataPropertyName = "Ten_tang"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Số phòng"
            .DataPropertyName = "So_phong"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .HeaderText = "Sức chứa"
            .DataPropertyName = "Suc_chua"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col6 As New DataGridViewTextBoxColumn
        With col6
            .HeaderText = "Tên loại phòng"
            .DataPropertyName = "Ten_loai_phong"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col7 As New DataGridViewCheckBoxColumn
        With col7
            .HeaderText = "Âm thanh"
            .DataPropertyName = "Am_thanh"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col8 As New DataGridViewCheckBoxColumn
        With col8
            .HeaderText = "Tivi"
            .DataPropertyName = "Tivi"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col9 As New DataGridViewCheckBoxColumn
        With col9
            .HeaderText = "Máy tính"
            .DataPropertyName = "May_tinh"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col10 As New DataGridViewCheckBoxColumn
        With col10
            .HeaderText = "Máy chiếu"
            .DataPropertyName = "May_chieu"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
            .Add(col6)
            .Add(col7)
            .Add(col8)
            .Add(col9)
            .Add(col10)
        End With
    End Sub
    Private Sub Clear_Control()
        txtSoPhong.Text = ""
        txtSucChua.Text = ""
        cbAmThanh.Checked = False
        cbMayTinh.Checked = False
        cbMayChieu.Checked = False
        cbTiVi.Checked = False
        cboCoSo.SelectedIndex = -1
        CboLoaiPhong.SelectedIndex = -1
        cboTang.SelectedIndex = -1
        cboToaNha.SelectedIndex = -1
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtSoPhong.Enabled = f
        txtSucChua.Enabled = f
        cbAmThanh.Enabled = f
        cbMayChieu.Enabled = f
        cbTiVi.Enabled = f
        cbMayTinh.Enabled = f
        cboCoSo.Enabled = f
        CboLoaiPhong.Enabled = f
        cboTang.Enabled = f
        cboToaNha.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Enabled = f
        cmdEdit.Enabled = f
        cmdDelete.Enabled = f
        cmdCancel.Enabled = Not f
        cmdSave.Enabled = Not f
        grdDMPhongHoc.Enabled = f
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Clear_Control()
            Visible_Button(False)
            Enabled_Control(True)
            mEdit = False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Enabled_Control(True)
            Visible_Button(False)
            mEdit = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Visible_Button(True)
            Enabled_Control(False)
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If cboCoSo.Text.Trim = "" Then
            Call SetErrPro(cboCoSo, ErrorProvider1, "Bạn hãy nhập Cơ sở !")
            If CtrlErr Is Nothing Then CtrlErr = cboCoSo
        End If
        If CboLoaiPhong.Text.Trim = "" Then
            Call SetErrPro(CboLoaiPhong, ErrorProvider1, "Bạn hãy nhập Loại phòng !")
            If CtrlErr Is Nothing Then CtrlErr = CboLoaiPhong
        End If
        If cboTang.Text.Trim = "" Then
            Call SetErrPro(cboTang, ErrorProvider1, "Bạn hãy nhập Tầng !")
            If CtrlErr Is Nothing Then CtrlErr = cboTang
        End If
        If cboToaNha.Text.Trim = "" Then
            Call SetErrPro(cboToaNha, ErrorProvider1, "Bạn hãy nhập Tòa nhà !")
            If CtrlErr Is Nothing Then CtrlErr = cboToaNha
        End If
        If txtSoPhong.Text.Trim = "" Then
            Call SetErrPro(txtSoPhong, ErrorProvider1, "Bạn hãy nhập số phòng !")
            If CtrlErr Is Nothing Then CtrlErr = txtSoPhong
        End If

        If txtSoPhong.Text.Trim = "" Then
            Call SetErrPro(txtSoPhong, ErrorProvider1, "Bạn hãy nhập số phòng !")
            If CtrlErr Is Nothing Then CtrlErr = txtSoPhong
        End If
        If txtSucChua.Text.Trim = "" Then
            Call SetErrPro(txtSucChua, ErrorProvider1, "Bạn hãy nhập Sức chứa !")
            If CtrlErr Is Nothing Then CtrlErr = txtSucChua
        ElseIf Not IsNumeric(txtSucChua.Text.Trim) Then
            Call SetErrPro(txtSucChua, ErrorProvider1, "Bạn hãy nhập Sức chứa là kiểu số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSucChua
        ElseIf CInt(txtSucChua.Text.Trim) <= 0 Then
            Call SetErrPro(txtSucChua, ErrorProvider1, "Bạn hãy nhập Sức chứa > 0 !")
            If CtrlErr Is Nothing Then CtrlErr = txtSucChua
        End If
        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub Fill_Data()
        Try
            Dim dv As New DataView
            dv = grdDMPhongHoc.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdDMPhongHoc.CurrentRow.Index
            cboCoSo.SelectedValue = dv.Table.Rows(mIdx).Item("Id_co_so")
            CboLoaiPhong.SelectedValue = dv.Table.Rows(mIdx).Item("Id_loai_phong")
            cboTang.SelectedValue = dv.Table.Rows(mIdx).Item("ID_tang")
            cboToaNha.SelectedValue = dv.Table.Rows(mIdx).Item("Id_nha")
            txtSoPhong.Text = dv.Item(mIdx)("So_phong")
            txtSucChua.Text = dv.Item(mIdx)("Suc_chua")
            If dv.Item(mIdx)("Tivi") Then
                cbTiVi.Checked = True
            Else
                cbTiVi.Checked = False
            End If
            If dv.Item(mIdx)("May_tinh") Then
                cbMayTinh.Checked = True
            Else
                cbMayTinh.Checked = False
            End If
            If dv.Item(mIdx)("May_chieu") Then
                cbMayChieu.Checked = True
            Else
                cbMayChieu.Checked = False
            End If
            If dv.Item(mIdx)("Am_thanh") Then
                cbAmThanh.Checked = True
            Else
                cbAmThanh.Checked = False
            End If
            mID_phong = dv.Item(mIdx)("ID_phong")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub grdDMPhongHoc_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDMPhongHoc.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cboCoSo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCoSo.SelectedIndexChanged
        Try
            Dim mId_Coso As Integer = cboCoSo.SelectedValue
            Dim dtToaNha As DataTable = UDB.SelectTable("SELECT ID_nha, Ten_nha From PLAN_TOANHA where ID_co_so =" & mId_Coso)
            FillCombo(cboToaNha, dtToaNha)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim clsDanhMucPhong As New DanhMucPhong_BLL
            Dim obj As New DanhMucPhong
            Call Get_ID_Phong()
            obj.ID_phong = mID_phong
            obj.ID_co_so = cboCoSo.SelectedValue
            obj.ID_nha = cboToaNha.SelectedValue
            obj.ID_tang = cboTang.SelectedValue
            obj.So_phong = txtSoPhong.Text
            obj.Suc_chua = txtSucChua.Text
            obj.Am_thanh = cbAmThanh.Checked
            obj.May_chieu = cbMayChieu.Checked
            obj.May_tinh = cbMayTinh.Checked
            obj.Tivi = cbTiVi.Checked
            obj.ID_loai_phong = CboLoaiPhong.SelectedValue
            If mEdit Then ' Nếu update
                clsDanhMucPhong.Update_DMPhong(obj, mID_phong)
                Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
            Else ' Nếu thêm mới
                clsDanhMucPhong.Insert_DMPhong(obj)
                Thongbao("Đã thêm mới thành công !", MsgBoxStyle.OkOnly)
            End If
            Call Load_DS()
            Visible_Button(True)
            Enabled_Control(False)
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If grdDMPhongHoc.CurrentRow.Index >= 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá Phòng học này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim objDanhMucPhong As New DanhMucPhong_BLL
                    Call Get_ID_Phong()
                    objDanhMucPhong.DMPhong_DEL(mID_phong)
                    Call Load_DS()
                    Visible_Button(True)
                    Enabled_Control(False)
                    Fill_Data()
                    Thongbao("Xoá phòng học thành công !", MsgBoxStyle.Information)
                End If
            Else
                Thongbao("Mời bạn chọn phòng học để xóa !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboToaNha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboToaNha.SelectedIndexChanged

    End Sub
End Class