'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Thursday, May 08, 2008
'---------------------------------------------------------------------------
Imports System
Namespace Entity
    Public Class BoMon
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_bm As Integer = 0
        Private mMa_bo_mon As String = ""
        Private mBo_mon As String = ""
        Private mGiaoVien As New ArrayList
        Private mMonHoc As New ArrayList
        Private mSo_nhom As Integer = 0
#End Region
#Region "Function"
       
#End Region
#Region "Property"
        Public Property So_nhom() As Integer
            Get
                Return mSo_nhom
            End Get
            Set(ByVal Value As Integer)
                mSo_nhom = Value
            End Set
        End Property
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
        Public Property Ma_bo_mon() As String
            Get
                Return mMa_bo_mon
            End Get
            Set(ByVal Value As String)
                mMa_bo_mon = Value
            End Set
        End Property
        Public Property Bo_mon() As String
            Get
                Return mBo_mon
            End Get
            Set(ByVal Value As String)
                mBo_mon = Value
            End Set
        End Property
        Public Property dsGiangVien() As ArrayList
            Get
                Return mGiaoVien
            End Get
            Set(ByVal Value As ArrayList)
                mGiaoVien = Value
            End Set
        End Property
        Public Property dsMonHoc() As ArrayList
            Get
                Return mMonHoc
            End Get
            Set(ByVal Value As ArrayList)
                mMonHoc = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
