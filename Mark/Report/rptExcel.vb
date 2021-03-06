Imports DevExpress.XtraReports.UI

Public Class rptExcel
    Dim _dt As DataTable
    Dim _width As Integer = 0
    Public Sub New(ByVal dt As DataTable, Optional ByVal listCaption As List(Of String) = Nothing)
        InitializeComponent()
        Me.DataSource = dt.DefaultView
        Me._dt = dt
        Me._width = DetailCell.WidthF
        For i As Integer = 0 To dt.Columns.Count - 1
            WriteHeader(listCaption(i))
            WriteDetail(dt.Columns(i).ColumnName.ToString)
        Next
        Binding()
    End Sub
    Public Sub Binding()
        For j As Integer = _dt.Columns.Count - 1 To 0 Step -1
            Dim cell = DetailCell
            For k As Integer = 0 To _dt.Columns.Count - j - 1
                cell = cell.PreviousCell
            Next
            If _dt.Columns(j).DataType.Name = "DateTime" Then
                cell.DataBindings.Add("Text", DataSource, _dt.Columns(j).ColumnName, "{0:dd/MM/yyy}")
            Else
                cell.DataBindings.Add("Text", DataSource, _dt.Columns(j).ColumnName)
            End If

        Next
    End Sub
    Public Sub WriteHeader(ByVal headerText As String)
        Header.InsertColumnToLeft(HeaderCell)
        HeaderCell.PreviousCell.Text = headerText
        HeaderCell.PreviousCell.WidthF = _width / (_dt.Columns.Count + 1)
    End Sub
    Public Sub WriteDetail(Optional ByVal name As String = "")
        DetailReport.InsertColumnToLeft(DetailCell)
        DetailCell.PreviousCell.Name = name
        DetailCell.PreviousCell.WidthF = _width / (_dt.Columns.Count + 1)
    End Sub
End Class