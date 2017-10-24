'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------
Imports System
Namespace Entity
    Public Class GiaoVienMonDay
        Inherits MonHoc
        Private mMonHoc As New ArrayList
        Public Sub Add(ByVal mh As MonHoc)
            mMonHoc.Add(mh)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mMonHoc.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mMonHoc.Count
            End Get
        End Property
        Public Property MonDay(ByVal idx As Integer) As MonHoc
            Get
                Return CType(mMonHoc(idx), MonHoc)
            End Get
            Set(ByVal Value As MonHoc)
                mMonHoc(idx) = Value
            End Set
        End Property
    End Class
End Namespace