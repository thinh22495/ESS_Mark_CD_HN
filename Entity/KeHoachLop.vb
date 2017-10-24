'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KeHoachLop
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kh_lop As Integer = 0
        Private mID_kh_tuan As Integer = 0
        Private mTuan_thu As Integer = 0
        Private mID_lop As Integer = 0
        Private mID_ky_hieu As Integer = 0
        Private mKy_hieu As String = ""
#End Region

#Region "Property"
        Public Property ID_kh_lop() As Integer
            Get
                Return mID_kh_lop
            End Get
            Set(ByVal Value As Integer)
                mID_kh_lop = Value
            End Set
        End Property
        Public Property ID_kh_tuan() As Integer
            Get
                Return mID_kh_tuan
            End Get
            Set(ByVal Value As Integer)
                mID_kh_tuan = Value
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
        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal Value As Integer)
                mID_lop = Value
            End Set
        End Property
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
#End Region
    End Class
End Namespace
