Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Machine
Imports DevExpress.XtraEditors
Public Class frmKiemTraBu
    Private Loader As Boolean = False
    Private clsDiem As New Diem_BLL
    Private clsCTDT As New ChuongTrinhDaoTao_BLL
    Private mID_lops As String = ""
    Private mID_Mon As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As Integer = 0
    Public Overloads Sub ShowDialog(ByVal idMonHoc As Integer, ByVal ID_LOPs As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As Integer)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        Me.mID_lops = ID_LOPs
        Me.mID_Mon = idMonHoc
        Me.lbTen_Mon.Text = UDB.ExecuteScalar("select Ten_mon from mark_monhoc where id_mon=" + idMonHoc.ToString).ToString
        Me.ShowDialog()
    End Sub
    'Public Sub New(Optional ByVal idMonHoc As Integer = 0, Optional ByVal ID_LOPs As String = "")
    '    InitializeComponent()
    '    Me.mID_lops = ID_LOPs
    '    Me.mID_Mon = idMonHoc
    '    Me.lbTen_Mon.Text = UDB.ExecuteScalar("select Ten_mon from mark_monhoc where id_mon=" + idMonHoc.ToString).ToString
    'End Sub
    Private Sub frmKiemTraBu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        cmbHoc_ky.SelectedValue = mHoc_ky
        cmbNam_hoc.SelectedValue = mNam_hoc
        SetUpDataGridView(grdViewDiem)
        Loader = True
        load_data()
        Call cmbLan_hoc_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            'Set default lần học là 1
            cmbLan_hoc.SelectedIndex = 0
            cbLanKT.SelectedIndex = 0
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
        grdViewDiem.Columns("Diem").ReadOnly = True
        grdViewDiem.Columns("Ten_lop").ReadOnly = True
    End Sub
    Public Sub load_data()
        grdViewDiem.AutoGenerateColumns = False
        If Loader Then
            Dim dt As New DataTable
            If cbLanKT.Text.Length > 0 Then
                dt = clsDiem.Load_Diem_thanhPhan_Single(Convert.ToInt32(cmbLan_hoc.Text), mID_lops, cbThanhPhan.SelectedValue, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_Mon)
            End If
            Dim dv As DataView = dt.DefaultView
            Dim filter As String = "1=1 "
            If chkLoc.Checked Then
                If cbLanKT.Text = "1" Then
                    filter = filter + " and Diem<5"
                End If
                If cbLanKT.Text = "2" Then
                    filter = filter + " and Diem<5 and DIem_KT_bu1<5"
                End If
                If cbLanKT.Text = "3" Then
                    filter = filter + " and Diem<=5 and DIem_KT_bu1<5 and  diem_kt_bu2<5 "
                End If
                If cbLanKT.Text = "4" Then
                    filter = filter + " and Diem<=5 and DIem_KT_bu1<5 and  diem_kt_bu2<5 and diem_kt_bu3<5 "
                End If
                If cbLanKT.Text = "5" Then
                    filter = filter + " and Diem<=5 and DIem_KT_bu1<5 and  diem_kt_bu2<5 and diem_kt_bu3<5 and diem_kt_bu4<5"
                End If
            End If
            dv.RowFilter = filter
            dv.Sort = "Ma_sv"
            grdViewDiem.DataSource = dv
        End If

    End Sub
    Private Sub load_ComboThanhPhan(ByVal Lan_hoc As Integer)
        If Not cmbLan_hoc.Text Is Nothing Then
            If mID_lops.Length > 0 Then
                Dim dt As DataTable = clsDiem.Load_ThanhPhan_HocBu(Lan_hoc, mID_lops, Convert.ToInt32(cmbHoc_ky.Text), cmbNam_hoc.Text, mID_Mon)
                If dt.DefaultView.Count > 0 Then
                    FillCombo(cbThanhPhan, dt, "ID_thanh_phan", "Ten_thanh_phan")
                    cbThanhPhan.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub cmbLan_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_hoc.SelectedIndexChanged
        load_ComboThanhPhan(cmbLan_hoc.Text)
        load_data()
    End Sub

    Private Sub cbThanhPhan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbThanhPhan.SelectedIndexChanged
        If Not cbThanhPhan.SelectedValue Is Nothing Then
            load_data()
        End If
    End Sub

    Private Sub cbLanKT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLanKT.SelectedIndexChanged
        If cbLanKT.Text.Length > 0 Then

            Dim Lan_kiem_tra As Integer = Convert.ToInt32(cbLanKT.Text)
            Select Case Lan_kiem_tra
                Case 1
                    grdViewDiem.Columns("Diem_KT_bu1").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu2").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu3").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu4").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu5").Visible = False
                    Exit Select
                Case 2
                    grdViewDiem.Columns("Diem_KT_bu1").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu2").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu3").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu4").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu5").Visible = False
                    Exit Select
                Case 3
                    grdViewDiem.Columns("Diem_KT_bu1").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu2").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu3").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu4").Visible = False
                    grdViewDiem.Columns("Diem_KT_bu5").Visible = False
                    Exit Select
                Case 4
                    grdViewDiem.Columns("Diem_KT_bu1").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu2").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu3").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu4").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu5").Visible = False
                    Exit Select
                Case 5
                    grdViewDiem.Columns("Diem_KT_bu1").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu2").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu3").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu4").Visible = True
                    grdViewDiem.Columns("Diem_KT_bu5").Visible = True
                    Exit Select

            End Select
            load_data()
        End If
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
            If grdViewDiem.CurrentCell.Value.ToString.Length > 0 Then
                If Not IsNumeric(grdViewDiem.CurrentCell.Value.ToString) Then
                    Thongbao("Bạn phải nhập điểm là số !")
                    grdViewDiem.CurrentCell.Value = DBNull.Value
                Else
                    If grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentCell.Value > 10 Then
                        Thongbao("Bạn phải nhập điểm là số từ 0 đến 10 !")
                        grdViewDiem.CurrentCell.Value = DBNull.Value
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            Dim Lan_kiem_tra As Integer = IIf(cbLanKT.Text.Length > 0, Convert.ToInt32(cbLanKT.Text), 0)
            If Not Lan_kiem_tra > 0 Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                If grdViewDiem.Rows(i).Cells("ID_diem_tp").Value.ToString.Length > 0 And grdViewDiem.Rows(i).Cells("Diem_KT_bu" + Lan_kiem_tra.ToString()).Value.ToString.Length > 0 Then
                    Dim id_diem_tp As Integer = grdViewDiem.Rows(i).Cells("ID_diem_tp").Value
                    Dim DIem_KT_ban_dau As String = grdViewDiem.Rows(i).Cells("Diem").Value
                    Dim Diem As Single = Convert.ToSingle(grdViewDiem.Rows(i).Cells("Diem_KT_bu" + Lan_kiem_tra.ToString).Value)
                    clsDiem.Save_DiemKiemTraBu(id_diem_tp, Diem, Lan_kiem_tra)
                    SaveLog(LoaiSuKien.Sua, "Sửa điểm thành phần do kiểm tra bù, ID_Diem_TP:" + id_diem_tp.ToString + ", Điểm lần 1: " + DIem_KT_ban_dau.ToString)
                End If
            Next
            load_data()

            Thongbao("Cập nhật thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private formParent As frmESS_NhapDiemThanhPhanLop
    Private Sub frmKiemTraBu_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        For Each fParent As Form In Application.OpenForms
            If fParent.Name = "frmESS_NhapDiemThanhPhanLop" Then
                Dim f As frmESS_NhapDiemThanhPhanLop = fParent
                f.refreshDiemTP()
            End If
        Next
    End Sub
End Class