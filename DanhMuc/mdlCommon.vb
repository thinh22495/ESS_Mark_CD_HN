Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports System.Net
Imports System.Windows.Forms
Imports System.Drawing
Module mdlCommon
    Public Const gID_ph As Byte = 7
    Public gFunctionID As Integer = 0
    Public gobjUser As New Users
    Public gBgColor1 As Color = Color.FromArgb(227, 239, 255)
    Public gBgColor2 As Color = Color.FromArgb(227, 239, 255)
    Public Structure cboData
        Private Display_member As Object
        Private Value_member As Object
        Public Sub New(ByVal vValue As Object, ByVal vText As Object)
            Value_member = vValue
            Display_member = vText
        End Sub
        Public ReadOnly Property GetValue() As Object
            Get
                Return Value_member
            End Get
        End Property
        Public ReadOnly Property GetText() As Object
            Get
                Return Display_member
            End Get
        End Property
    End Structure

    Public Sub SetUpDataGridView(ByVal myDataGridView As DataGridView)
        With myDataGridView
            .AutoGenerateColumns = False
            .AutoResizeColumns()
            ' Set DataGridView visual properties (Colors, Fonts, etc.)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue
            .RowHeadersDefaultCellStyle.BackColor = Color.PowderBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Brown
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)

            .EditMode = DataGridViewEditMode.EditOnEnter
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = System.Drawing.Color.SandyBrown
            '.BackgroundColor = System.Drawing.Color.ControlDark
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            .MultiSelect = False
        End With
    End Sub

    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dt As DataTable)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()
            If dt.Columns.Count > 1 Then
                ComboboxName.ValueMember = dt.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dt.Columns(1).ColumnName.ToString
            Else
                ComboboxName.ValueMember = dt.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dt.Columns(0).ColumnName.ToString
            End If
            ComboboxName.DataSource = dt
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Sub FillComboHocky(ByVal ComboBoxName As ComboBox)
        Dim i As Integer
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = 1 To 2
                Arr.Add(New cboData(i, "0" & i))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                If Today.Month >= 9 Or Today.Month <= 1 Then
                    .SelectedValue = 1
                Else
                    .SelectedValue = 2
                End If
            End With
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Sub AFillComboHocky10(ByVal ComboBoxName As ComboBox)
        Dim i As Byte
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = 1 To 12
                Arr.Add(New cboData(i, i))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                .SelectedValue = 0
            End With
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Sub FillComboNamhoc(ByVal ComboBoxName As ComboBox)
        Dim i As Integer
        Dim CurYear As Integer = Today.Year
        Dim Arr As New ArrayList
        Try
            If Not ComboBoxName.DataSource Is Nothing Then ComboBoxName.Items.Clear()
            For i = CurYear - 5 To CurYear + 5
                Arr.Add(New cboData(i, i & "-" & i + 1))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                If Today.Month >= 9 Then
                    .SelectedValue = CurYear
                Else
                    .SelectedValue = CurYear - 1
                End If
            End With
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Sub FillComboNam(ByVal ComboBoxName As ComboBox)
        Dim i As Integer
        Dim CurYear As Integer = Today.Year
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = CurYear - 10 To CurYear + 5
                Arr.Add(New cboData(i, i.ToString))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                If Today.Month >= 9 Then
                    .SelectedValue = CurYear
                Else
                    .SelectedValue = CurYear - 1
                End If
            End With
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

#Region "Cac thuc tuc xu ly Control"
    Public Sub HandleNextTAB(ByVal Obj As Object)
        Dim frmESS_Obj As Object
        Try
            For Each frmESS_Obj In Obj.Controls
                If (TypeOf frmESS_Obj Is TextBox) And frmESS_Obj.Focused Then
                    If Not frmESS_Obj.Multiline Then SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is ComboBox) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is CheckBox) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is RadioButton) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is DateTimePicker) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is Panel) Then
                    HandleNextTAB(frmESS_Obj)
                ElseIf (TypeOf frmESS_Obj Is TabControl) Then
                    HandleNextTAB(frmESS_Obj.TabPages(frmESS_Obj.SelectedIndex))
                ElseIf (TypeOf frmESS_Obj Is GroupBox) Then
                    HandleNextTAB(frmESS_Obj)
                End If
            Next frmESS_Obj
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Sub HandleCombo_Delkey(ByVal Obj As Object)
        Dim frmESS_Obj As Object
        Try
            For Each frmESS_Obj In Obj.Controls
                If (TypeOf frmESS_Obj Is ComboBox) And frmESS_Obj.Focused Then
                    If frmESS_Obj.DropDownStyle = ComboBoxStyle.DropDownList Then
                        frmESS_Obj.SelectedIndex = -1
                        frmESS_Obj.SelectedIndex = -1
                    End If
                ElseIf (TypeOf frmESS_Obj Is Panel) Then
                    HandleCombo_Delkey(frmESS_Obj)
                ElseIf (TypeOf frmESS_Obj Is TabControl) Then
                    HandleCombo_Delkey(frmESS_Obj.TabPages(frmESS_Obj.SelectedIndex))
                ElseIf (TypeOf frmESS_Obj Is GroupBox) Then
                    HandleCombo_Delkey(frmESS_Obj)
                End If
            Next frmESS_Obj
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Function HandleNumberKey(ByVal eKeyChar As Char, Optional ByVal Str As String = "") As Boolean
        Try
            HandleNumberKey = False
            If Asc(eKeyChar) = 8 Then Return Nothing
            If Str = "" Then
Number:
                If Asc(eKeyChar) < 48 Or Asc(eKeyChar) > 57 Then HandleNumberKey = True
            ElseIf InStr(Str, eKeyChar, CompareMethod.Binary) > 0 Then
                Return Nothing
            Else
                GoTo Number
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Public Sub SetErrPro(ByVal Obj As Object, ByVal ErrPro As ErrorProvider, Optional ByVal strMessage As String = "", Optional ByVal Align As ErrorIconAlignment = ErrorIconAlignment.MiddleLeft)
        ErrPro.SetIconAlignment(Obj, Align)
        ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrPro.SetError(Obj, strMessage)
    End Sub
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dt As DataTable, ByVal ValueMemberField As String, ByVal DisplayMemberField As String)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()

            ComboboxName.ValueMember = ValueMemberField
            ComboboxName.DisplayMember = DisplayMemberField

            ComboboxName.DataSource = dt
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Cac thu tuc loc du lieu"
    Public Function SelectDistinct(ByVal SourceTable As DataTable, ByVal ParamArray FieldNames() As String) As DataTable
        Dim lastValues() As Object
        Dim newTable As DataTable

        If FieldNames Is Nothing OrElse FieldNames.Length = 0 Then
            Throw New ArgumentNullException("FieldNames")
        End If

        lastValues = New Object(FieldNames.Length - 1) {}
        newTable = New DataTable

        For Each field As String In FieldNames
            newTable.Columns.Add(field, SourceTable.Columns(field).DataType)
        Next

        For Each Row As DataRow In SourceTable.Select("", String.Join(", ", FieldNames))
            If Not fieldValuesAreEqual(lastValues, Row, FieldNames) Then
                newTable.Rows.Add(createRowClone(Row, newTable.NewRow(), FieldNames))

                setLastValues(lastValues, Row, FieldNames)
            End If
        Next

        Return newTable
    End Function
    Private Function fieldValuesAreEqual(ByVal lastValues() As Object, ByVal currentRow As DataRow, ByVal fieldNames() As String) As Boolean
        Dim areEqual As Boolean = True

        For i As Integer = 0 To fieldNames.Length - 1
            If lastValues(i) Is Nothing OrElse Not lastValues(i).Equals(currentRow(fieldNames(i))) Then
                areEqual = False
                Exit For
            End If
        Next

        Return areEqual
    End Function
    Private Function createRowClone(ByVal sourceRow As DataRow, ByVal newRow As DataRow, ByVal fieldNames() As String) As DataRow
        For Each field As String In fieldNames
            newRow(field) = sourceRow(field)
        Next

        Return newRow
    End Function
    Private Sub setLastValues(ByVal lastValues() As Object, ByVal sourceRow As DataRow, ByVal fieldNames() As String)
        For i As Integer = 0 To fieldNames.Length - 1
            lastValues(i) = sourceRow(fieldNames(i))
        Next
    End Sub
#End Region
    Public Sub SetQuyenTruyCap(Optional ByVal cmdSave As Object = Nothing, Optional ByVal cmdAdd As Object = Nothing, Optional ByVal cmdEdit As Object = Nothing, Optional ByVal cmdDelete As Object = Nothing)
        Dim idx_quyen As Integer
        idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
        If idx_quyen >= 0 Then
            If gobjUser.Quyen.Quyen(idx_quyen).Them = 0 Then
                If Not cmdAdd Is Nothing Then cmdAdd.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.Quyen.Quyen(idx_quyen).Sua = 0 Then
                If Not cmdEdit Is Nothing Then cmdEdit.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.Quyen.Quyen(idx_quyen).Xoa = 0 Then
                If Not cmdDelete Is Nothing Then cmdDelete.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
        End If
    End Sub
    Public Sub SaveLog(ByVal Su_kien As LoaiSuKien, ByVal Noi_dung As String)
        Dim objSuKien As New SuKienNguoiDung
        Dim clsSuKien As New SuKienNguoiDung_BLL
        Dim May_tram As String
        'Get IP Address
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        May_tram = CType(h.AddressList.GetValue(0), IPAddress).ToString
        objSuKien.ID_phan_he = gID_ph
        objSuKien.Su_kien = Su_kien
        objSuKien.UserName = gobjUser.UserName
        objSuKien.Thoi_diem = Now
        objSuKien.May_tram = May_tram
        objSuKien.Noi_dung = Noi_dung
        clsSuKien.Insert_SuKienNguoiDung(objSuKien)
    End Sub
End Module
