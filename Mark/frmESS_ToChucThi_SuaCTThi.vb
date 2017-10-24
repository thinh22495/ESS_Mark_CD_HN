Imports System.Windows.Forms
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Public Class frmESS_ToChucThi_SuaCTThi
    Public mID_Phong_thi As Integer
    Private Sub frmESS_ToChucThi_SuaCTThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Combo()
    End Sub
    Public Overloads Sub ShowDialog(ByVal ID_Phong_Thi As Integer)
        mID_Phong_thi = ID_Phong_Thi
        Me.ShowDialog()
    End Sub
    Public Sub Load_Combo()
        Try
            Dim dtCoSo As DataTable = UDB.SelectTable("Select Id_co_so,Ten_co_so FROM Plan_CoSoDaotao Order By Ten_Co_so Asc")
            Dim dtTang As DataTable = UDB.SelectTable("Select Id_tang,Ten_tang FROM Plan_Tang Order By Ten_tang Asc")
            FillCombo(cmbCo_so, dtCoSo)
            FillCombo(cmbTang, dtTang)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbCo_so_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCo_so.SelectedIndexChanged
        Try
            Dim mId_Coso As Integer = cmbCo_so.SelectedValue
            Dim dtToaNha As DataTable = UDB.SelectTable("SELECT ID_nha, Ten_nha From PLAN_TOANHA where ID_co_so =" & mId_Coso)
            FillCombo(cmbToa_nha, dtToaNha)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbToa_nha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbToa_nha.SelectedIndexChanged, cmbTang.SelectedIndexChanged
        Try
            Dim mId_ToaNha As Integer = cmbToa_nha.SelectedValue
            Dim mId_Tang As Integer = cmbTang.SelectedValue
            Dim dtPhong As DataTable = UDB.SelectTable("SELECT ID_phong, So_phong From PLAN_PhongHoc where ID_nha =" & mId_ToaNha & "AND ID_tang = " & mId_Tang)
            FillCombo(cbmPhong, dtPhong)
        Catch ex As Exception
        End Try
    End Sub

    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If dtpNgay_thi.Checked = False Then
            Call SetErrPro(dtpNgay_thi, ErrorProvider1, "Bạn hãy nhập Ngày thi !")
            If CtrlErr Is Nothing Then CtrlErr = dtpNgay_thi
        End If
        If cmbDot_thi.Text.Trim = "" Then
            Call SetErrPro(cmbDot_thi, ErrorProvider1, "Bạn hãy chọn Đợt thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbDot_thi
        End If
        If cmbCa_thi.Text.Trim = "" Then
            Call SetErrPro(cmbCa_thi, ErrorProvider1, "Bạn hãy chọn Buổi thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbCa_thi
        End If
        If cmbNhom_tiet.Text.Trim = "" Then
            Call SetErrPro(cmbNhom_tiet, ErrorProvider1, "Bạn hãy chọn Ca thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNhom_tiet
        End If
        If cbmPhong.Text.Trim = "" Then
            Call SetErrPro(cbmPhong, ErrorProvider1, "Bạn hãy chọn Phòng thi !")
            If CtrlErr Is Nothing Then CtrlErr = cbmPhong
        End If
        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim clsTCTPhong As New ToChucThiPhong_BLL
            Dim obj As New ToChucThiPhong
            obj.ID_phong_thi = mID_Phong_thi
            obj.ID_phong = cbmPhong.SelectedValue
            obj.Ten_phong = cmbToa_nha.Text & " - " & cbmPhong.Text
            obj.Ngay_thi = dtpNgay_thi.Value
            obj.Dot_thi = cmbDot_thi.SelectedIndex
            obj.Ca_thi = cmbCa_thi.SelectedIndex
            obj.Dot_thi = cmbDot_thi.SelectedIndex
            obj.Nhom_tiet = cmbNhom_tiet.SelectedIndex
            obj.Thoi_gian = txtThoi_gian.Text
            clsTCTPhong.Update_ToChucThi_ChiTiet_Phong(obj, mID_Phong_thi)
            Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
            Me.Tag = 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class