Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMHeDaoTao
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False
#Region "Khai bao Bien & Hang"
    Private Const Header As String = "Danh Mục Hệ Đào Tạo"
    Private Const TableName As String = "STU_He"
    Private Const FieldID As String = "ID_he"
    Private Const FieldMa As String = "Ma_he"
    Private Const FieldTen As String = "Ten_he"
    Private Const FieldTenEn As String = "Ten_he_en"
    Private Const FieldTen_QC As String = "Quy_che"
    Private Const HeadMa As String = "Mã hệ"
    Private Const HeadTen As String = "Tên hệ"
    Private Const HeadTenEn As String = "Tên hệ"
    Private Const HeadTen_QC As String = "Áp dụng Quy chế"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueTenEn As String = ""
    Dim Value_QC As Integer = 25
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
            .Name = FieldTen
            .DataPropertyName = FieldTen
            .HeaderText = HeadTen
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Tên En
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldTenEn
            .DataPropertyName = FieldTenEn
            .HeaderText = HeadTenEn
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .Name = FieldTen_QC
            .DataPropertyName = FieldTen_QC
            .HeaderText = HeadTen_QC
            .Width = 250
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col4)
    End Sub
    Private Sub SetValueFromUI()
        txtMa.Text = ValueMa
        txtTen.Text = ValueTen
        txtTenEn.Text = ValueTenEn
        txtQuy_che.Text = Value_QC
        cmbQuyChe.SelectedValue = Value_QC
    End Sub
    Private Sub GetValueFromUI()
        ValueMa = txtMa.Text
        ValueTen = txtTen.Text
        ValueTenEn = txtTenEn.Text
        ''Value_QC = txtQuy_che.Text
        Value_QC = cmbQuyChe.SelectedValue
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
        If txtTen.Text = "" Then
            Me.ErrorProvider1.SetError(txtTen, "Bạn phải nhập tên!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtMa.Text.Length > 5 Then
            Me.ErrorProvider1.SetError(txtMa, "Mã quá dài, chỉ được nhập " & 5 & " ký tự!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text.Length > 50 Then
            Me.ErrorProvider1.SetError(txtTen, "Tên quá dài, chỉ được nhập " & 50 & " ký tự!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtQuy_che.Text = "" Then
            Me.ErrorProvider1.SetError(txtQuy_che, "Hãy nhập Quy chế đào tạo!")
            txtQuy_che.Focus()
            ValidForm = False
        ElseIf Not IsNumeric(txtQuy_che.Text.Trim) Then
            Me.ErrorProvider1.SetError(txtQuy_che, "Hãy nhập Quy chế đào tạo dạng số như 25 hay 40!")
            txtQuy_che.Focus()
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
        txtMa.Enabled = status
        txtTen.Enabled = status
        txtTenEn.Enabled = status
        txtQuy_che.Enabled = status
        cmbQuyChe.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.CatalogueLoad(TableName).DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Try
            Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
            If Not rowCurr Is Nothing Then
                ValueID = rowCurr.Cells(FieldID).Value
                ValueMa = rowCurr.Cells(FieldMa).Value
                ValueTen = rowCurr.Cells(FieldTen).Value
                ValueTenEn = IIf(IsDBNull(rowCurr.Cells(FieldTenEn).Value), "", rowCurr.Cells(FieldTenEn).Value)
                Value_QC = rowCurr.Cells(FieldTen_QC).Value
                SetValueFromUI()
                Return True
            Else
                Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
                Return False
            End If
        Catch ex As Exception

        End Try

    End Function
    Private Function CheckExist(ByVal Ma As String) As Boolean
        If cls.CheckExist_Ma(TableName, FieldMa, Ma) Then
            Thongbao("""" & Ma & """ đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ShowCaption()
        Me.Text = Header
        Me.LabelMa.Text = HeadMa
        Me.LabelTen.Text = HeadTen
        Me.LabelTenEn.Text = HeadTenEn
    End Sub
#End Region
#Region "Form Event"

    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim dt As DataTable
            dt = ESS.Machine.UDB.SelectTable("SELECT DISTINCT Quy_che, N'Quy chế ' + CONVERT(nvarchar(10),Quy_che) Ten_quy_che FROM MARK_ThamSoQuyChe")
            FillCombo(cmbQuyChe, dt)
            ShowCaption()
            FormatDataGridView()
            ReloadDataGridView()
            VisibleCmd(True)
            loaded = True
        Catch ex As Exception
        End Try
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
            txtTen.Text = ""
            txtTenEn.Text = ""
            txtQuy_che.Text = ""
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
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldTenEn, ValueTenEn, FieldTen_QC, Value_QC)

                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldTenEn, ValueTenEn, FieldTen_QC, Value_QC)

                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldTenEn, ValueTenEn, FieldTen_QC, Value_QC)

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