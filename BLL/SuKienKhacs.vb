'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class SukienKhacs
        Private mSukien As ArrayList
        Public Sub New()
            mSukien = New ArrayList
        End Sub
        Public Sub Add(ByVal sk As Object)
            mSukien.Add(sk)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mSukien.Count
            End Get
        End Property
        Public Property Sukien(ByVal idx As Integer) As Object
            Get
                Return mSukien(idx)
            End Get
            Set(ByVal Value As Object)
                mSukien(idx) = Value
            End Set
        End Property
        Public Property sk_gv(ByVal idx As Integer) As Sukien_gv
            Get
                Return CType(mSukien(idx), Sukien_gv)
            End Get
            Set(ByVal Value As Sukien_gv)
                mSukien(idx) = Value
            End Set
        End Property
        Public Property sk_phong(ByVal idx As Integer) As Sukien_phong
            Get
                Return CType(mSukien(idx), Sukien_phong)
            End Get
            Set(ByVal Value As Sukien_phong)
                mSukien(idx) = Value
            End Set
        End Property
        Public Property sk_lop(ByVal idx As Integer) As Sukien_lop
            Get
                Return CType(mSukien(idx), Sukien_lop)
            End Get
            Set(ByVal Value As Sukien_lop)
                mSukien(idx) = Value
            End Set
        End Property
    End Class
End Namespace