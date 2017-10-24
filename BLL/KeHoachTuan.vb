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
    Public Class KeHoachTuan_BLL
        Private arrKeHoachTuan As ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_kh As Integer)
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Dim dt As DataTable = obj.Load_KeHoachTuan_List(ID_kh)
                Dim objsvKeHoachTuan As KeHoachTuan = Nothing
                Dim dr As DataRow = Nothing
                arrKeHoachTuan = New ArrayList
                For Each dr In dt.Rows
                    objsvKeHoachTuan = Converting(dr)
                    arrKeHoachTuan.Add(objsvKeHoachTuan)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrKeHoachTuan.Count
            End Get
        End Property
        Public Property KeHoachTuan(ByVal idx As Integer) As KeHoachTuan
            Get
                Return CType(Me.arrKeHoachTuan(idx), KeHoachTuan)
            End Get
            Set(ByVal Value As KeHoachTuan)
                Me.arrKeHoachTuan(idx) = Value
            End Set
        End Property
        Public Function Load_KeHoachTuan_List(ByVal ID_kh As Integer) As DataTable
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Return obj.Load_KeHoachTuan_List(ID_kh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachTuanChiTiet_List(ByVal ID_kh As Integer, ByVal Hoc_ky As Integer) As DataTable
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Dim dt As DataTable = obj.Load_KeHoachTuanChiTiet_List(ID_kh)
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If Hoc_ky = 1 And dt.Rows(i)("Tuan_thu") > 26 Then
                        dt.Rows(i).Delete()
                    ElseIf Hoc_ky > 1 And dt.Rows(i)("Tuan_thu") <= 26 Then
                        dt.Rows(i).Delete()
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachTuan(ByVal objKeHoachTuan As KeHoachTuan) As Integer
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Return obj.Insert_KeHoachTuan(objKeHoachTuan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachTuan(ByVal objKeHoachTuan As KeHoachTuan, ByVal ID_kh_tuan As Integer) As Integer
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Return obj.Update_KeHoachTuan(objKeHoachTuan, ID_kh_tuan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachTuan(ByVal ID_kh_tuan As Integer) As Integer
            Try
                Dim obj As KeHoachTuan_DAL = New KeHoachTuan_DAL
                Return obj.Delete_KeHoachTuan(ID_kh_tuan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachTuan As DataRow) As KeHoachTuan
            Dim result As KeHoachTuan
            Try
                result = New KeHoachTuan
                If drKeHoachTuan("ID_kh_tuan").ToString() <> "" Then result.ID_kh_tuan = CType(drKeHoachTuan("ID_kh_tuan").ToString(), Integer)
                If drKeHoachTuan("ID_kh").ToString() <> "" Then result.ID_kh = CType(drKeHoachTuan("ID_kh").ToString(), Integer)
                If drKeHoachTuan("Tuan_thu").ToString() <> "" Then result.Tuan_thu = CType(drKeHoachTuan("Tuan_thu").ToString(), Integer)
                If drKeHoachTuan("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drKeHoachTuan("Tu_ngay").ToString(), Date)
                If drKeHoachTuan("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drKeHoachTuan("Den_ngay").ToString(), Date)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
