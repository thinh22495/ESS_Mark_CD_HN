'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ReportView_BLL
        Public Function LoadReportNote(ByVal ReportName As String) As String
            Dim ReportNote As String = ""
            Dim objReport As New ReportView_DAL
            'Load nội dung báo cáo
            Dim dt As DataTable = objReport.Load_Report_Note(ReportName)
            'Lấy nội dung báo cáo
            If dt.Rows.Count > 0 Then
                ReportNote = dt.Rows(0).Item("ReportNote")
            End If
            Return ReportNote
        End Function
        Public Function GetReport(ByVal ReportName As String) As DataTable
            Dim objReport As New ReportView_DAL
            'Load nội dung báo cáo
            Dim dt As DataTable = objReport.Load_Report_Note(ReportName)
            Return dt
        End Function

    End Class
End Namespace
