Imports System
Imports System.Data

Public Class UCommon

#Region "ConnString"
    Public Shared Function GetBusinessConnString() As String
        Try
            Dim str As String = URegistry.GetReg("ConnectionString").ToString()
            Return str
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function GetSystemConnString() As String
        Try
            Dim str As String = URegistry.GetReg("BusinessConnString").ToString()
            Return str
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "Path"
    Public Shared Current_Path As String = AppDomain.CurrentDomain.BaseDirectory
#End Region

#Region "GUID"
    Public Shared Function GetGUID() As String
        Dim id As Guid = Guid.NewGuid()
        Return id.ToString()
    End Function
#End Region

#Region "Searching"
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As String, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString().ToString(), String)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Integer, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Integer)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Byte, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Byte)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Single, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Single)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Double, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Double)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Long, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Int32)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Searching(ByVal table As DataTable, ByVal FindValue As Int16, ByVal FindCol As String) As Integer
        Try
            Dim idx As Integer
            For idx = 0 To table.Rows.Count - 1
                Dim val As String = CType(table.Rows(idx)(FindCol).ToString(), Int16)
                If val = FindValue Then
                    Return idx
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
#End Region
End Class

