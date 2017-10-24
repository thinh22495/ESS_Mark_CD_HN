'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemDanh
#Region "Constructor"
#End Region

#Region "Var"
        Private mLan_hoc As Integer = 0
        Private mSo_tiet_nghi As Integer = 0
        Private mSo_tiet_nghi_th As Integer = 0
        Private mThieu_bai_thuc_hanh As Byte = 0
        Private mHash_code As Integer = 0
        Private mLocked_dd As Integer = 0
        Private mGhi_chu As String = ""
        Private mDiemDanh As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal dTP As DiemDanh)
            mDiemDanh.Add(dTP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemDanh.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal Lan_hoc As Integer) As Integer
            For i As Integer = 0 To mDiemDanh.Count - 1
                If CType(mDiemDanh(i), DiemDanh).Lan_hoc = Lan_hoc Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemDanh.Count
            End Get
        End Property
        Public Property DiemDanh(ByVal idx As Integer) As DiemDanh
            Get
                Return CType(mDiemDanh(idx), DiemDanh)
            End Get
            Set(ByVal Value As DiemDanh)
                mDiemDanh(idx) = Value
            End Set
        End Property
        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property
        Public Property So_tiet_nghi() As Double
            Get
                Return mSo_tiet_nghi
            End Get
            Set(ByVal Value As Double)
                mSo_tiet_nghi = Value
            End Set
        End Property
        'Add by anhnt
        Public Property So_tiet_nghi_th() As Double
            Get
                Return mSo_tiet_nghi_th
            End Get
            Set(ByVal Value As Double)
                mSo_tiet_nghi_th = Value
            End Set
        End Property
        Public Property Thieu_bai_thuc_hanh() As Byte
            Get
                Return mThieu_bai_thuc_hanh
            End Get
            Set(ByVal Value As Byte)
                mThieu_bai_thuc_hanh = Value
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
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked_dd() As Integer
            Get
                Return mLocked_dd
            End Get
            Set(ByVal Value As Integer)
                mLocked_dd = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
