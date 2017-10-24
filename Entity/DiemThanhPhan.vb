'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemThanhPhan
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_thanh_phan As Integer = 0
        Private mLan_hoc As Integer = 0
        Private mDiem As Double = 0
        Private mLy_do As String = ""
        Private mTy_le As Integer = 0
        Private mHash_code As Integer = 0
        Private mLocked As Integer = 0
        Private mDiemThanhPhan As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal dTP As DiemThanhPhan)
            mDiemThanhPhan.Add(dTP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemThanhPhan.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_thanh_phan As Integer, ByVal Lan_hoc As Integer) As Integer
            For i As Integer = 0 To mDiemThanhPhan.Count - 1
                If CType(mDiemThanhPhan(i), DiemThanhPhan).ID_thanh_phan = ID_thanh_phan And _
                   CType(mDiemThanhPhan(i), DiemThanhPhan).Lan_hoc = Lan_hoc Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemThanhPhan.Count
            End Get
        End Property
        Public Property DiemThanhPhan(ByVal idx As Integer) As DiemThanhPhan
            Get
                Return CType(mDiemThanhPhan(idx), DiemThanhPhan)
            End Get
            Set(ByVal Value As DiemThanhPhan)
                mDiemThanhPhan(idx) = Value
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
        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property
        Public Property Diem() As Double
            Get
                Return mDiem
            End Get
            Set(ByVal Value As Double)
                mDiem = Value
            End Set
        End Property
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
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
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked() As Integer
            Get
                Return mLocked
            End Get
            Set(ByVal Value As Integer)
                mLocked = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
