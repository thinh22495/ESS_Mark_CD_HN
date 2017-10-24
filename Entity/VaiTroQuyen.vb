'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/21/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class VaiTroQuyen
        Inherits Quyen
#Region "Constructor"
#End Region

#Region "Var"
        Private mThem As Integer = 0
        Private mSua As Integer = 0
        Private mXoa As Integer = 0
        Private mVaiTroQuyen As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal VaiTro As VaiTroQuyen)
            mVaiTroQuyen.Add(VaiTro)
        End Sub
        Public Sub Remove(ByVal idx_vai_tro As Integer)
            mVaiTroQuyen.RemoveAt(idx_vai_tro)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mVaiTroQuyen.Count
            End Get
        End Property
        Public Property VaiTroQuyen(ByVal idx As Integer) As VaiTroQuyen
            Get
                Return CType(mVaiTroQuyen(idx), VaiTroQuyen)
            End Get
            Set(ByVal Value As VaiTroQuyen)
                mVaiTroQuyen(idx) = Value
            End Set
        End Property
        Public Property Them() As Integer
            Get
                Return mThem
            End Get
            Set(ByVal Value As Integer)
                mThem = Value
            End Set
        End Property
        Public Property Sua() As Integer
            Get
                Return mSua
            End Get
            Set(ByVal Value As Integer)
                mSua = Value
            End Set
        End Property
        Public Property Xoa() As Integer
            Get
                Return mXoa
            End Get
            Set(ByVal Value As Integer)
                mXoa = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
