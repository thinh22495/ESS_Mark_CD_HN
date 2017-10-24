'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports ESS.DAL.DBManager
Namespace Business
    Public Class Connect_data_BLL
        Function ConnectDatabase(ByVal sConnString As String, ByVal DBType As Integer) As Boolean
            Try
                Dim obj As New Connect_data_DALL()
                Return obj.ConnectDatabase(sConnString, DBType)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
