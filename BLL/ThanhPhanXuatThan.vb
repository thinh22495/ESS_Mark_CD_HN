'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ThanhPhanXuatThan_BLL
        Inherits ThanhPhanXuatThan

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        ' Load Danh mục Tỉnh
        Public Function Load_ThanhPhanXuatThan() As DataTable
            Try
                Dim obj As ThanhPhanXuatThan_DAL = New ThanhPhanXuatThan_DAL
                Dim dt As DataTable = obj.Load_ThanhPhanXuatThan()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
