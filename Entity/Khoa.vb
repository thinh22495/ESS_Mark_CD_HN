'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, June 07, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Khoa
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_khoa As Integer = 0
        Private mMa_khoa As String = ""
        Private mTen_khoa As String = ""
#End Region

#Region "Property"
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property
        Public Property Ma_khoa() As String
            Get
                Return mMa_khoa
            End Get
            Set(ByVal Value As String)
                mMa_khoa = Value
            End Set
        End Property
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
