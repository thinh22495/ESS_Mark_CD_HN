'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KehoachMonChiTiet
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kh_mon_ct As Integer = 0
        Private mID_kh_tuan As Integer = 0
        Private mTuan_thu As Integer = 0
        Private mID_kh_mon As Integer = 0
        Private mSo_tiet_ly_thuyet As Integer = 0
        Private mSo_tiet_thuc_hanh As Integer = 0
        Private mPhan_doan As Integer = 0
        Private mGhi_chu As String = ""
#End Region

#Region "Property"
        Public Property ID_kh_mon_ct() As Integer
            Get
                Return mID_kh_mon_ct
            End Get
            Set(ByVal Value As Integer)
                mID_kh_mon_ct = Value
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
        Public Property ID_kh_mon() As Integer
            Get
                Return mID_kh_mon
            End Get
            Set(ByVal Value As Integer)
                mID_kh_mon = Value
            End Set
        End Property
        Public Property So_tiet_ly_thuyet() As Integer
            Get
                Return mSo_tiet_ly_thuyet
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_ly_thuyet = Value
            End Set
        End Property
        Public Property So_tiet_thuc_hanh() As Integer
            Get
                Return mSo_tiet_thuc_hanh
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_thuc_hanh = Value
            End Set
        End Property
        Public Property Phan_doan() As Integer
            Get
                Return mPhan_doan
            End Get
            Set(ByVal Value As Integer)
                mPhan_doan = Value
            End Set
        End Property
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
