'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, April 21, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Tinh
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_tinh As String = ""
        Private mTen_tinh As String = ""
#End Region

#Region "Property"
        Public Property ID_tinh() As String
            Get
                Return mID_tinh
            End Get
            Set(ByVal Value As String)
                mID_tinh = Value
            End Set
        End Property
        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
