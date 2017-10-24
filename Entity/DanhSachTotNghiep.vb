Namespace Entity
    Public Class DanhSachTotNghiep
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region
#Region "Var"
        Private mLan_thu As Integer = 0
        Private mSo_bang As Integer = 0
        Private mDiem_toan_khoa As Double = -1
        Private mTBCHT As Double = -1
        Private mID_xep_loai As Integer = 0
        Private mID_dt As Integer = 0
        Private mXep_hang As String = ""
        Private mNam_hoc As String = ""
        Private mLy_do As String = ""

        Private mChuyen_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mTen_khoa As String = ""
        Private mKhoa_hoc As String = ""
        Private mTen_he As String = ""
        Private mTen_tinh As String = ""
        Private mNien_khoa As String = ""
        Private mGhi_chu As String = ""
#End Region
#Region "Property"
        Public Property Lan_thu() As Integer
            Get
                Return mLan_thu
            End Get
            Set(ByVal Value As Integer)
                mLan_thu = Value
            End Set
        End Property
        Public Property So_bang() As Integer
            Get
                Return mSo_bang
            End Get
            Set(ByVal Value As Integer)
                mSo_bang = Value
            End Set
        End Property
        Public Property Diem_toan_khoa() As Double
            Get
                Return mDiem_toan_khoa
            End Get
            Set(ByVal Value As Double)
                mDiem_toan_khoa = Value
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
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
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
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
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
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
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
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
        Public Property Khoa_hoc() As String
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As String)
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
        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
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