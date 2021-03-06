'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/15/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DNU_Lop
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer, ByVal ID_lop As Integer, ByVal ID_lop_khoi As Integer, ByVal ID_khoa As Integer, ByVal Ten_lop As String, ByVal Ca_hoc As eCA_HOC, ByVal So_sv As Integer, ByVal Khoi As Boolean, ByVal Ten_phong As String)
            mTKB = New TKB(Ngay_tuan, So_tiet_ngay)
            mID_lop = ID_lop
            mID_lop_khoi = ID_lop_khoi
            mID_khoa = ID_khoa
            mTen_lop = Ten_lop
            mKhoi = Khoi
            mSo_sv = So_sv
            mCa_hoc = Ca_hoc
            mSo_tiet = 0
            mTen_phong = Ten_phong
            mThu = -1
        End Sub
#End Region
#Region "Var"
        Private mID_lop As Integer = 0
        Private mTen_lop As String = ""
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mTen_he As String = ""
        Private mTen_khoa As String = ""
        Private mChuyen_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mNien_khoa As String = ""
        Private mID_dt As Integer = 0
        Private mSo_sv As Integer = 0
        Private mRa_truong As Boolean = 0
        Private mID_nganh As Integer = 0
        Private mID_lop_khoi As Integer
        Private mKhoi As Integer
        Private mCa_hoc As Integer
        Private mID_phong As Integer
        Private mTen_phong As String
        Private mSo_tiet As Integer
        Private mThu As Integer
        Private mTKB As TKB
        Private mHo_ten_GV As String
        Private mDien_thoai As String
        Private mEmail As String
#End Region

#Region "Property"
        Public Property TKB(ByVal thu As Integer, ByVal tiet As Integer) As Integer
            Get
                Return mTKB.TKB(thu, tiet)
            End Get
            Set(ByVal Value As Integer)
                mTKB.TKB(thu, tiet) = Value
            End Set
        End Property
        Public Property Loai_sk(ByVal thu As Integer, ByVal tiet As Integer) As eLOAI_SK
            Get
                Return mTKB.Loai_sk(thu, tiet)
            End Get
            Set(ByVal Value As eLOAI_SK)
                mTKB.Loai_sk(thu, tiet) = Value
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
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
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
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
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
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
            End Set
        End Property
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
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
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
            End Set
        End Property
        Public Property Nien_khoa() As String
            Get
                Return mNien_khoa
            End Get
            Set(ByVal Value As String)
                mNien_khoa = Value
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
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
        Public Property Ra_truong() As Boolean
            Get
                Return mRa_truong
            End Get
            Set(ByVal Value As Boolean)
                mRa_truong = Value
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
        Public Property ID_lop_khoi() As Integer
            Get
                Return Me.mID_lop_khoi
            End Get
            Set(ByVal Value As Integer)
                Me.mID_lop_khoi = Value
            End Set
        End Property
        Public Property Khoi() As Integer
            Get
                Return Me.mKhoi
            End Get
            Set(ByVal Value As Integer)
                Me.mKhoi = Value
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
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal Value As Integer)
                mID_phong = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property

        Public Property Ho_ten_gv() As String
            Get
                Return mHo_ten_GV
            End Get
            Set(ByVal Value As String)
                mHo_ten_GV = Value
            End Set
        End Property
        Public Property Dien_thoai() As String
            Get
                Return mDien_thoai
            End Get
            Set(ByVal Value As String)
                mDien_thoai = Value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return mEmail
            End Get
            Set(ByVal Value As String)
                mEmail = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
