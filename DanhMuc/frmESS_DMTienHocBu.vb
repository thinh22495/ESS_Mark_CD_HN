Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports ESS.Machine
Public Class frmESS_DMTienHocBu
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False

#Region "Khai bao Bien & Hang"
    Private Const Header As String = "LỆ PHÍ HỌC BÙ THI BÙ"
    Private Const TableName As String = "MARK_GIATIENHOCBU"
    Private Const TableParentName As String = "STU_He"
    Private Const FieldID As String = "ID_Gia_tien"
    Private Const FieldMa As String = "Nam_hoc"
    Private Const FieldTen As String = "Gia_tien"
    Private Const FieldTenEn As String = "Loai"
    Private Const FieldParentID As String = "ID_he"
    Private Const HeadMa As String = "Năm học"
    Private Const HeadTen As String = "Giá tiền"
    Private Const HeadTenEn As String = "Loại thu"
    Private Const HeadParent As String = "Tên hệ"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As Single = 0
    Dim ValueTenEn As String = ""
    Dim ValueParentID As Integer = 0
    Dim frmESS_Parrent As New frmESS_DMHuyen

#End Region

#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'ID
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = "ID_Gia_tien"
            .DataPropertyName = "ID_Gia_tien"
            .HeaderText = "id"
            .Width = 10
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        'Tên tinh
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = "Ten_he"
            .DataPropertyName = "Ten_he"
            .HeaderText = "Tên hệ"
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)

        'Tên huyen
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = "Nam_hoc"
            .DataPropertyName = "Nam_hoc"
            .HeaderText = "Năm học"
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        'Tên
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = "Gia_tien"
            .DataPropertyName = "Gia_tien"
            .HeaderText = "Giá tiền"
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'ID Parent
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .Name = "ID_he"
            .DataPropertyName = "ID_he"
            .HeaderText = "ID_he"
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col4)
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .Name = "Loai"
            .DataPropertyName = "Loai"
            .HeaderText = "Loại"
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col5)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        If CheckSelectedGridView() Then
            ComboBox1.SelectedValue = ValueMa
            txtGiaTien.Text = ValueTen
            ComboBox2.SelectedValue = ValueTenEn
            cmbParentsID.SelectedValue = ValueParentID
        End If

    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueMa = ComboBox1.SelectedText
        ValueTen = txtGiaTien.Text
        ValueTenEn = ComboBox2.SelectedValue
        ValueParentID = cmbParentsID.SelectedValue
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        'If txtMa.Text = "" Then
        '    Me.ErrorProvider1.SetError(txtMa, "Bạn phải nhập dữ liệu!")
        '    txtMa.Focus()
        '    ValidForm = False
        'End If
        If txtGiaTien.Text = "" Then
            Me.ErrorProvider1.SetError(txtGiaTien, "Bạn phải nhập dữ liệu!")
            txtGiaTien.Focus()
            ValidForm = False
        End If
        'If txtMa.Text.Length > 5 Then
        '    Me.ErrorProvider1.SetError(txtMa, "Không được nhập quá " & 5 & " ký tự!")
        '    txtMa.Focus()
        '    ValidForm = False
        'End If
        If txtGiaTien.Text.Length > 30 Then
            Me.ErrorProvider1.SetError(txtGiaTien, "Không được nhập quá " & 30 & " ký tự!")
            txtGiaTien.Focus()
            ValidForm = False
        End If
        'If txtTenEn.Text.Length > 30 Then
        '    Me.ErrorProvider1.SetError(txtTenEn, "Không được nhập quá " & 30 & " ký tự!")
        '    txtTenEn.Focus()
        '    ValidForm = False
        'End If
        If cmbParentsID.Text = "" Then
            Me.ErrorProvider1.SetError(cmbParentsID, "Bạn phải chọn dữ liệu!")
            cmbParentsID.Focus()
            ValidForm = False
        End If
    End Function
    Private Sub VisibleCmd(ByVal status As Boolean)
        cmdAdd.Visible = status
        cmdEdit.Visible = status
        cmdDelete.Visible = status
        'cmdClose.Visible = status
        cmdSave.Visible = Not status
        cmdCancel.Visible = Not status
    End Sub
    Private Sub EnableTextBox(ByVal status As Boolean)
        'txtMa.Enabled = status
        txtGiaTien.Enabled = status
        'txtTenEn.Enabled = status
        cmbParentsID.Enabled = status
        ComboBox1.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = UDB.SelectTable("Select * from mark_giatienhocbu a inner join stu_he b on a.id_he=b.id_he")
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            ValueID = rowCurr.Cells("ID_gia_tien").Value()
            ComboBox1.Text = rowCurr.Cells("Nam_hoc").Value().ToString()
            txtGiaTien.Text = rowCurr.Cells("Gia_tien").Value
            ComboBox2.Text = rowCurr.Cells("Loai").Value().ToString()
            cmbParentsID.SelectedValue = rowCurr.Cells("ID_he").Value()
            'SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function

    Public Function CheckExit_Xa(ByVal ten As String, ByVal ID_huyen As String) As Boolean
        If ID_huyen.Length > 0 Then
            Dim sql As String = "select * from stu_xaphuong where id_huyen='" + ID_huyen + "' and Xa_phuong=N'" + ten + "'"
            Dim dt As DataTable = UDB.SelectTable(sql)
            If dt.Rows.Count > 0 Then
                Return False
            End If
        Else
            Thongbao("Bạn phải chọn huyện")
            Return False
        End If
        Return True
    End Function
    Private Sub FillComboBox()
        FillCombo(cmbParentsID, cls.CatalogueLoad(TableParentName), "ID_he", "Ten_he")
        FillComboNamhoc(ComboBox1)
    End Sub
    Private Sub ShowCaption()
        Me.Text = Header
        'Me.LabelMa.Text = HeadMa
        Me.LabelTen.Text = HeadTen
        Me.LabelTenEn.Text = HeadTenEn
        Me.LabelParent.Text = HeadParent
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
    Private Sub frmESS_DM_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            txtGiaTien.Text = ""
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
                If CheckExit_Xa(ValueTen, ValueParentID) Then
                    cls.CatalogueInsert(TableName, FieldTen, ValueTen, FieldParentID, ValueParentID)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueTen <> txtGiaTien.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If CheckExit_Xa(txtGiaTien.Text, ValueParentID) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID.ToString, FieldTen, ValueTen.ToString, FieldParentID, ValueParentID.ToString)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID.ToString, FieldTen, ValueTen.ToString, FieldParentID, ValueParentID.ToString)
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
    Private Sub cmbParentsID_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbParentsID.MouseDoubleClick
        If loaded = False Then Exit Sub
        frmESS_Parrent.ShowDialog()
        FillComboBox()
    End Sub
    Private Sub cmbParentsID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbParentsID.SelectedIndexChanged
        If loaded = False Then Exit Sub
        If add = True Then
            'txtMa.Text = cmbParentsID.SelectedValue
        End If
    End Sub
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.SelectionChanged
        If loaded = False Then Exit Sub
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            CheckSelectedGridView()
        End If
    End Sub
#End Region

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
      
    End Sub
End Class