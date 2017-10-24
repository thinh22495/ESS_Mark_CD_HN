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
    Public Class DanToc_BLL
        Inherits DanToc

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanToc() As DataTable
            Try
                Dim obj As DanToc_DAL = New DanToc_DAL
                Dim dt As DataTable = obj.Load_DanToc()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanToc(ByVal objDanToc As DanToc) As Integer
            Try
                Dim obj As DanToc_DAL = New DanToc_DAL
                Return obj.Insert_DanToc(objDanToc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanToc(ByVal objDanToc As DanToc, ByVal ID_dan_toc As Integer) As Integer
            Try
                Dim obj As DanToc_DAL = New DanToc_DAL
                Return obj.Update_DanToc(objDanToc, ID_dan_toc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanToc(ByVal ID_dan_toc As Integer) As Integer
            Try
                Dim obj As DanToc_DAL = New DanToc_DAL
                Return obj.Delete_DanToc(ID_dan_toc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanToc As DataRow) As DanToc
            Dim result As DanToc
            Try
                result = New DanToc
                If drDanToc("ID_dan_toc").ToString() <> "" Then result.ID_dan_toc = CType(drDanToc("ID_dan_toc").ToString(), Integer)
                result.Ma_dan_toc = drDanToc("Ma_dan_toc").ToString()
                result.Dan_toc = drDanToc("Dan_toc").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
