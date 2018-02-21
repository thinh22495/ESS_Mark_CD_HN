Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_DiemRenLuyen
#Region "Var"
    Private mID_lops As String = "0"
    Private x As Integer = 0
    Private loader As Boolean = False
    Private Diem_toi_da As Integer = 0
    Dim xlsFileName As String = ""
    Private dt As New DataTable
#End Region
#Region "Form Events"

    Private Sub TrvLop_ChuanHoa_TreeNodeSelected_() Handles TrvLop_ChuanHoa.TreeNodeSelected_
        If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
            mID_lops = TrvLop_ChuanHoa.ID_lop_list
            Dim dvDiemRL As DataView = Load_DiemRL()
            dvDiemRL.AllowDelete = False
            dvDiemRL.AllowEdit = True
            dvDiemRL.AllowNew = False
            grdDanhSachSinhVien.DataSource = dvDiemRL
            KhoaDuLieu()
        End If
    End Sub
    'Private Sub trvLop_Select()
    '    If Not TrvLop_ChuanHoa.ID_lop_list Is Nothing Then
    '        mID_lops = TrvLop_ChuanHoa.ID_lop_list
    '        Dim dvDiemRL As DataView = Load_DiemRL()
    '        dvDiemRL.AllowDelete = False
    '        dvDiemRL.AllowEdit = True
    '        dvDiemRL.AllowNew = False
    '        grdDanhSachSinhVien.DataSource = dvDiemRL
    '        KhoaDuLieu()
    '    End If
    'End Sub
    'Private Sub frmESS_DiemRenLuyen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
    '    e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    'End Sub
#End Region
#Region "Control Events"

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As New DataView
            dv = Me.grdDanhSachSinhVien.DataSource
            If dv Is Nothing Then
                Thongbao(" Không có dữ liệu để lưu ! ", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Not CheckInputData() Then Exit Sub
            Dim obj As New DiemRenLuyen_New_BLL
            grdDanhSachSinhVien.EndEdit()
            For i As Integer = 0 To dv.Count - 1
                '' Kiểm tra xem dòng nào bị thay đồi thì mới update hoặc insert
                If dv.Item(i).Row.RowState = DataRowState.Modified Then

                    If dv.Item(i).Item("ID_diem_rl") = 0 And IsDBNull(dv.Item(i).Item("Diem")) Then
                        GoTo quit
                    End If
                    ' Delete svDiemRenLuyen nếu như điểm bị xóa đi
                    If dv.Item(i).Item("ID_diem_rl") <> 0 And IsDBNull(dv.Item(i).Item("Diem")) Then
                        obj.Delete_DiemRenLuyen_New(dv.Item(i).Item("ID_diem_rl"))
                    End If
                    ' Update svDiemRenLuyen
                    If dv.Item(i).Item("ID_diem_rl") <> 0 And Not IsDBNull(dv.Item(i).Item("Diem")) Then
                        Dim objDiemrl As New DiemRenLuyen_New
                        objDiemrl.Hoc_ky = CInt(cmbHoc_ky.Text)
                        objDiemrl.Nam_hoc = CStr(cmbNam_hoc.Text.Trim)
                        objDiemrl.ID_sv = dv.Item(i).Item("ID_sv")
                        objDiemrl.ID_loai_rl = CInt(cmbID_loai_rl.SelectedValue)
                        objDiemrl.Diem = dv.Item(i).Item("Diem")
                        objDiemrl.ID_diem_rl = dv.Item(i).Item("ID_diem_rl")
                        If obj.CheckExist_svDiemRenLuyen_New(objDiemrl) Then
                            obj.Update_DiemRenLuyen_New(objDiemrl)
                        Else
                            obj.Insert_DiemRenLuyen(objDiemrl)
                        End If
                    End If
                    ' Insert svDiemRenLuyen
                    If dv.Item(i).Item("ID_diem_rl") = 0 Then
                        Dim objDiemrl As New DiemRenLuyen_New
                        objDiemrl.Hoc_ky = CInt(cmbHoc_ky.Text)
                        objDiemrl.Nam_hoc = CStr(cmbNam_hoc.Text.Trim)
                        objDiemrl.ID_sv = dv.Item(i).Item("ID_sv")
                        objDiemrl.ID_loai_rl = CInt(cmbID_loai_rl.SelectedValue)
                        objDiemrl.Diem = dv.Item(i).Item("Diem")
                        obj.Insert_DiemRenLuyen(objDiemrl)
                    End If
                End If
Quit:
            Next
            Thongbao("Đã cập nhập điểm rèn luyện ", MsgBoxStyle.OkOnly)
            Load_DiemRenLuyen()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub KhoaDuLieu()
        Try
            For i As Integer = 0 To grdDanhSachSinhVien.Rows.Count - 1
                If grdDanhSachSinhVien.Rows(i).Cells("Locked").Value = True Then

                    'ReadOnly toàn bộ điểm rèn luyện
                    grdDanhSachSinhVien.Rows(i).Cells("Diem").ReadOnly = True

                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdDanhSachSinhVien.Rows(i).Cells("imgLock") = CellImage
                Else
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Edit
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdDanhSachSinhVien.Rows(i).Cells("imgLock") = CellImage
                End If
            Next
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        If loader = False Then Exit Sub
        grdDanhSachSinhVien.Enabled = False
        Dim dv As DataView = Load_DiemRL()
        grdDanhSachSinhVien.DataSource = dv
    End Sub

    Private Sub cmbID_cap_rl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_cap_rl.SelectedIndexChanged
        If loader = False Then Exit Sub
        x = 0
        grdDanhSachSinhVien.Enabled = False
        lblDiem.Text = ""
        Dim obj As New DanhMuc_BLL
        Dim dv1 As DataView = obj.DanhMuc_Load("STU_LoaiRenLuyen", "ID_loai_rl", "Ten_Loai", "ID_cap_rl", Me.cmbID_cap_rl.SelectedValue).DefaultView
        FillCombo(cmbID_loai_rl, dv1)
        x = 1
    End Sub

    Private Sub cmbID_loai_rl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_loai_rl.SelectedIndexChanged
        If loader = False Then Exit Sub
        Dim dv As DataView = Row_filter()
        grdDanhSachSinhVien.DataSource = dv
        KhoaDuLieu()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim dt As DataTable
        dt = grdDanhSachSinhVien.DataSource.Table
        If dt.Rows.Count = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim Tieu_de2 As String = ""
        Tieu_de2 = TrvLop_ChuanHoa.Tieu_de
        Dim frmESS_ As New frmESS_ReportView
        frmESS_.ShowDialog("RpNhapDiemRenLuyen", dt, , Tieu_de2, , )
        Me.Cursor = Cursors.Default
    End Sub

#End Region
#Region "User Functions"
    Private Function Load_DiemRL() As DataView
        Try
            Dim dv As New DataView
            Dim obj As New DiemRenLuyen_New_BLL(mID_lops)
            If cmbID_cap_rl.Text.Trim <> "" And cmbID_loai_rl.Text.Trim <> "" Then
                dv = Row_filter()
            Else
                dv = obj.Load_DiemRenLuyen_New().DefaultView
            End If
            Return dv
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub Load_DiemRenLuyen()
        Try
            Dim dv As DataView = Load_DiemRL()
            grdDanhSachSinhVien.DataSource = dv
            KhoaDuLieu()
        Catch ex As Exception
            Thongbao(ex.ToString)
        End Try

    End Sub
    Private Sub Fill_combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        Dim obj As New DanhMuc_BLL
        Dim dv As DataView = obj.DanhMuc_Load("STU_CapRenLuyen", "ID_cap_rl", "Ten_cap").DefaultView
        FillCombo(cmbID_cap_rl, dv)
        dv = obj.DanhMuc_Load("STU_LoaiRenLuyen", "ID_loai_rl", "Ten_Loai").DefaultView
        FillCombo(cmbID_loai_rl, dv)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra loai giay to
        If cmbHoc_ky.SelectedValue < 0 Then
            Call SetErrPro(cmbHoc_ky, ErrorProvider1, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedValue < 0 Then
            Call SetErrPro(cmbNam_hoc, ErrorProvider1, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbID_cap_rl.Text.Trim = "" Then
            Call SetErrPro(cmbID_cap_rl, ErrorProvider1, "Bạn hãy chọn nội dung đánh giá !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_cap_rl
        End If
        If cmbID_loai_rl.Text.Trim = "" Then
            Call SetErrPro(cmbID_loai_rl, ErrorProvider1, "Bạn hãy chọn tiêu chí đánh giá !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_loai_rl
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub grdDanhSachSinhVien_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDanhSachSinhVien.CellEndEdit
        Try
            If e.ColumnIndex = Me.grdDanhSachSinhVien.Columns("Diem").Index Then
                If Not IsDBNull(Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value) And Not IsNumeric(Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value) Then
                    Thongbao("Bạn phải nhập điểm rèn luyện là chữ số !", MsgBoxStyle.Information)
                    Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value = 0
                    Exit Sub
                End If
                If Not IsDBNull(Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value) Then
                    If CInt(Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value) > Diem_toi_da Then
                        Thongbao("Bạn phải nhập điểm rèn luyện nhỏ hơn " & CStr(Diem_toi_da) & " !", MsgBoxStyle.Information)
                        Me.grdDanhSachSinhVien.Rows(grdDanhSachSinhVien.CurrentRow.Index).Cells("Diem").Value = 0
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
    Private Function Row_filter() As DataView
        Try
            Dim obj As New DiemRenLuyen_New_BLL(mID_lops)
            Dim ID_loai_rl As Integer = -1, ID_cap_rl As Integer = -1
            If Me.cmbID_loai_rl.Text.Trim <> "" Then
                ID_loai_rl = cmbID_loai_rl.SelectedValue
            End If
            If Me.cmbID_cap_rl.Text.Trim <> "" Then
                ID_cap_rl = cmbID_cap_rl.SelectedValue
            End If
            Dim dv As DataView = obj.Load_DiemRenLuyen_New().DefaultView
            If x = 1 Then
                dv = obj.Load_DiemRenLuyen_New(dv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, ID_loai_rl, ID_cap_rl)
                Diem_toi_da = obj.Load_DiemLoaiRenLuyen(ID_loai_rl)
                lblDiem.Text = Diem_toi_da
                grdDanhSachSinhVien.Enabled = True
            End If
            Return dv
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
#End Region

    Private Sub cmdTH_diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cls As New DiemRenLuyenTinChi_BLL(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, 0)
            Dim dv As DataView
            dv = grdDanhSachSinhVien.DataSource
            grdDanhSachSinhVien.DataSource = cls.DanhSachTongHop_DiemRenLuyenTinChi(dv)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocked.Click
        Try
            Dim dv As New DataView
            dv = Me.grdDanhSachSinhVien.DataSource
            If dv Is Nothing Then
                Thongbao("Không có dữ liệu để khóa ! ", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim obj As New DiemRenLuyen_New_BLL
            grdDanhSachSinhVien.EndEdit()
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i).Item("ID_diem_rl") <> 0 And Not IsDBNull(dv.Item(i).Item("Diem")) Then
                    obj.KhoaMo_DiemRenLuyen_New(True, dv.Item(i).Item("ID_diem_rl"))
                End If
            Next
            Thongbao("Đã khóa điểm rèn luyện ", MsgBoxStyle.OkOnly)
            Load_DiemRenLuyen()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnLock.Click
        Try
            Dim dv As New DataView
            dv = Me.grdDanhSachSinhVien.DataSource
            If dv Is Nothing Then
                Thongbao("Không có dữ liệu để khóa ! ", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim obj As New DiemRenLuyen_New_BLL
            grdDanhSachSinhVien.EndEdit()
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i).Item("ID_diem_rl") <> 0 And Not IsDBNull(dv.Item(i).Item("Diem")) Then
                    obj.KhoaMo_DiemRenLuyen_New(False, dv.Item(i).Item("ID_diem_rl"))
                End If
            Next
            Thongbao("Mở khóa điểm rèn luyện ", MsgBoxStyle.OkOnly)
            Load_DiemRenLuyen()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            If grdDanhSachSinhVien.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim dt As DataTable
            dt = grdDanhSachSinhVien.DataSource
            ExportToExcel(dt.DefaultView)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub TreeViewLop_NEW1_TreeNodeSelected_()

    End Sub

    Private Sub frmESS_DiemRenLuyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_combo()
        Me.TrvLop_ChuanHoa.Load_TreeView()
        SetUpDataGridView(grdDanhSachSinhVien)
        grdDanhSachSinhVien.Enabled = False
        SetQuyenTruyCap(cmdSave, , , )
        SetQuyenTruyCap(cmdLocked, , , )
        SetQuyenTruyCap(cmdUnLock, , , )
        loader = True
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        With dlgOpenFile
            .InitialDirectory = Application.StartupPath
            .Filter = "Tệp Excel|*.xls"
            .FilterIndex = 1
        End With
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            xlsFileName = dlgOpenFile.FileName
            Dim xlsFile As String = xlsFileName.Trim.ToLower.Substring(xlsFileName.Trim.Length - 3, 3)
            If xlsFile = "xls" Then
                Try
                    cmbChonFile.Items.Clear()
                    Dim conADO As New ADODB.Connection
                    Dim myrs As New ADODB.Recordset
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
                    While Not myrs.EOF
                        If myrs.Fields("TABLE_NAME").Value.ToString.Length > 0 Then
                            If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) = "$" Then
                                cmbChonFile.Items.Add(myrs.Fields("TABLE_NAME").Value)
                            End If
                        End If
                        myrs.MoveNext()
                    End While
                    myrs.Close()
                    If cmbChonFile.Items.Count > 0 Then
                        cmbChonFile.SelectedIndex = 0
                    End If
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmbChonFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChonFile.SelectedIndexChanged
        If cmbChonFile.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            If xlsFileName.Trim <> "" Then
                Try
                    dt = New DataTable
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    da.Fill(dt)
                    Dim dt_tp, dt_tp_excel, dt_maSV As New DataTable
                    dt_tp_excel.Columns.Add("ID_TP_E", GetType(Integer))
                    dt_tp_excel.Columns.Add("Ten_TP_E", GetType(String))
                    If dt.Columns.Count > 0 Then
                        For j As Integer = 0 To dt.Columns.Count - 1
                            Dim dr As DataRow = dt_tp_excel.NewRow
                            dr("ID_TP_E") = j
                            dr("Ten_TP_E") = dt.Columns(j).ColumnName
                            dt_tp_excel.Rows.Add(dr)
                        Next
                    End If
                    FillCombo(cmbCot_diem, dt_tp_excel)
                    dt_maSV = dt_tp_excel.Copy
                    FillCombo(cmbMa_sv, dt_maSV)

                    dt_tp.Columns.Add("ID_TP", GetType(Integer))
                    dt_tp.Columns.Add("Ten_TP", GetType(String))

                    Dim dr1 As DataRow = dt_tp.NewRow
                    dr1("ID_tp") = 1
                    dr1("Ten_TP") = "Điểm RL"
                    dt_tp.Rows.Add(dr1)
                    FillCombo(cmbThanh_phan, dt_tp)
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdDongBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongBo.Click
        Dim dv As DataView = grdDanhSachSinhVien.DataSource
        For i As Integer = 0 To dv.Count - 1
            Dim dk As String = cmbMa_sv.Text & "=" & "'" & dv.Item(i)("Ma_sv").ToString & "'"
            dt.DefaultView.RowFilter = dk
            If dt.DefaultView.Count > 0 Then
                dv.Item(i)("Diem") = dt.DefaultView.Item(0)(cmbCot_diem.Text)
            End If
        Next
    End Sub
End Class