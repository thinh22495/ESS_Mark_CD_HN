'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, June 07, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class GioiTinh
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_gioi_tinh As Integer = 0
        Private mGioi_tinh As String = ""
#End Region

#Region "Property"
        Public Property ID_gioi_tinh() As Integer
            Get
                Return mID_gioi_tinh
            End Get
            Set(ByVal Value As Integer)
                mID_gioi_tinh = Value
            End Set
        End Property
        Public Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal Value As String)
                mGioi_tinh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
