Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_ThanhPhanDiem
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False
#Region "Khai bao Bien & Hang"
    Private Const TableName As String = "MARK_ThanhPhanMon"
    Private Const TableName2 As String = "STU_He"
    Private Const FieldID As String = "ID_thanh_phan"
    Private Const FieldMa As String = "Ky_hieu"
    Private Const FieldTen As String = "Ten_thanh_phan"
    Private Const FieldID_He As String = "ID_he"
    Private Const FieldSTT As String = "STT"
    Private Const FieldTy_le As String = "Ty_le"
    Private Const FieldChon_mac_dinh As String = "Chon_mac_dinh"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueID_he As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueSTT As Integer = 0
    Dim ValueTy_le As Integer = 0
    Dim ValueChon_mac_dinh As Integer = 0

#End Region
#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'ID
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = FieldID
            .DataPropertyName = FieldID
            .HeaderText = "id"
            .Width = 10
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        Dim col01 As New DataGridViewTextBoxColumn
        With col01
            .Name = FieldID_He
            .DataPropertyName = FieldID_He
            .HeaderText = "id_he"
            .Width = 1
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col01)
        'Mã
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldSTT
            .DataPropertyName = FieldSTT
            .HeaderText = "STT"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'Tên
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldMa
            .DataPropertyName = FieldMa
            .HeaderText = "Ký hiệu"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Tên
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldTen
            .DataPropertyName = FieldTen
            .HeaderText = "Tên thành phần"
            .Width = 120
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .Name = "Ten_he"
            .DataPropertyName = "Ten_he"
            .HeaderText = "Hệ đào tạo"
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col4)

        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .Name = FieldTy_le
            .DataPropertyName = FieldTy_le
            .HeaderText = "Hệ số"
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col5)
        Dim col6 As New DataGridViewCheckBoxColumn
        With col6
            .Name = FieldChon_mac_dinh
            .DataPropertyName = FieldChon_mac_dinh
            .HeaderText = "Mặc định"
            .Width = 50
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col6)
    End Sub
    Private Sub SetValueFromUI()
        txtSTT.Text = ValueSTT
        txtKy_hieu.Text = ValueMa
        txtTen_thanh_phan.Text = ValueTen
        cmbID_he.SelectedValue = ValueID_he
        txtTy_le.Text = ValueTy_le
        optMac_dinh.Checked = ValueChon_mac_dinh
    End Sub
    Private Sub GetValueFromUI()
        ValueSTT = txtSTT.Text
        ValueMa = txtKy_hieu.Text
        ValueTen = txtTen_thanh_phan.Text
        ValueID_he = cmbID_he.SelectedValue
        ValueTy_le = txtTy_le.Text
        ValueChon_mac_dinh = optMac_dinh.Checked
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If txtTen_thanh_phan.Text = "" Then
            Me.ErrorProvider1.SetError(txtTen_thanh_phan, "Bạn phải nhập Tên thành phần!")
            txtTen_thanh_phan.Focus()
            ValidForm = False
        End If
        If txtKy_hieu.Text = "" Then
            Me.ErrorProvider1.SetError(txtKy_hieu, "Bạn phải nhập Ký hiệu!")
            txtKy_hieu.Focus()
            ValidForm = False
        End If
        If cmbID_he.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(cmbID_he, "Bạn phải nhập hệ đào tạo!")
            cmbID_he.Focus()
            ValidForm = False
        End If
        If txtSTT.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(txtSTT, "Phải nhập STT!")
            txtSTT.Focus()
            ValidForm = False
        End If
        If txtSTT.Text.Length > 0 AndAlso Not IsNumeric(txtSTT.Text) Then
            Me.ErrorProvider1.SetError(txtSTT, "Phải nhập số!")
            txtSTT.Focus()
            ValidForm = False
        End If
        If txtTy_le.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(txtTy_le, "Phải nhập Tỷ lệ!")
            txtTy_le.Focus()
            ValidForm = False
        End If
        If txtTy_le.Text.Length > 0 AndAlso Not IsNumeric(txtTy_le.Text) Then
            Me.ErrorProvider1.SetError(txtTy_le, "Phải nhập số!")
            txtTy_le.Focus()
            ValidForm = False
        End If
    End Function
    Private Sub VisibleCmd(ByVal status As Boolean)
        cmdAdd.Visible = status
        cmdEdit.Visible = status
        cmdDelete.Visible = status
        cmdClose.Visible = status
        cmdSave.Visible = Not status
        cmdCancel.Visible = Not status
    End Sub
    Private Sub EnableTextBox(ByVal status As Boolean)
        txtSTT.Enabled = status
        txtKy_hieu.Enabled = status
        txtTen_thanh_phan.Enabled = status
        txtTy_le.Enabled = status
        'cmbID_he.Enabled = status
        optMac_dinh.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.Catalogue2TableLoad(TableName, "ID_he", TableName2, "ID_he").DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            ValueID = rowCurr.Cells(FieldID).Value
            ValueMa = rowCurr.Cells(FieldMa).Value
            ValueTen = rowCurr.Cells(FieldTen).Value
            ValueSTT = rowCurr.Cells(FieldSTT).Value
            ValueID_he = rowCurr.Cells(FieldID_He).Value
            ValueTy_le = rowCurr.Cells(FieldTy_le).Value
            ValueChon_mac_dinh = rowCurr.Cells(FieldChon_mac_dinh).Value

            SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckExist(ByVal Ma As String) As Boolean
        If cls.CheckExist_Ma(TableName, FieldMa, Ma) Then
            Thongbao("""" & Ma & """ đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub FillComboBox()
        Dim dt1 As DataTable = cls.CatalogueLoad(TableName2)
        Dim dt2 As New DataTable
        dt2.Columns.Add("ID_he", GetType(String))
        dt2.Columns.Add("Ten_he", GetType(String))
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim row As DataRow = dt2.NewRow()
            row("ID_he") = dt1.Rows(i)("ID_he")
            row("Ten_he") = dt1.Rows(i)("Ten_he")
            dt2.Rows.Add(row)
        Next
        FillCombo(cmbID_he, dt2)
    End Sub
#End Region
#Region "Form Event"
    Private Sub frmESS_ThanhPhanDiem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FillComboBox()
            FormatDataGridView()
            ReloadDataGridView()
            VisibleCmd(True)
            loaded = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_ThanhPhanDiem_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            txtSTT.Text = ""
            txtKy_hieu.Text = ""
            txtTen_thanh_phan.Text = ""
            add = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If CheckSelectedGridView() = False Then Exit Sub
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            edit = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If CheckSelectedGridView() Then
                If cls.CatalogueDelete(TableName, FieldID, ValueID) Then
                    ReloadDataGridView()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If ValidForm() = False Then Exit Sub
            If add Then
                'Gán giá trị co đối tượng
                Call GetValueFromUI()
                'If Not CheckExist(ValueMa) Then
                cls.CatalogueInsert(TableName, FieldSTT, ValueSTT, FieldMa, ValueMa, FieldTen, ValueTen, FieldID_He, ValueID_he, FieldTy_le, ValueTy_le, FieldChon_mac_dinh, ValueChon_mac_dinh)
                ReloadDataGridView()
                add = False
                'End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtKy_hieu.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtKy_hieu.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldSTT, ValueSTT, FieldMa, ValueMa, FieldTen, ValueTen, FieldID_He, ValueID_he, FieldTy_le, ValueTy_le, FieldChon_mac_dinh, ValueChon_mac_dinh)

                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldSTT, ValueSTT, FieldMa, ValueMa, FieldTen, ValueTen, FieldID_He, ValueID_he, FieldTy_le, ValueTy_le, FieldChon_mac_dinh, ValueChon_mac_dinh)

                    ReloadDataGridView()
                    edit = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ReloadDataGridView()
        edit = False
        add = False
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.SelectionChanged
        If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region
End Class