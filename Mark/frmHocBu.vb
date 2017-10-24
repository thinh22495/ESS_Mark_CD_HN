Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraEditors
Public Class frmHocBu
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As New ChuongTrinhDaoTao_BLL
    Private mID_lops As String = ""
    Private mID_Mon As Integer = 0
    Private mLan_hoc As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""

    Public Sub New(Optional ByVal idMonHoc As Integer = 0, Optional ByVal ID_LOPs As String = "", Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal Lan_hoc As Integer = 0)
        InitializeComponent()
        Me.mID_lops = ID_LOPs
        Me.mID_Mon = idMonHoc
        Me.mLan_hoc = Lan_hoc
        Me.mNam_hoc = Nam_hoc
        Me.mHoc_ky = Hoc_ky
        Me.lbTen_Mon.Text = UDB.ExecuteScalar("select Ten_mon from mark_monhoc where id_mon=" + idMonHoc.ToString).ToString
    End Sub
    Private Sub frmKiemTraBu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        SetUpDataGridView(grdViewDiem)
        Loader = True
        load_data()
    End Sub
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            cmbHoc_ky.SelectedValue = mHoc_ky
            Add_Namhoc(cmbNam_hoc)
            cmbNam_hoc.Text = mNam_hoc
            cmbLan_hoc.Text = Me.mLan_hoc.ToString
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Sub SetUpDataGridView(ByVal myDataGridView As DataGridView)
        With myDataGridView
            .AutoGenerateColumns = False
            '.AutoResizeColumns()
            ' Set DataGridView visual properties (Colors, Fonts, etc.)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen
            .RowHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen
            .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Brown
            .ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Regular)

            .EditMode = DataGridViewEditMode.EditOnEnter
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = System.Drawing.Color.DarkSeaGreen
            '.BackgroundColor = System.Drawing.Color.DarkSeaGreen
            '.ForeColor = System.Drawing.Color.DarkSeaGreen
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            .MultiSelect = False
        End With
        Dim style As New DataGridViewCellStyle
        style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dim style1 As New DataGridViewCellStyle
        style1.Alignment = DataGridViewContentAlignment.MiddleLeft
        myDataGridView.DefaultCellStyle = style
        grdViewDiem.Columns("Ho_ten").DefaultCellStyle = style1
        grdViewDiem.Columns("Ho_ten").ReadOnly = True
        grdViewDiem.Columns("Ma_sv").ReadOnly = True
        'grdViewDiem.Columns("Diem").ReadOnly = True
        grdViewDiem.Columns("Ten_lop").ReadOnly = True
    End Sub
    Public Sub load_data()
        If Loader Then
            Dim dt As New DataTable
            If cmbLan_hoc.Text.Length > 0 Then
                dt = clsDiem.Load_HocBu(Convert.ToInt32(cmbLan_hoc.Text), mID_lops, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_Mon)
                If Not dt.Columns.Contains("Hoc_bu") Then dt.Columns.Add("Hoc_bu", GetType(Boolean))
                For Each rdiem As DataRow In dt.Rows
                    Dim Tong_tiet As Integer = 0
                    Dim Tong_tiet_nghi As Integer = 0
                    If IsNumeric(rdiem("Tong_so_tiet_LT")) Then Tong_tiet += rdiem("Tong_so_tiet_LT")
                    If IsNumeric(rdiem("Tong_so_tiet_TH")) Then Tong_tiet += rdiem("Tong_so_tiet_TH")
                    If IsNumeric(rdiem("Nghi_lt")) Then Tong_tiet_nghi += rdiem("Nghi_lt")
                    If IsNumeric(rdiem("Nghi_th")) Then Tong_tiet_nghi += rdiem("Nghi_th")
                    rdiem("Hoc_bu") = False
                    If Tong_tiet > 0 Then
                        If (Tong_tiet_nghi / Tong_tiet) >= 0.2 And (Tong_tiet_nghi / Tong_tiet) < 0.3 Then
                            rdiem("Hoc_bu") = True
                        End If
                    End If
                Next
                Dim dv As DataView = dt.DefaultView
                Dim filter As String = "1=1 "
                If chkLoc.Checked Then
                    filter = "Hoc_bu='True'"
                    'filter = "(Nghi_lt>=(0.2*Tong_so_tiet_LT) and Nghi_lt<(0.3*Tong_so_tiet_LT)) or (Nghi_th>0 and Nghi_th<=(0.15*Tong_so_tiet_TH))"
                End If
                dv.RowFilter = filter
                grdViewDiem.DataSource = dv
            End If
        End If
    End Sub

    Private Sub cmbLan_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_hoc.SelectedIndexChanged
        load_data()
    End Sub
    Private Sub cbLanKT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        load_data()
    End Sub
    Public Function GridColumn(ByVal name As String, ByVal headerText As String, ByVal dataProperty As String, ByVal width As Integer, ByVal visible As Boolean) As DataGridViewTextBoxColumn
        Dim col1 As New DataGridViewTextBoxColumn()
        With col1
            .HeaderText = headerText
            .Name = name
            .DataPropertyName = dataProperty
            .Visible = visible
            .ReadOnly = False
            .Width = width
            .DefaultCellStyle = New DataGridViewCellStyle
        End With
        Return col1
    End Function

    Private Sub cmbNam_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNam_hoc.SelectedIndexChanged
        If Not cmbNam_hoc.Text Is Nothing Then
            load_data()
        End If

    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged
        If Not cmbHoc_ky.Text Is Nothing Then
            load_data()
        End If
    End Sub

    Private Sub chkLoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoc.CheckedChanged
        load_data()
    End Sub

    Private Sub grdViewDiem_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
        Try
            Dim lt As Integer = 0
            Dim th As Integer = 0
            Dim id_he As Integer = grdViewDiem.CurrentRow.Cells("ID_he").Value
            Dim gia_tien As String = UDB.ExecuteScalar("select Gia_tien from mark_giatienhocbu z where z.ID_he=" + id_he.ToString + " and z.Nam_hoc='" + cmbNam_hoc.Text + "' AND z.Loai='1'")
            If grdViewDiem.CurrentCell.Value.ToString.Length > 0 Then
                If grdViewDiem.CurrentCell.ColumnIndex = grdViewDiem.CurrentRow.Cells("So_tiet_dk_LT").ColumnIndex Then
                    If Not IsNumeric(grdViewDiem.CurrentCell.Value.ToString) Then
                        Thongbao("Bạn phải nhập điểm là số !")
                        grdViewDiem.CurrentCell.Value = DBNull.Value
                    Else
                        If grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentRow.Cells("Tong_so_tiet_LT").Value < Convert.ToSingle(grdViewDiem.CurrentCell.Value) Then
                            Thongbao("Bạn phải nhập là số từ 0 đến " + grdViewDiem.CurrentRow.Cells("Tong_so_tiet_LT").Value.ToString)
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        Else
                            lt = IIf(grdViewDiem.CurrentRow.Cells("So_tiet_dk_LT").Value Is Nothing, 0, Convert.ToInt32(grdViewDiem.CurrentRow.Cells("So_tiet_dk_LT").Value))
                        End If
                    End If
                End If
                'TH
                If grdViewDiem.CurrentCell.ColumnIndex = grdViewDiem.CurrentRow.Cells("So_tiet_dk_TH").ColumnIndex Then
                    If Not IsNumeric(grdViewDiem.CurrentCell.Value.ToString) Then
                        Thongbao("Bạn phải nhập là số !")
                        grdViewDiem.CurrentCell.Value = DBNull.Value
                    Else
                        If grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentRow.Cells("Tong_so_tiet_TH").Value < Convert.ToSingle(grdViewDiem.CurrentCell.Value) Then
                            Thongbao("Bạn phải nhập là số từ 0 đến " + grdViewDiem.CurrentRow.Cells("Tong_so_tiet_TH").Value.ToString)
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        Else
                            th = IIf(grdViewDiem.CurrentRow.Cells("So_tiet_dk_TH").Value Is Nothing, 0, Convert.ToInt32(grdViewDiem.CurrentRow.Cells("So_tiet_dk_TH").Value))
                        End If
                    End If
                End If
                grdViewDiem.CurrentRow.Cells("So_tien").Value = (lt + th) * gia_tien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            'For i As Integer = 0 To dv.Count - 1
            '    If grdViewDiem.Rows(i).Cells("So_tiet_dk_lt").Value.ToString.Length > 0 Then
            '        grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value = 0
            '    End If
            '    If grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value.ToString.Length > 0 Then
            '        grdViewDiem.Rows(i).Cells("So_tiet_dk_lt").Value = 0
            '    End If
            'Next
            grdViewDiem.EndEdit()
            If Not cmbLan_hoc.Text.Length > 0 Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                If grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value.ToString = "" Then grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value = 0
                If grdViewDiem.Rows(i).Cells("So_tiet_nghi_th").Value.ToString = "" Then grdViewDiem.Rows(i).Cells("So_tiet_nghi_th").Value = 0

                If grdViewDiem.Rows(i).Cells("So_tiet_dk_lt").Value.ToString.Length > 0 And grdViewDiem.Rows(i).Cells("Dang_ky").Value Then
                    Dim id_diem As Integer = grdViewDiem.Rows(i).Cells("ID_diem").Value
                    Dim so_tiet_hoc_lt As Integer = IIf(Not grdViewDiem.Rows(i).Cells("So_tiet_dk_lt").Value Is Nothing, Convert.ToInt32(grdViewDiem.Rows(i).Cells("So_tiet_dk_lt").Value), 0)
                    Dim so_tiet_hoc_th As Integer = IIf(Not grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value Is Nothing, Convert.ToInt32(grdViewDiem.Rows(i).Cells("So_tiet_dk_th").Value), 0)
                    Dim lan_hoc As Integer = Convert.ToInt32(cmbLan_hoc.Text)
                    clsDiem.Insert_HocBu(id_diem, so_tiet_hoc_lt, so_tiet_hoc_th, lan_hoc)

                    Dim so_tiet_nghi_lt_Str As String = IIf(grdViewDiem.Rows(i).Cells("So_tiet_nghi_LT").Value.ToString <> "", grdViewDiem.Rows(i).Cells("So_tiet_nghi_lt").Value, "0/0")
                    Dim so_tiet_nghi_lt_arr As String() = so_tiet_nghi_lt_Str.Split(New Char() {"/"c})
                    Dim so_tiet_nghi_lt As Integer = Convert.ToInt32(so_tiet_nghi_lt_arr(0))

                    Dim so_tiet_nghi_th_Str As String = IIf(grdViewDiem.Rows(i).Cells("So_tiet_nghi_th").Value.ToString <> "", grdViewDiem.Rows(i).Cells("So_tiet_nghi_th").Value, "0/0")
                    Dim so_tiet_nghi_th_arr As String() = so_tiet_nghi_th_Str.Split(New Char() {"/"c})
                    Dim so_tiet_nghi_th As Integer = Convert.ToInt32(so_tiet_nghi_th_arr(0))

                    Dim objDiemDanh As New DiemDanh
                    If so_tiet_hoc_lt >= so_tiet_nghi_lt And so_tiet_hoc_th >= so_tiet_nghi_th Then
                        objDiemDanh.So_tiet_nghi = 0
                        objDiemDanh.So_tiet_nghi_th = 0
                        objDiemDanh.Lan_hoc = lan_hoc
                        clsDiem.Update_DiemDanh_NEW(objDiemDanh, id_diem, lan_hoc)
                    Else
                        objDiemDanh.So_tiet_nghi = IIf((so_tiet_nghi_lt - so_tiet_hoc_lt) > 0, (so_tiet_nghi_lt - so_tiet_hoc_lt), 0)
                        objDiemDanh.So_tiet_nghi_th = IIf((so_tiet_nghi_th - so_tiet_hoc_th) > 0, so_tiet_nghi_th - so_tiet_hoc_th, 0)
                        objDiemDanh.Lan_hoc = lan_hoc
                        clsDiem.Update_DiemDanh_NEW(objDiemDanh, id_diem, lan_hoc)
                    End If
                    Dim noi_dung As String = "Thêm mới học bù, cập nhật lại số tiết nghỉ môn: " + lbTen_Mon.Text + ", Họ tên sv: " + grdViewDiem.Rows(i).Cells("Ho_ten").Value.ToString() + ", Học kỳ: " + cmbHoc_ky.SelectedValue.ToString + ", Năm học: " + cmbNam_hoc.Text
                    SaveLog(LoaiSuKien.Sua, noi_dung)
                End If
            Next
            load_data()
            Thongbao("Cập nhật thành công")
        Catch ex As Exception
            Thongbao("Có lỗi xảy ra. Có thể bạn đã để trống ô số tiết đăng ký LT hoặc TH")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frmKiemTraBu_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        For Each fParent As Form In Application.OpenForms
            If fParent.Name = "frmESS_NhapDiemThanhPhanLop" Then
                Dim f As frmESS_NhapDiemThanhPhanLop = fParent
                f.refreshDiemTP()
            End If
        Next
    End Sub
End Class