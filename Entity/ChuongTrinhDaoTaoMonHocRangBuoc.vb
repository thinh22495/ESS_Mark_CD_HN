'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChuongTrinhDaoTaoMonHocRangBuoc
        Inherits MonHoc
#Region "Var"
        Private mID_mon_rb As Integer = 0
        Private mID_rb As Integer = 0
        Private mLoai_rang_buoc As Integer = 0
        Private mTen_rang_buoc As String = ""
        Private mID_DT As Integer = 0
        Private mTen_mon1 As String = ""
        Private mTen_mon_rb As String = ""
        Private mChuongTrinhDaoTaoMonRangBuoc As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal ctdtMonRangBuoc As ChuongTrinhDaoTaoMonHocRangBuoc)
            mChuongTrinhDaoTaoMonRangBuoc.Add(ctdtMonRangBuoc)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoMonRangBuoc.RemoveAt(idx)
        End Sub

        
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoMonRangBuoc.Count
            End Get
        End Property
        Public Property ChuongTrinhDaoTaoRangBuoc(ByVal idx As Integer) As ChuongTrinhDaoTaoMonHocRangBuoc
            Get
                Return CType(mChuongTrinhDaoTaoMonRangBuoc(idx), ChuongTrinhDaoTaoMonHocRangBuoc)
            End Get
            Set(ByVal Value As ChuongTrinhDaoTaoMonHocRangBuoc)
                mChuongTrinhDaoTaoMonRangBuoc(idx) = Value
            End Set
        End Property
        Public Property ID_rb() As Integer
            Get
                Return mID_rb
            End Get
            Set(ByVal Value As Integer)
                mID_rb = Value
            End Set
        End Property
        Public Property ID_mon_rb() As Integer
            Get
                Return mID_mon_rb
            End Get
            Set(ByVal Value As Integer)
                mID_mon_rb = Value
            End Set
        End Property
        Public Property Loai_rang_buoc() As Integer
            Get
                Return mLoai_rang_buoc
            End Get
            Set(ByVal Value As Integer)
                mLoai_rang_buoc = Value
            End Set
        End Property
        Public Property Ten_rang_buoc() As String
            Get
                Return mTen_rang_buoc
            End Get
            Set(ByVal Value As String)
                mTen_rang_buoc = Value
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
        Public Property Ten_mon1() As String
            Get
                Return mTen_mon1
            End Get
            Set(ByVal Value As String)
                mTen_mon1 = Value
            End Set
        End Property
        Public Property Ten_mon_rb() As String
            Get
                Return mTen_mon_rb
            End Get
            Set(ByVal Value As String)
                mTen_mon_rb = Value
            End Set
        End Property
#End Region
    End Class
End Namespace