Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports ESS.BLL.Business
Public Class frmESS_DMKeHoachKyHieu
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False

#Region "Khai bao Bien & Hang"
    Private Const Header As String = "Định Mức Học Phí Theo Hệ Đào Tạo"
    Private Const TableName As String = "PLAN_KeHoachKyHieu"
    Private Const FieldOption0 As String = "Ky_hieu"
    Private Const FieldOption1 As String = "Ten_ky_hieu"
    Private Const FieldOption2 As String = "bgColor"
    Private Const FieldOption3 As String = "txtColor"

    Private Const HeadOption0 As String = "Ký hiệu"
    Private Const HeadOption1 As String = "Tên ký hiệu"
    Private Const HeadOption2 As String = "Mầu nền"
    Private Const HeadOption3 As String = "Mầu chữ"

    Dim cls As New clsDanh_muc
    Dim ValueOption0 As String = ""
    Dim ValueOption1 As String = ""
    Dim ValueOption2 As Integer = 0
    Dim ValueOption3 As Integer = 0

#End Region

#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'Ký hiệu
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = FieldOption0
            .DataPropertyName = FieldOption0
            .HeaderText = HeadOption0
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col0)
        'Tên ký hiệu
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldOption1
            .DataPropertyName = FieldOption1
            .HeaderText = HeadOption1
            .Width = 300
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col1)
        'Mầu nền
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldOption2
            .DataPropertyName = FieldOption2
            .HeaderText = HeadOption2
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Mầu chữ
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldOption3
            .DataPropertyName = FieldOption3
            .HeaderText = HeadOption3
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col3)
    End Sub
    Private Sub SetValueFromUI()
        TextBoxKyHieu.Text = ValueOption0
        TextBoxTen.Text = ValueOption1
        TextBoxBackColor.Text = ValueOption2
        TextBoxTextColor.Text = ValueOption3
        LabelBackColor.BackColor = Color.FromArgb(ValueOption2)
        LabelTextColor.ForeColor = Color.FromArgb(ValueOption3)
        LabelShow.BackColor = Color.FromArgb(ValueOption2)
        LabelShow.ForeColor = Color.FromArgb(ValueOption3)
    End Sub
    Private Sub GetValueFromUI()
        ValueOption0 = TextBoxKyHieu.Text
        ValueOption1 = TextBoxTen.Text
        ValueOption2 = CInt(TextBoxBackColor.Text)
        ValueOption3 = CInt(TextBoxTextColor.Text)
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If TextBoxKyHieu.Text = "" Then
            Me.ErrorProvider1.SetError(TextBoxKyHieu, "Bạn phải chọn dữ liệu!")
            TextBoxKyHieu.Focus()
            ValidForm = False
        End If
        If TextBoxTen.Text = "" Then
            Me.ErrorProvider1.SetError(TextBoxTen, "Bạn phải chọn dữ liệu!")
            TextBoxTen.Focus()
            ValidForm = False
        End If
        If TextBoxBackColor.Text = "" Then
            Me.ErrorProvider1.SetError(TextBoxBackColor, "Bạn phải chọn dữ liệu!")
            TextBoxBackColor.Focus()
            ValidForm = False
        End If
        If TextBoxTextColor.Text = "" Then
            Me.ErrorProvider1.SetError(TextBoxTextColor, "Bạn phải chọn dữ liệu!")
            TextBoxTextColor.Focus()
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
        TextBoxKyHieu.Enabled = status
        TextBoxTen.Enabled = status
        TextBoxBackColor.Enabled = False
        TextBoxTextColor.Enabled = False

    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.CatalogueLoad(TableName).DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            ValueOption0 = rowCurr.Cells(FieldOption0).Value
            ValueOption1 = rowCurr.Cells(FieldOption1).Value
            ValueOption2 = rowCurr.Cells(FieldOption2).Value
            ValueOption3 = rowCurr.Cells(FieldOption3).Value
            SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckExist(ByVal Option0 As String) As Boolean
        If cls.CheckExist_Options(TableName, FieldOption0, Option0) Then
            Thongbao("Dữ liệu đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ShowCaption()
        Me.Text = Header
        'Me.LabelOption0.Text = HeadOption0
        'Me.LabelOption1.Text = HeadOption1
        'Me.LabelOption2.Text = HeadOption2
        'Me.LabelOption3.Text = HeadOption3
    End Sub
#End Region

#Region "Form Event"
    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
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
            TextBoxKyHieu.Text = ""
            TextBoxTen.Text = ""
            TextBoxBackColor.Text = ""
            TextBoxTextColor.Text = ""
            LabelBackColor.BackColor = Color.Transparent
            LabelTextColor.ForeColor = Color.Black
            LabelShow.BackColor = Color.Transparent
            LabelShow.ForeColor = Color.Black
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
                If cls.CatalogueDelete(TableName, FieldOption0, ValueOption0) Then
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
                If Not CheckExist(ValueOption0) Then
                    cls.CatalogueInsert(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueOption0 <> TextBoxKyHieu.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(TextBoxKyHieu.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
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
    Private Sub LabelBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelBackColor.Click, LabelTextColor.Click
        If edit = False And add = False Then Exit Sub
        Dim dlg As New ColorDialog 'show color
        dlg.ShowDialog()
        If CType(sender, System.Windows.Forms.Label).Name = "LabelBackColor" Then
            sender.BackColor = dlg.Color
        Else
            sender.ForeColor = dlg.Color
        End If
        LabelShow.BackColor = LabelBackColor.BackColor
        LabelShow.ForeColor = LabelTextColor.ForeColor
        TextBoxBackColor.Text = LabelBackColor.BackColor.ToArgb
        TextBoxTextColor.Text = LabelTextColor.ForeColor.ToArgb
    End Sub
#End Region
End Class