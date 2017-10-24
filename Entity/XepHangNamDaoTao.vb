'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, July 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class XepHangNamDaoTao
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_xep_hang As Integer = 0
        Private mNam_thu As Integer = 0
        Private mTu_tin_chi As Integer = 0
        Private mDen_tin_chi As Integer = 0
        Private mXepHangNamDaoTao As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal xephang As XepHangNamDaoTao)
            mXepHangNamDaoTao.Add(xephang)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepHangNamDaoTao.RemoveAt(idx)
        End Sub
        Public Function XepHangNamDaoTao(ByVal So_hoc_trinh As Double) As Integer
            For i As Integer = 0 To mXepHangNamDaoTao.Count - 1
                If CType(mXepHangNamDaoTao(i), XepHangNamDaoTao).Tu_tin_chi <= So_hoc_trinh And _
                    CType(mXepHangNamDaoTao(i), XepHangNamDaoTao).Den_tin_chi > So_hoc_trinh Then
                    Return CType(mXepHangNamDaoTao(i), XepHangNamDaoTao).Nam_thu
                End If
            Next
            Return 1
        End Function
#End Region
#Region "Property"
        Public Property ID_xep_hang() As Integer
            Get
                Return mID_xep_hang
            End Get
            Set(ByVal Value As Integer)
                mID_xep_hang = Value
            End Set
        End Property
        Public Property Nam_thu() As Integer
            Get
                Return mNam_thu
            End Get
            Set(ByVal Value As Integer)
                mNam_thu = Value
            End Set
        End Property
        Public Property Tu_tin_chi() As Integer
            Get
                Return mTu_tin_chi
            End Get
            Set(ByVal Value As Integer)
                mTu_tin_chi = Value
            End Set
        End Property
        Public Property Den_tin_chi() As Integer
            Get
                Return mDen_tin_chi
            End Get
            Set(ByVal Value As Integer)
                mDen_tin_chi = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
