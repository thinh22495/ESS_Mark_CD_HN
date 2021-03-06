Imports System
Namespace Entity
    Public Class DanhSachSinhVien
#Region "Var"
        Private mLock As Boolean = False
        Private mTrang_thai_hoc As Integer = 1
        Private mID_sv As Integer = 0
        Private mID_lop As Integer = 0
        Private mID_dt1 As Integer = 0
        Private mID_dt2 As Integer = 0
        Private mID_he As Integer = 0
        Private mID_gioi_tinh As Integer = 0
        Private mMa_sv As String = ""
        Private mID_svs As String = ""
        Private mHo_ten As String = ""
        Private mTen_tinh As String = ""
        Private mHo_dem As String = ""
        Private mVan_dau As String = ""
        Private mTen As String = ""
        Private mNgay_sinh As Date = Nothing
        Private mGioi_tinh As String = ""
        Private mNoi_sinh As String = ""
        Private mTen_lop As String = ""
        Private mNien_khoa As String = ""
        Private mMat_khau As String = ""
        Private mActive As Boolean = False
        Private mQuy_che As Integer = 25
        Private mDa_tot_nghiep As Boolean = False
        Private mQuy As Boolean = False
        Private mNgoai_ngan_sach As Boolean = 0
        Private mID_doi_tuong_TC As Integer = 0
        Private mID_doi_tuong_TS As Integer = 0
        Private mdia_chi_tt As String = ""
        Private mTong_diem As Double = 0
        Private mSbd As String = ""
        Private mTen_khoa As String = ""
        Private mTen_he As String = ""
        Private mTen_nganh As String = ""
        Private mChuyen_nganh As String = ""
        Private mKhoa_hoc As Integer = 0
        Private mNam_thu As Integer = 0
        Private mCMND As String = ""
        Private mQue_quan As String = ""
        Private mNoi_cap As String = ""
        Private mNgay_cap As Date = Nothing
        Private mNgay_nhap_hoc As Date = Nothing
        Private mTen_he_en As String = ""
        Private mSo_hieu As String = ""
        Private mSo_vao_so As String = ""
        Private mSo_QD As String = ""
        Private mNgay_QD As Date = Nothing
        Private mLoai_dao_tao As String = ""
        Private mLoai_dao_tao_en As String = ""
        Private mTrinh_do As String = ""
        Private mVan_hoa As Boolean = False
        Private mTrang_thai As Integer = 0
#End Region

#Region "Property"
        Public Property Trang_thai_hoc() As Integer
            Get
                Return mTrang_thai_hoc
            End Get
            Set(ByVal Value As Integer)
                mTrang_thai_hoc = Value
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
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
        Public Property Noi_cap() As String
            Get
                Return mNoi_cap
            End Get
            Set(ByVal Value As String)
                mNoi_cap = Value
            End Set
        End Property
        Public Property CMND() As String
            Get
                Return mCMND
            End Get
            Set(ByVal Value As String)
                mCMND = Value
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
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
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
        Public Property ID_doi_tuong_TS() As Integer
            Get
                Return mID_doi_tuong_TS
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TS = Value
            End Set
        End Property
        Public Property ID_doi_tuong_TC() As Integer
            Get
                Return mID_doi_tuong_TC
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TC = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Lock() As Boolean
            Get
                Return mLock
            End Get
            Set(ByVal Value As Boolean)
                mLock = Value
            End Set
        End Property
        Public Property Nam_thu() As Integer
            Get
                Return mNam_thu
            End Get
            Set(ByVal Value As Integer)
                mNam_thu = Value
            End Set
        End Property
        Public Property ID_gioi_tinh() As Integer
            Get
                Return mID_gioi_tinh
            End Get
            Set(ByVal Value As Integer)
                mID_gioi_tinh = Value
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
        Public Property ID_dt1() As Integer
            Get
                Return mID_dt1
            End Get
            Set(ByVal Value As Integer)
                mID_dt1 = Value
            End Set
        End Property
        Public Property ID_dt2() As Integer
            Get
                Return mID_dt2
            End Get
            Set(ByVal Value As Integer)
                mID_dt2 = Value
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
        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
            End Set
        End Property
        Public Property Ho_dem() As String
            Get
                Return mHo_dem
            End Get
            Set(ByVal Value As String)
                mHo_dem = Value
            End Set
        End Property
        Public Property Van_dau() As String
            Get
                Return mVan_dau
            End Get
            Set(ByVal Value As String)
                mVan_dau = Value
            End Set
        End Property
        Public Property Ten() As String
            Get
                Return mTen
            End Get
            Set(ByVal Value As String)
                mTen = Value
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
        Public Property Noi_sinh() As String
            Get
                Return mNoi_sinh
            End Get
            Set(ByVal Value As String)
                mNoi_sinh = Value
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
        Public Property Mat_khau() As String
            Get
                Return mMat_khau
            End Get
            Set(ByVal Value As String)
                mMat_khau = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return mActive
            End Get
            Set(ByVal Value As Boolean)
                mActive = Value
            End Set
        End Property
        Public Property Quy_che() As Integer
            Get
                Return mQuy_che
            End Get
            Set(ByVal Value As Integer)
                mQuy_che = Value
            End Set
        End Property
        Public Property Da_tot_nghiep() As Boolean
            Get
                Return mDa_tot_nghiep
            End Get
            Set(ByVal Value As Boolean)
                mDa_tot_nghiep = Value
            End Set
        End Property
        Public Property Ngoai_ngan_sach() As Boolean
            Get
                Return mNgoai_ngan_sach
            End Get
            Set(ByVal Value As Boolean)
                mNgoai_ngan_sach = Value
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
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property SBD() As String
            Get
                Return mSbd
            End Get
            Set(ByVal Value As String)
                mSbd = Value
            End Set
        End Property
        Public Property Dia_chi_tt() As String
            Get
                Return mdia_chi_tt
            End Get
            Set(ByVal Value As String)
                mdia_chi_tt = Value
            End Set
        End Property
        Public Property Que_quan() As String
            Get
                Return mQue_quan
            End Get
            Set(ByVal Value As String)
                mQue_quan = Value
            End Set
        End Property
        Public Property Tong_diem() As Double
            Get
                Return mTong_diem
            End Get
            Set(ByVal Value As Double)
                mTong_diem = Value
            End Set
        End Property
        Public Property Ngay_cap() As Date
            Get
                Return mNgay_cap
            End Get
            Set(ByVal Value As Date)
                mNgay_cap = Value
            End Set
        End Property
        Public Property Ngay_nhap_hoc() As Date
            Get
                Return mNgay_nhap_hoc
            End Get
            Set(ByVal Value As Date)
                mNgay_nhap_hoc = Value
            End Set
        End Property

        Public Property ID_svs() As String
            Get
                Return mID_svs
            End Get
            Set(ByVal Value As String)
                mID_svs = Value
            End Set
        End Property

        Public Property Ten_he_en() As String
            Get
                Return mTen_he_en
            End Get
            Set(ByVal Value As String)
                mTen_he_en = Value
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

        Public Property Loai_dao_tao() As String
            Get
                Return mLoai_dao_tao
            End Get
            Set(ByVal Value As String)
                mLoai_dao_tao = Value
            End Set
        End Property


        Public Property Loai_dao_tao_en() As String
            Get
                Return mLoai_dao_tao_en
            End Get
            Set(ByVal Value As String)
                mLoai_dao_tao_en = Value
            End Set
        End Property
        Public Property Trinh_do() As String
            Get
                Return mTrinh_do
            End Get
            Set(ByVal Value As String)
                mTrinh_do = Value
            End Set
        End Property

        Public Property Ngay_QD() As Date
            Get
                Return mNgay_QD
            End Get
            Set(ByVal Value As Date)
                mNgay_QD = Value
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
        Public Property So_QD() As String
            Get
                Return mSo_QD
            End Get
            Set(ByVal Value As String)
                mSo_QD = Value
            End Set
        End Property

        Public Property Van_hoa() As Boolean
            Get
                Return mVan_hoa
            End Get
            Set(ByVal Value As Boolean)
                mVan_hoa = Value
            End Set
        End Property
        Public Property Trang_thai() As Integer
            Get
                Return mTrang_thai
            End Get
            Set(ByVal Value As Integer)
                mTrang_thai = Value
            End Set
        End Property
#End Region
    End Class
End Namespace