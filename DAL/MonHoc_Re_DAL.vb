Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class MonHoc_Re_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
        Public Function Load_MonHoc() As DataTable
            Try
                Return UDB.SelectTableSP("Load_MonHoc")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
