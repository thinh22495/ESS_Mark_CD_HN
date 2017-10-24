﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Sunday, May 04, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class LoaiGiayTo
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_giay_to As Integer = 0
        Private mMa_giay_to As String = ""
        Private mTen_giay_to As String = ""
#End Region

#Region "Property"
        Public Property ID_giay_to() As Integer
            Get
                Return mID_giay_to
            End Get
            Set(ByVal Value As Integer)
                mID_giay_to = Value
            End Set
        End Property
        Public Property Ma_giay_to() As String
            Get
                Return mMa_giay_to
            End Get
            Set(ByVal Value As String)
                mMa_giay_to = Value
            End Set
        End Property
        Public Property Ten_giay_to() As String
            Get
                Return mTen_giay_to
            End Get
            Set(ByVal Value As String)
                mTen_giay_to = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
