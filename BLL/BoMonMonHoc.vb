'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Thursday, June 05, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class BoMonMonHoc_BLL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_BoMonMonHoc(ByVal objBoMonMonHoc As BoMonMonHoc) As Integer
            Try
                Dim obj As BoMonMonHoc_DAL = New BoMonMonHoc_DAL
                Return obj.Insert_BoMonMonHoc(objBoMonMonHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BoMonMonHoc(ByVal ID_bm As Integer, ByVal ID_mon As Integer) As Integer
            Try
                Dim obj As BoMonMonHoc_DAL = New BoMonMonHoc_DAL
                Return obj.Delete_BoMonMonHoc(ID_bm, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonMonHoc(ByVal ID_bm As Integer, ByVal ID_mon As Integer) As Boolean
            Try
                Dim obj As BoMonMonHoc_DAL = New BoMonMonHoc_DAL
                Return obj.CheckExist_BoMonMonHoc(ID_bm, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
