Imports System
Namespace Entity
    Public Class DanhSachLuanVanThiNoTotNghiep
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mTBCHT As Double = 0
        Private mLan_xet As Integer = 0
        Private mID_xep_loai As Integer = 0
        Private mSo_hoc_trinh As Integer = 0
        Private mLy_do As String = ""
        Private mXep_hang As String = ""
        Private mSo_mon_no As Integer
#End Region

#Region "Property"
        Public Property TBCHT() As Double
            Get
                Return mTBCHT
            End Get
            Set(ByVal Value As Double)
                mTBCHT = Value
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
        Public Property So_hoc_trinh() As Integer
            Get
                Return mSo_hoc_trinh
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh = Value
            End Set
        End Property

        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
            End Set
        End Property
        Public Property So_mon_no() As Integer
            Get
                Return mSo_mon_no
            End Get
            Set(ByVal Value As Integer)
                mSo_mon_no = Value
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

        Public Property Lan_xet() As Integer
            Get
                Return mLan_xet
            End Get
            Set(ByVal Value As Integer)
                mLan_xet = Value
            End Set
        End Property
#End Region

    End Class
End Namespace