﻿'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Tuesday, July 29, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DanhSachMienGiamHocPhi
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mPhan_tram As Double = 0
#End Region

#Region "Property"
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property Phan_tram() As Double
            Get
                Return mPhan_tram
            End Get
            Set(ByVal Value As Double)
                mPhan_tram = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
