'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class MonTinChi
        Inherits ChuongTrinhDaoTaoChiTiet
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_mon_tc As Integer = 0
        Private mKy_dang_ky As Integer = 0
        Private mKy_hieu_lop_tc As String = ""
        Private mSo_tien As Integer = 0
        Private mLopTinChi As New LopTinChi
        Private mPhamViDangKy As New PhamViDangKy
#End Region

#Region "Property"
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
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
        Public Property Ky_hieu_lop_tc() As String
            Get
                Return mKy_hieu_lop_tc
            End Get
            Set(ByVal Value As String)
                mKy_hieu_lop_tc = Value
            End Set
        End Property
        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
            End Set
        End Property
        Public Property dsLopTinChi() As LopTinChi
            Get
                Return mLopTinChi
            End Get
            Set(ByVal Value As LopTinChi)
                mLopTinChi = Value
            End Set
        End Property
        Public Property dsPhamViDangKy() As PhamViDangKy
            Get
                Return mPhamViDangKy
            End Get
            Set(ByVal Value As PhamViDangKy)
                mPhamViDangKy = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
