'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, May 03, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DanhSach
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mSo_tiet_hoc_bu As Integer = 0
        Private mSo_tien_hoc_bu As Integer = 0
        Private mSo_nam_dao_tao As Integer = 0
        Private mSo_tien_hoan_tra As Integer = 0
#End Region

#Region "Property"
        Public Property So_nam_dao_tao() As Integer
            Get
                Return mSo_nam_dao_tao
            End Get
            Set(ByVal Value As Integer)
                mSo_nam_dao_tao = Value
            End Set
        End Property
        Public Property So_tien_hoan_tra() As Integer
            Get
                Return mSo_tien_hoan_tra
            End Get
            Set(ByVal Value As Integer)
                mSo_tien_hoan_tra = Value
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
        Public Property So_tiet_hoc_bu() As Integer
            Get
                Return mSo_tiet_hoc_bu
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_hoc_bu = Value
            End Set
        End Property
        Public Property So_tien_hoc_bu() As Integer
            Get
                Return mSo_tien_hoc_bu
            End Get
            Set(ByVal Value As Integer)
                mSo_tien_hoc_bu = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
