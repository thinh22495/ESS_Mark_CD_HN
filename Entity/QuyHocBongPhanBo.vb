'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, August 01, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class QuyHocBongPhanBo
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_phan_bo As Integer = 0
        Private mTen_phan_bo As String = ""
        Private mID_hb As Integer = 0
        Private mSo_sv As Integer = 0
        Private mSo_tien As Double
        Private mPhan_dac_biet As Boolean = 0
#End Region

#Region "Property"
        Public Property ID_phan_bo() As Integer
            Get
                Return mID_phan_bo
            End Get
            Set(ByVal Value As Integer)
                mID_phan_bo = Value
            End Set
        End Property
        Public Property Ten_phan_bo() As String
            Get
                Return mTen_phan_bo
            End Get
            Set(ByVal Value As String)
                mTen_phan_bo = Value
            End Set
        End Property
        Public Property ID_hb() As Integer
            Get
                Return mID_hb
            End Get
            Set(ByVal Value As Integer)
                mID_hb = Value
            End Set
        End Property
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
        Public Property So_tien() As Double
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Double)
                mSo_tien = Value
            End Set
        End Property
        Public Property Phan_dac_biet() As Boolean
            Get
                Return mPhan_dac_biet
            End Get
            Set(ByVal Value As Boolean)
                mPhan_dac_biet = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
