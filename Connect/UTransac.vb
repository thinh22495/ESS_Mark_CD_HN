Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class UTransac
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private myTrans As SqlTransaction

    Public Sub New()
        Try
            conn = New SqlConnection(UDB.ConnectionString)
            conn.Open()

            cmd = New SqlCommand
            cmd.Connection = conn

        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal strConnection As String)
        Try
            conn = New SqlConnection(strConnection)
            conn.Open()

            cmd = New SqlCommand
            cmd.Connection = conn

            myTrans = conn.BeginTransaction()
            cmd.Transaction = myTrans
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub BeginTransaction()
        myTrans = conn.BeginTransaction()
        cmd.Transaction = myTrans
    End Sub

    Public Sub Execute(ByVal strSQL As String)
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            cmd.ExecuteNonQuery()
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Execute(ByVal strSQL As String, ByVal param As SqlParameter)
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            If param.Value Is Nothing Then
                param.Value = DBNull.Value
            End If
            cmd.Parameters.Add(param)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Execute(ByVal strSQL As String, ByVal param() As SqlParameter)
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            Dim i As Integer
            For i = 0 To param.Length - 2
                If param(i).Value Is Nothing Then
                    param(i).Value = DBNull.Value
                End If
                cmd.Parameters.Add(param(i))
            Next
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Commit()
        Try
            myTrans.Commit()
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Rollback()
        Try
            myTrans.Rollback()
        Catch se As SqlException
            Throw New Exception(se.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        conn.Close()
    End Sub

    Public Sub Dispose()
        conn.Dispose()
        cmd.Dispose()
    End Sub
End Class
