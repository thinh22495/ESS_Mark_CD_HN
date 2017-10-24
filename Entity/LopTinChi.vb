'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class LopTinChi
#Region "Constructor"
        Public Sub New()
            mLopTinChi = New ArrayList
        End Sub
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            mTKB = New TKB(Ngay_tuan, So_tiet_ngay)
        End Sub
#End Region

#Region "Var"
        Private mID_lop_tc As Integer = 0
        Private mID_lop_lt As Integer = 0
        Private mSTT_lop_lt As Integer = 0
        Private mID_mon_tc As Integer = 0
        Private mID_mon As Integer = 0
        Private mKy_hieu_lop_tc As String = ""
        Private mKy_hieu As String = ""
        Private mTen_mon As String = ""
        Private mSTT_lop As Integer = 0
        Private mSo_sv_min As Integer = 0
        Private mSo_sv_max As Integer = 0
        Private mSo_tiet_tuan As Integer = 0
        Private mSo_tin_chi As Integer = 0
        Private mLy_thuyet As Integer = 0
        Private mThuc_hanh As Integer = 0
        Private mID_phong As Integer = 0
        Private mTen_phong As String = ""
        Private mID_cb As Integer = 0
        Private mHo_Ten_gv As String = ""
        Private mTu_ngay As Date
        Private mDen_ngay As Date
        Private mCa_hoc As Integer = 0
        Private mTen_ca_hoc As String = ""
        Private mHuy_lop As Boolean = 0
        Private mLy_do As String = ""
        Private mNhom_dang_ky As String = ""
        Private mID_he As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_nganh As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mLopTinChi As ArrayList
        Private mTKB As TKB
        Private mID_bm As Integer = 0
#End Region

#Region "Functions"

        Public Sub Add(ByVal Lop As LopTinChi)
            mLopTinChi.Add(Lop)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mLopTinChi.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_lop_tc As Integer) As Integer
            For i As Integer = 0 To mLopTinChi.Count - 1
                If CType(mLopTinChi(i), LopTinChi).ID_lop_tc = ID_lop_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
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
        Public ReadOnly Property Count() As Integer
            Get
                Return mLopTinChi.Count
            End Get
        End Property
        Public Property LopTinChi(ByVal idx As Integer) As LopTinChi
            Get
                Return CType(mLopTinChi(idx), LopTinChi)
            End Get
            Set(ByVal Value As LopTinChi)
                mLopTinChi(idx) = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return mID_lop_tc
            End Get
            Set(ByVal Value As Integer)
                mID_lop_tc = Value
            End Set
        End Property
        Public Property Ten_lop_tc() As String
            Get
                If ID_lop_lt = 0 Then
                    Return Ky_hieu_lop_tc + "." + STT_lop.ToString + "_LT"
                Else
                    Return Ky_hieu_lop_tc + "." + STT_lop.ToString + "_TH" + "." + STT_lop_lt.ToString
                End If
            End Get
            Set(ByVal Value As String)
                Ky_hieu_lop_tc = Value
            End Set
        End Property
        Public Property ID_lop_lt() As Integer
            Get
                Return mID_lop_lt
            End Get
            Set(ByVal Value As Integer)
                mID_lop_lt = Value
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
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
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
        Public Property Ky_hieu_lop_tc() As String
            Get
                Return mKy_hieu_lop_tc
            End Get
            Set(ByVal Value As String)
                mKy_hieu_lop_tc = Value
            End Set
        End Property
        Public Property STT_lop() As Integer
            Get
                Return mSTT_lop
            End Get
            Set(ByVal Value As Integer)
                mSTT_lop = Value
            End Set
        End Property
        Public Property STT_lop_lt() As Integer
            Get
                Return mSTT_lop_lt
            End Get
            Set(ByVal Value As Integer)
                mSTT_lop_lt = Value
            End Set
        End Property
        Public Property So_tin_chi() As Integer
            Get
                Return mSo_tin_chi
            End Get
            Set(ByVal Value As Integer)
                mSo_tin_chi = Value
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
        Public Property So_sv_min() As Integer
            Get
                Return mSo_sv_min
            End Get
            Set(ByVal Value As Integer)
                mSo_sv_min = Value
            End Set
        End Property
        Public Property So_sv_max() As Integer
            Get
                Return mSo_sv_max
            End Get
            Set(ByVal Value As Integer)
                mSo_sv_max = Value
            End Set
        End Property
        Public Property So_tiet_tuan() As Integer
            Get
                Return mSo_tiet_tuan
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_tuan = Value
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
        Public Property ID_cb() As Integer
            Get
                Return mID_cb
            End Get
            Set(ByVal Value As Integer)
                mID_cb = Value
            End Set
        End Property
        Public Property Ho_ten_gv() As String
            Get
                Return mHo_ten_gv
            End Get
            Set(ByVal Value As String)
                mHo_ten_gv = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
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
        Public Property Ten_ca_hoc() As String
            Get
                Return mTen_ca_hoc
            End Get
            Set(ByVal Value As String)
                mTen_ca_hoc = Value
            End Set
        End Property
        Public Property Huy_lop() As Boolean
            Get
                Return mHuy_lop
            End Get
            Set(ByVal Value As Boolean)
                mHuy_lop = Value
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
        Public Property Nhom_dang_ky() As String
            Get
                Return mNhom_dang_ky
            End Get
            Set(ByVal Value As String)
                mNhom_dang_ky = Value
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
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
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
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
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
        Public Property ID_BM() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
