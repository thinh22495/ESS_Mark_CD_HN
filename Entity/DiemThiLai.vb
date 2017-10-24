'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemThiLai
#Region "Constructor"
#End Region

#Region "Var"
        Private mLan_hoc As Integer = 0
        Private mLan_thi As Integer = 0
        Private mThi_lai As Integer = 0
        Private mDiemThiLai As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal thilai As DiemThiLai)
            mDiemThiLai.Add(thilai)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemThiLai.RemoveAt(idx)
        End Sub
        Public Function Thi_lai_lan(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Integer
            For i As Integer = 0 To mDiemThiLai.Count - 1
                If CType(mDiemThiLai(i), DiemThiLai).Lan_hoc = Lan_hoc And CType(mDiemThiLai(i), DiemThiLai).Lan_thi = Lan_thi Then
                    Return 1
                End If
            Next
            Return 0
        End Function
        Public Function Thi_lai() As Integer
            If mDiemThiLai.Count > 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemThiLai.Count
            End Get
        End Property
        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property
        Public Property Lan_thi() As Integer
            Get
                Return mLan_thi
            End Get
            Set(ByVal Value As Integer)
                mLan_thi = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
