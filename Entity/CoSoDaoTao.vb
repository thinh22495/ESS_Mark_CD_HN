﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, August 29, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class CoSoDaoTao
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_co_so As Integer = 0
        Private mMa_co_so As String = ""
        Private mTen_co_so As String = ""
#End Region

#Region "Property"
        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal Value As Integer)
                mID_co_so = Value
            End Set
        End Property
        Public Property Ma_co_so() As String
            Get
                Return mMa_co_so
            End Get
            Set(ByVal Value As String)
                mMa_co_so = Value
            End Set
        End Property
        Public Property Ten_co_so() As String
            Get
                Return mTen_co_so
            End Get
            Set(ByVal Value As String)
                mTen_co_so = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
