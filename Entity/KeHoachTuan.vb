'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KeHoachTuan
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kh_tuan As Integer = 0
        Private mID_kh As Integer = 0
        Private mTuan_thu As Integer = 0
        Private mTu_ngay As Date
        Private mDen_ngay As Date
#End Region

#Region "Property"
        Public Property ID_kh_tuan() As Integer
            Get
                Return mID_kh_tuan
            End Get
            Set(ByVal Value As Integer)
                mID_kh_tuan = Value
            End Set
        End Property
        Public Property ID_kh() As Integer
            Get
                Return mID_kh
            End Get
            Set(ByVal Value As Integer)
                mID_kh = Value
            End Set
        End Property
        Public Property Tuan_thu() As Integer
            Get
                Return mTuan_thu
            End Get
            Set(ByVal Value As Integer)
                mTuan_thu = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
