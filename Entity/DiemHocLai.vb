'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemHocLai
#Region "Constructor"
#End Region

#Region "Var"
        Private mLan_hoc As Integer = 0
        Private mDiemHocLai As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal hoclai As DiemHocLai)
            mDiemHocLai.Add(hoclai)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemHocLai.RemoveAt(idx)
        End Sub
        Public Function Hoc_lai_lan(ByVal Lan_hoc As Integer) As Integer
            For i As Integer = 0 To mDiemHocLai.Count - 1
                If CType(mDiemHocLai(i), DiemHocLai).Lan_hoc = Lan_hoc Then
                    Return 1
                End If
            Next
            Return 0
        End Function
        Public Function Hoc_lai() As Integer
            If mDiemHocLai.Count > 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemHocLai.Count
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
#End Region
    End Class
End Namespace
