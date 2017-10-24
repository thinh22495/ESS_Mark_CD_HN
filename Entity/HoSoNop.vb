'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Tuesday, May 27, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class HoSoNop
        Inherits LoaiGiayTo
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mGhi_chu_nop As String = ""
        Private mGhi_chu_tra As String = ""
        Private mDa_tra As Boolean = 0
        Private mNgay_tra As Date = Nothing
#End Region

#Region "Property"
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Ghi_chu_nop() As String
            Get
                Return mGhi_chu_nop
            End Get
            Set(ByVal Value As String)
                mGhi_chu_nop = Value
            End Set
        End Property
        Public Property Ghi_chu_tra() As String
            Get
                Return mGhi_chu_tra
            End Get
            Set(ByVal Value As String)
                mGhi_chu_tra = Value
            End Set
        End Property
        Public Property Da_tra() As Boolean
            Get
                Return mDa_tra
            End Get
            Set(ByVal Value As Boolean)
                mDa_tra = Value
            End Set
        End Property
        Public Property Ngay_tra() As Date
            Get
                Return mNgay_tra
            End Get
            Set(ByVal Value As Date)
                mNgay_tra = Value
            End Set
        End Property        
#End Region

    End Class
End Namespace
