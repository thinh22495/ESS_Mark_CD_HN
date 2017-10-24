Imports System.Xml
Imports System.Text
Imports System.Data
Imports System.IO

Public Class ULog
    Private Shared LimitRecs As Integer = 30000

#Region "XML"
    Public Shared Function GetAppFileName() As String
        Dim fn As String = UCommon.Current_Path + "\ApplicationLog.xml"
        fn = fn.Replace("\\", "\")
        Return fn
    End Function
    Private Shared Sub InitAppLog()
        Dim fn As String = GetAppFileName()
        If Not File.Exists(fn) Then
            Dim dt As New DataTable("AppplicationLog")
            dt.Columns.Add("Date", GetType(String))
            dt.Columns.Add("User", GetType(String))
            dt.Columns.Add("Info", GetType(String))

            Dim ds As New DataSet("ApplicationLog")
            ds.Tables.Add(dt)
            ds.WriteXmlSchema(fn)
        End If
    End Sub
    Public Shared Sub WriteAppLog(ByVal user As String, ByVal Info As String, Optional ByVal thisDate As Date = #1/1/1000#)
        Dim fn As String = GetAppFileName()
        Try
            Dim dt As DataTable = ReadAppLog()
            If dt Is Nothing Then
                Throw New Exception("Không tìm thấy file : " + fn)
            End If

            Dim dr As DataRow = dt.NewRow()
            If thisDate = #1/1/1000# Then thisDate = Now
            dr("Date") = thisDate.ToString()
            dr("User") = user
            dr("Info") = Info
            dt.Rows.Add(dr)

            Dim ds As DataSet = dt.DataSet
            ds.WriteXml(fn)
            ' Khi số lượng bản ghi là quá lớn để giảm
            ' tải cho việc đọc và ghi chúng ta ghi nó 
            ' vào một file back up khác
            If dt.Rows.Count >= LimitRecs Then
                Dim nfn As String = UCommon.Current_Path + "AppLog-" + Now.ToLongDateString() _
                    + " " + Now.Hour.ToString() + "-" + Now.Minute.ToString() _
                    + "-" + Now.Second.ToString() + "-Backup.xml"
                System.IO.File.Copy(fn, nfn)
                System.IO.File.Delete(fn)
                InitAppLog()
            End If

        Catch ex As Exception
            Throw New Exception("Không thể ghi được vào file : " + fn)
        End Try
    End Sub
    Public Shared Function ReadAppLog() As DataTable
        Dim fn As String = GetAppFileName()
        Try
            Dim ds As New DataSet("ApplicationLog")
            If Not System.IO.File.Exists(fn) Then
                InitAppLog()
            End If
            ds.ReadXml(fn)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("Không tìm thấy file : " + fn)
        End Try
        Return Nothing
    End Function
    Public Shared Function GetSysFileName() As String
        Dim fn As String = UCommon.Current_Path + "\SystemLog.xml"
        fn = fn.Replace("\\", "\")
        Return fn
    End Function
    Private Shared Sub InitSysLog()
        Dim fn As String = GetSysFileName()
        If Not File.Exists(fn) Then
            Dim dt As New DataTable("SystemLog")
            dt.Columns.Add("Date", GetType(String))
            dt.Columns.Add("User", GetType(String))
            dt.Columns.Add("Info", GetType(String))

            Dim ds As New DataSet("SystemLog")
            ds.Tables.Add(dt)
            ds.WriteXmlSchema(fn)
        End If
    End Sub
    Public Shared Sub WriteSysLog(ByVal user As String, ByVal Info As String, Optional ByVal thisDate As Date = #1/1/1000#)
        Dim fn As String = GetSysFileName()
        Try
            Dim dt As DataTable = ReadSysLog()
            If dt Is Nothing Then
                Throw New Exception("Không tìm thấy file : " + fn)
            End If

            Dim dr As DataRow = dt.NewRow()
            If thisDate = #1/1/1000# Then thisDate = Now
            dr("Date") = thisDate.ToString()
            dr("User") = user
            dr("Info") = Info
            dt.Rows.Add(dr)

            Dim ds As DataSet = dt.DataSet
            ds.WriteXml(fn)
            ' Khi số lượng bản ghi là quá lớn để giảm
            ' tải cho việc đọc và ghi chúng ta ghi nó 
            ' vào một file back up khác
            If dt.Rows.Count >= LimitRecs Then
                Dim nfn As String = UCommon.Current_Path + "AppLog-" + Now.ToLongDateString() _
                    + " " + Now.Hour.ToString() + "-" + Now.Minute.ToString() _
                    + "-" + Now.Second.ToString() + "-Backup.xml"
                System.IO.File.Copy(fn, nfn)
                System.IO.File.Delete(fn)
                InitSysLog()
            End If

        Catch ex As Exception
            Throw New Exception("Không thể ghi được vào file : " + fn)
        End Try
    End Sub
    Public Shared Function ReadSysLog() As DataTable
        Dim fn As String = GetSysFileName()
        Try
            Dim ds As New DataSet("SystemLog")
            If Not System.IO.File.Exists(fn) Then
                InitSysLog()
            End If
            ds.ReadXml(fn)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("Không tìm thấy file : " + fn)
        End Try
        Return Nothing
    End Function
    Public Shared Function GetDBFileName() As String
        Dim fn As String = UCommon.Current_Path + "\DataBaseLog.xml"
        fn = fn.Replace("\\", "\")
        Return fn
    End Function
    Private Shared Sub InitDBLog()
        Dim fn As String = GetDBFileName()
        If Not File.Exists(fn) Then
            Dim dt As New DataTable("DataBaseLog")
            dt.Columns.Add("Date", GetType(String))
            dt.Columns.Add("User", GetType(String))
            dt.Columns.Add("Info", GetType(String))

            Dim ds As New DataSet("DataBaseLog")
            ds.Tables.Add(dt)
            ds.WriteXmlSchema(fn)
        End If
    End Sub
    Public Shared Sub WriteDBLog(ByVal user As String, ByVal Info As String, Optional ByVal thisDate As Date = #1/1/1000#)
        Dim fn As String = GetDBFileName()
        Try
            Dim dt As DataTable = ReadDBLog()
            If dt Is Nothing Then
                Throw New Exception("Không tìm thấy file : " + fn)
            End If

            Dim dr As DataRow = dt.NewRow()
            If thisDate = #1/1/1000# Then thisDate = Now
            dr("Date") = thisDate.ToString()
            dr("User") = user
            dr("Info") = Info
            dt.Rows.Add(dr)

            Dim ds As DataSet = dt.DataSet
            ds.WriteXml(fn)
            ' Khi số lượng bản ghi là quá lớn để giảm
            ' tải cho việc đọc và ghi chúng ta ghi nó 
            ' vào một file back up khác
            If dt.Rows.Count >= LimitRecs Then
                Dim nfn As String = UCommon.Current_Path + "AppLog-" + Now.ToLongDateString() _
                    + " " + Now.Hour.ToString() + "-" + Now.Minute.ToString() _
                    + "-" + Now.Second.ToString() + "-Backup.xml"
                System.IO.File.Copy(fn, nfn)
                System.IO.File.Delete(fn)
                InitDBLog()
            End If

        Catch ex As Exception
            Throw New Exception("Không thể ghi được vào file : " + fn)
        End Try
    End Sub
    Public Shared Function ReadDBLog() As DataTable
        Dim fn As String = GetDBFileName()
        Try
            Dim ds As New DataSet("DataBaseLog")
            If Not System.IO.File.Exists(fn) Then
                InitDBLog()
            End If
            ds.ReadXml(fn)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("Không tìm thấy file : " + fn)
        End Try
        Return Nothing
    End Function
    Public Shared Function GetErrFileName() As String
        Dim fn As String = UCommon.Current_Path + "\ErrorLog.xml"
        fn = fn.Replace("\\", "\")
        Return fn
    End Function
    Private Shared Sub InitErrLog()
        Dim fn As String = GetErrFileName()
        If Not File.Exists(fn) Then
            Dim dt As New DataTable("ErrorLog")
            dt.Columns.Add("Date", GetType(String))
            dt.Columns.Add("User", GetType(String))
            dt.Columns.Add("Info", GetType(String))

            Dim ds As New DataSet("ErrorLog")
            ds.Tables.Add(dt)
            ds.WriteXmlSchema(fn)
        End If
    End Sub
    Public Shared Sub WriteErrLog(ByVal user As String, ByVal Info As String, Optional ByVal thisDate As Date = #1/1/1000#)
        Dim fn As String = GetDBFileName()
        Try
            Dim dt As DataTable = ReadErrLog()
            If dt Is Nothing Then
                Throw New Exception("Không tìm thấy file : " + fn)
            End If

            Dim dr As DataRow = dt.NewRow()
            If thisDate = #1/1/1000# Then thisDate = Now
            dr("Date") = thisDate.ToString()
            dr("User") = user
            dr("Info") = Info
            dt.Rows.Add(dr)

            Dim ds As DataSet = dt.DataSet
            ds.WriteXml(fn)
            ' Khi số lượng bản ghi là quá lớn để giảm
            ' tải cho việc đọc và ghi chúng ta ghi nó 
            ' vào một file back up khác
            If dt.Rows.Count >= LimitRecs Then
                Dim nfn As String = UCommon.Current_Path + "AppLog-" + Now.ToLongDateString() _
                    + " " + Now.Hour.ToString() + "-" + Now.Minute.ToString() _
                    + "-" + Now.Second.ToString() + "-Backup.xml"
                System.IO.File.Copy(fn, nfn)
                System.IO.File.Delete(fn)
                InitDBLog()
            End If

        Catch ex As Exception
            Throw New Exception("Không thể ghi được vào file : " + fn)
        End Try
    End Sub
    Public Shared Function ReadErrLog() As DataTable
        Dim fn As String = GetErrFileName()
        Try
            Dim ds As New DataSet("DataBaseLog")
            If Not System.IO.File.Exists(fn) Then
                InitDBLog()
            End If
            ds.ReadXml(fn)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("Không tìm thấy file : " + fn)
        End Try
        Return Nothing
    End Function
#End Region

#Region "Text"
#End Region

End Class
