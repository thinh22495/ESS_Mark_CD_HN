Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class MonHoc_Re_BLL
        Public Function Load_MonHoc() As DataTable
            Try
                Dim obj As New MonHoc_Re_BLL()
                Return obj.Load_MonHoc()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

