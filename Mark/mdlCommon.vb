﻿Imports System.IO
Imports Microsoft.Win32
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports System.Net
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Module mdlCommon
    Public Const gUserName As String = "ESSAdmin"
    Public Const gPassWord As String = "ess10102012"
    Public Const gID_ph As Byte = 3
    Public gFunctionID As Integer = 0
    Public gobjUser As New Users
    Public gBgColor1 As Color = Color.FromArgb(247, 245, 241)
    Public gBgColor2 As Color = Color.FromArgb(247, 245, 241)


    Public gTieu_de_ten_bo As String = ""
    Public gTieu_de_ten_truong As String = ""
    Public gTieu_de_noi_ki As String = ""
    Public gTieu_de_chuc_danh1 As String = ""
    Public gTieu_de_chuc_danh2 As String = ""
    Public gTieu_de_chuc_danh3 As String = ""
    Public gTieu_de_chuc_danh4 As String = ""
    Public gTieu_de_nguoi_ki1 As String = ""
    Public gTieu_de_nguoi_ki2 As String = ""
    Public gTieu_de_nguoi_ki3 As String = ""
    Public gTieu_de_nguoi_ki4 As String = ""

    Public EncodeVNI() As String
    Public Sub GetReportHeader()
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_BLL(gobjUser.ID_dv, gobjUser.UserID)
        'Fill Value Tieu_de_bao_cao
        If objBaoCaoTieuDe.Count > 0 Then
            gTieu_de_ten_bo = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_ten_bo
            gTieu_de_ten_truong = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_Ten_truong
            gTieu_de_noi_ki = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_noi_ky
            gTieu_de_chuc_danh1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh1
            gTieu_de_chuc_danh2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh2
            gTieu_de_chuc_danh3 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh3
            gTieu_de_chuc_danh4 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_chuc_danh4
            gTieu_de_nguoi_ki1 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            gTieu_de_nguoi_ki2 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            gTieu_de_nguoi_ki3 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky3
            gTieu_de_nguoi_ki4 = objBaoCaoTieuDe.BaoCaoTieuDe(0).Tieu_de_nguoi_ky4
        End If
    End Sub
    Public Sub PrintXtraReport(ByVal rpt As XtraReport)
        GetReportHeader()
        Dim lookAndFeel As New DefaultLookAndFeel
        lookAndFeel.LookAndFeel.SetSkinStyle("Caramel")
        lookAndFeel.LookAndFeel.SetStyle(LookAndFeelStyle.Skin, False, True)
        rpt.CreateDocument()
        PreviewLocalizer.Active = New VietnameseReportPreview
        rpt.ShowPreview(lookAndFeel.LookAndFeel)
    End Sub
    Public Function GetFilteredDataView(ByVal grid As GridControl) As DataView
        'by anhnt: get dataview from GridControl when filter
        Dim colView As ColumnView = CType(grid.MainView, ColumnView)
        If colView Is Nothing Then
            Return Nothing
        End If
        If colView.ActiveFilter Is Nothing OrElse Not colView.ActiveFilterEnabled OrElse colView.ActiveFilter.Expression = "" Then
            Return TryCast(colView.DataSource, DataView)
        End If

        Dim table As DataTable = DirectCast(colView.DataSource, DataView).Table
        Dim filteredDataView As New DataView(table)
        filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(colView.ActiveFilterCriteria)
        Return filteredDataView
    End Function
    Public Function GetReportDate() As String
        Dim ngay As Integer = DateTime.Now.Day
        Dim Ngay_HT As String = ""
        If ngay < 10 Then
            Ngay_HT = "0" & ngay.ToString
        Else
            Ngay_HT = ngay.ToString
        End If
        Return ", ngày " & Ngay_HT.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Function
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
    End Sub
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal strSQL As String)
        Try
            If strSQL = "" Then Exit Sub
            Dim obj As New DanhMuc_BLL
            Dim dt As DataTable = obj.LoadDanhMuc(strSQL)
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()
            If dt Is Nothing Then Exit Sub
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
        End Try
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
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dv As DataView)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()
            If dv.Table.Columns.Count > 1 Then
                ComboboxName.ValueMember = dv.Table.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dv.Table.Columns(1).ColumnName.ToString
            Else
                ComboboxName.ValueMember = dv.Table.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dv.Table.Columns(0).ColumnName.ToString
            End If
            ComboboxName.DataSource = dv.Table
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
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
    Sub Add_Hocky(ByVal ComboBoxName As ComboBox)
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
            Throw ex
        End Try
    End Sub


    Public Sub HocKy_Nam_Hoc(ByVal Ky_thu As Integer, ByVal Nien_khoa As String, ByRef Hoc_ky As Integer, ByRef Nam_hoc As String)
        Try
            Hoc_ky = 0
            If Nien_khoa <> "" Then
                Nam_hoc = ""
                Select Case Ky_thu
                    Case 1
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) & "-" & CInt(Left(Nien_khoa, 4)) + 1
                        Hoc_ky = 1
                    Case 2
                        Hoc_ky = 2
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) & "-" & CInt(Left(Nien_khoa, 4)) + 1
                    Case 3
                        Hoc_ky = 1
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 1 & "-" & CInt(Left(Nien_khoa, 4)) + 2
                    Case 4
                        Hoc_ky = 2
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 1 & "-" & CInt(Left(Nien_khoa, 4)) + 2
                    Case 5
                        Hoc_ky = 1
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 2 & "-" & CInt(Left(Nien_khoa, 4)) + 3
                    Case 6
                        Hoc_ky = 2
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 2 & "-" & CInt(Left(Nien_khoa, 4)) + 3
                    Case 7
                        Hoc_ky = 1
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 3 & "-" & CInt(Left(Nien_khoa, 4)) + 4
                    Case 8
                        Hoc_ky = 2
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 3 & "-" & CInt(Left(Nien_khoa, 4)) + 4
                    Case 9
                        Hoc_ky = 1
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 4 & "-" & CInt(Left(Nien_khoa, 4)) + 5
                    Case 10
                        Hoc_ky = 2
                        Nam_hoc = CInt(Left(Nien_khoa, 4)) + 4 & "-" & CInt(Left(Nien_khoa, 4)) + 5
                End Select
            Else
                Nam_hoc = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Add_Namhoc(ByVal ComboBoxName As ComboBox)
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
            Throw ex
        End Try
    End Sub
    Sub Add_LanThi(ByVal ComboBoxName As ComboBox, ByVal So_diem_thi As Integer)
        Dim i As Integer
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = 1 To So_diem_thi
                Arr.Add(New cboData(i, "0" & i))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                .SelectedValue = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Ky2to10(ByVal Hoc_ky As Byte, ByVal Nam_hoc As String, ByVal Nien_khoa As String) As Integer
        Try
            If Nien_khoa <> "" And Nam_hoc <> "" Then
                Return (CInt(Left(Nam_hoc, 4)) - CInt(Left(Nien_khoa, 4))) * 2 + Hoc_ky
            Else
                Return -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
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

    Public Sub SetQuyenTruyCap(Optional ByVal cmdSave As Object = Nothing, Optional ByVal cmdAdd As Object = Nothing, Optional ByVal cmdEdit As Object = Nothing, Optional ByVal cmdDelete As Object = Nothing)
        Dim idx_quyen As Integer
        idx_quyen = gobjUser.Quyen.Tim_idx(gFunctionID)
        If idx_quyen >= 0 Then
            If gobjUser.Quyen.Quyen(idx_quyen).Them = 0 Then
                If Not cmdAdd Is Nothing Then cmdAdd.Enabled = False
                'If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.Quyen.Quyen(idx_quyen).Sua = 0 Then
                If Not cmdEdit Is Nothing Then cmdEdit.Enabled = False
                'If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.Quyen.Quyen(idx_quyen).Xoa = 0 Then
                If Not cmdDelete Is Nothing Then cmdDelete.Enabled = False
                'If Not cmdSave Is Nothing Then cmdSave.Enabled = False
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
        objSuKien.Chuc_nang = gFunctionID
        clsSuKien.Insert_SuKienNguoiDung(objSuKien)
    End Sub
#End Region

#Region "Convert font to UniCode"
    Private Function GetLocalDirectory() As String
        ' Obtain the folder where the program resides
        Dim TStr
        ' Get folder where the Exe of this program resides
        TStr = Path.GetDirectoryName(Application.ExecutablePath).ToLower()
        ' Append a backslash if folder does not end with one
        If Right(TStr, 1) <> "\" Then TStr = TStr & "\Encodings\"
        GetLocalDirectory = TStr ' Return the folder
    End Function

    Private Function ReadTextFile(ByRef FileName As Object) As String
        Dim Fs As Scripting.FileSystemObject
        ' Create a FileSystem Object
        Dim TS As Scripting.TextStream
        Fs = CreateObject("Scripting.FileSystemObject")
        ' Open TextStream for Input
        TS = Fs.OpenTextFile(FileName, Scripting.IOMode.ForReading, False, Scripting.Tristate.TristateUseDefault)
        ReadTextFile = TS.ReadAll ' Read the whole content of the text file in one stroke
        TS.Close() ' Close the Text Stream
        Fs = Nothing ' Dispose FileSystem Object
    End Function

    Private Sub PopulateListBoxFromFile(ByVal FileName As String)
        ' Display a text file in a listbox
        Dim FileNum, aLine As Object
        Dim i As Integer
        Dim theFileName As Object
        ' Get out if the input file does not exist
        If Dir(FileName) = "" Then Exit Sub
        FileNum = FreeFile()
        ' Open input file
        'Open theFileName For Input As FileNum
        FileOpen(FileNum, FileName, OpenMode.Input)
        ' Read till End-Of-File
        i = 0
        Do While Not EOF(FileNum)
            'Line Input #FileNum, aLine ' Read a Text line
            aLine = LineInput(FileNum) ' Read a Text line
            ReDim Preserve EncodeVNI(i)
            EncodeVNI(i) = aLine ' Add the line to the EncodeVNI
            i = i + 1
        Loop
        FileClose(FileNum) ' Close the input file
    End Sub

    Private Function StringToString(ByVal Vowel1 As String, ByVal Vowel2 As String, ByVal Str As String) As String
        'Direct one-to-one character mapping from one encoding to another
        Dim letter As String
        Dim Text1 As String
        Dim Text2 As String
        Dim i, pos
        'Use Text1 to execute a litle faster than Str
        If IsDBNull(Str) Then Exit Function
        Text1 = Str
        ' Iterate through each character of the from Text string
        For i = 0 To Text1.Length - 1
            letter = Text1.Substring(i, 1)
            ' Leave Carriage Return and Line Feed characters as is
            If (letter = vbCr) Then
                Text2 = Text2 & vbCr
            ElseIf (letter = vbLf) Then
                Text2 = Text2 & vbLf
            Else
                ' Find position of character in the vowel list
                pos = InStr(Vowel1, letter, CompareMethod.Binary)
                If pos <= 0 Then
                    ' Not found - so do not map
                    Text2 = Text2 & letter
                Else
                    ' Found - so pick the corresponding character in the other vowel list
                    Text2 = Text2 & Vowel2.Substring(pos + 1, 1)
                End If
            End If
        Next
        StringToString = Text2
    End Function

    Private Function MulticharToUnicode(ByVal UVowels As String, ByVal Str As String) As String
        ' Convert a multi-character vowel in VNI or VIQR to Unicode
        Dim letter As String
        Dim Text1 As String
        Dim Text2 As String
        Dim i, pos, Item, MapNum, TLen
        ' Assign content of input Textbox to Text1
        Text1 = Str
        ' Replace every multi-character vowel in Text1 with a string like |067 that represents
        ' the 67th Unicode vowel
        ' Iterate through every multi-character vowel
        For i = 0 To EncodeVNI.Length - 1
            ' Get an item from the Vowel listbox
            Item = EncodeVNI(i) ' like a^~016
            letter = RTrim(Left(Item, 3)) ' isolate the multi-character vowel eg: a^~
            MapNum = "|" & Right(Item, 3) ' Prefix the | character to the digit string eg: &016
            Text1 = Replace(Text1, letter, MapNum, , , CompareMethod.Binary) ' replace all occurences of the vowel
        Next
        ' Now map the position strings like &016, &114 to 16th and 114th Unicode vowels
        i = 1
        TLen = Len(Text1)
        Do While i <= TLen
            ' get a character
            letter = Mid(Text1, i, 1)
            ' if it's a Carriage return or a LineFeed then just copy across
            If (letter = vbCr) Then
                Text2 = Text2 & vbCr
                i = i + 1
            ElseIf (letter = vbLf) Then
                Text2 = Text2 & vbLf
                i = i + 1
            ElseIf letter <> "|" Then
                ' merely copy across everything else
                Text2 = Text2 & letter
                i = i + 1
            Else
                ' get here if encounter a "&", obtain the position of the Unicode vowel
                ' Note that there'll be a bug if the text string contains genuine "|" character
                pos = Val(Mid(Text1, i + 1, 3))
                If pos = 0 Then
                    Text2 = Text2 & letter
                    i = i + 1
                Else
                    ' get the Unicode vowel for output
                    Text2 = Text2 & UVowels.Substring(pos + 1, 1) 'Mid(UVowels, pos, 1)
                    i = i + 4
                End If
            End If
        Loop
        ' Return the result
        MulticharToUnicode = Text2
    End Function

    Private Sub ConvertVNToUnicode(ByVal Vowels As String, ByVal UVowels As String, ByVal kt As Integer, ByRef dt As DataTable)
        Dim i, j As Integer
        If dt Is Nothing Then
            Thongbao("Không có dữ liệu để chuyển đổi", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                For j = 0 To dt.Columns.Count - 1
                    If kt = 1 Then
                        If Not IsDBNull(dt.Rows(i).Item(j)) And dt.Rows(i).Item(j).GetType.ToString = "System.String" Then
                            dt.Rows(i).Item(j) = StringToString(Vowels, UVowels, dt.Rows(i).Item(j))
                        End If
                    Else
                        If Not IsDBNull(dt.Rows(i).Item(j)) Then
                            dt.Rows(i).Item(j) = MulticharToUnicode(UVowels, dt.Rows(i).Item(j))
                        End If
                    End If
                Next
            Next
            dt.AcceptChanges()
        End If
    End Sub

    Public Function Convert_font(ByVal FontName As String, ByRef dt As DataTable) As Boolean
        If FontName.Trim = "" Then
            Thongbao("Không thể chuyển đổi được font chữ vì không biết tên font")
            Return False
        End If
        Dim FileXML As String = GetLocalDirectory() & "UnicodeVowels.xml"
        Dim f As System.IO.File
        Dim UVowels As String = "", Vowels As String = ""
        Dim myDs As New DataSet
        Dim dtRow As DataRow

        If f.Exists(FileXML) Then
            myDs.ReadXml(FileXML)
            If myDs.Tables.Count > 0 Then
                dtRow = myDs.Tables(0).Rows(0)
                UVowels = dtRow(0).ToString
            End If
        Else
            Thongbao("Không thể chuyển đổi dữ liệu được vì không có file font unicode")
            Return False
        End If

        Select Case FontName
            Case "VPS"
                ' Read the VPS Vowel list
                Vowels = ReadTextFile(GetLocalDirectory() & "VPSVowels.txt")
                ' Convert the Text from VPS to Unicode, using one-to-one look-up
                Call ConvertVNToUnicode(Vowels, UVowels, 1, dt)
            Case "VISCII"
                ' Read the VISCII Vowel list
                Vowels = ReadTextFile(GetLocalDirectory() & "VISCIIVowels.txt")
                ' Convert the Text from VISCII to Unicode, using one-to-one look-up
                Call ConvertVNToUnicode(Vowels, UVowels, 1, dt)
            Case "TCVN"
                ' Read the TCVN Vowel list
                Vowels = ReadTextFile(GetLocalDirectory() & "TCVNVowels.txt")
                ' Convert the Text from TCVN to Unicode, using one-to-one look-up
                Call ConvertVNToUnicode(Vowels, UVowels, 1, dt)
            Case "VNI"
                ' Read the table that maps VNI vowels to position of the corresponding Unicode Vowel
                PopulateListBoxFromFile(GetLocalDirectory() & "VNIVowelMap.txt")
                ' Convert from VNI vowels to Unicode vowels
                Call ConvertVNToUnicode(Vowels, UVowels, 2, dt)
            Case "VIQR"
                ' Read the table that maps VIQR vowels to position of the corresponding Unicode Vowel
                PopulateListBoxFromFile(GetLocalDirectory() & "VIQRVowelMap.txt")
                ' Convert from VIQR vowels to Unicode vowels
                Call ConvertVNToUnicode(Vowels, UVowels, 2, dt)
        End Select
        dt.AcceptChanges()
        Return True
    End Function

    Public Sub Replace_FieldValue(ByVal FieldName As String, ByVal Value1 As String, ByVal Value2 As String, ByRef dt As DataTable)
        If FieldName.Trim = "" Then Exit Sub
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                With dt.Rows(i)
                    .Item(FieldName) = Replace(.Item(FieldName).ToString, Value1, Value2)
                End With
            Next
            dt.AcceptChanges()
        End If
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

    Public Sub getFont(ByVal cmbName As ComboBox)
        cmbName.Items.Add("TCVN")
        cmbName.Items.Add("VNI")
        cmbName.Items.Add("UniCode")
        cmbName.SelectedIndex = 0
    End Sub
    Function Round_Mark_TBC_ToanKhoa(ByVal Diem_TBC_ToanKhoa As Double) As Double
        If Diem_TBC_ToanKhoa > 0 Then
            Dim Diem_Chan As Double = Math.Truncate(Diem_TBC_ToanKhoa)
            Dim Diem_le As Double = Diem_TBC_ToanKhoa - Diem_Chan

            If Diem_le >= 0.95 Then
                Diem_Chan = Diem_Chan + 1
            Else
                Diem_Chan = Diem_TBC_ToanKhoa
            End If
            Return Diem_Chan
        Else
            Return 0
        End If
    End Function

    Function Doc_so(ByVal str As String) As String
        Select Case str
            Case "0" : Return "Không không"
            Case "0.0" : Return "Không không"
            Case "0.1" : Return "Không một"
            Case "0.2" : Return "Không hai"
            Case "0.3" : Return "Không ba"
            Case "0.4" : Return "Không bốn"
            Case "0.5" : Return "Không năm"
            Case "0.6" : Return "Không sáu"
            Case "0.7" : Return "Không bảy"
            Case "0.8" : Return "Không tám"
            Case "0.9" : Return "Không chín"

            Case "1" : Return "Một không"
            Case "1.0" : Return "Mộ không"
            Case "1.1" : Return "Một một"
            Case "1.2" : Return "Một hai"
            Case "1.3" : Return "Một ba"
            Case "1.4" : Return "Một bốn"
            Case "1.5" : Return "Một năm"
            Case "1.6" : Return "Một sáu"
            Case "1.7" : Return "Một bảy"
            Case "1.8" : Return "Một tám"
            Case "1.9" : Return "Một chín"

            Case "2" : Return "Hai không"
            Case "2.0" : Return "Hai không"
            Case "2.1" : Return "Hai một"
            Case "2.2" : Return "Hai hai"
            Case "2.3" : Return "Hai ba"
            Case "2.4" : Return "Hai bốn"
            Case "2.5" : Return "Hai năm"
            Case "2.6" : Return "Hai sáu"
            Case "2.7" : Return "Hai bảy"
            Case "2.8" : Return "Hai tám"
            Case "2.9" : Return "Hai chín"

            Case "3" : Return "Ba không"
            Case "3.0" : Return "Ba không"
            Case "3.1" : Return "Ba một"
            Case "3.2" : Return "Ba hai"
            Case "3.3" : Return "Ba ba"
            Case "3.4" : Return "Ba bốn"
            Case "3.5" : Return "Ba năm"
            Case "3.6" : Return "Ba sáu"
            Case "3.7" : Return "Ba bảy"
            Case "3.8" : Return "Ba tám"
            Case "3.9" : Return "Ba chín"

            Case "4" : Return "Bốn không"
            Case "4.0" : Return "Bốn không"
            Case "4.1" : Return "Bốn một"
            Case "4.2" : Return "Bốn hai"
            Case "4.3" : Return "Bốn ba"
            Case "4.4" : Return "Bốn bốn"
            Case "4.5" : Return "Bốn năm"
            Case "4.6" : Return "Bốn sáu"
            Case "4.7" : Return "Bốn bảy"
            Case "4.8" : Return "Bốn tám"
            Case "4.9" : Return "Bốn chín"

            Case "5" : Return "Năm không"
            Case "5.0" : Return "Năm không"
            Case "5.1" : Return "Năm một"
            Case "5.2" : Return "Năm hai"
            Case "5.3" : Return "Năm ba"
            Case "5.4" : Return "Năm bốn"
            Case "5.5" : Return "Năm năm"
            Case "5.6" : Return "Năm sáu"
            Case "5.7" : Return "Năm bảy"
            Case "5.8" : Return "Năm tám"
            Case "5.9" : Return "Năm chín"

            Case "6" : Return "Sáu không"
            Case "6.0" : Return "Sáu không"
            Case "6.1" : Return "Sáu một"
            Case "6.2" : Return "Sáu hai"
            Case "6.3" : Return "Sáu ba"
            Case "6.4" : Return "Sáu bốn"
            Case "6.5" : Return "Sáu năm"
            Case "6.6" : Return "Sáu sáu"
            Case "6.7" : Return "Sáu bảy"
            Case "6.8" : Return "Sáu tám"
            Case "6.9" : Return "Sáu chín"

            Case "7" : Return "Bẩy không"
            Case "7.0" : Return "Bẩy không"
            Case "7.1" : Return "Bẩy một"
            Case "7.2" : Return "Bẩy hai"
            Case "7.3" : Return "Bẩy ba"
            Case "7.4" : Return "Bẩy bốn"
            Case "7.5" : Return "Bẩy năm"
            Case "7.6" : Return "Bẩy sáu"
            Case "7.7" : Return "Bẩy bảy"
            Case "7.8" : Return "Bẩy tám"
            Case "7.9" : Return "Bẩy chín"

            Case "8" : Return "Tám không"
            Case "8.0" : Return "Tám không"
            Case "8.1" : Return "Tám một"
            Case "8.2" : Return "Tám hai"
            Case "8.3" : Return "Tám ba"
            Case "8.4" : Return "Tám bốn"
            Case "8.5" : Return "Tám năm"
            Case "8.6" : Return "Tám sáu"
            Case "8.7" : Return "Tám bảy"
            Case "8.8" : Return "Tám tám"
            Case "8.9" : Return "Tám chín"

            Case "9" : Return "Chín không"
            Case "9.0" : Return "Chín không"
            Case "9.1" : Return "Chín một"
            Case "9.2" : Return "Chín hai"
            Case "9.3" : Return "Chín ba"
            Case "9.4" : Return "Chín bốn"
            Case "9.5" : Return "Chín năm"
            Case "9.6" : Return "Chín sáu"
            Case "9.7" : Return "Chín bảy"
            Case "9.8" : Return "Chín tám"
            Case "9.9" : Return "Chín chín"

            Case "10" : Return "Mười"
            Case "10.0" : Return "Mười"
        End Select
    End Function
End Module