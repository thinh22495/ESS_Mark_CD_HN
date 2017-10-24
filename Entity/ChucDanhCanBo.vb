﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Saturday, June 07, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class ChucDanhCanBo
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_chuc_danh As Integer = 0
        Private mMa_chuc_danh As String = ""
        Private mChuc_danh As String = ""
#End Region

#Region "Property"
        Public Property ID_chuc_danh() As Integer
            Get
                Return mID_chuc_danh
            End Get
            Set(ByVal Value As Integer)
                mID_chuc_danh = Value
            End Set
        End Property
        Public Property Ma_chuc_danh() As String
            Get
                Return mMa_chuc_danh
            End Get
            Set(ByVal Value As String)
                mMa_chuc_danh = Value
            End Set
        End Property
        Public Property Chuc_danh() As String
            Get
                Return mChuc_danh
            End Get
            Set(ByVal Value As String)
                mChuc_danh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
