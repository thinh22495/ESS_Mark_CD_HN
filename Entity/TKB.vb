'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports System
Namespace Entity
    Public Class TKB
        Private _Tkb(,) As Integer
        Private _Loai_sk(,) As eLOAI_SK
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            ReDim _Tkb(Ngay_tuan - 1, So_tiet_ngay - 1)
            ReDim _Loai_sk(Ngay_tuan - 1, So_tiet_ngay - 1)
            For i As Integer = 0 To Ngay_tuan - 1
                For j As Integer = 0 To So_tiet_ngay - 1
                    _Tkb(i, j) = -1
                    _Loai_sk(i, j) = eLOAI_SK.LICH_HOC
                Next
            Next
        End Sub
        Public Property TKB(ByVal thu As Integer, ByVal tiet As Integer) As Integer
            Get
                Return _Tkb(thu, tiet)
            End Get
            Set(ByVal Value As Integer)
                _Tkb(thu, tiet) = Value
            End Set
        End Property
        Public Property Loai_sk(ByVal thu As Integer, ByVal tiet As Integer) As eLOAI_SK
            Get
                Return _Loai_sk(thu, tiet)
            End Get
            Set(ByVal Value As eLOAI_SK)
                _Loai_sk(thu, tiet) = Value
            End Set
        End Property
    End Class
    Public Enum eLOAI_SK
        LICH_HOC = 0
        LK_LOP = 1
        LK_GV = 2
        LK_PHONG = 3
    End Enum
End Namespace