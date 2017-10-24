'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports ESS.Machine
Namespace DBManager
    Public Class Connect_data_DALL
        Function ConnectDatabase(ByVal sConnString As String, ByVal DBType As Integer) As Boolean
            Try
                gDBType = DBType
                UDB.SetConnectionString(sConnString)
                UDB.SetDBType(DBType)
                If UDB.Connected Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


