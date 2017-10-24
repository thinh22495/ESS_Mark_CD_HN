'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ThanhPhanDiem
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_thanh_phan As Integer = 0
        Private mSTT As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_thanh_phan As String = ""
        Private mTy_le As Integer = 0
        Private mChecked As Boolean = False
        Private mChuyenCan As Boolean = True
        Private mThanhPhanDiem As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal TP As ThanhPhanDiem)
            mThanhPhanDiem.Add(TP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mThanhPhanDiem.RemoveAt(idx)
        End Sub

        Public Function Tim_idx(ByVal ID_thanh_phan As Integer) As Integer
            For i As Integer = 0 To mThanhPhanDiem.Count - 1
                If CType(mThanhPhanDiem(i), ThanhPhanDiem).ID_thanh_phan = ID_thanh_phan Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mThanhPhanDiem.Count
            End Get
        End Property
        Public Property ThanhPhanDiem(ByVal idx As Integer) As ThanhPhanDiem
            Get
                Return CType(mThanhPhanDiem(idx), ThanhPhanDiem)
            End Get
            Set(ByVal Value As ThanhPhanDiem)
                mThanhPhanDiem(idx) = Value
            End Set
        End Property
        Public Property ID_thanh_phan() As Integer
            Get
                Return mID_thanh_phan
            End Get
            Set(ByVal Value As Integer)
                mID_thanh_phan = Value
            End Set
        End Property
        Public Property STT() As Integer
            Get
                Return mSTT
            End Get
            Set(ByVal Value As Integer)
                mSTT = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_thanh_phan() As String
            Get
                Return mTen_thanh_phan
            End Get
            Set(ByVal Value As String)
                mTen_thanh_phan = Value
            End Set
        End Property
        Public Property Ty_le() As Integer
            Get
                Return mTy_le
            End Get
            Set(ByVal Value As Integer)
                mTy_le = Value
            End Set
        End Property
        Public Property Checked() As Boolean
            Get
                Return mChecked
            End Get
            Set(ByVal Value As Boolean)
                mChecked = Value
            End Set
        End Property

        Public Property Chuyencan() As Boolean
            Get
                Return mChuyenCan
            End Get
            Set(ByVal value As Boolean)
                mChuyenCan = value
            End Set
        End Property

#End Region

    End Class
End Namespace
