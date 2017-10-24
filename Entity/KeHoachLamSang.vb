'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, July 24, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KeHoachLamSang
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kh_ls As Integer = 0
        Private mID_kh_mon As Integer = 0
        Private mID_bm As Integer = 0
        Private mNhom As Integer = 0
        Private mTu_tuan As Integer = 0
        Private mDen_tuan As Integer = 0
        Private mCa_hoc As Integer = 0
        Private mTen_lop As String = ""
#End Region

#Region "Property"
        Public Property ID_kh_ls() As Integer
            Get
                Return mID_kh_ls
            End Get
            Set(ByVal Value As Integer)
                mID_kh_ls = Value
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
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
        Public Property Nhom() As Integer
            Get
                Return mNhom
            End Get
            Set(ByVal Value As Integer)
                mNhom = Value
            End Set
        End Property
        Public Property Tu_tuan() As Integer
            Get
                Return mTu_tuan
            End Get
            Set(ByVal Value As Integer)
                mTu_tuan = Value
            End Set
        End Property
        Public Property Den_tuan() As Integer
            Get
                Return mDen_tuan
            End Get
            Set(ByVal Value As Integer)
                mDen_tuan = Value
            End Set
        End Property
        Public Property Ca_hoc() As Integer
            Get
                Return mCa_hoc
            End Get
            Set(ByVal Value As Integer)
                mCa_hoc = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
