'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KeHoachKyHieu
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_ky_hieu As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_ky_hieu As String = ""
        Private mbgColor As Integer = 0
        Private mtxtColor As Integer = 0
#End Region

#Region "Property"
        Public Property ID_ky_hieu() As Integer
            Get
                Return mID_ky_hieu
            End Get
            Set(ByVal Value As Integer)
                mID_ky_hieu = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_ky_hieu() As String
            Get
                Return mTen_ky_hieu
            End Get
            Set(ByVal Value As String)
                mTen_ky_hieu = Value
            End Set
        End Property
        Public Property bgColor() As Integer
            Get
                Return mbgColor
            End Get
            Set(ByVal Value As Integer)
                mbgColor = Value
            End Set
        End Property
        Public Property txtColor() As Integer
            Get
                Return mtxtColor
            End Get
            Set(ByVal Value As Integer)
                mtxtColor = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
