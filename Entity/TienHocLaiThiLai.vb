'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Thursday, June 26, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class TienHocLaiThiLai
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_mon As Integer = 0
        Private mID_sv As Integer = 0
        Private mLan_hoc As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTrang_thai As Boolean
        Private mDa_nop_tien As Boolean
        Private mGhi_chu As String = ""
#End Region

#Region "Property"
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property

        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property

        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property

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

        Public Property Trang_thai() As Boolean
            Get
                Return mTrang_thai
            End Get
            Set(ByVal Value As Boolean)
                mTrang_thai = Value
            End Set
        End Property

        Public Property Da_nop_tien() As Boolean
            Get
                Return mDa_nop_tien
            End Get
            Set(ByVal Value As Boolean)
                mDa_nop_tien = Value
            End Set
        End Property

        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
#End Region

    End Class
End Namespace


