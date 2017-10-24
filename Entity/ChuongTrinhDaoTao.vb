﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChuongTrinhDaoTao
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_dt As Integer = 0
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mSo As Integer = 1
        Private mID_nganh As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mSo_hoc_trinh As Double = 0
        Private mSo_ky_hoc As Integer = 0
        Private mTen_he As String = ""
        Private mTen_khoa As String = ""
        Private mTen_nganh As String = ""
        Private mChuyen_nganh As String = ""
        Private mChuongTrinhDaoTaoChiTiet As New ChuongTrinhDaoTaoChiTiet
        Private mChuongTrinhDaoTaoLop As New ChuongTrinhDaoTaoLop
        Private mChuongTrinhDaoTaoRangBuoc As New ChuongTrinhDaoTaoMonHocRangBuoc
        Private mChuongTrinhDaoTaoNhomTuChon As New ChuongTrinhDaoTaoNhomTuChon
#End Region

#Region "Property"
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
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
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
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
        Public Property So_hoc_trinh() As Double
            Get
                Return mSo_hoc_trinh
            End Get
            Set(ByVal Value As Double)
                mSo_hoc_trinh = Value
            End Set
        End Property
        Public Property So_ky_hoc() As Integer
            Get
                Return mSo_ky_hoc
            End Get
            Set(ByVal Value As Integer)
                mSo_ky_hoc = Value
            End Set
        End Property
        Public Property So() As Integer
            Get
                Return mSo
            End Get
            Set(ByVal Value As Integer)
                mSo = Value
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
        Public Property ChuongTrinhDaoTaoChiTiet() As ChuongTrinhDaoTaoChiTiet
            Get
                Return mChuongTrinhDaoTaoChiTiet
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoChiTiet)
                mChuongTrinhDaoTaoChiTiet = Value
            End Set
        End Property
        Public Property ChuongTrinhDaoTaoLop() As ChuongTrinhDaoTaoLop
            Get
                Return mChuongTrinhDaoTaoLop
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoLop)
                mChuongTrinhDaoTaoLop = Value
            End Set
        End Property
        Public Property ChuongTrinhDaoTaoRangBuoc() As ChuongTrinhDaoTaoMonHocRangBuoc
            Get
                Return mChuongTrinhDaoTaoRangBuoc
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoMonHocRangBuoc)
                mChuongTrinhDaoTaoRangBuoc = Value
            End Set
        End Property

        Public Property ChuongTrinhDaoTaoNhomTuChon() As ChuongTrinhDaoTaoNhomTuChon
            Get
                Return mChuongTrinhDaoTaoNhomTuChon
            End Get
            Set(ByVal value As ChuongTrinhDaoTaoNhomTuChon)
                mChuongTrinhDaoTaoNhomTuChon = value
            End Set
        End Property
#End Region
    End Class
End Namespace
