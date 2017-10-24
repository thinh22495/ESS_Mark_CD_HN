Imports System
Namespace Entity
    Public Class DanhMucPhong
#Region "Constructor"
#End Region
#Region "Var"
        Private mID_phong As Integer = 0
        Private mID_co_so As Integer = 0
        Private mID_nha As Integer = 0
        Private mID_tang As Integer = 0
        Private mSo_phong As String = ""
        Private mSuc_chua As Integer = 0
        Private mAm_thanh As Boolean = False
        Private mMay_tinh As Boolean = False
        Private mTivi As Boolean = False
        Private mMay_chieu As Boolean = False
        Private mID_loai_phong As Integer = 0
#End Region
#Region "Property"
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal value As Integer)
                mID_phong = value
            End Set
        End Property
        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal value As Integer)
                mID_co_so = value
            End Set
        End Property
        Public Property ID_nha() As Integer
            Get
                Return mID_nha
            End Get
            Set(ByVal value As Integer)
                mID_nha = value
            End Set
        End Property
        Public Property ID_tang() As Integer
            Get
                Return mID_tang
            End Get
            Set(ByVal value As Integer)
                mID_tang = value
            End Set
        End Property
        Public Property So_phong() As String
            Get
                Return mSo_phong
            End Get
            Set(ByVal value As String)
                mSo_phong = value
            End Set
        End Property
        Public Property Suc_chua() As Integer
            Get
                Return mSuc_chua
            End Get
            Set(ByVal value As Integer)
                mSuc_chua = value
            End Set
        End Property
        Public Property Am_thanh() As Boolean
            Get
                Return mAm_thanh
            End Get
            Set(ByVal value As Boolean)
                mAm_thanh = value
            End Set
        End Property
        Public Property May_tinh() As Boolean
            Get
                Return mMay_tinh
            End Get
            Set(ByVal value As Boolean)
                mMay_tinh = value
            End Set
        End Property
        Public Property Tivi() As Boolean
            Get
                Return mTivi
            End Get
            Set(ByVal value As Boolean)
                mTivi = value
            End Set
        End Property
        Public Property May_chieu() As Boolean
            Get
                Return mMay_chieu
            End Get
            Set(ByVal value As Boolean)
                mMay_chieu = value
            End Set
        End Property
        Public Property ID_loai_phong() As Integer
            Get
                Return mID_Loai_phong
            End Get
            Set(ByVal value As Integer)
                mID_Loai_phong = value
            End Set
        End Property
#End Region

    End Class
End Namespace
