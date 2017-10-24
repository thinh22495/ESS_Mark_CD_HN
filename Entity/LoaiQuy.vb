'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, August 29, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class LoaiQuy
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_quy As Integer = 0
        Private mLoai_quy As String = ""
        Private mGhi_chu As String = ""
#End Region

#Region "Property"
        Public Property ID_quy() As Integer
            Get
                Return mID_quy
            End Get
            Set(ByVal Value As Integer)
                mID_quy = Value
            End Set
        End Property
        Public Property Loai_quy() As String
            Get
                Return mLoai_quy
            End Get
            Set(ByVal Value As String)
                mLoai_quy = Value
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
