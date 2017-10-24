Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMPhongKTX
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False

#Region "Khai bao Bien & Hang"
    Private Const Header As String = "Danh Mục Phòng KTX"
    Private Const TableName As String = "STU_PhongKyTucXa"
    Private Const TableParentName As String = "STU_ToaNhaKyTucXa"
    Private Const FieldID As String = "ID_phong_ktx"
    Private Const FieldID_tang As String = "ID_tang"
    Private Const FieldMa As String = "So_phong_KTX"
    Private Const FieldSucChua As String = "Suc_chua"
    Private Const FieldThietBi As String = "Thiet_bi"
    Private Const FieldParentID As String = "ID_nha_ktx"
    Private Const FieldSo_tien_mot_nguoi As String = "So_tien_mot_nguoi"

    Private Const HeadTang As String = "Tầng"
    Private Const HeadMa As String = "Số phòng"
    Private Const HeadSucChua As String = "Sức chứa"
    Private Const HeadThietBi As String = "Thiết bị"
    Private Const HeadParent As String = "Nhà"
    Private Const HeadSo_tien_mot_nguoi As String = "Số tiền / người"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueID_tang As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueSucChua As String = ""
    Dim ValueThietBi As String = ""
    Dim ValueParentID As Integer = 0
    Dim ValueSo_tien_mot_nguoi As Integer = 0
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
            .HeaderText = "ID"
            .Width = 10
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        'Mã
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldMa
            .DataPropertyName = FieldMa
            .HeaderText = HeadMa
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'Tên
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldSucChua
            .DataPropertyName = FieldSucChua
            .HeaderText = HeadSucChua
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Tên
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldThietBi
            .DataPropertyName = FieldThietBi
            .HeaderText = HeadThietBi
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        'ID Parent
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .Name = FieldParentID
            .DataPropertyName = FieldParentID
            .HeaderText = HeadParent
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col4)
        'ID Parent
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .Name = FieldID_tang
            .DataPropertyName = FieldID_tang
            .HeaderText = HeadTang
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col5)
        'ID Parent
        Dim col6 As New DataGridViewTextBoxColumn
        With col6
            .Name = FieldSo_tien_mot_nguoi
            .DataPropertyName = FieldSo_tien_mot_nguoi
            .HeaderText = HeadSo_tien_mot_nguoi
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col6)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        cmbTang.SelectedIndex = ValueID_tang - 1
        txtMa.Text = ValueMa
        txtSucChua.Text = ValueSucChua
        txtThietBi.Text = ValueThietBi
        cmbParentsID.SelectedValue = ValueParentID
        txtSo_tien_mot_nguoi.Text = ValueSo_tien_mot_nguoi
    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueID_tang = cmbTang.Text
        ValueMa = txtMa.Text
        ValueSucChua = txtSucChua.Text
        ValueThietBi = txtThietBi.Text
        ValueParentID = cmbParentsID.SelectedValue
        ValueSo_tien_mot_nguoi = txtSo_tien_mot_nguoi.Text
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If txtMa.Text = "" Then
            Me.ErrorProvider1.SetError(txtMa, "Bạn phải nhập mã!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtMa.Text.Length > 10 Then
            Me.ErrorProvider1.SetError(txtMa, "Mã quá dài, chỉ được nhập " & 10 & " ký tự!")
            txtMa.Focus()
            ValidForm = False
        End If
        If cmbParentsID.Text = "" Then
            Me.ErrorProvider1.SetError(cmbParentsID, "Bạn phải nhập ngành!")
            cmbParentsID.Focus()
            ValidForm = False
        End If
        If cmbTang.Text = "" Then
            Me.ErrorProvider1.SetError(cmbTang, "Bạn phải nhập tầng!")
            cmbTang.Focus()
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
        txtThietBi.Enabled = status
        txtMa.Enabled = status
        txtSucChua.Enabled = status
        cmbParentsID.Enabled = status
        cmbTang.Enabled = status
        txtSo_tien_mot_nguoi.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.CatalogueLoad(TableName).DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        If Not loaded Then Exit Function
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            ValueID_tang = rowCurr.Cells(FieldID_tang).Value
            ValueID = rowCurr.Cells(FieldID).Value
            ValueMa = rowCurr.Cells(FieldMa).Value
            ValueSucChua = rowCurr.Cells(FieldSucChua).Value
            ValueThietBi = rowCurr.Cells(FieldThietBi).Value
            ValueParentID = rowCurr.Cells(FieldParentID).Value
            ValueSo_tien_mot_nguoi = IIf(rowCurr.Cells(FieldSo_tien_mot_nguoi).Value.ToString = "", 0, rowCurr.Cells(FieldSo_tien_mot_nguoi).Value)
            SetValueFromUI()
            Return True
        Else
            'Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
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
        Dim dt1 As DataTable = cls.CatalogueLoad(TableParentName)
        Dim dt2 As New DataTable
        dt2.Columns.Add("ID", GetType(Integer))
        dt2.Columns.Add("Ten", GetType(String))
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim row As DataRow = dt2.NewRow()
            row("ID") = dt1.Rows(i)(0)
            row("Ten") = "(" & dt1.Rows(i)(1) & ") " & dt1.Rows(i)(2)
            dt2.Rows.Add(row)
        Next
        FillCombo(cmbParentsID, dt2)
    End Sub
    Private Sub ShowCaption()
        Me.Text = Header
        Me.LabelMa.Text = HeadMa
        Me.LabelSucChua.Text = HeadSucChua
        Me.LabelThietBi.Text = HeadThietBi
        Me.LabelParent.Text = HeadParent
        Me.lblSo_tien_mot_nguoi.Text = HeadSo_tien_mot_nguoi
    End Sub
#End Region
#Region "Form Event"
    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ShowCaption()
            FillComboBox()
            FormatDataGridView()
            ReloadDataGridView()
            VisibleCmd(True)
            loaded = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSo_tien_mot_nguoi.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar, ".")
    End Sub
    Private Sub frmESS_DM_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            txtMa.Text = ""
            txtSucChua.Text = ""
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
                If Not CheckExist(ValueMa) Then
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldSucChua, ValueSucChua, _
                    FieldThietBi, ValueThietBi, FieldID_tang, ValueID_tang, FieldParentID, _
                    ValueParentID, FieldSo_tien_mot_nguoi, ValueSo_tien_mot_nguoi)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldSucChua, _
                        ValueSucChua, FieldThietBi, ValueThietBi, FieldID_tang, ValueID_tang, _
                        FieldParentID, ValueParentID, FieldSo_tien_mot_nguoi, ValueSo_tien_mot_nguoi)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldSucChua, _
                    ValueSucChua, FieldThietBi, ValueThietBi, FieldID_tang, ValueID_tang, _
                    FieldParentID, ValueParentID, FieldSo_tien_mot_nguoi, ValueSo_tien_mot_nguoi)
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
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.SelectionChanged, DataGridViewDM.CurrentCellChanged
        If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region
End Class