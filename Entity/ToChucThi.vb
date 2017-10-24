'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, May 03, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class TochucThi
        Inherits MonHoc
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_thi As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTen_khoa As String = ""
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mThoi_gian As String = ""
        Private mThoi_gian_lam_bai As String = ""
        Private mID_khoa As Integer = 0
        Private mLan_thi As Integer = 0
        Private mDot_thi As Integer = 0
        Private mNgay_thi As Date
        Private mCa_thi As Integer = 0
        Private mNhom_tiet As Integer = 0
        Private mToChucThiPhong As New ToChucThiPhong
        Private mToChucThiTheoTui As New ToChucThiDongTui
        Private mToChucThiChiTiet As New TochucThiChiTiet
#End Region

#Region "Property"
        Public Property ID_thi() As Integer
            Get
                Return mID_thi
            End Get
            Set(ByVal Value As Integer)
                mID_thi = Value
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
        'Public Property Khoa_hoc() As Integer
        '    Get
        '        Return mKhoa_hoc
        '    End Get
        '    Set(ByVal Value As Integer)
        '        mKhoa_hoc = Value
        '    End Set
        'End Property
        Public Property Lan_thi() As Integer
            Get
                Return mLan_thi
            End Get
            Set(ByVal Value As Integer)
                mLan_thi = Value
            End Set
        End Property
        Public Property Dot_thi() As Integer
            Get
                Return mDot_thi
            End Get
            Set(ByVal Value As Integer)
                mDot_thi = Value
            End Set
        End Property
        Public Property Thoi_gian_lam_bai() As String
            Get
                Return mThoi_gian_lam_bai
            End Get
            Set(ByVal Value As String)
                mThoi_gian_lam_bai = Value
            End Set
        End Property
        Public Property Ngay_thi() As Date
            Get
                Return mNgay_thi
            End Get
            Set(ByVal Value As Date)
                mNgay_thi = Value
            End Set
        End Property
        Public Property dsChiTietSinhVien() As TochucThiChiTiet
            Get
                Return mToChucThiChiTiet
            End Get
            Set(ByVal Value As TochucThiChiTiet)
                mToChucThiChiTiet = Value
            End Set
        End Property
        Public Property dsPhongThi() As ToChucThiPhong
            Get
                Return mToChucThiPhong
            End Get
            Set(ByVal Value As ToChucThiPhong)
                mToChucThiPhong = Value
            End Set
        End Property
        Public Property dsTuiThi() As ToChucThiDongTui
            Get
                Return mToChucThiTheoTui
            End Get
            Set(ByVal Value As ToChucThiDongTui)
                mToChucThiTheoTui = Value
            End Set
        End Property
        Public ReadOnly Property TongSoSVPhongThi() As Integer
            Get
                Dim Tong_sv As Integer = 0
                For i As Integer = 0 To mToChucThiPhong.Count - 1
                    Tong_sv += mToChucThiPhong.TochucThiPhong(i).So_sv
                Next
                Return Tong_sv
            End Get
        End Property
        Public Property Ca_thi() As Integer
            Get
                Return mCa_thi
            End Get
            Set(ByVal Value As Integer)
                mCa_thi = Value
            End Set
        End Property
        Public Property Nhom_tiet() As Integer
            Get
                Return mNhom_tiet
            End Get
            Set(ByVal Value As Integer)
                mNhom_tiet = Value
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