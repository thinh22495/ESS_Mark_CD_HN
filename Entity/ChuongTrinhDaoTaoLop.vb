'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChuongTrinhDaoTaoLop
        Inherits Lop
#Region "Var"
        Private mChuongTrinhDaoTaoLop As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal l As Lop)
            mChuongTrinhDaoTaoLop.Add(l)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoLop.RemoveAt(idx)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoLop.Count
            End Get
        End Property
        Public Property ChuongTrinhDaoTaoLop(ByVal idx As Integer) As Lop
            Get
                Return CType(mChuongTrinhDaoTaoLop(idx), Lop)
            End Get
            Set(ByVal Value As Lop)
                mChuongTrinhDaoTaoLop(idx) = Value
            End Set
        End Property
        Public Function Tim_idx(ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To mChuongTrinhDaoTaoLop.Count - 1
                If CType(mChuongTrinhDaoTaoLop(i), Lop).ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace