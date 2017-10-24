'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, June 06, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ToChucThiPhong
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_phong_thi As Integer = 0
        Private mID_phong As Integer = 0
        Private mTen_phong As String = ""
        Private mSo_sv As Integer = 0
        Private mTochucThiPhong As New ArrayList
        Private mDot_thi As Integer = 0
        Private mNgay_thi As Date
        Private mCa_thi As Integer = 0
        Private mNhom_tiet As Integer = 0
        Private mThoi_gian As String = ""
#End Region
        Public Sub Add(ByVal PhongThi As ToChucThiPhong)
            mTochucThiPhong.Add(PhongThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mTochucThiPhong.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal Ten_phong As String) As Integer
            For i As Integer = 0 To mTochucThiPhong.Count - 1
                If CType(mTochucThiPhong(i), ToChucThiPhong).Ten_phong = Ten_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mTochucThiPhong.Count
            End Get
        End Property
        Public Property TochucThiPhong(ByVal idx As Integer) As ToChucThiPhong
            Get
                Return CType(mTochucThiPhong(idx), ToChucThiPhong)
            End Get
            Set(ByVal Value As ToChucThiPhong)
                mTochucThiPhong(idx) = Value
            End Set
        End Property
        Public Property ID_phong_thi() As Integer
            Get
                Return mID_phong_thi
            End Get
            Set(ByVal Value As Integer)
                mID_phong_thi = Value
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
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
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
        Public Property Dot_thi() As Integer
            Get
                Return mDot_thi
            End Get
            Set(ByVal Value As Integer)
                mDot_thi = Value
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
