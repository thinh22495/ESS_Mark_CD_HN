'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Tuesday, July 29, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class BienLaiThu
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_bien_lai As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mDot_thu As Integer = 0
        Private mLan_thu As Integer = 0
        Private mThu_chi As Boolean = 0
        Private mSo_phieu As Integer = 0
        Private mNgay_thu As Date
        Private mNoi_dung As String = ""
        Private mSo_tien As Integer
        Private mSo_tien_chu As String = ""
        Private mNgoai_te As String = ""
        Private mHuy_phieu As Boolean = 0
        Private mGhi_chu As String = ""
        Private mNguoi_thu As String = ""
        Private mPrinted As Boolean = 0
        Private mBienLaiChiTiet As New BienLaiThuChiTiet
        Private mTen_tinh As String = ""
        Private mTen_huyen As String = ""
#End Region

#Region "Property"
        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
            End Set
        End Property
        Public Property Ten_huyen() As String
            Get
                Return mTen_huyen
            End Get
            Set(ByVal Value As String)
                mTen_huyen = Value
            End Set
        End Property
        Public Property ID_bien_lai() As Integer
            Get
                Return mID_bien_lai
            End Get
            Set(ByVal Value As Integer)
                mID_bien_lai = Value
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
        Public Property Dot_thu() As Integer
            Get
                Return mDot_thu
            End Get
            Set(ByVal Value As Integer)
                mDot_thu = Value
            End Set
        End Property
        Public Property Lan_thu() As Integer
            Get
                Return mLan_thu
            End Get
            Set(ByVal Value As Integer)
                mLan_thu = Value
            End Set
        End Property
        Public Property Thu_chi() As Boolean
            Get
                Return mThu_chi
            End Get
            Set(ByVal Value As Boolean)
                mThu_chi = Value
            End Set
        End Property
        Public Property So_phieu() As Integer
            Get
                Return mSo_phieu
            End Get
            Set(ByVal Value As Integer)
                mSo_phieu = Value
            End Set
        End Property
        Public Property Ngay_thu() As Date
            Get
                Return mNgay_thu
            End Get
            Set(ByVal Value As Date)
                mNgay_thu = Value
            End Set
        End Property
        Public Property Noi_dung() As String
            Get
                Return mNoi_dung
            End Get
            Set(ByVal Value As String)
                mNoi_dung = Value
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
        Public Property So_tien_chu() As String
            Get
                Return mSo_tien_chu
            End Get
            Set(ByVal Value As String)
                mSo_tien_chu = Value
            End Set
        End Property
        Public Property Ngoai_te() As String
            Get
                Return mNgoai_te
            End Get
            Set(ByVal Value As String)
                mNgoai_te = Value
            End Set
        End Property
        Public Property Huy_phieu() As Boolean
            Get
                Return mHuy_phieu
            End Get
            Set(ByVal Value As Boolean)
                mHuy_phieu = Value
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
        Public Property Nguoi_thu() As String
            Get
                Return mNguoi_thu
            End Get
            Set(ByVal Value As String)
                mNguoi_thu = Value
            End Set
        End Property
        Public Property Printed() As Boolean
            Get
                Return mPrinted
            End Get
            Set(ByVal Value As Boolean)
                mPrinted = Value
            End Set
        End Property
        Public Property dsBienLaiChiTiet() As BienLaiThuChiTiet
            Get
                Return mBienLaiChiTiet
            End Get
            Set(ByVal Value As BienLaiThuChiTiet)
                mBienLaiChiTiet = Value
            End Set
        End Property
        Public ReadOnly Property ThuTheoHocPhan() As Boolean
            Get
                For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                    If mBienLaiChiTiet.BienLaiChiTiet(i).ID_mon_tc > 0 Then
                        Return True
                    End If
                Next
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
