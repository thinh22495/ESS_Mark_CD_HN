'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Thursday, August 28, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChuyenNganh
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_chuyen_nganh As Integer = 0
        Private mID_nganh As Integer = 0
        Private mMa_chuyen_nganh As String = ""
        Private mChuyen_nganh As String = ""
#End Region

#Region "Property"
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
            End Set
        End Property
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
            End Set
        End Property
        Public Property Ma_chuyen_nganh() As String
            Get
                Return mMa_chuyen_nganh
            End Get
            Set(ByVal Value As String)
                mMa_chuyen_nganh = Value
            End Set
        End Property
        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
