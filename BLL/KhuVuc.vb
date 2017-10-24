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
    Public Class KhuVuc_BLL
        Inherits KhuVuc

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        ' Load Danh mục Tỉnh
        Public Function Load_KhuVuc() As DataTable
            Try
                Dim obj As KhuVuc_DAL = New KhuVuc_DAL
                Dim dt As DataTable = obj.Load_KhuVuc()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function        
        Public Function Insert_KhuVuc(ByVal objKhuVuc As KhuVuc) As Integer
            Try
                Dim obj As KhuVuc_DAL = New KhuVuc_DAL
                Return obj.Insert_KhuVuc(objKhuVuc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhuVuc(ByVal objKhuVuc As KhuVuc, ByVal ID_kv As Integer) As Integer
            Try
                Dim obj As KhuVuc_DAL = New KhuVuc_DAL
                Return obj.Update_KhuVuc(objKhuVuc, ID_kv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhuVuc(ByVal ID_kv As Integer) As Integer
            Try
                Dim obj As KhuVuc_DAL = New KhuVuc_DAL
                Return obj.Delete_KhuVuc(ID_kv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
