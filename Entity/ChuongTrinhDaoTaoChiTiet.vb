'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChuongTrinhDaoTaoChiTiet
        Inherits MonHoc
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_dt_mon As Integer = 0
        Private mID_dt As Integer = 0
        Private mKy_thu As Integer = 0
        Private mSo_hoc_trinh As Double = 0
        Private mLy_thuyet As Double = 0
        Private mThuc_hanh As Double = 0
        Private mBai_tap As Double = 0
        Private mBai_tap_lon As Double = 0
        Private mThuc_tap As Double = 0
        Private mTu_chon As Boolean = 0
        Private mSTT_mon As Integer = 0
        Private mHe_so As Double = 0
        Private mTong_tiet As Double = 0
        Private mKien_thuc As Integer = 0
        Private mKhong_tinh_TBCHT As Boolean = False
        Private mNhom_tu_chon As Integer = 0
        Private mTen_kien_thuc As String = ""
        Private mID_mon_main As Integer = 0
        Private mTen_mon_main As String = ""
        Private mChon As String = ""
        Private mTu_hoc As Integer = 0
        Private mMa_khoa_phu_trach As String = ""
        Private mSo_hoc_trinh_tien_quyet As Integer
        Private mMon_thi_TN As Boolean = False
        Private mMon_tot_nghiep_thuc_hanh As Boolean = False
        Private mThuc_hanh_nghe As Boolean = False
        Private mLy_thuyet_nghe As Boolean = False
        Private mNhom_mon_sub As Integer = 0
        Private mMonRangBuoc As ChuongTrinhDaoTaoMonHocRangBuoc
        Private mChuongTrinhDaoTaoChiTiet As New ArrayList
        Private mChuongTrinhDaoTaoRangBuoc As New ChuongTrinhDaoTaoMonHocRangBuoc


#End Region
#Region "Function"
        Public Sub Add(ByVal ctdtChiTiet As ChuongTrinhDaoTaoChiTiet)
            mChuongTrinhDaoTaoChiTiet.Add(ctdtChiTiet)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoChiTiet.RemoveAt(idx)
        End Sub
#End Region

#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoChiTiet.Count
            End Get
        End Property
        Public Property ChuongTrinhDaoTaoChiTiet(ByVal idx As Integer) As ChuongTrinhDaoTaoChiTiet
            Get
                Return CType(mChuongTrinhDaoTaoChiTiet(idx), ChuongTrinhDaoTaoChiTiet)
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoChiTiet)
                mChuongTrinhDaoTaoChiTiet(idx) = Value
            End Set
        End Property

        Public Function Tim_idx(ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To mChuongTrinhDaoTaoChiTiet.Count - 1
                If CType(mChuongTrinhDaoTaoChiTiet(i), ChuongTrinhDaoTaoChiTiet).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Property ID_dt_mon() As Integer
            Get
                Return mID_dt_mon
            End Get
            Set(ByVal Value As Integer)
                mID_dt_mon = Value
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
        Public Property Ky_thu() As Integer
            Get
                Return mKy_thu
            End Get
            Set(ByVal Value As Integer)
                mKy_thu = Value
            End Set
        End Property
        Public Property So_hoc_trinh() As Double
            Get
                Return mSo_hoc_trinh
            End Get
            Set(ByVal Value As Double)
                mSo_hoc_trinh = Value
            End Set
        End Property
        Public Property Ly_thuyet() As Integer
            Get
                Return mLy_thuyet
            End Get
            Set(ByVal Value As Integer)
                mLy_thuyet = Value
            End Set
        End Property
        Public Property Thuc_hanh() As Integer
            Get
                Return mThuc_hanh
            End Get
            Set(ByVal Value As Integer)
                mThuc_hanh = Value
            End Set
        End Property
        Public Property Bai_tap() As Integer
            Get
                Return mBai_tap
            End Get
            Set(ByVal Value As Integer)
                mBai_tap = Value
            End Set
        End Property
        Public Property Bai_tap_lon() As Integer
            Get
                Return mBai_tap_lon
            End Get
            Set(ByVal Value As Integer)
                mBai_tap_lon = Value
            End Set
        End Property
        Public Property Thuc_tap() As Integer
            Get
                Return mThuc_tap
            End Get
            Set(ByVal Value As Integer)
                mThuc_tap = Value
            End Set
        End Property
        Public Property Tu_chon() As Boolean
            Get
                Return mTu_chon
            End Get
            Set(ByVal Value As Boolean)
                mTu_chon = Value
            End Set
        End Property
        Public Property STT_mon() As Integer
            Get
                Return mSTT_mon
            End Get
            Set(ByVal Value As Integer)
                mSTT_mon = Value
            End Set
        End Property
        Public Property He_so() As Double
            Get
                Return mHe_so
            End Get
            Set(ByVal Value As Double)
                mHe_so = Value
            End Set
        End Property
        Public Property Kien_thuc() As Integer
            Get
                Return mKien_thuc
            End Get
            Set(ByVal Value As Integer)
                mKien_thuc = Value
            End Set
        End Property
        Public Property Khong_tinh_TBCHT() As Boolean
            Get
                Return mKhong_tinh_TBCHT
            End Get
            Set(ByVal Value As Boolean)
                mKhong_tinh_TBCHT = Value
            End Set
        End Property
        Public Property Nhom_tu_chon() As Integer
            Get
                Return mNhom_tu_chon
            End Get
            Set(ByVal Value As Integer)
                mNhom_tu_chon = Value
            End Set
        End Property
        Public Property Ten_kien_thuc() As String
            Get
                Return mTen_kien_thuc
            End Get
            Set(ByVal Value As String)
                mTen_kien_thuc = Value
            End Set
        End Property
        Public Property Chon() As String
            Get
                Return mChon
            End Get
            Set(ByVal Value As String)
                mChon = Value
            End Set
        End Property
        Public Property Tu_hoc() As Integer
            Get
                Return mTu_hoc
            End Get
            Set(ByVal Value As Integer)
                mTu_hoc = Value
            End Set
        End Property
        Public Property So_hoc_trinh_tien_quyet() As Integer
            Get
                Return mSo_hoc_trinh_tien_quyet
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_tien_quyet = Value
            End Set
        End Property
        Public Property Ma_khoa_phu_trach() As String
            Get
                Return mMa_khoa_phu_trach
            End Get
            Set(ByVal Value As String)
                mMa_khoa_phu_trach = Value
            End Set
        End Property

        Public Property MonRangBuoc() As ChuongTrinhDaoTaoMonHocRangBuoc
            Get
                Return mMonRangBuoc
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoMonHocRangBuoc)
                mMonRangBuoc = Value
            End Set
        End Property

        Public Property Mon_thi_TN() As Boolean
            Get
                Return mMon_thi_TN
            End Get
            Set(ByVal Value As Boolean)
                mMon_thi_TN = Value
            End Set
        End Property

        Public Property Mon_thi_TN_thuc_hanh() As Boolean
            Get
                Return mMon_tot_nghiep_thuc_hanh
            End Get
            Set(ByVal Value As Boolean)
                mMon_tot_nghiep_thuc_hanh = Value
            End Set
        End Property

        Public Property ID_mon_main() As Integer
            Get
                Return mID_mon_main
            End Get
            Set(ByVal Value As Integer)
                mID_mon_main = Value
            End Set
        End Property
        Public Property Ten_mon_main() As String
            Get
                Return mTen_mon_main
            End Get
            Set(ByVal Value As String)
                mTen_mon_main = Value
            End Set
        End Property
        Public Property Nhom_mon_sub() As String
            Get
                Return mNhom_mon_sub
            End Get
            Set(ByVal Value As String)
                mNhom_mon_sub = Value
            End Set
        End Property

        Public Function Tong_tiet() As Integer
            mTong_tiet = mThuc_hanh + mBai_tap + mBai_tap_lon + mThuc_tap + mLy_thuyet + mTu_hoc
            Return mTong_tiet
        End Function

        Public Property Ly_thuyet_nghe() As Boolean
            Get
                Return mLy_thuyet_nghe
            End Get
            Set(ByVal Value As Boolean)
                mLy_thuyet_nghe = Value
            End Set
        End Property

        Public Property Thuc_hanh_nghe() As Boolean
            Get
                Return mThuc_hanh_nghe
            End Get
            Set(ByVal Value As Boolean)
                mThuc_hanh_nghe = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
