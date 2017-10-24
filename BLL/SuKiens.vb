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
    Public Class Sukiens
        Private mSukien As ArrayList
        Public Sub New()
            mSukien = New ArrayList
        End Sub
        Public Sub Add(ByVal sk As Su_kien)
            mSukien.Add(sk)
        End Sub
        Public Sub Remove(ByVal idx_sk As Integer)
            mSukien.RemoveAt(idx_sk)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mSukien.Count
            End Get
        End Property
        Public Property Sukien(ByVal idx As Integer) As Su_kien
            Get
                Return CType(mSukien(idx), Su_kien)
            End Get
            Set(ByVal Value As Su_kien)
                mSukien(idx) = Value
            End Set
        End Property
    End Class
End Namespace