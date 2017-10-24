'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class Huyen_BLL
        Inherits Huyen

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_Huyen() As DataTable
            Try
                Dim obj As Huyen_DAL = New Huyen_DAL
                Dim dt As DataTable = obj.Load_Huyen()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Huyen(ByVal objHuyen As Huyen) As Integer
            Try
                Dim obj As Huyen_DAL = New Huyen_DAL
                Return obj.Insert_Huyen(objHuyen)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Huyen(ByVal objHuyen As Huyen, ByVal ID_huyen As Integer) As Integer
            Try
                Dim obj As Huyen_DAL = New Huyen_DAL
                Return obj.Update_Huyen(objHuyen, ID_huyen)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Huyen(ByVal ID_huyen As Integer) As Integer
            Try
                Dim obj As Huyen_DAL = New Huyen_DAL
                Return obj.Delete_Huyen(ID_huyen)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
