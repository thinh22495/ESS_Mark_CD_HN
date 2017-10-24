'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KeHoachKyHieu_BLL
        Private arrKeHoachKyHieu As ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As KeHoachKyHieu_DAL = New KeHoachKyHieu_DAL
                Dim dt As DataTable = obj.Load_KeHoachKyHieu_List()
                Dim objsvKeHoachKyHieu As KeHoachKyHieu = Nothing
                Dim dr As DataRow = Nothing
                arrKeHoachKyHieu = New ArrayList
                For Each dr In dt.Rows
                    objsvKeHoachKyHieu = Converting(dr)
                    arrKeHoachKyHieu.Add(objsvKeHoachKyHieu)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrKeHoachKyHieu.Count
            End Get
        End Property
        Public Property KeHoachKyHieu(ByVal idx As Integer) As KeHoachKyHieu
            Get
                Return CType(Me.arrKeHoachKyHieu(idx), KeHoachKyHieu)
            End Get
            Set(ByVal Value As KeHoachKyHieu)
                Me.arrKeHoachKyHieu(idx) = Value
            End Set
        End Property
        Public Function Insert_KeHoachKyHieu(ByVal objKeHoachKyHieu As KeHoachKyHieu) As Integer
            Try
                Dim obj As KeHoachKyHieu_DAL = New KeHoachKyHieu_DAL
                Return obj.Insert_KeHoachKyHieu(objKeHoachKyHieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachKyHieu(ByVal objKeHoachKyHieu As KeHoachKyHieu, ByVal ID_ky_hieu As Integer) As Integer
            Try
                Dim obj As KeHoachKyHieu_DAL = New KeHoachKyHieu_DAL
                Return obj.Update_KeHoachKyHieu(objKeHoachKyHieu, ID_ky_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachKyHieu(ByVal ID_ky_hieu As Integer) As Integer
            Try
                Dim obj As KeHoachKyHieu_DAL = New KeHoachKyHieu_DAL
                Return obj.Delete_KeHoachKyHieu(ID_ky_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachKyHieu As DataRow) As KeHoachKyHieu
            Dim result As KeHoachKyHieu
            Try
                result = New KeHoachKyHieu
                If drKeHoachKyHieu("ID_ky_hieu").ToString() <> "" Then result.ID_ky_hieu = CType(drKeHoachKyHieu("ID_ky_hieu").ToString(), Integer)
                result.Ky_hieu = drKeHoachKyHieu("Ky_hieu").ToString()
                result.Ten_ky_hieu = drKeHoachKyHieu("Ten_ky_hieu").ToString()
                If drKeHoachKyHieu("bgColor").ToString() <> "" Then result.bgColor = CType(drKeHoachKyHieu("bgColor").ToString(), Integer)
                If drKeHoachKyHieu("txtColor").ToString() <> "" Then result.txtColor = CType(drKeHoachKyHieu("txtColor").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
