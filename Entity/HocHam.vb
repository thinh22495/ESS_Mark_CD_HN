'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, June 07, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class HocHam
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_hoc_ham As Integer = 0
        Private mMa_hoc_ham As String = ""
        Private mHoc_ham As String = ""
#End Region

#Region "Property"
        Public Property ID_hoc_ham() As Integer
            Get
                Return mID_hoc_ham
            End Get
            Set(ByVal Value As Integer)
                mID_hoc_ham = Value
            End Set
        End Property
        Public Property Ma_hoc_ham() As String
            Get
                Return mMa_hoc_ham
            End Get
            Set(ByVal Value As String)
                mMa_hoc_ham = Value
            End Set
        End Property
        Public Property Hoc_ham() As String
            Get
                Return mHoc_ham
            End Get
            Set(ByVal Value As String)
                mHoc_ham = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
