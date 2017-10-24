'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Thursday, August 28, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Nganh
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_nganh As Integer = 0
        Private mMa_nganh As String = ""
        Private mTen_nganh As String = ""
#End Region

#Region "Property"
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
            End Set
        End Property
        Public Property Ma_nganh() As String
            Get
                Return mMa_nganh
            End Get
            Set(ByVal Value As String)
                mMa_nganh = Value
            End Set
        End Property
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
