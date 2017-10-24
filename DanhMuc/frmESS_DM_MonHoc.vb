Imports System.Windows.Forms
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmESS_DM_MonHoc
    Private mEdit As Boolean = False
    Private mID_mon As Integer = 0
    Private Loader As Boolean = False
    Private mIdx As Integer = 0
    Private clsMonHoc As New DanhMucMon_BLL
    Private Ky_hieu_old As String = ""
    Private Ten_mon_old As String = ""
    'Private Id_bm As Integer = 0

    Public Sub New(ByVal _gobjUser As Users)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gobjUser = _gobjUser

    End Sub

    Private Sub frmESS_DM_MonHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Id_bm = gobjUser.ID_Bomon
        SetUpDataGridView(grdDMMonHoc)
        FormatDataGrid_CanBo(grdDMMonHoc)
        Call Load_DS()
        Enabled_Control(False)
        SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
        Fill_Combo()
    End Sub
    Private Sub Load_DS()
        Try
            Dim clsDanhMucMon As New DanhMucMon_BLL
            Dim dv As DataView = clsDanhMucMon.MonHoc_Load_List.DefaultView
            grdDMMonHoc.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Get_ID_mon()
        Dim dv As New DataView
        dv = grdDMMonHoc.DataSource
        If dv.Count = 0 Then Exit Sub
        mID_mon = dv.Item(mIdx)("Id_mon")
    End Sub
    Public Sub Fill_Combo()
        Try
            Dim dtHe As DataTable = UDB.SelectTable("Select ID_he,Ten_he FROM Stu_he Order By Ten_he Asc")
            Dim dtBoMon As DataTable = UDB.SelectTable("Select ID_bm, Bo_mon From PLAN_BoMon Order by Bo_mon asc")
            Dim dtLoc As DataTable = UDB.SelectTable("Select ID_bm, Bo_mon From PLAN_BoMon Order by Bo_mon asc")
            FillCombo(cboHe_dao_tao, dtHe)
            FillCombo(cboBo_mon, dtBoMon)
            FillCombo(cmbLoc, dtLoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub FormatDataGrid_CanBo(ByVal grdView As DataGridView)

        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .HeaderText = "Hệ đào tạo"
            .DataPropertyName = "Ten_he"
            .Visible = True
            .ReadOnly = True
            .Width = 170
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Bộ môn"
            .DataPropertyName = "Bo_mon"
            .Visible = True
            .ReadOnly = True
            .Width = 160
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Mã môn học"
            .DataPropertyName = "Ky_hieu"
            .Visible = True
            .ReadOnly = True
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Tên môn học"
            .DataPropertyName = "Ten_mon"
            .Visible = True
            .ReadOnly = True
            .Width = 450
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .HeaderText = "Tên tiếng anh"
            .DataPropertyName = "Ten_tieng_anh"
            .Visible = True
            .ReadOnly = True
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        grdView.Columns.Clear()
        With grdView.Columns
            .Add(col3)
            .Add(col4)
            .Add(col5)
            .Add(col1)
            .Add(col2)
        End With
    End Sub
    Private Sub Clear_Control()
        txtMa_mon.Text = ""
        txtTen_mon.Text = ""
        txtTen_tieng_anh.Text = ""
        cboHe_dao_tao.SelectedIndex = -1
        cboBo_mon.SelectedIndex = -1
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtMa_mon.Enabled = f
        txtTen_tieng_anh.Enabled = f
        txtTen_mon.Enabled = f
        cboHe_dao_tao.Enabled = f
        cboBo_mon.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Enabled = f
        cmdEdit.Enabled = f
        cmdDelete.Enabled = f
        cmdCancel.Enabled = Not f
        cmdSave.Enabled = Not f
        grdDMMonHoc.Enabled = f
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Clear_Control()
            Visible_Button(False)
            Enabled_Control(True)
            mEdit = False
            cmbLoc.Enabled = False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Enabled_Control(True)
            Visible_Button(False)
            mEdit = True
            cmbLoc.Enabled = False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Visible_Button(True)
            Enabled_Control(False)
            Fill_Data()
            cmbLoc.SelectedValue = -1
            cmbLoc.Enabled = True
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
        If cboHe_dao_tao.Text.Trim = "" Then
            Call SetErrPro(cboHe_dao_tao, ErrorProvider1, "Bạn hãy nhập Tên hệ !")
            If CtrlErr Is Nothing Then CtrlErr = cboHe_dao_tao
        End If
        If cboBo_mon.Text.Trim = "" Then
            Call SetErrPro(cboBo_mon, ErrorProvider1, "Bạn hãy nhập Tên bộ môn !")
            If CtrlErr Is Nothing Then CtrlErr = cboBo_mon
        End If
        If txtMa_mon.Text.Trim = "" Then
            Call SetErrPro(txtMa_mon, ErrorProvider1, "Bạn hãy nhập Mã môn học !")
            If CtrlErr Is Nothing Then CtrlErr = txtMa_mon
        End If

        If txtTen_mon.Text.Trim = "" Then
            Call SetErrPro(txtTen_mon, ErrorProvider1, "Bạn hãy nhập Tên môn học !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_mon
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
            dv = grdDMMonHoc.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdDMMonHoc.CurrentRow.Index
            cboHe_dao_tao.SelectedValue = dv.Table.Rows(mIdx).Item("ID_he")
            cboBo_mon.SelectedValue = dv.Table.Rows(mIdx).Item("Id_bm")
            txtMa_mon.Text = dv.Item(mIdx)("Ky_hieu")
            txtTen_mon.Text = dv.Item(mIdx)("Ten_mon")
            txtTen_tieng_anh.Text = dv.Item(mIdx)("Ten_tieng_anh")
            mID_mon = dv.Item(mIdx)("ID_mon")
            Dim Ky_hieu_old As String = dv.Table.Rows(grdDMMonHoc.CurrentRow.Index).Item("Ky_hieu").ToString
            Dim Ten_mon_old As String = dv.Table.Rows(grdDMMonHoc.CurrentRow.Index).Item("Ten_mon").ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub grdDMMonHoc_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDMMonHoc.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Function Check_trung_mon() As Boolean
        Check_trung_mon = clsMonHoc.Check_Exist_MonHoc(txtMa_mon.Text, txtTen_mon.Text)
        If Check_trung_mon = True Then
            Thongbao("Môn học này đã có rồi", MsgBoxStyle.Information, "Thông Báo")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim clsDanhMucMon As New DanhMucMon_BLL
            Dim obj As New DanhMucMon
            Call Get_ID_mon()
            obj.ID_mon = mID_mon
            'obj.Id_bm = Id_bm
            obj.ID_he_dt = cboHe_dao_tao.SelectedValue
            obj.Id_bm = cboBo_mon.SelectedValue
            obj.Ky_hieu = txtMa_mon.Text
            obj.Ten_mon = txtTen_mon.Text
            obj.Ten_tieng_anh = txtTen_tieng_anh.Text
            If mEdit Then ' Nếu update
                If Ky_hieu_old <> txtMa_mon.Text And Ten_mon_old <> txtTen_mon.Text Then
                    If Check_trung_mon() = False Then Exit Sub
                    clsDanhMucMon.Update_DMMon(obj, mID_mon)
                    Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                Else
                    clsDanhMucMon.Update_DMMon(obj, mID_mon)
                    Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                End If
            Else ' Nếu thêm mới
                If Check_trung_mon() = False Then Exit Sub
                clsDanhMucMon.Insert_DMMon(obj)
                Thongbao("Đã thêm mới thành công !", MsgBoxStyle.OkOnly)
            End If
                Call Load_DS()
                Visible_Button(True)
                Enabled_Control(False)
            Fill_Data()
            cmbLoc.Enabled = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If grdDMMonHoc.CurrentRow.Index >= 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá Môn học này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim objDanhMucMon As New DanhMucMon_BLL
                    Call Get_ID_mon()
                    objDanhMucMon.DMMon_DEL(mID_mon)
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

    Private Sub cmbLoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoc.SelectedIndexChanged
        Try
            Dim clsDanhMucMon As New DanhMucMon_BLL
            Dim dv As DataView = clsDanhMucMon.MonHoc_Load_List.DefaultView
            dv.RowFilter = "Id_bm = " & cmbLoc.SelectedValue
            grdDMMonHoc.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub
End Class