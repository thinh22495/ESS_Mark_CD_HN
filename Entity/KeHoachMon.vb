'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KeHoachMon
        Inherits ChuongTrinhDaoTaoChiTiet
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kh_mon As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_lop As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mSo_top As Integer = 0
        Private mID_cb As Integer = 0
        Private mHo_ten As String = ""
        Private mTen_lop As String = ""
        Private mSo_sv As Integer = 0
        Private mCa_hoc As Integer = -1
        Private mThoi_gian As String = ""
#End Region

#Region "Property"
        Public Property ID_kh_mon() As Integer
            Get
                Return mID_kh_mon
            End Get
            Set(ByVal Value As Integer)
                mID_kh_mon = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
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
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
            End Set
        End Property
        Public Property So_top() As Integer
            Get
                Return mSo_top
            End Get
            Set(ByVal Value As Integer)
                mSo_top = Value
            End Set
        End Property
        Public Property ID_cb() As Integer
            Get
                Return mID_cb
            End Get
            Set(ByVal Value As Integer)
                mID_cb = Value
            End Set
        End Property
        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal Value As String)
                mHo_ten = Value
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
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
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
        Public Property Thoi_gian() As String
            Get
                Return mThoi_gian
            End Get
            Set(ByVal Value As String)
                mThoi_gian = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
