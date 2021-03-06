﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Monday, July 07, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class QuyDinhSoTinChi
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mKy_dang_ky As Integer = 0
        Private mSo_hoc_trinh_min_bt As Integer = 0
        Private mSo_hoc_trinh_max_bt As Integer = 0
        Private mSo_hoc_trinh_option_bt As Integer = 0
        Private mCheck_So_hoc_trinh_min_bt As Boolean = 0
        Private mCheck_So_hoc_trinh_max_bt As Boolean = 0
        Private mSo_hoc_trinh_min_yeu As Integer = 0
        Private mSo_hoc_trinh_max_yeu As Integer = 0
        Private mSo_hoc_trinh_option_yeu As Integer = 0
        Private mCheck_So_hoc_trinh_min_yeu As Boolean = 0
        Private mCheck_So_hoc_trinh_max_yeu As Boolean = 0
        Private mTu_ngay1 As Object
        Private mDen_ngay1 As Object
        Private mTu_ngay2 As Object
        Private mDen_ngay2 As Object
        Private mTen_he As String
        Private mTen_khoa As String
#End Region

#Region "Property"
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
        Public Property Ky_dang_ky() As Integer
            Get
                Return mKy_dang_ky
            End Get
            Set(ByVal Value As Integer)
                mKy_dang_ky = Value
            End Set
        End Property
        Public Property So_hoc_trinh_min_bt() As Integer
            Get
                Return mSo_hoc_trinh_min_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_min_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_max_bt() As Integer
            Get
                Return mSo_hoc_trinh_max_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_max_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_option_bt() As Integer
            Get
                Return mSo_hoc_trinh_option_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_option_bt = Value
            End Set
        End Property
        Public Property Check_So_hoc_trinh_min_bt() As Boolean
            Get
                Return mCheck_So_hoc_trinh_min_bt
            End Get
            Set(ByVal Value As Boolean)
                mCheck_So_hoc_trinh_min_bt = Value
            End Set
        End Property
        Public Property Check_So_hoc_trinh_max_bt() As Boolean
            Get
                Return mCheck_So_hoc_trinh_max_bt
            End Get
            Set(ByVal Value As Boolean)
                mCheck_So_hoc_trinh_max_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_min_yeu() As Integer
            Get
                Return mSo_hoc_trinh_min_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_min_yeu = Value
            End Set
        End Property
        Public Property So_hoc_trinh_max_yeu() As Integer
            Get
                Return mSo_hoc_trinh_max_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_max_yeu = Value
            End Set
        End Property
        Public Property So_hoc_trinh_option_yeu() As Integer
            Get
                Return mSo_hoc_trinh_option_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_option_yeu = Value
            End Set
        End Property
        Public Property Check_So_hoc_trinh_min_yeu() As Boolean
            Get
                Return mCheck_So_hoc_trinh_min_yeu
            End Get
            Set(ByVal Value As Boolean)
                mCheck_So_hoc_trinh_min_yeu = Value
            End Set
        End Property
        Public Property Check_So_hoc_trinh_max_yeu() As Boolean
            Get
                Return mCheck_So_hoc_trinh_max_yeu
            End Get
            Set(ByVal Value As Boolean)
                mCheck_So_hoc_trinh_max_yeu = Value
            End Set
        End Property
        Public Property Tu_ngay1() As Object
            Get
                Return mTu_ngay1
            End Get
            Set(ByVal Value As Object)
                mTu_ngay1 = Value
            End Set
        End Property
        Public Property Den_ngay1() As Object
            Get
                Return mDen_ngay1
            End Get
            Set(ByVal Value As Object)
                mDen_ngay1 = Value
            End Set
        End Property
        Public Property Tu_ngay2() As Object
            Get
                Return mTu_ngay2
            End Get
            Set(ByVal Value As Object)
                mTu_ngay2 = Value
            End Set
        End Property
        Public Property Den_ngay2() As Object
            Get
                Return mDen_ngay2
            End Get
            Set(ByVal Value As Object)
                mDen_ngay2 = Value
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
#End Region

    End Class
End Namespace
