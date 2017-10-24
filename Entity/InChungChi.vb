Namespace Entity
    Public Class InChungChi
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date = Nothing
        Private mGioi_tinh As String = ""
        Private mTen_tinh As String = ""
        Private mDiem As Double = 0
        Private mXep_loai As String = ""
        Private mSo_hieu As String = ""
        Private mSo_vao_so As String = ""
        Private mTen_cc As String = ""
        Private mChuyen_nganh As String = ""
        Private mTen_lop As String = ""
        Private mTu_ngay As String = ""
        Private mDen_ngay As String = ""
        Private mTu_thang As String = ""
        Private mDen_thang As String = ""
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
        Public Property Ma_sv() As String
            Get
                Return mMa_sv
            End Get
            Set(ByVal Value As String)
                mMa_sv = Value
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
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
                mNgay_sinh = Value
            End Set
        End Property
        Public Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal Value As String)
                mGioi_tinh = Value
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
        Public Property Diem() As String
            Get
                Return mDiem
            End Get
            Set(ByVal Value As String)
                mDiem = Value
            End Set
        End Property
        Public Property Xep_loai() As String
            Get
                Return mXep_loai
            End Get
            Set(ByVal Value As String)
                mXep_loai = Value
            End Set
        End Property
        Public Property So_hieu() As String
            Get
                Return mSo_hieu
            End Get
            Set(ByVal Value As String)
                mSo_hieu = Value
            End Set
        End Property
        Public Property So_vao_so() As String
            Get
                Return mSo_vao_so
            End Get
            Set(ByVal Value As String)
                mSo_vao_so = Value
            End Set
        End Property
        Public Property Ten_cc() As String
            Get
                Return mTen_cc
            End Get
            Set(ByVal Value As String)
                mTen_cc = Value
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
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
            End Set
        End Property
        Public Property Tu_ngay() As String
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As String)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As String
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As String)
                mDen_ngay = Value
            End Set
        End Property
        Public Property Tu_thang() As String
            Get
                Return mTu_thang
            End Get
            Set(ByVal Value As String)
                mTu_thang = Value
            End Set
        End Property
        Public Property Den_thang() As String
            Get
                Return mDen_thang
            End Get
            Set(ByVal Value As String)
                mDen_thang = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
