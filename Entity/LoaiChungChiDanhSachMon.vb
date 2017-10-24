Imports System
Namespace Entity
    Public Class LoaiChungChiDanhSachMon
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_chung_chi As Integer = 0
        Private mID_mon As Integer = 0
        Private mID_dt As Integer = 0
        Private mID_mon1 As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_mon As String = ""
        Private mTen_tieng_anh As String = ""
        Private mID_bm As Integer = 0
        Private mID_he_dt As Integer = 0
        Private mID_nhom_hp As Integer = 0
        Private mLan_xet As Integer = 0
        Private mID_xep_loai As Integer = 0
        Private mXep_hang As String = ""
        Private mTBCHT As Double = 0
#End Region

#Region "Property"
        Public Property ID_chung_chi() As Integer
            Get
                Return mID_chung_chi
            End Get
            Set(ByVal Value As Integer)
                mID_chung_chi = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property ID_mon1() As Integer
            Get
                Return mID_mon1
            End Get
            Set(ByVal Value As Integer)
                mID_mon1 = Value
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
        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal Value As String)
                mTen_mon = Value
            End Set
        End Property
        Public Property Ten_tieng_anh() As String
            Get
                Return mTen_tieng_anh
            End Get
            Set(ByVal Value As String)
                mTen_tieng_anh = Value
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
        Public Property ID_he_dt() As Integer
            Get
                Return mID_he_dt
            End Get
            Set(ByVal Value As Integer)
                mID_he_dt = Value
            End Set
        End Property
        Public Property ID_nhom_hp() As Integer
            Get
                Return mID_nhom_hp
            End Get
            Set(ByVal Value As Integer)
                mID_nhom_hp = Value
            End Set
        End Property

        Public Property Lan_xet() As Integer
            Get
                Return mLan_xet
            End Get
            Set(ByVal Value As Integer)
                mLan_xet = Value
            End Set
        End Property
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
            End Set
        End Property
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
            End Set
        End Property
        Public Property TBCHT() As Double
            Get
                Return mTBCHT
            End Get
            Set(ByVal Value As Double)
                mTBCHT = Value
            End Set
        End Property
#End Region
    End Class
End Namespace