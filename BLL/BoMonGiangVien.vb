'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, June 05, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class BoMonGiangVIen_BLL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_BoMonGiangVien(ByVal objBoMonGiangVien As BoMonGiangVien) As Integer
            Try
                Dim obj As BoMonGiangVien_DAL = New BoMonGiangVien_DAL
                Return obj.Insert_BoMonGiangVien(objBoMonGiangVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As BoMonGiangVien_DAL = New BoMonGiangVien_DAL
                Return obj.Delete_BoMonGiangVien(ID_bm, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Boolean
            Try
                Dim obj As BoMonGiangVien_DAL = New BoMonGiangVien_DAL
                Return obj.CheckExist_BoMonGiangVien(ID_bm, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
