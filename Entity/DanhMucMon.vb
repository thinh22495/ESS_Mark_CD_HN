Imports System
Namespace Entity
    Public Class DanhMucMon
#Region "Constructor"
#End Region
#Region "Var"
        Private mID_mon As Integer = 0
        Private mID_he_dt As Integer = 0
        Private mId_bm As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_mon As String = 0
        Private mTen_tieng_anh As String = ""
#End Region
#Region "Property"
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal value As Integer)
                mID_mon = value
            End Set
        End Property
        Public Property ID_he_dt() As Integer
            Get
                Return mID_he_dt
            End Get
            Set(ByVal value As Integer)
                mID_he_dt = value
            End Set
        End Property
        Public Property Id_bm() As Integer
            Get
                Return mId_bm
            End Get
            Set(ByVal value As Integer)
                mId_bm = value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal value As String)
                mKy_hieu = value
            End Set
        End Property
        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal value As String)
                mTen_mon = value
            End Set
        End Property
        Public Property Ten_tieng_anh() As String
            Get
                Return mTen_tieng_anh
            End Get
            Set(ByVal value As String)
                mTen_tieng_anh = value
            End Set
        End Property
#End Region
    End Class
End Namespace
