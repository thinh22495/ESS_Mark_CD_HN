﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Tang
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_TANG As Integer = 0
        Private mMa_tang As String = ""
        Private mTen_tang As String = ""
#End Region

#Region "Property"
        Public Property ID_TANG() As Integer
            Get
                Return mID_TANG
            End Get
            Set(ByVal Value As Integer)
                mID_TANG = Value
            End Set
        End Property
        Public Property Ma_tang() As String
            Get
                Return mMa_tang
            End Get
            Set(ByVal Value As String)
                mMa_tang = Value
            End Set
        End Property
        Public Property Ten_tang() As String
            Get
                Return mTen_tang
            End Get
            Set(ByVal Value As String)
                mTen_tang = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
